using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Abp.UI;
using Cloud.BookList.CloudBookList.BookListManagement.Authorization;
using Cloud.BookList.CloudBookList.BookListManagement.DomainService;
using Cloud.BookList.CloudBookList.BookManagement.DomainService;
using Cloud.BookList.CloudBookList.RelationshipManagement.DomainService;
using Cloud.BookList.CloudBookLists.BookLists.Dtos;
using Cloud.BookList.CloudBookLists.Books.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Cloud.BookList.CloudBookLists.BookLists
{
    /// <summary>
    /// BookList应用层服务的接口实现方法  
    ///</summary>
    public class BookListAppService : BookListAppServiceBase, IBookListAppService
    {
        private readonly IRepository<CloudBookList.BookListManagement.BookList, long> _entityRepository;

        private readonly IBookListManager _entityManager;

        private readonly IBookListAndBookRelationshipManager _bookListAndBookRelationshipManager;

        private readonly IBookManager _bookManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public BookListAppService(
        IRepository<CloudBookList.BookListManagement.BookList, long> entityRepository
        , IBookListManager entityManager,
        IBookListAndBookRelationshipManager bookListAndBookRelationshipManager,
        IBookManager bookManager
        )
        {
            _entityRepository = entityRepository;
            _entityManager = entityManager;
            _bookListAndBookRelationshipManager = bookListAndBookRelationshipManager;
            _bookManager = bookManager;
        }

        public async Task<BookListShareDto> GetShare(long? id, int? tenantId)
        {
            // 参数校验
            if (!id.HasValue || id <= 0 || !tenantId.HasValue || tenantId <= 0)
            {
                throw new UserFriendlyException("未能找到相关书单!");
            }

            // 校验租户是否存在
            var tenant = await TenantManager.GetByIdAsync(tenantId.Value);
            if (tenant == null)
            {
                throw new UserFriendlyException("未能找到相关书单!");
            }

            // 设置工作单元为书单所属的租户
            using (CurrentUnitOfWork.SetTenantId(tenantId))
            {

                var entity = await _entityRepository.GetAll()
                            .IgnoreQueryFilters()
                            .Where(o => o.Id == id)
                            .FirstOrDefaultAsync();

                var outputDto = entity.MapTo<BookListShareDto>();

                // 创建书单的用户名
                outputDto.UserName = string.Empty;
                if (entity.CreatorUserId.HasValue)
                {
                    var user = await UserManager.Users
                                .IgnoreQueryFilters()
                                .Where(o => o.Id == entity.CreatorUserId.Value)
                                .FirstOrDefaultAsync();
                    outputDto.UserName = user.UserName;
                }


                if (entity.BookListAndBookRelationships == null)
                {
                    return outputDto;
                }

                outputDto.Books = new List<BookAndBookTagDto>();

                BookAndBookTagDto bookAndBookTagDto = null;
                foreach (var bookListAndBookRelationship in entity.BookListAndBookRelationships)
                {
                    // 书籍
                    bookAndBookTagDto = bookListAndBookRelationship.Book.MapTo<BookAndBookTagDto>();

                    outputDto.Books.Add(bookAndBookTagDto);
                    if (bookListAndBookRelationship.Book.BookAndBookTagRelationships == null)
                    {
                        continue;
                    }

                    // 书籍标签
                    bookAndBookTagDto.BookTags = new List<string>();
                    foreach (var bookAndBookTagRelationship in bookListAndBookRelationship.Book.BookAndBookTagRelationships)
                    {
                        bookAndBookTagDto.BookTags.Add(bookAndBookTagRelationship.BookTag.Name);
                    }
                }

                return outputDto;
            }
        }


        /// <summary>
        /// 获取BookList的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
		[AbpAuthorize(BookListPermissions.Query)]
        public async Task<PagedResultDto<BookListListDto>> GetPaged(GetBookListsInput input)
        {
            var query = _entityRepository.GetAll().AsNoTracking()
                .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), o => o.Name.Contains(input.FilterText));

            // TODO:根据传入的参数添加过滤条件


            var count = await query.CountAsync();

            var entityList = await query
                    .OrderBy(input.Sorting)
                    .PageBy(input)
                    .ToListAsync();

            // var entityListDtos = ObjectMapper.Map<List<BookListListDto>>(entityList);
            var entityListDtos = entityList.MapTo<List<BookListListDto>>();

            return new PagedResultDto<BookListListDto>(count, entityListDtos);
        }

        [AbpAuthorize(BookListPermissions.Query)]
        public async Task<ListResultDto<BookListListDto>> GetAll(GetBookListsInput input)
        {
            var query = _entityRepository.GetAll().AsNoTracking()
               .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), o => o.Name.Contains(input.FilterText));

            var count = await query.CountAsync();
            var entityList = await query
                   .OrderBy(input.Sorting)
                   //.PageBy(input)
                   .ToListAsync();

            return new ListResultDto<BookListListDto>()
            {
                Items = entityList.MapTo<IReadOnlyList<BookListListDto>>()
            };
        }


        /// <summary>
        /// 通过指定id获取BookListListDto信息
        /// </summary>
        [AbpAuthorize(BookListPermissions.Query)]
        public async Task<BookListListDto> GetById(EntityDto<long> input)
        {
            var entity = await _entityRepository.GetAsync(input.Id);

            return entity.MapTo<BookListListDto>();
        }

        /// <summary>
        /// 获取编辑 BookList
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookListPermissions.Create, BookListPermissions.Edit)]
        public async Task<GetBookListForEditOutput> GetForEdit(NullableIdDto<long> input)
        {
            var output = new GetBookListForEditOutput();
            BookListEditDto editDto;

            var allBooks = (await _bookManager.GetAll()).MapTo<List<BookSelectListDto>>();

            if (input.Id.HasValue)
            {
                var entity = await _entityRepository.GetAsync(input.Id.Value);

                editDto = entity.MapTo<BookListEditDto>();

                var bookIds = (await _bookListAndBookRelationshipManager.GetByBookListId(entity.Id))
                    .Select(o => o.BookId)
                    .ToList();

                foreach (var book in allBooks)
                {
                    if (bookIds.Exists(o => o == book.Id))
                    {
                        book.IsSelected = true;
                    }
                }
            }
            else
            {
                editDto = new BookListEditDto();
            }

            output.BookList = editDto;
            output.Books = allBooks;
            return output;
        }


        /// <summary>
        /// 添加或者修改BookList的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookListPermissions.Create, BookListPermissions.Edit)]
        public async Task CreateOrUpdate(CreateOrUpdateBookListInput input)
        {

            if (input.BookList.Id.HasValue)
            {
                await Update(input.BookList, input.BookIds);
            }
            else
            {
                await Create(input.BookList, input.BookIds);
            }
        }


        /// <summary>
        /// 新增BookList
        /// </summary>
        [AbpAuthorize(BookListPermissions.Create)]
        protected virtual async Task<BookListEditDto> Create(BookListEditDto input, List<long> bookIds)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            // var entity = ObjectMapper.Map <BookList>(input);
            var entity = input.MapTo<CloudBookList.BookListManagement.BookList>();


            var entityId = await _entityRepository.InsertAndGetIdAsync(entity);

            if (bookIds != null)
            {
                bookIds = bookIds.Where(o => o > 0).ToList();
                await _bookListAndBookRelationshipManager.CreateRelationship(entity.Id, bookIds);
            }


            return entity.MapTo<BookListEditDto>();
        }

        /// <summary>
        /// 编辑BookList
        /// </summary>
        [AbpAuthorize(BookListPermissions.Edit)]
        protected virtual async Task Update(BookListEditDto input, List<long> bookIds)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _entityRepository.GetAsync(input.Id.Value);
            input.MapTo(entity);

            // ObjectMapper.Map(input, entity);
            await _entityRepository.UpdateAsync(entity);


            if (bookIds != null)
            {
                bookIds = bookIds.Where(o => o > 0).ToList();
                await _bookListAndBookRelationshipManager.CreateRelationship(entity.Id, bookIds);
            }
        }



        /// <summary>
        /// 删除BookList信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookListPermissions.Delete)]
        public async Task Delete(EntityDto<long> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _bookListAndBookRelationshipManager.DeleteByBookListId(input.Id);
            await _entityRepository.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除BookList的方法
        /// </summary>
        [AbpAuthorize(BookListPermissions.BatchDelete)]
        public async Task BatchDelete(List<long> input)
        {
            // TODO:批量删除前的逻辑判断，是否允许删除
            await _bookListAndBookRelationshipManager.DeleteByBookListId(input);
            await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
        }


        /// <summary>
        /// 导出BookList为excel表,等待开发。
        /// </summary>
        /// <returns></returns>
        //public async Task<FileDto> GetToExcel()
        //{
        //	var users = await UserManager.Users.ToListAsync();
        //	var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
        //	await FillRoleNames(userListDtos);
        //	return _userListExcelExporter.ExportToFile(userListDtos);
        //}

    }
}



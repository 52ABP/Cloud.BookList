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
using Cloud.BookList.CloudBookLists.Books.Authorization;
using Cloud.BookList.CloudBookLists.Books.DomainService;
using Cloud.BookList.CloudBookLists.Books.Dtos;
using Cloud.BookList.CloudBookLists.BookTags.DomainService;
using Cloud.BookList.CloudBookLists.BookTags.Dtos;
using Cloud.BookList.CloudBookLists.Relationships.DomainService;
using Cloud.BookList.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Cloud.BookList.CloudBookLists.Books
{
    /// <summary>
    /// Book应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class BookAppService : BookListAppServiceBase, IBookAppService
    {
        private readonly IRepository<Book, long> _entityRepository;

        private readonly IBookManager _entityManager;

        private readonly IBookAndBookTagRelationshipManager _bookAndBookTagRelationshipManager;

        private readonly IBookTagManager _bookTagManager;

       private readonly IBookListAndBookRelationshipManager _bookListAndBookRelationshipManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public BookAppService(
        IRepository<Book, long> entityRepository
        , IBookManager entityManager,
        IBookAndBookTagRelationshipManager bookAndBookTagRelationshipManager,
        IBookTagManager bookTagManager,
        IBookListAndBookRelationshipManager bookListAndBookRelationshipManager
        )
        {
            _entityRepository = entityRepository;
            _entityManager = entityManager;
            _bookAndBookTagRelationshipManager = bookAndBookTagRelationshipManager;
            _bookTagManager = bookTagManager;
            _bookListAndBookRelationshipManager = bookListAndBookRelationshipManager;
        }


        /// <summary>
        /// 获取Book的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
		[AbpAuthorize(BookPermissions.Query)]
        public async Task<PagedResultDto<BookListDto>> GetPaged(GetBooksInput input)
        {

            var query = _entityRepository
                .GetAll()
                .AsNoTracking()
                // TODO:根据传入的参数添加过滤条件
                .WhereIf(!input.FilterText.IsNullOrWhiteSpace(), o => o.Name.Contains(input.FilterText));

            var count = await query.CountAsync();

            var entityList = await query
                    .OrderBy(input.Sorting)
                    .PageBy(input)
                    .ToListAsync();

            // var entityListDtos = ObjectMapper.Map<List<BookListDto>>(entityList);
            var entityListDtos = entityList.MapTo<List<BookListDto>>();

            if (!AbpSession.TenantId.HasValue)
            {
                // 这里的写法需要优化，但是这里我就这么写了
                Tenant tmpTenant = null;
                int i = 0;
                foreach (var item in entityList)
                {
                    if (item.TenantId <= 0)
                    {
                        i++;
                        continue;
                    }

                    tmpTenant = await TenantManager.GetByIdAsync(item.TenantId);
                    var tmpDto = entityListDtos[i++];
                    tmpDto.TenancyName = tmpTenant.TenancyName;
                    tmpDto.TenancyDisplayName = tmpTenant.Name;
                }

            }

            return new PagedResultDto<BookListDto>(count, entityListDtos);
        }


        /// <summary>
        /// 通过指定id获取BookListDto信息
        /// </summary>
        [AbpAuthorize(BookPermissions.Query)]
        public async Task<BookListDto> GetById(EntityDto<long> input)
        {
            var entity = await _entityRepository.GetAsync(input.Id);

            return entity.MapTo<BookListDto>();
        }

        /// <summary>
        /// 获取编辑 Book
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookPermissions.Create, BookPermissions.Edit)]
        public async Task<GetBookForEditOutput> GetForEdit(NullableIdDto<long> input)
        {
            var output = new GetBookForEditOutput();
            BookEditDto editDto;
            // 已选中的标签Id
            List<long> bookTagIds = null;
            // 所有标签
            var allbookTag = (await _bookTagManager.GetAll()).MapTo<List<BookTagSelectListDto>>();

            if (input.Id.HasValue)
            {
                var entity = await _entityRepository.GetAsync(input.Id.Value);

                editDto = entity.MapTo<BookEditDto>();


                bookTagIds = (await _bookAndBookTagRelationshipManager.GetByBookId(input.Id.Value))
                     .Select(o => o.BookTagId)
                     .ToList();


                foreach (var bookTag in allbookTag)
                {
                    if (bookTagIds.Exists(o => o == bookTag.Id))
                    {
                        bookTag.IsSelected = true;
                    }
                }
            }
            else
            {
                editDto = new BookEditDto();
            }

            output.Book = editDto;
            output.BookTags = allbookTag;

            return output;
        }


        /// <summary>
        /// 添加或者修改Book的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookPermissions.Create, BookPermissions.Edit)]
        public async Task CreateOrUpdate(CreateOrUpdateBookInput input)
        {

            if (input.Book.Id.HasValue)
            {
                await Update(input.Book, input.TagIds);
            }
            else
            {
                await Create(input.Book, input.TagIds);
            }
        }


        /// <summary>
        /// 新增Book
        /// </summary>
        [AbpAuthorize(BookPermissions.Create)]
        protected virtual async Task<BookEditDto> Create(BookEditDto input, List<long> tagIds)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            // var entity = ObjectMapper.Map <Book>(input);
            var entity = input.MapTo<Book>();

            var entityId = await _entityRepository.InsertAndGetIdAsync(entity);

            // 创建标签关联
            if (tagIds != null)
            {
                // 过滤掉不符合条件的数据
                tagIds = tagIds.Where(o => o > 0).ToList();

                await _bookAndBookTagRelationshipManager.CreateRelationship(entity.Id, tagIds);
            }


            return entity.MapTo<BookEditDto>();
        }

        /// <summary>
        /// 编辑Book
        /// </summary>
        [AbpAuthorize(BookPermissions.Edit)]
        protected virtual async Task Update(BookEditDto input, List<long> tagIds)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _entityRepository.GetAsync(input.Id.Value);
            input.MapTo(entity);

            // ObjectMapper.Map(input, entity);
            await _entityRepository.UpdateAsync(entity);

            // 创建标签关联
            if (tagIds != null)
            {
                // 过滤掉不符合条件的数据
                tagIds = tagIds.Where(o => o > 0).ToList();

                await _bookAndBookTagRelationshipManager.CreateRelationship(entity.Id, tagIds);
            }
        }



        /// <summary>
        /// 删除Book信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookPermissions.Delete)]
        public async Task Delete(EntityDto<long> input)
        {
            await _bookAndBookTagRelationshipManager.DeleteByBookId(input.Id);
            await _bookListAndBookRelationshipManager.DeleteByBookId(input.Id);
            //TODO:删除前的逻辑判断，是否允许删除
            await _entityRepository.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除Book的方法
        /// </summary>
        [AbpAuthorize(BookPermissions.BatchDelete)]
        public async Task BatchDelete(List<long> input)
        {
            await _bookAndBookTagRelationshipManager.DeleteByBookId(input);
            await _bookListAndBookRelationshipManager.DeleteByBookId(input);
            // TODO:批量删除前的逻辑判断，是否允许删除
            await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
        }


        /// <summary>
        /// 导出Book为excel表,等待开发。
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



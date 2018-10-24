
using System;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Abp.UI;
using Abp.AutoMapper;
using Abp.Extensions;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;


using Cloud.BookList.CloudBookList.BookTagManagement;
using Cloud.BookList.CloudBookList.BookTagManagement.Dtos;
using Cloud.BookList.CloudBookList.BookTagManagement.DomainService;
using Cloud.BookList.CloudBookList.BookTagManagement.Authorization;
using Abp.MultiTenancy;
using Cloud.BookList.MultiTenancy;
using Cloud.BookList.Users;
using Cloud.BookList.CloudBookList.RelationshipManagement.DomainService;

namespace Cloud.BookList.CloudBookList.BookTagManagement
{
    /// <summary>
    /// BookTag应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class BookTagAppService : BookListAppServiceBase, IBookTagAppService
    {
        private readonly IRepository<BookTag, long> _entityRepository;

        private readonly IBookTagManager _entityManager;

        private readonly IBookAndBookTagRelationshipManager _bookAndBookTagRelationshipManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public BookTagAppService(
        IRepository<BookTag, long> entityRepository
        , IBookTagManager entityManager,
        IBookAndBookTagRelationshipManager bookAndBookTagRelationshipManager
        )
        {
            _entityRepository = entityRepository;
            _entityManager = entityManager;
            _bookAndBookTagRelationshipManager = bookAndBookTagRelationshipManager;
        }


        /// <summary>
        /// 获取BookTag的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
		[AbpAuthorize(BookTagPermissions.Query)]
        public async Task<PagedResultDto<BookTagListDto>> GetPaged(GetBookTagsInput input)
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

            // var entityListDtos = ObjectMapper.Map<List<BookTagListDto>>(entityList);
            var entityListDtos = entityList.MapTo<List<BookTagListDto>>();

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


            return new PagedResultDto<BookTagListDto>(count, entityListDtos);
        }


        /// <summary>
        /// 通过指定id获取BookTagListDto信息
        /// </summary>
        [AbpAuthorize(BookTagPermissions.Query)]
        public async Task<BookTagListDto> GetById(EntityDto<long> input)
        {
            var entity = await _entityRepository.GetAsync(input.Id);

            return entity.MapTo<BookTagListDto>();
        }

        /// <summary>
        /// 获取编辑 BookTag
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookTagPermissions.Create, BookTagPermissions.Edit)]
        public async Task<GetBookTagForEditOutput> GetForEdit(NullableIdDto<long> input)
        {
            var output = new GetBookTagForEditOutput();
            BookTagEditDto editDto;

            if (input.Id.HasValue)
            {
                var entity = await _entityRepository.GetAsync(input.Id.Value);

                editDto = entity.MapTo<BookTagEditDto>();

                //bookTagEditDto = ObjectMapper.Map<List<bookTagEditDto>>(entity);
            }
            else
            {
                editDto = new BookTagEditDto();
            }

            output.BookTag = editDto;
            return output;
        }


        /// <summary>
        /// 添加或者修改BookTag的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookTagPermissions.Create, BookTagPermissions.Edit)]
        public async Task CreateOrUpdate(CreateOrUpdateBookTagInput input)
        {
            if (input.BookTag.Id.HasValue)
            {
                await Update(input.BookTag);
            }
            else
            {
                await Create(input.BookTag);
            }
        }

        [AbpAuthorize(BookTagPermissions.Create)]
        public async Task<BookTagEditDto> Create(CreateOrUpdateBookTagInput input)
        {
            //TODO:新增前的逻辑判断，是否允许新增
            // var entity = ObjectMapper.Map <BookTag>(input);
            var entity = input.BookTag.MapTo<BookTag>();

            var entityId = await _entityRepository.InsertAndGetIdAsync(entity);
            return entity.MapTo<BookTagEditDto>();
        }


        /// <summary>
        /// 新增BookTag
        /// </summary>
        [AbpAuthorize(BookTagPermissions.Create)]
        protected virtual async Task<BookTagEditDto> Create(BookTagEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增
            // var entity = ObjectMapper.Map <BookTag>(input);
            var entity = input.MapTo<BookTag>();

            entity = await _entityRepository.InsertAsync(entity);
            return entity.MapTo<BookTagEditDto>();
        }

        /// <summary>
        /// 编辑BookTag
        /// </summary>
        [AbpAuthorize(BookTagPermissions.Edit)]
        protected virtual async Task Update(BookTagEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _entityRepository.GetAsync(input.Id.Value);
            input.MapTo(entity);

            // ObjectMapper.Map(input, entity);
            await _entityRepository.UpdateAsync(entity);
        }



        /// <summary>
        /// 删除BookTag信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookTagPermissions.Delete)]
        public async Task Delete(EntityDto<long> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _bookAndBookTagRelationshipManager.DeleteByBookTagId(input.Id);
            await _entityRepository.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除BookTag的方法
        /// </summary>
        [AbpAuthorize(BookTagPermissions.BatchDelete)]
        public async Task BatchDelete(List<long> input)
        {
            // TODO:批量删除前的逻辑判断，是否允许删除
            await _bookAndBookTagRelationshipManager.DeleteByBookTagId(input);
            await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
        }


        /// <summary>
        /// 导出BookTag为excel表,等待开发。
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



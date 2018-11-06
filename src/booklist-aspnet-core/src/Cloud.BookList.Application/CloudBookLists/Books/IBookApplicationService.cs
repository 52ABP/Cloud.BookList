using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Cloud.BookList.CloudBookLists.Books.Dtos;

namespace Cloud.BookList.CloudBookLists.Books
{
    /// <summary>
    /// Book应用层服务的接口方法
    ///</summary>
    public interface IBookAppService : IApplicationService
    {
        /// <summary>
		/// 获取Book的分页列表信息
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<BookListDto>> GetPaged(GetBooksInput input);


        /// <summary>
        /// 通过指定id获取BookListDto信息
        /// </summary>
        Task<BookListDto> GetById(EntityDto<long> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetBookForEditOutput> GetForEdit(NullableIdDto<long> input);


        /// <summary>
        /// 添加或者修改Book的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateBookInput input);


        /// <summary>
        /// 删除Book信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<long> input);


        /// <summary>
        /// 批量删除Book
        /// </summary>
        Task BatchDelete(List<long> input);


        /// <summary>
        /// 导出Book为excel表
        /// </summary>
        /// <returns></returns>
        //Task<FileDto> GetToExcel();

    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace Cloud.BookList.CloudBookLists.Relationships.DomainService
{
    public interface IBookListAndBookRelationshipManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitBookListAndBookRelationship();


        /// <summary>
        /// 根据 书单Id获取所有关联
        /// </summary>
        /// <param name="bookListId"></param>
        /// <returns></returns>
        Task<List<BookListAndBookRelationship>> GetByBookListId(long? bookListId);


        /// <summary>
        /// 根据 书籍Id获取所有关联
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        Task<List<BookListAndBookRelationship>> GetByBookId(long? bookId);


        /// <summary>
        /// 创建关联
        /// </summary>
        /// <param name="bookListId"></param>
        /// <param name="bookIds"></param>
        /// <returns></returns>
        Task CreateRelationship(long? bookListId, List<long> bookIds);


        /// <summary>
        /// 根据书籍Id删除关联
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        Task DeleteByBookId(long? bookId);


        /// <summary>
        /// 根据书籍id集合删除关联
        /// </summary>
        /// <param name="bookIds"></param>
        /// <returns></returns>
        Task DeleteByBookId(List<long> bookIds);


        /// <summary>
        /// 根据书单Id删除关联
        /// </summary>
        /// <param name="bookListId"></param>
        /// <returns></returns>
        Task DeleteByBookListId(long? bookListId);


        /// <summary>
        /// 根据书单id集合删除关联
        /// </summary>
        /// <param name="bookListIds"></param>
        /// <returns></returns>
        Task DeleteByBookListId(List<long> bookListIds);
    }
}

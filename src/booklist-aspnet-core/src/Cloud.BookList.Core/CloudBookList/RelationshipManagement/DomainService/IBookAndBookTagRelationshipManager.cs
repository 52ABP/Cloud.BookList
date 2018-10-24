

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using Cloud.BookList.CloudBookList.RelationshipManagement;


namespace Cloud.BookList.CloudBookList.RelationshipManagement.DomainService
{
    public interface IBookAndBookTagRelationshipManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitBookAndBookTagRelationship();



        /// <summary>
        /// 根据BookId查询所有关联数据
        /// </summary>
        /// <param name="blogId"></param>
        Task<List<BookAndBookTagRelationship>> GetByBookId(long? blogId);

        /// <summary>
        /// 根据BookTagId查询所有关联数据
        /// </summary>
        /// <param name="bookTagId"></param>
        /// <returns></returns>
        Task<List<BookAndBookTagRelationship>> GetByBookTagId(long? bookTagId);

        /// <summary>
        /// 创建书籍和多个标签的关联
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="bookTagIds"></param>
        /// <returns></returns>
        Task CreateRelationship(long? bookId, List<long> bookTagIds);


        /// <summary>
        /// 根据书籍Id删除关联
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        Task DeleteByBookId(long? bookId);

        /// <summary>
        /// 根据书籍Id删除关联
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        Task DeleteByBookId(List<long> bookIds);


        /// <summary>
        /// 根据书籍标签Id删除关联
        /// </summary>
        /// <param name="bookTagId"></param>
        /// <returns></returns>
        Task DeleteByBookTagId(long? bookTagId);

        /// <summary>
        /// 根据书籍标签Id删除关联
        /// </summary>
        /// <param name="bookTagIds"></param>
        /// <returns></returns>
        Task DeleteByBookTagId(List<long> bookTagIds); 
    }
}

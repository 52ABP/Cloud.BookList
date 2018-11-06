

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using Cloud.BookList.CloudBookList.BookTagManagement;


namespace Cloud.BookList.CloudBookList.BookTagManagement.DomainService
{
    public interface IBookTagManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitBookTag();



        /// <summary>
        /// 获取所有书籍标签
        /// </summary>
        /// <returns></returns>
        Task<List<BookTag>> GetAll();


    }
}

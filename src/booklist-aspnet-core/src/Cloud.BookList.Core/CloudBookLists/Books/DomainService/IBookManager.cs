

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using Cloud.BookList.CloudBookList.BookManagement;


namespace Cloud.BookList.CloudBookList.BookManagement.DomainService
{
    public interface IBookManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitBook();


        /// <summary>
        /// 获取所有的书籍
        /// </summary>
        /// <returns></returns>
        Task<List<Book>> GetAll();
		 
      
         

    }
}

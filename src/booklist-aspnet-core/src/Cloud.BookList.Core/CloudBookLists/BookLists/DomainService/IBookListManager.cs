

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using Cloud.BookList.CloudBookList.BookListManagement;


namespace Cloud.BookList.CloudBookList.BookListManagement.DomainService
{
    public interface IBookListManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitBookList();



		 
      
         

    }
}

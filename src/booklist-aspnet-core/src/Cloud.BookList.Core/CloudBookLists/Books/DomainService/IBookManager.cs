using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace Cloud.BookList.CloudBookLists.Books.DomainService
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

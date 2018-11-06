using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace Cloud.BookList.CloudBookLists.BookTags.DomainService
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

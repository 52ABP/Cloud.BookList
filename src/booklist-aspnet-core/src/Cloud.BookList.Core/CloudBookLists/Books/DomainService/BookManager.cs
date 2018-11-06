using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Cloud.BookList.CloudBookLists.Books.DomainService
{
    /// <summary>
    /// Book领域层的业务管理
    ///</summary>
    public class BookManager : BookListDomainServiceBase, IBookManager
    {

        private readonly IRepository<Book, long> _repository;

        /// <summary>
        /// Book的构造方法
        ///</summary>
        public BookManager(
            IRepository<Book, long> repository
        )
        {
            _repository = repository;
        }

        public async Task<List<Book>> GetAll()
        {
            return await _repository.GetAll()
                .AsNoTracking()
                .ToListAsync();
        }


        /// <summary>
        /// 初始化
        ///</summary>
        public void InitBook()
        {
            throw new NotImplementedException();
        }

        // TODO:编写领域业务代码







    }
}

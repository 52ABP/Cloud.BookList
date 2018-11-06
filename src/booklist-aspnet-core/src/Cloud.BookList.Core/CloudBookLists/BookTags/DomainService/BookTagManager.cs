using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Cloud.BookList.CloudBookLists.BookTags.DomainService
{
    /// <summary>
    /// BookTag领域层的业务管理
    ///</summary>
    public class BookTagManager : BookListDomainServiceBase, IBookTagManager
    {

        private readonly IRepository<BookTag, long> _repository;

        /// <summary>
        /// BookTag的构造方法
        ///</summary>
        public BookTagManager(
            IRepository<BookTag, long> repository
        )
        {
            _repository = repository;
        }

        public async Task<List<BookTag>> GetAll()
        {
            return await _repository.GetAll()
                .AsNoTracking()
                .ToListAsync();
        }


        /// <summary>
        /// 初始化
        ///</summary>
        public void InitBookTag()
        {
            throw new NotImplementedException();
        }

        // TODO:编写领域业务代码 



    }
}

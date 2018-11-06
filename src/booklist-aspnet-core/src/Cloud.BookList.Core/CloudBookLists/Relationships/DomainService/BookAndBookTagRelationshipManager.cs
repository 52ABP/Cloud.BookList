using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Cloud.BookList.CloudBookLists.Relationships.DomainService
{
    /// <summary>
    /// BookAndBookTagRelationship领域层的业务管理
    ///</summary>
    public class BookAndBookTagRelationshipManager : BookListDomainServiceBase, IBookAndBookTagRelationshipManager
    {

        private readonly IRepository<BookAndBookTagRelationship, long> _repository;

        /// <summary>
        /// BookAndBookTagRelationship的构造方法
        ///</summary>
        public BookAndBookTagRelationshipManager(
            IRepository<BookAndBookTagRelationship, long> repository
        )
        {
            _repository = repository;
        }


        public async Task<List<BookAndBookTagRelationship>> GetByBookId(long? bookId)
        {
            return await _repository.GetAll()
                .AsNoTracking()
                .Where(o => o.BookId == bookId.Value)
                .ToListAsync();
        }

        public async Task<List<BookAndBookTagRelationship>> GetByBookTagId(long? bookTagId)
        {
            return await _repository.GetAll()
                .AsNoTracking()
                .Where(o => o.BookTagId == bookTagId.Value)
                .ToListAsync();
        }

        public async Task CreateRelationship(long? bookId, List<long> bookTagIds)
        {
            // 删除原有的关联
            await _repository.DeleteAsync(o => o.BookId == bookId.Value);
            await CurrentUnitOfWork.SaveChangesAsync();


            // 创建关联
            var insertdBookTagIds = new List<long>();
            foreach (var bookTagId in bookTagIds)
            {
                // 已经插入过了
                if (insertdBookTagIds.Exists(o => o == bookTagId))
                {
                    continue;
                }

                await _repository.InsertAsync(new BookAndBookTagRelationship()
                {
                    BookId = bookId.Value,
                    BookTagId = bookTagId,
                });
                insertdBookTagIds.Add(bookTagId);
            }
        }



        /// <summary>
        /// 初始化
        ///</summary>
        public void InitBookAndBookTagRelationship()
        {
            throw new NotImplementedException();
        }

        public async Task DeleteByBookId(long? bookId)
        {
            await _repository.DeleteAsync(o => o.BookId == bookId.Value);
        }

        public async Task DeleteByBookId(List<long> bookIds)
        {
            await _repository.DeleteAsync(o => bookIds.Contains(o.BookId));
        }

        public async Task DeleteByBookTagId(long? bookTagId)
        {
            await _repository.DeleteAsync(o => o.BookTagId == bookTagId.Value);
        }

        public async Task DeleteByBookTagId(List<long> bookTagIds)
        {
            await _repository.DeleteAsync(o => bookTagIds.Contains(o.BookTagId));
        }

        // TODO:编写领域业务代码







    }
}

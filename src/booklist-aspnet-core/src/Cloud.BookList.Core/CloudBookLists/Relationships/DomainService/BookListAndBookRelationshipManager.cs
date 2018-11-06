using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Cloud.BookList.CloudBookLists.Relationships.DomainService
{
    /// <summary>
    /// BookListAndBookRelationship领域层的业务管理
    ///</summary>
    public class BookListAndBookRelationshipManager : BookListDomainServiceBase, IBookListAndBookRelationshipManager
    {

        private readonly IRepository<BookListAndBookRelationship, long> _repository;

        /// <summary>
        /// BookListAndBookRelationship的构造方法
        ///</summary>
        public BookListAndBookRelationshipManager(
            IRepository<BookListAndBookRelationship, long> repository
        )
        {
            _repository = repository;
        }


        /// <summary>
        /// 初始化
        ///</summary>
        public void InitBookListAndBookRelationship()
        {
            throw new NotImplementedException();
        }

        // TODO:编写领域业务代码


        public async Task<List<BookListAndBookRelationship>> GetByBookListId(long? bookListId)
        {
            return await _repository.GetAll()
                .AsNoTracking()
                .Where(o => o.BookListId == bookListId.Value)
                .ToListAsync();
        }

        public async Task<List<BookListAndBookRelationship>> GetByBookId(long? bookId)
        {
            return await _repository.GetAll()
                .AsNoTracking()
                .Where(o => o.BookId == bookId.Value)
                .ToListAsync();
        }

        public async Task CreateRelationship(long? bookListId, List<long> bookIds)
        {
            // 删除原有的关联
            await _repository.DeleteAsync(o => o.BookListId == bookListId.Value);
            await CurrentUnitOfWork.SaveChangesAsync();


            // 创建关联
            var insertdBookIds = new List<long>();
            foreach (var bookId in bookIds)
            {
                // 已经插入过了
                if (insertdBookIds.Exists(o => o == bookId))
                {
                    continue;
                }

                await _repository.InsertAsync(new BookListAndBookRelationship()
                {
                    BookId = bookId,
                    BookListId = bookListId.Value
                });
                insertdBookIds.Add(bookId);
            }
        }




        public async Task DeleteByBookId(long? bookId)
        {
            await _repository.DeleteAsync(o => o.BookId == bookId.Value);
        }


        public async Task DeleteByBookId(List<long> bookIds)
        {
            await _repository.DeleteAsync(o => bookIds.Contains(o.BookId));
        }


        public async Task DeleteByBookListId(long? bookListId)
        {
            await _repository.DeleteAsync(o => o.BookListId == bookListId.Value);
        }


        public async Task DeleteByBookListId(List<long> bookListIds)
        {
            await _repository.DeleteAsync(o => bookListIds.Contains(o.BookListId));
        }

    }
}

using System;
using Abp.Domain.Repositories;

namespace Cloud.BookList.CloudBookLists.BookLists.DomainService
{
    /// <summary>
    /// BookList领域层的业务管理
    ///</summary>
    public class BookListManager :BookListDomainServiceBase, IBookListManager
    {
		
		private readonly IRepository<BookList,long> _repository;

		/// <summary>
		/// BookList的构造方法
		///</summary>
		public BookListManager(
			IRepository<BookList, long> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitBookList()
		{
			throw new NotImplementedException();
		}

		// TODO:编写领域业务代码



		 
		  
		 

	}
}

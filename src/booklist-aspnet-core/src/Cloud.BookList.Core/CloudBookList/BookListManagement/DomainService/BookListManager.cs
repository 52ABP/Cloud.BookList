

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Linq;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.UI;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

using Cloud.BookList;
using Cloud.BookList.CloudBookList.BookListManagement;


namespace Cloud.BookList.CloudBookList.BookListManagement.DomainService
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

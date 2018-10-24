
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Cloud.BookList.CloudBookList.BookListManagement;

namespace  Cloud.BookList.CloudBookList.BookListManagement.Dtos
{
    public class BookListEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }         


        
		/// <summary>
		/// 书单名称
		/// </summary>
		[Required(ErrorMessage="书单名称不能为空")]
		public string Name { get; set; }



		/// <summary>
		/// 书单介绍
		/// </summary>
		public string Intro { get; set; }




    }
}
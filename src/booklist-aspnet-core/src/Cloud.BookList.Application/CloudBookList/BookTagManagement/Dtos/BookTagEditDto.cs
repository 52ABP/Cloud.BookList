
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Cloud.BookList.CloudBookList.BookTagManagement;

namespace  Cloud.BookList.CloudBookList.BookTagManagement.Dtos
{
    public class BookTagEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }         


        
		/// <summary>
		/// 名称
		/// </summary>
		public string Name { get; set; }




    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Cloud.BookList.CloudBookList.BookManagement;

namespace  Cloud.BookList.CloudBookList.BookManagement.Dtos
{
    public class BookEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }



        /// <summary>
        /// 封面
        /// </summary>
        public string ImgUrl { get; set; }



        /// <summary>
        /// 书名
        /// </summary>
        [Required]
        public string Name { get; set; }



        /// <summary>
        /// 作者
        /// </summary>
        [Required]
        public string Author { get; set; }



		/// <summary>
		/// 简介
		/// </summary>
		public string Intro { get; set; }



		/// <summary>
		/// 购买链接
		/// </summary>
		public string Url { get; set; }

    }
}
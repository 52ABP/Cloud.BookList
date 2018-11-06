using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;

namespace Cloud.BookList.CloudBookLists.Books.Dtos
{
    public class BookListDto : EntityDto<long>,IHasCreationTime
    {

        
		/// <summary>
		/// 封面
		/// </summary>
		public string ImgUrl { get; set; }



		/// <summary>
		/// 书名
		/// </summary>
		public string Name { get; set; }



		/// <summary>
		/// 作者
		/// </summary>
		public string Author { get; set; }



		/// <summary>
		/// 简介
		/// </summary>
		public string Intro { get; set; }



		/// <summary>
		/// 购买链接
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreationTime { get; set; }


        /// <summary>
        /// 租户显示名称
        /// </summary>
        public string TenancyDisplayName { get; set; }

        /// <summary>
        /// 租户名称(唯一)
        /// </summary>
        public string TenancyName { get; set; }

    }
}
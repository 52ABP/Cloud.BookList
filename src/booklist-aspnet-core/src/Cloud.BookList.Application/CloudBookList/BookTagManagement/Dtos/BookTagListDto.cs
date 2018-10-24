

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using Cloud.BookList.CloudBookList.BookTagManagement;
using Abp.Domain.Entities;

namespace Cloud.BookList.CloudBookList.BookTagManagement.Dtos
{
    public class BookTagListDto : EntityDto<long>,IHasCreationTime
    {

        
		/// <summary>
		/// 名称
		/// </summary>
		public string Name { get; set; }



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
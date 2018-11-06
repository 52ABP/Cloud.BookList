using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Cloud.BookList.CloudBookLists.BookLists.Dtos
{
    public class BookListListDto : EntityDto<long>, IHasCreationTime, IMustHaveTenant
    {


        /// <summary>
        /// 书单名称
        /// </summary>
        [Required(ErrorMessage = "书单名称不能为空")]
        public string Name { get; set; }



        /// <summary>
        /// 书单介绍
        /// </summary>
        public string Intro { get; set; }



        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        public int TenantId { get; set; }
    }
}
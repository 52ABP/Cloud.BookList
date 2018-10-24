using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.BookList.CloudBookList.BookTagManagement.Dtos
{
    public class BookTagSelectListDto : BookTagListDto
    {
        /// <summary>
        /// 是否已选择
        /// </summary>
        public bool IsSelected { get; set; }
    }
}

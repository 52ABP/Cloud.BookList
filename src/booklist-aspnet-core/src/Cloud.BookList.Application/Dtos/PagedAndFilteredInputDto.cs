

using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace  Cloud.BookList.Dtos
{
    public class PagedAndFilteredInputDto : IPagedResultRequest
    {
        [Range(1, AppLtmConsts.MaxPageSize)]
        public int MaxResultCount { get; set; }

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        public string Filter { get; set; }


		 
		 
         


        public PagedAndFilteredInputDto()
        {
            MaxResultCount = AppLtmConsts.DefaultPageSize;
        }
    }
}
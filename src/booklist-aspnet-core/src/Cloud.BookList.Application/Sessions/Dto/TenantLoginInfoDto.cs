using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Cloud.BookList.MultiTenancy;

namespace Cloud.BookList.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}

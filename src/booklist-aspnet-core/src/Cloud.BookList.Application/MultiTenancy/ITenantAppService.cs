using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Cloud.BookList.MultiTenancy.Dto;

namespace Cloud.BookList.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

using Cloud.BookList.MultiTenancy.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.BookList.MultiTenancy
{
    public interface ITenantRegistrationAppService
    {
        Task<TenantDto> RegisterTenant(CreateTenantDto input);
    }
}

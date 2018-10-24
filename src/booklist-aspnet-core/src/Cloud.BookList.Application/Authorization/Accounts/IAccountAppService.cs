using System.Threading.Tasks;
using Abp.Application.Services;
using Cloud.BookList.Authorization.Accounts.Dto;

namespace Cloud.BookList.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

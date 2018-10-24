using System.Threading.Tasks;
using Abp.Application.Services;
using Cloud.BookList.Sessions.Dto;

namespace Cloud.BookList.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

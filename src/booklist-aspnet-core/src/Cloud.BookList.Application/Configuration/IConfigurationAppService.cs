using System.Threading.Tasks;
using Cloud.BookList.Configuration.Dto;

namespace Cloud.BookList.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

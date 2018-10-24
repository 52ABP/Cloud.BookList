using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Cloud.BookList.Configuration.Dto;

namespace Cloud.BookList.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BookListAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

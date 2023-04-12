using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Sadec.Sample.Configuration.Dto;

namespace Sadec.Sample.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SampleAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

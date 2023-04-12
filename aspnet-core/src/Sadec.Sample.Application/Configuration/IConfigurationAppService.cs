using System.Threading.Tasks;
using Sadec.Sample.Configuration.Dto;

namespace Sadec.Sample.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

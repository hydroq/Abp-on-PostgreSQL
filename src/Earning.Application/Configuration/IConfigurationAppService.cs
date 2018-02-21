using System.Threading.Tasks;
using Earning.Configuration.Dto;

namespace Earning.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

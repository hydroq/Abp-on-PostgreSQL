using System.Threading.Tasks;
using Abp.Application.Services;
using Earning.Authorization.Accounts.Dto;

namespace Earning.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

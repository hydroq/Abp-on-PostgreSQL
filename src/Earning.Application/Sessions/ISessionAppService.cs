using System.Threading.Tasks;
using Abp.Application.Services;
using Earning.Sessions.Dto;

namespace Earning.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

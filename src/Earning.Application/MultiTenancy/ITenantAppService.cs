using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Earning.MultiTenancy.Dto;

namespace Earning.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

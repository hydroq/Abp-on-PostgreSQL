using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Earning.Roles.Dto;
using Earning.Users.Dto;

namespace Earning.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

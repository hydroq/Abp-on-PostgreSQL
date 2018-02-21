using Abp.Authorization;
using Earning.Authorization.Roles;
using Earning.Authorization.Users;

namespace Earning.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

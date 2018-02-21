using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Earning.Controllers
{
    public abstract class EarningControllerBase: AbpController
    {
        protected EarningControllerBase()
        {
            LocalizationSourceName = EarningConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Earning.Authorization;

namespace Earning
{
    [DependsOn(
        typeof(EarningCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EarningApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EarningAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EarningApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

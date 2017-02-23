using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace Quorse
{
    [DependsOn(typeof(AbpWebApiModule), typeof(QuorseApplicationModule))]
    public class QuorseWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(QuorseApplicationModule).Assembly, "app")
                .Build();
        }
    }
}

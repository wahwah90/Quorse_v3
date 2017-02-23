using System.Reflection;
using Abp.Modules;

namespace Quorse
{
    [DependsOn(typeof(QuorseCoreModule))]
    public class QuorseApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

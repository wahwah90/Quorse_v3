using System.Reflection;
using Abp.Modules;

namespace Quorse
{
    public class QuorseCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

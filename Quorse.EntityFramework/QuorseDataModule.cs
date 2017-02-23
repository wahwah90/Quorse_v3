using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Quorse.EntityFramework;

namespace Quorse
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(QuorseCoreModule))]
    public class QuorseDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<QuorseDbContext>(null);
        }
    }
}

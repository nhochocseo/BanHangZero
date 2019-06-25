using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Center.Production
{
    [DependsOn(typeof(ProductionClientModule), typeof(AbpAutoMapperModule))]
    public class ProductionXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProductionXamarinSharedModule).GetAssembly());
        }
    }
}
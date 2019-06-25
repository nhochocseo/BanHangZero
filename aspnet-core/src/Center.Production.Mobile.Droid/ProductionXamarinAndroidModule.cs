using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Center.Production
{
    [DependsOn(typeof(ProductionXamarinSharedModule))]
    public class ProductionXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProductionXamarinAndroidModule).GetAssembly());
        }
    }
}
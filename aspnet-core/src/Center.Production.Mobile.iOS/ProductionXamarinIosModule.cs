using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Center.Production
{
    [DependsOn(typeof(ProductionXamarinSharedModule))]
    public class ProductionXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProductionXamarinIosModule).GetAssembly());
        }
    }
}
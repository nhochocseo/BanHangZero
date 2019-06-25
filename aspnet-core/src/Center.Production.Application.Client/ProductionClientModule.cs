using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Center.Production
{
    public class ProductionClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProductionClientModule).GetAssembly());
        }
    }
}

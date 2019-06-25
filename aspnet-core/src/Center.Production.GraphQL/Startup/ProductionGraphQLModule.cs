using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Center.Production.Startup
{
    [DependsOn(typeof(ProductionCoreModule))]
    public class ProductionGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProductionGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}
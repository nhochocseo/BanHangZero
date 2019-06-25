using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Center.Production.Configure;
using Center.Production.Startup;
using Center.Production.Test.Base;

namespace Center.Production.GraphQL.Tests
{
    [DependsOn(
        typeof(ProductionGraphQLModule),
        typeof(ProductionTestBaseModule))]
    public class ProductionGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProductionGraphQLTestModule).GetAssembly());
        }
    }
}
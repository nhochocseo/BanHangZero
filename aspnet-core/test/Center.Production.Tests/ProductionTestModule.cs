using Abp.Modules;
using Center.Production.Test.Base;

namespace Center.Production.Tests
{
    [DependsOn(typeof(ProductionTestBaseModule))]
    public class ProductionTestModule : AbpModule
    {
       
    }
}

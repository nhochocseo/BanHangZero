using Abp.AspNetCore.Mvc.ViewComponents;

namespace Center.Production.Web.Views
{
    public abstract class ProductionViewComponent : AbpViewComponent
    {
        protected ProductionViewComponent()
        {
            LocalizationSourceName = ProductionConsts.LocalizationSourceName;
        }
    }
}
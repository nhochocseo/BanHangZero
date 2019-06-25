using Abp.AspNetCore.Mvc.Views;

namespace Center.Production.Web.Views
{
    public abstract class ProductionRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected ProductionRazorPage()
        {
            LocalizationSourceName = ProductionConsts.LocalizationSourceName;
        }
    }
}

using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Center.Production.Web.Public.Views
{
    public abstract class ProductionRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ProductionRazorPage()
        {
            LocalizationSourceName = ProductionConsts.LocalizationSourceName;
        }
    }
}

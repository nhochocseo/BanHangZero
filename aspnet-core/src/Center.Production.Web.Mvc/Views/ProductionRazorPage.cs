using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Center.Production.UiCustomization;
using Center.Production.UiCustomization.Dto;

namespace Center.Production.Web.Views
{
    public abstract class ProductionRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        [RazorInject]
        public IUiThemeCustomizerFactory UiThemeCustomizerFactory { get; set; }

        protected ProductionRazorPage()
        {
            LocalizationSourceName = ProductionConsts.LocalizationSourceName;
        }

        public async Task<UiCustomizationSettingsDto> GetTheme()
        {
            var themeCustomizer = await UiThemeCustomizerFactory.GetCurrentUiCustomizer();
            var settings = await themeCustomizer.GetUiSettings();
            return settings;
        }
    }
}

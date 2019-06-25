using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Center.Production.Web.Areas.AppAreaName.Models.Layout;
using Center.Production.Web.Session;
using Center.Production.Web.Views;

namespace Center.Production.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameFooter
{
    public class AppAreaNameFooterViewComponent : ProductionViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameFooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(bool useWrapperDiv)
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
                UseWrapperDiv = useWrapperDiv
            };

            return View(footerModel);
        }
    }
}

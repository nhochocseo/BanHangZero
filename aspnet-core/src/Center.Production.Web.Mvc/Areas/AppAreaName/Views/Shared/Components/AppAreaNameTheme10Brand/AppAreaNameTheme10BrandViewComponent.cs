using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Center.Production.Web.Areas.AppAreaName.Models.Layout;
using Center.Production.Web.Session;
using Center.Production.Web.Views;

namespace Center.Production.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameTheme10Brand
{
    public class AppAreaNameTheme10BrandViewComponent : ProductionViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameTheme10BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}

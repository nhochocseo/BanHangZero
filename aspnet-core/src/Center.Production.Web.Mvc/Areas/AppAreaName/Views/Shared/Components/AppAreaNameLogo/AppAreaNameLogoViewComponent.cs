using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Center.Production.Web.Areas.AppAreaName.Models.Layout;
using Center.Production.Web.Session;
using Center.Production.Web.Views;

namespace Center.Production.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameLogo
{
    public class AppAreaNameLogoViewComponent : ProductionViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;
        
        public AppAreaNameLogoViewComponent(
            IPerRequestSessionCache sessionCache
        )
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null)
        {
            var headerModel = new LogoViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
                LogoSkinOverride = logoSkin
            };
            
            return View(headerModel);
        }
    }
}

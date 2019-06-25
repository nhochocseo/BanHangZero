using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Center.Production.Web.Session;

namespace Center.Production.Web.Views.Shared.Components.AccountLogo
{
    public class AccountLogoViewComponent : ProductionViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AccountLogoViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            return View(new AccountLogoViewModel(loginInfo));
        }
    }
}

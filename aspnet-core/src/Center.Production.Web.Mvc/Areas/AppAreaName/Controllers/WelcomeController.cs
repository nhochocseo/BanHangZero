using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Center.Production.Web.Controllers;

namespace Center.Production.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize]
    public class WelcomeController : ProductionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
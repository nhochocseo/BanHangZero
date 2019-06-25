using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace Center.Production.Web.Controllers
{
    public class HomeController : ProductionControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Ui");
        }
    }
}

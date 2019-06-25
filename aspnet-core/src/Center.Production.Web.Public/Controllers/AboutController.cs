using Microsoft.AspNetCore.Mvc;
using Center.Production.Web.Controllers;

namespace Center.Production.Web.Public.Controllers
{
    public class AboutController : ProductionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
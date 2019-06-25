using Abp.Application.Navigation;

namespace Center.Production.Web.Areas.AppAreaName.Models.Layout
{
    public class MenuViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; }
    }
}
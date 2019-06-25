using System.Collections.Generic;
using MvvmHelpers;
using Center.Production.Models.NavigationMenu;

namespace Center.Production.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}
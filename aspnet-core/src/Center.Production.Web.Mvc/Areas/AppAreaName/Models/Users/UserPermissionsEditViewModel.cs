using Abp.AutoMapper;
using Center.Production.Authorization.Users;
using Center.Production.Authorization.Users.Dto;
using Center.Production.Web.Areas.AppAreaName.Models.Common;

namespace Center.Production.Web.Areas.AppAreaName.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}
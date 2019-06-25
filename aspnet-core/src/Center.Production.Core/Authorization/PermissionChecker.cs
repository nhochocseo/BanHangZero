using Abp.Authorization;
using Center.Production.Authorization.Roles;
using Center.Production.Authorization.Users;

namespace Center.Production.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

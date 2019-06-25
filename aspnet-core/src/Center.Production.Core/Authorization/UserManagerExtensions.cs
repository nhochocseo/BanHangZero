using System.Threading.Tasks;
using Abp.Authorization.Users;
using Center.Production.Authorization.Users;

namespace Center.Production.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}

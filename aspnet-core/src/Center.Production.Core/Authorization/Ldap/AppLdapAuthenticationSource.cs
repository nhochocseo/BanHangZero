using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Center.Production.Authorization.Users;
using Center.Production.MultiTenancy;

namespace Center.Production.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
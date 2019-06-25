using System.Collections.Generic;

namespace Center.Production.MultiTenancy.HostDashboard.Dto
{
    public class GetRecentTenantsOutput
    {
        public List<RecentTenant> RecentTenants;

        public GetRecentTenantsOutput(List<RecentTenant> recentTenants)
        {
            RecentTenants = recentTenants;
        }
    }
}
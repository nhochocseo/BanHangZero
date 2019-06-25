using Abp.Auditing;
using Center.Production.Configuration.Dto;

namespace Center.Production.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}
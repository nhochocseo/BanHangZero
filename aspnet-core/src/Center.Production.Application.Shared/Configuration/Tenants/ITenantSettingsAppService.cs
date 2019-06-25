using System.Threading.Tasks;
using Abp.Application.Services;
using Center.Production.Configuration.Tenants.Dto;

namespace Center.Production.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}

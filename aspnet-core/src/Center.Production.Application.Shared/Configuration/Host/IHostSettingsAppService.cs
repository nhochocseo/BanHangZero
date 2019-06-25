using System.Threading.Tasks;
using Abp.Application.Services;
using Center.Production.Configuration.Host.Dto;

namespace Center.Production.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}

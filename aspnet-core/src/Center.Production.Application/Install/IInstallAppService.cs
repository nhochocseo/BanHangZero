using System.Threading.Tasks;
using Abp.Application.Services;
using Center.Production.Install.Dto;

namespace Center.Production.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}
using Abp.Application.Services;
using Center.Production.Dto;
using Center.Production.Logging.Dto;

namespace Center.Production.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Center.Production.Caching.Dto;

namespace Center.Production.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}

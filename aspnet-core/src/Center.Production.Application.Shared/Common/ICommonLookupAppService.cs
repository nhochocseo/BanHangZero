using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Center.Production.Common.Dto;
using Center.Production.Editions.Dto;

namespace Center.Production.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}
using System.Threading.Tasks;
using Abp.Application.Services;
using Center.Production.Editions.Dto;
using Center.Production.MultiTenancy.Dto;

namespace Center.Production.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}
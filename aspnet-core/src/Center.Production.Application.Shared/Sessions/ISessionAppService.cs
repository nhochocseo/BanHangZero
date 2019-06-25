using System.Threading.Tasks;
using Abp.Application.Services;
using Center.Production.Sessions.Dto;

namespace Center.Production.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}

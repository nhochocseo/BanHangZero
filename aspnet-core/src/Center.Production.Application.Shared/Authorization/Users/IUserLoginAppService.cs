using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Center.Production.Authorization.Users.Dto;

namespace Center.Production.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}

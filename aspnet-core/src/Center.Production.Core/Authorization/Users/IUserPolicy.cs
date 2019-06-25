using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Center.Production.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}

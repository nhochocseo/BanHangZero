using System.Threading.Tasks;
using Center.Production.Sessions.Dto;

namespace Center.Production.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}

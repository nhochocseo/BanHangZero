using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Center.Production.Dto;

namespace Center.Production.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}

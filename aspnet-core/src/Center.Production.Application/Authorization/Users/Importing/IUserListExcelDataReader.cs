using System.Collections.Generic;
using Center.Production.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Center.Production.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}

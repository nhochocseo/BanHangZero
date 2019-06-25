using System.Collections.Generic;
using Center.Production.Authorization.Users.Importing.Dto;
using Center.Production.Dto;

namespace Center.Production.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}

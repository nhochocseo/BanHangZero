using System.Collections.Generic;
using Center.Production.Authorization.Users.Dto;
using Center.Production.Dto;

namespace Center.Production.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}
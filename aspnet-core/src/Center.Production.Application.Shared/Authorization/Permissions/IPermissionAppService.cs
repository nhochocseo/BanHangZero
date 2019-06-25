using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Center.Production.Authorization.Permissions.Dto;

namespace Center.Production.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}

namespace Center.Production.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}
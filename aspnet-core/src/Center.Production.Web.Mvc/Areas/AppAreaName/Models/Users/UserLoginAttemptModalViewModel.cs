using System.Collections.Generic;
using Center.Production.Authorization.Users.Dto;

namespace Center.Production.Web.Areas.AppAreaName.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}
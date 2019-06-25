using System.ComponentModel.DataAnnotations;
using Abp.Auditing;

namespace Center.Production.Web.Models.Account
{
    public class LoginModel
    {
        [Required]
        public string UsernameOrEmailAddress { get; set; }

        [Required]
        [DisableAuditing]
        public string Password { get; set; }
    }
}
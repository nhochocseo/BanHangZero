using System.ComponentModel.DataAnnotations;

namespace Center.Production.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Center.Production.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}

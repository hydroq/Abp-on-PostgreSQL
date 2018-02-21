using System.ComponentModel.DataAnnotations;

namespace Earning.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
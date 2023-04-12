using System.ComponentModel.DataAnnotations;

namespace Sadec.Sample.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
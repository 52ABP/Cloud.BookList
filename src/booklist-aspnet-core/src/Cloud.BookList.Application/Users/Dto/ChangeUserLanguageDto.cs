using System.ComponentModel.DataAnnotations;

namespace Cloud.BookList.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
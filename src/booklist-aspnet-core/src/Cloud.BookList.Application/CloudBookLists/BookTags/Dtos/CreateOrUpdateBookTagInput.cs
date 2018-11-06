using System.ComponentModel.DataAnnotations;

namespace Cloud.BookList.CloudBookLists.BookTags.Dtos
{
    public class CreateOrUpdateBookTagInput
    {
        [Required]
        public BookTagEditDto BookTag { get; set; }

    }
}
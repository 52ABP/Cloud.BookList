using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cloud.BookList.CloudBookLists.Books.Dtos
{
    public class CreateOrUpdateBookInput
    {
        [Required]
        public BookEditDto Book { get; set; }


        public List<long> TagIds { get; set; }
    }
}
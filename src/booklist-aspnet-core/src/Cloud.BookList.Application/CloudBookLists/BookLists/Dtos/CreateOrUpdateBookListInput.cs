using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cloud.BookList.CloudBookLists.BookLists.Dtos
{
    public class CreateOrUpdateBookListInput
    {
        [Required]
        public BookListEditDto BookList { get; set; }


        public List<long> BookIds { get; set; }
    }
}
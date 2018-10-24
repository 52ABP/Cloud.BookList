

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cloud.BookList.CloudBookList.BookListManagement;

namespace Cloud.BookList.CloudBookList.BookListManagement.Dtos
{
    public class CreateOrUpdateBookListInput
    {
        [Required]
        public BookListEditDto BookList { get; set; }


        public List<long> BookIds { get; set; }
    }
}
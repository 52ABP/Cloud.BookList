

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cloud.BookList.CloudBookList.BookManagement;

namespace Cloud.BookList.CloudBookList.BookManagement.Dtos
{
    public class CreateOrUpdateBookInput
    {
        [Required]
        public BookEditDto Book { get; set; }


        public List<long> TagIds { get; set; }
    }
}


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cloud.BookList.CloudBookList.BookTagManagement;

namespace Cloud.BookList.CloudBookList.BookTagManagement.Dtos
{
    public class CreateOrUpdateBookTagInput
    {
        [Required]
        public BookTagEditDto BookTag { get; set; }

    }
}
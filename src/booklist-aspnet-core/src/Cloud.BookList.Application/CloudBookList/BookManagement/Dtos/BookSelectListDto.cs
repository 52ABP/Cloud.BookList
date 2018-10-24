using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.BookList.CloudBookList.BookManagement.Dtos
{
    public class BookSelectListDto : BookListDto
    {
        public bool IsSelected { get; set; }
    }
}

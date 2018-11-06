using System.Collections.Generic;
using Cloud.BookList.CloudBookLists.Books.Dtos;

namespace Cloud.BookList.CloudBookLists.BookLists.Dtos
{
    public class GetBookListForEditOutput
    {

        public BookListEditDto BookList { get; set; }


        public List<BookSelectListDto> Books { get; set; }
    }
}
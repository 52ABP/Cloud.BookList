using System.Collections.Generic;
using Cloud.BookList.CloudBookLists.BookTags.Dtos;

namespace Cloud.BookList.CloudBookLists.Books.Dtos
{
    public class GetBookForEditOutput
    {

        public BookEditDto Book { get; set; }

        public List<BookTagSelectListDto> BookTags { get; set; }
    }
}
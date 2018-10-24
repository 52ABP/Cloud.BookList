

using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Cloud.BookList.CloudBookList.BookListManagement;
using Cloud.BookList.CloudBookList.BookManagement.Dtos;

namespace Cloud.BookList.CloudBookList.BookListManagement.Dtos
{
    public class GetBookListForEditOutput
    {

        public BookListEditDto BookList { get; set; }


        public List<BookSelectListDto> Books { get; set; }
    }
}
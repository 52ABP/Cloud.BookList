

using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Cloud.BookList.CloudBookList.BookManagement;
using Cloud.BookList.CloudBookList.BookTagManagement.Dtos;

namespace Cloud.BookList.CloudBookList.BookManagement.Dtos
{
    public class GetBookForEditOutput
    {

        public BookEditDto Book { get; set; }

        public List<BookTagSelectListDto> BookTags { get; set; }
    }
}
using Cloud.BookList.CloudBookList.BookManagement.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.BookList.CloudBookList.BookListManagement.Dtos
{
    public class BookListShareDto
    {
        public string Name { get; set; }



        /// <summary>
        /// 书单介绍
        /// </summary>
        public string Intro { get; set; }



        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }


        /// <summary>
        /// 书籍
        /// </summary>
        public List<BookAndBookTagDto> Books { get; set; }



        public string UserName { get; set; }
    }

}

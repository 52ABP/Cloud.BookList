using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.BookList.CloudBookList.BookManagement.Dtos
{
    public class BookAndBookTagDto
    {
        /// <summary>
        /// 封面
        /// </summary>
        public string ImgUrl { get; set; }



        /// <summary>
        /// 书名
        /// </summary>
        public string Name { get; set; }



        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }



        /// <summary>
        /// 简介
        /// </summary>
        public string Intro { get; set; }



        /// <summary>
        /// 购买链接
        /// </summary>
        public string Url { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public List<string> BookTags { get; set; }
    }
}

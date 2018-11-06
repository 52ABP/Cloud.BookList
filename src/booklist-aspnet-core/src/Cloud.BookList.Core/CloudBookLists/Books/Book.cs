using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Cloud.BookList.CloudBookList.RelationshipManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.BookList.CloudBookList.BookManagement
{
    /// <summary>
    /// 书籍
    /// </summary>
    public class Book : Entity<long>, IHasCreationTime, ICreationAudited, IModificationAudited, IMustHaveTenant
    {
        /// <summary>
        /// 封面图片Url
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
        /// 书籍链接(购买链接或其余链接)
        /// </summary>
        public string Url { get; set; }



        /// <summary>
        /// 和标签的关联
        /// </summary>
        public virtual List<BookAndBookTagRelationship> BookAndBookTagRelationships { get; set; }

        /// <summary>
        /// 和书单的关联
        /// </summary>
        public virtual List<BookListAndBookRelationship> BookListAndBookRelationships { get; set; }



        public int TenantId { get; set; }

        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

        public long? LastModifierUserId { get; set; }

        public DateTime? LastModificationTime { get; set; }
    }
}

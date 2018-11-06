using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Cloud.BookList.CloudBookList.RelationshipManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.BookList.CloudBookList.BookListManagement
{
    /// <summary>
    /// 书单
    /// </summary>
    public class BookList : Entity<long>, IHasCreationTime, ICreationAudited, IModificationAudited, IMustHaveTenant
    {
        /// <summary>
        /// 书单名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 书单简介
        /// </summary>
        public string Intro { get; set; }


        /// <summary>
        /// 和书籍的关联
        /// </summary>
        public virtual List<BookListAndBookRelationship> BookListAndBookRelationships { get; set; }


        public int TenantId { get; set; }

        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

        public long? LastModifierUserId { get; set; }

        public DateTime? LastModificationTime { get; set; }
    }
}

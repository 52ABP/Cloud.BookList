using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Cloud.BookList.CloudBookList.RelationshipManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.BookList.CloudBookList.BookTagManagement
{
    /// <summary>
    /// 书籍标签
    /// </summary>
    public class BookTag : Entity<long>, IHasCreationTime, ICreationAudited, IModificationAudited, IMustHaveTenant
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        public string Name { get; set; }



        public virtual List<BookAndBookTagRelationship> BookAndBookTagRelationships { get; set; }

        public int TenantId { get; set; }

        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

        public long? LastModifierUserId { get; set; }

        public DateTime? LastModificationTime { get; set; }
    }
}

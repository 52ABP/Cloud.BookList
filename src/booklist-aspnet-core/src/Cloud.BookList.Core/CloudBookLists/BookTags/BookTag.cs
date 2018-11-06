using System;
using System.Collections.Generic;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Cloud.BookList.CloudBookLists.Relationships;

namespace Cloud.BookList.CloudBookLists.BookTags
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

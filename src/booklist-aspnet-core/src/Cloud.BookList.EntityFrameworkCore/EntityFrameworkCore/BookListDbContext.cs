using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Cloud.BookList.Authorization.Roles;
using Cloud.BookList.Authorization.Users;
using Cloud.BookList.MultiTenancy;
using Cloud.BookList.CloudBookList.BookTagManagement;
using Cloud.BookList.CloudBookList.BookManagement;
using Cloud.BookList.CloudBookList.RelationshipManagement;

namespace Cloud.BookList.EntityFrameworkCore
{
    public class BookListDbContext : AbpZeroDbContext<Tenant, Role, User, BookListDbContext>
    {
        #region 云书单

        public DbSet<BookTag> BookTags { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<CloudBookList.BookListManagement.BookList> BookLists { get; set; }

        public DbSet<BookAndBookTagRelationship> BookAndBookTagRelationships { get; set; }

        public DbSet<BookListAndBookRelationship> BookListAndBookRelationship { get; set; }

        #endregion

        public BookListDbContext(DbContextOptions<BookListDbContext> options)
            : base(options)
        {


        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //修改ABP的默认表信息
            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("", YoYoAbpefCoreConsts.SchemaNames.ABP);
            base.OnModelCreating(modelBuilder);

            // ============  其它对表信息的修改 =============



            // 关系关联

            // 书籍和书籍标签
            modelBuilder.Entity<BookAndBookTagRelationship>()
                .HasOne(o => o.Book)
                .WithMany(o => o.BookAndBookTagRelationships)
                .HasForeignKey(e => e.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<BookAndBookTagRelationship>()
              .HasOne(o => o.BookTag)
              .WithMany(o => o.BookAndBookTagRelationships)
              .HasForeignKey(e => e.BookTagId)
              .OnDelete(DeleteBehavior.ClientSetNull);

            // 书单和书籍
            modelBuilder.Entity<BookListAndBookRelationship>()
            .HasOne(o => o.BookList)
            .WithMany(o => o.BookListAndBookRelationships)
            .HasForeignKey(e => e.BookListId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<BookListAndBookRelationship>()
             .HasOne(o => o.Book)
             .WithMany(o => o.BookListAndBookRelationships)
             .HasForeignKey(e => e.BookId)
             .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}

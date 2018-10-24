using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Cloud.BookList.EntityFrameworkCore
{
    public static class BookListDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BookListDbContext> builder, string connectionString)
        {
            builder.UseLazyLoadingProxies().UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BookListDbContext> builder, DbConnection connection)
        {
            builder.UseLazyLoadingProxies().UseSqlServer(connection);
        }
    }
}

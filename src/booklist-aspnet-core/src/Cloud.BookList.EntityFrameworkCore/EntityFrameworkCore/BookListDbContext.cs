using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Cloud.BookList.Authorization.Roles;
using Cloud.BookList.Authorization.Users;
using Cloud.BookList.MultiTenancy;

namespace Cloud.BookList.EntityFrameworkCore
{
    public class BookListDbContext : AbpZeroDbContext<Tenant, Role, User, BookListDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BookListDbContext(DbContextOptions<BookListDbContext> options)
            : base(options)
        {
        }
    }
}

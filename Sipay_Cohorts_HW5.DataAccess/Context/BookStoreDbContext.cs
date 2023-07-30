using Microsoft.EntityFrameworkCore;
using Sipay_Cohorts_HW5.Entities.DbSets;

namespace Sipay_Cohorts_HW5.DataAccess.Context
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options):base(options)
        {
            
        }
        public DbSet<Book>Books { get; set; }
        public DbSet<Genre>Genres { get; set; }
        public DbSet<Author>Authors { get; set; }
    }
}

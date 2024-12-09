using Microsoft.EntityFrameworkCore;
using CRUDBook.Models;

namespace CRUDBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}

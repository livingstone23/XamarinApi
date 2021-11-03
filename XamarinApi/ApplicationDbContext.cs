using Microsoft.EntityFrameworkCore;
using XamarinApi.Model;

namespace XamarinApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Author> Autores { get; set; }

    }
}

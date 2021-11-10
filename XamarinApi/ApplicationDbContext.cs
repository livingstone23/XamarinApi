using Microsoft.EntityFrameworkCore;
using XamarinApi.Model;

namespace XamarinApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }

        public DbSet<Libro> Libros { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

    }
}

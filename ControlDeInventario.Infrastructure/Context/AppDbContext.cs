using Microsoft.EntityFrameworkCore;
using ControlDeInventario.Domain.Entities;
using ControlDelInventario.Domain.Entities;

namespace ControlDeInventario.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Agregar configuraciones adicionales aquí si es necesario
        }
    }
}

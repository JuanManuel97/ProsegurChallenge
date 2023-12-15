using Microsoft.EntityFrameworkCore;
using ProsegurChallenge.Models;
using System.Security.Cryptography.X509Certificates;

namespace ProsegurChallenge.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<MateriaPrima> MateriaPrimas { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<ProductoMateriaPrima> ProductoMateriaPrimas { get; set; }
        public DbSet<OrdenProducto> OrdenProductos { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DataSource=CafeteriaDatabase.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrdenProducto>()
                .HasKey(op => new { op.IdOrden, op.IdProducto });

            modelBuilder.Entity<ProductoMateriaPrima>()
                .HasKey(pm => new { pm.IdProducto, pm.IdMateriaPrima });
        }
    }
}

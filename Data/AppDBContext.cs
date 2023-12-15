using Microsoft.EntityFrameworkCore;
using ProsegurChallenge.Entities;
using System.Security.Cryptography.X509Certificates;

namespace ProsegurChallenge.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<MateriaPrima> MateriaPrimas { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<EstadoOrden> EstadoOrdenes { get; set; }
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
            modelBuilder.Entity<Usuario>()
                .Property(u => u.IdUsuario).ValueGeneratedOnAdd();            

            modelBuilder.Entity<Rol>()
                .Property(r => r.IdRol).ValueGeneratedOnAdd();

            modelBuilder.Entity<MateriaPrima>()
                .Property(x => x.IdMateriaPrima).ValueGeneratedOnAdd();

            modelBuilder.Entity<Orden>()
                .Property(x => x.IdOrden).ValueGeneratedOnAdd();

            modelBuilder.Entity<Ciudad>()
                .Property(x => x.IdCiudad).ValueGeneratedOnAdd();

            modelBuilder.Entity<EstadoOrden>()
                .Property(x => x.IdEstado).ValueGeneratedOnAdd();

            modelBuilder.Entity<Producto>()
                .Property(x => x.IdProducto).ValueGeneratedOnAdd();

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Rol)
                .WithMany(r => r.Usuarios)
                .HasForeignKey(u => u.IdRol);

            modelBuilder.Entity<Orden>()
                .HasOne(o => o.Estado)
                .WithMany(e => e.Ordenes)
                .HasForeignKey(o => o.IdEstado);

            modelBuilder.Entity<OrdenProducto>()
                .HasKey(op => new { op.IdOrden, op.IdProducto });

            modelBuilder.Entity<OrdenProducto>()
                .HasOne(op => op.Orden)
                .WithMany(o => o.OrdenProductos)
                .HasForeignKey(op => op.IdOrden);

            modelBuilder.Entity<OrdenProducto>()
                .HasOne(op => op.Producto)
                .WithMany(p => p.OrdenProductos)
                .HasForeignKey(op => op.IdProducto);

            modelBuilder.Entity<ProductoMateriaPrima>()
                .HasKey(pm => new { pm.IdProducto, pm.IdMateriaPrima });

            modelBuilder.Entity<ProductoMateriaPrima>()
                .HasOne(pm => pm.Producto)
                .WithMany(p => p.ProductoMateriaPrimas)
                .HasForeignKey(pm => pm.IdProducto);

            modelBuilder.Entity<ProductoMateriaPrima>()
                .HasOne(pm => pm.MateriaPrima)
                .WithMany(p => p.ProductoMateriaPrimas)
                .HasForeignKey(pm => pm.IdMateriaPrima);
        }
    }
}

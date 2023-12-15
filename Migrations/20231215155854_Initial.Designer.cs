﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProsegurChallenge.Data;

#nullable disable

namespace ProsegurChallenge.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20231215155854_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("ProsegurChallenge.Models.Ciudad", b =>
                {
                    b.Property<int>("IdCiudad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PorcentajeImpuesto")
                        .HasColumnType("TEXT");

                    b.HasKey("IdCiudad");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("ProsegurChallenge.Models.Estado", b =>
                {
                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("IdEstado");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("ProsegurChallenge.Models.MateriaPrima", b =>
                {
                    b.Property<int>("IdMateriaPrima")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescripcionCantidad")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.HasKey("IdMateriaPrima");

                    b.ToTable("MateriaPrimas");
                });

            modelBuilder.Entity("ProsegurChallenge.Models.Orden", b =>
                {
                    b.Property<int>("IdOrden")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdEstado")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdOrden");

                    b.HasIndex("IdEstado");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("ProsegurChallenge.Models.OrdenProducto", b =>
                {
                    b.Property<int>("IdOrden")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<int>("IdProducto")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(2);

                    b.HasKey("IdOrden", "IdProducto");

                    b.HasIndex("IdProducto");

                    b.ToTable("OrdenProductos");
                });

            modelBuilder.Entity("ProsegurChallenge.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("TEXT");

                    b.HasKey("IdProducto");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("ProsegurChallenge.Models.ProductoMateriaPrima", b =>
                {
                    b.Property<int>("IdProducto")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<int>("IdMateriaPrima")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(2);

                    b.Property<decimal>("CantidadPorUnidad")
                        .HasColumnType("TEXT");

                    b.HasKey("IdProducto", "IdMateriaPrima");

                    b.HasIndex("IdMateriaPrima");

                    b.ToTable("ProductoMateriaPrimas");
                });

            modelBuilder.Entity("ProsegurChallenge.Models.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("IdRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ProsegurChallenge.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdRol")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdRol");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProsegurChallenge.Models.Orden", b =>
                {
                    b.HasOne("ProsegurChallenge.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("IdEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("ProsegurChallenge.Models.OrdenProducto", b =>
                {
                    b.HasOne("ProsegurChallenge.Models.Orden", "Orden")
                        .WithMany()
                        .HasForeignKey("IdOrden")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProsegurChallenge.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orden");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("ProsegurChallenge.Models.ProductoMateriaPrima", b =>
                {
                    b.HasOne("ProsegurChallenge.Models.MateriaPrima", "MateriaPrima")
                        .WithMany()
                        .HasForeignKey("IdMateriaPrima")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProsegurChallenge.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MateriaPrima");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("ProsegurChallenge.Models.Usuario", b =>
                {
                    b.HasOne("ProsegurChallenge.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });
#pragma warning restore 612, 618
        }
    }
}

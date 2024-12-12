﻿// <auto-generated />
using System;
using Codigo2024Clase33.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Codigo2024Clase33.Migrations
{
    [DbContext(typeof(DemoContex))]
    [Migration("20241212032721_Llaves foraneas")]
    partial class Llavesforaneas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Codigo2024Clase33.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteID"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Codigo2024Clase33.Models.Detalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("FacturaID")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductoID")
                        .HasColumnType("int");

                    b.HasKey("DetalleId");

                    b.HasIndex("FacturaID");

                    b.HasIndex("ProductoID");

                    b.ToTable("Detalles");
                });

            modelBuilder.Entity("Codigo2024Clase33.Models.Factura", b =>
                {
                    b.Property<int>("FacturaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacturaID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("VendedorID")
                        .HasColumnType("int");

                    b.HasKey("FacturaID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("VendedorID");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Codigo2024Clase33.Models.Producto", b =>
                {
                    b.Property<int>("ProductoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductoID"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductoID");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Codigo2024Clase33.Models.Vendedor", b =>
                {
                    b.Property<int>("VendedorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendedorID"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendedorID");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("Codigo2024Clase33.Models.Detalle", b =>
                {
                    b.HasOne("Codigo2024Clase33.Models.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("FacturaID");

                    b.HasOne("Codigo2024Clase33.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factura");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Codigo2024Clase33.Models.Factura", b =>
                {
                    b.HasOne("Codigo2024Clase33.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Codigo2024Clase33.Models.Vendedor", "vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorID");

                    b.Navigation("Cliente");

                    b.Navigation("vendedor");
                });
#pragma warning restore 612, 618
        }
    }
}

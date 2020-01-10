﻿// <auto-generated />
using System;
using ASP.NET_CORE_API_REST.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP.NET_CORE_API_REST.Migrations
{
    [DbContext(typeof(wsWorkshopsEntities))]
    partial class wsWorkshopsEntitiesModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Categorias", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CategoriaID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Establecimientos", b =>
                {
                    b.Property<int>("EstablecimientoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acerca_de")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Establecimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mapa")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("NIF")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("WebSite")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("EstablecimientoID");

                    b.ToTable("Establecimientos");
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Estados", b =>
                {
                    b.Property<int>("EstadoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("RegionID")
                        .HasColumnType("int");

                    b.HasKey("EstadoID");

                    b.HasIndex("RegionID");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Fotos", b =>
                {
                    b.Property<int>("FotoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstablecimientoID")
                        .HasColumnType("int");

                    b.Property<string>("Ruta_Foto")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("FotoID");

                    b.HasIndex("EstablecimientoID");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Meta_data", b =>
                {
                    b.Property<int>("MetadataID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstablecimientoID")
                        .HasColumnType("int");

                    b.Property<string>("Metadata")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MetadataID");

                    b.HasIndex("EstablecimientoID");

                    b.ToTable("Metadata");
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Municipios", b =>
                {
                    b.Property<int>("MunicipioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstadoID")
                        .HasColumnType("int");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("MunicipioID");

                    b.HasIndex("EstadoID");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Paises", b =>
                {
                    b.Property<int>("PaisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("PaisID");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Regiones", b =>
                {
                    b.Property<int>("RegionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PaisID")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("RegionID");

                    b.HasIndex("PaisID");

                    b.ToTable("Regiones");
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Rel_Categoria_Servicio", b =>
                {
                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<int>("ServicioID")
                        .HasColumnType("int");

                    b.HasKey("CategoriaID", "ServicioID");

                    b.ToTable("Rel_Categoria_Servicios");
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Servicios", b =>
                {
                    b.Property<int>("ServicioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Servicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ServicioID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Estados", b =>
                {
                    b.HasOne("ASP.NET_CORE_API_REST.Models.Regiones", "Regiones")
                        .WithMany()
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Fotos", b =>
                {
                    b.HasOne("ASP.NET_CORE_API_REST.Models.Establecimientos", "Establecimientos")
                        .WithMany()
                        .HasForeignKey("EstablecimientoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Meta_data", b =>
                {
                    b.HasOne("ASP.NET_CORE_API_REST.Models.Establecimientos", "Establecimientos")
                        .WithMany()
                        .HasForeignKey("EstablecimientoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Municipios", b =>
                {
                    b.HasOne("ASP.NET_CORE_API_REST.Models.Estados", "Estados")
                        .WithMany()
                        .HasForeignKey("EstadoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Regiones", b =>
                {
                    b.HasOne("ASP.NET_CORE_API_REST.Models.Paises", "Paises")
                        .WithMany()
                        .HasForeignKey("PaisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_CORE_API_REST.Models.Servicios", b =>
                {
                    b.HasOne("ASP.NET_CORE_API_REST.Models.Categorias", "Categorias")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

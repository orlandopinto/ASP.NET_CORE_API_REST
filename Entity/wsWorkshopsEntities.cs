using ASP.NET_CORE_API_REST.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_CORE_API_REST.Entity
{
	public partial class wsWorkshopsEntities : DbContext
	{
		public wsWorkshopsEntities(DbContextOptions<wsWorkshopsEntities> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Rel_Categoria_Servicio>().HasKey(r => new { r.CategoriaID, r.ServicioID });
		}

		public virtual DbSet<Categorias> Categorias { get; set; }
		public virtual DbSet<Establecimientos> Establecimientos { get; set; }
		public virtual DbSet<Estados> Estados { get; set; }
		public virtual DbSet<Fotos> Fotos { get; set; }
		public virtual DbSet<Meta_data> Metadata { get; set; }
		public virtual DbSet<Municipios> Municipios { get; set; }
		public virtual DbSet<Paises> Paises { get; set; }
		public virtual DbSet<Regiones> Regiones { get; set; }
		public virtual DbSet<Rel_Categoria_Servicio> Rel_Categoria_Servicios { get; set; }
		public virtual DbSet<Servicios> Servicios { get; set; }
	}
}
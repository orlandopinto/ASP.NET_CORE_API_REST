using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_CORE_API_REST.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    Activo = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaID);
                });

            migrationBuilder.CreateTable(
                name: "Establecimientos",
                columns: table => new
                {
                    EstablecimientoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    Establecimiento = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    WebSite = table.Column<string>(maxLength: 150, nullable: false),
                    Direccion = table.Column<string>(maxLength: 150, nullable: true),
                    NIF = table.Column<string>(maxLength: 50, nullable: false),
                    Telefonos = table.Column<string>(maxLength: 50, nullable: false),
                    Acerca_de = table.Column<string>(maxLength: 150, nullable: true),
                    Mapa = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Establecimientos", x => x.EstablecimientoID);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    PaisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pais = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.PaisID);
                });

            migrationBuilder.CreateTable(
                name: "Rel_Categoria_Servicios",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(nullable: false),
                    ServicioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rel_Categoria_Servicios", x => new { x.CategoriaID, x.ServicioID });
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    ServicioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaID = table.Column<int>(nullable: false),
                    Servicio = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    Activo = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.ServicioID);
                    table.ForeignKey(
                        name: "FK_Servicios_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    FotoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstablecimientoID = table.Column<int>(nullable: false),
                    Ruta_Foto = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.FotoID);
                    table.ForeignKey(
                        name: "FK_Fotos_Establecimientos_EstablecimientoID",
                        column: x => x.EstablecimientoID,
                        principalTable: "Establecimientos",
                        principalColumn: "EstablecimientoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Metadata",
                columns: table => new
                {
                    MetadataID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstablecimientoID = table.Column<int>(nullable: false),
                    Metadata = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metadata", x => x.MetadataID);
                    table.ForeignKey(
                        name: "FK_Metadata_Establecimientos_EstablecimientoID",
                        column: x => x.EstablecimientoID,
                        principalTable: "Establecimientos",
                        principalColumn: "EstablecimientoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regiones",
                columns: table => new
                {
                    RegionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaisID = table.Column<int>(nullable: false),
                    Region = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiones", x => x.RegionID);
                    table.ForeignKey(
                        name: "FK_Regiones_Paises_PaisID",
                        column: x => x.PaisID,
                        principalTable: "Paises",
                        principalColumn: "PaisID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    EstadoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionID = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.EstadoID);
                    table.ForeignKey(
                        name: "FK_Estados_Regiones_RegionID",
                        column: x => x.RegionID,
                        principalTable: "Regiones",
                        principalColumn: "RegionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    MunicipioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoID = table.Column<int>(nullable: false),
                    Municipio = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.MunicipioID);
                    table.ForeignKey(
                        name: "FK_Municipios_Estados_EstadoID",
                        column: x => x.EstadoID,
                        principalTable: "Estados",
                        principalColumn: "EstadoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estados_RegionID",
                table: "Estados",
                column: "RegionID");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_EstablecimientoID",
                table: "Fotos",
                column: "EstablecimientoID");

            migrationBuilder.CreateIndex(
                name: "IX_Metadata_EstablecimientoID",
                table: "Metadata",
                column: "EstablecimientoID");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_EstadoID",
                table: "Municipios",
                column: "EstadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Regiones_PaisID",
                table: "Regiones",
                column: "PaisID");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_CategoriaID",
                table: "Servicios",
                column: "CategoriaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fotos");

            migrationBuilder.DropTable(
                name: "Metadata");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Rel_Categoria_Servicios");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Establecimientos");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Regiones");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}

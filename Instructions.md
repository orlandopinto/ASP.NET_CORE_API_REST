INSTALAR LOS SIGUIENTES PAQUETES NUGET:
- dotnet tool install --global dotnet-ef --version 3.1.0
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools

AGREGAR LAS REFERENCIAS AL PROYECTO: 
	Boton derecho sobre el proyecto - add - references
	buscar Microsoft.EntityFrameworkCore.Design en su carpeta (boton derecho sobre el package - properties)

PARA REALIZAR LA MIGRACION POR PRIMERA HAY QUE ABRIR Package Manager Console

ESCRIBIR: 
1.- dotnet ef migrations add InitialCreate
2.- dotnet ef database update
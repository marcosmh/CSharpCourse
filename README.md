# CSharpCourse

## Dev C#


### .Net
* SDK DE .NET: 
	- Version: 7.0.317

* Entorno de tiempo de ejecución:
  - OS Name:     Mac OS X
  - OS Version:  13.6
  - OS Platform: Darwin
  - Architecture: x64

* Visual Studio 2022 para Mac OS

### Instalar dependencias en Mac OS
 * colocarse en la ruta del proyecto: /Users/markcode/Projects/CSharpCourse/BD
 * dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.10
 * dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.10
 * dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10

### Docker
- Docker —> SQL SERVER 2022

* Descarga la imagen de SQL Server Developer
  docker pull mcr.microsoft.com/mssql/server:2022-latest

* Ejecuta el contenedor
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=******" \
-p 1433:1433 --name sql_dev \
-d mcr.microsoft.com/mssql/server:2022-latest


### Notas

- para windows
  dotnet add package Microsoft.Data.SqlClient 

- para mac os
  dotnet add package System.Data.SqlClient --version 4.9.0

* Ejecutar la conexion desde la consola en Windows
Scaffold-DbContext "Server=localhost; Database=CsharpBD; User=sa; Password=******;Encrypt=False;" Microsoft.EntityFrameworkCore.SqlServer

* Ejecutar la conexion desde la consola en Mac Os
dotnet ef dbcontext scaffold "Server=localhost;Database=CsharpBD;User=sa;Password=Admindba\$;Encrypt=False;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --context-dir Data --context CsharpContext --force






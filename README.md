# CSharpCourse

## Dev C#
---------------

### .Net
- Version = SDK 7.0.317

### Instalar dependencias en Mac OS
 * colocarse en la ruta del proyecto: /Users/markcode/Projects/CSharpCourse/BD
 * dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.10
 * dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.10
 * dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10

### Docker
Docker —> SQL SERVER 2022

* Descarga la imagen de SQL Server Developer
docker pull mcr.microsoft.com/mssql/server:2022-latest

* Ejecuta el contenedor
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=******" \
-p 1433:1433 --name sql_dev \
-d mcr.microsoft.com/mssql/server:2022-latest


### Notas

* Ejecutar la conexion desde la consola en Windows
Scaffold-DbContext "Server=localhost; Database=CsharpBD; User=sa; Password=******;Encrypt=False;" Microsoft.EntityFrameworkCore.SqlServer

* Ejecutar la conexion desde la consola en Mac Os
dotnet ef dbcontext scaffold "Server=localhost;Database=CsharpBD;User=sa;Password=Admindba\$;Encrypt=False;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --context-dir Data --context CsharpContext --force






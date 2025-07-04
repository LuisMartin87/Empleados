# EmpleadosApp

Mini CRUD de gesti�n de empleados usando Razor Pages (.NET Core 3.0+) y Entity Framework Core con SQLite.

---

## Requisitos Previos

- [.NET Core SDK 3.0 o superior](https://dotnet.microsoft.com/download)
- SQLite instalado (opcional, ya que EF Core puede crear la base de datos autom�ticamente)
- Visual Studio 2019/2022 o VS Code para desarrollo

---

## Instalaci�n y Ejecuci�n

1. Clona el repositorio

```bash
git clone <URL-del-repositorio>
cd EmpleadosApp

2. Aplica migraciones y crea la base de datos

- dotnet ef database update

3. Ejecuta la aplicaci�n
- dotnet run

 4. Abre tu navegador y navega a `http://localhost:5000/Empleados` o `http://localhost:5001/Empleados`

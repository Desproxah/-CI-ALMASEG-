# CI Almaseg - Gestión de ferretería

Aplicación de escritorio para la ferretería **CI Almaseg S.A.S.**, desarrollada en
Windows Forms con .NET Framework 4.8. Incluye autenticación, panel administrativo,
gestión de categorías, productos y proveedores, además del catálogo de productos.

La base de datos corre en **SQL Server LocalDB**, un motor de SQL Server que se
ejecuta bajo demanda en el equipo. No requiere Docker, no instala un servicio de
Windows y no necesita configurar contraseñas de administrador.

## Requisitos

- Windows 10 u 11.
- .NET Framework 4.8.
- **SQL Server LocalDB** (2019 o superior) y `sqlcmd`.
- Visual Studio 2022 o superior con la carga de trabajo **.NET desktop development**
  (solo para compilar). También sirven las Build Tools con MSBuild.

Para comprobar que LocalDB está disponible:

```powershell
sqllocaldb info
sqlcmd -S "(localdb)\MSSQLLocalDB" -E -Q "SELECT @@VERSION"
```

Si el primer comando no existe, instala **SQL Server Express LocalDB** desde el
instalador de SQL Server Express o desde el paquete `SqlLocalDB.msi`
([guía de Microsoft](https://learn.microsoft.com/sql/database-engine/configure-windows/sql-server-express-localdb)).
Si falta `sqlcmd`, instala las herramientas de línea de comandos de SQL Server.

## Inicio rápido

Desde la carpeta del proyecto:

```powershell
powershell -ExecutionPolicy Bypass -File .\scripts\start.ps1
```

También puedes hacer doble clic en `iniciar.cmd`.

El script realiza todo el flujo:

1. Inicia la instancia `MSSQLLocalDB`.
2. Crea la base `Ci.Almaseg.Ferreteria.Final` y carga los datos de demostración
   si no existe.
3. Aplica las migraciones pendientes.
4. Compila la aplicación si el ejecutable no existe o el código cambió.
5. Abre la aplicación.

Para preparar la base de datos sin abrir la aplicación:

```powershell
.\scripts\init-db.ps1
```

## Credenciales de demostración

| Correo | Contraseña | Rol |
| --- | --- | --- |
| admin@cialmaseg.com | Admin123* | ADMINISTRADOR |
| compras@cialmaseg.com | Compras123* | AUXILIAR_COMPRAS |
| laura.gomez@cialmaseg.com | Ventas123* | VENDEDOR |
| carlos.ramirez@cialmaseg.com | Ventas123* | VENDEDOR |
| andrea.lopez@cialmaseg.com | Ventas123* | VENDEDOR |
| inventario@cialmaseg.com | Inventario123* | ENCARGADO_INVENTARIO |

Solo el rol **ADMINISTRADOR** entra al panel administrativo. El catálogo se puede
abrir desde la pantalla de acceso sin iniciar sesión.

## Scripts disponibles

| Script | Descripción |
| --- | --- |
| `scripts\start.ps1` | Prepara la base, compila si hace falta y abre la aplicación. Usa `-SkipApp` para no abrirla. |
| `scripts\init-db.ps1` | Inicia LocalDB, crea la base si no existe y aplica migraciones. |
| `scripts\build-app.ps1` | Compila la solución y copia el resultado a `dist\CIAlmaseg`. |
| `scripts\run-app.ps1` | Abre el ejecutable ya compilado. |
| `scripts\stop.ps1` | Detiene LocalDB. Los datos se conservan. |
| `scripts\reset-db.ps1` | Elimina la base y vuelve a cargar los datos de demostración. Pierdes los cambios actuales; pide confirmación y acepta `-Force` para omitirla. |

## Base de datos

- Instancia: `(localdb)\MSSQLLocalDB`
- Base de datos: `Ci.Almaseg.Ferreteria.Final`
- Esquema: `tbl`
- Script principal: `database\Ci.Almaseg.Ferreteria.Final_Datos.sql`
- Migraciones: `database\migrations`

La cadena de conexión está en `CIAlmaseg\App.config`:

```text
Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Ci.Almaseg.Ferreteria.Final;Integrated Security=True;Encrypt=False;Connect Timeout=10
```

La autenticación usa la cuenta de Windows (`Integrated Security=True`), por eso no
hay usuario ni contraseña de SQL en el archivo.

### Usar otro servidor SQL

Puedes sobrescribir la conexión con la variable de entorno
`CIALMASEG_CONNECTION_STRING`:

```powershell
$env:CIALMASEG_CONNECTION_STRING = "Data Source=MI-SERVIDOR;Initial Catalog=Ci.Almaseg.Ferreteria.Final;User Id=usuario;Password=clave;TrustServerCertificate=True"
.\scripts\run-app.ps1
```

La variable tiene prioridad sobre `App.config` y sirve tanto para LocalDB como para
un SQL Server completo.

## Estructura del proyecto

```text
CIAlmaseg\
  CIAlmaseg\        Proyecto WinForms (.NET Framework 4.8)
  database\         Script de creación y datos + migraciones
  scripts\          Automatización local (LocalDB, compilación y ejecución)
  dist\             Salida compilada (se genera, no se versiona)
  iniciar.cmd       Lanzador de doble clic
  CIAlmaseg.slnx    Solución
```

## Solución de problemas

**No se encontró MSBuild.**
Instala Visual Studio con la carga de trabajo ".NET desktop development" o las
Build Tools de Visual Studio.

**"La instancia LocalDB no está disponible".**
Ejecuta:

```powershell
sqllocaldb start MSSQLLocalDB
.\scripts\init-db.ps1
```

**"La base de datos no existe".**
Ejecuta `.\scripts\init-db.ps1`. Si el problema continúa, revisa que `sqlcmd`
pueda conectarse con `sqlcmd -S "(localdb)\MSSQLLocalDB" -E -Q "SELECT 1"`.

**El login falla con una base creada anteriormente.**
La base antigua guardaba las contraseñas en texto plano. `init-db.ps1` aplica la
migración que las convierte a SHA-256. Si aun así falla, restaura los datos demo con
`.\scripts\reset-db.ps1`.

**Quiero empezar de cero.**
Ejecuta `.\scripts\reset-db.ps1` y confirma con `SI`. Esto elimina la base y vuelve
a cargar los datos de demostración, así que **borra todos los datos actuales,
incluidas las modificaciones que hayas hecho**.

**Errores inesperados de la aplicación.**
Revisa el archivo de log en `%LOCALAPPDATA%\CIAlmaseg\logs`.

## Alcance actual

- Funcional: inicio de sesión, panel administrativo, categorías, productos,
  proveedores y catálogo.
- Solo interfaz (sin lógica conectada): clientes, empleados, compras, ventas y
  reportes.

## Notas

- No se usan librerías externas de interfaz.
- Las contraseñas de demostración se guardan como SHA-256 sin sal. Para producción
  se recomienda usar un esquema con sal (PBKDF2, bcrypt o similar).
- El proyecto no requiere Docker.

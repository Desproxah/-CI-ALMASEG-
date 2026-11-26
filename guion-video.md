# Guion para el video de exposición (máximo 10 minutos)

Proyecto: **CI Almaseg** — Windows Forms + .NET Framework 4.8 + SQL Server LocalDB.

---

## 1. Estado verificado (ya lo probé por ti)

| Verificación | Resultado |
| --- | --- |
| `scripts\init-db.ps1` | Base `Ci.Almaseg.Ferreteria.Final` lista, migraciones al día |
| Datos demo | 14 productos, 6 usuarios, 15 ventas completadas, 6 clientes |
| Login `admin@cialmaseg.com` / `Admin123*` | Funciona (contraseña en SHA-256) |
| Los 9 módulos (`catalogo`, `categorias`, `productos`, `clientes`, `proveedores`, `empleados`, `ventas`, `compras`, `reportes`) | Abren sin crashes, sin diálogos de error y sin errores en el log |
| Query del panel (KPIs) | $11.774.815 en ventas · 14 productos · 2 con stock bajo · 6 clientes |
| Triggers de stock y totales | Funcionan: al insertar un detalle de venta el stock baja (67 → 65) y el total se recalcula (2 × 10,50 = 21,00). Probado con `ROLLBACK`, tus datos no se tocaron |
| Herramientas de grabación | Instaladas: **Xbox Game Bar** y **Herramienta de Recortes** (Windows 11) |

---

## 2. Checklist ANTES de grabar (hazlo esta noche)

- [ ] Cerrar todo lo que no vayas a usar (navegador, WhatsApp, Discord, correo) y activar **modo concentración** para que no entren notificaciones.
- [ ] Micrófono probado (graba y reproduces un audio de prueba).
- [ ] Resolución 1920 × 1080 y la app en pantalla completa / maximizada.
- [ ] Dejar la terminal con el comando listo para copiar y pegar.
- [ ] **Restablecer los datos de demostración** para que el video empiece limpio:
  ```powershell
  .\scripts\reset-db.ps1        # responde SI
  ```
  (Si haces una práctica completa antes de grabar, repite este paso.)
- [ ] Compilar la última versión:
  ```powershell
  .\scripts\build-app.ps1
  ```
- [ ] Practicar el guion **una vez sin grabar** cronometrando.
- [ ] Decidir la herramienta de grabación y probarla:
  - **Win + Shift + R** → Herramienta de Recortes (graba pantalla con micrófono). *Recomendada.*
  - **Win + Alt + R** → Xbox Game Bar (no captura el escritorio ni el explorador, solo ventanas).
  - Si ninguna convence: instalar OBS Studio (gratis).

---

## 3. Guion minuto a minuto

> Los textos entre comillas son una sugerencia de narración; dilo con tus palabras.
> Las cifras pueden variar si modificas datos.

### 0:00 – 0:40 · Presentación
**En pantalla:** el ícono del proyecto / el código en el explorador (breve) y luego la app cerrada.

> "Este es **CI Almaseg**, una aplicación de escritorio para la ferretería CI Almaseg S.A.S. para gestionar productos, categorías, clientes, proveedores, empleados, compras, ventas y reportes.
> Está desarrollada en **Windows Forms con .NET Framework 4.8**, usa **SQL Server LocalDB** como base de datos y **no utiliza librerías externas de interfaz**: todo el diseño y la lógica son propios."

### 0:40 – 1:30 · Arquitectura y arranque
**En pantalla:** explorador de carpetas mostrando `scripts`, `database`, `CIAlmaseg` y luego la terminal.

> "El proyecto tiene tres partes: `CIAlmaseg` con el código de la aplicación, `database` con el script de creación de la base y las migraciones, y `scripts` con la automatización.
> La base tiene **11 tablas** en el esquema `tbl`, **4 triggers** que controlan el stock y recalculan totales, y **7 índices** para acelerar las consultas.
> Para levantar todo basta un comando: `iniciar.cmd` o `scripts\start.ps1`."

**Acción:** doble clic en `iniciar.cmd` (o ejecuta el comando). Se ve la terminal: crea/verifica la base, aplica migraciones, compila si hace falta y abre la app.

> "El script arranca LocalDB, crea la base con los datos de demostración si no existe, aplica las migraciones, compila la aplicación y la abre. Sin instalar servicios de Windows ni Docker."

### 1:30 – 2:30 · Login y seguridad
**En pantalla:** pantalla de acceso.

> "La pantalla de acceso tiene dos modos: **Administrador**, que entra al panel, y **Cliente**, que abre el catálogo directamente."

**Acción:** escribe un correo sin `@` → aparece la validación. Escribe correo correcto con contraseña vacía → validación. Luego correo y contraseña malos → "El correo o la contraseña no son correctos."

> "Validamos el formato del correo, que la contraseña no esté vacía y que las credenciales existan en la base. Las contraseñas se guardan como **hash SHA-256**, nunca en texto plano."

**Acción:** pulsa el botón **Ver** de la contraseña, escribe `Admin123*`, y entra con `admin@cialmaseg.com`.

> "También se puede mostrar u ocultar la contraseña. Entramos con el usuario administrador."

### 2:30 – 3:20 · Panel administrativo
**En pantalla:** panel con KPIs.

> "El panel muestra el saludo al usuario, la fecha y el rol de la sesión, y **cuatro indicadores que se calculan directamente en SQL**: ventas acumuladas, productos activos, productos con stock bajo y clientes activos.
> A la izquierda está la navegación con todos los módulos, y arriba el acceso a cerrar sesión."

**Acción:** pasar el mouse por los 4 KPIs y por el menú lateral. Mencionar: "14 productos activos, 2 con stock bajo".

### 3:20 – 4:00 · Categorías
**Acción:** crear una categoría nueva (nombre + descripción + activa) y editarla.

> "En categorías se listan las existentes y se pueden crear o editar. Cada categoría tiene nombre, descripción y un estado activo/inactivo; el estado se usa como filtro en el resto del módulo."

### 4:00 – 5:00 · Productos
**Acción:** filtrar por categoría en la tabla, editar un producto (cambiar precio o stock y guardar), mostrar la validación de nombre duplicado si aplica.

> "Productos es el módulo central: nombre, categoría, descripción, precio, stock y stock mínimo. Se filtra por categoría y por estado, y el stock mínimo es el que alimenta el indicador de *stock bajo* del panel."

### 5:00 – 5:50 · Clientes, proveedores y empleados (rápido)
**Acción:** abrir cada uno, hacer un alta o una edición breve.

> "Clientes, proveedores y empleados siguen el mismo patrón CRUD: tabla con búsqueda, formulario de alta y edición, y estado activo/inactivo. Todos persisten en la base con sus respectivas llaves foráneas."

### 5:50 – 7:10 · Ventas (la parte estrella)
**Acción:**
1. Abrir Productos, elegir un producto y **señalar el stock** ("hoy hay 67 unidades").
2. Abrir Ventas, elegir cliente, producto, cantidad (2) y agregar al carrito.
3. Señalar que **no deja poner más cantidad que el stock disponible** (validación en la interfaz).
4. Confirmar la venta y mostrar el mensaje de éxito con el total.
5. Volver a Productos y **mostrar que el stock bajó a 65**.

> "En ventas se selecciona el cliente, el producto y la cantidad; el carrito calcula el total. La interfaz valida que no se venda más de lo disponible, y al confirmar se inserta la venta y su detalle en una sola transacción.
> Lo importante: **el stock no lo descuenta la aplicación, lo descuenta un trigger en la base de datos** (`tr_stock_detalle_venta`), que además impide dejar stock negativo y lanza un error si algo queda inconsistente.
> Como ven, el stock pasó de 67 a 65 unidades: la regla de negocio vive en la base, no en la interfaz."

### 7:10 – 7:50 · Compras
**Acción:** registrar una compra breve (proveedor, producto, cantidad, costo).

> "Compras funciona igual pero al revés: aumenta el stock con el trigger `tr_stock_detalle_compra` y recalcula el total de la compra con `tr_total_detalle_compra`. Si la compra dejaría stock negativo, la base lo rechaza."

### 7:50 – 8:50 · Reportes
**Acción:** elegir un rango de fechas, un empleado y pulsar **Consultar**. Mostrar las gráficas.

> "Reportes cruza fechas y empleado para mostrar tres vistas: resumen del período, **ventas por mes** y **ventas por empleado**, con gráficas de columnas generadas con la librería de gráficas de .NET y consultas con `GROUP BY`."

### 8:50 – 9:20 · Catálogo sin sesión
**Acción:** cerrar sesión → "Ver catálogo de productos" → buscar un texto y usar el filtro (que ahora dice **Todos los productos**).

> "Desde la pantalla de acceso se abre el catálogo **sin iniciar sesión**: búsqueda por texto y filtro de categoría, pensado para consulta del cliente."

### 9:20 – 10:00 · Cierre
**En pantalla:** de vuelta en el panel o el explorador.

> "En resumen: aplicación WinForms completa con autenticación, 9 módulos funcionales conectados a SQL Server LocalDB, reglas de negocio (stock y totales) resueltas con triggers, contraseñas en hash SHA-256, automatización de base y compilación con scripts, y manejo de errores con registro en `%LOCALAPPDATA%\CIAlmaseg\logs`.
> Eso es todo, gracias."

---

## 4. Consejos de grabación

1. **Graba en un solo intento y edita después** si sobra tiempo; es más fácil recortar que repetir.
2. **Mantén el mouse en movimiento** y señala con el cursor lo que estás explicando.
3. **No leas el guion word por word:** usa los bullets y habla natural.
4. **Cronómetro a la vista** (celular). Si vas a 6:00 y no has llegado a Ventas, acelera los CRUD.
5. **Deja margen:** apunta a **9:30**, no a 10:00.
6. Antes de empezar a narrar, **deja la app cargada y en la pantalla inicial** para no perder tiempo con cargas.
7. Si algo falla en vivo: "eso lo solucionamos con `scripts\init-db.ps1`" y sigue; no detengas el video.

## 5. Plan B si algo falla

| Problema | Solución rápida |
| --- | --- |
| "La instancia LocalDB no está disponible" | `sqllocaldb start MSSQLLocalDB` y `.\scripts\init-db.ps1` |
| "La base de datos no existe" | `.\scripts\init-db.ps1` |
| Login falla (base vieja con contraseñas en texto plano) | `.\scripts\reset-db.ps1` (responde SI) |
| Datos sucios por la práctica | `.\scripts\reset-db.ps1` antes de grabar |
| Error raro de la aplicación | revisa `%LOCALAPPDATA%\CIAlmaseg\logs\error.log` |
| La app no abre | `.\scripts\build-app.ps1` y luego `.\scripts\run-app.ps1` |

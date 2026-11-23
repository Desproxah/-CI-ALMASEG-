/* =====================================================================
   CI ALMASEG S.A.S. - BASE DE DATOS FINAL CON DATOS DE FERRETERIA
   Motor: Microsoft SQL Server 2017+
   Base nueva: [Ci.Almaseg.Ferreteria.Final]
   Esquema: tbl

   Incluye:
   - 11 tablas definitivas
   - Empleados y registro del empleado que realiza cada venta
   - Precio de venta calculado automáticamente
   - Compras que aumentan stock
   - Ventas que disminuyen stock
   - Datos distribuidos en varios meses para gráficos
   - Consultas para ventas por mes y por empleado

   IMPORTANTE: este script únicamente elimina y reconstruye
   [Ci.Almaseg.Ferreteria.Final]. No modifica bases anteriores.
   ===================================================================== */

SET ANSI_NULLS ON;
SET ANSI_PADDING ON;
SET ANSI_WARNINGS ON;
SET ARITHABORT ON;
SET CONCAT_NULL_YIELDS_NULL ON;
SET QUOTED_IDENTIFIER ON;
SET NUMERIC_ROUNDABORT OFF;
GO

USE master;
GO

IF DB_ID(N'Ci.Almaseg.Ferreteria.Final') IS NOT NULL
BEGIN
    ALTER DATABASE [Ci.Almaseg.Ferreteria.Final]
        SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [Ci.Almaseg.Ferreteria.Final];
END;
GO

CREATE DATABASE [Ci.Almaseg.Ferreteria.Final];
GO

USE [Ci.Almaseg.Ferreteria.Final];
GO

IF SCHEMA_ID(N'tbl') IS NULL
    EXEC(N'CREATE SCHEMA tbl AUTHORIZATION dbo;');
GO

/* ================================ 1. ROL ================================ */
CREATE TABLE tbl.rol (
    id_rol       INT IDENTITY(1,1) NOT NULL,
    nombre       VARCHAR(50) NOT NULL,
    descripcion  VARCHAR(200) NULL,
    estado       BIT NOT NULL CONSTRAINT df_rol_estado DEFAULT (1),
    CONSTRAINT pk_rol PRIMARY KEY (id_rol),
    CONSTRAINT uq_rol_nombre UNIQUE (nombre)
);
GO

/* ============================== 2. USUARIO ============================== */
CREATE TABLE tbl.usuario (
    id_usuario      INT IDENTITY(1,1) NOT NULL,
    id_rol          INT NOT NULL,
    nombre          VARCHAR(100) NOT NULL,
    correo          VARCHAR(120) NOT NULL,
    clave_hash      VARCHAR(255) NOT NULL,
    estado          BIT NOT NULL CONSTRAINT df_usuario_estado DEFAULT (1),
    fecha_registro  DATETIME2(0) NOT NULL CONSTRAINT df_usuario_fecha DEFAULT (SYSDATETIME()),
    ultimo_acceso   DATETIME2(0) NULL,
    CONSTRAINT pk_usuario PRIMARY KEY (id_usuario),
    CONSTRAINT uq_usuario_correo UNIQUE (correo),
    CONSTRAINT fk_usuario_rol FOREIGN KEY (id_rol)
        REFERENCES tbl.rol(id_rol)
);
GO

/* ============================= 3. EMPLEADO ============================== */
CREATE TABLE tbl.empleado (
    id_empleado        INT IDENTITY(1,1) NOT NULL,
    id_usuario         INT NULL,
    tipo_documento     VARCHAR(25) NOT NULL,
    numero_documento   VARCHAR(30) NOT NULL,
    nombre             VARCHAR(120) NOT NULL,
    telefono           VARCHAR(20) NULL,
    correo             VARCHAR(120) NULL,
    cargo              VARCHAR(50) NOT NULL,
    estado             BIT NOT NULL CONSTRAINT df_empleado_estado DEFAULT (1),
    fecha_registro     DATETIME2(0) NOT NULL CONSTRAINT df_empleado_fecha DEFAULT (SYSDATETIME()),
    CONSTRAINT pk_empleado PRIMARY KEY (id_empleado),
    CONSTRAINT uq_empleado_usuario UNIQUE (id_usuario),
    CONSTRAINT uq_empleado_documento UNIQUE (numero_documento),
    CONSTRAINT uq_empleado_correo UNIQUE (correo),
    CONSTRAINT chk_empleado_tipo_documento CHECK
        (tipo_documento IN ('CEDULA','CEDULA_EXTRANJERIA','PASAPORTE')),
    CONSTRAINT chk_empleado_cargo CHECK
        (cargo IN ('ADMINISTRADOR','AUXILIAR_COMPRAS','VENDEDOR','ENCARGADO_INVENTARIO')),
    CONSTRAINT fk_empleado_usuario FOREIGN KEY (id_usuario)
        REFERENCES tbl.usuario(id_usuario)
);
GO

/* ============================== 4. CLIENTE ============================== */
CREATE TABLE tbl.cliente (
    id_cliente        INT IDENTITY(1,1) NOT NULL,
    tipo_documento    VARCHAR(25) NOT NULL,
    numero_documento  VARCHAR(30) NOT NULL,
    nombre            VARCHAR(120) NOT NULL,
    telefono          VARCHAR(20) NULL,
    direccion         VARCHAR(200) NULL,
    ciudad            VARCHAR(80) NULL,
    estado            BIT NOT NULL CONSTRAINT df_cliente_estado DEFAULT (1),
    CONSTRAINT pk_cliente PRIMARY KEY (id_cliente),
    CONSTRAINT uq_cliente_documento UNIQUE (numero_documento),
    CONSTRAINT chk_cliente_tipo_documento CHECK
        (tipo_documento IN ('CEDULA','CEDULA_EXTRANJERIA','NIT','PASAPORTE'))
);
GO

/* ============================= 5. CATEGORIA ============================= */
CREATE TABLE tbl.categoria (
    id_categoria  INT IDENTITY(1,1) NOT NULL,
    nombre        VARCHAR(80) NOT NULL,
    descripcion   VARCHAR(200) NULL,
    estado        BIT NOT NULL CONSTRAINT df_categoria_estado DEFAULT (1),
    CONSTRAINT pk_categoria PRIMARY KEY (id_categoria),
    CONSTRAINT uq_categoria_nombre UNIQUE (nombre)
);
GO

/* ============================== 6. PRODUCTO =============================
   precio_venta es calculado. El usuario solo escribe precio_compra y
   porcentaje_ganancia.
   Ejemplo: 100000 + 30% = 130000.
   ===================================================================== */
CREATE TABLE tbl.producto (
    id_producto          INT IDENTITY(1,1) NOT NULL,
    id_categoria         INT NOT NULL,
    codigo               VARCHAR(30) NOT NULL,
    nombre               VARCHAR(120) NOT NULL,
    descripcion          VARCHAR(500) NULL,
    precio_compra        DECIMAL(12,2) NOT NULL CONSTRAINT df_producto_compra DEFAULT (0),
    porcentaje_ganancia  DECIMAL(5,2) NOT NULL CONSTRAINT df_producto_ganancia DEFAULT (30),
    precio_venta AS
        (CONVERT(DECIMAL(12,2), precio_compra + (precio_compra * porcentaje_ganancia / 100.0))) PERSISTED,
    stock                INT NOT NULL CONSTRAINT df_producto_stock DEFAULT (0),
    stock_minimo         INT NOT NULL CONSTRAINT df_producto_minimo DEFAULT (0),
    estado               BIT NOT NULL CONSTRAINT df_producto_estado DEFAULT (1),
    fecha_registro       DATETIME2(0) NOT NULL CONSTRAINT df_producto_fecha DEFAULT (SYSDATETIME()),
    CONSTRAINT pk_producto PRIMARY KEY (id_producto),
    CONSTRAINT uq_producto_codigo UNIQUE (codigo),
    CONSTRAINT chk_producto_precio_compra CHECK (precio_compra >= 0),
    CONSTRAINT chk_producto_ganancia CHECK (porcentaje_ganancia >= 0 AND porcentaje_ganancia <= 500),
    CONSTRAINT chk_producto_stock CHECK (stock >= 0),
    CONSTRAINT chk_producto_stock_minimo CHECK (stock_minimo >= 0),
    CONSTRAINT fk_producto_categoria FOREIGN KEY (id_categoria)
        REFERENCES tbl.categoria(id_categoria)
);
GO

/* ============================= 7. PROVEEDOR ============================= */
CREATE TABLE tbl.proveedor (
    id_proveedor  INT IDENTITY(1,1) NOT NULL,
    nit           VARCHAR(20) NOT NULL,
    razon_social  VARCHAR(120) NOT NULL,
    telefono      VARCHAR(20) NULL,
    correo        VARCHAR(120) NULL,
    direccion     VARCHAR(200) NULL,
    ciudad        VARCHAR(80) NULL,
    estado        BIT NOT NULL CONSTRAINT df_proveedor_estado DEFAULT (1),
    CONSTRAINT pk_proveedor PRIMARY KEY (id_proveedor),
    CONSTRAINT uq_proveedor_nit UNIQUE (nit)
);
GO

/* =============================== 8. COMPRA ============================== */
CREATE TABLE tbl.compra (
    id_compra     INT IDENTITY(1,1) NOT NULL,
    id_proveedor  INT NOT NULL,
    id_empleado   INT NOT NULL,
    fecha         DATETIME2(0) NOT NULL CONSTRAINT df_compra_fecha DEFAULT (SYSDATETIME()),
    estado        VARCHAR(20) NOT NULL CONSTRAINT df_compra_estado DEFAULT ('REGISTRADA'),
    total         DECIMAL(14,2) NOT NULL CONSTRAINT df_compra_total DEFAULT (0),
    observacion   VARCHAR(250) NULL,
    CONSTRAINT pk_compra PRIMARY KEY (id_compra),
    CONSTRAINT chk_compra_total CHECK (total >= 0),
    CONSTRAINT chk_compra_estado CHECK (estado IN ('REGISTRADA','RECIBIDA','CANCELADA')),
    CONSTRAINT fk_compra_proveedor FOREIGN KEY (id_proveedor)
        REFERENCES tbl.proveedor(id_proveedor),
    CONSTRAINT fk_compra_empleado FOREIGN KEY (id_empleado)
        REFERENCES tbl.empleado(id_empleado)
);
GO

/* ========================== 9. DETALLE COMPRA ========================== */
CREATE TABLE tbl.detalle_compra (
    id_detalle_compra  INT IDENTITY(1,1) NOT NULL,
    id_compra          INT NOT NULL,
    id_producto        INT NOT NULL,
    cantidad           INT NOT NULL,
    costo_unitario     DECIMAL(12,2) NOT NULL,
    subtotal AS (CONVERT(DECIMAL(14,2), cantidad * costo_unitario)) PERSISTED,
    CONSTRAINT pk_detalle_compra PRIMARY KEY (id_detalle_compra),
    CONSTRAINT uq_detalle_compra_producto UNIQUE (id_compra,id_producto),
    CONSTRAINT chk_detalle_compra_cantidad CHECK (cantidad > 0),
    CONSTRAINT chk_detalle_compra_costo CHECK (costo_unitario >= 0),
    CONSTRAINT fk_detalle_compra_compra FOREIGN KEY (id_compra)
        REFERENCES tbl.compra(id_compra) ON DELETE CASCADE,
    CONSTRAINT fk_detalle_compra_producto FOREIGN KEY (id_producto)
        REFERENCES tbl.producto(id_producto)
);
GO

/* =============================== 10. VENTA ============================== */
CREATE TABLE tbl.venta (
    id_venta      INT IDENTITY(1,1) NOT NULL,
    id_cliente    INT NOT NULL,
    id_empleado   INT NOT NULL,
    fecha         DATETIME2(0) NOT NULL CONSTRAINT df_venta_fecha DEFAULT (SYSDATETIME()),
    estado        VARCHAR(20) NOT NULL CONSTRAINT df_venta_estado DEFAULT ('REGISTRADA'),
    total         DECIMAL(14,2) NOT NULL CONSTRAINT df_venta_total DEFAULT (0),
    observacion   VARCHAR(250) NULL,
    CONSTRAINT pk_venta PRIMARY KEY (id_venta),
    CONSTRAINT chk_venta_total CHECK (total >= 0),
    CONSTRAINT chk_venta_estado CHECK (estado IN ('REGISTRADA','COMPLETADA','CANCELADA')),
    CONSTRAINT fk_venta_cliente FOREIGN KEY (id_cliente)
        REFERENCES tbl.cliente(id_cliente),
    CONSTRAINT fk_venta_empleado FOREIGN KEY (id_empleado)
        REFERENCES tbl.empleado(id_empleado)
);
GO

/* ========================== 11. DETALLE VENTA ========================== */
CREATE TABLE tbl.detalle_venta (
    id_detalle_venta  INT IDENTITY(1,1) NOT NULL,
    id_venta          INT NOT NULL,
    id_producto       INT NOT NULL,
    cantidad          INT NOT NULL,
    precio_unitario   DECIMAL(12,2) NOT NULL,
    subtotal AS (CONVERT(DECIMAL(14,2), cantidad * precio_unitario)) PERSISTED,
    CONSTRAINT pk_detalle_venta PRIMARY KEY (id_detalle_venta),
    CONSTRAINT uq_detalle_venta_producto UNIQUE (id_venta,id_producto),
    CONSTRAINT chk_detalle_venta_cantidad CHECK (cantidad > 0),
    CONSTRAINT chk_detalle_venta_precio CHECK (precio_unitario >= 0),
    CONSTRAINT fk_detalle_venta_venta FOREIGN KEY (id_venta)
        REFERENCES tbl.venta(id_venta) ON DELETE CASCADE,
    CONSTRAINT fk_detalle_venta_producto FOREIGN KEY (id_producto)
        REFERENCES tbl.producto(id_producto)
);
GO

/* =========================== TRIGGERS DE STOCK ========================= */
CREATE TRIGGER tbl.tr_stock_detalle_compra
ON tbl.detalle_compra
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    ;WITH movimientos AS (
        SELECT id_producto, SUM(cantidad) variacion FROM inserted GROUP BY id_producto
        UNION ALL
        SELECT id_producto, -SUM(cantidad) FROM deleted GROUP BY id_producto
    ), cambios AS (
        SELECT id_producto, SUM(variacion) variacion FROM movimientos GROUP BY id_producto
    )
    UPDATE p SET stock = p.stock + c.variacion
    FROM tbl.producto p INNER JOIN cambios c ON c.id_producto=p.id_producto;

    IF EXISTS (SELECT 1 FROM tbl.producto WHERE stock < 0)
        THROW 50001, 'La modificación de la compra dejaría stock negativo.', 1;
END;
GO

CREATE TRIGGER tbl.tr_stock_detalle_venta
ON tbl.detalle_venta
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    ;WITH movimientos AS (
        SELECT id_producto, -SUM(cantidad) variacion FROM inserted GROUP BY id_producto
        UNION ALL
        SELECT id_producto, SUM(cantidad) FROM deleted GROUP BY id_producto
    ), cambios AS (
        SELECT id_producto, SUM(variacion) variacion FROM movimientos GROUP BY id_producto
    )
    UPDATE p WITH (UPDLOCK,HOLDLOCK) SET stock = p.stock + c.variacion
    FROM tbl.producto p INNER JOIN cambios c ON c.id_producto=p.id_producto;

    IF EXISTS (SELECT 1 FROM tbl.producto WHERE stock < 0)
        THROW 50002, 'Stock insuficiente para registrar la venta.', 1;
END;
GO

/* =========================== TRIGGERS DE TOTALES ======================= */
CREATE TRIGGER tbl.tr_total_detalle_compra
ON tbl.detalle_compra
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    ;WITH afectados AS (
        SELECT id_compra FROM inserted UNION SELECT id_compra FROM deleted
    )
    UPDATE c SET total=ISNULL(x.total,0)
    FROM tbl.compra c
    INNER JOIN afectados a ON a.id_compra=c.id_compra
    OUTER APPLY (SELECT SUM(subtotal) total FROM tbl.detalle_compra d WHERE d.id_compra=c.id_compra) x;
END;
GO

CREATE TRIGGER tbl.tr_total_detalle_venta
ON tbl.detalle_venta
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    ;WITH afectados AS (
        SELECT id_venta FROM inserted UNION SELECT id_venta FROM deleted
    )
    UPDATE v SET total=ISNULL(x.total,0)
    FROM tbl.venta v
    INNER JOIN afectados a ON a.id_venta=v.id_venta
    OUTER APPLY (SELECT SUM(subtotal) total FROM tbl.detalle_venta d WHERE d.id_venta=v.id_venta) x;
END;
GO

/* ================================ ÍNDICES =============================== */
CREATE INDEX ix_producto_nombre ON tbl.producto(nombre);
CREATE INDEX ix_producto_categoria ON tbl.producto(id_categoria,estado);
CREATE INDEX ix_empleado_nombre ON tbl.empleado(nombre);
CREATE INDEX ix_cliente_nombre ON tbl.cliente(nombre);
CREATE INDEX ix_proveedor_razon ON tbl.proveedor(razon_social);
CREATE INDEX ix_compra_fecha ON tbl.compra(fecha);
CREATE INDEX ix_venta_fecha_empleado ON tbl.venta(fecha,id_empleado);
GO

/* ============================= DATOS INICIALES ========================= */
INSERT INTO tbl.rol(nombre,descripcion) VALUES
('ADMINISTRADOR','Acceso total al panel administrativo.'),
('AUXILIAR_COMPRAS','Registra proveedores y compras.'),
('VENDEDOR','Registra clientes y ventas.'),
('ENCARGADO_INVENTARIO','Consulta productos y existencias.');
GO

/* Las credenciales de demostración se almacenan como SHA-256.
   Usuario administrador: admin@cialmaseg.com / Admin123* */
INSERT INTO tbl.usuario(id_rol,nombre,correo,clave_hash,estado) VALUES
(1,'Administrador CI Almaseg','admin@cialmaseg.com',LOWER(CONVERT(VARCHAR(64),HASHBYTES('SHA2_256',N'Admin123*'),2)),1),
(2,'Auxiliar de Compras','compras@cialmaseg.com',LOWER(CONVERT(VARCHAR(64),HASHBYTES('SHA2_256',N'Compras123*'),2)),1),
(3,'Laura Gómez','laura.gomez@cialmaseg.com',LOWER(CONVERT(VARCHAR(64),HASHBYTES('SHA2_256',N'Ventas123*'),2)),1),
(3,'Carlos Ramírez','carlos.ramirez@cialmaseg.com',LOWER(CONVERT(VARCHAR(64),HASHBYTES('SHA2_256',N'Ventas123*'),2)),1),
(3,'Andrea López','andrea.lopez@cialmaseg.com',LOWER(CONVERT(VARCHAR(64),HASHBYTES('SHA2_256',N'Ventas123*'),2)),1),
(4,'Encargado de Inventario','inventario@cialmaseg.com',LOWER(CONVERT(VARCHAR(64),HASHBYTES('SHA2_256',N'Inventario123*'),2)),1);
GO

INSERT INTO tbl.empleado
(id_usuario,tipo_documento,numero_documento,nombre,telefono,correo,cargo,estado)
VALUES
(1,'CEDULA','1032444001','Administrador CI Almaseg','3005550101','admin@cialmaseg.com','ADMINISTRADOR',1),
(2,'CEDULA','1032444002','Auxiliar de Compras','3005550102','compras@cialmaseg.com','AUXILIAR_COMPRAS',1),
(3,'CEDULA','1032444003','Laura Gómez','3005550103','laura.gomez@cialmaseg.com','VENDEDOR',1),
(4,'CEDULA','1032444004','Carlos Ramírez','3005550104','carlos.ramirez@cialmaseg.com','VENDEDOR',1),
(5,'CEDULA','1032444005','Andrea López','3005550105','andrea.lopez@cialmaseg.com','VENDEDOR',1),
(6,'CEDULA','1032444006','Encargado de Inventario','3005550106','inventario@cialmaseg.com','ENCARGADO_INVENTARIO',1);
GO

INSERT INTO tbl.cliente(tipo_documento,numero_documento,nombre,telefono,direccion,ciudad,estado) VALUES
('NIT','901345678-2','Constructora El Poblado S.A.S.','6044441200','Carrera 43A # 10-35','Medellín',1),
('NIT','900876543-1','Reparaciones Envigado S.A.S.','6043321177','Calle 37 Sur # 25-18','Envigado',1),
('CEDULA','1032456789','Cliente mostrador 001','3005550148','Carrera 40 # 38 Sur-20','Envigado',1),
('NIT','901112233-4','Servicios Técnicos del Sur S.A.S.','3155559080','Calle 49 Sur # 43A-12','Sabaneta',1),
('CEDULA','1019001001','Julián Torres','3015550188','Calle 32 # 42-10','Medellín',1),
('NIT','901445566-7','Obras Menores del Aburrá S.A.S.','6045550140','Carrera 48 # 18 Sur-40','Itagüí',1);
GO

INSERT INTO tbl.categoria(nombre,descripcion,estado) VALUES
('Herramientas manuales','Herramientas de uso manual para obra y mantenimiento.',1),
('Herramientas eléctricas','Equipos eléctricos para perforación, corte y reparación.',1),
('Tornillería y fijaciones','Tornillos, chazos, pernos, tuercas y elementos de fijación.',1),
('Pinturas','Pinturas, esmaltes, rodillos y accesorios.',1),
('Material eléctrico','Cables, cintas, tomacorrientes e interruptores.',1),
('Plomería','Tubería, accesorios y soluciones hidráulicas.',1),
('Construcción','Cemento y materiales básicos para obra.',1),
('Seguridad industrial','Elementos de protección personal.',1);
GO

/* El precio de venta no se inserta: SQL Server lo calcula. */
INSERT INTO tbl.producto
(id_categoria,codigo,nombre,descripcion,precio_compra,porcentaje_ganancia,stock,stock_minimo,estado)
VALUES
(1,'FER-001','Martillo de uña 16 oz','Martillo con mango antideslizante.',28000,50,0,5,1),
(1,'FER-002','Destornillador plano 6 pulgadas','Destornillador de acero con mango aislado.',9500,57.89,0,10,1),
(2,'FER-003','Taladro percutor 1/2 pulgada','Taladro percutor de velocidad variable.',180000,38.83,0,3,1),
(3,'FER-004','Tornillo drywall 1 pulgada','Tornillo negro para placa de yeso, unidad.',80,87.50,0,500,1),
(4,'FER-005','Pintura blanca 1 galón','Pintura vinilo blanca para interiores.',55000,41.82,0,8,1),
(5,'FER-006','Cinta aislante negra','Cinta PVC de 18 mm por 20 m.',4000,75,0,20,1),
(6,'FER-007','Tubo PVC 1/2 pulgada x 6 m','Tubo PVC de presión para agua fría.',18000,52.78,0,12,1),
(7,'FER-008','Cemento gris 50 kg','Cemento gris de uso general en saco.',29000,31.03,0,20,1),
(8,'FER-009','Guantes de carnaza','Guantes de protección para trabajo pesado.',11000,59.09,0,15,1),
(1,'FER-010','Llave ajustable 10 pulgadas','Llave cromada de apertura ajustable.',32000,50,0,5,1),
(5,'FER-011','Cable eléctrico calibre 12 - metro','Cable de cobre aislado, venta por metro.',2800,60.71,0,50,1),
(3,'FER-012','Chazo plástico 1/4 pulgada','Chazo plástico universal, unidad.',120,108.33,0,300,1);
GO

INSERT INTO tbl.proveedor(nit,razon_social,telefono,correo,direccion,ciudad,estado) VALUES
('900456789-1','Distribuciones Ferreteras Antioquia S.A.S.','6044442233','ventas@dfa.com.co','Carrera 52 # 12-45','Medellín',1),
('901223344-5','Suministros Eléctricos del Valle S.A.S.','6025554411','pedidos@sev.com.co','Calle 32 # 18-60','Cali',1),
('900778899-3','Pinturas y Acabados Medellín S.A.S.','6043229080','comercial@pintumed.com','Carrera 65 # 48-20','Medellín',1),
('901556677-8','PVC y Construcción Colombiana S.A.S.','6017451200','ventas@pvccol.com','Avenida Industrial # 80-25','Bogotá',1);
GO

/* Compras iniciales que generan las existencias. */
INSERT INTO tbl.compra(id_proveedor,id_empleado,fecha,estado,observacion) VALUES
(1,2,'2026-01-05T09:00:00','RECIBIDA','Compra inicial de herramientas y fijaciones.'),
(2,2,'2026-01-07T10:30:00','RECIBIDA','Abastecimiento de material eléctrico.'),
(3,2,'2026-01-09T14:00:00','RECIBIDA','Compra de pinturas y protección industrial.'),
(4,2,'2026-01-11T08:45:00','RECIBIDA','Material de plomería y construcción.');
GO

INSERT INTO tbl.detalle_compra(id_compra,id_producto,cantidad,costo_unitario) VALUES
(1,1,80,28000),(1,2,120,9500),(1,3,35,180000),(1,4,5000,80),(1,10,50,32000),(1,12,4000,120),
(2,6,250,4000),(2,11,1500,2800),
(3,5,100,55000),(3,9,180,11000),
(4,7,150,18000),(4,8,300,29000);
GO

/* Ventas distribuidas de enero a octubre de 2026.
   Empleados 3, 4 y 5 son vendedores. */
INSERT INTO tbl.venta(id_cliente,id_empleado,fecha,estado,observacion) VALUES
(1,3,'2026-01-15T10:00:00','COMPLETADA','Venta enero - Laura.'),
(2,4,'2026-01-23T15:00:00','COMPLETADA','Venta enero - Carlos.'),
(3,5,'2026-02-08T11:20:00','COMPLETADA','Venta febrero - Andrea.'),
(4,3,'2026-02-19T14:35:00','COMPLETADA','Venta febrero - Laura.'),
(5,4,'2026-03-05T09:10:00','COMPLETADA','Venta marzo - Carlos.'),
(6,5,'2026-03-21T16:20:00','COMPLETADA','Venta marzo - Andrea.'),
(1,3,'2026-04-11T08:40:00','COMPLETADA','Venta abril - Laura.'),
(2,4,'2026-05-07T13:20:00','COMPLETADA','Venta mayo - Carlos.'),
(3,5,'2026-06-14T10:15:00','COMPLETADA','Venta junio - Andrea.'),
(4,3,'2026-07-09T15:45:00','COMPLETADA','Venta julio - Laura.'),
(5,4,'2026-08-17T11:25:00','COMPLETADA','Venta agosto - Carlos.'),
(6,5,'2026-09-04T09:50:00','COMPLETADA','Venta septiembre - Andrea.'),
(1,3,'2026-10-10T12:30:00','COMPLETADA','Venta octubre - Laura.'),
(2,4,'2026-10-22T16:00:00','COMPLETADA','Venta octubre - Carlos.');
GO

/* Los precios unitarios se toman del precio calculado de cada producto. */
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 1,1,3,precio_venta FROM tbl.producto WHERE id_producto=1;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 1,8,20,precio_venta FROM tbl.producto WHERE id_producto=8;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 2,6,12,precio_venta FROM tbl.producto WHERE id_producto=6;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 2,11,100,precio_venta FROM tbl.producto WHERE id_producto=11;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 3,10,2,precio_venta FROM tbl.producto WHERE id_producto=10;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 3,9,4,precio_venta FROM tbl.producto WHERE id_producto=9;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 4,5,8,precio_venta FROM tbl.producto WHERE id_producto=5;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 4,4,500,precio_venta FROM tbl.producto WHERE id_producto=4;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 5,3,2,precio_venta FROM tbl.producto WHERE id_producto=3;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 5,2,10,precio_venta FROM tbl.producto WHERE id_producto=2;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 6,7,12,precio_venta FROM tbl.producto WHERE id_producto=7;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 6,12,300,precio_venta FROM tbl.producto WHERE id_producto=12;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 7,8,30,precio_venta FROM tbl.producto WHERE id_producto=8;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 7,9,10,precio_venta FROM tbl.producto WHERE id_producto=9;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 8,1,5,precio_venta FROM tbl.producto WHERE id_producto=1;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 8,6,30,precio_venta FROM tbl.producto WHERE id_producto=6;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 9,5,10,precio_venta FROM tbl.producto WHERE id_producto=5;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 9,11,150,precio_venta FROM tbl.producto WHERE id_producto=11;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 10,3,3,precio_venta FROM tbl.producto WHERE id_producto=3;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 10,10,5,precio_venta FROM tbl.producto WHERE id_producto=10;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 11,7,20,precio_venta FROM tbl.producto WHERE id_producto=7;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 11,4,600,precio_venta FROM tbl.producto WHERE id_producto=4;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 12,8,40,precio_venta FROM tbl.producto WHERE id_producto=8;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 12,2,15,precio_venta FROM tbl.producto WHERE id_producto=2;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 13,1,8,precio_venta FROM tbl.producto WHERE id_producto=1;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 13,9,20,precio_venta FROM tbl.producto WHERE id_producto=9;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 14,6,40,precio_venta FROM tbl.producto WHERE id_producto=6;
INSERT INTO tbl.detalle_venta(id_venta,id_producto,cantidad,precio_unitario)
SELECT 14,11,200,precio_venta FROM tbl.producto WHERE id_producto=11;
GO

/* ================================ VISTAS ================================ */
CREATE VIEW tbl.vw_catalogo_productos
AS
SELECT p.id_producto,p.codigo,p.nombre,c.nombre categoria,p.descripcion,
       p.precio_compra,p.porcentaje_ganancia,p.precio_venta,
       p.stock,p.stock_minimo,
       CASE WHEN p.stock=0 THEN 'AGOTADO'
            WHEN p.stock<=p.stock_minimo THEN 'STOCK BAJO'
            ELSE 'DISPONIBLE' END disponibilidad
FROM tbl.producto p
INNER JOIN tbl.categoria c ON c.id_categoria=p.id_categoria
WHERE p.estado=1 AND c.estado=1;
GO

CREATE VIEW tbl.vw_ventas_por_mes
AS
SELECT YEAR(fecha) anio,MONTH(fecha) numero_mes,
       DATENAME(MONTH,fecha) mes,
       COUNT(*) cantidad_ventas,SUM(total) total_vendido
FROM tbl.venta
WHERE estado='COMPLETADA'
GROUP BY YEAR(fecha),MONTH(fecha),DATENAME(MONTH,fecha);
GO

CREATE VIEW tbl.vw_ventas_por_empleado
AS
SELECT e.id_empleado,e.nombre,e.cargo,
       COUNT(v.id_venta) cantidad_ventas,
       ISNULL(SUM(v.total),0) total_vendido
FROM tbl.empleado e
LEFT JOIN tbl.venta v ON v.id_empleado=e.id_empleado AND v.estado='COMPLETADA'
WHERE e.cargo='VENDEDOR'
GROUP BY e.id_empleado,e.nombre,e.cargo;
GO

/* ========================== CONSULTAS DE PRUEBA ======================== */
PRINT '=== USUARIOS CREADOS (CLAVES SHA-256) ===';
SELECT u.correo,u.clave_hash AS hash_clave,r.nombre rol
FROM tbl.usuario u INNER JOIN tbl.rol r ON r.id_rol=u.id_rol;

PRINT '=== PRODUCTOS Y PRECIOS CALCULADOS ===';
SELECT codigo,nombre,precio_compra,porcentaje_ganancia,precio_venta,stock,stock_minimo
FROM tbl.producto ORDER BY codigo;

PRINT '=== VENTAS POR MES PARA chtVentasMes ===';
SELECT * FROM tbl.vw_ventas_por_mes ORDER BY anio,numero_mes;

PRINT '=== VENTAS POR EMPLEADO PARA chtVentasEmpleado ===';
SELECT * FROM tbl.vw_ventas_por_empleado ORDER BY total_vendido DESC;

PRINT '=== VENTAS CON EMPLEADO RESPONSABLE ===';
SELECT v.id_venta,v.fecha,c.nombre cliente,e.nombre empleado,v.total,v.estado
FROM tbl.venta v
INNER JOIN tbl.cliente c ON c.id_cliente=v.id_cliente
INNER JOIN tbl.empleado e ON e.id_empleado=v.id_empleado
ORDER BY v.fecha;

PRINT '=== 11 TABLAS CREADAS ===';
SELECT SCHEMA_NAME(schema_id) esquema,name tabla
FROM sys.tables WHERE SCHEMA_NAME(schema_id)='tbl' ORDER BY name;
GO

PRINT 'Base [Ci.Almaseg.Ferreteria.Final] creada correctamente con datos.';
GO

/* =====================================================================
   Migración 001: convertir claves existentes a SHA-256
   =====================================================================
   Ejecutar una sola vez sobre bases creadas con el script anterior.
   El script de datos principal ya crea las claves con hash.

   Nota: SHA-256 sin sal es una mejora frente a texto plano, pero para
   producción se recomienda un esquema con sal (PBKDF2, bcrypt o similar).
   ===================================================================== */

USE [Ci.Almaseg.Ferreteria.Final];
GO

UPDATE tbl.usuario
SET clave_hash = LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', CAST(clave_hash AS NVARCHAR(255))), 2))
WHERE LEN(clave_hash) <> 64;
GO

SELECT correo, rol = (SELECT nombre FROM tbl.rol WHERE tbl.rol.id_rol = tbl.usuario.id_rol)
FROM tbl.usuario
ORDER BY id_usuario;
GO

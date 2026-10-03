-- ============================================================================
-- Migración: Nombre estructurado en especialistas para RDA-Paciente (Practitioner)
-- Confirmado contra el validador real de MinSalud: RETHUS valida el
-- Practitioner por apellido paterno/materno y nombres por separado, no un
-- solo campo de texto libre.
--
-- No se toca ni se borra la columna existente 'nombre': se agregan 4
-- columnas nuevas, opcionales (NULL permitido). El código VB.NET
-- (RDABundleBuilder.ConstruirPractitioner) ya usa estas columnas si tienen
-- datos, y cae de vuelta al campo 'nombre' de texto libre si están vacías.
-- Sintaxis MySQL/MariaDB.
-- ============================================================================

ALTER TABLE especialistas
    ADD COLUMN primer_nombre    VARCHAR(60) NULL COMMENT 'Requerido por PractitionerRDA (RETHUS valida por separado)',
    ADD COLUMN segundo_nombre   VARCHAR(60) NULL,
    ADD COLUMN primer_apellido  VARCHAR(60) NULL COMMENT 'Apellido paterno - va en ExtensionFathersFamilyName',
    ADD COLUMN segundo_apellido VARCHAR(60) NULL COMMENT 'Apellido materno - va en ExtensionMothersFamilyName';

-- Nota: mientras no se llenen estas columnas para un especialista, el envío
-- de RDA sigue funcionando (usa el campo 'nombre' de texto libre como
-- fallback), pero es más seguro llenarlas para evitar advertencias/errores
-- de "el apellido no coincide" al validar contra RETHUS.

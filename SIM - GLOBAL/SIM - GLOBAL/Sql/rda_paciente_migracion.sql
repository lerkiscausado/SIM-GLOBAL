-- ============================================================================
-- Migración: Interoperabilidad RDA-Paciente (MinSalud) - base
-- Ejecutar contra la base de datos de SIM antes de usar el envío de RDA.
-- Sintaxis MySQL/MariaDB (motor usado por el resto del esquema del SIM).
-- ============================================================================

-- 1. Datos del prestador requeridos para armar la Organization del Bundle RDA
--    (Código de habilitación REPS y NIT), agregados a la tabla de config ya
--    existente para la interoperabilidad.
ALTER TABLE config_interop_api
    ADD COLUMN codigo_prestador_reps VARCHAR(50) NULL
        COMMENT 'Código de habilitación del prestador (REPS) - requerido para RDA',
    ADD COLUMN nit_prestador VARCHAR(30) NULL
        COMMENT 'NIT del prestador SIN dígito de verificación (confirmado: $consultar-organizacion solo encuentra la organización con el NIT sin DV)';

-- 2. Auditoría de envíos de documentos RDA (uno o varios intentos por orden).
CREATE TABLE IF NOT EXISTS rda_envios (
    id              INT AUTO_INCREMENT PRIMARY KEY,
    id_orden        INT NOT NULL,
    tipo_documento  VARCHAR(30) NOT NULL DEFAULT 'RDA-PACIENTE',
    exitoso         TINYINT(1) NOT NULL,
    codigo_http     INT NULL,
    detalle         TEXT NULL,
    fecha_envio     DATETIME NOT NULL,
    INDEX idx_rda_envios_orden (id_orden),
    INDEX idx_rda_envios_fecha (fecha_envio)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Notas:
-- * Después de correr esta migración, ingresa a "Interoperabilidad RDA" (frmRDA) y
--   completa "Código Prestador (REPS)" = 1300102098 y "NIT Prestador" = 900270916
--   (sin dígito de verificación) para Gastrocaribe SAS, ya confirmados contra
--   el sandbox real de MinSalud.
-- * rda_envios permite auditar éxitos/fallas del envío automático al guardar la
--   historia clínica; es informativa y su ausencia no rompe el envío (el
--   código la usa de forma defensiva, con try/catch silencioso).

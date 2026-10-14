-- ============================================================================
-- Migración: Tablas base de configuración de Interoperabilidad RDA
--   config_interop_api / interop_token_cache
--
-- Corrige el error:
--   Table 'config_interop_api' doesn't exist
--
-- Causa: rda_paciente_migracion.sql solo hace ALTER TABLE config_interop_api
-- (asume que la tabla ya existe, porque en la base de datos original de
-- Gastrocaribe se había creado manualmente, fuera de cualquier migración
-- comiteada). En una base de datos nueva/distinta (como la usada para
-- probar la rama dr-marcelo-rda-prueba) esa tabla nunca se crea, y todo el
-- módulo de interoperabilidad (frmRDA, DRDA, DRDAPaciente, DRDAConsultaExterna)
-- falla al intentar leerla.
--
-- Esta migración es segura de correr en CUALQUIER base de datos del SIM,
-- sin importar su estado:
--   * Si config_interop_api / interop_token_cache NO existen (caso del
--     error de arriba), las crea completas, con columnas incluidas.
--   * Si YA existen (ej. la base de datos real de Gastrocaribe), no hace
--     nada (CREATE TABLE IF NOT EXISTS), y el chequeo de columnas de abajo
--     tampoco falla si codigo_prestador_reps/nit_prestador ya estaban.
--   * No usa "ADD COLUMN IF NOT EXISTS": aunque el estándar MySQL 8.0 lo
--     soporta en teoría, el servidor real contra el que se probó esto
--     (mysqld 8.0.46 de Ubuntu 24.04, vía ODBC/HeidiSQL) lo rechazó con
--     error de sintaxis 1064. En su lugar se usa SQL dinámico con
--     INFORMATION_SCHEMA, que funciona en cualquier versión de MySQL o
--     MariaDB razonablemente reciente.
--
-- Ejecútala ANTES de (o en cualquier orden respecto a) rda_paciente_migracion.sql:
-- ambas son idempotentes entre sí.
-- ============================================================================

CREATE TABLE IF NOT EXISTS config_interop_api (
    id                      INT AUTO_INCREMENT PRIMARY KEY,
    ambiente                VARCHAR(20)  NOT NULL DEFAULT 'SANDBOX'
        COMMENT 'Valores: SANDBOX o PRODUCCION',
    tenant_id               VARCHAR(100) NULL
        COMMENT 'Tenant ID de Azure AD provisto por MinSalud',
    client_id               VARCHAR(100) NULL,
    client_secret           VARCHAR(255) NULL,
    subscription_key        VARCHAR(100) NULL
        COMMENT 'Ocp-Apim-Subscription-Key',
    url_auth_server         VARCHAR(255) NULL,
    url_base_api            VARCHAR(255) NULL
        COMMENT 'URL base para el envío de los Bundles FHIR RDA',
    codigo_prestador_reps   VARCHAR(50)  NULL
        COMMENT 'Código de habilitación REPS del prestador - requerido para RDA',
    nit_prestador           VARCHAR(30)  NULL
        COMMENT 'NIT del prestador SIN dígito de verificación',
    estado                  TINYINT(1)   NOT NULL DEFAULT 1,
    fecha_registro          DATETIME     NULL,
    fecha_actualizacion     DATETIME     NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4
COMMENT='Credenciales/config de conexión a la API de interoperabilidad RDA de MinSalud (frmRDA)';

-- Por si la tabla ya existía de antes (otra base de datos) sin estas 2
-- columnas, pero sin haber corrido rda_paciente_migracion.sql todavía.
-- (SQL dinámico porque "ADD COLUMN IF NOT EXISTS" no corrió en el servidor
-- real contra el que se probó esto; ver nota arriba.)
SET @tiene_codigo_prestador_reps := (
    SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'config_interop_api' AND COLUMN_NAME = 'codigo_prestador_reps'
);
SET @sql_codigo_prestador_reps := IF(@tiene_codigo_prestador_reps = 0,
    'ALTER TABLE config_interop_api ADD COLUMN codigo_prestador_reps VARCHAR(50) NULL COMMENT ''Codigo de habilitacion del prestador (REPS) - requerido para RDA''',
    'SELECT 1');
PREPARE stmt_codigo_prestador_reps FROM @sql_codigo_prestador_reps;
EXECUTE stmt_codigo_prestador_reps;
DEALLOCATE PREPARE stmt_codigo_prestador_reps;

SET @tiene_nit_prestador := (
    SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'config_interop_api' AND COLUMN_NAME = 'nit_prestador'
);
SET @sql_nit_prestador := IF(@tiene_nit_prestador = 0,
    'ALTER TABLE config_interop_api ADD COLUMN nit_prestador VARCHAR(30) NULL COMMENT ''NIT del prestador SIN digito de verificacion''',
    'SELECT 1');
PREPARE stmt_nit_prestador FROM @sql_nit_prestador;
EXECUTE stmt_nit_prestador;
DEALLOCATE PREPARE stmt_nit_prestador;


CREATE TABLE IF NOT EXISTS interop_token_cache (
    id                  INT AUTO_INCREMENT PRIMARY KEY,
    config_id           INT NOT NULL,
    access_token        TEXT NULL,
    token_type          VARCHAR(20) NULL DEFAULT 'Bearer',
    expires_in          INT NULL,
    fecha_expiracion    DATETIME NULL,
    fecha_captura       DATETIME NULL,
    INDEX idx_interop_token_cache_config (config_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4
COMMENT='Cache del token OAuth2 obtenido de Azure AD para no autenticar en cada envío RDA (DRDA.TraerToken)';

-- ============================================================================
-- Después de correr esto, entra a "Interoperabilidad RDA" (frmRDA) en el SIM
-- y completa las credenciales reales (Tenant ID, Client ID, Client Secret,
-- Subscription Key, URLs, Código Prestador REPS y NIT) para esta base de
-- datos/cliente. Sin ese registro guardado, el envío de RDA seguirá
-- fallando (con un mensaje distinto: "Sin configuración de interoperabilidad
-- RDA"), pero ya no por falta de la tabla.
-- ============================================================================

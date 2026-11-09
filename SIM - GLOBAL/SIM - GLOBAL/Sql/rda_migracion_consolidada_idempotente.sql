-- ============================================================================
-- Migración consolidada RDA + Res. 3100 (IDEMPOTENTE)
-- Reúne, en el orden del runbook:
--   rda_config_interop_api_base, rda_paciente_migracion,
--   rda_usuarios_campos_obligatorios, rda_especialistas_nombre_estructurado,
--   rda_empresa_codigo_prestador, rda_envios_composition_id,
--   resolucion3100_inalterabilidad_historia
-- Cada columna / índice se agrega solo si no existe (INFORMATION_SCHEMA +
-- SQL dinámico), así que se puede correr varias veces sin error.
-- No borra ni modifica datos existentes.
-- ============================================================================

DROP PROCEDURE IF EXISTS rda_add_col;
DELIMITER $$
CREATE PROCEDURE rda_add_col(IN p_tabla VARCHAR(64), IN p_col VARCHAR(64), IN p_def TEXT)
BEGIN
    IF (SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS
        WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = p_tabla AND COLUMN_NAME = p_col) = 0 THEN
        SET @rda_sql = CONCAT('ALTER TABLE `', p_tabla, '` ADD COLUMN `', p_col, '` ', p_def);
        PREPARE s FROM @rda_sql; EXECUTE s; DEALLOCATE PREPARE s;
    END IF;
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS rda_add_idx;
DELIMITER $$
CREATE PROCEDURE rda_add_idx(IN p_tabla VARCHAR(64), IN p_idx VARCHAR(64), IN p_cols VARCHAR(255))
BEGIN
    IF (SELECT COUNT(*) FROM INFORMATION_SCHEMA.STATISTICS
        WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = p_tabla AND INDEX_NAME = p_idx) = 0 THEN
        SET @rda_sql = CONCAT('ALTER TABLE `', p_tabla, '` ADD INDEX `', p_idx, '` (', p_cols, ')');
        PREPARE s FROM @rda_sql; EXECUTE s; DEALLOCATE PREPARE s;
    END IF;
END$$
DELIMITER ;

-- 1) config_interop_api / interop_token_cache --------------------------------
CREATE TABLE IF NOT EXISTS config_interop_api (
    id                      INT AUTO_INCREMENT PRIMARY KEY,
    ambiente                VARCHAR(20)  NOT NULL DEFAULT 'SANDBOX' COMMENT 'Valores: SANDBOX o PRODUCCION',
    tenant_id               VARCHAR(100) NULL COMMENT 'Tenant ID de Azure AD provisto por MinSalud',
    client_id               VARCHAR(100) NULL,
    client_secret           VARCHAR(255) NULL,
    subscription_key        VARCHAR(100) NULL COMMENT 'Ocp-Apim-Subscription-Key',
    url_auth_server         VARCHAR(255) NULL,
    url_base_api            VARCHAR(255) NULL COMMENT 'URL base para el envío de los Bundles FHIR RDA',
    codigo_prestador_reps   VARCHAR(50)  NULL COMMENT 'Código de habilitación REPS del prestador - requerido para RDA',
    nit_prestador           VARCHAR(30)  NULL COMMENT 'NIT del prestador SIN dígito de verificación',
    estado                  TINYINT(1)   NOT NULL DEFAULT 1,
    fecha_registro          DATETIME     NULL,
    fecha_actualizacion     DATETIME     NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4
COMMENT='Credenciales/config de conexión a la API de interoperabilidad RDA de MinSalud (frmRDA)';

CALL rda_add_col('config_interop_api', 'codigo_prestador_reps', 'VARCHAR(50) NULL COMMENT ''Codigo de habilitacion del prestador (REPS) - requerido para RDA''');
CALL rda_add_col('config_interop_api', 'nit_prestador',         'VARCHAR(30) NULL COMMENT ''NIT del prestador SIN digito de verificacion''');

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
COMMENT='Cache del token OAuth2 obtenido de Azure AD (DRDA.TraerToken)';

-- 2) rda_envios ---------------------------------------------------------------
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

-- 3) usuarios: campos obligatorios PatientRDA ---------------------------------
CALL rda_add_col('usuarios', 'codigo_pais_nacimiento',  'VARCHAR(5) NULL COMMENT ''ISO 3166 numerico. Colombia = 170. ExtensionPatientNationality (OBLIGATORIO)''');
CALL rda_add_col('usuarios', 'codigo_etnia',            'VARCHAR(5) NULL COMMENT ''ColombianEthnicGroup. ExtensionPatientEthnicity (OBLIGATORIO)''');
CALL rda_add_col('usuarios', 'codigo_discapacidad',     'VARCHAR(5) NULL COMMENT ''ColombianDisabilityClassification. ExtensionPatientDisability (OBLIGATORIO). 08 = Sin discapacidad''');
CALL rda_add_col('usuarios', 'codigo_identidad_genero', 'VARCHAR(5) NULL COMMENT ''ColombianGenderIdentity (opcional)''');
CALL rda_add_col('usuarios', 'hora_nacimiento',         'TIME NULL COMMENT ''ExtensionBirthTime (opcional)''');
CALL rda_add_col('usuarios', 'nombre_municipio',        'VARCHAR(120) NULL COMMENT ''Texto del municipio (opcional)''');

-- 4) especialistas: nombre estructurado (RETHUS) ------------------------------
CALL rda_add_col('especialistas', 'primer_nombre',    'VARCHAR(60) NULL COMMENT ''Requerido por PractitionerRDA (RETHUS valida por separado)''');
CALL rda_add_col('especialistas', 'segundo_nombre',   'VARCHAR(60) NULL');
CALL rda_add_col('especialistas', 'primer_apellido',  'VARCHAR(60) NULL COMMENT ''Apellido paterno - ExtensionFathersFamilyName''');
CALL rda_add_col('especialistas', 'segundo_apellido', 'VARCHAR(60) NULL COMMENT ''Apellido materno - ExtensionMothersFamilyName''');

-- 5) empresa: código de habilitación REPS -------------------------------------
CALL rda_add_col('empresa', 'codigo_prestador', 'VARCHAR(50) NULL COMMENT ''Codigo de habilitacion REPS del prestador''');

-- 6) rda_envios.composition_id ------------------------------------------------
CALL rda_add_col('rda_envios', 'composition_id', 'VARCHAR(100) NULL COMMENT ''Id de Composition asignado por MinSalud (GET /Composition/{id}/$document)''');
CALL rda_add_idx('rda_envios', 'idx_rda_envios_composition_id', 'composition_id');

-- 7) Resolución 3100: inalterabilidad de historia_clinica ---------------------
CALL rda_add_col('historia_clinica', 'firmada',       'TINYINT(1) NOT NULL DEFAULT 0 COMMENT ''Res. 3100: 1 = firmada, solo adendas''');
CALL rda_add_col('historia_clinica', 'fecha_firma',   'DATETIME NULL COMMENT ''Fecha/hora del servidor al firmar''');
CALL rda_add_col('historia_clinica', 'usuario_firma', 'INT NULL COMMENT ''Id del especialista/empleado que firmo''');
CALL rda_add_idx('historia_clinica', 'idx_historia_clinica_firmada', 'firmada');

CREATE TABLE IF NOT EXISTS historia_clinica_trazabilidad (
    id              INT AUTO_INCREMENT PRIMARY KEY,
    id_orden        INT NOT NULL,
    id_historia     INT NULL,
    id_usuario      INT NULL,
    accion          VARCHAR(30) NOT NULL COMMENT 'CREACION | ACTUALIZACION | FIRMA | INTENTO_BLOQUEADO | ADENDA',
    detalle         VARCHAR(500) NULL,
    fecha_hora      DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    INDEX idx_hc_trazabilidad_orden (id_orden),
    INDEX idx_hc_trazabilidad_fecha (fecha_hora)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4
COMMENT='Bitacora de inalterabilidad de historia_clinica';

CREATE TABLE IF NOT EXISTS historia_clinica_adendas (
    id              INT AUTO_INCREMENT PRIMARY KEY,
    id_orden        INT NOT NULL,
    id_historia     INT NOT NULL,
    id_usuario      INT NOT NULL,
    texto           TEXT NOT NULL,
    fecha_hora      DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    INDEX idx_hc_adendas_orden (id_orden),
    INDEX idx_hc_adendas_historia (id_historia)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4
COMMENT='Anotaciones posteriores a la firma';

-- Limpieza de los procedimientos auxiliares
DROP PROCEDURE IF EXISTS rda_add_col;
DROP PROCEDURE IF EXISTS rda_add_idx;

-- Verificación
SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_SCHEMA = DATABASE() AND (
   (TABLE_NAME='config_interop_api' AND COLUMN_NAME IN ('codigo_prestador_reps','nit_prestador'))
OR (TABLE_NAME='usuarios' AND COLUMN_NAME IN ('codigo_pais_nacimiento','codigo_etnia','codigo_discapacidad','codigo_identidad_genero','hora_nacimiento','nombre_municipio'))
OR (TABLE_NAME='especialistas' AND COLUMN_NAME IN ('primer_nombre','segundo_nombre','primer_apellido','segundo_apellido'))
OR (TABLE_NAME='empresa' AND COLUMN_NAME='codigo_prestador')
OR (TABLE_NAME='rda_envios' AND COLUMN_NAME='composition_id')
OR (TABLE_NAME='historia_clinica' AND COLUMN_NAME IN ('firmada','fecha_firma','usuario_firma'))
OR (TABLE_NAME IN ('interop_token_cache','historia_clinica_trazabilidad','historia_clinica_adendas') AND COLUMN_NAME='id'))
ORDER BY TABLE_NAME, COLUMN_NAME;

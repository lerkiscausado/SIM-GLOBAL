-- ============================================================================
-- GASTROLAP - INSTALACIÓN COMPLETA DE CAMBIOS EN BASE DE DATOS (RDA + Res. 3100)
-- Rama gastrolap de SIM-GLOBAL. Generado 2026-11-21. Probado en simdb-gastrolap-rda: 0 errores.
--
-- Ejecutar UNA vez sobre la base de datos del servidor de GASTROLAP:
--   SQLyog: seleccionar la base de datos -> pegar todo -> "Execute All Queries" (Ctrl+F9)
--   HeidiSQL: F9
-- ANTES: hacer un respaldo completo de la base de datos.
--
-- Es seguro correrlo más de una vez: cada tabla, columna e índice se crea solo si
-- no existe, y las actualizaciones de datos dejan el mismo resultado.
-- No borra datos. Las credenciales de MinSalud NO van aquí: se ingresan en el SIM
-- (Configuración -> Interoperabilidad).
--
-- Contenido:
--   PARTE 1. Estructura RDA + Res. 3100 (tablas y columnas nuevas)
--   PARTE 2. Código de habilitación REPS de GASTROLAP en la tabla empresa
--   PARTE 3. Configuración inicial de Interoperabilidad (sin credenciales)
--   PARTE 4. Descripciones oficiales CIE-10 de MinSalud (102 diagnósticos, con respaldo)
--   PARTE 5. Especialistas de GASTROLAP con nombres y documento (verificados en RETHUS)
--   PARTE 6. Verificación
-- ============================================================================

-- ============================================================================
-- PARTE 1. Estructura RDA + Res. 3100
-- ============================================================================
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

-- ============================================================================
-- PARTE 2. Código de habilitación REPS (sin sufijo de sede) de GASTROLAP
-- ============================================================================
UPDATE empresa SET codigo_prestador = '1300102449'
WHERE nombre LIKE '%GASTROLAP%' AND (codigo_prestador IS NULL OR codigo_prestador = '');

-- ============================================================================
-- PARTE 3. Configuración inicial de Interoperabilidad (solo si no existe ninguna).
-- Ambiente SANDBOX hasta que MinSalud entregue las credenciales de producción.
-- Tenant ID, Client ID, Client Secret y llave de suscripción se ingresan en el SIM.
-- ============================================================================
INSERT INTO config_interop_api (ambiente, url_auth_server, url_base_api, codigo_prestador_reps, nit_prestador, estado, fecha_registro)
SELECT 'SANDBOX',
       'https://login.microsoftonline.com/{{tenantid}}/oauth2/v2.0/token',
       'https://sandbox.ihcecol.gov.co/ihce',
       '1300102449', '900329923', 1, NOW()
FROM DUAL
WHERE NOT EXISTS (SELECT 1 FROM config_interop_api);

-- ============================================================================
-- PARTE 4. Descripciones oficiales CIE-10 (servicio de terminología de MinSalud).
-- MinSalud rechaza el RDA si la descripción del diagnóstico no es la oficial
-- (ej. K30X "DISPEPSIA" -> "DISPEPSIA FUNCIONAL"). Antes se guarda un respaldo de
-- las filas originales en diagnosticos_respaldo_rda (solo la primera vez).
-- Excluidos K580, K85X y M45X: el sandbox devuelve el título del capítulo.
-- ============================================================================
CREATE TABLE IF NOT EXISTS diagnosticos_respaldo_rda AS SELECT * FROM diagnosticos WHERE codigo_diagnostico IN ('A000','A009','A010','A029','B201','B24X','B980','C787','C810','C820','C827','C829','C838','C839','D411','D571','D691','D729','E102','E103','E106','E109','E112','E114','E116','E119','E126','E142','E149','E46X','E807','F009','F023','F419','F840','G473','G479','H055','I694','I982','J985','K227','K250','K251','K252','K253','K254','K257','K259','K260','K261','K263','K264','K267','K269','K270','K273','K274','K277','K280','K282','K289','K293','K30X','K409','K439','K449','K510','K514','K515','K603','K712','K713','K716','K717','K718','K746','K768','K778','K838','K915','M068','M239','M350','M795','N189','N202','N432','O219','T150','T180','T182','T543','T789','T815','V429','W337','W442','Y229','Z001','Z121','Z763');
START TRANSACTION;
UPDATE diagnosticos SET nombre_diagnostico='COLERA DEBIDO A VIBRIO CHOLERAE 01, BIOTIPO CHOLERAE' WHERE codigo_diagnostico='A000';
UPDATE diagnosticos SET nombre_diagnostico='COLERA, NO ESPECIFICADO' WHERE codigo_diagnostico='A009';
UPDATE diagnosticos SET nombre_diagnostico='FIEBRE TIFOIDEA' WHERE codigo_diagnostico='A010';
UPDATE diagnosticos SET nombre_diagnostico='INFECCION DEBIDA A SALMONELLA, NO ESPECIFICADA' WHERE codigo_diagnostico='A029';
UPDATE diagnosticos SET nombre_diagnostico='ENFERMEDAD POR VIH, RESULTANTE EN OTRAS INFECCIONES BACTERIANAS' WHERE codigo_diagnostico='B201';
UPDATE diagnosticos SET nombre_diagnostico='ENFERMEDAD POR VIRUS DE LA INMUNODEFICIENCIA HUMANA [VIH], SIN OTRA ESPECIFICACION' WHERE codigo_diagnostico='B24X';
UPDATE diagnosticos SET nombre_diagnostico='HELICOBACTER PYLORI [H.PYLORI] COMO LA CAUSA DE ENFERMEDADES CLASIFICADAS EN OTROS CAPITULOS' WHERE codigo_diagnostico='B980';
UPDATE diagnosticos SET nombre_diagnostico='TUMOR MALIGNO SECUNDARIO DEL HIGADO Y DE LOS CONDUCTOS BILIARES INTRAHEPATICOS' WHERE codigo_diagnostico='C787';
UPDATE diagnosticos SET nombre_diagnostico='LINFOMA DE HODGKIN CON PREDOMINIO LINFOCITICO NODULAR' WHERE codigo_diagnostico='C810';
UPDATE diagnosticos SET nombre_diagnostico='LINFOMA FOLICULAR GRADO I' WHERE codigo_diagnostico='C820';
UPDATE diagnosticos SET nombre_diagnostico='OTROS TIPOS ESPECIFICADOS DE LINFOMA FOLICULAR' WHERE codigo_diagnostico='C827';
UPDATE diagnosticos SET nombre_diagnostico='LINFOMA FOLICULAR, SIN OTRA ESPECIFICACION' WHERE codigo_diagnostico='C829';
UPDATE diagnosticos SET nombre_diagnostico='OTROS TIPOS ESPECIFICADOS DE LINFOMA NO FOLICULAR' WHERE codigo_diagnostico='C838';
UPDATE diagnosticos SET nombre_diagnostico='LINFOMA NO FOLICULAR (DIFUSO), SIN OTRA ESPECIFICACION' WHERE codigo_diagnostico='C839';
UPDATE diagnosticos SET nombre_diagnostico='TUMOR DE COMPORTAMIENTO INCIERTO O DESCONOCIDO DE LA PELVIS RENAL' WHERE codigo_diagnostico='D411';
UPDATE diagnosticos SET nombre_diagnostico='ANEMIA FALCIFORME  SIN CRISIS' WHERE codigo_diagnostico='D571';
UPDATE diagnosticos SET nombre_diagnostico='DEFECTO CUALITATIVOS DE LAS PLAQUETAS' WHERE codigo_diagnostico='D691';
UPDATE diagnosticos SET nombre_diagnostico='TRASTORNO DE LOS LEUCOCITOS, NO ESPECIFICADO' WHERE codigo_diagnostico='D729';
UPDATE diagnosticos SET nombre_diagnostico='DIABETES MELLITUS INSULINODEPENDIENTE, CON COMPLICACIONES RENALES' WHERE codigo_diagnostico='E102';
UPDATE diagnosticos SET nombre_diagnostico='DIABETES MELLITUS INSULINODEPENDIENTE, CON COMPLICACIONES OFTALMICAS' WHERE codigo_diagnostico='E103';
UPDATE diagnosticos SET nombre_diagnostico='DIABETES MELLITUS INSULINODEPENDIENTE, CON OTRAS COMPLICACIONES ESPECIFICADAS' WHERE codigo_diagnostico='E106';
UPDATE diagnosticos SET nombre_diagnostico='DIABETES MELLITUS INSULINODEPENDIENTE, SIN MENCION DE COMPLICACION' WHERE codigo_diagnostico='E109';
UPDATE diagnosticos SET nombre_diagnostico='DIABETES MELLITUS NO INSULINODEPENDIENTE, CON COMPLICACIONES RENALES' WHERE codigo_diagnostico='E112';
UPDATE diagnosticos SET nombre_diagnostico='DIABETES MELLITUS NO INSULINODEPENDIENTE, CON COMPLICACIONES NEUROLOGICAS' WHERE codigo_diagnostico='E114';
UPDATE diagnosticos SET nombre_diagnostico='DIABETES MELLITUS NO INSULINODEPENDIENTE, CON OTRAS COMPLICACIONES ESPECIFICADAS' WHERE codigo_diagnostico='E116';
UPDATE diagnosticos SET nombre_diagnostico='DIABETES MELLITUS NO INSULINODEPENDIENTE, SIN MENCION DE COMPLICACION' WHERE codigo_diagnostico='E119';
UPDATE diagnosticos SET nombre_diagnostico='DIABETES MELLITUS ASOCIADA CON DESNUTRICION, CON OTRAS COMPLICACIONES ESPECIFICADAS' WHERE codigo_diagnostico='E126';
UPDATE diagnosticos SET nombre_diagnostico='DIABETES MELLITUS NO ESPECIFICADA, CON COMPLICACIONES RENALES' WHERE codigo_diagnostico='E142';
UPDATE diagnosticos SET nombre_diagnostico='DIABETES MELLITUS NO ESPECIFICADA, SIN MENCION DE COMPLICACION' WHERE codigo_diagnostico='E149';
UPDATE diagnosticos SET nombre_diagnostico='DESNUTRICION PROTEICOCALORICA, NO ESPECIFICADA' WHERE codigo_diagnostico='E46X';
UPDATE diagnosticos SET nombre_diagnostico='TRASTORNO DEL METABOLISMO DE LA BILIRRUBINA, NO ESPECIFICADO' WHERE codigo_diagnostico='E807';
UPDATE diagnosticos SET nombre_diagnostico='DEMENCIA  EN LA ENFERMEDAD DE ALZHEIMER, NO ESPECIFICADA' WHERE codigo_diagnostico='F009';
UPDATE diagnosticos SET nombre_diagnostico='DEMENCIA  EN LA ENFERMEDAD DE PARKINSON' WHERE codigo_diagnostico='F023';
UPDATE diagnosticos SET nombre_diagnostico='TRASTORNO DE ANSIEDAD, NO ESPECIFICADO' WHERE codigo_diagnostico='F419';
UPDATE diagnosticos SET nombre_diagnostico='AUTISMO EN LA NINEZ' WHERE codigo_diagnostico='F840';
UPDATE diagnosticos SET nombre_diagnostico='APNEA DEL SUENO' WHERE codigo_diagnostico='G473';
UPDATE diagnosticos SET nombre_diagnostico='TRASTORNO DEL SUENO, NO ESPECIFICADO' WHERE codigo_diagnostico='G479';
UPDATE diagnosticos SET nombre_diagnostico='RETENCION DE CUERPO EXTRANO (ANTIGUO), CONSECUTIVA A HERIDA PENETRANTE DE LA ORBITA' WHERE codigo_diagnostico='H055';
UPDATE diagnosticos SET nombre_diagnostico='SECUELAS DE ACCIDENTE VASCULAR ENCEFALICO, NO ESPECIFICADO COMO HEMORRAGICO O ISQUEMICO' WHERE codigo_diagnostico='I694';
UPDATE diagnosticos SET nombre_diagnostico='VARICES ESOFAGICAS SIN HEMORRAGIA EN ENFERMEDADES CLASIFICADAS EN OTRA PARTE' WHERE codigo_diagnostico='I982';
UPDATE diagnosticos SET nombre_diagnostico='ENFERMEDADES DEL MEDIASTINO, NO CLASIFICADAS EN OTRA PARTE' WHERE codigo_diagnostico='J985';
UPDATE diagnosticos SET nombre_diagnostico='ESOFAGO DE BARRETT' WHERE codigo_diagnostico='K227';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA GASTRICA, AGUDA CON HEMORRAGIA' WHERE codigo_diagnostico='K250';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA GASTRICA, AGUDA CON PERFORACION' WHERE codigo_diagnostico='K251';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA GASTRICA, AGUDA CON HEMORRAGIA Y PERFORACION' WHERE codigo_diagnostico='K252';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA GASTRICA, AGUDA SIN HEMORRAGIA NI PERFORACION' WHERE codigo_diagnostico='K253';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA GASTRICA, CRONICA O NO ESPECIFICADA, CON HEMORRAGIA' WHERE codigo_diagnostico='K254';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA GASTRICA, CRONICA SIN HEMORRAGIA NI PERFORACION' WHERE codigo_diagnostico='K257';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA GASTRICA, NO ESPECIFICADA COMO AGUDA NI CRONICA, SIN HEMORRAGIA NI PERFORACION' WHERE codigo_diagnostico='K259';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA DUODENAL, AGUDA CON HEMORRAGIA' WHERE codigo_diagnostico='K260';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA DUODENAL, AGUDA CON PERFORACION' WHERE codigo_diagnostico='K261';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA DUODENAL, AGUDA SIN HEMORRAGIA NI PERFORACION' WHERE codigo_diagnostico='K263';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA DUODENAL, CRONICA O NO ESPECIFICADA, CON HEMORRAGIA' WHERE codigo_diagnostico='K264';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA DUODENAL, CRONICA SIN HEMORRAGIA NI PERFORACION' WHERE codigo_diagnostico='K267';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA DUODENAL, NO ESPECIFICADA COMO AGUDA NI CRONICA, SIN HEMORRAGIA NI PERFORACION' WHERE codigo_diagnostico='K269';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA PEPTICA, DE SITIO NO ESPECIFICADO, AGUDA CON HEMORRAGIA' WHERE codigo_diagnostico='K270';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA PEPTICA, DE SITIO NO ESPECIFICADO, AGUDA SIN HEMORRAGIA NI PERFORACION' WHERE codigo_diagnostico='K273';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA PEPTICA, DE SITIO NO ESPECIFICADO, CRONICA O NO ESPECIFICADA, CON HEMORRAGIA' WHERE codigo_diagnostico='K274';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA PEPTICA, DE SITIO NO ESPECIFICADO, CRONICA SIN  HEMORRAGIA NI PERFORACION' WHERE codigo_diagnostico='K277';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA GASTROYEYUNAL, AGUDA CON HEMORRAGIA' WHERE codigo_diagnostico='K280';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA GASTROYEYUNAL, AGUDA CON HEMORRAGIA Y PERFORACION' WHERE codigo_diagnostico='K282';
UPDATE diagnosticos SET nombre_diagnostico='ULCERA GASTROYEYUNAL, NO ESPECIFICADA COMO AGUDA NI CRONICA, SIN HEMORRAGIA NI PERFORACION' WHERE codigo_diagnostico='K289';
UPDATE diagnosticos SET nombre_diagnostico='GASTRITIS CRONICA SUPERFICIAL' WHERE codigo_diagnostico='K293';
UPDATE diagnosticos SET nombre_diagnostico='DISPEPSIA FUNCIONAL' WHERE codigo_diagnostico='K30X';
UPDATE diagnosticos SET nombre_diagnostico='HERNIA INGUINAL UNILATERAL O NO ESPECIFICADA, SIN OBSTRUCCION NI GANGRENA' WHERE codigo_diagnostico='K409';
UPDATE diagnosticos SET nombre_diagnostico='OTRAS HERNIAS VENTRALES Y LAS NO ESPECIFICADAS SIN OBSTRUCCION O GANGRENA' WHERE codigo_diagnostico='K439';
UPDATE diagnosticos SET nombre_diagnostico='HERNIA DIAFRAGMATICA SIN OBSTRUCCION NI GANGRENA' WHERE codigo_diagnostico='K449';
UPDATE diagnosticos SET nombre_diagnostico='PANCOLITIS ULCERATIVA (CRONICA)' WHERE codigo_diagnostico='K510';
UPDATE diagnosticos SET nombre_diagnostico='POLIPOS INFLAMATORIOS' WHERE codigo_diagnostico='K514';
UPDATE diagnosticos SET nombre_diagnostico='COLITIS DEL LADO IZQUIERDO' WHERE codigo_diagnostico='K515';
UPDATE diagnosticos SET nombre_diagnostico='FISTULA ANAL' WHERE codigo_diagnostico='K603';
UPDATE diagnosticos SET nombre_diagnostico='ENFERMEDAD TOXICA DEL HIGADO CON HEPATITIS AGUDA' WHERE codigo_diagnostico='K712';
UPDATE diagnosticos SET nombre_diagnostico='ENFERMEDAD TOXICA DEL HIGADO CON HEPATITIS CRONICA PERSISTENTE' WHERE codigo_diagnostico='K713';
UPDATE diagnosticos SET nombre_diagnostico='ENFERMEDAD TOXICA DEL HIGADO CON HEPATITIS NO CLASIFICADA EN OTRA PARTE' WHERE codigo_diagnostico='K716';
UPDATE diagnosticos SET nombre_diagnostico='ENFERMEDAD TOXICA DEL HIGADO CON CIRROSIS Y FIBROSIS DEL HIGADO' WHERE codigo_diagnostico='K717';
UPDATE diagnosticos SET nombre_diagnostico='ENFERMEDAD TOXICA DEL HIGADO CON OTROS TRASTORNOS HEPATICOS' WHERE codigo_diagnostico='K718';
UPDATE diagnosticos SET nombre_diagnostico='OTRAS CIRROSIS DEL HIGADO Y LAS NO ESPECIFICADAS' WHERE codigo_diagnostico='K746';
UPDATE diagnosticos SET nombre_diagnostico='OTRAS ENFERMEDADES ESPECIFICADAS DEL HIGADO' WHERE codigo_diagnostico='K768';
UPDATE diagnosticos SET nombre_diagnostico='TRASTORNOS DEL HIGADO EN OTRAS ENFERMEDADES CLASIFICADAS EN OTRA PARTE' WHERE codigo_diagnostico='K778';
UPDATE diagnosticos SET nombre_diagnostico='OTRAS ENFERMEDADES ESPECIFICADAS DE LAS VIAS BILIARES' WHERE codigo_diagnostico='K838';
UPDATE diagnosticos SET nombre_diagnostico='SINDROME DE POSTCOLECISTECTOMIA' WHERE codigo_diagnostico='K915';
UPDATE diagnosticos SET nombre_diagnostico='OTRAS ARTRITIS REUMATOIDES ESPECIFICADAS' WHERE codigo_diagnostico='M068';
UPDATE diagnosticos SET nombre_diagnostico='TRASTORNO INTERNO DE LA RODILLA, NO ESPECIFICADO' WHERE codigo_diagnostico='M239';
UPDATE diagnosticos SET nombre_diagnostico='SINDROME SECO [SJGREN]' WHERE codigo_diagnostico='M350';
UPDATE diagnosticos SET nombre_diagnostico='CUERPO EXTRANO RESIDUAL EN TEJIDO BLANDO' WHERE codigo_diagnostico='M795';
UPDATE diagnosticos SET nombre_diagnostico='ENFERMEDAD RENAL CRONICA NO ESPECIFICADA' WHERE codigo_diagnostico='N189';
UPDATE diagnosticos SET nombre_diagnostico='CALCULO DEL RINON CON CALCULO DEL URETER' WHERE codigo_diagnostico='N202';
UPDATE diagnosticos SET nombre_diagnostico='OTROS HIDROCELES' WHERE codigo_diagnostico='N432';
UPDATE diagnosticos SET nombre_diagnostico='VOMITOS DEL EMBARAZO, NO ESPECIFICADOS' WHERE codigo_diagnostico='O219';
UPDATE diagnosticos SET nombre_diagnostico='CUERPO EXTRANO EN LA CORNEA' WHERE codigo_diagnostico='T150';
UPDATE diagnosticos SET nombre_diagnostico='CUERPO EXTRANO EN LA BOCA' WHERE codigo_diagnostico='T180';
UPDATE diagnosticos SET nombre_diagnostico='CUERPO EXTRANO EN EL ESTOMAGO' WHERE codigo_diagnostico='T182';
UPDATE diagnosticos SET nombre_diagnostico='EFECTO TOXICO DE ALCALIS CAUSTICOS Y SUSTANCIAS ALCALINAS SIMILARES' WHERE codigo_diagnostico='T543';
UPDATE diagnosticos SET nombre_diagnostico='EFECTO ADVERSO NO ESPECIFICADO' WHERE codigo_diagnostico='T789';
UPDATE diagnosticos SET nombre_diagnostico='CUERPO EXTRANO DEJADO ACCIDENTALMENTE EN CAVIDAD CORPORAL O EN HERIDA OPERATORIA CONSECUTIVA A PROCEDIMIENTO' WHERE codigo_diagnostico='T815';
UPDATE diagnosticos SET nombre_diagnostico='OCUPANTE DE AUTOMOVIL LESIONADO POR COLISION CON VEHICULO DE MOTOR DE DOS O TRES RUEDAS, OCUPANTE NO ESPECIFICADO DE AUTOMOVIL, LESIONADO EN ACCIDENTE DE TRANSITO' WHERE codigo_diagnostico='V429';
UPDATE diagnosticos SET nombre_diagnostico='DISPARO DE RIFLE, ESCOPETA Y ARMA LARGA, GRANJA' WHERE codigo_diagnostico='W337';
UPDATE diagnosticos SET nombre_diagnostico='CUERPO EXTRANO QUE PENETRA POR EL OJO U ORIFICIO NATURAL, ESCUELAS, OTRAS INSTITUCIONES Y AREAS ADMINISTRATIVAS PUBLICAS' WHERE codigo_diagnostico='W442';
UPDATE diagnosticos SET nombre_diagnostico='DISPARO DE ARMA CORTA, DE INTENCION NO DETERMINADA, LUGAR NO ESPECIFICADO' WHERE codigo_diagnostico='Y229';
UPDATE diagnosticos SET nombre_diagnostico='CONTROL DE SALUD DE RUTINA DEL NINO' WHERE codigo_diagnostico='Z001';
UPDATE diagnosticos SET nombre_diagnostico='EXAMEN DE PESQUISA ESPECIAL PARA TUMOR DEL INTESTINO' WHERE codigo_diagnostico='Z121';
UPDATE diagnosticos SET nombre_diagnostico='PERSONA SANA QUE ACOMPANA AL ENFERMO' WHERE codigo_diagnostico='Z763';

COMMIT;

-- ============================================================================
-- PARTE 5. Especialistas de GASTROLAP: tipo y número de documento, nombres y
-- apellidos separados (obligatorios para el RDA, verificados en RETHUS).
-- Se ubican por cédula o por nombre porque el id puede variar entre bases.
-- Nota: RETHUS tiene invertidos nombres/apellidos del Dr. Rubén Carrasquilla;
-- aquí queda en el orden correcto.
-- ============================================================================
START TRANSACTION;
UPDATE especialistas SET id_tipo_identificacion='CC', identificacion='73106055',
       primer_nombre='JAIME', segundo_nombre='JOSE', primer_apellido='BONFANTE', segundo_apellido='MOLINARES',
       nombre='JAIME JOSE BONFANTE MOLINARES'
WHERE identificacion='73106055' OR nombre LIKE 'JAIME JOSE BONFANTE MOLINARES%';

UPDATE especialistas SET id_tipo_identificacion='CC', identificacion='1128047125',
       primer_nombre='LILIANA', segundo_nombre='ISABEL', primer_apellido='ARROYO', segundo_apellido='CASAS',
       nombre='LILIANA ISABEL ARROYO CASAS'
WHERE identificacion='1128047125' OR nombre LIKE 'LILIANA%ARROYO%';

UPDATE especialistas SET id_tipo_identificacion='CC', identificacion='51974166',
       primer_nombre='SANDRA', segundo_nombre='YADIRA', primer_apellido='MORENO', segundo_apellido='ALONSO',
       nombre='SANDRA YADIRA MORENO ALONSO'
WHERE identificacion='51974166' OR nombre LIKE 'SANDRA%MORENO%';

UPDATE especialistas SET id_tipo_identificacion='CC', identificacion='78696551',
       primer_nombre='RUBEN', segundo_nombre='DARIO', primer_apellido='CARRASQUILLA', segundo_apellido='MELENDEZ',
       nombre='RUBEN DARIO CARRASQUILLA MELENDEZ'
WHERE identificacion='78696551' OR nombre LIKE 'RUBEN%CARRASQUILLA%';
COMMIT;

-- ============================================================================
-- PARTE 6. Verificación (revisar los resultados de estas consultas)
-- ============================================================================
-- 6.1 Tablas nuevas (deben salir las 5)
SELECT TABLE_NAME AS tabla_nueva FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = DATABASE()
  AND TABLE_NAME IN ('config_interop_api','interop_token_cache','rda_envios','historia_clinica_trazabilidad','historia_clinica_adendas');

-- 6.2 Columnas nuevas (debe dar 20: 17 columnas en tablas existentes + id de 3 tablas nuevas)
SELECT COUNT(*) AS columnas_nuevas_deben_ser_20 FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_SCHEMA = DATABASE() AND (
   (TABLE_NAME='config_interop_api' AND COLUMN_NAME IN ('codigo_prestador_reps','nit_prestador'))
OR (TABLE_NAME='usuarios' AND COLUMN_NAME IN ('codigo_pais_nacimiento','codigo_etnia','codigo_discapacidad','codigo_identidad_genero','hora_nacimiento','nombre_municipio'))
OR (TABLE_NAME='especialistas' AND COLUMN_NAME IN ('primer_nombre','segundo_nombre','primer_apellido','segundo_apellido'))
OR (TABLE_NAME='empresa' AND COLUMN_NAME='codigo_prestador')
OR (TABLE_NAME='rda_envios' AND COLUMN_NAME='composition_id')
OR (TABLE_NAME='historia_clinica' AND COLUMN_NAME IN ('firmada','fecha_firma','usuario_firma'))
OR (TABLE_NAME IN ('interop_token_cache','historia_clinica_trazabilidad','historia_clinica_adendas') AND COLUMN_NAME='id'));

-- 6.3 IMPORTANTE: el SIM lee historia_clinica por posición. Debe dar 35 columnas y
--     'firmada' en la posición 33 (igual que la base de prueba). Si no coincide, avisar
--     antes de usar el SIM.
SELECT (SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME='historia_clinica') AS columnas_historia_deben_ser_35,
       (SELECT ORDINAL_POSITION FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME='historia_clinica' AND COLUMN_NAME='firmada') AS posicion_firmada_debe_ser_33;

-- 6.4 Prestador y configuración
SELECT id, nombre, codigo_prestador FROM empresa;
SELECT id, ambiente, url_base_api, codigo_prestador_reps, nit_prestador,
       (tenant_id IS NOT NULL AND tenant_id <> '') AS tiene_credenciales FROM config_interop_api;

-- 6.5 Diagnósticos (K30X debe decir DISPEPSIA FUNCIONAL; respaldo con 102 filas)
SELECT codigo_diagnostico, nombre_diagnostico FROM diagnosticos WHERE codigo_diagnostico IN ('K30X','K227','K293');
SELECT COUNT(*) AS respaldo_diagnosticos_102 FROM diagnosticos_respaldo_rda;

-- 6.6 Especialistas (deben salir los 4 con CC, número y nombres completos, una vez cada uno)
SELECT id_especialista, id_tipo_identificacion, identificacion, nombre, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido
FROM especialistas WHERE identificacion IN ('73106055','1128047125','51974166','78696551');

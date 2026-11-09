-- ============================================================================
-- Migración: Inalterabilidad de la Historia Clínica (Resolución 3100 de 2019)
--
-- Hallazgo de auditoría: DHistoriaClinica.Guardar() hacía UPDATE sobre
-- historia_clinica sin ninguna validación de si ya había sido firmada. El
-- mensaje "Si continua no se podran hacer cambios en la historia" que ve el
-- médico al firmar no se cumplía en el código: era solo un texto en
-- pantalla, no una regla aplicada por la aplicación ni por la base de datos.
-- Tampoco existía ninguna tabla de trazabilidad para historia_clinica (la
-- tabla 'auditoria' existente es de otro dominio: autorizaciones de
-- facturación de ordenes/detalle_orden).
--
-- Esta migración:
--   1) Agrega el estado de firma a historia_clinica (bloqueo real).
--   2) Crea una bitácora de trazabilidad específica para historia_clinica
--      (incluye intentos de modificación bloqueados).
--   3) Crea la tabla de adendas: el único mecanismo permitido para agregar
--      información a una historia ya firmada (nunca se sobrescribe el
--      contenido original firmado).
--
-- No borra ni modifica datos existentes. Todo registro histórico
-- (historia_clinica.firmada) queda en 0 por defecto, así que las historias
-- ya guardadas antes de esta migración seguirán editables hasta que el
-- código las marque como firmadas (ver DHistoriaClinica.MarcarFirmada).
-- ============================================================================


-- ----------------------------------------------------------------------------
-- 1) Estado de firma en historia_clinica
-- ----------------------------------------------------------------------------
ALTER TABLE historia_clinica
    ADD COLUMN firmada       TINYINT(1)  NOT NULL DEFAULT 0
        COMMENT 'Resolucion 3100: 1 = la historia fue firmada y ya no se puede modificar (solo adendas)',
    ADD COLUMN fecha_firma   DATETIME    NULL
        COMMENT 'Fecha/hora real del servidor en el momento de firmar (no editable por el usuario)',
    ADD COLUMN usuario_firma INT         NULL
        COMMENT 'Id del especialista/empleado que firmó (puede diferir de id_especialista si firma otro usuario)',
    ADD INDEX idx_historia_clinica_firmada (firmada);


-- ----------------------------------------------------------------------------
-- 2) Trazabilidad de historia_clinica (quién, cuándo, qué intentó hacer)
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS historia_clinica_trazabilidad (
    id              INT AUTO_INCREMENT PRIMARY KEY,
    id_orden        INT NOT NULL,
    id_historia     INT NULL
        COMMENT 'Id de historia_clinica, si ya existía al momento del evento',
    id_usuario      INT NULL
        COMMENT 'Id del empleado/especialista que ejecutó la acción',
    accion          VARCHAR(30) NOT NULL
        COMMENT 'CREACION | ACTUALIZACION | FIRMA | INTENTO_BLOQUEADO | ADENDA',
    detalle         VARCHAR(500) NULL,
    fecha_hora      DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    INDEX idx_hc_trazabilidad_orden (id_orden),
    INDEX idx_hc_trazabilidad_fecha (fecha_hora)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4
COMMENT='Bitácora de inalterabilidad: cada intento de modificar una historia ya firmada queda registrado aquí aunque la aplicación lo rechace';


-- ----------------------------------------------------------------------------
-- 3) Adendas: la única forma de "cambiar" una historia ya firmada
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS historia_clinica_adendas (
    id              INT AUTO_INCREMENT PRIMARY KEY,
    id_orden        INT NOT NULL,
    id_historia     INT NOT NULL,
    id_usuario      INT NOT NULL
        COMMENT 'Quien registra la adenda',
    texto           TEXT NOT NULL,
    fecha_hora      DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    INDEX idx_hc_adendas_orden (id_orden),
    INDEX idx_hc_adendas_historia (id_historia)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4
COMMENT='Anotaciones posteriores a la firma. El contenido original de historia_clinica nunca se sobrescribe una vez firmada';


-- ============================================================================
-- Nota: esta migración NO marca como firmadas las historias ya existentes.
-- Si quieres considerar "firmadas" (bloqueadas) todas las historias de
-- órdenes que ya están en estado ATENDIDO/FACTURADO, puedes correr (opcional,
-- revisa antes si eso es lo que quieres para datos históricos):
--
-- UPDATE historia_clinica hc
-- INNER JOIN ordenes o ON o.id = hc.id_orden
-- SET hc.firmada = 1, hc.fecha_firma = IFNULL(hc.fecha_firma, NOW())
-- WHERE o.estado IN ('ATENDIDO','FACTURADO') AND hc.firmada = 0;
-- ============================================================================

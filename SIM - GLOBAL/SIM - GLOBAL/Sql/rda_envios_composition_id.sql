-- ============================================================================
-- Migración: guardar el id de Composition que MinSalud asigna a cada RDA
--
-- Necesario para poder usar después la operación oficial:
--   GET {APIMurl}/Composition/{id-composition}/$document
-- (recuperar el documento completo ya enviado, por ejemplo para auditoría,
-- soporte, o para enviar una nota aclaratoria referenciando ese RDA).
--
-- Sin esta columna, el id solo queda enterrado dentro del JSON completo en
-- rda_envios.detalle, sin poder consultarlo/indexarlo directamente.
-- ============================================================================

ALTER TABLE rda_envios
    ADD COLUMN composition_id VARCHAR(100) NULL
        COMMENT 'Id del recurso Composition asignado por MinSalud al aceptar el RDA (HTTP 201). Permite recuperarlo después vía GET /Composition/{id}/$document',
    ADD INDEX idx_rda_envios_composition_id (composition_id);

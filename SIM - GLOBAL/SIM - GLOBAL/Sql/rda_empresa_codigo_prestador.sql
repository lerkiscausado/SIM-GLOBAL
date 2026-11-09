-- ============================================================================
-- Migración: Código de habilitación (REPS) en empresa
--
-- IMPORTANTE: el modelo Empresa.vb ya tenía la propiedad CodigoPrestador
-- antes de este trabajo, lo que sugiere que la columna PUEDE ya existir en
-- tu base de datos (simplemente nunca se leía/escribía correctamente por
-- los bugs en DEmpresa.vb que ya se corrigieron en el código).
--
-- Verifica PRIMERO con:
--   DESCRIBE empresa;
-- Si 'codigo_prestador' ya aparece en el resultado, NO ejecutes el ALTER
-- de abajo (fallará con "Duplicate column" o similar, sin causar daño,
-- pero no hace falta).
-- ============================================================================

ALTER TABLE empresa
    ADD COLUMN codigo_prestador VARCHAR(50) NULL
        COMMENT 'Código de habilitación REPS del prestador (ej. 1300102098 para Gastrocaribe SAS)';

-- Una vez agregada (o confirmado que ya existía), completa el valor real
-- para tu empresa, por ejemplo:
--   UPDATE empresa SET codigo_prestador = '1300102098' WHERE id_licencia = '<tu_id_licencia>';

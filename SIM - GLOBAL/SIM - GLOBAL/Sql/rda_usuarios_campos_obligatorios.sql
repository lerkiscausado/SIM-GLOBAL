-- ============================================================================
-- Migración: Campos obligatorios de Patient (usuarios) para RDA-Paciente
-- Confirmado contra el validador real de MinSalud (envío exitoso HTTP 201
-- el 2026-09-08 con paciente de prueba) - estos NO son especulativos, son
-- los campos que el perfil PatientRDA exige.
--
-- Ninguna columna existente se modifica ni se borra: todo son columnas
-- NUEVAS y opcionales (NULL permitido) para no romper el sistema mientras
-- se van capturando los datos reales.
-- Sintaxis MySQL/MariaDB (motor usado por el resto del esquema del SIM).
-- ============================================================================

ALTER TABLE usuarios
    -- OBLIGATORIOS para el envío del RDA (Patient.extension, cardinalidad 1..* / 1..1):
    ADD COLUMN codigo_pais_nacimiento VARCHAR(5) NULL
        COMMENT 'ISO 3166 numérico. Colombia = 170. Usado en ExtensionPatientNationality (OBLIGATORIO)',
    ADD COLUMN codigo_etnia VARCHAR(5) NULL
        COMMENT 'CodeSystem ColombianEthnicGroup de MinSalud. Usado en ExtensionPatientEthnicity (OBLIGATORIO)',
    ADD COLUMN codigo_discapacidad VARCHAR(5) NULL
        COMMENT 'CodeSystem ColombianDisabilityClassification de MinSalud. Usado en ExtensionPatientDisability (OBLIGATORIO). "08" = Sin discapacidad',

    -- OPCIONALES (no bloquearon el envío de prueba, pero el perfil los contempla):
    ADD COLUMN codigo_identidad_genero VARCHAR(5) NULL
        COMMENT 'CodeSystem ColombianGenderIdentity. Usado en ExtensionPatientGenderIdentity (opcional)',
    ADD COLUMN hora_nacimiento TIME NULL
        COMMENT 'Usado en ExtensionBirthTime dentro de Patient._birthDate (opcional)',
    ADD COLUMN nombre_municipio VARCHAR(120) NULL
        COMMENT 'Texto del municipio (hoy solo se guarda el código DIVIPOLA en codigo_municipio); mejora la calidad del dato pero no es obligatorio para el envío';

-- ============================================================================
-- Notas para cuando se capturen los datos reales (no es parte de esta migración):
--
-- * codigo_pais_nacimiento: mientras no se capture, el código VB.NET usa por
--   defecto "170" (Colombia) para todo paciente, asumiendo que la gran
--   mayoría de pacientes son colombianos. Ajustar si se atienden muchos
--   pacientes extranjeros.
--
-- * codigo_etnia y codigo_discapacidad: mientras no se capturen, el código
--   VB.NET usa por defecto "6" (Otras etnias) y "08" (Sin discapacidad).
--   Estos NO son afirmaciones clínicas verificadas sobre el paciente real,
--   son placeholders necesarios porque MinSalud exige el campo. Se
--   recomienda capturarlos en frmUsuarios cuando se pueda, y actualizar
--   RDABundleBuilder.ConstruirPatient para leerlos de estas columnas en
--   vez de usar el valor fijo.
--
-- * Los códigos válidos de cada tabla de valores (etnia, discapacidad,
--   identidad de género) están publicados por MinSalud en
--   https://fhir.minsalud.gov.co/rda/CodeSystem/... - te los puedo traer
--   cuando decidas capturarlos en el formulario.
-- ============================================================================

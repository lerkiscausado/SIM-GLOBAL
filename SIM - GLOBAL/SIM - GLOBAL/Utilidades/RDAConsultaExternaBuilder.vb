Imports Newtonsoft.Json.Linq
Imports SIM___GLOBAL.Modelo

Namespace Utilidades

    ''' <summary>
    ''' Arma el Bundle FHIR tipo "document" para el documento RDA-Consulta Externa
    ''' (perfil CompositionAmbulatoryRDA), según la Guía de Implementación FHIR RDA de MinSalud.
    '''
    ''' A diferencia de RDA-Paciente, este documento SÍ requiere un Encounter y SÍ tiene un
    ''' lugar válido para el Practitioner (como author y como participante del encuentro).
    '''
    ''' Estructura validada exhaustivamente contra el sandbox real (2026-09-09), incluyendo:
    ''' - Las 9 secciones EXACTAS que exige el perfil (cardinalidad 9..10) - no admite
    '''   secciones inventadas ni "Procedimientos" como sección propia.
    ''' - El procedimiento se reporta como ServiceRequest (orden) dentro de "Órdenes", NO como
    '''   Procedure independiente (ese recurso requiere existir previamente en el servidor de
    '''   MinSalud - "prior creation required" - probablemente vía RIPS/CUV, no vía este Bundle).
    ''' - IDs fijos obligatorios: Encounter.participant.id="AttenderPhysician",
    '''   Encounter.diagnosis.id="MainDiagnosis".
    ''' - Encounter.reasonCode usa el CodeSystem RIPSCausaExternaVersion2 (no RIPSFinalidadConsultaVersion2,
    '''   ese es para ServiceRequest.reasonCode).
    ''' - La sección "Documentos de soporte" es la ÚNICA que NO admite quedar vacía (emptyReason
    '''   prohibido, cardinalidad 0..0) - siempre necesita un DocumentReference real con adjunto PDF.
    ''' - DocumentReference.description, content.attachment y content.format tienen valores FIJOS
    '''   exactos exigidos por el perfil.
    '''
    ''' IMPORTANTE - limitación conocida del sandbox: el ValueSet CUPSProcedureCodes que usa
    ''' MinSalud para validar ServiceRequest.code es un subconjunto reducido (~434 códigos, casi
    ''' todos de consulta) que NO incluye la mayoría de códigos CUPS reales de procedimientos
    ''' (ej. endoscopia). Pendiente de escalar a soporte de MinSalud/IHCE.
    ''' </summary>
    Public Module RDAConsultaExternaBuilder

        Private Const LOINC As String = "http://loinc.org"
        Private Const BASE_RDA As String = "https://fhir.minsalud.gov.co/rda"

        ''' <summary>
        ''' Construye el Bundle completo de RDA-Consulta Externa y lo devuelve como texto JSON,
        ''' listo para enviar en el body del POST a {UrlBaseApi}/Composition/$enviar-rda-consulta
        ''' </summary>
        ''' <param name="grupoServiciosCodigo">"01"=Consulta externa, "04"=Quirúrgico (día del procedimiento). Ver CodeSystem/GrupoServicios.</param>
        ''' <param name="cupsProcedimientoCodigo">Opcional: CUPS del procedimiento realizado/ordenado (ej. endoscopia). Si se omite, la sección "Órdenes" queda con emptyReason.</param>
        Public Function ConstruirBundleConsultaExterna(
            paciente As Usuarios,
            especialista As Especialista,
            config As ConfigInteropApi,
            nombreOrganizacion As String,
            diagnosticoCie10Codigo As String,
            diagnosticoCie10Texto As String,
            cupsConsultaCodigo As String,
            cupsConsultaTexto As String,
            grupoServiciosCodigo As String,
            grupoServiciosTexto As String,
            repsHealthcareServiceCodigo As String,
            repsHealthcareServiceTexto As String,
            Optional cupsProcedimientoCodigo As String = Nothing,
            Optional cupsProcedimientoTexto As String = Nothing,
            Optional fechaInicioEncuentro As Date? = Nothing,
            Optional fechaFinEncuentro As Date? = Nothing) As String

            If paciente Is Nothing Then Throw New ArgumentException("No se encontró información del paciente para armar el RDA de Consulta Externa.")
            If especialista Is Nothing OrElse String.IsNullOrWhiteSpace(especialista.Identificacion) Then
                Throw New ArgumentException("RDA-Consulta Externa requiere un profesional de salud (Practitioner) válido.")
            End If
            If String.IsNullOrWhiteSpace(config.CodigoPrestadorReps) Then
                Throw New InvalidOperationException("Falta configurar el 'Código de habilitación del prestador (REPS)' en Interoperabilidad RDA.")
            End If

            Dim inicio As Date = If(fechaInicioEncuentro.HasValue, fechaInicioEncuentro.Value, DateTime.Now.AddMinutes(-30))
            Dim fin As Date = If(fechaFinEncuentro.HasValue, fechaFinEncuentro.Value, DateTime.Now)
            ' Nunca permitir fechas futuras (MinSalud lo rechaza): si "ahora" quedó antes que
            ' inicio/fin por reloj/zona horaria, se recorta a "ahora".
            If fin > DateTime.Now Then fin = DateTime.Now
            If inicio > fin Then inicio = fin.AddMinutes(-30)

            ' ── Identificadores de referencia internos del Bundle ─────────────────────
            Dim idPaciente As String = SanitizarId(paciente.CodigotipoIdentificacion & "-" & paciente.Identificacion)
            Dim idOrganizacion As String = SanitizarId(config.CodigoPrestadorReps)
            Dim tipoIdEspecialista As String = If(Not String.IsNullOrWhiteSpace(especialista.IdTipoIdentificacion), especialista.IdTipoIdentificacion, "CC")
            Dim idPractitioner As String = SanitizarId(tipoIdEspecialista & "-" & especialista.Identificacion)
            Const idEncounter As String = "Encounter-0"
            Const idCondition As String = "Condition-0"
            Const idServiceRequest As String = "ServiceRequest-0"
            Const idDocumentReference As String = "DocumentReference-0"
            Dim idLocation As String = idOrganizacion & "-01"

            ' ── Condition (diagnóstico del encuentro) ─────────────────────────────────
            Dim condition As New JObject From {
                {"resourceType", "Condition"},
                {"id", idCondition},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/ConditionRDA"}}}},
                {"clinicalStatus", New JObject From {{"coding", New JArray From {New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/condition-clinical"}, {"code", "active"}, {"display", "Active"}}}}}},
                {"verificationStatus", New JObject From {{"coding", New JArray From {New JObject From {{"code", "confirmed"}, {"display", "Confirmed"}}}}}},
                {"category", New JArray From {New JObject From {{"coding", New JArray From {New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/condition-category"}, {"code", "encounter-diagnosis"}, {"display", "Encounter Diagnosis"}}}}}}},
                {"code", New JObject From {{"coding", New JArray From {New JObject From {{"system", "http://hl7.org/fhir/sid/icd-10"}, {"code", diagnosticoCie10Codigo}, {"display", diagnosticoCie10Texto}}}}}},
                {"subject", New JObject From {{"reference", "#" & idPaciente}}}
            }

            ' ── ServiceRequest (orden/realización del procedimiento) - opcional ───────
            Dim hayProcedimiento As Boolean = Not String.IsNullOrWhiteSpace(cupsProcedimientoCodigo)
            Dim serviceRequest As JObject = Nothing
            If hayProcedimiento Then
                serviceRequest = New JObject From {
                    {"resourceType", "ServiceRequest"},
                    {"id", idServiceRequest},
                    {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/ServiceRequestRDA"}}}},
                    {"status", "active"},
                    {"intent", "order"},
                    {"category", New JArray From {New JObject From {{"coding", New JArray From {New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianHealthTechnologyCategory"}, {"code", "01"}, {"display", "Procedimiento en salud"}}}}}}},
                    {"code", New JObject From {{"coding", New JArray From {New JObject From {{"system", BASE_RDA & "/CodeSystem/CUPS"}, {"code", cupsProcedimientoCodigo}, {"display", cupsProcedimientoTexto}}}}}},
                    {"subject", New JObject From {{"reference", "#" & idPaciente}}},
                    {"encounter", New JObject From {{"reference", "#" & idEncounter}}},
                    {"authoredOn", inicio.ToString("yyyy-MM-dd")},
                    {"requester", New JObject From {{"reference", "#" & idPractitioner}}},
                    {"reasonCode", New JArray From {New JObject From {{"coding", New JArray From {New JObject From {{"system", BASE_RDA & "/CodeSystem/RIPSFinalidadConsultaVersion2"}, {"code", "15"}, {"display", "DIAGNOSTICO"}}}}}}}
                }
            End If

            ' ── Encounter ──────────────────────────────────────────────────────────
            Dim encounter As New JObject From {
                {"resourceType", "Encounter"},
                {"id", idEncounter},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/EncounterAmbulatoryRDA"}}}},
                {"identifier", New JArray From {New JObject From {{"id", "EncounterIdentifier"}, {"use", "usual"}, {"system", BASE_RDA & "/NamingSystem/Encounters"}, {"value", $"{idOrganizacion}-{DateTime.Now:yyyyMMddHHmmss}"}}}},
                {"status", "finished"},
                {"class", New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/v3-ActCode"}, {"code", "AMB"}, {"display", "ambulatory"}}},
                {"type", New JArray From {
                    New JObject From {{"coding", New JArray From {New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianTechModality"}, {"code", "01"}, {"display", "Intramural"}}}}},
                    New JObject From {{"coding", New JArray From {New JObject From {{"system", BASE_RDA & "/CodeSystem/GrupoServicios"}, {"code", grupoServiciosCodigo}, {"display", grupoServiciosTexto}}}}},
                    New JObject From {{"coding", New JArray From {New JObject From {{"system", BASE_RDA & "/CodeSystem/REPShealthcareServices"}, {"code", repsHealthcareServiceCodigo}, {"display", repsHealthcareServiceTexto}}}}},
                    New JObject From {{"coding", New JArray From {New JObject From {{"system", BASE_RDA & "/CodeSystem/EntornoAtencion"}, {"code", "05"}, {"display", "Institucional"}}}}}
                }},
                {"serviceType", New JObject From {{"coding", New JArray From {New JObject From {{"system", BASE_RDA & "/CodeSystem/CUPS"}, {"code", cupsConsultaCodigo}, {"display", cupsConsultaTexto}}}}}},
                {"subject", New JObject From {{"reference", "#" & idPaciente}}},
                {"participant", New JArray From {
                    New JObject From {
                        {"id", "AttenderPhysician"},
                        {"type", New JArray From {New JObject From {{"coding", New JArray From {New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"}, {"code", "ATND"}, {"display", "attender"}}}}}}},
                        {"individual", New JObject From {{"reference", "#" & idPractitioner}}}
                    }
                }},
                {"period", New JObject From {{"start", inicio.ToString("yyyy-MM-ddTHH:mm:sszzz")}, {"end", fin.ToString("yyyy-MM-ddTHH:mm:sszzz")}}},
                {"reasonCode", New JArray From {New JObject From {{"coding", New JArray From {New JObject From {{"system", BASE_RDA & "/CodeSystem/RIPSCausaExternaVersion2"}, {"code", "38"}, {"display", "ENFERMEDAD GENERAL"}}}}}}},
                {"diagnosis", New JArray From {
                    New JObject From {
                        {"id", "MainDiagnosis"},
                        {"extension", New JArray From {New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionDiagnosisType"}, {"valueCoding", New JObject From {{"system", BASE_RDA & "/CodeSystem/RIPSTipoDiagnosticoPrincipalVersion2"}, {"code", "02"}, {"display", "Confirmado Nuevo"}}}}}},
                        {"condition", New JObject From {{"reference", "#" & idCondition}}},
                        {"use", New JObject From {{"coding", New JArray From {New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianDiagnosisRole"}, {"code", "8319008"}, {"display", "diagnóstico primario"}}}}}},
                        {"rank", 1}
                    }
                }},
                {"location", New JArray From {New JObject From {{"location", New JObject From {{"reference", "#" & idLocation}}}}}},
                {"serviceProvider", New JObject From {{"reference", "#" & idOrganizacion}}}
            }

            ' ── DocumentReference (obligatorio, PDF real, valores fijos) ──────────────
            Dim documentReference As New JObject From {
                {"resourceType", "DocumentReference"},
                {"id", idDocumentReference},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/DocumentReferenceEPIRDA"}}}},
                {"text", New JObject From {{"status", "generated"}, {"div", "<div xmlns='http://www.w3.org/1999/xhtml'>Resumen de la consulta</div>"}}},
                {"status", "current"},
                {"type", New JObject From {{"coding", New JArray From {
                    New JObject From {{"system", LOINC}, {"code", "18842-5"}, {"display", "Discharge summary"}},
                    New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianDocumentTypes"}, {"code", "EPI"}, {"display", "Epicrisis"}}
                }}}},
                {"category", New JArray From {New JObject From {{"coding", New JArray From {New JObject From {{"system", LOINC}, {"code", "55108-5"}, {"display", "Clinical presentation Document"}}}}}}},
                {"subject", New JObject From {{"reference", "#" & idPaciente}}},
                {"date", fin.ToString("yyyy-MM-ddTHH:mm:sszzz")},
                {"author", New JArray From {New JObject From {{"reference", "#" & idOrganizacion}}}},
                {"custodian", New JObject From {{"reference", "Organization/MinSalud"}}},
                {"description", "Epicrisis del encuentro de atención en salud - RDA"},
                {"securityLabel", New JArray From {New JObject From {{"coding", New JArray From {New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/v3-Confidentiality"}, {"code", "R"}, {"display", "restricted"}}}}}}},
                {"content", New JArray From {
                    New JObject From {
                        {"attachment", New JObject From {{"data", GenerarPdfResumenBase64(paciente, especialista, diagnosticoCie10Texto)}}},
                        {"format", New JObject From {{"system", "urn:ietf:bcp:13"}, {"code", "application/pdf"}, {"display", "PDF"}}}
                    }
                }}
            }

            ' ── Composition (las 9 secciones exactas, cardinalidad 9..10) ────────────
            Dim seccionesVacias As New List(Of (Titulo As String, CodigoLoinc As String, DisplayLoinc As String)) From {
                ("Entidad(es) responsable(s) por el plan de beneficios en salud (consulta)", "48768-6", "Payment sources Document"),
                ("Otros datos demográficos", "74208-0", "Demographic information + History of occupation Document"),
                ("Datos incapacidad (SIPE – Sistema de Incapacidades y Prestaciones Economicas)", "105583-9", "Worker Sick leave form"),
                ("Historial de alergias, intolerancias y reacciones adversas", "48765-2", "Allergies and adverse reactions Document"),
                ("Factores de riesgo", "75492-9", "Risk assessment and screening note"),
                ("Historial de medicamentos", "10160-0", "History of Medication use Narrative")
            }

            Dim secciones As New JArray
            ' 1. Pagadores (vacío por ahora - sin integración EAPB todavía)
            secciones.Add(ConstruirSeccionVacia(seccionesVacias(0).Titulo, seccionesVacias(0).CodigoLoinc, seccionesVacias(0).DisplayLoinc, "No se registró entidad pagadora para esta prueba"))
            ' 2. Otros datos demográficos (vacío)
            secciones.Add(ConstruirSeccionVacia(seccionesVacias(1).Titulo, seccionesVacias(1).CodigoLoinc, seccionesVacias(1).DisplayLoinc, "Sin datos de ocupación para esta prueba"))
            ' 3. Incapacidad (vacío)
            secciones.Add(ConstruirSeccionVacia(seccionesVacias(2).Titulo, seccionesVacias(2).CodigoLoinc, seccionesVacias(2).DisplayLoinc, "Sin incapacidad otorgada en esta consulta"))
            ' 4. Diagnósticos (con entry real)
            secciones.Add(New JObject From {
                {"title", "Historial de diagnósticos de problemas de salud"},
                {"code", New JObject From {{"coding", New JArray From {New JObject From {{"system", LOINC}, {"code", "11450-4"}, {"display", "Problem list - Reported"}}}}}},
                {"entry", New JArray From {New JObject From {{"reference", "#" & idCondition}}}}
            })
            ' 5. Alergias (vacío)
            secciones.Add(ConstruirSeccionVacia(seccionesVacias(3).Titulo, seccionesVacias(3).CodigoLoinc, seccionesVacias(3).DisplayLoinc, "No se reportan alergias en esta consulta"))
            ' 6. Factores de riesgo (vacío)
            secciones.Add(ConstruirSeccionVacia(seccionesVacias(4).Titulo, seccionesVacias(4).CodigoLoinc, seccionesVacias(4).DisplayLoinc, "Sin factores de riesgo registrados en esta consulta"))
            ' 7. Medicamentos (vacío)
            secciones.Add(ConstruirSeccionVacia(seccionesVacias(5).Titulo, seccionesVacias(5).CodigoLoinc, seccionesVacias(5).DisplayLoinc, "Sin medicamentos formulados en esta consulta"))
            ' 8. Órdenes (con entry si hay procedimiento, si no vacío)
            If hayProcedimiento Then
                secciones.Add(New JObject From {
                    {"title", "Órdenes, prescripciones o solicitudes de servicio"},
                    {"code", New JObject From {{"coding", New JArray From {New JObject From {{"system", LOINC}, {"code", "61146-1"}, {"display", "Orders for services Document"}}}}}},
                    {"entry", New JArray From {New JObject From {{"reference", "#" & idServiceRequest}}}}
                })
            Else
                secciones.Add(ConstruirSeccionVacia("Órdenes, prescripciones o solicitudes de servicio", "61146-1", "Orders for services Document", "Sin órdenes adicionales para esta consulta"))
            End If
            ' 9. Documentos de soporte (SIEMPRE con entry real - no admite vacío)
            secciones.Add(New JObject From {
                {"title", "Documentos de soporte"},
                {"code", New JObject From {{"coding", New JArray From {New JObject From {{"system", LOINC}, {"code", "55107-7"}, {"display", "Addendum Document"}}}}}},
                {"entry", New JArray From {New JObject From {{"reference", "#" & idDocumentReference}}}}
            })

            Dim composition As New JObject From {
                {"resourceType", "Composition"},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/CompositionAmbulatoryRDA"}}}},
                {"status", "final"},
                {"type", New JObject From {{"coding", New JArray From {New JObject From {{"system", LOINC}, {"code", "51845-6"}, {"display", "Outpatient Consult note"}}}}}},
                {"subject", New JObject From {{"reference", "#" & idPaciente}}},
                {"encounter", New JObject From {{"reference", "#" & idEncounter}}},
                {"date", fin.ToString("yyyy-MM-ddTHH:mm:sszzz")},
                {"author", New JArray From {New JObject From {{"reference", "#" & idPractitioner}}}},
                {"title", "RDA Consulta Externa - " & nombreOrganizacion},
                {"confidentiality", "N"},
                {"attester", New JArray From {New JObject From {{"mode", "legal"}, {"party", New JObject From {{"reference", "#" & idOrganizacion}}}}}},
                {"custodian", New JObject From {{"reference", "#" & idOrganizacion}}},
                {"event", New JObject From {{"period", New JObject From {{"start", inicio.ToString("yyyy-MM-ddTHH:mm:sszzz")}, {"end", fin.ToString("yyyy-MM-ddTHH:mm:sszzz")}}}}},
                {"section", secciones}
            }

            ' ── Bundle final ───────────────────────────────────────────────────────
            Dim entradas As New JArray
            entradas.Add(EnvolverRecurso(composition))
            entradas.Add(EnvolverRecurso(ConstruirPatientSimple(idPaciente, paciente)))
            entradas.Add(EnvolverRecurso(ConstruirOrganizationSimple(idOrganizacion, config, nombreOrganizacion)))
            entradas.Add(EnvolverRecurso(ConstruirPractitionerSimple(idPractitioner, especialista)))
            entradas.Add(EnvolverRecurso(ConstruirLocationSimple(idLocation, idOrganizacion, config, nombreOrganizacion)))
            entradas.Add(EnvolverRecurso(condition))
            If hayProcedimiento Then entradas.Add(EnvolverRecurso(serviceRequest))
            entradas.Add(EnvolverRecurso(encounter))
            entradas.Add(EnvolverRecurso(documentReference))

            Dim bundle As New JObject From {
                {"resourceType", "Bundle"},
                {"language", "es-CO"},
                {"type", "document"},
                {"entry", entradas}
            }

            Return bundle.ToString(Newtonsoft.Json.Formatting.Indented)
        End Function

        ' ───────────────────────────── Recursos auxiliares ─────────────────────────────

        Private Function ConstruirSeccionVacia(titulo As String, codigoLoinc As String, displayLoinc As String, textoVacio As String) As JObject
            Return New JObject From {
                {"title", titulo},
                {"code", New JObject From {{"coding", New JArray From {New JObject From {{"system", LOINC}, {"code", codigoLoinc}, {"display", displayLoinc}}}}}},
                {"text", New JObject From {{"status", "generated"}, {"div", $"<div xmlns='http://www.w3.org/1999/xhtml'>{textoVacio}</div>"}}},
                {"emptyReason", New JObject From {{"coding", New JArray From {New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/list-empty-reason"}, {"code", "nilknown"}, {"display", "Nil Known"}}}}}}
            }
        End Function

        ' Nota: estas construcciones de Patient/Organization/Practitioner/Location son deliberadamente
        ' independientes de RDABundleBuilder (aunque haya solapamiento) para no acoplar los dos tipos
        ' de documento - cada perfil de documento puede evolucionar sus reglas por separado.

        Private Function ConstruirPatientSimple(idPaciente As String, paciente As Usuarios) As JObject
            Dim generoFhir As String = "unknown"
            Dim codigoGenero As String = Nothing
            If paciente.Sexo IsNot Nothing Then
                Select Case paciente.Sexo.Trim().ToUpperInvariant()
                    Case "M" : generoFhir = "male" : codigoGenero = "01"
                    Case "F" : generoFhir = "female" : codigoGenero = "02"
                End Select
            End If

            Dim nombresValidos As String() = {paciente.PrimerNombre, paciente.SegundoNombre}.
                Where(Function(n) Not String.IsNullOrWhiteSpace(n)).ToArray()
            Dim given As New JArray()
            For Each n In nombresValidos
                given.Add(n)
            Next

            Dim patient As New JObject From {
                {"resourceType", "Patient"},
                {"id", idPaciente},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/PatientRDA"}}}},
                {"extension", New JArray From {
                    New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionPatientNationality"}, {"valueCoding", New JObject From {{"system", BASE_RDA & "/CodeSystem/ISO31661"}, {"code", "170"}, {"display", "Colombia"}}}},
                    New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionPatientEthnicity"}, {"valueCoding", New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianEthnicGroup"}, {"code", "99"}, {"display", "Ninguna de las anteriores"}}}},
                    New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionPatientDisability"}, {"valueCoding", New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianDisabilityClassification"}, {"code", "08"}, {"display", "Sin discapacidad"}}}}
                }},
                {"identifier", New JArray From {
                    New JObject From {
                        {"id", "NationalPersonIdentifier-0"},
                        {"type", New JObject From {{"coding", New JArray From {
                            New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/v2-0203"}, {"code", "PN"}, {"display", "Person number"}},
                            New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianPersonIdentifier"}, {"code", paciente.CodigotipoIdentificacion}, {"display", "Cédula ciudadanía"}}
                        }}}},
                        {"use", "official"},
                        {"system", BASE_RDA & "/NamingSystem/RNEC"},
                        {"value", paciente.Identificacion}
                    }
                }},
                {"name", New JArray From {New JObject From {
                    {"use", "official"},
                    {"family", (paciente.PrimerApellido & " " & paciente.SegundoApellido).Trim()},
                    {"_family", New JObject From {{"extension", New JArray From {
                        New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionFathersFamilyName"}, {"valueString", paciente.PrimerApellido}},
                        New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionMothersFamilyName"}, {"valueString", paciente.SegundoApellido}}
                    }}}},
                    {"given", given}
                }}},
                {"active", True},
                {"gender", generoFhir}
            }
            If codigoGenero IsNot Nothing Then
                patient("_gender") = New JObject From {{"extension", New JArray From {New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionBiologicalGender"}, {"valueCoding", New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianGenderGroup"}, {"code", codigoGenero}, {"display", If(codigoGenero = "01", "Hombre", "Mujer")}}}}}}}
            End If
            If paciente.FechaNacimiento <> Date.MinValue Then
                patient("birthDate") = paciente.FechaNacimiento.ToString("yyyy-MM-dd")
            End If
            If Not String.IsNullOrWhiteSpace(paciente.CodigoMunicipio) Then
                Dim direccion As New JObject From {
                    {"id", "HomeAddress-0"},
                    {"use", "home"}, {"type", "physical"},
                    {"country", "Colombia"},
                    {"_country", New JObject From {{"extension", New JArray From {New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionCountryCode"}, {"valueCoding", New JObject From {{"system", BASE_RDA & "/CodeSystem/ISO31661"}, {"code", "170"}}}}}}}},
                    {"_city", New JObject From {{"extension", New JArray From {New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionDivipolaMunicipality"}, {"valueCoding", New JObject From {{"system", BASE_RDA & "/CodeSystem/DIVIPOLA"}, {"code", paciente.CodigoMunicipio}}}}}}}}
                }
                If Not String.IsNullOrWhiteSpace(paciente.Zona) Then
                    Dim codZona As String = If(paciente.Zona.Trim().ToUpperInvariant() = "R", "02", "01")
                    Dim displayZona As String = If(codZona = "02", "Rural", "Urbana")
                    direccion("extension") = New JArray From {New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionResidenceZone"}, {"valueCoding", New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianResidenceZone"}, {"code", codZona}, {"display", displayZona}}}}}
                End If
                patient("address") = New JArray From {direccion}
            End If
            Return patient
        End Function

        Private Function ConstruirOrganizationSimple(idOrganizacion As String, config As ConfigInteropApi, nombreOrganizacion As String) As JObject
            Dim identificadores As New JArray()
            If Not String.IsNullOrWhiteSpace(config.NitPrestador) Then
                identificadores.Add(New JObject From {
                    {"use", "official"},
                    {"type", New JObject From {{"coding", New JArray From {
                        New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/v2-0203"}, {"code", "TAX"}, {"display", "Tax ID number"}},
                        New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianOrganizationIdentifiers"}, {"code", "NIT"}}
                    }}}},
                    {"value", config.NitPrestador}
                })
            End If
            identificadores.Add(New JObject From {
                {"use", "official"},
                {"type", New JObject From {{"coding", New JArray From {
                    New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/v2-0203"}, {"code", "PRN"}, {"display", "Provider number"}},
                    New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianOrganizationIdentifiers"}, {"code", "CodigoPrestador"}}
                }}}},
                {"system", BASE_RDA & "/NamingSystem/REPS"},
                {"value", config.CodigoPrestadorReps}
            })
            Return New JObject From {
                {"resourceType", "Organization"},
                {"id", idOrganizacion},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/CareDeliveryOrganizationRDA"}}}},
                {"name", nombreOrganizacion},
                {"identifier", identificadores}
            }
        End Function

        Private Function ConstruirPractitionerSimple(idPractitioner As String, especialista As Especialista) As JObject
            Dim tipoIdEspecialista As String = If(Not String.IsNullOrWhiteSpace(especialista.IdTipoIdentificacion), especialista.IdTipoIdentificacion, "CC")
            Dim nameNode As JObject
            If Not String.IsNullOrWhiteSpace(especialista.PrimerNombre) AndAlso Not String.IsNullOrWhiteSpace(especialista.PrimerApellido) Then
                Dim givenPractitioner As New JArray()
                For Each n In {especialista.PrimerNombre, especialista.SegundoNombre}.Where(Function(x) Not String.IsNullOrWhiteSpace(x))
                    givenPractitioner.Add(n)
                Next
                Dim apellidos As String = especialista.PrimerApellido
                If Not String.IsNullOrWhiteSpace(especialista.SegundoApellido) Then apellidos &= " " & especialista.SegundoApellido
                nameNode = New JObject From {
                    {"use", "official"}, {"family", apellidos},
                    {"_family", New JObject From {{"extension", New JArray From {
                        New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionFathersFamilyName"}, {"valueString", especialista.PrimerApellido}},
                        New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionMothersFamilyName"}, {"valueString", especialista.SegundoApellido}}
                    }}}},
                    {"given", givenPractitioner}
                }
            Else
                nameNode = New JObject From {{"use", "official"}, {"text", especialista.Nombre}}
            End If
            Return New JObject From {
                {"resourceType", "Practitioner"},
                {"id", idPractitioner},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/PractitionerRDA"}}}},
                {"identifier", New JArray From {New JObject From {
                    {"id", "NationalPersonIdentifier-0"},
                    {"use", "official"},
                    {"type", New JObject From {{"coding", New JArray From {
                        New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/v2-0203"}, {"code", "PN"}, {"display", "Person number"}},
                        New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianPersonIdentifier"}, {"code", tipoIdEspecialista}}
                    }}}},
                    {"value", especialista.Identificacion}
                }}},
                {"name", New JArray From {nameNode}}
            }
        End Function

        Private Function ConstruirLocationSimple(idLocation As String, idOrganizacion As String, config As ConfigInteropApi, nombreOrganizacion As String) As JObject
            Return New JObject From {
                {"resourceType", "Location"},
                {"id", idLocation},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/CareDeliveryLocationRDA"}}}},
                {"identifier", New JArray From {New JObject From {{"use", "official"}, {"system", BASE_RDA & "/NamingSystem/REPS"}, {"value", idLocation}}}},
                {"status", "active"},
                {"name", nombreOrganizacion},
                {"managingOrganization", New JObject From {{"reference", "#" & idOrganizacion}}}
            }
        End Function

        ''' <summary>Genera un PDF mínimo válido en base64 con un resumen breve del encuentro.</summary>
        Private Function GenerarPdfResumenBase64(paciente As Usuarios, especialista As Especialista, diagnostico As String) As String
            Dim texto As String = $"Resumen RDA - Consulta - {paciente.PrimerNombre} {paciente.PrimerApellido} - CC {paciente.Identificacion} - Dx: {diagnostico}"
            If texto.Length > 90 Then texto = texto.Substring(0, 90)
            Dim contenido As String =
                "%PDF-1.4" & vbLf &
                "1 0 obj<</Type/Catalog/Pages 2 0 R>>endobj" & vbLf &
                "2 0 obj<</Type/Pages/Kids[3 0 R]/Count 1>>endobj" & vbLf &
                "3 0 obj<</Type/Page/Parent 2 0 R/MediaBox[0 0 612 792]/Resources<</Font<</F1 4 0 R>>>>/Contents 5 0 R>>endobj" & vbLf &
                "4 0 obj<</Type/Font/Subtype/Type1/BaseFont/Helvetica>>endobj" & vbLf &
                "5 0 obj<</Length " & (texto.Length + 40).ToString() & ">>" & vbLf &
                "stream" & vbLf &
                "BT /F1 12 Tf 50 750 Td (" & texto.Replace("(", "").Replace(")", "") & ") Tj ET" & vbLf &
                "endstream" & vbLf &
                "endobj" & vbLf &
                "xref" & vbLf & "0 6" & vbLf & "0000000000 65535 f " & vbLf &
                "trailer<</Size 6/Root 1 0 R>>" & vbLf & "startxref" & vbLf & "0" & vbLf & "%%EOF"
            Return Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(contenido))
        End Function

        Private Function EnvolverRecurso(recurso As JObject) As JObject
            Return New JObject From {{"resource", recurso}}
        End Function

        Private Function SanitizarId(valor As String) As String
            If String.IsNullOrWhiteSpace(valor) Then Return "SD"
            Dim limpio = New String(valor.Where(Function(c) Char.IsLetterOrDigit(c) OrElse c = "-"c OrElse c = "."c).ToArray())
            Return If(limpio.Length > 64, limpio.Substring(0, 64), limpio)
        End Function

    End Module

End Namespace

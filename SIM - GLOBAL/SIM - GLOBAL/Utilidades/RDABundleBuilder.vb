Imports Newtonsoft.Json.Linq
Imports SIM___GLOBAL.Modelo

Namespace Utilidades

    ''' <summary>
    ''' Arma el Bundle FHIR tipo "document" para el documento RDA-Paciente
    ''' (perfil CompositionPatientStatementRDA), según la Guía de Implementación FHIR RDA
    ''' de MinSalud (https://vulcano.ihcecol.gov.co/RDA-paciente.html).
    '''
    ''' Alcance de este builder (RDA-Paciente = antecedentes AUTOREPORTADOS por el paciente):
    '''   - Composition, Patient, Organization (IPS), Practitioner
    '''   - Section: Antecedentes farmacológicos     -> MedicationStatement
    '''   - Section: Antecedentes alérgicos           -> AllergyIntolerance
    '''   - Section: Antecedentes patológicos          -> Condition
    '''   - Section: Antecedentes familiares           -> FamilyMemberHistory
    '''
    ''' Los datos de alergias/medicamentos/condiciones se derivan del campo de texto libre
    ''' 'antecedentes_personales' mediante RDATextParser (ver ese módulo para el detalle y
    ''' las limitaciones de esta aproximación).
    ''' </summary>
    Public Module RDABundleBuilder

        Private Const LOINC As String = "http://loinc.org"
        Private Const BASE_RDA As String = "https://fhir.minsalud.gov.co/rda"

        ''' <summary>
        ''' Construye el Bundle completo y lo devuelve como texto JSON, listo para enviar
        ''' en el body del POST a {UrlBaseApi}/Composition/$enviar-rda-paciente
        ''' </summary>
        Public Function ConstruirBundlePaciente(paciente As Usuarios,
                                                  especialista As Especialista,
                                                  config As ConfigInteropApi,
                                                  antecedentesPersonales As String,
                                                  antecedentesFamiliares As String,
                                                  Optional nombreOrganizacion As String = Nothing) As String

            If paciente Is Nothing Then Throw New ArgumentException("No se encontró información del paciente para armar el RDA.")
            If String.IsNullOrWhiteSpace(config.CodigoPrestadorReps) Then
                Throw New InvalidOperationException("Falta configurar el 'Código de habilitación del prestador (REPS)' en Interoperabilidad RDA antes de poder enviar documentos.")
            End If

            ' ── Identificadores de referencia internos del Bundle ─────────────────────
            Dim idPaciente As String = SanitizarId(paciente.CodigotipoIdentificacion & "-" & paciente.Identificacion)
            Dim idOrganizacion As String = SanitizarId(config.CodigoPrestadorReps)
            Dim idPractitioner As String = If(especialista IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(especialista.Identificacion),
                                               SanitizarId(especialista.IdTipoIdentificacion & "-" & especialista.Identificacion),
                                               Nothing)

            ' ── Clasificar antecedentes (best-effort, ver RDATextParser) ──────────────
            Dim alergias As List(Of String) = Nothing
            Dim medicamentos As List(Of String) = Nothing
            Dim condiciones As List(Of String) = Nothing
            RDATextParser.ClasificarAntecedentesPersonales(antecedentesPersonales, alergias, medicamentos, condiciones)
            Dim familiares As List(Of String) = RDATextParser.ExtraerAntecedentesFamiliares(antecedentesFamiliares)

            ' ── Construir recursos referenciados y juntar sus ids para las secciones ──
            Dim entradasCondition As New JArray()
            Dim entradasAllergy As New JArray()
            Dim entradasMedication As New JArray()
            Dim entradasFamily As New JArray()

            Dim recursosCondition As New JArray()
            Dim recursosAllergy As New JArray()
            Dim recursosMedication As New JArray()
            Dim recursosFamily As New JArray()

            For i As Integer = 0 To condiciones.Count - 1
                Dim idRec = $"Condition-{i}"
                recursosCondition.Add(EnvolverRecurso(ConstruirCondition(idRec, idPaciente, condiciones(i))))
                entradasCondition.Add(New JObject From {{"reference", "#" & idRec}})
            Next

            For i As Integer = 0 To alergias.Count - 1
                Dim idRec = $"AllergyIntolerance-{i}"
                recursosAllergy.Add(EnvolverRecurso(ConstruirAllergy(idRec, idPaciente, alergias(i))))
                entradasAllergy.Add(New JObject From {{"reference", "#" & idRec}})
            Next

            For i As Integer = 0 To medicamentos.Count - 1
                Dim idRec = $"MedicationStatement-{i}"
                recursosMedication.Add(EnvolverRecurso(ConstruirMedicationStatement(idRec, idPaciente, medicamentos(i))))
                entradasMedication.Add(New JObject From {{"reference", "#" & idRec}})
            Next

            For i As Integer = 0 To familiares.Count - 1
                Dim idRec = $"FamilyMemberHistory-{i}"
                recursosFamily.Add(EnvolverRecurso(ConstruirFamilyMemberHistory(idRec, idPaciente, familiares(i))))
                entradasFamily.Add(New JObject From {{"reference", "#" & idRec}})
            Next

            ' ── Secciones de la Composition (con emptyReason si no hay datos) ─────────
            Dim secciones As New JArray From {
                ConstruirSeccion("Historial de diagnósticos de problemas de salud", "11450-4", "Problem list - Reported", entradasCondition),
                ConstruirSeccion("Historial de alergias, intolerancias y reacciones adversas", "48765-2", "Allergies and adverse reactions Document", entradasAllergy),
                ConstruirSeccion("Historial de medicamentos", "10160-0", "History of Medication use Narrative", entradasMedication),
                ConstruirSeccion("Historial de antecedentes familiares", "10157-6", "History of family member diseases Narrative", entradasFamily)
            }

            ' ── Composition ────────────────────────────────────────────────────────
            Dim autores As New JArray()
            ' Composition.author en RDA-Paciente debe ser el PACIENTE mismo (es un autoreporte),
            ' no la Organization ni el Practitioner. Ver guía oficial vulcano.ihcecol.gov.co/RDA-paciente:
            ' "Composition.author: en este caso, el paciente mismo puede figurar como autor,
            ' modelado como un recurso Patient o, en algunos casos, RelatedPerson."
            autores.Add(New JObject From {{"reference", "#" & idPaciente}})

            Dim composition As New JObject From {
                {"resourceType", "Composition"},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/CompositionPatientStatementRDA"}}}},
                {"status", "final"},
                {"type", New JObject From {
                    {"coding", New JArray From {
                        New JObject From {
                            {"system", LOINC},
                            {"code", "102089-0"},
                            {"display", "FHIR resource patient medical record"}
                        }
                    }}
                }},
                {"subject", New JObject From {{"reference", "#" & idPaciente}}},
                {"date", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")},
                {"author", autores},
                {"title", "Resumen Digital de Atención en Salud - RDA de antecedentes manifestados por el paciente"},
                {"confidentiality", "N"},
                {"attester", New JArray From {
                    New JObject From {
                        {"mode", "legal"},
                        {"party", New JObject From {{"reference", "#" & idOrganizacion}}}
                    }
                }},
                {"custodian", New JObject From {{"reference", "#" & idOrganizacion}}},
                {"event", New JObject From {
                    {"code", New JArray From {
                        New JObject From {
                            {"id", "eventCodeModality"},
                            {"coding", New JArray From {
                                New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianTechModality"}, {"code", "01"}, {"display", "Intramural"}}
                            }}
                        },
                        New JObject From {
                            {"id", "eventCodeServiceGroup"},
                            {"coding", New JArray From {
                                New JObject From {{"system", BASE_RDA & "/CodeSystem/GrupoServicios"}, {"code", "01"}, {"display", "Consulta externa"}}
                            }}
                        }
                    }},
                    {"period", New JObject From {
                        {"start", DateTime.Now.AddMinutes(-5).ToString("yyyy-MM-ddTHH:mm:sszzz")},
                        {"end", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")}
                    }}
                }},
                {"section", secciones}
            }

            ' ── Bundle final ───────────────────────────────────────────────────────
            Dim entradas As New JArray()
            entradas.Add(EnvolverRecurso(composition))
            entradas.Add(EnvolverRecurso(ConstruirPatient(idPaciente, paciente)))
            entradas.Add(EnvolverRecurso(ConstruirOrganization(idOrganizacion, config, nombreOrganizacion)))
            If idPractitioner IsNot Nothing Then
                entradas.Add(EnvolverRecurso(ConstruirPractitioner(idPractitioner, especialista)))
            End If
            For Each r In recursosCondition : entradas.Add(r) : Next
            For Each r In recursosAllergy : entradas.Add(r) : Next
            For Each r In recursosMedication : entradas.Add(r) : Next
            For Each r In recursosFamily : entradas.Add(r) : Next

            Dim bundle As New JObject From {
                {"resourceType", "Bundle"},
                {"language", "es-CO"},
                {"type", "document"},
                {"entry", entradas}
            }

            Return bundle.ToString(Newtonsoft.Json.Formatting.Indented)
        End Function

        ' ───────────────────────────── Recursos individuales ─────────────────────────────

        Private Function ConstruirSeccion(titulo As String, codigoLoinc As String, display As String, entradas As JArray) As JObject
            Dim seccion As New JObject From {
                {"title", titulo},
                {"code", New JObject From {
                    {"coding", New JArray From {
                        New JObject From {{"system", LOINC}, {"code", codigoLoinc}, {"display", display}}
                    }}
                }}
            }
            If entradas.Count > 0 Then
                seccion("entry") = entradas
            Else
                ' Sin información reportada por el paciente en esta categoría: se documenta
                ' explícitamente con emptyReason (según la guía RDA). La restricción cmp-1 del
                ' perfil exige ADEMÁS un "text" narrativo: emptyReason por sí solo no basta.
                seccion("emptyReason") = New JObject From {
                    {"coding", New JArray From {
                        New JObject From {
                            {"system", "http://terminology.hl7.org/CodeSystem/list-empty-reason"},
                            {"code", "unavailable"},
                            {"display", "Unavailable"}
                        }
                    }}
                }
                seccion("text") = New JObject From {
                    {"status", "generated"},
                    {"div", "<div xmlns='http://www.w3.org/1999/xhtml'>No existen elementos conocidos para esta lista y/o el paciente no declara información</div>"}
                }
            End If
            Return seccion
        End Function

        Private Function ConstruirPatient(idPaciente As String, paciente As Usuarios) As JObject
            Dim generoFhir As String = "unknown"
            If paciente.Sexo IsNot Nothing Then
                Select Case paciente.Sexo.Trim().ToUpperInvariant()
                    Case "M" : generoFhir = "male"
                    Case "F" : generoFhir = "female"
                End Select
            End If

            Dim nombresValidos As String() = {paciente.PrimerNombre, paciente.SegundoNombre}.
                Where(Function(n) Not String.IsNullOrWhiteSpace(n)).ToArray()

            Dim given As New JArray()
            For Each n In nombresValidos
                given.Add(n)
            Next

            Dim nombre As New JObject From {
                {"use", "official"},
                {"family", (paciente.PrimerApellido & " " & paciente.SegundoApellido).Trim()},
                {"given", given}
            }
            ' El registro nacional (EVOL) valida el apellido paterno/materno por separado, no el
            ' campo "family" combinado; sin esta extensión, MinSalud rechaza el Bundle con
            ' err-000 "El apellido... no coincide como primer apellido" aunque "family" sea correcto.
            If Not String.IsNullOrWhiteSpace(paciente.PrimerApellido) Then
                Dim extensionesApellido As New JArray From {
                    New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionFathersFamilyName"}, {"valueString", paciente.PrimerApellido}}
                }
                If Not String.IsNullOrWhiteSpace(paciente.SegundoApellido) Then
                    extensionesApellido.Add(New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionMothersFamilyName"}, {"valueString", paciente.SegundoApellido}})
                End If
                nombre("_family") = New JObject From {{"extension", extensionesApellido}}
            End If

            Dim direccion As New JObject From {
                {"id", "HomeAddress-0"},
                {"use", "home"},
                {"type", "physical"},
                {"country", "Colombia"},
                {"_country", New JObject From {
                    {"extension", New JArray From {
                        New JObject From {
                            {"url", BASE_RDA & "/StructureDefinition/ExtensionCountryCode"},
                            {"valueCoding", New JObject From {{"system", BASE_RDA & "/CodeSystem/ISO31661"}, {"code", "170"}}}
                        }
                    }}
                }}
            }
            If Not String.IsNullOrWhiteSpace(paciente.CodigoMunicipio) Then
                direccion("_city") = New JObject From {
                    {"extension", New JArray From {
                        New JObject From {
                            {"url", BASE_RDA & "/StructureDefinition/ExtensionDivipolaMunicipality"},
                            {"valueCoding", New JObject From {{"code", paciente.CodigoMunicipio}, {"system", BASE_RDA & "/CodeSystem/DIVIPOLA"}}}
                        }
                    }}
                }
            End If
            If Not String.IsNullOrWhiteSpace(paciente.Zona) Then
                Dim codZona As String = If(paciente.Zona.Trim().ToUpperInvariant() = "R", "01", "02")
                Dim displayZona As String = If(codZona = "01", "Rural", "Urbana")
                direccion("extension") = New JArray From {
                    New JObject From {
                        {"url", BASE_RDA & "/StructureDefinition/ExtensionResidenceZone"},
                        {"valueCoding", New JObject From {
                            {"system", BASE_RDA & "/CodeSystem/ColombianResidenceZone"},
                            {"code", codZona},
                            {"display", displayZona}
                        }}
                    }
                }
            End If

            ' ── Extensiones obligatorias del perfil PatientRDA (mínimo 3: Nationality, Ethnicity,
            ' Disability). El SIM actualmente NO captura etnia ni discapacidad del paciente, así que
            ' se usa un valor por defecto explícito ("Otras etnias" / "Sin discapacidad") en vez de
            ' dejarlas vacías, ya que el validador de MinSalud las exige. Esto es un placeholder
            ' razonable, NO un dato clínico verificado: para producción real se recomienda capturar
            ' estos campos en el formulario de pacientes (ver análisis de brechas entregado aparte).
            Dim extensionesPaciente As New JArray From {
                New JObject From {
                    {"url", BASE_RDA & "/StructureDefinition/ExtensionPatientNationality"},
                    {"valueCoding", New JObject From {{"system", BASE_RDA & "/CodeSystem/ISO31661"}, {"code", "170"}, {"display", "Colombia"}}}
                },
                New JObject From {
                    {"url", BASE_RDA & "/StructureDefinition/ExtensionPatientEthnicity"},
                    {"valueCoding", New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianEthnicGroup"}, {"code", "6"}, {"display", "Otras etnias"}}}
                },
                New JObject From {
                    {"url", BASE_RDA & "/StructureDefinition/ExtensionPatientDisability"},
                    {"valueCoding", New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianDisabilityClassification"}, {"code", "08"}, {"display", "Sin discapacidad"}}}
                }
            }

            Dim patient As New JObject From {
                {"resourceType", "Patient"},
                {"id", idPaciente},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/PatientRDA"}}}},
                {"extension", extensionesPaciente},
                {"identifier", New JArray From {
                    New JObject From {
                        {"id", "NationalPersonIdentifier-0"},
                        {"type", New JObject From {
                            {"coding", New JArray From {
                                New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/v2-0203"}, {"code", "PN"}, {"display", "Person number"}},
                                New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianPersonIdentifier"}, {"code", paciente.CodigotipoIdentificacion}}
                            }}
                        }},
                        {"use", "official"},
                        {"system", BASE_RDA & "/NamingSystem/RNEC"},
                        {"value", paciente.Identificacion}
                    }
                }},
                {"name", New JArray From {nombre}},
                {"address", New JArray From {direccion}},
                {"active", True},
                {"gender", generoFhir},
                {"birthDate", If(paciente.FechaNacimiento = Date.MinValue, Nothing, paciente.FechaNacimiento.ToString("yyyy-MM-dd"))}
            }

            ' Extensión obligatoria de género biológico dentro de Patient.gender (_gender), separada
            ' del campo "gender" administrativo de FHIR.
            Dim codigoGeneroBiologico As String = If(generoFhir = "male", "01", If(generoFhir = "female", "02", Nothing))
            If codigoGeneroBiologico IsNot Nothing Then
                patient("_gender") = New JObject From {
                    {"extension", New JArray From {
                        New JObject From {
                            {"url", BASE_RDA & "/StructureDefinition/ExtensionBiologicalGender"},
                            {"valueCoding", New JObject From {
                                {"system", BASE_RDA & "/CodeSystem/ColombianGenderGroup"},
                                {"code", codigoGeneroBiologico},
                                {"display", If(codigoGeneroBiologico = "01", "Hombre", "Mujer")}
                            }}
                        }
                    }}
                }
            End If

            Return patient
        End Function

        Private Function ConstruirOrganization(idOrganizacion As String, config As ConfigInteropApi, Optional nombreOrganizacion As String = Nothing) As JObject
            Dim identificadores As New JArray()

            If Not String.IsNullOrWhiteSpace(config.NitPrestador) Then
                identificadores.Add(New JObject From {
                    {"use", "official"},
                    {"type", New JObject From {
                        {"coding", New JArray From {
                            New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/v2-0203"}, {"code", "TAX"}, {"display", "Tax ID number"}},
                            New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianOrganizationIdentifiers"}, {"code", "NIT"}, {"display", "Número de Identificación Tributaria"}}
                        }}
                    }},
                    {"value", config.NitPrestador}
                })
            End If

            identificadores.Add(New JObject From {
                {"use", "official"},
                {"type", New JObject From {
                    {"coding", New JArray From {
                        New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/v2-0203"}, {"code", "PRN"}, {"display", "Provider number"}},
                        New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianOrganizationIdentifiers"}, {"code", "CodigoPrestador"}, {"display", "Código de habilitación de prestador de servicios de salud"}}
                    }}
                }},
                {"system", BASE_RDA & "/NamingSystem/REPS"},
                {"value", config.CodigoPrestadorReps}
            })

            Dim organization As New JObject From {
                {"resourceType", "Organization"},
                {"id", idOrganizacion},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/CareDeliveryOrganizationRDA"}}}},
                {"identifier", identificadores}
            }
            If Not String.IsNullOrWhiteSpace(nombreOrganizacion) Then
                organization("name") = nombreOrganizacion
            End If
            Return organization
        End Function

        Private Function ConstruirPractitioner(idPractitioner As String, especialista As Especialista) As JObject
            ' Nombre estructurado si está disponible (requerido para que coincida con el registro
            ' oficial de RETHUS, igual que ocurre con el Patient contra EVOL); si no hay datos
            ' estructurados, se hace mejor esfuerzo usando "text" con el nombre completo.
            Dim nameNode As JObject
            If Not String.IsNullOrWhiteSpace(especialista.PrimerNombre) AndAlso Not String.IsNullOrWhiteSpace(especialista.PrimerApellido) Then
                Dim givenPractitioner As New JArray()
                For Each n In {especialista.PrimerNombre, especialista.SegundoNombre}.Where(Function(x) Not String.IsNullOrWhiteSpace(x))
                    givenPractitioner.Add(n)
                Next

                Dim apellidos As String = especialista.PrimerApellido
                If Not String.IsNullOrWhiteSpace(especialista.SegundoApellido) Then
                    apellidos &= " " & especialista.SegundoApellido
                End If

                nameNode = New JObject From {
                    {"use", "official"},
                    {"family", apellidos},
                    {"_family", New JObject From {
                        {"extension", New JArray From {
                            New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionFathersFamilyName"}, {"valueString", especialista.PrimerApellido}},
                            New JObject From {{"url", BASE_RDA & "/StructureDefinition/ExtensionMothersFamilyName"}, {"valueString", especialista.SegundoApellido}}
                        }}
                    }},
                    {"given", givenPractitioner}
                }
            Else
                nameNode = New JObject From {
                    {"use", "official"},
                    {"text", especialista.Nombre}
                }
            End If

            Return New JObject From {
                {"resourceType", "Practitioner"},
                {"id", idPractitioner},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/PractitionerRDA"}}}},
                {"identifier", New JArray From {
                    New JObject From {
                        {"use", "official"},
                        {"type", New JObject From {
                            {"coding", New JArray From {
                                New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/v2-0203"}, {"code", "PN"}, {"display", "Person number"}},
                                New JObject From {{"system", BASE_RDA & "/CodeSystem/ColombianPersonIdentifier"}, {"code", especialista.IdTipoIdentificacion}}
                            }}
                        }},
                        {"value", especialista.Identificacion}
                    }
                }},
                {"name", New JArray From {nameNode}}
            }
        End Function

        Private Function ConstruirCondition(idRecurso As String, idPaciente As String, textoLibre As String) As JObject
            Return New JObject From {
                {"resourceType", "Condition"},
                {"id", idRecurso},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/ConditionStatementRDA"}}}},
                {"clinicalStatus", New JObject From {
                    {"coding", New JArray From {New JObject From {{"code", "active"}, {"system", "http://terminology.hl7.org/CodeSystem/condition-clinical"}, {"display", "Active"}}}}
                }},
                {"verificationStatus", New JObject From {
                    {"coding", New JArray From {New JObject From {{"code", "unconfirmed"}, {"display", "Unconfirmed"}}}}
                }},
                {"category", New JArray From {
                    New JObject From {{"coding", New JArray From {New JObject From {{"system", "http://terminology.hl7.org/CodeSystem/condition-category"}, {"code", "encounter-diagnosis"}, {"display", "Encounter Diagnosis"}}}}}
                }},
                {"code", New JObject From {{"text", textoLibre}}},
                {"subject", New JObject From {{"reference", "#" & idPaciente}}}
            }
        End Function

        Private Function ConstruirAllergy(idRecurso As String, idPaciente As String, textoLibre As String) As JObject
            Return New JObject From {
                {"resourceType", "AllergyIntolerance"},
                {"id", idRecurso},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/AllergyIntoleranceStatementRDA"}}}},
                {"clinicalStatus", New JObject From {
                    {"coding", New JArray From {New JObject From {{"code", "active"}, {"display", "Active"}}}}
                }},
                {"verificationStatus", New JObject From {
                    {"coding", New JArray From {New JObject From {{"code", "unconfirmed"}, {"display", "Unconfirmed"}}}}
                }},
                {"code", New JObject From {{"text", textoLibre}}},
                {"patient", New JObject From {{"reference", "#" & idPaciente}}}
            }
        End Function

        Private Function ConstruirMedicationStatement(idRecurso As String, idPaciente As String, textoLibre As String) As JObject
            Return New JObject From {
                {"resourceType", "MedicationStatement"},
                {"id", idRecurso},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/MedicationStatementRDA"}}}},
                {"status", "completed"},
                {"medicationCodeableConcept", New JObject From {{"text", textoLibre}}},
                {"subject", New JObject From {{"reference", "#" & idPaciente}}}
            }
        End Function

        Private Function ConstruirFamilyMemberHistory(idRecurso As String, idPaciente As String, textoLibre As String) As JObject
            Dim parentesco = RDATextParser.DetectarParentesco(textoLibre)
            Dim codigoParentesco As String = If(parentesco.HasValue, parentesco.Value.Codigo, "99")
            Dim displayParentesco As String = If(parentesco.HasValue, parentesco.Value.Display, "Otro / No especificado")

            Return New JObject From {
                {"resourceType", "FamilyMemberHistory"},
                {"id", idRecurso},
                {"meta", New JObject From {{"profile", New JArray From {BASE_RDA & "/StructureDefinition/FamilyMemberHistoryRDA"}}}},
                {"status", "partial"},
                {"patient", New JObject From {{"reference", "#" & idPaciente}}},
                {"relationship", New JObject From {
                    {"coding", New JArray From {
                        New JObject From {{"system", BASE_RDA & "/CodeSystem/ParentescoAntecedente"}, {"code", codigoParentesco}, {"display", displayParentesco}}
                    }}
                }},
                {"condition", New JArray From {
                    New JObject From {{"code", New JObject From {{"text", textoLibre}}}}
                }}
            }
        End Function

        ' ───────────────────────────── Utilidades ─────────────────────────────

        Private Function EnvolverRecurso(recurso As JObject) As JObject
            Return New JObject From {{"resource", recurso}}
        End Function

        ''' <summary>
        ''' Genera un id de recurso FHIR válido (letras, números, '-', '.') a partir de un
        ''' identificador arbitrario, eliminando espacios y caracteres no permitidos.
        ''' </summary>
        Private Function SanitizarId(valor As String) As String
            If String.IsNullOrWhiteSpace(valor) Then Return "SD"
            Dim limpio = New String(valor.Where(Function(c) Char.IsLetterOrDigit(c) OrElse c = "-"c OrElse c = "."c).ToArray())
            Return If(limpio.Length > 64, limpio.Substring(0, 64), limpio)
        End Function

    End Module

End Namespace

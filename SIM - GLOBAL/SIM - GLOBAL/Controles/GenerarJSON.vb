Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Namespace Controles
    Public Class GenerarJSON
        Public Shared Sub GenerarFacturaJson()
            Dim factura = New With {
        .numDocumentoIdObligado = "900329923",
        .numFactura = "GAST1957",
        .tipoNota = CType(Nothing, String),
        .numNota = CType(Nothing, String),
        .usuarios = New Object() {
            New With {
                .tipoDocumentoIdentificacion = "CC",
                .numDocumentoIdentificacion = "22806609",
                .tipoUsuario = "04",
                .fechaNacimiento = "1971-07-21",
                .codSexo = "F",
                .codPaisResidencia = "170",
                .codMunicipioResidencia = "13001",
                .codZonaTerritorialResidencia = "02",
                .incapacidad = "NO",
                .consecutivo = 1,
                .codPaisOrigen = "170",
                .servicios = New With {
                    .procedimientos = New Object() {
                        New With {
                            .codPrestador = "130010244901",
                            .fechaInicioAtencion = "2025-04-01 11:30",
                            .idMIPRES = CType(Nothing, String),
                            .numAutorizacion = "1300105212154",
                            .codProcedimiento = "903043",
                            .viaIngresoServicioSalud = "02",
                            .modalidadGrupoServicioTecSal = "01",
                            .grupoServicios = "02",
                            .codServicio = 706,
                            .finalidadTecnologiaSalud = "15",
                            .tipoDocumentoIdentificacion = "CC",
                            .numDocumentoIdentificacion = "73106055",
                            .codDiagnosticoPrincipal = "K30X",
                            .codDiagnosticoRelacionado = CType(Nothing, String),
                            .codComplicacion = CType(Nothing, String),
                            .vrServicio = 265000,
                            .conceptoRecaudo = "05",
                            .valorPagoModerador = 0,
                            .numFEVPagoModerador = CType(Nothing, String),
                            .consecutivo = 1
                        }
                    }
                }
            }
        }
    }

            ' Serializar a JSON
            Dim json As String = JsonConvert.SerializeObject(factura, Formatting.Indented)

            ' Guardar en archivo (ajusta la ruta si es necesario)
            Dim rutaArchivo = "C:\Otros Documentos\Proyectos\Rips\salida.json"
            File.WriteAllText(rutaArchivo, json, Encoding.UTF8)

            MessageBox.Show("Archivo JSON generado exitosamente en:" & vbCrLf & rutaArchivo)
        End Sub
    End Class

End Namespace



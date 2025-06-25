
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmImprimir
    Public Sub CargarReporte(ByVal reporte As String, ByVal data As String)
        'Try
        'Dim report As ReportDocument
        Dim report = New ReportDocument
        report.Load(Application.StartupPath + "\Reportes\" + reporte)

        If Not (String.IsNullOrEmpty(data)) Then
            Dim crParameterDiscreteValue As New ParameterDiscreteValue

            crParameterDiscreteValue.Value = data
            Dim crParameterFieldDefinitions As ParameterFieldDefinitions = report.DataDefinition.ParameterFields()
            Dim crParameterFieldDefinition As ParameterFieldDefinition = crParameterFieldDefinitions.Item("filtro")
            Dim crParameterValues As ParameterValues = crParameterFieldDefinition.CurrentValues

            crParameterValues.Clear()
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        End If

        crv.ReportSource = report
        crv.Refresh()
        ShowDialog()
        'crv.PrintReport()
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Public Sub ImprimirReporte(ByVal reporte As String, ByVal data As String)
        Try

            Dim report = New ReportDocument
            report.Load(Application.StartupPath + "\Reportes\" + reporte)

            If Not (String.IsNullOrEmpty(data)) Then
                Dim crParameterDiscreteValue As New ParameterDiscreteValue

                crParameterDiscreteValue.Value = data
                Dim crParameterFieldDefinitions As ParameterFieldDefinitions = report.DataDefinition.ParameterFields()
                Dim crParameterFieldDefinition As ParameterFieldDefinition = crParameterFieldDefinitions.Item("filtro")
                Dim crParameterValues As ParameterValues = crParameterFieldDefinition.CurrentValues

                crParameterValues.Clear()
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            End If

            crv.ReportSource = report
            crv.Refresh()
            'ShowDialog()
            crv.PrintReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirAgenda(ByVal Fecha As String, ByVal Especialista As String)
        Try
            Dim rptAgenda As New rptAgendaEntidad
            rptAgenda.SetParameterValue("filtro", Fecha)
            rptAgenda.SetParameterValue("filtro2", Especialista)
            crv.ReportSource = rptAgenda
            crv.Refresh()
            ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub ImprimirReserva(ByVal Fecha As String, ByVal Salon As String)
        Try
            Dim rptReserva As New rptAgendaEntidad
            rptReserva.SetParameterValue("filtro", Fecha)
            rptReserva.SetParameterValue("filtro2", Salon)
            crv.ReportSource = rptReserva
            crv.Refresh()
            ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirCodigoBarra(ByVal Filtro As String)
        Try
            Dim rptCodigoBarra As New rptCodigoBarra
            rptCodigoBarra.SetParameterValue("filtro", Filtro)
            crv.ReportSource = rptCodigoBarra
            crv.Refresh()
            ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ActualizarReporte(ByVal reporte As String, ByVal data As String)
        'Try
        'Dim report As ReportDocument
        Dim report = New ReportDocument
        report.Load(Application.StartupPath + "\Reportes\" + reporte)

        If Not (String.IsNullOrEmpty(data)) Then
            Dim crParameterDiscreteValue As New ParameterDiscreteValue

            crParameterDiscreteValue.Value = data
            Dim crParameterFieldDefinitions As ParameterFieldDefinitions = report.DataDefinition.ParameterFields()
            Dim crParameterFieldDefinition As ParameterFieldDefinition = crParameterFieldDefinitions.Item("filtro")
            Dim crParameterValues As ParameterValues = crParameterFieldDefinition.CurrentValues

            crParameterValues.Clear()
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        End If

        crv.ReportSource = report
        crv.Refresh()
        'ShowDialog()
        'crv.PrintReport()
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
    End Sub
#Region "HISTORIA"
    Public Sub ImprimirHistoria(ByVal filtro As String, ByVal Reporte As String, ByVal Licencia As String)
        Try
            Select Case Licencia
                Case "1"
                    MsgBox("MARTINEZ")
                Case "2"
                    MsgBox("INMUNOPAT")
                Case "3" 'DITEG
                    MsgBox("DITEG")
                Case "4" 'GASTROLAP
                    'cambios del la clase reporte para gastrolap
                    'Dim rptHistoriaClinica As New rptHistoriaClinicaGL
                    Dim rptHistoriaClinica As New rptHistoriaClinica
                    rptHistoriaClinica.SetParameterValue("filtro", filtro)
                    rptHistoriaClinica.SetParameterValue("reporte", Reporte)
                    crv.ReportSource = rptHistoriaClinica
                    crv.Refresh()
                    ShowDialog()

                Case "5"
                    MsgBox("INTEGRA")
                Case "6"
                    MsgBox("KELLY")
                Case "9" 'BEATRIZ LINCE
                    Dim rptHistoriaClinica As New rptHistoriaClinica
                    rptHistoriaClinica.SetParameterValue("filtro", filtro)
                    rptHistoriaClinica.SetParameterValue("reporte", Reporte)
                    crv.ReportSource = rptHistoriaClinica
                    crv.Refresh()
                    ShowDialog()
                Case "10"
                    MsgBox("FANNY")
                Case "14" 'FERNANDO PONCE
                    Dim rptHistoriaClinica As New rptHistoriaClinica
                    rptHistoriaClinica.SetParameterValue("filtro", filtro)
                    rptHistoriaClinica.SetParameterValue("reporte", Reporte)
                    crv.ReportSource = rptHistoriaClinica
                    crv.Refresh()
                    ShowDialog()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirOrdenMedica(ByVal filtro As String, ByVal Licencia As String, ByVal OrdenMedica As String)
        Try
            Select Case OrdenMedica
                Case "LABORATORIOS"
                    Select Case Licencia
                        Case 3 'DITEG
                            Dim rptLaboratorios As New rptLaboratoriosDiteg
                            rptLaboratorios.SetParameterValue("filtro", filtro)
                            rptLaboratorios.SetParameterValue("licencia", Licencia)
                            crv.ReportSource = rptLaboratorios
                            crv.Refresh()
                            ShowDialog()
                        Case 4 'Gastrolap
                            Dim rptLaboratorios As New rptLaboratoriosMR
                            rptLaboratorios.SetParameterValue("filtro", filtro)
                            rptLaboratorios.SetParameterValue("licencia", Licencia)
                            crv.ReportSource = rptLaboratorios
                            crv.Refresh()
                            ShowDialog()
                    End Select

                Case "ESTUDIOS DIAGNOSTICOS"
                    Select Case Licencia
                        Case 3 'Diteg
                            Dim rptEstudios As New rptEstudiosDiagnosticosDiteg
                            rptEstudios.SetParameterValue("filtro", filtro)
                            rptEstudios.SetParameterValue("licencia", Licencia)
                            crv.ReportSource = rptEstudios
                            crv.Refresh()
                            ShowDialog()
                        Case 4 ' Gastrolap
                            Dim rptEstudios As New rptEstudiosDiagnosticosMR
                            rptEstudios.SetParameterValue("filtro", filtro)
                            rptEstudios.SetParameterValue("licencia", Licencia)
                            crv.ReportSource = rptEstudios
                            crv.Refresh()
                            ShowDialog()
                    End Select

                Case "PROCEDIMIENTOS"
                    Select Case Licencia
                        Case 3 'Diteg
                            Dim rptProcedimientos As New rptProcedimientosditeg
                            rptProcedimientos.SetParameterValue("filtro", filtro)
                            rptProcedimientos.SetParameterValue("licencia", Licencia)
                            crv.ReportSource = rptProcedimientos
                            crv.Refresh()
                            ShowDialog()
                        Case 4 'Gastrolap
                            Dim rptProcedimientos As New rptProcedimientosMR
                            rptProcedimientos.SetParameterValue("filtro", filtro)
                            rptProcedimientos.SetParameterValue("licencia", Licencia)
                            crv.ReportSource = rptProcedimientos
                            crv.Refresh()
                            ShowDialog()
                    End Select
                Case "MEDICAMENTOS"
                    Select Case Licencia
                        Case 3 'Diteg
                            Dim rptFormulacionDiteg As New rptFormulacionDiteg
                            rptFormulacionDiteg.SetParameterValue("filtro", filtro)
                            rptFormulacionDiteg.SetParameterValue("licencia", Licencia)
                            crv.ReportSource = rptFormulacionDiteg
                            crv.Refresh()
                            ShowDialog()
                        Case 4 ' Gastrolap
                            Dim rptFormulacion As New rptFormulacionMR
                            rptFormulacion.SetParameterValue("filtro", filtro)
                            rptFormulacion.SetParameterValue("licencia", Licencia)
                            crv.ReportSource = rptFormulacion
                            crv.Refresh()
                            ShowDialog()
                    End Select

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "endoscopia"
    Public Sub ImprimirEndoscopia(ByVal filtro As String, ByVal Reporte As String, ByVal Licencia As String, ByVal Fotos As String)
        Try
            Select Case Licencia
                Case "1"
                    MsgBox("MARTINEZ")
                Case "2"
                    MsgBox("INMUNOPAT")
                Case "3" 'DITEG
                    Dim rptEndoscopiaGL As New rptEndoscopiaDiteg
                    rptEndoscopiaGL.SetParameterValue("filtro", filtro)
                    rptEndoscopiaGL.SetParameterValue("reporte", Reporte)
                    rptEndoscopiaGL.SetParameterValue("fotos", Fotos)
                    crv.ReportSource = rptEndoscopiaGL
                    crv.Refresh()
                    ShowDialog()

                Case "4" 'GASTROLAP
                    Dim rptEndoscopiaGL As New rptImgEndoscopiaGL
                    rptEndoscopiaGL.SetParameterValue("filtro", filtro)
                    rptEndoscopiaGL.SetParameterValue("reporte", Reporte)
                    rptEndoscopiaGL.SetParameterValue("fotos", Fotos)
                    crv.ReportSource = rptEndoscopiaGL
                    crv.Refresh()
                    ShowDialog()
                Case "5"
                    MsgBox("INTEGRA")
                Case "6"
                    MsgBox("KELLY")
                Case "9"
                    MsgBox("BAETRIZ")
                Case "10"
                    MsgBox("FANNY")
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirColonoscopia(ByVal filtro As String, ByVal Reporte As String, ByVal Licencia As String, ByVal Fotos As String)
        Try
            Select Case Licencia
                Case "1"
                    MsgBox("MARTINEZ")
                Case "2"
                    MsgBox("INMUNOPAT")
                Case "3" 'DITEG
                    MsgBox("DITEG")
                Case "4" 'GASTROLAP
                    Dim rptColonoscopiaGL As New rptImgColonoscopiaGL
                    rptColonoscopiaGL.SetParameterValue("filtro", filtro)
                    rptColonoscopiaGL.SetParameterValue("reporte", Reporte)
                    rptColonoscopiaGL.SetParameterValue("fotos", Fotos)
                    crv.ReportSource = rptColonoscopiaGL
                    crv.Refresh()
                    ShowDialog()

                Case "5"
                    MsgBox("INTEGRA")
                Case "6"
                    MsgBox("KELLY")
                Case "9"
                    MsgBox("BAETRIZ")
                Case "10"
                    MsgBox("FANNY")
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirRectoscopia(ByVal filtro As String, ByVal Reporte As String, ByVal Licencia As String, ByVal Fotos As String)
        Try
            Select Case Licencia
                Case "1"
                    MsgBox("MARTINEZ")
                Case "2"
                    MsgBox("INMUNOPAT")
                Case "3" 'DITEG
                    MsgBox("DITEG")
                Case "4" 'GASTROLAP
                    Dim rptRectoscopiaGL As New rptImgRectoscopiaGL
                    rptRectoscopiaGL.SetParameterValue("filtro", filtro)
                    rptRectoscopiaGL.SetParameterValue("reporte", Reporte)
                    rptRectoscopiaGL.SetParameterValue("fotos", Fotos)
                    crv.ReportSource = rptRectoscopiaGL
                    crv.Refresh()
                    ShowDialog()
                Case "5"
                    MsgBox("INTEGRA")
                Case "6"
                    MsgBox("KELLY")
                Case "9"
                    MsgBox("BAETRIZ")
                Case "10"
                    MsgBox("FANNY")
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirEstudiosEspeciales(ByVal filtro As String, ByVal Reporte As String, ByVal Licencia As String, ByVal Fotos As String)
        Try
            Select Case Licencia
                Case "1"
                    MsgBox("MARTINEZ")
                Case "2"
                    MsgBox("INMUNOPAT")
                Case "3" 'DITEG
                    MsgBox("DITEG")
                Case "4" 'GASTROLAP
                    Dim rptEstudiosEspecialesGL As New rptImgEstudiosEspecialesGL
                    rptEstudiosEspecialesGL.SetParameterValue("filtro", filtro)
                    rptEstudiosEspecialesGL.SetParameterValue("reporte", Reporte)
                    rptEstudiosEspecialesGL.SetParameterValue("fotos", Fotos)
                    crv.ReportSource = rptEstudiosEspecialesGL
                    crv.Refresh()
                    ShowDialog()
                Case "5"
                    MsgBox("INTEGRA")
                Case "6"
                    MsgBox("KELLY")
                Case "9"
                    MsgBox("BAETRIZ")
                Case "10"
                    MsgBox("FANNY")
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region
#Region "PATOLOGIA"
    Public Sub ImprimirPatologia(ByVal filtro As String, ByVal Reporte As String, ByVal Licencia As String, ByVal Fotos As String, ByVal VistaPrevia As Boolean)
        Try
            Select Case Licencia
                Case "11" 'CITOPAT DE LA COSTA
                    Dim rptPatologia As New rptPatologia
                    rptPatologia.SetParameterValue("filtro", filtro)
                    'rptEndoscopiaGL.SetParameterValue("reporte", Reporte)
                    'rptEndoscopiaGL.SetParameterValue("fotos", Fotos)
                    crv.ReportSource = rptPatologia
                    crv.Refresh()
                    If VistaPrevia = True Then
                        ShowDialog()
                    Else
                        crv.PrintReport()
                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirCitologia(ByVal filtro As String, ByVal Reporte As String, ByVal Licencia As String, ByVal Fotos As String, ByVal VistaPrevia As Boolean)
        Try
            Select Case Licencia
                Case "6" 'KELLY GOMEZ
                    MsgBox("Kelly")
                    Dim rptCitologia As New rptCitologia_kelly
                    rptCitologia.SetParameterValue("filtro", filtro)
                    'rptEndoscopiaGL.SetParameterValue("reporte", Reporte)
                    'rptEndoscopiaGL.SetParameterValue("fotos", Fotos)
                    crv.ReportSource = rptCitologia
                    crv.Refresh()
                    If VistaPrevia = True Then
                        ShowDialog()
                    Else
                        crv.PrintReport()
                    End If
                Case "11" 'CITOPAT DE LA COSTA
                    Dim rptCitologia As New rptCitologia
                    rptCitologia.SetParameterValue("filtro", filtro)
                    'rptEndoscopiaGL.SetParameterValue("reporte", Reporte)
                    'rptEndoscopiaGL.SetParameterValue("fotos", Fotos)
                    crv.ReportSource = rptCitologia
                    crv.Refresh()
                    If VistaPrevia = True Then
                        ShowDialog()
                    Else
                        crv.PrintReport()
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ExportarPDF(ByVal filtro As String, ByVal Reporte As String, ByVal Licencia As String, ByVal Fotos As String)
        Try
            Select Case Licencia
                Case "1"
                    MsgBox("MARTINEZ")
                Case "2"
                    MsgBox("INMUNOPAT")
                Case "3" 'DITEG
                    Dim rptEndoscopiaGL As New rptEndoscopiaDiteg
                    rptEndoscopiaGL.SetParameterValue("filtro", filtro)
                    rptEndoscopiaGL.SetParameterValue("reporte", Reporte)
                    rptEndoscopiaGL.SetParameterValue("fotos", Fotos)
                    crv.ReportSource = rptEndoscopiaGL
                    crv.Refresh()
                    ShowDialog()

                Case "4" 'GASTROLAP
                    Dim rptEndoscopiaGL As New rptImgEndoscopiaGL
                    rptEndoscopiaGL.SetParameterValue("filtro", filtro)
                    rptEndoscopiaGL.SetParameterValue("reporte", Reporte)
                    rptEndoscopiaGL.SetParameterValue("fotos", Fotos)
                    crv.ReportSource = rptEndoscopiaGL
                    crv.Refresh()

                    ShowDialog()
                Case "5"
                    MsgBox("INTEGRA")
                Case "6"
                    MsgBox("KELLY")
                Case "9"
                    MsgBox("BAETRIZ")
                Case "10"
                    MsgBox("FANNY")
                Case "11" 'CITOPAT DE LA COSTA
                    Dim rptCitologia As New rptCitologia

                    Dim CrExportOptions As ExportOptions
                    Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
                    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()

                    'Dim Guardar = New SaveFileDialog






                    'crv.Refresh()
                    rptCitologia.Refresh()
                    'Guardar.Filter = "Pdf Files|*.pdf"
                    'If Guardar.ShowDialog = DialogResult.OK Then
                    CrDiskFileDestinationOptions.DiskFileName = "x:\PDF\" & filtro & ".pdf" 'Guardar.FileName
                    'End If
                    'MsgBox(Guardar.FileName)
                    CrExportOptions = rptCitologia.ExportOptions
                    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
                    CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat
                    CrExportOptions.ExportDestinationOptions = CrDiskFileDestinationOptions
                    CrExportOptions.ExportFormatOptions = New PdfFormatOptions



                    If Not (String.IsNullOrEmpty(filtro)) Then
                        Dim crParameterDiscreteValue As New ParameterDiscreteValue

                        crParameterDiscreteValue.Value = filtro
                        Dim crParameterFieldDefinitions As ParameterFieldDefinitions = rptCitologia.DataDefinition.ParameterFields()
                        Dim crParameterFieldDefinition As ParameterFieldDefinition = crParameterFieldDefinitions.Item("filtro")
                        Dim crParameterValues As ParameterValues = crParameterFieldDefinition.CurrentValues

                        crParameterValues.Clear()
                        crParameterValues.Add(crParameterDiscreteValue)
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                    End If


                    rptCitologia.SetParameterValue("filtro", filtro)
                    rptCitologia.Export()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirRelacionPatologias(ByVal Fecha As String, ByVal Licencia As String)
        Try
            Select Case Licencia
                Case "11" 'CITOPAT DE LA COSTA
                    Dim rptRelacionPatologia As New rptRelacionPatologias
                    rptRelacionPatologia.SetParameterValue("filtro", Fecha)
                    'rptEndoscopiaGL.SetParameterValue("reporte", Reporte)
                    'rptEndoscopiaGL.SetParameterValue("fotos", Fotos)
                    crv.ReportSource = rptRelacionPatologia
                    crv.Refresh()
                    ShowDialog()
                Case "16"
                    Dim rptRelacionPatologia As New rptRelacionPatologias
                    rptRelacionPatologia.SetParameterValue("filtro", Fecha)
                    'rptEndoscopiaGL.SetParameterValue("reporte", Reporte)
                    'rptEndoscopiaGL.SetParameterValue("fotos", Fotos)
                    crv.ReportSource = rptRelacionPatologia
                    crv.Refresh()
                    ShowDialog()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "INMUNOPAT"
    Public Sub ImprimirCliente()
        Try
            Dim rptClientes As New rptClientes


            Dim crDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
            Dim crExportOptions As CrystalDecisions.Shared.ExportOptions = New CrystalDecisions.Shared.ExportOptions

            crDiskFileDestinationOptions.DiskFileName = "d:\estudios\ejemplo.pdf"

            With crExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .ExportDestinationOptions = crDiskFileDestinationOptions
            End With

            rptClientes.Export(crExportOptions)

            'crv.ReportSource = rptClientes
            'crv.Refresh()
            'ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirTarifaProductos(ByVal filtro As String)
        Try
            Dim rptTarifas As New rptTarifasProductos
            rptTarifas.SetParameterValue("filtro", filtro)
            crv.ReportSource = rptTarifas
            crv.Refresh()
            ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirOrdenCompra(ByVal IdOrden As String, ByVal Licencia As String)
        Try
            Dim rptOrdenCompra As New rptOrdenCompra
            rptOrdenCompra.SetParameterValue("filtro", IdOrden)
            rptOrdenCompra.SetParameterValue("licencia", Licencia)
            crv.ReportSource = rptOrdenCompra
            crv.Refresh()
            ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



#End Region
#Region "FACTURAS"
    Public Sub ImprimirRelacionFactura(ByVal filtro As String)
        Try

            Dim rptFactura As New rptRelacionFactura
            rptFactura.SetParameterValue("filtro", filtro)
            crv.ReportSource = rptFactura
            crv.Refresh()
            ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirFacturaConcepto(ByVal filtro As String)
        Try

            Dim rptFactura As New rptFacturaConcepto
            rptFactura.SetParameterValue("filtro", filtro)
            crv.ReportSource = rptFactura
            crv.Refresh()
            ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirFacturaDetalle(ByVal filtro As String)
        Try

            Dim rptFactura As New rptFacturaDetalle
            rptFactura.SetParameterValue("filtro", filtro)
            crv.ReportSource = rptFactura
            crv.Refresh()
            ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirFacturaResumida(ByVal filtro As String)
        Try

            Dim rptFactura As New rptFacturaResumida
            rptFactura.SetParameterValue("filtro", filtro)
            crv.ReportSource = rptFactura
            crv.Refresh()
            ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirFacturaProductos(ByVal IdFactura As String, ByVal VistaPrevia As Byte)
        Try
            Dim rptFactura As New rptFacturaProductos
            rptFactura.SetParameterValue("filtro", IdFactura)
            crv.ReportSource = rptFactura
            crv.Refresh()
            If VistaPrevia = 0 Then
                crv.PrintReport()
            Else
                ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirCotizacion(ByVal IdCotizacion As String, ByVal VistaPrevia As Byte)
        Try
            Dim rptCotizacion As New rptCotizacionProductos
            rptCotizacion.SetParameterValue("filtro", IdCotizacion)
            crv.ReportSource = rptCotizacion
            crv.Refresh()
            If VistaPrevia = 0 Then
                crv.PrintReport()
            Else
                ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirCotizacionAgora(ByVal IdCotizacion As String, ByVal VistaPrevia As Byte)
        Try
            Dim rptCotizacion As New rptCotizacionAgora
            rptCotizacion.SetParameterValue("filtro", IdCotizacion)
            crv.ReportSource = rptCotizacion
            crv.Refresh()
            If VistaPrevia = 0 Then
                crv.PrintReport()
            Else
                ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirOrdenServicioAgora(ByVal IdOrden As String, ByVal VistaPrevia As Byte)
        Try
            Dim rptOrden As New rptOrdenAgora
            rptOrden.SetParameterValue("filtro", IdOrden)
            crv.ReportSource = rptOrden
            crv.Refresh()
            If VistaPrevia = 0 Then
                crv.PrintReport()
            Else
                ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirOrdenServicio(ByVal IdOrdenServicio As String, ByVal VistaPrevia As Byte)
        Try
            Dim rptOrdenServicio As New rptOrdenServicio
            rptOrdenServicio.SetParameterValue("filtro", IdOrdenServicio)
            crv.ReportSource = rptOrdenServicio
            crv.Refresh()
            If VistaPrevia = 0 Then
                crv.PrintReport()
            Else
                ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirEjemplo()
        Try

            Dim rptEjemplo As New Ejemplo
            crv.ReportSource = rptEjemplo
            crv.Refresh()
            ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



#End Region
    Public Sub ImprimirReciboCaja(ByVal IdRecibo As String, ByVal Licencia As String, ByVal VistaPrevia As Byte)
        Try
            Select Case Licencia
                Case "1"
                    MsgBox("MARTINEZ")
                Case "2"
                    MsgBox("INMUNOPAT")
                Case "3" 'DITEG
                    MsgBox("DITEG")
                Case "4" 'GASTROLAP
                    MsgBox("GASTROLAP")
                Case "5"
                    MsgBox("INTEGRA")
                Case "6"
                    MsgBox("KELLY")
                Case "9"
                    MsgBox("BAETRIZ")
                Case "10"
                    MsgBox("FANNY")
                Case "11"
                    'Dim rptReciboCaja As New rptReciboCaja_Orden
                    'Dim rptReciboCaja2 As New rptReciboCaja
                    'if IdRecibo = "0" Then
                    'rptReciboCaja2.SetParameterValue("IDRECIBO", IdRecibo)
                    'rptReciboCaja2.SetParameterValue("LICENCIA", Licencia)
                    'crv.ReportSource = rptReciboCaja2
                    'Else
                    'rptReciboCaja.SetParameterValue("IDRECIBO", IdRecibo)
                    'rptReciboCaja.SetParameterValue("LICENCIA", Licencia)
                    'crv.ReportSource = rptReciboCaja
                    'End If
                    'crv.Refresh()
                    'ShowDialog()

                    Dim rptReciboCaja As New rptReciboCajaOF
                    rptReciboCaja.SetParameterValue("IDRECIBO", IdRecibo)
                    rptReciboCaja.SetParameterValue("LICENCIA", Licencia)
                    crv.ReportSource = rptReciboCaja
                    crv.Refresh()
                    If VistaPrevia = 0 Then
                        crv.PrintReport()
                    Else
                        ShowDialog()
                    End If

                Case "15", "17"
                    Dim rptReciboCaja As New rptReciboCajaOF
                    rptReciboCaja.SetParameterValue("IDRECIBO", IdRecibo)
                    rptReciboCaja.SetParameterValue("LICENCIA", Licencia)
                    crv.ReportSource = rptReciboCaja
                    crv.Refresh()
                    If VistaPrevia = 0 Then
                        crv.PrintReport()
                    Else
                        ShowDialog()
                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirCierreCaja(ByVal IdCierre As String, ByVal Licencia As String, ByVal VistaPrevia As Byte)
        Try
            Select Case Licencia
                Case "1"
                    MsgBox("MARTINEZ")
                Case "2"
                    MsgBox("INMUNOPAT")
                Case "3" 'DITEG
                    MsgBox("DITEG")
                Case "4" 'GASTROLAP
                    MsgBox("GASTROLAP")
                Case "5"
                    MsgBox("INTEGRA")
                Case "6"
                    MsgBox("KELLY")
                Case "9"
                    MsgBox("BAETRIZ")
                Case "10"
                    MsgBox("FANNY")

                Case "15"
                    Dim rptCierreCaja As New rptCierreCaja
                    rptCierreCaja.SetParameterValue("filtro", IdCierre)
                    rptCierreCaja.SetParameterValue("LICENCIA", Licencia)
                    crv.ReportSource = rptCierreCaja
                    crv.Refresh()
                    If VistaPrevia = 0 Then
                        crv.PrintReport()
                    Else
                        ShowDialog()
                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirReciboEntregaResultados(ByVal IdOrden As String, ByVal Licencia As String)
        Try
            Select Case Licencia
                Case "1"
                    MsgBox("MARTINEZ")
                Case "2"
                    MsgBox("INMUNOPAT")
                Case "3" 'DITEG
                    MsgBox("DITEG")
                Case "4" 'GASTROLAP
                    MsgBox("GASTROLAP")
                Case "5"
                    MsgBox("INTEGRA")
                Case "6"
                    MsgBox("KELLY")
                Case "9"
                    MsgBox("BAETRIZ")
                Case "10"
                    MsgBox("FANNY")
                Case "11", "16"
                    Dim rptEntregaResultados As New rptEntregaResultados

                    rptEntregaResultados.SetParameterValue("ORDEN", IdOrden)
                    rptEntregaResultados.SetParameterValue("LICENCIA", Licencia)
                    crv.ReportSource = rptEntregaResultados

                    crv.ReportSource = rptEntregaResultados
                    crv.Refresh()
                    crv.PrintReport()
                    'ShowDialog()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirOptometria(ByVal IdOrden As String, ByVal Licencia As String)
        Try
            Select Case Licencia
                Case "1"
                    MsgBox("MARTINEZ")
                Case "2"
                    MsgBox("INMUNOPAT")
                Case "3" 'DITEG
                    MsgBox("DITEG")
                Case "4" 'GASTROLAP
                    MsgBox("GASTROLAP")
                Case "5"
                    MsgBox("INTEGRA")
                Case "6"
                    MsgBox("KELLY")
                Case "9"
                    MsgBox("BAETRIZ")
                Case "10"
                    MsgBox("FANNY")
                Case "11"
                    Dim rptEntregaResultados As New rptEntregaResultados

                    rptEntregaResultados.SetParameterValue("ORDEN", IdOrden)
                    rptEntregaResultados.SetParameterValue("LICENCIA", Licencia)
                    crv.ReportSource = rptEntregaResultados

                    crv.ReportSource = rptEntregaResultados
                    crv.Refresh()
                    crv.PrintReport()
                    'ShowDialog()
                Case "15" ' FREISEM
                    Dim rptHistoriaOptometria As New rptHistoriaOptometria
                    rptHistoriaOptometria.SetParameterValue("filtro", IdOrden)
                    crv.ReportSource = rptHistoriaOptometria
                    crv.Refresh()
                    ShowDialog()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub VistaOptometria(ByVal IdOrden As String)
        Try
            Dim rptVistaOptometria As New rptVistaOptometria
            rptVistaOptometria.SetParameterValue("filtro", IdOrden)
            crv.ReportSource = rptVistaOptometria
            crv.Refresh()
            ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ImprimirIncapacidad(ByVal IdOrden As String)
        Try
            Dim rptIncapacidad As New rptIncapacidad
            rptIncapacidad.SetParameterValue("filtro", IdOrden)
            crv.ReportSource = rptIncapacidad
            crv.Refresh()
            ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ImprimirEstudios(ByVal idOrden As String, ByVal idDetalleOrden As String, ByVal Reporte As String, ByVal Fotos As String, ByVal Licencia As String, ByVal TipoEstudio As String, ByVal VistaPrevia As Boolean)
        Select Case TipoEstudio
            ' HISTORI CLINICA
            Case "CONSULTA PRIMERA VEZ"
                Select Case Licencia
                    Case 3 'DITEG
                        Dim rptHistoriaClinica As New rptHistoriaClinicaDiteg
                        rptHistoriaClinica.SetParameterValue("filtro", idDetalleOrden)
                        rptHistoriaClinica.SetParameterValue("reporte", Reporte)
                        crv.ReportSource = rptHistoriaClinica
                    Case 4 'GASTROLAP
<<<<<<< Updated upstream
                        Dim rptHistoriaClinica As New rptHistoriaClinicaMR
=======
                        Dim rptHistoriaClinica As New rptHistoriaClinicaGL
>>>>>>> Stashed changes
                        rptHistoriaClinica.SetParameterValue("filtro", idDetalleOrden)
                        rptHistoriaClinica.SetParameterValue("reporte", Reporte)
                        crv.ReportSource = rptHistoriaClinica
                End Select

            Case "CONSULTA DE CONTROL"
                Select Case Licencia
                    Case 3 'DITEG
                        Dim rptHistoriaClinica As New rptHistoriaClinicaDiteg
                        rptHistoriaClinica.SetParameterValue("filtro", idDetalleOrden)
                        rptHistoriaClinica.SetParameterValue("reporte", Reporte)
                        crv.ReportSource = rptHistoriaClinica
                    Case 4 'GASTROLAP
<<<<<<< Updated upstream
                        Dim rptHistoriaClinica As New rptHistoriaClinicaMR
=======
                        Dim rptHistoriaClinica As New rptHistoriaClinicaGL
>>>>>>> Stashed changes
                        rptHistoriaClinica.SetParameterValue("filtro", idDetalleOrden)
                        rptHistoriaClinica.SetParameterValue("reporte", Reporte)
                        crv.ReportSource = rptHistoriaClinica

                End Select
            'ENDOSCOPIAS
            Case "ENDOSCOPIA"
                Select Case Licencia
                    Case 3 'DITEG
                        Dim rptEndoscopiaGL As New rptImgEndoscopiaDiteg
                        rptEndoscopiaGL.SetParameterValue("filtro", idDetalleOrden)
                        rptEndoscopiaGL.SetParameterValue("reporte", Reporte)
                        rptEndoscopiaGL.SetParameterValue("fotos", Fotos)
                        crv.ReportSource = rptEndoscopiaGL
                    Case 4 'GASTROLAP
                        Dim rptEndoscopiaGL As New rptImgEndoscopiaGL
                        rptEndoscopiaGL.SetParameterValue("filtro", idDetalleOrden)
                        rptEndoscopiaGL.SetParameterValue("reporte", Reporte)
                        rptEndoscopiaGL.SetParameterValue("fotos", Fotos)
                        crv.ReportSource = rptEndoscopiaGL

                End Select
            Case "COLONOSCOPIA"
                Select Case Licencia
                    Case 3 'DITEG
                        Dim rptColonoscopiaGL As New rptImgColonoscopiaDiteg
                        rptColonoscopiaGL.SetParameterValue("filtro", idDetalleOrden)
                        rptColonoscopiaGL.SetParameterValue("reporte", Reporte)
                        rptColonoscopiaGL.SetParameterValue("fotos", Fotos)
                        crv.ReportSource = rptColonoscopiaGL
                    Case 4 'GASTROLAP
                        Dim rptColonoscopiaGL As New rptImgColonoscopiaGL
                        rptColonoscopiaGL.SetParameterValue("filtro", idDetalleOrden)
                        rptColonoscopiaGL.SetParameterValue("reporte", Reporte)
                        rptColonoscopiaGL.SetParameterValue("fotos", Fotos)
                        crv.ReportSource = rptColonoscopiaGL

                End Select
            Case "RECTOSCOPIA"
                Select Case Licencia
                    Case 3 'DITEG
                        Dim rptRectoscopiaGL As New rptImgRectoscopiaDiteg
                        rptRectoscopiaGL.SetParameterValue("filtro", idDetalleOrden)
                        rptRectoscopiaGL.SetParameterValue("reporte", Reporte)
                        rptRectoscopiaGL.SetParameterValue("fotos", Fotos)
                        crv.ReportSource = rptRectoscopiaGL
                    Case 4 'GASTROLAP
                        Dim rptRectoscopiaGL As New rptImgRectoscopiaGL
                        rptRectoscopiaGL.SetParameterValue("filtro", idDetalleOrden)
                        rptRectoscopiaGL.SetParameterValue("reporte", Reporte)
                        rptRectoscopiaGL.SetParameterValue("fotos", Fotos)
                        crv.ReportSource = rptRectoscopiaGL

                End Select
            Case "CONSULTA PREANESTESICA"
            Case "REGISTRO ANESTESIA"
                Select Case Licencia
                    Case 3 'DITEG
                    Case 4 'GASTROLAP
                        Dim rptAnestesiaGL As New rptAnestesiaGL
                        rptAnestesiaGL.SetParameterValue("filtro", idOrden)
                        'rptRectoscopiaGL.SetParameterValue("reporte", Reporte)
                        'rptRectoscopiaGL.SetParameterValue("fotos", Fotos)
                        crv.ReportSource = rptAnestesiaGL

                End Select
            Case "ESTUDIOS ESPECIALES"
                Select Case Licencia
                    Case 3 'DITEG
                        Dim rptEstudiosEspecialesGL As New rptImgEstudiosEspecialesDiteg
                        rptEstudiosEspecialesGL.SetParameterValue("filtro", idDetalleOrden)
                        rptEstudiosEspecialesGL.SetParameterValue("reporte", Reporte)
                        rptEstudiosEspecialesGL.SetParameterValue("fotos", Fotos)
                        crv.ReportSource = rptEstudiosEspecialesGL
                    Case 4 'GASTROLAP
                        Dim rptEstudiosEspecialesGL As New rptImgEstudiosEspecialesGL
                        rptEstudiosEspecialesGL.SetParameterValue("filtro", idDetalleOrden)
                        rptEstudiosEspecialesGL.SetParameterValue("reporte", Reporte)
                        rptEstudiosEspecialesGL.SetParameterValue("fotos", Fotos)
                        crv.ReportSource = rptEstudiosEspecialesGL

                End Select
            'LABORATORIO PATOLOGIA
            Case "CITOLOGIA"
                Select Case Licencia
                    Case 11 ' CITOPAT
                        Dim rptCitologia As New rptCitologia
                        rptCitologia.SetParameterValue("filtro", idOrden)
                        crv.ReportSource = rptCitologia
                    Case 16 'CD PATOLOGIA ONCOLOGICA
                        Dim rptCitologia As New rptCitologia
                        rptCitologia.SetParameterValue("filtro", idOrden)
                        crv.ReportSource = rptCitologia
                End Select
            Case "CITOLOGIA ANAL"
                Select Case Licencia
                    Case 11 ' CITOPAT
                        Dim rptCitologiaAnal As New rptCitologiaAnoRectal
                        rptCitologiaAnal.SetParameterValue("filtro", idOrden)
                        crv.ReportSource = rptCitologiaAnal
                    Case 16 'CD PATOLOGIA ONCOLOGICA
                        'Dim rptCitologia As New rptCitologia
                        'rptCitologia.SetParameterValue("filtro", idOrden)
                        'crv.ReportSource = rptCitologia
                End Select
            Case "CITOLOGIA BASE LIQUIDA"
            Case "BIOPSIA", "BIOPSIA POR CONGELACION", "BACAF", "RECEPTORES HORMONALES", "INMUNOHISTOQUIMICA"
                Select Case Licencia
                    Case 11 ' CITOPAT
                        Dim rptPatologia As New rptPatologia
                        rptPatologia.SetParameterValue("filtro", idOrden)
                        crv.ReportSource = rptPatologia
                    Case 16 'CD PATOLOGIA ONCOLOGICA
                        Dim rptPatologia As New rptCDPatologia
                        rptPatologia.SetParameterValue("filtro", idOrden)
                        crv.ReportSource = rptPatologia
                End Select

        End Select
        crv.Refresh()
        If VistaPrevia = True Then
            ShowDialog()
        Else
            crv.PrintReport()
        End If

    End Sub

    Private Sub frmImprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



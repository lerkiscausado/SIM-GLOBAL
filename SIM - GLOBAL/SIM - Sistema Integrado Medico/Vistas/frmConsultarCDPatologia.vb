Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraPrinting
Imports SIM___GLOBAL.Utilidades

Public Class frmConsultarCDPatologia
    ReadOnly _funciones As New SIM___GLOBAL.Utilidades.Funciones

    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _dOrdenes = New SIM___GLOBAL.Controles.DOrdenes
    Dim _dImpresionHistoria As New SIM___GLOBAL.Controles.DImpresionHistoria
    Dim _dImpresionDetalleHistoria As New SIM___GLOBAL.Controles.DImpresionDetalleHistoria
    Dim _dImpresionEndoscopia As New SIM___GLOBAL.Controles.DImpresionEndoscopia
    Dim _ImpresionEndoscopia As New SIM___GLOBAL.Modelo.ImpresionEndoscopia
    Private Sub ImpresionResultados(ByVal Fotos As String, ByVal VistaPrevia As Boolean)
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        Dim Reporte As Integer = 1
        LicenciaG = 16
        'Verificamos la Licencia
        Select Case LicenciaG
            Case 16 'CD PATOLOGIA ONCOLOGICA SAS
                'IMPRESION CON DEVEXPRESS XTRA REPORT
                'definimos elreporte
                If VistaPrevia = False Then
                    Dim reporteRTB As New SIM___GLOBAL.xrPatologiaCDPreliminar
                    Dim filtro As New Parameter()
                    'filtro.Name = "idOrden"
                    filtro.Value = IDOrdenG
                    filtro.Visible = False
                    reporteRTB.Parameters.Add(filtro)
                    reporteRTB.FilterString = "[ID] = ?idOrden"
                    reporteRTB.RequestParameters = False
                    reporteRTB.Parameters(0).Value = IDOrdenG
                    reporteRTB.Parameters("idOrden").Value = IDOrdenG
                    Dim printTool As New ReportPrintTool(reporteRTB)
                    printTool.ShowPreviewDialog()
                    'printTool.show
                Else
                    'Verificamos si es una Inmunohistoquimica
                    If Fotos = "0" Then
                        Dim reporteRTB As New SIM___GLOBAL.xrPatologiaCD
                        Dim filtro As New Parameter()
                        'filtro.Name = "idOrden"
                        filtro.Value = IDOrdenG
                        filtro.Visible = False
                        reporteRTB.Parameters.Add(filtro)
                        reporteRTB.FilterString = "[ID] = ?idOrden"
                        reporteRTB.RequestParameters = False
                        reporteRTB.Parameters(0).Value = IDOrdenG
                        reporteRTB.Parameters("idOrden").Value = IDOrdenG
                        'reporteRTB.ExportToPdf()
                        Dim printTool As New ReportPrintTool(reporteRTB)
                        printTool.ShowPreviewDialog()
                    Else
                        Dim reporteRTB As New SIM___GLOBAL.xrPatologiaCD
                        Dim filtro As New Parameter()
                        'DEFINIMOS EL PROCESO DE GUARDADO EN TABLA IMPRESION HISTORIA
                        Dim _DImpresionPatologia As New SIM___GLOBAL.Controles.DImpresionPatologia
                        _DImpresionPatologia.Guardar(IDOrdenG)
                        '------------------------------------------------------------
                        Dim reportPath As String = "c:\\SIM\pdf\" + DatosPacienteG + ".pdf"
                        Dim pdfOptions As PdfExportOptions = reporteRTB.ExportOptions.Pdf

                        pdfOptions.DocumentOptions.Application = "SIM - Sistema Integrado Medico"
                        pdfOptions.DocumentOptions.Author = "Ados Software"
                        pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF"
                        pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString()
                        'pdfOptions.DocumentOptions.Subject = "Document Subject"
                        pdfOptions.DocumentOptions.Title = DatosPacienteG

                        ' ⬇⬇⬇ Estas opciones reducen la calidad ⬇⬇⬇
                        pdfOptions.ImageQuality = PdfJpegImageQuality.Low  ' Bajo (puedes usar Medium si prefieres más detalle)
                        pdfOptions.ConvertImagesToJpeg = True              ' Convierte imágenes a JPEG (más ligero que PNG)
                        pdfOptions.NeverEmbeddedFonts = True               ' No incrustar fuentes (reduce tamaño)
                        pdfOptions.PdfACompatibility = PdfACompatibility.None ' No generar compatibilidad PDF/A
                        pdfOptions.ShowPrintDialogOnOpen = False           ' No muestra diálogo de impresión

                        'filtro.Name = "idOrden"
                        filtro.Value = IDOrdenG
                        filtro.Visible = False
                        reporteRTB.Parameters.Add(filtro)
                        reporteRTB.FilterString = "[ID] = ?idOrden"
                        reporteRTB.RequestParameters = False
                        reporteRTB.Parameters(0).Value = IDOrdenG
                        reporteRTB.Parameters("idOrden").Value = IDOrdenG
                        reporteRTB.ExportToPdf(reportPath, pdfOptions)
                        'aqui guardamos el PDF en la base de datos 
                        _DImpresionPatologia.GuardarPDF(IDOrdenG, reportPath)
                    End If
                End If


        End Select
    End Sub
    Public Sub Recargar(ByVal filtro As String)
        Try
            Dim _ds = New DataSet
            _ds = _dOrdenes.Ordenescdpatologia()
            GCConsultar.DataSource = _ds.Tables(0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            IDOrdenG = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            Estudio = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            Estado = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ESTADO").ToString()
            FechaG = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "FECHA_INGRESO").ToString()
            DatosPacienteG = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "CONSECUTIVO").ToString() + " - " +
            GVConsultar.GetRowCellValue(e.RowHandle.ToString, "NOMBRE").ToString() + " - " +
            GVConsultar.GetRowCellValue(e.RowHandle.ToString, "IDENTIFICACION").ToString()
            ConsecutivoG = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "CONSECUTIVO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub tsmExportarExcel_Click(sender As Object, e As EventArgs) Handles tsmExportarExcel.Click
        sfdRuta.Filter = "Archivo Excel |*.xls"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToXls(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmExportarPDF_Click(sender As Object, e As EventArgs) Handles tsmExportarPDF.Click
        sfdRuta.Filter = "Archivo PDF |*.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmImprimir_Click(sender As Object, e As EventArgs) Handles tsmImprimir.Click
        GCConsultar.PrintDialog()
    End Sub

    Private Sub tsmActualizarVista_Click(sender As Object, e As EventArgs) Handles tsmActualizarVista.Click
        Recargar(Year(Now))
    End Sub

    Private Sub tsm2020_Click(sender As Object, e As EventArgs) Handles tsm2020.Click
        Recargar("2020")
    End Sub

    Private Sub tsm2019_Click(sender As Object, e As EventArgs) Handles tsm2019.Click
        Recargar("2019")
    End Sub

    Private Sub tsm2018_Click(sender As Object, e As EventArgs) Handles tsm2018.Click
        Recargar("2018")
    End Sub

    Private Sub tsm2017_Click(sender As Object, e As EventArgs) Handles tsm2017.Click
        Recargar("2017")
    End Sub

    Private Sub tsm2021_Click(sender As Object, e As EventArgs) Handles tsm2021.Click
        Recargar("2021")
    End Sub

    Private Async Sub tsmExportarLotePDF_Click(sender As Object, e As EventArgs) Handles tsmExportarLotePDF.Click

        pbExportarPDF.Visible = True
        pbExportarPDF.Maximum = GVConsultar.RowCount - 1
        If MessageBox.Show("Desea Exportar los resultados, ¿Este proceso puede tomar unos minutos, Desea Continuar?", "Exportar Resultados", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then


            For x As Integer = 0 To GVConsultar.RowCount - 1
                'ppExportarPDF.FrameCount = x + 1
                pbExportarPDF.Value = x
                IDOrdenG = GVConsultar.GetRowCellValue(x, "ORDEN").ToString
                Estado = GVConsultar.GetRowCellValue(x, "ESTADO").ToString
                DatosPacienteG = GVConsultar.GetRowCellValue(x, "CONSECUTIVO").ToString() + " - " + GVConsultar.GetRowCellValue(x, "NOMBRE").ToString() + " - " + GVConsultar.GetRowCellValue(x, "IDENTIFICACION").ToString()
                'Exportamos Datos porLote
                If IDDetalleOrdenG <> Nothing Or IDOrdenG <> Nothing Then
                    If Estado = "ATENDIDO" Or Estado = "FACTURADO" Then

                        ImpresionResultados(DatosPacienteG, True)
                        'MessageBox.Show(DatosPacienteG, "Reporte PDF Generado con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        If LicenciaG = 16 Then
                            ImpresionResultados("0", False)
                        Else
                            MessageBox.Show("El Estudio se Encuentra en Estado: " & Estado, "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    End If
                Else
                    MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Await Task.Delay(300)
            Next
            MessageBox.Show("Reportes Exportados Con Exito", "Exportar Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        pbExportarPDF.Visible = False
    End Sub


End Class
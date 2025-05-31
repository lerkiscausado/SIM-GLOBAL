
Public Class frmConsultarCitoPato
    ReadOnly _funciones As New SIM___GLOBAL.Utilidades.Funciones
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _dOrdenes = New SIM___GLOBAL.Controles.DOrdenes
    Public Sub Recargar(ByVal filtro As String)
        Try
            Dim _ds = New DataSet
            _ds = _dOrdenes.Ordenescitopato(filtro)
            GCConsultar.DataSource = _ds.Tables(0)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ImpresionResultados(ByVal Fotos As String, ByVal VistaPrevia As Boolean)
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        Dim Reporte As Integer = 1
        'Verificamos la Licencia
        'Select Case LicenciaG
        'Case 11 'CITOPAT DE LA COSTA LTDA
        'ImprimirFrm.ImprimirEstudios(IDOrdenG, IDDetalleOrdenG, Reporte, Fotos, 11, Estudio, VistaPrevia)
        '_funciones.GenerarPDF(IDOrdenG, _ClickEstudio, 1, Licencia, "\\servidor-pc\pdf\" & lblConsecutivoOrden.Text & ".pdf")
        'End Select
    End Sub

    Private Sub frmConsultarCitoPato_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'IDDetalleOrden = Nothing
        'IDORden = Nothing
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            IDORdenG = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            Estudio = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            Estado = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ESTADO").ToString()
            FechaG = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "FECHA_INGRESO").ToString()
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

    Private Sub tsmVistaPrevia_Click(sender As Object, e As EventArgs) Handles tsmVistaPrevia.Click
        If IDOrdenG <> Nothing And Estado = "ATENDIDO" Then
            _funciones.Imprimir(IDOrdenG, IDDetalleOrdenG, Estudio, LicenciaG)
        Else
            MessageBox.Show("Debe Seleccionar una Orden Atendida", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tsm2021_Click(sender As Object, e As EventArgs) Handles tsm2021.Click
        Recargar("2021")
    End Sub

    Private Sub frmConsultarCitoPato_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tsm2022_Click(sender As Object, e As EventArgs) Handles tsm2022.Click
        Recargar("2022")
    End Sub

    Private Sub tsm2023_Click(sender As Object, e As EventArgs) Handles tsm2023.Click
        Recargar("2023")
    End Sub

    Private Sub ImprimirListadoPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirListadoPDFToolStripMenuItem.Click

        If MessageBox.Show("Desea Exportar los resultados, ¿Este proceso puede tomar unos minutos, Desea Continuar?", "Exportar Resultados", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then


            For x As Integer = 0 To GVConsultar.RowCount - 1
                'ppExportarPDF.FrameCount = x + 1

                IDOrdenG = GVConsultar.GetRowCellValue(x, "ORDEN").ToString
                Estado = GVConsultar.GetRowCellValue(x, "ESTADO").ToString

                DatosPacienteG = GVConsultar.GetRowCellValue(x, "CONSECUTIVO").ToString() + " - " + GVConsultar.GetRowCellValue(x, "NOMBRE").ToString() + " - " + GVConsultar.GetRowCellValue(x, "IDENTIFICACION").ToString()
                'Exportamos Datos porLote
                If IDDetalleOrdenG <> Nothing Or IDOrdenG <> Nothing Then
                    If Estado = "ATENDIDO" Or Estado = "FACTURADO" Then

                        'ImpresionResultados(IDOrdenG, True)
                        _funciones.GenerarPDF(IDOrdenG, GVConsultar.GetRowCellValue(x, "ESTUDIO").ToString, 1, 11, "C:\SIM\reportes\" & IDOrdenG & ".pdf")
                        'MessageBox.Show(DatosPacienteG, "Reporte PDF Generado con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'MessageBox.Show("Estudio No. " & IDOrdenG & " Paciente: " & DatosPacienteG & " item: " & x)
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
            Next
            MessageBox.Show("Reportes Exportados Con Exito", "Exportar Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tsm2024_Click(sender As Object, e As EventArgs) Handles tsm2024.Click
        Recargar("2024")
    End Sub
End Class
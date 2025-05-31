Public Class frmConsultarPOS
    ReadOnly _funciones As New SIM___GLOBAL.Utilidades.Funciones
    Dim _ds As DataSet
    Dim Estado As String
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _dOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _DUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    Public Licencia As String
    Public IdEmpleado As String
    Private Sub frmConsultarPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Licencia
            Case 15 'Optica Freisem
                Try
                    Dim _ds = New DataSet
                    _ds = _dOrdenes.OrdenesOPTOMETRIA()
                    GCConsultar.DataSource = _ds.Tables(0)

                    _ds = _DUsuarios.CumpleanosMes
                    gcCumpleanosMes.DataSource = _ds.Tables(0)

                    _ds = _dOrdenes.OrdenesProximoControl
                    gcControles.DataSource = _ds.Tables(0)
                Catch ex As Exception
                    MessageBox.Show(ex, "Error no especificado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Case Else
        End Select

    End Sub

    Private Sub tsmExportarPDF_Click(sender As Object, e As EventArgs) Handles tsmExportarPDF.Click
        sfdRuta.Filter = "Archivo PDF |*.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmExportarExcel_Click(sender As Object, e As EventArgs) Handles tsmExportarExcel.Click
        sfdRuta.Filter = "Archivo Excel |*.xls"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToXls(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmImprimir_Click(sender As Object, e As EventArgs) Handles tsmImprimir.Click
        GCConsultar.PrintDialog()
    End Sub

    Private Sub tsmVistaPrevia_Click(sender As Object, e As EventArgs) Handles tsmVistaPrevia.Click
        If _ClickGrilla <> Nothing And Estado = "ATENDIDO" Then
            frmImprimir.ImprimirOptometria(_ClickGrilla, Licencia)
            ' _funciones.Imprimir(_ClickGrilla, IDDetalleOrdenG, Estudio, LicenciaG)
        Else
            MessageBox.Show("Debe Seleccionar una Orden Atendida", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tsmActualizarVista_Click(sender As Object, e As EventArgs) Handles tsmActualizarVista.Click
        Try
            Dim _ds = New DataSet
            _ds = _dOrdenes.OrdenesOPTOMETRIA()
            GCConsultar.DataSource = _ds.Tables(0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            'Estudio = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString()
            Estado = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ESTADO").ToString()
            'FechaG = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "FECHA_INGRESO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
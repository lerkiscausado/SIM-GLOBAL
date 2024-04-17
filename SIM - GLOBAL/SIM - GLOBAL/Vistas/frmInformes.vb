Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Controles
Public Class frmInformes
    Public Admin As String
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim Estado As String
    Dim _DInformes As New SIM___GLOBAL.Controles.DInformes
    Private Sub Guardar()
        Try
            Dim _Informes As New SIM___GLOBAL.Modelo.Informes
            _Informes.Id = Val(txtId.Text)
            _Informes.Nombre = txtNombre.Text
            _Informes.Query = txtQuery.Text
            If chkEstado.Checked = True Then
                _Informes.Estado = "A"
            Else
                _Informes.Estado = "I"
            End If
            _DInformes.Guardar(_Informes)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LimpiarCampos()
        txtId.Text = Nothing
        txtNombre.Text = Nothing
        txtQuery.Text = Nothing
        chkEstado.Checked = False
        cboInforme.EditValue = Nothing
        'bbiGuardar.Enabled = False
        GCConsultar.DataSource = Nothing
        GVConsultar.Columns.Clear()
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DInformes.Listar()
        cboInforme.Properties.DataSource = _ds.Tables(0)
        cboInforme.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboInforme.Properties.ValueMember = _ds.Tables(0).Columns(2).Caption
    End Sub
    Private Sub frmInformes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        chkEstado.Checked = True

        'Verificamos si el usuario que ingreso es Admin
        If Admin <> "ADMINISTRADOR" Then
            bbiGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            bbiEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            xtpQuery.PageVisible = False
        End If
    End Sub

    Private Sub cboInforme_EditValueChanged(sender As Object, e As EventArgs) Handles cboInforme.EditValueChanged
        GCConsultar.DataSource = Nothing
        GVConsultar.Columns.Clear()

        If cboInforme.Text <> "" Then
            _ds = New DataSet
            _ds = _DInformes.Resultado(cboInforme.EditValue)

            GCConsultar.DataSource = _ds.Tables(0)

            txtQuery.Text = cboInforme.EditValue
            txtNombre.Text = cboInforme.Text

            If cboInforme.GetSelectedDataRow(3) = "A" Then
                chkEstado.Checked = True
            Else
                chkEstado.Checked = False
            End If
            GVConsultar.BestFitColumns()
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre Es Obligatorio", "Registro de Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtQuery.Text = "" Then
            MessageBox.Show("El Campo Consulta  es Obligatorio", "Registro de Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            LimpiarCampos()
            ActualizarGrilla()
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiExportarPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarPDF.ItemClick
        If GVConsultar.DataRowCount <> 0 Then
            sfdRuta.Filter = "Archivo PDF |*.pdf"
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GCConsultar.ExportToPdf(sfdRuta.FileName)
            End If
        Else
            MessageBox.Show("No se encontro información a exportar", "Exportar a PDF", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiExportarExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportarExcel.ItemClick
        If GVConsultar.DataRowCount <> 0 Then
            sfdRuta.Filter = "Archivo Excel |*.xls"
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GCConsultar.ExportToXls(sfdRuta.FileName)
            End If
        Else
            MessageBox.Show("No se encontro información a exportar", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
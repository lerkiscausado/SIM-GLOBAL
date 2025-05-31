Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo
Public Class frmEquipos
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Private Sub ActualizarGrilla()
        Dim _ds = New DataSet
        Dim _DEquipos As New DEquipos
        _ds = _DEquipos.Listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub Guardar()
        Try
            Dim _dequipos As New DEquipos
            Dim _Equipos As New Equipos
            _Equipos.Id = Val(txtID.Text)
            _Equipos.Nombre = txtNombre.Text
            _Equipos.Marca = txtMarca.Text
            _Equipos.Modelo = txtModelo.Text
            If chkEstado.Checked = True Then
                _Equipos.Estado = "A"
            Else
                _Equipos.Estado = "I"
            End If
            _dequipos.Guardar(_Equipos)
            bbiGuardar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        txtMarca.Text = ""
        txtModelo.Text = ""
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub EditarCampos()
        If _ClickGrilla <> "" Then
            If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                = DialogResult.Yes Then
                txtID.Text = _ClickGrilla
                txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "NOMBRE").ToString()
                txtMarca.Text = GVConsultar.GetRowCellValue(_Fila, "MARCA").ToString()
                txtModelo.Text = GVConsultar.GetRowCellValue(_Fila, "MODELO").ToString()
                If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                bbiGuardar.Enabled = False
            End If
        Else
            MessageBox.Show("No ha seleccionado el Equipo", "Registro de Equipos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub frmEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        chkEstado.Checked = True
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbrir.ItemClick
        EditarCampos()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Equipos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Guardar()
            LimpiarCampos()
            ActualizarGrilla()
        End If
    End Sub





    Private Sub GVConsultar_DoubleClick(sender As Object, e As EventArgs)
        EditarCampos()
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtMarca_EditValueChanged(sender As Object, e As EventArgs) Handles txtMarca.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtModelo_EditValueChanged(sender As Object, e As EventArgs) Handles txtModelo.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub



    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
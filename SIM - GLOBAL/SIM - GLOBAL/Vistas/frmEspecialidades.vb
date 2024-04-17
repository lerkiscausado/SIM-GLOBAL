Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Public Class frmEspecialidades
    Dim _ds As DataSet
    Dim _dEspecialidades As New DEspecialidades
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _Especialidades As New Especialidades

    Private Sub frmEspecialidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GVConsultar.OptionsFind.AlwaysVisible = False
        'solo mayusculas
        'llenamos la grilla de registros
        _ds = New DataSet
        _ds = _dEspecialidades.Listar()
        GCConsultar.DataSource = _ds.Tables(0)

        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        txtID.Text = ""
        txtNombre.Text = ""
        chkEstado.Checked = False
        bbiGuardar.Enabled = False
        txtNombre.Enabled = True
    End Sub

    Private Sub bbiAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbrir.ItemClick
        If _ClickGrilla <> "" Then
            If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
            = DialogResult.Yes Then
                txtID.Enabled = False
                txtID.Text = _ClickGrilla
                txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "ESPECIALIDAD").ToString()
                If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                bbiGuardar.Enabled = False
                txtNombre.Enabled = False
            End If
        Else
            MessageBox.Show("No ha seleccionado la especialidad", "Registro de Especialidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Especialidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _Especialidades.Id = Val(txtID.Text)
            _Especialidades.NombreEspecialidad = txtNombre.Text
            If chkEstado.Checked = True Then
                _Especialidades.Estado = "A"
            Else
                _Especialidades.Estado = "I"
            End If
            _dEspecialidades.Guardar(_Especialidades)
            'llenamos la grilla de registros
            _ds = New DataSet
            _ds = _dEspecialidades.Listar()
            GCConsultar.DataSource = _ds.Tables(0)
            GVConsultar.Columns(0).BestFit()
            GVConsultar.Columns(1).BestFit()
            'Limpiar Campos
            txtID.Text = ""
            txtNombre.Text = ""
            chkEstado.Checked = False
            bbiGuardar.Enabled = False
        End If
    End Sub
    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub
    Private Sub GVConsultar_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs)
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs)
        bbiGuardar.Enabled = True
    End Sub

    Private Sub GVConsultar_DoubleClick(sender As Object, e As EventArgs)
        If _ClickGrilla <> "" Then
            If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
            = DialogResult.Yes Then
                txtID.Enabled = False
                txtID.Text = _ClickGrilla
                txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "ESPECIALIDAD").ToString()
                If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                bbiGuardar.Enabled = False
                txtNombre.Enabled = False
            End If
        Else
            MessageBox.Show("No ha seleccionado la especialidad", "Registro de Especialidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Controles
Public Class frmProcedimientos
    Dim _ds As DataSet
    Dim _dProcedimientos As New DProcedimientos
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _procedimientos As New Procedimientos

    Private Sub frmProcedimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GVConsultar.OptionsFind.AlwaysVisible = False
        'solo mayusculas

        'llenamos la grilla de registros
        _ds = New DataSet
        _ds = _dProcedimientos.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
        GVConsultar.Columns(0).BestFit()
        GVConsultar.Columns(1).BestFit()
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        txtCodigo.Enabled = True
        txtCodigo.Text = ""
        txtNombre.Text = ""
        chkEstado.Checked = False
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Procedimientos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            _procedimientos.ID = Val(txtCodigo.Text)
            _procedimientos.NombreProcedimiento = txtNombre.Text

            If chkEstado.Checked = True Then
                _procedimientos.Estado = "A"
            Else
                _procedimientos.Estado = "I"

            End If
            _dProcedimientos.Guardar(_procedimientos)
            'llenamos la grilla de registros
            _ds = New DataSet
            _ds = _dProcedimientos.Listar()
            GCConsultar.DataSource = _ds.Tables(0)
            GVConsultar.Columns(0).BestFit()
            GVConsultar.Columns(1).BestFit()
            txtCodigo.Enabled = True
            txtCodigo.Text = ""
            txtNombre.Text = ""
            chkEstado.Checked = False
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub
    Private Sub GVConsultar_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
        = DialogResult.Yes Then
            txtCodigo.Enabled = False
            txtCodigo.Text = _ClickGrilla
            txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "PROCEDIMIENTO").ToString()
            If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                chkEstado.Checked = False
            Else
                chkEstado.Checked = True
            End If
        End If
    End Sub
End Class
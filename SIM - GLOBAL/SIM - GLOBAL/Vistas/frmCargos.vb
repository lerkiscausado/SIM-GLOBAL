Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Public Class frmCargos
    Public Licencia As String
    Public IdEmpleado As String
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _dCargos As New DCargos
    Dim _Cargos As New Cargos

    Private Function Guardar() As Boolean
        Try
            Dim idIngresado As Integer
            If Not Integer.TryParse(txtID.Text, idIngresado) Then
                MessageBox.Show("El campo ID debe ser un número válido", "Registro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            _Cargos.Id = idIngresado
            _Cargos.NombreCargo = txtNombre.Text.Trim()
            If chkEstado.Checked = True Then
                _Cargos.Estado = "A"
            Else
                _Cargos.Estado = "I"
            End If
            _dCargos.Guardar(_Cargos)
            bbiGuardar.Enabled = False
            Return True
        Catch ex As Exception
            MessageBox.Show("No se pudo guardar el cargo: " & ex.Message, "Registro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        chkEstado.Checked = False
        txtID.Enabled = True
        txtNombre.Enabled = True
        bbiGuardar.Enabled = False
        txtID.Text = 0
    End Sub
    Private Sub EditarCampos()
        If _ClickGrilla <> "" Then
            If MessageBox.Show("Desea Editar el Registro?", "Editar Registros ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                = DialogResult.Yes Then
                txtID.Enabled = False
                txtNombre.Enabled = False
                txtID.Text = _ClickGrilla
                txtNombre.Text = GVConsultar.GetRowCellValue(_Fila, "NOMBRE_CARGO").ToString()
                If GVConsultar.GetRowCellValue(_Fila, "ESTADO").ToString() = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                bbiGuardar.Enabled = False
            End If
        Else
            MessageBox.Show("No ha seleccionado el cargo", "Registro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _dCargos.Listar
        GCConsultar.DataSource = _ds.Tables(0)

    End Sub

    Private Sub frmCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Text = 0
        ActualizarGrilla()

        GVConsultar.OptionsFind.AlwaysVisible = False
        bbiGuardar.Enabled = False

    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbrir.ItemClick
        EditarCampos()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El Campo Nombre es Obligatorio", "Registro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            If Guardar() Then
                LimpiarCampos()
                ActualizarGrilla()
            End If
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub GVConsultar_DoubleClick(sender As Object, e As EventArgs) Handles GVConsultar.DoubleClick
        EditarCampos()
    End Sub

    Private Sub GVConsultar_RowClick_1(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub
End Class
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Controles
Public Class frmUsers
    Dim _ds As DataSet
    Dim _DUsers = New DUsers
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Public Licencia As String
    Public IdEmpleado As String
    Dim _Users As New Users
    'ReadOnly _tipoIdentificacion = New DTipoIdentificacion
    ReadOnly _DEmpleados = New DEmpleados
    Private Sub LimpiarCampos()
        cboEmpleados.ItemIndex = -1
        cboEmpleados.Enabled = True
        txtID.Text = ""
        txtUsuario.Text = ""
        txtClave.Text = ""
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
        _ClickGrilla = ""
    End Sub
    Private Sub ActualizarGrilla()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        _ds = _DUsers.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenamos empleados
        _ds = New DataSet()

        If Licencia = 17 Then
            _ds = _DEmpleados.listarcomboagora
        Else
            _ds = _DEmpleados.listarempleado()
        End If

        cboEmpleados.Properties.DataSource = _ds.Tables(0)
        cboEmpleados.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboEmpleados.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboEmpleados.Properties.PopulateColumns()
        cboEmpleados.Properties.Columns("ID").Visible = False
        cboEmpleados.ItemIndex = -1
        '----------------------------------
        ActualizarGrilla()
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub GVConsultar_DoubleClick(sender As Object, e As EventArgs)
        Try
            If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                _Users = _DUsers.Cargar(_ClickGrilla)
                txtID.Text = _ClickGrilla
                cboEmpleados.ItemIndex = cboEmpleados.Properties.GetDataSourceRowIndex("ID", _Users.IdEmpleado)
                txtUsuario.Text = _Users.Usuario
                txtClave.Text = _Users.Pass
                If _Users.Estado = "I" Then
                    chkEstado.Checked = False
                Else
                    chkEstado.Checked = True
                End If
                cboEmpleados.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If cboEmpleados.Text = "" Then
            MessageBox.Show("Debe seleccionar el empleado", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtID.Text = "" And _DUsers.existeempleado(cboEmpleados.GetColumnValue("ID")) = True Then
            MessageBox.Show("El usuario ya existe", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtUsuario.Text = "" Then
            MessageBox.Show("El Campo Usuario es Obligatorio", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtClave.Text = "" Then
            MessageBox.Show("El Campo Clave es Obligatorio", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _Users.Id = Val(txtID.Text)
            _Users.IdEmpleado = cboEmpleados.GetColumnValue("ID")
            _Users.Usuario = txtUsuario.Text
            _Users.Pass = txtClave.Text
            _Users.IdLicencia = Licencia


            If chkEstado.Checked = True Then
                _Users.Estado = "A"
            Else
                _Users.Estado = "I"

            End If

            _DUsers.Guardar(_Users)

            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Try
            If _ClickGrilla = "" Then
                MessageBox.Show("No ha seleccionado el usuario", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Desea Editar el Usuario?", "Editar Registros ",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                        = DialogResult.Yes Then
                    cboEmpleados.Enabled = False
                    _Users = _DUsers.Cargar(_ClickGrilla)

                    txtID.Text = _ClickGrilla
                    cboEmpleados.ItemIndex = cboEmpleados.Properties.GetDataSourceRowIndex("ID", _Users.IdEmpleado)
                    txtUsuario.Text = _Users.Usuario
                    txtClave.Text = _Users.Pass
                    If _Users.Estado = "I" Then
                        chkEstado.Checked = False
                    Else
                        chkEstado.Checked = True
                    End If
                    bbiGuardar.Enabled = False
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub bbiEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Try
            If _ClickGrilla = "" Then
                MessageBox.Show("Debe seleccionar un usuario", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf MessageBox.Show("Desea Inactivar el Usuario?", "Registro de Usuarios",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                = DialogResult.Yes Then
                _DUsers.eliminarusuario(_ClickGrilla)
                ActualizarGrilla()
                LimpiarCampos()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboEmpleados_EditValueChanged(sender As Object, e As EventArgs) Handles cboEmpleados.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtUsuario_EditValueChanged(sender As Object, e As EventArgs) Handles txtUsuario.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub txtClave_EditValueChanged(sender As Object, e As EventArgs) Handles txtClave.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub chkEstado_EditValueChanged(sender As Object, e As EventArgs) Handles chkEstado.EditValueChanged
        bbiGuardar.Enabled = True
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID_EMPLEADO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
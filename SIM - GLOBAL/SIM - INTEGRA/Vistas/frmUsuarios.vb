Imports SIM___GLOBAL.Controles
Public Class frmUsuarios
    Dim _ds As DataSet
    Dim _dUsuarios = New SIM___INTEGRA.Controles.DUsuarios
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _usuarios As New SIM___INTEGRA.Modelo.Usuarios
    ReadOnly _tipoIdentificacion = New DTipoIdentificacion
    Private Sub ActivarGuardar()
        bbtGuardar.Enabled = True
    End Sub
    Private Sub LimpiarCampos()
        txtCodigo.Text = ""
        cboTipoIdentificacion.ItemIndex = 0
        txtNumeroIdentificacion.Text = ""
        txtPrimerNombre.Text = ""
        txtSegundoNombre.Text = ""
        txtPrimerApellido.Text = ""
        txtSegundoApellido.Text = ""
        cboSexo.SelectedIndex = 0
        dtFechaNacimiento.Text = ""
        txtCiudadNacimiento.Text = ""
        txtPaisNacimiento.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtCorreoElectronico.Text = ""
        cboEstadoCivil.SelectedIndex = 0
        txtOcupacion.Text = ""
        cboTipoIdentificacion.Enabled = True
        txtNumeroIdentificacion.Enabled = True
        txtacompanante.Text = ""
        txtTelefonoA.Text = ""
        txtTelefonoR.Text = ""
        txtResponsable.Text = ""
        txtParentescoA.Text = ""
        txtParentescoR.Text = ""
        bbtGuardar.Enabled = False
    End Sub
    Private Sub ActualizarGrilla()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        _ds = _dUsuarios.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub Guardar()
        _usuarios.IdTipoIdentificacion = cboTipoIdentificacion.GetColumnValue("CODIGO")
        _usuarios.Identificacion = txtNumeroIdentificacion.Text
        _usuarios.PrimerNombre = txtPrimerNombre.Text
        _usuarios.SegundoNombre = txtSegundoNombre.Text
        _usuarios.PrimerApellido = txtPrimerApellido.Text
        _usuarios.SegundoApellido = txtSegundoApellido.Text
        _usuarios.Sexo = cboSexo.Text
        _usuarios.FechaNacimiento = dtFechaNacimiento.Text
        _usuarios.CiudadNacimiento = txtCiudadNacimiento.Text
        _usuarios.PaisNacimiento = txtPaisNacimiento.Text
        _usuarios.Direccion = txtDireccion.Text
        _usuarios.Telefono = txtTelefono.Text
        _usuarios.CorreoElectronico = txtCorreoElectronico.Text
        _usuarios.EstadoCivil = cboEstadoCivil.Text
        _usuarios.Ocupacion = txtOcupacion.Text
        _usuarios.Responsable = txtResponsable.Text
        _usuarios.ParentescoR = txtParentescoR.Text
        _usuarios.TelefonoR = txtTelefonoR.Text
        _usuarios.Acompanante = txtacompanante.Text
        _usuarios.ParentescoA = txtParentescoA.Text
        _usuarios.TelefonoA = txtTelefonoA.Text
        'If _dUsuarios.verificarusuario(cboTipoIdentificacion.GetColumnValue("CODIGO"), txtNumeroIdentificacion.Text) = True Then
        'MessageBox.Show("El Paciente con esta Identificacion ya ha sido Registrado", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else

        _dUsuarios.Guardar(_usuarios)
    End Sub
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSexo.SelectedIndex = 0
        cboEstadoCivil.SelectedIndex = 0

        'Llenamos lista de usuarios
        ActualizarGrilla()

        'llenamos campo tipo identificacion
        _ds = New DataSet()
        _ds = _tipoIdentificacion.listar()
        cboTipoIdentificacion.Properties.DataSource = _ds.Tables(0)
        cboTipoIdentificacion.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoIdentificacion.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoIdentificacion.ItemIndex = 0
        '----------------------------------
        bbtGuardar.Enabled = False

    End Sub

    Private Sub bbtConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtConsultar.ItemClick
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

    Private Sub bbtEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtEditar.ItemClick
        Try
            If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                txtCodigo.Enabled = False
                _usuarios = _dUsuarios.Cargar(_ClickGrilla)
                txtCodigo.Text = _ClickGrilla
                txtNumeroIdentificacion.Text = _usuarios.Identificacion
                txtPrimerNombre.Text = _usuarios.PrimerNombre
                txtSegundoNombre.Text = _usuarios.SegundoNombre
                txtPrimerApellido.Text = _usuarios.PrimerApellido
                txtSegundoApellido.Text = _usuarios.SegundoApellido
                txtCiudadNacimiento.Text = _usuarios.CiudadNacimiento
                txtPaisNacimiento.Text = _usuarios.PaisNacimiento
                txtDireccion.Text = _usuarios.Direccion
                txtTelefono.Text = _usuarios.Telefono
                txtCorreoElectronico.Text = _usuarios.CorreoElectronico
                cboSexo.Text = _usuarios.Sexo
                dtFechaNacimiento.Text = _usuarios.FechaNacimiento
                cboEstadoCivil.Text = _usuarios.EstadoCivil
                txtOcupacion.Text = _usuarios.Ocupacion
                txtResponsable.Text = _usuarios.Responsable
                txtParentescoR.Text = _usuarios.ParentescoR
                txtTelefonoR.Text = _usuarios.TelefonoR
                txtacompanante.Text = _usuarios.Acompanante
                txtParentescoA.Text = _usuarios.ParentescoA
                txtTelefonoA.Text = _usuarios.TelefonoA
                cboTipoIdentificacion.ItemIndex = cboTipoIdentificacion.Properties.GetDataSourceRowIndex("CODIGO", _usuarios.IdTipoIdentificacion)
                txtNumeroIdentificacion.Enabled = False
                cboTipoIdentificacion.Enabled = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bbtGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtGuardar.ItemClick
        If txtNumeroIdentificacion.Text = "" Then
            MessageBox.Show("El Campo Identificación es Obligatorio", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtPrimerNombre.Text = "" Then
            MessageBox.Show("El Campo Primer Nombre es Obligatorio", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtPrimerApellido.Text = "" Then
            MessageBox.Show("El Campo Primer Apellido es Obligatorio", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaNacimiento.Text = "" Then
            MessageBox.Show("El Campo Fecha de Nacimiento es Obligatorio", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()

            'llenamos la grilla de registros
            ActualizarGrilla()
            LimpiarCampos()

            'End If
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub cboTipoIdentificacion_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoIdentificacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtNumeroIdentificacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtNumeroIdentificacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtPrimerNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtPrimerNombre.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtSegundoNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtSegundoNombre.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtPrimerApellido_EditValueChanged(sender As Object, e As EventArgs) Handles txtPrimerApellido.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtSegundoApellido_EditValueChanged(sender As Object, e As EventArgs) Handles txtSegundoApellido.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboSexo_EditValueChanged(sender As Object, e As EventArgs) Handles cboSexo.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub dtFechaNacimiento_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaNacimiento.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtCiudadNacimiento_EditValueChanged(sender As Object, e As EventArgs) Handles txtCiudadNacimiento.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtPaisNacimiento_EditValueChanged(sender As Object, e As EventArgs) Handles txtPaisNacimiento.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDireccion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDireccion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtTelefono_EditValueChanged(sender As Object, e As EventArgs) Handles txtTelefono.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtCorreoElectronico_EditValueChanged(sender As Object, e As EventArgs) Handles txtCorreoElectronico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboEstadoCivil_EditValueChanged(sender As Object, e As EventArgs) Handles cboEstadoCivil.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtOcupacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtOcupacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtResponsable_EditValueChanged(sender As Object, e As EventArgs) Handles txtResponsable.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtParentescoR_EditValueChanged(sender As Object, e As EventArgs) Handles txtParentescoR.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtTelefonoR_EditValueChanged(sender As Object, e As EventArgs) Handles txtTelefonoR.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtacompanante_EditValueChanged(sender As Object, e As EventArgs) Handles txtacompanante.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtParentescoA_EditValueChanged(sender As Object, e As EventArgs) Handles txtParentescoA.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtTelefonoA_EditValueChanged(sender As Object, e As EventArgs) Handles txtTelefonoA.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtNumeroIdentificacion_Leave(sender As Object, e As EventArgs) Handles txtNumeroIdentificacion.Leave
        If _dUsuarios.existe(cboTipoIdentificacion.GetColumnValue("CODIGO"), txtNumeroIdentificacion.Text) = True Then
            MessageBox.Show("Ya existe un usuario registrado con este numero", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNumeroIdentificacion.Text = ""
        End If
    End Sub
End Class
Public Class frmJugadores
    Dim _ds As DataSet
    Dim _DJugadores As New ADOSPLAY.My.Controles.DJugadores
    Dim _Clickgrilla As String
    Dim _Jugadores As New ADOSPLAY.My.Modelo.Jugadores
    Private Sub LimpiarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        dtFechaNacimiento.Text = ""
        cboSexo.SelectedIndex = 0
        txtEstatura.Text = ""
        txtPeso.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        bbiGuardar.Enabled = False
    End Sub
    Private Sub frmJugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSVistas.DTJugadores' Puede moverla o quitarla según sea necesario.
        ' Me.DTJugadoresTableAdapter.Fill(Me.DSVistas.DTJugadores)
        'LLENAR GRID VIEW 
        _ds = New DataSet
        _ds = _DJugadores.Listar()
        GCConsultar.DataSource = _ds.Tables(0)

    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiAbrir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbrir.ItemClick
        Try
            If _ClickGrilla = "" Then
                MessageBox.Show("No ha seleccionado el paciente", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                If MessageBox.Show("Desea Editar el Registro " & _ClickGrilla & "?", "Editar Registros ",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                    txtID.Enabled = False
                    '  _Jugadores = _dUsuarios.Cargar(_Clickgrilla)
                    '  txtCodigo.Text = _ClickGrilla
                    '  txtNumeroIdentificacion.Text = _usuarios.Identificacion
                    '  txtPrimerNombre.Text = _usuarios.PrimerNombre
                    '  txtSegundoNombre.Text = _usuarios.SegundoNombre
                    ' txtPrimerApellido.Text = _usuarios.PrimerApellido
                    '  txtSegundoApellido.Text = _usuarios.SegundoApellido
                    '  txtCiudadNacimiento.Text = _usuarios.CiudadNacimiento
                    '  txtPaisNacimiento.Text = _usuarios.PaisNacimiento
                    '  txtDireccion.Text = _usuarios.Direccion
                    '  txtTelefono.Text = _usuarios.Telefono
                    '  txtCorreoElectronico.Text = _usuarios.CorreoElectronico
                    '  cboSexo.Text = _usuarios.Sexo
                    '  dtFechaNacimiento.Text = _usuarios.FechaNacimiento
                    '  cboEstadoCivil.Text = _usuarios.EstadoCivil
                    '  cboTipoIdentificacion.ItemIndex = cboTipoIdentificacion.Properties.GetDataSourceRowIndex("CODIGO", _usuarios.CodigotipoIdentificacion)
                    '  cboDepartamentos.ItemIndex = cboDepartamentos.Properties.GetDataSourceRowIndex("CODIGO", Mid(_usuarios.CodigoMunicipio, 1, 2))
                    '  cboMunicipios.ItemIndex = cboMunicipios.Properties.GetDataSourceRowIndex("CODIGO", Mid(_usuarios.CodigoMunicipio, 3, 3))
                    '  txtNumeroIdentificacion.Enabled = False
                    '  cboTipoIdentificacion.Enabled = False
                    bbiGuardar.Enabled = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
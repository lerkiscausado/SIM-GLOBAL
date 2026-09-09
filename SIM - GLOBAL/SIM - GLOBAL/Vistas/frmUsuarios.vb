Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Imports System.Text.RegularExpressions
Public Class frmUsuarios
    Dim _ds As DataSet
    Dim _dUsuarios = New DUsuarios
    Dim _Clientes As New SIM___GLOBAL.Modelo.Clientes
    Dim _DClientes As New SIM___GLOBAL.Controles.DClientes
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _usuarios As New Usuarios
    ReadOnly _tipoIdentificacion = New DTipoIdentificacion
    ReadOnly _departamentos = New DDepartamentos
    ReadOnly _municipios = New DMunicipios
    Dim _funciones As New SIM___GLOBAL.Utilidades.Funciones
    Public Licencia As String
    Public IdEmpleado As String

    Private Function ValidarMail(ByVal EMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(EMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    ''' <summary>
    ''' Los combos de Etnia/Discapacidad/Identidad de Género muestran "CODIGO - Descripción"
    ''' (ver Properties.Items en el Designer). Estas dos funciones convierten entre el código
    ''' guardado en base de datos y el texto mostrado en el combo.
    ''' </summary>
    Private Function ObtenerCodigoDeCombo(combo As DevExpress.XtraEditors.ComboBoxEdit) As String
        If combo.SelectedIndex < 0 OrElse String.IsNullOrEmpty(combo.Text) Then Return ""
        Dim partes = combo.Text.Split(New String() {" - "}, 2, StringSplitOptions.None)
        Return If(partes.Length > 0, partes(0).Trim(), "")
    End Function

    Private Sub SeleccionarItemComboPorCodigo(combo As DevExpress.XtraEditors.ComboBoxEdit, codigo As String)
        combo.SelectedIndex = -1
        If String.IsNullOrWhiteSpace(codigo) Then Exit Sub
        For i As Integer = 0 To combo.Properties.Items.Count - 1
            Dim item As String = combo.Properties.Items(i).ToString()
            Dim codigoItem As String = item.Split(New String() {" - "}, 2, StringSplitOptions.None)(0).Trim()
            If codigoItem = codigo.Trim() Then
                combo.SelectedIndex = i
                Exit Sub
            End If
        Next
    End Sub

    Private Sub ActualizarGrilla()
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _dUsuarios.Listarultimosregistros()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub

    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub GuardarRegistro()
        Dim _Registros As New SIM___GLOBAL.Modelo.Registros
        Dim _DRegistros As New SIM___GLOBAL.Controles.DRegistros
        Try
            _Registros.Fecha = DateTime.Now
            _Registros.IdTabla = 1
            If txtCodigo.Text = "" Then
                '_Registros.IdRegistro = _Ordenes.Id
                _Registros.TipoRegistro = "Registro"
            Else
                _Registros.IdRegistro = txtCodigo.Text
                _Registros.TipoRegistro = "Actualizacion"
            End If
            _Registros.IdUsuario = IdEmpleado
            _Registros.Nota = ""
            _DRegistros.Guardar(_Registros)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Registro")
        End Try
    End Sub

    Private Sub GuardarUsuarios()
        _usuarios.ID = Val(txtCodigo.Text)
        _usuarios.CodigotipoIdentificacion = cboTipoIdentificacion.GetColumnValue("CODIGO")
        _usuarios.Identificacion = txtNumeroIdentificacion.Text
        _usuarios.PrimerNombre = txtPrimerNombre.Text
        _usuarios.SegundoNombre = txtSegundoNombre.Text
        _usuarios.PrimerApellido = txtPrimerApellido.Text
        _usuarios.SegundoApellido = txtSegundoApellido.Text
        _usuarios.Sexo = cboSexo.Text
        _usuarios.FechaNacimiento = dtFechaNacimiento.Text
        _usuarios.CiudadNacimiento = txtCiudadNacimiento.Text
        _usuarios.PaisNacimiento = ""
        _usuarios.Direccion = txtDireccion.Text
        _usuarios.Telefono = txtTelefono.Text
        _usuarios.CorreoElectronico = txtCorreoElectronico.Text
        _usuarios.EstadoCivil = cboEstadoCivil.Text
        _usuarios.CodigoMunicipio = cboDepartamentos.GetColumnValue("CODIGO") & cboMunicipios.GetColumnValue("CODIGO")
        _usuarios.Foto = _funciones.Imagen_Bytes(peFoto.EditValue)
        _usuarios.CodigoPaisNacimiento = If(cboPais.EditValue IsNot Nothing, cboPais.EditValue.ToString(), "")
        _usuarios.CodigoEtnia = ObtenerCodigoDeCombo(cboEtnia)
        _usuarios.CodigoDiscapacidad = ObtenerCodigoDeCombo(cboDiscapacidad)
        _usuarios.CodigoIdentidadGenero = ObtenerCodigoDeCombo(cboIdentidadGenero)
        _dUsuarios.Guardar(_usuarios)
    End Sub
    Private Sub GuardarClientes()
        _Clientes.Id = Val(txtCodigo.Text)
        _Clientes.IdTipoIdentificacion = cboTipoIdentificacion.GetColumnValue("CODIGO")
        _Clientes.Identificacion = txtNumeroIdentificacion.Text
        _Clientes.Nombre = txtPrimerNombre.Text & " " & txtSegundoNombre.Text & " " & txtPrimerApellido.Text & " " & txtSegundoApellido.Text
        _Clientes.Contacto = "NO APLICA"
        _Clientes.Direccion = txtDireccion.Text
        _Clientes.Telefono = txtTelefono.Text
        _Clientes.CorreoElectronico = txtCorreoElectronico.Text
        _Clientes.Estado = "A"
        _DClientes.Guardar(_Clientes)
    End Sub
    Private Sub LimpiarCampos()
        txtCodigo.Text = ""
        cboTipoIdentificacion.ItemIndex = 0
        cboDepartamentos.ItemIndex = 4
        cboMunicipios.ItemIndex = 0
        txtNumeroIdentificacion.Text = ""
        txtPrimerNombre.Text = ""
        txtSegundoNombre.Text = ""
        txtPrimerApellido.Text = ""
        txtSegundoApellido.Text = ""
        cboSexo.SelectedIndex = 0
        dtFechaNacimiento.Text = ""
        txtEdad.Text = ""
        txtCiudadNacimiento.Text = ""

        cboPais.EditValue = "170" ' Colombia por defecto
        SeleccionarItemComboPorCodigo(cboEtnia, "99")   ' Ninguna de las anteriores (valor por defecto)
        SeleccionarItemComboPorCodigo(cboDiscapacidad, "08")  ' Sin discapacidad (valor por defecto)
        cboIdentidadGenero.SelectedIndex = -1
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtCorreoElectronico.Text = ""
        cboEstadoCivil.SelectedIndex = 0
        cboTipoIdentificacion.Enabled = True
        txtNumeroIdentificacion.Enabled = True
        lblCodigoResultado.Visible = False
        txtCodigoResultado.Visible = False
        bbiGuardar.Enabled = False
        Try
            'Cargamos FOTO Temporal
            Select Case Licencia
                Case 14, 15, 16 '14. Fernando Ponce - 15. Optica Freisem y 16
                    peFoto.Image = Image.FromFile("c:\sim\imagenes\foto.jpg")
                Case Else
                    peFoto.Image = Image.FromFile("x:\foto.jpg")
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Cargamos FOTO Temporal
            'Select Case Licencia
            ' Case 14, 15
            ' peFoto.Image = Image.FromFile("c:\sim\imagenes\foto.jpg")
            ' Case 16
            ' peFoto.Image = Image.FromFile("c:\pec\imagenes\foto.jpg")
            ' Case Else
            ' peFoto.Image = Image.FromFile("x:\foto.jpg")
            ' End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'ACtualizar grilla
        ActualizarGrilla()


        cboSexo.SelectedIndex = 0
        cboEstadoCivil.SelectedIndex = 0
        'llenamos campo tipo identificacion
        _ds = New DataSet()
        _ds = _tipoIdentificacion.listar()
        cboTipoIdentificacion.Properties.DataSource = _ds.Tables(0)
        cboTipoIdentificacion.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoIdentificacion.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoIdentificacion.ItemIndex = 0
        '----------------------------------
        'llenamos campo departamentos
        _ds = New DataSet()
        _ds = _departamentos.listar()
        cboDepartamentos.Properties.DataSource = _ds.Tables(0)
        cboDepartamentos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboDepartamentos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        'cboDepartamentos.ItemIndex = 4
        Select Case Licencia
            Case 11
                cboDepartamentos.EditValue = "47"
            Case Else
                cboDepartamentos.EditValue = "13"
        End Select

        '----------------------------------
        'llenamos campo Pais Nacimiento (código ISO 3166-1 numérico, requerido por RDA-Paciente:
        ' https://fhir.minsalud.gov.co/rda/CodeSystem/ISO31661). Lista de los países más comunes
        ' en la práctica; se puede ampliar si se atienden pacientes de otras nacionalidades.
        Dim dtPaises As New DataTable()
        dtPaises.Columns.Add("CODIGO", GetType(String))
        dtPaises.Columns.Add("NOMBRE", GetType(String))
        Dim paises As (String, String)() = {
            ("170", "Colombia"),
            ("862", "Venezuela"),
            ("218", "Ecuador"),
            ("604", "Perú"),
            ("076", "Brasil"),
            ("032", "Argentina"),
            ("152", "Chile"),
            ("068", "Bolivia"),
            ("600", "Paraguay"),
            ("858", "Uruguay"),
            ("591", "Panamá"),
            ("188", "Costa Rica"),
            ("340", "Honduras"),
            ("222", "El Salvador"),
            ("320", "Guatemala"),
            ("558", "Nicaragua"),
            ("192", "Cuba"),
            ("214", "República Dominicana"),
            ("484", "México"),
            ("840", "Estados Unidos"),
            ("124", "Canadá"),
            ("724", "España"),
            ("380", "Italia"),
            ("250", "Francia"),
            ("276", "Alemania"),
            ("826", "Reino Unido"),
            ("620", "Portugal"),
            ("156", "China"),
            ("356", "India"),
            ("999", "Otro país no listado")
        }
        For Each p In paises
            dtPaises.Rows.Add(p.Item1, p.Item2)
        Next
        cboPais.Properties.DataSource = dtPaises
        cboPais.Properties.DisplayMember = "NOMBRE"
        cboPais.Properties.ValueMember = "CODIGO"
        cboPais.Properties.Columns.Clear()
        cboPais.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO", "Código"))
        cboPais.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "País"))
        cboPais.EditValue = "170" ' Colombia por defecto

        '----------------------------------

        'llenamos campo Municipios
        'Select Case Licencia
        'Case 11 'CitoPat de la costa
        '_ds = New DataSet()
        '        _ds = _municipios.listar(47)
        'Case Else
        '_ds = New DataSet()
        '_ds = _municipios.listar(13)
        'End Select
        'cboMunicipios.Properties.DataSource = _ds.Tables(0)
        'cboMunicipios.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        'cboMunicipios.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        'cboMunicipios.ItemIndex = 0
        '----------------------------------

        bbiGuardar.Enabled = False
    End Sub
    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Dim _Sesiones As New SIM___GLOBAL.Modelo.Sesiones
        Dim _DSesiones As New SIM___GLOBAL.Controles.DSesiones

        If _ClickGrilla = "" Then
                MessageBox.Show("No ha seleccionado el paciente", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else


            If MessageBox.Show("Desea Editar el Registro ?", "Editar Registros ",
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

                If Not String.IsNullOrWhiteSpace(_usuarios.CodigoPaisNacimiento) Then
                        cboPais.EditValue = _usuarios.CodigoPaisNacimiento
                    Else
                        cboPais.EditValue = "170" ' Colombia por defecto si aún no se ha capturado
                    End If
                    SeleccionarItemComboPorCodigo(cboEtnia, _usuarios.CodigoEtnia)
                    SeleccionarItemComboPorCodigo(cboDiscapacidad, _usuarios.CodigoDiscapacidad)
                    SeleccionarItemComboPorCodigo(cboIdentidadGenero, _usuarios.CodigoIdentidadGenero)
                    txtDireccion.Text = _usuarios.Direccion
                    txtTelefono.Text = _usuarios.Telefono
                    txtCorreoElectronico.Text = _usuarios.CorreoElectronico
                    cboSexo.Text = _usuarios.Sexo
                    dtFechaNacimiento.Text = _usuarios.FechaNacimiento
                    'calcular edad
                    txtEdad.Text = Year(Date.Now) - Year(dtFechaNacimiento.Text)
                    cboEstadoCivil.Text = _usuarios.EstadoCivil
                    cboTipoIdentificacion.ItemIndex = cboTipoIdentificacion.Properties.GetDataSourceRowIndex("CODIGO", _usuarios.CodigotipoIdentificacion)
                    cboDepartamentos.ItemIndex = cboDepartamentos.Properties.GetDataSourceRowIndex("CODIGO", Mid(_usuarios.CodigoMunicipio, 1, 2))
                    cboMunicipios.ItemIndex = cboMunicipios.Properties.GetDataSourceRowIndex("CODIGO", Mid(_usuarios.CodigoMunicipio, 3, 3))
                    'Lamar funcion image bytes

                    Dim img2 As Image

                Try
                    img2 = _funciones.Bytes_Imagen(_usuarios.Foto)
                    peFoto.EditValue = img2
                    txtNumeroIdentificacion.Enabled = False
                    cboTipoIdentificacion.Enabled = False
                    bbiGuardar.Enabled = False
                Catch ex As Exception

                End Try

                If _DSesiones.ExisteUsuario(txtCodigo.Text) = True Then
                    lblCodigoResultado.Visible = True
                    txtCodigoResultado.Visible = True
                    _Sesiones = _DSesiones.Cargar(_ClickGrilla)
                    txtCodigoResultado.Text = _Sesiones.Contrasena
                End If

            End If
        End If

    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNumeroIdentificacion.Text = "" Then
            MessageBox.Show("El Campo Identificación es Obligatorio", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtPrimerNombre.Text = "" Then
            MessageBox.Show("El Campo Primer Nombre es Obligatorio", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtPrimerApellido.Text = "" Then
            MessageBox.Show("El Campo Primer Apellido es Obligatorio", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaNacimiento.Text = "" Then
            MessageBox.Show("El Campo Fecha de Nacimiento es Obligatorio", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtEdad.Text = "" Then
            MessageBox.Show("El Campo Edad es Obligatorio", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCorreoElectronico.Text <> "" And ValidarMail(txtCorreoElectronico.Text) = False Then
            MessageBox.Show("El correo electronico ingresado esta errado", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            GuardarUsuarios()

            'Guardamos en la tabla registros el registro del usuario
            If txtCodigo.Text = "" Then
                'Traemos el ultimo registro de la tabla Usuarios
                _usuarios = _dUsuarios.ultimoregistro()
                _funciones.GuardarRegistro("1", _usuarios.ID, IdEmpleado, "Registro", cboTipoIdentificacion.GetColumnValue("CODIGO") & txtNumeroIdentificacion.Text)
            Else
                _funciones.GuardarRegistro("1", txtCodigo.Text, IdEmpleado, "Actualizacion", cboTipoIdentificacion.GetColumnValue("CODIGO") & txtNumeroIdentificacion.Text)
            End If

            'Guardamos Usuario en Tabla Clientes
            Select Case Licencia
                Case 11, 15
                    'Validamos si el usuario existe en la tabla Clientes para crearlo
                    If _DClientes.Existe(cboTipoIdentificacion.GetColumnValue("CODIGO"), txtNumeroIdentificacion.Text) = False Then
                        GuardarClientes()
                    End If
                Case Else
            End Select

            'llenamos la grilla de registros
            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub cboDepartamentos_EditValueChanged(sender As Object, e As EventArgs) Handles cboDepartamentos.EditValueChanged
        'llenamos campo Municipios
        _ds = New DataSet()
        _ds = _municipios.listar(cboDepartamentos.GetColumnValue("CODIGO"))
        cboMunicipios.Properties.DataSource = _ds.Tables(0)
        cboMunicipios.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboMunicipios.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboMunicipios.ItemIndex = 0
        bbiGuardar.Enabled = True
        '----------------------------------
    End Sub

    Private Sub txtNumeroIdentificacion_Leave(sender As Object, e As EventArgs) Handles txtNumeroIdentificacion.Leave
        If _dUsuarios.existe(cboTipoIdentificacion.GetColumnValue("CODIGO"), txtNumeroIdentificacion.Text) = True Then
            MessageBox.Show("Ya existe un usuario registrado con este numero", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNumeroIdentificacion.Text = ""
        End If
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

    Private Sub txtPaisNacimiento_EditValueChanged(sender As Object, e As EventArgs)
        ActivarGuardar()
    End Sub

    Private Sub cboPais_EditValueChanged(sender As Object, e As EventArgs) Handles cboPais.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboEtnia_EditValueChanged(sender As Object, e As EventArgs) Handles cboEtnia.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboDiscapacidad_EditValueChanged(sender As Object, e As EventArgs) Handles cboDiscapacidad.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboIdentidadGenero_EditValueChanged(sender As Object, e As EventArgs) Handles cboIdentidadGenero.EditValueChanged
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

    Private Sub cboMunicipios_EditValueChanged(sender As Object, e As EventArgs) Handles cboMunicipios.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboEstadoCivil_EditValueChanged(sender As Object, e As EventArgs) Handles cboEstadoCivil.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub peFoto_EditValueChanged(sender As Object, e As EventArgs) Handles peFoto.EditValueChanged
        Dim Imagen As Image
        Imagen = peFoto.EditValue
        ActivarGuardar()
        If Imagen.Size.Width > 273 Or Imagen.Size.Height > 320 Then
            MessageBox.Show("Maxima Resolucion Soportada 320 Pixeles", "Registro de Foto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtEdad_Leave(sender As Object, e As EventArgs) Handles txtEdad.Leave
        'MsgBox(Year(Date.Now) - Val(txtEdad.Text))
        dtFechaNacimiento.Text = "06/06/" & Val(Format(DateTime.Now, "yyyy")) - Val(txtEdad.Text)

    End Sub

    Private Sub dtFechaNacimiento_Leave(sender As Object, e As EventArgs) Handles dtFechaNacimiento.Leave
        If dtFechaNacimiento.Text <> Nothing Then
            txtEdad.Text = Year(Date.Now) - Year(dtFechaNacimiento.Text)
        End If

    End Sub

    Private Sub tsmActualizarVista_Click(sender As Object, e As EventArgs) Handles tsmActualizarVista.Click
        ActualizarGrilla()
    End Sub

    Private Sub tsmTodoslosRegistros_Click(sender As Object, e As EventArgs) Handles tsmTodoslosRegistros.Click
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _dUsuarios.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
End Class
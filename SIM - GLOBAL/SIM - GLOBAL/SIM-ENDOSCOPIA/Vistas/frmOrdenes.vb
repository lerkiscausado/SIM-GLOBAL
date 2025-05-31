Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.Utilidades
Public Class frmOrdenes
    Dim _ds As DataSet
    Dim _dOrdenes As New DOrdenes
    Dim _ordenes As New Ordenes
    Dim _dUsuarios = New DUsuarios
    Dim _DetalleOrden As New DetalleOrden
    Dim _DDetalleOrden As New DDetalleOrden
    Dim _DDetalleTarifa As New DDetalleTarifas
    Dim _Dorden = New SIM___GLOBAL.Controles.DOrdenes
    Dim _IdUsuario As Integer
    Dim _IdContrato As Integer
    Dim _idTipoEstudio As Integer
    Dim _TipoAtencion As String
    Dim NumeroEstudio As String
    Dim _ClickGrilla As String
    Dim _ClickIdentificacion As String
    Dim _ClickGrillaDetalleOrden As String
    Dim _Fila As Integer

#Region "PROCEDIMIENTOS"
    Private Sub LimpiarCampos()
        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
        txtConsecutivo.Text = ""
        txtDatosUsuario.Text = ""
        txtComentarios.Text = ""
        txtConsecutivo.Text = ""
        cboTipoAfiliado.ItemIndex = 0
        cboTipoUsuario.ItemIndex = 0
        dtFechaOrden.Text = ""
        txtAutorizacion.Text = ""
        txtNumeroOrden.Text = ""
        GPDetalleOrden.Visible = False

        ' Cargar Contratos
        cboContrato.Properties.ValueMember = Nothing
        cboContrato.ReadOnly = False

        Dim _DContratos = New DContratos
        _ds = _DContratos.ListarCombo
        cboContrato.Properties.DataSource = _ds.Tables(0)
        cboContrato.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboContrato.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboContrato.ItemIndex = -1

        'Eliminamos todos los registros de Detalle Orden que no tienen id_Orden
        '_DDetalleOrden.EliminarDetalleOrden("0")

        ActualizarGrillaDetalleOrden("")
        bbiGuardar.Enabled = False
    End Sub
    Private Sub LimpiarCamposDetalleOrden()
        txtCodigoProcedimiento.Text = ""
        txtValor.Text = ""
        txtCopago.Text = ""
        txtNeto.Text = ""
        txtCodigoCups.Text = ""
        cboProcedimiento.Text = ""
    End Sub
    Private Sub GuardarOrdenes()
        Try
            _ordenes.Id = Val(txtConsecutivo.Text)
            _ordenes.IdUsuario = _IdUsuario
            _ordenes.IdContrato = cboContrato.GetColumnValue("ID")
            _ordenes.IdSubEntidad = cboSubentidades.GetColumnValue("ID")

            _ordenes.IdIngreso = Val("2")
            _ordenes.IdSede = Val("1")
            _ordenes.IdEmpleado = cboMedico.GetColumnValue("ID")
            _ordenes.Autorizacion = txtAutorizacion.Text
            _ordenes.NumeroOrden = txtNumeroOrden.Text

            _ordenes.FechaIngreso = dtFechaIngreso.Text
            _ordenes.FechaOrden = dtFechaOrden.Text
            _ordenes.Hora = DateTime.Now
            _ordenes.Idfactura = "0"

            _ordenes.IdTipoAfiliado = cboTipoAfiliado.GetColumnValue("ID")
            _ordenes.IdTipoUsuario = cboTipoUsuario.GetColumnValue("ID")
            _ordenes.IdTipoEstudio = cboTipoEstudio.GetColumnValue("ID")

            _ordenes.Comentarios = txtComentarios.Text
            _ordenes.Estado = "PENDIENTE"
            _dOrdenes.Guardar(_ordenes)
            bbiGuardar.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Ordenes")
        End Try
    End Sub
    Private Sub CancelarDetalleOrden()
        Try
            _DetalleOrden.IdOrden = Val(txtConsecutivo.Text)
            _DetalleOrden.IdCausa = Val("15")
            _DetalleOrden.IdFinalidadConsulta = Val("10")
            _DetalleOrden.IdFinalidadProcedimiento = Val("1")
            _DetalleOrden.IdAmbito = Val("1")
            _DetalleOrden.IdPersonaAtiende = Val("1")
            '_DetalleOrden.FechaSalida = ""
            _DetalleOrden.Hora = DateTime.Now
            _DetalleOrden.IdTipoDiagnostico = Val("1")
            '_DetalleOrden.Diagnostico1 = ""
            '_DetalleOrden.Diagnostico2 = ""
            '_DetalleOrden.Diagnostico3 = ""
            '_DetalleOrden.Diagnostico4 = ""
            _DetalleOrden.IdFormaRealizacion = Val("1")
            _DetalleOrden.CodigoProcedimiento = "1"
            _DetalleOrden.IdTipoEstudio = "8"
            _DetalleOrden.Valor = Val(txtValor.EditValue)
            _DetalleOrden.Copago = Val(txtCopago.EditValue)
            _DetalleOrden.Neto = Val(txtNeto.EditValue)
            _DetalleOrden.CodigoCups = txtCodigoCups.Text
            _DetalleOrden.Tipo = "P"
            _DetalleOrden.Estado = "CANCELADO"
            _DDetalleOrden.GuardarDetalleOrden(_DetalleOrden)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Cancelar Detalle de Orden")
        End Try
    End Sub
    Private Sub GuardarDetalleOrden()
        Try
            'If txtConsecutivo.Text = "" Then
            ' _DetalleOrden.IdOrden = "0"
            'Else
            _DetalleOrden.IdOrden = Val(_ordenes.Id)
            'End If
            _DetalleOrden.IdCausa = Val("15")
            _DetalleOrden.IdFinalidadConsulta = Val("10")
            _DetalleOrden.IdFinalidadProcedimiento = Val("1")
            _DetalleOrden.IdAmbito = cboAmbitoProcedimiento.GetColumnValue("ID")
            _DetalleOrden.IdPersonaAtiende = Val("1")
            '_DetalleOrden.FechaSalida = ""
            _DetalleOrden.Hora = DateTime.Now
            _DetalleOrden.IdTipoDiagnostico = Val("1")
            '_DetalleOrden.Diagnostico1 = ""
            '_DetalleOrden.Diagnostico2 = ""
            '_DetalleOrden.Diagnostico3 = ""
            '_DetalleOrden.Diagnostico4 = ""
            _DetalleOrden.IdFormaRealizacion = Val("1")
            _DetalleOrden.CodigoProcedimiento = txtCodigoProcedimiento.Text
            _DetalleOrden.IdTipoEstudio = _idTipoEstudio 'cboProcedimiento.EditValue
            _DetalleOrden.Valor = Val(txtValor.EditValue)
            _DetalleOrden.Copago = Val(txtCopago.EditValue)
            _DetalleOrden.Neto = Val(txtNeto.EditValue)
            _DetalleOrden.CodigoCups = txtCodigoCups.Text

            _DetalleOrden.Tipo = _TipoAtencion
            _DetalleOrden.Estado = "PENDIENTE"
            _DDetalleOrden.GuardarDetalleOrden(_DetalleOrden)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Detalle de Orden")
        End Try
    End Sub
    Private Sub DatosPaciente(ByVal Filtro As Integer)
        Try
            _ds = New DataSet()
            '_ds = _dOrdenes.DatosUsuarios(Filtro)
            txtDatosUsuario.Text = "ID: " & _ds.Tables(0).Rows(0)(0).ToString & vbCrLf _
                & "IDENTIFICACION: " & _ds.Tables(0).Rows(0)(1).ToString & _ds.Tables(0).Rows(0)(2).ToString & vbCrLf _
                & "PACIENTE: " & _ds.Tables(0).Rows(0)(3).ToString & vbCrLf _
                & "SEXO: " & _ds.Tables(0).Rows(0)(4).ToString & "  EDAD: " & _ds.Tables(0).Rows(0)(5).ToString & vbCrLf _
                & "TELEFONO:  " & _ds.Tables(0).Rows(0)(6).ToString & vbCrLf _
                & "DIRECCION: " & _ds.Tables(0).Rows(0)(7).ToString
        Catch ex As Exception
            'MessageBox()
        End Try

    End Sub
    Private Sub ActualizarGrillaDetalleOrden(ByVal filtro As String)
        'LLENAR GRID VIEW 
        _ds = New DataSet
        'If txtConsecutivo.Text = "" Then
        ' _ds = _DDetalleOrden.Listar("0")
        ' Else
        _ds = _DDetalleOrden.Listar(filtro)
        ' End If
        GCDetalleOrden.DataSource = _ds.Tables(0)

    End Sub
    Private Sub EditarOrden()
        Dim _DOrden As New SIM___GLOBAL.Controles.DOrdenes
        bbiConsultar.Enabled = False
        bbtNuevo.Enabled = False
        bbiUsuarios.Enabled = False
        GCConsultar.Enabled = False
        _ordenes = _dOrdenes.Cargar(IDOrdenG)
        txtConsecutivo.Text = _ordenes.Id
        txtComentarios.Text = _ordenes.Comentarios
        cboTipoAfiliado.ItemIndex = cboTipoAfiliado.Properties.GetDataSourceRowIndex("ID", _ordenes.IdTipoAfiliado)
        cboTipoUsuario.ItemIndex = cboTipoUsuario.Properties.GetDataSourceRowIndex("ID", _ordenes.IdTipoUsuario)
        dtFechaOrden.Text = _ordenes.FechaOrden
        dtFechaIngreso.Text = _ordenes.FechaIngreso
        txtAutorizacion.Text = _ordenes.Autorizacion
        txtNumeroOrden.Text = _ordenes.NumeroOrden
        cboContrato.ItemIndex = cboContrato.Properties.GetDataSourceRowIndex("ID", _ordenes.IdContrato)
        _IdContrato = cboContrato.ItemIndex
        cboMedico.ItemIndex = cboMedico.Properties.GetDataSourceRowIndex("ID", _ordenes.IdEmpleado)
        cboTipoEstudio.ItemIndex = cboTipoEstudio.Properties.GetDataSourceRowIndex("ID", _ordenes.IdTipoEstudio)
        _ds = New DataSet()
        _ds = _dUsuarios.DatosUsuarios2(_ordenes.IdUsuario)
        txtDatosUsuario.Text = "ID: " & _ds.Tables(0).Rows(0)(0).ToString & " TI: " & _ds.Tables(0).Rows(0)(1).ToString & " IDENTIFICACION: " & _ds.Tables(0).Rows(0)(2).ToString & vbCrLf _
                             & "PACIENTE: " & _ds.Tables(0).Rows(0)(3).ToString & " " & _ds.Tables(0).Rows(0)(4).ToString & " " & _ds.Tables(0).Rows(0)(5).ToString & " " & _ds.Tables(0).Rows(0)(6).ToString & vbCrLf _
                             & "TELEFONO: " & _ds.Tables(0).Rows(0)(12).ToString

        GPDetalleOrden.Visible = True
        ActualizarGrillaDetalleOrden(_ordenes.Id)
        cboContrato.Enabled = False
        bbiGuardar.Enabled = False

    End Sub
    Private Sub ActivarGuardar()
        If txtDatosUsuario.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
#End Region
    Private Sub frmOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Eliminamos todos los registros de Detalle Orden que no tienen id_Orden
        '_DDetalleOrden.EliminarDetalleOrden("0")

        ' dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
        GPDetalleOrden.Visible = False

        'llenamos GridCONTROL Usuarios
        'LLENAR GRID VIEW 
        _ds = New DataSet
        _ds = _dUsuarios.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
        '----------------------------------

        ' Cargar Tipo Afiliado
        Dim _Dtipoafiliado = New DTipoAfiliado
        _ds = _Dtipoafiliado.Listar
        cboTipoAfiliado.Properties.DataSource = _ds.Tables(0)
        cboTipoAfiliado.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoAfiliado.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoAfiliado.ItemIndex = 0        '---------------------------------

        ' Cargar Tipo Usuario
        Dim _DtipoUsuario = New DTipoUsuario
        _ds = _DtipoUsuario.Listar
        cboTipoUsuario.Properties.DataSource = _ds.Tables(0)
        cboTipoUsuario.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoUsuario.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoUsuario.ItemIndex = 0

        ' Cargar Ambito Procedimiento
        Dim _DAmbitoProcedimiento = New SIM___GLOBAL.DAmbitoProcedimiento
        _ds = _DAmbitoProcedimiento.Listar
        cboAmbitoProcedimiento.Properties.DataSource = _ds.Tables(0)
        cboAmbitoProcedimiento.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboAmbitoProcedimiento.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboAmbitoProcedimiento.ItemIndex = 0
        '---------------------------------

        ' Cargar Tipo Estudio
        Dim _DTipoEstudio = New DTipoEstudio
        _ds = _DTipoEstudio.Listar
        cboTipoEstudio.Properties.DataSource = _ds.Tables(0)
        cboTipoEstudio.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoEstudio.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoEstudio.ItemIndex = 0
        '---------------------------------
        ' Cargar Contratos
        Dim _DContratos = New DContratos
        _ds = _DContratos.ListarCombo
        cboContrato.Properties.DataSource = _ds.Tables(0)
        cboContrato.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboContrato.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboContrato.ItemIndex = -1

        ' Cargar Especialista
        Dim _Dempleados = New DEmpleados
        _ds = _Dempleados.ListarEspecialista
        cboMedico.Properties.DataSource = _ds.Tables(0)
        cboMedico.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboMedico.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboMedico.ItemIndex = -1

        '---------------------------------
        If Formulario = "Editar" Then
            EditarOrden()
        End If

    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        Try
            If _ClickGrilla = "" Then
                MessageBox.Show("No se ha Seleccionado Paciente", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtConsecutivo.Text <> "" And GVDetalleOrden.DataRowCount = 0 Then
                If MessageBox.Show("La Orden no puede quedar sin detalle, Si presiona ACEPTAR se cancelara la Orden. ¿Desea Continuar?", "Nueva Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    If _Dorden.OrdenPendiente(txtConsecutivo.Text) = True Then
                        _Dorden.CancelarOrden(txtConsecutivo.Text)
                        CancelarDetalleOrden()
                        MessageBox.Show("La Orden # " & txtConsecutivo.Text & " Fue cancelada", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarCampos()
                    Else
                        MessageBox.Show("La Orden ya esta en estado ATENDIDO o CANCELADO, debe agregar el detalle", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            ElseIf bbiGuardar.Enabled = True Then
                If MessageBox.Show("Realizo cambios en la Orden, Si presiona ACEPTAR se perderan los cambios. ¿Desea Continuar?", "Nueva Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    LimpiarCampos()
                    _ds = New DataSet()
                    _ds = _dUsuarios.DatosUsuarios(_ClickGrilla, _ClickIdentificacion)
                    txtDatosUsuario.Text = "ID: " & _ds.Tables(0).Rows(0)(0).ToString & " TI: " & _ds.Tables(0).Rows(0)(1).ToString & " IDENTIFICACION: " & _ds.Tables(0).Rows(0)(2).ToString & vbCrLf _
                             & "PACIENTE: " & _ds.Tables(0).Rows(0)(3).ToString & " " & _ds.Tables(0).Rows(0)(4).ToString & " " & _ds.Tables(0).Rows(0)(5).ToString & " " & _ds.Tables(0).Rows(0)(6).ToString & vbCrLf _
                             & "TELEFONO: " & _ds.Tables(0).Rows(0)(12).ToString
                    _IdUsuario = _ds.Tables(0).Rows(0)(0).ToString
                End If
            Else
                LimpiarCampos()
                _ds = New DataSet()
                _ds = _dUsuarios.DatosUsuarios(_ClickGrilla, _ClickIdentificacion)
                txtDatosUsuario.Text = "ID: " & _ds.Tables(0).Rows(0)(0).ToString & " TI: " & _ds.Tables(0).Rows(0)(1).ToString & " IDENTIFICACION: " & _ds.Tables(0).Rows(0)(2).ToString & vbCrLf _
                         & "PACIENTE: " & _ds.Tables(0).Rows(0)(3).ToString & " " & _ds.Tables(0).Rows(0)(4).ToString & " " & _ds.Tables(0).Rows(0)(5).ToString & " " & _ds.Tables(0).Rows(0)(6).ToString & vbCrLf _
                         & "TELEFONO: " & _ds.Tables(0).Rows(0)(12).ToString
                _IdUsuario = _ds.Tables(0).Rows(0)(0).ToString
            End If

            Dim funciones = New Funciones
            funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
        Catch ex As Exception

        End Try
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
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "TI").ToString()
            _ClickIdentificacion = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "IDENTIFICACION").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtDatosUsuario.Text = "" Then
            MessageBox.Show("No ha seleccionado el paciente", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaOrden.Text = "" Then
            MessageBox.Show("La fecha de Orden es Obligatoria", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboContrato.Text = "" Then
            MessageBox.Show("Debe Seleccionar el Contrato", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboMedico.Text = "" Then
            MessageBox.Show("Debe seleccionar el medico", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf _DDetalleOrden.ExisteDetalleOrden(_ordenes.Id, "0") = False Then
            '    MessageBox.Show("Falta el detalle de la Orden", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            GuardarOrdenes()
            GPDetalleOrden.Visible = True

            If txtConsecutivo.Text = "" Then
                _ordenes = _dOrdenes.UltimoRegistroPaciente(CStr(_IdUsuario))

                '_DDetalleOrden.ActualizarDetalleOrden(_ordenes.Id, "0")

                ' Mensaje del numero de Orden GEnerada
                Dim _frmMensaje As New SIM___GLOBAL.frmMensaje

                _frmMensaje.NumeroOrden = _ordenes.Id
                _frmMensaje.ShowDialog()
                'txtNumeroEstudio.Text = NumeroEstudio
                txtConsecutivo.Text = _ordenes.Id
                cboContrato.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub bbiUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUsuarios.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmUsuarios
        _frmOpen.ShowDialog()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        _ds = _dUsuarios.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
        'GVConsultar.Columns(0).Visible = False
        'GVConsultar.Columns(1).BestFit()
        'GVConsultar.Columns(2).BestFit()
        'GVConsultar.Columns(3).BestFit()
        '----------------------------------
    End Sub

    Private Sub cboContrato_EditValueChanged(sender As Object, e As EventArgs) Handles cboContrato.EditValueChanged

        'LIMPIAMOS CAMPOS DETALLE ORDEN
        txtCodigoProcedimiento.Text = ""
        txtCopago.Text = ""
        txtNeto.Text = ""
        txtValor.Text = ""
        txtCodigoCups.Text = ""

        'llenamos combo procedimientos
        _ds = New DataSet()
        _ds = _DDetalleTarifa.ListarCombo2(cboContrato.GetColumnValue("ID"))
        cboProcedimiento.Properties.DataSource = _ds.Tables(0)
        cboProcedimiento.Properties.DisplayMember = _ds.Tables(0).Columns(3).Caption
        cboProcedimiento.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption


        'llenamos combo subentidades
        Dim _DSubentidades = New DSudentidades
        _ds = New DataSet()

        _ds = _DSubentidades.ListarComboActivas(cboContrato.GetColumnValue("ID"), "I")
        cboSubentidades.Properties.DataSource = _ds.Tables(0)
        cboSubentidades.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboSubentidades.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboSubentidades.Properties.PopulateColumns()
        cboSubentidades.Properties.Columns("ID").Visible = False
        cboSubentidades.ItemIndex = 0
        bbiGuardar.Enabled = True

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtDatosUsuario.Text = "" Then
            MessageBox.Show("No ha seleccionado el paciente", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCodigoProcedimiento.Text = "" Then
            MessageBox.Show("Debe Seleccionar el Procedimiento a realizar", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (Val(txtValor.EditValue) - Val(txtCopago.EditValue)) < 0 Then
            MessageBox.Show("Verificar el Valor en Neto, No debe ser Negativo", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetalleOrden()
            ActualizarGrillaDetalleOrden(_ordenes.Id)
            LimpiarCamposDetalleOrden()

            'cboProcedimiento.Text = ""

            Dim funciones = New Funciones
            funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
        End If
    End Sub



    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        txtNeto.Text = Val(txtValor.EditValue) - Val(txtCopago.EditValue)
    End Sub

    Private Sub txtCopago_Leave(sender As Object, e As EventArgs) Handles txtCopago.Leave
        txtNeto.Text = Val(txtValor.EditValue) - Val(txtCopago.EditValue)
    End Sub

    Private Sub GVDetalleOrden_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVDetalleOrden.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaDetalleOrden = GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickGrillaDetalleOrden = "" Then
            MessageBox.Show("Debe seleccionar un registro", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleOrden.Eliminar(_ClickGrillaDetalleOrden)
            ActualizarGrillaDetalleOrden(_ordenes.Id)
            _ClickGrillaDetalleOrden = ""
            'LimpiarCamposDetalleOrden()
            Dim funciones = New Funciones
            funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
        End If
    End Sub

    Private Sub txtComentarios_EditValueChanged(sender As Object, e As EventArgs) Handles txtComentarios.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboTipoAfiliado_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoAfiliado.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboTipoUsuario_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoUsuario.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub dtFechaOrden_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaOrden.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtAutorizacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtAutorizacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtNumeroOrden_EditValueChanged(sender As Object, e As EventArgs) Handles txtNumeroOrden.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub frmOrdenes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If txtConsecutivo.Text <> "" And GVDetalleOrden.DataRowCount = 0 Then
            If MessageBox.Show("La Orden no puede quedar sin detalle, Si cierra la ventana se cancelara la Orden. ¿Desea Continuar?", "Registro de Ordenes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                If _Dorden.OrdenPendiente(txtConsecutivo.Text) = True Then
                    _Dorden.CancelarOrden(txtConsecutivo.Text)
                    CancelarDetalleOrden()
                    MessageBox.Show("La Orden # " & txtConsecutivo.Text & " Fue cancelada", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    e.Cancel = False
                    Dim funciones = New Funciones
                    funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
                Else
                    MessageBox.Show("La Orden ya esta en estado ATENDIDO o CANCELADO, debe agregar el detalle", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
            End If
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Orden pendiente por Guardar, Si cierran la ventana se perderan los cambios ¿Desea Continuar?", "Nueva Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                e.Cancel = False
                Dim funciones = New Funciones
                funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub cboMedico_EditValueChanged(sender As Object, e As EventArgs) Handles cboMedico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboProcedimiento_EditValueChanged(sender As Object, e As EventArgs) Handles cboProcedimiento.EditValueChanged
        If cboProcedimiento.Text <> "" And txtDatosUsuario.Text <> "" Then
            _ds = New DataSet
            _ds = _DDetalleTarifa.ListarValor(cboContrato.GetColumnValue("ID"), cboProcedimiento.EditValue)

            'MsgBox(_ds.Tables(0).Rows(0)(0).ToString)
            txtCodigoProcedimiento.Text = _ds.Tables(0).Rows(0)(0).ToString
            _idTipoEstudio = _ds.Tables(0).Rows(0)(1).ToString
            txtValor.Text = _ds.Tables(0).Rows(0)(2).ToString
            txtCodigoCups.Text = _ds.Tables(0).Rows(0)(3).ToString
            _TipoAtencion = _ds.Tables(0).Rows(0)(4).ToString
        End If
    End Sub


End Class
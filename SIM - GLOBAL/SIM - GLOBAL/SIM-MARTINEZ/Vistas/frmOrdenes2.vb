Imports SIM___GLOBAL.My.Modelo
'Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Utilidades
Public Class frmOrdenes2
    Dim _ds As DataSet
    'Dim _doioodd As DOrdenes
    Dim _ClickGrilla As String
    Dim _ClickIdentificacion As String
    Dim _Fila As Integer
    Dim _IdUsuario As Integer
    Dim _dOrdenes = New DOrdenes
    Dim _ordenes As New Ordenes
    Dim _DetalleOrden As New DetalleOrden
    Dim _DDetalleOrden As New DDetalleOrden
    'Dim _usuarios As New Usuarios
    Dim _dUsuarios = New DUsuarios

    Dim _dsUsuarios As DataSet
    Dim _dsTipoAfiliado As DataSet
    Dim _dsTipoUsuario As DataSet
    Dim _dsFinalidadConsulta As DataSet
    Dim _dsContratos As DataSet
    Dim _dsSedes As DataSet
    Dim _Cups As String





    'Dim _dDiagnostico As New DDiagnostico
    'ReadOnly _tipoIdentificacion = New DTipoIdentificacion
    'ReadOnly _tipoConsulta = New DTipoConsulta
#Region "PROCEDIMIENTOS"
    Private Sub LimpiarCampos()
        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
        txtDatosUsuario.Text = ""
        txtComentarios.Text = ""
        txtConsecutivo.Text = ""
        cboTipoAfiliado.ItemIndex = 0
        cboTipoUsuario.ItemIndex = 0
        dtFechaOrden.Text = ""
        txtAutorizacion.Text = ""
        txtNumeroOrden.Text = ""
        cboFinalidad.ItemIndex = 11
        'cboContrato.ItemIndex = -1
        txtCodigoProcedimiento.Text = ""
        'cboProcedimiento.ItemIndex = -1
        txtValor.Text = ""
        txtCopago.Text = ""
        txtNeto.Text = ""


        ' Cargar Contratos
        cboContrato.Properties.ValueMember = Nothing
        cboSubEntidad.Properties.ValueMember = Nothing
        Dim _DContratos = New DContratos
        _ds = _DContratos.ListarCombo
        cboContrato.Properties.DataSource = _ds.Tables(0)
        cboContrato.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboContrato.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboContrato.ItemIndex = -1
        '---------------------------------
        'dtFechaIngreso.Enabled = True
        cboProcedimiento.Properties.ValueMember = Nothing

        'llenamos combo procedimientos
        ' Dim _DDetalleTarifa = New DDetalleTarifas
        ' _ds = New DataSet()

        '        _ds = _DDetalleTarifa.ListarCombo(Val(cboContrato.GetColumnValue("ID")))
        '        cboProcedimiento.Properties.DataSource = _ds.Tables(0)
        '        cboProcedimiento.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        '        cboProcedimiento.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        '        cboProcedimiento.ItemIndex = -1
        '----------------------------------
    End Sub
    Private Sub GuardarOrdenes()
        Try
            _ordenes.Id = Val(txtConsecutivo.Text)
            _ordenes.IdUsuario = _IdUsuario
            _ordenes.IdContrato = cboContrato.GetColumnValue("ID")
            _ordenes.Idsubentidad = cboSubEntidad.GetColumnValue("ID")
            _ordenes.IdIngreso = Val("2")
            _ordenes.IdSede = cboSede.GetColumnValue("ID")
            _ordenes.IdEmpleado = Val("16") 'Id del Especialista - Carlos Martinez
            _ordenes.Autorizacion = txtAutorizacion.Text
            _ordenes.NumeroOrden = txtNumeroOrden.Text
            _ordenes.FechaIngreso = dtFechaIngreso.Text
            _ordenes.FechaOrden = dtFechaOrden.Text
            _ordenes.Hora = DateTime.Now
            _ordenes.Idfactura = "0"
            _ordenes.IdTipoAfiliado = cboTipoAfiliado.GetColumnValue("ID")
            _ordenes.IdTipoUsuario = cboTipoUsuario.GetColumnValue("ID")
            _ordenes.IdTipoEstudio = cboProcedimiento.GetColumnValue("TIPOESTUDIO")
            _ordenes.Comentarios = txtComentarios.Text
            _ordenes.Estado = "PENDIENTE"
            _dOrdenes.guardar(_ordenes)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Ordenes")
        End Try
    End Sub
    Private Sub GuardarDetalleOrden()
        Try
            _DetalleOrden.IdOrden = Val(_ordenes.Id)
            _DetalleOrden.IdCausa = Val("13")
            _DetalleOrden.IdFinalidadConsulta = cboFinalidad.GetColumnValue("ID")
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
            _DetalleOrden.CodigoProcedimiento = txtCodigoProcedimiento.Text
            _DetalleOrden.CodigoCups = _Cups
            _DetalleOrden.IdTipoEstudio = cboProcedimiento.GetColumnValue("TIPOESTUDIO")
            _DetalleOrden.Valor = Val(txtValor.EditValue)
            _DetalleOrden.Copago = Val(txtCopago.EditValue)
            _DetalleOrden.Neto = Val(txtNeto.EditValue)
            _DetalleOrden.Tipo = "C"
            _DetalleOrden.Estado = "PENDIENTE"
            _DDetalleOrden.Guardar(_DetalleOrden)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Detalle de Orden")
        End Try
    End Sub
#End Region


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

    Private Sub frmOrdenes2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bwLoad.RunWorkerAsync()
        ppCargar.Visible = True


    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtDatosUsuario.Text = "" Then
            MessageBox.Show("No ha seleccionado el paciente", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaOrden.Text = "" Then
            MessageBox.Show("La fecha de Orden es Obligatoria", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboSede.Text = "" Then
            MessageBox.Show("Debe Seleccionar la Sede", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboContrato.Text = "" Then
            MessageBox.Show("Debe Seleccionar el Contrato", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCodigoProcedimiento.Text = "" Then
            MessageBox.Show("Debe Seleccionar el Procedimiento a realizar", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (Val(txtValor.EditValue) - Val(txtCopago.EditValue)) < 0 Then
            MessageBox.Show("Verificar el Valor en Neto, No debe ser Negativo", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _dOrdenes.existeordendia(_IdUsuario) = True Then
            MessageBox.Show("El paciente ya se encuentra registrado el dia de hoy", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            GuardarOrdenes()
            _ordenes = _dOrdenes.ultimoregistropaciente(CStr(_IdUsuario))
            ' Mensaje del numero de Orden GEnerada
            Dim _frmMensaje As New SIM___GLOBAL.frmMensaje
            _frmMensaje.NumeroOrden = "OR" & _ordenes.Id
            _frmMensaje.ShowDialog()

            GuardarDetalleOrden()
            Dim funciones = New Funciones
            funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
            If MessageBox.Show("Datos Enviados. Desea ingresar una nueva orden?", "Registro de Ordenes", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                LimpiarCampos()
            Else
                Me.Close()
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

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "TI").ToString()
            _ClickIdentificacion = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "IDENTIFICACION").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick

        Try
            If _ClickGrilla = "" Then
                MessageBox.Show("No se ha Seleccionado Paciente", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                LimpiarCampos()
                _ds = New DataSet()
                _ds = _dUsuarios.DatosUsuarios(_ClickGrilla, _ClickIdentificacion)
                txtDatosUsuario.Text = "ID: " & _ds.Tables(0).Rows(0)(0).ToString & " TI: " & _ds.Tables(0).Rows(0)(1).ToString & " IDENTIFICACION: " & _ds.Tables(0).Rows(0)(2).ToString & vbCrLf _
                         & "PACIENTE: " & _ds.Tables(0).Rows(0)(3).ToString & " " & _ds.Tables(0).Rows(0)(4).ToString & " " & _ds.Tables(0).Rows(0)(5).ToString & " " & _ds.Tables(0).Rows(0)(6).ToString & vbCrLf _
                         & "TELEFONO: " & _ds.Tables(0).Rows(0)(12).ToString
                _IdUsuario = _ds.Tables(0).Rows(0)(0).ToString

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GVConsultar_DoubleClick(sender As Object, e As EventArgs) Handles GVConsultar.DoubleClick, GCConsultar.DoubleClick
        '  Try
        ' _ds = New DataSet()
        '_ds = _dUsuarios.DatosUsuarios(_ClickGrilla, _ClickIdentificacion)
        'txtDatosUsuario.Text = "ID: " & _ds.Tables(0).Rows(0)(0).ToString & " TI: " & _ds.Tables(0).Rows(0)(1).ToString & " IDENTIFICACION: " & _ds.Tables(0).Rows(0)(2).ToString & vbCrLf _
        '        & "PACIENTE: " & _ds.Tables(0).Rows(0)(3).ToString & " " & _ds.Tables(0).Rows(0)(4).ToString & " " & _ds.Tables(0).Rows(0)(5).ToString & " " & _ds.Tables(0).Rows(0)(6).ToString & vbCrLf _
        '        & "TELEFONO: " & _ds.Tables(0).Rows(0)(12).ToString
        'Catch ex As Exception
        'MsgBox("Usuario no registrado")
        '    'MessageBox()
        'End Try
    End Sub

    Private Sub bbiUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUsuarios.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmUsuarios
        _frmOpen.ShowDialog()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        _ds = _dUsuarios.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
        GVConsultar.Columns(0).Visible = False
        GVConsultar.Columns(1).BestFit()
        GVConsultar.Columns(2).BestFit()
        GVConsultar.Columns(3).BestFit()
        '----------------------------------
    End Sub

    Private Sub cboContrato_EditValueChanged(sender As Object, e As EventArgs) Handles cboContrato.EditValueChanged
        'llenamos combo sub entidades
        Dim _DSubEntidades = New DSudentidades
        _ds = New DataSet()

        _ds = _DSubEntidades.ListarCombo(cboContrato.GetColumnValue("ID"), "E")
        cboSubEntidad.Properties.DataSource = _ds.Tables(0)
        cboSubEntidad.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboSubEntidad.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboSubEntidad.ItemIndex = 0

        'cboProcedimiento.Properties.DataSource = ""
        cboProcedimiento.Properties.ValueMember = Nothing
        txtCodigoProcedimiento.Text = ""
        txtCopago.Text = ""
        txtNeto.Text = ""
        txtValor.Text = ""
        'llenamos combo procedimientos
        Dim _DDetalleTarifa = New DDetalleTarifas
        _ds = New DataSet()

        _ds = _DDetalleTarifa.ListarCombo(cboContrato.GetColumnValue("ID"))
        cboProcedimiento.Properties.DataSource = _ds.Tables(0)
        cboProcedimiento.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboProcedimiento.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboProcedimiento.ItemIndex = -1
        'cboProcedimiento.
        'cboProcedimiento.Columns(1).Visible = False
        'cboProcedimiento.Properties.Columns(3).Visible = False
        '----------------------------------
    End Sub

    Private Sub cboProcedimiento_EditValueChanged(sender As Object, e As EventArgs) Handles cboProcedimiento.EditValueChanged
        txtCodigoProcedimiento.Text = cboProcedimiento.GetColumnValue("CODIGO")
        txtValor.Text = cboProcedimiento.GetColumnValue("VALOR")
        _Cups = cboProcedimiento.GetColumnValue("CUPS")
        MsgBox(_Cups)
    End Sub

    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        txtNeto.Text = Val(txtValor.EditValue) - Val(txtCopago.EditValue)
    End Sub

    Private Sub txtCopago_Leave(sender As Object, e As EventArgs) Handles txtCopago.Leave
        txtNeto.Text = Val(txtValor.EditValue) - Val(txtCopago.EditValue)
    End Sub

    Private Sub bwLoad_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoad.DoWork
        'llenamos LISTAR Usuarios
        _dsUsuarios = New DataSet
        _dsUsuarios = _dUsuarios.Listar()
        ' Cargar Tipo Afiliado
        Dim _Dtipoafiliado = New DTipoAfiliado
        _dsTipoAfiliado = _Dtipoafiliado.Listar
        ' Cargar Tipo Usuario
        Dim _DtipoUsuario = New DTipoUsuario
        _dsTipoUsuario = _DtipoUsuario.Listar
        ' Cargar Finalidad Consulta
        Dim _DFinalidadConsulta = New DFinalidadConsulta
        _dsFinalidadConsulta = _DFinalidadConsulta.Listar
        'CArgar Contratos
        Dim _DContratos = New DContratos
        _dsContratos = _DContratos.ListarCombo
        ' Cargar Sedes
        Dim _DSedes = New DSedes
        _dsSedes = _DSedes.ListarCombo

    End Sub

    Private Sub bwLoad_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoad.RunWorkerCompleted
        If e.Cancelled Then
            MessageBox.Show("Laación ha sido cancelada.")
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show("Seroducido un error durante la ejecución: " & e.Error.Message)
        Else
            'llenamos LISTAR Usuarios
            GCConsultar.DataSource = _dsUsuarios.Tables(0)
            ' Tipo Afiliado
            cboTipoAfiliado.Properties.DataSource = _dsTipoAfiliado.Tables(0)
            cboTipoAfiliado.Properties.DisplayMember = _dsTipoAfiliado.Tables(0).Columns(1).Caption
            cboTipoAfiliado.Properties.ValueMember = _dsTipoAfiliado.Tables(0).Columns(0).Caption
            cboTipoAfiliado.ItemIndex = 0
            'tipo usuario
            cboTipoUsuario.Properties.DataSource = _dsTipoUsuario.Tables(0)
            cboTipoUsuario.Properties.DisplayMember = _dsTipoUsuario.Tables(0).Columns(1).Caption
            cboTipoUsuario.Properties.ValueMember = _dsTipoUsuario.Tables(0).Columns(0).Caption
            cboTipoUsuario.ItemIndex = 0
            'finalidad consulta
            cboFinalidad.Properties.DataSource = _dsFinalidadConsulta.Tables(0)
            cboFinalidad.Properties.DisplayMember = _dsFinalidadConsulta.Tables(0).Columns(1).Caption
            cboFinalidad.Properties.ValueMember = _dsFinalidadConsulta.Tables(0).Columns(0).Caption
            cboFinalidad.ItemIndex = 11
            'contratos
            cboContrato.Properties.DataSource = _dsContratos.Tables(0)
            cboContrato.Properties.DisplayMember = _dsContratos.Tables(0).Columns(1).Caption
            cboContrato.Properties.ValueMember = _dsContratos.Tables(0).Columns(0).Caption
            cboContrato.ItemIndex = -1
            'sedes
            cboSede.Properties.DataSource = _dsSedes.Tables(0)
            cboSede.Properties.DisplayMember = _dsSedes.Tables(0).Columns(1).Caption
            cboSede.Properties.ValueMember = _dsSedes.Tables(0).Columns(0).Caption
            cboSede.ItemIndex = -1

            dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")

            'bbiGuardar.Enabled = False
            ppCargar.Visible = False

            'Limpiamos Memoria
            _dsUsuarios = Nothing
            _dsTipoAfiliado = Nothing
            _dsTipoUsuario = Nothing
            _dsFinalidadConsulta = Nothing
            _dsContratos = Nothing
            _dsSedes = Nothing
        End If
    End Sub
End Class
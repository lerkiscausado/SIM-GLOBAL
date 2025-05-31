Imports SIM___GLOBAL.Controles
Public Class frmOrdenes
    Dim _ds As DataSet
    Dim _dUsuarios = New DUsuarios
    Dim _dsDiagnostico As DataSet
    Dim _DOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _Ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    Dim _ClickGrilla As String
    Dim _ClickIdentificacion As String
    Dim _IdUsuario As String
    Dim _Fila As Integer
    Private Sub ActualizarGrilla()
        'Llenamos la grilla de pacientes 
        _ds = New DataSet
        _ds = _dUsuarios.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCampos()

        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
        txtDatosUsuario.Text = ""
        txtComentarios.Text = ""
        txtConsecutivo.Text = ""
        cboTipoAfiliado.ItemIndex = 1
        cboTipoUsuario.ItemIndex = 1
        dtFechaOrden.Text = ""
        txtAutorizacion.Text = ""
        txtNumeroOrden.Text = ""
        'cboFinalidad.ItemIndex = 11
        'cboContrato.ItemIndex = -1
        'txtCodigoProcedimiento.Text = ""
        'cboProcedimiento.ItemIndex = -1
        'txtValor.Text = ""
        'txtCopago.Text = ""
        'txtNeto.Text = ""

        ' Cargar Contratos
        cboContrato.Properties.ValueMember = Nothing
        'cboSubEntidad.Properties.ValueMember = Nothing
        Dim _DContratos = New DContratos
        _ds = _DContratos.ListarCombo
        cboContrato.Properties.DataSource = _ds.Tables(0)
        cboContrato.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboContrato.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboContrato.ItemIndex = -1
        '---------------------------------l
        bbiGuardar.Enabled = False

    End Sub
    Private Sub ActivarGuardar()
        If txtDatosUsuario.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub NuevaOrden()
        Try
            LimpiarCampos()
            _ds = New DataSet()
            _ds = _dUsuarios.DatosUsuarios(_ClickGrilla, _ClickIdentificacion)
            _IdUsuario = _ds.Tables(0).Rows(0)(0).ToString
            If _DOrdenes.ExisteOrdenIntegraSinFacturar(_IdUsuario) = True Then
                If MessageBox.Show("El paciente seleccionado tiene orden(es) abierta(s), Desea crear una nueva orden?", "Nueva Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    txtDatosUsuario.Text = "ID: " & _ds.Tables(0).Rows(0)(0).ToString & " TI: " & _ds.Tables(0).Rows(0)(1).ToString & " IDENTIFICACION: " & _ds.Tables(0).Rows(0)(2).ToString & vbCrLf _
                             & "PACIENTE: " & _ds.Tables(0).Rows(0)(3).ToString & " " & _ds.Tables(0).Rows(0)(4).ToString & " " & _ds.Tables(0).Rows(0)(5).ToString & " " & _ds.Tables(0).Rows(0)(6).ToString & vbCrLf _
                             & "TELEFONO: " & _ds.Tables(0).Rows(0)(12).ToString
                End If
            Else
                'LimpiarCampos()
                txtDatosUsuario.Text = "ID: " & _ds.Tables(0).Rows(0)(0).ToString & " TI: " & _ds.Tables(0).Rows(0)(1).ToString & " IDENTIFICACION: " & _ds.Tables(0).Rows(0)(2).ToString & vbCrLf _
                            & "PACIENTE: " & _ds.Tables(0).Rows(0)(3).ToString & " " & _ds.Tables(0).Rows(0)(4).ToString & " " & _ds.Tables(0).Rows(0)(5).ToString & " " & _ds.Tables(0).Rows(0)(6).ToString & vbCrLf _
                            & "TELEFONO: " & _ds.Tables(0).Rows(0)(12).ToString
            End If
            _ds = New DataSet()
            _ds = _DOrdenes.ListarUltimaOrden(_IdUsuario)
            If _ds.Tables(0).Rows.Count <> 0 Then
                cboDiagnostico.Text = _ds.Tables(0).Rows(0)(0).ToString
                cboContrato.ItemIndex = cboContrato.Properties.GetDataSourceRowIndex("ID", _ds.Tables(0).Rows(0)(1).ToString)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Guardar()

        _Ordenes.Id = Val(txtConsecutivo.Text)
        _Ordenes.IdUsuario = _IdUsuario
        _Ordenes.IdContrato = cboContrato.GetColumnValue("ID")
        _Ordenes.IdSubEntidad = cboSubentidades.GetColumnValue("ID")
        _Ordenes.IdIngreso = Val("2")
        _Ordenes.IdSede = Val("0")
        _Ordenes.IdEmpleado = IdEmpleado
        _Ordenes.Autorizacion = txtAutorizacion.Text
        _Ordenes.NumeroOrden = txtNumeroOrden.Text
        _Ordenes.FechaIngreso = dtFechaIngreso.Text
        If dtFechaOrden.Text <> "" Then
            _Ordenes.FechaOrden = dtFechaOrden.Text
        End If
        _Ordenes.Hora = DateTime.Now
        _Ordenes.Idfactura = "0"
        _Ordenes.IdTipoAfiliado = cboTipoAfiliado.GetColumnValue("ID")
        _Ordenes.IdTipoUsuario = cboTipoUsuario.GetColumnValue("ID")
        _Ordenes.IdTipoEstudio = cboTipoEstudio.GetColumnValue("TIPOESTUDIO")
        _Ordenes.Comentarios = txtComentarios.Text
        _Ordenes.Consecutivo = "0"
        _Ordenes.Estado = "PENDIENTE"
        '_Ordenes.codigodiagnostico = ""
        '_Ordenes.idtipoconsulta = ""
        _DOrdenes.GuardarOrdenIntegra(_Ordenes, cboDiagnostico.EditValue, "0")

        'RECARGAMOS EL FORMULARIO DE CONSULTAS
        Dim funciones = New SIM___GLOBAL.Utilidades.Funciones
        funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
        If MessageBox.Show("Datos Enviados. Desea ingresar una nueva orden?", "Registro de Ordenes", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            LimpiarCampos()
        Else
            Me.Close()
        End If
    End Sub
    Private Sub frmOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
        dtFechaOrden.Text = Format(DateTime.Now, "dd/MM/yyyy")
        'llenamos GridCONTROL Usuarios
        ActualizarGrilla()
        '----------------------------------
        ' Cargar Tipo Afiliado
        Dim _Dtipoafiliado = New DTipoAfiliado
        _ds = _Dtipoafiliado.Listar
        cboTipoAfiliado.Properties.DataSource = _ds.Tables(0)
        cboTipoAfiliado.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoAfiliado.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoAfiliado.Properties.PopulateColumns()
        cboTipoAfiliado.Properties.Columns("ID").Visible = False
        cboTipoAfiliado.ItemIndex = 1
        '---------------------------------
        ' Cargar Tipo Usuario
        Dim _DtipoUsuario = New DTipoUsuario
        _ds = _DtipoUsuario.Listar
        cboTipoUsuario.Properties.DataSource = _ds.Tables(0)
        cboTipoUsuario.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoUsuario.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoUsuario.Properties.PopulateColumns()
        cboTipoUsuario.Properties.Columns("ID").Visible = False
        cboTipoUsuario.ItemIndex = 1
        '---------------------------------

        ' Cargar Contratos
        Dim _DContratos = New DContratos
        _ds = _DContratos.ListarCombo
        cboContrato.Properties.DataSource = _ds.Tables(0)
        cboContrato.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboContrato.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboContrato.Properties.PopulateColumns()
        cboContrato.Properties.Columns("ID").Visible = False
        cboContrato.Properties.Columns("EMPRESA").Visible = False
        cboContrato.ItemIndex = -1

        ' MsgBox("Hola")
        'llenamos COMBO Diagnosticos
        Dim _dDiagnosticos As New DDiagnostico
        _dsDiagnostico = New DataSet()
        _dsDiagnostico = _dDiagnosticos.ListarCombo()
        cboDiagnostico.Properties.DataSource = _dsDiagnostico.Tables(0)
        cboDiagnostico.Properties.DisplayMember = _dsDiagnostico.Tables(0).Columns(1).Caption
        cboDiagnostico.Properties.ValueMember = _dsDiagnostico.Tables(0).Columns(0).Caption

        ' Cargar Tipo Estudio
        Dim _DTipoEstudio = New DTipoEstudio
        _ds = _DTipoEstudio.Listar
        cboTipoEstudio.Properties.DataSource = _ds.Tables(0)
        cboTipoEstudio.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoEstudio.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        'cboTipoEstudio.Properties.PopulateColumns()
        'cboTipoEstudio.Properties.Columns("ID").Visible = False
        'cboTipoEstudio.Properties.Columns("PREFIJO").Visible = False
        cboTipoEstudio.ItemIndex = 1
        cboTipoEstudio.ReadOnly = True



        'If Formulario = "Editar" Then
        ' EditarOrden()
        ' End If

    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "TI").ToString()
            _ClickIdentificacion = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "IDENTIFICACION").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Try
            If _ClickGrilla = "" Then
                MessageBox.Show("No se ha Seleccionado Paciente", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf bbiGuardar.Enabled = True Then
                If MessageBox.Show("Tiene una Orden pendiente por Guardar, Si continua se perderan los cambios ¿Desea Continuar?", "Nueva Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    NuevaOrden()
                End If
            Else
                NuevaOrden()
            End If
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

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

    Private Sub bbiUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUsuarios.ItemClick
        Dim _frmOpen As New SIM___INTEGRA.frmUsuarios
        _frmOpen.ShowDialog()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        _ds = _dUsuarios.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub

    Private Sub txtComentarios_EditValueChanged(sender As Object, e As EventArgs) Handles txtComentarios.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboDiagnostico_EditValueChanged(sender As Object, e As EventArgs) Handles cboDiagnostico.EditValueChanged
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

    Private Sub cboContrato_EditValueChanged(sender As Object, e As EventArgs) Handles cboContrato.EditValueChanged
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
        '---------------------------------
        ActivarGuardar()
    End Sub

    Private Sub cboTipoEstudio_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoEstudio.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboSubentidades_EditValueChanged(sender As Object, e As EventArgs) Handles cboSubentidades.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If dtFechaIngreso.Text = "" Then
            MessageBox.Show("La fecha de ingreso es Obligatoria", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboContrato.Text = "" Then
            MessageBox.Show("Debe seleccionar el contrato", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboDiagnostico.Text = "" Then
            MessageBox.Show("Debe seleccionar el diagnostico", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
        End If

    End Sub

    Private Sub LabelControl13_Click(sender As Object, e As EventArgs) Handles LabelControl13.Click

    End Sub
End Class
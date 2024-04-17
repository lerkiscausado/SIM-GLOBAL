Imports DevExpress.XtraGrid.Views.Grid
Imports SIM___GLOBAL.Utilidades
Public Class frmOrdenes
    'Variables Publicas
    Public Licencia As String
    Public IdEmpleado As String
    Dim IdEstudio As String
    'Declaracion de Variables
    Dim IdTipoEstudio As String
    Dim _Id As New Guid
    Dim _ds As DataSet
    Dim _IdUsuario As String
    Dim _Fila As String
    Dim _ClickIdDetalleOrden As String
    Dim _ClickIdOrden As String
    Dim _ClickIdEstudioAnalista As String
    Dim _IdUsuarioOrden As Integer
    'Declaracion de Objetos
    Dim _dUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    Dim _DDetalleTarifa As New PEC___App.Controles.DDetalleTarifa
    Dim _DetalleOrden As New PEC___App.Modelo.DetalleOrden
    Dim _DDetalleOrden As New PEC___App.Controles.DDetalleOrden
    Dim _Ordenes As New PEC___App.Modelo.Ordenes
    Dim _DOrdenes As New PEC___App.Controles.DOrdenes
    Dim _EstudioAnalista As New PEC___App.Modelo.DetalleOrdenAnalista
    Dim _DEstudioAnalista As New PEC___App.Controles.DDetalleOrdenAnalista
    Dim _DClientesSedes As New PEC___App.Controles.DClienteSedes
    Dim TarifaIva As String

    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DOrdenes.ListarOrdenes2

        GCConsultarOrdenes.DataSource = _ds.Tables(0)
    End Sub
    Private Sub EliminarDetalleOrden()
        If txtConsecutivo.Text = "" And GVDetalleOrden.RowCount <> 0 Then
            _DDetalleOrden.EliminarDetalleOrden(_Id.ToString)
            _DEstudioAnalista.EliminarEstudioAnalista(_Id.ToString)
        End If
    End Sub
    Private Sub LimpiarCampos()

        txtComentarios.Text = Nothing
        cboContrato.Enabled = True
        cboContrato.EditValue = Nothing 'cboContrato.Properties.ValueMember = Nothing
        cboContrato.ReadOnly = False
        dtFechaSolicitud.Text = ""
        cboAnalista.EditValue = Nothing
        txtAutorizacion.Text = Nothing
        txtConsecutivo.Text = Nothing
        GCDetalleOrden.DataSource = Nothing
        gcAnalista.DataSource = Nothing
        bbiGuardar.Enabled = False

    End Sub
    Private Sub ActivarGuardar()
        If TVDatosUsuarios.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub EditarOrden()

        '------------Traemos datos usuarios--------------
        _ds = New DataSet
        _ds = _dUsuarios.DatosUsuarioCARD(_IdUsuarioorden)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

        _Ordenes = _DOrdenes.Cargar(_ClickIdOrden)
        txtConsecutivo.Text = _Ordenes.Id
        cboContrato.ItemIndex = cboContrato.Properties.GetDataSourceRowIndex("ID", _Ordenes.IdContrato)
        txtAutorizacion.Text = _Ordenes.Autorizacion
        dtFechaIngreso.Text = _Ordenes.FechaIngreso
        dtFechaSolicitud.Text = _Ordenes.FechaSolicitud
        txtComentarios.Text = _Ordenes.Comentarios
        cboCiudadSede.ItemIndex = cboCiudadSede.Properties.GetDataSourceRowIndex("ID", _Ordenes.IdClienteSede)

        'LLenamos el detalle orden
        ActualizarGrillaDetalleOrden(_Ordenes.Id)
        cboContrato.ReadOnly = True
        bbiGuardar.Enabled = False
        _IdUsuarioOrden = Nothing
        _IdUsuario = Nothing
    End Sub
    Private Sub ActualizarGrillaDetalleOrden(ByVal IdOrden As String)
        'LLENAR GRID VIEW 
        _ds = New DataSet
        If txtConsecutivo.Text = "" Then
            _ds = _DDetalleOrden.Listar(_Id.ToString)
        Else
            _ds = _DDetalleOrden.Listar(IdOrden)
        End If
        GCDetalleOrden.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActualizarGrillaAnalista(ByVal IdDetalleOrden As String)
        'LLENAR GRID VIEW 
        _ds = New DataSet
        _ds = _DEstudioAnalista.ListarEstudioAnalista(IdDetalleOrden)
        gcAnalista.DataSource = _ds.Tables(0)
    End Sub
    Private Sub GuardarOrdenes()
        Try
            _Ordenes.Id = Val(txtConsecutivo.Text)
            _Ordenes.IdUsuario = _IdUsuario
            _Ordenes.IdContrato = cboContrato.GetColumnValue("ID")
            _Ordenes.IdClienteSede = cboCiudadSede.GetColumnValue("ID")
            _Ordenes.IdEmpleado = cboAnalista.GetColumnValue("ID")
            _Ordenes.Autorizacion = txtAutorizacion.Text
            _Ordenes.FechaIngreso = dtFechaIngreso.Text
            _Ordenes.FechaSolicitud = dtFechaSolicitud.Text
            _Ordenes.Hora = DateTime.Now
            _Ordenes.IdFactura = "P"
            _Ordenes.Comentarios = txtComentarios.Text
            _Ordenes.Estado = "PENDIENTE"
            _DOrdenes.Guardar(_Ordenes)
            bbiGuardar.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Ordenes")
        End Try
    End Sub
    Private Sub GuardarDetalleOrden()
        Try
            If txtConsecutivo.Text = Nothing Then
                _DetalleOrden.IdOrden = _Id.ToString
            Else
                _DetalleOrden.IdOrden = Val(_Ordenes.Id)
            End If
            _DetalleOrden.IdTipoEstudio = IdTipoEstudio
            _DetalleOrden.Hora = DateTime.Now
            _DetalleOrden.Valor = txtValor.EditValue
            _DetalleOrden.IVA = txtIVA.EditValue
            _DetalleOrden.Estado = "PENDIENTE"
            _DDetalleOrden.Guardar(_DetalleOrden)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Detalle de Orden")
        End Try
    End Sub
    Private Sub LimpiarCamposDetalleOrden()
        txtValor.EditValue = Nothing
        txtIVA.EditValue = Nothing
        txtNeto.EditValue = Nothing
        cboEstudios.Text = ""
    End Sub
    Private Sub GuardarAnalista()
        Try
            If txtConsecutivo.Text = Nothing Then
                _EstudioAnalista.IdOrden = _Id.ToString
            Else
                _EstudioAnalista.IdOrden = Val(_Ordenes.Id)
            End If
            _EstudioAnalista.IdDetalleOrden = _ClickIdDetalleOrden
            _EstudioAnalista.IdEmpleado = cboAnalista.GetColumnValue("ID")
            _EstudioAnalista.Valor = txtValorAnalista.EditValue
            _DEstudioAnalista.Guardar(_EstudioAnalista)

        Catch ex As Exception
            MessageBox.Show(ex.Message & "Guardar Analista")
        End Try
    End Sub
    Private Sub NuevaOrden()

        '------------Traemos datos usuarios--------------
        _ds = New DataSet
        _ds = _dUsuarios.DatosUsuarioCARD(_IdUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

        'Identificacion = _ds.Tables(0).Rows(0)(1).ToString
        'MsgBox(Mid(Identificacion, 3, Len(Identificacion) - 2))
        'Sexo = _ds.Tables(0).Rows(0)(5)

        _Id = Guid.NewGuid()

        xtpRegistroOrdenes.PageVisible = True
        xtpRegistroOrdenes.Show()

    End Sub
    Private Sub frmOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar Fecha Actual
        dtFechaIngreso.Text = Format(DateTime.Now, "dd/MM/yyyy")
        ' Cargar Empleados Analistas
        Dim _DEmpleado = New PEC___App.Controles.DEmpleados
        _ds = _DEmpleado.ListarAnalista
        cboAnalista.Properties.DataSource = _ds.Tables(0)
        cboAnalista.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboAnalista.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        ' Cargar Contratos
        Dim _DContratos = New PEC___App.Controles.DContratos
        _ds = _DContratos.ListarCombo
        cboContrato.Properties.DataSource = _ds.Tables(0)
        cboContrato.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboContrato.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        'llenamos GridCONTROL Usuarios
        _ds = New DataSet
        _ds = _dUsuarios.Listar()
        GCConsultar.DataSource = _ds.Tables(0)

        ActualizarGrilla()
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _IdUsuario = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        If _IdUsuario = Nothing Then
            MessageBox.Show("No ha seleccionado el usuario", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("La Orden actual presenta cambios sin guardar, Si presiona ACEPTAR se perderan los cambios. ¿Desea Continuar?", "Nueva Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                EliminarDetalleOrden()
                NuevaOrden()
                LimpiarCampos()
            End If
        Else
            EliminarDetalleOrden()
            NuevaOrden()
            LimpiarCampos()
        End If
    End Sub

    Private Sub frmOrdenes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Orden pendiente por Guardar, Si cierran la ventana se perderan los cambios ¿Desea Continuar?", "Nueva Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                e.Cancel = False

                EliminarDetalleOrden()

                Dim funciones = New Funciones
                funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
            Else
                e.Cancel = True
            End If
        Else
            'If txtConsecutivo.Text <> "" Then
            '_DOrdenes.ActualizarEstado(txtConsecutivo.Text, "PENDIENTE")
            '_DDetalleOrden.ActualizarEstadoOrden(txtConsecutivo.Text, "PENDIENTE")
            'Else
            If txtConsecutivo.Text = "" And GVDetalleOrden.RowCount <> 0 Then
                _DDetalleOrden.EliminarDetalleOrden(_Id.ToString)
            End If
            'End If

            Dim funciones = New Funciones
            funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
        End If
    End Sub
    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If dtFechaSolicitud.Text = "" Then
            MessageBox.Show("La fecha de solicitud es Obligatoria", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboContrato.Text = "" Then
            MessageBox.Show("Debe Seleccionar el Contrato", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboCiudadSede.Text = "" Then
            MessageBox.Show("Debe Seleccionar la ciudad-sede", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVDetalleOrden.RowCount = 0 Then
            MessageBox.Show("Falta los servicios a prestar al usuario", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvAnalista.RowCount = 0 Then
            MessageBox.Show("Debe seleccionar el analista", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If txtConsecutivo.Text = "" Then
                GuardarOrdenes()

                _Ordenes = _DOrdenes.UltimoRegistroUsuario(CStr(_IdUsuario))

                'Actualizamos del Id Temporal al ID definitivo de la Orden
                _DDetalleOrden.ActualizarDetalleOrden(_Ordenes.Id, _Id.ToString)
                _DEstudioAnalista.ActualizarEstudioAnalista(_Ordenes.Id, _Id.ToString)

                ' Mensaje del numero de Orden GEnerada
                Dim _frmMensaje As New SIM___GLOBAL.frmMensaje
                _frmMensaje.NumeroOrden = _Ordenes.Id
                _frmMensaje.ShowDialog()

                txtConsecutivo.Text = _Ordenes.Id

            ElseIf txtConsecutivo.Text <> "" And _DOrdenes.OrdenPendiente(txtConsecutivo.Text) = True Then
                GuardarOrdenes()
            Else
                MessageBox.Show("Esta orden no puede ser actualizada porque esta Cancelada o Atendida", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            LimpiarCampos()
            _IdUsuario = Nothing
            GCDatosUsuarios.DataSource = Nothing
            'NuevaO = 0
            ActualizarGrilla()
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
        If GVConsultarOrdenes.OptionsFind.AlwaysVisible = True Then
            GVConsultarOrdenes.OptionsFind.AlwaysVisible = False
        Else
            GVConsultarOrdenes.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickIdOrden = Nothing Then
            MessageBox.Show("Debe seleccionar una Orden", "Edición de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DOrdenes.OrdenPendiente(_ClickIdOrden) = False Then
            MessageBox.Show("Solo se puede editar la Orden si esta en estado PENDIENTE", "Edición de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf _DBloqueoregistros.ExisteIdOrden(_ClickIdOrden) = True Then
            '    MessageBox.Show("La orden esta ocupada por otro usuario", "Edición de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("La orden: " & _ClickIdOrden & " esta ocupada por el Usuario: " & _ds.Tables(0).Rows(0)(2).ToString(), "Edición de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Orden pendiente por Guardar, Si presiona Aceptar perdera los cambios y Editara la Orden seleccionada", "Nueva Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                EditarOrden()
            End If
        Else
            If MessageBox.Show("¿Desea editar la Orden seleccionada?", "Nueva Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                EditarOrden()
            End If
        End If
    End Sub

    Private Sub btnEliminarAnalista_Click(sender As Object, e As EventArgs) 
        If _ClickIdEstudioAnalista = "" Then
            MessageBox.Show("Debe seleccionar el analista", "Analista", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVanalista.RowCount = 1 And txtConsecutivo.Text <> "" Then
            MessageBox.Show("No se puede eliminar el analista", "Analista", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DEstudioAnalista.Eliminar(_ClickIdEstudioAnalista)
            ActualizarGrillaAnalista(_ClickIdDetalleOrden)
            _ClickIdEstudioAnalista = ""
        End If
    End Sub

    Private Sub gvAnalista_RowClick(sender As Object, e As RowClickEventArgs) 
        If e.RowHandle >= 0 Then
            _ClickIdEstudioAnalista = gvAnalista.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub txtValor_Leave(sender As Object, e As EventArgs) 
        txtIVA.Text = (Val(txtValor.EditValue) * Val(TarifaIva)) / 100
        txtNeto.Text = Val(txtValor.EditValue) + Val(txtIVA.EditValue)

    End Sub

    Private Sub GVConsultarOrdenes_RowClick(sender As Object, e As RowClickEventArgs) Handles GVConsultarOrdenes.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdOrden = GVConsultarOrdenes.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _IdUsuarioOrden = GVConsultarOrdenes.GetRowCellValue(e.RowHandle.ToString, "IDUSUARIO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancelar.ItemClick
        If txtConsecutivo.Text = Nothing Then
            MessageBox.Show("Debe seleccionar una Orden", "Cancelar Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DOrdenes.OrdenPendiente(txtConsecutivo.Text) = False Then
            MessageBox.Show("Esta orden no se puede Cancelar", "Cancelar Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea Cancelar la Orden", "Cancelar Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                _DOrdenes.ActualizarEstado(txtConsecutivo.Text, "CANCELADO")
                _DDetalleOrden.ActualizarEstadoOrden(txtConsecutivo.Text, "CANCELADO")
                LimpiarCampos()
                _IdUsuario = Nothing
                GCDatosUsuarios.DataSource = Nothing
                ActualizarGrilla()
            End If
        End If
    End Sub

    Private Sub cboContrato_EditValueChanged(sender As Object, e As EventArgs) Handles cboContrato.EditValueChanged
        'LIMPIAMOS CAMPOS DETALLE ORDEN
        txtNeto.Text = ""
        txtValor.Text = ""
        txtIVA.Text = ""

        'llenamos combo estudios
        _ds = New DataSet()
        _ds = _DDetalleTarifa.ListarCombo(cboContrato.GetColumnValue("ID"))
        cboEstudios.Properties.DataSource = _ds.Tables(0)
        cboEstudios.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboEstudios.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        'llenamos combo clientes-sedes
        _ds = New DataSet()
        _ds = _DClientesSedes.ListarCombo(cboContrato.GetColumnValue("ID"))
        cboCiudadSede.Properties.DataSource = _ds.Tables(0)
        cboCiudadSede.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboCiudadSede.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        ActivarGuardar()
    End Sub

    Private Sub cboGVProcedimientos_RowClick(sender As Object, e As RowClickEventArgs) Handles cboGVProcedimientos.RowClick
        If e.RowHandle >= 0 Then
            IdEstudio = cboGVProcedimientos.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            txtValor.Text = cboGVProcedimientos.GetRowCellValue(e.RowHandle.ToString, "VALOR").ToString()
            txtIVA.Text = cboGVProcedimientos.GetRowCellValue(e.RowHandle.ToString, "IVA").ToString()
            txtNeto.Text = Val(txtValor.Text) + Val(txtIVA.Text)
            IdTipoEstudio = cboGVProcedimientos.GetRowCellValue(e.RowHandle.ToString, "IDTIPOESTUDIO").ToString()
            TarifaIva = Mid(cboGVProcedimientos.GetRowCellValue(e.RowHandle.ToString, "TARIFA").ToString(), 1, Len(cboGVProcedimientos.GetRowCellValue(e.RowHandle.ToString, "TARIFA").ToString()) - 1)
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If TVDatosUsuarios.RowCount = 0 Then
            MessageBox.Show("Debe seleccionar el usuario y dar click en nueva orden", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf IdEstudio = "" Then
            MessageBox.Show("Debe Seleccionar el estudio a realizar", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboEstudios.Text = "" Then
            MessageBox.Show("Debe Seleccionar el estudio a realizar", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Val(txtNeto.EditValue) < 0 Then
            MessageBox.Show("Verificar el Valor en Neto, No debe ser Negativo", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetalleOrden()
            ActualizarGrillaDetalleOrden(_Ordenes.Id)
            LimpiarCamposDetalleOrden()
            bbiGuardar.Enabled = True

            If GVDetalleOrden.RowCount <> 0 Then
                cboContrato.Enabled = False
            End If
            MessageBox.Show("No olvide asignar el analista al estudio", "Analista", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickIdDetalleOrden = "" Then
            MessageBox.Show("Debe seleccionar un registro", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVDetalleOrden.RowCount = 1 And txtConsecutivo.Text <> "" Then
            MessageBox.Show("La Orden no puede quedar sin detalle. Agregue el servicio correcto y luego elimine el incorrecto", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DEstudioAnalista.ExisteEstudioAnalista(_ClickIdDetalleOrden) = True Then
            MessageBox.Show("Debe eliminar primero el analista", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleOrden.Eliminar(_ClickIdDetalleOrden)
            ActualizarGrillaDetalleOrden(_Ordenes.Id)
            _ClickIdDetalleOrden = ""

            If GVDetalleOrden.RowCount <> 0 Then
                cboContrato.Enabled = False
            Else
                cboContrato.Enabled = True
            End If

        End If
    End Sub

    Private Sub GVDetalleOrden_RowClick(sender As Object, e As RowClickEventArgs) Handles GVDetalleOrden.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdDetalleOrden = GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString

            ActualizarGrillaAnalista(_ClickIdDetalleOrden)
        End If
    End Sub

    Private Sub btnAgregarAnalista_Click(sender As Object, e As EventArgs) Handles btnAgregarAnalista.Click
        If GVDetalleOrden.RowCount = 0 Then
            MessageBox.Show("Debe seleccionar un estudio para asignarle el analista", "Analista", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickIdDetalleOrden = "" Then
            MessageBox.Show("Debe seleccionar un estudio para asignarle el analista", "Analista", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboAnalista.Text = "" Then
            MessageBox.Show("Debe Seleccionar el Analista", "Analista", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Val(txtValorAnalista.EditValue) < 0 Then
            MessageBox.Show("Valor invalido", "Analista", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DEstudioAnalista.ExisteEstudioAnalista2(_ClickIdDetalleOrden, cboAnalista.EditValue) = True Then
            MessageBox.Show("El analista ya fue asignado", "Analista", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarAnalista()
            cboAnalista.Text = ""
            txtValorAnalista.EditValue = Nothing
            ActualizarGrillaAnalista(_ClickIdDetalleOrden)

        End If
    End Sub

    Private Sub gvAnalista_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvAnalista.RowUpdated
        If e.RowHandle >= 0 Then
            _DEstudioAnalista.ActualizarValor(gvAnalista.GetRowCellValue(e.RowHandle.ToString, "ID").ToString(), gvAnalista.GetRowCellValue(e.RowHandle.ToString, "VALOR").ToString())
        End If
    End Sub
End Class
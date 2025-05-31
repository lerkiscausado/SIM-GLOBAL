Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Utilidades
Imports AGORA.Controles
Public Class frmCotizaciones
    Dim _Id As New Guid
    Dim _ds As DataSet
    Dim _Cotizaciones As New AGORA.Modelo.Cotizaciones
    Dim _DCotizaciones As New AGORA.Controles.DCotizaciones
    Dim _DetalleCotizacion As New AGORA.Modelo.DetalleCotizacion
    Dim _DDetalleCotizacion As New AGORA.Controles.DDetalleCotizacion
    Dim _DSalones As New AGORA.Controles.DSalones
    Dim _DServicios As New AGORA.Controles.DServicios
    Dim _DClientes = New DClientes
    Dim _DEventos As New DEventos
    Public Licencia As String
    Public IDEmpleado As String
    ReadOnly _funciones As New Funciones
    '-----------------------------------
    Dim _ClickGrillaCotizacion As String
    Dim _ClickGrilla As String
    Dim _ClickGrillaServicio As String
    Dim _Fila As String
    Dim TipoFactura As String
    Dim Servicio As String
    Dim Impuesto As Boolean = True
    Private Sub ListarComboClientes()
        ' Cargar Clientes
        _ds = New DataSet()
        _ds = _DClientes.listarcombo
        cboCliente.Properties.DataSource = _ds.Tables(0)
        cboCliente.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboCliente.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
    End Sub
    Private Sub ActualizarGrilla()
        ' Listar Cotizaciones
        _ds = New DataSet
        _ds = _DCotizaciones.listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub NuevaCotizacion()
        txtID.Text = Nothing
        cboCliente.Text = ""
        GCDatosCliente.DataSource = Nothing
        'cboSalon.Text = ""
        txtCotizacion.Text = Nothing
        'cboServicios.Properties.DataSource = Nothing
        txtCantidadP.Text = Nothing
        txtValorUnitarioP.Text = Nothing
        txtDescuento.Text = Nothing
        txtSubTotal.Text = Nothing
        GCServicios.DataSource = Nothing
        txtConcepto.Text = Nothing
        txtSon.Text = Nothing
        txtCSubTotal.Text = "$0"
        txtCDescuento.Text = "$0"
        txtIVA.Text = "$0"
        txtTotal.Text = "$0"
        cboSalon.EditValue = Nothing
        dtFechaServicio.Text = Nothing
        dtHoraInicio.EditValue = Nothing
        dtHoraFinal.EditValue = Nothing
        bbiGuardar.Enabled = False
        'actualizacmos grilla cotizaciones
        ActualizarGrilla()

        _Id = Guid.NewGuid()

    End Sub

    Private Sub GuardarCotizacion()
        '_Cotizaciones.Id = Val("")
        _Cotizaciones.IdLicencia = Licencia
        _Cotizaciones.Cotizacion = ""
        _Cotizaciones.FechaCotizacion = dtFechaExpedicion.Text
        _Cotizaciones.FechaVencimiento = dtFechaVencimiento.Text
        _Cotizaciones.Concepto = txtConcepto.Text
        _Cotizaciones.Valor = txtCSubTotal.EditValue
        _Cotizaciones.Descuento = txtCDescuento.EditValue
        _Cotizaciones.Estado = "F"
        _Cotizaciones.IdCliente = cboCliente.EditValue
        _Cotizaciones.TipoFactura = "SERVICIOS"
        _Cotizaciones.IdEvento = cboEventos.GetColumnValue("ID")
        _DCotizaciones.Guardar(_Cotizaciones)

        'Traemos el ultimo consecutivo de la cotizacion guardada
        _Cotizaciones = _DCotizaciones.UltimoRegistroCotizacion()

        'Actualizamos el detalle de cotización
        _DDetalleCotizacion.ActualizarDetalleCotizacion(_Id.ToString, _Cotizaciones.Id)

        txtCotizacion.Text = _Cotizaciones.Id
        '_DFacturas.ActualizarOrdenes(cboContrato.GetColumnValue("ID"))
        '_DFacturas.GuardarDetalleFactura()
    End Sub
    Private Sub ActualizarGrillaDetalleCotizacion()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        If txtID.Text = "" Then
            _ds = _DDetalleCotizacion.Listar(_Id.ToString)
        Else
            _ds = _DDetalleCotizacion.Listar(txtID.Text)
        End If
        GCServicios.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCamposDetalleCotizacion()
        txtDescripcion.Text = Nothing
        txtCantidadP.Text = 1
        txtValorUnitarioP.Text = Nothing
        txtSubTotal.Text = Nothing
        txtDescuento.Text = Nothing
        _ClickGrillaServicio = Nothing
        cboServicios.Text = Nothing
        'cboSalon.EditValue = Nothing
        'dtFechaServicio.Text = Nothing
        'dtHoraInicio.EditValue = Nothing
        'dtHoraFinal.EditValue = Nothing
        '---------------------------------
    End Sub
    Private Sub GuardarDetalleCotizacion()
        If _Id = Nothing Then
            _Id = Guid.NewGuid()
        End If
        If txtID.Text <> "" Then
            _DetalleCotizacion.IdCotizacion = Val(txtID.Text)
        Else
            _DetalleCotizacion.IdCotizacion = _Id.ToString
        End If
        _DetalleCotizacion.Salon = cboSalon.Text
        _DetalleCotizacion.Servicio = cboServicios.Text
        _DetalleCotizacion.Descripcion = txtDescripcion.Text
        _DetalleCotizacion.FechaServicio = dtFechaServicio.Text
        _DetalleCotizacion.HoraInicio = dtHoraInicio.EditValue
        _DetalleCotizacion.HoraFinal = dtHoraFinal.EditValue
        _DetalleCotizacion.Cantidad = Val(txtCantidadP.Text)
        _DetalleCotizacion.Valor = txtValorUnitarioP.EditValue
        _DetalleCotizacion.IVA = 0
        _DetalleCotizacion.Descuento = txtDescuento.EditValue
        _DetalleCotizacion.Estado = "A"
        _DDetalleCotizacion.Guardar(_DetalleCotizacion)
    End Sub
    Private Sub frmCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()


        'Llenamos Campos Fecha de Factura de Productos
        dtFechaExpedicion.Text = Format(DateTime.Now, "dd/MM/yyyy")
        dtFechaVencimiento.Text = Format(DateTime.Now, "dd/MM/yyyy")

        ' Cargar Clientes
        _ds = _DClientes.ListarCombo
        cboCliente.Properties.DataSource = _ds.Tables(0)
        cboCliente.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboCliente.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        'Listar tipo de eventos
        _ds = _DEventos.ListarCombo
        cboEventos.Properties.DataSource = _ds.Tables(0)
        cboEventos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboEventos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        'Listar salones
        _ds = New DataSet()
        _ds = _DSalones.ListarCombo
        cboSalon.Properties.DataSource = _ds.Tables(0)
        cboSalon.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboSalon.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboSalon.ItemIndex = 0
        '---------------------------------

        'Listar Servicios
        _ds = New DataSet()
        _ds = _DServicios.ListarCombo
        cboServicios.Properties.DataSource = _ds.Tables(0)
        cboServicios.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboServicios.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        'cboCliente.ItemIndex = -1

        '---------------------------------
        xtpCotizacionesProductos.Show()
    End Sub
    Private Sub gvComboProductos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)
        txtValorUnitarioP.Text = gvComboServicios.GetRowCellValue(e.RowHandle, "VALOR").ToString
        txtCantidadP.Text = 1
        txtSubTotal.Text = Val(txtCantidadP.Text) * Val(txtValorUnitarioP.EditValue)
    End Sub

    Private Sub txtCantidadP_Leave(sender As Object, e As EventArgs) Handles txtCantidadP.Leave
        txtSubTotal.Text = Val(txtCantidadP.Text) * Val(txtValorUnitarioP.EditValue) - Val(txtDescuento.EditValue)
    End Sub

    Private Sub txtValorUnitarioP_Leave(sender As Object, e As EventArgs) Handles txtValorUnitarioP.Leave
        txtSubTotal.Text = Val(txtCantidadP.Text) * Val(txtValorUnitarioP.EditValue) - Val(txtDescuento.EditValue)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cboCliente.Text = "" Then
            MessageBox.Show("no se ha Seleccionado Cliente", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboSalon.Text = "" Then
            MessageBox.Show("Debe seleccionar el salon", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboServicios.Text = "" Then
            MessageBox.Show("Debe seleccionar el servicio", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtDescripcion.Text = "" Then
            MessageBox.Show("El campo descripcion es obligatorio", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaServicio.Text = "" Then
            MessageBox.Show("El campo fecha de servicio es obligatorio", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtHoraInicio.Text = "" Then
            MessageBox.Show("El campo hora inicio es obligatorio", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtHoraFinal.Text = "" Then
            MessageBox.Show("El campo hora final es obligatorio", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Val(txtCantidadP.Text) <= 0 Then
            MessageBox.Show("la Cantidad minima debe ser (1)", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtValorUnitarioP.EditValue <= 0 Then
            MessageBox.Show("Ingresar Valor Unitario", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetalleCotizacion()
            ActualizarGrillaDetalleCotizacion()
            LimpiarCamposDetalleCotizacion()
            txtCSubTotal.Text = colNETO.SummaryItem.SummaryValue 'colCSubTotal.SummaryItem.SummaryValue
            txtCDescuento.Text = colDESCUENTODC.SummaryItem.SummaryValue
            txtIVA.Text = 0
            txtTotal.Text = colNETO.SummaryItem.SummaryValue - colDESCUENTODC.SummaryItem.SummaryValue
            txtSon.Text = _funciones.Num2Text(txtTotal.Text) & " PESOS M/CTE."
            bbiGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickGrillaServicio = "" Then
            MessageBox.Show("Debe seleccionar un Item", "Registro de Cotizaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvServicios.RowCount = 1 And txtID.Text <> "" Then
            MessageBox.Show("La Cotización no puede quedar sin detalle", "Registro de Cotizaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleCotizacion.EliminarItemDetalleCotizacion(_ClickGrillaServicio)
            ActualizarGrillaDetalleCotizacion()
            LimpiarCamposDetalleCotizacion()
            txtCSubTotal.Text = colSUBTOTALDC.SummaryItem.SummaryValue
            txtCDescuento.Text = colDESCUENTODC.SummaryItem.SummaryValue
            txtIVA.Text = 0
            txtTotal.Text = colSUBTOTALDC.SummaryItem.SummaryValue - colDESCUENTODC.SummaryItem.SummaryValue
            txtSon.Text = _funciones.Num2Text(txtTotal.Text) & " PESOS M/CTE."

            If gvServicios.RowCount <> 0 Then
                bbiGuardar.Enabled = True
            Else
                bbiGuardar.Enabled = False
            End If

        End If
    End Sub
    Private Sub gvProductos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvServicios.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaServicio = gvServicios.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()

            gvServicios.GetRowCellValue(e.RowHandle.ToString, "ID")
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If dtFechaVencimiento.Text = "" Then
            MessageBox.Show("La fecha de vencimiento es obligatoria", "Guardar Cotización", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboEventos.Text = "" Then
            MessageBox.Show("No ha seleccionado el evento", "Guardar Cotización", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarCotizacion()
            Dim _frmMensaje As New SIM___GLOBAL.frmMensaje
            _frmMensaje.NumeroOrden = txtCotizacion.Text
            _frmMensaje.Text = "Cotización Generada"
            _frmMensaje.ShowDialog()
            NuevaCotizacion()
        End If

    End Sub

    Private Sub bbiDetalleFactura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDetalleFactura.ItemClick
        If _ClickGrillaCotizacion <> Nothing Then
            Select Case Licencia
                Case 12, 15 'aquamedical - Optica Freisem
                    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
                    ImprimirFrm.ImprimirCotizacion(_ClickGrillaCotizacion, 1)
                Case Else
                    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
                    ImprimirFrm.ImprimirFacturaDetalle(_ClickGrillaCotizacion)
            End Select
        Else
            MessageBox.Show("Debe Seleccionar una Factura", "Imprimir Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub gvConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaCotizacion = gvConsultar.GetRowCellValue(e.RowHandle.ToString, "COTIZACION").ToString()
        End If
    End Sub

    Private Sub bbiImprimirCotizacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimirCotizacion.ItemClick
        If _ClickGrillaCotizacion <> Nothing Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.ImprimirCotizacionAgora(_ClickGrillaCotizacion, 1)
        Else
            MessageBox.Show("Debe Seleccionar una Cotizacion", "Imprimir Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtDescuento_Leave(sender As Object, e As EventArgs) Handles txtDescuento.Leave
        txtSubTotal.Text = Val(txtCantidadP.Text) * Val(txtValorUnitarioP.EditValue) - Val(txtDescuento.OldEditValue)
    End Sub

    Private Sub cboCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cboCliente.EditValueChanged
        'Mostrar información del cliente
        _ds = New DataSet()
        _ds = _DCotizaciones.CargarCliente(cboCliente.EditValue)
        GCDatosCliente.DataSource = _ds.Tables(0)
    End Sub

    Private Sub bbiClientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClientes.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmClientes
        _frmOpen.Licencia = Licencia
        _frmOpen.IdEmpleado = IDEmpleado
        _frmOpen.ShowDialog()
        ListarComboClientes()
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If gvConsultar.OptionsFind.AlwaysVisible = True Then
            gvConsultar.OptionsFind.AlwaysVisible = False
        Else
            gvConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub
    Private Sub gvComboServicios_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvComboServicios.RowClick
        Servicio = gvComboServicios.GetRowCellValue(e.RowHandle, "SERVICIO").ToString
        txtDescripcion.Text = gvComboServicios.GetRowCellValue(e.RowHandle, "DESCRIPCION").ToString
        txtValorUnitarioP.Text = gvComboServicios.GetRowCellValue(e.RowHandle, "VALOR").ToString
        txtCantidadP.Text = 1
        txtSubTotal.Text = Val(txtCantidadP.Text) * Val(txtValorUnitarioP.EditValue)
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        NuevaCotizacion()
    End Sub

    Private Sub frmCotizaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If gvServicios.RowCount <> 0 Then
            'If MessageBox.Show("Tiene una cotización pendiente por Guardar, Si cierra la ventana se perderan los cambios ¿Desea Continuar?", "Nueva cotización", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
            'e.Cancel = False
            _DDetalleCotizacion.EliminarDetalleCotizacion(_Id.ToString)
            '    Else
            '       e.Cancel = True
        End If
        'Else
        '   e.Cancel = True
        'End If
    End Sub

    Private Sub bbiCorreo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCorreo.ItemClick
        If _ClickGrillaCotizacion <> Nothing Then
            Dim _frmOpen As New frmMail
            _frmOpen.Licencia = Licencia
            _frmOpen.IdFiltro = _ClickGrillaCotizacion
            _frmOpen.Asunto = "Cotizacion"
            _frmOpen.ShowDialog()
        Else
            MessageBox.Show("Debe Seleccionar una Cotizacion", "Enviar Correo Electronico", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


End Class
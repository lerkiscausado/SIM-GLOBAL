Imports SIM___GLOBAL.Controles
Imports AGORA.Controles
Imports SIM___GLOBAL.Utilidades
Public Class frmOrdenServicio
    Public Licencia As String
    Public IDEmpleado As String
    Dim Servicio As String
    Dim Concepto As String
    Dim Evento As String
    Dim _Id As New Guid
    Dim _IdDetallePagoRecibo As New Guid
    Dim _ds As DataSet
    Dim _ClickGrillaServicio As String
    Dim _ClickGrillaOrden As String
    Dim _ClickDetallePago As String
    Dim _Fila As String
    Dim _DClientes = New DClientes
    Dim _DEventos As New DEventos
    Dim _DSalones As New AGORA.Controles.DSalones
    Dim _DServicios As New AGORA.Controles.DServicios
    Dim _DetalleOrdenServicio As New AGORA.Modelo.DetalleOrdenServicio
    Dim _DDetalleOrdenServicio As New AGORA.Controles.DDetalleOrdenServicio
    Dim _DOrdenServicio As New AGORA.Controles.DOrdenServicio
    Dim _OrdenServicio As New AGORA.Modelo.OrdenServicio
    Dim _DCotizaciones As New AGORA.Controles.DCotizaciones
    Dim _CuentasClientes As New SIM___GLOBAL.Modelo.CuentasClientes
    Dim _DCuentasClientes As New SIM___GLOBAL.Controles.DCuentasClientes
    Dim _DMedioPago As New SIM___GLOBAL.Controles.DMediosPago
    Dim _DDetallePagoRecibo As New SIM___GLOBAL.Controles.DDetallePagoRecibo
    Dim _DetallePagoRecibo As New SIM___GLOBAL.Modelo.DetallePagoRecibo
    Dim _Caja As New SIM___GLOBAL.Modelo.Caja
    Dim _DCaja As New SIM___GLOBAL.Controles.DCaja
    Dim _DetalleCuentaCliente As New SIM___GLOBAL.Modelo.DetalleCuentaCliente
    Dim _DDetalleCuentaCliente As New SIM___GLOBAL.Controles.DDetalleCuentaCliente
    ReadOnly _funciones As New Funciones
    Private Sub EditarOrden()

        '_ds = New DataSet
        '_ds = _dUsuarios.DatosUsuarioCARD(_IdUsuarioOrden)
        'GCDatosUsuarios.DataSource = _ds.Tables(0)

        _OrdenServicio = _DOrdenServicio.Cargar(_ClickGrillaOrden)
        txtID.Text = _OrdenServicio.Id
        txtOrden.Text = _OrdenServicio.Id
        Licencia = _OrdenServicio.IdLicencia
        'Orden_Servicio
        dtFechaExpedicion.Text = _OrdenServicio.FechaOrden
        dtFechaVencimiento.Text = _OrdenServicio.FechaVencimiento
        txtConcepto.Text = _OrdenServicio.Concepto
        txtCSubTotal.Text = _OrdenServicio.Valor
        txtCDescuento.Text = _OrdenServicio.Descuento
        cboCliente.EditValue = _OrdenServicio.IdCliente
        'cboEventos.EditValue = _OrdenServicio.IdEvento
        cboEventos.ItemIndex = cboEventos.Properties.GetDataSourceRowIndex("ID", _OrdenServicio.IdEvento)
        cboCliente.Enabled = False
        bbiGuardar.Enabled = False
        xtpRegistroOrdenes.Show()
    End Sub
    Private Sub GuardarRecibo()
        _Caja.Id = Val("")
        _Caja.IdOrden = txtOrden.Text
        _Caja.Fecha = dtFechaExpedicion.Text
        _Caja.Ciudad = "Cartagena"
        _Caja.Nombre = cboCliente.Text
        _Caja.Valor = Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
        _Caja.Concepto = "Por Concepto ABONO a Orden de Servicio Generada No. " & txtOrden.Text
        _Caja.Estado = "R"
        _Caja.IdEmpleado = IDEmpleado
        _Caja.IdCierre = Val("0")
        _Caja.Referencia = "OS" & txtOrden.Text
        _Caja.IdCliente = cboCliente.EditValue
        _DCaja.Guardar(_Caja)
    End Sub
    Private Sub GuardarDetallePagoRecibo()
        If _IdDetallePagoRecibo = Nothing Then
            _IdDetallePagoRecibo = Guid.NewGuid()
        End If
        _DetallePagoRecibo.Id = Val("")
        _DetallePagoRecibo.IdRecibo = _IdDetallePagoRecibo.ToString
        _DetallePagoRecibo.IdMedioPago = cboFormaPago.GetColumnValue("ID")
        _DetallePagoRecibo.Valor = txtFormaPagoValor.EditValue
        _DDetallePagoRecibo.Guardar(_DetallePagoRecibo)
    End Sub
    Private Sub ActualizarGrillaDetallePago()
        'Listar los medios de pago del recibo actual
        _ds = _DDetallePagoRecibo.Listar(_IdDetallePagoRecibo.ToString)
        GCDetallePagoDocumento.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCamposDetallePagoRecibo()
        cboFormaPago.EditValue = Nothing
        txtFormaPagoValor.EditValue = Nothing
    End Sub
    Private Sub GuardarCuentaCliente()
        'Guardamos el movimiento del cliente
        _CuentasClientes.Id = Val("")
        _CuentasClientes.IdLicencia = Licencia
        _CuentasClientes.IdCliente = cboCliente.EditValue
        _CuentasClientes.TipoDocumento = "OS"
        _CuentasClientes.NumeroDocumento = txtOrden.Text
        _CuentasClientes.Fecha = dtFechaExpedicion.Text
        _CuentasClientes.Concepto = "Por Concepto ABONO a Orden de Servicio Generada No. " & txtOrden.Text
        _CuentasClientes.Valor = Val(txtTotal.EditValue)
        '_CuentasClientes.Saldo = Val(txtTotal.EditValue) - Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
        _CuentasClientes.Saldo = Val(txtTotal.EditValue)
        _DCuentasClientes.Guardar(_CuentasClientes)

        '_DetalleCuentaCliente.Id = Val("")
        '_DetalleCuentaCliente.IdCuentaCliente = Val(_DCuentasClientes.UltimoID)
        '_DetalleCuentaCliente.IdRecibo = Val(_DCaja.UltimoReciboCaja)
        '_DetalleCuentaCliente.Valor = Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
        '_DetalleCuentaCliente.Saldo = Val(txtTotal.EditValue) - Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
        '_DetalleCuentaCliente.Estado = "A"
        '_DDetalleCuentaCliente.Guardar(_DetalleCuentaCliente)
    End Sub
    Private Sub GuardarOrdenServicio()

        _OrdenServicio.Id = Val(txtID.Text)
        _OrdenServicio.IdLicencia = Licencia
        _OrdenServicio.OrdenServicio = ""
        _OrdenServicio.FechaOrden = dtFechaExpedicion.Text
        _OrdenServicio.FechaVencimiento = dtFechaVencimiento.Text
        _OrdenServicio.Concepto = txtConcepto.Text
        _OrdenServicio.Valor = txtCSubTotal.EditValue
        _OrdenServicio.Descuento = txtCDescuento.EditValue
        _OrdenServicio.Estado = "F"
        _OrdenServicio.IdCliente = cboCliente.EditValue
        _OrdenServicio.TipoOrden = "SERVICIOS"
        _OrdenServicio.IdEvento = cboEventos.GetColumnValue("ID")
        _DOrdenServicio.Guardar(_OrdenServicio)

    End Sub
    Private Sub ListarComboClientes()
        ' Cargar Clientes
        _ds = New DataSet()
        _ds = _DClientes.listarcombo
        cboCliente.Properties.DataSource = _ds.Tables(0)
        cboCliente.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboCliente.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
    End Sub
    Private Sub ActivarGuardar()
        If gvServicios.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub NuevaOrden()
        txtID.Text = Nothing
        txtOrden.Text = Nothing
        cboCliente.Text = ""
        cboCliente.Enabled = True
        cboCotizaciones.Text = ""
        GCDatosCliente.DataSource = Nothing
        'cboSalon.Text = ""
        'txtCotizacion.Text = Nothing
        'cboServicios.Properties.DataSource = Nothing
        txtCantidadP.Text = Nothing
        txtValorUnitarioP.Text = Nothing
        txtDescuento.Text = Nothing
        txtSubTotal.Text = Nothing
        GCServicios.DataSource = Nothing
        GCDetallePagoDocumento.DataSource = Nothing
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
        _Id = Nothing
        'actualizacmos grilla orden servicio
        ActualizarGrilla()

    End Sub
    Private Sub ActualizarGrilla()
        ' Listar Ordenes de Servicios
        _ds = New DataSet
        _ds = _DOrdenServicio.Listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCamposDetalleOrden()
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
    Private Sub ActualizarGrillaDetalleOrdenServicio()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        If txtID.Text = "" Then
            _ds = _DDetalleOrdenServicio.Listar(_Id.ToString)
        Else
            _ds = _DDetalleOrdenServicio.Listar(txtID.Text)
        End If
        GCServicios.DataSource = _ds.Tables(0)
    End Sub
    Private Sub GuardarDetalleOrden()
        If _Id = Nothing Then
            _Id = Guid.NewGuid()
        End If
        If txtID.Text <> "" Then
            _DetalleOrdenServicio.IdOrdenServicio = Val(txtID.Text)
        Else
            _DetalleOrdenServicio.IdOrdenServicio = _Id.ToString
        End If
        _DetalleOrdenServicio.Salon = cboSalon.Text
        _DetalleOrdenServicio.Servicio = cboServicios.Text
        _DetalleOrdenServicio.Descripcion = txtDescripcion.Text
        _DetalleOrdenServicio.FechaServicio = dtFechaServicio.Text
        _DetalleOrdenServicio.HoraInicio = dtHoraInicio.EditValue
        _DetalleOrdenServicio.HoraFinal = dtHoraFinal.EditValue
        _DetalleOrdenServicio.Cantidad = Val(txtCantidadP.Text)
        _DetalleOrdenServicio.Valor = txtValorUnitarioP.EditValue
        _DetalleOrdenServicio.IVA = 0
        _DetalleOrdenServicio.Descuento = txtDescuento.EditValue
        _DetalleOrdenServicio.Estado = "A"
        _DDetalleOrdenServicio.Guardar(_DetalleOrdenServicio)
    End Sub
    Private Sub frmOrdenServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        ' Cargar Medios de Pago
        _ds = New DataSet()
        _ds = _DMedioPago.ListarCombo
        cboFormaPago.Properties.DataSource = _ds.Tables(0)
        cboFormaPago.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboFormaPago.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        xtpRegistroOrdenes.Show()
        txtID.Text = ""

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cboCliente.Text = "" Then
            MessageBox.Show("no se ha Seleccionado Cliente", "Registro de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboSalon.Text = "" Then
            MessageBox.Show("Debe seleccionar el salon", "Registro de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboServicios.Text = "" Then
            MessageBox.Show("Debe seleccionar el servicio", "Registro de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtDescripcion.Text = "" Then
            MessageBox.Show("El campo descripcion es obligatorio", "Registro de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaServicio.Text = "" Then
            MessageBox.Show("El campo fecha de servicio es obligatorio", "Registro de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtHoraInicio.Text = "" Then
            MessageBox.Show("El campo hora inicio es obligatorio", "Registro de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtHoraFinal.Text = "" Then
            MessageBox.Show("El campo hora final es obligatorio", "Registro de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Val(txtCantidadP.Text) <= 0 Then
            MessageBox.Show("la Cantidad minima debe ser (1)", "Registro de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtValorUnitarioP.EditValue <= 0 Then
            MessageBox.Show("Ingresar Valor Unitario", "Registro de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetalleOrden()
            ActualizarGrillaDetalleOrdenServicio()
            LimpiarCamposDetalleOrden()
            txtCSubTotal.Text = colNETODOS.SummaryItem.SummaryValue 'colCSubTotal.SummaryItem.SummaryValue
            'txtCSubTotal.Text = colSUBTOTALDC.SummaryItem.SummaryValue 'colCSubTotal.SummaryItem.SummaryValue
            txtCDescuento.Text = colDESCUENTODC.SummaryItem.SummaryValue
            txtIVA.Text = 0
            txtTotal.Text = colNETODOS.SummaryItem.SummaryValue - colDESCUENTODC.SummaryItem.SummaryValue
            txtSon.Text = _funciones.Num2Text(txtTotal.Text) & " PESOS M/CTE."
            bbiGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickGrillaServicio = "" Then
            MessageBox.Show("Debe seleccionar un Item", "Registro de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvServicios.RowCount = 1 And txtID.Text <> "" Then
            MessageBox.Show("La Orden no puede quedar sin detalle", "Registro de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleOrdenServicio.EliminarItemDetalleOrden(_ClickGrillaServicio)
            ActualizarGrillaDetalleOrdenServicio()
            LimpiarCamposDetalleOrden()
            txtCSubTotal.Text = colNETODOS.SummaryItem.SummaryValue 'colCSubTotal.SummaryItem.SummaryValue
            txtCDescuento.Text = colDESCUENTODC.SummaryItem.SummaryValue
            txtIVA.Text = 0
            txtTotal.Text = colNETODOS.SummaryItem.SummaryValue - colDESCUENTODC.SummaryItem.SummaryValue
            txtSon.Text = _funciones.Num2Text(txtTotal.Text) & " PESOS M/CTE."

            If gvServicios.RowCount <> 0 Then
                bbiGuardar.Enabled = True
            Else
                bbiGuardar.Enabled = False
            End If

        End If
    End Sub

    Private Sub frmOrdenServicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If gvServicios.RowCount <> 0 Then
            'If MessageBox.Show("Tiene una cotización pendiente por Guardar, Si cierra la ventana se perderan los cambios ¿Desea Continuar?", "Nueva cotización", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
            'e.Cancel = False
            _DDetalleOrdenServicio.EliminarDetalleOrden(_Id.ToString)
            '    Else
            '       e.Cancel = True
        End If
        'Else
        '   e.Cancel = True
        'End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        NuevaOrden()
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
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

    Private Sub cboCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cboCliente.EditValueChanged
        'Mostrar información del cliente
        _ds = New DataSet()
        _ds = _DOrdenServicio.CargarCliente(cboCliente.EditValue)
        GCDatosCliente.DataSource = _ds.Tables(0)

        ' Cargar Cotizaciones
        _ds = _DCotizaciones.ListarCombo(cboCliente.EditValue)
        cboCotizaciones.Properties.DataSource = _ds.Tables(0)
        cboCotizaciones.Properties.DisplayMember = _ds.Tables(0).Columns(0).Caption
        cboCotizaciones.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If dtFechaVencimiento.Text = "" Then
            MessageBox.Show("La fecha de vencimiento es obligatoria", "Guardar Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboEventos.Text = "" Then
            MessageBox.Show("No ha seleccionado el evento", "Guardar Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtConcepto.Text = "" Then
            MessageBox.Show("No ha ingresado el concepto", "Guardar Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarOrdenServicio()

            If txtID.Text = "" Then
                'Traemos el ultimo consecutivo de la orden de servicio guardada
                _OrdenServicio = _DOrdenServicio.UltimoRegistroOrdenServicio

                'Actualizamos el detalle de Orden de servicio
                _DDetalleOrdenServicio.ActualizarDetalleOrdenServicio(_Id.ToString, _OrdenServicio.Id)

                txtOrden.Text = _OrdenServicio.Id
            End If

            Dim _frmMensaje As New SIM___GLOBAL.frmMensaje
            _frmMensaje.NumeroOrden = txtOrden.Text
            _frmMensaje.Text = "Orden de Servicio Generada"

            GuardarCuentaCliente()

            _frmMensaje.ShowDialog()

            Dim _frmOpen As New AGORA.frmCaja
            If MessageBox.Show("¿Desea generar un recibo de caja?", "Recibo de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                '_frmOpen.cboCliente.EditValue = cboCliente.EditValue
                _frmOpen.IdCliente = cboCliente.EditValue
                _frmOpen.IdOrden = txtOrden.Text
                '_frmOpen.Empleado = Empleado
                _frmOpen.IdEmpleado = IDEmpleado
                _frmOpen.Licencia = Licencia
                _frmOpen.ShowDialog()
            Else
                _frmOpen.IdCliente = Nothing
            End If
            NuevaOrden()
        End If
    End Sub

    Private Sub btnSeleccionarCotizacion_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCotizacion.Click
        If cboCotizaciones.Text = "" Then
            MessageBox.Show("No ha seleccionado la cotización", "Seleccionar Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If gvServicios.RowCount <> 0 Then
                MessageBox.Show("Existen ya servicios agregados a la cotización", "Vista Previa Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtConcepto.Text = Concepto
                cboEventos.ItemIndex = cboEventos.Properties.GetDataSourceRowIndex("ID", Evento)

                If _Id = Nothing Then
                    _Id = Guid.NewGuid()
                End If
                _DDetalleOrdenServicio.GuardarDetalleOrdenServicio(_Id.ToString, cboCotizaciones.EditValue)
                ActualizarGrillaDetalleOrdenServicio()
                txtCSubTotal.Text = colNETODOS.SummaryItem.SummaryValue 'colCSubTotal.SummaryItem.SummaryValue
                txtCDescuento.Text = colDESCUENTODC.SummaryItem.SummaryValue
                txtIVA.Text = 0
                txtTotal.Text = colNETODOS.SummaryItem.SummaryValue - colDESCUENTODC.SummaryItem.SummaryValue
                txtSon.Text = _funciones.Num2Text(txtTotal.Text) & " PESOS M/CTE."
                bbiGuardar.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnVistaCotizacion_Click(sender As Object, e As EventArgs) Handles btnVistaCotizacion.Click
        If cboCotizaciones.Text <> Nothing Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.ImprimirCotizacionAgora(cboCotizaciones.EditValue, 1)
        Else
            MessageBox.Show("Debe Seleccionar una Cotizacion", "Vista Previa Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiImprimirCotizacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimirCotizacion.ItemClick
        If _ClickGrillaOrden <> Nothing Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            ImprimirFrm.ImprimirOrdenServicioAgora(_ClickGrillaOrden, 1)
        Else
            MessageBox.Show("Debe Seleccionar una Orden de Servicio", "Imprimir Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub gvConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaOrden = gvConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
        End If
    End Sub
    Private Sub btnAgregarDetallePago_Click(sender As Object, e As EventArgs) Handles btnAgregarDetallePago.Click
        If cboFormaPago.Text = "" Then
            MessageBox.Show("Debe seleccionar el medio de pago", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtFormaPagoValor.EditValue <= 0 Then
            MessageBox.Show("Valor ingresado es incorrecto", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf colVALORDETALLEPAGO.SummaryItem.SummaryValue > val(txtTotal.Text) Then
            MessageBox.Show("El valor del recibo no puede ser mayor al total de la orden de servicio", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DDetallePagoRecibo.Existe(_IdDetallePagoRecibo.ToString, cboFormaPago.GetColumnValue("ID")) Then
            MessageBox.Show("El medio de pago ya fue agregado", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetallePagoRecibo()
            ActualizarGrillaDetallePago()
            LimpiarCamposDetallePagoRecibo()
        End If
    End Sub

    Private Sub txtCantidadP_Properties_Leave(sender As Object, e As EventArgs) Handles txtCantidadP.Properties.Leave
        txtSubTotal.Text = Val(txtCantidadP.Text) * Val(txtValorUnitarioP.EditValue) - Val(txtDescuento.EditValue)
    End Sub

    Private Sub txtValorUnitarioP_Properties_Leave(sender As Object, e As EventArgs) Handles txtValorUnitarioP.Properties.Leave
        txtSubTotal.Text = Val(txtCantidadP.Text) * Val(txtValorUnitarioP.EditValue) - Val(txtDescuento.EditValue)
    End Sub

    Private Sub txtDescuento_Properties_Leave(sender As Object, e As EventArgs) Handles txtDescuento.Properties.Leave
        txtSubTotal.Text = Val(txtCantidadP.Text) * Val(txtValorUnitarioP.EditValue) - Val(txtDescuento.EditValue)
    End Sub

    Private Sub gvServicios_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvServicios.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaServicio = gvServicios.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
        End If
    End Sub

    Private Sub btnEliminarDetallePago_Click(sender As Object, e As EventArgs) Handles btnEliminarDetallePago.Click
        If _ClickDetallePago = "" Then
            MessageBox.Show("Debe seleccionar el medio de pago a eliminar", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetallePagoRecibo.Eliminar(_ClickDetallePago)
            ActualizarGrillaDetallePago()
            _ClickDetallePago = Nothing
            'If gvDetallePagoDocumento.RowCount <> 0 Then
            'bbiGuardar.Enabled = True
            'Else
            ' bbiGuardar.Enabled = False
            'End If
        End If
    End Sub

    Private Sub gvCotizaciones_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvCotizaciones.RowClick
        If e.RowHandle >= 0 Then
            Concepto = gvCotizaciones.GetRowCellValue(e.RowHandle.ToString, "CONCEPTO").ToString()
            Evento = gvCotizaciones.GetRowCellValue(e.RowHandle.ToString, "EVENTO").ToString()
        End If
    End Sub
    Private Sub gvDetallePagoDocumento_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvDetallePagoDocumento.RowClick
        If e.RowHandle >= 0 Then
            _ClickDetallePago = gvDetallePagoDocumento.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiEnviarCorreo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEnviarCorreo.ItemClick
        If _ClickGrillaOrden <> Nothing Then
            Dim _frmOpen As New frmMail
            _frmOpen.Licencia = Licencia
            _frmOpen.IdFiltro = _ClickGrillaOrden
            _frmOpen.Asunto = "Orden de Servicio"
            _frmOpen.ShowDialog()
        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Enviar Correo Electronico", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickGrillaOrden = Nothing Then
            MessageBox.Show("Debe seleccionar una Orden", "Editar Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("¿Desea editar la Orden seleccionada?", "Editar Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                EditarOrden()
                ActualizarGrillaDetalleOrdenServicio()
                LimpiarCamposDetalleOrden()
                txtCSubTotal.Text = colNETODOS.SummaryItem.SummaryValue 'colCSubTotal.SummaryItem.SummaryValue
                'txtCSubTotal.Text = colSUBTOTALDC.SummaryItem.SummaryValue 'colCSubTotal.SummaryItem.SummaryValue
                txtCDescuento.Text = colDESCUENTODC.SummaryItem.SummaryValue
                txtIVA.Text = 0
                txtTotal.Text = colNETODOS.SummaryItem.SummaryValue - colDESCUENTODC.SummaryItem.SummaryValue
                txtSon.Text = _funciones.Num2Text(txtTotal.Text) & " PESOS M/CTE."
            End If

        End If
    End Sub

    Private Sub cboEventos_EditValueChanged(sender As Object, e As EventArgs) Handles cboEventos.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtConcepto_EditValueChanged(sender As Object, e As EventArgs) Handles txtConcepto.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub dtFechaVencimiento_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaVencimiento.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub dtFechaExpedicion_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaExpedicion.EditValueChanged
        ActivarGuardar()
    End Sub
End Class
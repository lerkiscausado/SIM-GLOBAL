Imports DevExpress.XtraGrid.Views.Grid
Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Utilidades
Public Class frmOrdenServicio
    Dim _Id As New Guid
    Dim _IdDetallePagoRecibo As New Guid
    Dim _ds As DataSet
    Dim _OrdenServicio As New OrdenServicio
    Dim _DOrdenServicio As New DOrdenServicio
    Dim _DetalleOrdenServicio As New DetalleOrdenServicio
    Dim _DDetalleordenservicio As New DDetalleOrdenServicio
    Dim _CuentasClientes As New CuentasClientes
    Dim _DCuentasClientes As New DCuentasClientes
    Dim _DetalleCuentaCliente As New DetalleCuentaCliente
    Dim _DDetalleCuentaCliente As New DDetalleCuentaCliente
    Dim _DClientes = New DClientes
    Dim _DTarifas = New DTarifaProductos
    Dim _DDetalleTarifaProductos = New DDetalleTarifaProductos
    Dim _DMedioPago As New SIM___GLOBAL.Controles.DMediosPago
    Dim _DDetallePagoRecibo As New SIM___GLOBAL.Controles.DDetallePagoRecibo
    Dim _DetallePagoRecibo As New SIM___GLOBAL.Modelo.DetallePagoRecibo
    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
    Dim _Caja As New SIM___GLOBAL.Modelo.Caja
    Dim _DCaja As New SIM___GLOBAL.Controles.DCaja
    Public Licencia As String
    Public IDEmpleado As String
    ReadOnly _funciones As New Funciones
    '-----------------------------------
    Dim _ClickGrillaOrdenServicio As String
    Dim _ClickGrilla As String
    Dim _ClickGrillaProductos As String
    Dim _ClickDetallePago As String
    Dim _Fila As String
    Dim TipoFactura As String

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
    Private Sub GuardarRecibo()
        _Caja.Id = Val("")
        _Caja.IdOrden = txtCotizacion.Text
        _Caja.Fecha = dtFechaExpedicion.Text
        _Caja.Ciudad = "Cartagena"
        _Caja.Nombre = cboCliente.Text
        '_Caja.Identificacion = txtIdentificacion.Text
        '_Caja.Direccion = txtDireccion.Text
        '_Caja.Telefono = txtTelefono.Text
        _Caja.Valor = Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
        _Caja.Concepto = "Por Concepto ABONO a Orden de Servicio Generada No. " & txtCotizacion.Text
        _Caja.Estado = "R"
        _Caja.IdEmpleado = IDEmpleado
        _Caja.IdCierre = Val("0")
        _Caja.Referencia = "OS" & txtCotizacion.Text
        _Caja.IdCliente = cboCliente.EditValue
        _DCaja.Guardar(_Caja)
    End Sub
    Private Sub ActualizarGrillaDetallePago()
        'Listar los medios de pago del recibo actual
        _ds = _DDetallePagoRecibo.Listar(_IdDetallePagoRecibo.ToString)
        GCDetallePagoDocumento.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActualizarGrilla()
        ' Listar Ordenes de Servicios
        _ds = New DataSet
        _ds = _DOrdenServicio.Listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActivaGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub NuevaOrdenServicio()
        txtID.Text = Nothing
        cboCliente.Text = ""
        GCDatosCliente.DataSource = Nothing
        cboTarifaProducto.Text = ""
        txtCotizacion.Text = Nothing
        cboProducto.Properties.DataSource = Nothing
        txtCantidadP.Text = Nothing
        txtValorUnitarioP.Text = Nothing
        txtDescuento.Text = Nothing
        txtSubTotal.Text = Nothing
        GCProductos.DataSource = Nothing
        GCDetallePagoDocumento.DataSource = Nothing
        txtConcepto.Text = Nothing
        txtSon.Text = Nothing
        txtCSubTotal.Text = Nothing
        txtCDescuento.Text = Nothing
        txtIVA.Text = Nothing
        txtTotal.Text = Nothing
        bbiGuardar.Enabled = False
        'actualizacmos grilla Ordenes de Servicios
        ActualizarGrilla()
    End Sub
    Private Sub GuardarOrdenServicio()
        _OrdenServicio.Id = Val("")
        _OrdenServicio.IdLicencia = Licencia
        _OrdenServicio.OrdenServicio = ""
        _OrdenServicio.FechaOrden = dtFechaExpedicion.Text
        _OrdenServicio.FechaVencimiento = dtFechaVencimiento.Text
        _OrdenServicio.Concepto = txtConcepto.Text
        _OrdenServicio.Valor = Val(txtCSubTotal.EditValue)
        _OrdenServicio.Descuento = Val(txtCDescuento.EditValue)
        _OrdenServicio.Estado = "P"
        _OrdenServicio.IdCliente = cboCliente.EditValue
        _OrdenServicio.TipoOrden = "PRODUCTOS"
        '_Cotizaciones.IdEmpleado = IDEmpleado
        _DOrdenServicio.Guardar(_OrdenServicio)

        'Traemos el ultimo consecutivo de la orden de servicio guardada
        _OrdenServicio = _DOrdenServicio.UltimoRegistroOrdenProductos()

        'Actualizamos el detalle de orden productos
        _DDetalleordenservicio.ActualizarDetalleOrdenServicio(_Id.ToString, _OrdenServicio.Id)

        txtCotizacion.Text = _OrdenServicio.Id

    End Sub
    Private Sub ActualizarGrillaDetalleOrdenServicio()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        If txtID.Text = "" Then
            _ds = _DDetalleordenservicio.Listar(_Id.ToString)
        Else
            _ds = _DDetalleordenservicio.Listar(txtID.Text)
        End If
        GCProductos.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCamposDetalleOrdenServicio()
        txtCantidadP.Text = 1
        txtValorUnitarioP.Text = Nothing
        txtDescuento.Text = Nothing
        txtSubTotal.Text = Nothing
        _ClickGrillaProductos = Nothing
        cboProducto.Text = Nothing
    End Sub
    Private Sub LimpiarCamposDetallePagoRecibo()
        cboFormaPago.EditValue = Nothing
        txtFormaPagoValor.EditValue = Nothing
    End Sub
    Private Sub GuardarDetalleOrdenServicio()
        If _Id = Nothing Then
            _Id = Guid.NewGuid()
        End If
        If txtID.Text <> "" Then
            _DetalleOrdenServicio.IdOrdenServicio = Val(txtID.Text)
        Else
            'MsgBox(_Id.ToString)
            _DetalleOrdenServicio.IdOrdenServicio = _Id.ToString
        End If
        _DetalleOrdenServicio.IdProducto = cboProducto.EditValue
        _DetalleOrdenServicio.Cantidad = Val(txtCantidadP.Text)
        _DetalleOrdenServicio.Valor = Val(txtValorUnitarioP.EditValue)
        _DetalleOrdenServicio.Descuento = Val(txtDescuento.EditValue)
        _DetalleOrdenServicio.Iva = 0
        _DetalleOrdenServicio.Estado = "A"
        _DDetalleordenservicio.Guardar(_DetalleOrdenServicio)
    End Sub
    Private Sub ListarComboClientes()
        ' Cargar Clientes
        _ds = _DClientes.ListarCombo
        cboCliente.Properties.DataSource = _ds.Tables(0)
        cboCliente.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboCliente.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        '---------------------------------
    End Sub
    Private Sub frmOrdenServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        Select Case Licencia

            Case 12, 13, 15 'AQUAMEDICAL, FERRETERIA LA PUNTA Y OPTICA FREISEM

                'Llenamos Campos Fecha de Factura de Productos
                dtFechaExpedicion.Text = Format(DateTime.Now, "dd/MM/yyyy")
                dtFechaVencimiento.Text = Format(DateTime.Now, "dd/MM/yyyy")

                ' Cargar Tarifas
                '_ds = New DataSet()
                _ds = _DTarifas.ListarCombo
                cboTarifaProducto.Properties.DataSource = _ds.Tables(0)
                cboTarifaProducto.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
                cboTarifaProducto.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
                cboTarifaProducto.ItemIndex = 0
                '---------------------------------
            Case Else
                'xtpFacturaProductos.PageVisible = False
        End Select

        'Llenamos Campos FECHA
        dtFechaExpedicion.Text = Format(DateTime.Now, "dd/MM/yyyy")
        dtFechaVencimiento.Text = Format(DateTime.Now, "dd/MM/yyyy")

        ListarComboClientes()

        ' Cargar Tarifas
        _ds = _DTarifas.ListarCombo
        cboTarifaProducto.Properties.DataSource = _ds.Tables(0)
        cboTarifaProducto.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTarifaProducto.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTarifaProducto.ItemIndex = 0
        '---------------------------------

        ' Cargar Medios de Pago
        _ds = New DataSet()
        _ds = _DMedioPago.ListarCombo
        cboFormaPago.Properties.DataSource = _ds.Tables(0)
        cboFormaPago.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboFormaPago.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        'cboFormaPago.ItemIndex = 0

        xtpOrdenesProductos.Show()
    End Sub

    Private Sub cboTarifaProducto_EditValueChanged(sender As Object, e As EventArgs) Handles cboTarifaProducto.EditValueChanged
        ' Cargar Tarifas
        _ds = _DDetalleTarifaProductos.ListarCombo(cboTarifaProducto.EditValue)
        cboProducto.Properties.DataSource = _ds.Tables(0)
        cboProducto.Properties.DisplayMember = _ds.Tables(0).Columns(3).Caption
        cboProducto.Properties.ValueMember = _ds.Tables(0).Columns(1).Caption
        '---------------------------------
    End Sub

    Private Sub gvComboProductos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvComboProductos.RowClick
        txtValorUnitarioP.Text = gvComboProductos.GetRowCellValue(e.RowHandle, "VALOR").ToString
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
            MessageBox.Show("no se ha Seleccionado Cliente", "Registro de Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboTarifaProducto.Text = "" Then
            MessageBox.Show("Debe Seleccionar una Tarifa", "Registro de Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboProducto.Text = "" Then
            MessageBox.Show("Seleccionar Producto", "Registro de Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Val(txtCantidadP.Text) <= 0 Then
            MessageBox.Show("la Cantidad minima debe ser (1)", "Registro de Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtValorUnitarioP.EditValue) <= 0 Then
            MessageBox.Show("Ingresar Valor Unitario", "Registro de Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DDetalleordenservicio.ExisteProducto(_Id.ToString, cboProducto.EditValue) = True Then
            MessageBox.Show("El producto ya fue agregado", "Registro de Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetalleOrdenServicio()
            ActualizarGrillaDetalleOrdenServicio()
            LimpiarCamposDetalleOrdenServicio()
            txtCSubTotal.Text = colValorUnitario.SummaryItem.SummaryValue 'colCSubTotal.SummaryItem.SummaryValue
            txtCDescuento.Text = colCDescuento.SummaryItem.SummaryValue
            txtIVA.Text = 0
            txtTotal.Text = colCSubTotal.SummaryItem.SummaryValue
            txtSon.Text = _funciones.Num2Text(txtTotal.Text) & " PESOS M/CTE."
            bbiGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickGrillaProductos = "" Then
            MessageBox.Show("Debe seleccionar un Item", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvProductos.RowCount = 1 And txtID.Text <> "" Then
            MessageBox.Show("La tarifa no puede quedar sin detalle", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleordenservicio.EliminarItemDetalleOrdenServicio(_ClickGrillaProductos)
            ActualizarGrillaDetalleOrdenServicio()
            LimpiarCamposDetalleOrdenServicio()
            txtCSubTotal.Text = colCSubTotal.SummaryItem.SummaryValue
            txtCDescuento.Text = colCDescuento.SummaryItem.SummaryValue
            txtIVA.Text = 0
            txtTotal.Text = colCSubTotal.SummaryItem.SummaryValue
            txtSon.Text = _funciones.Num2Text(txtTotal.Text) & " PESOS M/CTE."

            If gvProductos.RowCount <> 0 Then
                bbiGuardar.Enabled = True
            Else
                bbiGuardar.Enabled = False
            End If
        End If
    End Sub

    Private Sub cboCliente_EditValueChanged(sender As Object, e As EventArgs)
        'Mostrar información del cliente
        _ds = New DataSet()
        _ds = _DOrdenServicio.CargarCliente(cboCliente.EditValue)
        GCDatosCliente.DataSource = _ds.Tables(0)
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        'Dim SaldoCantidad As Integer = 0
        'Dim SaldoTotal As Integer = 0
        'Dim ValorPromedio As Integer = 0

        If dtFechaExpedicion.Text = "" Then
            MessageBox.Show("La fecha de expedicion es obligatoria", "Guardar Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaVencimiento.Text = "" Then
            MessageBox.Show("La fecha de vencimiento es obligatoria", "Guardar Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvDetallePagoDocumento.RowCount = 0 Then
            MessageBox.Show("No ha registrado el abono para generar el recibo de caja", "Guardar Orden de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarOrdenServicio()

            'Guardamos el recibo de caja
            GuardarRecibo()
            _DDetallePagoRecibo.ActualizarDetallePago(_IdDetallePagoRecibo.ToString)

            'Guardamos el movimiento del cliente
            _CuentasClientes.Id = Val("")
            _CuentasClientes.IdLicencia = Licencia
            _CuentasClientes.IdCliente = cboCliente.EditValue
            _CuentasClientes.TipoDocumento = "OS"
            _CuentasClientes.NumeroDocumento = txtCotizacion.Text
            _CuentasClientes.Fecha = dtFechaExpedicion.Text
            _CuentasClientes.Concepto = "Por Concepto ABONO a Orden de Servicio Generada No. " & txtCotizacion.Text
            _CuentasClientes.Valor = Val(txtTotal.EditValue)
            _CuentasClientes.Saldo = Val(txtTotal.EditValue) - Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
            _DCuentasClientes.Guardar(_CuentasClientes)

            _DetalleCuentaCliente.Id = Val("")
            _DetalleCuentaCliente.IdCuentaCliente = Val(_DCuentasClientes.UltimoID)
            _DetalleCuentaCliente.IdRecibo = Val(_DCaja.UltimoReciboCaja)
            _DetalleCuentaCliente.Valor = Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
            _DetalleCuentaCliente.Saldo = Val(txtTotal.EditValue) - Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
            _DetalleCuentaCliente.Estado = "A"
            _DDetalleCuentaCliente.Guardar(_DetalleCuentaCliente)


            Dim _frmMensaje As New frmMensaje
            _frmMensaje.NumeroOrden = txtCotizacion.Text
            _frmMensaje.Text = "Orden Generada"
            _frmMensaje.ShowDialog()

            If MessageBox.Show("Desea imprimir la Orden de Servicios?", "Imprimir Orden de Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                ImprimirFrm.ImprimirOrdenServicio(Val(txtCotizacion.Text), 1)
            End If

            If MessageBox.Show("Desea imprimir el recibo de caja?", "Imprimir Recibo de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                ImprimirFrm.ImprimirReciboCaja(Val(_DCaja.UltimoReciboCaja), Licencia, 1)
            End If

            NuevaOrdenServicio()
        End If
    End Sub

    Private Sub gvConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaOrdenServicio = gvConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If gvConsultar.OptionsFind.AlwaysVisible = True Then
            gvConsultar.OptionsFind.AlwaysVisible = False
            'GVDetalleFactura.OptionsFind.AlwaysVisible = False
        Else
            gvConsultar.OptionsFind.AlwaysVisible = True
            'GVDetalleFactura.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        ActualizarGrilla()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmClientes
        _frmOpen.Licencia = Licencia
        _frmOpen.IdEmpleado = IDEmpleado
        _frmOpen.ShowDialog()
        ListarComboClientes()
    End Sub

    Private Sub frmOrdenServicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Orden pendiente por Guardar, Si cierra la ventana se perderan los cambios ¿Desea Continuar?", "Registro de Ordenes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                e.Cancel = False
                If _Id <> Nothing And gvProductos.RowCount <> 0 Then
                    _DDetalleordenservicio.EliminarDetalleOrdenServicio(_Id.ToString)
                End If
            Else
                e.Cancel = True
            End If
        End If
        If gvDetallePagoDocumento.RowCount <> 0 Then
            _DDetallePagoRecibo.EliminarDetalleRecibo(_IdDetallePagoRecibo.ToString)
        End If
    End Sub

    Private Sub gvProductos_RowClick_1(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvProductos.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaProductos = gvProductos.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
        End If
    End Sub

    Private Sub txtDescuento_Leave(sender As Object, e As EventArgs) Handles txtDescuento.Leave
        txtSubTotal.Text = Val(txtCantidadP.Text) * Val(txtValorUnitarioP.EditValue) - Val(txtDescuento.OldEditValue)
    End Sub

    Private Sub cboCliente_EditValueChanged_1(sender As Object, e As EventArgs) Handles cboCliente.EditValueChanged
        'Mostrar información del cliente
        _ds = New DataSet()
        _ds = _DOrdenServicio.CargarCliente(cboCliente.EditValue)
        GCDatosCliente.DataSource = _ds.Tables(0)
    End Sub

    Private Sub bbiImprimirCotizacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimirCotizacion.ItemClick
        If _ClickGrillaOrdenServicio <> Nothing Then
            Select Case Licencia
                Case 12, 15 'aquamedical - Optica Freisem
                    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
                    ImprimirFrm.ImprimirOrdenServicio(_ClickGrillaOrdenServicio, 1)
            End Select
        Else
            MessageBox.Show("Debe Seleccionar una Orden de Servicio", "Imprimir Orden Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If cboFormaPago.Text = "" Then
            MessageBox.Show("Debe seleccionar el medio de pago", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtFormaPagoValor.EditValue <= 0 Then
            MessageBox.Show("Valor ingresado es incorrecto", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DDetallePagoRecibo.Existe(_IdDetallePagoRecibo.ToString, cboFormaPago.GetColumnValue("ID")) Then
            MessageBox.Show("El medio de pago ya fue agregado", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetallePagoRecibo()
            ActualizarGrillaDetallePago()
            LimpiarCamposDetallePagoRecibo()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
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

    Private Sub gvDetallePagoDocumento_RowClick(sender As Object, e As RowClickEventArgs) Handles gvDetallePagoDocumento.RowClick
        If e.RowHandle >= 0 Then
            _ClickDetallePago = gvDetallePagoDocumento.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAnular.ItemClick
        If _ClickGrillaOrdenServicio <> Nothing Then
            Select Case Licencia
                Case 15 'Optica Freisem
                    If _DOrdenServicio.ExisteOrdenPendiente(_ClickGrillaOrdenServicio) = True Then
                        'Dim IdCuentaCliente As String
                        'IdCuentaCliente = _DCuentasClientes.IdCuentaClienteOS(_ClickGrillaOrdenServicio)
                        If _DCaja.ReciboCerradoOrdenes("OS" & _ClickGrillaOrdenServicio) = True Then
                            MessageBox.Show("La Orden de Servicio no puede ser Anulada. Existen Recibos de Caja cerrados", "Anular Orden Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            If MessageBox.Show("Si anula la orden de servicio, se anularan tambien los recibos de caja. Desea continuar?", "Anular Orden de Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                Dim IdCuentaCliente As String
                                _DOrdenServicio.AnularOrdenServicio(_ClickGrillaOrdenServicio)
                                _DCaja.AnularReciboOrdenServicio("OS" & _ClickGrillaOrdenServicio)
                                _DCuentasClientes.AnularOrdenServicio(_ClickGrillaOrdenServicio)
                                IdCuentaCliente = _DCuentasClientes.IdCuentaCliente(_ClickGrillaOrdenServicio, "OS")
                                _DDetalleCuentaCliente.AnularDetalleCuentaCliente2(IdCuentaCliente)
                            End If
                        End If
                    Else
                        MessageBox.Show("La Orden de Servicio no puede ser Anulada", "Anular Orden Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
        Else
            MessageBox.Show("Debe Seleccionar una Orden de Servicio", "Anular Orden Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.Utilidades
Public Class frmCotizaciones
    Dim _Id As New Guid
    Dim _ds As DataSet
    Dim _Cotizaciones As New Cotizaciones
    Dim _DCotizaciones As New DCotizaciones
    Dim _DetalleCotizacion As New DetalleCotizacion
    Dim _DDetalleCotizacion As New DDetalleCotizacion
    Dim _DClientes = New DClientes
    Dim _DTarifas = New DTarifaProductos
    Dim _DDetalleTarifaProductos = New DDetalleTarifaProductos
    Public Licencia As String
    Public IDEmpleado As String
    ReadOnly _funciones As New Funciones
    '-----------------------------------
    Dim _ClickGrillaCotizacion As String
    Dim _ClickGrilla As String
    Dim _ClickGrillaProductos As String
    Dim _Fila As String
    Dim TipoFactura As String
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
        cboTarifaProducto.Text = ""
        txtCotizacion.Text = Nothing
        cboProducto.Properties.DataSource = Nothing
        txtCantidadP.Text = Nothing
        txtValorUnitarioP.Text = Nothing
        txtDescuento.Text = Nothing
        txtSubTotal.Text = Nothing
        GCProductos.DataSource = Nothing
        txtConcepto.Text = Nothing
        txtSon.Text = Nothing
        txtCSubTotal.Text = Nothing
        txtCDescuento.Text = Nothing
        txtIVA.Text = Nothing
        txtTotal.Text = Nothing
        bbiGuardar.Enabled = False
        'actualizacmos grilla cotizaciones
        ActualizarGrilla()

    End Sub

    Private Sub GuardarCotizacion()
        _Cotizaciones.Id = Val("")
        _Cotizaciones.IdLicencia = Licencia
        _Cotizaciones.Cotizacion = ""
        _Cotizaciones.FechaCotizacion = dtFechaExpedicion.Text
        _Cotizaciones.FechaVencimiento = dtFechaVencimiento.Text
        _Cotizaciones.Concepto = txtConcepto.Text
        _Cotizaciones.Valor = Val(txtCSubTotal.EditValue)
        _Cotizaciones.Descuento = Val(txtCDescuento.EditValue)
        _Cotizaciones.Estado = "F"
        _Cotizaciones.IdCliente = cboCliente.EditValue
        _Cotizaciones.TipoFactura = "PRODUCTOS"
        '_Cotizaciones.IdEmpleado = IDEmpleado
        _DCotizaciones.Guardar(_Cotizaciones)

        'Traemos el ultimo consecutivo de la cotizacion guardada
        _Cotizaciones = _DCotizaciones.UltimoRegistroCotizacionProductos()

        'Actualizamos el detalle de factura productos
        _DDetalleCotizacion.ActualizarDetalleCotizacion(_Id.ToString, _Cotizaciones.Id)

        'Registrar venta en el Inventario
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
        GCProductos.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCamposDetalleCotizacion()
        txtCantidadP.Text = 1
        txtValorUnitarioP.Text = Nothing
        txtSubTotal.Text = Nothing
        txtDescuento.Text = Nothing
        _ClickGrillaProductos = Nothing
        cboProducto.Text = Nothing

        '---------------------------------
    End Sub
    Private Sub Guardar()
        Try
            _Cotizaciones.Id = Val(txtID.Text)
            _Cotizaciones.IdLicencia = Licencia
            '_Cotizaciones.Nombre = txtNombre.Text
            'If chkEstado.Checked = True Then
            ' _TarifaProductos.Estado = "A"
            ' Else
            ' _TarifaProductos.Estado = "I"
            ' End If
            '_DTarifaProductos.Guardar(_TarifaProductos)
            'bbiGuardar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GuardarDetalleCotizacion()
        If _Id = Nothing Then
            _Id = Guid.NewGuid()
        End If
        If txtID.Text <> "" Then
            _DetalleCotizacion.IdCotizacion = Val(txtID.Text)
        Else
            'MsgBox(_Id.ToString)
            _DetalleCotizacion.IdCotizacion = _Id.ToString
        End If
        _DetalleCotizacion.IdProducto = cboProducto.EditValue
        _DetalleCotizacion.Cantidad = Val(txtCantidadP.Text)
        _DetalleCotizacion.Valor = Val(txtValorUnitarioP.EditValue)
        _DetalleCotizacion.Descuento = Val(txtDescuento.EditValue)
        _DetalleCotizacion.Iva = 0
        _DetalleCotizacion.Estado = "A"
        _DDetalleCotizacion.Guardar(_DetalleCotizacion)

    End Sub
    Private Sub frmCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        Select Case Licencia

            Case 12, 13, 15 'AQUAMEDICAL, FERRETERIA LA PUNTA Y OPTICA FREISEM



                'Botones Rips - Ocultar
                '  bbiRips.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                '  bbiAgregarFacturaRips.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                '  bbiAgregarFacturasRips.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                '  bbiEliminarFacturaRips.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                '  bbiEliminarFacturasRips.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                'Llenamos Campos Fecha de Factura de Productos
                dtFechaExpedicion.Text = Format(DateTime.Now, "dd/MM/yyyy")
                dtFechaVencimiento.Text = Format(DateTime.Now, "dd/MM/yyyy")

                'ListarComboClientes()

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

        ' Cargar Clientes
        _ds = _DClientes.ListarCombo
        cboCliente.Properties.DataSource = _ds.Tables(0)
        cboCliente.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboCliente.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        'cboCliente.ItemIndex = -1
        '---------------------------------

        ' Cargar Tarifas
        _ds = _DTarifas.ListarCombo
        cboTarifaProducto.Properties.DataSource = _ds.Tables(0)
        cboTarifaProducto.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTarifaProducto.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTarifaProducto.ItemIndex = 0
        '---------------------------------
        xtpCotizacionesProductos.Show()
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
            MessageBox.Show("no se ha Seleccionado Cliente", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cbotarifaproducto.Text = "" Then
            MessageBox.Show("Debe Seleccionar una Tarifa", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboproducto.Text = "" Then
            MessageBox.Show("Seleccionar Producto", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf val(txtCantidadP.Text) <= 0 Then
            MessageBox.Show("la Cantidad minima debe ser (1)", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtValorUnitarioP.EditValue <= 0 Then
            MessageBox.Show("Ingresar Valor Unitario", "Registro de Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetallecotizacion()
            ActualizarGrillaDetalleCotizacion()
            LimpiarCamposDetalleCotizacion()
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
            MessageBox.Show("Debe seleccionar un Item", "Registro de Cotizaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVproductos.RowCount = 1 And txtID.Text <> "" Then
            MessageBox.Show("La cotización no puede quedar sin detalle", "Registro de cotizaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleCotizacion.EliminarItemDetalleCotizacion(_ClickGrillaProductos)
            ActualizarGrillaDetalleCotizacion()
            LimpiarCamposDetalleCotizacion()
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



    Private Sub gvProductos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvProductos.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaProductos = gvProductos.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        'Dim SaldoCantidad As Integer = 0
        'Dim SaldoTotal As Integer = 0
        'Dim ValorPromedio As Integer = 0

        If dtFechaExpedicion.Text = "" Then
            MessageBox.Show("La fecha de expedicion es obligatoria", "Guardar Cotización", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaVencimiento.Text = "" Then
            MessageBox.Show("La fecha de vencimiento es obligatoria", "Guardar Cotización", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarCotizacion()
            Dim _frmMensaje As New frmMensaje
            _frmMensaje.NumeroOrden = txtCotizacion.Text
            _frmMensaje.Text = "Factura Generada"
            _frmMensaje.ShowDialog()
            NuevaCotizacion()
        End If
        'ElseIf TipoFactura = "Facturar Productos" Then
        'facturar Productos
        'If dtFechaExpedicion.Text = "" Then
        'MessageBox.Show("La fecha de expedicion es obligatoria", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'ElseIf dtFechaVencimiento.Text = "" Then
        'MessageBox.Show("La fecha de vencimiento es obligatoria", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'ElseIf txtFacturaP.Text = "" Then
        'MessageBox.Show("El campo Numero de Factura es obligatorio", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'ElseIf _DFacturas.ExisteFactura(Licencia, txtFacturaP.Text) = True Then
        'MessageBox.Show("El Numero de Factura ya fue Utilizado", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'ElseIf txtConceptoP.Text = "" Then
        'MessageBox.Show("El campo concepto es obligatorio", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        'GuardarProductos()

        'Se realiza barrido en el GVProductos para registrar los salidas de los productos
        'Dim i As Integer = 0
        'Do While i < gvProductos.RowCount
        'BUscamos el saldo actual del producto en el inventario
        '_ds = _DInventario.SaldoActualInventario(gvProductos.GetRowCellValue(i, "IDPRODUCTO").ToString)

        'If _ds.Tables(0).Rows.Count <> 0 Then
        'SaldoCantidad = Val(_ds.Tables(0).Rows(0)(1).ToString) - Val(gvProductos.GetRowCellValue(i, "CANTIDAD").ToString)
        'SaldoTotal = Val(_ds.Tables(0).Rows(0)(2).ToString) - (Val(gvProductos.GetRowCellValue(i, "CANTIDAD").ToString) * Val(gvProductos.GetRowCellValue(i, "COSTOVENTA").ToString))
        ''Else
        '   SaldoCantidad = Val("0") + Val(gvProductos.GetRowCellValue(i, "CANTIDAD").ToString)
        '  SaldoTotal = Val("0") + (Val(gvProductos.GetRowCellValue(i, "CANTIDAD").ToString) * Val(gvProductos.GetRowCellValue(i, "COSTOVENTA").ToString))
        'ValorPromedio = Val(SaldoTotal / SaldoCantidad)
        ' End If

        'GuardarVentaInventario(gvProductos.GetRowCellValue(i, "IDPRODUCTO").ToString, gvProductos.GetRowCellValue(i, "CANTIDAD").ToString, gvProductos.GetRowCellValue(i, "COSTOVENTA").ToString, SaldoCantidad, SaldoTotal, ValorPromedio)

        'i = i + 1
        'Loop

        'Dim _frmMensaje As New frmMensaje
        '_frmMensaje.NumeroOrden = txtFacturaP.Text
        '_frmMensaje.Text = "Factura Generada"
        '_frmMensaje.ShowDialog()

        'NuevaFactura()
        'End If
        'Else
        'MessageBox.Show("Debe Seleccionar el tipo de Facturacion", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
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
            Select Case Licencia
                Case 12, 15 'aquamedical - Optica Freisem
                    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
                    ImprimirFrm.ImprimirCotizacion(_ClickGrillaCotizacion, 1)
                Case Else
                    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
                    ImprimirFrm.ImprimirFacturaDetalle(_ClickGrillaCotizacion)
            End Select
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
    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        NuevaCotizacion()
    End Sub
End Class
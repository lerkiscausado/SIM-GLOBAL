Public Class frmCompras
    Public Licencia As String
    Public IdEmpleado As String
    Dim _ds As DataSet
    Dim _DOrdenCompra As New SIM___GLOBAL.Controles.DOrdenCompra
    Dim _DDetalleOrdenCompra As New SIM___GLOBAL.Controles.DDetalleOrdenCompra
    Dim _Compras As New SIM___GLOBAL.Modelo.Compras
    Dim _DCompras As New SIM___GLOBAL.Controles.DCompras
    Dim _DetalleCompra As New SIM___GLOBAL.Modelo.DetalleCompra
    Dim _DDetalleCompra As New SIM___GLOBAL.Controles.DDetalleCompra
    Dim _Inventario As New SIM___GLOBAL.Modelo.Inventario
    Dim _DInventario As New SIM___GLOBAL.Controles.DInventario
    'Dim _DProductos As New SIM___GLOBAL.Controles.DProductos
    Dim _DPresentacionProductos As New SIM___GLOBAL.Controles.DPresentacionProductos

    Dim _Id As New Guid
    Dim _ClickCompra As String
    Dim _ClickProductoDetalleCompra As String
    Dim _ClickCantidad As String
    Dim _ClickProducto As String
    Dim _Fila As String
    Dim IdOrdenCompra As String

    Private Sub ComboProductosOrdenCompra()
        'llenamos combo Productos Ordenes de Compra
        _ds = New DataSet()
        _ds = _DDetalleOrdenCompra.ListarComboProductosOC(cboOrdenCompra.EditValue)
        cboProducto.Properties.DataSource = _ds.Tables(0)
        cboProducto.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboProducto.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
    End Sub

    Private Sub Editar()
        _Compras = _DCompras.Cargar(_ClickCompra)
        txtId.Text = _Compras.Id
        dtFecha.Text = _Compras.Fecha
        cboOrdenCompra.EditValue = _Compras.IdOrdenCompra
        txtConcepto.Text = _Compras.Concepto
        txtFactura.Text = _Compras.Factura
        'Bloqueamos
        bbiGuardar.Enabled = False
        cboOrdenCompra.Enabled = False
        GrillaDetalleCompra()
    End Sub
    Private Sub ActualizarGrilla()
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _DCompras.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub GrillaDetalleCompra()
        'LLENAR GRILLA
        _ds = New DataSet
        If txtId.Text = "" Then
            _ds = _DDetalleCompra.Listar(_Id.ToString)
        Else
            _ds = _DDetalleCompra.Listar(txtId.Text)
        End If
        GCProductos.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCampos()
        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        txtId.Text = Nothing
        cboOrdenCompra.EditValue = Nothing
        txtConcepto.Text = Nothing
        txtFactura.Text = Nothing
        GCProductos.DataSource = Nothing
        bbiGuardar.Enabled = False
        cboOrdenCompra.Enabled = True
        btnAgregarDetalleOrdenCompra.Enabled = True
        _Id = Nothing
    End Sub
    Private Sub LimpiarCamposDetalleCompra()
        cboProducto.EditValue = Nothing
        txtCantidad.Text = ""
        txtValorUnitario.Text = ""
        txtSubTotal.Text = Nothing
    End Sub
    Private Sub ActivarGuardar()
        If gvProductos.RowCount <> 0 Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub GuardarCompraInventario(ByVal IdProducto As String, ByVal IdMarca As String, ByVal IdPresentacionProducto As String, ByVal Cantidad As Double, ByVal ValorUnitario As Double, ByVal SaldoCantidad As Double, ByVal SaldoTotal As Double, ByVal ValorPromedio As Double)
        _Inventario.Fecha = DateTime.Now
        _Inventario.Hora = DateTime.Now
        _Inventario.IdDocumento = Val("1")
        _Inventario.IdProducto = Val(IdProducto)
        _Inventario.IdMarca = Val(IdMarca)
        _Inventario.IdPresentacionProducto = Val(IdPresentacionProducto)
        _Inventario.Movimiento = "E"
        _Inventario.Factura = txtFactura.Text
        _Inventario.Observacion = "."
        _Inventario.EntradaCantidad = Cantidad
        _Inventario.EntradaValor = ValorUnitario
        _Inventario.SalidaCantidad = 0
        _Inventario.SalidaValor = 0
        _Inventario.SaldoCantidad = SaldoCantidad
        _Inventario.SaldoTotal = SaldoTotal
        _Inventario.ValorPromedio = ValorPromedio
        _Inventario.IdEmpleado = IdEmpleado
        _Inventario.Estado = "A"
        '_idDetalleOrden = _dHistoria.GuardarHistoriayDetalle(_DetalleOrden, _Historia)
        _DInventario.Guardar(_Inventario)
        'MsgBox(_idDetalleOrden)
    End Sub
    Private Sub Guardar()
        _Compras.Id = Val(txtId.Text)
        _Compras.Fecha = dtFecha.Text
        _Compras.Hora = DateTime.Now
        _Compras.IdOrdenCompra = cboOrdenCompra.EditValue
        _Compras.Concepto = txtConcepto.Text
        _Compras.Factura = txtFactura.Text
        _Compras.Estado = "A"
        '_Compras.FechaConfirmacion=""
        _Compras.IdEmpleado = IdEmpleado
        _DCompras.Guardar(_Compras)
    End Sub
    Private Sub AgregarDetalleCompra()
        _DetalleCompra.Id = Val("")
        If _Id = Nothing Then
            _Id = Guid.NewGuid()
        End If
        If txtId.Text <> "" Then
            _DetalleCompra.IdCompra = Val(txtId.Text)
        Else
            _DetalleCompra.IdCompra = _Id.ToString
        End If
        _DetalleCompra.IdProducto = cboProducto.EditValue
        _DetalleCompra.Cantidad = txtCantidad.Text
        _DetalleCompra.ValorUnitario = txtValorUnitario.Text
        _DetalleCompra.Estado = "A"
        _DDetalleCompra.Guardar(_DetalleCompra)
    End Sub

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")

        'llenamos combo Ordenes de Compra
        _ds = New DataSet()
        _ds = _DOrdenCompra.ListarCombo()
        cboOrdenCompra.Properties.DataSource = _ds.Tables(0)
        cboOrdenCompra.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboOrdenCompra.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        ActualizarGrilla()
        bbiGuardar.Enabled = False
    End Sub

    Private Sub cboOrdenCompra_EditValueChanged(sender As Object, e As EventArgs) Handles cboOrdenCompra.EditValueChanged
        IdOrdenCompra = cboOrdenCompra.EditValue
        'llenar campos de Proveedor
        _ds = _DCompras.CargarProveedor(cboOrdenCompra.EditValue)
        GCDatosProveedor.DataSource = _ds.Tables(0)

        'llenamos combo Productos Ordenes de Compra
        _ds = New DataSet()
        _ds = _DDetalleOrdenCompra.ListarComboProductosOC(cboOrdenCompra.EditValue)
        cboProducto.Properties.DataSource = _ds.Tables(0)
        cboProducto.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboProducto.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        ActivarGuardar()
    End Sub

    Private Sub dtFecha_EditValueChanged(sender As Object, e As EventArgs) Handles dtFecha.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtConcepto_EditValueChanged(sender As Object, e As EventArgs) Handles txtConcepto.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        Dim CantidadEntrada As Double = 0
        Dim ValorUnitario As Double = 0
        Dim SaldoCantidad As Double = 0
        Dim SaldoTotal As Double = 0
        Dim ValorPromedio As Double = 0
        If dtFecha.Text = "" Then
            MessageBox.Show("El Campo Fecha es obligatorio", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboOrdenCompra.Text = "" Then
            MessageBox.Show("Debe seleccionar la Orden de Compra", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtFactura.Text = "" Then
            MessageBox.Show("El campo Factura es obligatorio", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvProductos.RowCount = 0 Then
            MessageBox.Show("La Compra no tiene detalle", "Registro de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            If txtId.Text = "" Then
                txtId.Text = _DCompras.UltimoConsecutivo()
                'txtCodigoCompra.Text = _DOrdenCompra.Codigo()
                _DDetalleCompra.ActualizarDetalleCompra(txtId.Text, _Id.ToString)

                'MsgBox("La Orden de Compra No. " & txtCodigoCompra.Text & " fue registrada exitosamente")

                Dim i As Integer = 0
                Dim CantidadProducto As Double
                Do While i < gvProductos.RowCount
                    CantidadProducto = CDec(_DPresentacionProductos.CantidadProducto(gvProductos.GetRowCellValue(i, "IDPRESENTACIONPRODUCTO").ToString))

                    'BUscamos el saldo actual del producto en el inventario
                    _ds = _DInventario.SaldoActualInventario2(gvProductos.GetRowCellValue(i, "IDPRESENTACIONPRODUCTO").ToString)
                    CantidadEntrada = CDec(gvProductos.GetRowCellValue(i, "CANTIDAD").ToString) * CDec(CantidadProducto)
                    ValorUnitario = CDec(gvProductos.GetRowCellValue(i, "VALOR_UNITARIO").ToString) / CDec(CantidadProducto)

                    If _ds.Tables(0).Rows.Count <> 0 Then
                        SaldoCantidad = CDec(_ds.Tables(0).Rows(0)(1).ToString) + (CDec(gvProductos.GetRowCellValue(i, "CANTIDAD").ToString) * CantidadProducto)
                        SaldoTotal = CDec(_ds.Tables(0).Rows(0)(2).ToString) + (ValorUnitario * CantidadEntrada)
                        ValorPromedio = SaldoTotal / SaldoCantidad
                    Else
                        SaldoCantidad = CantidadEntrada
                        SaldoTotal = ValorUnitario * CantidadEntrada
                        ValorPromedio = ValorUnitario
                    End If

                    GuardarCompraInventario(gvProductos.GetRowCellValue(i, "IDPRODUCTO").ToString, gvProductos.GetRowCellValue(i, "IDMARCA").ToString, gvProductos.GetRowCellValue(i, "IDPRESENTACIONPRODUCTO").ToString, CantidadEntrada, ValorUnitario, SaldoCantidad, SaldoTotal, ValorPromedio)

                    i = i + 1
                Loop
            End If
            'txtId.Text = _DCompras.UltimoConsecutivo()
            ActualizarGrilla()
            LimpiarCampos()
            bbiGuardar.Enabled = False
        End If
    End Sub

    Private Sub gvProductos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvProductos.RowClick
        If e.RowHandle >= 0 Then
            _ClickProductoDetalleCompra = gvProductos.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _ClickProducto = gvProductos.GetRowCellValue(e.RowHandle.ToString, "IDPRODUCTO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cboProducto.Text = "" Then
            MessageBox.Show("Debe seleccionar el producto", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtCantidad.Text) <= 0 Then
            MessageBox.Show("Cantidad invalida", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtValorUnitario.Text) <= 0 Then
            MessageBox.Show("Valor Unitario es obligatoria", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            AgregarDetalleCompra()

            _DDetalleOrdenCompra.CambiarEstado(cboOrdenCompra.EditValue, cboProducto.EditValue, "ASIGNADO")

            GrillaDetalleCompra()
            LimpiarCamposDetalleCompra()

            If gvProductos.RowCount <> 0 Then
                cboOrdenCompra.Enabled = False
            End If
            ActivarGuardar()

            ComboProductosOrdenCompra()
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub gvProductoDetalleCompra_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvProductoDetalleCompra.RowClick
        If e.RowHandle >= 0 Then
            txtCantidad.Text = CDec(gvProductoDetalleCompra.GetRowCellValue(e.RowHandle.ToString, "CANTIDAD").ToString())
            txtValorUnitario.Text = CDec(gvProductoDetalleCompra.GetRowCellValue(e.RowHandle.ToString, "VALOR").ToString())
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickProductoDetalleCompra = "" Then
            MessageBox.Show("Debe seleccionar el producto a eliminar", "Eliminar Producto Detalle de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvProductos.RowCount = 1 And txtId.Text <> "" Then
            MessageBox.Show("La Orden de Compra no puede quedar sin detalle", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleCompra.EliminarProductoDetalleCompra(_ClickProductoDetalleCompra)
            GrillaDetalleCompra()
            _ClickProductoDetalleCompra = ""
            If gvProductos.RowCount <> 0 Then
                cboOrdenCompra.Enabled = False
                btnAgregarDetalleOrdenCompra.Enabled = False
            Else
                cboOrdenCompra.Enabled = True
                btnAgregarDetalleOrdenCompra.Enabled = True
            End If

            _DDetalleOrdenCompra.CambiarEstado(cboOrdenCompra.EditValue, _ClickProducto, "REQUERIDO")

            ComboProductosOrdenCompra()
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickCompra = "" Then
            MessageBox.Show("No ha seleccionado la Compra", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf _DOrdenCompra.OrdenCompraAprobada(_ClickOrdenCompra) = True Then
            '   MessageBox.Show("La orden de Compra ya fue aprobada", "Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea Editar la Compra?", "Editar Compra",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                        = DialogResult.Yes Then
                Editar()
            End If
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickCompra = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Compra pendiente por Guardar, Si presiona ACEPTAR se perderan los cambios ¿Desea Continuar?", "Nueva Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                If txtId.Text = Nothing And gvProductos.RowCount <> 0 Then
                    _DDetalleCompra.EliminarDetalleCompra(_Id.ToString)
                End If
                LimpiarCampos()
            End If
        Else
            LimpiarCampos()
        End If

        'LimpiarCampos()
    End Sub

    Private Sub frmCompras_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Compra pendiente por Guardar, Si cierra la ventana se perderan los cambios ¿Desea Continuar?", "Nueva Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                e.Cancel = False
                If txtId.Text = Nothing And gvProductos.RowCount <> 0 Then
                    _DDetalleCompra.EliminarDetalleCompra(_Id.ToString)
                    'Cambiamos el estado del detalle orden de compra a Asignado
                    _DDetalleOrdenCompra.CambiarEstadoOrdenCompra(cboOrdenCompra.EditValue, "REQUERIDO")
                End If
            Else
                e.Cancel = True
            End If
        Else
            If txtId.Text = Nothing And gvProductos.RowCount <> 0 Then
                _DDetalleCompra.EliminarDetalleCompra(_Id.ToString)
                'Cambiamos el estado del detalle orden de compra a Asignado
                _DDetalleOrdenCompra.CambiarEstadoOrdenCompra(cboOrdenCompra.EditValue, "REQUERIDO")
            End If
        End If
    End Sub

    Private Sub btnAgregarDetalleOrdenCompra_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalleOrdenCompra.Click
        If txtId.Text = Nothing Then
            If cboOrdenCompra.Text = "" Then
                MessageBox.Show("No ha seleccionado la Orden de Compra", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf gvProductos.RowCount = 0 Then
                _Id = Guid.NewGuid()
                _DDetalleCompra.GuardarDetalleOrdenCompra(_Id.ToString, cboOrdenCompra.EditValue)
                GrillaDetalleCompra()
                LimpiarCamposDetalleCompra()
                If gvProductos.RowCount <> 0 Then
                    cboOrdenCompra.Enabled = False
                End If
                btnAgregarDetalleOrdenCompra.Enabled = False
                'Cambiamos el estado del detalle orden de compra a Asignado
                _DDetalleOrdenCompra.CambiarEstadoOrdenCompra(cboOrdenCompra.EditValue, "ASIGNADO")
                'Actualizamos la lista de productos de la orden de compra
                ComboProductosOrdenCompra()
                ActivarGuardar()
            Else
                MsgBox("Ya tiene registros")
            End If
        End If
    End Sub

    Private Sub txtCantidad_Leave(sender As Object, e As EventArgs) Handles txtCantidad.Leave
        txtSubTotal.Text = CDec(txtCantidad.Text) * CDec(txtValorUnitario.Text)
    End Sub

    Private Sub txtValorUnitario_Leave(sender As Object, e As EventArgs) Handles txtValorUnitario.Leave
        txtSubTotal.Text = CDec(txtCantidad.Text) * CDec(txtValorUnitario.Text)
    End Sub
End Class
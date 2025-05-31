Public Class frmOrdenCompra
    Public IDEmpleado As String
    Public Licencia As String
    Dim _Id As New Guid
    Dim _ds As DataSet
    Dim _DProveedores As New SIM___GLOBAL.Controles.DProveedores
    Dim _DPresentacionProductos As New SIM___GLOBAL.Controles.DPresentacionProductos
    Dim _OrdenCompra As New SIM___GLOBAL.Modelo.OrdenCompra
    Dim _DOrdenCompra As New SIM___GLOBAL.Controles.DOrdenCompra
    Dim _DDetalleOrdenCompra As New SIM___GLOBAL.Controles.DDetalleOrdenCompra
    Dim _DetalleOrdenCompra As New SIM___GLOBAL.Modelo.DetalleOrdenCompra

    Dim _ClickProducto As String
    Dim _ClickOrdenCompra As String
    Dim _Fila As String
    Private Sub ActualizarGrilla()
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _DOrdenCompra.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub GrillaDetalleOrden()
        If txtCodigo.Text = "" Then
            _ds = _DDetalleOrdenCompra.Listar(_Id.ToString)
        Else
            _ds = _DDetalleOrdenCompra.Listar(txtCodigo.Text)
        End If
        GCProductos.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub Editar()
        _OrdenCompra = _DOrdenCompra.Cargar(_ClickOrdenCompra)
        txtCodigo.Text = _OrdenCompra.Id
        dtFecha.Text = _OrdenCompra.Fecha
        txtCodigoCompra.Text = "OC" & txtCodigo.Text & Format(CDate(dtFecha.Text), "ddMMyyyy").ToString
        cboProveedores.EditValue = _OrdenCompra.IdProveedor
        txtObservacion.Text = _OrdenCompra.Observacion
        'Bloqueamos
        bbiGuardar.Enabled = False
        GrillaDetalleOrden()
    End Sub
    Private Sub Guardar()
        _OrdenCompra.Id = Val(txtCodigo.Text)
        _OrdenCompra.Fecha = dtFecha.Text
        _OrdenCompra.Hora = DateTime.Now
        _OrdenCompra.IdProveedor = cboProveedores.EditValue
        _OrdenCompra.IdEmpleado = IdEmpleado
        _OrdenCompra.Observacion = txtObservacion.Text
        _OrdenCompra.Estado = "ABIERTA"
        _DOrdenCompra.Guardar(_OrdenCompra)
    End Sub
    Private Sub GuardarDetalleOrdenCompra()
        _DetalleOrdenCompra.Id = Val("")
        If _Id = Nothing Then
            _Id = Guid.NewGuid()
        End If
        If txtCodigo.Text <> "" Then
            _DetalleOrdenCompra.IdOrdenCompra = Val(txtCodigo.Text)
        Else
            _DetalleOrdenCompra.IdOrdenCompra = _Id.ToString
        End If
        _DetalleOrdenCompra.IdProducto = cboProducto.EditValue
        _DetalleOrdenCompra.Cantidad = txtCantidad.Text
        _DetalleOrdenCompra.ValorUnitario = txtValorUnitario.Text
        _DetalleOrdenCompra.Estado = "REQUERIDO"
        _DDetalleOrdenCompra.Guardar(_DetalleOrdenCompra)

    End Sub
    Private Sub LimpiarCampos()
        txtCodigo.Text = Nothing
        txtCodigoCompra.Text = Nothing
        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        cboProveedores.EditValue = Nothing
        txtObservacion.Text = Nothing
        bbiGuardar.Enabled = False
        GCProductos.DataSource = Nothing
        _Id = Nothing
    End Sub
    Private Sub LimpiarDetalleOrdenCompra()
        cboProducto.Text = Nothing
        txtCantidad.Text = ""
        txtValorUnitario.Text = ""
        txtSubTotal.Text = Nothing
    End Sub
    Private Sub ComboProductos()
        _ds = New DataSet()
        _ds = _DPresentacionProductos.ListarCombo()
        cboProducto.Properties.DataSource = _ds.Tables(0)
        cboProducto.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboProducto.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
    End Sub
    Private Sub frmOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarGrilla()
        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")

        'llenamos combo proveedores
        _ds = New DataSet()
        _ds = _DProveedores.ListarCombo()
        cboProveedores.Properties.DataSource = _ds.Tables(0)
        cboProveedores.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboProveedores.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        'llenamos combo productos
        comboproductos

        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If dtFecha.Text = "" Then
            MessageBox.Show("El Campo Fecha es Obligatorio", "Registro de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboProveedores.Text = "" Then
            MessageBox.Show("Debe seleccionar el Proveedor", "Registro de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVproductos.RowCount = 0 Then
            MessageBox.Show("La Orden de Compra no tiene detalle", "Registro de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()

            If txtCodigo.Text = "" Then
                txtCodigo.Text = _DOrdenCompra.UltimoConsecutivo()
                txtCodigoCompra.Text = _DOrdenCompra.Codigo()
                _DDetalleOrdenCompra.ActualizarDetalleordencompra(txtCodigo.Text, _Id.ToString)
                MsgBox("La Orden de Compra No. " & txtCodigoCompra.Text & " fue registrada exitosamente")
            End If

            'llenamos la grilla de registros
            ActualizarGrilla()
            LimpiarDetalleOrdenCompra()
            LimpiarCampos()
            bbiGuardar.Enabled = False
        End If
    End Sub

    Private Sub dtFecha_EditValueChanged(sender As Object, e As EventArgs) Handles dtFecha.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboProveedores_EditValueChanged(sender As Object, e As EventArgs) Handles cboProveedores.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtObservacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtObservacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Orden de Compra pendiente por Guardar, Si presiona ACEPTAR se perderan los cambios ¿Desea Continuar?", "Nueva Orden de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                If txtCodigo.Text = Nothing And gvProductos.RowCount <> 0 Then
                    _DDetalleOrdenCompra.EliminarDetalleOrdenCompra(_Id.ToString)
                End If
                LimpiarCampos()
            End If
        Else
            LimpiarCampos()
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim IdOrdenCompra As String
        If txtCodigo.Text <> "" Then
            IdOrdenCompra = Val(txtCodigo.Text)
        Else
            IdOrdenCompra = _Id.ToString
        End If
        If cboProducto.Text = Nothing Then
            MessageBox.Show("Debe seleccionar el producto", "Registro de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtCantidad.Text) <= 0 Then
            MessageBox.Show("El campo Cantidad es invalido", "Registro de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtValorUnitario.Text) <= 0 Then
            MessageBox.Show("El campo Valor Unitario es invalido", "Registro de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DDetalleOrdenCompra.ExisteProducto(IdOrdenCompra, cboProducto.EditValue) = True Then
            MessageBox.Show("El Producto ya esta registrado en la Orden de Compra", "Registro de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetalleOrdenCompra()
            GrillaDetalleOrden()
            LimpiarDetalleOrdenCompra()
        End If
    End Sub

    Private Sub gvProductos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvProductos.RowClick
        If e.RowHandle >= 0 Then
            _ClickProducto = gvProductos.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickProducto = "" Then
            MessageBox.Show("Debe seleccionar el producto a eliminar", "Eliminar Producto Orden de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GVproductos.RowCount = 1 And txtCodigo.Text <> "" Then
            MessageBox.Show("La Orden de Compra no puede quedar sin detalle", "Registro de Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetalleOrdenCompra.EliminarProducto(_ClickProducto)
            GrillaDetalleOrden()
            _ClickProducto = ""
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickOrdenCompra = "" Then
            MessageBox.Show("No ha seleccionado la Orden de Compra", "Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DOrdenCompra.OrdenCompraAbierta(_ClickOrdenCompra) = False Then
            MessageBox.Show("La orden de compra no se puede editar", "Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea Editar la Orden de Compra?", "Editar Orden de Compra",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                        = DialogResult.Yes Then
                Editar()
            End If
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickOrdenCompra = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub frmOrdenCompra_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bbiGuardar.Enabled = True Then
            If MessageBox.Show("Tiene una Orden de Compra pendiente por Guardar, Si cierran la ventana se perderan los cambios ¿Desea Continuar?", "Nueva Orden de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                e.Cancel = False
                If txtCodigo.Text = Nothing And gvProductos.RowCount <> 0 Then
                    _DDetalleOrdenCompra.EliminarDetalleordencompra(_Id.ToString)
                End If
            Else
                e.Cancel = True
            End If
        Else
            If txtCodigo.Text = Nothing And gvProductos.RowCount <> 0 Then
                _DDetalleOrdenCompra.EliminarDetalleOrdenCompra(_Id.ToString)
            End If
        End If
    End Sub

    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        If _ClickOrdenCompra = Nothing Then
            MessageBox.Show("No ha seleccionado la Orden de Compra", "Imprimir Orden Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim frmImprimir = New SIM___GLOBAL.frmImprimir
            MsgBox(_ClickOrdenCompra)
            frmImprimir.ImprimirOrdenCompra(_ClickOrdenCompra, Licencia)
        End If
    End Sub

    Private Sub bbiProveedores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProveedores.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmProveedores
        _frmOpen.Licencia = Licencia
        _frmOpen.IdEmpleado = IDEmpleado
        _frmOpen.ShowDialog()

        'llenamos combo proveedores
        _ds = New DataSet()
        _ds = _DProveedores.ListarCombo()
        cboProveedores.Properties.DataSource = _ds.Tables(0)
        cboProveedores.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboProveedores.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
    End Sub

    Private Sub txtCantidad_Leave(sender As Object, e As EventArgs) Handles txtCantidad.Leave
        txtSubTotal.Text = CDec(txtCantidad.Text) * CDec(txtValorUnitario.Text)
    End Sub

    Private Sub txtValorUnitario_Leave(sender As Object, e As EventArgs) Handles txtValorUnitario.Leave
        txtSubTotal.Text = CDec(txtCantidad.Text) * CDec(txtValorUnitario.Text)
    End Sub

    Private Sub bbiAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAnular.ItemClick
        If _ClickOrdenCompra = "" Then
            MessageBox.Show("No ha seleccionado la Orden de Compra", "Anular Orden Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DOrdenCompra.OrdenCompraAbierta(_ClickOrdenCompra) = False Then
            MessageBox.Show("No se puede anular la Orden de Compra", "Anular Orden Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea anular la Orden de Compra?", "Anular Orden Compra",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                        = DialogResult.Yes Then
                _DOrdenCompra.Anular(_ClickOrdenCompra)
                ActualizarGrilla()
                LimpiarDetalleOrdenCompra()
                LimpiarCampos()
                bbiGuardar.Enabled = False
            End If
        End If
    End Sub

    Private Sub bbiAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAprobar.ItemClick
        If _ClickOrdenCompra = "" Then
            MessageBox.Show("No ha seleccionado la Orden de Compra", "Aprobar Orden Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DOrdenCompra.OrdenCompraAbierta(_ClickOrdenCompra) = False Then
            MessageBox.Show("No se puede aprobar la Orden de Compra", "Aprobar Orden Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea aprobar la Orden de Compra?. Si es aprobada no podra realizar ningun cambio.", "Aprobar Orden Compra",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                        = DialogResult.Yes Then
                _DOrdenCompra.Aprobar(_ClickOrdenCompra)
                ActualizarGrilla()
                LimpiarDetalleOrdenCompra()
                LimpiarCampos()
                bbiGuardar.Enabled = False
            End If
        End If
    End Sub
End Class
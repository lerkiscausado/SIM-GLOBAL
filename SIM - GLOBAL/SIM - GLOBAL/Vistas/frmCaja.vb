Imports SIM___GLOBAL.Utilidades
Public Class frmCaja
    Public IdOrden As String
    Public Empleado As String
    Public IdEmpleado As String
    Public Licencia As String
    Dim _ds As DataSet
    Dim _dsMedioPago As DataSet
    Dim _DOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _DMedioPago As New SIM___GLOBAL.Controles.DMediosPago
    Dim _DetallePagoRecibo As New SIM___GLOBAL.Modelo.DetallePagoRecibo
    Dim _DDetallePagoRecibo As New SIM___GLOBAL.Controles.DDetallePagoRecibo
    Dim _Caja As New SIM___GLOBAL.Modelo.Caja
    Dim _DCaja As New SIM___GLOBAL.Controles.DCaja
    Dim _Cierrecaja As New SIM___GLOBAL.Modelo.CierreCaja
    Dim _DCierrecaja As New SIM___GLOBAL.Controles.DCierreCaja
    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
    ReadOnly _funciones As New Funciones
    Dim _ClickRecibo As String
    Dim _ClickRecibo2 As String
    Dim _ClickDetallePago As String
    Dim _ClickValorRecibo As Double
    Dim _ClickIdOrden As String
    Dim Estado As String
    Dim _Fila As String
    Dim _Id As New Guid
    Dim _Cambio As Double
    Dim Saldo As Double

    Private Sub GuardarDetallePagoRecibo()
        _DetallePagoRecibo.Id = Val("")
        _DetallePagoRecibo.IdRecibo = _Id.ToString
        _DetallePagoRecibo.IdMedioPago = cboFormaPago.GetColumnValue("ID")
        If txtEfectivo.Text <= txtValor.Text Then
            _DetallePagoRecibo.Valor = txtEfectivo.Text
        Else
            _DetallePagoRecibo.Valor = txtValor.Text
        End If
        _DDetallePagoRecibo.Guardar(_DetallePagoRecibo)
    End Sub
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet

        _ds = _DCaja.Listar
        GCConsultar.DataSource = _ds.Tables(0)

        _ds = _DCaja.ListarRecibosPendientes()
        GCRecibosPendientes.DataSource = _ds.Tables(0)

        _ds = _DCaja.ListarRecibosOrden(IdOrden)
        GCRecibosOrden.DataSource = _ds.Tables(0)

        txtSaldoActual.Text = colVALORP.SummaryItem.SummaryValue
    End Sub
    Private Sub ActualizarGrillaDetallePago()
        'Listar los medios de pago del recibo actual
        _ds = _DDetallePagoRecibo.Listar(_Id.ToString)
        GCDetallePagoDocumento.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCampos()
        txtNombre.Text = Nothing
        txtIdentificacion.Text = Nothing
        txtTelefono.Text = Nothing
        txtCiudad.Text = Nothing
        txtDireccion.Text = Nothing
        txtOrden.Text = 0
        txtConcepto.Text = Nothing
        txtGenerado.Text = Nothing
        txtSon.Text = Nothing
        txtValor.Text = 0
        _ClickRecibo = Nothing
        _ClickRecibo2 = Nothing
        IdOrden = Nothing
        Saldo = 0
        _Id = Guid.NewGuid()
        bbiGuardar.Enabled = False
    End Sub
    Private Sub Guardar()
        _Caja.Id = Val("")
        _Caja.IdOrden = txtOrden.Text
        _Caja.Fecha = dtFecha.Text
        _Caja.Ciudad = txtCiudad.Text
        _Caja.Nombre = txtNombre.Text
        _Caja.Identificacion = txtIdentificacion.Text
        _Caja.Direccion = txtDireccion.Text
        _Caja.Telefono = txtTelefono.Text
        _Caja.Valor = CDec(txtValor.Text)
        _Caja.Concepto = txtConcepto.Text
        _Caja.Estado = "R"
        _Caja.IdEmpleado = IdEmpleado
        _Caja.IdCierre = Val("0")
        _Caja.Referencia = txtConsecutivo.Text
        _Caja.IdCliente = 1
        _DCaja.Guardar(_Caja)
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNombre.Text = "" Then
            MessageBox.Show("El campo recibido de es obligatorio", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtIdentificacion.Text = "" Then
            MessageBox.Show("El campo identificación es obligatorio", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCiudad.Text = "" Then
            MessageBox.Show("El campo Ciudad es obligatorio", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (txtvalor.text > Saldo And IdOrden <> "") Then
            MessageBox.Show("El Valor a recibir es mayor al saldo pendiente", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtValor.Text <> colVALORDETALLEPAGO.SummaryItem.SummaryValue Then
            MessageBox.Show("El Recibo de Caja esta descuadrado. Por favor verifique", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            _DDetallePagoRecibo.ActualizarDetallePago(_Id.ToString)
            _DCaja.ActualizarSaldoOrden(IdOrden, Saldo - txtValor.Text)
            MessageBox.Show("El recibo se guardo satisfactoriamente", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ActualizarGrillaDetallePago()
            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtIdentificacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtIdentificacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtTelefono_EditValueChanged(sender As Object, e As EventArgs) Handles txtTelefono.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtCiudad_EditValueChanged(sender As Object, e As EventArgs) Handles txtCiudad.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDireccion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDireccion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtConcepto_EditValueChanged(sender As Object, e As EventArgs) Handles txtConcepto.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboMedioPago_EditValueChanged(sender As Object, e As EventArgs)
        ActivarGuardar()
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub GVRecibosOrden_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVRecibosOrden.RowClick
        If e.RowHandle >= 0 Then
            _ClickRecibo = GVRecibosOrden.GetRowCellValue(e.RowHandle.ToString, "RECIBO").ToString()
            _ClickValorRecibo = GVRecibosOrden.GetRowCellValue(e.RowHandle.ToString, "VALOR")
            _ClickIdOrden = GVRecibosOrden.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            Estado = GVRecibosOrden.GetRowCellValue(e.RowHandle.ToString, "ESTADO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAnular.ItemClick
        If xtcCaja.SelectedTabPage.Text = "Caja" Then

            If _ClickRecibo = "" Then
                MessageBox.Show("Debe seleccionar el recibo a Anular", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf _DCaja.ReciboRegistrado(_ClickRecibo) = False Then
                MessageBox.Show("Este recibo no se puede anular", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("¿Desea anular el recibo?", "Registro de Recibos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    _DCaja.AnularRecibo(_ClickRecibo)
                    If _ClickIdOrden <> "0" Then
                        Dim SaldoOrden As Double
                        SaldoOrden = _DCaja.SaldoOrden(_ClickIdOrden)
                        _DCaja.ActualizarSaldoOrden(_ClickIdOrden, SaldoOrden + _ClickValorRecibo)
                    End If
                    LimpiarCampos()
                    ActualizarGrilla()
                End If
            End If
        Else
            If _ClickRecibo2 = "" Then
                MessageBox.Show("Debe seleccionar el recibo a Anular", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf _DCaja.ReciboRegistrado(_ClickRecibo2) = False Then
                MessageBox.Show("Este recibo no se puede anular", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("¿Desea anular el recibo?", "Registro de Recibos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    _DCaja.AnularRecibo(_ClickRecibo2)
                    If _ClickIdOrden <> "0" Then
                        Dim SaldoOrden As Double
                        SaldoOrden = _DCaja.SaldoOrden(_ClickIdOrden)
                        _DCaja.ActualizarSaldoOrden(_ClickIdOrden, SaldoOrden + _ClickValorRecibo)
                    End If
                    LimpiarCampos()
                    ActualizarGrilla()
                End If
            End If
        End If
    End Sub

    Private Sub btnCerrarCaja_Click(sender As Object, e As EventArgs) Handles btnCerrarCaja.Click
        If MessageBox.Show("¿Desea cerrar la caja?", "Registro de Recibos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
            _Cierrecaja.Id = Val("")
            _Cierrecaja.Fecha = dtFechaCierre.Text
            _Cierrecaja.Hora = DateTime.Now
            _Cierrecaja.Saldo = txtSaldoActual.Text
            _Cierrecaja.Observaciones = txtObservaciones.Text
            _Cierrecaja.IdEmpleado = IdEmpleado
            _DCierrecaja.Guardar(_Cierrecaja)

            _DCaja.ActualizarRecibos()
            LimpiarCampos()
            ActualizarGrilla()

            MsgBox("El cierre de caja fue elaborado satisfactoriamente")
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickRecibo2 = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "RECIBO").ToString()
            _ClickValorRecibo = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "VALOR")
            _ClickIdOrden = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            Estado = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ESTADO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cboFormaPago.Text = "" Then
            MessageBox.Show("Debe seleccionar el medio de pago", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtefectivo.Text <= 0 Or txtValor.Text <= 0 Then
            MessageBox.Show("Valor ingresado es incorrecto", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DDetallePagoRecibo.Existe(_Id.ToString, cboFormaPago.GetColumnValue("ID")) Then
            MessageBox.Show("El medio de pago ya fue agregado", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetallePagoRecibo()
            ActualizarGrillaDetallePago()
            'cboFormaPago.EditValue = Nothing

            txtEfectivo.Text = txtValor.Text - colVALORDETALLEPAGO.SummaryItem.SummaryValue

            If txtEfectivo.Text < 0 Then
                txtEfectivo.Text = 0
            End If

            bbiGuardar.Enabled = True
        End If
    End Sub

    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        If txtValor.Text >= 0 Then
            txtSon.Text = _funciones.Num2Text(txtValor.Text) & " PESOS M/CTE."
        Else
            txtSon.Text = Nothing
        End If
        _Cambio = txtEfectivo.Text - txtValor.Text
        If _Cambio < 0 Then
            txtCambio.Text = 0
        Else
            txtCambio.Text = _Cambio
        End If
    End Sub

    Private Sub txtEfectivo_Leave(sender As Object, e As EventArgs) Handles txtEfectivo.Leave
        _Cambio = txtEfectivo.Text - txtValor.Text
        If _Cambio < 0 Then
            txtCambio.Text = 0
        Else
            txtCambio.Text = _Cambio
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickDetallePago = "" Then
            MessageBox.Show("Debe seleccionar el medio de pago a eliminar", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetallePagoRecibo.Eliminar(_ClickDetallePago)
            ActualizarGrillaDetallePago()
            _ClickDetallePago = Nothing
            If gvDetallePagoDocumento.RowCount <> 0 Then
                bbiGuardar.Enabled = True
            Else
                bbiGuardar.Enabled = False
            End If

            txtEfectivo.Text = txtValor.Text - colVALORDETALLEPAGO.SummaryItem.SummaryValue

            If txtEfectivo.Text < 0 Then
                txtEfectivo.Text = 0
            End If
        End If
    End Sub

    Private Sub gvDetallePagoDocumento_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvDetallePagoDocumento.RowClick
        If e.RowHandle >= 0 Then
            _ClickDetallePago = gvDetallePagoDocumento.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub cboFormaPago_EditValueChanged(sender As Object, e As EventArgs) Handles cboFormaPago.EditValueChanged
        If cboFormaPago.Text = "EFECTIVO" Then
            lblValor.Text = "Efectivo:"
            txtCambio.Visible = True
            lblCambio.Visible = True
        Else
            lblValor.Text = "Valor:"
            txtCambio.Visible = False
            lblCambio.Visible = False
        End If
    End Sub

    Private Sub frmCaja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If gvDetallePagoDocumento.RowCount <> 0 Then
            _DDetallePagoRecibo.EliminarDetalleRecibo(_Id.ToString)
        End If
    End Sub

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ds = New DataSet()

        xtpCaja.Show()
        txtGenerado.Text = Empleado
        txtElaborado.Text = Empleado

        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        dtFechaCierre.Text = Format(DateTime.Now, "dd/MM/yyyy")


        'Traemos el ultimo cierre de caja
        _ds = _DCierrecaja.UltimoCierre()
        If _ds.Tables(0).Rows.Count <> 0 Then
            dtFechaCierre.Text = _ds.Tables(0).Rows(0)(0).ToString()
            txtSaldoAnterior.Text = _ds.Tables(0).Rows(0)(1).ToString()
        End If

        'Si fue seleccionada una orden se traen los datos del paciente y de la orden
        If IdOrden <> "" Then
            _ds = New DataSet()
            _ds = _DOrdenes.DatosUsuarioRecibo(IdOrden)

            If _ds.Tables(0).Rows(0)(5) <> 0 And _ds.Tables(0).Rows(0)(7).ToString <> "CANCELADO" Then
                txtNombre.Text = _ds.Tables(0).Rows(0)(0).ToString()
                txtIdentificacion.Text = _ds.Tables(0).Rows(0)(1).ToString()
                txtTelefono.Text = _ds.Tables(0).Rows(0)(2).ToString()
                txtDireccion.Text = _ds.Tables(0).Rows(0)(3).ToString()
                txtOrden.Text = _ds.Tables(0).Rows(0)(4).ToString()
                txtValor.Text = _ds.Tables(0).Rows(0)(5).ToString()
                txtEfectivo.Text = _ds.Tables(0).Rows(0)(5).ToString()
                Saldo = _ds.Tables(0).Rows(0)(5)
                txtConsecutivo.Text = _ds.Tables(0).Rows(0)(6)

                _ds = _DOrdenes.DetalleRecibo(IdOrden)
                'txtValor.Text = _ds.Tables(0).Rows(0)(0).ToString
                txtConcepto.Text = _ds.Tables(0).Rows(0)(1).ToString
            Else
                txtOrden.Text = 0
                txtValor.Text = 0
                txtEfectivo.Text = 0
            End If
        Else
            txtOrden.Text = 0
            txtValor.Text = 0
            txtEfectivo.Text = 0

        End If

        If txtValor.Text >= 0 Then
            txtSon.Text = _funciones.Num2Text(txtValor.Text) & " PESOS M/CTE."
        Else
            txtSon.Text = Nothing
        End If

        ' Cargar Medios de Pago
        _dsMedioPago = New DataSet()
        _dsMedioPago = _DMedioPago.ListarCombo
        cboFormaPago.Properties.DataSource = _dsMedioPago.Tables(0)
        cboFormaPago.Properties.DisplayMember = _dsMedioPago.Tables(0).Columns(1).Caption
        cboFormaPago.Properties.ValueMember = _dsMedioPago.Tables(0).Columns(0).Caption
        cboFormaPago.ItemIndex = 0

        Select Case Licencia
            Case "11"
                colORDENP.Visible = False
                colIDORDEN.Visible = False
                colIDORDENRECIBO.Visible = False
                txtCiudad.Text = "Santa Marta"
            Case Else
                colCONSECUTIVO.Visible = False
                colCONSECUTIVOP.Visible = False
                colCONSECUTIVORECIBO.Visible = False
                txtCiudad.Text = "Cartagena"
        End Select

        ActualizarGrilla()

        _Id = Guid.NewGuid()

        _Cambio = txtEfectivo.Text - txtValor.Text
        If cboFormaPago.Text = "EFECTIVO" Then
            If _Cambio < 0 Then
                txtCambio.Text = 0
            Else
                txtCambio.Text = _Cambio
            End If
        Else
            txtCambio.Text = 0
        End If

        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        If xtcCaja.SelectedTabPage.Text = "Caja" Then
            If _ClickRecibo = "" Then
                MessageBox.Show("Debe seleccionar el recibo a Imprimir", "Imprimir Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Estado = "ANULADO" Then
                MessageBox.Show("El recibo se encuentra anulado", "Imprimir Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ImprimirFrm.ImprimirReciboCaja(_ClickRecibo, Licencia, 1)
            End If
        Else
            If _ClickRecibo2 = "" Then
                MessageBox.Show("Debe seleccionar el recibo a Imprimir", "Imprimir Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Estado = "ANULADO" Then
                MessageBox.Show("El recibo se encuentra anulado", "Imprimir Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ImprimirFrm.ImprimirReciboCaja(_ClickRecibo2, Licencia, 1)
            End If
        End If
    End Sub

    Private Sub LabelControl17_Click(sender As Object, e As EventArgs) Handles LabelControl17.Click

    End Sub
End Class
Imports DevExpress.XtraGrid.Views.Grid
Imports SIM___GLOBAL.Utilidades
Public Class frmReciboCaja
    Public IdOrden As String
    Public Empleado As String
    Public ClienteFactura As Integer
    Public Licencia As String
    Public IdEmpleado As String
    Public IdCuentaCliente As String
    Public IdCliente As String
    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
    ReadOnly _funciones As New Funciones
    Dim _DetallePagoRecibo As New SIM___GLOBAL.Modelo.DetallePagoRecibo
    Dim _DDetallePagoRecibo As New SIM___GLOBAL.Controles.DDetallePagoRecibo
    Dim _DMedioPago As New SIM___GLOBAL.Controles.DMediosPago
    Dim _Caja As New SIM___GLOBAL.Modelo.Caja
    Dim _DCaja As New SIM___GLOBAL.Controles.DCaja
    Dim _Cierrecaja As New SIM___GLOBAL.Modelo.CierreCaja
    Dim _DCierrecaja As New SIM___GLOBAL.Controles.DCierreCaja
    Dim _DOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _Clientes As New SIM___GLOBAL.Modelo.Clientes
    Dim _DClientes = New SIM___GLOBAL.Controles.DClientes
    Dim _CuentasClientes As New SIM___GLOBAL.Modelo.CuentasClientes
    Dim _DCuentasClientes As New SIM___GLOBAL.Controles.DCuentasClientes
    Dim _DetalleCuentaCliente As New SIM___GLOBAL.Modelo.DetalleCuentaCliente
    Dim _DDetalleCuentaCliente As New SIM___GLOBAL.Controles.DDetalleCuentaCliente
    Dim _DOrdenServicio As New SIM___GLOBAL.Controles.DOrdenServicio
    Dim _Id As New Guid
    Dim _ds As DataSet
    Dim _dsMedioPago As DataSet
    Dim _ClickRecibo As String
    Dim _ClickRecibo2 As String
    Dim _ClickValorRecibo As Double
    Dim _ClickDetallePago As String
    Dim _ClickIdOrden As String
    Dim _ClickCuentasClientes As String
    Dim _ClickIdCierre As String
    Dim _ClickConsecutivo As String
    Dim Estado As String
    Dim _Fila As String
    Dim Saldo As Double
    Dim Referencia As String
    Dim _Cambio As Double
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim _frmOpen As New SIM___GLOBAL.frmClientes
        _frmOpen.Licencia = Licencia
        _frmOpen.IdEmpleado = IdEmpleado
        _frmOpen.ShowDialog()
        ' ListarComboClientes()
    End Sub
    Private Sub GuardarDetallePagoRecibo()
        _DetallePagoRecibo.Id = Val("")
        _DetallePagoRecibo.IdRecibo = _Id.ToString
        _DetallePagoRecibo.IdMedioPago = cboFormaPago.GetColumnValue("ID")
        'If Val(txtEfectivo.Text) <= Val(txtValor.Text) Then
        _DetallePagoRecibo.Valor = txtFormaPagoValor.EditValue
        ' 'MsgBox("Efectivo")
        ' Else
        ' _DetallePagoRecibo.Valor = txtValor.Text
        ' End If
        _DDetallePagoRecibo.Guardar(_DetallePagoRecibo)
    End Sub
    Private Sub LimpiarCamposDetallePagoRecibo()
        cboFormaPago.EditValue = Nothing
        txtFormaPagoValor.EditValue = Nothing
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

        _ds = _DCaja.ListarCierre()
        GCConsultaCierre.DataSource = _ds.Tables(0)

        txtSaldoActual.Text = colVALORP.SummaryItem.SummaryValue
    End Sub
    Private Sub ActualizarGrillaDetallePago()
        'Listar los medios de pago del recibo actual
        _ds = _DDetallePagoRecibo.Listar(_Id.ToString)
        GCDetallePagoDocumento.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCampos()
        'txtNombre.Text = Nothing
        'txtIdentificacion.Text = Nothing
        'txtTelefono.Text = Nothing
        'txtCiudad.Text = Nothing
        'txtDireccion.Text = Nothing
        'txtOrden.Text = 0
        txtConcepto.Text = Nothing
        txtConsecutivo.Text = Nothing
        txtTipoDocumento.Text = Nothing
        txtGenerado.Text = Nothing
        txtSon.Text = Nothing
        cboCliente.EditValue = Nothing

        txtValor.Text = 0
        GCCuentasClientes.DataSource = Nothing
        _ClickRecibo = Nothing
        _ClickRecibo2 = Nothing
        IdOrden = Nothing
        Saldo = 0
        _Id = Guid.NewGuid()
        bbiGuardar.Enabled = False
    End Sub
    Private Sub Guardar()
        _Caja.Id = Val("")
        _Caja.IdOrden = Val(txtConsecutivo.Text)
        _Caja.Fecha = dtFecha.Text
        _Caja.Ciudad = txtCiudad.Text
        _Caja.Nombre = cboCliente.Text
        '_Caja.Identificacion = txtIdentificacion.Text
        '_Caja.Direccion = txtDireccion.Text
        '_Caja.Telefono = txtTelefono.Text
        _Caja.Valor = Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
        _Caja.Concepto = txtConcepto.Text
        _Caja.Estado = "R"
        _Caja.IdEmpleado = IdEmpleado
        _Caja.IdCierre = Val("0")

        Select Case txtTipoDocumento.Text
            Case "ORDEN SERVICIO"
                _Caja.Referencia = "OS" & txtConsecutivo.Text
            Case "ORDEN MEDICA"
                _Caja.Referencia = "OM" & txtConsecutivo.Text
            Case "FACTURA"
                _Caja.Referencia = "FA" & txtConsecutivo.Text
            Case Else
                _Caja.Referencia = "RC" & txtConsecutivo.Text
        End Select

        'If txtTipoDocumento.Text = "" Then
        '_Caja.Referencia = "RC" & txtConsecutivo.Text
        'ElseIf txtTipoDocumento.Text = "ORDEN SERVICIO" Then
        ' _Caja.Referencia = "OS" & txtConsecutivo.Text
        ' Else
        '_Caja.Referencia = "FA" & txtConsecutivo.Text
        'End If
        _Caja.IdCliente = cboCliente.EditValue
        _DCaja.Guardar(_Caja)
    End Sub
    Private Sub ListarComboClientes()
        ' Cargar Clientes
        _ds = New DataSet()
        _ds = _DClientes.listarcombo
        cboCliente.Properties.DataSource = _ds.Tables(0)
        cboCliente.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboCliente.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
    End Sub
    Private Sub frmReciboCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ds = New DataSet()

        'Listamos los clientes
        ListarComboClientes()

        ' Cargar Medios de Pago
        _dsMedioPago = New DataSet()
        _dsMedioPago = _DMedioPago.ListarCombo
        cboFormaPago.Properties.DataSource = _dsMedioPago.Tables(0)
        cboFormaPago.Properties.DisplayMember = _dsMedioPago.Tables(0).Columns(1).Caption
        cboFormaPago.Properties.ValueMember = _dsMedioPago.Tables(0).Columns(0).Caption
        cboFormaPago.ItemIndex = 0

        xtpCaja.Show()
        txtGenerado.Text = Empleado
        txtElaborado.Text = Empleado

        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        dtFechaCierre.Text = Format(DateTime.Now, "dd/MM/yyyy")

        'Traemos el ultimo cierre de caja
        _ds = _DCierrecaja.UltimoCierre()
        If _ds.Tables(0).Rows.Count <> 0 Then
            'dtFechaCierre.Text = _ds.Tables(0).Rows(0)(0).ToString()
            txtSaldoAnterior.Text = _ds.Tables(0).Rows(0)(1).ToString()
        End If

        'Si fue seleccionada una orden se traen los datos del paciente y de la orden
        'If IdOrden <> "" Then
        ' _ds = New DataSet()
        ' _ds = _DOrdenes.DatosUsuarioRecibo(IdOrden)
        '
        '        If _ds.Tables(0).Rows(0)(5) <> 0 And _ds.Tables(0).Rows(0)(7).ToString <> "CANCELADO" Then
        'txtNombre.Text = _ds.Tables(0).Rows(0)(0).ToString()
        '        txtIdentificacion.Text = _ds.Tables(0).Rows(0)(1).ToString()
        '       txtTelefono.Text = _ds.Tables(0).Rows(0)(2).ToString()
        '      txtDireccion.Text = _ds.Tables(0).Rows(0)(3).ToString()
        '     txtOrden.Text = _ds.Tables(0).Rows(0)(4).ToString()
        '    txtValor.Text = _ds.Tables(0).Rows(0)(5).ToString()
        '   txtEfectivo.Text = _ds.Tables(0).Rows(0)(5).ToString()
        '  Saldo = _ds.Tables(0).Rows(0)(5)
        ' txtConsecutivo.Text = _ds.Tables(0).Rows(0)(6)

        '_ds = _DOrdenes.DetalleRecibo(IdOrden)
        'txtValor.Text = _ds.Tables(0).Rows(0)(0).ToString
        'txtConcepto.Text = _ds.Tables(0).Rows(0)(1).ToString
        'Else
        'txtOrden.Text = 0
        'txtValor.Text = 0
        'txtEfectivo.Text = 0
        'End If
        'Else
        'txtOrden.Text = 0
        txtValor.Text = 0
        'txtEfectivo.Text = 0

        'End If

        If txtValor.Text >= 0 Then
            txtSon.Text = _funciones.Num2Text(txtValor.Text) & " PESOS M/CTE."
        Else
            txtSon.Text = Nothing
        End If


        'If txtOrden.Text <> "" Then
        ' cboCliente.EditValue = ClienteFactura
        ' End If

        Select Case Licencia
            Case 11
                cboCliente.EditValue = IdCliente
                colORDENP.Visible = False
                colIDORDEN.Visible = False
                'colIDORDENRECIBO.Visible = False
                txtCiudad.Text = "Santa Marta"
            Case Else
                colCONSECUTIVO.Visible = False
                colCONSECUTIVOP.Visible = False
                'colCONSECUTIVORECIBO.Visible = False
                txtCiudad.Text = "Cartagena"
        End Select

        ActualizarGrilla()

        _Id = Guid.NewGuid()

        '_Cambio = txtEfectivo.Text - txtValor.Text
        'If cboFormaPago.Text = "EFECTIVO" Then
        'If _Cambio < 0 Then
        '' txtCambio.Text = 0
        'Else
        ''txtCambio.Text = _Cambio
        'End If
        'Else
        ' txtCambio.Text = 0
        ' End If

        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        'If txtIdentificacion.Text = "" Then
        ' MessageBox.Show("El campo recibido de es obligatorio", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If txtConcepto.Text = "" Then
            MessageBox.Show("El campo concepto es obligatorio", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCiudad.Text = "" Then
            MessageBox.Show("El campo Ciudad es obligatorio", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvDetallePagoDocumento.RowCount = 0 Then
            MessageBox.Show("Falta detalle del recibo de caja", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtValor.EditValue <> 0 And (colVALORDETALLEPAGO.SummaryItem.SummaryValue > txtValor.EditValue) Then
            MessageBox.Show("El Saldo a cancelar no puede ser mayor al Saldo pendiente por el cliente. Por favor verifique", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            _DDetallePagoRecibo.ActualizarDetallePago(_Id.ToString)
            '_DCaja.ActualizarSaldoOrden(IdOrden, Saldo - txtValor.Text)

            'Buscamos el ultimo recibo
            Dim UltimoRecibo As String
            UltimoRecibo = _DCaja.UltimoReciboCaja

            If txtValor.EditValue <> 0 Then
                _CuentasClientes = _DCuentasClientes.Cargar(Val(_ClickCuentasClientes))

                _DCuentasClientes.AjustarSaldo(Val(_ClickCuentasClientes), Val(_CuentasClientes.Saldo) - Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue))

                _DetalleCuentaCliente.Id = Val("")
                _DetalleCuentaCliente.IdCuentaCliente = Val(_ClickCuentasClientes)
                _DetalleCuentaCliente.IdRecibo = Val(UltimoRecibo)
                _DetalleCuentaCliente.Valor = Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
                _DetalleCuentaCliente.Saldo = Val(_CuentasClientes.Saldo) - Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
                _DetalleCuentaCliente.Estado = "A"
                _DDetalleCuentaCliente.Guardar(_DetalleCuentaCliente)

            Else
                'Guardamos el movimiento del cliente
                _CuentasClientes.Id = Val("")
                _CuentasClientes.IdLicencia = Licencia
                _CuentasClientes.IdCliente = cboCliente.EditValue
                _CuentasClientes.TipoDocumento = "RC"
                _CuentasClientes.NumeroDocumento = UltimoRecibo
                _CuentasClientes.Fecha = dtFecha.Text
                _CuentasClientes.Concepto = txtConcepto.Text
                _CuentasClientes.Valor = Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
                _CuentasClientes.Saldo = Val("0")
                _DCuentasClientes.Guardar(_CuentasClientes)

                _DetalleCuentaCliente.Id = Val("")
                _DetalleCuentaCliente.IdCuentaCliente = Val(_DCuentasClientes.UltimoID)
                _DetalleCuentaCliente.IdRecibo = Val(UltimoRecibo)
                _DetalleCuentaCliente.Valor = Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)
                _DetalleCuentaCliente.Saldo = Val("0")
                _DetalleCuentaCliente.Estado = "A"
                _DDetalleCuentaCliente.Guardar(_DetalleCuentaCliente)
            End If

            If MessageBox.Show("Desea imprimir el recibo de caja?", "Registro de Recibos de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                ImprimirFrm.ImprimirReciboCaja(Val(UltimoRecibo), Licencia, 0)
            End If
            ActualizarGrillaDetallePago()
            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub

    Private Sub txtIdentificacion_EditValueChanged(sender As Object, e As EventArgs)
        ActivarGuardar()
    End Sub

    Private Sub txtTelefono_EditValueChanged(sender As Object, e As EventArgs)
        ActivarGuardar()
    End Sub

    Private Sub txtCiudad_EditValueChanged(sender As Object, e As EventArgs) Handles txtCiudad.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDireccion_EditValueChanged(sender As Object, e As EventArgs)
        ActivarGuardar()
    End Sub

    Private Sub txtConcepto_EditValueChanged(sender As Object, e As EventArgs) Handles txtConcepto.EditValueChanged
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

    Private Sub GVRecibosOrden_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)
        If e.RowHandle >= 0 Then
            ' _ClickRecibo = GVRecibosOrden.GetRowCellValue(e.RowHandle.ToString, "RECIBO").ToString()
            ' _ClickValorRecibo = GVRecibosOrden.GetRowCellValue(e.RowHandle.ToString, "VALOR")
            ' _ClickIdOrden = GVRecibosOrden.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            ' Estado = GVRecibosOrden.GetRowCellValue(e.RowHandle.ToString, "ESTADO").ToString()
            ' _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAnular.ItemClick
        'If xtcCaja.SelectedTabPage.Text = "Caja" Then
        If _ClickRecibo2 = "" Then
            MessageBox.Show("Debe seleccionar el recibo a Anular", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DCaja.ReciboRegistrado(_ClickRecibo2) = False Then
            MessageBox.Show("Este recibo no se puede anular", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("¿Desea anular el recibo?", "Registro de Recibos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                _DCaja.AnularRecibo(_ClickRecibo2)
                'MsgBox(_ClickIdOrden)
                If _ClickIdOrden <> Val("0") Then
                    Dim SaldoOrden As Double
                    SaldoOrden = _DCuentasClientes.SaldoCuentaCliente(_ClickIdOrden, Mid(_ClickConsecutivo, 1, 2))
                    _DCuentasClientes.ActualizarSaldoCliente(_ClickIdOrden, SaldoOrden + _ClickValorRecibo, Mid(_ClickConsecutivo, 1, 2))
                    _DDetalleCuentaCliente.AnularDetalleCuentaCliente(_ClickRecibo2)
                Else
                    Dim IdCuentaCliente As String
                    IdCuentaCliente = _DDetalleCuentaCliente.IdCuentaCliente(_ClickRecibo2)
                    _DCuentasClientes.ActualizarConceptoCliente(IdCuentaCliente)
                    _DDetalleCuentaCliente.AnularDetalleCuentaCliente(_ClickRecibo2)
                End If
                LimpiarCampos()
                ActualizarGrilla()
            End If
        End If
        'Else
        'If _ClickRecibo2 = "" Then
        'MessageBox.Show("Debe seleccionar el recibo a Anular", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'ElseIf _DCaja.ReciboRegistrado(_ClickRecibo2) = False Then
        ' MessageBox.Show("Este recibo no se puede anular", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        'If MessageBox.Show("¿Desea anular el recibo?", "Registro de Recibos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
        '_DCaja.AnularRecibo(_ClickRecibo2)
        'If _ClickIdOrden <> Val("0") Then
        'Dim SaldoOrden As Double
        'SaldoOrden = _DCuentasClientes.SaldoCuentaCliente(_ClickIdOrden)
        '_DCuentasClientes.ActualizarSaldoCliente(_ClickIdOrden, SaldoOrden + _ClickValorRecibo)
        'Else
        'Dim IdCuentaCliente As String
        'IdCuentaCliente = _DDetalleCuentaCliente.IdCuentaCliente(_ClickRecibo2)
        '_DCuentasClientes.ActualizarConceptoCliente(IdCuentaCliente)
        '_DDetalleCuentaCliente.AnularDetalleCuentaCliente(_ClickRecibo2)
        'End If
        'LimpiarCampos()
        'ActualizarGrilla()
        'End If
        'End If
        'End If
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
            _ClickConsecutivo = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "CONSECUTIVO").ToString()
            Estado = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ESTADO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        If cboFormaPago.Text = "" Then
            MessageBox.Show("Debe seleccionar el medio de pago", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' ElseIf txtEfectivo.Text <= 0 Or txtValor.Text <= 0 Then
            '     MessageBox.Show("Valor ingresado es incorrecto", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DDetallePagoRecibo.Existe(_Id.ToString, cboFormaPago.GetColumnValue("ID")) Then
            MessageBox.Show("El medio de pago ya fue agregado", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetallePagoRecibo()
            ActualizarGrillaDetallePago()
            'cboFormaPago.EditValue = Nothing

            '    txtEfectivo.Text = txtValor.Text - colVALORDETALLEPAGO.SummaryItem.SummaryValue
            '
            '            If txtEfectivo.Text < 0 Then
            '            txtEfectivo.Text = 0
            '        End If

            bbiGuardar.Enabled = True
        End If
    End Sub

    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        If txtValor.Text >= 0 Then
            txtSon.Text = _funciones.Num2Text(txtValor.Text) & " PESOS M/CTE."
        Else
            txtSon.Text = Nothing
        End If
        '_Cambio = txtEfectivo.Text - txtValor.Text
        'If _Cambio < 0 Then
        ' txtCambio.Text = 0
        ' Else
        ' txtCambio.Text = _Cambio
        ' End If
    End Sub

    Private Sub txtEfectivo_Leave(sender As Object, e As EventArgs)
        '_Cambio = txtEfectivo.Text - txtValor.Text
        'If _Cambio < 0 Then
        ' txtCambio.Text = 0
        ' Else
        ' txtCambio.Text = _Cambio
        'End If
    End Sub

    Private Sub cboCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cboCliente.EditValueChanged
        'Mostrar información del cliente

        'If cboCliente.Text <> "[Vacío]" Then
        ' _Clientes = _DClientes.Cargar(cboCliente.EditValue)
        ' txtIdentificacion.Text = _Clientes.Identificacion
        ' txtTelefono.Text = _Clientes.Telefono
        ' txtDireccion.Text = _Clientes.Direccion
        '
        '        _ds = _DCuentasClientes.SaldoActualCliente(cboCliente.EditValue)
        '        If _ds.Tables(0).Rows.Count <> 0 Then
        '        txtOrden.Text = _ds.Tables(0).Rows(0)(1).ToString
        '        txtSaldo.Text = _ds.Tables(0).Rows(0)(3).ToString
        '        IdCuentaCliente = _ds.Tables(0).Rows(0)(4).ToString
        '        Else
        '        txtOrden.Text = Val("0")
        '        txtSaldo.Text = Val("0")
        '        IdCuentaCliente = "0"
        '        End If
        '        End If
        'Mostrar información del cliente

        _ds = New DataSet()
        _ds = _DOrdenServicio.CargarCliente(cboCliente.EditValue)
        GCDatosCliente.DataSource = _ds.Tables(0)

        _ds = New DataSet
        _ds = _DCuentasClientes.SaldosCliente(cboCliente.EditValue)
        GCCuentasClientes.DataSource = _ds.Tables(0)

        If gvCuentasClientes.RowCount = 0 Then
            txtConsecutivo.Text = Nothing
            txtTipoDocumento.Text = Nothing
            txtValor.Text = Val("0")
        End If

        bbiGuardar.Enabled = True

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
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

            '   txtEfectivo.Text = txtValor.Text - colVALORDETALLEPAGO.SummaryItem.SummaryValue

            '            If txtEfectivo.Text < 0 Then
            '            txtEfectivo.Text = 0
        End If
        '       End If
    End Sub

    'Private Sub gvDetallePagoDocumento_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)
    ' If e.RowHandle >= 0 Then
    '        _ClickDetallePago = gvDetallePagoDocumento.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
    '       _Fila = e.RowHandle.ToString
    ' End If
    'End Sub

    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        If xtcCaja.SelectedTabPage.Text = "Caja" Then
            If _ClickRecibo = "" Then
                MessageBox.Show("Debe seleccionar el recibo a Imprimir", "Imprimir Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Estado = "ANULADO" Then
                MessageBox.Show("El recibo se encuentra anulado", "Imprimir Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ImprimirFrm.ImprimirReciboCaja(_ClickRecibo, Licencia, 1)
            End If
        ElseIf xtcCaja.SelectedTabPage.Text = "Consulta Cierres" Then
            If _ClickIdCierre = "" Then
                MessageBox.Show("Debe seleccionar el Cierre a Imprimir", "Imprimir Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ImprimirFrm.ImprimirCierreCaja(_ClickIdCierre, Licencia, 1)
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

    Private Sub frmReciboCaja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If gvDetallePagoDocumento.RowCount <> 0 Then
            _DDetallePagoRecibo.EliminarDetalleRecibo(_Id.ToString)
        End If
    End Sub

    Private Sub gvCuentasClientes_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvCuentasClientes.RowClick
        If e.RowHandle >= 0 Then
            _ClickCuentasClientes = gvCuentasClientes.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            txtConsecutivo.Text = gvCuentasClientes.GetRowCellValue(e.RowHandle.ToString, "CONSECUTIVO").ToString()
            txtTipoDocumento.Text = gvCuentasClientes.GetRowCellValue(e.RowHandle.ToString, "DOCUMENTO").ToString()
            txtValor.Text = gvCuentasClientes.GetRowCellValue(e.RowHandle.ToString, "SALDO").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiOrdenServicio_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOrdenServicio.ItemClick
        If _ClickCuentasClientes <> Nothing Then
            Select Case Licencia
                Case 12, 15 'aquamedical - Optica Freisem
                    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
                    ImprimirFrm.ImprimirOrdenServicio(_ClickCuentasClientes, 1)
            End Select
        Else
            MessageBox.Show("Debe Seleccionar una Orden de Servicio", "Imprimir Orden Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAgregarFormaPago_Click(sender As Object, e As EventArgs) Handles btnAgregarFormaPago.Click
        If cboFormaPago.Text = "" Then
            MessageBox.Show("Debe seleccionar el medio de pago", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtFormaPagoValor.EditValue <= 0 Then
            MessageBox.Show("Valor ingresado es incorrecto", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _DDetallePagoRecibo.Existe(_Id.ToString, cboFormaPago.GetColumnValue("ID")) Then
            MessageBox.Show("El medio de pago ya fue agregado", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetallePagoRecibo()
            ActualizarGrillaDetallePago()
            txtSon.Text = _funciones.Num2Text(Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)) & " PESOS M/CTE."
            LimpiarCamposDetallePagoRecibo()
        End If
    End Sub

    Private Sub btnEliminarFormaPago_Click(sender As Object, e As EventArgs) Handles btnEliminarFormaPago.Click
        If _ClickDetallePago = "" Then
            MessageBox.Show("Debe seleccionar el medio de pago a eliminar", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetallePagoRecibo.Eliminar(_ClickDetallePago)
            ActualizarGrillaDetallePago()
            _ClickDetallePago = Nothing
            txtSon.Text = _funciones.Num2Text(Val(colVALORDETALLEPAGO.SummaryItem.SummaryValue)) & " PESOS M/CTE."
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

    Private Sub GVConsultaCierre_RowClick(sender As Object, e As RowClickEventArgs) Handles GVConsultaCierre.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdCierre = GVConsultaCierre.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick

    End Sub
End Class
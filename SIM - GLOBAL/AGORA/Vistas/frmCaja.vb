Imports SIM___GLOBAL.Utilidades
Public Class frmCaja
    Public Licencia As String
    Public IdEmpleado As String
    Public IdOrden As String
    Public IdCliente As String
    Dim _Id As New Guid
    Dim _ds As DataSet
    Dim _dsMedioPago As DataSet
    Dim _Caja As New SIM___GLOBAL.Modelo.Caja
    Dim _DCaja As New SIM___GLOBAL.Controles.DCaja
    Dim _DClientes = New SIM___GLOBAL.Controles.DClientes
    Dim _DMedioPago As New SIM___GLOBAL.Controles.DMediosPago
    Dim _DOrdenServicio As New AGORA.Controles.DOrdenServicio
    Dim _CuentasClientes As New SIM___GLOBAL.Modelo.CuentasClientes
    Dim _DCuentasClientes As New SIM___GLOBAL.Controles.DCuentasClientes
    Dim _DDetallePagoRecibo As New SIM___GLOBAL.Controles.DDetallePagoRecibo
    Dim _DetallePagoRecibo As New SIM___GLOBAL.Modelo.DetallePagoRecibo
    Dim _DetalleCuentaCliente As New SIM___GLOBAL.Modelo.DetalleCuentaCliente
    Dim _DDetalleCuentaCliente As New SIM___GLOBAL.Controles.DDetalleCuentaCliente
    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
    Dim _ClickDetallePago As String
    Dim _ClickCuentasClientes As String
    Dim _ClickRecibo As String
    Dim _ClickRecibo2 As String
    Dim _ClickIdCierre As String
    Dim _ClickValorRecibo As Double
    Dim _ClickIdOrden As String
    Dim _ClickConsecutivo As String
    ReadOnly _funciones As New Funciones
    Dim _Fila As String
    Dim Saldo As Double
    Dim Estado As String

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
        GCDetallePagoDocumento.DataSource = Nothing
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

        _Caja.IdCliente = cboCliente.EditValue
        _DCaja.Guardar(_Caja)
    End Sub
    Private Sub LimpiarCamposDetallePagoRecibo()
        cboFormaPago.EditValue = Nothing
        txtFormaPagoValor.EditValue = Nothing
    End Sub
    Private Sub ActualizarGrillaDetallePago()
        'Listar los medios de pago del recibo actual
        _ds = _DDetallePagoRecibo.Listar(_Id.ToString)
        GCDetallePagoDocumento.DataSource = _ds.Tables(0)
    End Sub
    Private Sub GuardarDetallePagoRecibo()
        _DetallePagoRecibo.Id = Val("")
        _DetallePagoRecibo.IdRecibo = _Id.ToString
        _DetallePagoRecibo.IdMedioPago = cboFormaPago.GetColumnValue("ID")
        _DetallePagoRecibo.Valor = txtFormaPagoValor.EditValue
        _DDetallePagoRecibo.Guardar(_DetallePagoRecibo)
    End Sub
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub ListarComboClientes()
        ' Cargar Clientes
        _ds = New DataSet()
        _ds = _DClientes.listarcombo
        cboCliente.Properties.DataSource = _ds.Tables(0)
        cboCliente.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboCliente.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
    End Sub
    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _DCaja.Listar
        GCConsultar.DataSource = _ds.Tables(0)
        'txtSaldoActual.Text = colVALORP.SummaryItem.SummaryValue
    End Sub
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim _frmOpen As New SIM___GLOBAL.frmClientes
        _frmOpen.Licencia = Licencia
        _frmOpen.IdEmpleado = IdEmpleado
        _frmOpen.ShowDialog()
    End Sub

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarGrilla()

        dtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")

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

        If IdCliente <> "" Then
            cboCliente.EditValue = IdCliente
        End If

        txtCiudad.Text = "Cartagena"

        _Id = Guid.NewGuid()
        bbiGuardar.Enabled = False

    End Sub

    Private Sub cboCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cboCliente.EditValueChanged
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

    Private Sub gvCuentasClientes_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvCuentasClientes.RowClick
        If e.RowHandle >= 0 Then
            _ClickCuentasClientes = gvCuentasClientes.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            txtConsecutivo.Text = gvCuentasClientes.GetRowCellValue(e.RowHandle.ToString, "CONSECUTIVO").ToString()
            txtTipoDocumento.Text = gvCuentasClientes.GetRowCellValue(e.RowHandle.ToString, "DOCUMENTO").ToString()
            txtValor.Text = gvCuentasClientes.GetRowCellValue(e.RowHandle.ToString, "SALDO").ToString()
            _Fila = e.RowHandle.ToString
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
            ActivarGuardar()
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

        End If
    End Sub

    Private Sub gvDetallePagoDocumento_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvDetallePagoDocumento.RowClick
        If e.RowHandle >= 0 Then
            _ClickDetallePago = gvDetallePagoDocumento.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtConcepto.Text = "" Then
            MessageBox.Show("El campo concepto es obligatorio", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCiudad.Text = "" Then
            MessageBox.Show("El campo Ciudad es obligatorio", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf gvDetallePagoDocumento.RowCount = 0 Then
            MessageBox.Show("Falta detalle del recibo de caja", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtValor.EditValue <> 0 And (colVALORDETALLEPAGO.SummaryItem.SummaryValue > txtValor.EditValue) Then
            MessageBox.Show("El Saldo a cancelar no puede ser mayor al Saldo pendiente por el cliente. Por favor verifique", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If txtConsecutivo.Text = "" And gvCuentasClientes.RowCount > 0 Then
                If MessageBox.Show("El cliente presenta un saldo pendiente por pagar. Si lo guarda no se aplicara sobre la Orden de Servicio", "Guardar Recibo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    Guardar()
                    _DDetallePagoRecibo.ActualizarDetallePago(_Id.ToString)

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
            Else
                Guardar()
                _DDetallePagoRecibo.ActualizarDetallePago(_Id.ToString)

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

        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        LimpiarCampos()
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

    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        If _ClickRecibo2 = "" Then
            MessageBox.Show("Debe seleccionar el recibo a Imprimir", "Imprimir Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Estado = "ANULADO" Then
            MessageBox.Show("El recibo se encuentra anulado", "Imprimir Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ImprimirFrm.ImprimirReciboCaja(_ClickRecibo2, Licencia, 1)
        End If
    End Sub

    Private Sub txtConcepto_EditValueChanged(sender As Object, e As EventArgs) Handles txtConcepto.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub bbiAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAnular.ItemClick
        If _ClickRecibo2 = "" Then
            MessageBox.Show("Debe seleccionar el recibo a Anular", "Anular Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf _DCaja.ReciboRegistrado(_ClickRecibo2) = False Then
            'MessageBox.Show("Este recibo no se puede anular", "Registro de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("¿Desea anular el recibo?", "Anular Recibo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If _DCaja.ReciboRegistrado(_ClickRecibo2) = False Then
                    MessageBox.Show("Este recibo no se puede anular", "Anular Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    _DCaja.AnularRecibo(_ClickRecibo2)

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
                    'LimpiarCampos()
                    ActualizarGrilla()
                End If
            End If
        End If

    End Sub
End Class
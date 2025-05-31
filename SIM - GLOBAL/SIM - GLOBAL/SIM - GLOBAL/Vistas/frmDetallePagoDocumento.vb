Public Class frmDetallePagoDocumento
    Dim _ds As DataSet
    Dim _DMediosPago As New SIM___GLOBAL.Controles.DMediosPago
    Dim _DDetallePagoRecibo As New SIM___GLOBAL.Controles.DDetallePagoRecibo
    Dim _DetallePagoRecibo As New SIM___GLOBAL.Modelo.DetallePagoRecibo
    Dim _Id As New Guid
    Dim _ClickDetallePago As String
    Dim _Fila As String

    Private Sub ActualizarGrilla()
        'Listar los medios de pago del recibo actual
        _ds = _DDetallePagoRecibo.Listar(_Id.ToString)
        GCDetallePagoDocumento.DataSource = _ds.Tables(0)
    End Sub
    Private Sub LimpiarCampos()
        cboFormaPago.EditValue = Nothing
        txtValor.Text = ""
    End Sub
    Private Sub GuardarDetallePagoFactura()
        '_DetallePagoFactura.IdFactura = txtDocumento.Text
        '_DetallePagoFactura.IdMedioPago = cboFormaPago.GetColumnValue("ID")
        '_DetallePagoFactura.Valor = CDec(txtValor.Text)
        '_DDetallePagoFactura.GuardarDetallePagoFactura(_DetallePagoFactura)
    End Sub
    Private Sub GuardarDetallePagoRecibo()
        _DetallePagoRecibo.Id = Val("")
        _DetallePagoRecibo.IdRecibo = _Id.ToString
        _DetallePagoRecibo.IdMedioPago = cboFormaPago.GetColumnValue("ID")
        _DetallePagoRecibo.Valor = txtValor.Text
        _DDetallePagoRecibo.Guardar(_DetallePagoRecibo)
    End Sub
    Private Sub frmDetallePagoFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtValor.Text = txtValorDocumento.Text
        ' Cargar Medios de Pago
        _ds = _DMediosPago.ListarCombo
        cboFormaPago.Properties.DataSource = _ds.Tables(0)
        cboFormaPago.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboFormaPago.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboFormaPago.ItemIndex = -1

        ActualizarGrilla()
        _Id = Guid.NewGuid()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cboFormaPago.Text = "" Then
            MessageBox.Show("Debe seleccionar el medio de pago", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtValor.Text) <= 0 Then
            MessageBox.Show("Valor ingresado es incorrecto", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetallePagoRecibo()
            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub

    Private Sub frmDetallePagoDocumento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If gvDetallePagoDocumento.RowCount <> 0 Then
            If MessageBox.Show("Desea guardar y finalizar el recibo de caja", "Medio de Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                e.Cancel = False
                _DDetallePagoRecibo.EliminarDetalleRecibo(_Id.ToString)
            Else
                e.Cancel = True
                '_Id = Nothing
            End If

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickDetallePago = "" Then
            MessageBox.Show("Debe seleccionar el medio de pago a eliminar", "Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _DDetallePagoRecibo.Eliminar(_ClickDetallePago)
            ActualizarGrilla()
            LimpiarCampos()
            _ClickDetallePago = Nothing
        End If
    End Sub

    Private Sub gvDetallePagoDocumento_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvDetallePagoDocumento.RowClick
        If e.RowHandle >= 0 Then
            _ClickDetallePago = gvDetallePagoDocumento.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
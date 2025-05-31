Imports DevExpress.XtraGrid.Views.Grid

Public Class frmDetalleOrdenViejo
    Dim _dOrdenes = New SIM___GLOBAL.Controles.DOrdenes
    Dim _Ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    Dim _dDetalleOrden = New SIM___GLOBAL.Controles.DDetalleOrden
    Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
    Dim _DdetalleTarifa As New SIM___GLOBAL.Controles.DDetalleTarifas
    Dim _ds As DataSet
    Dim _ClickGrillaDetalleOrden As String
    Dim _Cambios As Byte
    Dim _Fila As Integer
    Dim FilaProcedimiento As Integer
    Dim _idTipoEstudio As String
    Dim _CodigoCups As String
    Dim _TipoAtencion As String
    Dim _IdContrato As String
    Private Sub LimpiarCamposDetalleOrden()
        cboProcedimientos.EditValue = Nothing
        'TRAER CONTRATO
        _Ordenes = _dOrdenes.Cargar(txtOrden.Text)
        Dim _DDetalleTarifa = New SIM___GLOBAL.Controles.DDetalleTarifas
        _ds = New DataSet()
        _ds = _DDetalleTarifa.ListarCombo2(_Ordenes.IdContrato)
        cboProcedimientos.Properties.DataSource = _ds.Tables(0)
        cboProcedimientos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboProcedimientos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        'cboProcedimiento.ItemIndex = -1

        txtCodigoProcedimiento.Text = ""
        txtValor.Text = ""
        txtCopago.Text = ""
        txtNeto.Text = ""
    End Sub
    Private Sub GuardarDetalleOrden()
        Try
            _DetalleOrden.IdOrden = txtOrden.Text
            _DetalleOrden.IdCausa = Val("15")
            _DetalleOrden.IdFinalidadConsulta = Val("10")
            _DetalleOrden.IdFinalidadProcedimiento = Val("1")
            _DetalleOrden.IdAmbito = Val("1")
            _DetalleOrden.IdPersonaAtiende = Val("1")
            '_DetalleOrden.FechaSalida = ""
            _DetalleOrden.Hora = DateTime.Now
            _DetalleOrden.IdTipoDiagnostico = Val("1")
            '_DetalleOrden.Diagnostico1 = ""
            '_DetalleOrden.Diagnostico2 = ""
            '_DetalleOrden.Diagnostico3 = ""
            '_DetalleOrden.Diagnostico4 = ""
            _DetalleOrden.IdFormaRealizacion = Val("1")
            _DetalleOrden.CodigoProcedimiento = txtCodigoProcedimiento.Text
            _DetalleOrden.CodigoCups = _CodigoCups
            _DetalleOrden.IdTipoEstudio = _idTipoEstudio 'cboProcedimiento.EditValue
            _DetalleOrden.Valor = Val(txtValor.EditValue)
            _DetalleOrden.Copago = Val(txtCopago.EditValue)
            _DetalleOrden.Neto = Val(txtNeto.EditValue)
            _DetalleOrden.Tipo = _TipoAtencion
            _DetalleOrden.Estado = "PENDIENTE"
            _dDetalleOrden.GuardarDetalleOrden(_DetalleOrden)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " Guardar Detalle de Orden")
        End Try
    End Sub
    Private Sub ActualizarGrillaDetalleOrden()
        'LLENAR GRID VIEW 
        _ds = New DataSet
        _ds = _dDetalleOrden.Listar(txtOrden.Text)
        GCDetalleOrden.DataSource = _ds.Tables(0)
        'GVDetalleOrden.Columns(0).Visible = False
        'GVDetalleOrden.Columns(1).BestFit()
        'GVDetalleOrden.Columns(2).BestFit()
        'GVDetalleOrden.Columns(3).BestFit()
        '----------------------------------
    End Sub
    Private Sub frmDetalleOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Formulario Detalle Orden")
        'TRAER CONTRATO
        _Ordenes = _dOrdenes.Cargar(txtOrden.Text)
        _IdContrato = _Ordenes.IdContrato
        Dim _DDetalleTarifa = New SIM___GLOBAL.Controles.DDetalleTarifas
        _ds = New DataSet()
        _ds = _DDetalleTarifa.ListarCombo2(_Ordenes.IdContrato)

        cboProcedimientos.Properties.DataSource = _ds.Tables(0)
        cboProcedimientos.Properties.DisplayMember = _ds.Tables(0).Columns(3).Caption
        cboProcedimientos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        ActualizarGrillaDetalleOrden()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCodigoProcedimiento.Text = "" Then
            MessageBox.Show("Debe Seleccionar el Procedimiento a realizar", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (Val(txtValor.EditValue) - Val(txtCopago.EditValue)) < 0 Then
            MessageBox.Show("Verificar el Valor en Neto, No debe ser Negativo", "Registro de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GuardarDetalleOrden()
            ActualizarGrillaDetalleOrden()
            LimpiarCamposDetalleOrden()
        End If
    End Sub

    Private Sub cboProcedimiento_EditValueChanged(sender As Object, e As EventArgs)
        'txtCodigoProcedimiento.Text = cboProcedimientos.GetColumnValue("CODIGO")
        'txtValor.Text = cboProcedimientos.GetColumnValue("VALOR")
        'txtCodigoProcedimiento.Text=cboGVProcedimientos

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _ClickGrillaDetalleOrden = "" Then
            MessageBox.Show("Debe seleccionar un registro", "Registro de Detalle Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _dDetalleOrden.Eliminar(_ClickGrillaDetalleOrden)
            ActualizarGrillaDetalleOrden()
            _ClickGrillaDetalleOrden = ""

        End If
    End Sub

    Private Sub GVDetalleOrden_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVDetalleOrden.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaDetalleOrden = GVDetalleOrden.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub frmDetalleOrden_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.Cancel = False Then
            'MsgBox("hola")
        End If
    End Sub

    Private Sub cboProcedimientos_EditValueChanged(sender As Object, e As EventArgs) Handles cboProcedimientos.EditValueChanged
        If _IdContrato <> "" Then
            _ds = New DataSet
            _ds = _DdetalleTarifa.ListarValor(_Ordenes.IdContrato, cboProcedimientos.EditValue)

            txtCodigoProcedimiento.Text = _ds.Tables(0).Rows(0)(0).ToString
            _idTipoEstudio = _ds.Tables(0).Rows(0)(1).ToString
            txtValor.Text = _ds.Tables(0).Rows(0)(2).ToString
            _CodigoCups = _ds.Tables(0).Rows(0)(3).ToString
            _TipoAtencion = _ds.Tables(0).Rows(0)(4).ToString
        End If
    End Sub

End Class
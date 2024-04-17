Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo
'import para validar
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
'*************************************
Public Class frmListadoOrdenes
    Dim _ClickGrilla As String
    Dim _ClickGrillaF As String
    Dim _Fila As String
    Dim _ds As DataSet
    Dim _dOrdenes As New DOrdenes

    ReadOnly _contratos As New DContratos
    ReadOnly _dDetalletarifa = New DDetalleTarifas

    Public Sub Recargar()
        'llenamos Grilla Ordenes Atendidas
        _ds = New DataSet
        _ds.Tables.Add(_dOrdenes.ListadoOrdenesEndoscopia)
        GCOrdenesAtendidas.DataSource = _ds.Tables(0)
        'llenamos Grilla Ordenes A Facturar
        _ds = New DataSet
        _ds.Tables.Add(_dOrdenes.OrdenesFacturarEndoscopia)
        GCOrdenesFacturar.DataSource = _ds.Tables(0)
    End Sub

    Private Sub frmListadoOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Recargar()
    End Sub

    Private Sub bbConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbConsultar.ItemClick
        If GVOrdenesAtendidas.OptionsFind.AlwaysVisible = True Then
            GVOrdenesAtendidas.OptionsFind.AlwaysVisible = False
            GVOrdenesFacturar.OptionsFind.AlwaysVisible = False
        Else
            GVOrdenesAtendidas.OptionsFind.AlwaysVisible = True
            GVOrdenesFacturar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAgregar.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("Debe Seleccionar una Orden a Agregar al Listado a Facturar", "ORDEN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _dOrdenes As New DOrdenes
            _dOrdenes.AgregarOrdenes(_ClickGrilla, "1")
            'TODO: esta línea de código carga datos en la tabla 'DSVistas.DTOrdenesAtendidas' Puede moverla o quitarla según sea necesario.
            ' Me.DTOrdenesAtendidasTableAdapter.Fill(Me.DSVistas.DTOrdenesAtendidas)
            'TODO: esta línea de código carga datos en la tabla 'DSVistas.DTOrdenesFacturar' Puede moverla o quitarla según sea necesario.
            ' Me.DTOrdenesFacturarTableAdapter.Fill(Me.DSVistas.DTOrdenesFacturar)
            _ClickGrilla = ""
            Recargar()
        End If

    End Sub

    Private Sub bbiEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        If _ClickGrillaF = "" Then
            MessageBox.Show("Debe Seleccionar una Orden a Agregar al Listado a Facturar", "ORDEN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _dOrdenes As New DOrdenes
            _dOrdenes.AgregarOrdenes(_ClickGrillaF, "0")
            'TODO: esta línea de código carga datos en la tabla 'DSVistas.DTOrdenesAtendidas' Puede moverla o quitarla según sea necesario.
            ' Me.DTOrdenesAtendidasTableAdapter.Fill(Me.DSVistas.DTOrdenesAtendidas)
            'TODO: esta línea de código carga datos en la tabla 'DSVistas.DTOrdenesFacturar' Puede moverla o quitarla según sea necesario.
            ' Me.DTOrdenesFacturarTableAdapter.Fill(Me.DSVistas.DTOrdenesFacturar)
            _ClickGrillaF = ""
            Recargar()
        End If
    End Sub

    Private Sub GVOrdenesAtendidas_RowClick(sender As Object, e As RowClickEventArgs) Handles GVOrdenesAtendidas.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVOrdenesAtendidas.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If

    End Sub

    Private Sub GVOrdenesFacturar_RowClick(sender As Object, e As RowClickEventArgs) Handles GVOrdenesFacturar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaF = GVOrdenesFacturar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub bbiDetalleOrden_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDetalleOrden.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("Debe Seleccionar una Orden a Editar", "DETALLE DE ORDEN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _frmOpen As New frmDetalleOrden
            'Enviamos Valores a DEtalle Orden
            _frmOpen.txtOrden.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "ID").ToString()
            _frmOpen.deFechaIngreso.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "FECHA_INGRESO").ToString()
            _frmOpen.txtIdentificacion.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "IDENTIFICACION").ToString()
            _frmOpen.txtPaciente.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "PACIENTE").ToString()
            _frmOpen.txtContrato.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "CONTRATO").ToString()
            _frmOpen.txtEntidad.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "ENTIDAD").ToString()
            _frmOpen.deFechaOrden.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "FECHA_ORDEN").ToString()
            _frmOpen.txtNumeroOrden.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "NUMERO_ORDEN").ToString()
            _frmOpen.txtAutorizacion.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "AUTORIZACION").ToString()
            '_frmOpen.cboSubentidad.Text = GVOrdenesAtendidas.GetRowCellValue(_Fila, "SUBENTIDAD").ToString()
            'MsgBox(GVOrdenesAtendidas.GetRowCellValue(_Fila, "SUBENTIDAD").ToString())
            _frmOpen.ShowDialog()
            Recargar()
        End If
    End Sub

    Private Sub bbiAgregarTodo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAgregarTodo.ItemClick
        If GVOrdenesAtendidas.DataRowCount = 0 Then
            MessageBox.Show("No hay Ordenes a Agregar", "Ordenes a Facturar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea Agregar los Registros Seleccionados?", "Agregar Registros a Facturar",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                _Fila = 0
                While _Fila < GVOrdenesAtendidas.DataRowCount
                    _dOrdenes.AgregarOrdenes(GVOrdenesAtendidas.GetRowCellValue(_Fila, "ID").ToString(), "1")
                    _Fila = _Fila + 1
                End While
                Recargar()
            End If
        End If



    End Sub

    Private Sub bbiEliminarTodo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminarTodo.ItemClick
        If GVOrdenesFacturar.DataRowCount = 0 Then
            MessageBox.Show("No hay Ordenes a Eliminar", "Ordenes a Facturar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Desea Eliminar los Registros Seleccionados?", "Eliminar Registros a Facturar",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
                _Fila = 0
                While _Fila < GVOrdenesFacturar.DataRowCount
                    _dOrdenes.AgregarOrdenes(GVOrdenesFacturar.GetRowCellValue(_Fila, "ID").ToString(), "0")
                    _Fila = _Fila + 1
                End While
                Recargar()
            End If
        End If

    End Sub

    Private Sub bbiActualizarGrilla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizarGrilla.ItemClick
        Recargar()
    End Sub
End Class
Imports SIM___GLOBAL.Utilidades

Public Class frmHistoriasAnteriores
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Registro As String
    Public _IDEmpleado As Integer
    Dim _Fila As String
    ReadOnly _funciones As New Funciones
    Dim _dHistoriaClinica As New SIM___GLOBAL.Controles.DHistoriaClinica
    Private Sub frmHistoriasAnteriores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSVistas.DTHistoriasAnteriores' Puede moverla o quitarla según sea necesario.
        'Me.DTHistoriasAnterioresTableAdapter.Fill(Me.DSVistas.DTHistoriasAnteriores)
        _ds = New DataSet
        _ds = _dHistoriaClinica.HistoriasAnterioresMartinez
        GCHistoriasAnteriores.DataSource = _ds.Tables(0)


    End Sub

    Private Sub GCHistoriasAnteriores_Click(sender As Object, e As EventArgs) Handles GCHistoriasAnteriores.Click

    End Sub

    Private Sub bbiMedicamentos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiMedicamentos.ItemClick
        If _ClickGrilla <> "" Then
            Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
            Dim _dImpresionHistoria As New SIM___GLOBAL.Controles.DImpresionHistoria
            Dim _dImpresionDetalleHistoria As New SIM___GLOBAL.Controles.DImpresionDetalleHistoria
            ImprimirFrm = New SIM___GLOBAL.frmImprimir
            _funciones.ImprimirHistoria(_Registro, _IDEmpleado)
            '_funciones.ImprimirDetalleHistoria(_ClickGrilla, _IDEmpleado, "M")
            ImprimirFrm.CargarReporte("medicamentos.rpt", _Registro)
            _dImpresionHistoria.EliminarHistoria(_IDEmpleado)
            _dImpresionDetalleHistoria.EliminarDetalleHistoria(_IDEmpleado)
        End If
        'If _ClickGrilla <> "" Then
        ' Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        ' ImprimirFrm.CargarReporte("medicamentos.rpt", _ClickGrilla)
        ' End If
    End Sub



    Private Sub bbiLaboratorios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLaboratorios.ItemClick
        If _ClickGrilla <> "" Then
            Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
            Dim _dImpresionHistoria As New SIM___GLOBAL.Controles.DImpresionHistoria
            Dim _dImpresionDetalleHistoria As New SIM___GLOBAL.Controles.DImpresionDetalleHistoria
            ImprimirFrm = New SIM___GLOBAL.frmImprimir
            _funciones.ImprimirHistoria(_Registro, _IDEmpleado)
            '_funciones.ImprimirDetalleHistoria(_ClickGrilla, _IDEmpleado, "L")
            ImprimirFrm.CargarReporte("examenes_laboratorios.rpt", _Registro)
            _dImpresionHistoria.EliminarHistoria(_IDEmpleado)
            _dImpresionDetalleHistoria.EliminarDetalleHistoria(_IDEmpleado)
        End If
        'If Registro <> "" Then


        '
        '        ImprimirFrm.CargarReporte("historia_martinez.rpt", Registro)
        '        _dImpresionHistoria.EliminarHistoria(Registro, IdEmpleado)
        '        Else
        '        MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If
    End Sub

    Private Sub bbiImagenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImagenes.ItemClick
        If _ClickGrilla <> "" Then
            Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
            Dim _dImpresionHistoria As New SIM___GLOBAL.Controles.DImpresionHistoria
            Dim _dImpresionDetalleHistoria As New SIM___GLOBAL.Controles.DImpresionDetalleHistoria
            ImprimirFrm = New SIM___GLOBAL.frmImprimir
            _funciones.ImprimirHistoria(_Registro, _IDEmpleado)
            '_funciones.ImprimirDetalleHistoria(_ClickGrilla, _IDEmpleado, "O")
            ImprimirFrm.CargarReporte("imagenes.rpt", _Registro)
            _dImpresionHistoria.EliminarHistoria(_IDEmpleado)
            _dImpresionDetalleHistoria.EliminarDetalleHistoria(_IDEmpleado)
        End If
        'If _ClickGrilla <> "" Then
        ' Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        ' ImprimirFrm.CargarReporte("procedimientos.rpt", _ClickGrilla)
        ' End If
    End Sub

    Private Sub GVHistoriasAnteriores_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVHistoriasAnteriores.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVHistoriasAnteriores.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _Registro = GVHistoriasAnteriores.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub
End Class
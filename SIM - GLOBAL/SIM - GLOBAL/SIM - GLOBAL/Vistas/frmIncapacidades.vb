Imports SIM___GLOBAL.Controles
Public Class frmIncapacidades
    Public Licencia As String
    Public IdOrden As String
    Public IdDetalleOrden As String
    Dim _DOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _DUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    Dim _Incapacidades As New SIM___GLOBAL.Modelo.Incapacidades
    Dim _DIncapacidades As New SIM___GLOBAL.Controles.DIncapacidades
    Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
    Dim IdUsuario As String
    Dim Dias As Long
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Private Sub ActualizarGrilla()
        _ds = _DIncapacidades.Listar
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub Guardar()
        _Incapacidades.Id = Val("")
        _Incapacidades.IdOrden = IdOrden
        _Incapacidades.IdDetalleOrden = IdDetalleOrden
        _Incapacidades.TipoIncapacidad = cboTipoIncapacidad.Text
        _Incapacidades.FechaInicial = dtFechaInicial.Text
        _Incapacidades.FechaFinal = dtFechaFinal.Text
        _Incapacidades.Nota = txtDescripcion.Text
        _Incapacidades.Diagnostico = txtDiagnostico.Text
        _DIncapacidades.Guardar(_Incapacidades)
        bbiGuardar.Enabled = False
    End Sub
    Private Sub LimpiarCampos()
        GCDatosUsuarios.DataSource = Nothing
        txtOrden.Text = Nothing

    End Sub
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub frmIncapacidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        xtpIncapacidades.Show()
        IdUsuario = _DOrdenes.CargarIDUsuario(IdOrden)
        _ds = New DataSet
        _ds = _DUsuarios.DatosUsuarioCARD(IdUsuario)
        GCDatosUsuarios.DataSource = _ds.Tables(0)

        If _DIncapacidades.Existe(IdOrden) = True Then
            _Incapacidades = _DIncapacidades.Cargar(IdOrden)
            txtOrden.Text = _Incapacidades.IdOrden
            cboTipoIncapacidad.Text = _Incapacidades.TipoIncapacidad
            dtFechaInicial.Text = _Incapacidades.FechaInicial
            dtFechaFinal.Text = _Incapacidades.FechaFinal
            txtDescripcion.Text = _Incapacidades.Nota
            txtDiagnostico.Text = _Incapacidades.Diagnostico
        Else
            txtOrden.Text = IdOrden
            cboTipoIncapacidad.SelectedIndex = 0
            dtFechaInicial.Text = Format(DateTime.Now, "dd/MM/yyyy")
            dtFechaFinal.Text = Format(DateTime.Now, "dd/MM/yyyy")
            If _DOrdenes.ExisteDiagnostico(IdOrden) = True Then
                txtDiagnostico.Text = _DOrdenes.Diagnostico(IdOrden)
            End If
        End If
        ActualizarGrilla()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If dtFechaInicial.Text = "" Then
            MessageBox.Show("El Campo Fecha Inicial es Obligatorio", "Registro de Incapacidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaFinal.Text = "" Then
            MessageBox.Show("El Campo Fecha Final es Obligatorio", "Registro de Incapacidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtDiagnostico.Text = "" Then
            MessageBox.Show("El Campo Diagnostico es Obligatorio", "Registro de Incapacidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()
            ActualizarGrilla()
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub dtFechaInicial_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaInicial.EditValueChanged
        ActivarGuardar()
        'txtDias.Text = "2021/03/17" - "2021/04/15"
    End Sub

    Private Sub dtFechaFinal_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaFinal.EditValueChanged
        ActivarGuardar()
        'txtDias.Text = DateDiff(DateInterval.Day, CDate(Format(dtFechaInicial.Text, "dd/MM/yyyy")), CDate(Format(dtFechaFinal.Text, "dd/MM/yyyy")))
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
        End If
    End Sub

    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        If _ClickGrilla <> Nothing Then
            ImprimirFrm.ImprimirIncapacidad(_ClickGrilla)
        Else
            MessageBox.Show("Debe Seleccionar una Incapacidad", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cboTipoIncapacidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoIncapacidad.SelectedIndexChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDescripcion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescripcion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDiagnostico_EditValueChanged(sender As Object, e As EventArgs) Handles txtDiagnostico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickGrilla <> Nothing Then

            IdUsuario = _DOrdenes.CargarIDUsuario(_ClickGrilla)
            _ds = New DataSet
            _ds = _DUsuarios.DatosUsuarioCARD(IdUsuario)
            GCDatosUsuarios.DataSource = _ds.Tables(0)

            _Incapacidades = _DIncapacidades.Cargar(_ClickGrilla)
            txtOrden.Text = _Incapacidades.IdOrden
            cboTipoIncapacidad.Text = _Incapacidades.TipoIncapacidad
            dtFechaInicial.Text = _Incapacidades.FechaInicial
            dtFechaFinal.Text = _Incapacidades.FechaFinal
            txtDescripcion.Text = _Incapacidades.Nota
            txtDiagnostico.Text = _Incapacidades.Diagnostico
            xtpIncapacidades.Show()
        Else
            MessageBox.Show("Debe Seleccionar una Incapacidad", "Editar Incapacidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
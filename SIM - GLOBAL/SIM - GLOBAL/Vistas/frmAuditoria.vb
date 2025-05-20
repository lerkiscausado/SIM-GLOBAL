Public Class frmAuditoria
    Public Licencia As String
    Public IdEmpleado As String

    Dim _ds As DataSet
    Dim _dUsuarios = New SIM___GLOBAL.Controles.DUsuarios
    Dim _DOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _dAuditoria As New SIM___GLOBAL.Controles.DAuditoria
    Dim _usuarios As New SIM___GLOBAL.Modelo.Usuarios
    ReadOnly _tipoIdentificacion = New SIM___GLOBAL.Controles.DTipoIdentificacion
    Dim _ClickGrillaUsuario As String
    Dim _ClickGrillaUsuarioEstudio As String
    Dim _ClickGrillaOrden As String
    Dim _ClickGrillaDetalleOrden As String
    Dim _ClickEstudio As String
    Dim _ClickGrillaRegistros As String
    Dim _ClickGrillaTabla As String
    Dim _Fila As Integer
    Dim _frmOpen As New SIM___GLOBAL.frmConfirmarAuditoria

    Private Sub LimpiarCampos()
        txtNumeroIdentificacion.Text = Nothing
        txtConcepto.Text = Nothing
        _ClickGrillaUsuario = Nothing
        txtEstudio.Text = Nothing
        txtConceptoEstudio.Text = Nothing
        chkEstado.Checked = False
        GCDatosUsuarios.DataSource = _ds.Tables(0)
        GCUsuarioEstudios.DataSource = _ds.Tables(0)
        ActualizarGrillaUsuarios()
        ActualizarGrilla()
    End Sub
    Private Sub ActualizarGrillaUsuarios()
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _dUsuarios.ListarUltimosRegistros()
        GCUsuarios.DataSource = _ds.Tables(0)
    End Sub
    Public Sub ListarGrillaOrdenes(ByVal Ano As String)
        Try
            Select Case Licencia
                Case 11
                    colORDEN.Visible = False
                    colCONSECUTIVO.Visible = True
                Case 15 ' freisem
                Case Else
                    colORDEN.Visible = True
                    colCONSECUTIVO.Visible = False


            End Select
            Dim _ds = New DataSet
            _ds = _DOrdenes.OrdenesxAnoAtendidos(Ano)
            GCEstudios.DataSource = _ds.Tables(0)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ActualizarGrilla()
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _dAuditoria.Listar()
        GCAuditoria.DataSource = _ds.Tables(0)
    End Sub
    Private Sub frmAuditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
        'llamamos listar usuarios
        ActualizarGrillaUsuarios()

        'Listamos las ordenes del año actual
        ListarGrillaOrdenes(Year(Now))

        'llenamos campo tipo identificacion
        _ds = New DataSet()
        _ds = _tipoIdentificacion.listar()
        cboTipoIdentificacion.Properties.DataSource = _ds.Tables(0)
        cboTipoIdentificacion.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoIdentificacion.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoIdentificacion.ItemIndex = 0

        'Listamos los registros realizados por todos los usuarios en el sistema
        If _dAuditoria.MostrarRegistros(IdEmpleado) = True Then
            'LLENAR GRILLA  
            _ds = New DataSet
            _ds = _dAuditoria.ListarUltimosRegistros()
            gcRegistros.DataSource = _ds.Tables(0)
            xtpRegistros.PageVisible = True
        Else
            xtpRegistros.PageVisible = False
        End If
    End Sub

    Private Sub GVUsuarios_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVUsuarios.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaUsuario = GVUsuarios.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
            'cargamos datos de usuario
            txtNumeroIdentificacion.Text = GVUsuarios.GetRowCellValue(e.RowHandle.ToString, "IDENTIFICACION").ToString()
            cboTipoIdentificacion.EditValue = GVUsuarios.GetRowCellValue(e.RowHandle.ToString, "TI").ToString()
            _ds = New DataSet
            _ds = _dUsuarios.DatosUsuarioCARD(_ClickGrillaUsuario)
            GCDatosUsuarios.DataSource = _ds.Tables(0)
        End If
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVUsuarios.OptionsFind.AlwaysVisible = True Then
            GVUsuarios.OptionsFind.AlwaysVisible = False
        Else
            GVUsuarios.OptionsFind.AlwaysVisible = True
        End If
        If GVAuditoria.OptionsFind.AlwaysVisible = True Then
            GVAuditoria.OptionsFind.AlwaysVisible = False
        Else
            GVAuditoria.OptionsFind.AlwaysVisible = True
        End If
        If GVEstudios.OptionsFind.AlwaysVisible = True Then
            GVEstudios.OptionsFind.AlwaysVisible = False
        Else
            GVEstudios.OptionsFind.AlwaysVisible = True
        End If
        If gvRegistros.OptionsFind.AlwaysVisible = True Then
            gvRegistros.OptionsFind.AlwaysVisible = False
        Else
            gvRegistros.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        Select Case xtcAuditoria.SelectedTabPageIndex
            Case 0
            Case 1
                If _ClickGrillaUsuario = "" Then
                    MessageBox.Show("No ha seleccionado el paciente", "Registro de Auditoria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf txtNumeroIdentificacion.Text = "" Then
                    MessageBox.Show("El Numero de Identificacion es Obligatorio", "Registro de Auditoria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf cboTipoIdentificacion.EditValue = Nothing Then
                    MessageBox.Show("No ha seleccionado el Tipo de Identificacion", "Registro de Auditoria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf txtConcepto.Text = "" Then
                    MessageBox.Show("El Concepto es Obligatorio", "Registro de Auditoria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    _frmOpen.Licencia = Licencia
                    _frmOpen.IdEmpleado = IdEmpleado
                    _frmOpen.IdUsuario = _ClickGrillaUsuario
                    _frmOpen.TipoIdentificacion = cboTipoIdentificacion.EditValue
                    _frmOpen.Identificacion = txtNumeroIdentificacion.Text
                    _frmOpen.Concepto = txtConcepto.Text
                    _frmOpen.Formulario = "USUARIO"
                    _frmOpen.ShowDialog()
                    LimpiarCampos()
                End If
            Case 2
                If _ClickGrillaDetalleOrden = "" Then
                    MessageBox.Show("No ha seleccionado la Orden", "Registro de Auditoria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf txtConceptoESTUDIO.Text = "" Then
                    MessageBox.Show("El Concepto es Obligatorio", "Registro de Auditoria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf chkEstado.Checked = True Then
                    MessageBox.Show("Debe desmarcar la firma para desautorizar el estudio", "Registro de Auditoria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    _frmOpen.Licencia = Licencia
                    _frmOpen.IdEmpleado = IdEmpleado
                    _frmOpen.IdOrden = _ClickGrillaOrden
                    _frmOpen.IdDetalleOrden = _ClickGrillaDetalleOrden
                    _frmOpen.Concepto = txtConceptoEstudio.Text
                    _frmOpen.Formulario = "ESTUDIOS"
                    _frmOpen.ShowDialog()
                    LimpiarCampos()
                    ListarGrillaOrdenes("2021")
                End If
        End Select

    End Sub

    Private Sub tsmExportarExcel_Click(sender As Object, e As EventArgs) Handles tsmExportarExcel.Click
        sfdRuta.Filter = "Archivo Excel |*.xls"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCEstudios.ExportToXls(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmExportarPDF_Click(sender As Object, e As EventArgs) Handles tsmExportarPDF.Click
        sfdRuta.Filter = "Archivo PDF |*.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCEstudios.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmImprimir_Click(sender As Object, e As EventArgs) Handles tsmImprimir.Click
        GCEstudios.PrintDialog()
    End Sub

    Private Sub tsm2020_Click(sender As Object, e As EventArgs) Handles tsm2020.Click
        ListarGrillaOrdenes("2020")
    End Sub

    Private Sub tsmActualizarVista_Click(sender As Object, e As EventArgs) Handles tsmActualizarVista.Click
        ListarGrillaOrdenes(Year(Now))
    End Sub

    Private Sub tsm2019_Click(sender As Object, e As EventArgs) Handles tsm2019.Click
        ListarGrillaOrdenes("2019")
    End Sub

    Private Sub tsm2018_Click(sender As Object, e As EventArgs) Handles tsm2018.Click
        ListarGrillaOrdenes("2018")
    End Sub

    Private Sub tsm2017_Click(sender As Object, e As EventArgs) Handles tsm2017.Click
        ListarGrillaOrdenes("2017")
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVEstudios.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaDetalleOrden = GVEstudios.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _ClickGrillaOrden = GVEstudios.GetRowCellValue(e.RowHandle.ToString, "ORDEN").ToString()
            _ClickGrillaUsuarioEstudio = GVEstudios.GetRowCellValue(e.RowHandle.ToString, "IDUSUARIO").ToString()
            txtEstudio.Text = GVEstudios.GetRowCellValue(e.RowHandle.ToString, "CUPS").ToString
            _ClickEstudio = GVEstudios.GetRowCellValue(e.RowHandle.ToString, "ESTUDIO").ToString
            chkEstado.Checked = True
            _Fila = e.RowHandle.ToString

            'cargamos datos de usuario

            _ds = New DataSet
            _ds = _dUsuarios.DatosUsuarioCARD(_ClickGrillaUsuarioEstudio)
            GCUsuarioEstudios.DataSource = _ds.Tables(0)
        End If
    End Sub

    Private Sub btVistaPrevia_Click(sender As Object, e As EventArgs) Handles btVistaPrevia.Click
        If txtEstudio.Text <> Nothing Then
            Dim _frmOpen As New SIM___GLOBAL.frmVistaHistoria
            _frmOpen.IdDetalleOrden = _ClickGrillaDetalleOrden 'Registro
            _frmOpen.Licencia = Licencia
            _frmOpen.Estudio = _ClickEstudio
            _frmOpen.ShowDialog()
        Else
            MessageBox.Show("Debe Seleccionar un Estudio o Historia", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AñoActualToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsm2021_Click(sender As Object, e As EventArgs) Handles tsm2021.Click
        ListarGrillaOrdenes("2021")
    End Sub

    Private Sub gvRegistros_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvRegistros.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrillaRegistros = gvRegistros.GetRowCellValue(e.RowHandle.ToString, "REGISTRO").ToString()
            _ClickGrillaTabla = gvRegistros.GetRowCellValue(e.RowHandle.ToString, "TABLA").ToString()
            _Fila = e.RowHandle.ToString
            gcDetalleRegistro.DataSource = Nothing
            gvDetalleRegistro.Columns.Clear()
            'Mostramos registro seleccionado
            Select Case _ClickGrillaTabla
                Case "USUARIOS"
                    _ds = New DataSet
                    _ds = _dAuditoria.MostrarUsuario(_ClickGrillaRegistros)
                    gcDetalleRegistro.DataSource = _ds.Tables(0)
                Case "ORDENES"
                    _ds = New DataSet
                    _ds = _dAuditoria.MostrarOrden(_ClickGrillaRegistros)
                    gcDetalleRegistro.DataSource = _ds.Tables(0)
            End Select

        End If
    End Sub

    Private Sub tsmActual_Click(sender As Object, e As EventArgs) Handles tsmActual.Click
        ListarGrillaOrdenes(Year(Now))
    End Sub

    Private Sub tsmActualizarListado_Click(sender As Object, e As EventArgs) Handles tsmActualizarListado.Click
        ActualizarGrillaUsuarios()
    End Sub

    Private Sub tsmTodoslosRegistros_Click(sender As Object, e As EventArgs) Handles tsmTodoslosRegistros.Click
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _dUsuarios.Listar()
        GCUsuarios.DataSource = _ds.Tables(0)
    End Sub

    Private Sub tsmActualizarListadoRegistros_Click(sender As Object, e As EventArgs) Handles tsmActualizarListadoRegistros.Click
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _dAuditoria.ListarUltimosRegistros()
        gcRegistros.DataSource = _ds.Tables(0)
    End Sub

    Private Sub tsmMostrarTodosRegistros_Click(sender As Object, e As EventArgs) Handles tsmMostrarTodosRegistros.Click
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _dAuditoria.ListarRegistros()
        gcRegistros.DataSource = _ds.Tables(0)
    End Sub

    Private Sub tsm2022_Click(sender As Object, e As EventArgs) Handles tsm2022.Click
        ListarGrillaOrdenes("2022")
    End Sub

    Private Sub tsm2023_Click(sender As Object, e As EventArgs) Handles tsm2023.Click
        ListarGrillaOrdenes("2023")
    End Sub

    Private Sub tsm2024_Click(sender As Object, e As EventArgs) Handles tsm2024.Click
        ListarGrillaOrdenes("2024")
    End Sub
End Class
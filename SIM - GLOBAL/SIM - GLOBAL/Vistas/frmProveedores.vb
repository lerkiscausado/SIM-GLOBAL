Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Imports DevExpress.XtraPrinting
Public Class frmProveedores
    Public Licencia As String
    Public IdEmpleado As String
    Dim _ds As DataSet
    Dim _ClickIdProveedor As String
    Dim _Fila As String
    Dim _Proveedores As New SIM___GLOBAL.Modelo.Proveedores
    Dim _DProveedores As New SIM___GLOBAL.Controles.DProveedores
    ReadOnly _tipoIdentificacion As New DTipoIdentificacion
    Private Sub LimpiarCampos()
        _ClickIdProveedor = Nothing
        txtCodigo.Text = Nothing
        cboTipoIdentificacion.EditValue = Nothing
        txtNumeroIdentificacion.Text = Nothing
        txtNombre.Text = Nothing
        txtContacto.Text = Nothing
        txtDireccion.Text = Nothing
        txtTelefono.Text = Nothing
        txtCorreoElectronico.Text = Nothing
        chkEstado.Checked = True
        cboTipoIdentificacion.Enabled = True
        txtNumeroIdentificacion.Enabled = True
        bbiGuardar.Enabled = False
    End Sub
    Private Sub ActualizarGrilla()
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _DProveedores.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub Guardar()
        _Proveedores.Id = Val(txtCodigo.Text)
        _Proveedores.IdTipoIdentificacion = cboTipoIdentificacion.GetColumnValue("CODIGO")
        _Proveedores.Identificacion = txtNumeroIdentificacion.Text
        _Proveedores.Nombre = txtNombre.Text
        _Proveedores.Contacto = txtContacto.Text
        _Proveedores.Direccion = txtDireccion.Text
        _Proveedores.Telefono = txtTelefono.Text
        _Proveedores.CorreoElectronico = txtCorreoElectronico.Text
        If chkEstado.Checked = True Then
            _Proveedores.Estado = "A"
        Else
            _Proveedores.Estado = "I"
        End If
        _DProveedores.Guardar(_Proveedores)
    End Sub
    Private Sub EditarProveedor()
        _Proveedores = _DProveedores.Cargar(_ClickIdProveedor)
        txtCodigo.Text = _Proveedores.Id
        cboTipoIdentificacion.ItemIndex = cboTipoIdentificacion.Properties.GetDataSourceRowIndex("CODIGO", _Proveedores.IdTipoIdentificacion)
        txtNumeroIdentificacion.Text = _Proveedores.Identificacion
        txtNombre.Text = _Proveedores.Nombre
        txtDireccion.Text = _Proveedores.Direccion
        txtTelefono.Text = _Proveedores.Telefono
        txtCorreoElectronico.Text = _Proveedores.CorreoElectronico
        txtContacto.Text = _Proveedores.Contacto

        If _Proveedores.Estado = "A" Then
            chkEstado.Checked = True
        Else
            chkEstado.Checked = False
        End If

        cboTipoIdentificacion.Enabled = False
        txtNumeroIdentificacion.Enabled = False
        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVConsultar.OptionsFind.AlwaysVisible = True Then
            GVConsultar.OptionsFind.AlwaysVisible = False
        Else
            GVConsultar.OptionsFind.AlwaysVisible = True
        End If
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If txtNumeroIdentificacion.Text = "" Then
            MessageBox.Show("El Campo Identificación es Obligatorio", "Registro de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtNombre.Text = "" Then
            MessageBox.Show("El Campo Razon Social es Obligatorio", "Registro de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Guardar()

            'llenamos la grilla de registros
            ActualizarGrilla()
            LimpiarCampos()
        End If
    End Sub

    Private Sub cboTipoIdentificacion_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoIdentificacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtNumeroIdentificacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtNumeroIdentificacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtNombre_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtContacto_EditValueChanged(sender As Object, e As EventArgs) Handles txtContacto.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtDireccion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDireccion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtTelefono_EditValueChanged(sender As Object, e As EventArgs) Handles txtTelefono.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtCorreoElectronico_EditValueChanged(sender As Object, e As EventArgs) Handles txtCorreoElectronico.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        ActivarGuardar()
    End Sub

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarGrilla()

        'llenamos campo tipo identificacion
        _ds = New DataSet()
        _ds = _tipoIdentificacion.Listar()
        'MsgBox("Hola")
        cboTipoIdentificacion.Properties.DataSource = _ds.Tables(0)
        cboTipoIdentificacion.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoIdentificacion.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoIdentificacion.ItemIndex = 0
        '----------------------------------
        chkEstado.Checked = True

        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        LimpiarCampos()
    End Sub

    Private Sub tsmImprimir_Click(sender As Object, e As EventArgs) Handles tsmImprimir.Click
        GVConsultar.ShowPrintPreview()
    End Sub

    Private Sub bbiPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrint.ItemClick
        GVConsultar.ShowPrintPreview()
    End Sub

    Private Sub bbiPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPDF.ItemClick
        sfdRuta.Filter = "Archivo PDF |*.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmExportarPDF_Click(sender As Object, e As EventArgs) Handles tsmExportarPDF.Click
        sfdRuta.Filter = "Archivo PDF |*.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub

    Private Sub bbiExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExcel.ItemClick
        sfdRuta.Filter = "Archivo Excel |*.xls"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToXls(sfdRuta.FileName)
        End If
    End Sub

    Private Sub tsmExportarExcel_Click(sender As Object, e As EventArgs) Handles tsmExportarExcel.Click
        sfdRuta.Filter = "Archivo Excel |*.xls"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GCConsultar.ExportToXls(sfdRuta.FileName)
        End If
    End Sub

    Private Sub GVConsultar_PrintInitialize(sender As Object, e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GVConsultar.PrintInitialize
        Dim pb As PrintingSystemBase = CType(e.PrintingSystem, PrintingSystemBase)
        pb.PageSettings.Landscape = True
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickIdProveedor = Nothing Then
            MessageBox.Show("Debe seleccionar un Proveedor", "Registro de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            EditarProveedor()
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdProveedor = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString
        End If
    End Sub

    Private Sub txtNumeroIdentificacion_Leave(sender As Object, e As EventArgs) Handles txtNumeroIdentificacion.Leave
        If _DProveedores.Existe(cboTipoIdentificacion.GetColumnValue("CODIGO"), txtNumeroIdentificacion.Text) = True Then
            MessageBox.Show("Ya existe un proveedor registrado con este numero", "Registro de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNumeroIdentificacion.Text = ""
        End If
    End Sub
End Class
Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Public Class frmProductos
    Public Licencia As String
    Public IdEmpleado As String
    Dim _ds As DataSet
    Dim _ClickIdProducto As String
    Dim _Fila As Integer
    Dim _dUnidadMedida As New SIM___GLOBAL.Controles.DUnidadMedida
    Dim _PresentacionProductos As New SIM___GLOBAL.Modelo.PresentacionProductos
    Dim _DPresentacionProductos As New SIM___GLOBAL.Controles.DPresentacionProductos
    Dim _Marcas As New SIM___GLOBAL.Modelo.Marcas
    Dim _DMarcas As New SIM___GLOBAL.Controles.DMarcas
    Dim _Productos As New SIM___GLOBAL.Modelo.Productos
    Dim _dProductos As New SIM___GLOBAL.Controles.DProductos
    Dim _funciones As New SIM___GLOBAL.Utilidades.Funciones
    Dim Marca As String
    Dim Producto As String
    Private Sub LimpiarCampos()
        txtID.Text = Nothing
        txtCodigo.Text = Nothing
        txtPresentacion.Text = Nothing
        txtCantidad.Text = 0
        cboUnidadMedida.EditValue = Nothing
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
        peCodigoBarra.EditValue = Nothing
        Marca = Nothing
        Producto = Nothing
        cboMarca.EditValue = Nothing
        cboProductos.EditValue = Nothing
        cboInventario.SelectedIndex = 0
        Try
            'Cargamos FOTO Temporal
            peFotoProducto.Image = Image.FromFile("c:\sim\imagenes\productos2.png")
            peCodigoBarra.Image = Image.FromFile("c:\sim\imagenes\productos.png")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'GenerarCodigo()
    End Sub
    Private Sub ActualizarGrilla()
        'LLENAR GRILLA  
        _ds = New DataSet
        _ds = _DPresentacionProductos.Listar()
        GCConsultar.DataSource = _ds.Tables(0)
    End Sub
    Private Sub ActivarGuardar()
        bbiGuardar.Enabled = True
    End Sub
    Private Sub GenerarCodigo()
        Dim Codigo = New BarcodeLib.Barcode
        Codigo.IncludeLabel = False
        peCodigoBarra.Image = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigo.Text, 400, 100)
    End Sub
    Private Sub EditarProducto()

        _PresentacionProductos = _DPresentacionProductos.Cargar(_ClickIdProducto)
        txtID.Text = _PresentacionProductos.Id
        txtCodigo.Text = _PresentacionProductos.CodigoBarra
        txtPresentacion.Text = _PresentacionProductos.Presentacion
        cboUnidadMedida.ItemIndex = cboUnidadMedida.Properties.GetDataSourceRowIndex("ID", _PresentacionProductos.IdUnidadMedida)
        cboProductos.ItemIndex = cboProductos.Properties.GetDataSourceRowIndex("ID", _PresentacionProductos.IdProducto)
        cboMarca.ItemIndex = cboMarca.Properties.GetDataSourceRowIndex("ID", _PresentacionProductos.IdMarca)
        txtCantidad.Text = _PresentacionProductos.Cantidad
        If _PresentacionProductos.Estado = "A" Then
            chkEstado.Checked = True
        Else
            chkEstado.Checked = False
        End If

        If _PresentacionProductos.Inventario = "SI" Then
            cboInventario.SelectedIndex = 0
        Else
            cboInventario.SelectedIndex = 1
        End If
        'Llamar funcion image bytes
        Dim FotoProducto As Image
        Dim img2 As Image
        FotoProducto = _funciones.Bytes_Imagen(_PresentacionProductos.FotoProducto)
        img2 = _funciones.Bytes_Imagen(_PresentacionProductos.Foto)
        peFotoProducto.EditValue = FotoProducto
        peCodigoBarra.EditValue = img2
        bbiGuardar.Enabled = False

    End Sub
    Private Sub GuardarMarca()
        _Marcas.Id = Val(0)
        _Marcas.Nombre = cboMarca.Text
        _Marcas.Estado = "A"
        _DMarcas.Guardar(_Marcas)
        ' actualizo grilla marcas
        _ds = New DataSet()
        _ds = _DMarcas.Listar
        cboMarca.Properties.DataSource = _ds.Tables(0)
        cboMarca.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboMarca.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboMarca.Text = Marca

    End Sub
    Private Sub GuardarProductos()
        _Productos.Id = Val(0)
        _Productos.Nombre = cboProductos.Text
        _Productos.Estado = "A"
        _dProductos.Guardar(_Productos)
        ' actualizo grilla productos
        _ds = New DataSet()
        _ds = _dProductos.Listar
        cboProductos.Properties.DataSource = _ds.Tables(0)
        cboProductos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboProductos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboProductos.Text = Producto

    End Sub
    Private Sub Guardar()
        _PresentacionProductos.Id = Val(txtID.Text)
        _PresentacionProductos.Presentacion = txtPresentacion.Text
        _PresentacionProductos.IdUnidadMedida = cboUnidadMedida.GetColumnValue("ID")
        _PresentacionProductos.Cantidad = txtCantidad.Text
        _PresentacionProductos.CodigoBarra = txtCodigo.Text
        _PresentacionProductos.FotoProducto = _funciones.Imagen_Bytes(peFotoProducto.Image)
        _PresentacionProductos.IdMarca = cboMarca.GetColumnValue("ID")
        _PresentacionProductos.IdProducto = cboProductos.GetColumnValue("ID")
        If chkEstado.Checked = True Then
            _PresentacionProductos.Estado = "A"
        Else
            _PresentacionProductos.Estado = "I"
        End If
        _PresentacionProductos.Foto = _funciones.Imagen_Bytes(peCodigoBarra.Image)
        If cboInventario.SelectedIndex = 0 Then
            _PresentacionProductos.Inventario = "SI"
        Else
            _PresentacionProductos.Inventario = "NO"
        End If
        _PresentacionProductos.Licencia = Licencia
        _DPresentacionProductos.Guardar(_PresentacionProductos)

        'txtID.Text = _DProductos.Guardar(_Productos)
        '_Productos.Id = Val(txtID.Text)

    End Sub

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtCodigo.Text = "07000516042020"
        'GenerarCodigo()
        'llenamos campo tipo identificacion

        _ds = New DataSet()
        _ds = _dUnidadMedida.Listar
        cboUnidadMedida.Properties.DataSource = _ds.Tables(0)
        cboUnidadMedida.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboUnidadMedida.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboUnidadMedida.ItemIndex = 0

        _ds = New DataSet()
        _ds = _DMarcas.Listar
        cboMarca.Properties.DataSource = _ds.Tables(0)
        cboMarca.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboMarca.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        _ds = New DataSet()
        _ds = _dProductos.Listar
        cboProductos.Properties.DataSource = _ds.Tables(0)
        cboProductos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboProductos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        cboInventario.SelectedIndex = 0

        ActualizarGrilla()
        chkEstado.Checked = True
        bbiGuardar.Enabled = False
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        If cboProductos.Text = "" Then
            MessageBox.Show("Debe seleccionar el Producto", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboMarca.Text = "" Then
            MessageBox.Show("Debe seleccionar la Marca", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDec(txtcantidad.Text) <= 0 Then
            MessageBox.Show("El Campo Cantidad debe ser mayor que CERO", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboUnidadMedida.Text = "" Then
            MessageBox.Show("Debe seleccionar la unidad de medida", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Guardar MArca
            'GuardarMarca()
            'GuardarProductos()
            Guardar()
            ActualizarGrilla()
            If MessageBox.Show("Desea Imprimir el Codigo de Barras?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                _ClickIdProducto = GVConsultar.GetRowCellValue(GVConsultar.RowCount - 1, "ID").ToString()
                Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
                ImprimirFrm = New SIM___GLOBAL.frmImprimir
                ImprimirFrm.ImprimirCodigoBarra(_ClickIdProducto)
            End If
            LimpiarCampos()

        End If
    End Sub

    Private Sub txtPresentacion_EditValueChanged(sender As Object, e As EventArgs) Handles txtPresentacion.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboUnidadMedida_EditValueChanged(sender As Object, e As EventArgs) Handles cboUnidadMedida.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub txtCantidad_EditValueChanged(sender As Object, e As EventArgs)
        ActivarGuardar()
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
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

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        If _ClickIdProducto = Nothing Then
            MessageBox.Show("Debe seleccionar un Producto", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _DInventario As New SIM___GLOBAL.Controles.DInventario
            If _DInventario.ExisteProducto(_ClickIdProducto) = False Then
                EditarProducto()
            Else
                MessageBox.Show("El producto no se puede editar, ya presenta movimientos registrados", "Editar de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub bbiCodigoBarra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCodigoBarra.ItemClick
        'Registro = 26
        If _ClickIdProducto <> Nothing Then
            Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
            ImprimirFrm = New SIM___GLOBAL.frmImprimir
            'ImprimirFrm.CargarReporte("codigo_barra.rpt", _ClickIdProducto)
            ImprimirFrm.ImprimirCodigoBarra(_ClickIdProducto)
        Else
            MessageBox.Show("Debe Seleccionar un Producto", "Imprimir Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub GVConsultar_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVConsultar.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdProducto = GVConsultar.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _Fila = e.RowHandle.ToString

        End If
    End Sub

    Private Sub tsmCodigoBarras_Click(sender As Object, e As EventArgs) Handles tsmCodigoBarras.Click
        'Registro = 26
        If _ClickIdProducto <> Nothing Then
            Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
            ImprimirFrm = New SIM___GLOBAL.frmImprimir
            ImprimirFrm.CargarReporte("codigo_barra.rpt", _ClickIdProducto)
        Else
            MessageBox.Show("Debe Seleccionar un Producto", "Imprimir Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub bbiListadoProductos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiListadoProductos.ItemClick
        colEstado.Visible = False
        GVConsultar.ShowPrintPreview()
        colEstado.Visible = True
    End Sub

    Private Sub tsmImprimir_Click(sender As Object, e As EventArgs) Handles tsmImprimir.Click
        GVConsultar.ShowPrintPreview()
    End Sub

    Private Sub peFotoProducto_EditValueChanged(sender As Object, e As EventArgs) Handles peFotoProducto.EditValueChanged
        ActivarGuardar()
    End Sub
    Private Sub cboProductos_EditValueChanged(sender As Object, e As EventArgs) Handles cboProductos.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboMarca_EditValueChanged(sender As Object, e As EventArgs) Handles cboMarca.EditValueChanged
        ActivarGuardar()
    End Sub

    Private Sub cboProductos_KeyUp(sender As Object, e As KeyEventArgs) Handles cboProductos.KeyUp
        'If e.KeyCode = Keys.Enter Then
        '
        '        MsgBox(Producto)
        '        End If
    End Sub

    Private Sub cboProductos_ProcessNewValue(sender As Object, e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs) Handles cboProductos.ProcessNewValue
        If e.DisplayValue <> Nothing Then
            _Productos.Id = Val(0)
            _Productos.Nombre = e.DisplayValue
            _Productos.Estado = "A"
            _dProductos.Guardar(_Productos)
            ' actualizo grilla productos
            _ds = New DataSet()
            _ds = _dProductos.Listar
            cboProductos.Properties.DataSource = _ds.Tables(0)
            cboProductos.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
            cboProductos.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
            cboProductos.Text = e.DisplayValue
        End If

    End Sub

    Private Sub cboMarca_ProcessNewValue(sender As Object, e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs) Handles cboMarca.ProcessNewValue
        If e.DisplayValue <> Nothing Then
            _Marcas.Id = Val(0)
            _Marcas.Nombre = e.DisplayValue
            _Marcas.Estado = "A"
            _DMarcas.Guardar(_Marcas)
            ' actualizo grilla marcas
            _ds = New DataSet()
            _ds = _DMarcas.Listar
            cboMarca.Properties.DataSource = _ds.Tables(0)
            cboMarca.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
            cboMarca.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
            cboMarca.Text = e.DisplayValue
        End If
    End Sub

    Private Sub cboInventario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInventario.SelectedIndexChanged
        ActivarGuardar()
    End Sub
End Class
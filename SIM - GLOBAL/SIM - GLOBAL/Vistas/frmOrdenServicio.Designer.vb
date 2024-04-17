<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenServicio
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenServicio))
        Me.TileViewColumn3 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn5 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn2 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtpOrdenesProductos = New DevExpress.XtraTab.XtraTabPage()
        Me.GCDatosCliente = New DevExpress.XtraGrid.GridControl()
        Me.TVDatosCliente = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.TileViewColumn1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colApellidos = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colEdad = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn4 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colFoto = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaExpedicion = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaVencimiento = New DevExpress.XtraEditors.DateEdit()
        Me.GCProductos = New DevExpress.XtraGrid.GridControl()
        Me.gvProductos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDProductos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDPRESENTACIONPRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimirCotizacion = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.cboFactura = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bbiVistaPrevia = New DevExpress.XtraBars.BarSubItem()
        Me.bsiImprimir = New DevExpress.XtraBars.BarSubItem()
        Me.bbiFacturaConcepto = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRelacionFactura = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiFactura = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDetalleFactura = New DevExpress.XtraBars.BarButtonItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIVA = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCSubTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GCDetallePagoDocumento = New DevExpress.XtraGrid.GridControl()
        Me.gvDetallePagoDocumento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTODETALLEPAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALORDETALLEPAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFormaPagoValor = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblValor = New DevExpress.XtraEditors.LabelControl()
        Me.cboFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboCliente = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDCLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CONTACTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TELEFONO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.peFoto = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorUnitarioP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTarifaProducto = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl4 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtSon = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtCotizacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCantidadP = New DevExpress.XtraEditors.TextEdit()
        Me.cboProducto = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvComboProductos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoBarra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRESENTACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMEDIDA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.colCTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCFechaVencimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCFechaOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.xtpOrdenesGeneradas = New DevExpress.XtraTab.XtraTabPage()
        Me.xtcOrdenesServicios = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpOrdenesProductos.SuspendLayout()
        CType(Me.GCDatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtFechaExpedicion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaExpedicion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtCDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIVA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GCDetallePagoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetallePagoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormaPagoValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorUnitarioP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTarifaProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCotizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvComboProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpOrdenesGeneradas.SuspendLayout()
        CType(Me.xtcOrdenesServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcOrdenesServicios.SuspendLayout()
        Me.SuspendLayout()
        '
        'TileViewColumn3
        '
        Me.TileViewColumn3.Caption = "Nombres"
        Me.TileViewColumn3.FieldName = "NOMBRE"
        Me.TileViewColumn3.Name = "TileViewColumn3"
        Me.TileViewColumn3.Visible = True
        Me.TileViewColumn3.VisibleIndex = 2
        '
        'TileViewColumn5
        '
        Me.TileViewColumn5.Caption = "Telefono"
        Me.TileViewColumn5.FieldName = "TELEFONO"
        Me.TileViewColumn5.Name = "TileViewColumn5"
        Me.TileViewColumn5.Visible = True
        Me.TileViewColumn5.VisibleIndex = 4
        '
        'TileViewColumn2
        '
        Me.TileViewColumn2.Caption = "Identificacion"
        Me.TileViewColumn2.FieldName = "IDENTIFICACION"
        Me.TileViewColumn2.Name = "TileViewColumn2"
        Me.TileViewColumn2.Visible = True
        Me.TileViewColumn2.VisibleIndex = 1
        '
        'colEmail
        '
        Me.colEmail.Caption = "EMAIL"
        Me.colEmail.FieldName = "EMAIL"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 7
        '
        'colDireccion
        '
        Me.colDireccion.Caption = "DIRECCION"
        Me.colDireccion.FieldName = "DIRECCION"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 6
        '
        'colValor
        '
        Me.colValor.Caption = "VALOR"
        Me.colValor.DisplayFormat.FormatString = "C0"
        Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValor.FieldName = "VALOR"
        Me.colValor.Name = "colValor"
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 3
        '
        'colSubTotal
        '
        Me.colSubTotal.Caption = "SUBTOTAL"
        Me.colSubTotal.DisplayFormat.FormatString = "C0"
        Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotal.FieldName = "SUBTOTAL"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.Visible = True
        Me.colSubTotal.VisibleIndex = 4
        '
        'xtpOrdenesProductos
        '
        Me.xtpOrdenesProductos.Controls.Add(Me.GCDatosCliente)
        Me.xtpOrdenesProductos.Controls.Add(Me.GroupBox3)
        Me.xtpOrdenesProductos.Controls.Add(Me.GCProductos)
        Me.xtpOrdenesProductos.Controls.Add(Me.GroupBox2)
        Me.xtpOrdenesProductos.Controls.Add(Me.GroupBox1)
        Me.xtpOrdenesProductos.Controls.Add(Me.cboCliente)
        Me.xtpOrdenesProductos.Controls.Add(Me.txtDescuento)
        Me.xtpOrdenesProductos.Controls.Add(Me.peFoto)
        Me.xtpOrdenesProductos.Controls.Add(Me.LabelControl3)
        Me.xtpOrdenesProductos.Controls.Add(Me.txtSubTotal)
        Me.xtpOrdenesProductos.Controls.Add(Me.txtValorUnitarioP)
        Me.xtpOrdenesProductos.Controls.Add(Me.LabelControl1)
        Me.xtpOrdenesProductos.Controls.Add(Me.cboTarifaProducto)
        Me.xtpOrdenesProductos.Controls.Add(Me.LabelControl25)
        Me.xtpOrdenesProductos.Controls.Add(Me.SeparatorControl4)
        Me.xtpOrdenesProductos.Controls.Add(Me.txtSon)
        Me.xtpOrdenesProductos.Controls.Add(Me.LabelControl23)
        Me.xtpOrdenesProductos.Controls.Add(Me.LabelControl24)
        Me.xtpOrdenesProductos.Controls.Add(Me.SeparatorControl2)
        Me.xtpOrdenesProductos.Controls.Add(Me.txtCotizacion)
        Me.xtpOrdenesProductos.Controls.Add(Me.LabelControl9)
        Me.xtpOrdenesProductos.Controls.Add(Me.LabelControl13)
        Me.xtpOrdenesProductos.Controls.Add(Me.LabelControl14)
        Me.xtpOrdenesProductos.Controls.Add(Me.LabelControl16)
        Me.xtpOrdenesProductos.Controls.Add(Me.btnEliminar)
        Me.xtpOrdenesProductos.Controls.Add(Me.btnAgregar)
        Me.xtpOrdenesProductos.Controls.Add(Me.txtCantidadP)
        Me.xtpOrdenesProductos.Controls.Add(Me.cboProducto)
        Me.xtpOrdenesProductos.Controls.Add(Me.LabelControl15)
        Me.xtpOrdenesProductos.Controls.Add(Me.txtConcepto)
        Me.xtpOrdenesProductos.Name = "xtpOrdenesProductos"
        Me.xtpOrdenesProductos.Size = New System.Drawing.Size(1077, 566)
        Me.xtpOrdenesProductos.Text = "Generar Orden"
        '
        'GCDatosCliente
        '
        Me.GCDatosCliente.EmbeddedNavigator.Appearance.BorderColor = System.Drawing.Color.Red
        Me.GCDatosCliente.EmbeddedNavigator.Appearance.Options.UseBorderColor = True
        Me.GCDatosCliente.Location = New System.Drawing.Point(15, 37)
        Me.GCDatosCliente.MainView = Me.TVDatosCliente
        Me.GCDatosCliente.Name = "GCDatosCliente"
        Me.GCDatosCliente.Size = New System.Drawing.Size(440, 100)
        Me.GCDatosCliente.TabIndex = 249
        Me.GCDatosCliente.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TVDatosCliente})
        '
        'TVDatosCliente
        '
        Me.TVDatosCliente.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TVDatosCliente.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TileViewColumn1, Me.TileViewColumn2, Me.TileViewColumn3, Me.colApellidos, Me.colEdad, Me.TileViewColumn4, Me.colDireccion, Me.colEmail, Me.TileViewColumn5, Me.colFoto})
        Me.TVDatosCliente.GridControl = Me.GCDatosCliente
        Me.TVDatosCliente.Name = "TVDatosCliente"
        Me.TVDatosCliente.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(28, 0, 0, 16)
        Me.TVDatosCliente.OptionsTiles.IndentBetweenItems = 13
        Me.TVDatosCliente.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(5)
        Me.TVDatosCliente.OptionsTiles.ItemSize = New System.Drawing.Size(372, 72)
        Me.TVDatosCliente.OptionsTiles.Padding = New System.Windows.Forms.Padding(3)
        TableColumnDefinition1.Length.Value = 138.0R
        Me.TVDatosCliente.TileColumns.Add(TableColumnDefinition1)
        TileViewItemElement1.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Left
        TileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        TileViewItemElement1.Appearance.Normal.Options.UseFont = True
        TileViewItemElement1.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement1.Column = Me.TileViewColumn3
        TileViewItemElement1.StretchHorizontal = True
        TileViewItemElement1.Text = "TileViewColumn3"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement1.TextLocation = New System.Drawing.Point(10, 5)
        TileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
        TileViewItemElement2.Appearance.Normal.Options.UseFont = True
        TileViewItemElement2.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement2.Column = Me.TileViewColumn5
        TileViewItemElement2.StretchHorizontal = True
        TileViewItemElement2.Text = "TileViewColumn5"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement2.TextLocation = New System.Drawing.Point(10, 35)
        TileViewItemElement3.Column = Me.TileViewColumn2
        TileViewItemElement3.StretchHorizontal = True
        TileViewItemElement3.Text = "TileViewColumn2"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement3.TextLocation = New System.Drawing.Point(10, 22)
        TileViewItemElement4.Column = Me.colEmail
        TileViewItemElement4.StretchHorizontal = True
        TileViewItemElement4.Text = "colEmail"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement4.TextLocation = New System.Drawing.Point(10, 60)
        TileViewItemElement5.Appearance.Normal.BackColor = System.Drawing.Color.Transparent
        TileViewItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.DimGray
        TileViewItemElement5.Appearance.Normal.Options.UseBackColor = True
        TileViewItemElement5.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement5.Column = Me.colDireccion
        TileViewItemElement5.StretchHorizontal = True
        TileViewItemElement5.Text = "colDireccion"
        TileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement5.TextLocation = New System.Drawing.Point(10, 47)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement1)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement2)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement3)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement4)
        Me.TVDatosCliente.TileTemplate.Add(TileViewItemElement5)
        '
        'TileViewColumn1
        '
        Me.TileViewColumn1.Caption = "ID"
        Me.TileViewColumn1.FieldName = "ID"
        Me.TileViewColumn1.Name = "TileViewColumn1"
        Me.TileViewColumn1.Visible = True
        Me.TileViewColumn1.VisibleIndex = 0
        '
        'colApellidos
        '
        Me.colApellidos.Caption = "APELLIDOS"
        Me.colApellidos.FieldName = "TELEFONO"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.Visible = True
        Me.colApellidos.VisibleIndex = 8
        '
        'colEdad
        '
        Me.colEdad.Caption = "EDAD"
        Me.colEdad.FieldName = "EDAD"
        Me.colEdad.Name = "colEdad"
        Me.colEdad.Visible = True
        Me.colEdad.VisibleIndex = 5
        '
        'TileViewColumn4
        '
        Me.TileViewColumn4.Caption = "Sexo"
        Me.TileViewColumn4.FieldName = "SEXO"
        Me.TileViewColumn4.Name = "TileViewColumn4"
        Me.TileViewColumn4.Visible = True
        Me.TileViewColumn4.VisibleIndex = 3
        '
        'colFoto
        '
        Me.colFoto.Caption = "FOTO"
        Me.colFoto.FieldName = "FOTO"
        Me.colFoto.Name = "colFoto"
        Me.colFoto.Visible = True
        Me.colFoto.VisibleIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelControl6)
        Me.GroupBox3.Controls.Add(Me.dtFechaExpedicion)
        Me.GroupBox3.Controls.Add(Me.LabelControl18)
        Me.GroupBox3.Controls.Add(Me.dtFechaVencimiento)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(808, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 94)
        Me.GroupBox3.TabIndex = 248
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha de Servicio"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(32, 30)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(82, 19)
        Me.LabelControl6.TabIndex = 204
        Me.LabelControl6.Text = "Expedición:"
        '
        'dtFechaExpedicion
        '
        Me.dtFechaExpedicion.EditValue = Nothing
        Me.dtFechaExpedicion.Location = New System.Drawing.Point(122, 27)
        Me.dtFechaExpedicion.Name = "dtFechaExpedicion"
        Me.dtFechaExpedicion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.dtFechaExpedicion.Properties.Appearance.Options.UseFont = True
        Me.dtFechaExpedicion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaExpedicion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaExpedicion.Properties.CalendarTimeProperties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtFechaExpedicion.Properties.CalendarTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Custom
        Me.dtFechaExpedicion.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = True
        Me.dtFechaExpedicion.Properties.DisplayFormat.FormatString = ""
        Me.dtFechaExpedicion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaExpedicion.Properties.EditFormat.FormatString = ""
        Me.dtFechaExpedicion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaExpedicion.Size = New System.Drawing.Size(111, 26)
        Me.dtFechaExpedicion.TabIndex = 191
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Location = New System.Drawing.Point(21, 62)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(93, 19)
        Me.LabelControl18.TabIndex = 205
        Me.LabelControl18.Text = "Vencimiento:"
        '
        'dtFechaVencimiento
        '
        Me.dtFechaVencimiento.EditValue = Nothing
        Me.dtFechaVencimiento.Location = New System.Drawing.Point(122, 59)
        Me.dtFechaVencimiento.Name = "dtFechaVencimiento"
        Me.dtFechaVencimiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.dtFechaVencimiento.Properties.Appearance.Options.UseFont = True
        Me.dtFechaVencimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaVencimiento.Properties.DisplayFormat.FormatString = ""
        Me.dtFechaVencimiento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaVencimiento.Properties.EditFormat.FormatString = ""
        Me.dtFechaVencimiento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaVencimiento.Size = New System.Drawing.Size(110, 26)
        Me.dtFechaVencimiento.TabIndex = 192
        '
        'GCProductos
        '
        Me.GCProductos.Location = New System.Drawing.Point(14, 209)
        Me.GCProductos.MainView = Me.gvProductos
        Me.GCProductos.MenuManager = Me.BarManager1
        Me.GCProductos.Name = "GCProductos"
        Me.GCProductos.Size = New System.Drawing.Size(1052, 148)
        Me.GCProductos.TabIndex = 247
        Me.GCProductos.UseEmbeddedNavigator = True
        Me.GCProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProductos})
        '
        'gvProductos
        '
        Me.gvProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDProductos, Me.colCodigoProducto, Me.colProducto, Me.colUNIDAD, Me.colCANTIDAD, Me.colValorUnitario, Me.colCSubTotal, Me.colCDescuento, Me.colIDPRESENTACIONPRODUCTO})
        Me.gvProductos.GridControl = Me.GCProductos
        Me.gvProductos.Name = "gvProductos"
        Me.gvProductos.OptionsBehavior.Editable = False
        Me.gvProductos.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvProductos.OptionsPrint.EnableAppearanceOddRow = True
        Me.gvProductos.OptionsPrint.ExpandAllDetails = True
        Me.gvProductos.OptionsPrint.ExpandAllGroups = False
        Me.gvProductos.OptionsPrint.PrintFooter = False
        Me.gvProductos.OptionsView.EnableAppearanceOddRow = True
        Me.gvProductos.OptionsView.ShowGroupPanel = False
        '
        'colIDProductos
        '
        Me.colIDProductos.Caption = "ID"
        Me.colIDProductos.FieldName = "ID"
        Me.colIDProductos.Name = "colIDProductos"
        '
        'colCodigoProducto
        '
        Me.colCodigoProducto.Caption = "CODIGO"
        Me.colCodigoProducto.FieldName = "CODIGO"
        Me.colCodigoProducto.Name = "colCodigoProducto"
        Me.colCodigoProducto.Visible = True
        Me.colCodigoProducto.VisibleIndex = 0
        Me.colCodigoProducto.Width = 100
        '
        'colProducto
        '
        Me.colProducto.Caption = "PRESENTACION"
        Me.colProducto.FieldName = "PRESENTACION"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 1
        Me.colProducto.Width = 417
        '
        'colUNIDAD
        '
        Me.colUNIDAD.Caption = "UNI MED"
        Me.colUNIDAD.FieldName = "UNIDAD"
        Me.colUNIDAD.Name = "colUNIDAD"
        Me.colUNIDAD.Visible = True
        Me.colUNIDAD.VisibleIndex = 2
        Me.colUNIDAD.Width = 71
        '
        'colCANTIDAD
        '
        Me.colCANTIDAD.Caption = "CANTIDAD"
        Me.colCANTIDAD.FieldName = "CANTIDAD"
        Me.colCANTIDAD.Name = "colCANTIDAD"
        Me.colCANTIDAD.Visible = True
        Me.colCANTIDAD.VisibleIndex = 3
        Me.colCANTIDAD.Width = 80
        '
        'colValorUnitario
        '
        Me.colValorUnitario.Caption = "VAL UNIT"
        Me.colValorUnitario.DisplayFormat.FormatString = "C0"
        Me.colValorUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorUnitario.FieldName = "VALOR"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "SUMA={0:C0}")})
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 4
        Me.colValorUnitario.Width = 78
        '
        'colCSubTotal
        '
        Me.colCSubTotal.Caption = "SUBTOTAL"
        Me.colCSubTotal.DisplayFormat.FormatString = "C0"
        Me.colCSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCSubTotal.FieldName = "SUBTOTAL"
        Me.colCSubTotal.Name = "colCSubTotal"
        Me.colCSubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SUBTOTAL", "TOTAL={0:C0}")})
        Me.colCSubTotal.Visible = True
        Me.colCSubTotal.VisibleIndex = 6
        Me.colCSubTotal.Width = 116
        '
        'colCDescuento
        '
        Me.colCDescuento.Caption = "DESCUENTO"
        Me.colCDescuento.DisplayFormat.FormatString = "C0"
        Me.colCDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCDescuento.FieldName = "DESCUENTO"
        Me.colCDescuento.Name = "colCDescuento"
        Me.colCDescuento.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DESCUENTO", "DESCUENTO={0:C0}")})
        Me.colCDescuento.Visible = True
        Me.colCDescuento.VisibleIndex = 5
        Me.colCDescuento.Width = 84
        '
        'colIDPRESENTACIONPRODUCTO
        '
        Me.colIDPRESENTACIONPRODUCTO.Caption = "CODIGO PRODUCTO"
        Me.colIDPRESENTACIONPRODUCTO.FieldName = "IDPRODUCTO"
        Me.colIDPRESENTACIONPRODUCTO.Name = "colIDPRESENTACIONPRODUCTO"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.BarDockControl2)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiNuevo, Me.bbiGuardar, Me.bbiImprimir, Me.bbiAnular, Me.cboFactura, Me.bbiVistaPrevia, Me.bsiImprimir, Me.bbiActualizar, Me.bbiFactura, Me.bbiDetalleFactura, Me.bbiConsultar, Me.bbiFacturaConcepto, Me.bbiRelacionFactura, Me.BarButtonItem1, Me.bbiImprimirCotizacion})
        Me.BarManager1.MaxItemId = 15
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        '
        'Bar3
        '
        Me.Bar3.BarName = "Herramientas"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.FloatLocation = New System.Drawing.Point(86, 132)
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAnular), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimirCotizacion, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar3.Text = "Herramientas"
        '
        'bbiNuevo
        '
        Me.bbiNuevo.Caption = "Nueva Factura"
        Me.bbiNuevo.Id = 0
        Me.bbiNuevo.ImageOptions.Image = CType(resources.GetObject("bbiNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiNuevo.Name = "bbiNuevo"
        '
        'bbiGuardar
        '
        Me.bbiGuardar.Caption = "Guardar Factura"
        Me.bbiGuardar.Enabled = False
        Me.bbiGuardar.Id = 1
        Me.bbiGuardar.ImageOptions.Image = CType(resources.GetObject("bbiGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGuardar.Name = "bbiGuardar"
        '
        'bbiAnular
        '
        Me.bbiAnular.Caption = "Anular Orden de Servicio"
        Me.bbiAnular.Id = 3
        Me.bbiAnular.ImageOptions.Image = CType(resources.GetObject("bbiAnular.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiAnular.Name = "bbiAnular"
        '
        'bbiActualizar
        '
        Me.bbiActualizar.Caption = "Actualizar"
        Me.bbiActualizar.Id = 7
        Me.bbiActualizar.ImageOptions.Image = CType(resources.GetObject("bbiActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiActualizar.Name = "bbiActualizar"
        '
        'bbiConsultar
        '
        Me.bbiConsultar.Caption = "Consultar"
        Me.bbiConsultar.Id = 10
        Me.bbiConsultar.ImageOptions.Image = CType(resources.GetObject("bbiConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiConsultar.Name = "bbiConsultar"
        '
        'bbiImprimirCotizacion
        '
        Me.bbiImprimirCotizacion.Caption = "Imprimir"
        Me.bbiImprimirCotizacion.Id = 14
        Me.bbiImprimirCotizacion.ImageOptions.Image = CType(resources.GetObject("bbiImprimirCotizacion.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimirCotizacion.Name = "bbiImprimirCotizacion"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Registro de Clientes"
        Me.BarButtonItem1.Id = 13
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl2.Manager = Me.BarManager1
        Me.BarDockControl2.Size = New System.Drawing.Size(1079, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 622)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1079, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 598)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1079, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 598)
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.Id = 2
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'cboFactura
        '
        Me.cboFactura.Caption = "BarEditItem1"
        Me.cboFactura.Edit = Me.RepositoryItemLookUpEdit1
        Me.cboFactura.Id = 4
        Me.cboFactura.Name = "cboFactura"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'bbiVistaPrevia
        '
        Me.bbiVistaPrevia.Caption = "Imprimir"
        Me.bbiVistaPrevia.Id = 5
        Me.bbiVistaPrevia.ImageOptions.Image = CType(resources.GetObject("bbiVistaPrevia.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiVistaPrevia.Name = "bbiVistaPrevia"
        '
        'bsiImprimir
        '
        Me.bsiImprimir.Caption = "Imprimir"
        Me.bsiImprimir.Id = 6
        Me.bsiImprimir.ImageOptions.Image = CType(resources.GetObject("bsiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bsiImprimir.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFacturaConcepto), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiRelacionFactura), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFactura), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDetalleFactura)})
        Me.bsiImprimir.Name = "bsiImprimir"
        '
        'bbiFacturaConcepto
        '
        Me.bbiFacturaConcepto.Caption = "Factura con Concepto"
        Me.bbiFacturaConcepto.Id = 11
        Me.bbiFacturaConcepto.Name = "bbiFacturaConcepto"
        '
        'bbiRelacionFactura
        '
        Me.bbiRelacionFactura.Caption = "Relación de la Factura"
        Me.bbiRelacionFactura.Id = 12
        Me.bbiRelacionFactura.Name = "bbiRelacionFactura"
        '
        'bbiFactura
        '
        Me.bbiFactura.Caption = "Factura Resumida"
        Me.bbiFactura.Id = 8
        Me.bbiFactura.ImageOptions.Image = CType(resources.GetObject("bbiFactura.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiFactura.Name = "bbiFactura"
        '
        'bbiDetalleFactura
        '
        Me.bbiDetalleFactura.Caption = "Factura Detallada"
        Me.bbiDetalleFactura.Id = 9
        Me.bbiDetalleFactura.ImageOptions.Image = CType(resources.GetObject("bbiDetalleFactura.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiDetalleFactura.Name = "bbiDetalleFactura"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl22)
        Me.GroupBox2.Controls.Add(Me.LabelControl21)
        Me.GroupBox2.Controls.Add(Me.txtCDescuento)
        Me.GroupBox2.Controls.Add(Me.LabelControl20)
        Me.GroupBox2.Controls.Add(Me.txtIVA)
        Me.GroupBox2.Controls.Add(Me.LabelControl19)
        Me.GroupBox2.Controls.Add(Me.txtCSubTotal)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(805, 363)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 182)
        Me.GroupBox2.TabIndex = 246
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales Servicios"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Location = New System.Drawing.Point(17, 37)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(87, 23)
        Me.LabelControl22.TabIndex = 211
        Me.LabelControl22.Text = "Sub Total:"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(68, 107)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(36, 23)
        Me.LabelControl21.TabIndex = 216
        Me.LabelControl21.Text = "IVA:"
        '
        'txtCDescuento
        '
        Me.txtCDescuento.EditValue = "0"
        Me.txtCDescuento.Location = New System.Drawing.Point(121, 69)
        Me.txtCDescuento.Name = "txtCDescuento"
        Me.txtCDescuento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCDescuento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtCDescuento.Properties.Appearance.Options.UseBackColor = True
        Me.txtCDescuento.Properties.Appearance.Options.UseFont = True
        Me.txtCDescuento.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCDescuento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCDescuento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCDescuento.Properties.Mask.BeepOnError = True
        Me.txtCDescuento.Properties.Mask.EditMask = "c0"
        Me.txtCDescuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCDescuento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCDescuento.Properties.ReadOnly = True
        Me.txtCDescuento.Size = New System.Drawing.Size(120, 28)
        Me.txtCDescuento.TabIndex = 237
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Location = New System.Drawing.Point(56, 144)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(48, 23)
        Me.LabelControl20.TabIndex = 218
        Me.LabelControl20.Text = "Total:"
        '
        'txtIVA
        '
        Me.txtIVA.EditValue = "0"
        Me.txtIVA.Location = New System.Drawing.Point(121, 105)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIVA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtIVA.Properties.Appearance.Options.UseBackColor = True
        Me.txtIVA.Properties.Appearance.Options.UseFont = True
        Me.txtIVA.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIVA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIVA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtIVA.Properties.Mask.BeepOnError = True
        Me.txtIVA.Properties.Mask.EditMask = "c0"
        Me.txtIVA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIVA.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIVA.Properties.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(120, 28)
        Me.txtIVA.TabIndex = 238
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Location = New System.Drawing.Point(9, 71)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(95, 23)
        Me.LabelControl19.TabIndex = 221
        Me.LabelControl19.Text = "Descuento:"
        '
        'txtCSubTotal
        '
        Me.txtCSubTotal.EditValue = "0"
        Me.txtCSubTotal.Location = New System.Drawing.Point(121, 35)
        Me.txtCSubTotal.Name = "txtCSubTotal"
        Me.txtCSubTotal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCSubTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtCSubTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtCSubTotal.Properties.Appearance.Options.UseFont = True
        Me.txtCSubTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCSubTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCSubTotal.Properties.Mask.BeepOnError = True
        Me.txtCSubTotal.Properties.Mask.EditMask = "c0"
        Me.txtCSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCSubTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCSubTotal.Properties.ReadOnly = True
        Me.txtCSubTotal.Size = New System.Drawing.Size(120, 28)
        Me.txtCSubTotal.TabIndex = 236
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = "0"
        Me.txtTotal.Location = New System.Drawing.Point(121, 142)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTotal.Properties.Mask.BeepOnError = True
        Me.txtTotal.Properties.Mask.EditMask = "c0"
        Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(120, 28)
        Me.txtTotal.TabIndex = 239
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.GCDetallePagoDocumento)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.txtFormaPagoValor)
        Me.GroupBox1.Controls.Add(Me.SimpleButton2)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Controls.Add(Me.cboFormaPago)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(210, 404)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 141)
        Me.GroupBox1.TabIndex = 245
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de Pago"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(273, 12)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl5.TabIndex = 248
        Me.LabelControl5.Text = "Detalle:"
        '
        'GCDetallePagoDocumento
        '
        Me.GCDetallePagoDocumento.Location = New System.Drawing.Point(273, 31)
        Me.GCDetallePagoDocumento.MainView = Me.gvDetallePagoDocumento
        Me.GCDetallePagoDocumento.Name = "GCDetallePagoDocumento"
        Me.GCDetallePagoDocumento.Size = New System.Drawing.Size(272, 103)
        Me.GCDetallePagoDocumento.TabIndex = 251
        Me.GCDetallePagoDocumento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetallePagoDocumento})
        '
        'gvDetallePagoDocumento
        '
        Me.gvDetallePagoDocumento.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colCONCEPTODETALLEPAGO, Me.colVALORDETALLEPAGO})
        Me.gvDetallePagoDocumento.GridControl = Me.GCDetallePagoDocumento
        Me.gvDetallePagoDocumento.Name = "gvDetallePagoDocumento"
        Me.gvDetallePagoDocumento.OptionsBehavior.Editable = False
        Me.gvDetallePagoDocumento.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvDetallePagoDocumento.OptionsPrint.EnableAppearanceOddRow = True
        Me.gvDetallePagoDocumento.OptionsPrint.ExpandAllDetails = True
        Me.gvDetallePagoDocumento.OptionsPrint.ExpandAllGroups = False
        Me.gvDetallePagoDocumento.OptionsPrint.PrintFooter = False
        Me.gvDetallePagoDocumento.OptionsView.EnableAppearanceOddRow = True
        Me.gvDetallePagoDocumento.OptionsView.ShowColumnHeaders = False
        Me.gvDetallePagoDocumento.OptionsView.ShowFooter = True
        Me.gvDetallePagoDocumento.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colCONCEPTODETALLEPAGO
        '
        Me.colCONCEPTODETALLEPAGO.Caption = "CONCEPTO"
        Me.colCONCEPTODETALLEPAGO.FieldName = "CONCEPTO"
        Me.colCONCEPTODETALLEPAGO.Name = "colCONCEPTODETALLEPAGO"
        Me.colCONCEPTODETALLEPAGO.Visible = True
        Me.colCONCEPTODETALLEPAGO.VisibleIndex = 0
        Me.colCONCEPTODETALLEPAGO.Width = 368
        '
        'colVALORDETALLEPAGO
        '
        Me.colVALORDETALLEPAGO.Caption = "VALOR"
        Me.colVALORDETALLEPAGO.DisplayFormat.FormatString = "C0"
        Me.colVALORDETALLEPAGO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALORDETALLEPAGO.FieldName = "VALOR"
        Me.colVALORDETALLEPAGO.Name = "colVALORDETALLEPAGO"
        Me.colVALORDETALLEPAGO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.colVALORDETALLEPAGO.Visible = True
        Me.colVALORDETALLEPAGO.VisibleIndex = 1
        Me.colVALORDETALLEPAGO.Width = 162
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(227, 54)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(23, 23)
        Me.SimpleButton1.TabIndex = 249
        Me.SimpleButton1.ToolTip = "Eliminar Producto"
        '
        'txtFormaPagoValor
        '
        Me.txtFormaPagoValor.Location = New System.Drawing.Point(92, 56)
        Me.txtFormaPagoValor.Name = "txtFormaPagoValor"
        Me.txtFormaPagoValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txtFormaPagoValor.Properties.Appearance.Options.UseFont = True
        Me.txtFormaPagoValor.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtFormaPagoValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFormaPagoValor.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtFormaPagoValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFormaPagoValor.Properties.Mask.EditMask = "c0"
        Me.txtFormaPagoValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFormaPagoValor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFormaPagoValor.Size = New System.Drawing.Size(100, 20)
        Me.txtFormaPagoValor.TabIndex = 248
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(198, 54)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(23, 23)
        Me.SimpleButton2.TabIndex = 248
        Me.SimpleButton2.ToolTip = "Agregar Producto"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(62, 59)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl4.TabIndex = 250
        Me.LabelControl4.Text = "Valor"
        '
        'lblValor
        '
        Me.lblValor.Location = New System.Drawing.Point(16, 31)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(70, 13)
        Me.lblValor.TabIndex = 249
        Me.lblValor.Text = "Medio de Pago"
        '
        'cboFormaPago
        '
        Me.cboFormaPago.Location = New System.Drawing.Point(92, 28)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.cboFormaPago.Properties.Appearance.Options.UseFont = True
        Me.cboFormaPago.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFormaPago.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CONCEPTO", "CONCEPTO")})
        Me.cboFormaPago.Properties.NullText = ""
        Me.cboFormaPago.Properties.ShowHeader = False
        Me.cboFormaPago.Size = New System.Drawing.Size(158, 20)
        Me.cboFormaPago.TabIndex = 248
        '
        'cboCliente
        '
        Me.cboCliente.EditValue = "SELECCIONAR"
        Me.cboCliente.Location = New System.Drawing.Point(69, 11)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cboCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCliente.Properties.NullText = ""
        Me.cboCliente.Properties.PopupView = Me.GridView1
        Me.cboCliente.Size = New System.Drawing.Size(386, 20)
        Me.cboCliente.TabIndex = 189
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDCLIENTE, Me.IDENTIFICACION, Me.CLIENTE, Me.CONTACTO, Me.TELEFONO})
        Me.GridView1.DetailHeight = 200
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoPopulateColumns = False
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 1000
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIDCLIENTE
        '
        Me.colIDCLIENTE.Caption = "ID"
        Me.colIDCLIENTE.FieldName = "IDCLIENTE"
        Me.colIDCLIENTE.Name = "colIDCLIENTE"
        '
        'IDENTIFICACION
        '
        Me.IDENTIFICACION.Caption = "IDENTIFICACION"
        Me.IDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.IDENTIFICACION.Name = "IDENTIFICACION"
        Me.IDENTIFICACION.Visible = True
        Me.IDENTIFICACION.VisibleIndex = 0
        '
        'CLIENTE
        '
        Me.CLIENTE.Caption = "CLIENTE"
        Me.CLIENTE.FieldName = "CLIENTE"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.Visible = True
        Me.CLIENTE.VisibleIndex = 1
        '
        'CONTACTO
        '
        Me.CONTACTO.Caption = "CONTACTO"
        Me.CONTACTO.FieldName = "CONTACTO"
        Me.CONTACTO.Name = "CONTACTO"
        Me.CONTACTO.Visible = True
        Me.CONTACTO.VisibleIndex = 2
        '
        'TELEFONO
        '
        Me.TELEFONO.Caption = "TELEFONO"
        Me.TELEFONO.FieldName = "TELEFONO"
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.Visible = True
        Me.TELEFONO.VisibleIndex = 3
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(791, 177)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtDescuento.Properties.Appearance.Options.UseFont = True
        Me.txtDescuento.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuento.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtDescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuento.Properties.Mask.EditMask = "c0"
        Me.txtDescuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescuento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDescuento.Size = New System.Drawing.Size(100, 26)
        Me.txtDescuento.TabIndex = 188
        '
        'peFoto
        '
        Me.peFoto.EditValue = CType(resources.GetObject("peFoto.EditValue"), Object)
        Me.peFoto.Location = New System.Drawing.Point(511, 37)
        Me.peFoto.Name = "peFoto"
        Me.peFoto.Properties.InitialImageOptions.Image = CType(resources.GetObject("peFoto.Properties.InitialImageOptions.Image"), System.Drawing.Image)
        Me.peFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.peFoto.Size = New System.Drawing.Size(209, 100)
        Me.peFoto.TabIndex = 173
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(791, 152)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 19)
        Me.LabelControl3.TabIndex = 187
        Me.LabelControl3.Text = "Descuento"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(898, 177)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSubTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtSubTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSubTotal.Properties.Appearance.Options.UseFont = True
        Me.txtSubTotal.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtSubTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubTotal.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtSubTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubTotal.Properties.Mask.EditMask = "c0"
        Me.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSubTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSubTotal.Properties.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 26)
        Me.txtSubTotal.TabIndex = 186
        '
        'txtValorUnitarioP
        '
        Me.txtValorUnitarioP.Location = New System.Drawing.Point(683, 177)
        Me.txtValorUnitarioP.Name = "txtValorUnitarioP"
        Me.txtValorUnitarioP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtValorUnitarioP.Properties.Appearance.Options.UseFont = True
        Me.txtValorUnitarioP.Properties.DisplayFormat.FormatString = "{0:C0}"
        Me.txtValorUnitarioP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorUnitarioP.Properties.EditFormat.FormatString = "{0:C0}"
        Me.txtValorUnitarioP.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorUnitarioP.Properties.Mask.EditMask = "c0"
        Me.txtValorUnitarioP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorUnitarioP.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValorUnitarioP.Size = New System.Drawing.Size(100, 26)
        Me.txtValorUnitarioP.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(473, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 183
        Me.LabelControl1.Text = "Tarifa:"
        '
        'cboTarifaProducto
        '
        Me.cboTarifaProducto.Location = New System.Drawing.Point(511, 11)
        Me.cboTarifaProducto.Name = "cboTarifaProducto"
        Me.cboTarifaProducto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTarifaProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTarifaProducto.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TARIFA", "TARIFA")})
        Me.cboTarifaProducto.Properties.NullText = ""
        Me.cboTarifaProducto.Size = New System.Drawing.Size(208, 20)
        Me.cboTarifaProducto.TabIndex = 2
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(14, 14)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl25.TabIndex = 181
        Me.LabelControl25.Text = "Cliente:"
        '
        'SeparatorControl4
        '
        Me.SeparatorControl4.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl4.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl4.Location = New System.Drawing.Point(774, 363)
        Me.SeparatorControl4.Name = "SeparatorControl4"
        Me.SeparatorControl4.Size = New System.Drawing.Size(23, 182)
        Me.SeparatorControl4.TabIndex = 178
        '
        'txtSon
        '
        Me.txtSon.Location = New System.Drawing.Point(57, 372)
        Me.txtSon.Name = "txtSon"
        Me.txtSon.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSon.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtSon.Properties.Appearance.Options.UseBackColor = True
        Me.txtSon.Properties.Appearance.Options.UseFont = True
        Me.txtSon.Properties.Appearance.Options.UseForeColor = True
        Me.txtSon.Properties.ReadOnly = True
        Me.txtSon.Size = New System.Drawing.Size(711, 26)
        Me.txtSon.TabIndex = 173
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Location = New System.Drawing.Point(15, 375)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(36, 19)
        Me.LabelControl23.TabIndex = 172
        Me.LabelControl23.Text = "Son:"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(14, 404)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl24.TabIndex = 168
        Me.LabelControl24.Text = "Concepto:"
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl2.Location = New System.Drawing.Point(727, 14)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(23, 119)
        Me.SeparatorControl2.TabIndex = 167
        '
        'txtCotizacion
        '
        Me.txtCotizacion.Location = New System.Drawing.Point(920, 9)
        Me.txtCotizacion.Name = "txtCotizacion"
        Me.txtCotizacion.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCotizacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtCotizacion.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtCotizacion.Properties.Appearance.Options.UseBackColor = True
        Me.txtCotizacion.Properties.Appearance.Options.UseFont = True
        Me.txtCotizacion.Properties.Appearance.Options.UseForeColor = True
        Me.txtCotizacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCotizacion.Size = New System.Drawing.Size(146, 36)
        Me.txtCotizacion.TabIndex = 164
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(805, 12)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(109, 29)
        Me.LabelControl9.TabIndex = 161
        Me.LabelControl9.Text = "Orden No."
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(901, 152)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl13.TabIndex = 110
        Me.LabelControl13.Text = "Sub Total"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(683, 152)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl14.TabIndex = 109
        Me.LabelControl14.Text = "Valor Uni."
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(14, 152)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl16.TabIndex = 106
        Me.LabelControl16.Text = "Producto"
        '
        'btnEliminar
        '
        Me.btnEliminar.ImageOptions.Image = CType(resources.GetObject("btnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(1039, 177)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(26, 26)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.ToolTip = "Eliminar Producto"
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageOptions.Image = CType(resources.GetObject("btnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(1007, 177)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(26, 26)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.ToolTip = "Agregar Producto"
        '
        'txtCantidadP
        '
        Me.txtCantidadP.Location = New System.Drawing.Point(576, 177)
        Me.txtCantidadP.MenuManager = Me.BarManager1
        Me.txtCantidadP.Name = "txtCantidadP"
        Me.txtCantidadP.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtCantidadP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtCantidadP.Properties.Appearance.Options.UseBackColor = True
        Me.txtCantidadP.Properties.Appearance.Options.UseFont = True
        Me.txtCantidadP.Properties.Mask.EditMask = "d"
        Me.txtCantidadP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidadP.Size = New System.Drawing.Size(100, 26)
        Me.txtCantidadP.TabIndex = 6
        '
        'cboProducto
        '
        Me.cboProducto.EditValue = "SELECCIONAR"
        Me.cboProducto.Location = New System.Drawing.Point(14, 178)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cboProducto.Properties.Appearance.Options.UseFont = True
        Me.cboProducto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProducto.Properties.NullText = ""
        Me.cboProducto.Properties.PopupView = Me.gvComboProductos
        Me.cboProducto.Size = New System.Drawing.Size(556, 26)
        Me.cboProducto.TabIndex = 5
        '
        'gvComboProductos
        '
        Me.gvComboProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdProducto, Me.colID, Me.colCodigoBarra, Me.colPRESENTACION, Me.colMEDIDA, Me.colValor, Me.colIVA, Me.colSubTotal})
        Me.gvComboProductos.DetailHeight = 200
        Me.gvComboProductos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvComboProductos.Name = "gvComboProductos"
        Me.gvComboProductos.OptionsBehavior.AutoPopulateColumns = False
        Me.gvComboProductos.OptionsEditForm.PopupEditFormWidth = 1000
        Me.gvComboProductos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvComboProductos.OptionsView.ColumnAutoWidth = False
        Me.gvComboProductos.OptionsView.EnableAppearanceOddRow = True
        Me.gvComboProductos.OptionsView.ShowGroupPanel = False
        '
        'colIdProducto
        '
        Me.colIdProducto.Caption = "ID PRODUCTO"
        Me.colIdProducto.FieldName = "IDPRODUCTO"
        Me.colIdProducto.Name = "colIdProducto"
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colCodigoBarra
        '
        Me.colCodigoBarra.Caption = "CODIGO"
        Me.colCodigoBarra.FieldName = "CODIGO"
        Me.colCodigoBarra.Name = "colCodigoBarra"
        Me.colCodigoBarra.Visible = True
        Me.colCodigoBarra.VisibleIndex = 0
        Me.colCodigoBarra.Width = 90
        '
        'colPRESENTACION
        '
        Me.colPRESENTACION.Caption = "PRESENTACION"
        Me.colPRESENTACION.FieldName = "PRESENTACION"
        Me.colPRESENTACION.Name = "colPRESENTACION"
        Me.colPRESENTACION.Visible = True
        Me.colPRESENTACION.VisibleIndex = 1
        Me.colPRESENTACION.Width = 251
        '
        'colMEDIDA
        '
        Me.colMEDIDA.Caption = "MEDIDA"
        Me.colMEDIDA.FieldName = "UNIDAD"
        Me.colMEDIDA.Name = "colMEDIDA"
        Me.colMEDIDA.Visible = True
        Me.colMEDIDA.VisibleIndex = 2
        '
        'colIVA
        '
        Me.colIVA.Caption = "IVA"
        Me.colIVA.DisplayFormat.FormatString = "C0"
        Me.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIVA.FieldName = "IVA"
        Me.colIVA.Name = "colIVA"
        Me.colIVA.Visible = True
        Me.colIVA.VisibleIndex = 5
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(576, 152)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(62, 19)
        Me.LabelControl15.TabIndex = 108
        Me.LabelControl15.Text = "Cantidad"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(14, 423)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtConcepto.Properties.Appearance.Options.UseFont = True
        Me.txtConcepto.Size = New System.Drawing.Size(190, 122)
        Me.txtConcepto.TabIndex = 169
        '
        'Bar2
        '
        Me.Bar2.BarName = "Herramientas"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.Text = "Herramientas"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(854, 9)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl2.TabIndex = 170
        Me.LabelControl2.Text = "ID:"
        Me.LabelControl2.Visible = False
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Herramientas"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(879, 6)
        Me.txtID.MenuManager = Me.BarManager1
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 171
        Me.txtID.Visible = False
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(1079, 0)
        '
        'Bar4
        '
        Me.Bar4.BarName = "Herramientas"
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar4.Text = "Herramientas"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl1.Manager = Nothing
        Me.BarDockControl1.Size = New System.Drawing.Size(1079, 0)
        '
        'colCTotal
        '
        Me.colCTotal.Caption = "TOTAL"
        Me.colCTotal.DisplayFormat.FormatString = "C0"
        Me.colCTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCTotal.FieldName = "TOTAL"
        Me.colCTotal.Name = "colCTotal"
        Me.colCTotal.Visible = True
        Me.colCTotal.VisibleIndex = 9
        '
        'colDescuento
        '
        Me.colDescuento.Caption = "DESCUENTO"
        Me.colDescuento.DisplayFormat.FormatString = "C0"
        Me.colDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDescuento.FieldName = "DESCUENTO"
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.Visible = True
        Me.colDescuento.VisibleIndex = 8
        '
        'colCValor
        '
        Me.colCValor.Caption = "VALOR"
        Me.colCValor.DisplayFormat.FormatString = "C0"
        Me.colCValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCValor.FieldName = "VALOR"
        Me.colCValor.Name = "colCValor"
        Me.colCValor.Visible = True
        Me.colCValor.VisibleIndex = 7
        '
        'colCConcepto
        '
        Me.colCConcepto.Caption = "CONCEPTO"
        Me.colCConcepto.FieldName = "CONCEPTO"
        Me.colCConcepto.Name = "colCConcepto"
        Me.colCConcepto.Visible = True
        Me.colCConcepto.VisibleIndex = 6
        Me.colCConcepto.Width = 185
        '
        'colCFechaVencimiento
        '
        Me.colCFechaVencimiento.Caption = "VENCIMIENTO"
        Me.colCFechaVencimiento.FieldName = "FECHA_VENCIMIENTO"
        Me.colCFechaVencimiento.Name = "colCFechaVencimiento"
        Me.colCFechaVencimiento.Visible = True
        Me.colCFechaVencimiento.VisibleIndex = 2
        Me.colCFechaVencimiento.Width = 80
        '
        'colCFechaOrden
        '
        Me.colCFechaOrden.Caption = "FECHA"
        Me.colCFechaOrden.FieldName = "FECHA_ORDEN"
        Me.colCFechaOrden.Name = "colCFechaOrden"
        Me.colCFechaOrden.Visible = True
        Me.colCFechaOrden.VisibleIndex = 1
        Me.colCFechaOrden.Width = 56
        '
        'colCId
        '
        Me.colCId.Caption = "ORDEN"
        Me.colCId.FieldName = "ORDEN"
        Me.colCId.Name = "colCId"
        Me.colCId.Visible = True
        Me.colCId.VisibleIndex = 0
        Me.colCId.Width = 47
        '
        'gvConsultar
        '
        Me.gvConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCId, Me.colCFechaOrden, Me.colCFechaVencimiento, Me.colCNombre, Me.colCConcepto, Me.colCValor, Me.colDescuento, Me.colCTotal, Me.colCTelefono, Me.colCEmail, Me.colESTADO})
        Me.gvConsultar.GridControl = Me.GCConsultar
        Me.gvConsultar.Name = "gvConsultar"
        Me.gvConsultar.OptionsBehavior.Editable = False
        Me.gvConsultar.OptionsBehavior.ReadOnly = True
        Me.gvConsultar.OptionsView.ColumnAutoWidth = False
        Me.gvConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.gvConsultar.OptionsView.ShowFooter = True
        Me.gvConsultar.OptionsView.ShowGroupPanel = False
        Me.gvConsultar.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCId, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colCNombre
        '
        Me.colCNombre.Caption = "CLIENTE"
        Me.colCNombre.FieldName = "NOMBRE"
        Me.colCNombre.Name = "colCNombre"
        Me.colCNombre.Visible = True
        Me.colCNombre.VisibleIndex = 3
        Me.colCNombre.Width = 214
        '
        'colCTelefono
        '
        Me.colCTelefono.Caption = "TELEFONO"
        Me.colCTelefono.FieldName = "TELEFONO"
        Me.colCTelefono.Name = "colCTelefono"
        Me.colCTelefono.Visible = True
        Me.colCTelefono.VisibleIndex = 4
        Me.colCTelefono.Width = 82
        '
        'colCEmail
        '
        Me.colCEmail.Caption = "EMAIL"
        Me.colCEmail.FieldName = "CORREO_ELECTRONICO"
        Me.colCEmail.Name = "colCEmail"
        Me.colCEmail.Visible = True
        Me.colCEmail.VisibleIndex = 5
        Me.colCEmail.Width = 165
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 10
        '
        'GCConsultar
        '
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.gvConsultar
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(1077, 573)
        Me.GCConsultar.TabIndex = 14
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvConsultar})
        '
        'xtpOrdenesGeneradas
        '
        Me.xtpOrdenesGeneradas.Controls.Add(Me.GCConsultar)
        Me.xtpOrdenesGeneradas.Name = "xtpOrdenesGeneradas"
        Me.xtpOrdenesGeneradas.Size = New System.Drawing.Size(1077, 573)
        Me.xtpOrdenesGeneradas.Text = "Ordenes Generadas"
        '
        'xtcOrdenesServicios
        '
        Me.xtcOrdenesServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcOrdenesServicios.Location = New System.Drawing.Point(0, 24)
        Me.xtcOrdenesServicios.Name = "xtcOrdenesServicios"
        Me.xtcOrdenesServicios.SelectedTabPage = Me.xtpOrdenesGeneradas
        Me.xtcOrdenesServicios.Size = New System.Drawing.Size(1079, 598)
        Me.xtcOrdenesServicios.TabIndex = 169
        Me.xtcOrdenesServicios.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpOrdenesGeneradas, Me.xtpOrdenesProductos})
        '
        'frmOrdenServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 622)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.xtcOrdenesServicios)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.BarDockControl2)
        Me.IconOptions.Icon = CType(resources.GetObject("frmOrdenServicio.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdenServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes de Servicios"
        Me.xtpOrdenesProductos.ResumeLayout(False)
        Me.xtpOrdenesProductos.PerformLayout()
        CType(Me.GCDatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtFechaExpedicion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaExpedicion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtCDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIVA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GCDetallePagoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetallePagoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormaPagoValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorUnitarioP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTarifaProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCotizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvComboProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpOrdenesGeneradas.ResumeLayout(False)
        CType(Me.xtcOrdenesServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcOrdenesServicios.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpOrdenesProductos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents peFoto As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorUnitarioP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTarifaProducto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl4 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtSon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtCotizacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimirCotizacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents xtcOrdenesServicios As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpOrdenesGeneradas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCFechaOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCFechaVencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboFactura As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bbiVistaPrevia As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bsiImprimir As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bbiFacturaConcepto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRelacionFactura As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiFactura As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDetalleFactura As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCantidadP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboProducto As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvComboProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoBarra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESENTACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEDIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents txtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboCliente As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDCLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CONTACTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TELEFONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIVA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCSubTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GCProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDProductos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblValor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFormaPagoValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCDetallePagoDocumento As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetallePagoDocumento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTODETALLEPAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALORDETALLEPAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaExpedicion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaVencimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GCDatosCliente As DevExpress.XtraGrid.GridControl
    Friend WithEvents TVDatosCliente As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents TileViewColumn1 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn2 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn3 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colApellidos As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colEdad As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn4 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn5 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colFoto As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colCTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDPRESENTACIONPRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
End Class

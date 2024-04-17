<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCotizaciones
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCotizaciones))
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.TileViewColumn3 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn5 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn2 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.xtpCotizacionesGeneradas = New DevExpress.XtraTab.XtraTabPage()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.gvConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCFechaCotizacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCFechaVencimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colCValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSUBTOTALDC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALORDC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCIONDC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colFECHASERVICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDDC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvServicios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSALON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERVICIODC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHORAINICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHORAFINAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCUENTODC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNETO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCServicios = New DevExpress.XtraGrid.GridControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimirCotizacion = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCorreo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClientes = New DevExpress.XtraBars.BarButtonItem()
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
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.gvComboServicios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERVICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colVALOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSon = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtCotizacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpCotizacionesProductos = New DevExpress.XtraTab.XtraTabPage()
        Me.dtHoraFinal = New DevExpress.XtraEditors.TimeEdit()
        Me.dtHoraInicio = New DevExpress.XtraEditors.TimeEdit()
        Me.SeparatorControl3 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.dtFechaServicio = New DevExpress.XtraEditors.DateEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboEventos = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIVA = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCSubTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtFechaExpedicion = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaVencimiento = New DevExpress.XtraEditors.DateEdit()
        Me.GCDatosCliente = New DevExpress.XtraGrid.GridControl()
        Me.TVDatosCliente = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.TileViewColumn1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colApellidos = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colEdad = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn4 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colFoto = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.cboCliente = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDCLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CONTACTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TELEFONO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorUnitarioP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cboSalon = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCantidadP = New DevExpress.XtraEditors.TextEdit()
        Me.cboServicios = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.xtcCotizaciones = New DevExpress.XtraTab.XtraTabControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpCotizacionesGeneradas.SuspendLayout()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvComboServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCotizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpCotizacionesProductos.SuspendLayout()
        CType(Me.dtHoraFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtHoraInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaServicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaServicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEventos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtCDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIVA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtFechaExpedicion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaExpedicion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorUnitarioP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSalon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboServicios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcCotizaciones.SuspendLayout()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'xtpCotizacionesGeneradas
        '
        Me.xtpCotizacionesGeneradas.Controls.Add(Me.GCConsultar)
        Me.xtpCotizacionesGeneradas.Name = "xtpCotizacionesGeneradas"
        Me.xtpCotizacionesGeneradas.Size = New System.Drawing.Size(1211, 487)
        Me.xtpCotizacionesGeneradas.Text = "Cotizaciones Generadas"
        '
        'GCConsultar
        '
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.gvConsultar
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit3})
        Me.GCConsultar.Size = New System.Drawing.Size(1211, 487)
        Me.GCConsultar.TabIndex = 14
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvConsultar})
        '
        'gvConsultar
        '
        Me.gvConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCId, Me.colCFechaCotizacion, Me.colCFechaVencimiento, Me.colCNombre, Me.colCConcepto, Me.colCValor, Me.colDescuento, Me.colCTotal, Me.colCTelefono, Me.colCEmail})
        Me.gvConsultar.GridControl = Me.GCConsultar
        Me.gvConsultar.Name = "gvConsultar"
        Me.gvConsultar.OptionsBehavior.Editable = False
        Me.gvConsultar.OptionsBehavior.ReadOnly = True
        Me.gvConsultar.OptionsView.ColumnAutoWidth = False
        Me.gvConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.gvConsultar.OptionsView.RowAutoHeight = True
        Me.gvConsultar.OptionsView.ShowFooter = True
        Me.gvConsultar.OptionsView.ShowGroupPanel = False
        Me.gvConsultar.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCId, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colCId
        '
        Me.colCId.Caption = "COTIZACION"
        Me.colCId.FieldName = "COTIZACION"
        Me.colCId.Name = "colCId"
        Me.colCId.Visible = True
        Me.colCId.VisibleIndex = 0
        '
        'colCFechaCotizacion
        '
        Me.colCFechaCotizacion.Caption = "FECHA"
        Me.colCFechaCotizacion.FieldName = "FECHA_COTIZACION"
        Me.colCFechaCotizacion.Name = "colCFechaCotizacion"
        Me.colCFechaCotizacion.Visible = True
        Me.colCFechaCotizacion.VisibleIndex = 1
        Me.colCFechaCotizacion.Width = 69
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
        'colCNombre
        '
        Me.colCNombre.Caption = "CLIENTE"
        Me.colCNombre.FieldName = "NOMBRE"
        Me.colCNombre.Name = "colCNombre"
        Me.colCNombre.Visible = True
        Me.colCNombre.VisibleIndex = 3
        Me.colCNombre.Width = 188
        '
        'colCConcepto
        '
        Me.colCConcepto.Caption = "CONCEPTO"
        Me.colCConcepto.ColumnEdit = Me.RepositoryItemMemoEdit3
        Me.colCConcepto.FieldName = "CONCEPTO"
        Me.colCConcepto.Name = "colCConcepto"
        Me.colCConcepto.Visible = True
        Me.colCConcepto.VisibleIndex = 6
        Me.colCConcepto.Width = 333
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
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
        'colCTelefono
        '
        Me.colCTelefono.Caption = "TELEFONO"
        Me.colCTelefono.FieldName = "TELEFONO"
        Me.colCTelefono.Name = "colCTelefono"
        Me.colCTelefono.Visible = True
        Me.colCTelefono.VisibleIndex = 4
        Me.colCTelefono.Width = 81
        '
        'colCEmail
        '
        Me.colCEmail.Caption = "EMAIL"
        Me.colCEmail.FieldName = "EMAIL"
        Me.colCEmail.Name = "colCEmail"
        Me.colCEmail.Visible = True
        Me.colCEmail.VisibleIndex = 5
        Me.colCEmail.Width = 147
        '
        'colSUBTOTALDC
        '
        Me.colSUBTOTALDC.Caption = "VALOR TOTAL"
        Me.colSUBTOTALDC.DisplayFormat.FormatString = "C0"
        Me.colSUBTOTALDC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSUBTOTALDC.FieldName = "SUBTOTAL"
        Me.colSUBTOTALDC.Name = "colSUBTOTALDC"
        Me.colSUBTOTALDC.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SUBTOTAL", "TOTAL={0:C0}")})
        Me.colSUBTOTALDC.Visible = True
        Me.colSUBTOTALDC.VisibleIndex = 9
        Me.colSUBTOTALDC.Width = 94
        '
        'colVALORDC
        '
        Me.colVALORDC.Caption = "VAL UNIT"
        Me.colVALORDC.DisplayFormat.FormatString = "C0"
        Me.colVALORDC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALORDC.FieldName = "VALOR"
        Me.colVALORDC.Name = "colVALORDC"
        Me.colVALORDC.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "SUMA={0:C0}")})
        Me.colVALORDC.Visible = True
        Me.colVALORDC.VisibleIndex = 7
        Me.colVALORDC.Width = 78
        '
        'colCANTIDAD
        '
        Me.colCANTIDAD.Caption = "CANTIDAD"
        Me.colCANTIDAD.FieldName = "CANTIDAD"
        Me.colCANTIDAD.Name = "colCANTIDAD"
        Me.colCANTIDAD.Visible = True
        Me.colCANTIDAD.VisibleIndex = 6
        Me.colCANTIDAD.Width = 59
        '
        'colDESCRIPCIONDC
        '
        Me.colDESCRIPCIONDC.Caption = "DESCRIPCION"
        Me.colDESCRIPCIONDC.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colDESCRIPCIONDC.FieldName = "DESCRIPCION"
        Me.colDESCRIPCIONDC.Name = "colDESCRIPCIONDC"
        Me.colDESCRIPCIONDC.Visible = True
        Me.colDESCRIPCIONDC.VisibleIndex = 3
        Me.colDESCRIPCIONDC.Width = 215
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colFECHASERVICIO
        '
        Me.colFECHASERVICIO.Caption = "FECHA SERVICIO"
        Me.colFECHASERVICIO.FieldName = "FECHA_SERVICIO"
        Me.colFECHASERVICIO.Name = "colFECHASERVICIO"
        Me.colFECHASERVICIO.Visible = True
        Me.colFECHASERVICIO.VisibleIndex = 0
        Me.colFECHASERVICIO.Width = 89
        '
        'colIDDC
        '
        Me.colIDDC.Caption = "ID"
        Me.colIDDC.FieldName = "ID"
        Me.colIDDC.Name = "colIDDC"
        '
        'gvServicios
        '
        Me.gvServicios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDDC, Me.colFECHASERVICIO, Me.colSALON, Me.colSERVICIODC, Me.colDESCRIPCIONDC, Me.colHORAINICIO, Me.colHORAFINAL, Me.colCANTIDAD, Me.colVALORDC, Me.colDESCUENTODC, Me.colSUBTOTALDC, Me.colNETO})
        Me.gvServicios.GridControl = Me.GCServicios
        Me.gvServicios.Name = "gvServicios"
        Me.gvServicios.OptionsBehavior.Editable = False
        Me.gvServicios.OptionsPrint.EnableAppearanceOddRow = True
        Me.gvServicios.OptionsPrint.ExpandAllDetails = True
        Me.gvServicios.OptionsPrint.ExpandAllGroups = False
        Me.gvServicios.OptionsPrint.PrintFooter = False
        Me.gvServicios.OptionsView.ColumnAutoWidth = False
        Me.gvServicios.OptionsView.EnableAppearanceOddRow = True
        Me.gvServicios.OptionsView.RowAutoHeight = True
        Me.gvServicios.OptionsView.ShowGroupPanel = False
        '
        'colSALON
        '
        Me.colSALON.Caption = "SALON"
        Me.colSALON.FieldName = "SALON"
        Me.colSALON.Name = "colSALON"
        Me.colSALON.Visible = True
        Me.colSALON.VisibleIndex = 1
        Me.colSALON.Width = 87
        '
        'colSERVICIODC
        '
        Me.colSERVICIODC.Caption = "SERVICIO"
        Me.colSERVICIODC.FieldName = "SERVICIO"
        Me.colSERVICIODC.Name = "colSERVICIODC"
        Me.colSERVICIODC.Visible = True
        Me.colSERVICIODC.VisibleIndex = 2
        Me.colSERVICIODC.Width = 114
        '
        'colHORAINICIO
        '
        Me.colHORAINICIO.Caption = "HORA INICIO"
        Me.colHORAINICIO.FieldName = "HORA_INICIO"
        Me.colHORAINICIO.Name = "colHORAINICIO"
        Me.colHORAINICIO.Visible = True
        Me.colHORAINICIO.VisibleIndex = 4
        Me.colHORAINICIO.Width = 68
        '
        'colHORAFINAL
        '
        Me.colHORAFINAL.Caption = "HORA FINAL"
        Me.colHORAFINAL.FieldName = "HORA_FINAL"
        Me.colHORAFINAL.Name = "colHORAFINAL"
        Me.colHORAFINAL.Visible = True
        Me.colHORAFINAL.VisibleIndex = 5
        Me.colHORAFINAL.Width = 68
        '
        'colDESCUENTODC
        '
        Me.colDESCUENTODC.Caption = "DESCUENTO"
        Me.colDESCUENTODC.DisplayFormat.FormatString = "C0"
        Me.colDESCUENTODC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDESCUENTODC.FieldName = "DESCUENTO"
        Me.colDESCUENTODC.Name = "colDESCUENTODC"
        Me.colDESCUENTODC.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DESCUENTO", "DESCUENTO={0:C0}")})
        Me.colDESCUENTODC.Visible = True
        Me.colDESCUENTODC.VisibleIndex = 8
        Me.colDESCUENTODC.Width = 78
        '
        'colNETO
        '
        Me.colNETO.Caption = "NETO"
        Me.colNETO.FieldName = "NETO"
        Me.colNETO.Name = "colNETO"
        Me.colNETO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETO", "SUMA={0:C0}")})
        '
        'GCServicios
        '
        Me.GCServicios.Location = New System.Drawing.Point(11, 297)
        Me.GCServicios.MainView = Me.gvServicios
        Me.GCServicios.MenuManager = Me.BarManager1
        Me.GCServicios.Name = "GCServicios"
        Me.GCServicios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit2, Me.RepositoryItemCheckEdit1})
        Me.GCServicios.Size = New System.Drawing.Size(898, 145)
        Me.GCServicios.TabIndex = 107
        Me.GCServicios.UseEmbeddedNavigator = True
        Me.GCServicios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvServicios})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.BarDockControl2)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiNuevo, Me.bbiGuardar, Me.bbiImprimir, Me.bbiAnular, Me.cboFactura, Me.bbiVistaPrevia, Me.bsiImprimir, Me.bbiActualizar, Me.bbiFactura, Me.bbiDetalleFactura, Me.bbiConsultar, Me.bbiFacturaConcepto, Me.bbiRelacionFactura, Me.bbiClientes, Me.bbiImprimirCotizacion, Me.bbiCorreo})
        Me.BarManager1.MaxItemId = 16
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        '
        'Bar3
        '
        Me.Bar3.BarName = "Herramientas"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.FloatLocation = New System.Drawing.Point(86, 132)
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.bbiAnular, False), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimirCotizacion, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCorreo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiClientes, True)})
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
        Me.bbiAnular.Caption = "Anular Factura"
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
        'bbiCorreo
        '
        Me.bbiCorreo.Caption = "Enviar por Correo"
        Me.bbiCorreo.Id = 15
        Me.bbiCorreo.ImageOptions.Image = CType(resources.GetObject("bbiCorreo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiCorreo.Name = "bbiCorreo"
        '
        'bbiClientes
        '
        Me.bbiClientes.Caption = "Registro de Clientes"
        Me.bbiClientes.Id = 13
        Me.bbiClientes.ImageOptions.Image = CType(resources.GetObject("bbiClientes.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiClientes.Name = "bbiClientes"
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl2.Manager = Me.BarManager1
        Me.BarDockControl2.Size = New System.Drawing.Size(1213, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 536)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1213, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 512)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1213, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 512)
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
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.CheckBox
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'gvComboServicios
        '
        Me.gvComboServicios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colSERVICIO, Me.colDESCRIPCION, Me.colVALOR})
        Me.gvComboServicios.DetailHeight = 200
        Me.gvComboServicios.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvComboServicios.Name = "gvComboServicios"
        Me.gvComboServicios.OptionsBehavior.AutoPopulateColumns = False
        Me.gvComboServicios.OptionsEditForm.PopupEditFormWidth = 600
        Me.gvComboServicios.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvComboServicios.OptionsView.EnableAppearanceOddRow = True
        Me.gvComboServicios.OptionsView.RowAutoHeight = True
        Me.gvComboServicios.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colSERVICIO
        '
        Me.colSERVICIO.Caption = "SERVICIO"
        Me.colSERVICIO.FieldName = "SERVICIO"
        Me.colSERVICIO.Name = "colSERVICIO"
        Me.colSERVICIO.Visible = True
        Me.colSERVICIO.VisibleIndex = 0
        Me.colSERVICIO.Width = 209
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "DESCRIPCION"
        Me.colDESCRIPCION.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 1
        Me.colDESCRIPCION.Width = 308
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colVALOR
        '
        Me.colVALOR.Caption = "VALOR"
        Me.colVALOR.DisplayFormat.FormatString = "C0"
        Me.colVALOR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALOR.FieldName = "VALOR"
        Me.colVALOR.Name = "colVALOR"
        Me.colVALOR.Visible = True
        Me.colVALOR.VisibleIndex = 2
        Me.colVALOR.Width = 85
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(14, 14)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl25.TabIndex = 181
        Me.LabelControl25.Text = "Cliente:"
        '
        'txtSon
        '
        Me.txtSon.Location = New System.Drawing.Point(69, 450)
        Me.txtSon.Name = "txtSon"
        Me.txtSon.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSon.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtSon.Properties.Appearance.Options.UseBackColor = True
        Me.txtSon.Properties.Appearance.Options.UseFont = True
        Me.txtSon.Properties.Appearance.Options.UseForeColor = True
        Me.txtSon.Properties.ReadOnly = True
        Me.txtSon.Size = New System.Drawing.Size(840, 26)
        Me.txtSon.TabIndex = 173
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Location = New System.Drawing.Point(16, 453)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(36, 19)
        Me.LabelControl23.TabIndex = 172
        Me.LabelControl23.Text = "Son:"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(14, 186)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl24.TabIndex = 168
        Me.LabelControl24.Text = "Concepto:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(14, 203)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(336, 86)
        Me.txtConcepto.TabIndex = 169
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl2.Location = New System.Drawing.Point(356, 9)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(23, 282)
        Me.SeparatorControl2.TabIndex = 167
        '
        'txtCotizacion
        '
        Me.txtCotizacion.Location = New System.Drawing.Point(1073, 14)
        Me.txtCotizacion.Name = "txtCotizacion"
        Me.txtCotizacion.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCotizacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtCotizacion.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtCotizacion.Properties.Appearance.Options.UseBackColor = True
        Me.txtCotizacion.Properties.Appearance.Options.UseFont = True
        Me.txtCotizacion.Properties.Appearance.Options.UseForeColor = True
        Me.txtCotizacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCotizacion.Size = New System.Drawing.Size(129, 32)
        Me.txtCotizacion.TabIndex = 164
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(965, 22)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(102, 19)
        Me.LabelControl9.TabIndex = 161
        Me.LabelControl9.Text = "Cotización No."
        '
        'xtpCotizacionesProductos
        '
        Me.xtpCotizacionesProductos.Controls.Add(Me.dtHoraFinal)
        Me.xtpCotizacionesProductos.Controls.Add(Me.dtHoraInicio)
        Me.xtpCotizacionesProductos.Controls.Add(Me.SeparatorControl3)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl10)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl8)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl7)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl5)
        Me.xtpCotizacionesProductos.Controls.Add(Me.txtDescripcion)
        Me.xtpCotizacionesProductos.Controls.Add(Me.dtFechaServicio)
        Me.xtpCotizacionesProductos.Controls.Add(Me.SeparatorControl1)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl4)
        Me.xtpCotizacionesProductos.Controls.Add(Me.cboEventos)
        Me.xtpCotizacionesProductos.Controls.Add(Me.GroupBox2)
        Me.xtpCotizacionesProductos.Controls.Add(Me.GroupBox3)
        Me.xtpCotizacionesProductos.Controls.Add(Me.GCDatosCliente)
        Me.xtpCotizacionesProductos.Controls.Add(Me.cboCliente)
        Me.xtpCotizacionesProductos.Controls.Add(Me.txtDescuento)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl3)
        Me.xtpCotizacionesProductos.Controls.Add(Me.txtSubTotal)
        Me.xtpCotizacionesProductos.Controls.Add(Me.txtValorUnitarioP)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl1)
        Me.xtpCotizacionesProductos.Controls.Add(Me.cboSalon)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl25)
        Me.xtpCotizacionesProductos.Controls.Add(Me.txtSon)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl23)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl24)
        Me.xtpCotizacionesProductos.Controls.Add(Me.txtConcepto)
        Me.xtpCotizacionesProductos.Controls.Add(Me.SeparatorControl2)
        Me.xtpCotizacionesProductos.Controls.Add(Me.txtCotizacion)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl9)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl13)
        Me.xtpCotizacionesProductos.Controls.Add(Me.GCServicios)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl14)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl16)
        Me.xtpCotizacionesProductos.Controls.Add(Me.btnEliminar)
        Me.xtpCotizacionesProductos.Controls.Add(Me.btnAgregar)
        Me.xtpCotizacionesProductos.Controls.Add(Me.txtCantidadP)
        Me.xtpCotizacionesProductos.Controls.Add(Me.cboServicios)
        Me.xtpCotizacionesProductos.Controls.Add(Me.LabelControl15)
        Me.xtpCotizacionesProductos.Name = "xtpCotizacionesProductos"
        Me.xtpCotizacionesProductos.Size = New System.Drawing.Size(1211, 487)
        Me.xtpCotizacionesProductos.Text = "Cotizar Servicios"
        '
        'dtHoraFinal
        '
        Me.dtHoraFinal.EditValue = Nothing
        Me.dtHoraFinal.Location = New System.Drawing.Point(798, 199)
        Me.dtHoraFinal.Name = "dtHoraFinal"
        Me.dtHoraFinal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.dtHoraFinal.Properties.Appearance.Options.UseFont = True
        Me.dtHoraFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtHoraFinal.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.dtHoraFinal.Properties.Mask.EditMask = "t"
        Me.dtHoraFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtHoraFinal.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.dtHoraFinal.Size = New System.Drawing.Size(111, 26)
        Me.dtHoraFinal.TabIndex = 265
        '
        'dtHoraInicio
        '
        Me.dtHoraInicio.EditValue = Nothing
        Me.dtHoraInicio.Location = New System.Drawing.Point(798, 150)
        Me.dtHoraInicio.Name = "dtHoraInicio"
        Me.dtHoraInicio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.dtHoraInicio.Properties.Appearance.Options.UseFont = True
        Me.dtHoraInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtHoraInicio.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.dtHoraInicio.Properties.Mask.EditMask = "t"
        Me.dtHoraInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtHoraInicio.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.dtHoraInicio.Size = New System.Drawing.Size(111, 26)
        Me.dtHoraInicio.TabIndex = 264
        '
        'SeparatorControl3
        '
        Me.SeparatorControl3.Location = New System.Drawing.Point(381, 52)
        Me.SeparatorControl3.Name = "SeparatorControl3"
        Me.SeparatorControl3.Size = New System.Drawing.Size(528, 19)
        Me.SeparatorControl3.TabIndex = 263
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(798, 179)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(72, 19)
        Me.LabelControl10.TabIndex = 262
        Me.LabelControl10.Text = "Hora Final"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(798, 129)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(78, 19)
        Me.LabelControl8.TabIndex = 260
        Me.LabelControl8.Text = "Hora Inicio"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(381, 126)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(81, 19)
        Me.LabelControl7.TabIndex = 258
        Me.LabelControl7.Text = "Descripcion"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(798, 78)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(100, 19)
        Me.LabelControl5.TabIndex = 257
        Me.LabelControl5.Text = "Fecha Servicio"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(381, 149)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(400, 76)
        Me.txtDescripcion.TabIndex = 256
        '
        'dtFechaServicio
        '
        Me.dtFechaServicio.EditValue = Nothing
        Me.dtFechaServicio.Location = New System.Drawing.Point(798, 100)
        Me.dtFechaServicio.Name = "dtFechaServicio"
        Me.dtFechaServicio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.dtFechaServicio.Properties.Appearance.Options.UseFont = True
        Me.dtFechaServicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaServicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaServicio.Properties.CalendarTimeProperties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtFechaServicio.Properties.CalendarTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Custom
        Me.dtFechaServicio.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = True
        Me.dtFechaServicio.Properties.DisplayFormat.FormatString = ""
        Me.dtFechaServicio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaServicio.Properties.EditFormat.FormatString = ""
        Me.dtFechaServicio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaServicio.Size = New System.Drawing.Size(111, 26)
        Me.dtFechaServicio.TabIndex = 191
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(923, 14)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(19, 458)
        Me.SeparatorControl1.TabIndex = 255
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(14, 136)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl4.TabIndex = 254
        Me.LabelControl4.Text = "Evento:"
        '
        'cboEventos
        '
        Me.cboEventos.Location = New System.Drawing.Point(14, 154)
        Me.cboEventos.Name = "cboEventos"
        Me.cboEventos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cboEventos.Properties.Appearance.Options.UseFont = True
        Me.cboEventos.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboEventos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEventos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EVENTO", "EVENTO")})
        Me.cboEventos.Properties.NullText = ""
        Me.cboEventos.Properties.ShowHeader = False
        Me.cboEventos.Size = New System.Drawing.Size(336, 26)
        Me.cboEventos.TabIndex = 253
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
        Me.GroupBox2.Location = New System.Drawing.Point(957, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 182)
        Me.GroupBox2.TabIndex = 252
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales Cotizacion"
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
        Me.txtCDescuento.Location = New System.Drawing.Point(110, 69)
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
        Me.txtIVA.Location = New System.Drawing.Point(110, 105)
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
        Me.txtCSubTotal.Location = New System.Drawing.Point(110, 35)
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
        Me.txtTotal.Location = New System.Drawing.Point(110, 142)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtFechaExpedicion)
        Me.GroupBox3.Controls.Add(Me.LabelControl6)
        Me.GroupBox3.Controls.Add(Me.LabelControl18)
        Me.GroupBox3.Controls.Add(Me.dtFechaVencimiento)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(957, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 94)
        Me.GroupBox3.TabIndex = 251
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha Cotizacion"
        '
        'dtFechaExpedicion
        '
        Me.dtFechaExpedicion.EditValue = Nothing
        Me.dtFechaExpedicion.Location = New System.Drawing.Point(125, 27)
        Me.dtFechaExpedicion.Name = "dtFechaExpedicion"
        Me.dtFechaExpedicion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.dtFechaExpedicion.Properties.Appearance.Options.UseFont = True
        Me.dtFechaExpedicion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaExpedicion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaExpedicion.Properties.DisplayFormat.FormatString = ""
        Me.dtFechaExpedicion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaExpedicion.Properties.EditFormat.FormatString = ""
        Me.dtFechaExpedicion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaExpedicion.Size = New System.Drawing.Size(110, 26)
        Me.dtFechaExpedicion.TabIndex = 206
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(37, 30)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(82, 19)
        Me.LabelControl6.TabIndex = 204
        Me.LabelControl6.Text = "Expedición:"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Location = New System.Drawing.Point(26, 62)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(93, 19)
        Me.LabelControl18.TabIndex = 205
        Me.LabelControl18.Text = "Vencimiento:"
        '
        'dtFechaVencimiento
        '
        Me.dtFechaVencimiento.EditValue = Nothing
        Me.dtFechaVencimiento.Location = New System.Drawing.Point(124, 59)
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
        'GCDatosCliente
        '
        Me.GCDatosCliente.EmbeddedNavigator.Appearance.BorderColor = System.Drawing.Color.Red
        Me.GCDatosCliente.EmbeddedNavigator.Appearance.Options.UseBorderColor = True
        Me.GCDatosCliente.Location = New System.Drawing.Point(14, 37)
        Me.GCDatosCliente.MainView = Me.TVDatosCliente
        Me.GCDatosCliente.Name = "GCDatosCliente"
        Me.GCDatosCliente.Size = New System.Drawing.Size(336, 91)
        Me.GCDatosCliente.TabIndex = 250
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
        Me.TVDatosCliente.OptionsTiles.ItemSize = New System.Drawing.Size(320, 72)
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
        Me.cboCliente.Size = New System.Drawing.Size(281, 20)
        Me.cboCliente.TabIndex = 1
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
        Me.txtDescuento.Location = New System.Drawing.Point(593, 265)
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
        Me.txtDescuento.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(593, 244)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 19)
        Me.LabelControl3.TabIndex = 187
        Me.LabelControl3.Text = "Descuento"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(699, 265)
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
        Me.txtSubTotal.Size = New System.Drawing.Size(146, 26)
        Me.txtSubTotal.TabIndex = 9
        '
        'txtValorUnitarioP
        '
        Me.txtValorUnitarioP.Location = New System.Drawing.Point(487, 265)
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
        Me.txtValorUnitarioP.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(381, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl1.TabIndex = 183
        Me.LabelControl1.Text = "Salon:"
        '
        'cboSalon
        '
        Me.cboSalon.Location = New System.Drawing.Point(432, 18)
        Me.cboSalon.Name = "cboSalon"
        Me.cboSalon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cboSalon.Properties.Appearance.Options.UseFont = True
        Me.cboSalon.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboSalon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSalon.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SALON", "SALON")})
        Me.cboSalon.Properties.NullText = ""
        Me.cboSalon.Properties.ShowHeader = False
        Me.cboSalon.Size = New System.Drawing.Size(349, 26)
        Me.cboSalon.TabIndex = 2
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(704, 244)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl13.TabIndex = 110
        Me.LabelControl13.Text = "Sub Total"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(487, 244)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl14.TabIndex = 109
        Me.LabelControl14.Text = "Valor Uni."
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(381, 77)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(62, 19)
        Me.LabelControl16.TabIndex = 106
        Me.LabelControl16.Text = "Servicios"
        '
        'btnEliminar
        '
        Me.btnEliminar.ImageOptions.Image = CType(resources.GetObject("btnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(883, 265)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(26, 26)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.ToolTip = "Eliminar Servicio"
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageOptions.Image = CType(resources.GetObject("btnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(851, 265)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(26, 26)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.ToolTip = "Agregar Servicio"
        '
        'txtCantidadP
        '
        Me.txtCantidadP.Location = New System.Drawing.Point(381, 265)
        Me.txtCantidadP.MenuManager = Me.BarManager1
        Me.txtCantidadP.Name = "txtCantidadP"
        Me.txtCantidadP.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtCantidadP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtCantidadP.Properties.Appearance.Options.UseBackColor = True
        Me.txtCantidadP.Properties.Appearance.Options.UseFont = True
        Me.txtCantidadP.Properties.Mask.EditMask = "d"
        Me.txtCantidadP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidadP.Size = New System.Drawing.Size(100, 26)
        Me.txtCantidadP.TabIndex = 4
        '
        'cboServicios
        '
        Me.cboServicios.EditValue = "SELECCIONAR"
        Me.cboServicios.Location = New System.Drawing.Point(381, 99)
        Me.cboServicios.Name = "cboServicios"
        Me.cboServicios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cboServicios.Properties.Appearance.Options.UseFont = True
        Me.cboServicios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboServicios.Properties.NullText = ""
        Me.cboServicios.Properties.PopupView = Me.gvComboServicios
        Me.cboServicios.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.cboServicios.Size = New System.Drawing.Size(400, 26)
        Me.cboServicios.TabIndex = 3
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(381, 244)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(62, 19)
        Me.LabelControl15.TabIndex = 108
        Me.LabelControl15.Text = "Cantidad"
        '
        'Bar4
        '
        Me.Bar4.BarName = "Herramientas"
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar4.Text = "Herramientas"
        '
        'xtcCotizaciones
        '
        Me.xtcCotizaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcCotizaciones.Location = New System.Drawing.Point(0, 24)
        Me.xtcCotizaciones.Name = "xtcCotizaciones"
        Me.xtcCotizaciones.SelectedTabPage = Me.xtpCotizacionesGeneradas
        Me.xtcCotizaciones.Size = New System.Drawing.Size(1213, 512)
        Me.xtcCotizaciones.TabIndex = 85
        Me.xtcCotizaciones.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpCotizacionesGeneradas, Me.xtpCotizacionesProductos})
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(1213, 0)
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Herramientas"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Herramientas"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.Text = "Herramientas"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl1.Manager = Nothing
        Me.BarDockControl1.Size = New System.Drawing.Size(1213, 0)
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(879, 12)
        Me.txtID.MenuManager = Me.BarManager1
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 166
        Me.txtID.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(854, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl2.TabIndex = 165
        Me.LabelControl2.Text = "ID:"
        Me.LabelControl2.Visible = False
        '
        'frmCotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 536)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.xtcCotizaciones)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.BarDockControl2)
        Me.IconOptions.Icon = CType(resources.GetObject("frmCotizaciones.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCotizaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizaciones"
        Me.xtpCotizacionesGeneradas.ResumeLayout(False)
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvComboServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCotizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpCotizacionesProductos.ResumeLayout(False)
        Me.xtpCotizacionesProductos.PerformLayout()
        CType(Me.dtHoraFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtHoraInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaServicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaServicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEventos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtCDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIVA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtFechaExpedicion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaExpedicion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorUnitarioP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSalon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboServicios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcCotizaciones.ResumeLayout(False)
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents xtpCotizacionesGeneradas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSUBTOTALDC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALORDC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCIONDC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHASERVICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDDC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvServicios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCServicios As DevExpress.XtraGrid.GridControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiImprimir As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bbiFacturaConcepto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRelacionFactura As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiFactura As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDetalleFactura As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents xtcCotizaciones As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpCotizacionesProductos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtCotizacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCantidadP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboServicios As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvComboServicios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboFactura As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bbiVistaPrevia As DevExpress.XtraBars.BarSubItem
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValorUnitarioP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colDESCUENTODC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bbiClientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCFechaCotizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCFechaVencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiImprimirCotizacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboCliente As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDCLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CONTACTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TELEFONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCEmail As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaServicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaVencimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIVA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCSubTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboEventos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents dtFechaExpedicion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SeparatorControl3 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents cboSalon As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtHoraFinal As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents dtHoraInicio As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colSERVICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSALON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAINICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAFINAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colSERVICIODC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiCorreo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colNETO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class

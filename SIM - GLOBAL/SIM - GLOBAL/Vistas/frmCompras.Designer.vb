<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.TileViewColumn6 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn8 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn5 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.gvProductos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDCOMPRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALORUNITARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSUBTOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDPRESENTACIONPRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDPRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDMARCA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCProductos = New DevExpress.XtraGrid.GridControl()
        Me.cboGVProcedimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORDEN2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOBSERVACION1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.cboProducto = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvProductoDetalleCompra = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRESENTACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCANTIDAD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cboOrdenCompra = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROVEEDOR2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFACTURA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtId = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.TileViewColumn1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn2 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn3 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.btnAgregarDetalleOrdenCompra = New DevExpress.XtraEditors.SimpleButton()
        Me.GCDatosProveedor = New DevExpress.XtraGrid.GridControl()
        Me.TVDatosCliente = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.TileViewColumn4 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colApellidos = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colEdad = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn7 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colFoto = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.txtFactura = New DevExpress.XtraEditors.TextEdit()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorUnitario = New DevExpress.XtraEditors.TextEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGVProcedimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProductoDetalleCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrdenCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDatosProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorUnitario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TileViewColumn6
        '
        Me.TileViewColumn6.Caption = "Nombres"
        Me.TileViewColumn6.FieldName = "NOMBRE"
        Me.TileViewColumn6.Name = "TileViewColumn6"
        Me.TileViewColumn6.Visible = True
        Me.TileViewColumn6.VisibleIndex = 2
        '
        'TileViewColumn8
        '
        Me.TileViewColumn8.Caption = "Telefono"
        Me.TileViewColumn8.FieldName = "TELEFONO"
        Me.TileViewColumn8.Name = "TileViewColumn8"
        Me.TileViewColumn8.Visible = True
        Me.TileViewColumn8.VisibleIndex = 4
        '
        'TileViewColumn5
        '
        Me.TileViewColumn5.Caption = "Identificacion"
        Me.TileViewColumn5.FieldName = "IDENTIFICACION"
        Me.TileViewColumn5.Name = "TileViewColumn5"
        Me.TileViewColumn5.Visible = True
        Me.TileViewColumn5.VisibleIndex = 1
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir})
        Me.BarManager1.MaxItemId = 5
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir)})
        Me.Bar1.Text = "Herramientas"
        '
        'bbtNuevo
        '
        Me.bbtNuevo.Caption = "Nuevo"
        Me.bbtNuevo.Id = 0
        Me.bbtNuevo.ImageOptions.Image = CType(resources.GetObject("bbtNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbtNuevo.Name = "bbtNuevo"
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar"
        Me.bbiEditar.Id = 1
        Me.bbiEditar.ImageOptions.Image = CType(resources.GetObject("bbiEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEditar.Name = "bbiEditar"
        '
        'bbiGuardar
        '
        Me.bbiGuardar.Caption = "Guardar"
        Me.bbiGuardar.Enabled = False
        Me.bbiGuardar.Id = 2
        Me.bbiGuardar.ImageOptions.Image = CType(resources.GetObject("bbiGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGuardar.Name = "bbiGuardar"
        '
        'bbiConsultar
        '
        Me.bbiConsultar.Caption = "Consultar"
        Me.bbiConsultar.Id = 3
        Me.bbiConsultar.ImageOptions.Image = CType(resources.GetObject("bbiConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiConsultar.Name = "bbiConsultar"
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.Id = 4
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1081, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 601)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1081, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 577)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1081, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 577)
        '
        'gvProductos
        '
        Me.gvProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID4, Me.colIDCOMPRA, Me.colCODIGO, Me.colPRODUCTO, Me.colCANTIDAD, Me.colVALORUNITARIO, Me.colSUBTOTAL, Me.colIDPRESENTACIONPRODUCTO, Me.colIDPRODUCTO, Me.colIDMARCA})
        Me.gvProductos.GridControl = Me.GCProductos
        Me.gvProductos.Name = "gvProductos"
        Me.gvProductos.OptionsBehavior.Editable = False
        Me.gvProductos.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvProductos.OptionsPrint.EnableAppearanceOddRow = True
        Me.gvProductos.OptionsPrint.ExpandAllDetails = True
        Me.gvProductos.OptionsPrint.ExpandAllGroups = False
        Me.gvProductos.OptionsPrint.PrintFooter = False
        Me.gvProductos.OptionsView.EnableAppearanceOddRow = True
        Me.gvProductos.OptionsView.ShowFooter = True
        Me.gvProductos.OptionsView.ShowGroupPanel = False
        '
        'colID4
        '
        Me.colID4.Caption = "ID"
        Me.colID4.FieldName = "ID"
        Me.colID4.Name = "colID4"
        '
        'colIDCOMPRA
        '
        Me.colIDCOMPRA.Caption = "ID_COMPRA"
        Me.colIDCOMPRA.FieldName = "ID_COMPRA"
        Me.colIDCOMPRA.Name = "colIDCOMPRA"
        '
        'colCODIGO
        '
        Me.colCODIGO.Caption = "CODIGO"
        Me.colCODIGO.FieldName = "CODIGO"
        Me.colCODIGO.Name = "colCODIGO"
        Me.colCODIGO.Visible = True
        Me.colCODIGO.VisibleIndex = 0
        Me.colCODIGO.Width = 76
        '
        'colPRODUCTO
        '
        Me.colPRODUCTO.Caption = "PRODUCTO"
        Me.colPRODUCTO.FieldName = "PRODUCTO"
        Me.colPRODUCTO.Name = "colPRODUCTO"
        Me.colPRODUCTO.Visible = True
        Me.colPRODUCTO.VisibleIndex = 1
        Me.colPRODUCTO.Width = 266
        '
        'colCANTIDAD
        '
        Me.colCANTIDAD.Caption = "CANTIDAD"
        Me.colCANTIDAD.FieldName = "CANTIDAD"
        Me.colCANTIDAD.Name = "colCANTIDAD"
        Me.colCANTIDAD.Visible = True
        Me.colCANTIDAD.VisibleIndex = 2
        Me.colCANTIDAD.Width = 86
        '
        'colVALORUNITARIO
        '
        Me.colVALORUNITARIO.Caption = "V. UNITARIO"
        Me.colVALORUNITARIO.FieldName = "VALOR_UNITARIO"
        Me.colVALORUNITARIO.Name = "colVALORUNITARIO"
        Me.colVALORUNITARIO.Visible = True
        Me.colVALORUNITARIO.VisibleIndex = 3
        Me.colVALORUNITARIO.Width = 85
        '
        'colSUBTOTAL
        '
        Me.colSUBTOTAL.Caption = "SUBTOTAL"
        Me.colSUBTOTAL.FieldName = "SUBTOTAL"
        Me.colSUBTOTAL.Name = "colSUBTOTAL"
        Me.colSUBTOTAL.Visible = True
        Me.colSUBTOTAL.VisibleIndex = 4
        Me.colSUBTOTAL.Width = 56
        '
        'colIDPRESENTACIONPRODUCTO
        '
        Me.colIDPRESENTACIONPRODUCTO.Caption = "IDPRESENTACIONPRODUCTO"
        Me.colIDPRESENTACIONPRODUCTO.FieldName = "IDPRESENTACIONPRODUCTO"
        Me.colIDPRESENTACIONPRODUCTO.Name = "colIDPRESENTACIONPRODUCTO"
        '
        'colIDPRODUCTO
        '
        Me.colIDPRODUCTO.Caption = "IDPRODUCTO"
        Me.colIDPRODUCTO.FieldName = "IDPRODUCTO"
        Me.colIDPRODUCTO.Name = "colIDPRODUCTO"
        '
        'colIDMARCA
        '
        Me.colIDMARCA.Caption = "IDMARCA"
        Me.colIDMARCA.FieldName = "IDMARCA"
        Me.colIDMARCA.Name = "colIDMARCA"
        '
        'GCProductos
        '
        Me.GCProductos.Location = New System.Drawing.Point(414, 97)
        Me.GCProductos.MainView = Me.gvProductos
        Me.GCProductos.MenuManager = Me.BarManager1
        Me.GCProductos.Name = "GCProductos"
        Me.GCProductos.Size = New System.Drawing.Size(623, 270)
        Me.GCProductos.TabIndex = 104
        Me.GCProductos.UseEmbeddedNavigator = True
        Me.GCProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProductos})
        '
        'cboGVProcedimientos
        '
        Me.cboGVProcedimientos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colORDEN2, Me.colFECHA2, Me.colPROVEEDOR, Me.colOBSERVACION1})
        Me.cboGVProcedimientos.DetailHeight = 200
        Me.cboGVProcedimientos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.cboGVProcedimientos.Name = "cboGVProcedimientos"
        Me.cboGVProcedimientos.OptionsBehavior.AutoPopulateColumns = False
        Me.cboGVProcedimientos.OptionsEditForm.PopupEditFormWidth = 1000
        Me.cboGVProcedimientos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.cboGVProcedimientos.OptionsView.ColumnAutoWidth = False
        Me.cboGVProcedimientos.OptionsView.EnableAppearanceOddRow = True
        Me.cboGVProcedimientos.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colORDEN2
        '
        Me.colORDEN2.Caption = "ORDEN"
        Me.colORDEN2.FieldName = "ORDEN"
        Me.colORDEN2.Name = "colORDEN2"
        Me.colORDEN2.Visible = True
        Me.colORDEN2.VisibleIndex = 0
        '
        'colFECHA2
        '
        Me.colFECHA2.Caption = "FECHA"
        Me.colFECHA2.FieldName = "FECHA"
        Me.colFECHA2.Name = "colFECHA2"
        Me.colFECHA2.Visible = True
        Me.colFECHA2.VisibleIndex = 1
        '
        'colPROVEEDOR
        '
        Me.colPROVEEDOR.Caption = "PROVEEDOR"
        Me.colPROVEEDOR.FieldName = "PROVEEDOR"
        Me.colPROVEEDOR.Name = "colPROVEEDOR"
        Me.colPROVEEDOR.Visible = True
        Me.colPROVEEDOR.VisibleIndex = 2
        '
        'colOBSERVACION1
        '
        Me.colOBSERVACION1.Caption = "OBSERVACION"
        Me.colOBSERVACION1.FieldName = "OBSERVACION"
        Me.colOBSERVACION1.Name = "colOBSERVACION1"
        Me.colOBSERVACION1.Visible = True
        Me.colOBSERVACION1.VisibleIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(771, 53)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl5.TabIndex = 108
        Me.LabelControl5.Text = "Cantidad"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(388, 48)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(19, 319)
        Me.SeparatorControl1.TabIndex = 100
        '
        'cboProducto
        '
        Me.cboProducto.EditValue = "SELECCIONAR"
        Me.cboProducto.Location = New System.Drawing.Point(414, 73)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProducto.Properties.NullText = ""
        Me.cboProducto.Properties.PopupView = Me.gvProductoDetalleCompra
        Me.cboProducto.Size = New System.Drawing.Size(314, 20)
        Me.cboProducto.TabIndex = 107
        '
        'gvProductoDetalleCompra
        '
        Me.gvProductoDetalleCompra.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID2, Me.colCODIGO2, Me.colPRESENTACION, Me.colUNIDAD, Me.colCANTIDAD2, Me.colVALOR})
        Me.gvProductoDetalleCompra.DetailHeight = 200
        Me.gvProductoDetalleCompra.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvProductoDetalleCompra.Name = "gvProductoDetalleCompra"
        Me.gvProductoDetalleCompra.OptionsBehavior.AutoPopulateColumns = False
        Me.gvProductoDetalleCompra.OptionsEditForm.PopupEditFormWidth = 1000
        Me.gvProductoDetalleCompra.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvProductoDetalleCompra.OptionsView.ColumnAutoWidth = False
        Me.gvProductoDetalleCompra.OptionsView.EnableAppearanceOddRow = True
        Me.gvProductoDetalleCompra.OptionsView.ShowGroupPanel = False
        '
        'colID2
        '
        Me.colID2.Caption = "ID"
        Me.colID2.FieldName = "ID"
        Me.colID2.Name = "colID2"
        '
        'colCODIGO2
        '
        Me.colCODIGO2.Caption = "CODIGO"
        Me.colCODIGO2.FieldName = "CODIGO"
        Me.colCODIGO2.Name = "colCODIGO2"
        Me.colCODIGO2.Visible = True
        Me.colCODIGO2.VisibleIndex = 0
        '
        'colPRESENTACION
        '
        Me.colPRESENTACION.Caption = "PRESENTACION"
        Me.colPRESENTACION.FieldName = "PRESENTACION"
        Me.colPRESENTACION.Name = "colPRESENTACION"
        Me.colPRESENTACION.Visible = True
        Me.colPRESENTACION.VisibleIndex = 1
        Me.colPRESENTACION.Width = 165
        '
        'colUNIDAD
        '
        Me.colUNIDAD.Caption = "UNIDAD"
        Me.colUNIDAD.FieldName = "UNIDAD"
        Me.colUNIDAD.Name = "colUNIDAD"
        Me.colUNIDAD.Visible = True
        Me.colUNIDAD.VisibleIndex = 2
        '
        'colCANTIDAD2
        '
        Me.colCANTIDAD2.Caption = "CANTIDAD"
        Me.colCANTIDAD2.FieldName = "CANTIDAD"
        Me.colCANTIDAD2.Name = "colCANTIDAD2"
        Me.colCANTIDAD2.Visible = True
        Me.colCANTIDAD2.VisibleIndex = 3
        '
        'colVALOR
        '
        Me.colVALOR.Caption = "VALOR"
        Me.colVALOR.FieldName = "VALOR"
        Me.colVALOR.Name = "colVALOR"
        Me.colVALOR.Visible = True
        Me.colVALOR.VisibleIndex = 4
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageOptions.Image = CType(resources.GetObject("btnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(1043, 72)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregar.TabIndex = 102
        Me.btnAgregar.ToolTip = "Agregar Producto"
        '
        'btnEliminar
        '
        Me.btnEliminar.ImageOptions.Image = CType(resources.GetObject("btnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(1043, 101)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(26, 23)
        Me.btnEliminar.TabIndex = 103
        Me.btnEliminar.ToolTip = "Eliminar Producto"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(414, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl2.TabIndex = 101
        Me.LabelControl2.Text = "Producto"
        '
        'cboOrdenCompra
        '
        Me.cboOrdenCompra.EditValue = "SELECCIONAR"
        Me.cboOrdenCompra.Location = New System.Drawing.Point(135, 73)
        Me.cboOrdenCompra.Name = "cboOrdenCompra"
        Me.cboOrdenCompra.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboOrdenCompra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOrdenCompra.Properties.NullText = ""
        Me.cboOrdenCompra.Properties.PopupView = Me.cboGVProcedimientos
        Me.cboOrdenCompra.Size = New System.Drawing.Size(247, 20)
        Me.cboOrdenCompra.TabIndex = 106
        '
        'GCConsultar
        '
        Me.GCConsultar.Location = New System.Drawing.Point(16, 386)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(1021, 198)
        Me.GCConsultar.TabIndex = 99
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID3, Me.colCODIGO3, Me.colFECHA, Me.colORDEN, Me.colPROVEEDOR2, Me.colFACTURA, Me.colCONCEPTO, Me.colTOTAL, Me.colEMPLEADO, Me.colESTADO})
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.Editable = False
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultar.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultar.OptionsPrint.PrintFooter = False
        Me.GVConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsView.ShowGroupPanel = False
        '
        'colID3
        '
        Me.colID3.Caption = "ID"
        Me.colID3.FieldName = "ID"
        Me.colID3.Name = "colID3"
        '
        'colCODIGO3
        '
        Me.colCODIGO3.Caption = "CODIGO"
        Me.colCODIGO3.FieldName = "CODIGO"
        Me.colCODIGO3.Name = "colCODIGO3"
        Me.colCODIGO3.Visible = True
        Me.colCODIGO3.VisibleIndex = 0
        Me.colCODIGO3.Width = 64
        '
        'colFECHA
        '
        Me.colFECHA.Caption = "FECHA"
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 1
        Me.colFECHA.Width = 81
        '
        'colORDEN
        '
        Me.colORDEN.Caption = "ORDEN"
        Me.colORDEN.FieldName = "ORDEN"
        Me.colORDEN.Name = "colORDEN"
        Me.colORDEN.Visible = True
        Me.colORDEN.VisibleIndex = 2
        Me.colORDEN.Width = 107
        '
        'colPROVEEDOR2
        '
        Me.colPROVEEDOR2.Caption = "PROVEEDOR"
        Me.colPROVEEDOR2.FieldName = "PROVEEDOR"
        Me.colPROVEEDOR2.Name = "colPROVEEDOR2"
        Me.colPROVEEDOR2.Visible = True
        Me.colPROVEEDOR2.VisibleIndex = 3
        Me.colPROVEEDOR2.Width = 242
        '
        'colFACTURA
        '
        Me.colFACTURA.Caption = "FACTURA"
        Me.colFACTURA.FieldName = "FACTURA"
        Me.colFACTURA.Name = "colFACTURA"
        Me.colFACTURA.Visible = True
        Me.colFACTURA.VisibleIndex = 4
        Me.colFACTURA.Width = 93
        '
        'colCONCEPTO
        '
        Me.colCONCEPTO.Caption = "CONCEPTO"
        Me.colCONCEPTO.FieldName = "CONCEPTO"
        Me.colCONCEPTO.Name = "colCONCEPTO"
        Me.colCONCEPTO.Visible = True
        Me.colCONCEPTO.VisibleIndex = 5
        Me.colCONCEPTO.Width = 195
        '
        'colTOTAL
        '
        Me.colTOTAL.Caption = "TOTAL"
        Me.colTOTAL.DisplayFormat.FormatString = "C0"
        Me.colTOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOTAL.FieldName = "TOTAL"
        Me.colTOTAL.Name = "colTOTAL"
        Me.colTOTAL.Visible = True
        Me.colTOTAL.VisibleIndex = 6
        Me.colTOTAL.Width = 77
        '
        'colEMPLEADO
        '
        Me.colEMPLEADO.Caption = "EMPLEADO"
        Me.colEMPLEADO.FieldName = "EMPLEADO"
        Me.colEMPLEADO.Name = "colEMPLEADO"
        Me.colEMPLEADO.Visible = True
        Me.colEMPLEADO.VisibleIndex = 7
        Me.colEMPLEADO.Width = 93
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 8
        Me.colESTADO.Width = 100
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(68, 187)
        Me.txtConcepto.MenuManager = Me.BarManager1
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(314, 71)
        Me.txtConcepto.TabIndex = 94
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(90, 52)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl9.TabIndex = 98
        Me.LabelControl9.Text = "Fecha"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(14, 77)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl3.TabIndex = 95
        Me.LabelControl3.Text = "Orden de Compra No."
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(16, 187)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl4.TabIndex = 96
        Me.LabelControl4.Text = "Concepto"
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = Nothing
        Me.dtFecha.Location = New System.Drawing.Point(135, 48)
        Me.dtFecha.MenuManager = Me.BarManager1
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.ReadOnly = True
        Me.dtFecha.Size = New System.Drawing.Size(247, 20)
        Me.dtFecha.TabIndex = 97
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(841, 53)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl1.TabIndex = 110
        Me.LabelControl1.Text = "Val. Unitario"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(932, 74)
        Me.txtSubTotal.MenuManager = Me.BarManager1
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSubTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSubTotal.Properties.Mask.EditMask = "d"
        Me.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSubTotal.Properties.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(105, 20)
        Me.txtSubTotal.TabIndex = 113
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(932, 53)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl6.TabIndex = 112
        Me.LabelControl6.Text = "Sub Total"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(25, 264)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl7.TabIndex = 119
        Me.LabelControl7.Text = "Factura"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(344, 22)
        Me.txtId.MenuManager = Me.BarManager1
        Me.txtId.Name = "txtId"
        Me.txtId.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtId.Properties.Appearance.Options.UseBackColor = True
        Me.txtId.Properties.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(260, 20)
        Me.txtId.TabIndex = 121
        Me.txtId.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(288, 25)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl8.TabIndex = 122
        Me.LabelControl8.Text = "Id Compra"
        Me.LabelControl8.Visible = False
        '
        'TileViewColumn1
        '
        Me.TileViewColumn1.Caption = "ID"
        Me.TileViewColumn1.FieldName = "ID"
        Me.TileViewColumn1.Name = "TileViewColumn1"
        '
        'TileViewColumn2
        '
        Me.TileViewColumn2.Caption = "Identificacion"
        Me.TileViewColumn2.FieldName = "NIT"
        Me.TileViewColumn2.Name = "TileViewColumn2"
        '
        'TileViewColumn3
        '
        Me.TileViewColumn3.Caption = "Nombres"
        Me.TileViewColumn3.FieldName = "NOMBRE_ENTIDAD"
        Me.TileViewColumn3.Name = "TileViewColumn3"
        '
        'btnAgregarDetalleOrdenCompra
        '
        Me.btnAgregarDetalleOrdenCompra.ImageOptions.Image = CType(resources.GetObject("btnAgregarDetalleOrdenCompra.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregarDetalleOrdenCompra.Location = New System.Drawing.Point(734, 72)
        Me.btnAgregarDetalleOrdenCompra.Name = "btnAgregarDetalleOrdenCompra"
        Me.btnAgregarDetalleOrdenCompra.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarDetalleOrdenCompra.TabIndex = 168
        Me.btnAgregarDetalleOrdenCompra.ToolTip = "Agregar Producto"
        '
        'GCDatosProveedor
        '
        Me.GCDatosProveedor.EmbeddedNavigator.Appearance.BorderColor = System.Drawing.Color.Red
        Me.GCDatosProveedor.EmbeddedNavigator.Appearance.Options.UseBorderColor = True
        Me.GCDatosProveedor.Location = New System.Drawing.Point(16, 97)
        Me.GCDatosProveedor.MainView = Me.TVDatosCliente
        Me.GCDatosProveedor.Name = "GCDatosProveedor"
        Me.GCDatosProveedor.Size = New System.Drawing.Size(370, 84)
        Me.GCDatosProveedor.TabIndex = 186
        Me.GCDatosProveedor.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TVDatosCliente})
        '
        'TVDatosCliente
        '
        Me.TVDatosCliente.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TileViewColumn4, Me.TileViewColumn5, Me.TileViewColumn6, Me.colApellidos, Me.colEdad, Me.TileViewColumn7, Me.colDireccion, Me.colEmail, Me.TileViewColumn8, Me.colFoto})
        Me.TVDatosCliente.GridControl = Me.GCDatosProveedor
        Me.TVDatosCliente.Name = "TVDatosCliente"
        Me.TVDatosCliente.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(28, 0, 0, 16)
        Me.TVDatosCliente.OptionsTiles.IndentBetweenItems = 13
        Me.TVDatosCliente.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(5)
        Me.TVDatosCliente.OptionsTiles.ItemSize = New System.Drawing.Size(360, 72)
        Me.TVDatosCliente.OptionsTiles.Padding = New System.Windows.Forms.Padding(3)
        TableColumnDefinition1.Length.Value = 138.0R
        Me.TVDatosCliente.TileColumns.Add(TableColumnDefinition1)
        TileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        TileViewItemElement1.Appearance.Normal.Options.UseFont = True
        TileViewItemElement1.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement1.Column = Me.TileViewColumn6
        TileViewItemElement1.StretchHorizontal = True
        TileViewItemElement1.Text = "TileViewColumn6"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement1.TextLocation = New System.Drawing.Point(10, 5)
        TileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
        TileViewItemElement2.Appearance.Normal.Options.UseFont = True
        TileViewItemElement2.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement2.Column = Me.TileViewColumn8
        TileViewItemElement2.StretchHorizontal = True
        TileViewItemElement2.Text = "TileViewColumn8"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement2.TextLocation = New System.Drawing.Point(10, 35)
        TileViewItemElement3.Column = Me.TileViewColumn5
        TileViewItemElement3.StretchHorizontal = True
        TileViewItemElement3.Text = "TileViewColumn5"
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
        'TileViewColumn4
        '
        Me.TileViewColumn4.Caption = "ID"
        Me.TileViewColumn4.FieldName = "ID"
        Me.TileViewColumn4.Name = "TileViewColumn4"
        Me.TileViewColumn4.Visible = True
        Me.TileViewColumn4.VisibleIndex = 0
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
        'TileViewColumn7
        '
        Me.TileViewColumn7.Caption = "Sexo"
        Me.TileViewColumn7.FieldName = "SEXO"
        Me.TileViewColumn7.Name = "TileViewColumn7"
        Me.TileViewColumn7.Visible = True
        Me.TileViewColumn7.VisibleIndex = 3
        '
        'colFoto
        '
        Me.colFoto.Caption = "FOTO"
        Me.colFoto.FieldName = "FOTO"
        Me.colFoto.Name = "colFoto"
        Me.colFoto.Visible = True
        Me.colFoto.VisibleIndex = 9
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(68, 264)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFactura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtFactura.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtFactura.Properties.Appearance.Options.UseBackColor = True
        Me.txtFactura.Properties.Appearance.Options.UseFont = True
        Me.txtFactura.Properties.Appearance.Options.UseForeColor = True
        Me.txtFactura.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFactura.Size = New System.Drawing.Size(314, 36)
        Me.txtFactura.TabIndex = 187
        '
        'txtCantidad
        '
        Me.txtCantidad.EditValue = "0"
        Me.txtCantidad.Location = New System.Drawing.Point(766, 74)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCantidad.Properties.Appearance.Options.UseBackColor = True
        Me.txtCantidad.Properties.Mask.BeepOnError = True
        Me.txtCantidad.Properties.Mask.EditMask = "f"
        Me.txtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Size = New System.Drawing.Size(59, 20)
        Me.txtCantidad.TabIndex = 192
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.EditValue = "0"
        Me.txtValorUnitario.Location = New System.Drawing.Point(831, 73)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtValorUnitario.Properties.Appearance.Options.UseBackColor = True
        Me.txtValorUnitario.Properties.Mask.BeepOnError = True
        Me.txtValorUnitario.Properties.Mask.EditMask = "f"
        Me.txtValorUnitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorUnitario.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValorUnitario.Size = New System.Drawing.Size(95, 20)
        Me.txtValorUnitario.TabIndex = 193
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 601)
        Me.Controls.Add(Me.txtValorUnitario)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.GCDatosProveedor)
        Me.Controls.Add(Me.btnAgregarDetalleOrdenCompra)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.GCProductos)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cboOrdenCompra)
        Me.Controls.Add(Me.GCConsultar)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frmCompras.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompras"
        Me.Text = "Compras"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGVProcedimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProductoDetalleCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrdenCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDatosProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorUnitario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents cboProducto As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvProductoDetalleCompra As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESENTACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboOrdenCompra As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents cboGVProcedimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORDEN2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBSERVACION1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colID4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDCOMPRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALORUNITARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSUBTOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROVEEDOR2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFACTURA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TileViewColumn1 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn2 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn3 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colTOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAgregarDetalleOrdenCompra As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colIDPRESENTACIONPRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDPRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDMARCA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCDatosProveedor As DevExpress.XtraGrid.GridControl
    Friend WithEvents TVDatosCliente As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents TileViewColumn4 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn5 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn6 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colApellidos As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colEdad As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn7 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn8 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colFoto As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorUnitario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
End Class

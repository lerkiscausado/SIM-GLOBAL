<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrdenCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenCompra))
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROVEEDOR2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiProveedores = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAprobar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtObservacion = New DevExpress.XtraEditors.MemoEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.GCProductos = New DevExpress.XtraGrid.GridControl()
        Me.gvProductos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRESENTACION2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOCSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboProveedores = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.cboGVProcedimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDENTIFICACION2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONTACTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFONO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboProducto = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoBarra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRESENTACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMEDIDA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtCodigoCompra = New DevExpress.XtraEditors.TextEdit()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorUnitario = New DevExpress.XtraEditors.TextEdit()
        Me.colCodigoProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPresentacionProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadMedida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedores.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGVProcedimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorUnitario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCConsultar
        '
        Me.GCConsultar.Location = New System.Drawing.Point(19, 267)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(1030, 247)
        Me.GCConsultar.TabIndex = 69
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID3, Me.colORDEN, Me.colFECHA, Me.colPROVEEDOR2, Me.colTotal, Me.colESTADO, Me.colCodigoProducto, Me.colPresentacionProducto, Me.colUnidadMedida, Me.colCantidadProducto, Me.colValorProducto})
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.Editable = False
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultar.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultar.OptionsPrint.PrintFooter = False
        Me.GVConsultar.OptionsView.ColumnAutoWidth = False
        Me.GVConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsView.ShowGroupPanel = False
        '
        'colID3
        '
        Me.colID3.Caption = "ID"
        Me.colID3.FieldName = "ID"
        Me.colID3.Name = "colID3"
        '
        'colORDEN
        '
        Me.colORDEN.Caption = "ORDEN"
        Me.colORDEN.FieldName = "ORDEN"
        Me.colORDEN.Name = "colORDEN"
        Me.colORDEN.Visible = True
        Me.colORDEN.VisibleIndex = 0
        Me.colORDEN.Width = 83
        '
        'colFECHA
        '
        Me.colFECHA.Caption = "FECHA"
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 1
        Me.colFECHA.Width = 62
        '
        'colPROVEEDOR2
        '
        Me.colPROVEEDOR2.Caption = "PROVEEDOR"
        Me.colPROVEEDOR2.FieldName = "PROVEEDOR"
        Me.colPROVEEDOR2.Name = "colPROVEEDOR2"
        Me.colPROVEEDOR2.Visible = True
        Me.colPROVEEDOR2.VisibleIndex = 2
        Me.colPROVEEDOR2.Width = 193
        '
        'colTotal
        '
        Me.colTotal.Caption = "TOTAL"
        Me.colTotal.DisplayFormat.FormatString = "C0"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "TOTAL"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 9
        Me.colTotal.Width = 65
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 10
        Me.colESTADO.Width = 67
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir, Me.bbiProveedores, Me.bbiAnular, Me.bbiAprobar})
        Me.BarManager1.MaxItemId = 8
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiProveedores, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAnular), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAprobar)})
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
        'bbiProveedores
        '
        Me.bbiProveedores.Caption = "Proveedores"
        Me.bbiProveedores.Id = 5
        Me.bbiProveedores.ImageOptions.Image = CType(resources.GetObject("bbiProveedores.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiProveedores.Name = "bbiProveedores"
        '
        'bbiAnular
        '
        Me.bbiAnular.Caption = "Anular"
        Me.bbiAnular.Id = 6
        Me.bbiAnular.Name = "bbiAnular"
        '
        'bbiAprobar
        '
        Me.bbiAprobar.Caption = "Aprobar"
        Me.bbiAprobar.Id = 7
        Me.bbiAprobar.Name = "bbiAprobar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1056, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 526)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1056, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 495)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1056, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 495)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(19, 61)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "Orden No. "
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(19, 127)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 40
        Me.LabelControl3.Text = "Proveedor"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(19, 155)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl4.TabIndex = 43
        Me.LabelControl4.Text = "Observacion"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(108, 228)
        Me.txtCodigo.MenuManager = Me.BarManager1
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCodigo.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigo.Properties.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(260, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Visible = False
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = Nothing
        Me.dtFecha.Location = New System.Drawing.Point(108, 95)
        Me.dtFecha.MenuManager = Me.BarManager1
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.ReadOnly = True
        Me.dtFecha.Size = New System.Drawing.Size(260, 20)
        Me.dtFecha.TabIndex = 2
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(19, 98)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl9.TabIndex = 59
        Me.LabelControl9.Text = "Fecha"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(108, 151)
        Me.txtObservacion.MenuManager = Me.BarManager1
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(260, 71)
        Me.txtObservacion.TabIndex = 4
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(371, 41)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(20, 195)
        Me.SeparatorControl1.TabIndex = 73
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(397, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl2.TabIndex = 75
        Me.LabelControl2.Text = "Producto"
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageOptions.Image = CType(resources.GetObject("btnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(1022, 83)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(22, 22)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.ToolTip = "Agregar Producto"
        '
        'btnEliminar
        '
        Me.btnEliminar.ImageOptions.Image = CType(resources.GetObject("btnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(1022, 111)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(22, 22)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.ToolTip = "Eliminar Producto"
        '
        'GCProductos
        '
        Me.GCProductos.Location = New System.Drawing.Point(392, 83)
        Me.GCProductos.MainView = Me.gvProductos
        Me.GCProductos.MenuManager = Me.BarManager1
        Me.GCProductos.Name = "GCProductos"
        Me.GCProductos.Size = New System.Drawing.Size(625, 154)
        Me.GCProductos.TabIndex = 78
        Me.GCProductos.UseEmbeddedNavigator = True
        Me.GCProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProductos})
        '
        'gvProductos
        '
        Me.gvProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID4, Me.colCODIGO, Me.colPRESENTACION2, Me.colUNIDAD, Me.colCANTIDAD, Me.colValorUnitario, Me.colOCSubTotal})
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
        'colCODIGO
        '
        Me.colCODIGO.Caption = "CODIGO"
        Me.colCODIGO.FieldName = "CODIGO"
        Me.colCODIGO.Name = "colCODIGO"
        Me.colCODIGO.Visible = True
        Me.colCODIGO.VisibleIndex = 0
        Me.colCODIGO.Width = 78
        '
        'colPRESENTACION2
        '
        Me.colPRESENTACION2.Caption = "PRESENTACION"
        Me.colPRESENTACION2.FieldName = "PRESENTACION"
        Me.colPRESENTACION2.Name = "colPRESENTACION2"
        Me.colPRESENTACION2.Visible = True
        Me.colPRESENTACION2.VisibleIndex = 1
        Me.colPRESENTACION2.Width = 211
        '
        'colUNIDAD
        '
        Me.colUNIDAD.Caption = "UNIDAD"
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
        Me.colCANTIDAD.Width = 61
        '
        'colValorUnitario
        '
        Me.colValorUnitario.Caption = "VALOR UNI."
        Me.colValorUnitario.DisplayFormat.FormatString = "C0"
        Me.colValorUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorUnitario.FieldName = "VALOR_UNITARIO"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 4
        Me.colValorUnitario.Width = 73
        '
        'colOCSubTotal
        '
        Me.colOCSubTotal.Caption = "SUBTOTAL"
        Me.colOCSubTotal.DisplayFormat.FormatString = "C0"
        Me.colOCSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOCSubTotal.FieldName = "SUBTOTAL"
        Me.colOCSubTotal.Name = "colOCSubTotal"
        Me.colOCSubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SUBTOTAL", "TOTAL={0:C0}")})
        Me.colOCSubTotal.Visible = True
        Me.colOCSubTotal.VisibleIndex = 5
        Me.colOCSubTotal.Width = 113
        '
        'cboProveedores
        '
        Me.cboProveedores.EditValue = "SELECCIONAR"
        Me.cboProveedores.Location = New System.Drawing.Point(108, 124)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboProveedores.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProveedores.Properties.NullText = ""
        Me.cboProveedores.Properties.PopupView = Me.cboGVProcedimientos
        Me.cboProveedores.Size = New System.Drawing.Size(260, 20)
        Me.cboProveedores.TabIndex = 3
        '
        'cboGVProcedimientos
        '
        Me.cboGVProcedimientos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDENTIFICACION2, Me.colPROVEEDOR, Me.colCONTACTO, Me.colTELEFONO2})
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
        'colIDENTIFICACION2
        '
        Me.colIDENTIFICACION2.Caption = "IDENTIFICACION"
        Me.colIDENTIFICACION2.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACION2.Name = "colIDENTIFICACION2"
        Me.colIDENTIFICACION2.Visible = True
        Me.colIDENTIFICACION2.VisibleIndex = 0
        '
        'colPROVEEDOR
        '
        Me.colPROVEEDOR.Caption = "PROVEEDOR"
        Me.colPROVEEDOR.FieldName = "PROVEEDOR"
        Me.colPROVEEDOR.Name = "colPROVEEDOR"
        Me.colPROVEEDOR.Visible = True
        Me.colPROVEEDOR.VisibleIndex = 1
        '
        'colCONTACTO
        '
        Me.colCONTACTO.Caption = "CONTACTO"
        Me.colCONTACTO.FieldName = "CONTACTO"
        Me.colCONTACTO.Name = "colCONTACTO"
        Me.colCONTACTO.Visible = True
        Me.colCONTACTO.VisibleIndex = 2
        '
        'colTELEFONO2
        '
        Me.colTELEFONO2.Caption = "TELEFONO"
        Me.colTELEFONO2.FieldName = "TELEFONO"
        Me.colTELEFONO2.Name = "colTELEFONO2"
        Me.colTELEFONO2.Visible = True
        Me.colTELEFONO2.VisibleIndex = 3
        '
        'cboProducto
        '
        Me.cboProducto.EditValue = "SELECCIONAR"
        Me.cboProducto.Location = New System.Drawing.Point(392, 56)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProducto.Properties.NullText = ""
        Me.cboProducto.Properties.PopupView = Me.GridView1
        Me.cboProducto.Size = New System.Drawing.Size(357, 20)
        Me.cboProducto.TabIndex = 5
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID2, Me.colCodigoBarra, Me.colPRESENTACION, Me.colMEDIDA})
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
        'colID2
        '
        Me.colID2.Caption = "ID"
        Me.colID2.FieldName = "ID"
        Me.colID2.Name = "colID2"
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
        Me.colMEDIDA.FieldName = "MEDIDA"
        Me.colMEDIDA.Name = "colMEDIDA"
        Me.colMEDIDA.Visible = True
        Me.colMEDIDA.VisibleIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(758, 37)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl5.TabIndex = 90
        Me.LabelControl5.Text = "Cantidad"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(935, 54)
        Me.txtSubTotal.MenuManager = Me.BarManager1
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSubTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSubTotal.Properties.Mask.EditMask = "d"
        Me.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSubTotal.Properties.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(82, 20)
        Me.txtSubTotal.TabIndex = 8
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(820, 37)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 98
        Me.LabelControl6.Text = "Valor Uni."
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(937, 37)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl7.TabIndex = 99
        Me.LabelControl7.Text = "Sub Total"
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.AutoSizeMode = True
        Me.SeparatorControl2.Location = New System.Drawing.Point(19, 241)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(1030, 20)
        Me.SeparatorControl2.TabIndex = 100
        '
        'txtCodigoCompra
        '
        Me.txtCodigoCompra.Enabled = False
        Me.txtCodigoCompra.Location = New System.Drawing.Point(108, 58)
        Me.txtCodigoCompra.MenuManager = Me.BarManager1
        Me.txtCodigoCompra.Name = "txtCodigoCompra"
        Me.txtCodigoCompra.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCodigoCompra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtCodigoCompra.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtCodigoCompra.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigoCompra.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoCompra.Properties.Appearance.Options.UseForeColor = True
        Me.txtCodigoCompra.Properties.ReadOnly = True
        Me.txtCodigoCompra.Size = New System.Drawing.Size(260, 30)
        Me.txtCodigoCompra.TabIndex = 105
        '
        'txtCantidad
        '
        Me.txtCantidad.EditValue = "0"
        Me.txtCantidad.Location = New System.Drawing.Point(758, 54)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCantidad.Properties.Appearance.Options.UseBackColor = True
        Me.txtCantidad.Properties.Mask.BeepOnError = True
        Me.txtCantidad.Properties.Mask.EditMask = "f"
        Me.txtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Size = New System.Drawing.Size(56, 20)
        Me.txtCantidad.TabIndex = 110
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.EditValue = "0"
        Me.txtValorUnitario.Location = New System.Drawing.Point(820, 54)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtValorUnitario.Properties.Appearance.Options.UseBackColor = True
        Me.txtValorUnitario.Properties.Mask.BeepOnError = True
        Me.txtValorUnitario.Properties.Mask.EditMask = "f"
        Me.txtValorUnitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorUnitario.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValorUnitario.Size = New System.Drawing.Size(109, 20)
        Me.txtValorUnitario.TabIndex = 111
        '
        'colCodigoProducto
        '
        Me.colCodigoProducto.Caption = "CODIGO"
        Me.colCodigoProducto.FieldName = "CODIGO"
        Me.colCodigoProducto.Name = "colCodigoProducto"
        Me.colCodigoProducto.Visible = True
        Me.colCodigoProducto.VisibleIndex = 3
        Me.colCodigoProducto.Width = 82
        '
        'colPresentacionProducto
        '
        Me.colPresentacionProducto.Caption = "PRESENTACION"
        Me.colPresentacionProducto.FieldName = "PRESENTACION"
        Me.colPresentacionProducto.Name = "colPresentacionProducto"
        Me.colPresentacionProducto.Visible = True
        Me.colPresentacionProducto.VisibleIndex = 4
        Me.colPresentacionProducto.Width = 350
        '
        'colUnidadMedida
        '
        Me.colUnidadMedida.Caption = "UNI/MED"
        Me.colUnidadMedida.FieldName = "UNIDAD"
        Me.colUnidadMedida.Name = "colUnidadMedida"
        Me.colUnidadMedida.Visible = True
        Me.colUnidadMedida.VisibleIndex = 5
        Me.colUnidadMedida.Width = 53
        '
        'colCantidadProducto
        '
        Me.colCantidadProducto.Caption = "CANTIDAD"
        Me.colCantidadProducto.FieldName = "CANTIDAD"
        Me.colCantidadProducto.Name = "colCantidadProducto"
        Me.colCantidadProducto.Visible = True
        Me.colCantidadProducto.VisibleIndex = 6
        Me.colCantidadProducto.Width = 63
        '
        'colValorProducto
        '
        Me.colValorProducto.Caption = "VALOR UNI"
        Me.colValorProducto.DisplayFormat.FormatString = "C0"
        Me.colValorProducto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorProducto.FieldName = "VALOR"
        Me.colValorProducto.Name = "colValorProducto"
        Me.colValorProducto.Visible = True
        Me.colValorProducto.VisibleIndex = 7
        Me.colValorProducto.Width = 70
        '
        'frmOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 526)
        Me.Controls.Add(Me.txtValorUnitario)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtCodigoCompra)
        Me.Controls.Add(Me.SeparatorControl2)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.cboProveedores)
        Me.Controls.Add(Me.GCProductos)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.GCConsultar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Compra"
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedores.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGVProcedimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorUnitario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtObservacion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents GCProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboProducto As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboProveedores As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents cboGVProcedimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTACTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESENTACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEDIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROVEEDOR2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESENTACION2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colCodigoBarra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOCSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCodigoCompra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bbiProveedores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtValorUnitario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bbiAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAprobar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCodigoProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPresentacionProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadMedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorProducto As DevExpress.XtraGrid.Columns.GridColumn
End Class

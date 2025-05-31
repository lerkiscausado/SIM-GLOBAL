<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListadoOrdenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoOrdenes))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GridSplitContainer1 = New DevExpress.XtraGrid.GridSplitContainer()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODIGO_CUPS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_CUPS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAgregarTodo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminarTodo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDetalleOrden = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GCOrdenesAtendidas = New DevExpress.XtraGrid.GridControl()
        Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmExportarExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExportarPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.GVOrdenesAtendidas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gvColID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsecutivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColFechaIngreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColPaciente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEdad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColEntidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColFechaOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColAutorizacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColCodigoProcedimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColEstudio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColCups = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColCopago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColNeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvColTipoUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboContratos = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cboCodigoProcedimiento = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GCOrdenesFacturar = New DevExpress.XtraGrid.GridControl()
        Me.GVOrdenesFacturar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColFacID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacConsecutivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacFechaIngreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacPaciente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacEdad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacEntidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacAutorizacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacFechaOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacCodigoProcedimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacEstudio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacCups = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacCopago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFacNeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bwCargar = New System.ComponentModel.BackgroundWorker()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.colTipoUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridSplitContainer1.SuspendLayout()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GCOrdenesAtendidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsGrid.SuspendLayout()
        CType(Me.GVOrdenesAtendidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCodigoProcedimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GCOrdenesFacturar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVOrdenesFacturar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.bbiImprimir.Enabled = False
        Me.bbiImprimir.Id = 4
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1196, 25)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 551)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(200, 100)
        Me.SplitContainerControl1.TabIndex = 0
        '
        'GridSplitContainer1
        '
        Me.GridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSplitContainer1.Grid = Me.GCConsultar
        Me.GridSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.GridSplitContainer1.Name = "GridSplitContainer1"
        Me.GridSplitContainer1.Size = New System.Drawing.Size(400, 400)
        Me.GridSplitContainer1.TabIndex = 0
        '
        'GCConsultar
        '
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(407, 359)
        Me.GCConsultar.TabIndex = 0
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_CUPS, Me.colNOMBRE_CUPS, Me.colESTADO})
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.Editable = False
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultar.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultar.OptionsPrint.PrintFooter = False
        Me.GVConsultar.OptionsView.ShowFooter = True
        Me.GVConsultar.OptionsView.ShowGroupPanel = False
        '
        'colCODIGO_CUPS
        '
        Me.colCODIGO_CUPS.Caption = "CODIGO"
        Me.colCODIGO_CUPS.FieldName = "CODIGO_CUPS"
        Me.colCODIGO_CUPS.Name = "colCODIGO_CUPS"
        Me.colCODIGO_CUPS.Visible = True
        Me.colCODIGO_CUPS.VisibleIndex = 0
        Me.colCODIGO_CUPS.Width = 58
        '
        'colNOMBRE_CUPS
        '
        Me.colNOMBRE_CUPS.Caption = "NOMBRE"
        Me.colNOMBRE_CUPS.FieldName = "NOMBRE_CUPS"
        Me.colNOMBRE_CUPS.Name = "colNOMBRE_CUPS"
        Me.colNOMBRE_CUPS.Visible = True
        Me.colNOMBRE_CUPS.VisibleIndex = 1
        Me.colNOMBRE_CUPS.Width = 272
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 2
        Me.colESTADO.Width = 59
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.DockControls.Add(Me.BarDockControl5)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiAgregar, Me.bbiEliminar, Me.bbConsultar, Me.bbiAgregarTodo, Me.bbiEliminarTodo, Me.bbiDetalleOrden})
        Me.BarManager2.MaxItemId = 10
        Me.BarManager2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        '
        'Bar2
        '
        Me.Bar2.BarName = "Herramientas"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(180, 144)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAgregar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEliminar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAgregarTodo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEliminarTodo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDetalleOrden)})
        Me.Bar2.Offset = 1
        Me.Bar2.Text = "Herramientas"
        '
        'bbiAgregar
        '
        Me.bbiAgregar.Caption = "Agregar Una"
        Me.bbiAgregar.Id = 0
        Me.bbiAgregar.ImageOptions.Image = CType(resources.GetObject("bbiAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiAgregar.Name = "bbiAgregar"
        '
        'bbiEliminar
        '
        Me.bbiEliminar.Caption = "Eliminar Una"
        Me.bbiEliminar.Id = 1
        Me.bbiEliminar.ImageOptions.Image = CType(resources.GetObject("bbiEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEliminar.Name = "bbiEliminar"
        '
        'bbiAgregarTodo
        '
        Me.bbiAgregarTodo.Caption = "Agregar Todo"
        Me.bbiAgregarTodo.Id = 6
        Me.bbiAgregarTodo.ImageOptions.Image = CType(resources.GetObject("bbiAgregarTodo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiAgregarTodo.Name = "bbiAgregarTodo"
        '
        'bbiEliminarTodo
        '
        Me.bbiEliminarTodo.Caption = "Eliminar Todo"
        Me.bbiEliminarTodo.Id = 7
        Me.bbiEliminarTodo.ImageOptions.Image = CType(resources.GetObject("bbiEliminarTodo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEliminarTodo.Name = "bbiEliminarTodo"
        '
        'bbConsultar
        '
        Me.bbConsultar.Caption = "Consultar Orden"
        Me.bbConsultar.Id = 3
        Me.bbConsultar.ImageOptions.Image = CType(resources.GetObject("bbConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbConsultar.Name = "bbConsultar"
        '
        'bbiDetalleOrden
        '
        Me.bbiDetalleOrden.Caption = "Detalle de Orden"
        Me.bbiDetalleOrden.Id = 8
        Me.bbiDetalleOrden.ImageOptions.Image = CType(resources.GetObject("bbiDetalleOrden.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiDetalleOrden.Name = "bbiDetalleOrden"
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(1196, 25)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 576)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(1196, 0)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl4.Location = New System.Drawing.Point(0, 25)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 551)
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl5.Location = New System.Drawing.Point(1196, 25)
        Me.BarDockControl5.Manager = Me.BarManager2
        Me.BarDockControl5.Size = New System.Drawing.Size(0, 551)
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1196, 551)
        Me.SplitContainerControl2.SplitterPosition = 251
        Me.SplitContainerControl2.TabIndex = 8
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GCOrdenesAtendidas)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1196, 251)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Ordenes Atendidas"
        '
        'GCOrdenesAtendidas
        '
        Me.GCOrdenesAtendidas.ContextMenuStrip = Me.cmsGrid
        Me.GCOrdenesAtendidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCOrdenesAtendidas.Location = New System.Drawing.Point(2, 25)
        Me.GCOrdenesAtendidas.MainView = Me.GVOrdenesAtendidas
        Me.GCOrdenesAtendidas.MenuManager = Me.BarManager2
        Me.GCOrdenesAtendidas.Name = "GCOrdenesAtendidas"
        Me.GCOrdenesAtendidas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboContratos, Me.cboCodigoProcedimiento})
        Me.GCOrdenesAtendidas.Size = New System.Drawing.Size(1192, 224)
        Me.GCOrdenesAtendidas.TabIndex = 1
        Me.GCOrdenesAtendidas.UseEmbeddedNavigator = True
        Me.GCOrdenesAtendidas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVOrdenesAtendidas})
        '
        'cmsGrid
        '
        Me.cmsGrid.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmImprimir, Me.ToolStripSeparator2, Me.tsmExportarExcel, Me.tsmExportarPDF})
        Me.cmsGrid.Name = "cmsGrid"
        Me.cmsGrid.Size = New System.Drawing.Size(224, 82)
        '
        'tsmImprimir
        '
        Me.tsmImprimir.Image = CType(resources.GetObject("tsmImprimir.Image"), System.Drawing.Image)
        Me.tsmImprimir.Name = "tsmImprimir"
        Me.tsmImprimir.Size = New System.Drawing.Size(223, 24)
        Me.tsmImprimir.Text = "Imprimir Listado"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(220, 6)
        '
        'tsmExportarExcel
        '
        Me.tsmExportarExcel.Image = CType(resources.GetObject("tsmExportarExcel.Image"), System.Drawing.Image)
        Me.tsmExportarExcel.Name = "tsmExportarExcel"
        Me.tsmExportarExcel.Size = New System.Drawing.Size(223, 24)
        Me.tsmExportarExcel.Text = "Exportar Listado a Excel"
        '
        'tsmExportarPDF
        '
        Me.tsmExportarPDF.Image = CType(resources.GetObject("tsmExportarPDF.Image"), System.Drawing.Image)
        Me.tsmExportarPDF.Name = "tsmExportarPDF"
        Me.tsmExportarPDF.Size = New System.Drawing.Size(223, 24)
        Me.tsmExportarPDF.Text = "Exportar Listado  a PDF"
        '
        'GVOrdenesAtendidas
        '
        Me.GVOrdenesAtendidas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVOrdenesAtendidas.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVOrdenesAtendidas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GVOrdenesAtendidas.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVOrdenesAtendidas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gvColID, Me.colConsecutivo, Me.gvColFechaIngreso, Me.gvColIdentificacion, Me.gvColPaciente, Me.colSexo, Me.colEdad, Me.gvColContrato, Me.gvColEntidad, Me.gvColFechaOrden, Me.gvColAutorizacion, Me.gvColCodigoProcedimiento, Me.gvColEstudio, Me.gvColCups, Me.gvColValor, Me.gvColCopago, Me.gvColNeto, Me.gvColTipoUsuario})
        Me.GVOrdenesAtendidas.GridControl = Me.GCOrdenesAtendidas
        Me.GVOrdenesAtendidas.Name = "GVOrdenesAtendidas"
        Me.GVOrdenesAtendidas.OptionsBehavior.Editable = False
        Me.GVOrdenesAtendidas.OptionsBehavior.ReadOnly = True
        Me.GVOrdenesAtendidas.OptionsSelection.MultiSelect = True
        Me.GVOrdenesAtendidas.OptionsView.ColumnAutoWidth = False
        Me.GVOrdenesAtendidas.OptionsView.EnableAppearanceEvenRow = True
        Me.GVOrdenesAtendidas.OptionsView.ShowFooter = True
        '
        'gvColID
        '
        Me.gvColID.Caption = "ORDEN"
        Me.gvColID.FieldName = "ORDEN"
        Me.gvColID.Name = "gvColID"
        Me.gvColID.Visible = True
        Me.gvColID.VisibleIndex = 0
        Me.gvColID.Width = 50
        '
        'colConsecutivo
        '
        Me.colConsecutivo.Caption = "CONSECUTIVO"
        Me.colConsecutivo.FieldName = "CONSECUTIVO"
        Me.colConsecutivo.Name = "colConsecutivo"
        Me.colConsecutivo.Visible = True
        Me.colConsecutivo.VisibleIndex = 1
        '
        'gvColFechaIngreso
        '
        Me.gvColFechaIngreso.Caption = "FECHA INGRESO"
        Me.gvColFechaIngreso.FieldName = "FECHA_INGRESO"
        Me.gvColFechaIngreso.Name = "gvColFechaIngreso"
        Me.gvColFechaIngreso.Visible = True
        Me.gvColFechaIngreso.VisibleIndex = 2
        Me.gvColFechaIngreso.Width = 89
        '
        'gvColIdentificacion
        '
        Me.gvColIdentificacion.Caption = "IDENTIFICACION"
        Me.gvColIdentificacion.FieldName = "IDENTIFICACION"
        Me.gvColIdentificacion.Name = "gvColIdentificacion"
        Me.gvColIdentificacion.Visible = True
        Me.gvColIdentificacion.VisibleIndex = 3
        Me.gvColIdentificacion.Width = 93
        '
        'gvColPaciente
        '
        Me.gvColPaciente.Caption = "PACIENTE"
        Me.gvColPaciente.FieldName = "PACIENTE"
        Me.gvColPaciente.Name = "gvColPaciente"
        Me.gvColPaciente.Visible = True
        Me.gvColPaciente.VisibleIndex = 4
        Me.gvColPaciente.Width = 199
        '
        'colSexo
        '
        Me.colSexo.Caption = "SEXO"
        Me.colSexo.FieldName = "SEXO"
        Me.colSexo.Name = "colSexo"
        Me.colSexo.Visible = True
        Me.colSexo.VisibleIndex = 5
        Me.colSexo.Width = 38
        '
        'colEdad
        '
        Me.colEdad.Caption = "EDAD"
        Me.colEdad.FieldName = "EDAD"
        Me.colEdad.Name = "colEdad"
        Me.colEdad.Visible = True
        Me.colEdad.VisibleIndex = 6
        Me.colEdad.Width = 39
        '
        'gvColContrato
        '
        Me.gvColContrato.Caption = "CONTRATO"
        Me.gvColContrato.FieldName = "CONTRATO"
        Me.gvColContrato.Name = "gvColContrato"
        Me.gvColContrato.Visible = True
        Me.gvColContrato.VisibleIndex = 8
        Me.gvColContrato.Width = 190
        '
        'gvColEntidad
        '
        Me.gvColEntidad.Caption = "ENTIDAD"
        Me.gvColEntidad.FieldName = "ENTIDAD"
        Me.gvColEntidad.Name = "gvColEntidad"
        Me.gvColEntidad.Width = 195
        '
        'gvColFechaOrden
        '
        Me.gvColFechaOrden.Caption = "FECHA ORDEN"
        Me.gvColFechaOrden.FieldName = "FECHA_ORDEN"
        Me.gvColFechaOrden.Name = "gvColFechaOrden"
        Me.gvColFechaOrden.Visible = True
        Me.gvColFechaOrden.VisibleIndex = 10
        Me.gvColFechaOrden.Width = 82
        '
        'gvColAutorizacion
        '
        Me.gvColAutorizacion.Caption = "AUTORIZACION"
        Me.gvColAutorizacion.FieldName = "AUTORIZACION"
        Me.gvColAutorizacion.Name = "gvColAutorizacion"
        Me.gvColAutorizacion.Visible = True
        Me.gvColAutorizacion.VisibleIndex = 9
        '
        'gvColCodigoProcedimiento
        '
        Me.gvColCodigoProcedimiento.Caption = "CODIGO P."
        Me.gvColCodigoProcedimiento.FieldName = "CODIGO_PROCEDIMIENTO"
        Me.gvColCodigoProcedimiento.Name = "gvColCodigoProcedimiento"
        Me.gvColCodigoProcedimiento.Visible = True
        Me.gvColCodigoProcedimiento.VisibleIndex = 12
        '
        'gvColEstudio
        '
        Me.gvColEstudio.Caption = "ESTUDIO"
        Me.gvColEstudio.FieldName = "ESTUDIO"
        Me.gvColEstudio.Name = "gvColEstudio"
        Me.gvColEstudio.Visible = True
        Me.gvColEstudio.VisibleIndex = 11
        Me.gvColEstudio.Width = 215
        '
        'gvColCups
        '
        Me.gvColCups.Caption = "CUPS"
        Me.gvColCups.FieldName = "CUPS"
        Me.gvColCups.Name = "gvColCups"
        Me.gvColCups.Visible = True
        Me.gvColCups.VisibleIndex = 13
        Me.gvColCups.Width = 235
        '
        'gvColValor
        '
        Me.gvColValor.Caption = "VALOR"
        Me.gvColValor.DisplayFormat.FormatString = "C"
        Me.gvColValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gvColValor.FieldName = "VALOR"
        Me.gvColValor.Name = "gvColValor"
        Me.gvColValor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.gvColValor.Visible = True
        Me.gvColValor.VisibleIndex = 14
        '
        'gvColCopago
        '
        Me.gvColCopago.Caption = "COPAGO"
        Me.gvColCopago.DisplayFormat.FormatString = "C2"
        Me.gvColCopago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gvColCopago.FieldName = "COPAGO"
        Me.gvColCopago.Name = "gvColCopago"
        Me.gvColCopago.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "COPAGO", "{0:C0}")})
        Me.gvColCopago.Visible = True
        Me.gvColCopago.VisibleIndex = 15
        '
        'gvColNeto
        '
        Me.gvColNeto.Caption = "NETO"
        Me.gvColNeto.DisplayFormat.FormatString = "C2"
        Me.gvColNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gvColNeto.FieldName = "NETO"
        Me.gvColNeto.Name = "gvColNeto"
        Me.gvColNeto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETO", "{0:C0}")})
        Me.gvColNeto.Visible = True
        Me.gvColNeto.VisibleIndex = 16
        '
        'gvColTipoUsuario
        '
        Me.gvColTipoUsuario.Caption = "TIPO USUARIO"
        Me.gvColTipoUsuario.FieldName = "TIPO_USUARIO"
        Me.gvColTipoUsuario.MinWidth = 22
        Me.gvColTipoUsuario.Name = "gvColTipoUsuario"
        Me.gvColTipoUsuario.Visible = True
        Me.gvColTipoUsuario.VisibleIndex = 7
        Me.gvColTipoUsuario.Width = 104
        '
        'cboContratos
        '
        Me.cboContratos.AutoHeight = False
        Me.cboContratos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboContratos.Name = "cboContratos"
        '
        'cboCodigoProcedimiento
        '
        Me.cboCodigoProcedimiento.AutoHeight = False
        Me.cboCodigoProcedimiento.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCodigoProcedimiento.Name = "cboCodigoProcedimiento"
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.GCOrdenesFacturar)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1196, 289)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Ordenes Auditadas"
        '
        'GCOrdenesFacturar
        '
        Me.GCOrdenesFacturar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCOrdenesFacturar.Location = New System.Drawing.Point(2, 25)
        Me.GCOrdenesFacturar.MainView = Me.GVOrdenesFacturar
        Me.GCOrdenesFacturar.MenuManager = Me.BarManager2
        Me.GCOrdenesFacturar.Name = "GCOrdenesFacturar"
        Me.GCOrdenesFacturar.Size = New System.Drawing.Size(1192, 262)
        Me.GCOrdenesFacturar.TabIndex = 1
        Me.GCOrdenesFacturar.UseEmbeddedNavigator = True
        Me.GCOrdenesFacturar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVOrdenesFacturar})
        '
        'GVOrdenesFacturar
        '
        Me.GVOrdenesFacturar.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVOrdenesFacturar.Appearance.OddRow.Options.UseBackColor = True
        Me.GVOrdenesFacturar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColFacID, Me.colFacConsecutivo, Me.colFacFechaIngreso, Me.colFacIdentificacion, Me.colFacPaciente, Me.colFacSexo, Me.colFacEdad, Me.colFacContrato, Me.colFacEntidad, Me.colFacAutorizacion, Me.colFacFechaOrden, Me.colFacCodigoProcedimiento, Me.colFacEstudio, Me.colFacCups, Me.colFacValor, Me.colFacCopago, Me.colFacNeto, Me.colTipoUsuario})
        GridFormatRule1.Name = "Format0"
        GridFormatRule1.Rule = Nothing
        Me.GVOrdenesFacturar.FormatRules.Add(GridFormatRule1)
        Me.GVOrdenesFacturar.GridControl = Me.GCOrdenesFacturar
        Me.GVOrdenesFacturar.Name = "GVOrdenesFacturar"
        Me.GVOrdenesFacturar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVOrdenesFacturar.OptionsBehavior.ReadOnly = True
        Me.GVOrdenesFacturar.OptionsView.ColumnAutoWidth = False
        Me.GVOrdenesFacturar.OptionsView.EnableAppearanceOddRow = True
        Me.GVOrdenesFacturar.OptionsView.ShowFooter = True
        '
        'ColFacID
        '
        Me.ColFacID.Caption = "ORDEN"
        Me.ColFacID.FieldName = "ORDEN"
        Me.ColFacID.Name = "ColFacID"
        Me.ColFacID.Visible = True
        Me.ColFacID.VisibleIndex = 0
        Me.ColFacID.Width = 47
        '
        'colFacConsecutivo
        '
        Me.colFacConsecutivo.Caption = "CONSECUTIVO"
        Me.colFacConsecutivo.FieldName = "CONSECUTIVO"
        Me.colFacConsecutivo.Name = "colFacConsecutivo"
        Me.colFacConsecutivo.Visible = True
        Me.colFacConsecutivo.VisibleIndex = 1
        '
        'colFacFechaIngreso
        '
        Me.colFacFechaIngreso.Caption = "FECHA INGRESO"
        Me.colFacFechaIngreso.FieldName = "FECHA_INGRESO"
        Me.colFacFechaIngreso.Name = "colFacFechaIngreso"
        Me.colFacFechaIngreso.Visible = True
        Me.colFacFechaIngreso.VisibleIndex = 2
        Me.colFacFechaIngreso.Width = 89
        '
        'colFacIdentificacion
        '
        Me.colFacIdentificacion.Caption = "IDENTIFICACION"
        Me.colFacIdentificacion.FieldName = "IDENTIFICACION"
        Me.colFacIdentificacion.Name = "colFacIdentificacion"
        Me.colFacIdentificacion.Visible = True
        Me.colFacIdentificacion.VisibleIndex = 3
        Me.colFacIdentificacion.Width = 97
        '
        'colFacPaciente
        '
        Me.colFacPaciente.Caption = "PACIENTE"
        Me.colFacPaciente.FieldName = "PACIENTE"
        Me.colFacPaciente.Name = "colFacPaciente"
        Me.colFacPaciente.Visible = True
        Me.colFacPaciente.VisibleIndex = 4
        Me.colFacPaciente.Width = 198
        '
        'colFacSexo
        '
        Me.colFacSexo.Caption = "SEXO"
        Me.colFacSexo.FieldName = "SEXO"
        Me.colFacSexo.Name = "colFacSexo"
        Me.colFacSexo.Visible = True
        Me.colFacSexo.VisibleIndex = 5
        Me.colFacSexo.Width = 40
        '
        'colFacEdad
        '
        Me.colFacEdad.Caption = "EDAD"
        Me.colFacEdad.FieldName = "EDAD"
        Me.colFacEdad.Name = "colFacEdad"
        Me.colFacEdad.Visible = True
        Me.colFacEdad.VisibleIndex = 6
        Me.colFacEdad.Width = 44
        '
        'colFacContrato
        '
        Me.colFacContrato.Caption = "CONTRATO"
        Me.colFacContrato.FieldName = "CONTRATO"
        Me.colFacContrato.Name = "colFacContrato"
        Me.colFacContrato.Visible = True
        Me.colFacContrato.VisibleIndex = 8
        Me.colFacContrato.Width = 194
        '
        'colFacEntidad
        '
        Me.colFacEntidad.Caption = "ENTIDAD"
        Me.colFacEntidad.FieldName = "ENTIDAD"
        Me.colFacEntidad.Name = "colFacEntidad"
        Me.colFacEntidad.Width = 221
        '
        'colFacAutorizacion
        '
        Me.colFacAutorizacion.Caption = "AUTORIZACION"
        Me.colFacAutorizacion.FieldName = "AUTORIZACION"
        Me.colFacAutorizacion.Name = "colFacAutorizacion"
        Me.colFacAutorizacion.Visible = True
        Me.colFacAutorizacion.VisibleIndex = 9
        '
        'colFacFechaOrden
        '
        Me.colFacFechaOrden.Caption = "FECHA ORDEN"
        Me.colFacFechaOrden.FieldName = "FECHA_ORDEN"
        Me.colFacFechaOrden.Name = "colFacFechaOrden"
        Me.colFacFechaOrden.Visible = True
        Me.colFacFechaOrden.VisibleIndex = 10
        Me.colFacFechaOrden.Width = 82
        '
        'colFacCodigoProcedimiento
        '
        Me.colFacCodigoProcedimiento.Caption = "CODIGO P."
        Me.colFacCodigoProcedimiento.FieldName = "CODIGO_PROCEDIMIENTO"
        Me.colFacCodigoProcedimiento.Name = "colFacCodigoProcedimiento"
        Me.colFacCodigoProcedimiento.Visible = True
        Me.colFacCodigoProcedimiento.VisibleIndex = 12
        '
        'colFacEstudio
        '
        Me.colFacEstudio.Caption = "ESTUDIO"
        Me.colFacEstudio.FieldName = "ESTUDIO"
        Me.colFacEstudio.Name = "colFacEstudio"
        Me.colFacEstudio.Visible = True
        Me.colFacEstudio.VisibleIndex = 11
        Me.colFacEstudio.Width = 239
        '
        'colFacCups
        '
        Me.colFacCups.Caption = "CUPS"
        Me.colFacCups.FieldName = "CUPS"
        Me.colFacCups.Name = "colFacCups"
        Me.colFacCups.Visible = True
        Me.colFacCups.VisibleIndex = 13
        Me.colFacCups.Width = 245
        '
        'colFacValor
        '
        Me.colFacValor.Caption = "VALOR"
        Me.colFacValor.DisplayFormat.FormatString = "C2"
        Me.colFacValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFacValor.FieldName = "VALOR"
        Me.colFacValor.Name = "colFacValor"
        Me.colFacValor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "TOTAL={c2}")})
        Me.colFacValor.Visible = True
        Me.colFacValor.VisibleIndex = 14
        '
        'colFacCopago
        '
        Me.colFacCopago.Caption = "COPAGO"
        Me.colFacCopago.DisplayFormat.FormatString = "C2"
        Me.colFacCopago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFacCopago.FieldName = "COPAGO"
        Me.colFacCopago.Name = "colFacCopago"
        Me.colFacCopago.Visible = True
        Me.colFacCopago.VisibleIndex = 15
        '
        'colFacNeto
        '
        Me.colFacNeto.Caption = "NETO"
        Me.colFacNeto.DisplayFormat.FormatString = "C2"
        Me.colFacNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFacNeto.FieldName = "NETO"
        Me.colFacNeto.Name = "colFacNeto"
        Me.colFacNeto.Visible = True
        Me.colFacNeto.VisibleIndex = 16
        '
        'bwCargar
        '
        Me.bwCargar.WorkerReportsProgress = True
        Me.bwCargar.WorkerSupportsCancellation = True
        '
        'colTipoUsuario
        '
        Me.colTipoUsuario.Caption = "TIPO USUARIO"
        Me.colTipoUsuario.FieldName = "TIPO_USUARIO"
        Me.colTipoUsuario.MinWidth = 22
        Me.colTipoUsuario.Name = "colTipoUsuario"
        Me.colTipoUsuario.Visible = True
        Me.colTipoUsuario.VisibleIndex = 7
        Me.colTipoUsuario.Width = 111
        '
        'frmListadoOrdenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 576)
        Me.Controls.Add(Me.SplitContainerControl2)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl5)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl2)
        Me.IconOptions.Icon = CType(resources.GetObject("frmListadoOrdenes.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmListadoOrdenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditoria de Ordenes"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridSplitContainer1.ResumeLayout(False)
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GCOrdenesAtendidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsGrid.ResumeLayout(False)
        CType(Me.GVOrdenesAtendidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCodigoProcedimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GCOrdenesFacturar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVOrdenesFacturar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridSplitContainer1 As DevExpress.XtraGrid.GridSplitContainer
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO_CUPS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_CUPS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    'Friend WithEvents DTOrdenesFacturarTableAdapter As DSVistasTableAdapters.DTOrdenesFacturarTableAdapter
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCOrdenesAtendidas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVOrdenesAtendidas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboContratos As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboCodigoProcedimiento As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCOrdenesFacturar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVOrdenesFacturar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bbiAgregarTodo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminarTodo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDetalleOrden As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gvColID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColFechaIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColPaciente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColEntidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColFechaOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColAutorizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColCodigoProcedimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColEstudio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColCups As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColCopago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColNeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFacID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacFechaIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacPaciente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacEntidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacAutorizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacFechaOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacCodigoProcedimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacEstudio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacCups As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacCopago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacNeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEdad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsGrid As ContextMenuStrip
    Friend WithEvents tsmImprimir As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmExportarExcel As ToolStripMenuItem
    Friend WithEvents tsmExportarPDF As ToolStripMenuItem
    Friend WithEvents bwCargar As System.ComponentModel.BackgroundWorker
    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents colConsecutivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacConsecutivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFacEdad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvColTipoUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoUsuario As DevExpress.XtraGrid.Columns.GridColumn
End Class

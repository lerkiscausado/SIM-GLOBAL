<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTarifas))
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmExportarExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExportarPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.bbiPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPDF = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl9 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl10 = New DevExpress.XtraBars.BarDockControl()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bwCargar = New System.ComponentModel.BackgroundWorker()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnombre_tarifa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cboIVA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.GCDetalleTarifa = New DevExpress.XtraGrid.GridControl()
        Me.GVDetalleTarifa = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDDT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIFA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.cboTipoEstudio = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.chkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cmsGrid.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIVA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDetalleTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDetalleTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Nothing
        Me.BarDockControl1.Size = New System.Drawing.Size(0, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl2.Manager = Nothing
        Me.BarDockControl2.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Nothing
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Nothing
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 0)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl4.Manager = Nothing
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 0)
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl5.Manager = Nothing
        Me.BarDockControl5.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlBottom.Manager = Nothing
        Me.barDockControlBottom.Size = New System.Drawing.Size(0, 0)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl6.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl6.Manager = Nothing
        Me.BarDockControl6.Size = New System.Drawing.Size(0, 0)
        '
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl7.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl7.Manager = Nothing
        Me.BarDockControl7.Size = New System.Drawing.Size(0, 0)
        '
        'cmsGrid
        '
        Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmImprimir, Me.ToolStripSeparator2, Me.tsmExportarExcel, Me.tsmExportarPDF})
        Me.cmsGrid.Name = "cmsGrid"
        Me.cmsGrid.Size = New System.Drawing.Size(199, 76)
        '
        'tsmImprimir
        '
        Me.tsmImprimir.Image = CType(resources.GetObject("tsmImprimir.Image"), System.Drawing.Image)
        Me.tsmImprimir.Name = "tsmImprimir"
        Me.tsmImprimir.Size = New System.Drawing.Size(198, 22)
        Me.tsmImprimir.Text = "Imprimir Listado"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'tsmExportarExcel
        '
        Me.tsmExportarExcel.Image = CType(resources.GetObject("tsmExportarExcel.Image"), System.Drawing.Image)
        Me.tsmExportarExcel.Name = "tsmExportarExcel"
        Me.tsmExportarExcel.Size = New System.Drawing.Size(198, 22)
        Me.tsmExportarExcel.Text = "Exportar Listado a Excel"
        '
        'tsmExportarPDF
        '
        Me.tsmExportarPDF.Image = CType(resources.GetObject("tsmExportarPDF.Image"), System.Drawing.Image)
        Me.tsmExportarPDF.Name = "tsmExportarPDF"
        Me.tsmExportarPDF.Size = New System.Drawing.Size(198, 22)
        Me.tsmExportarPDF.Text = "Exportar Listado  a PDF"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.BarDockControl8)
        Me.BarManager1.DockControls.Add(Me.BarDockControl9)
        Me.BarManager1.DockControls.Add(Me.BarDockControl10)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir, Me.BarSubItem1, Me.bbiPrint, Me.bbiExcel, Me.bbiPDF})
        Me.BarManager1.MaxItemId = 9
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1)})
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
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Imprimir"
        Me.BarSubItem1.Id = 5
        Me.BarSubItem1.ImageOptions.Image = CType(resources.GetObject("BarSubItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExcel, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPDF)})
        Me.BarSubItem1.Name = "BarSubItem1"
        Me.BarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        '
        'bbiPrint
        '
        Me.bbiPrint.Caption = "Listado Clientes"
        Me.bbiPrint.Id = 6
        Me.bbiPrint.ImageOptions.Image = CType(resources.GetObject("bbiPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiPrint.Name = "bbiPrint"
        '
        'bbiExcel
        '
        Me.bbiExcel.Caption = "Exportar Excel"
        Me.bbiExcel.Id = 7
        Me.bbiExcel.ImageOptions.Image = CType(resources.GetObject("bbiExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiExcel.Name = "bbiExcel"
        '
        'bbiPDF
        '
        Me.bbiPDF.Caption = "Exportar PDF"
        Me.bbiPDF.Id = 8
        Me.bbiPDF.ImageOptions.Image = CType(resources.GetObject("bbiPDF.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiPDF.Name = "bbiPDF"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1127, 24)
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl8.Location = New System.Drawing.Point(0, 466)
        Me.BarDockControl8.Manager = Me.BarManager1
        Me.BarDockControl8.Size = New System.Drawing.Size(1127, 0)
        '
        'BarDockControl9
        '
        Me.BarDockControl9.CausesValidation = False
        Me.BarDockControl9.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl9.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl9.Manager = Me.BarManager1
        Me.BarDockControl9.Size = New System.Drawing.Size(0, 442)
        '
        'BarDockControl10
        '
        Me.BarDockControl10.CausesValidation = False
        Me.BarDockControl10.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl10.Location = New System.Drawing.Point(1127, 24)
        Me.BarDockControl10.Manager = Me.BarManager1
        Me.BarDockControl10.Size = New System.Drawing.Size(0, 442)
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.Id = 4
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'bwCargar
        '
        Me.bwCargar.WorkerReportsProgress = True
        Me.bwCargar.WorkerSupportsCancellation = True
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(500, 11)
        Me.txtID.MenuManager = Me.BarManager1
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 187
        Me.txtID.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(475, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl1.TabIndex = 186
        Me.LabelControl1.Text = "ID:"
        Me.LabelControl1.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Location = New System.Drawing.Point(12, 37)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GCConsultar)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl7)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl6)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl10)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.cboIVA)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl8)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.btnEliminar)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.btnAgregar)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GCDetalleTarifa)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SeparatorControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.cboTipoEstudio)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtValor)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.chkEstado)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtNombre)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl9)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1104, 417)
        Me.SplitContainerControl1.SplitterPosition = 464
        Me.SplitContainerControl1.TabIndex = 197
        '
        'GCConsultar
        '
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(464, 417)
        Me.GCConsultar.TabIndex = 178
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colnombre_tarifa, Me.colESTADO})
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
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 35
        '
        'colnombre_tarifa
        '
        Me.colnombre_tarifa.Caption = "TARIFA"
        Me.colnombre_tarifa.FieldName = "TARIFA"
        Me.colnombre_tarifa.Name = "colnombre_tarifa"
        Me.colnombre_tarifa.Visible = True
        Me.colnombre_tarifa.VisibleIndex = 0
        Me.colnombre_tarifa.Width = 402
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 1
        Me.colESTADO.Width = 85
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(9, 21)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl7.TabIndex = 208
        Me.LabelControl7.Text = "Nombre Tarifa"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(53, 91)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl6.TabIndex = 207
        Me.LabelControl6.Text = "Valor"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(414, 91)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl10.TabIndex = 206
        Me.LabelControl10.Text = "%"
        '
        'cboIVA
        '
        Me.cboIVA.Location = New System.Drawing.Point(310, 88)
        Me.cboIVA.MenuManager = Me.BarManager1
        Me.cboIVA.Name = "cboIVA"
        Me.cboIVA.Properties.AutoComplete = False
        Me.cboIVA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIVA.Properties.Items.AddRange(New Object() {"0", "19"})
        Me.cboIVA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboIVA.Size = New System.Drawing.Size(98, 20)
        Me.cboIVA.TabIndex = 205
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(283, 91)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl8.TabIndex = 204
        Me.LabelControl8.Text = "IVA"
        '
        'btnEliminar
        '
        Me.btnEliminar.ImageOptions.Image = CType(resources.GetObject("btnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(582, 50)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(26, 23)
        Me.btnEliminar.TabIndex = 200
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageOptions.Image = CType(resources.GetObject("btnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(550, 50)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregar.TabIndex = 199
        '
        'GCDetalleTarifa
        '
        Me.GCDetalleTarifa.Location = New System.Drawing.Point(9, 151)
        Me.GCDetalleTarifa.MainView = Me.GVDetalleTarifa
        Me.GCDetalleTarifa.MenuManager = Me.BarManager1
        Me.GCDetalleTarifa.Name = "GCDetalleTarifa"
        Me.GCDetalleTarifa.Size = New System.Drawing.Size(612, 262)
        Me.GCDetalleTarifa.TabIndex = 201
        Me.GCDetalleTarifa.UseEmbeddedNavigator = True
        Me.GCDetalleTarifa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDetalleTarifa})
        '
        'GVDetalleTarifa
        '
        Me.GVDetalleTarifa.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDDT, Me.colESTUDIO, Me.colVALOR, Me.colIVA, Me.colTARIFA, Me.colTOTAL})
        Me.GVDetalleTarifa.GridControl = Me.GCDetalleTarifa
        Me.GVDetalleTarifa.Name = "GVDetalleTarifa"
        Me.GVDetalleTarifa.OptionsBehavior.Editable = False
        Me.GVDetalleTarifa.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVDetalleTarifa.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVDetalleTarifa.OptionsPrint.ExpandAllDetails = True
        Me.GVDetalleTarifa.OptionsPrint.ExpandAllGroups = False
        Me.GVDetalleTarifa.OptionsPrint.PrintFooter = False
        Me.GVDetalleTarifa.OptionsView.EnableAppearanceOddRow = True
        Me.GVDetalleTarifa.OptionsView.ShowGroupPanel = False
        '
        'colIDDT
        '
        Me.colIDDT.Caption = "ID"
        Me.colIDDT.FieldName = "ID"
        Me.colIDDT.Name = "colIDDT"
        '
        'colESTUDIO
        '
        Me.colESTUDIO.Caption = "ESTUDIO"
        Me.colESTUDIO.FieldName = "ESTUDIO"
        Me.colESTUDIO.Name = "colESTUDIO"
        Me.colESTUDIO.Visible = True
        Me.colESTUDIO.VisibleIndex = 0
        Me.colESTUDIO.Width = 276
        '
        'colVALOR
        '
        Me.colVALOR.Caption = "VALOR"
        Me.colVALOR.DisplayFormat.FormatString = "C"
        Me.colVALOR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALOR.FieldName = "VALOR"
        Me.colVALOR.Name = "colVALOR"
        Me.colVALOR.Visible = True
        Me.colVALOR.VisibleIndex = 1
        Me.colVALOR.Width = 76
        '
        'colIVA
        '
        Me.colIVA.Caption = "IVA"
        Me.colIVA.DisplayFormat.FormatString = "C"
        Me.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIVA.FieldName = "IVA"
        Me.colIVA.Name = "colIVA"
        Me.colIVA.Visible = True
        Me.colIVA.VisibleIndex = 2
        Me.colIVA.Width = 67
        '
        'colTARIFA
        '
        Me.colTARIFA.Caption = "TARIFA"
        Me.colTARIFA.FieldName = "TARIFA"
        Me.colTARIFA.Name = "colTARIFA"
        Me.colTARIFA.Visible = True
        Me.colTARIFA.VisibleIndex = 3
        '
        'colTOTAL
        '
        Me.colTOTAL.Caption = "TOTAL"
        Me.colTOTAL.DisplayFormat.FormatString = "C"
        Me.colTOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOTAL.FieldName = "TOTAL"
        Me.colTOTAL.Name = "colTOTAL"
        Me.colTOTAL.Visible = True
        Me.colTOTAL.VisibleIndex = 4
        Me.colTOTAL.Width = 99
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Location = New System.Drawing.Point(9, 126)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(612, 22)
        Me.SeparatorControl2.TabIndex = 203
        '
        'cboTipoEstudio
        '
        Me.cboTipoEstudio.Location = New System.Drawing.Point(83, 53)
        Me.cboTipoEstudio.MenuManager = Me.BarManager1
        Me.cboTipoEstudio.Name = "cboTipoEstudio"
        Me.cboTipoEstudio.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTipoEstudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoEstudio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTUDIO", "ESTUDIO")})
        Me.cboTipoEstudio.Properties.NullText = ""
        Me.cboTipoEstudio.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboTipoEstudio.Properties.PopupSizeable = False
        Me.cboTipoEstudio.Properties.ShowHeader = False
        Me.cboTipoEstudio.Size = New System.Drawing.Size(447, 20)
        Me.cboTipoEstudio.TabIndex = 202
        '
        'txtValor
        '
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(83, 88)
        Me.txtValor.MenuManager = Me.BarManager1
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Properties.MaxLength = 50
        Me.txtValor.Size = New System.Drawing.Size(180, 20)
        Me.txtValor.TabIndex = 198
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(549, 17)
        Me.chkEstado.MenuManager = Me.BarManager1
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.Caption = "Activo"
        Me.chkEstado.Size = New System.Drawing.Size(59, 20)
        Me.chkEstado.TabIndex = 195
        '
        'txtNombre
        '
        Me.txtNombre.EnterMoveNextControl = True
        Me.txtNombre.Location = New System.Drawing.Point(83, 18)
        Me.txtNombre.MenuManager = Me.BarManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Properties.MaxLength = 50
        Me.txtNombre.Size = New System.Drawing.Size(447, 20)
        Me.txtNombre.TabIndex = 194
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(19, 56)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl9.TabIndex = 196
        Me.LabelControl9.Text = "Tipo Estudio"
        '
        'frmTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 466)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.BarDockControl9)
        Me.Controls.Add(Me.BarDockControl10)
        Me.Controls.Add(Me.BarDockControl8)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmTarifas"
        Me.Text = "Tarifas"
        Me.cmsGrid.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIVA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDetalleTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDetalleTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmsGrid As ContextMenuStrip
    Friend WithEvents tsmImprimir As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmExportarExcel As ToolStripMenuItem
    Friend WithEvents tsmExportarPDF As ToolStripMenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bbiPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiPDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl9 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl10 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bwCargar As System.ComponentModel.BackgroundWorker
    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnombre_tarifa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboIVA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCDetalleTarifa As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDetalleTarifa As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDDT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTUDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIFA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents cboTipoEstudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Private WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class

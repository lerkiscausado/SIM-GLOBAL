<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmExportarExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExportarPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFONO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCorreoElectronico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContaco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCorreoElectronico = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.cboTipoIdentificacion = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNumeroIdentificacion = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtContacto = New DevExpress.XtraEditors.TextEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.chkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.bwCargar = New System.ComponentModel.BackgroundWorker()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsGrid.SuspendLayout()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorreoElectronico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoIdentificacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroIdentificacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCConsultar
        '
        Me.GCConsultar.ContextMenuStrip = Me.cmsGrid
        Me.GCConsultar.Location = New System.Drawing.Point(11, 155)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(923, 247)
        Me.GCConsultar.TabIndex = 69
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'cmsGrid
        '
        Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmImprimir, Me.ToolStripSeparator2, Me.tsmExportarExcel, Me.tsmExportarPDF})
        Me.cmsGrid.Name = "cmsGrid"
        Me.cmsGrid.Size = New System.Drawing.Size(197, 76)
        '
        'tsmImprimir
        '
        Me.tsmImprimir.Image = CType(resources.GetObject("tsmImprimir.Image"), System.Drawing.Image)
        Me.tsmImprimir.Name = "tsmImprimir"
        Me.tsmImprimir.Size = New System.Drawing.Size(196, 22)
        Me.tsmImprimir.Text = "Imprimir Listado"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(193, 6)
        '
        'tsmExportarExcel
        '
        Me.tsmExportarExcel.Image = CType(resources.GetObject("tsmExportarExcel.Image"), System.Drawing.Image)
        Me.tsmExportarExcel.Name = "tsmExportarExcel"
        Me.tsmExportarExcel.Size = New System.Drawing.Size(196, 22)
        Me.tsmExportarExcel.Text = "Exportar Listado a Excel"
        '
        'tsmExportarPDF
        '
        Me.tsmExportarPDF.Image = CType(resources.GetObject("tsmExportarPDF.Image"), System.Drawing.Image)
        Me.tsmExportarPDF.Name = "tsmExportarPDF"
        Me.tsmExportarPDF.Size = New System.Drawing.Size(196, 22)
        Me.tsmExportarPDF.Text = "Exportar Listado  a PDF"
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colTI, Me.colIDENTIFICACION, Me.colNOMBRE, Me.colDireccion, Me.colTELEFONO, Me.colCorreoElectronico, Me.colContaco, Me.colEstado})
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.Editable = False
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsPrint.AutoWidth = False
        Me.GVConsultar.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultar.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultar.OptionsPrint.PrintFooter = False
        Me.GVConsultar.OptionsView.ColumnAutoWidth = False
        Me.GVConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 83
        '
        'colTI
        '
        Me.colTI.Caption = "TI"
        Me.colTI.FieldName = "ID_TIPO_IDENTIFICACION"
        Me.colTI.Name = "colTI"
        Me.colTI.Visible = True
        Me.colTI.VisibleIndex = 0
        Me.colTI.Width = 32
        '
        'colIDENTIFICACION
        '
        Me.colIDENTIFICACION.Caption = "IDENTIFICACION"
        Me.colIDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACION.Name = "colIDENTIFICACION"
        Me.colIDENTIFICACION.Visible = True
        Me.colIDENTIFICACION.VisibleIndex = 1
        Me.colIDENTIFICACION.Width = 120
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "PROVEEDOR"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 2
        Me.colNOMBRE.Width = 220
        '
        'colDireccion
        '
        Me.colDireccion.Caption = "DIRECCION"
        Me.colDireccion.FieldName = "DIRECCION"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 3
        Me.colDireccion.Width = 220
        '
        'colTELEFONO
        '
        Me.colTELEFONO.Caption = "TELEFONO"
        Me.colTELEFONO.FieldName = "TELEFONO"
        Me.colTELEFONO.Name = "colTELEFONO"
        Me.colTELEFONO.Visible = True
        Me.colTELEFONO.VisibleIndex = 4
        Me.colTELEFONO.Width = 100
        '
        'colCorreoElectronico
        '
        Me.colCorreoElectronico.Caption = "CORREO"
        Me.colCorreoElectronico.FieldName = "CORREO_ELECTRONICO"
        Me.colCorreoElectronico.Name = "colCorreoElectronico"
        Me.colCorreoElectronico.Visible = True
        Me.colCorreoElectronico.VisibleIndex = 5
        Me.colCorreoElectronico.Width = 166
        '
        'colContaco
        '
        Me.colContaco.Caption = "CONTACO"
        Me.colContaco.FieldName = "CONTACTO"
        Me.colContaco.Name = "colContaco"
        Me.colContaco.Visible = True
        Me.colContaco.VisibleIndex = 6
        Me.colContaco.Width = 173
        '
        'colEstado
        '
        Me.colEstado.Caption = "ESTADO"
        Me.colEstado.FieldName = "ESTADO"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 7
        Me.colEstado.Width = 87
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
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
        Me.bbiPrint.Caption = "Listado Proovedores"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(946, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 412)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(946, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 381)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(946, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 381)
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.Id = 4
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(757, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "Codigo:"
        Me.LabelControl1.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 102)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "Nombres o Razon Soc."
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.EnterMoveNextControl = True
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(493, 99)
        Me.txtCorreoElectronico.MenuManager = Me.BarManager1
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(441, 20)
        Me.txtCorreoElectronico.TabIndex = 53
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(429, 102)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl14.TabIndex = 64
        Me.LabelControl14.Text = "Email"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(11, 50)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl3.TabIndex = 40
        Me.LabelControl3.Text = "Tipo de Id"
        '
        'txtTelefono
        '
        Me.txtTelefono.EnterMoveNextControl = True
        Me.txtTelefono.Location = New System.Drawing.Point(493, 73)
        Me.txtTelefono.MenuManager = Me.BarManager1
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(441, 20)
        Me.txtTelefono.TabIndex = 52
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(429, 76)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl13.TabIndex = 63
        Me.LabelControl13.Text = "Telefonos"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(11, 76)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 43
        Me.LabelControl4.Text = "Identificacion"
        '
        'txtDireccion
        '
        Me.txtDireccion.EnterMoveNextControl = True
        Me.txtDireccion.Location = New System.Drawing.Point(493, 47)
        Me.txtDireccion.MenuManager = Me.BarManager1
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(441, 20)
        Me.txtDireccion.TabIndex = 50
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(429, 50)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl12.TabIndex = 62
        Me.LabelControl12.Text = "Direccion"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(832, 12)
        Me.txtCodigo.MenuManager = Me.BarManager1
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCodigo.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigo.Properties.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 38
        Me.txtCodigo.Visible = False
        '
        'cboTipoIdentificacion
        '
        Me.cboTipoIdentificacion.Location = New System.Drawing.Point(129, 47)
        Me.cboTipoIdentificacion.MenuManager = Me.BarManager1
        Me.cboTipoIdentificacion.Name = "cboTipoIdentificacion"
        Me.cboTipoIdentificacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoIdentificacion.Properties.NullText = ""
        Me.cboTipoIdentificacion.Properties.PopupSizeable = False
        Me.cboTipoIdentificacion.Size = New System.Drawing.Size(260, 20)
        Me.cboTipoIdentificacion.TabIndex = 36
        '
        'txtNumeroIdentificacion
        '
        Me.txtNumeroIdentificacion.EnterMoveNextControl = True
        Me.txtNumeroIdentificacion.Location = New System.Drawing.Point(129, 73)
        Me.txtNumeroIdentificacion.MenuManager = Me.BarManager1
        Me.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion"
        Me.txtNumeroIdentificacion.Properties.Mask.EditMask = "d"
        Me.txtNumeroIdentificacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumeroIdentificacion.Size = New System.Drawing.Size(260, 20)
        Me.txtNumeroIdentificacion.TabIndex = 39
        '
        'txtNombre
        '
        Me.txtNombre.EnterMoveNextControl = True
        Me.txtNombre.Location = New System.Drawing.Point(129, 99)
        Me.txtNombre.MenuManager = Me.BarManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(260, 20)
        Me.txtNombre.TabIndex = 41
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(11, 126)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl5.TabIndex = 71
        Me.LabelControl5.Text = "Contacto"
        '
        'txtContacto
        '
        Me.txtContacto.EnterMoveNextControl = True
        Me.txtContacto.Location = New System.Drawing.Point(129, 125)
        Me.txtContacto.MenuManager = Me.BarManager1
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(260, 20)
        Me.txtContacto.TabIndex = 70
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(395, 46)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(20, 103)
        Me.SeparatorControl1.TabIndex = 72
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(493, 125)
        Me.chkEstado.MenuManager = Me.BarManager1
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.Caption = "Activo"
        Me.chkEstado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkEstado.Size = New System.Drawing.Size(75, 19)
        Me.chkEstado.TabIndex = 73
        '
        'bwCargar
        '
        Me.bwCargar.WorkerReportsProgress = True
        Me.bwCargar.WorkerSupportsCancellation = True
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 412)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.GCConsultar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtCorreoElectronico)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.cboTipoIdentificacion)
        Me.Controls.Add(Me.txtNumeroIdentificacion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Proveedores"
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsGrid.ResumeLayout(False)
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorreoElectronico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoIdentificacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroIdentificacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents txtContacto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCorreoElectronico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboTipoIdentificacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNumeroIdentificacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents chkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCorreoElectronico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContaco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bbiPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiPDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bwCargar As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmsGrid As ContextMenuStrip
    Friend WithEvents tsmImprimir As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmExportarExcel As ToolStripMenuItem
    Friend WithEvents tsmExportarPDF As ToolStripMenuItem
    Friend WithEvents sfdRuta As SaveFileDialog
End Class

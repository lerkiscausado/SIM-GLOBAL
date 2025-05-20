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
        Me.chkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAbrir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnombre_tarifa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cboCups = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTipoEstudio = New DevExpress.XtraEditors.LookUpEdit()
        Me.GCDetalleTarifa = New DevExpress.XtraGrid.GridControl()
        Me.GVDetalleTarifa = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUPS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.cboTipoAtencion = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCups.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDetalleTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDetalleTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoAtencion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(568, 47)
        Me.chkEstado.MenuManager = Me.BarManager1
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.Caption = "Activo"
        Me.chkEstado.Size = New System.Drawing.Size(59, 20)
        Me.chkEstado.TabIndex = 5
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir, Me.bbiEliminar, Me.bbiAbrir})
        Me.BarManager1.MaxItemId = 7
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAbrir), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir)})
        Me.Bar1.Text = "Herramientas"
        '
        'bbtNuevo
        '
        Me.bbtNuevo.Caption = "Nuevo"
        Me.bbtNuevo.Id = 0
        Me.bbtNuevo.ImageOptions.Image = CType(resources.GetObject("bbtNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbtNuevo.Name = "bbtNuevo"
        '
        'bbiAbrir
        '
        Me.bbiAbrir.Caption = "Abir"
        Me.bbiAbrir.Id = 6
        Me.bbiAbrir.ImageOptions.Image = CType(resources.GetObject("bbiAbrir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiAbrir.Name = "bbiAbrir"
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
        Me.bbiImprimir.Enabled = False
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
        Me.barDockControlTop.Size = New System.Drawing.Size(637, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 601)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(637, 0)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(637, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 577)
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar"
        Me.bbiEditar.Id = 1
        Me.bbiEditar.ImageOptions.Image = CType(resources.GetObject("bbiEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEditar.Name = "bbiEditar"
        '
        'bbiEliminar
        '
        Me.bbiEliminar.Caption = "Eliminar "
        Me.bbiEliminar.Enabled = False
        Me.bbiEliminar.Id = 5
        Me.bbiEliminar.ImageOptions.Image = CType(resources.GetObject("bbiEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEliminar.Name = "bbiEliminar"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(463, 12)
        Me.txtID.MenuManager = Me.BarManager1
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 2
        Me.txtID.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 50)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Nombre Tarifa"
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
        Me.colnombre_tarifa.Width = 522
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 1
        Me.colESTADO.Width = 71
        '
        'GCConsultar
        '
        Me.GCConsultar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCConsultar.Location = New System.Drawing.Point(14, 420)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(611, 169)
        Me.GCConsultar.TabIndex = 1
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'txtNombre
        '
        Me.txtNombre.EnterMoveNextControl = True
        Me.txtNombre.Location = New System.Drawing.Point(97, 47)
        Me.txtNombre.MenuManager = Me.BarManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Properties.MaxLength = 50
        Me.txtNombre.Size = New System.Drawing.Size(463, 20)
        Me.txtNombre.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(438, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID:"
        Me.LabelControl1.Visible = False
        '
        'cboCups
        '
        Me.cboCups.EditValue = ""
        Me.cboCups.Location = New System.Drawing.Point(248, 124)
        Me.cboCups.Name = "cboCups"
        Me.cboCups.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboCups.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCups.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cboCups.Size = New System.Drawing.Size(312, 20)
        Me.cboCups.TabIndex = 90
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO, Me.colNOMBRE})
        Me.SearchLookUpEdit1View.DetailHeight = 200
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 1000
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colCODIGO
        '
        Me.colCODIGO.Caption = "ID"
        Me.colCODIGO.FieldName = "ID"
        Me.colCODIGO.Name = "colCODIGO"
        Me.colCODIGO.Visible = True
        Me.colCODIGO.VisibleIndex = 0
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "NOMBRE"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.MaxWidth = 800
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 1
        Me.colNOMBRE.Width = 800
        '
        'cboTipoEstudio
        '
        Me.cboTipoEstudio.Location = New System.Drawing.Point(97, 98)
        Me.cboTipoEstudio.MenuManager = Me.BarManager1
        Me.cboTipoEstudio.Name = "cboTipoEstudio"
        Me.cboTipoEstudio.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTipoEstudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoEstudio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTUDIO", "ESTUDIO")})
        Me.cboTipoEstudio.Properties.NullText = ""
        Me.cboTipoEstudio.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboTipoEstudio.Properties.PopupSizeable = False
        Me.cboTipoEstudio.Properties.ShowHeader = False
        Me.cboTipoEstudio.Size = New System.Drawing.Size(463, 20)
        Me.cboTipoEstudio.TabIndex = 89
        '
        'GCDetalleTarifa
        '
        Me.GCDetalleTarifa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCDetalleTarifa.Location = New System.Drawing.Point(14, 176)
        Me.GCDetalleTarifa.MainView = Me.GVDetalleTarifa
        Me.GCDetalleTarifa.MenuManager = Me.BarManager1
        Me.GCDetalleTarifa.Name = "GCDetalleTarifa"
        Me.GCDetalleTarifa.Size = New System.Drawing.Size(611, 210)
        Me.GCDetalleTarifa.TabIndex = 88
        Me.GCDetalleTarifa.UseEmbeddedNavigator = True
        Me.GCDetalleTarifa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDetalleTarifa})
        '
        'GVDetalleTarifa
        '
        Me.GVDetalleTarifa.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colCODIGO1, Me.colESTUDIO, Me.colCUPS, Me.colNOMBRE1, Me.colVALOR})
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
        'colID1
        '
        Me.colID1.Caption = "ID"
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        Me.colID1.Width = 43
        '
        'colCODIGO1
        '
        Me.colCODIGO1.Caption = "CODIGO"
        Me.colCODIGO1.FieldName = "CODIGO"
        Me.colCODIGO1.Name = "colCODIGO1"
        Me.colCODIGO1.Visible = True
        Me.colCODIGO1.VisibleIndex = 0
        Me.colCODIGO1.Width = 63
        '
        'colESTUDIO
        '
        Me.colESTUDIO.Caption = "ESTUDIO"
        Me.colESTUDIO.FieldName = "ESTUDIO"
        Me.colESTUDIO.Name = "colESTUDIO"
        Me.colESTUDIO.Visible = True
        Me.colESTUDIO.VisibleIndex = 2
        Me.colESTUDIO.Width = 179
        '
        'colCUPS
        '
        Me.colCUPS.Caption = "CUPS"
        Me.colCUPS.FieldName = "CUPS"
        Me.colCUPS.Name = "colCUPS"
        Me.colCUPS.Visible = True
        Me.colCUPS.VisibleIndex = 1
        Me.colCUPS.Width = 61
        '
        'colNOMBRE1
        '
        Me.colNOMBRE1.Caption = "NOMBRE"
        Me.colNOMBRE1.FieldName = "NOMBRE"
        Me.colNOMBRE1.Name = "colNOMBRE1"
        Me.colNOMBRE1.Visible = True
        Me.colNOMBRE1.VisibleIndex = 3
        Me.colNOMBRE1.Width = 235
        '
        'colVALOR
        '
        Me.colVALOR.Caption = "VALOR"
        Me.colVALOR.DisplayFormat.FormatString = "C"
        Me.colVALOR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVALOR.FieldName = "VALOR"
        Me.colVALOR.Name = "colVALOR"
        Me.colVALOR.Visible = True
        Me.colVALOR.VisibleIndex = 4
        Me.colVALOR.Width = 111
        '
        'btnEliminar
        '
        Me.btnEliminar.ImageOptions.Image = CType(resources.GetObject("btnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(599, 148)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(26, 23)
        Me.btnEliminar.TabIndex = 87
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageOptions.Image = CType(resources.GetObject("btnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(566, 148)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregar.TabIndex = 86
        '
        'cboTipoAtencion
        '
        Me.cboTipoAtencion.Location = New System.Drawing.Point(248, 150)
        Me.cboTipoAtencion.MenuManager = Me.BarManager1
        Me.cboTipoAtencion.Name = "cboTipoAtencion"
        Me.cboTipoAtencion.Properties.AutoComplete = False
        Me.cboTipoAtencion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoAtencion.Properties.Items.AddRange(New Object() {"CONSULTA", "PROCEDIMIENTO"})
        Me.cboTipoAtencion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoAtencion.Size = New System.Drawing.Size(312, 20)
        Me.cboTipoAtencion.TabIndex = 33
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(178, 153)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl8.TabIndex = 32
        Me.LabelControl8.Text = "Tipo Atencion"
        '
        'txtValor
        '
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(97, 150)
        Me.txtValor.MenuManager = Me.BarManager1
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Properties.MaxLength = 50
        Me.txtValor.Size = New System.Drawing.Size(75, 20)
        Me.txtValor.TabIndex = 31
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 153)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl6.TabIndex = 30
        Me.LabelControl6.Text = "Valor"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(178, 127)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl5.TabIndex = 29
        Me.LabelControl5.Text = "Codigo Cups"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 101)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl4.TabIndex = 26
        Me.LabelControl4.Text = "Tipo Estudio"
        '
        'txtCodigo
        '
        Me.txtCodigo.EnterMoveNextControl = True
        Me.txtCodigo.Location = New System.Drawing.Point(97, 124)
        Me.txtCodigo.MenuManager = Me.BarManager1
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Properties.MaxLength = 10
        Me.txtCodigo.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigo.TabIndex = 22
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(12, 127)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl7.TabIndex = 20
        Me.LabelControl7.Text = "Codigo"
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Location = New System.Drawing.Point(12, 73)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(613, 22)
        Me.SeparatorControl2.TabIndex = 159
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(14, 392)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(611, 22)
        Me.SeparatorControl1.TabIndex = 160
        '
        'frmTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 601)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GCDetalleTarifa)
        Me.Controls.Add(Me.cboCups)
        Me.Controls.Add(Me.SeparatorControl2)
        Me.Controls.Add(Me.cboTipoAtencion)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.cboTipoEstudio)
        Me.Controls.Add(Me.GCConsultar)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frmTarifas.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmTarifas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifas"
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCups.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDetalleTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDetalleTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoAtencion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAbrir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnombre_tarifa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboCups As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCDetalleTarifa As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDetalleTarifa As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTUDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUPS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboTipoAtencion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoEstudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
End Class

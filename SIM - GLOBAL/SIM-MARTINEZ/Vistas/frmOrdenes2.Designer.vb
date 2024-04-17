<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenes2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenes2))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiUsuarios = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbi = New DevExpress.XtraBars.BarButtonItem()
        Me.GridSplitContainer1 = New DevExpress.XtraGrid.GridSplitContainer()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEXO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFONO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ppCargar = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.tcDatos = New DevExpress.XtraTab.XtraTabControl()
        Me.tpGeneral = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cboSubEntidad = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboSede = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtNeto = New DevExpress.XtraEditors.TextEdit()
        Me.cboContrato = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCopago = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.cboFinalidad = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoProcedimiento = New DevExpress.XtraEditors.TextEdit()
        Me.cboProcedimiento = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaOrden = New DevExpress.XtraEditors.DateEdit()
        Me.cboTipoUsuario = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroOrden = New DevExpress.XtraEditors.TextEdit()
        Me.cboTipoAfiliado = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAutorizacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDatosUsuario = New DevExpress.XtraEditors.MemoEdit()
        Me.txtConsecutivo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaIngreso = New DevExpress.XtraEditors.DateEdit()
        Me.bwLoad = New System.ComponentModel.BackgroundWorker()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridSplitContainer1.SuspendLayout()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.tcDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcDatos.SuspendLayout()
        Me.tpGeneral.SuspendLayout()
        CType(Me.cboSubEntidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSede.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNeto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCopago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFinalidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProcedimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProcedimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaOrden.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoAfiliado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAutorizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatosUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaIngreso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbi, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir, Me.bbiUsuarios})
        Me.BarManager1.MaxItemId = 6
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiUsuarios)})
        Me.Bar1.Text = "Herramientas"
        '
        'bbtNuevo
        '
        Me.bbtNuevo.Caption = "Nuevo"
        Me.bbtNuevo.Id = 0
        Me.bbtNuevo.ImageOptions.Image = CType(resources.GetObject("bbtNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbtNuevo.Name = "bbtNuevo"
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
        'bbiUsuarios
        '
        Me.bbiUsuarios.Caption = "Registro de Usuarios"
        Me.bbiUsuarios.Id = 5
        Me.bbiUsuarios.ImageOptions.Image = CType(resources.GetObject("bbiUsuarios.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiUsuarios.Name = "bbiUsuarios"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1168, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 580)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1168, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 549)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1168, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 549)
        '
        'bbi
        '
        Me.bbi.Caption = "Editar"
        Me.bbi.Id = 1
        Me.bbi.ImageOptions.Image = CType(resources.GetObject("bbi.ImageOptions.Image"), System.Drawing.Image)
        Me.bbi.Name = "bbi"
        '
        'GridSplitContainer1
        '
        Me.GridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSplitContainer1.Grid = Me.GCConsultar
        Me.GridSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.GridSplitContainer1.Name = "GridSplitContainer1"
        Me.GridSplitContainer1.Panel1.Controls.Add(Me.ppCargar)
        Me.GridSplitContainer1.Panel1.Controls.Add(Me.GCConsultar)
        Me.GridSplitContainer1.Size = New System.Drawing.Size(535, 549)
        Me.GridSplitContainer1.TabIndex = 0
        '
        'GCConsultar
        '
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(535, 549)
        Me.GCConsultar.TabIndex = 0
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colTI, Me.colIDENTIFICACION, Me.colNOMBRE, Me.colSEXO, Me.colTELEFONO})
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
        Me.GVConsultar.OptionsView.ShowFooter = True
        Me.GVConsultar.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 30
        '
        'colTI
        '
        Me.colTI.Caption = "TI"
        Me.colTI.FieldName = "TI"
        Me.colTI.Name = "colTI"
        Me.colTI.Visible = True
        Me.colTI.VisibleIndex = 0
        Me.colTI.Width = 29
        '
        'colIDENTIFICACION
        '
        Me.colIDENTIFICACION.Caption = "IDENTIFICACION"
        Me.colIDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACION.Name = "colIDENTIFICACION"
        Me.colIDENTIFICACION.Visible = True
        Me.colIDENTIFICACION.VisibleIndex = 1
        Me.colIDENTIFICACION.Width = 98
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "NOMBRE"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 2
        Me.colNOMBRE.Width = 190
        '
        'colSEXO
        '
        Me.colSEXO.Caption = "SEXO"
        Me.colSEXO.FieldName = "SEXO"
        Me.colSEXO.Name = "colSEXO"
        Me.colSEXO.Visible = True
        Me.colSEXO.VisibleIndex = 3
        Me.colSEXO.Width = 45
        '
        'colTELEFONO
        '
        Me.colTELEFONO.Caption = "TELEFONO"
        Me.colTELEFONO.FieldName = "TELEFONO"
        Me.colTELEFONO.Name = "colTELEFONO"
        Me.colTELEFONO.Visible = True
        Me.colTELEFONO.VisibleIndex = 4
        Me.colTELEFONO.Width = 269
        '
        'ppCargar
        '
        Me.ppCargar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ppCargar.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ppCargar.Appearance.Options.UseBackColor = True
        Me.ppCargar.BarAnimationElementThickness = 2
        Me.ppCargar.Caption = "Por Favor Espere"
        Me.ppCargar.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ppCargar.Description = "Cargando"
        Me.ppCargar.Location = New System.Drawing.Point(150, 156)
        Me.ppCargar.Name = "ppCargar"
        Me.ppCargar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ppCargar.Size = New System.Drawing.Size(238, 70)
        Me.ppCargar.TabIndex = 43
        Me.ppCargar.Text = "6"
        Me.ppCargar.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridSplitContainer1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.tcDatos)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtComentarios)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl6)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtDatosUsuario)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtConsecutivo)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.dtFechaIngreso)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1168, 549)
        Me.SplitContainerControl1.SplitterPosition = 535
        Me.SplitContainerControl1.TabIndex = 8
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'tcDatos
        '
        Me.tcDatos.Location = New System.Drawing.Point(20, 173)
        Me.tcDatos.Name = "tcDatos"
        Me.tcDatos.SelectedTabPage = Me.tpGeneral
        Me.tcDatos.Size = New System.Drawing.Size(594, 343)
        Me.tcDatos.TabIndex = 42
        Me.tcDatos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpGeneral})
        '
        'tpGeneral
        '
        Me.tpGeneral.Controls.Add(Me.LabelControl11)
        Me.tpGeneral.Controls.Add(Me.cboSubEntidad)
        Me.tpGeneral.Controls.Add(Me.cboSede)
        Me.tpGeneral.Controls.Add(Me.LabelControl7)
        Me.tpGeneral.Controls.Add(Me.SeparatorControl1)
        Me.tpGeneral.Controls.Add(Me.txtNeto)
        Me.tpGeneral.Controls.Add(Me.cboContrato)
        Me.tpGeneral.Controls.Add(Me.LabelControl4)
        Me.tpGeneral.Controls.Add(Me.LabelControl12)
        Me.tpGeneral.Controls.Add(Me.txtCopago)
        Me.tpGeneral.Controls.Add(Me.LabelControl20)
        Me.tpGeneral.Controls.Add(Me.txtValor)
        Me.tpGeneral.Controls.Add(Me.LabelControl21)
        Me.tpGeneral.Controls.Add(Me.cboFinalidad)
        Me.tpGeneral.Controls.Add(Me.LabelControl22)
        Me.tpGeneral.Controls.Add(Me.txtCodigoProcedimiento)
        Me.tpGeneral.Controls.Add(Me.cboProcedimiento)
        Me.tpGeneral.Controls.Add(Me.LabelControl19)
        Me.tpGeneral.Controls.Add(Me.LabelControl13)
        Me.tpGeneral.Controls.Add(Me.dtFechaOrden)
        Me.tpGeneral.Controls.Add(Me.cboTipoUsuario)
        Me.tpGeneral.Controls.Add(Me.LabelControl9)
        Me.tpGeneral.Controls.Add(Me.LabelControl10)
        Me.tpGeneral.Controls.Add(Me.txtNumeroOrden)
        Me.tpGeneral.Controls.Add(Me.cboTipoAfiliado)
        Me.tpGeneral.Controls.Add(Me.LabelControl8)
        Me.tpGeneral.Controls.Add(Me.txtAutorizacion)
        Me.tpGeneral.Controls.Add(Me.LabelControl5)
        Me.tpGeneral.Name = "tpGeneral"
        Me.tpGeneral.Size = New System.Drawing.Size(588, 315)
        Me.tpGeneral.Text = "General"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(12, 179)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl11.TabIndex = 69
        Me.LabelControl11.Text = "Sub Entidad"
        '
        'cboSubEntidad
        '
        Me.cboSubEntidad.Location = New System.Drawing.Point(12, 198)
        Me.cboSubEntidad.MenuManager = Me.BarManager1
        Me.cboSubEntidad.Name = "cboSubEntidad"
        Me.cboSubEntidad.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboSubEntidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSubEntidad.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "NOMBRE")})
        Me.cboSubEntidad.Properties.NullText = ""
        Me.cboSubEntidad.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboSubEntidad.Properties.PopupWidth = 600
        Me.cboSubEntidad.Properties.ShowHeader = False
        Me.cboSubEntidad.Size = New System.Drawing.Size(201, 20)
        Me.cboSubEntidad.TabIndex = 68
        '
        'cboSede
        '
        Me.cboSede.Location = New System.Drawing.Point(219, 198)
        Me.cboSede.MenuManager = Me.BarManager1
        Me.cboSede.Name = "cboSede"
        Me.cboSede.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboSede.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSede.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "NOMBRE")})
        Me.cboSede.Properties.NullText = ""
        Me.cboSede.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboSede.Properties.PopupWidth = 600
        Me.cboSede.Properties.ShowHeader = False
        Me.cboSede.Size = New System.Drawing.Size(355, 20)
        Me.cboSede.TabIndex = 67
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(223, 179)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl7.TabIndex = 66
        Me.LabelControl7.Text = "Sede:"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(12, 112)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(555, 18)
        Me.SeparatorControl1.TabIndex = 65
        '
        'txtNeto
        '
        Me.txtNeto.Location = New System.Drawing.Point(239, 286)
        Me.txtNeto.MenuManager = Me.BarManager1
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNeto.Properties.Appearance.Options.UseBackColor = True
        Me.txtNeto.Properties.Mask.EditMask = "c"
        Me.txtNeto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNeto.Properties.ReadOnly = True
        Me.txtNeto.Size = New System.Drawing.Size(109, 20)
        Me.txtNeto.TabIndex = 15
        '
        'cboContrato
        '
        Me.cboContrato.Location = New System.Drawing.Point(12, 153)
        Me.cboContrato.MenuManager = Me.BarManager1
        Me.cboContrato.Name = "cboContrato"
        Me.cboContrato.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboContrato.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CONTRATO", "CONTRATO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ENTIDAD", "ENTIDAD")})
        Me.cboContrato.Properties.NullText = ""
        Me.cboContrato.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboContrato.Properties.PopupWidth = 600
        Me.cboContrato.Size = New System.Drawing.Size(562, 20)
        Me.cboContrato.TabIndex = 10
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(16, 134)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl4.TabIndex = 43
        Me.LabelControl4.Text = "Entidad o Contrato:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(239, 267)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl12.TabIndex = 64
        Me.LabelControl12.Text = "Neto:"
        '
        'txtCopago
        '
        Me.txtCopago.Location = New System.Drawing.Point(126, 286)
        Me.txtCopago.MenuManager = Me.BarManager1
        Me.txtCopago.Name = "txtCopago"
        Me.txtCopago.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCopago.Properties.Appearance.Options.UseBackColor = True
        Me.txtCopago.Properties.Mask.EditMask = "c"
        Me.txtCopago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCopago.Size = New System.Drawing.Size(107, 20)
        Me.txtCopago.TabIndex = 14
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(126, 267)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl20.TabIndex = 62
        Me.LabelControl20.Text = "Copago:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(11, 286)
        Me.txtValor.MenuManager = Me.BarManager1
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtValor.Properties.Appearance.Options.UseBackColor = True
        Me.txtValor.Properties.Mask.BeepOnError = True
        Me.txtValor.Properties.Mask.EditMask = "c"
        Me.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValor.Size = New System.Drawing.Size(108, 20)
        Me.txtValor.TabIndex = 13
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(11, 269)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl21.TabIndex = 60
        Me.LabelControl21.Text = "Valor:"
        '
        'cboFinalidad
        '
        Me.cboFinalidad.Location = New System.Drawing.Point(239, 87)
        Me.cboFinalidad.MenuManager = Me.BarManager1
        Me.cboFinalidad.Name = "cboFinalidad"
        Me.cboFinalidad.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboFinalidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFinalidad.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FINALIDAD", "FINALIDAD")})
        Me.cboFinalidad.Properties.NullText = ""
        Me.cboFinalidad.Properties.PopupWidth = 600
        Me.cboFinalidad.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cboFinalidad.Properties.ShowHeader = False
        Me.cboFinalidad.Size = New System.Drawing.Size(273, 20)
        Me.cboFinalidad.TabIndex = 9
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(241, 68)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl22.TabIndex = 57
        Me.LabelControl22.Text = "Finalidad:"
        '
        'txtCodigoProcedimiento
        '
        Me.txtCodigoProcedimiento.Location = New System.Drawing.Point(12, 243)
        Me.txtCodigoProcedimiento.MenuManager = Me.BarManager1
        Me.txtCodigoProcedimiento.Name = "txtCodigoProcedimiento"
        Me.txtCodigoProcedimiento.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCodigoProcedimiento.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtCodigoProcedimiento.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigoProcedimiento.Properties.Appearance.Options.UseForeColor = True
        Me.txtCodigoProcedimiento.Properties.ReadOnly = True
        Me.txtCodigoProcedimiento.Size = New System.Drawing.Size(107, 20)
        Me.txtCodigoProcedimiento.TabIndex = 11
        '
        'cboProcedimiento
        '
        Me.cboProcedimiento.Location = New System.Drawing.Point(126, 243)
        Me.cboProcedimiento.MenuManager = Me.BarManager1
        Me.cboProcedimiento.Name = "cboProcedimiento"
        Me.cboProcedimiento.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboProcedimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProcedimiento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO", "CODIGO", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTUDIO", "ESTUDIO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("VALOR", "VALOR", 20, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPOESTUDIO", "TIPOESTUDIO", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUPS", "CUPS", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboProcedimiento.Properties.NullText = ""
        Me.cboProcedimiento.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboProcedimiento.Properties.PopupWidth = 600
        Me.cboProcedimiento.Size = New System.Drawing.Size(448, 20)
        Me.cboProcedimiento.TabIndex = 12
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(11, 224)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(125, 13)
        Me.LabelControl19.TabIndex = 53
        Me.LabelControl19.Text = "Consulta o Procedimiento:"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(369, 17)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl13.TabIndex = 51
        Me.LabelControl13.Text = "Fecha Orden:"
        '
        'dtFechaOrden
        '
        Me.dtFechaOrden.EditValue = Nothing
        Me.dtFechaOrden.Location = New System.Drawing.Point(369, 36)
        Me.dtFechaOrden.MenuManager = Me.BarManager1
        Me.dtFechaOrden.Name = "dtFechaOrden"
        Me.dtFechaOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaOrden.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaOrden.Size = New System.Drawing.Size(100, 20)
        Me.dtFechaOrden.TabIndex = 6
        '
        'cboTipoUsuario
        '
        Me.cboTipoUsuario.Location = New System.Drawing.Point(154, 36)
        Me.cboTipoUsuario.MenuManager = Me.BarManager1
        Me.cboTipoUsuario.Name = "cboTipoUsuario"
        Me.cboTipoUsuario.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTipoUsuario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoUsuario.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPO", "TIPO")})
        Me.cboTipoUsuario.Properties.NullText = ""
        Me.cboTipoUsuario.Properties.PopupWidth = 600
        Me.cboTipoUsuario.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cboTipoUsuario.Properties.ShowHeader = False
        Me.cboTipoUsuario.Size = New System.Drawing.Size(209, 20)
        Me.cboTipoUsuario.TabIndex = 5
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(154, 17)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(116, 13)
        Me.LabelControl9.TabIndex = 46
        Me.LabelControl9.Text = "Regimen o Tipo Usuario:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(126, 68)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl10.TabIndex = 49
        Me.LabelControl10.Text = "No. de Orden"
        '
        'txtNumeroOrden
        '
        Me.txtNumeroOrden.Location = New System.Drawing.Point(126, 87)
        Me.txtNumeroOrden.MenuManager = Me.BarManager1
        Me.txtNumeroOrden.Name = "txtNumeroOrden"
        Me.txtNumeroOrden.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNumeroOrden.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumeroOrden.Size = New System.Drawing.Size(107, 20)
        Me.txtNumeroOrden.TabIndex = 8
        '
        'cboTipoAfiliado
        '
        Me.cboTipoAfiliado.Location = New System.Drawing.Point(12, 36)
        Me.cboTipoAfiliado.MenuManager = Me.BarManager1
        Me.cboTipoAfiliado.Name = "cboTipoAfiliado"
        Me.cboTipoAfiliado.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTipoAfiliado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoAfiliado.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPO", "TIPO")})
        Me.cboTipoAfiliado.Properties.NullText = ""
        Me.cboTipoAfiliado.Properties.PopupWidth = 600
        Me.cboTipoAfiliado.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cboTipoAfiliado.Properties.ShowHeader = False
        Me.cboTipoAfiliado.Size = New System.Drawing.Size(136, 20)
        Me.cboTipoAfiliado.TabIndex = 4
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(12, 17)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl8.TabIndex = 43
        Me.LabelControl8.Text = "Tipo Afiliado:"
        '
        'txtAutorizacion
        '
        Me.txtAutorizacion.Location = New System.Drawing.Point(12, 87)
        Me.txtAutorizacion.MenuManager = Me.BarManager1
        Me.txtAutorizacion.Name = "txtAutorizacion"
        Me.txtAutorizacion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtAutorizacion.Properties.Appearance.Options.UseBackColor = True
        Me.txtAutorizacion.Size = New System.Drawing.Size(107, 20)
        Me.txtAutorizacion.TabIndex = 7
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 68)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl5.TabIndex = 45
        Me.LabelControl5.Text = "Autorizacion:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(20, 39)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "Paciente:"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(429, 58)
        Me.txtComentarios.MenuManager = Me.BarManager1
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtComentarios.Properties.Appearance.Options.UseBackColor = True
        Me.txtComentarios.Size = New System.Drawing.Size(171, 109)
        Me.txtComentarios.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(429, 39)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl6.TabIndex = 34
        Me.LabelControl6.Text = "Comentarios:"
        '
        'txtDatosUsuario
        '
        Me.txtDatosUsuario.Location = New System.Drawing.Point(20, 58)
        Me.txtDatosUsuario.MenuManager = Me.BarManager1
        Me.txtDatosUsuario.Name = "txtDatosUsuario"
        Me.txtDatosUsuario.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDatosUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDatosUsuario.Properties.Appearance.Options.UseBackColor = True
        Me.txtDatosUsuario.Properties.Appearance.Options.UseFont = True
        Me.txtDatosUsuario.Properties.ReadOnly = True
        Me.txtDatosUsuario.Size = New System.Drawing.Size(403, 109)
        Me.txtDatosUsuario.TabIndex = 3
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(505, 12)
        Me.txtConsecutivo.MenuManager = Me.BarManager1
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtConsecutivo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtConsecutivo.Properties.Appearance.Options.UseBackColor = True
        Me.txtConsecutivo.Properties.Appearance.Options.UseForeColor = True
        Me.txtConsecutivo.Properties.ReadOnly = True
        Me.txtConsecutivo.Size = New System.Drawing.Size(100, 20)
        Me.txtConsecutivo.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(407, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Consecutivo Orden"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Fecha Ingreso:"
        '
        'dtFechaIngreso
        '
        Me.dtFechaIngreso.EditValue = Nothing
        Me.dtFechaIngreso.Location = New System.Drawing.Point(99, 12)
        Me.dtFechaIngreso.MenuManager = Me.BarManager1
        Me.dtFechaIngreso.Name = "dtFechaIngreso"
        Me.dtFechaIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaIngreso.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaIngreso.Properties.ReadOnly = True
        Me.dtFechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.dtFechaIngreso.TabIndex = 0
        '
        'bwLoad
        '
        '
        'frmOrdenes2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 580)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdenes2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes o Admisiones de Pacientes"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridSplitContainer1.ResumeLayout(False)
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.tcDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcDatos.ResumeLayout(False)
        Me.tpGeneral.ResumeLayout(False)
        Me.tpGeneral.PerformLayout()
        CType(Me.cboSubEntidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSede.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNeto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCopago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFinalidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProcedimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProcedimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaOrden.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoAfiliado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAutorizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatosUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaIngreso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridSplitContainer1 As DevExpress.XtraGrid.GridSplitContainer
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaIngreso As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtConsecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDatosUsuario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bbiUsuarios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tcDatos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpGeneral As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cboTipoUsuario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoAfiliado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboContrato As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAutorizacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaOrden As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumeroOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNeto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCopago As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboFinalidad As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoProcedimiento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboProcedimiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents cboSede As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboSubEntidad As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEXO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bwLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents ppCargar As DevExpress.XtraWaitForm.ProgressPanel
End Class

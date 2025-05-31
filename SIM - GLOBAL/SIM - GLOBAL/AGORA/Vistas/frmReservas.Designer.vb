<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservas))
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEnviarEmail = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiOrdenServicio = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DNFecha = New DevExpress.XtraScheduler.DateNavigator()
        Me.GCFecha = New DevExpress.XtraEditors.GroupControl()
        Me.GCReservas = New DevExpress.XtraGrid.GridControl()
        Me.GVReservas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHORA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEVENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cboSalon = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DNFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DNFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCFecha.SuspendLayout()
        CType(Me.GCReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSalon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl2.Manager = Nothing
        Me.BarDockControl2.Size = New System.Drawing.Size(1072, 0)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiNuevo, Me.bbiImprimir, Me.bbiEnviarEmail, Me.bbiOrdenServicio})
        Me.BarManager1.MaxItemId = 4
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEnviarEmail, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiOrdenServicio), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir, True)})
        Me.Bar1.Text = "Herramientas"
        '
        'bbiNuevo
        '
        Me.bbiNuevo.Caption = "Nuevo"
        Me.bbiNuevo.Id = 0
        Me.bbiNuevo.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiNuevo.Name = "bbiNuevo"
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.Id = 1
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'bbiEnviarEmail
        '
        Me.bbiEnviarEmail.Caption = "Enviar Email"
        Me.bbiEnviarEmail.Id = 2
        Me.bbiEnviarEmail.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEnviarEmail.Name = "bbiEnviarEmail"
        '
        'bbiOrdenServicio
        '
        Me.bbiOrdenServicio.Caption = "Vista Orden de Servicio"
        Me.bbiOrdenServicio.Id = 3
        Me.bbiOrdenServicio.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiOrdenServicio.Name = "bbiOrdenServicio"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1072, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 511)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1072, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 487)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1072, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 487)
        '
        'DNFecha
        '
        Me.DNFecha.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.DNFecha.CalendarAppearance.DayCellSpecial.Options.UseFont = True
        Me.DNFecha.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DNFecha.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.[Default]
        Me.DNFecha.DateTime = New Date(2022, 4, 1, 0, 0, 0, 0)
        Me.DNFecha.EditValue = New Date(2022, 4, 1, 0, 0, 0, 0)
        Me.DNFecha.FirstDayOfWeek = System.DayOfWeek.Sunday
        Me.DNFecha.Location = New System.Drawing.Point(12, 26)
        Me.DNFecha.Name = "DNFecha"
        Me.DNFecha.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.[Single]
        Me.DNFecha.Size = New System.Drawing.Size(233, 473)
        Me.DNFecha.TabIndex = 7
        '
        'GCFecha
        '
        Me.GCFecha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCFecha.Controls.Add(Me.GCReservas)
        Me.GCFecha.Location = New System.Drawing.Point(251, 62)
        Me.GCFecha.Name = "GCFecha"
        Me.GCFecha.Size = New System.Drawing.Size(809, 437)
        Me.GCFecha.TabIndex = 8
        Me.GCFecha.Text = "Agenda del Dia"
        '
        'GCReservas
        '
        Me.GCReservas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCReservas.Location = New System.Drawing.Point(2, 23)
        Me.GCReservas.MainView = Me.GVReservas
        Me.GCReservas.Name = "GCReservas"
        Me.GCReservas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.GCReservas.Size = New System.Drawing.Size(805, 412)
        Me.GCReservas.TabIndex = 2
        Me.GCReservas.UseEmbeddedNavigator = True
        Me.GCReservas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVReservas})
        '
        'GVReservas
        '
        Me.GVReservas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colHORA, Me.colCLIENTE, Me.colEVENTO, Me.colCONCEPTO, Me.colESTADO})
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Name = "Format0"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Expression = "CANCELADA"
        FormatConditionRuleValue2.Value1 = "CANCELADA"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.GVReservas.FormatRules.Add(GridFormatRule2)
        Me.GVReservas.GridControl = Me.GCReservas
        Me.GVReservas.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVReservas.Name = "GVReservas"
        Me.GVReservas.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVReservas.OptionsBehavior.ReadOnly = True
        Me.GVReservas.OptionsPrint.AutoWidth = False
        Me.GVReservas.OptionsView.AllowCellMerge = True
        Me.GVReservas.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast
        Me.GVReservas.OptionsView.ColumnAutoWidth = False
        Me.GVReservas.OptionsView.EnableAppearanceOddRow = True
        Me.GVReservas.OptionsView.ShowGroupPanel = False
        Me.GVReservas.OptionsView.ShowGroupPanelColumnsAsSingleRow = True
        Me.GVReservas.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colHORA
        '
        Me.colHORA.Caption = "HORA"
        Me.colHORA.FieldName = "HORA"
        Me.colHORA.Name = "colHORA"
        Me.colHORA.Visible = True
        Me.colHORA.VisibleIndex = 0
        '
        'colCLIENTE
        '
        Me.colCLIENTE.Caption = "CLIENTE"
        Me.colCLIENTE.FieldName = "CLIENTE"
        Me.colCLIENTE.Name = "colCLIENTE"
        Me.colCLIENTE.Visible = True
        Me.colCLIENTE.VisibleIndex = 1
        Me.colCLIENTE.Width = 182
        '
        'colEVENTO
        '
        Me.colEVENTO.Caption = "EVENTO"
        Me.colEVENTO.FieldName = "EVENTO"
        Me.colEVENTO.Name = "colEVENTO"
        Me.colEVENTO.Visible = True
        Me.colEVENTO.VisibleIndex = 2
        Me.colEVENTO.Width = 229
        '
        'colCONCEPTO
        '
        Me.colCONCEPTO.Caption = "CONCEPTO"
        Me.colCONCEPTO.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colCONCEPTO.FieldName = "CONCEPTO"
        Me.colCONCEPTO.Name = "colCONCEPTO"
        Me.colCONCEPTO.Visible = True
        Me.colCONCEPTO.VisibleIndex = 3
        Me.colCONCEPTO.Width = 390
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(253, 39)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl5.TabIndex = 127
        Me.LabelControl5.Text = "Salon"
        '
        'cboSalon
        '
        Me.cboSalon.Location = New System.Drawing.Point(285, 36)
        Me.cboSalon.Name = "cboSalon"
        Me.cboSalon.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboSalon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSalon.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SALON", "SALON")})
        Me.cboSalon.Properties.NullText = ""
        Me.cboSalon.Properties.ShowHeader = False
        Me.cboSalon.Size = New System.Drawing.Size(349, 20)
        Me.cboSalon.TabIndex = 133
        '
        'frmReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 511)
        Me.Controls.Add(Me.cboSalon)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.GCFecha)
        Me.Controls.Add(Me.DNFecha)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Image = CType(resources.GetObject("frmReservas.IconOptions.Image"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservas"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DNFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DNFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCFecha.ResumeLayout(False)
        CType(Me.GCReservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVReservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSalon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEnviarEmail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiOrdenServicio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DNFecha As DevExpress.XtraScheduler.DateNavigator
    Friend WithEvents GCFecha As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCReservas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVReservas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents cboSalon As DevExpress.XtraEditors.LookUpEdit
End Class

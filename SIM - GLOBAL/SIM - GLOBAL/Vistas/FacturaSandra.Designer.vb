<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaSandra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturaSandra))
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.Bar7 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.bbiExportarExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.XtraTabControl3 = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpConsulta = New DevExpress.XtraTab.XtraTabPage()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCaso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaIngreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubEntidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstudio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAutorizacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEspecimen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCups = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportarPDF = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl3.SuspendLayout()
        Me.xtpConsulta.SuspendLayout()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar7
        '
        Me.Bar7.BarName = "Herramientas"
        Me.Bar7.DockCol = 0
        Me.Bar7.DockRow = 0
        Me.Bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar7.Text = "Herramientas"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Herramientas"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.Text = "Herramientas"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Herramientas"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.Text = "Herramientas"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Herramientas"
        '
        'Bar5
        '
        Me.Bar5.BarName = "Herramientas"
        Me.Bar5.DockCol = 0
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar5.Text = "Herramientas"
        '
        'bbiExportarExcel
        '
        Me.bbiExportarExcel.Caption = "Exportar a Excel"
        Me.bbiExportarExcel.Id = 5
        Me.bbiExportarExcel.ImageOptions.Image = CType(resources.GetObject("bbiExportarExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiExportarExcel.Name = "bbiExportarExcel"
        '
        'XtraTabControl3
        '
        Me.XtraTabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl3.Location = New System.Drawing.Point(12, 30)
        Me.XtraTabControl3.Name = "XtraTabControl3"
        Me.XtraTabControl3.SelectedTabPage = Me.xtpConsulta
        Me.XtraTabControl3.Size = New System.Drawing.Size(1106, 529)
        Me.XtraTabControl3.TabIndex = 171
        Me.XtraTabControl3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpConsulta})
        '
        'xtpConsulta
        '
        Me.xtpConsulta.Controls.Add(Me.GCConsultar)
        Me.xtpConsulta.Name = "xtpConsulta"
        Me.xtpConsulta.Size = New System.Drawing.Size(1104, 504)
        Me.xtpConsulta.Text = "Resultado de Consulta"
        '
        'GCConsultar
        '
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(1104, 504)
        Me.GCConsultar.TabIndex = 13
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCaso, Me.colFechaIngreso, Me.colIdentificacion, Me.colNombre, Me.colSexo, Me.colEntidad, Me.colSubEntidad, Me.colEstudio, Me.colAutorizacion, Me.colEspecimen, Me.colCups, Me.colValor, Me.colEstado, Me.colOrden})
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultar.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultar.OptionsPrint.PrintFooter = False
        Me.GVConsultar.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GVConsultar.OptionsView.ColumnAutoWidth = False
        Me.GVConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsView.ShowGroupPanel = False
        '
        'colCaso
        '
        Me.colCaso.Caption = "CASO"
        Me.colCaso.FieldName = "CASO"
        Me.colCaso.Name = "colCaso"
        Me.colCaso.OptionsColumn.AllowEdit = False
        Me.colCaso.OptionsColumn.ReadOnly = True
        Me.colCaso.Visible = True
        Me.colCaso.VisibleIndex = 0
        Me.colCaso.Width = 58
        '
        'colFechaIngreso
        '
        Me.colFechaIngreso.Caption = "FECHA INGRESO"
        Me.colFechaIngreso.FieldName = "FECHA_INGRESO"
        Me.colFechaIngreso.Name = "colFechaIngreso"
        Me.colFechaIngreso.OptionsColumn.AllowEdit = False
        Me.colFechaIngreso.OptionsColumn.ReadOnly = True
        Me.colFechaIngreso.Visible = True
        Me.colFechaIngreso.VisibleIndex = 1
        Me.colFechaIngreso.Width = 78
        '
        'colIdentificacion
        '
        Me.colIdentificacion.Caption = "IDENTIFICACION"
        Me.colIdentificacion.FieldName = "IDENTIFICACION"
        Me.colIdentificacion.Name = "colIdentificacion"
        Me.colIdentificacion.OptionsColumn.AllowEdit = False
        Me.colIdentificacion.OptionsColumn.ReadOnly = True
        Me.colIdentificacion.Visible = True
        Me.colIdentificacion.VisibleIndex = 2
        Me.colIdentificacion.Width = 102
        '
        'colNombre
        '
        Me.colNombre.Caption = "NOMBRE"
        Me.colNombre.FieldName = "NOMBRE"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.OptionsColumn.ReadOnly = True
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 3
        Me.colNombre.Width = 239
        '
        'colSexo
        '
        Me.colSexo.Caption = "SEXO"
        Me.colSexo.FieldName = "SEXO"
        Me.colSexo.Name = "colSexo"
        Me.colSexo.OptionsColumn.AllowEdit = False
        Me.colSexo.OptionsColumn.ReadOnly = True
        Me.colSexo.Visible = True
        Me.colSexo.VisibleIndex = 4
        Me.colSexo.Width = 67
        '
        'colEntidad
        '
        Me.colEntidad.Caption = "ENTIDAD"
        Me.colEntidad.FieldName = "ENTIDAD"
        Me.colEntidad.Name = "colEntidad"
        Me.colEntidad.OptionsColumn.AllowEdit = False
        Me.colEntidad.OptionsColumn.ReadOnly = True
        Me.colEntidad.Visible = True
        Me.colEntidad.VisibleIndex = 5
        Me.colEntidad.Width = 160
        '
        'colSubEntidad
        '
        Me.colSubEntidad.Caption = "SUBENTIDAD"
        Me.colSubEntidad.FieldName = "SUBENTIDAD"
        Me.colSubEntidad.Name = "colSubEntidad"
        Me.colSubEntidad.OptionsColumn.AllowEdit = False
        Me.colSubEntidad.OptionsColumn.ReadOnly = True
        Me.colSubEntidad.Visible = True
        Me.colSubEntidad.VisibleIndex = 6
        Me.colSubEntidad.Width = 170
        '
        'colEstudio
        '
        Me.colEstudio.Caption = "ESTUDIO"
        Me.colEstudio.FieldName = "ESTUDIO"
        Me.colEstudio.Name = "colEstudio"
        Me.colEstudio.OptionsColumn.AllowEdit = False
        Me.colEstudio.OptionsColumn.ReadOnly = True
        Me.colEstudio.Visible = True
        Me.colEstudio.VisibleIndex = 7
        Me.colEstudio.Width = 236
        '
        'colAutorizacion
        '
        Me.colAutorizacion.Caption = "AUTORIZACION"
        Me.colAutorizacion.FieldName = "AUTORIZACION"
        Me.colAutorizacion.Name = "colAutorizacion"
        Me.colAutorizacion.Visible = True
        Me.colAutorizacion.VisibleIndex = 8
        Me.colAutorizacion.Width = 98
        '
        'colEspecimen
        '
        Me.colEspecimen.Caption = "ESPECIMEN"
        Me.colEspecimen.FieldName = "ESPECIMEN"
        Me.colEspecimen.Name = "colEspecimen"
        Me.colEspecimen.OptionsColumn.AllowEdit = False
        Me.colEspecimen.OptionsColumn.ReadOnly = True
        Me.colEspecimen.Visible = True
        Me.colEspecimen.VisibleIndex = 9
        Me.colEspecimen.Width = 200
        '
        'colCups
        '
        Me.colCups.Caption = "CUPS"
        Me.colCups.FieldName = "CUPS"
        Me.colCups.Name = "colCups"
        Me.colCups.OptionsColumn.AllowEdit = False
        Me.colCups.OptionsColumn.ReadOnly = True
        Me.colCups.Visible = True
        Me.colCups.VisibleIndex = 10
        Me.colCups.Width = 81
        '
        'colValor
        '
        Me.colValor.Caption = "VALOR"
        Me.colValor.FieldName = "VALOR"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.AllowEdit = False
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 11
        Me.colValor.Width = 87
        '
        'colEstado
        '
        Me.colEstado.Caption = "ESTADO"
        Me.colEstado.FieldName = "ESTADO"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowEdit = False
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 12
        Me.colEstado.Width = 82
        '
        'colOrden
        '
        Me.colOrden.Caption = "ORDEN"
        Me.colOrden.FieldName = "ORDEN"
        Me.colOrden.Name = "colOrden"
        Me.colOrden.OptionsColumn.AllowEdit = False
        Me.colOrden.OptionsColumn.ReadOnly = True
        Me.colOrden.Visible = True
        Me.colOrden.VisibleIndex = 13
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar4})
        Me.BarManager1.DockControls.Add(Me.BarDockControl3)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiConsultar, Me.bbiExportarPDF, Me.bbiExportarExcel})
        Me.BarManager1.MaxItemId = 6
        '
        'Bar4
        '
        Me.Bar4.BarName = "Herramientas"
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportarPDF, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportarExcel)})
        Me.Bar4.Text = "Herramientas"
        '
        'bbiConsultar
        '
        Me.bbiConsultar.Caption = "Consultar"
        Me.bbiConsultar.Id = 3
        Me.bbiConsultar.ImageOptions.Image = CType(resources.GetObject("bbiConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiConsultar.Name = "bbiConsultar"
        '
        'bbiExportarPDF
        '
        Me.bbiExportarPDF.Caption = "Exportar PDF"
        Me.bbiExportarPDF.Id = 4
        Me.bbiExportarPDF.ImageOptions.Image = CType(resources.GetObject("bbiExportarPDF.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiExportarPDF.Name = "bbiExportarPDF"
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager1
        Me.BarDockControl3.Size = New System.Drawing.Size(1130, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 571)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1130, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 547)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1130, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 547)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl2.Manager = Nothing
        Me.BarDockControl2.Size = New System.Drawing.Size(1130, 0)
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl1.Manager = Nothing
        Me.BarDockControl1.Size = New System.Drawing.Size(1130, 0)
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(1130, 0)
        '
        'FacturaSandra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 571)
        Me.Controls.Add(Me.XtraTabControl3)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Name = "FacturaSandra"
        Me.Text = "Listado de Ordenes a Facturar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl3.ResumeLayout(False)
        Me.xtpConsulta.ResumeLayout(False)
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents Bar7 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiExportarExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabControl3 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpConsulta As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExportarPDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCaso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubEntidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstudio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEspecimen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCups As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAutorizacion As DevExpress.XtraGrid.Columns.GridColumn
End Class

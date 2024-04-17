<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultar
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultar))
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INGRESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEXO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFONOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSede = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmActualizarVista = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltratPorAñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm2020 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm2019 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm2018 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm2017 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmVistaPrevia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmExportarExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExportarPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.ppCargar = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.bwCargar = New System.ComponentModel.BackgroundWorker()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.colDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 11
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colORDEN, Me.colFECHA_INGRESO, Me.colIDENTIFICACION, Me.colNOMBRE, Me.colSEXO, Me.colEDAD, Me.colTELEFONOS, Me.colESTUDIO, Me.colCONTRATO, Me.colENTIDAD, Me.colESTADO, Me.colSede, Me.colDetalle})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colESTADO
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Expression = "CANCELADO"
        FormatConditionRuleValue1.Value1 = "CANCELADO"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.colESTADO
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Expression = "PENDIENTE"
        FormatConditionRuleValue2.Value1 = "PENDIENTE"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.GVConsultar.FormatRules.Add(GridFormatRule1)
        Me.GVConsultar.FormatRules.Add(GridFormatRule2)
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsBehavior.ReadOnly = True
        Me.GVConsultar.OptionsFind.AlwaysVisible = True
        Me.GVConsultar.OptionsPrint.AutoWidth = False
        Me.GVConsultar.OptionsView.ColumnAutoWidth = False
        Me.GVConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsView.ShowFooter = True
        Me.GVConsultar.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.GVConsultar.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colORDEN, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colORDEN
        '
        Me.colORDEN.FieldName = "ORDEN"
        Me.colORDEN.Name = "colORDEN"
        Me.colORDEN.Visible = True
        Me.colORDEN.VisibleIndex = 0
        Me.colORDEN.Width = 55
        '
        'colFECHA_INGRESO
        '
        Me.colFECHA_INGRESO.Caption = "FECHA INGRESO"
        Me.colFECHA_INGRESO.FieldName = "FECHA_INGRESO"
        Me.colFECHA_INGRESO.Name = "colFECHA_INGRESO"
        Me.colFECHA_INGRESO.Visible = True
        Me.colFECHA_INGRESO.VisibleIndex = 1
        Me.colFECHA_INGRESO.Width = 98
        '
        'colIDENTIFICACION
        '
        Me.colIDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACION.Name = "colIDENTIFICACION"
        Me.colIDENTIFICACION.Visible = True
        Me.colIDENTIFICACION.VisibleIndex = 2
        Me.colIDENTIFICACION.Width = 124
        '
        'colNOMBRE
        '
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 3
        Me.colNOMBRE.Width = 208
        '
        'colSEXO
        '
        Me.colSEXO.FieldName = "SEXO"
        Me.colSEXO.Name = "colSEXO"
        Me.colSEXO.Visible = True
        Me.colSEXO.VisibleIndex = 4
        Me.colSEXO.Width = 36
        '
        'colEDAD
        '
        Me.colEDAD.FieldName = "EDAD"
        Me.colEDAD.Name = "colEDAD"
        Me.colEDAD.Visible = True
        Me.colEDAD.VisibleIndex = 5
        Me.colEDAD.Width = 37
        '
        'colTELEFONOS
        '
        Me.colTELEFONOS.FieldName = "TELEFONOS"
        Me.colTELEFONOS.Name = "colTELEFONOS"
        Me.colTELEFONOS.Visible = True
        Me.colTELEFONOS.VisibleIndex = 6
        Me.colTELEFONOS.Width = 143
        '
        'colESTUDIO
        '
        Me.colESTUDIO.FieldName = "ESTUDIO"
        Me.colESTUDIO.Name = "colESTUDIO"
        Me.colESTUDIO.Visible = True
        Me.colESTUDIO.VisibleIndex = 7
        Me.colESTUDIO.Width = 154
        '
        'colCONTRATO
        '
        Me.colCONTRATO.FieldName = "CONTRATO"
        Me.colCONTRATO.Name = "colCONTRATO"
        Me.colCONTRATO.Visible = True
        Me.colCONTRATO.VisibleIndex = 8
        Me.colCONTRATO.Width = 188
        '
        'colENTIDAD
        '
        Me.colENTIDAD.FieldName = "ENTIDAD"
        Me.colENTIDAD.Name = "colENTIDAD"
        Me.colENTIDAD.Visible = True
        Me.colENTIDAD.VisibleIndex = 9
        Me.colENTIDAD.Width = 180
        '
        'colSede
        '
        Me.colSede.Caption = "SEDE"
        Me.colSede.FieldName = "SEDE"
        Me.colSede.Name = "colSede"
        Me.colSede.Visible = True
        Me.colSede.VisibleIndex = 10
        Me.colSede.Width = 202
        '
        'GCConsultar
        '
        Me.GCConsultar.ContextMenuStrip = Me.cmsGrid
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(1096, 465)
        Me.GCConsultar.TabIndex = 0
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'cmsGrid
        '
        Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmActualizarVista, Me.FiltratPorAñoToolStripMenuItem, Me.ToolStripSeparator1, Me.tsmVistaPrevia, Me.tsmImprimir, Me.ToolStripSeparator2, Me.tsmExportarExcel, Me.tsmExportarPDF})
        Me.cmsGrid.Name = "cmsGrid"
        Me.cmsGrid.Size = New System.Drawing.Size(199, 148)
        '
        'tsmActualizarVista
        '
        Me.tsmActualizarVista.Image = CType(resources.GetObject("tsmActualizarVista.Image"), System.Drawing.Image)
        Me.tsmActualizarVista.Name = "tsmActualizarVista"
        Me.tsmActualizarVista.Size = New System.Drawing.Size(198, 22)
        Me.tsmActualizarVista.Text = "Actualizar Listado"
        '
        'FiltratPorAñoToolStripMenuItem
        '
        Me.FiltratPorAñoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm2020, Me.tsm2019, Me.tsm2018, Me.tsm2017})
        Me.FiltratPorAñoToolStripMenuItem.Image = CType(resources.GetObject("FiltratPorAñoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FiltratPorAñoToolStripMenuItem.Name = "FiltratPorAñoToolStripMenuItem"
        Me.FiltratPorAñoToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.FiltratPorAñoToolStripMenuItem.Text = "Filtrat por Año"
        '
        'tsm2020
        '
        Me.tsm2020.Name = "tsm2020"
        Me.tsm2020.Size = New System.Drawing.Size(133, 22)
        Me.tsm2020.Text = "Año Actual"
        '
        'tsm2019
        '
        Me.tsm2019.Name = "tsm2019"
        Me.tsm2019.Size = New System.Drawing.Size(133, 22)
        Me.tsm2019.Text = "2019"
        '
        'tsm2018
        '
        Me.tsm2018.Name = "tsm2018"
        Me.tsm2018.Size = New System.Drawing.Size(133, 22)
        Me.tsm2018.Text = "2018"
        '
        'tsm2017
        '
        Me.tsm2017.Name = "tsm2017"
        Me.tsm2017.Size = New System.Drawing.Size(133, 22)
        Me.tsm2017.Text = "2017"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'tsmVistaPrevia
        '
        Me.tsmVistaPrevia.Image = CType(resources.GetObject("tsmVistaPrevia.Image"), System.Drawing.Image)
        Me.tsmVistaPrevia.Name = "tsmVistaPrevia"
        Me.tsmVistaPrevia.Size = New System.Drawing.Size(198, 22)
        Me.tsmVistaPrevia.Text = "Vista Previa Reporte"
        '
        'tsmImprimir
        '
        Me.tsmImprimir.Image = CType(resources.GetObject("tsmImprimir.Image"), System.Drawing.Image)
        Me.tsmImprimir.Name = "tsmImprimir"
        Me.tsmImprimir.Size = New System.Drawing.Size(198, 22)
        Me.tsmImprimir.Text = "Imprimir Reporte"
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
        'ppCargar
        '
        Me.ppCargar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ppCargar.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ppCargar.Appearance.Options.UseBackColor = True
        Me.ppCargar.BarAnimationElementThickness = 2
        Me.ppCargar.Caption = "Por Favor Espere"
        Me.ppCargar.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ppCargar.Description = "Cargando"
        Me.ppCargar.Location = New System.Drawing.Point(425, 230)
        Me.ppCargar.Name = "ppCargar"
        Me.ppCargar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ppCargar.Size = New System.Drawing.Size(238, 70)
        Me.ppCargar.TabIndex = 3
        Me.ppCargar.Text = "ProgressPanel1"
        Me.ppCargar.Visible = False
        '
        'bwCargar
        '
        Me.bwCargar.WorkerReportsProgress = True
        Me.bwCargar.WorkerSupportsCancellation = True
        '
        'colDetalle
        '
        Me.colDetalle.Caption = "DETALLE"
        Me.colDetalle.FieldName = "DETALLE"
        Me.colDetalle.Name = "colDetalle"
        '
        'frmConsultar
        '
        Me.Appearance.Image = CType(resources.GetObject("frmConsultar.Appearance.Image"), System.Drawing.Image)
        Me.Appearance.Options.UseImage = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 465)
        Me.Controls.Add(Me.ppCargar)
        Me.Controls.Add(Me.GCConsultar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Ordenes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsGrid.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents colORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INGRESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEXO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTUDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ppCargar As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents bwCargar As System.ComponentModel.BackgroundWorker
    Friend WithEvents colSede As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsGrid As ContextMenuStrip
    Friend WithEvents tsmActualizarVista As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmVistaPrevia As ToolStripMenuItem
    Friend WithEvents tsmImprimir As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmExportarExcel As ToolStripMenuItem
    Friend WithEvents tsmExportarPDF As ToolStripMenuItem
    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents FiltratPorAñoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsm2020 As ToolStripMenuItem
    Friend WithEvents tsm2019 As ToolStripMenuItem
    Friend WithEvents tsm2018 As ToolStripMenuItem
    Friend WithEvents tsm2017 As ToolStripMenuItem
    Friend WithEvents colDetalle As DevExpress.XtraGrid.Columns.GridColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarPOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarPOS))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule5 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue5 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule6 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue6 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule7 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue7 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule8 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue8 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule9 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue9 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmActualizarVista = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmVistaPrevia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmExportarExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExportarPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.xtcOrdenesOptometria = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpOrdenes = New DevExpress.XtraTab.XtraTabPage()
        Me.xtpCumpleanos = New DevExpress.XtraTab.XtraTabPage()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.xtpFuturosControles = New DevExpress.XtraTab.XtraTabPage()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INGRESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEXO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFONO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsecutivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCorreoElectronico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOMENTARIOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEspecialista = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCumpleanosMes = New DevExpress.XtraGrid.GridControl()
        Me.gvCumpleanosMes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDENTIFICACIONCM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRECM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEXOCM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHANACIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADOCIVIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIRECCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFONOCM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcControles = New DevExpress.XtraGrid.GridControl()
        Me.gvControles = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmsGrid.SuspendLayout()
        CType(Me.xtcOrdenesOptometria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcOrdenesOptometria.SuspendLayout()
        Me.xtpOrdenes.SuspendLayout()
        Me.xtpCumpleanos.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpFuturosControles.SuspendLayout()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCumpleanosMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCumpleanosMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcControles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvControles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmsGrid
        '
        Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmActualizarVista, Me.ToolStripSeparator1, Me.tsmVistaPrevia, Me.tsmImprimir, Me.ToolStripSeparator2, Me.tsmExportarExcel, Me.tsmExportarPDF})
        Me.cmsGrid.Name = "cmsGrid"
        Me.cmsGrid.Size = New System.Drawing.Size(197, 126)
        '
        'tsmActualizarVista
        '
        Me.tsmActualizarVista.Image = CType(resources.GetObject("tsmActualizarVista.Image"), System.Drawing.Image)
        Me.tsmActualizarVista.Name = "tsmActualizarVista"
        Me.tsmActualizarVista.Size = New System.Drawing.Size(196, 22)
        Me.tsmActualizarVista.Text = "Actualizar Listado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(193, 6)
        '
        'tsmVistaPrevia
        '
        Me.tsmVistaPrevia.Image = CType(resources.GetObject("tsmVistaPrevia.Image"), System.Drawing.Image)
        Me.tsmVistaPrevia.Name = "tsmVistaPrevia"
        Me.tsmVistaPrevia.Size = New System.Drawing.Size(196, 22)
        Me.tsmVistaPrevia.Text = "Vista Previa Reporte"
        '
        'tsmImprimir
        '
        Me.tsmImprimir.Image = CType(resources.GetObject("tsmImprimir.Image"), System.Drawing.Image)
        Me.tsmImprimir.Name = "tsmImprimir"
        Me.tsmImprimir.Size = New System.Drawing.Size(196, 22)
        Me.tsmImprimir.Text = "Imprimir Reporte"
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
        'xtcOrdenesOptometria
        '
        Me.xtcOrdenesOptometria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcOrdenesOptometria.Location = New System.Drawing.Point(0, 0)
        Me.xtcOrdenesOptometria.Name = "xtcOrdenesOptometria"
        Me.xtcOrdenesOptometria.SelectedTabPage = Me.xtpOrdenes
        Me.xtcOrdenesOptometria.Size = New System.Drawing.Size(1228, 491)
        Me.xtcOrdenesOptometria.TabIndex = 83
        Me.xtcOrdenesOptometria.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpOrdenes, Me.xtpCumpleanos, Me.xtpFuturosControles})
        '
        'xtpOrdenes
        '
        Me.xtpOrdenes.Controls.Add(Me.GCConsultar)
        Me.xtpOrdenes.Name = "xtpOrdenes"
        Me.xtpOrdenes.Size = New System.Drawing.Size(1222, 463)
        Me.xtpOrdenes.Text = "Ordenes"
        '
        'xtpCumpleanos
        '
        Me.xtpCumpleanos.Controls.Add(Me.gcCumpleanosMes)
        Me.xtpCumpleanos.Name = "xtpCumpleanos"
        Me.xtpCumpleanos.Size = New System.Drawing.Size(1222, 463)
        Me.xtpCumpleanos.Text = "Cumpleaños del mes"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'xtpFuturosControles
        '
        Me.xtpFuturosControles.Controls.Add(Me.gcControles)
        Me.xtpFuturosControles.Name = "xtpFuturosControles"
        Me.xtpFuturosControles.Size = New System.Drawing.Size(1222, 463)
        Me.xtpFuturosControles.Text = "Controles"
        '
        'GCConsultar
        '
        Me.GCConsultar.ContextMenuStrip = Me.cmsGrid
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(1222, 463)
        Me.GCConsultar.TabIndex = 4
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colORDEN, Me.colFECHA_INGRESO, Me.colIDENTIFICACION, Me.colNOMBRE, Me.colSEXO, Me.colEDAD, Me.colTELEFONO, Me.colCONTRATO, Me.colENTIDAD, Me.colESTUDIO, Me.colESTADO, Me.colConsecutivo, Me.colCorreoElectronico, Me.colCOMENTARIOS, Me.colEspecialista})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colESTADO
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Expression = "PENDIENTE"
        FormatConditionRuleValue1.Value1 = "PENDIENTE"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.colESTADO
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Expression = "CANCELADO"
        FormatConditionRuleValue2.Value1 = "CANCELADO"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.ApplyToRow = True
        GridFormatRule3.Column = Me.colESTUDIO
        GridFormatRule3.Name = "Format2"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue3.Expression = "ANEXOS"
        FormatConditionRuleValue3.Value1 = "ANEXOS"
        FormatConditionRuleValue3.Value2 = ""
        GridFormatRule3.Rule = FormatConditionRuleValue3
        Me.GVConsultar.FormatRules.Add(GridFormatRule1)
        Me.GVConsultar.FormatRules.Add(GridFormatRule2)
        Me.GVConsultar.FormatRules.Add(GridFormatRule3)
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
        Me.colORDEN.Width = 62
        '
        'colFECHA_INGRESO
        '
        Me.colFECHA_INGRESO.Caption = "FECHA"
        Me.colFECHA_INGRESO.FieldName = "FECHA_INGRESO"
        Me.colFECHA_INGRESO.Name = "colFECHA_INGRESO"
        Me.colFECHA_INGRESO.Visible = True
        Me.colFECHA_INGRESO.VisibleIndex = 1
        Me.colFECHA_INGRESO.Width = 66
        '
        'colIDENTIFICACION
        '
        Me.colIDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACION.Name = "colIDENTIFICACION"
        Me.colIDENTIFICACION.Visible = True
        Me.colIDENTIFICACION.VisibleIndex = 2
        Me.colIDENTIFICACION.Width = 98
        '
        'colNOMBRE
        '
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 3
        Me.colNOMBRE.Width = 217
        '
        'colSEXO
        '
        Me.colSEXO.FieldName = "SEXO"
        Me.colSEXO.Name = "colSEXO"
        Me.colSEXO.Visible = True
        Me.colSEXO.VisibleIndex = 4
        Me.colSEXO.Width = 34
        '
        'colEDAD
        '
        Me.colEDAD.FieldName = "EDAD"
        Me.colEDAD.Name = "colEDAD"
        Me.colEDAD.Visible = True
        Me.colEDAD.VisibleIndex = 5
        Me.colEDAD.Width = 37
        '
        'colTELEFONO
        '
        Me.colTELEFONO.FieldName = "TELEFONO"
        Me.colTELEFONO.Name = "colTELEFONO"
        Me.colTELEFONO.Visible = True
        Me.colTELEFONO.VisibleIndex = 6
        '
        'colCONTRATO
        '
        Me.colCONTRATO.FieldName = "CONTRATO"
        Me.colCONTRATO.Name = "colCONTRATO"
        Me.colCONTRATO.Visible = True
        Me.colCONTRATO.VisibleIndex = 9
        Me.colCONTRATO.Width = 185
        '
        'colENTIDAD
        '
        Me.colENTIDAD.FieldName = "ENTIDAD"
        Me.colENTIDAD.Name = "colENTIDAD"
        Me.colENTIDAD.Width = 177
        '
        'colESTUDIO
        '
        Me.colESTUDIO.FieldName = "ESTUDIO"
        Me.colESTUDIO.Name = "colESTUDIO"
        Me.colESTUDIO.Visible = True
        Me.colESTUDIO.VisibleIndex = 8
        Me.colESTUDIO.Width = 198
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 11
        Me.colESTADO.Width = 87
        '
        'colConsecutivo
        '
        Me.colConsecutivo.Caption = "CONSECUTIVO"
        Me.colConsecutivo.FieldName = "CONSECUTIVO"
        Me.colConsecutivo.Name = "colConsecutivo"
        '
        'colCorreoElectronico
        '
        Me.colCorreoElectronico.Caption = "CORREO"
        Me.colCorreoElectronico.FieldName = "CORREO_ELECTRONICO"
        Me.colCorreoElectronico.Name = "colCorreoElectronico"
        Me.colCorreoElectronico.Visible = True
        Me.colCorreoElectronico.VisibleIndex = 7
        Me.colCorreoElectronico.Width = 151
        '
        'colCOMENTARIOS
        '
        Me.colCOMENTARIOS.Caption = "COMENTARIOS"
        Me.colCOMENTARIOS.FieldName = "COMENTARIOS"
        Me.colCOMENTARIOS.Name = "colCOMENTARIOS"
        Me.colCOMENTARIOS.Width = 145
        '
        'colEspecialista
        '
        Me.colEspecialista.Caption = "ATENDIDO POR:"
        Me.colEspecialista.FieldName = "ESPECIALISTA"
        Me.colEspecialista.Name = "colEspecialista"
        Me.colEspecialista.Visible = True
        Me.colEspecialista.VisibleIndex = 10
        Me.colEspecialista.Width = 161
        '
        'gcCumpleanosMes
        '
        Me.gcCumpleanosMes.ContextMenuStrip = Me.cmsGrid
        Me.gcCumpleanosMes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCumpleanosMes.Location = New System.Drawing.Point(0, 0)
        Me.gcCumpleanosMes.MainView = Me.gvCumpleanosMes
        Me.gcCumpleanosMes.Name = "gcCumpleanosMes"
        Me.gcCumpleanosMes.Size = New System.Drawing.Size(1222, 463)
        Me.gcCumpleanosMes.TabIndex = 5
        Me.gcCumpleanosMes.UseEmbeddedNavigator = True
        Me.gcCumpleanosMes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCumpleanosMes})
        '
        'gvCumpleanosMes
        '
        Me.gvCumpleanosMes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDENTIFICACIONCM, Me.colNOMBRECM, Me.colSEXOCM, Me.colFECHANACIMIENTO, Me.colESTADOCIVIL, Me.colDIRECCION, Me.colTELEFONOCM, Me.colMAIL})
        GridFormatRule4.ApplyToRow = True
        GridFormatRule4.Name = "Format0"
        FormatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue4.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue4.Expression = "PENDIENTE"
        FormatConditionRuleValue4.Value1 = "PENDIENTE"
        GridFormatRule4.Rule = FormatConditionRuleValue4
        GridFormatRule5.ApplyToRow = True
        GridFormatRule5.Name = "Format1"
        FormatConditionRuleValue5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue5.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue5.Expression = "CANCELADO"
        FormatConditionRuleValue5.Value1 = "CANCELADO"
        GridFormatRule5.Rule = FormatConditionRuleValue5
        GridFormatRule6.ApplyToRow = True
        GridFormatRule6.Name = "Format2"
        FormatConditionRuleValue6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue6.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue6.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue6.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue6.Expression = "ANEXOS"
        FormatConditionRuleValue6.Value1 = "ANEXOS"
        FormatConditionRuleValue6.Value2 = ""
        GridFormatRule6.Rule = FormatConditionRuleValue6
        Me.gvCumpleanosMes.FormatRules.Add(GridFormatRule4)
        Me.gvCumpleanosMes.FormatRules.Add(GridFormatRule5)
        Me.gvCumpleanosMes.FormatRules.Add(GridFormatRule6)
        Me.gvCumpleanosMes.GridControl = Me.gcCumpleanosMes
        Me.gvCumpleanosMes.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvCumpleanosMes.Name = "gvCumpleanosMes"
        Me.gvCumpleanosMes.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvCumpleanosMes.OptionsBehavior.ReadOnly = True
        Me.gvCumpleanosMes.OptionsFind.AlwaysVisible = True
        Me.gvCumpleanosMes.OptionsPrint.AutoWidth = False
        Me.gvCumpleanosMes.OptionsView.ColumnAutoWidth = False
        Me.gvCumpleanosMes.OptionsView.EnableAppearanceOddRow = True
        Me.gvCumpleanosMes.OptionsView.ShowFooter = True
        Me.gvCumpleanosMes.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'colIDENTIFICACIONCM
        '
        Me.colIDENTIFICACIONCM.Caption = "IDENTIFICACION"
        Me.colIDENTIFICACIONCM.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACIONCM.Name = "colIDENTIFICACIONCM"
        Me.colIDENTIFICACIONCM.Visible = True
        Me.colIDENTIFICACIONCM.VisibleIndex = 0
        '
        'colNOMBRECM
        '
        Me.colNOMBRECM.Caption = "NOMBRE"
        Me.colNOMBRECM.FieldName = "NOMBRE"
        Me.colNOMBRECM.Name = "colNOMBRECM"
        Me.colNOMBRECM.Visible = True
        Me.colNOMBRECM.VisibleIndex = 1
        Me.colNOMBRECM.Width = 267
        '
        'colSEXOCM
        '
        Me.colSEXOCM.Caption = "SEXO"
        Me.colSEXOCM.FieldName = "SEXO"
        Me.colSEXOCM.Name = "colSEXOCM"
        Me.colSEXOCM.Visible = True
        Me.colSEXOCM.VisibleIndex = 2
        Me.colSEXOCM.Width = 51
        '
        'colFECHANACIMIENTO
        '
        Me.colFECHANACIMIENTO.Caption = "FECHA NACIMIENTO"
        Me.colFECHANACIMIENTO.FieldName = "FECHA_NACIMIENTO"
        Me.colFECHANACIMIENTO.Name = "colFECHANACIMIENTO"
        Me.colFECHANACIMIENTO.Visible = True
        Me.colFECHANACIMIENTO.VisibleIndex = 3
        Me.colFECHANACIMIENTO.Width = 86
        '
        'colESTADOCIVIL
        '
        Me.colESTADOCIVIL.Caption = "ESTADO CIVIL"
        Me.colESTADOCIVIL.FieldName = "ESTADO_CIVIL"
        Me.colESTADOCIVIL.Name = "colESTADOCIVIL"
        Me.colESTADOCIVIL.Visible = True
        Me.colESTADOCIVIL.VisibleIndex = 4
        Me.colESTADOCIVIL.Width = 101
        '
        'colDIRECCION
        '
        Me.colDIRECCION.Caption = "DIRECCION"
        Me.colDIRECCION.FieldName = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        Me.colDIRECCION.Visible = True
        Me.colDIRECCION.VisibleIndex = 5
        Me.colDIRECCION.Width = 192
        '
        'colTELEFONOCM
        '
        Me.colTELEFONOCM.Caption = "TELEFONO"
        Me.colTELEFONOCM.FieldName = "TELEFONO"
        Me.colTELEFONOCM.Name = "colTELEFONOCM"
        Me.colTELEFONOCM.Visible = True
        Me.colTELEFONOCM.VisibleIndex = 6
        Me.colTELEFONOCM.Width = 116
        '
        'colMAIL
        '
        Me.colMAIL.Caption = "EMAIL"
        Me.colMAIL.FieldName = "MAIL"
        Me.colMAIL.Name = "colMAIL"
        Me.colMAIL.Visible = True
        Me.colMAIL.VisibleIndex = 7
        Me.colMAIL.Width = 185
        '
        'gcControles
        '
        Me.gcControles.ContextMenuStrip = Me.cmsGrid
        Me.gcControles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcControles.Location = New System.Drawing.Point(0, 0)
        Me.gcControles.MainView = Me.gvControles
        Me.gcControles.Name = "gcControles"
        Me.gcControles.Size = New System.Drawing.Size(1222, 463)
        Me.gcControles.TabIndex = 5
        Me.gcControles.UseEmbeddedNavigator = True
        Me.gcControles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvControles})
        '
        'gvControles
        '
        Me.gvControles.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15})
        GridFormatRule7.ApplyToRow = True
        GridFormatRule7.Column = Me.GridColumn11
        GridFormatRule7.Name = "Format0"
        FormatConditionRuleValue7.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue7.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue7.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue7.Expression = "PENDIENTE"
        FormatConditionRuleValue7.Value1 = "PENDIENTE"
        GridFormatRule7.Rule = FormatConditionRuleValue7
        GridFormatRule8.ApplyToRow = True
        GridFormatRule8.Column = Me.GridColumn11
        GridFormatRule8.Name = "Format1"
        FormatConditionRuleValue8.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue8.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue8.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue8.Expression = "CANCELADO"
        FormatConditionRuleValue8.Value1 = "CANCELADO"
        GridFormatRule8.Rule = FormatConditionRuleValue8
        GridFormatRule9.ApplyToRow = True
        GridFormatRule9.Column = Me.GridColumn10
        GridFormatRule9.Name = "Format2"
        FormatConditionRuleValue9.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue9.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue9.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue9.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue9.Expression = "ANEXOS"
        FormatConditionRuleValue9.Value1 = "ANEXOS"
        FormatConditionRuleValue9.Value2 = ""
        GridFormatRule9.Rule = FormatConditionRuleValue9
        Me.gvControles.FormatRules.Add(GridFormatRule7)
        Me.gvControles.FormatRules.Add(GridFormatRule8)
        Me.gvControles.FormatRules.Add(GridFormatRule9)
        Me.gvControles.GridControl = Me.gcControles
        Me.gvControles.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvControles.Name = "gvControles"
        Me.gvControles.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvControles.OptionsBehavior.ReadOnly = True
        Me.gvControles.OptionsFind.AlwaysVisible = True
        Me.gvControles.OptionsPrint.AutoWidth = False
        Me.gvControles.OptionsView.ColumnAutoWidth = False
        Me.gvControles.OptionsView.EnableAppearanceOddRow = True
        Me.gvControles.OptionsView.ShowFooter = True
        Me.gvControles.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.gvControles.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ORDEN"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 62
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "FECHA"
        Me.GridColumn2.FieldName = "FECHA_INGRESO"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 66
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "IDENTIFICACION"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 98
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "NOMBRE"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 217
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "SEXO"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 34
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "EDAD"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 37
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "TELEFONO"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "CONTRATO"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 9
        Me.GridColumn8.Width = 185
        '
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "ENTIDAD"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Width = 177
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "ESTUDIO"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        Me.GridColumn10.Width = 198
        '
        'GridColumn11
        '
        Me.GridColumn11.FieldName = "ESTADO"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 11
        Me.GridColumn11.Width = 87
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "CONSECUTIVO"
        Me.GridColumn12.FieldName = "CONSECUTIVO"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "CORREO"
        Me.GridColumn13.FieldName = "CORREO_ELECTRONICO"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 7
        Me.GridColumn13.Width = 151
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "COMENTARIOS"
        Me.GridColumn14.FieldName = "COMENTARIOS"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Width = 145
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "ATENDIDO POR:"
        Me.GridColumn15.FieldName = "ESPECIALISTA"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 10
        Me.GridColumn15.Width = 161
        '
        'frmConsultarPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 491)
        Me.Controls.Add(Me.xtcOrdenesOptometria)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultarPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Atenciones"
        Me.cmsGrid.ResumeLayout(False)
        CType(Me.xtcOrdenesOptometria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcOrdenesOptometria.ResumeLayout(False)
        Me.xtpOrdenes.ResumeLayout(False)
        Me.xtpCumpleanos.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpFuturosControles.ResumeLayout(False)
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCumpleanosMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCumpleanosMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcControles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvControles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents cmsGrid As ContextMenuStrip
    Friend WithEvents tsmActualizarVista As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmVistaPrevia As ToolStripMenuItem
    Friend WithEvents tsmImprimir As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmExportarExcel As ToolStripMenuItem
    Friend WithEvents tsmExportarPDF As ToolStripMenuItem
    Friend WithEvents xtcOrdenesOptometria As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpOrdenes As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INGRESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEXO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTUDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsecutivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCorreoElectronico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOMENTARIOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEspecialista As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpCumpleanos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcCumpleanosMes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCumpleanosMes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents xtpFuturosControles As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDENTIFICACIONCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRECM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEXOCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHANACIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADOCIVIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIRECCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONOCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcControles As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvControles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
End Class

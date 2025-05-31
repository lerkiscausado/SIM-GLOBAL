<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultar
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
        Me.colCONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsecutivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEMPRESA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip()
        Me.tsmActualizarListado = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmVistaPrevia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.colESTADO.VisibleIndex = 10
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colORDEN, Me.colFECHA_INGRESO, Me.colIDENTIFICACION, Me.colNOMBRE, Me.colSEXO, Me.colEDAD, Me.colTELEFONOS, Me.colCONTRATO, Me.colENTIDAD, Me.colConsecutivo, Me.colESTUDIO, Me.colEMPRESA, Me.colESTADO})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colESTADO
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.colORDEN.Caption = "ORDEN"
        Me.colORDEN.FieldName = "ORDEN"
        Me.colORDEN.Name = "colORDEN"
        Me.colORDEN.Width = 55
        '
        'colFECHA_INGRESO
        '
        Me.colFECHA_INGRESO.Caption = "INGRESO"
        Me.colFECHA_INGRESO.FieldName = "FECHA_INGRESO"
        Me.colFECHA_INGRESO.Name = "colFECHA_INGRESO"
        Me.colFECHA_INGRESO.Visible = True
        Me.colFECHA_INGRESO.VisibleIndex = 1
        Me.colFECHA_INGRESO.Width = 81
        '
        'colIDENTIFICACION
        '
        Me.colIDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACION.Name = "colIDENTIFICACION"
        Me.colIDENTIFICACION.Visible = True
        Me.colIDENTIFICACION.VisibleIndex = 2
        Me.colIDENTIFICACION.Width = 94
        '
        'colNOMBRE
        '
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 3
        Me.colNOMBRE.Width = 243
        '
        'colSEXO
        '
        Me.colSEXO.FieldName = "SEXO"
        Me.colSEXO.Name = "colSEXO"
        Me.colSEXO.Visible = True
        Me.colSEXO.VisibleIndex = 4
        Me.colSEXO.Width = 41
        '
        'colEDAD
        '
        Me.colEDAD.FieldName = "EDAD"
        Me.colEDAD.Name = "colEDAD"
        Me.colEDAD.Visible = True
        Me.colEDAD.VisibleIndex = 5
        Me.colEDAD.Width = 42
        '
        'colTELEFONOS
        '
        Me.colTELEFONOS.FieldName = "TELEFONOS"
        Me.colTELEFONOS.Name = "colTELEFONOS"
        Me.colTELEFONOS.Visible = True
        Me.colTELEFONOS.VisibleIndex = 6
        '
        'colCONTRATO
        '
        Me.colCONTRATO.FieldName = "CONTRATO"
        Me.colCONTRATO.Name = "colCONTRATO"
        Me.colCONTRATO.Visible = True
        Me.colCONTRATO.VisibleIndex = 8
        Me.colCONTRATO.Width = 186
        '
        'colENTIDAD
        '
        Me.colENTIDAD.FieldName = "ENTIDAD"
        Me.colENTIDAD.Name = "colENTIDAD"
        Me.colENTIDAD.Visible = True
        Me.colENTIDAD.VisibleIndex = 9
        Me.colENTIDAD.Width = 155
        '
        'colConsecutivo
        '
        Me.colConsecutivo.Caption = "CONSECUTIVO"
        Me.colConsecutivo.FieldName = "CONSECUTIVO"
        Me.colConsecutivo.Name = "colConsecutivo"
        Me.colConsecutivo.Visible = True
        Me.colConsecutivo.VisibleIndex = 0
        '
        'colESTUDIO
        '
        Me.colESTUDIO.FieldName = "ESTUDIO"
        Me.colESTUDIO.Name = "colESTUDIO"
        Me.colESTUDIO.Visible = True
        Me.colESTUDIO.VisibleIndex = 7
        Me.colESTUDIO.Width = 156
        '
        'colEMPRESA
        '
        Me.colEMPRESA.FieldName = "EMPRESA"
        Me.colEMPRESA.Name = "colEMPRESA"
        Me.colEMPRESA.Width = 154
        '
        'GCConsultar
        '
        Me.GCConsultar.ContextMenuStrip = Me.cmsGrid
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(992, 558)
        Me.GCConsultar.TabIndex = 1
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'cmsGrid
        '
        Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmActualizarListado, Me.ToolStripSeparator1, Me.tsmVistaPrevia, Me.tsmImprimir, Me.ToolStripSeparator2, Me.tsmExel, Me.tsmPDF})
        Me.cmsGrid.Name = "cmsGrid"
        Me.cmsGrid.Size = New System.Drawing.Size(199, 126)
        '
        'tsmActualizarListado
        '
        Me.tsmActualizarListado.Image = CType(resources.GetObject("tsmActualizarListado.Image"), System.Drawing.Image)
        Me.tsmActualizarListado.Name = "tsmActualizarListado"
        Me.tsmActualizarListado.Size = New System.Drawing.Size(198, 22)
        Me.tsmActualizarListado.Text = "Actualizar Listado"
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
        'tsmExel
        '
        Me.tsmExel.Image = CType(resources.GetObject("tsmExel.Image"), System.Drawing.Image)
        Me.tsmExel.Name = "tsmExel"
        Me.tsmExel.Size = New System.Drawing.Size(198, 22)
        Me.tsmExel.Text = "Exportar Listado a Excel"
        '
        'tsmPDF
        '
        Me.tsmPDF.Image = CType(resources.GetObject("tsmPDF.Image"), System.Drawing.Image)
        Me.tsmPDF.Name = "tsmPDF"
        Me.tsmPDF.Size = New System.Drawing.Size(198, 22)
        Me.tsmPDF.Text = "Exportar Listado a PDF"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'frmConsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 558)
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
    Friend WithEvents colEMPRESA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsecutivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsGrid As ContextMenuStrip
    Friend WithEvents tsmVistaPrevia As ToolStripMenuItem
    Friend WithEvents tsmImprimir As ToolStripMenuItem
    Friend WithEvents tsmExel As ToolStripMenuItem
    Friend WithEvents tsmPDF As ToolStripMenuItem
    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents tsmActualizarListado As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class

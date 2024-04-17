<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultarEndoscopia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarEndoscopia))
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule5 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue5 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule6 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue6 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmActualizarVista = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltrarPorAñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmActual = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm2023 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm2022 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm2021 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INGRESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEXO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFONO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESPECIALISTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEMPRESA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCups = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOMENTARIOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsGrid.SuspendLayout()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 11
        Me.colESTADO.Width = 87
        '
        'colESTUDIO
        '
        Me.colESTUDIO.FieldName = "ESTUDIO"
        Me.colESTUDIO.Name = "colESTUDIO"
        Me.colESTUDIO.Width = 198
        '
        'GCConsultar
        '
        Me.GCConsultar.ContextMenuStrip = Me.cmsGrid
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(1119, 456)
        Me.GCConsultar.TabIndex = 1
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'cmsGrid
        '
        Me.cmsGrid.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmActualizarVista, Me.FiltrarPorAñoToolStripMenuItem, Me.ToolStripSeparator1, Me.tsmVistaPrevia, Me.tsmImprimir, Me.ToolStripSeparator2, Me.tsmExportarExcel, Me.tsmExportarPDF})
        Me.cmsGrid.Name = "cmsGrid"
        Me.cmsGrid.Size = New System.Drawing.Size(224, 160)
        '
        'tsmActualizarVista
        '
        Me.tsmActualizarVista.Image = CType(resources.GetObject("tsmActualizarVista.Image"), System.Drawing.Image)
        Me.tsmActualizarVista.Name = "tsmActualizarVista"
        Me.tsmActualizarVista.Size = New System.Drawing.Size(223, 24)
        Me.tsmActualizarVista.Text = "Actualizar Listado"
        '
        'FiltrarPorAñoToolStripMenuItem
        '
        Me.FiltrarPorAñoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmActual, Me.tsm2023, Me.tsm2022, Me.tsm2021, Me.tsm2020, Me.tsm2019, Me.tsm2018, Me.tsm2017})
        Me.FiltrarPorAñoToolStripMenuItem.Image = CType(resources.GetObject("FiltrarPorAñoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FiltrarPorAñoToolStripMenuItem.Name = "FiltrarPorAñoToolStripMenuItem"
        Me.FiltrarPorAñoToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.FiltrarPorAñoToolStripMenuItem.Text = "Filtrar por Año"
        '
        'tsmActual
        '
        Me.tsmActual.Name = "tsmActual"
        Me.tsmActual.Size = New System.Drawing.Size(198, 24)
        Me.tsmActual.Text = "Año Actual"
        '
        'tsm2023
        '
        Me.tsm2023.Name = "tsm2023"
        Me.tsm2023.Size = New System.Drawing.Size(198, 24)
        Me.tsm2023.Text = "2023"
        '
        'tsm2022
        '
        Me.tsm2022.Name = "tsm2022"
        Me.tsm2022.Size = New System.Drawing.Size(198, 24)
        Me.tsm2022.Text = "2022"
        '
        'tsm2021
        '
        Me.tsm2021.Name = "tsm2021"
        Me.tsm2021.Size = New System.Drawing.Size(198, 24)
        Me.tsm2021.Text = "2021"
        '
        'tsm2020
        '
        Me.tsm2020.Name = "tsm2020"
        Me.tsm2020.Size = New System.Drawing.Size(198, 24)
        Me.tsm2020.Text = "2020"
        '
        'tsm2019
        '
        Me.tsm2019.Name = "tsm2019"
        Me.tsm2019.Size = New System.Drawing.Size(198, 24)
        Me.tsm2019.Text = "2019"
        '
        'tsm2018
        '
        Me.tsm2018.Name = "tsm2018"
        Me.tsm2018.Size = New System.Drawing.Size(198, 24)
        Me.tsm2018.Text = "2018"
        '
        'tsm2017
        '
        Me.tsm2017.Name = "tsm2017"
        Me.tsm2017.Size = New System.Drawing.Size(198, 24)
        Me.tsm2017.Text = "2017"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(220, 6)
        '
        'tsmVistaPrevia
        '
        Me.tsmVistaPrevia.Image = CType(resources.GetObject("tsmVistaPrevia.Image"), System.Drawing.Image)
        Me.tsmVistaPrevia.Name = "tsmVistaPrevia"
        Me.tsmVistaPrevia.Size = New System.Drawing.Size(223, 24)
        Me.tsmVistaPrevia.Text = "Vista Previa Reporte"
        '
        'tsmImprimir
        '
        Me.tsmImprimir.Image = CType(resources.GetObject("tsmImprimir.Image"), System.Drawing.Image)
        Me.tsmImprimir.Name = "tsmImprimir"
        Me.tsmImprimir.Size = New System.Drawing.Size(223, 24)
        Me.tsmImprimir.Text = "Imprimir Reporte"
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
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colORDEN, Me.colFECHA_INGRESO, Me.colIDENTIFICACION, Me.colNOMBRE, Me.colSEXO, Me.colEDAD, Me.colTELEFONO, Me.colESPECIALISTA, Me.colCONTRATO, Me.colENTIDAD, Me.colESTUDIO, Me.colEMPRESA, Me.colESTADO, Me.colCups, Me.colCOMENTARIOS})
        GridFormatRule4.ApplyToRow = True
        GridFormatRule4.Column = Me.colESTADO
        GridFormatRule4.Name = "Format0"
        FormatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue4.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue4.Expression = "PENDIENTE"
        FormatConditionRuleValue4.Value1 = "PENDIENTE"
        GridFormatRule4.Rule = FormatConditionRuleValue4
        GridFormatRule5.ApplyToRow = True
        GridFormatRule5.Column = Me.colESTADO
        GridFormatRule5.Name = "Format1"
        FormatConditionRuleValue5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue5.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue5.Expression = "CANCELADO"
        FormatConditionRuleValue5.Value1 = "CANCELADO"
        GridFormatRule5.Rule = FormatConditionRuleValue5
        GridFormatRule6.ApplyToRow = True
        GridFormatRule6.Column = Me.colESTUDIO
        GridFormatRule6.Name = "Format2"
        FormatConditionRuleValue6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue6.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue6.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue6.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue6.Expression = "ANEXOS"
        FormatConditionRuleValue6.Value1 = "ANEXOS"
        FormatConditionRuleValue6.Value2 = ""
        GridFormatRule6.Rule = FormatConditionRuleValue6
        Me.GVConsultar.FormatRules.Add(GridFormatRule4)
        Me.GVConsultar.FormatRules.Add(GridFormatRule5)
        Me.GVConsultar.FormatRules.Add(GridFormatRule6)
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsBehavior.ReadOnly = True
        Me.GVConsultar.OptionsFind.AlwaysVisible = True
        Me.GVConsultar.OptionsPrint.AutoWidth = False
        Me.GVConsultar.OptionsView.ColumnAutoWidth = False
        Me.GVConsultar.OptionsView.ShowFooter = True
        Me.GVConsultar.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colORDEN
        '
        Me.colORDEN.FieldName = "ORDEN"
        Me.colORDEN.Name = "colORDEN"
        Me.colORDEN.Visible = True
        Me.colORDEN.VisibleIndex = 0
        Me.colORDEN.Width = 49
        '
        'colFECHA_INGRESO
        '
        Me.colFECHA_INGRESO.Caption = "FECHA INGRESO"
        Me.colFECHA_INGRESO.FieldName = "FECHA_INGRESO"
        Me.colFECHA_INGRESO.Name = "colFECHA_INGRESO"
        Me.colFECHA_INGRESO.Visible = True
        Me.colFECHA_INGRESO.VisibleIndex = 1
        Me.colFECHA_INGRESO.Width = 97
        '
        'colIDENTIFICACION
        '
        Me.colIDENTIFICACION.FieldName = "IDENTIFICACION"
        Me.colIDENTIFICACION.Name = "colIDENTIFICACION"
        Me.colIDENTIFICACION.Visible = True
        Me.colIDENTIFICACION.VisibleIndex = 2
        Me.colIDENTIFICACION.Width = 102
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
        'colESPECIALISTA
        '
        Me.colESPECIALISTA.FieldName = "ESPECIALISTA"
        Me.colESPECIALISTA.Name = "colESPECIALISTA"
        Me.colESPECIALISTA.Visible = True
        Me.colESPECIALISTA.VisibleIndex = 8
        Me.colESPECIALISTA.Width = 195
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
        Me.colENTIDAD.Visible = True
        Me.colENTIDAD.VisibleIndex = 10
        Me.colENTIDAD.Width = 177
        '
        'colEMPRESA
        '
        Me.colEMPRESA.FieldName = "EMPRESA"
        Me.colEMPRESA.Name = "colEMPRESA"
        Me.colEMPRESA.Width = 202
        '
        'colCups
        '
        Me.colCups.Caption = "ESTUDIO"
        Me.colCups.FieldName = "CUPS"
        Me.colCups.Name = "colCups"
        Me.colCups.Visible = True
        Me.colCups.VisibleIndex = 7
        Me.colCups.Width = 429
        '
        'colCOMENTARIOS
        '
        Me.colCOMENTARIOS.Caption = "COMENTARIOS"
        Me.colCOMENTARIOS.FieldName = "COMENTARIOS"
        Me.colCOMENTARIOS.Name = "colCOMENTARIOS"
        Me.colCOMENTARIOS.Width = 144
        '
        'frmConsultarEndoscopia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 456)
        Me.Controls.Add(Me.GCConsultar)
        Me.IconOptions.Icon = CType(resources.GetObject("frmConsultarEndoscopia.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultarEndoscopia"
        Me.Text = "Consultar Estudios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsGrid.ResumeLayout(False)
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INGRESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEXO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESPECIALISTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTUDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMPRESA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmsGrid As ContextMenuStrip
    Friend WithEvents tsmActualizarVista As ToolStripMenuItem
    Friend WithEvents tsmVistaPrevia As ToolStripMenuItem
    Friend WithEvents tsmImprimir As ToolStripMenuItem
    Friend WithEvents tsmExportarExcel As ToolStripMenuItem
    Friend WithEvents tsmExportarPDF As ToolStripMenuItem
    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents colCups As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FiltrarPorAñoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsm2020 As ToolStripMenuItem
    Friend WithEvents tsm2019 As ToolStripMenuItem
    Friend WithEvents tsm2018 As ToolStripMenuItem
    Friend WithEvents tsm2017 As ToolStripMenuItem
    Friend WithEvents tsmActual As ToolStripMenuItem
    Friend WithEvents colCOMENTARIOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsm2021 As ToolStripMenuItem
    Friend WithEvents tsm2022 As ToolStripMenuItem
    Friend WithEvents tsm2023 As ToolStripMenuItem
End Class

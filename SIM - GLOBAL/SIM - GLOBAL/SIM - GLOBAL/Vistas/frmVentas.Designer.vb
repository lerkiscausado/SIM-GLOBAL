<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.tsmExportarPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmVistaPrevia = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmActualizarVista = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmExportarExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.colFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPresentacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmsGrid.SuspendLayout()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsmExportarPDF
        '
        Me.tsmExportarPDF.Image = CType(resources.GetObject("tsmExportarPDF.Image"), System.Drawing.Image)
        Me.tsmExportarPDF.Name = "tsmExportarPDF"
        Me.tsmExportarPDF.Size = New System.Drawing.Size(198, 22)
        Me.tsmExportarPDF.Text = "Exportar Listado  a PDF"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'tsmImprimir
        '
        Me.tsmImprimir.Image = CType(resources.GetObject("tsmImprimir.Image"), System.Drawing.Image)
        Me.tsmImprimir.Name = "tsmImprimir"
        Me.tsmImprimir.Size = New System.Drawing.Size(198, 22)
        Me.tsmImprimir.Text = "Imprimir Reporte"
        '
        'tsmVistaPrevia
        '
        Me.tsmVistaPrevia.Image = CType(resources.GetObject("tsmVistaPrevia.Image"), System.Drawing.Image)
        Me.tsmVistaPrevia.Name = "tsmVistaPrevia"
        Me.tsmVistaPrevia.Size = New System.Drawing.Size(198, 22)
        Me.tsmVistaPrevia.Text = "Vista Previa Reporte"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'tsmActualizarVista
        '
        Me.tsmActualizarVista.Image = CType(resources.GetObject("tsmActualizarVista.Image"), System.Drawing.Image)
        Me.tsmActualizarVista.Name = "tsmActualizarVista"
        Me.tsmActualizarVista.Size = New System.Drawing.Size(198, 22)
        Me.tsmActualizarVista.Text = "Actualizar Listado"
        '
        'cmsGrid
        '
        Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmActualizarVista, Me.ToolStripSeparator1, Me.tsmVistaPrevia, Me.tsmImprimir, Me.ToolStripSeparator2, Me.tsmExportarExcel, Me.tsmExportarPDF})
        Me.cmsGrid.Name = "cmsGrid"
        Me.cmsGrid.Size = New System.Drawing.Size(199, 126)
        '
        'tsmExportarExcel
        '
        Me.tsmExportarExcel.Image = CType(resources.GetObject("tsmExportarExcel.Image"), System.Drawing.Image)
        Me.tsmExportarExcel.Name = "tsmExportarExcel"
        Me.tsmExportarExcel.Size = New System.Drawing.Size(198, 22)
        Me.tsmExportarExcel.Text = "Exportar Listado a Excel"
        '
        'GCConsultar
        '
        Me.GCConsultar.ContextMenuStrip = Me.cmsGrid
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(1172, 562)
        Me.GCConsultar.TabIndex = 4
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFactura, Me.colFecha, Me.colProducto, Me.colMarca, Me.colPresentacion, Me.colCantidad, Me.colValor, Me.colDescuento, Me.colNeto, Me.colSubtotal})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Expression = "PENDIENTE"
        FormatConditionRuleValue1.Value1 = "PENDIENTE"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Expression = "CANCELADO"
        FormatConditionRuleValue2.Value1 = "CANCELADO"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.ApplyToRow = True
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
        '
        'colFactura
        '
        Me.colFactura.Caption = "FACTURA"
        Me.colFactura.FieldName = "FACTURA"
        Me.colFactura.Name = "colFactura"
        Me.colFactura.Visible = True
        Me.colFactura.VisibleIndex = 0
        Me.colFactura.Width = 65
        '
        'colFecha
        '
        Me.colFecha.Caption = "FECHA"
        Me.colFecha.FieldName = "FECHA"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        '
        'colProducto
        '
        Me.colProducto.Caption = "PRODUCTO"
        Me.colProducto.FieldName = "PRODUCTO"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 2
        Me.colProducto.Width = 111
        '
        'colMarca
        '
        Me.colMarca.Caption = "MARCA"
        Me.colMarca.FieldName = "MARCA"
        Me.colMarca.Name = "colMarca"
        Me.colMarca.Visible = True
        Me.colMarca.VisibleIndex = 3
        Me.colMarca.Width = 116
        '
        'colPresentacion
        '
        Me.colPresentacion.Caption = "PRESENTACION"
        Me.colPresentacion.FieldName = "PRESENTACION"
        Me.colPresentacion.Name = "colPresentacion"
        Me.colPresentacion.Visible = True
        Me.colPresentacion.VisibleIndex = 4
        Me.colPresentacion.Width = 211
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "CANTIDAD"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "CANTIDAD"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CANTIDAD", "{0}")})
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 6
        Me.colCantidad.Width = 65
        '
        'colValor
        '
        Me.colValor.Caption = "VALOR UNI."
        Me.colValor.DisplayFormat.FormatString = "C0"
        Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValor.FieldName = "VALOR"
        Me.colValor.Name = "colValor"
        Me.colValor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALOR", "{0:C0}")})
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 5
        Me.colValor.Width = 99
        '
        'colDescuento
        '
        Me.colDescuento.Caption = "DESCUENTO"
        Me.colDescuento.DisplayFormat.FormatString = "C0"
        Me.colDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDescuento.FieldName = "DESCUENTO"
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DESCUENTO", "{0:C0}")})
        Me.colDescuento.Visible = True
        Me.colDescuento.VisibleIndex = 8
        Me.colDescuento.Width = 94
        '
        'colNeto
        '
        Me.colNeto.Caption = "NETO"
        Me.colNeto.DisplayFormat.FormatString = "C0"
        Me.colNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNeto.FieldName = "NETO"
        Me.colNeto.Name = "colNeto"
        Me.colNeto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETO", "{0:C0}")})
        Me.colNeto.Visible = True
        Me.colNeto.VisibleIndex = 9
        Me.colNeto.Width = 121
        '
        'colSubtotal
        '
        Me.colSubtotal.Caption = "SUBTOTAL"
        Me.colSubtotal.DisplayFormat.FormatString = "C0"
        Me.colSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubtotal.FieldName = "SUBTOTAL"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SUBTOTAL", "{0:C0}")})
        Me.colSubtotal.Visible = True
        Me.colSubtotal.VisibleIndex = 7
        Me.colSubtotal.Width = 104
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 562)
        Me.Controls.Add(Me.GCConsultar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas "
        Me.cmsGrid.ResumeLayout(False)
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tsmExportarPDF As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmImprimir As ToolStripMenuItem
    Friend WithEvents tsmVistaPrevia As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmActualizarVista As ToolStripMenuItem
    Friend WithEvents cmsGrid As ContextMenuStrip
    Friend WithEvents tsmExportarExcel As ToolStripMenuItem
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents colFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPresentacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotal As DevExpress.XtraGrid.Columns.GridColumn
End Class

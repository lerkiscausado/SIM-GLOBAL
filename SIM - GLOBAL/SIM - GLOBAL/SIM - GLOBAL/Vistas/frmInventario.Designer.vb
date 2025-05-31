<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventario
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
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventario))
        Me.GCInventario = New DevExpress.XtraGrid.GridControl()
        Me.GVInventario = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPresentacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMovimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadEntrada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIUnidadMedida = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCInventario
        '
        Me.GCInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCInventario.Location = New System.Drawing.Point(0, 0)
        Me.GCInventario.MainView = Me.GVInventario
        Me.GCInventario.Name = "GCInventario"
        Me.GCInventario.Size = New System.Drawing.Size(1169, 504)
        Me.GCInventario.TabIndex = 3
        Me.GCInventario.UseEmbeddedNavigator = True
        Me.GCInventario.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVInventario})
        '
        'GVInventario
        '
        Me.GVInventario.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFecha, Me.colPresentacion, Me.GridColumn6, Me.GridColumn7, Me.colMovimiento, Me.colFactura, Me.colCantidadEntrada, Me.GridColumn1, Me.GridColumn4, Me.GridColumn8, Me.colIUnidadMedida})
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
        Me.GVInventario.FormatRules.Add(GridFormatRule1)
        Me.GVInventario.FormatRules.Add(GridFormatRule2)
        Me.GVInventario.FormatRules.Add(GridFormatRule3)
        Me.GVInventario.GridControl = Me.GCInventario
        Me.GVInventario.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVInventario.Name = "GVInventario"
        Me.GVInventario.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVInventario.OptionsBehavior.ReadOnly = True
        Me.GVInventario.OptionsFind.AlwaysVisible = True
        Me.GVInventario.OptionsPrint.AutoWidth = False
        Me.GVInventario.OptionsView.ColumnAutoWidth = False
        Me.GVInventario.OptionsView.EnableAppearanceOddRow = True
        Me.GVInventario.OptionsView.ShowFooter = True
        Me.GVInventario.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.GVInventario.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn8, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFecha
        '
        Me.colFecha.Caption = "FECHA"
        Me.colFecha.FieldName = "FECHA"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 0
        Me.colFecha.Width = 68
        '
        'colPresentacion
        '
        Me.colPresentacion.Caption = "PRODUCTO"
        Me.colPresentacion.FieldName = "PRODUCTO"
        Me.colPresentacion.Name = "colPresentacion"
        Me.colPresentacion.Visible = True
        Me.colPresentacion.VisibleIndex = 1
        Me.colPresentacion.Width = 167
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "MARCA"
        Me.GridColumn6.FieldName = "MARCA"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 129
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "PRESENTACION"
        Me.GridColumn7.FieldName = "PRESENTACION"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 113
        '
        'colMovimiento
        '
        Me.colMovimiento.Caption = "MOVIMIENTO"
        Me.colMovimiento.FieldName = "MOVIMIENTO"
        Me.colMovimiento.Name = "colMovimiento"
        Me.colMovimiento.Visible = True
        Me.colMovimiento.VisibleIndex = 5
        '
        'colFactura
        '
        Me.colFactura.Caption = "FACTURA"
        Me.colFactura.FieldName = "FACTURA"
        Me.colFactura.Name = "colFactura"
        Me.colFactura.Visible = True
        Me.colFactura.VisibleIndex = 6
        Me.colFactura.Width = 55
        '
        'colCantidadEntrada
        '
        Me.colCantidadEntrada.Caption = "ENTRADAS"
        Me.colCantidadEntrada.FieldName = "ENTRADA_CANTIDAD"
        Me.colCantidadEntrada.Name = "colCantidadEntrada"
        Me.colCantidadEntrada.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ENTRADA_CANTIDAD", "{0}")})
        Me.colCantidadEntrada.Visible = True
        Me.colCantidadEntrada.VisibleIndex = 7
        Me.colCantidadEntrada.Width = 62
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "SALIDAS"
        Me.GridColumn1.FieldName = "SALIDA_CANTIDAD"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SALIDA_CANTIDAD", "{0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 8
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "SALDO"
        Me.GridColumn4.FieldName = "SALDO_CANTIDAD"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 9
        Me.GridColumn4.Width = 112
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "ID"
        Me.GridColumn8.FieldName = "ID"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'colIUnidadMedida
        '
        Me.colIUnidadMedida.Caption = "Unid./Med."
        Me.colIUnidadMedida.FieldName = "UNIDAD_MEDIDA"
        Me.colIUnidadMedida.Name = "colIUnidadMedida"
        Me.colIUnidadMedida.Visible = True
        Me.colIUnidadMedida.VisibleIndex = 4
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 504)
        Me.Controls.Add(Me.GCInventario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        CType(Me.GCInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCInventario As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVInventario As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPresentacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMovimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIUnidadMedida As DevExpress.XtraGrid.Columns.GridColumn
End Class

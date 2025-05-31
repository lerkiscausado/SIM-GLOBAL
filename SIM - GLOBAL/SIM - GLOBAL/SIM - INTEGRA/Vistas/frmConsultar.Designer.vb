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
        Me.components = New System.ComponentModel.Container()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultar))
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaIngreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEdad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAutorizacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiagnostico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmActualizarGrilla = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInformacionUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmVistaPrevia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPDF = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'colEstado
        '
        Me.colEstado.Caption = "ESTADO"
        Me.colEstado.FieldName = "ESTADO"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 12
        Me.colEstado.Width = 84
        '
        'sfdRuta
        '
        Me.sfdRuta.Filter = "Archivos Excel | *.xls"
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrden, Me.colFechaIngreso, Me.colIdentificacion, Me.colUsuario, Me.colSexo, Me.colEdad, Me.colTelefono, Me.colNumeroOrden, Me.colAutorizacion, Me.colDiagnostico, Me.colContrato, Me.colEntidad, Me.colEstado})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colEstado
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Expression = "CANCELADA"
        FormatConditionRuleValue1.Value1 = "CANCELADA"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.colEstado
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Expression = "PENDIENTE"
        FormatConditionRuleValue2.Value1 = "PENDIENTE"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.GVConsultar.FormatRules.Add(GridFormatRule1)
        Me.GVConsultar.FormatRules.Add(GridFormatRule2)
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsFind.AlwaysVisible = True
        Me.GVConsultar.OptionsMenu.ShowFooterItem = True
        Me.GVConsultar.OptionsPrint.PrintPreview = True
        Me.GVConsultar.OptionsView.ColumnAutoWidth = False
        Me.GVConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsView.ShowFooter = True
        Me.GVConsultar.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colOrden, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colOrden
        '
        Me.colOrden.Caption = "ORDEN"
        Me.colOrden.FieldName = "ORDEN"
        Me.colOrden.Name = "colOrden"
        Me.colOrden.Visible = True
        Me.colOrden.VisibleIndex = 0
        Me.colOrden.Width = 61
        '
        'colFechaIngreso
        '
        Me.colFechaIngreso.Caption = "FECHA INGRESO"
        Me.colFechaIngreso.FieldName = "FECHA_INGRESO"
        Me.colFechaIngreso.Name = "colFechaIngreso"
        Me.colFechaIngreso.Visible = True
        Me.colFechaIngreso.VisibleIndex = 1
        Me.colFechaIngreso.Width = 99
        '
        'colIdentificacion
        '
        Me.colIdentificacion.Caption = "IDENTIFICACION"
        Me.colIdentificacion.FieldName = "IDENTIFICACION"
        Me.colIdentificacion.Name = "colIdentificacion"
        Me.colIdentificacion.Visible = True
        Me.colIdentificacion.VisibleIndex = 2
        Me.colIdentificacion.Width = 100
        '
        'colUsuario
        '
        Me.colUsuario.Caption = "USUARIO"
        Me.colUsuario.FieldName = "USUARIO"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.Visible = True
        Me.colUsuario.VisibleIndex = 3
        Me.colUsuario.Width = 198
        '
        'colSexo
        '
        Me.colSexo.Caption = "SEXO"
        Me.colSexo.FieldName = "SEXO"
        Me.colSexo.Name = "colSexo"
        Me.colSexo.Visible = True
        Me.colSexo.VisibleIndex = 4
        Me.colSexo.Width = 39
        '
        'colEdad
        '
        Me.colEdad.Caption = "EDAD"
        Me.colEdad.FieldName = "EDAD"
        Me.colEdad.Name = "colEdad"
        Me.colEdad.Visible = True
        Me.colEdad.VisibleIndex = 5
        Me.colEdad.Width = 36
        '
        'colTelefono
        '
        Me.colTelefono.Caption = "TELEFONO"
        Me.colTelefono.FieldName = "TELEFONO"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Visible = True
        Me.colTelefono.VisibleIndex = 6
        Me.colTelefono.Width = 84
        '
        'colNumeroOrden
        '
        Me.colNumeroOrden.Caption = "NUMERO ORDEN"
        Me.colNumeroOrden.FieldName = "NUMERO_ORDEN"
        Me.colNumeroOrden.Name = "colNumeroOrden"
        Me.colNumeroOrden.Visible = True
        Me.colNumeroOrden.VisibleIndex = 7
        Me.colNumeroOrden.Width = 92
        '
        'colAutorizacion
        '
        Me.colAutorizacion.Caption = "AUTORIZACION"
        Me.colAutorizacion.FieldName = "AUTORIZACION"
        Me.colAutorizacion.Name = "colAutorizacion"
        Me.colAutorizacion.Visible = True
        Me.colAutorizacion.VisibleIndex = 8
        Me.colAutorizacion.Width = 95
        '
        'colDiagnostico
        '
        Me.colDiagnostico.Caption = "DIAGNOSTICO"
        Me.colDiagnostico.FieldName = "DIAGNOSTICO"
        Me.colDiagnostico.Name = "colDiagnostico"
        Me.colDiagnostico.Visible = True
        Me.colDiagnostico.VisibleIndex = 9
        Me.colDiagnostico.Width = 85
        '
        'colContrato
        '
        Me.colContrato.Caption = "CONTRATO"
        Me.colContrato.FieldName = "CONTRATO"
        Me.colContrato.Name = "colContrato"
        Me.colContrato.Visible = True
        Me.colContrato.VisibleIndex = 10
        Me.colContrato.Width = 177
        '
        'colEntidad
        '
        Me.colEntidad.Caption = "ENTIDAD"
        Me.colEntidad.FieldName = "ENTIDAD"
        Me.colEntidad.Name = "colEntidad"
        Me.colEntidad.Visible = True
        Me.colEntidad.VisibleIndex = 11
        Me.colEntidad.Width = 244
        '
        'GCConsultar
        '
        Me.GCConsultar.ContextMenuStrip = Me.cmsGrid
        Me.GCConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConsultar.Location = New System.Drawing.Point(0, 0)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(1182, 513)
        Me.GCConsultar.TabIndex = 3
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'cmsGrid
        '
        Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmActualizarGrilla, Me.tsmInformacionUsuario, Me.ToolStripSeparator1, Me.tsmVistaPrevia, Me.tsmImprimir, Me.ToolStripSeparator2, Me.tsmExcel, Me.tsmPDF})
        Me.cmsGrid.Name = "cmsGrid"
        Me.cmsGrid.Size = New System.Drawing.Size(198, 148)
        '
        'tsmActualizarGrilla
        '
        Me.tsmActualizarGrilla.Image = CType(resources.GetObject("tsmActualizarGrilla.Image"), System.Drawing.Image)
        Me.tsmActualizarGrilla.Name = "tsmActualizarGrilla"
        Me.tsmActualizarGrilla.Size = New System.Drawing.Size(197, 22)
        Me.tsmActualizarGrilla.Text = "Actualizar Grilla"
        '
        'tsmInformacionUsuario
        '
        Me.tsmInformacionUsuario.Enabled = False
        Me.tsmInformacionUsuario.Image = CType(resources.GetObject("tsmInformacionUsuario.Image"), System.Drawing.Image)
        Me.tsmInformacionUsuario.Name = "tsmInformacionUsuario"
        Me.tsmInformacionUsuario.Size = New System.Drawing.Size(197, 22)
        Me.tsmInformacionUsuario.Text = "Informacion de usuario"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(194, 6)
        '
        'tsmVistaPrevia
        '
        Me.tsmVistaPrevia.Image = CType(resources.GetObject("tsmVistaPrevia.Image"), System.Drawing.Image)
        Me.tsmVistaPrevia.Name = "tsmVistaPrevia"
        Me.tsmVistaPrevia.Size = New System.Drawing.Size(197, 22)
        Me.tsmVistaPrevia.Text = "Vista Previa"
        '
        'tsmImprimir
        '
        Me.tsmImprimir.Image = CType(resources.GetObject("tsmImprimir.Image"), System.Drawing.Image)
        Me.tsmImprimir.Name = "tsmImprimir"
        Me.tsmImprimir.Size = New System.Drawing.Size(197, 22)
        Me.tsmImprimir.Text = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(194, 6)
        '
        'tsmExcel
        '
        Me.tsmExcel.Image = CType(resources.GetObject("tsmExcel.Image"), System.Drawing.Image)
        Me.tsmExcel.Name = "tsmExcel"
        Me.tsmExcel.Size = New System.Drawing.Size(197, 22)
        Me.tsmExcel.Text = "Exportar a Excel"
        '
        'tsmPDF
        '
        Me.tsmPDF.Image = CType(resources.GetObject("tsmPDF.Image"), System.Drawing.Image)
        Me.tsmPDF.Name = "tsmPDF"
        Me.tsmPDF.Size = New System.Drawing.Size(197, 22)
        Me.tsmPDF.Text = "Exportar a PDF"
        '
        'frmConsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 513)
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
    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmsGrid As ContextMenuStrip
    Friend WithEvents tsmVistaPrevia As ToolStripMenuItem
    Friend WithEvents tsmImprimir As ToolStripMenuItem
    Friend WithEvents tsmExcel As ToolStripMenuItem
    Friend WithEvents tsmPDF As ToolStripMenuItem
    Friend WithEvents colOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEdad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAutorizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiagnostico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsmActualizarGrilla As ToolStripMenuItem
    Friend WithEvents tsmInformacionUsuario As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class

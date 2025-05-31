<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHistoriasAnteriores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoriasAnteriores))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tsmPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmVistaPrevia = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmInformacionUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmActualizarGrilla = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.GCHistoriasAnteriores = New DevExpress.XtraGrid.GridControl()
        Me.GVHistoriasAnteriores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEdad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiagnostico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEspecialidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEspecialista = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiVistaPrevia = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPDF = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimirHistoria = New DevExpress.XtraBars.BarButtonItem()
        Me.colCITA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREMISION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmsGrid.SuspendLayout()
        CType(Me.GCHistoriasAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVHistoriasAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "ESTADO"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 12
        Me.colEstado.Width = 97
        '
        'tsmPDF
        '
        Me.tsmPDF.Image = CType(resources.GetObject("tsmPDF.Image"), System.Drawing.Image)
        Me.tsmPDF.Name = "tsmPDF"
        Me.tsmPDF.Size = New System.Drawing.Size(197, 22)
        Me.tsmPDF.Text = "Exportar a PDF"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(194, 6)
        '
        'tsmImprimir
        '
        Me.tsmImprimir.Image = CType(resources.GetObject("tsmImprimir.Image"), System.Drawing.Image)
        Me.tsmImprimir.Name = "tsmImprimir"
        Me.tsmImprimir.Size = New System.Drawing.Size(197, 22)
        Me.tsmImprimir.Text = "Imprimir"
        '
        'tsmVistaPrevia
        '
        Me.tsmVistaPrevia.Image = CType(resources.GetObject("tsmVistaPrevia.Image"), System.Drawing.Image)
        Me.tsmVistaPrevia.Name = "tsmVistaPrevia"
        Me.tsmVistaPrevia.Size = New System.Drawing.Size(197, 22)
        Me.tsmVistaPrevia.Text = "Vista Previa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(194, 6)
        '
        'tsmInformacionUsuario
        '
        Me.tsmInformacionUsuario.Enabled = False
        Me.tsmInformacionUsuario.Image = CType(resources.GetObject("tsmInformacionUsuario.Image"), System.Drawing.Image)
        Me.tsmInformacionUsuario.Name = "tsmInformacionUsuario"
        Me.tsmInformacionUsuario.Size = New System.Drawing.Size(197, 22)
        Me.tsmInformacionUsuario.Text = "Informacion de usuario"
        '
        'tsmActualizarGrilla
        '
        Me.tsmActualizarGrilla.Image = CType(resources.GetObject("tsmActualizarGrilla.Image"), System.Drawing.Image)
        Me.tsmActualizarGrilla.Name = "tsmActualizarGrilla"
        Me.tsmActualizarGrilla.Size = New System.Drawing.Size(197, 22)
        Me.tsmActualizarGrilla.Text = "Actualizar Grilla"
        '
        'cmsGrid
        '
        Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmActualizarGrilla, Me.tsmInformacionUsuario, Me.ToolStripSeparator1, Me.tsmVistaPrevia, Me.tsmImprimir, Me.ToolStripSeparator2, Me.tsmExcel, Me.tsmPDF})
        Me.cmsGrid.Name = "cmsGrid"
        Me.cmsGrid.Size = New System.Drawing.Size(198, 148)
        '
        'tsmExcel
        '
        Me.tsmExcel.Image = CType(resources.GetObject("tsmExcel.Image"), System.Drawing.Image)
        Me.tsmExcel.Name = "tsmExcel"
        Me.tsmExcel.Size = New System.Drawing.Size(197, 22)
        Me.tsmExcel.Text = "Exportar a Excel"
        '
        'GCHistoriasAnteriores
        '
        Me.GCHistoriasAnteriores.ContextMenuStrip = Me.cmsGrid
        Me.GCHistoriasAnteriores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCHistoriasAnteriores.Location = New System.Drawing.Point(0, 31)
        Me.GCHistoriasAnteriores.MainView = Me.GVHistoriasAnteriores
        Me.GCHistoriasAnteriores.Name = "GCHistoriasAnteriores"
        Me.GCHistoriasAnteriores.Size = New System.Drawing.Size(908, 489)
        Me.GCHistoriasAnteriores.TabIndex = 4
        Me.GCHistoriasAnteriores.UseEmbeddedNavigator = True
        Me.GCHistoriasAnteriores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVHistoriasAnteriores})
        '
        'GVHistoriasAnteriores
        '
        Me.GVHistoriasAnteriores.ActiveFilterEnabled = False
        Me.GVHistoriasAnteriores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdDetalle, Me.colOrden, Me.colFecha, Me.colHora, Me.colIdentificacion, Me.colUsuario, Me.colSexo, Me.colEdad, Me.colDiagnostico, Me.colContrato, Me.colEntidad, Me.colEspecialidad, Me.colEspecialista, Me.colEstado, Me.colCITA, Me.colREMISION})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colEstado
        GridFormatRule1.Name = "Format1"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Expression = "PENDIENTE"
        FormatConditionRuleValue1.Value1 = "PENDIENTE"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.GVHistoriasAnteriores.FormatRules.Add(GridFormatRule1)
        Me.GVHistoriasAnteriores.GridControl = Me.GCHistoriasAnteriores
        Me.GVHistoriasAnteriores.Name = "GVHistoriasAnteriores"
        Me.GVHistoriasAnteriores.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVHistoriasAnteriores.OptionsBehavior.ReadOnly = True
        Me.GVHistoriasAnteriores.OptionsMenu.ShowFooterItem = True
        Me.GVHistoriasAnteriores.OptionsPrint.PrintPreview = True
        Me.GVHistoriasAnteriores.OptionsView.ColumnAutoWidth = False
        Me.GVHistoriasAnteriores.OptionsView.EnableAppearanceOddRow = True
        '
        'colIdDetalle
        '
        Me.colIdDetalle.Caption = "IDDETALLE"
        Me.colIdDetalle.FieldName = "IDDETALLE"
        Me.colIdDetalle.Name = "colIdDetalle"
        Me.colIdDetalle.Width = 61
        '
        'colOrden
        '
        Me.colOrden.Caption = "Orden"
        Me.colOrden.FieldName = "ORDEN"
        Me.colOrden.Name = "colOrden"
        Me.colOrden.Visible = True
        Me.colOrden.VisibleIndex = 0
        Me.colOrden.Width = 51
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "FECHA"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        Me.colFecha.Width = 70
        '
        'colHora
        '
        Me.colHora.Caption = "Hora"
        Me.colHora.FieldName = "HORA"
        Me.colHora.Name = "colHora"
        Me.colHora.Visible = True
        Me.colHora.VisibleIndex = 2
        Me.colHora.Width = 64
        '
        'colIdentificacion
        '
        Me.colIdentificacion.Caption = "Identificacion"
        Me.colIdentificacion.FieldName = "IDENTIFICACION"
        Me.colIdentificacion.Name = "colIdentificacion"
        Me.colIdentificacion.Visible = True
        Me.colIdentificacion.VisibleIndex = 3
        Me.colIdentificacion.Width = 110
        '
        'colUsuario
        '
        Me.colUsuario.AppearanceHeader.Options.UseImage = True
        Me.colUsuario.Caption = "Usuario"
        Me.colUsuario.FieldName = "USUARIO"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.Visible = True
        Me.colUsuario.VisibleIndex = 4
        Me.colUsuario.Width = 219
        '
        'colSexo
        '
        Me.colSexo.Caption = "Sexo"
        Me.colSexo.FieldName = "SEXO"
        Me.colSexo.Name = "colSexo"
        Me.colSexo.Visible = True
        Me.colSexo.VisibleIndex = 5
        Me.colSexo.Width = 36
        '
        'colEdad
        '
        Me.colEdad.Caption = "Edad"
        Me.colEdad.FieldName = "EDAD"
        Me.colEdad.Name = "colEdad"
        Me.colEdad.Visible = True
        Me.colEdad.VisibleIndex = 6
        Me.colEdad.Width = 39
        '
        'colDiagnostico
        '
        Me.colDiagnostico.Caption = "Diagnostico"
        Me.colDiagnostico.FieldName = "DIAGNOSTICO"
        Me.colDiagnostico.Name = "colDiagnostico"
        Me.colDiagnostico.Visible = True
        Me.colDiagnostico.VisibleIndex = 7
        Me.colDiagnostico.Width = 66
        '
        'colContrato
        '
        Me.colContrato.Caption = "Contrato"
        Me.colContrato.FieldName = "CONTRATO"
        Me.colContrato.Name = "colContrato"
        Me.colContrato.Visible = True
        Me.colContrato.VisibleIndex = 8
        Me.colContrato.Width = 178
        '
        'colEntidad
        '
        Me.colEntidad.Caption = "Entidad"
        Me.colEntidad.FieldName = "ENTIDAD"
        Me.colEntidad.Name = "colEntidad"
        Me.colEntidad.Visible = True
        Me.colEntidad.VisibleIndex = 9
        Me.colEntidad.Width = 167
        '
        'colEspecialidad
        '
        Me.colEspecialidad.Caption = "Especialidad"
        Me.colEspecialidad.FieldName = "ESPECIALIDAD"
        Me.colEspecialidad.Name = "colEspecialidad"
        Me.colEspecialidad.Visible = True
        Me.colEspecialidad.VisibleIndex = 10
        Me.colEspecialidad.Width = 170
        '
        'colEspecialista
        '
        Me.colEspecialista.Caption = "Especialista"
        Me.colEspecialista.FieldName = "ESPECIALISTA"
        Me.colEspecialista.Name = "colEspecialista"
        Me.colEspecialista.Visible = True
        Me.colEspecialista.VisibleIndex = 11
        Me.colEspecialista.Width = 234
        '
        'sfdRuta
        '
        Me.sfdRuta.Filter = "Archivos Excel | *.xls"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiBuscar, Me.bbiActualizar, Me.BarButtonItem3, Me.bbiExcel, Me.bbiPDF, Me.bbiImprimir, Me.bbiVistaPrevia, Me.BarSubItem1, Me.BarSubItem2, Me.BarButtonItem1, Me.bbiImprimirHistoria})
        Me.BarManager1.MaxItemId = 11
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiBuscar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVistaPrevia), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExcel), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPDF), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimirHistoria)})
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.Text = "Herramientas"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Informacion del Usuario"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bbiBuscar
        '
        Me.bbiBuscar.Caption = "Consultar"
        Me.bbiBuscar.Id = 0
        Me.bbiBuscar.ImageOptions.Image = CType(resources.GetObject("bbiBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiBuscar.Name = "bbiBuscar"
        '
        'bbiActualizar
        '
        Me.bbiActualizar.Caption = "Actualizar "
        Me.bbiActualizar.Id = 1
        Me.bbiActualizar.ImageOptions.Image = CType(resources.GetObject("bbiActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiActualizar.Name = "bbiActualizar"
        '
        'bbiVistaPrevia
        '
        Me.bbiVistaPrevia.Caption = "Vista Previa Historia"
        Me.bbiVistaPrevia.Id = 6
        Me.bbiVistaPrevia.ImageOptions.Image = CType(resources.GetObject("bbiVistaPrevia.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiVistaPrevia.Name = "bbiVistaPrevia"
        '
        'bbiExcel
        '
        Me.bbiExcel.Caption = "Exportar a Excel"
        Me.bbiExcel.Id = 3
        Me.bbiExcel.ImageOptions.Image = CType(resources.GetObject("bbiExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiExcel.Name = "bbiExcel"
        '
        'bbiPDF
        '
        Me.bbiPDF.Caption = "Exportar PDF"
        Me.bbiPDF.Id = 4
        Me.bbiPDF.ImageOptions.Image = CType(resources.GetObject("bbiPDF.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiPDF.Name = "bbiPDF"
        '
        'bbiImprimir
        '
        Me.bbiImprimir.ActAsDropDown = True
        Me.bbiImprimir.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.DropDownControl = Me.PopupMenu1
        Me.bbiImprimir.Id = 5
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(908, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 520)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(908, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 489)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(908, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 489)
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Historia"
        Me.BarSubItem1.Id = 7
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "prueba"
        Me.BarSubItem2.Id = 8
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "jhjghg"
        Me.BarButtonItem1.Id = 9
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'bbiImprimirHistoria
        '
        Me.bbiImprimirHistoria.Caption = "Imprimir Historia"
        Me.bbiImprimirHistoria.Id = 10
        Me.bbiImprimirHistoria.Name = "bbiImprimirHistoria"
        '
        'colCITA
        '
        Me.colCITA.Caption = "CITA"
        Me.colCITA.FieldName = "CITA"
        Me.colCITA.Name = "colCITA"
        '
        'colREMISION
        '
        Me.colREMISION.Caption = "REMISION"
        Me.colREMISION.FieldName = "REMISION"
        Me.colREMISION.Name = "colREMISION"
        '
        'frmHistoriasAnteriores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 520)
        Me.Controls.Add(Me.GCHistoriasAnteriores)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHistoriasAnteriores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historias Anteriores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cmsGrid.ResumeLayout(False)
        CType(Me.GCHistoriasAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVHistoriasAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsmPDF As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmImprimir As ToolStripMenuItem
    Friend WithEvents tsmVistaPrevia As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmInformacionUsuario As ToolStripMenuItem
    Friend WithEvents tsmActualizarGrilla As ToolStripMenuItem
    Friend WithEvents cmsGrid As ContextMenuStrip
    Friend WithEvents tsmExcel As ToolStripMenuItem
    Friend WithEvents GCHistoriasAnteriores As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVHistoriasAnteriores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents colIdDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEdad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiagnostico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEspecialidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEspecialista As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiPDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiVistaPrevia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimirHistoria As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCITA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREMISION As DevExpress.XtraGrid.Columns.GridColumn
End Class

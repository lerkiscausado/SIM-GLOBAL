<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEventos))
        Me.chkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.gcConsultar = New DevExpress.XtraGrid.GridControl()
        Me.gvConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtEvento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lblID = New DevExpress.XtraEditors.LabelControl()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEvento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(399, 37)
        Me.chkEstado.MenuManager = Me.BarManager1
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.Caption = "Activo"
        Me.chkEstado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkEstado.Size = New System.Drawing.Size(75, 20)
        Me.chkEstado.TabIndex = 181
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir})
        Me.BarManager1.MaxItemId = 8
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir)})
        Me.Bar1.Text = "Herramientas"
        '
        'bbiNuevo
        '
        Me.bbiNuevo.Caption = "Nuevo"
        Me.bbiNuevo.Id = 0
        Me.bbiNuevo.ImageOptions.Image = CType(resources.GetObject("bbiNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiNuevo.Name = "bbiNuevo"
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar"
        Me.bbiEditar.Id = 1
        Me.bbiEditar.ImageOptions.Image = CType(resources.GetObject("bbiEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEditar.Name = "bbiEditar"
        '
        'bbiGuardar
        '
        Me.bbiGuardar.Caption = "Guardar"
        Me.bbiGuardar.Id = 5
        Me.bbiGuardar.ImageOptions.Image = CType(resources.GetObject("bbiGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGuardar.Name = "bbiGuardar"
        '
        'bbiConsultar
        '
        Me.bbiConsultar.Caption = "Consultar"
        Me.bbiConsultar.Id = 6
        Me.bbiConsultar.ImageOptions.Image = CType(resources.GetObject("bbiConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiConsultar.Name = "bbiConsultar"
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.Id = 7
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(486, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 351)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(486, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 327)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(486, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 327)
        '
        'gcConsultar
        '
        Me.gcConsultar.Location = New System.Drawing.Point(17, 74)
        Me.gcConsultar.MainView = Me.gvConsultar
        Me.gcConsultar.MenuManager = Me.BarManager1
        Me.gcConsultar.Name = "gcConsultar"
        Me.gcConsultar.Size = New System.Drawing.Size(457, 258)
        Me.gcConsultar.TabIndex = 180
        Me.gcConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvConsultar})
        '
        'gvConsultar
        '
        Me.gvConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNOMBRE, Me.colESTADO})
        Me.gvConsultar.GridControl = Me.gcConsultar
        Me.gvConsultar.Name = "gvConsultar"
        Me.gvConsultar.OptionsBehavior.Editable = False
        Me.gvConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.gvConsultar.OptionsView.ShowFooter = True
        Me.gvConsultar.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "EVENTO"
        Me.colNOMBRE.FieldName = "EVENTO"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 0
        Me.colNOMBRE.Width = 328
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 1
        Me.colESTADO.Width = 104
        '
        'txtEvento
        '
        Me.txtEvento.Location = New System.Drawing.Point(73, 37)
        Me.txtEvento.MenuManager = Me.BarManager1
        Me.txtEvento.Name = "txtEvento"
        Me.txtEvento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtEvento.Properties.Appearance.Options.UseBackColor = True
        Me.txtEvento.Size = New System.Drawing.Size(309, 20)
        Me.txtEvento.TabIndex = 174
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(17, 40)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl5.TabIndex = 175
        Me.LabelControl5.Text = "Evento:"
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(399, 55)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(6, 13)
        Me.lblID.TabIndex = 186
        Me.lblID.Text = "1"
        Me.lblID.Visible = False
        '
        'frmEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 351)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.gcConsultar)
        Me.Controls.Add(Me.txtEvento)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Image = CType(resources.GetObject("frmEventos.IconOptions.Image"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Eventos"
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEvento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents gcConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtEvento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
End Class

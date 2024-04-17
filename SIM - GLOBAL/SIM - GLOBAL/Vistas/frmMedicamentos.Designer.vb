<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMedicamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedicamentos))
        Me.chkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMEDICAMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(437, 49)
        Me.chkEstado.MenuManager = Me.BarManager1
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.Caption = "Activo"
        Me.chkEstado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkEstado.Size = New System.Drawing.Size(75, 20)
        Me.chkEstado.TabIndex = 5
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir})
        Me.BarManager1.MaxItemId = 5
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir)})
        Me.Bar1.Text = "Herramientas"
        '
        'bbtNuevo
        '
        Me.bbtNuevo.Caption = "Nuevo"
        Me.bbtNuevo.Id = 0
        Me.bbtNuevo.ImageOptions.Image = CType(resources.GetObject("bbtNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbtNuevo.Name = "bbtNuevo"
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
        Me.bbiGuardar.Id = 2
        Me.bbiGuardar.ImageOptions.Image = CType(resources.GetObject("bbiGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGuardar.Name = "bbiGuardar"
        '
        'bbiConsultar
        '
        Me.bbiConsultar.Caption = "Consultar"
        Me.bbiConsultar.Id = 3
        Me.bbiConsultar.ImageOptions.Image = CType(resources.GetObject("bbiConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiConsultar.Name = "bbiConsultar"
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.Enabled = False
        Me.bbiImprimir.Id = 4
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.Name = "bbiImprimir"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(522, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 465)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(522, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 441)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(522, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 441)
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(412, 11)
        Me.txtCodigo.MenuManager = Me.BarManager1
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCodigo.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 2
        Me.txtCodigo.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(365, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Codigo:"
        Me.LabelControl1.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.EnterMoveNextControl = True
        Me.txtNombre.Location = New System.Drawing.Point(85, 49)
        Me.txtNombre.MenuManager = Me.BarManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Properties.MaxLength = 150
        Me.txtNombre.Size = New System.Drawing.Size(346, 20)
        Me.txtNombre.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Nombre"
        '
        'GCConsultar
        '
        Me.GCConsultar.Location = New System.Drawing.Point(12, 107)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(500, 345)
        Me.GCConsultar.TabIndex = 12
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colMEDICAMENTO, Me.colESTADO})
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.Editable = False
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultar.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultar.OptionsPrint.PrintFooter = False
        Me.GVConsultar.OptionsView.ShowFooter = True
        Me.GVConsultar.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colMEDICAMENTO
        '
        Me.colMEDICAMENTO.Caption = "MEDICAMENTO"
        Me.colMEDICAMENTO.FieldName = "MEDICAMENTO"
        Me.colMEDICAMENTO.Name = "colMEDICAMENTO"
        Me.colMEDICAMENTO.Visible = True
        Me.colMEDICAMENTO.VisibleIndex = 0
        Me.colMEDICAMENTO.Width = 811
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 1
        Me.colESTADO.Width = 250
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(12, 75)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(500, 26)
        Me.SeparatorControl1.TabIndex = 142
        '
        'frmMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 465)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.GCConsultar)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frmMedicamentos.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMedicamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Medicamentos"
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEDICAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
End Class

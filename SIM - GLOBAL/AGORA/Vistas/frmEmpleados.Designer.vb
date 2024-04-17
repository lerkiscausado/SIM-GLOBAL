<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleados))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAbrir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cboCargo = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_CARGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.peFoto = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Nombre"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir, Me.bbiEliminar, Me.bbiAbrir})
        Me.BarManager1.MaxItemId = 7
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAbrir), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEliminar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir)})
        Me.Bar1.Text = "Herramientas"
        '
        'bbtNuevo
        '
        Me.bbtNuevo.Caption = "Nuevo"
        Me.bbtNuevo.Id = 0
        Me.bbtNuevo.ImageOptions.Image = CType(resources.GetObject("bbtNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbtNuevo.Name = "bbtNuevo"
        '
        'bbiAbrir
        '
        Me.bbiAbrir.Caption = "Abir"
        Me.bbiAbrir.Id = 6
        Me.bbiAbrir.ImageOptions.Image = CType(resources.GetObject("bbiAbrir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiAbrir.Name = "bbiAbrir"
        '
        'bbiGuardar
        '
        Me.bbiGuardar.Caption = "Guardar"
        Me.bbiGuardar.Id = 2
        Me.bbiGuardar.ImageOptions.Image = CType(resources.GetObject("bbiGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGuardar.Name = "bbiGuardar"
        '
        'bbiEliminar
        '
        Me.bbiEliminar.Caption = "Eliminar "
        Me.bbiEliminar.Id = 5
        Me.bbiEliminar.ImageOptions.Image = CType(resources.GetObject("bbiEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEliminar.Name = "bbiEliminar"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(621, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 514)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(621, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 490)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(621, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 490)
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar"
        Me.bbiEditar.Id = 1
        Me.bbiEditar.ImageOptions.Image = CType(resources.GetObject("bbiEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEditar.Name = "bbiEditar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 69)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Cargo"
        '
        'cboCargo
        '
        Me.cboCargo.Location = New System.Drawing.Point(101, 66)
        Me.cboCargo.MenuManager = Me.BarManager1
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboCargo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCargo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CARGO", "CARGO")})
        Me.cboCargo.Properties.NullText = ""
        Me.cboCargo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboCargo.Properties.PopupWidth = 400
        Me.cboCargo.Properties.ShowHeader = False
        Me.cboCargo.Size = New System.Drawing.Size(296, 20)
        Me.cboCargo.TabIndex = 5
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(403, 67)
        Me.chkEstado.MenuManager = Me.BarManager1
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.Caption = "Activo"
        Me.chkEstado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkEstado.Size = New System.Drawing.Size(75, 20)
        Me.chkEstado.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.EnterMoveNextControl = True
        Me.txtNombre.Location = New System.Drawing.Point(101, 41)
        Me.txtNombre.MenuManager = Me.BarManager1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Properties.MaxLength = 50
        Me.txtNombre.Size = New System.Drawing.Size(377, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(510, 12)
        Me.txtID.MenuManager = Me.BarManager1
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        Me.txtID.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(486, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID:"
        Me.LabelControl1.Visible = False
        '
        'GCConsultar
        '
        Me.GCConsultar.Location = New System.Drawing.Point(16, 195)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(594, 307)
        Me.GCConsultar.TabIndex = 13
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNOMBRE_EMPLEADO, Me.colNOMBRE_CARGO, Me.colESTADO})
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.Editable = False
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultar.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultar.OptionsPrint.PrintFooter = False
        Me.GVConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 43
        '
        'colNOMBRE_EMPLEADO
        '
        Me.colNOMBRE_EMPLEADO.Caption = "EMPLEADO"
        Me.colNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.Name = "colNOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.Visible = True
        Me.colNOMBRE_EMPLEADO.VisibleIndex = 0
        Me.colNOMBRE_EMPLEADO.Width = 204
        '
        'colNOMBRE_CARGO
        '
        Me.colNOMBRE_CARGO.Caption = "CARGO"
        Me.colNOMBRE_CARGO.FieldName = "NOMBRE_CARGO"
        Me.colNOMBRE_CARGO.Name = "colNOMBRE_CARGO"
        Me.colNOMBRE_CARGO.Visible = True
        Me.colNOMBRE_CARGO.VisibleIndex = 1
        Me.colNOMBRE_CARGO.Width = 163
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 2
        Me.colESTADO.Width = 60
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(16, 106)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(462, 26)
        Me.SeparatorControl1.TabIndex = 140
        '
        'peFoto
        '
        Me.peFoto.EditValue = CType(resources.GetObject("peFoto.EditValue"), Object)
        Me.peFoto.Location = New System.Drawing.Point(484, 38)
        Me.peFoto.Name = "peFoto"
        Me.peFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peFoto.Size = New System.Drawing.Size(126, 149)
        Me.peFoto.TabIndex = 141
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 514)
        Me.Controls.Add(Me.peFoto)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.GCConsultar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cboCargo)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frmEmpleados.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbtNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAbrir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCargo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_CARGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents peFoto As DevExpress.XtraEditors.PictureEdit
End Class

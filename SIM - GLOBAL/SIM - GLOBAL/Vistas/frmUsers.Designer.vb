<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbtNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.chkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.txtClave = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cboEmpleados = New DevExpress.XtraEditors.LookUpEdit()
        Me.GCConsultar = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCARGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSUARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbtNuevo, Me.bbiEditar, Me.bbiGuardar, Me.bbiConsultar, Me.bbiImprimir, Me.bbiEliminar})
        Me.BarManager1.MaxItemId = 6
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbtNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiConsultar), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiImprimir), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEliminar, True)})
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
        'bbiEliminar
        '
        Me.bbiEliminar.Caption = "Eliminar Usuario"
        Me.bbiEliminar.Id = 5
        Me.bbiEliminar.ImageOptions.Image = CType(resources.GetObject("bbiEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEliminar.Name = "bbiEliminar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(473, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 445)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(473, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 421)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(473, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 421)
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(387, 100)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.Caption = "Activo"
        Me.chkEstado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkEstado.Size = New System.Drawing.Size(75, 20)
        Me.chkEstado.TabIndex = 8
        '
        'txtClave
        '
        Me.txtClave.EnterMoveNextControl = True
        Me.txtClave.Location = New System.Drawing.Point(98, 99)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Properties.MaxLength = 20
        Me.txtClave.Properties.UseSystemPasswordChar = True
        Me.txtClave.Size = New System.Drawing.Size(281, 20)
        Me.txtClave.TabIndex = 7
        '
        'txtUsuario
        '
        Me.txtUsuario.EnterMoveNextControl = True
        Me.txtUsuario.Location = New System.Drawing.Point(98, 73)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.Mask.EditMask = "d"
        Me.txtUsuario.Properties.MaxLength = 60
        Me.txtUsuario.Size = New System.Drawing.Size(281, 20)
        Me.txtUsuario.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 76)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Usuario"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 50)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Empleado"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(339, 11)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Properties.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(66, 20)
        Me.txtID.TabIndex = 1
        Me.txtID.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 102)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Contraseña"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(318, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID:"
        Me.LabelControl1.Visible = False
        '
        'cboEmpleados
        '
        Me.cboEmpleados.Location = New System.Drawing.Point(98, 47)
        Me.cboEmpleados.Name = "cboEmpleados"
        Me.cboEmpleados.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboEmpleados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEmpleados.Properties.NullText = ""
        Me.cboEmpleados.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboEmpleados.Properties.PopupSizeable = False
        Me.cboEmpleados.Properties.ShowHeader = False
        Me.cboEmpleados.Size = New System.Drawing.Size(281, 20)
        Me.cboEmpleados.TabIndex = 3
        '
        'GCConsultar
        '
        Me.GCConsultar.Location = New System.Drawing.Point(12, 157)
        Me.GCConsultar.MainView = Me.GVConsultar
        Me.GCConsultar.MenuManager = Me.BarManager1
        Me.GCConsultar.Name = "GCConsultar"
        Me.GCConsultar.Size = New System.Drawing.Size(450, 275)
        Me.GCConsultar.TabIndex = 13
        Me.GCConsultar.UseEmbeddedNavigator = True
        Me.GCConsultar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultar})
        '
        'GVConsultar
        '
        Me.GVConsultar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colID_EMPLEADO, Me.colNOMBRE, Me.colCARGO, Me.colUSUARIO, Me.colESTADO})
        Me.GVConsultar.GridControl = Me.GCConsultar
        Me.GVConsultar.Name = "GVConsultar"
        Me.GVConsultar.OptionsBehavior.Editable = False
        Me.GVConsultar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GVConsultar.OptionsPrint.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsPrint.ExpandAllDetails = True
        Me.GVConsultar.OptionsPrint.ExpandAllGroups = False
        Me.GVConsultar.OptionsPrint.PrintFooter = False
        Me.GVConsultar.OptionsView.EnableAppearanceOddRow = True
        Me.GVConsultar.OptionsView.ShowFooter = True
        Me.GVConsultar.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 42
        '
        'colID_EMPLEADO
        '
        Me.colID_EMPLEADO.Caption = "ID_EMPLEADO"
        Me.colID_EMPLEADO.FieldName = "ID_EMPLEADO"
        Me.colID_EMPLEADO.Name = "colID_EMPLEADO"
        Me.colID_EMPLEADO.Width = 33
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "NOMBRE"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 0
        Me.colNOMBRE.Width = 196
        '
        'colCARGO
        '
        Me.colCARGO.Caption = "CARGO"
        Me.colCARGO.FieldName = "CARGO"
        Me.colCARGO.Name = "colCARGO"
        Me.colCARGO.Width = 166
        '
        'colUSUARIO
        '
        Me.colUSUARIO.Caption = "USUARIO"
        Me.colUSUARIO.FieldName = "USUARIO"
        Me.colUSUARIO.Name = "colUSUARIO"
        Me.colUSUARIO.Visible = True
        Me.colUSUARIO.VisibleIndex = 1
        Me.colUSUARIO.Width = 76
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "ESTADO"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 2
        Me.colESTADO.Width = 64
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(12, 125)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(450, 26)
        Me.SeparatorControl1.TabIndex = 141
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 445)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.GCConsultar)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.cboEmpleados)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frmUsers.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios de Sistema"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents bbiEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboEmpleados As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
End Class

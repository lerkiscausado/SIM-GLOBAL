<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSesion
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
        Me.btnEnviar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtUser = New DevExpress.XtraEditors.TextEdit()
        Me.txtPass = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.lblValidar = New DevExpress.XtraEditors.LabelControl()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cboLicencia = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLicencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnviar
        '
        Me.btnEnviar.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnEnviar.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.btnEnviar.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnEnviar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Appearance.Options.UseBackColor = True
        Me.btnEnviar.Appearance.Options.UseFont = True
        Me.btnEnviar.Appearance.Options.UseForeColor = True
        Me.btnEnviar.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnEnviar.AppearanceHovered.Options.UseBackColor = True
        Me.btnEnviar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnEnviar.Location = New System.Drawing.Point(18, 243)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(231, 35)
        Me.btnEnviar.TabIndex = 2
        Me.btnEnviar.Text = "Iniciar Sesión"
        '
        'txtUser
        '
        Me.txtUser.EditValue = ""
        Me.txtUser.Location = New System.Drawing.Point(18, 129)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtUser.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.txtUser.Properties.Appearance.Options.UseBackColor = True
        Me.txtUser.Properties.Appearance.Options.UseFont = True
        Me.txtUser.Size = New System.Drawing.Size(231, 32)
        Me.txtUser.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.EditValue = ""
        Me.txtPass.Location = New System.Drawing.Point(18, 185)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtPass.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.txtPass.Properties.Appearance.Options.UseBackColor = True
        Me.txtPass.Properties.Appearance.Options.UseFont = True
        Me.txtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(231, 32)
        Me.txtPass.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 110)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Usuario"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 167)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Contraseña"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(33, 20)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(196, 25)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Iniciar sesión en SIM"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(18, 291)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(231, 35)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        '
        'lblValidar
        '
        Me.lblValidar.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblValidar.Appearance.Options.UseForeColor = True
        Me.lblValidar.Location = New System.Drawing.Point(57, 223)
        Me.lblValidar.Name = "lblValidar"
        Me.lblValidar.Size = New System.Drawing.Size(156, 13)
        Me.lblValidar.TabIndex = 7
        Me.lblValidar.Text = "Verificar Usuario y/o Contraseña"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(18, 60)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl8.TabIndex = 119
        Me.LabelControl8.Text = "Licencia"
        '
        'cboLicencia
        '
        Me.cboLicencia.Location = New System.Drawing.Point(18, 79)
        Me.cboLicencia.Name = "cboLicencia"
        Me.cboLicencia.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboLicencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLicencia.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPRESA", "EMPRESA")})
        Me.cboLicencia.Properties.NullText = ""
        Me.cboLicencia.Properties.PopupWidth = 600
        Me.cboLicencia.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cboLicencia.Properties.ShowHeader = False
        Me.cboLicencia.Size = New System.Drawing.Size(231, 20)
        Me.cboLicencia.TabIndex = 118
        '
        'frmSesion
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.cboLicencia)
        Me.Controls.Add(Me.lblValidar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnEnviar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSesion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSesion"
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLicencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnviar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblValidar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLicencia As DevExpress.XtraEditors.LookUpEdit
End Class

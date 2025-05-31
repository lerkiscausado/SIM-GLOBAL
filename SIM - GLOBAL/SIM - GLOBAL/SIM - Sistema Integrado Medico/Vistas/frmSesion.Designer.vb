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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSesion))
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cboLicencia = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblValidar = New DevExpress.XtraEditors.LabelControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPass = New DevExpress.XtraEditors.TextEdit()
        Me.txtUser = New DevExpress.XtraEditors.TextEdit()
        Me.btnEnviar = New DevExpress.XtraEditors.SimpleButton()
        Me.peFoto = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btnFacebook = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInstagram = New DevExpress.XtraEditors.SimpleButton()
        Me.btnWhatsapp = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSoporte = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cboLicencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(40, 172)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl8.TabIndex = 129
        Me.LabelControl8.Text = "Licencia"
        '
        'cboLicencia
        '
        Me.cboLicencia.Location = New System.Drawing.Point(40, 191)
        Me.cboLicencia.Name = "cboLicencia"
        Me.cboLicencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.cboLicencia.Properties.Appearance.Options.UseFont = True
        Me.cboLicencia.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboLicencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLicencia.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPRESA", "EMPRESA")})
        Me.cboLicencia.Properties.NullText = ""
        Me.cboLicencia.Properties.PopupWidth = 817
        Me.cboLicencia.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cboLicencia.Properties.ShowHeader = False
        Me.cboLicencia.Size = New System.Drawing.Size(231, 32)
        Me.cboLicencia.TabIndex = 128
        '
        'lblValidar
        '
        Me.lblValidar.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblValidar.Appearance.Options.UseForeColor = True
        Me.lblValidar.Location = New System.Drawing.Point(79, 369)
        Me.lblValidar.Name = "lblValidar"
        Me.lblValidar.Size = New System.Drawing.Size(156, 13)
        Me.lblValidar.TabIndex = 127
        Me.lblValidar.Text = "Verificar Usuario y/o Contraseña"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(40, 437)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(231, 35)
        Me.btnSalir.TabIndex = 123
        Me.btnSalir.Text = "Salir"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(116, 131)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(90, 29)
        Me.LabelControl3.TabIndex = 126
        Me.LabelControl3.Text = "Ingresar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(40, 296)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 125
        Me.LabelControl2.Text = "Contraseña"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(40, 234)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 124
        Me.LabelControl1.Text = "Usuario"
        '
        'txtPass
        '
        Me.txtPass.EditValue = ""
        Me.txtPass.Location = New System.Drawing.Point(40, 313)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtPass.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.txtPass.Properties.Appearance.Options.UseBackColor = True
        Me.txtPass.Properties.Appearance.Options.UseFont = True
        Me.txtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(231, 38)
        Me.txtPass.TabIndex = 121
        '
        'txtUser
        '
        Me.txtUser.EditValue = ""
        Me.txtUser.Location = New System.Drawing.Point(40, 252)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtUser.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.txtUser.Properties.Appearance.Options.UseBackColor = True
        Me.txtUser.Properties.Appearance.Options.UseFont = True
        Me.txtUser.Size = New System.Drawing.Size(231, 38)
        Me.txtUser.TabIndex = 120
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
        Me.btnEnviar.Location = New System.Drawing.Point(40, 389)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(231, 35)
        Me.btnEnviar.TabIndex = 122
        Me.btnEnviar.Text = "Iniciar Sesión"
        '
        'peFoto
        '
        Me.peFoto.EditValue = CType(resources.GetObject("peFoto.EditValue"), Object)
        Me.peFoto.Location = New System.Drawing.Point(317, -1)
        Me.peFoto.Name = "peFoto"
        Me.peFoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.peFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.peFoto.Size = New System.Drawing.Size(560, 560)
        Me.peFoto.TabIndex = 130
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(118, 42)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(76, 71)
        Me.PictureEdit1.TabIndex = 131
        '
        'btnFacebook
        '
        Me.btnFacebook.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnFacebook.Appearance.BackColor2 = System.Drawing.Color.SteelBlue
        Me.btnFacebook.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnFacebook.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnFacebook.Appearance.Options.UseBackColor = True
        Me.btnFacebook.Appearance.Options.UseFont = True
        Me.btnFacebook.Appearance.Options.UseForeColor = True
        Me.btnFacebook.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnFacebook.AppearanceHovered.Options.UseBackColor = True
        Me.btnFacebook.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnFacebook.ImageOptions.Image = CType(resources.GetObject("btnFacebook.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFacebook.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnFacebook.Location = New System.Drawing.Point(40, 496)
        Me.btnFacebook.Name = "btnFacebook"
        Me.btnFacebook.Size = New System.Drawing.Size(50, 35)
        Me.btnFacebook.TabIndex = 132
        Me.btnFacebook.ToolTip = "Facebook"
        '
        'btnInstagram
        '
        Me.btnInstagram.Appearance.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnInstagram.Appearance.BackColor2 = System.Drawing.Color.MediumSlateBlue
        Me.btnInstagram.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnInstagram.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnInstagram.Appearance.Options.UseBackColor = True
        Me.btnInstagram.Appearance.Options.UseFont = True
        Me.btnInstagram.Appearance.Options.UseForeColor = True
        Me.btnInstagram.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnInstagram.AppearanceHovered.Options.UseBackColor = True
        Me.btnInstagram.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnInstagram.ImageOptions.Image = CType(resources.GetObject("btnInstagram.ImageOptions.Image"), System.Drawing.Image)
        Me.btnInstagram.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnInstagram.Location = New System.Drawing.Point(100, 496)
        Me.btnInstagram.Name = "btnInstagram"
        Me.btnInstagram.Size = New System.Drawing.Size(50, 35)
        Me.btnInstagram.TabIndex = 133
        Me.btnInstagram.ToolTip = "Instagram"
        '
        'btnWhatsapp
        '
        Me.btnWhatsapp.Appearance.BackColor = System.Drawing.Color.Chartreuse
        Me.btnWhatsapp.Appearance.BackColor2 = System.Drawing.Color.LimeGreen
        Me.btnWhatsapp.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnWhatsapp.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnWhatsapp.Appearance.Options.UseBackColor = True
        Me.btnWhatsapp.Appearance.Options.UseFont = True
        Me.btnWhatsapp.Appearance.Options.UseForeColor = True
        Me.btnWhatsapp.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnWhatsapp.AppearanceHovered.Options.UseBackColor = True
        Me.btnWhatsapp.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnWhatsapp.ImageOptions.Image = CType(resources.GetObject("btnWhatsapp.ImageOptions.Image"), System.Drawing.Image)
        Me.btnWhatsapp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnWhatsapp.Location = New System.Drawing.Point(162, 496)
        Me.btnWhatsapp.Name = "btnWhatsapp"
        Me.btnWhatsapp.Size = New System.Drawing.Size(50, 35)
        Me.btnWhatsapp.TabIndex = 134
        Me.btnWhatsapp.ToolTip = "Whatsapp"
        '
        'btnSoporte
        '
        Me.btnSoporte.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnSoporte.Appearance.BackColor2 = System.Drawing.Color.Brown
        Me.btnSoporte.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btnSoporte.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnSoporte.Appearance.Options.UseBackColor = True
        Me.btnSoporte.Appearance.Options.UseFont = True
        Me.btnSoporte.Appearance.Options.UseForeColor = True
        Me.btnSoporte.AppearanceHovered.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnSoporte.AppearanceHovered.Options.UseBackColor = True
        Me.btnSoporte.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnSoporte.ImageOptions.Image = CType(resources.GetObject("btnSoporte.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSoporte.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSoporte.Location = New System.Drawing.Point(221, 496)
        Me.btnSoporte.Name = "btnSoporte"
        Me.btnSoporte.Size = New System.Drawing.Size(50, 35)
        Me.btnSoporte.TabIndex = 135
        Me.btnSoporte.ToolTip = "Soporte"
        '
        'frmSesion
        '
        Me.Appearance.BackColor = System.Drawing.Color.GhostWhite
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 557)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSoporte)
        Me.Controls.Add(Me.btnWhatsapp)
        Me.Controls.Add(Me.btnInstagram)
        Me.Controls.Add(Me.btnFacebook)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.peFoto)
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
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIM Sistema Integrado Medico"
        CType(Me.cboLicencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLicencia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblValidar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnEnviar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents peFoto As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnFacebook As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInstagram As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnWhatsapp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSoporte As DevExpress.XtraEditors.SimpleButton
End Class

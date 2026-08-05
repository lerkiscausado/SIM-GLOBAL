<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRDA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRDA))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xtConexion = New DevExpress.XtraTab.XtraTabPage()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.lblEstadoServicio = New DevExpress.XtraEditors.LabelControl()
        Me.spCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.spGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.spConectar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.rbProduction = New System.Windows.Forms.RadioButton()
        Me.rbSandbox = New System.Windows.Forms.RadioButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubscriptionKey = New DevExpress.XtraEditors.TextEdit()
        Me.spVerSuscription = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtURLAuth = New DevExpress.XtraEditors.TextEdit()
        Me.txtURLBaseApi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtTenantID = New DevExpress.XtraEditors.TextEdit()
        Me.spVerClientSecret = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClientID = New DevExpress.XtraEditors.TextEdit()
        Me.txtClientSecret = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtConexion.SuspendLayout()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtSubscriptionKey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtURLAuth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtURLBaseApi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtTenantID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientSecret.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtConexion
        Me.XtraTabControl1.Size = New System.Drawing.Size(582, 398)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtConexion})
        '
        'xtConexion
        '
        Me.xtConexion.Controls.Add(Me.txtID)
        Me.xtConexion.Controls.Add(Me.lblEstadoServicio)
        Me.xtConexion.Controls.Add(Me.spCancelar)
        Me.xtConexion.Controls.Add(Me.spGuardar)
        Me.xtConexion.Controls.Add(Me.spConectar)
        Me.xtConexion.Controls.Add(Me.GroupControl2)
        Me.xtConexion.Controls.Add(Me.GroupControl1)
        Me.xtConexion.Name = "xtConexion"
        Me.xtConexion.Size = New System.Drawing.Size(580, 373)
        Me.xtConexion.Text = "Configuracion de Conexion"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(247, 339)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Size = New System.Drawing.Size(59, 20)
        Me.txtID.TabIndex = 23
        Me.txtID.Visible = False
        '
        'lblEstadoServicio
        '
        Me.lblEstadoServicio.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoServicio.Appearance.Options.UseFont = True
        Me.lblEstadoServicio.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lblEstadoServicio.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.lblEstadoServicio.Location = New System.Drawing.Point(11, 314)
        Me.lblEstadoServicio.Name = "lblEstadoServicio"
        Me.lblEstadoServicio.Size = New System.Drawing.Size(0, 13)
        Me.lblEstadoServicio.TabIndex = 22
        '
        'spCancelar
        '
        Me.spCancelar.ImageOptions.Image = CType(resources.GetObject("spCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.spCancelar.Location = New System.Drawing.Point(455, 333)
        Me.spCancelar.Name = "spCancelar"
        Me.spCancelar.Size = New System.Drawing.Size(114, 31)
        Me.spCancelar.TabIndex = 21
        Me.spCancelar.Text = "Cancelar"
        '
        'spGuardar
        '
        Me.spGuardar.ImageOptions.Image = CType(resources.GetObject("spGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.spGuardar.Location = New System.Drawing.Point(329, 333)
        Me.spGuardar.Name = "spGuardar"
        Me.spGuardar.Size = New System.Drawing.Size(114, 31)
        Me.spGuardar.TabIndex = 20
        Me.spGuardar.Text = "Guardar Cambios"
        '
        'spConectar
        '
        Me.spConectar.ImageOptions.Image = CType(resources.GetObject("spConectar.ImageOptions.Image"), System.Drawing.Image)
        Me.spConectar.Location = New System.Drawing.Point(10, 333)
        Me.spConectar.Name = "spConectar"
        Me.spConectar.Size = New System.Drawing.Size(113, 31)
        Me.spConectar.TabIndex = 19
        Me.spConectar.Text = "Probar Conexion"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.rbProduction)
        Me.GroupControl2.Controls.Add(Me.rbSandbox)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.txtSubscriptionKey)
        Me.GroupControl2.Controls.Add(Me.spVerSuscription)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.txtURLAuth)
        Me.GroupControl2.Controls.Add(Me.txtURLBaseApi)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Location = New System.Drawing.Point(10, 145)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(560, 163)
        Me.GroupControl2.TabIndex = 18
        Me.GroupControl2.Text = "Parametros de Conexion"
        '
        'rbProduction
        '
        Me.rbProduction.AutoSize = True
        Me.rbProduction.Location = New System.Drawing.Point(179, 41)
        Me.rbProduction.Name = "rbProduction"
        Me.rbProduction.Size = New System.Drawing.Size(77, 17)
        Me.rbProduction.TabIndex = 19
        Me.rbProduction.TabStop = True
        Me.rbProduction.Text = "Produccion"
        Me.rbProduction.UseVisualStyleBackColor = True
        '
        'rbSandbox
        '
        Me.rbSandbox.AutoSize = True
        Me.rbSandbox.Location = New System.Drawing.Point(107, 41)
        Me.rbSandbox.Name = "rbSandbox"
        Me.rbSandbox.Size = New System.Drawing.Size(66, 17)
        Me.rbSandbox.TabIndex = 18
        Me.rbSandbox.TabStop = True
        Me.rbSandbox.Text = "sandbox"
        Me.rbSandbox.UseVisualStyleBackColor = True
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(13, 46)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl7.TabIndex = 17
        Me.LabelControl7.Text = "Enviroment:"
        '
        'txtSubscriptionKey
        '
        Me.txtSubscriptionKey.Location = New System.Drawing.Point(106, 71)
        Me.txtSubscriptionKey.Name = "txtSubscriptionKey"
        Me.txtSubscriptionKey.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSubscriptionKey.Properties.Appearance.Options.UseBackColor = True
        Me.txtSubscriptionKey.Size = New System.Drawing.Size(395, 20)
        Me.txtSubscriptionKey.TabIndex = 10
        '
        'spVerSuscription
        '
        Me.spVerSuscription.ImageOptions.SvgImage = CType(resources.GetObject("spVerSuscription.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.spVerSuscription.Location = New System.Drawing.Point(508, 70)
        Me.spVerSuscription.Name = "spVerSuscription"
        Me.spVerSuscription.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.spVerSuscription.Size = New System.Drawing.Size(38, 22)
        Me.spVerSuscription.TabIndex = 16
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 74)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Subscription Key:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 126)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "API  Getway URL:"
        '
        'txtURLAuth
        '
        Me.txtURLAuth.Location = New System.Drawing.Point(106, 97)
        Me.txtURLAuth.Name = "txtURLAuth"
        Me.txtURLAuth.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtURLAuth.Properties.Appearance.Options.UseBackColor = True
        Me.txtURLAuth.Size = New System.Drawing.Size(395, 20)
        Me.txtURLAuth.TabIndex = 12
        '
        'txtURLBaseApi
        '
        Me.txtURLBaseApi.Location = New System.Drawing.Point(106, 123)
        Me.txtURLBaseApi.Name = "txtURLBaseApi"
        Me.txtURLBaseApi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtURLBaseApi.Properties.Appearance.Options.UseBackColor = True
        Me.txtURLBaseApi.Size = New System.Drawing.Size(395, 20)
        Me.txtURLBaseApi.TabIndex = 14
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 100)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Authorization URL:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtTenantID)
        Me.GroupControl1.Controls.Add(Me.spVerClientSecret)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtClientID)
        Me.GroupControl1.Controls.Add(Me.txtClientSecret)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(11, 20)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(559, 119)
        Me.GroupControl1.TabIndex = 17
        Me.GroupControl1.Text = "Credenciales"
        '
        'txtTenantID
        '
        Me.txtTenantID.Location = New System.Drawing.Point(106, 26)
        Me.txtTenantID.Name = "txtTenantID"
        Me.txtTenantID.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTenantID.Properties.Appearance.Options.UseBackColor = True
        Me.txtTenantID.Size = New System.Drawing.Size(395, 20)
        Me.txtTenantID.TabIndex = 10
        '
        'spVerClientSecret
        '
        Me.spVerClientSecret.ImageOptions.SvgImage = CType(resources.GetObject("spVerClientSecret.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.spVerClientSecret.Location = New System.Drawing.Point(507, 77)
        Me.spVerClientSecret.Name = "spVerClientSecret"
        Me.spVerClientSecret.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.spVerClientSecret.Size = New System.Drawing.Size(38, 22)
        Me.spVerClientSecret.TabIndex = 16
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Tenant ID: "
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 81)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Client Secret:"
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(106, 52)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtClientID.Properties.Appearance.Options.UseBackColor = True
        Me.txtClientID.Size = New System.Drawing.Size(395, 20)
        Me.txtClientID.TabIndex = 12
        '
        'txtClientSecret
        '
        Me.txtClientSecret.Location = New System.Drawing.Point(106, 78)
        Me.txtClientSecret.Name = "txtClientSecret"
        Me.txtClientSecret.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtClientSecret.Properties.Appearance.Options.UseBackColor = True
        Me.txtClientSecret.Size = New System.Drawing.Size(395, 20)
        Me.txtClientSecret.TabIndex = 14
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Client ID: "
        '
        'frmRDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 398)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.IconOptions.Image = CType(resources.GetObject("frmRDA.IconOptions.Image"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRDA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONFIGURACIÓN DE CONECTIVIDAD E INTEROPERABILIDAD - RDA COLOMBIA (MINSALUD)"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtConexion.ResumeLayout(False)
        Me.xtConexion.PerformLayout()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtSubscriptionKey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtURLAuth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtURLBaseApi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtTenantID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientSecret.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtConexion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents spVerClientSecret As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClientSecret As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClientID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenantID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents spConectar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSubscriptionKey As DevExpress.XtraEditors.TextEdit
    Friend WithEvents spVerSuscription As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtURLAuth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtURLBaseApi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents spCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblEstadoServicio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rbProduction As RadioButton
    Friend WithEvents rbSandbox As RadioButton
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
End Class

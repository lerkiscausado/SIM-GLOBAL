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
        Me.pnlEncabezado = New DevExpress.XtraEditors.PanelControl()
        Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.pnlBotones = New DevExpress.XtraEditors.PanelControl()
        Me.lnkHistorial = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.lblEstadoServicio = New DevExpress.XtraEditors.LabelControl()
        Me.spCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.spGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.spConectar = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xtConexion = New DevExpress.XtraTab.XtraTabPage()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtURLAuth = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtURLBaseApi = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenantID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClientID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClientSecret = New DevExpress.XtraEditors.TextEdit()
        Me.spVerClientSecret = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubscriptionKey = New DevExpress.XtraEditors.TextEdit()
        Me.spVerSuscription = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblNombrePrestador = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoPrestadorReps = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNitPrestador = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.rbSandbox = New System.Windows.Forms.RadioButton()
        Me.rbProduction = New System.Windows.Forms.RadioButton()
        Me.xtPruebas = New DevExpress.XtraTab.XtraTabPage()
        Me.lblPruebasInfo = New DevExpress.XtraEditors.LabelControl()
        Me.spEnviarRDAPrueba = New DevExpress.XtraEditors.SimpleButton()
        Me.spEnviarRDAConsultaPrueba = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.pnlEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEncabezado.SuspendLayout()
        CType(Me.pnlBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotones.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtConexion.SuspendLayout()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtURLAuth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtURLBaseApi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtTenantID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientSecret.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubscriptionKey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtCodigoPrestadorReps.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNitPrestador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtPruebas.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.pnlEncabezado.Appearance.Options.UseBackColor = True
        Me.pnlEncabezado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlEncabezado.Controls.Add(Me.lblSubtitulo)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.pnlEncabezado.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnlEncabezado.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(640, 64)
        Me.pnlEncabezado.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseForeColor = True
        Me.lblTitulo.Location = New System.Drawing.Point(16, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(330, 23)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Interoperabilidad RDA · MinSalud"
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblSubtitulo.Appearance.Options.UseFont = True
        Me.lblSubtitulo.Appearance.Options.UseForeColor = True
        Me.lblSubtitulo.Location = New System.Drawing.Point(17, 37)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(520, 15)
        Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = "Datos del prestador y credenciales para enviar el Resumen Digital de Atención (Res. 1888 de 2025)."
        '
        'pnlBotones
        '
        Me.pnlBotones.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlBotones.Controls.Add(Me.lnkHistorial)
        Me.pnlBotones.Controls.Add(Me.lblEstadoServicio)
        Me.pnlBotones.Controls.Add(Me.spCancelar)
        Me.pnlBotones.Controls.Add(Me.spGuardar)
        Me.pnlBotones.Controls.Add(Me.spConectar)
        Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBotones.Location = New System.Drawing.Point(0, 492)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(640, 60)
        Me.pnlBotones.TabIndex = 2
        '
        'spConectar
        '
        Me.spConectar.ImageOptions.Image = CType(resources.GetObject("spConectar.ImageOptions.Image"), System.Drawing.Image)
        Me.spConectar.Location = New System.Drawing.Point(12, 8)
        Me.spConectar.Name = "spConectar"
        Me.spConectar.Size = New System.Drawing.Size(130, 30)
        Me.spConectar.TabIndex = 0
        Me.spConectar.Text = "Probar conexión"
        '
        'lblEstadoServicio
        '
        Me.lblEstadoServicio.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEstadoServicio.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblEstadoServicio.Appearance.Options.UseFont = True
        Me.lblEstadoServicio.Appearance.Options.UseForeColor = True
        Me.lblEstadoServicio.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblEstadoServicio.Location = New System.Drawing.Point(150, 10)
        Me.lblEstadoServicio.Name = "lblEstadoServicio"
        Me.lblEstadoServicio.Size = New System.Drawing.Size(230, 26)
        Me.lblEstadoServicio.TabIndex = 1
        Me.lblEstadoServicio.Text = "⚪ Conexión sin probar"
        '
        'lnkHistorial
        '
        Me.lnkHistorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkHistorial.Location = New System.Drawing.Point(14, 42)
        Me.lnkHistorial.Name = "lnkHistorial"
        Me.lnkHistorial.Size = New System.Drawing.Size(140, 13)
        Me.lnkHistorial.TabIndex = 2
        Me.lnkHistorial.Text = "Ver historial de envíos RDA"
        '
        'spGuardar
        '
        Me.spGuardar.ImageOptions.Image = CType(resources.GetObject("spGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.spGuardar.Location = New System.Drawing.Point(388, 8)
        Me.spGuardar.Name = "spGuardar"
        Me.spGuardar.Size = New System.Drawing.Size(116, 30)
        Me.spGuardar.TabIndex = 3
        Me.spGuardar.Text = "Guardar"
        '
        'spCancelar
        '
        Me.spCancelar.ImageOptions.Image = CType(resources.GetObject("spCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.spCancelar.Location = New System.Drawing.Point(512, 8)
        Me.spCancelar.Name = "spCancelar"
        Me.spCancelar.Size = New System.Drawing.Size(116, 30)
        Me.spCancelar.TabIndex = 4
        Me.spCancelar.Text = "Cancelar"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 64)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.XtraTabControl1.SelectedTabPage = Me.xtConexion
        Me.XtraTabControl1.Size = New System.Drawing.Size(640, 428)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtConexion, Me.xtPruebas})
        '
        'xtConexion
        '
        Me.xtConexion.Controls.Add(Me.txtID)
        Me.xtConexion.Controls.Add(Me.GroupControl2)
        Me.xtConexion.Controls.Add(Me.GroupControl1)
        Me.xtConexion.Controls.Add(Me.GroupControl3)
        Me.xtConexion.Name = "xtConexion"
        Me.xtConexion.Size = New System.Drawing.Size(638, 403)
        Me.xtConexion.Text = "Configuración"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(560, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(59, 20)
        Me.txtID.TabIndex = 99
        Me.txtID.Visible = False
        '
        'GroupControl3  (Prestador)
        '
        Me.GroupControl3.Controls.Add(Me.LabelControl8)
        Me.GroupControl3.Controls.Add(Me.lblNombrePrestador)
        Me.GroupControl3.Controls.Add(Me.LabelControl9)
        Me.GroupControl3.Controls.Add(Me.txtCodigoPrestadorReps)
        Me.GroupControl3.Controls.Add(Me.LabelControl10)
        Me.GroupControl3.Controls.Add(Me.txtNitPrestador)
        Me.GroupControl3.Controls.Add(Me.LabelControl7)
        Me.GroupControl3.Controls.Add(Me.rbSandbox)
        Me.GroupControl3.Controls.Add(Me.rbProduction)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 10)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(614, 116)
        Me.GroupControl3.TabIndex = 0
        Me.GroupControl3.Text = "Prestador de servicios de salud"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(16, 34)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Prestador:"
        '
        'lblNombrePrestador
        '
        Me.lblNombrePrestador.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNombrePrestador.Appearance.Options.UseFont = True
        Me.lblNombrePrestador.Location = New System.Drawing.Point(150, 34)
        Me.lblNombrePrestador.Name = "lblNombrePrestador"
        Me.lblNombrePrestador.Size = New System.Drawing.Size(8, 13)
        Me.lblNombrePrestador.TabIndex = 1
        Me.lblNombrePrestador.Text = "—"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(16, 61)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl9.TabIndex = 2
        Me.LabelControl9.Text = "Código habilitación:"
        '
        'txtCodigoPrestadorReps
        '
        Me.txtCodigoPrestadorReps.Location = New System.Drawing.Point(150, 58)
        Me.txtCodigoPrestadorReps.Name = "txtCodigoPrestadorReps"
        Me.txtCodigoPrestadorReps.Properties.NullValuePrompt = "10 dígitos REPS"
        Me.txtCodigoPrestadorReps.Size = New System.Drawing.Size(170, 20)
        Me.txtCodigoPrestadorReps.TabIndex = 3
        Me.txtCodigoPrestadorReps.ToolTip = "Código de habilitación del prestador en REPS (sin el sufijo de sede)."
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(344, 61)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl10.TabIndex = 4
        Me.LabelControl10.Text = "NIT:"
        '
        'txtNitPrestador
        '
        Me.txtNitPrestador.Location = New System.Drawing.Point(380, 58)
        Me.txtNitPrestador.Name = "txtNitPrestador"
        Me.txtNitPrestador.Properties.NullValuePrompt = "Sin dígito de verificación"
        Me.txtNitPrestador.Size = New System.Drawing.Size(216, 20)
        Me.txtNitPrestador.TabIndex = 5
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(16, 89)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Ambiente:"
        '
        'rbSandbox
        '
        Me.rbSandbox.AutoSize = True
        Me.rbSandbox.Location = New System.Drawing.Point(150, 87)
        Me.rbSandbox.Name = "rbSandbox"
        Me.rbSandbox.Size = New System.Drawing.Size(110, 17)
        Me.rbSandbox.TabIndex = 7
        Me.rbSandbox.TabStop = True
        Me.rbSandbox.Text = "Sandbox (pruebas)"
        Me.rbSandbox.UseVisualStyleBackColor = True
        '
        'rbProduction
        '
        Me.rbProduction.AutoSize = True
        Me.rbProduction.Location = New System.Drawing.Point(290, 87)
        Me.rbProduction.Name = "rbProduction"
        Me.rbProduction.Size = New System.Drawing.Size(77, 17)
        Me.rbProduction.TabIndex = 8
        Me.rbProduction.TabStop = True
        Me.rbProduction.Text = "Producción"
        Me.rbProduction.UseVisualStyleBackColor = True
        '
        'GroupControl1  (Credenciales)
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtTenantID)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtClientID)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtClientSecret)
        Me.GroupControl1.Controls.Add(Me.spVerClientSecret)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtSubscriptionKey)
        Me.GroupControl1.Controls.Add(Me.spVerSuscription)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 136)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(614, 144)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Credenciales MinSalud (entregadas por el Ministerio)"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tenant ID:"
        '
        'txtTenantID
        '
        Me.txtTenantID.Location = New System.Drawing.Point(150, 31)
        Me.txtTenantID.Name = "txtTenantID"
        Me.txtTenantID.Size = New System.Drawing.Size(410, 20)
        Me.txtTenantID.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Client ID:"
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(150, 58)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Size = New System.Drawing.Size(410, 20)
        Me.txtClientID.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 88)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Client Secret:"
        '
        'txtClientSecret
        '
        Me.txtClientSecret.Location = New System.Drawing.Point(150, 85)
        Me.txtClientSecret.Name = "txtClientSecret"
        Me.txtClientSecret.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClientSecret.Size = New System.Drawing.Size(410, 20)
        Me.txtClientSecret.TabIndex = 5
        '
        'spVerClientSecret
        '
        Me.spVerClientSecret.ImageOptions.SvgImage = CType(resources.GetObject("spVerClientSecret.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.spVerClientSecret.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.spVerClientSecret.Location = New System.Drawing.Point(566, 84)
        Me.spVerClientSecret.Name = "spVerClientSecret"
        Me.spVerClientSecret.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.spVerClientSecret.Size = New System.Drawing.Size(30, 22)
        Me.spVerClientSecret.TabIndex = 6
        Me.spVerClientSecret.ToolTip = "Mostrar / ocultar"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(16, 115)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Llave de suscripción:"
        '
        'txtSubscriptionKey
        '
        Me.txtSubscriptionKey.Location = New System.Drawing.Point(150, 112)
        Me.txtSubscriptionKey.Name = "txtSubscriptionKey"
        Me.txtSubscriptionKey.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSubscriptionKey.Size = New System.Drawing.Size(410, 20)
        Me.txtSubscriptionKey.TabIndex = 8
        Me.txtSubscriptionKey.ToolTip = "Ocp-Apim-Subscription-Key"
        '
        'spVerSuscription
        '
        Me.spVerSuscription.ImageOptions.SvgImage = CType(resources.GetObject("spVerSuscription.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.spVerSuscription.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.spVerSuscription.Location = New System.Drawing.Point(566, 111)
        Me.spVerSuscription.Name = "spVerSuscription"
        Me.spVerSuscription.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.spVerSuscription.Size = New System.Drawing.Size(30, 22)
        Me.spVerSuscription.TabIndex = 9
        Me.spVerSuscription.ToolTip = "Mostrar / ocultar"
        '
        'GroupControl2  (Direcciones)
        '
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.txtURLAuth)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.txtURLBaseApi)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 290)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(614, 92)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Direcciones del servicio"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(16, 34)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "URL de autorización:"
        '
        'txtURLAuth
        '
        Me.txtURLAuth.Location = New System.Drawing.Point(150, 31)
        Me.txtURLAuth.Name = "txtURLAuth"
        Me.txtURLAuth.Size = New System.Drawing.Size(446, 20)
        Me.txtURLAuth.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 61)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl5.TabIndex = 2
        Me.LabelControl5.Text = "URL base de la API:"
        '
        'txtURLBaseApi
        '
        Me.txtURLBaseApi.Location = New System.Drawing.Point(150, 58)
        Me.txtURLBaseApi.Name = "txtURLBaseApi"
        Me.txtURLBaseApi.Size = New System.Drawing.Size(446, 20)
        Me.txtURLBaseApi.TabIndex = 3
        '
        'xtPruebas
        '
        Me.xtPruebas.Controls.Add(Me.lblPruebasInfo)
        Me.xtPruebas.Controls.Add(Me.spEnviarRDAPrueba)
        Me.xtPruebas.Controls.Add(Me.spEnviarRDAConsultaPrueba)
        Me.xtPruebas.Name = "xtPruebas"
        Me.xtPruebas.Size = New System.Drawing.Size(638, 403)
        Me.xtPruebas.Text = "Pruebas (sandbox)"
        '
        'lblPruebasInfo
        '
        Me.lblPruebasInfo.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPruebasInfo.Appearance.Options.UseFont = True
        Me.lblPruebasInfo.Appearance.Options.UseTextOptions = True
        Me.lblPruebasInfo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblPruebasInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPruebasInfo.Location = New System.Drawing.Point(20, 18)
        Me.lblPruebasInfo.Name = "lblPruebasInfo"
        Me.lblPruebasInfo.Size = New System.Drawing.Size(596, 52)
        Me.lblPruebasInfo.TabIndex = 0
        Me.lblPruebasInfo.Text = "Envía documentos RDA con datos fijos de prueba al sandbox de MinSalud, usando la configuración guardada. Sirve para verificar credenciales y estructura sin firmar una historia real. Solo disponible en ambiente Sandbox."
        '
        'spEnviarRDAPrueba
        '
        Me.spEnviarRDAPrueba.Location = New System.Drawing.Point(20, 82)
        Me.spEnviarRDAPrueba.Name = "spEnviarRDAPrueba"
        Me.spEnviarRDAPrueba.Size = New System.Drawing.Size(300, 32)
        Me.spEnviarRDAPrueba.TabIndex = 1
        Me.spEnviarRDAPrueba.Text = "Enviar RDA-Paciente de prueba"
        '
        'spEnviarRDAConsultaPrueba
        '
        Me.spEnviarRDAConsultaPrueba.Location = New System.Drawing.Point(20, 124)
        Me.spEnviarRDAConsultaPrueba.Name = "spEnviarRDAConsultaPrueba"
        Me.spEnviarRDAConsultaPrueba.Size = New System.Drawing.Size(300, 32)
        Me.spEnviarRDAConsultaPrueba.TabIndex = 2
        Me.spEnviarRDAConsultaPrueba.Text = "Enviar RDA-Consulta Externa de prueba"
        '
        'frmRDA
        '
        Me.AcceptButton = Me.spGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.spCancelar
        Me.ClientSize = New System.Drawing.Size(640, 552)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.pnlEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = CType(resources.GetObject("frmRDA.IconOptions.Image"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRDA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interoperabilidad RDA - MinSalud"
        CType(Me.pnlEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEncabezado.ResumeLayout(False)
        Me.pnlEncabezado.PerformLayout()
        CType(Me.pnlBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotones.ResumeLayout(False)
        Me.pnlBotones.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtConexion.ResumeLayout(False)
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtURLAuth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtURLBaseApi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtTenantID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientSecret.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubscriptionKey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtCodigoPrestadorReps.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNitPrestador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtPruebas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEncabezado As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlBotones As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lnkHistorial As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtConexion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtPruebas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNombrePrestador As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoPrestadorReps As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNitPrestador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPruebasInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spEnviarRDAPrueba As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents spEnviarRDAConsultaPrueba As DevExpress.XtraEditors.SimpleButton
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

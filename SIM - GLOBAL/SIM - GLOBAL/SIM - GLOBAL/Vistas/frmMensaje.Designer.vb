<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMensaje))
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lcNumeroOrden = New DevExpress.XtraEditors.LabelControl()
        Me.lblCodigoR = New DevExpress.XtraEditors.LabelControl()
        Me.lblCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(92, 149)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(90, 20)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(92, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Consecutivo:"
        '
        'lcNumeroOrden
        '
        Me.lcNumeroOrden.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcNumeroOrden.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lcNumeroOrden.Appearance.Options.UseFont = True
        Me.lcNumeroOrden.Appearance.Options.UseForeColor = True
        Me.lcNumeroOrden.Appearance.Options.UseTextOptions = True
        Me.lcNumeroOrden.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lcNumeroOrden.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lcNumeroOrden.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lcNumeroOrden.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.BottomCenter
        Me.lcNumeroOrden.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.lcNumeroOrden.Location = New System.Drawing.Point(22, 42)
        Me.lcNumeroOrden.Name = "lcNumeroOrden"
        Me.lcNumeroOrden.Size = New System.Drawing.Size(238, 33)
        Me.lcNumeroOrden.TabIndex = 2
        Me.lcNumeroOrden.Text = "88888888888888"
        '
        'lblCodigoR
        '
        Me.lblCodigoR.Location = New System.Drawing.Point(42, 91)
        Me.lblCodigoR.Name = "lblCodigoR"
        Me.lblCodigoR.Size = New System.Drawing.Size(177, 13)
        Me.lblCodigoR.TabIndex = 3
        Me.lblCodigoR.Text = "Codigo para descarga de resultados:"
        Me.lblCodigoR.Visible = False
        '
        'lblCodigo
        '
        Me.lblCodigo.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblCodigo.Appearance.Options.UseFont = True
        Me.lblCodigo.Appearance.Options.UseForeColor = True
        Me.lblCodigo.Appearance.Options.UseTextOptions = True
        Me.lblCodigo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCodigo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCodigo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lblCodigo.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.BottomCenter
        Me.lblCodigo.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.lblCodigo.Location = New System.Drawing.Point(22, 110)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(238, 33)
        Me.lblCodigo.TabIndex = 4
        Me.lblCodigo.Text = "88888888888888"
        Me.lblCodigo.Visible = False
        '
        'frmMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 189)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.lblCodigoR)
        Me.Controls.Add(Me.lcNumeroOrden)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Orden"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lcNumeroOrden As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCodigoR As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCodigo As DevExpress.XtraEditors.LabelControl
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguridad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeguridad))
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtContrasenaActual = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtContrasenaNueva = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConfirmarContrasena = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEnviar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtContrasenaActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContrasenaNueva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConfirmarContrasena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Herramientas"
        '
        'txtContrasenaActual
        '
        Me.txtContrasenaActual.Location = New System.Drawing.Point(18, 73)
        Me.txtContrasenaActual.Name = "txtContrasenaActual"
        Me.txtContrasenaActual.Properties.UseSystemPasswordChar = True
        Me.txtContrasenaActual.Size = New System.Drawing.Size(216, 20)
        Me.txtContrasenaActual.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(149, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Confirme su Contraseña Actual"
        '
        'txtContrasenaNueva
        '
        Me.txtContrasenaNueva.Location = New System.Drawing.Point(18, 118)
        Me.txtContrasenaNueva.Name = "txtContrasenaNueva"
        Me.txtContrasenaNueva.Properties.UseSystemPasswordChar = True
        Me.txtContrasenaNueva.Size = New System.Drawing.Size(216, 20)
        Me.txtContrasenaNueva.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 99)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(141, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Ingrese la Nueva Contraseña"
        '
        'txtConfirmarContrasena
        '
        Me.txtConfirmarContrasena.Location = New System.Drawing.Point(18, 163)
        Me.txtConfirmarContrasena.Name = "txtConfirmarContrasena"
        Me.txtConfirmarContrasena.Properties.UseSystemPasswordChar = True
        Me.txtConfirmarContrasena.Size = New System.Drawing.Size(216, 20)
        Me.txtConfirmarContrasena.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(18, 144)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Confirmar Contraseña:"
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(18, 193)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 9
        Me.btnEnviar.Text = "Enviar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(18, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(172, 19)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Cambiar Contraseña:"
        '
        'frmSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 230)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtConfirmarContrasena)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtContrasenaNueva)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtContrasenaActual)
        Me.Controls.Add(Me.LabelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeguridad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguridad de Sistema"
        CType(Me.txtContrasenaActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContrasenaNueva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConfirmarContrasena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtContrasenaActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContrasenaNueva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConfirmarContrasena As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEnviar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class

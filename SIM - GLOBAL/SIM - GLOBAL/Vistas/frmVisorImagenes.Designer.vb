<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVisorImagenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisorImagenes))
        Me.isImagenes = New DevExpress.XtraEditors.Controls.ImageSlider()
        CType(Me.isImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'isImagenes
        '
        Me.isImagenes.Appearance.Options.UseImage = True
        Me.isImagenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.isImagenes.Location = New System.Drawing.Point(0, 0)
        Me.isImagenes.Name = "isImagenes"
        Me.isImagenes.ScrollButtonVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.isImagenes.Size = New System.Drawing.Size(868, 434)
        Me.isImagenes.TabIndex = 0
        Me.isImagenes.Text = "ImageSlider1"
        '
        'frmVisorImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 434)
        Me.Controls.Add(Me.isImagenes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVisorImagenes"
        Me.Text = "Visor de Imagenes"
        CType(Me.isImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents isImagenes As DevExpress.XtraEditors.Controls.ImageSlider
End Class

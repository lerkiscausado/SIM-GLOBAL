<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRipsJson
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
        Me.sbJSON = New DevExpress.XtraEditors.SimpleButton()
        Me.txtJSON = New DevExpress.XtraEditors.MemoEdit()
        Me.txtFactura = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtJSON.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sbJSON
        '
        Me.sbJSON.Location = New System.Drawing.Point(12, 12)
        Me.sbJSON.Name = "sbJSON"
        Me.sbJSON.Size = New System.Drawing.Size(95, 23)
        Me.sbJSON.TabIndex = 0
        Me.sbJSON.Text = "Generar JSON"
        '
        'txtJSON
        '
        Me.txtJSON.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJSON.Location = New System.Drawing.Point(12, 41)
        Me.txtJSON.Name = "txtJSON"
        Me.txtJSON.Size = New System.Drawing.Size(579, 183)
        Me.txtJSON.TabIndex = 1
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(113, 14)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtFactura.TabIndex = 2
        '
        'frmRipsJson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 241)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.txtJSON)
        Me.Controls.Add(Me.sbJSON)
        Me.Name = "frmRipsJson"
        Me.Text = "frmRipsJson"
        CType(Me.txtJSON.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sbJSON As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtJSON As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
End Class

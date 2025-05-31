<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPDF
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
        Me.PdfAdjuntos = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.SuspendLayout()
        '
        'PdfAdjuntos
        '
        Me.PdfAdjuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PdfAdjuntos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfAdjuntos.Location = New System.Drawing.Point(0, 0)
        Me.PdfAdjuntos.Name = "PdfAdjuntos"
        Me.PdfAdjuntos.Size = New System.Drawing.Size(807, 534)
        Me.PdfAdjuntos.TabIndex = 3
        Me.PdfAdjuntos.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToVisible
        '
        'frmPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 534)
        Me.Controls.Add(Me.PdfAdjuntos)
        Me.Name = "frmPDF"
        Me.Text = "Vista Previa"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PdfAdjuntos As DevExpress.XtraPdfViewer.PdfViewer
End Class

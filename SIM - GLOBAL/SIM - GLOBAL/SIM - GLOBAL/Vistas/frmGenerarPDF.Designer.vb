<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarPDF
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaInicial = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaFinal = New DevExpress.XtraEditors.DateEdit()
        Me.btGenerarPDF = New System.Windows.Forms.Button()
        Me.pbPDFs = New System.Windows.Forms.ProgressBar()
        CType(Me.dtFechaInicial.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 90
        Me.LabelControl2.Text = "Fecha Inicial:"
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.EditValue = Nothing
        Me.dtFechaInicial.Location = New System.Drawing.Point(82, 24)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaInicial.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaInicial.Size = New System.Drawing.Size(143, 20)
        Me.dtFechaInicial.TabIndex = 89
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(246, 27)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl1.TabIndex = 92
        Me.LabelControl1.Text = "Fecha Final:"
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.EditValue = Nothing
        Me.dtFechaFinal.Location = New System.Drawing.Point(313, 24)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFinal.Size = New System.Drawing.Size(143, 20)
        Me.dtFechaFinal.TabIndex = 91
        '
        'btGenerarPDF
        '
        Me.btGenerarPDF.Location = New System.Drawing.Point(213, 85)
        Me.btGenerarPDF.Name = "btGenerarPDF"
        Me.btGenerarPDF.Size = New System.Drawing.Size(75, 23)
        Me.btGenerarPDF.TabIndex = 226
        Me.btGenerarPDF.Text = "Generar"
        Me.btGenerarPDF.UseVisualStyleBackColor = True
        '
        'pbPDFs
        '
        Me.pbPDFs.Location = New System.Drawing.Point(164, 124)
        Me.pbPDFs.Name = "pbPDFs"
        Me.pbPDFs.Size = New System.Drawing.Size(179, 23)
        Me.pbPDFs.TabIndex = 227
        Me.pbPDFs.Value = 1
        '
        'frmGenerarPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 170)
        Me.Controls.Add(Me.pbPDFs)
        Me.Controls.Add(Me.btGenerarPDF)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.dtFechaFinal)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.dtFechaInicial)
        Me.Name = "frmGenerarPDF"
        Me.Text = "frmGenerarPDF"
        CType(Me.dtFechaInicial.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btGenerarPDF As Button
    Friend WithEvents pbPDFs As ProgressBar
End Class

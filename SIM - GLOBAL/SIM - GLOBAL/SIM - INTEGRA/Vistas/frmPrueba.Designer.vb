<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrueba
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.pbRegistros = New System.Windows.Forms.ProgressBar()
        Me.gcTemporal = New DevExpress.XtraGrid.GridControl()
        Me.gvTemporal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.gcTemporal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTemporal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(473, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "insertar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(361, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registros No.:"
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.lblRegistros.Location = New System.Drawing.Point(443, 107)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(125, 33)
        Me.lblRegistros.TabIndex = 2
        Me.lblRegistros.Text = "Registros"
        '
        'pbRegistros
        '
        Me.pbRegistros.Location = New System.Drawing.Point(364, 162)
        Me.pbRegistros.Name = "pbRegistros"
        Me.pbRegistros.Size = New System.Drawing.Size(384, 23)
        Me.pbRegistros.Step = 1
        Me.pbRegistros.TabIndex = 3
        '
        'gcTemporal
        '
        Me.gcTemporal.Location = New System.Drawing.Point(36, 303)
        Me.gcTemporal.MainView = Me.gvTemporal
        Me.gcTemporal.Name = "gcTemporal"
        Me.gcTemporal.Size = New System.Drawing.Size(878, 200)
        Me.gcTemporal.TabIndex = 4
        Me.gcTemporal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTemporal})
        '
        'gvTemporal
        '
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Expression = "ACTIVO"
        FormatConditionRuleValue1.Value1 = "ACTIVO"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.gvTemporal.FormatRules.Add(GridFormatRule1)
        Me.gvTemporal.GridControl = Me.gcTemporal
        Me.gvTemporal.Name = "gvTemporal"
        Me.gvTemporal.OptionsView.ColumnAutoWidth = False
        '
        'frmPrueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 518)
        Me.Controls.Add(Me.gcTemporal)
        Me.Controls.Add(Me.pbRegistros)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmPrueba"
        Me.Text = "frmPrueba"
        CType(Me.gcTemporal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTemporal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRegistros As Label
    Friend WithEvents pbRegistros As ProgressBar
    Friend WithEvents gcTemporal As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTemporal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prueba2imagenes
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.peImagen = New DevExpress.XtraEditors.PictureEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.MemoEdit()
        Me.wbHtml = New System.Windows.Forms.WebBrowser()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.cboHora = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        CType(Me.peImagen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(738, 44)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'peImagen
        '
        Me.peImagen.Location = New System.Drawing.Point(365, 44)
        Me.peImagen.Name = "peImagen"
        Me.peImagen.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peImagen.Size = New System.Drawing.Size(100, 96)
        Me.peImagen.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(12, 181)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigo.Properties.Appearance.Options.UseFont = True
        Me.txtCodigo.Size = New System.Drawing.Size(373, 251)
        Me.txtCodigo.TabIndex = 96
        '
        'wbHtml
        '
        Me.wbHtml.Location = New System.Drawing.Point(484, 182)
        Me.wbHtml.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbHtml.Name = "wbHtml"
        Me.wbHtml.Size = New System.Drawing.Size(355, 250)
        Me.wbHtml.TabIndex = 98
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(403, 182)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 99
        Me.SimpleButton2.Text = "SimpleButton2"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(30, 134)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 100
        Me.SimpleButton3.Text = "SimpleButton3"
        '
        'cboHora
        '
        Me.cboHora.Location = New System.Drawing.Point(30, 91)
        Me.cboHora.Name = "cboHora"
        Me.cboHora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHora.Properties.Items.AddRange(New Object() {"15", "20", "30", "60"})
        Me.cboHora.Properties.PopupFormSize = New System.Drawing.Size(600, 0)
        Me.cboHora.Properties.PopupSizeable = True
        Me.cboHora.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboHora.Size = New System.Drawing.Size(136, 20)
        Me.cboHora.TabIndex = 103
        '
        'ChartControl1
        '
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(529, 28)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.Size = New System.Drawing.Size(300, 200)
        Me.ChartControl1.TabIndex = 104
        '
        'prueba2imagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 444)
        Me.Controls.Add(Me.ChartControl1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.wbHtml)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.peImagen)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cboHora)
        Me.Name = "prueba2imagenes"
        Me.Text = "prueba2imagenes"
        CType(Me.peImagen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents peImagen As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents wbHtml As WebBrowser
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboHora As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
End Class

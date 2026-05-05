<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrueba3
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
        Me.components = New System.ComponentModel.Container()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPass = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClienteID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLlave = New DevExpress.XtraEditors.TextEdit()
        Me.sbConectar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtToken = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcFacturas = New DevExpress.XtraGrid.GridControl()
        Me.gvFacturas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pdfFactura = New DevExpress.XtraPdfViewer.PdfViewer()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClienteID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLlave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToken.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gcFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(103, 26)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(233, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(34, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Usuario"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(34, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "contraseña"
        '
        'txtPass
        '
        Me.txtPass.Enabled = False
        Me.txtPass.Location = New System.Drawing.Point(103, 52)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(233, 20)
        Me.txtPass.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(362, 29)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Cliente ID"
        '
        'txtClienteID
        '
        Me.txtClienteID.Enabled = False
        Me.txtClienteID.Location = New System.Drawing.Point(431, 26)
        Me.txtClienteID.Name = "txtClienteID"
        Me.txtClienteID.Size = New System.Drawing.Size(233, 20)
        Me.txtClienteID.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(362, 55)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Llave Secreta"
        '
        'txtLlave
        '
        Me.txtLlave.Enabled = False
        Me.txtLlave.Location = New System.Drawing.Point(431, 52)
        Me.txtLlave.Name = "txtLlave"
        Me.txtLlave.Size = New System.Drawing.Size(233, 20)
        Me.txtLlave.TabIndex = 6
        '
        'sbConectar
        '
        Me.sbConectar.Location = New System.Drawing.Point(670, 50)
        Me.sbConectar.Name = "sbConectar"
        Me.sbConectar.Size = New System.Drawing.Size(75, 23)
        Me.sbConectar.TabIndex = 8
        Me.sbConectar.Text = "Conectar"
        '
        'txtToken
        '
        Me.txtToken.Location = New System.Drawing.Point(752, 22)
        Me.txtToken.Name = "txtToken"
        Me.txtToken.Size = New System.Drawing.Size(368, 51)
        Me.txtToken.TabIndex = 9
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 78)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1108, 476)
        Me.XtraTabControl1.TabIndex = 10
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcFacturas)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1106, 451)
        Me.XtraTabPage1.Text = "Facturas"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.pdfFactura)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1106, 451)
        Me.XtraTabPage2.Text = "Factura PDF"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1106, 451)
        Me.XtraTabPage3.Text = "XtraTabPage3"
        '
        'gcFacturas
        '
        Me.gcFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcFacturas.Location = New System.Drawing.Point(0, 0)
        Me.gcFacturas.MainView = Me.gvFacturas
        Me.gcFacturas.Name = "gcFacturas"
        Me.gcFacturas.Size = New System.Drawing.Size(1106, 451)
        Me.gcFacturas.TabIndex = 0
        Me.gcFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvFacturas})
        '
        'gvFacturas
        '
        Me.gvFacturas.GridControl = Me.gcFacturas
        Me.gvFacturas.Name = "gvFacturas"
        '
        'pdfFactura
        '
        Me.pdfFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfFactura.Location = New System.Drawing.Point(0, 0)
        Me.pdfFactura.Name = "pdfFactura"
        Me.pdfFactura.Size = New System.Drawing.Size(1106, 451)
        Me.pdfFactura.TabIndex = 0
        '
        'frmPrueba3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 566)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.sbConectar)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtLlave)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtClienteID)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtToken)
        Me.Name = "frmPrueba3"
        Me.Text = "frmPrueba3"
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClienteID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLlave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToken.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.gcFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClienteID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLlave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sbConectar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToken As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcFacturas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pdfFactura As DevExpress.XtraPdfViewer.PdfViewer
End Class

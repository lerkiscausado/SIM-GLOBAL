<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMail))
        Me.btnDescartar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAsunto = New DevExpress.XtraEditors.TextEdit()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.xtpConcepto = New DevExpress.XtraTab.XtraTabPage()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.xtpAdjunto = New DevExpress.XtraTab.XtraTabPage()
        Me.PDF = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnEnviar = New DevExpress.XtraEditors.SimpleButton()
        Me.xtcFactura = New DevExpress.XtraTab.XtraTabControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPara = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtAsunto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpConcepto.SuspendLayout()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpAdjunto.SuspendLayout()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcFactura.SuspendLayout()
        CType(Me.txtPara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDescartar
        '
        Me.btnDescartar.ImageOptions.Image = CType(resources.GetObject("btnDescartar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDescartar.Location = New System.Drawing.Point(495, 406)
        Me.btnDescartar.Name = "btnDescartar"
        Me.btnDescartar.Size = New System.Drawing.Size(87, 23)
        Me.btnDescartar.TabIndex = 243
        Me.btnDescartar.Text = "Descartar"
        '
        'txtAsunto
        '
        Me.txtAsunto.EnterMoveNextControl = True
        Me.txtAsunto.Location = New System.Drawing.Point(56, 42)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(614, 20)
        Me.txtAsunto.TabIndex = 238
        '
        'GridView11
        '
        Me.GridView11.Name = "GridView11"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(3, 3)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(651, 300)
        Me.txtConcepto.TabIndex = 210
        '
        'xtpConcepto
        '
        Me.xtpConcepto.Controls.Add(Me.txtConcepto)
        Me.xtpConcepto.Name = "xtpConcepto"
        Me.xtpConcepto.Size = New System.Drawing.Size(661, 295)
        Me.xtpConcepto.Text = "Concepto"
        '
        'GridView10
        '
        Me.GridView10.Name = "GridView10"
        '
        'xtpAdjunto
        '
        Me.xtpAdjunto.Controls.Add(Me.PDF)
        Me.xtpAdjunto.Name = "xtpAdjunto"
        Me.xtpAdjunto.Size = New System.Drawing.Size(661, 295)
        Me.xtpAdjunto.Text = "Adjunto"
        '
        'PDF
        '
        Me.PDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PDF.Location = New System.Drawing.Point(0, 0)
        Me.PDF.Name = "PDF"
        Me.PDF.NavigationPanePageVisibility = DevExpress.XtraPdfViewer.PdfNavigationPanePageVisibility.None
        Me.PDF.ReadOnly = True
        Me.PDF.ShowPrintStatusDialog = False
        Me.PDF.Size = New System.Drawing.Size(661, 295)
        Me.PDF.TabIndex = 0
        Me.PDF.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToVisible
        '
        'GridView9
        '
        Me.GridView9.Name = "GridView9"
        '
        'GridView8
        '
        Me.GridView8.Name = "GridView8"
        '
        'GridView7
        '
        Me.GridView7.Name = "GridView7"
        '
        'GridView6
        '
        Me.GridView6.Name = "GridView6"
        '
        'GridView5
        '
        Me.GridView5.Name = "GridView5"
        '
        'GridView4
        '
        Me.GridView4.Name = "GridView4"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'btnEnviar
        '
        Me.btnEnviar.ImageOptions.Image = CType(resources.GetObject("btnEnviar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEnviar.Location = New System.Drawing.Point(588, 406)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(87, 23)
        Me.btnEnviar.TabIndex = 242
        Me.btnEnviar.Text = "Enviar"
        '
        'xtcFactura
        '
        Me.xtcFactura.Location = New System.Drawing.Point(12, 78)
        Me.xtcFactura.Name = "xtcFactura"
        Me.xtcFactura.SelectedTabPage = Me.xtpConcepto
        Me.xtcFactura.Size = New System.Drawing.Size(663, 320)
        Me.xtcFactura.TabIndex = 241
        Me.xtcFactura.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpConcepto, Me.xtpAdjunto})
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(12, 45)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl13.TabIndex = 240
        Me.LabelControl13.Text = "Asunto:"
        '
        'txtPara
        '
        Me.txtPara.EnterMoveNextControl = True
        Me.txtPara.Location = New System.Drawing.Point(56, 12)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(614, 20)
        Me.txtPara.TabIndex = 237
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl12.TabIndex = 239
        Me.LabelControl12.Text = "Para:"
        '
        'frmMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 438)
        Me.Controls.Add(Me.btnDescartar)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.xtcFactura)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.LabelControl12)
        Me.IconOptions.Image = CType(resources.GetObject("frmMail.IconOptions.Image"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar Correo Electronico"
        CType(Me.txtAsunto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpConcepto.ResumeLayout(False)
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpAdjunto.ResumeLayout(False)
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcFactura.ResumeLayout(False)
        CType(Me.txtPara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDescartar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAsunto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents xtpConcepto As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents xtpAdjunto As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnEnviar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents xtcFactura As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PDF As DevExpress.XtraPdfViewer.PdfViewer
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImagenesCapturadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImagenesCapturadas))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.gcCapturadas = New DevExpress.XtraBars.Ribbon.GalleryControl()
        Me.GalleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
        Me.btnRemover = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.gcSeleccionadas = New DevExpress.XtraBars.Ribbon.GalleryControl()
        Me.GalleryControlClient2 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.peImagen = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.gcCapturadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcCapturadas.SuspendLayout()
        CType(Me.gcSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcSeleccionadas.SuspendLayout()
        CType(Me.peImagen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gcCapturadas)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.peImagen)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl8)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.btnRemover)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.btnAgregar)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.gcSeleccionadas)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1000, 609)
        Me.SplitContainerControl1.SplitterPosition = 365
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'gcCapturadas
        '
        Me.gcCapturadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcCapturadas.Controls.Add(Me.GalleryControlClient1)
        '
        '
        '
        Me.gcCapturadas.Gallery.CheckDrawMode = DevExpress.XtraBars.Ribbon.Gallery.CheckDrawMode.ImageAndText
        Me.gcCapturadas.Gallery.ImageSize = New System.Drawing.Size(100, 100)
        Me.gcCapturadas.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck
        Me.gcCapturadas.Gallery.ItemSize = New System.Drawing.Size(100, 100)
        Me.gcCapturadas.Gallery.ScaleImages = DevExpress.Utils.DefaultBoolean.[False]
        Me.gcCapturadas.Gallery.ShowItemText = True
        Me.gcCapturadas.Gallery.UseMaxImageSize = True
        Me.gcCapturadas.Location = New System.Drawing.Point(0, 14)
        Me.gcCapturadas.Name = "gcCapturadas"
        Me.gcCapturadas.Size = New System.Drawing.Size(361, 591)
        Me.gcCapturadas.TabIndex = 7
        Me.gcCapturadas.Text = "GalleryControl2"
        '
        'GalleryControlClient1
        '
        Me.GalleryControlClient1.GalleryControl = Me.gcCapturadas
        Me.GalleryControlClient1.Location = New System.Drawing.Point(2, 2)
        Me.GalleryControlClient1.Size = New System.Drawing.Size(340, 587)
        '
        'btnRemover
        '
        Me.btnRemover.ImageOptions.Image = CType(resources.GetObject("btnRemover.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRemover.Location = New System.Drawing.Point(6, 64)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(25, 23)
        Me.btnRemover.TabIndex = 6
        Me.btnRemover.Text = "Remover Imagenes"
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageOptions.Image = CType(resources.GetObject("btnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(6, 34)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(25, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Imagenes"
        '
        'gcSeleccionadas
        '
        Me.gcSeleccionadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcSeleccionadas.Controls.Add(Me.GalleryControlClient2)
        '
        '
        '
        Me.gcSeleccionadas.Gallery.CheckDrawMode = DevExpress.XtraBars.Ribbon.Gallery.CheckDrawMode.ImageAndText
        Me.gcSeleccionadas.Gallery.ImageSize = New System.Drawing.Size(100, 100)
        Me.gcSeleccionadas.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck
        Me.gcSeleccionadas.Gallery.ShowItemText = True
        Me.gcSeleccionadas.Location = New System.Drawing.Point(37, 435)
        Me.gcSeleccionadas.Name = "gcSeleccionadas"
        Me.gcSeleccionadas.Size = New System.Drawing.Size(581, 162)
        Me.gcSeleccionadas.TabIndex = 5
        Me.gcSeleccionadas.Text = "GalleryControl2"
        '
        'GalleryControlClient2
        '
        Me.GalleryControlClient2.GalleryControl = Me.gcSeleccionadas
        Me.GalleryControlClient2.Location = New System.Drawing.Point(2, 2)
        Me.GalleryControlClient2.Size = New System.Drawing.Size(560, 158)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(37, 416)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl1.TabIndex = 100
        Me.LabelControl1.Text = "Imagenes Seleccionadas"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(39, 15)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl8.TabIndex = 99
        Me.LabelControl8.Text = "Visor de Imagenes"
        '
        'peImagen
        '
        Me.peImagen.Location = New System.Drawing.Point(37, 34)
        Me.peImagen.Name = "peImagen"
        Me.peImagen.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peImagen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.peImagen.Size = New System.Drawing.Size(581, 376)
        Me.peImagen.TabIndex = 101
        '
        'frmImagenesCapturadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 609)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.IconOptions.Icon = CType(resources.GetObject("frmImagenesCapturadas.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmImagenesCapturadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imagenes Capturadas"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.gcCapturadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcCapturadas.ResumeLayout(False)
        CType(Me.gcSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcSeleccionadas.ResumeLayout(False)
        CType(Me.peImagen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcSeleccionadas As DevExpress.XtraBars.Ribbon.GalleryControl
    Friend WithEvents GalleryControlClient2 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    Friend WithEvents btnRemover As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcCapturadas As DevExpress.XtraBars.Ribbon.GalleryControl
    Friend WithEvents GalleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents peImagen As DevExpress.XtraEditors.PictureEdit
End Class

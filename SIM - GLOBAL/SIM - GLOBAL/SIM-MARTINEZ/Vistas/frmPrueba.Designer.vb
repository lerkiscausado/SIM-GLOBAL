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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrueba))
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.cboEscalaPrader = New DevExpress.XtraEditors.LookUpEdit()
        Me.peImagen = New DevExpress.XtraEditors.PictureEdit()
        Me.btVistaPrevia = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.cboEscalaPrader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peImagen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.cboEscalaPrader)
        Me.GroupControl5.Controls.Add(Me.peImagen)
        Me.GroupControl5.Location = New System.Drawing.Point(729, 178)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(115, 284)
        Me.GroupControl5.TabIndex = 71
        Me.GroupControl5.Text = "Escala de Prader"
        '
        'cboEscalaPrader
        '
        Me.cboEscalaPrader.Location = New System.Drawing.Point(5, 23)
        Me.cboEscalaPrader.Name = "cboEscalaPrader"
        Me.cboEscalaPrader.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEscalaPrader.Properties.NullText = ""
        Me.cboEscalaPrader.Properties.PopupSizeable = False
        Me.cboEscalaPrader.Size = New System.Drawing.Size(105, 20)
        Me.cboEscalaPrader.TabIndex = 15
        '
        'peImagen
        '
        Me.peImagen.Location = New System.Drawing.Point(5, 49)
        Me.peImagen.Name = "peImagen"
        Me.peImagen.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peImagen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peImagen.Size = New System.Drawing.Size(105, 230)
        Me.peImagen.TabIndex = 71
        '
        'btVistaPrevia
        '
        Me.btVistaPrevia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btVistaPrevia.ImageOptions.Image = CType(resources.GetObject("btVistaPrevia.ImageOptions.Image"), System.Drawing.Image)
        Me.btVistaPrevia.Location = New System.Drawing.Point(488, 138)
        Me.btVistaPrevia.Name = "btVistaPrevia"
        Me.btVistaPrevia.Size = New System.Drawing.Size(26, 23)
        Me.btVistaPrevia.TabIndex = 72
        Me.btVistaPrevia.Text = "Vista Previa Historias Clinicas"
        '
        'frmPrueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 486)
        Me.Controls.Add(Me.btVistaPrevia)
        Me.Controls.Add(Me.GroupControl5)
        Me.Name = "frmPrueba"
        Me.Text = "formulario de Prueba"
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.cboEscalaPrader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peImagen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboEscalaPrader As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents peImagen As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btVistaPrevia As DevExpress.XtraEditors.SimpleButton
End Class

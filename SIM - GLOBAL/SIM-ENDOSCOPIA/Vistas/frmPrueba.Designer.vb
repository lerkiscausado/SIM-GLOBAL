<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrueba
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager()
        Me.peFoto = New DevExpress.XtraEditors.PictureEdit()
        Me.peFoto2 = New DevExpress.XtraEditors.PictureEdit()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peFoto2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'peFoto
        '
        Me.peFoto.Location = New System.Drawing.Point(147, 63)
        Me.peFoto.Name = "peFoto"
        Me.peFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peFoto.Size = New System.Drawing.Size(126, 149)
        Me.peFoto.TabIndex = 35
        '
        'peFoto2
        '
        Me.peFoto2.Location = New System.Drawing.Point(410, 63)
        Me.peFoto2.Name = "peFoto2"
        Me.peFoto2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peFoto2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peFoto2.Size = New System.Drawing.Size(126, 149)
        Me.peFoto2.TabIndex = 36
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(232, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(398, 261)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmPrueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 543)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.peFoto2)
        Me.Controls.Add(Me.peFoto)
        Me.Name = "frmPrueba"
        Me.Text = "Form1"
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peFoto2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents peFoto As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents peFoto2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPruebaJson
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
        Me.sbPrueba = New DevExpress.XtraEditors.SimpleButton()
        Me.LblControlKey = New DevExpress.XtraEditors.LabelControl()
        Me.gcResponse = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtClave = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.spApi = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gcResponse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sbPrueba
        '
        Me.sbPrueba.Location = New System.Drawing.Point(428, 96)
        Me.sbPrueba.Name = "sbPrueba"
        Me.sbPrueba.Size = New System.Drawing.Size(83, 25)
        Me.sbPrueba.TabIndex = 0
        Me.sbPrueba.Text = "JSON"
        '
        'LblControlKey
        '
        Me.LblControlKey.Location = New System.Drawing.Point(12, 12)
        Me.LblControlKey.Name = "LblControlKey"
        Me.LblControlKey.Size = New System.Drawing.Size(66, 13)
        Me.LblControlKey.TabIndex = 1
        Me.LblControlKey.Text = "LabelControl1"
        '
        'gcResponse
        '
        Me.gcResponse.Location = New System.Drawing.Point(12, 153)
        Me.gcResponse.MainView = Me.GridView1
        Me.gcResponse.Name = "gcResponse"
        Me.gcResponse.Size = New System.Drawing.Size(749, 264)
        Me.gcResponse.TabIndex = 2
        Me.gcResponse.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.GridControl = Me.gcResponse
        Me.GridView1.Name = "GridView1"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.MinWidth = 22
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 48
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "IDENTIFICACION"
        Me.GridColumn2.FieldName = "identificacion"
        Me.GridColumn2.MinWidth = 22
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 927
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(229, 36)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(203, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(229, 62)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(203, 20)
        Me.txtClave.TabIndex = 4
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(547, 96)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(83, 25)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "prueba"
        '
        'spApi
        '
        Me.spApi.Location = New System.Drawing.Point(268, 122)
        Me.spApi.Name = "spApi"
        Me.spApi.Size = New System.Drawing.Size(83, 25)
        Me.spApi.TabIndex = 6
        Me.spApi.Text = "API"
        '
        'frmPruebaJson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 478)
        Me.Controls.Add(Me.spApi)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.gcResponse)
        Me.Controls.Add(Me.LblControlKey)
        Me.Controls.Add(Me.sbPrueba)
        Me.Name = "frmPruebaJson"
        Me.Text = "frmPruebaJson"
        CType(Me.gcResponse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sbPrueba As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LblControlKey As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcResponse As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spApi As DevExpress.XtraEditors.SimpleButton
End Class

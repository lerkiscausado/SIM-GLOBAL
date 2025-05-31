<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelacionCitas
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
        Me.txtPaciente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMotivo = New DevExpress.XtraEditors.TextEdit()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cboMotivo = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.txtPaciente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPaciente
        '
        Me.txtPaciente.Location = New System.Drawing.Point(116, 9)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPaciente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtPaciente.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtPaciente.Properties.Appearance.Options.UseBackColor = True
        Me.txtPaciente.Properties.Appearance.Options.UseFont = True
        Me.txtPaciente.Properties.Appearance.Options.UseForeColor = True
        Me.txtPaciente.Properties.ReadOnly = True
        Me.txtPaciente.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPaciente.Size = New System.Drawing.Size(369, 30)
        Me.txtPaciente.TabIndex = 223
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(12, 18)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(88, 23)
        Me.LabelControl9.TabIndex = 222
        Me.LabelControl9.Text = "Paciente:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(39, 53)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 23)
        Me.LabelControl5.TabIndex = 256
        Me.LabelControl5.Text = "Motivo:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(57, 87)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 23)
        Me.LabelControl1.TabIndex = 258
        Me.LabelControl1.Text = "Otro:"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(116, 90)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMotivo.Properties.Appearance.Options.UseBackColor = True
        Me.txtMotivo.Size = New System.Drawing.Size(369, 20)
        Me.txtMotivo.TabIndex = 259
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(166, 126)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(105, 26)
        Me.btnAceptar.TabIndex = 260
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(287, 126)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 26)
        Me.btnCancelar.TabIndex = 261
        Me.btnCancelar.Text = "Cancelar"
        '
        'cboMotivo
        '
        Me.cboMotivo.Location = New System.Drawing.Point(116, 56)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMotivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMotivo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION")})
        Me.cboMotivo.Properties.NullText = ""
        Me.cboMotivo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboMotivo.Properties.PopupWidth = 600
        Me.cboMotivo.Properties.ShowHeader = False
        Me.cboMotivo.Size = New System.Drawing.Size(369, 20)
        Me.cboMotivo.TabIndex = 262
        '
        'frmCancelacionCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 174)
        Me.Controls.Add(Me.cboMotivo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtPaciente)
        Me.Controls.Add(Me.LabelControl9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCancelacionCitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelación de Cita"
        CType(Me.txtPaciente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPaciente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMotivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboMotivo As DevExpress.XtraEditors.LookUpEdit
End Class

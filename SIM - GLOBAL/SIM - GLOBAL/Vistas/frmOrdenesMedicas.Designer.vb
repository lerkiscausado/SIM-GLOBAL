<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenesMedicas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenesMedicas))
        Me.sbHistoria = New DevExpress.XtraEditors.SimpleButton()
        Me.sbLaboratorios = New DevExpress.XtraEditors.SimpleButton()
        Me.sbProcedimientos = New DevExpress.XtraEditors.SimpleButton()
        Me.sbMedicamentos = New DevExpress.XtraEditors.SimpleButton()
        Me.sbImagenes = New DevExpress.XtraEditors.SimpleButton()
        Me.sbCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'sbHistoria
        '
        Me.sbHistoria.ImageOptions.Image = CType(resources.GetObject("sbHistoria.ImageOptions.Image"), System.Drawing.Image)
        Me.sbHistoria.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.sbHistoria.Location = New System.Drawing.Point(12, 25)
        Me.sbHistoria.Name = "sbHistoria"
        Me.sbHistoria.Size = New System.Drawing.Size(88, 71)
        Me.sbHistoria.TabIndex = 0
        Me.sbHistoria.Text = "Historia Clinica"
        '
        'sbLaboratorios
        '
        Me.sbLaboratorios.ImageOptions.Image = CType(resources.GetObject("sbLaboratorios.ImageOptions.Image"), System.Drawing.Image)
        Me.sbLaboratorios.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.sbLaboratorios.Location = New System.Drawing.Point(106, 25)
        Me.sbLaboratorios.Name = "sbLaboratorios"
        Me.sbLaboratorios.Size = New System.Drawing.Size(88, 71)
        Me.sbLaboratorios.TabIndex = 1
        Me.sbLaboratorios.Text = "Laboratorios"
        '
        'sbProcedimientos
        '
        Me.sbProcedimientos.ImageOptions.Image = CType(resources.GetObject("sbProcedimientos.ImageOptions.Image"), System.Drawing.Image)
        Me.sbProcedimientos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.sbProcedimientos.Location = New System.Drawing.Point(200, 25)
        Me.sbProcedimientos.Name = "sbProcedimientos"
        Me.sbProcedimientos.Size = New System.Drawing.Size(88, 71)
        Me.sbProcedimientos.TabIndex = 2
        Me.sbProcedimientos.Text = "Procedimientos"
        '
        'sbMedicamentos
        '
        Me.sbMedicamentos.ImageOptions.Image = CType(resources.GetObject("sbMedicamentos.ImageOptions.Image"), System.Drawing.Image)
        Me.sbMedicamentos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.sbMedicamentos.Location = New System.Drawing.Point(106, 102)
        Me.sbMedicamentos.Name = "sbMedicamentos"
        Me.sbMedicamentos.Size = New System.Drawing.Size(88, 71)
        Me.sbMedicamentos.TabIndex = 3
        Me.sbMedicamentos.Text = "Medicamentos"
        '
        'sbImagenes
        '
        Me.sbImagenes.ImageOptions.Image = CType(resources.GetObject("sbImagenes.ImageOptions.Image"), System.Drawing.Image)
        Me.sbImagenes.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.sbImagenes.Location = New System.Drawing.Point(12, 102)
        Me.sbImagenes.Name = "sbImagenes"
        Me.sbImagenes.Size = New System.Drawing.Size(88, 71)
        Me.sbImagenes.TabIndex = 4
        Me.sbImagenes.Text = "Imagenes "
        '
        'sbCancelar
        '
        Me.sbCancelar.ImageOptions.Image = CType(resources.GetObject("sbCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.sbCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.sbCancelar.Location = New System.Drawing.Point(200, 102)
        Me.sbCancelar.Name = "sbCancelar"
        Me.sbCancelar.Size = New System.Drawing.Size(88, 71)
        Me.sbCancelar.TabIndex = 5
        Me.sbCancelar.Text = "Cancelar"
        '
        'frmOrdenesMedicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 187)
        Me.Controls.Add(Me.sbCancelar)
        Me.Controls.Add(Me.sbImagenes)
        Me.Controls.Add(Me.sbMedicamentos)
        Me.Controls.Add(Me.sbProcedimientos)
        Me.Controls.Add(Me.sbLaboratorios)
        Me.Controls.Add(Me.sbHistoria)
        Me.IconOptions.Image = CType(resources.GetObject("frmOrdenesMedicas.IconOptions.Image"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrdenesMedicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Historia y Ordenes Medicas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sbHistoria As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbLaboratorios As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbProcedimientos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbMedicamentos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbImagenes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbCancelar As DevExpress.XtraEditors.SimpleButton
End Class

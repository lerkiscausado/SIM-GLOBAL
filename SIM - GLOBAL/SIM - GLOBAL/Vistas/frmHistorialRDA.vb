Imports SIM___GLOBAL.Controles

''' <summary>
''' Pantalla de solo consulta: muestra el historial de envíos de RDA (tabla rda_envios),
''' con el paciente resuelto cuando es posible. Formulario autocontenido (sin archivo
''' .Designer.vb separado) para minimizar riesgo de edición manual del layout.
''' </summary>
Public Class frmHistorialRDA
    Inherits System.Windows.Forms.Form

    Private WithEvents grilla As New System.Windows.Forms.DataGridView()
    Private WithEvents btnActualizar As New DevExpress.XtraEditors.SimpleButton()
    Friend WithEvents GCConsultar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEXO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCorreoElectronico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCCosultarRDA As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVConsultarRDA As DevExpress.XtraGrid.Views.Grid.GridView
    Private lblResumen As New DevExpress.XtraEditors.LabelControl()

    Public Sub New()
        Me.Text = "Historial de envíos RDA"
        Me.Size = New System.Drawing.Size(1000, 600)
        Me.StartPosition = FormStartPosition.CenterScreen

        btnActualizar.Text = "Actualizar"
        btnActualizar.Location = New System.Drawing.Point(12, 12)
        btnActualizar.Size = New System.Drawing.Size(100, 28)

        lblResumen.Location = New System.Drawing.Point(124, 18)
        lblResumen.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        lblResumen.Size = New System.Drawing.Size(400, 16)



        Me.Controls.Add(btnActualizar)
        Me.Controls.Add(lblResumen)
        Me.Controls.Add(grilla)

        AddHandler Me.Load, AddressOf frmHistorialRDA_Load
    End Sub

    Private Sub frmHistorialRDA_Load(sender As Object, e As EventArgs)
        CargarDatos()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarDatos()
    End Sub

    Private Sub CargarDatos()
        Dim tabla As DataTable = DRDAPaciente.ListarEnvios()
        grilla.DataSource = tabla

        If tabla.Columns.Contains("fecha_envio") Then
            grilla.Columns("fecha_envio").HeaderText = "Fecha"
            grilla.Columns("fecha_envio").DisplayIndex = 0
        End If
        If tabla.Columns.Contains("tipo_documento") Then grilla.Columns("tipo_documento").HeaderText = "Tipo de documento"
        If tabla.Columns.Contains("exitoso") Then
            grilla.Columns("exitoso").HeaderText = "¿Exitoso?"
            For Each fila As DataGridViewRow In grilla.Rows
                If fila.Cells("exitoso").Value IsNot Nothing Then
                    Dim exitoso As Boolean = Convert.ToInt32(fila.Cells("exitoso").Value) = 1
                    fila.DefaultCellStyle.BackColor = If(exitoso, System.Drawing.Color.FromArgb(220, 255, 220), System.Drawing.Color.FromArgb(255, 225, 225))
                End If
            Next
        End If
        If tabla.Columns.Contains("codigo_http") Then grilla.Columns("codigo_http").HeaderText = "HTTP"
        If tabla.Columns.Contains("id_orden") Then grilla.Columns("id_orden").HeaderText = "Orden"
        If tabla.Columns.Contains("paciente") Then grilla.Columns("paciente").HeaderText = "Paciente"
        If tabla.Columns.Contains("detalle") Then grilla.Columns("detalle").HeaderText = "Detalle / Respuesta"

        If tabla.Columns.Contains("Error") Then
            lblResumen.Text = "No se pudo cargar el historial (¿ya corriste la migración rda_paciente_migracion.sql?)."
        Else
            Dim total As Integer = tabla.Rows.Count
            Dim exitosos As Integer = 0
            For Each fila As DataRow In tabla.Rows
                If Convert.ToInt32(fila("exitoso")) = 1 Then exitosos += 1
            Next
            lblResumen.Text = $"{total} envíos mostrados · {exitosos} exitosos · {total - exitosos} con error/aviso"
        End If
    End Sub

    Private Sub InitializeComponent()
        Me.GCCosultarRDA = New DevExpress.XtraGrid.GridControl()
        Me.GVConsultarRDA = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GCCosultarRDA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVConsultarRDA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCCosultarRDA
        '
        Me.GCCosultarRDA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCosultarRDA.Location = New System.Drawing.Point(0, 0)
        Me.GCCosultarRDA.MainView = Me.GVConsultarRDA
        Me.GCCosultarRDA.Name = "GCCosultarRDA"
        Me.GCCosultarRDA.Size = New System.Drawing.Size(931, 395)
        Me.GCCosultarRDA.TabIndex = 0
        Me.GCCosultarRDA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVConsultarRDA})
        '
        'GVConsultarRDA
        '
        Me.GVConsultarRDA.GridControl = Me.GCCosultarRDA
        Me.GVConsultarRDA.Name = "GVConsultarRDA"
        '
        'frmHistorialRDA
        '
        Me.ClientSize = New System.Drawing.Size(931, 395)
        Me.Controls.Add(Me.GCCosultarRDA)
        Me.Name = "frmHistorialRDA"
        CType(Me.GCCosultarRDA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVConsultarRDA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class

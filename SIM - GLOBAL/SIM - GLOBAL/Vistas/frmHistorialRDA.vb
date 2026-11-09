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
    Private WithEvents btnReenviar As New DevExpress.XtraEditors.SimpleButton()
    Private lblResumen As New DevExpress.XtraEditors.LabelControl()

    Public Sub New()
        Me.Text = "Historial de envíos RDA"
        Me.Size = New System.Drawing.Size(1000, 600)
        Me.StartPosition = FormStartPosition.CenterScreen

        btnActualizar.Text = "Actualizar"
        btnActualizar.Location = New System.Drawing.Point(12, 12)
        btnActualizar.Size = New System.Drawing.Size(100, 28)

        btnReenviar.Text = "Reenviar seleccionado"
        btnReenviar.Location = New System.Drawing.Point(118, 12)
        btnReenviar.Size = New System.Drawing.Size(140, 28)

        lblResumen.Location = New System.Drawing.Point(270, 18)
        lblResumen.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        lblResumen.Size = New System.Drawing.Size(400, 16)

        ' IMPORTANTE: sin este bloque la grilla queda con tamaño 0 (invisible) - se había
        ' borrado por accidente al abrir el formulario en el diseñador de Visual Studio.
        grilla.Location = New System.Drawing.Point(12, 48)
        grilla.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grilla.Size = New System.Drawing.Size(Me.ClientSize.Width - 24, Me.ClientSize.Height - 60)
        grilla.ReadOnly = True
        grilla.AllowUserToAddRows = False
        grilla.AllowUserToDeleteRows = False
        grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Me.Controls.Add(btnActualizar)
        Me.Controls.Add(btnReenviar)
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

    ''' <summary>
    ''' Reenvía el RDA de la fila seleccionada (RDA-Paciente o RDA-Consulta Externa) con los
    ''' datos actuales de la orden. Pensado para envíos que fallaron (ej. 400 por datos que
    ''' luego se corrigieron). El resultado queda como un nuevo registro en rda_envios.
    ''' </summary>
    Private Async Sub btnReenviar_Click(sender As Object, e As EventArgs) Handles btnReenviar.Click
        If grilla.CurrentRow Is Nothing OrElse Not grilla.Columns.Contains("id_orden") Then
            MessageBox.Show("Seleccione un envío de la lista.", "Reenviar RDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim idOrden As Integer = 0
        Integer.TryParse(Convert.ToString(grilla.CurrentRow.Cells("id_orden").Value), idOrden)
        Dim tipo As String = Convert.ToString(grilla.CurrentRow.Cells("tipo_documento").Value).Trim().ToUpperInvariant()
        If idOrden <= 0 Then Return

        Dim datos = DRDAPaciente.DatosParaReenvio(idOrden)
        If datos Is Nothing Then
            MessageBox.Show($"No se encontraron el paciente o el especialista de la orden {idOrden}.", "Reenviar RDA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show($"¿Reenviar {tipo} de la orden {idOrden}?", "Reenviar RDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        btnReenviar.Enabled = False
        Try
            Dim ok As Boolean
            If tipo = "RDA-PACIENTE" Then
                ok = Await DRDAPaciente.EnviarRDAPacienteAsync(idOrden, datos.Value.IdUsuario, datos.Value.IdEspecialista)
            Else
                ok = Await DRDAConsultaExterna.EnviarRDAConsultaExternaAsync(idOrden, datos.Value.IdUsuario, datos.Value.IdEspecialista,
                                                                            tipoPreferido:=datos.Value.TipoPreferido)
            End If
            CargarDatos()
            MessageBox.Show(If(ok, "✅ MinSalud aceptó el reenvío.", "❌ MinSalud rechazó el reenvío. Revise el detalle en la lista."),
                            "Reenviar RDA", MessageBoxButtons.OK, If(ok, MessageBoxIcon.Information, MessageBoxIcon.Warning))
        Finally
            btnReenviar.Enabled = True
        End Try
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
        If tabla.Columns.Contains("composition_id") Then
            grilla.Columns("composition_id").HeaderText = "Id Composition (MinSalud)"
            grilla.Columns("composition_id").DisplayIndex = grilla.Columns("id_orden").DisplayIndex + 1
        End If
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
End Class

''' <summary>
''' Notificación flotante no modal (tipo "toast") que muestra el progreso del envío del
''' RDA-Paciente. Se posiciona sola en la esquina inferior derecha de la pantalla, no
''' bloquea al médico, y se cierra sola unos segundos después de terminar.
''' Independiente del layout de cualquier formulario (evita el riesgo de agregarle
''' controles a formularios grandes y densos como frmHistoriaGL).
''' </summary>
Public Class frmToastRDA
    Inherits System.Windows.Forms.Form

    ' Lleva la cuenta de cuántas notificaciones están abiertas a la vez, para apilarlas
    ' verticalmente en vez de que se encimen unas sobre otras (ej. RDA-Paciente y
    ' RDA-Consulta Externa se envían juntos al firmar la historia).
    Private Shared _toastsAbiertos As New List(Of frmToastRDA)

    Private WithEvents lblTitulo As New DevExpress.XtraEditors.LabelControl()
    Private WithEvents lblEstado As New DevExpress.XtraEditors.LabelControl()
    Private WithEvents timerCierre As New System.Windows.Forms.Timer()

    Public Sub New()
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.StartPosition = FormStartPosition.Manual
        Me.Size = New System.Drawing.Size(340, 90)
        Me.Text = "Interoperabilidad RDA"

        lblTitulo.Text = "Interoperabilidad RDA"
        lblTitulo.Location = New System.Drawing.Point(12, 10)
        lblTitulo.Font = New System.Drawing.Font(lblTitulo.Font, System.Drawing.FontStyle.Bold)

        lblEstado.Text = "Iniciando..."
        lblEstado.Location = New System.Drawing.Point(12, 10)
        lblEstado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        lblEstado.Size = New System.Drawing.Size(310, 40)
        lblEstado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap

        'Me.Controls.Add(lblTitulo)
        Me.Controls.Add(lblEstado)

        Dim area As System.Drawing.Rectangle = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea
        Dim desplazamientoVertical As Integer = _toastsAbiertos.Count * (Me.Height + 8)
        Me.Location = New System.Drawing.Point(area.Right - Me.Width - 16, area.Bottom - Me.Height - 16 - desplazamientoVertical)
        _toastsAbiertos.Add(Me)

        timerCierre.Interval = 3000 ' 3 segundos
    End Sub

    ''' <summary>Actualiza el mensaje visible. Seguro de llamar desde el hilo de UI.</summary>
    Public Sub ActualizarEstado(mensaje As String)
        If Me.IsDisposed Then Exit Sub
        lblEstado.Text = mensaje
        lblEstado.Refresh() ' Fuerza el repintado inmediato (evita que el cierre por timer
                             ' "adelante" al repintado del mensaje final en pantallas lentas)
        Me.Refresh()

        ' Si el mensaje indica que ya terminó (éxito, error o aviso), programar el cierre
        ' automático en unos segundos para no dejar la notificación pegada en pantalla.
        If mensaje.StartsWith("✅") OrElse mensaje.StartsWith("❌") Then
            timerCierre.Start()
        End If
    End Sub

    Private Sub timerCierre_Tick(sender As Object, e As EventArgs) Handles timerCierre.Tick
        timerCierre.Stop()
        Me.Close()
    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        _toastsAbiertos.Remove(Me)
        MyBase.OnFormClosed(e)
    End Sub
End Class

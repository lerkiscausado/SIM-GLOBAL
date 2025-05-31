Imports SIM___GLOBAL.Controles
Public Class frmCancelacionCitas
    Public IdAgenda As String
    Public Dia As Date
    Public Licencia As String
    Dim _ds As DataSet
    Dim _CitasCanceladas As New SIM___GLOBAL.Modelo.CitasCanceladas
    Dim _DCitasCanceladas As New SIM___GLOBAL.Controles.DCitasCanceladas
    Dim _DAgenda As New SIM___GLOBAL.Controles.DAgenda

    Private Sub frmCancelacionCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar motivos de cancelación
        Dim _DMotivoCancelacionCita = New DMotivoCancelacionCita
        _ds = _DMotivoCancelacionCita.ListarCombo
        cboMotivo.Properties.DataSource = _ds.Tables(0)
        cboMotivo.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboMotivo.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

    End Sub

    Private Sub cboMotivo_EditValueChanged(sender As Object, e As EventArgs) Handles cboMotivo.EditValueChanged
        If cboMotivo.EditValue = 10 Then
            txtMotivo.Enabled = True
            txtMotivo.Text = ""
        Else
            txtMotivo.Enabled = False
            txtMotivo.Text = cboMotivo.Text
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cboMotivo.Text = "" Then
            MessageBox.Show("Debe Seleccionar el motivo", "Cancelar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Dia = Format(DateTime.Now, "dd/MM/yyyy") Then
                'If MessageBox.Show("¿Desea Cancelar la Cita?", "Cancelar Cita", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                _DAgenda.CancelarCita(IdAgenda)
                'End If
            Else
                'If MessageBox.Show("¿Desea liberar la Cita?", "Liberar Cita", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Select Case Licencia
                    Case 3
                        _DAgenda.CancelarCita(IdAgenda)
                    Case 4
                        _DAgenda.LiberarCita(IdAgenda)
                End Select

                'End If
            End If

            _CitasCanceladas.Id = Val("")
            _CitasCanceladas.IdAgenda = IdAgenda
            _CitasCanceladas.Fecha = Format(DateTime.Now, "dd/MM/yyyy")
            _CitasCanceladas.IdMotivo = cboMotivo.EditValue
            _CitasCanceladas.Motivo = txtMotivo.Text
            _CitasCanceladas.Estado = "A"
            _DCitasCanceladas.Guardar(_CitasCanceladas)
            MsgBox("La cita fue cancelada")
            Me.Close()
        End If

    End Sub
End Class
Imports AGORA.Controles
Public Class frmReservas
    Dim dReservas As New DReservas
    Dim ds As DataSet
    Private Sub frmReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar agenda del dia
        ds = dReservas.Listar()
        GCReservas.DataSource = ds.Tables(0)

        'Carar Salones
        Dim dSalones As New DSalones
        ds = dSalones.ListarCombo
        cboSalon.Properties.DataSource = ds.Tables(0)
        cboSalon.Properties.DisplayMember = ds.Tables(0).Columns(1).Caption
        cboSalon.Properties.ValueMember = ds.Tables(0).Columns(0).Caption


    End Sub

    Private Sub DNFecha_DateTimeChanged(sender As Object, e As EventArgs) Handles DNFecha.DateTimeChanged
        GCFecha.Text = "Fecha Actual: " & Format(DNFecha.DateTime, "D")
        'dtFecha.Text = DNFecha.DateTime
        'If cboMedico.Text <> "" Then
        ' LimpiarCampos()
        ' AgendaDia()
        ' '_ClickGrilla = ""

        'End If
    End Sub

    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        If GVReservas.RowCount <> 0 Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            Dim fechaReserva As Date = Format(DNFecha.DateTime)
            MsgBox(fechaReserva)
            'ImprimirFrm.ImprimirAgenda(Format(fechaReserva, "yyyy/MM/dd"), cboSalon.EditValue)
        Else
            MessageBox.Show("No existen reservas para este dia", "Imprimir Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
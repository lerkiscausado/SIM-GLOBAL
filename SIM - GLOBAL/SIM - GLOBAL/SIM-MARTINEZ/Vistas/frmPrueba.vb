Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.Modelo
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraCharts

Public Class frmPrueba
    Dim _dsEscalaPrader As DataSet
    Dim _dEscalaPrader As New DEscalaPrader

    Private Sub frmPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenamos COMBO Escala PRADER

        _dsEscalaPrader = New DataSet()
        _dsEscalaPrader = _dEscalaPrader.Listar()

        cboEscalaPrader.Properties.DataSource = _dsEscalaPrader.Tables(0)
        cboEscalaPrader.Properties.DisplayMember = _dsEscalaPrader.Tables(0).Columns(1).Caption
        cboEscalaPrader.Properties.ValueMember = _dsEscalaPrader.Tables(0).Columns(0).Caption

        cboEscalaPrader.ItemIndex = 4


    End Sub

    Private Sub btVistaPrevia_Click(sender As Object, e As EventArgs) Handles btVistaPrevia.Click
        'cboEscalaPrader.ItemIndex = cboEscalaPrader.Properties.GetDataSourceRowIndex("ID", txtPrimerNombre.Text)
    End Sub

    Private Sub cboEscalaPrader_EditValueChanged(sender As Object, e As EventArgs) Handles cboEscalaPrader.EditValueChanged
        peImagen.Image = _DEscalaPrader.imagen(cboEscalaPrader.EditValue)
    End Sub
End Class
Imports SIM___GLOBAL.Controles
Imports DevExpress.XtraGrid.Views.Grid
Imports ADOSPLAY.My.Controles

Public Class frmTorneos
    Dim _ClickGrilla As String
    Dim _Fila As String
    Dim _ds As DataSet
    ReadOnly _Organizador As New DOrganizador
    ReadOnly _Deportes As New DDeportes
    'ReadOnly _dDetalletarifa = New DDetalleTarifas
    Private Sub LlenarCombo()
        'llenamos cOMBO ORGANIZADOR
        _ds = New DataSet()
        _ds = _Organizador.Listar
        cboOrganizador.DataSource = _ds.Tables(0)
        cboOrganizador.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboOrganizador.ValueMember = _ds.Tables(0).Columns(0).Caption
        'llenamos COMBO DEPORTES
        _ds = New DataSet()
        _ds = _Deportes.Listar
        cboDeporte.DataSource = _ds.Tables(0)
        cboDeporte.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboDeporte.ValueMember = _ds.Tables(0).Columns(0).Caption


    End Sub
    Private Sub frmTorneos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSVistas.DTTorneos' Puede moverla o quitarla según sea necesario.
        Me.DTTorneosTableAdapter.Fill(Me.DSVistas.DTTorneos)
        LlenarCombo()
    End Sub
End Class
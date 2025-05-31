Public Class frmPrueba
    Dim _CargarHistoria As New DInsertar
    Dim _ds As DataSet

    Private Sub FrmPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ds = _CargarHistoria.Listar()
        lblRegistros.Text = _ds.Tables(0).Rows.Count
        pbRegistros.Maximum = _ds.Tables(0).Rows.Count
        'Dim _dCups = New SIM___GLOBAL.Controles.DCups
        'Dim _ds = New DataSet
        '_ds = _dCups.Listar
        gcTemporal.DataSource = _ds.Tables(0)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Do While i < _ds.Tables(0).Rows.Count
            lblRegistros.Text = i
            pbRegistros.Value = i
            _CargarHistoria.Guardar(_ds.Tables(0).Rows(i)(0).ToString(), _ds.Tables(0).Rows(i)(1).ToString())
            i = i + 1
        Loop
    End Sub
End Class
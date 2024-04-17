Public Class frmConsultar
    Public Licencia As String
    Public IdEmpleado As String
    Dim _dOrdenes = New PEC___App.Controles.DOrdenes
    Public Sub ActualizarGrilla(ByVal Ano As String)
        Try
            'TODO: esta línea de código carga datos en la tabla 'DSVistas.dtOrdenes' Puede moverla o quitarla según sea necesario.
            'Me.DTOrdenesTableAdapter.Fill(Me.DSVistas.DTOrdenes)
            Dim _ds = New DataSet
            _ds = _dOrdenes.listarestudios(Ano)
            GCConsultar.DataSource = _ds.Tables(0)
            'bwCargar.RunWorkerAsync()
            'ppCargar.Visible = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmConsultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla(Year(Now))
    End Sub
End Class
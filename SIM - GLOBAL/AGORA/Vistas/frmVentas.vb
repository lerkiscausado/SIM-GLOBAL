Public Class frmVentas
    Dim _DCuentasClientes = New SIM___GLOBAL.Controles.DCuentasClientes
    Public Sub ActualizarGrilla(ByVal Ano As String)
        Try
            Dim _ds = New DataSet
            _ds = _DCuentasClientes.Ordenesservicios(Ano)
            GCConsultar.DataSource = _ds.Tables(0)

        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla(Year(Now))
    End Sub
End Class
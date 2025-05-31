Public Class frmVentas
    Dim _ds As DataSet
    Dim Estado As String
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _dFacturas As New SIM___GLOBAL.Controles.DFacturas
    Public Licencia As String
    Public IdEmpleado As String
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Licencia
            Case 15 'Optica Freisem
                Try
                    Dim _ds = New DataSet
                    _ds = _dFacturas.ListarVentas
                    GCConsultar.DataSource = _ds.Tables(0)
                Catch ex As Exception
                End Try
            Case Else
        End Select
    End Sub
End Class
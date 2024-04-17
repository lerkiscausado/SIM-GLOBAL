Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DCitasCanceladas
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _CitasCanceladas As CitasCanceladas)
            Try
                Dim query As String
                query = "INSERT INTO citas_canceladas VALUES('" & _CitasCanceladas.Id & "', '" & Format(_CitasCanceladas.Fecha, "yyyy/MM/dd") & "'," _
                        & "'" & _CitasCanceladas.IdAgenda & "','" & _CitasCanceladas.IdMotivo & "','" & _CitasCanceladas.Motivo & "', " _
                        & "'" & _CitasCanceladas.Estado & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
    End Class

End Namespace

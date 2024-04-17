Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DCierreCaja
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _CierreCaja As CierreCaja)
            Try
                Dim query As String
                query = "INSERT INTO cierre_caja VALUES('','" & Format(_CierreCaja.Fecha, "yyyy/MM/dd") & "', " _
                            & "'" & Format(_CierreCaja.Hora, "HH:mm:ss") & "', " _
                            & "?, " _
                            & "'" & _CierreCaja.Observaciones & "', " _
                            & "'" & _CierreCaja.IdEmpleado & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_CierreCaja.Saldo))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function UltimoCierre() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT fecha, saldo FROM cierre_caja ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try

        End Function
    End Class

End Namespace

Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports System.Data.Common
Namespace Controles
    Public Class DCiudades
        Shared _conn As New OdbcConnection
        Shared _adapter As DataAdapter
        Shared _ds As DataSet
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ID, " _
                                        & "CIUDAD " _
                                        & "FROM ciudades WHERE estado='A'")
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


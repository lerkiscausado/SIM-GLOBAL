Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DPrivilegios
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function ListarMenu() As DataSet
            Try
                Dim query As String =
                                    String.Format("Select ID, NOMBRE from MENU")
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

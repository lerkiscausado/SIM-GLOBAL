Imports System.Data
Imports System.Data.Odbc
Namespace My.Controles
    Public Class ConexionODBC
        Public Shared Cadena As String
        Public Shared BdAdos As OdbcConnection

        Public Shared Function Open() As OdbcConnection
            Try
                Dim nuevaConexion As New OdbcConnection(Cadena) ' Nueva instancia siempre
                nuevaConexion.Open()
                Return nuevaConexion
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Sub Close(ByVal BdAdos As OdbcConnection)
            Try
                If BdAdos.State = ConnectionState.Open Then
                    BdAdos.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al cerrar la conexión: " & ex.Message)
            End Try
        End Sub
    End Class
End Namespace


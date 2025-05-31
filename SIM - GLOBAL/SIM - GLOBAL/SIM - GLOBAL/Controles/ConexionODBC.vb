Imports System.Data
Imports System.Data.Odbc
Namespace My.Controles
    Public Class ConexionODBC
        Public Shared Cadena As String
        Public Shared BdAdos As OdbcConnection

        Public Shared Function Open() As OdbcConnection
            Try
                BdAdos = New OdbcConnection(Cadena)
                BdAdos.Open()
                Return BdAdos
            Catch ex As Exception
                Close(BdAdos)
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
            Return BdAdos
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


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
            Catch ex As Exception
                Close(BdAdos)
                MessageBox.Show(ex.Message)
            End Try
            Return BdAdos
        End Function

        Public Shared Sub Close(ByVal BdAdos As OdbcConnection)
            Try
                If BdAdos.State = ConnectionState.Open Then
                    Try
                        BdAdos.Close()
                    Catch ex As Exception
                        MsgBox("Error" & ex.ToString)
                    End Try
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
    End Class
End Namespace


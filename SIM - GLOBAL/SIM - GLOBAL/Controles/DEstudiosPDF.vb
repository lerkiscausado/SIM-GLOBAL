Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DEstudiosPDF
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Existe(ByVal IdOrden As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM estudios_pdf WHERE id_orden='" & IdOrden & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                Dim reader As OdbcDataReader
                reader = comando.ExecuteReader()
                If reader.Read() Then
                    ConexionODBC.Close(_conn)
                    Return True
                Else
                    ConexionODBC.Close(_conn)
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return Nothing
        End Function
        Public Sub Guardar(ByVal _EstudiosPDF As EstudiosPDF)
            Try
                Dim query As String
                query = "insert into estudios_pdf values('','" & _EstudiosPDF.IdOrden & "')"
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


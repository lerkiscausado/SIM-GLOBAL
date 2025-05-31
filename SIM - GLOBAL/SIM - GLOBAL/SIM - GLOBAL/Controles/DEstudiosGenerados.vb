Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DEstudiosGenerados
        Shared _conn As New OdbcConnection
        'Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _EstudiosGenerados As SIM___GLOBAL.Modelo.EstudiosGenerados)
            Try
                Dim query As String
                query = "insert into estudios_generados values('" & _EstudiosGenerados.Id & "', " _
                            & "'" & _EstudiosGenerados.IdOrden & "', " _
                            & "'" & _EstudiosGenerados.IdDetalleOrden & "', " _
                            & "'" & Format(_EstudiosGenerados.Fecha, "yyyy/MM/dd") & "', " _
                            & "TIME_FORMAT(NOW( ) , '%H:%i:%s'), " _
                            & "'" & _EstudiosGenerados.Estudio & "', " _
                            & "'" & _EstudiosGenerados.IdEmpleado & "')"
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

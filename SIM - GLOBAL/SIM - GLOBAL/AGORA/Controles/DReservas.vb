Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports System.Data.Common
Namespace Controles
    Public Class DReservas
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT reservas.ID	,DATE_FORMAT(`reservas`.`HORA`,'%h:%i %p') AS HORA,clientes.nombre AS CLIENTE " _
                                        & ", reservas.EVENTO ,orden_servicio_agora.CONCEPTO	,reservas.ESTADO FROM  reservas " _
                                        & "INNER JOIN clientes ON (reservas.id_cliente=clientes.id)	INNER JOIN orden_servicio_agora ON (reservas.id_orden=orden_servicio_agora.id)")
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

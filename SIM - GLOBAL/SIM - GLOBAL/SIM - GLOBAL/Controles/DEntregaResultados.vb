Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DEntregaResultados
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdOrden As String) As EntregaResultados
            Try
                Dim query As String = String.Format("SELECT * FROM entrega_resultados WHERE id_orden='" & IdOrden & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _EntregaResultados = New EntregaResultados
                _EntregaResultados.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _EntregaResultados.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _EntregaResultados.FechaEntrega = _ds.Tables(0).Rows(0)(2).ToString()
                _EntregaResultados.TipoEstudio = _ds.Tables(0).Rows(0)(3).ToString()
                Return _EntregaResultados
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal IdOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM entrega_resultados WHERE id_orden='" & IdOrden & "'")
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
        Public Sub Guardar(ByVal _EntregaResultados As EntregaResultados)
            Try
                Dim query As String
                If Existe(_EntregaResultados.IdOrden) = True Then
                    query = "UPDATE entrega_resultados SET fecha_entrega='" & Format(_EntregaResultados.FechaEntrega, "yyyy/MM/dd") & "', " _
                            & "tipo_estudio='" & _EntregaResultados.TipoEstudio & "' where id_orden='" & _EntregaResultados.IdOrden & "'"
                Else
                    query = "insert into entrega_resultados values('0','" & _EntregaResultados.IdOrden & "', " _
                            & "'" & Format(_EntregaResultados.FechaEntrega, "yyyy/MM/dd") & "','" & _EntregaResultados.TipoEstudio & "')"
                End If

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


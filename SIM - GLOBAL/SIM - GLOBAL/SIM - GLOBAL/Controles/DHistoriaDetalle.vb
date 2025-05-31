Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DHistoriaDetalle
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        'ReadOnly _funciones As Funciones
        Public Shared Function Cargar(ByVal IdDetalleOrden As String) As HistoriaDetalle
            Try
                Dim query As String = String.Format("SELECT * FROM historia_detalle WHERE id_detalle_orden='" & IdDetalleOrden & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _HistoriaDetalle = New HistoriaDetalle
                _HistoriaDetalle.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _HistoriaDetalle.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _HistoriaDetalle.IdDetalleOrden = _ds.Tables(0).Rows(0)(2).ToString()
                _HistoriaDetalle.FuncionEscrotal = _ds.Tables(0).Rows(0)(3).ToString()
                _HistoriaDetalle.MicroPene = _ds.Tables(0).Rows(0)(4).ToString()
                _HistoriaDetalle.MeatusUretral = _ds.Tables(0).Rows(0)(5).ToString()
                _HistoriaDetalle.TesticuloIzquierdo = _ds.Tables(0).Rows(0)(6).ToString()
                _HistoriaDetalle.TesticuloDerecho = _ds.Tables(0).Rows(0)(7).ToString()
                _HistoriaDetalle.IdEscalaPrader = _ds.Tables(0).Rows(0)(8).ToString()
                Return _HistoriaDetalle
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal IdDetalleOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT ID FROM historia_detalle WHERE id_detalle_orden='" & IdDetalleOrden & "' ")
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
        Public Sub Guardar(ByVal _HistoriaDetalle As HistoriaDetalle)
            Try
                Dim query As String

                If Existe(_HistoriaDetalle.IdDetalleOrden) = True Then
                    'Actualizamos el Usuario
                    query = "UPDATE historia_detalle SET funcion_escrotal='" & _HistoriaDetalle.FuncionEscrotal & "', " _
                            & "micro_pene='" & _HistoriaDetalle.MicroPene & "', " _
                            & "meatus_uretral='" & _HistoriaDetalle.MeatusUretral & "'," _
                            & "testiculo_izquierdo='" & _HistoriaDetalle.TesticuloIzquierdo & "', " _
                            & "testiculo_derecho='" & _HistoriaDetalle.TesticuloDerecho & "', " _
                            & "id_escala_prader='" & _HistoriaDetalle.IdEscalaPrader & "' " _
                            & "WHERE id_detalle_orden='" & _HistoriaDetalle.IdDetalleOrden & "'"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)

                Else
                    query = "INSERT INTO historia_detalle VALUES('" & _HistoriaDetalle.Id & "','" & _HistoriaDetalle.IdOrden & "','" & _HistoriaDetalle.IdDetalleOrden & "', " _
                        & "'" & _HistoriaDetalle.FuncionEscrotal & "','" & _HistoriaDetalle.MicroPene & "','" & _HistoriaDetalle.MeatusUretral & "','" & _HistoriaDetalle.TesticuloIzquierdo & "'," _
                        & "'" & _HistoriaDetalle.TesticuloDerecho & "','" & _HistoriaDetalle.IdEscalaPrader & "')"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
    End Class

End Namespace

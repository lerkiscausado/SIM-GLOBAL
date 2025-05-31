Imports SIM_CITOPATO.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc

Namespace Controles
    Public Class DOrdenes
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Ordenes
            Try
                Dim query As String = String.Format("SELECT * FROM ordenes WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Ordenes = New Ordenes
                _Ordenes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Ordenes.IdUsuario = _ds.Tables(0).Rows(0)(1).ToString()
                _Ordenes.IdContrato = _ds.Tables(0).Rows(0)(2).ToString()
                _Ordenes.IdIngreso = _ds.Tables(0).Rows(0)(3).ToString()
                _Ordenes.IdSede = _ds.Tables(0).Rows(0)(4).ToString()
                _Ordenes.Autorizacion = _ds.Tables(0).Rows(0)(5).ToString()
                _Ordenes.NumeroOrden = _ds.Tables(0).Rows(0)(6).ToString()
                _Ordenes.FechaIngreso = _ds.Tables(0).Rows(0)(7).ToString()
                _Ordenes.FechaOrden = _ds.Tables(0).Rows(0)(8).ToString()
                _Ordenes.Hora = _ds.Tables(0).Rows(0)(9).ToString()
                _Ordenes.Idfactura = _ds.Tables(0).Rows(0)(10).ToString()
                _Ordenes.IdTipoAfiliado = _ds.Tables(0).Rows(0)(11).ToString()
                _Ordenes.IdTipoUsuario = _ds.Tables(0).Rows(0)(12).ToString()
                _Ordenes.IdTipoEstudio = _ds.Tables(0).Rows(0)(13).ToString()
                _Ordenes.Comentarios = _ds.Tables(0).Rows(0)(14).ToString()
                _Ordenes.Estado = _ds.Tables(0).Rows(0)(15).ToString()
                Return _Ordenes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM ordenes WHERE id='" & filtro & "'")
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
        Public Sub Guardar(ByVal _Ordenes As Ordenes)
            Try
                Dim query As String
                If Existe(_Ordenes.Id) = True Then
                    query = "UPDATE ordenes SET numero_orden='" & _Ordenes.NumeroOrden & "', " _
                           & "fecha_orden='" & Format(_Ordenes.FechaOrden, "yyyy/MM/dd") & "', autorizacion='" & _Ordenes.Autorizacion & "' " _
                           & "where id='" & _Ordenes.Id & "'"
                Else
                    query = "insert into ordenes values('" & _Ordenes.Id & "','" &
                            _Ordenes.IdUsuario & "','" & _Ordenes.IdContrato & "','" &
                            _Ordenes.IdIngreso & "','" & _Ordenes.IdSede & "','" & _Ordenes.Autorizacion & "', '" &
                            _Ordenes.NumeroOrden & "', '" & Format(_Ordenes.FechaIngreso, "yyyy/MM/dd") & "', '" & Format(_Ordenes.FechaOrden, "yyyy/MM/dd") & "','" & Format(_Ordenes.Hora, "hh:mm:ss") & "', '" &
                            _Ordenes.Idfactura & "','" & _Ordenes.IdTipoAfiliado & "','" & _Ordenes.IdTipoUsuario & "','" & _Ordenes.IdTipoEstudio & "','" & _Ordenes.Comentarios & "', '" & _Ordenes.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub AgregarOrdenes(ByVal _orden As String, ByVal _Factura As String)
            Try
                Dim query As String
                query = "UPDATE ordenes SET id_factura='" & _Factura & "' where id='" & _orden & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarPacientesAtender() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ordenes.ID AS ORDEN, " _
                                                  & "CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.segundo_NOMBRE,' ',usuarios.PRIMER_apellido,' ',usuarios.segundo_apellido) AS PACIENTE " _
                                                  & ", contratos.NOMBRE AS CONTRATO FROM  ordenes INNER JOIN usuarios ON (ordenes.ID_USUARIO = usuarios.ID) " _
                                                  & "INNER JOIN contratos ON (ordenes.ID_CONTRATO = contratos.ID) WHERE (ordenes.FECHA_ingreso =CURDATE() AND ordenes.ESTADO <> 'CANCELADO')")
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
        Public Function ExisteOrdenDia(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT ID FROM ordenes WHERE (FECHA_INGRESO=CURDATE() AND ID_USUARIO ='" & filtro & "' AND estado<>'CANCELADO')")
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
        Public Shared Function UltimoRegistroPaciente(ByVal filtro As String) As Ordenes
            Try
                Dim query As String = String.Format("SELECT id FROM ordenes WHERE id_usuario='" & filtro & "' ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Ordenes = New Ordenes
                _Ordenes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Ordenes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub CancelarOrden(ByVal filtro As Integer)
            Try
                Dim query As String
                query = "UPDATE ordenes SET estado='CANCELADO' where id='" & filtro & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub ActualizarEstado(ByVal filtro As Integer)
            Try
                Dim query As String
                query = "UPDATE ordenes SET estado='ATENDIDO' where id='" & filtro & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function OrdenPendiente(ByVal filtro As Integer) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM ordenes WHERE id='" & filtro & "' and estado='PENDIENTE'")
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

    End Class
End Namespace


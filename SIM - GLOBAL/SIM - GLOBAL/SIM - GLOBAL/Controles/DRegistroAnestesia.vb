Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports System.Data.Common
Namespace Controles
    Public Class DRegistroAnestesia
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdDetalleOrden As String) As SIM___GLOBAL.Modelo.RegistroAnestesia
            Try
                Dim query As String = String.Format("SELECT * FROM registro_anestesia WHERE id_detalle_orden='" & IdDetalleOrden & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _RegistroAnestesia = New SIM___GLOBAL.Modelo.RegistroAnestesia
                _RegistroAnestesia.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _RegistroAnestesia.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _RegistroAnestesia.IdDetalleOrden = _ds.Tables(0).Rows(0)(2).ToString()
                _RegistroAnestesia.Fecha = _ds.Tables(0).Rows(0)(3).ToString()
                _RegistroAnestesia.Cardiovisoscopico = _ds.Tables(0).Rows(0)(4).ToString()
                _RegistroAnestesia.PresionArterial = _ds.Tables(0).Rows(0)(5).ToString()
                _RegistroAnestesia.OximetriaPulso = _ds.Tables(0).Rows(0)(6).ToString()
                _RegistroAnestesia.ViaAerea = _ds.Tables(0).Rows(0)(7).ToString()
                _RegistroAnestesia.Posicion = _ds.Tables(0).Rows(0)(8).ToString()
                _RegistroAnestesia.Complicaciones = _ds.Tables(0).Rows(0)(9).ToString()
                _RegistroAnestesia.Observaciones = _ds.Tables(0).Rows(0)(10).ToString()
                _RegistroAnestesia.ResumenAnestesico = _ds.Tables(0).Rows(0)(11).ToString()
                _RegistroAnestesia.IdEndoscopista = _ds.Tables(0).Rows(0)(12).ToString()
                _RegistroAnestesia.AuxiliarAnestesia = _ds.Tables(0).Rows(0)(13).ToString()
                _RegistroAnestesia.IdAnestesiologo = _ds.Tables(0).Rows(0)(14).ToString()
                _RegistroAnestesia.Estado = _ds.Tables(0).Rows(0)(15).ToString()

                Return _RegistroAnestesia
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal IdDetalleOrden As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT ID FROM registro_anestesia WHERE id_detalle_orden='" & IdDetalleOrden & "'")
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
        Public Function ExisteAnestesia(ByVal idOrden As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT id FROM registro_anestesia WHERE id_orden='" & idOrden & "' AND estado='ATENDIDO'")
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
        Public Sub Guardar(ByVal _RegistroAnestesia As SIM___GLOBAL.Modelo.RegistroAnestesia)
            Try
                Dim query As String
                If Existe(_RegistroAnestesia.IdDetalleOrden) = True Then
                    'Actualizar Registro de Anestesia
                    query = "UPDATE registro_anestesia SET cardiovisoscopico='" & _RegistroAnestesia.Cardiovisoscopico & "', " _
                        & "presion_arterial='" & _RegistroAnestesia.PresionArterial & "', " _
                        & "oximetria_pulso='" & _RegistroAnestesia.OximetriaPulso & "', " _
                        & "via_aerea='" & _RegistroAnestesia.ViaAerea & "', " _
                        & "posicion='" & _RegistroAnestesia.Posicion & "', " _
                        & "complicaciones='" & _RegistroAnestesia.Complicaciones & "', " _
                        & "observaciones='" & _RegistroAnestesia.Observaciones & "', " _
                        & "resumen_anestesico='" & _RegistroAnestesia.ResumenAnestesico & "', " _
                        & "id_endoscopista='" & _RegistroAnestesia.IdEndoscopista & "', " _
                        & "auxiliar_anestesia='" & _RegistroAnestesia.AuxiliarAnestesia & "', " _
                        & "id_anestesiologo='" & _RegistroAnestesia.IdAnestesiologo & "' " _
                        & "WHERE id_detalle_orden='" & _RegistroAnestesia.IdDetalleOrden & "'"
                Else
                    'Guardar Registro de Anestesia
                    query = "INSERT INTO registro_anestesia VALUES('','" & _RegistroAnestesia.IdOrden & "', " _
                        & "'" & _RegistroAnestesia.IdDetalleOrden & "', " _
                        & "'" & Format(_RegistroAnestesia.Fecha, "yyyy/MM/dd") & "', " _
                        & "'" & _RegistroAnestesia.Cardiovisoscopico & "', " _
                        & "'" & _RegistroAnestesia.PresionArterial & "', " _
                        & "'" & _RegistroAnestesia.OximetriaPulso & "', " _
                        & "'" & _RegistroAnestesia.ViaAerea & "', " _
                        & "'" & _RegistroAnestesia.Posicion & "', " _
                        & "'" & _RegistroAnestesia.Complicaciones & "', " _
                        & "'" & _RegistroAnestesia.Observaciones & "', " _
                        & "'" & _RegistroAnestesia.ResumenAnestesico & "', " _
                        & "'" & _RegistroAnestesia.IdEndoscopista & "', " _
                        & "'" & _RegistroAnestesia.AuxiliarAnestesia & "', " _
                        & "'" & _RegistroAnestesia.IdAnestesiologo & "', " _
                        & "'" & _RegistroAnestesia.Estado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Especialista(ByVal IdOrden As String) As String
            Try
                Dim query As String = String.Format("SELECT empleados.nombre_empleado AS ENDOSCOPISTA " _
                                                  & "FROM empleados INNER JOIN ordenes ON (empleados.id=ordenes.id_empleado) " _
                                                  & "WHERE ordenes.id='" & IdOrden & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds.Tables(0).Rows(0)(0).ToString()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Shared Function UltimoRegistro() As SIM___GLOBAL.Modelo.RegistroAnestesia
            Try
                Dim query As String = String.Format("SELECT id FROM registro_anestesia ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _RegistroAnestesia = New SIM___GLOBAL.Modelo.RegistroAnestesia
                _RegistroAnestesia.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _RegistroAnestesia
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub ActualizarEstado(ByVal IdOrden As String)
            Try
                Dim query As String
                query = "update registro_anestesia set estado='ATENDIDO' WHERE id_orden='" & IdOrden & "'"
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


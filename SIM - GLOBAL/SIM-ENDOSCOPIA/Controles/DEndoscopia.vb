Imports SIM_ENDOSCOPIA.Modelo
Imports SIM_ENDOSCOPIA.Controles
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DEndoscopia
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Endoscopia
            Try
                Dim query As String = String.Format("SELECT * FROM endoscopias WHERE id_detalle_orden='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Endoscopia = New Endoscopia
                _Endoscopia.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Endoscopia.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _Endoscopia.IdDetalleOrden = _ds.Tables(0).Rows(0)(2).ToString()
                _Endoscopia.FechaEstudio = _ds.Tables(0).Rows(0)(3).ToString()
                _Endoscopia.FechaSalida = _ds.Tables(0).Rows(0)(4).ToString()
                _Endoscopia.Hora = _ds.Tables(0).Rows(0)(5).ToString()
                _Endoscopia.MedicoSolicita = _ds.Tables(0).Rows(0)(6).ToString()
                _Endoscopia.Indicacion = _ds.Tables(0).Rows(0)(7).ToString()
                _Endoscopia.Medicamentos = _ds.Tables(0).Rows(0)(8).ToString()
                _Endoscopia.IdEquipo = _ds.Tables(0).Rows(0)(9).ToString()
                _Endoscopia.IdProcedimientoTerapeutico = _ds.Tables(0).Rows(0)(10).ToString()
                _Endoscopia.Anestesiologo = _ds.Tables(0).Rows(0)(11).ToString()
                _Endoscopia.Campo1 = _ds.Tables(0).Rows(0)(12).ToString()
                _Endoscopia.Campo2 = _ds.Tables(0).Rows(0)(13).ToString()
                _Endoscopia.Campo3 = _ds.Tables(0).Rows(0)(14).ToString()
                _Endoscopia.Campo4 = _ds.Tables(0).Rows(0)(15).ToString()
                _Endoscopia.Campo5 = _ds.Tables(0).Rows(0)(16).ToString()
                _Endoscopia.Campo6 = _ds.Tables(0).Rows(0)(17).ToString()
                _Endoscopia.Diagnostico = _ds.Tables(0).Rows(0)(18).ToString()
                _Endoscopia.IdEmpleado = _ds.Tables(0).Rows(0)(19).ToString()
                _Endoscopia.CodigoDiagnostico = _ds.Tables(0).Rows(0)(20).ToString()
                _Endoscopia.TomaBiopsia = _ds.Tables(0).Rows(0)(21).ToString()
                _Endoscopia.Biopsia = _ds.Tables(0).Rows(0)(22).ToString()

                Return _Endoscopia
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT ID FROM endoscopias WHERE id_detalle_orden='" & filtro & "'")
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
        Public Function Guardar(ByVal _Endoscopia As Endoscopia) As Boolean
            Try
                Dim query As String
                If Existe(_Endoscopia.IdDetalleOrden) = True Then
                    'Actualizar Historia
                    query = "UPDATE endoscopias SET fecha_estudio='" & Format(_Endoscopia.FechaEstudio, "yyyy/MM/dd") & "', " _
                        & "fecha_salida='" & Format(_Endoscopia.FechaSalida, "yyyy/MM/dd") & "', medico_solicita='" & _Endoscopia.MedicoSolicita & "', " _
                        & "indicacion='" & _Endoscopia.Indicacion & "', medicamentos='" & _Endoscopia.Medicamentos & "', " _
                        & "id_equipo='" & _Endoscopia.IdEquipo & "', id_procedimiento_terapeutico='" & _Endoscopia.IdProcedimientoTerapeutico & "', " _
                        & "anestesiologo='" & _Endoscopia.Anestesiologo & "', campo1='" & _Endoscopia.Campo1 & "', " _
                        & "campo2='" & _Endoscopia.Campo2 & "', campo3='" & _Endoscopia.Campo3 & "',campo4='" & _Endoscopia.Campo4 & "', " _
                        & "campo5='" & _Endoscopia.Campo5 & "',campo6='" & _Endoscopia.Campo6 & "', diagnostico='" & _Endoscopia.Diagnostico & "', " _
                        & "id_empleado='" & _Endoscopia.IdEmpleado & "', codigo_diagnostico='" & _Endoscopia.CodigoDiagnostico & "',toma_biopsia='" & _Endoscopia.TomaBiopsia & "', biopsia='" & _Endoscopia.Biopsia & "' WHERE id_detalle_orden='" & _Endoscopia.IdDetalleOrden & "'"
                Else
                    'Guardar Historia
                    query = "INSERT INTO endoscopias VALUES('','" & _Endoscopia.IdOrden & "','" & _Endoscopia.IdDetalleOrden & "','" & Format(_Endoscopia.FechaEstudio, "yyyy/MM/dd") & "'," _
                        & "'" & Format(_Endoscopia.FechaSalida, "yyyy/MM/dd") & "', '" & Format(_Endoscopia.Hora, "hh:mm:ss") & "','" & _Endoscopia.MedicoSolicita & "'," _
                        & "'" & _Endoscopia.Indicacion & "', '" & _Endoscopia.Medicamentos & "','" & _Endoscopia.IdEquipo & "','" & _Endoscopia.IdProcedimientoTerapeutico & "', " _
                        & "'" & _Endoscopia.Anestesiologo & "', '" & _Endoscopia.Campo1 & "', '" & _Endoscopia.Campo2 & "','" & _Endoscopia.Campo3 & "','" & _Endoscopia.Campo4 & "', " _
                        & "'" & _Endoscopia.Campo5 & "','" & _Endoscopia.Campo6 & "', '" & _Endoscopia.Diagnostico & "','" & _Endoscopia.IdEmpleado & "','" & _Endoscopia.CodigoDiagnostico & "','" & _Endoscopia.TomaBiopsia & "','" & _Endoscopia.Biopsia & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
                Return False
            End Try
        End Function
        Public Function ListarEstudiosAnteriores(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                String.Format("SELECT ordenes.ID AS ORDEN, " _
                                & "historia_clinica.FECHA_HISTORIA AS FECHA, " _
                                & "historia_clinica.MOTIVO_CONSULTA FROM ordenes INNER JOIN historia_clinica " _
                                & "ON (ordenes.ID = historia_clinica.ID_ORDEN) WHERE " _
                                & "(ordenes.ESTADO ='ATENDIDO' And ordenes.ID_USUARIO ='" & filtro & "')")
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
        Public Shared Function UltimoRegistroEndoscopia() As Endoscopia
            Try
                Dim query As String = String.Format("SELECT id FROM endoscopias ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Endoscopia = New Endoscopia
                _Endoscopia.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Endoscopia
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace

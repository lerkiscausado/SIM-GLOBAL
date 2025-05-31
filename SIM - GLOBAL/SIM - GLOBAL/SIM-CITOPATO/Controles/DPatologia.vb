Imports SIM_CITOPATO.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DPatologia
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As SIM_CITOPATO.My.Modelo.Patologia
            Try
                Dim query As String = String.Format("SELECT * FROM patologia WHERE id_orden='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Patologia = New SIM_CITOPATO.My.Modelo.Patologia
                _Patologia.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Patologia.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _Patologia.Fecha = _ds.Tables(0).Rows(0)(2).ToString()
                _Patologia.FechaSalida = _ds.Tables(0).Rows(0)(3).ToString()
                _Patologia.TipoMuestra = _ds.Tables(0).Rows(0)(4).ToString()
                _Patologia.SitioLesion = _ds.Tables(0).Rows(0)(5).ToString()
                _Patologia.Solicitado = _ds.Tables(0).Rows(0)(6).ToString()
                _Patologia.DescripcionMacroscopica = _ds.Tables(0).Rows(0)(7).ToString()
                _Patologia.DescripcionMicroscopica = _ds.Tables(0).Rows(0)(8).ToString()
                _Patologia.Diagnostico = _ds.Tables(0).Rows(0)(9).ToString()
                _Patologia.Observaciones = _ds.Tables(0).Rows(0)(10).ToString()
                _Patologia.CodigoDiagnostico = _ds.Tables(0).Rows(0)(11).ToString()
                _Patologia.IdEmpleado = _ds.Tables(0).Rows(0)(12).ToString()
                _Patologia.Estado = _ds.Tables(0).Rows(0)(13).ToString()
                _Patologia.CodigoPatologia = _ds.Tables(0).Rows(0)(14).ToString()
                Return _Patologia
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT id FROM patologia WHERE id_orden='" & filtro & "'")
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
        Public Sub Guardar(ByVal _Patologia As SIM_CITOPATO.My.Modelo.Patologia)
            Try
                Dim query As String
                If Existe(_Patologia.IdOrden) = True Then
                    query = "UPDATE patologia SET tipo_muestra='" & _Patologia.TipoMuestra & "', " _
                       & "sitio_lesion='" & _Patologia.SitioLesion & "', " _
                       & "solicitado='" & _Patologia.Solicitado & "', " _
                       & "descripcion_macroscopica='" & _Patologia.DescripcionMacroscopica & "', " _
                       & "descripcion_microscopica='" & _Patologia.DescripcionMicroscopica & "', " _
                       & "diagnostico='" & _Patologia.Diagnostico & "', observaciones='" & _Patologia.Observaciones & "', " _
                       & "codigo_diagnostico='" & _Patologia.CodigoDiagnostico & "', id_empleado='" & _Patologia.IdEmpleado & "', estado='" & _Patologia.Estado & "' where id_orden='" & _Patologia.IdOrden & "'"
                Else
                    query = "insert into patologia values('" & _Patologia.Id & "','" &
                    _Patologia.IdOrden & "','" &
                    Format(_Patologia.Fecha, "yyyy/MM/dd") & "','" &
                    Format(_Patologia.FechaSalida, "yyyy/MM/dd") & "','" &
                    _Patologia.TipoMuestra & "','" &
                    _Patologia.SitioLesion & "','" &
                    _Patologia.Solicitado & "','" &
                    _Patologia.DescripcionMacroscopica & "','" &
                    _Patologia.DescripcionMicroscopica & "','" &
                    _Patologia.Diagnostico & "','" &
                    _Patologia.Observaciones & "','" &
                    _Patologia.CodigoDiagnostico & "','" &
                    _Patologia.IdEmpleado & "','" &
                    _Patologia.Estado & "','" &
                    _Patologia.CodigoPatologia & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Shared Function UltimoRegistroPatologia() As DataSet
            Try
                Dim query As String = String.Format("SELECT tipo_estudio.PREFIJO, patologia.ID FROM ordenes " _
                                                & "INNER JOIN tipo_estudio ON (ordenes.ID_TIPO_ESTUDIO = tipo_estudio.ID) " _
                                                & "INNER JOIN patologia ON (ordenes.ID = patologia.ID_ORDEN) ORDER BY " _
                                                & "patologia.id DESC LIMIT 1")
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
        Public Shared Function OrdenPatologia(ByVal filtro As String) As SIM_CITOPATO.My.Modelo.Patologia
            Try
                Dim query As String = String.Format("SELECT ID_ORDEN FROM patologia WHERE (ID_ORDEN='" & filtro & "')")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Patologia = New SIM_CITOPATO.My.Modelo.Patologia
                _Patologia.IdOrden = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Patologia
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace

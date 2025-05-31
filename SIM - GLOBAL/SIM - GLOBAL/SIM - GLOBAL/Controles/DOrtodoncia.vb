Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Namespace Controles
    Public Class DOrtodoncia
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As Funciones
        Public Function Existe(ByVal IdOrden As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT ID FROM ortodoncia WHERE id_orden='" & IdOrden & "'")
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
        Public Sub Guardar(ByVal _Ortodoncia As SIM___GLOBAL.Modelo.Ortodoncias)
            Try
                Dim query As String
                If Existe(_Ortodoncia.IdOrden) = True Then
                    'Actualizar Historia
                    query = "UPDATE ortodoncia SET motivo_consulta='" & _Ortodoncia.MotivoConsulta & "', " _
                        & "responsables='" & _Ortodoncia.Responsables & "', ANTECEDENTES_PATOLOGICOS='" & _Ortodoncia.AntecedentesPatologicos & "', " _
                        & "PERFIL='" & _Ortodoncia.Perfil & "', FRENTE='" & _Ortodoncia.Frente & "', " _
                        & "HIPOTONIA='" & _Ortodoncia.Hipotonia & "', HIPERTONIA='" & _Ortodoncia.Hipertonia & "', " _
                        & "MACROQUELIA='" & _Ortodoncia.Macroquelia & "', MICROQUELIA='" & _Ortodoncia.Microquelia & "', " _
                        & "PROQUELIA='" & _Ortodoncia.Macroquelia & "', RETROQUELIA='" & _Ortodoncia.Retroquelia & "',FRENILLO_LABIAL_INFERIOR='" & _Ortodoncia.FrenilloLabialInferior & "', " _
                        & "FRENILLO_LINGUAL='" & _Ortodoncia.FrenilloLingual & "',RESPIRACION_BUCAL='" & _Ortodoncia.RespiracionBucal & "', USO_CHUPO='" & _Ortodoncia.UsoChupo & "', " _
                        & "BRUXOMANIA='" & _Ortodoncia.Bruxomania & "', SUCCION_DIGITAL='" & _Ortodoncia.Succiondigital & "',SUCCION_LABIAL='" & _Ortodoncia.Succionlabial & "', " _
                        & "DEGLUCION_INFANTIL='" & _Ortodoncia.DeglucionInfantil & "',ONICOFAGIA='" & _Ortodoncia.Onicofagia & "',EMPUJE_LINGUAL='" & _Ortodoncia.EmpujeLingual & "'," _
                        & "MORDER_OBJETO='" & _Ortodoncia.MorderObjeto & "',FONACION='" & _Ortodoncia.Fonacion & "',INTERPRETACION_CEFALOMETRICA='" & _Ortodoncia.InterpretacionCefalometrica & "'," _
                        & "DIAGNOSTICO='" & _Ortodoncia.Diagnostico & "',PRONOSTICO='" & _Ortodoncia.Pronostico & " ',PLAN_TRATAMIENTO='" & _Ortodoncia.PlanTratamiento & " ', " _
                        & "APARATOLOGIA='" & _Ortodoncia.Aparatologia & "',PRESUPUESTO='" & _Ortodoncia.Presupuesto & "',ACTIVIDAD_REALIZADA='" & _Ortodoncia.ActividadRealizada & "'," _
                        & "PROXIMA_CITA='" & _Ortodoncia.ProximaCita & "',CODIGO_DIAGNOSTICO='" & _Ortodoncia.CodigoDiagnostico & "',ID_EMPLEADO='" & _Ortodoncia.IdEmpleado & "' " _
                        & "WHERE id_detalle_orden='" & _Ortodoncia.IdDetalleOrden & "'"
                Else
                    'Guardar Historia
                    query = "INSERT INTO ortodoncia VALUES('','" & _Ortodoncia.IdOrden & "','" & _Ortodoncia.IdDetalleOrden & "','" & Format(_Ortodoncia.Fecha, "yyyy/MM/dd") & "'," _
                        & "'" & Format(_Ortodoncia.Hora, "hh:mm:ss") & "','" & _Ortodoncia.MotivoConsulta & "', '" & _Ortodoncia.Responsables & "' ," _
                        & "'" & _Ortodoncia.AntecedentesPatologicos & "', '" & _Ortodoncia.Perfil & "','" & _Ortodoncia.Frente & "'," _
                        & "'" & _Ortodoncia.Hipotonia & "','" & _Ortodoncia.Hipertonia & "','" & _Ortodoncia.Macroquelia & "','" & _Ortodoncia.Microquelia & "', " _
                        & "'" & _Ortodoncia.Proquelia & "','" & _Ortodoncia.Retroquelia & "', '" & _Ortodoncia.FrenilloLabiarSuperior & "', '" & _Ortodoncia.FrenilloLabialInferior & "'," _
                        & "'" & _Ortodoncia.FrenilloLingual & "','" & _Ortodoncia.RespiracionBucal & "','" & _Ortodoncia.UsoChupo & "', " _
                        & "'" & _Ortodoncia.Bruxomania & "','" & _Ortodoncia.Succiondigital & "', '" & _Ortodoncia.Succionlabial & "'," _
                        & "'" & _Ortodoncia.DeglucionInfantil & "','" & _Ortodoncia.Onicofagia & "','" & _Ortodoncia.EmpujeLingual & "', " _
                        & "'" & _Ortodoncia.MorderObjeto & "','" & _Ortodoncia.EvaluacionHabito & "','" & _Ortodoncia.Fonacion & "', " _
                        & "'" & _Ortodoncia.InterpretacionCefalometrica & "','" & _Ortodoncia.Diagnostico & "','" & _Ortodoncia.Pronostico & "', " _
                        & "'" & _Ortodoncia.PlanTratamiento & "','" & _Ortodoncia.Aparatologia & "','" & _Ortodoncia.Presupuesto & "', " _
                        & "'" & _Ortodoncia.ActividadRealizada & "','" & _Ortodoncia.ProximaCita & "','" & _Ortodoncia.CodigoDiagnostico & "', " _
                        & "'" & _Ortodoncia.IdEmpleado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Shared Function Cargar(ByVal IdOrden As String) As Ortodoncias
            Try
                Dim query As String = String.Format("SELECT * FROM ortodoncia WHERE id_orden='" & IdOrden & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Ortodoncia = New Ortodoncias
                _Ortodoncia.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Ortodoncia.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _Ortodoncia.IdDetalleOrden = _ds.Tables(0).Rows(0)(2).ToString()
                _Ortodoncia.Fecha = _ds.Tables(0).Rows(0)(3).ToString()
                _Ortodoncia.Hora = _ds.Tables(0).Rows(0)(4).ToString()
                _Ortodoncia.MotivoConsulta = _ds.Tables(0).Rows(0)(5).ToString()
                _Ortodoncia.Responsables = _ds.Tables(0).Rows(0)(6).ToString()
                _Ortodoncia.AntecedentesPatologicos = _ds.Tables(0).Rows(0)(7).ToString()
                _Ortodoncia.Perfil = _ds.Tables(0).Rows(0)(8).ToString()
                _Ortodoncia.Frente = _ds.Tables(0).Rows(0)(9).ToString()
                _Ortodoncia.Hipotonia = _ds.Tables(0).Rows(0)(10).ToString()
                _Ortodoncia.Hipertonia = _ds.Tables(0).Rows(0)(11).ToString()
                _Ortodoncia.Macroquelia = _ds.Tables(0).Rows(0)(12).ToString()
                _Ortodoncia.Microquelia = _ds.Tables(0).Rows(0)(13).ToString()
                _Ortodoncia.Proquelia = _ds.Tables(0).Rows(0)(14).ToString()
                _Ortodoncia.Retroquelia = _ds.Tables(0).Rows(0)(15).ToString()
                _Ortodoncia.FrenilloLabiarSuperior = _ds.Tables(0).Rows(0)(16).ToString()
                _Ortodoncia.FrenilloLabialInferior = _ds.Tables(0).Rows(0)(17).ToString()
                _Ortodoncia.FrenilloLingual = _ds.Tables(0).Rows(0)(18).ToString()
                _Ortodoncia.RespiracionBucal = _ds.Tables(0).Rows(0)(19).ToString()
                _Ortodoncia.UsoChupo = _ds.Tables(0).Rows(0)(20).ToString()
                _Ortodoncia.Bruxomania = _ds.Tables(0).Rows(0)(21).ToString()
                _Ortodoncia.Succiondigital = _ds.Tables(0).Rows(0)(22).ToString()
                _Ortodoncia.Succionlabial = _ds.Tables(0).Rows(0)(23).ToString()
                _Ortodoncia.DeglucionInfantil = _ds.Tables(0).Rows(0)(24).ToString()
                _Ortodoncia.Onicofagia = _ds.Tables(0).Rows(0)(25).ToString()
                _Ortodoncia.EmpujeLingual = _ds.Tables(0).Rows(0)(26).ToString()
                _Ortodoncia.MorderObjeto = _ds.Tables(0).Rows(0)(27).ToString()
                _Ortodoncia.EvaluacionHabito = _ds.Tables(0).Rows(0)(28).ToString()
                _Ortodoncia.Fonacion = _ds.Tables(0).Rows(0)(29).ToString()
                _Ortodoncia.InterpretacionCefalometrica = _ds.Tables(0).Rows(0)(30).ToString()
                _Ortodoncia.Diagnostico = _ds.Tables(0).Rows(0)(31).ToString()
                _Ortodoncia.Pronostico = _ds.Tables(0).Rows(0)(32).ToString()
                _Ortodoncia.PlanTratamiento = _ds.Tables(0).Rows(0)(33).ToString()
                _Ortodoncia.Aparatologia = _ds.Tables(0).Rows(0)(34).ToString()
                _Ortodoncia.Presupuesto = _ds.Tables(0).Rows(0)(35).ToString()
                _Ortodoncia.ActividadRealizada = _ds.Tables(0).Rows(0)(36).ToString()
                _Ortodoncia.ProximaCita = _ds.Tables(0).Rows(0)(37).ToString()
                _Ortodoncia.CodigoDiagnostico = _ds.Tables(0).Rows(0)(38).ToString()
                _Ortodoncia.IdEmpleado = _ds.Tables(0).Rows(0)(39).ToString()
                Return _Ortodoncia
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace

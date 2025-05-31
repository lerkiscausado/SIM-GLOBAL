Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DPlantillasInformes
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As SIM___GLOBAL.Modelo.PlantillasInformes
            Try
                Dim query As String = String.Format("SELECT * FROM plantillas_informes WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _PlantillasInformes = New SIM___GLOBAL.Modelo.PlantillasInformes
                _PlantillasInformes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _PlantillasInformes.IdTipoEstudio = _ds.Tables(0).Rows(0)(1).ToString()
                _PlantillasInformes.IdEspecialista = _ds.Tables(0).Rows(0)(2).ToString()
                _PlantillasInformes.Campo1 = _ds.Tables(0).Rows(0)(3).ToString()
                _PlantillasInformes.Campo2 = _ds.Tables(0).Rows(0)(4).ToString()
                _PlantillasInformes.Campo3 = _ds.Tables(0).Rows(0)(5).ToString()
                _PlantillasInformes.Campo4 = _ds.Tables(0).Rows(0)(6).ToString()
                _PlantillasInformes.Campo5 = _ds.Tables(0).Rows(0)(7).ToString()
                _PlantillasInformes.Campo6 = _ds.Tables(0).Rows(0)(8).ToString()
                _PlantillasInformes.Estado = _ds.Tables(0).Rows(0)(9).ToString()
                Return _PlantillasInformes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function AplicarPlantilla(ByVal IdMedico As String, ByVal IdTipoEstudio As String) As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "select campo1,campo2,campo3,campo4,campo5, campo6 from plantillas_informes where id_especialista='" & IdMedico & "' and id_tipo_estudio='" & IdTipoEstudio & "'")
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
        Public Sub Guardar(ByVal _PlantillasInformes As SIM___GLOBAL.Modelo.PlantillasInformes)
            Try
                Dim query As String
                If Existe(_PlantillasInformes.IdEspecialista, _PlantillasInformes.IdTipoEstudio) = True Then
                    query = "UPDATE plantillas_informes SET campo1='" & _PlantillasInformes.Campo1 & "', " _
                           & "campo2='" & _PlantillasInformes.Campo2 & "',campo3='" & _PlantillasInformes.Campo3 & "', " _
                           & "campo4='" & _PlantillasInformes.Campo4 & "',campo5='" & _PlantillasInformes.Campo5 & "', " _
                           & "campo6='" & _PlantillasInformes.Campo6 & "' where id='" & _PlantillasInformes.Id & "'"
                Else
                    query = "insert into plantillas_informes values('" & _PlantillasInformes.Id & "', " _
                             & "'" & _PlantillasInformes.IdTipoEstudio & "','" & _PlantillasInformes.IdEspecialista & "', " _
                             & "'" & _PlantillasInformes.Campo1 & "','" & _PlantillasInformes.Campo2 & "', " _
                             & "'" & _PlantillasInformes.Campo3 & "', '" & _PlantillasInformes.Campo4 & "', " _
                             & "'" & _PlantillasInformes.Campo5 & "','" & _PlantillasInformes.Campo6 & "','" & _PlantillasInformes.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal IdMedico As String, ByVal IdTipoEstudio As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM plantillas_informes WHERE id_especialista='" & IdMedico & "' And id_tipo_estudio='" & IdTipoEstudio & "'")
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
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT `plantillas_informes`.`ID`, `empleados`.`NOMBRE_EMPLEADO` AS `ESPECIALISTA`, " _
                                      & "`tipo_estudio`.`NOMBRE_TIPO_ESTUDIO` AS `ESTUDIO` FROM `plantillas_informes` INNER JOIN " _
                                      & "`tipo_estudio` ON (`plantillas_informes`.`ID_TIPO_ESTUDIO` = `tipo_estudio`.`ID`) INNER " _
                                      & "JOIN `empleados` ON (`plantillas_informes`.`ID_ESPECIALISTA` = `empleados`.`ID`)")
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


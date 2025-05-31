Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DPlantillasPatologia
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As PlantillasPatologia
            Try
                Dim query As String = String.Format("SELECT * FROM plantillas_patologia WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _plantilla = New PlantillasPatologia
                _plantilla.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _plantilla.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _plantilla.Macro = _ds.Tables(0).Rows(0)(2).ToString()
                _plantilla.Micro = _ds.Tables(0).Rows(0)(3).ToString()
                _plantilla.Diagnostico = _ds.Tables(0).Rows(0)(4).ToString()
                _plantilla.Estado = _ds.Tables(0).Rows(0)(5).ToString()
                Return _plantilla
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _plantilla As PlantillasPatologia)
            Try
                Dim query As String
                If Existe(_plantilla.Id) = True Then
                    query = "update `plantillas_patologia` SET  `nombre`='" & _plantilla.Nombre & "', " _
                            & "`diagnostico`='" & _plantilla.Diagnostico & "',`estado`='" & _plantilla.Estado & "' where `id`='" & _plantilla.Id & "'"

                Else
                    query = "insert into plantillas_patologia values('', " _
                        & "'" & _plantilla.Nombre & "','','','" & _plantilla.Diagnostico & "','" & _plantilla.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM plantillas_patologia WHERE id='" & filtro & "'")
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
                                    String.Format("select plantillas_patologia.ID , plantillas_patologia.NOMBRE " _
                                                  & ",plantillas_patologia.diagnostico as DIAGNOSTICO, " _
                                                  & "IF(plantillas_patologia.ESTADO='A','ACTIVO','INACTIVO') AS ESTADO from plantillas_patologia ")
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
        Public Shared Function UltimoRegistro() As String
            Try
                Dim query As String = String.Format("sELECT MAX(id) AS id FROM plantillas_patologia")
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
    End Class
End Namespace

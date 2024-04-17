Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Namespace Controles
    Public Class DConsentimientoInformadoPlantillas
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As Funciones
        Public Shared Function Cargar(ByVal Id As String) As ConsentimientoInformadoPlantillas
            Try
                Dim query As String = String.Format("SELECT * FROM consentimiento_informado_plantillas WHERE id='" & Id & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _ConsentimientoInformadoPlantillas = New ConsentimientoInformadoPlantillas
                _ConsentimientoInformadoPlantillas.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _ConsentimientoInformadoPlantillas.IdLicencia = _ds.Tables(0).Rows(0)(1).ToString()
                _ConsentimientoInformadoPlantillas.TipoConsentimiento = _ds.Tables(0).Rows(0)(2).ToString()
                _ConsentimientoInformadoPlantillas.Descripcion = _ds.Tables(0).Rows(0)(3).ToString()
                _ConsentimientoInformadoPlantillas.Estado = _ds.Tables(0).Rows(0)(4).ToString()
                Return _ConsentimientoInformadoPlantillas
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal Id As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT ID FROM consentimiento_informado_plantillas WHERE id='" & Id & "'")
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
        Public Sub Guardar(ByVal _ConsentimientoInformadoPlantillas As ConsentimientoInformadoPlantillas)
            Try
                Dim query As String
                If Existe(_ConsentimientoInformadoPlantillas.Id) = True Then
                    query = "UPDATE consentimiento_informado_plantillas SET descripcion='" & _ConsentimientoInformadoPlantillas.Descripcion & "', " _
                            & "estado='" & _ConsentimientoInformadoPlantillas.Estado & "' WHERE id='" & _ConsentimientoInformadoPlantillas.Id & "'"
                Else
                    query = "INSERT INTO consentimiento_informado_plantillas VALUES('" & _ConsentimientoInformadoPlantillas.Id & "', " _
                        & "'" & _ConsentimientoInformadoPlantillas.IdLicencia & "', " _
                        & "'" & _ConsentimientoInformadoPlantillas.TipoConsentimiento & "', " _
                        & "'" & _ConsentimientoInformadoPlantillas.Descripcion & "', " _
                        & "'" & _ConsentimientoInformadoPlantillas.Estado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `consentimiento_informado_plantillas`.`ID`, " _
                                                  & "`licencias`.`CLIENTE` AS EMPRESA, " _
                                                  & "`consentimiento_informado_plantillas`.`TIPO_CONSENTIMIENTO` AS TIPO, " _
                                                  & "`consentimiento_informado_plantillas`.`ESTADO` " _
                                                  & "FROM `consentimiento_informado_plantillas` " _
                                                  & "INNER JOIN `licencias` ON (`consentimiento_informado_plantillas`.`ID_LICENCIA` = `licencias`.`ID`)")
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

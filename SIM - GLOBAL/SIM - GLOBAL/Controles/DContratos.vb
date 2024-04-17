Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DContratos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Contratos
            Try
                Dim query As String = String.Format("SELECT * FROM contratos WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Contratos = New Contratos
                _Contratos.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Contratos.codigoentidad = _ds.Tables(0).Rows(0)(1).ToString()
                _Contratos.Nombre = _ds.Tables(0).Rows(0)(2).ToString()
                _Contratos.NumeroContrato = _ds.Tables(0).Rows(0)(3).ToString()
                _Contratos.FechaInicio = _ds.Tables(0).Rows(0)(4).ToString()
                _Contratos.FechaFinal = _ds.Tables(0).Rows(0)(5).ToString()
                _Contratos.Observaciones = _ds.Tables(0).Rows(0)(6).ToString()
                _Contratos.Contacto = _ds.Tables(0).Rows(0)(7).ToString()
                _Contratos.Telefono = _ds.Tables(0).Rows(0)(8).ToString()
                _Contratos.CorreoElectronico = _ds.Tables(0).Rows(0)(9).ToString()
                _Contratos.TipoContrato = _ds.Tables(0).Rows(0)(10).ToString()
                _Contratos.Rips = _ds.Tables(0).Rows(0)(11).ToString()
                _Contratos.IdTarifa = _ds.Tables(0).Rows(0)(12).ToString()
                _Contratos.ValorConvenio = _ds.Tables(0).Rows(0)(13).ToString()
                _Contratos.IdLicencia = _ds.Tables(0).Rows(0)(14).ToString()
                _Contratos.Estado = _ds.Tables(0).Rows(0)(15).ToString()
                Return _Contratos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM contratos WHERE id='" & filtro & "'")
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
        Public Sub Guardar(ByVal _Contratos As Contratos)
            Try
                Dim query As String
                If Existe(_Contratos.Id) = True Then
                    query = "UPDATE contratos SET numero_contrato='" & _Contratos.NumeroContrato & "', " _
                            & "fecha_inicio='" & Format(_Contratos.FechaInicio, "yyyy/MM/dd") & "', fecha_final='" & Format(_Contratos.FechaFinal, "yyyy/MM/dd") & "', " _
                            & "observaciones='" & _Contratos.Observaciones & "', " _
                            & "contacto='" & _Contratos.Contacto & "', " _
                            & "telefono='" & _Contratos.Telefono & "', " _
                            & "correo_electronico='" & _Contratos.CorreoElectronico & "', " _
                            & "tipo_contrato='" & _Contratos.TipoContrato & "',rips='" & _Contratos.Rips & "',id_tarifa='" & _Contratos.IdTarifa & "', " _
                            & "valor_convenio='" & _Contratos.ValorConvenio & "', id_licencia='" & _Contratos.IdLicencia & "', estado='" & _Contratos.Estado & "' where id='" & _Contratos.Id & "'"
                Else
                    query = "insert into contratos values('" & _Contratos.Id & "','" &
                            _Contratos.CodigoEntidad & "','" & _Contratos.Nombre & "','" &
                            _Contratos.NumeroContrato & "','" & Format(_Contratos.FechaInicio, "yyyy/MM/dd") & "', '" &
                            Format(_Contratos.FechaFinal, "yyyy/MM/dd") & "', '" & _Contratos.Observaciones & "', '" &
                            _Contratos.Contacto & "', '" & _Contratos.Telefono & "', '" & _Contratos.CorreoElectronico & "', '" &
                            _Contratos.TipoContrato & "','" & _Contratos.Rips & "','" & _Contratos.IdTarifa & "', '" & _Contratos.ValorConvenio & "','" & _Contratos.IdLicencia & "','" & _Contratos.Estado & "','','')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT contratos.ID, contratos.NOMBRE AS CONTRATO, 
                                    entidades.NOMBRE_ENTIDAD AS ENTIDAD, licencias.CLIENTE AS EMPRESA, contratos.id_licencia as LICENCIA FROM contratos INNER JOIN entidades 
                                    ON (contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD) INNER JOIN licencias ON (contratos.`ID_LICENCIA`=licencias.`ID`)
                                    WHERE (contratos.ESTADO ='A')")
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
        Public Function ListarComboLicencia(ByVal Licencia As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT contratos.ID, contratos.NOMBRE AS CONTRATO, 
                                    entidades.NOMBRE_ENTIDAD AS ENTIDAD, licencias.CLIENTE AS EMPRESA, contratos.id_licencia as LICENCIA FROM contratos INNER JOIN entidades 
                                    ON (contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD) INNER JOIN licencias ON (contratos.`ID_LICENCIA`=licencias.`ID`)
                                    WHERE contratos.id_licencia ='" & Licencia & "' and contratos.estado='A'")
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
        Public Shared Function UltimoRegistroContrato() As Contratos
            Try
                Dim query As String = String.Format("SELECT id FROM contratos ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Contratos = New Contratos
                _Contratos.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Contratos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT contratos.ID, contratos.NOMBRE, contratos.NUMERO_CONTRATO, contratos.FECHA_INICIO, " _
                                                  & "entidades.NOMBRE_ENTIDAD, tarifas.NOMBRE_TARIFA FROM contratos INNER JOIN entidades " _
                                                  & "ON (contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD) INNER JOIN tarifas " _
                                                  & "ON (contratos.ID_TARIFA = tarifas.ID)")
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
        Public Function DatosFactura(ByVal IdContrato As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT entidades.`NOMBRE_ENTIDAD`,entidades.`NIT`,contratos.`TELEFONO`,entidades.`DIRECCION` FROM contratos " _
                                    & "	INNER JOIN entidades ON (contratos.`CODIGO_ENTIDAD`=entidades.`CODIGO_ENTIDAD`) WHERE contratos.id='" & IdContrato & "'")
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

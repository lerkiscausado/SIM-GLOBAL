Imports PEC___App.Modelo
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
                _Contratos.NumeroContrato = _ds.Tables(0).Rows(0)(1).ToString()
                _Contratos.Nombre = _ds.Tables(0).Rows(0)(2).ToString()
                _Contratos.FechaInicio = _ds.Tables(0).Rows(0)(3).ToString()
                _Contratos.FechaFinal = _ds.Tables(0).Rows(0)(4).ToString()
                _Contratos.Observaciones = _ds.Tables(0).Rows(0)(5).ToString()
                _Contratos.Contacto = _ds.Tables(0).Rows(0)(6).ToString()
                _Contratos.Telefono = _ds.Tables(0).Rows(0)(7).ToString()
                _Contratos.CorreoElectronico = _ds.Tables(0).Rows(0)(8).ToString()
                _Contratos.idCliente = _ds.Tables(0).Rows(0)(9).ToString()
                _Contratos.IdTarifa = _ds.Tables(0).Rows(0)(10).ToString()
                _Contratos.Estado = _ds.Tables(0).Rows(0)(11).ToString()
                _Contratos.IdLicencia = _ds.Tables(0).Rows(0)(12).ToString()
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
                            & "contacto='" & _Contratos.Contacto & "', telefono='" & _Contratos.Telefono & "', " _
                            & "correo_electronico='" & _Contratos.CorreoElectronico & "', " _
                            & "id_tarifa='" & _Contratos.IdTarifa & "', " _
                            & "id_licencia='" & _Contratos.IdLicencia & "', estado='" & _Contratos.Estado & "' where id='" & _Contratos.Id & "'"
                Else
                    query = "insert into contratos values('" & _Contratos.Id & "','" &
                            _Contratos.NumeroContrato & "','" & _Contratos.Nombre & "','" & Format(_Contratos.FechaInicio, "yyyy/MM/dd") & "', '" &
                            Format(_Contratos.FechaFinal, "yyyy/MM/dd") & "', '" & _Contratos.Observaciones & "', '" &
                            _Contratos.Contacto & "', '" & _Contratos.Telefono & "', '" & _Contratos.CorreoElectronico & "', '" &
                             _Contratos.idCliente & "','" & _Contratos.IdTarifa & "', '" & _Contratos.Estado & "','" & _Contratos.IdLicencia & "')"
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
                                    String.Format("SELECT contratos.ID ,contratos.NOMBRE_contrato AS CONTRATO ,clientes.NOMBRE AS ENTIDAD " _
                                                  & "FROM contratos INNER JOIN clientes ON (contratos.`ID_CLIENTE` = clientes.`ID`) " _
                                                  & "INNER JOIN licencias ON (contratos.`ID_LICENCIA`=licencias.`ID`) WHERE (contratos.ESTADO ='A')")
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
                                    String.Format("SELECT contratos.ID,contratos.NOMBRE_contrato AS CONTRATO, contratos.NUMERO_CONTRATO AS NUMERO " _
                                                  & ", contratos.FECHA_INICIO , clientes.NOMBRE AS CLIENTE	, tarifas.NOMBRE_TARIFA AS TARIFA " _
                                                  & "FROM contratos INNER JOIN clientes ON (contratos.id_cliente = clientes.id) INNER JOIN tarifas ON (contratos.ID_TARIFA = tarifas.ID)")
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
        Public Function ExisteSede(ByVal IdCiudad As String, ByVal IdContrato As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM clientes_sedes WHERE id_ciudad='" & IdCiudad & "' and id_contrato='" & IdContrato & "'")
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

Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Namespace Controles
    Public Class DClientes
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As Funciones
        Public Shared Function Cargar(ByVal Id As String) As Clientes
            Try
                Dim query As String = String.Format("SELECT * FROM clientes WHERE id='" & Id & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Clientes = New Clientes
                _Clientes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Clientes.IdTipoIdentificacion = _ds.Tables(0).Rows(0)(1).ToString()
                _Clientes.Identificacion = _ds.Tables(0).Rows(0)(2).ToString()
                _Clientes.Nombre = _ds.Tables(0).Rows(0)(3).ToString()
                _Clientes.Direccion = _ds.Tables(0).Rows(0)(4).ToString()
                _Clientes.Telefono = _ds.Tables(0).Rows(0)(5).ToString()
                _Clientes.CorreoElectronico = _ds.Tables(0).Rows(0)(6).ToString()
                _Clientes.Contacto = _ds.Tables(0).Rows(0)(7).ToString()
                _Clientes.Estado = _ds.Tables(0).Rows(0)(8).ToString()
                Return _Clientes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal TI As String, ByVal Identificacion As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT ID FROM clientes WHERE id_tipo_identificacion='" & TI & "' AND identificacion='" & Identificacion & "' ")
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
        Public Sub Guardar(ByVal _Clientes As Clientes)
            Try
                Dim query As String
                If Existe(_Clientes.IdTipoIdentificacion, _Clientes.Identificacion) = True Then
                    'Actualizamos el Proveedor
                    query = "UPDATE clientes SET nombre='" & _Clientes.Nombre & "', " _
                            & "direccion='" & _Clientes.Direccion & "', " _
                            & "telefono='" & _Clientes.Telefono & "'," _
                            & "correo_electronico='" & _Clientes.CorreoElectronico & "', " _
                            & "contacto='" & _Clientes.Contacto & "', " _
                            & "estado='" & _Clientes.Estado & "' WHERE id='" & _Clientes.Id & "'"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)
                Else
                    query = "INSERT INTO clientes VALUES('" & _Clientes.Id & "','" & _Clientes.IdTipoIdentificacion & "', " _
                        & "'" & _Clientes.Identificacion & "','" & _Clientes.Nombre & "','" & _Clientes.Direccion & "', " _
                        & "'" & _Clientes.Telefono & "','" & _Clientes.CorreoElectronico & "', " _
                        & "'" & _Clientes.Contacto & "','" & _Clientes.Estado & "')"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ID AS IDCLIENTE,CONCAT(ID_TIPO_IDENTIFICACION,IDENTIFICACION) AS IDENTIFICACION, " _
                                                  & "nombre AS CLIENTE, CONTACTO, TELEFONO FROM clientes WHERE estado='A'")
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
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT  ID ,ID_TIPO_IDENTIFICACION   ,IDENTIFICACION,NOMBRE ,DIRECCION ,TELEFONO ,CORREO_ELECTRONICO ,CONTACTO ,IF(ESTADO='A','ACTIVO','INACTIVO' ) AS ESTADO FROM clientes")
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
        Public Shared Function IdCliente(ByVal TipoIdentificacion As String, ByVal Identificacion As String) As String
            Try
                Dim query As String = String.Format("SELECT id FROM clientes where id_tipo_identificacion='" & TipoIdentificacion & "' and identificacion='" & Identificacion & "'")
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

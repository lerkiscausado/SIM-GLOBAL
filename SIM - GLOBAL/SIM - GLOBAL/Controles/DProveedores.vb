Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Namespace Controles
    Public Class DProveedores
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As Funciones
        Public Shared Function Cargar(ByVal Id As String) As Proveedores
            Try
                Dim query As String = String.Format("SELECT * FROM proveedores WHERE id='" & Id & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Proveedores = New Proveedores
                _Proveedores.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Proveedores.IdTipoIdentificacion = _ds.Tables(0).Rows(0)(1).ToString()
                _Proveedores.Identificacion = _ds.Tables(0).Rows(0)(2).ToString()
                _Proveedores.Nombre = _ds.Tables(0).Rows(0)(3).ToString()
                _Proveedores.Direccion = _ds.Tables(0).Rows(0)(4).ToString()
                _Proveedores.Telefono = _ds.Tables(0).Rows(0)(5).ToString()
                _Proveedores.CorreoElectronico = _ds.Tables(0).Rows(0)(6).ToString()
                _Proveedores.Contacto = _ds.Tables(0).Rows(0)(7).ToString()
                _Proveedores.Estado = _ds.Tables(0).Rows(0)(8).ToString()
                Return _Proveedores
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal TI As String, ByVal Identificacion As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT ID FROM proveedores WHERE id_tipo_identificacion='" & TI & "' AND identificacion='" & Identificacion & "' ")
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
        Public Sub Guardar(ByVal _Proveedores As Proveedores)
            Try
                Dim query As String
                If Existe(_Proveedores.IdTipoIdentificacion, _Proveedores.Identificacion) = True Then
                    'Actualizamos el Proveedor
                    query = "UPDATE proveedores SET nombre='" & _Proveedores.Nombre & "', " _
                            & "direccion='" & _Proveedores.Direccion & "', " _
                            & "telefono='" & _Proveedores.Telefono & "'," _
                            & "correo_electronico='" & _Proveedores.CorreoElectronico & "', " _
                            & "contacto='" & _Proveedores.Contacto & "', " _
                            & "estado='" & _Proveedores.Estado & "' WHERE id='" & _Proveedores.Id & "'"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)
                Else
                    query = "INSERT INTO proveedores VALUES('" & _Proveedores.Id & "','" & _Proveedores.IdTipoIdentificacion & "','" & _Proveedores.Identificacion & "','" & _Proveedores.Nombre & "','" & _Proveedores.Direccion & "','" & _Proveedores.Telefono & "','" & _Proveedores.CorreoElectronico & "'," _
                        & "'" & _Proveedores.Contacto & "','" & _Proveedores.Estado & "')"
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
                                    String.Format("SELECT ID,CONCAT(ID_TIPO_IDENTIFICACION,IDENTIFICACION) AS IDENTIFICACION, " _
                                                  & "nombre AS PROVEEDOR, CONTACTO, TELEFONO FROM proveedores WHERE estado='A'")
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
                                    String.Format("SELECT ID ,ID_TIPO_IDENTIFICACION ,IDENTIFICACION ,NOMBRE ,DIRECCION ,TELEFONO ,CORREO_ELECTRONICO ,CONTACTO ,IF(ESTADO='A','ACTIVO','INACTIVO' ) AS ESTADO FROM proveedores")
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


Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DEntidades
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Sub Guardar(ByVal _Entidades As Entidades)
            Try
                Dim query As String
                If Existe(_Entidades.CodigoEntidad) = True Then

                    query = "UPDATE entidades SET nit='" & _Entidades.Nit & "', direccion='" & _Entidades.Direccion & "', telefono='" & _Entidades.telefono & "',estado='" & _Entidades.Estado & "' where codigo_entidad='" & _Entidades.CodigoEntidad & "'"
                Else
                    query = "insert into entidades values('" & _Entidades.CodigoEntidad & "','" & _Entidades.NombreEntidad & "','" & _Entidades.Nit & "','" & _Entidades.Direccion & "','" & _Entidades.telefono & "','" & _Entidades.Estado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal _entidades As Entidades)
            Try
                Dim query As String
                query = "UPDATE entidades SET estado='I' where codigo_entidad='" & _entidades.CodigoEntidad & "'"
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
                                    String.Format("SELECT CODIGO_ENTIDAD AS CODIGO, NOMBRE_ENTIDAD AS ENTIDAD, NIT, DIRECCION, IF(ESTADO='A','ACTIVO','INACTIVO') as ESTADO FROM entidades")
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
        Public Function ListarActivos() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT CODIGO_ENTIDAD AS CODIGO, NOMBRE_ENTIDAD AS ENTIDAD, ESTADO FROM  entidades WHERE (ESTADO ='A')")
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
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT codigo_entidad FROM entidades WHERE codigo_entidad='" & filtro & "'")
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

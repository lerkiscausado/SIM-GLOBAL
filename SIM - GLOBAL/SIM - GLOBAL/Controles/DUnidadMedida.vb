Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DUnidadMedida
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As SIM___GLOBAL.Modelo.UnidadMedida
            Try
                Dim query As String = String.Format("SELECT * FROM unidad_medida WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _UnidadMedida = New SIM___GLOBAL.Modelo.UnidadMedida
                _UnidadMedida.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _UnidadMedida.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _UnidadMedida.Estado = _ds.Tables(0).Rows(0)(2).ToString()
                Return _UnidadMedida
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _UnidadMedida As SIM___GLOBAL.Modelo.UnidadMedida)
            Try
                Dim query As String
                If Existe(_UnidadMedida.Id) = True Then
                    query = "UPDATE unidad_medida SET estado='" & _UnidadMedida.Estado & "' where id='" & _UnidadMedida.Id & "'"
                Else
                    query = "insert into unidad_medida values('" & _UnidadMedida.Id & "','" & _UnidadMedida.Nombre & "','" & _UnidadMedida.Estado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal Id As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT ID FROM unidad_medida WHERE id='" & Id & "'")
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
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "Select id as ID, nombre as NOMBRE, ESTADO " _
                                        & "from unidad_medida where estado='A'")
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
                                    String.Format(
                                        "Select id as ID, nombre as NOMBRE, IF(ESTADO='A','ACTIVO','INACTIVO' ) AS ESTADO " _
                                        & "from unidad_medida")
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


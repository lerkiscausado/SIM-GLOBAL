Imports SIM___GLOBAL.My.Controles
Imports System.Data.Odbc
Imports System.Data.Common
Namespace Controles
    Public Class DServicios
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdServicio As String) As AGORA.Modelo.Servicios
            Try
                Dim query As String = String.Format("SELECT * FROM servicios WHERE id='" & IdServicio & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Servicios = New AGORA.Modelo.Servicios
                _Servicios.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Servicios.NombreServicio = _ds.Tables(0).Rows(0)(1).ToString()
                _Servicios.Descripcion = _ds.Tables(0).Rows(0)(2).ToString()
                _Servicios.Valor = _ds.Tables(0).Rows(0)(3).ToString()
                _Servicios.Estado = _ds.Tables(0).Rows(0)(4).ToString()
                Return _Servicios
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _Servicios As AGORA.Modelo.Servicios)
            Try
                Dim query As String
                If Existe(_Servicios.Id) = False Then
                    query = "insert into servicios values('" & _Servicios.Id & "','" &
                            _Servicios.NombreServicio & "','" &
                            _Servicios.Descripcion & "',?,'" & _Servicios.Estado & "')"
                Else
                    query = "UPDATE servicios set nombre_servicio='" & _Servicios.NombreServicio & "', descripcion='" & _Servicios.Descripcion & "', valor=?, estado='" & _Servicios.Estado & "' where id='" & _Servicios.Id & "'"

                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_Servicios.Valor))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal IdServicio As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM servicios WHERE id='" & IdServicio & "'")
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
                                        "Select ID,  nombre_servicio as SERVICIO, DESCRIPCION, VALOR, IF(estado='A','ACTIVO','INACTIVO') as ESTADO " _
                                        & "from servicios")
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
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT ID, " _
                                      & "nombre_servicio as SERVICIO,  " _
                                      & "descripcion AS DESCRIPCION, " _
                                      & "VALOR FROM servicios WHERE estado='A'")
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

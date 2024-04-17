Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DEquipos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Equipos
            Try
                Dim query As String = String.Format("SELECT * FROM equipos WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Equipos = New Equipos
                _Equipos.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Equipos.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _Equipos.Marca = _ds.Tables(0).Rows(0)(2).ToString()
                _Equipos.Modelo = _ds.Tables(0).Rows(0)(3).ToString()
                _Equipos.Estado = _ds.Tables(0).Rows(0)(4).ToString()
                Return _Equipos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _equipos As Equipos)
            Try
                Dim query As String
                If Existe(_equipos.Id) = True Then
                    query = "UPDATE equipos SET nombre='" &
                        _equipos.Nombre & "',marca='" & _equipos.Marca & "',modelo='" & _equipos.Modelo & "', estado='" & _equipos.Estado & "' where id='" & _equipos.Id & "'"
                Else
                    query = "insert into equipos values('" & _equipos.Id & "','" &
                            _equipos.Nombre & "','" & _equipos.Marca & "','" & _equipos.Modelo & "','" & _equipos.Estado & "')"
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
                        String.Format("SELECT id FROM equipos WHERE id='" & filtro & "'")
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
                                        "Select id as ID, nombre as NOMBRE,marca as MARCA,modelo as MODELO, IF(estado='A','ACTIVO','INACTIVO') as ESTADO " _
                                        & "from equipos")
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
                                        "Select id as ID, nombre as NOMBRE, marca as MARCA, modelo as MODELO" _
                                        & " from equipos where estado='A'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds
            Catch ex As Exception
                MessageBox.Show(ex.Message & " EQUIPOS - Listar Combo")
                Return Nothing
            End Try
        End Function
    End Class
End Namespace


Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DCups
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Cups
            Try
                Dim query As String = String.Format("SELECT * FROM cups WHERE id='" & filtro & "' AND estado='A'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _cups = New Cups
                _cups.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _cups.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _cups.Estado = _ds.Tables(0).Rows(0)(2).ToString()
                Return _cups
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Sub Guardar(ByVal _cups As Cups)
            Try
                Dim query As String
                If Existe(_cups.Id) = True Then
                    query = "UPDATE cups SET nombre_cups='" &
                        _cups.Nombre & "', estado='" & _cups.Estado & "' where codigo_cups='" & _cups.Id & "'"
                Else
                    query = "insert into cups values('" & _cups.Id & "','" & _cups.Nombre & "','" & _cups.Estado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal codigo As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT codigo_cups FROM cups WHERE codigo_cups='" & codigo & "'")
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
                                        "Select codigo_cups as ID, nombre_cups as CUPS, IF(estado='A','ACTIVO','INACTIVO') as ESTADO " _
                                        & "from cups")
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
                                    String.Format(
                                        "SELECT `CODIGO_CUPS` AS ID, `NOMBRE_CUPS` AS NOMBRE, ESTADO FROM `cups` where estado='A'")
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
                                        "Select codigo_cups as CODIGO, nombre_cups as PROCEDIMIENTOS" _
                                        & " from cups where estado='A'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds
            Catch ex As Exception
                MessageBox.Show(ex.Message & " CUPS - Listar Combo")
                Return Nothing
            End Try
        End Function
    End Class
End Namespace

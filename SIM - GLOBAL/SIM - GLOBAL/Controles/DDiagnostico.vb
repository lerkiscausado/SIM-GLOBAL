Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDiagnostico
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Diagnosticos
            Try
                Dim query As String = String.Format("SELECT * FROM diagnosticos WHERE id='" & filtro & "' AND estado='A'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _diagnosticos = New Diagnosticos
                _diagnosticos.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _diagnosticos.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _diagnosticos.Estado = _ds.Tables(0).Rows(0)(2).ToString()
                Return _diagnosticos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Sub Guardar(ByVal _diagnosticos As Diagnosticos)
            Try
                Dim query As String
                If Existe(_diagnosticos.Id) = True Then
                    query = "UPDATE diagnosticos SET nombre_diagnostico='" &
                        _diagnosticos.Nombre & "', estado='" & _diagnosticos.Estado & "' where codigo_diagnostico='" & _diagnosticos.Id & "'"
                Else
                    query = "insert into diagnosticos values('" & _diagnosticos.Id & "','" &
                            _diagnosticos.Nombre & "','" & _diagnosticos.Estado & "')"
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
                        String.Format("SELECT codigo_diagnostico FROM diagnosticos WHERE codigo_diagnostico='" & codigo & "'")
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
                                        "Select diagnosticos.codigo_diagnostico as ID, diagnosticos.nombre_diagnostico as NOMBRE, IF(diagnosticos.estado='A','ACTIVO','INACTIVO') as ESTADO " _
                                        & "from diagnosticos ")
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
                                        "Select codigo_diagnostico as CODIGO, nombre_diagnostico as DIAGNOSTICO" _
                                        & " from diagnosticos where estado='A'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds
            Catch ex As Exception
                MessageBox.Show(ex.Message & " DIAGNOSTICOS - Listar Combo")
                Return Nothing
            End Try
        End Function
    End Class
End Namespace


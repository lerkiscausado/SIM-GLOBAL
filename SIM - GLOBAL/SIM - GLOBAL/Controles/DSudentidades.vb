Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DSudentidades
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Subentidades
            Try
                Dim query As String = String.Format("SELECT * FROM subentidades WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Subentidades = New Subentidades
                _Subentidades.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Subentidades.IdContrato = _ds.Tables(0).Rows(0)(1).ToString()
                _Subentidades.Nombre = _ds.Tables(0).Rows(0)(2).ToString()
                _Subentidades.Estado = _ds.Tables(0).Rows(0)(3).ToString()
                Return _Subentidades
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _Subentidades As Subentidades)
            Try
                Dim query As String
                If Existe(_Subentidades.Id) = True Then
                    query = "UPDATE subentidades SET nombre='" & _Subentidades.Nombre & "', estado='" & _Subentidades.Estado & "' WHERE id='" & _Subentidades.Id & "'"
                Else
                    query = "insert into subentidades values('" & _Subentidades.Id & "','" & _Subentidades.IdContrato & "', " _
                        & "'" & _Subentidades.Nombre & "','" & _Subentidades.Estado & "')"
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
                        String.Format("SELECT id FROM subentidades WHERE id='" & codigo & "'")
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
                                    String.Format("SELECT subentidades.ID, subentidades.NOMBRE, " _
                                                  & "contratos.NOMBRE AS CONTRATO, subentidades.ESTADO FROM " _
                                                  & "subentidades INNER JOIN contratos ON " _
                                                  & "(subentidades.ID_CONTRATO = contratos.ID) WHERE (subentidades.ESTADO <>'E')")
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
        Public Function ListarCombo(ByVal filtro As String, ByVal Estado As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT subentidades.ID, subentidades.NOMBRE FROM subentidades where id_contrato='" & filtro & "' and estado='" & Estado & "'")
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
        Public Function ListarComboActivas(ByVal filtro As String, ByVal Estado As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT subentidades.ID, subentidades.NOMBRE FROM subentidades where id_contrato='" & filtro & "' and estado<>'" & Estado & "'")
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
        Public Function ExisteContrato(ByVal codigo As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM subentidades WHERE id_contrato='" & codigo & "'")
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


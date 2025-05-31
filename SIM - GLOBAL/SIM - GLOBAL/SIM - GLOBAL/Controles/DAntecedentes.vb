Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DAntecedentes
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Antecedentes
            Try
                Dim query As String = String.Format("SELECT * FROM antecedentes WHERE id_usuario='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Antecedentes = New Antecedentes
                _Antecedentes.IdOrden = _ds.Tables(0).Rows(0)(0).ToString()
                _Antecedentes.IdUsuario = _ds.Tables(0).Rows(0)(1).ToString()
                _Antecedentes.AntecedentesFamiliares = _ds.Tables(0).Rows(0)(2).ToString()
                _Antecedentes.AntecedentesPersonales = _ds.Tables(0).Rows(0)(3).ToString()
                Return _Antecedentes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function CargarOrden(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT antecedentes_familiares, antecedentes_personales from antecedentes WHERE id_orden='" & filtro & "'")
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
        Public Function CargarAntecedentes(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT antecedentes_familiares, antecedentes_personales from antecedentes WHERE id_orden='" & filtro & "'")
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
        Public Sub Guardar(ByVal _Antecedentes As Antecedentes)
            Try
                Dim query As String
                If Existe(_Antecedentes.IdOrden) = True Then
                    query = "UPDATE antecedentes SET antecedentes_familiares='" & _Antecedentes.AntecedentesFamiliares & "', antecedentes_personales='" & _Antecedentes.AntecedentesPersonales & "' where id_orden='" & _Antecedentes.IdOrden & "'"
                Else
                    query = "insert into antecedentes values('" & Val(_Antecedentes.IdOrden) & "','" &
                            _Antecedentes.IdUsuario & "','" & _Antecedentes.AntecedentesFamiliares & "','" & _Antecedentes.AntecedentesPersonales & "')"
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
                        String.Format("SELECT id_orden FROM antecedentes WHERE id_orden='" & filtro & "'")
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
        Public Function ExisteUsuario(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id_orden FROM antecedentes WHERE id_usuario='" & filtro & "'")
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
        Public Function ExisteUsuarioAntecedente(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id_orden FROM antecedentes WHERE id_usuario='" & filtro & "'")
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
        Public Function ListarAntecedentes(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT GROUP_CONCAT(antecedentes_familiares SEPARATOR '. ') AS " _
                                                  & "FAMILIARES, GROUP_CONCAT(antecedentes_personales SEPARATOR '. ') AS " _
                                                  & "PERSONALES FROM antecedentes WHERE id_usuario='" & filtro & "'")
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


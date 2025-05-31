Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DProcedimientosTerapeuticos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "Select ID, nombre as PROCEDIMIENTO from procedimientos_terapeuticos where estado='A'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds
            Catch ex As Exception
                MessageBox.Show(ex.Message & " PROCEDIMIENTOS TERAPEUTICOS - Listar Combo")
                Return Nothing
            End Try
        End Function
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "Select ID, nombre as PROCEDIMIENTO, IF(estado='A','ACTIVO','INACTIVO') as ESTADO from procedimientos_terapeuticos")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds
            Catch ex As Exception
                MessageBox.Show(ex.Message & " PROCEDIMIENTOS TERAPEUTICOS - Listar")
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _ProcedimientosTerapeuticos As ProcedimientosTerapeuticos)
            Try
                Dim query As String
                If Existe(_ProcedimientosTerapeuticos.Id) = True Then
                    query = "UPDATE procedimientos_terapeuticos SET estado='" & _ProcedimientosTerapeuticos.Estado & "' where id='" & _ProcedimientosTerapeuticos.Id & "'"
                Else
                    query = "insert into procedimientos_terapeuticos values('" & _ProcedimientosTerapeuticos.Id & "','" &
                            _ProcedimientosTerapeuticos.Nombre & "','" & _ProcedimientosTerapeuticos.Estado & "')"
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
                        String.Format("SELECT id FROM procedimientos_terapeuticos WHERE id='" & filtro & "'")
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


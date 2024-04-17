Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DMedicamentos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Medicamentos
            Try
                Dim query As String = String.Format("SELECT * FROM medicamentos WHERE id='" & filtro & "' AND estado='A'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _medicamentos = New Medicamentos
                _medicamentos.ID = _ds.Tables(0).Rows(0)(0).ToString()
                _medicamentos.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _medicamentos.Estado = _ds.Tables(0).Rows(0)(2).ToString()
                Return _Medicamentos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Sub Guardar(ByVal _medicamentos As Medicamentos)
            Try
                Dim query As String
                If Existe(_medicamentos.ID) = True Then
                    query = "UPDATE medicamentos SET nombre='" &
                        _medicamentos.Nombre & "', estado='" & _medicamentos.Estado & "' where id='" & _medicamentos.ID & "'"
                Else
                    query = "insert into medicamentos values('" & Val(_medicamentos.Id) & "','" &
                            _medicamentos.Nombre & "','" & _medicamentos.Estado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal ID As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM medicamentos WHERE id='" & ID & "'")
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
                                        "Select medicamentos.id as ID, medicamentos.nombre as MEDICAMENTO, IF(medicamentos.estado='A','ACTIVO','INACTIVO') as ESTADO " _
                                        & "from medicamentos")
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
                                        "Select medicamentos.id as ID, medicamentos.nombre as MEDICAMENTOS, medicamentos.estado as ESTADO " _
                                        & "from medicamentos where estado='A'")
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
        Public Function ListarMedicamentos() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "Select * from v_medicamentos")
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


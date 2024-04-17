Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.My.Modelo
Namespace Controles
    Public Class DTarifas
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Tarifas
            Try
                Dim query As String = String.Format("SELECT * FROM tarifas WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Tarifas = New Tarifas
                _Tarifas.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Tarifas.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _Tarifas.Estado = _ds.Tables(0).Rows(0)(2).ToString()
                Return _Tarifas
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _Tarifas As Tarifas)
            Try
                Dim query As String
                If Existe(_Tarifas.Id) = True Then
                    query = "UPDATE tarifas SET nombre_tarifa='" & _Tarifas.Nombre & "', estado='" & _Tarifas.Estado & "' where id='" & _Tarifas.Id & "'"
                Else
                    query = "insert into tarifas values('" & _Tarifas.Id & "','" &
                            _Tarifas.Nombre & "','" & _Tarifas.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal _Tarifas As Tarifas)
            Try
                Dim query As String
                query = "UPDATE cargos SET estado='E' where id='" & _Tarifas.Id & "'"
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
                        String.Format("SELECT id FROM tarifas WHERE id='" & filtro & "'")
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
                                    String.Format("select id as ID, nombre_tarifa as TARIFA, if(ESTADO='A','ACTIVA','INACTIVA') AS ESTADO from tarifas")
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
                                    String.Format("SELECT tarifas.ID, tarifas.nombre_tarifa AS TARIFA FROM 
                                    tarifas INNER JOIN detalle_tarifa 
                                    ON (tarifas.ID = detalle_tarifa.ID_TARIFA) 
                                    WHERE tarifas.estado='A' GROUP BY tarifas.nombre_tarifa ORDER BY tarifas.id")
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
        Public Shared Function UltimoRegistro() As Tarifas
            Try
                Dim query As String = String.Format("SELECT id FROM tarifas ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Tarifas = New Tarifas
                _Tarifas.Id = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Tarifas
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ExisteTarifaContrato(ByVal IdTarifa As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM contratos WHERE id_tarifa='" & IdTarifa & "'")
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


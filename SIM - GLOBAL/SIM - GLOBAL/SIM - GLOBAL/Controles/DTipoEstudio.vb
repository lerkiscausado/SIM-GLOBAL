Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DTipoEstudio
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("Select ID, nombre_tipo_estudio as ESTUDIO, prefijo as PREFIJO from tipo_estudio where estado='A'")
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
        Public Function ListarEstudios() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT ID, nombre_tipo_estudio AS ESTUDIO, IF(ESTADO='A','ACTIVO','INACTIVO') AS ESTADO FROM tipo_estudio")
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
        Public Shared Function Cargar(ByVal filtro As String) As tipoestudio
            Try
                Dim query As String = String.Format("SELECT * FROM tipo_estudio WHERE id='" & filtro & "' AND estado='A'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _tipoEstudio = New TipoEstudio
                _tipoEstudio.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _tipoEstudio.NombreTipoEstudio = _ds.Tables(0).Rows(0)(1).ToString()
                _tipoEstudio.Prefijo = _ds.Tables(0).Rows(0)(2).ToString()
                _tipoEstudio.Estado = _ds.Tables(0).Rows(0)(3).ToString()
                Return _tipoEstudio
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ListarProcedimientos() As DataSet
            Try
                Dim query As String =
                                    String.Format("Select ID, nombre_tipo_estudio as ESTUDIO, prefijo as PREFIJO from tipo_estudio where nombre_tipo_estudio not like 'CONSULTA%' and estado='A'")
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

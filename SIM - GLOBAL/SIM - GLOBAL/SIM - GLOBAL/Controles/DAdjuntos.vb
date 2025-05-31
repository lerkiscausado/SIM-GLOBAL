Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DAdjuntos
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Adjuntos
            Try
                Dim query As String = String.Format("SELECT * FROM datos_adjuntos WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Adjuntos = New Adjuntos
                _Adjuntos.ID = _ds.Tables(0).Rows(0)(0).ToString()
                _Adjuntos.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _Adjuntos.Nombre = _ds.Tables(0).Rows(0)(2).ToString()
                Return _Adjuntos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _Adjuntos As Adjuntos)
            Try

                Dim query As String = "insert into datos_adjuntos values('','" & _Adjuntos.IdOrden & "','" & _Adjuntos.Ruta & "','" & _Adjuntos.Nombre & "','A')"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub Eliminar(ByVal filtro As Integer)
            Try
                Dim query As String
                query = "DELETE FROM datos_adjuntos WHERE datos_adjuntos.ID = '" & filtro & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal filtro As Integer) As DataSet
            Try
                Dim query As String =
                                    String.Format("select id as ID, ID_Orden as ORDEN, RUTA ,nombre as NOMBRE,ESTADO  from datos_adjuntos where id_orden='" & filtro & "'")
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
        Public Shared Function UltimoRegistro() As String
            Try
                Dim query As String = String.Format("SELECT id FROM datos_adjuntos ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _ID As String
                _ID = _ds.Tables(0).Rows(0)(0).ToString()
                Return _ID
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class

End Namespace

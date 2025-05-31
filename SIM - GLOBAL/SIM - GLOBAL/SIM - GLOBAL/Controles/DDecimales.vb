Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DDecimales
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter

        Public Sub Guardar(ByVal _decimales As Decimales)
            Try
                Dim query As String

                query = String.Format("insert into decimales value('0',?,?,?)")

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, CDec(_decimales.Flotante))
                comando.Parameters.AddWithValue(2, CDec(_decimales.Doble))
                comando.Parameters.AddWithValue(3, CDec(_decimales.Decimal))
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Shared Function Cargar(ByVal filtro As String) As Decimales
            Try
                Dim query As String = String.Format("SELECT * FROM decimales WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _decimales = New Decimales
                _decimales.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _decimales.Flotante = _ds.Tables(0).Rows(0)(1).ToString()
                _decimales.Doble = _ds.Tables(0).Rows(0)(2).ToString()
                _decimales.Decimal = _ds.Tables(0).Rows(0)(3).ToString()
                Return _decimales
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace

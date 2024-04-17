Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Namespace Controles
    Public Class DSedes
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Sedes
            Try
                Dim query As String = String.Format("SELECT * FROM sedes WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Sedes = New Sedes
                _Sedes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Sedes.Nombre = _ds.Tables(0).Rows(0)(1).ToString()
                _Sedes.Direccion = _ds.Tables(0).Rows(0)(2).ToString()
                _Sedes.Telefono = _ds.Tables(0).Rows(0)(3).ToString()
                _Sedes.Correo = _ds.Tables(0).Rows(0)(4).ToString()
                _Sedes.Estado = _ds.Tables(0).Rows(0)(5).ToString()
                Return _Sedes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ID`, `NOMBRE` FROM `sedes` WHERE (`ESTADO`='A')")
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

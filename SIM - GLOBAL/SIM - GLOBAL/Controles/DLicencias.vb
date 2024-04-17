Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Namespace Controles
    Public Class DLicencias
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As Licencias
            Try
                Dim query As String = String.Format("SELECT * FROM licencias WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Licencia = New Licencias
                _Licencia.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Licencia.NombreCliente = _ds.Tables(0).Rows(0)(1).ToString()
                _Licencia.FechaContatacion = _ds.Tables(0).Rows(0)(2).ToString()
                _Licencia.Serial = _ds.Tables(0).Rows(0)(3).ToString()
                _Licencia.IdOrigen = _ds.Tables(0).Rows(0)(4).ToString()
                _Licencia.Estado = _ds.Tables(0).Rows(0)(5).ToString()
                Return _Licencia
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ID`, `CLIENTE` AS `EMPRESA` FROM `licencias` WHERE (`ESTADO`='A')")
                'MsgBox(_conn.State.ToString)
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


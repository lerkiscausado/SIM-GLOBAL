Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.My.Modelo
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DMotivoCancelacionCita
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `ID`, `DESCRIPCION` FROM `motivo_cancelacion_cita` WHERE (`ESTADO` ='A')")
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


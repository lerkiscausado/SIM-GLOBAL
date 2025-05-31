Public Class frmInventario
    ReadOnly _funciones As New SIM___GLOBAL.Utilidades.Funciones
    Dim _ds As DataSet
    Dim _ClickGrilla As String
    Dim _Fila As Integer
    Dim _dInventario = New SIM___GLOBAL.Controles.DInventario
    Public Licencia As String
    Public IdEmpleado As String
    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _ds = New DataSet
            _ds = _dInventario.listar()
            GCInventario.DataSource = _ds.Tables(0)
        Catch ex As Exception
        End Try
    End Sub
End Class
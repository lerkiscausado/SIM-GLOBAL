Public Class frmTipoEstudio
    Public Licencia As String
    Public IdEmpleado As String
    Dim _ds As DataSet
    Dim _dTipoEstudio As New SIM___GLOBAL.Controles.DTipoEstudio

    Private Sub ActualizarGrilla()
        _ds = New DataSet
        _ds = _dTipoEstudio.ListarEstudios
        GCConsultar.DataSource = _ds.Tables(0)

    End Sub
    Private Sub frmTipoEstudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrilla()
    End Sub
End Class
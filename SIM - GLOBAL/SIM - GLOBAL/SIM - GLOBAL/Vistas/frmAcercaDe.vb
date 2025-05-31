Public Class frmAcercaDe
    Public Licencia As String
    Public IdEmpleado As String
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub btnInformacionSistema_Click(sender As Object, e As EventArgs) Handles btnInformacionSistema.Click
        Shell("C:\Windows\system32\msinfo32.exe", vbApplicationModal)

    End Sub

    Private Sub frmAcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Licencia As New SIM___GLOBAL.Modelo.Licencias
        Dim _DLicencia = New SIM___GLOBAL.Controles.DLicencias
        'MsgBox(IDLicencia)
        _Licencia = _DLicencia.Cargar(Licencia)
        lcNombreCliente.Text = _Licencia.NombreCliente
        lcSerial.Text = _Licencia.Serial
        lcIDOrigen.Text = _Licencia.IdOrigen

    End Sub


End Class
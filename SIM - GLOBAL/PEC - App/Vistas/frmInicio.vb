Imports System.Data.Odbc
Imports SIM___GLOBAL.My.Controles
Public Class frmInicio
    'declaraciones de Variables Publicas
    Public LicenciaG As String
    Public IdEmpleadoG As String
    Public NombreEmpleado As String


    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos Informacion de Licencia
        Dim _Licencia As New SIM___GLOBAL.Modelo.Licencias
        Dim _DLicencia As New SIM___GLOBAL.Controles.DLicencias
        'MsgBox(IDLicencia)
        _Licencia = _DLicencia.Cargar(LicenciaG)
        lcNombreCliente.Text = _Licencia.NombreCliente
        lcSerial.Text = _Licencia.Serial
        lcIDOrigen.Text = _Licencia.IdOrigen
        '--------------------------------------------------------------

    End Sub

    Private Sub btnAcercaDe_Click(sender As Object, e As EventArgs) Handles btnAcercaDe.Click
        Dim _frmOpen As New SIM___GLOBAL.frmAcercaDe
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim _frmOpen As New SIM___GLOBAL.frmUsuarios
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Dim _frmOpen As New frmEmpleados
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub LabelControl13_HyperlinkClick(sender As Object, e As DevExpress.Utils.HyperlinkClickEventArgs) Handles LabelControl13.HyperlinkClick
        System.Diagnostics.Process.Start(e.Link)
    End Sub

    Private Sub btnTipoEstudio_Click(sender As Object, e As EventArgs) Handles btnTipoEstudio.Click
        Dim _frmOpen As New SIM___GLOBAL.frmTipoEstudio
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnCargos_Click(sender As Object, e As EventArgs) Handles btnCargos.Click
        Dim _frmOpen As New SIM___GLOBAL.frmCargos
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnSeguridad_Click(sender As Object, e As EventArgs) Handles btnSeguridad.Click
        Dim _frmOpen As New SIM___GLOBAL.frmSeguridad
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim _frmOpen As New SIM___GLOBAL.frmUsers
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim _frmOpen As New SIM___GLOBAL.frmClientes
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnTarifas_Click(sender As Object, e As EventArgs) Handles btnTarifas.Click
        Dim _frmOpen As New frmTarifas
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnContratos_Click(sender As Object, e As EventArgs) Handles btnContratos.Click
        Dim _frmOpen As New frmContratos
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnOrden_Click(sender As Object, e As EventArgs) Handles btnOrden.Click
        Dim _frmOpen As New frmOrdenes
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnEstudios_Click(sender As Object, e As EventArgs) Handles btnEstudios.Click
        Dim _frmOpen As New frmConsultar
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub
End Class
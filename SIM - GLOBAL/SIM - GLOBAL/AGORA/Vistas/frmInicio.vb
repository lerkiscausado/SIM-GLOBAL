Imports System.Data.Odbc
Imports SIM___GLOBAL.My.Controles
Public Class frmInicio
    Dim conectar = New ConexionODBC
    Dim _conn As OdbcConnection
    Dim cerrar As Boolean = True
    Public IdEmpleadoG As String
    Public LicenciaG As String
    Public NombreEmpleado As String

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'INICIAR CONEXION BASE DE DATOS
        '   Try
        '   conectar.Cadena = String.Format("Dsn=SIMDB;uid=adossofn_admin;pwd=80082552700ers")
        '   _conn = conectar.Open()
        '   cerrar = False
        '   Catch ex As Exception
        '   End Try
        '
        'Dim _frmOpen As New frmSesion
        '_frmOpen.ShowDialog()
        '
        '        If _frmOpen.validar = True Then
        '        IdEmpleadoG = _frmOpen.IDEmpleado
        '        LicenciaG = _frmOpen.Licencia
        '        Me.Text = "SIM  Sistema Integrado Medico - Licencia Autorizada a: " & _frmOpen.NombreLicencia
        '        Dim _Licencia As New SIM___GLOBAL.Modelo.Licencias
        '        Dim _DLicencia As New SIM___GLOBAL.Controles.DLicencias
        '        _Licencia = _DLicencia.Cargar(LicenciaG)
        '        lcNombreCliente.Text = _Licencia.NombreCliente
        '        lcSerial.Text = _Licencia.Serial
        '        lcIDOrigen.Text = _Licencia.IdOrigen
        '        Else
        '       End
        '       End If
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim _frmOpen As New SIM___GLOBAL.frmUsers
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Dim _frmOpen As New frmEmpleados
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnAcercaDe_Click(sender As Object, e As EventArgs) Handles btnAcercaDe.Click
        Dim _frmOpen As New SIM___GLOBAL.frmAcercaDe
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        '******** Formulario Inicio de Sesion 
        Dim _frmOpen As New SIM___GLOBAL.frmSesion
        _frmOpen.ShowDialog()

        If _frmOpen.validar = True Then
            IdEmpleadoG = _frmOpen.IDEmpleado
            'lblUsers.Caption = _frmOpen.NombreEmpleado
            'bsiCargo.Caption = _frmOpen.Cargo
            'bsiEspecialidad.Caption = _frmOpen.Especialidad
            'IdEspecialidad = _frmOpen.IDEspecialidad
            LicenciaG = _frmOpen.Licencia
            'HabilitarPrivilegios(LicenciaG)
            'CargarPrivilegios(IdEmpleadoG)
            Dim _Licencia As New SIM___GLOBAL.Modelo.Licencias
            Dim _DLicencia As New SIM___GLOBAL.Controles.DLicencias
            'MsgBox(IDLicencia)
            _Licencia = _DLicencia.Cargar(LicenciaG)
            lcNombreCliente.Text = _Licencia.NombreCliente
            lcSerial.Text = _Licencia.Serial
            lcIDOrigen.Text = _Licencia.IdOrigen
        Else
            End
        End If
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim _frmOpen As New SIM___GLOBAL.frmClientes
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnSalones_Click(sender As Object, e As EventArgs) Handles btnSalones.Click
        Dim _frmOpen As New frmSalones
        '_frmOpen.Licencia = LicenciaG
        '_frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnEventos_Click(sender As Object, e As EventArgs) Handles btnEventos.Click
        Dim _frmOpen As New frmEventos
        '_frmOpen.Licencia = LicenciaG
        '_frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim _frmOpen As New frmServicios
        '_frmOpen.Licencia = LicenciaG
        '_frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnCotizaciones_Click(sender As Object, e As EventArgs) Handles btnCotizaciones.Click
        Dim _frmOpen As New frmCotizaciones
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IDEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnCargo_Click(sender As Object, e As EventArgs) Handles btnCargo.Click
        Dim _frmOpen As New SIM___GLOBAL.frmCargos
        '_frmOpen.Licencia = LicenciaG
        '_frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnOrdenServicio_Click(sender As Object, e As EventArgs) Handles btnOrdenServicio.Click
        Dim _frmOpen As New frmOrdenServicio
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IDEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        Dim _frmOpen As New frmCaja
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnReservas_Click(sender As Object, e As EventArgs) Handles btnReservas.Click
        Dim _frmOpen As New frmReservas
        '_frmOpen.Licencia = LicenciaG
        '_frmOpen.IDEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnPass.Click
        Dim _frmOpen As New SIM___GLOBAL.frmSeguridad
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnConfiguracionCorreo_Click(sender As Object, e As EventArgs) Handles btnConfiguracionCorreo.Click
        Dim _frmOpen As New SIM___GLOBAL.frmConfiguracionCorreo
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim _frmOpen As New frmVentas
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub
End Class
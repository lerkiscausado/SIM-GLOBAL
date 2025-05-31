Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Controles
Imports System.IO
Public Class frmInicio
    Dim conectar = New ConexionODBC
    Dim _conn As OdbcConnection
    Dim cerrar As Boolean = True
    Dim IdEmpleadoG As String
    Dim LicenciaG As String
    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Selecciona el SKIN predeterminado
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013")
        'INICIAR CONEXION BASE DE DATOS
        Try
            conectar.Cadena = String.Format("Dsn=SIMDB;uid=adossofn_admin;pwd=80082552700ers")
            _conn = conectar.Open()
            cerrar = False
        Catch ex As Exception
        End Try

        Dim _frmOpen As New SIM___GLOBAL.frmSesion
        _frmOpen.ShowDialog()

        If _frmOpen.validar = True Then
            IdEmpleadoG = _frmOpen.IDEmpleado
            'lblUsers.Caption = _frmOpen.NombreEmpleado
            LicenciaG = _frmOpen.Licencia
            'lcNombreCliente.Text = _frmOpen.NombreLicencia
            Me.Text = "SIM  Sistema Integrado Medico - Licencia Autorizada a: " & _frmOpen.NombreLicencia
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnUnidadMedida_Click(sender As Object, e As EventArgs) Handles btnUnidadMedida.Click
        Dim _frmOpen As New SIM___GLOBAL.frmUnidadMedida
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim _frmOpen As New SIM___GLOBAL.frmUsers
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Dim _frmOpen As New SIM___GLOBAL.frmEmpleados
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Dim _frmOpen As New SIM___GLOBAL.frmProveedores
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
        Dim _frmOpen As New SIM___GLOBAL.frmTarifaProductos
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub





    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim _frmOpen As New SIM___GLOBAL.frmProductos
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnCotizaciones_Click(sender As Object, e As EventArgs) Handles btnCotizaciones.Click
        Dim _frmOpen As New SIM___GLOBAL.frmCotizaciones
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Dim _frmOpen As New SIM___GLOBAL.frmInventario
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IDEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        Dim _frmOpen As New SIM___GLOBAL.frmFacturas
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim _frmOpen As New SIM___GLOBAL.frmPrueba3
        _frmOpen.ShowDialog()
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

    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click
        Dim _frmOpen As New SIM___GLOBAL.frmUsuarios
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        Dim _frmOpen As New SIM___GLOBAL.frmReciboCaja
        '_frmOpen.IdOrden = IDOrdenG
        '_frmOpen.Empleado = lblUsers.Caption
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub



    Private Sub btnOrdenServicio_Click(sender As Object, e As EventArgs) Handles btnOrdenServicio.Click
        Dim _frmOpen As New SIM___GLOBAL.frmOrdenServicio
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IDEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnOptometria_Click(sender As Object, e As EventArgs) Handles btnOptometria.Click
        Dim _frmOpen As New SIM___GLOBAL.frmOptometria
        '_frmOpen.IdOrden = IDOrdenG
        '_frmOpen.Empleado = lblUsers.Caption
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnOrden_Click(sender As Object, e As EventArgs) Handles btnOrden.Click
        'Formulario = Nothing
        Dim _frmOpen As New SIM___GLOBAL.frmOrdenes
        'IDDetalleOrdenG = Nothing
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IDEmpleado = IdEmpleadoG
        '_frmOpen.Empleado = lblUsers.Caption
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnAgenda_Click(sender As Object, e As EventArgs) Handles btnAgenda.Click
        Dim _frmOpen As New SIM___GLOBAL.frmAgenda
        _frmOpen.Licencia = LicenciaG
        _frmOpen.idEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim _frmOpen As New SIM___GLOBAL.frmConsultarPOS
        _frmOpen.Licencia = LicenciaG
        _frmOpen.idEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim _frmOpen As New SIM___GLOBAL.frmVentas
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnAcercaDe_Click(sender As Object, e As EventArgs) Handles btnAcercaDe.Click
        Dim _frmOpen As New SIM___GLOBAL.frmAcercaDe
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click
        Dim _frmOpen As New SIM___GLOBAL.frmAuditoria
        _frmOpen.Licencia = LicenciaG
        _frmOpen.idEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnCajaMenor_Click(sender As Object, e As EventArgs) Handles btnCajaMenor.Click
        Dim _frmOpen As New SIM___GLOBAL.frmReciboCajaMenor
        '_frmOpen.Licencia = LicenciaG
        '_frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        Dim _frmOpen As New SIM___GLOBAL.frmCompras
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub btnOrdenCompra_Click(sender As Object, e As EventArgs) Handles btnOrdenCompra.Click
        Dim _frmOpen As New SIM___GLOBAL.frmOrdenCompra
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IDEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub
End Class
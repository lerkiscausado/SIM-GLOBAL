Imports System.Data.Odbc
Imports ADOSPLAY.My.Controles
Imports ADOSPLAY.Utilidades

'Imports SIM___GLOBAL.Utilidades
'Imports SIM___GLOBAL.My.Controles
'Imports SIM___GLOBAL.Controles
Public Class frmAdosPlay
    'VARIABLES GLOBALES 
    ReadOnly _funciones As New Funciones
    ' Dim _frmConsultar As New frmConsultar


    '-----------------------
    Dim conectar = New ConexionODBC
    Dim _conn As OdbcConnection
    'Dim _user As New DUsers
    Dim cerrar As Boolean = True
    Private Sub bbiDeportes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDeportes.ItemClick
        Dim _frmOpen As New frmDeportes
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEscenarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEscenarios.ItemClick
        Dim _frmOpen As New frmEscenarios
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEquipos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEquipos.ItemClick
        Dim _frmOpen As New frmEquipos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiTorneos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTorneos.ItemClick
        Dim _frmOpen As New frmTorneos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub frmAdosPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Selecciona el SKIN predeterminado
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013")
        'INICIAR CONEXION BASE DE DATOS
        Try
            conectar.Cadena = String.Format("Dsn=ADOSPLAY;uid=unidadde_admin;pwd=80082552700ers")
            _conn = conectar.Open()
            cerrar = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bbiArbitros_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiArbitros.ItemClick
        Dim _frmOpen As New frmArbitros
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiJugadores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiJugadores.ItemClick
        Dim _frmOpen As New frmJugadores
        _frmOpen.ShowDialog()
    End Sub
End Class
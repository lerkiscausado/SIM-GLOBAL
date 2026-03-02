Imports SIM___GLOBAL.Controles
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.My.Controles
Public Class frmSesion
    ' Conexion
    Dim conectar = New ConexionODBC
    Dim _conn As OdbcConnection
    Dim cerrar As Boolean = True

    'Variables 
    Dim _ds As DataSet
    Dim validar As Boolean
    Dim IDEmpleado As String
    Dim IDEspecialidad As String
    Dim NombreEmpleado As String
    Dim Cargo As String
    Dim Especialidad As String
    Dim Licencia As String
    Dim NombreLicencia As String

    ' Controles y Modelos
    Dim _DLicencia As DLicencias
    Dim _dLogin As DLogin
    Private Sub CargarLicencias()
        Try
            Dim _DLicencia As New SIM___GLOBAL.Controles.DLicencias
            Dim dsLic As DataSet = _DLicencia.ListarCombo()

            ' Validar que el DataSet tenga datos
            If dsLic Is Nothing OrElse dsLic.Tables.Count = 0 OrElse dsLic.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No se encontraron licencias activas.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Asignar DataSource al combo
            Dim dt As DataTable = dsLic.Tables(0)
            cboLicencia.Properties.DataSource = dt
            cboLicencia.Properties.DisplayMember = "EMPRESA"  ' Usa el nombre real de la columna
            cboLicencia.Properties.ValueMember = "ID"       ' Usa el nombre real de la columna

            ' Seleccionar primer elemento si existe
            cboLicencia.ItemIndex = If(dt.Rows.Count > 0, 0, -1)

            lblValidar.Visible = False
        Catch ex As Exception
            MessageBox.Show($"Error al cargar licencias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Me.Close()
        'Exit Sub
        'end
        'Stop
        End
    End Sub

    Private Sub btnFacebook_Click(sender As Object, e As EventArgs) Handles btnFacebook.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/adossoftware")
    End Sub

    Private Sub btnInstagram_Click(sender As Object, e As EventArgs) Handles btnInstagram.Click
        System.Diagnostics.Process.Start("https://www.instagram.com/adossoftware/")
    End Sub

    Private Sub btnWhatsapp_Click(sender As Object, e As EventArgs) Handles btnWhatsapp.Click
        System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=573175035033")
    End Sub

    Private Sub btnSoporte_Click(sender As Object, e As EventArgs) Handles btnSoporte.Click
        System.Diagnostics.Process.Start("https://ados-software.com/soporte/")
    End Sub

    Private Sub frmSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Selecciona el SKIN predeterminado
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013")
        'INICIAR CONEXION BASE DE DATOS
        Try
            conectar.Cadena = String.Format("Dsn=SIMDB;uid=adossofn_admin;pwd=80082552700ers")
            _conn = conectar.Open()
            'cerrar = False
        Catch ex As Exception
        End Try

        'Cargamos las Licencias Activas
        CargarLicencias()

        '******** Formulario Inicio de Sesion 
        'Dim _frmOpen As New SIM___GLOBAL.frmSesion
        '_frmOpen.ShowDialog()

        'If _frmOpen.validar = True Then
        ' IdEmpleadoG = _frmOpen.IDEmpleado
        ' lblUsers.Caption = _frmOpen.NombreEmpleado
        ' LicenciaG = _frmOpen.Licencia
        ' Me.Text = "SIM  Sistema Integrado Medico - Licencia Autorizada a: " & _frmOpen.NombreLicencia
        ' HabilitarPrivilegios(LicenciaG)
        ' CargarPrivilegios(IdEmpleadoG)
        '
        ' Select Case LicenciaG
        ' Case 11
        ' bbiEntregaResultados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        ' Case Else
        ' bbiEntregaResultados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        ' End Select
        'Else
        ' End
        ' End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim _dlogin = New DLogin
        If _dLogin.Validar(txtUser.Text, txtPass.Text) = True Then
            validar = True

            Dim _ds = New DataSet
            _ds = _dLogin.ListarEmpleados(txtUser.Text, txtPass.Text)
            IDEmpleado = _ds.Tables(0).Rows(0)(0).ToString()
            NombreEmpleado = _ds.Tables(0).Rows(0)(1).ToString()
            Cargo = _ds.Tables(0).Rows(0)(2).ToString()
            Especialidad = _ds.Tables(0).Rows(0)(3).ToString()
            IDEspecialidad = _ds.Tables(0).Rows(0)(4).ToString()
            'Licencia = _ds.Tables(0).Rows(0)(5).ToString()
            Licencia = cboLicencia.GetColumnValue("ID")
            NombreLicencia = cboLicencia.Text

            _conn.Close()




            '******** Formulario Principal 
            Dim _frmOpen As New frmInicio
            _frmOpen.LicenciaG = Licencia
            _frmOpen.IdEmpleadoG = IDEmpleado
            _frmOpen.NombreEmpleado = NombreEmpleado
            _frmOpen.Show()
            Me.Close()

        Else
            lblValidar.Visible = True
        End If
    End Sub


End Class
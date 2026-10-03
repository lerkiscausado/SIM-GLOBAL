Imports SIM___GLOBAL.Controles
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.My.Controles

Public Class frmSesion

    ' Conexion
    Dim conectar As New ConexionODBC
    Dim _conn As OdbcConnection
    Dim admincerrar As Boolean = True

    ' Variables
    Dim validar As Boolean
    Dim IDEmpleado As String
    Dim IDEspecialidad As String
    Dim NombreEmpleado As String
    Dim Cargo As String
    Dim Especialidad As String
    Dim Licencia As String
    Dim NombreLicencia As String

    ' ─────────────────────────────────────────────
    ' CARGAR LICENCIAS
    ' ─────────────────────────────────────────────
    Private Sub CargarLicencias()
        Try
            Dim _DLicencia As New DLicencias
            Dim dsLic As DataSet = _DLicencia.ListarCombo()

            If dsLic Is Nothing OrElse dsLic.Tables.Count = 0 OrElse dsLic.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No se encontraron licencias activas.", "Sin resultados",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim dt As DataTable = dsLic.Tables(0)
            cboLicencia.Properties.DataSource = dt
            cboLicencia.Properties.DisplayMember = "EMPRESA"
            cboLicencia.Properties.ValueMember = "ID"
            cboLicencia.ItemIndex = If(dt.Rows.Count > 0, 0, -1)

            lblValidar.Visible = False

        Catch ex As Exception
            MessageBox.Show($"Error al cargar licencias: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ─────────────────────────────────────────────
    ' LOAD
    ' ─────────────────────────────────────────────
    Private Sub frmSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Skin predeterminado
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013")

        ' Iniciar conexión
        Try
            conectar.Cadena = "Dsn=SIMDB;uid=adossofn_admin;pwd=80082552700ers"
            _conn = conectar.Open()
        Catch ex As Exception
            MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}",
                            "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnEnviar.Enabled = False
        End Try

        ' Cargar licencias activas
        CargarLicencias()
    End Sub

    ' ─────────────────────────────────────────────
    ' LOGIN
    ' ─────────────────────────────────────────────
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        ' Validar campos vacíos
        If String.IsNullOrWhiteSpace(txtUser.Text) OrElse String.IsNullOrWhiteSpace(txtPass.Text) Then
            MessageBox.Show("Por favor ingrese usuario y contraseña.", "Campos requeridos",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim _dLogin As New DLogin

            If _dLogin.Validar(txtUser.Text, txtPass.Text) Then
                validar = True

                Dim _ds As DataSet = _dLogin.ListarEmpleados(txtUser.Text, txtPass.Text)

                If _ds Is Nothing OrElse _ds.Tables.Count = 0 OrElse _ds.Tables(0).Rows.Count = 0 Then
                    MessageBox.Show("No se encontraron datos del empleado.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Asignar datos del empleado
                IDEmpleado = _ds.Tables(0).Rows(0)(0).ToString()
                NombreEmpleado = _ds.Tables(0).Rows(0)(1).ToString()
                Cargo = _ds.Tables(0).Rows(0)(2).ToString()
                Especialidad = _ds.Tables(0).Rows(0)(3).ToString()
                IDEspecialidad = _ds.Tables(0).Rows(0)(4).ToString()
                Licencia = cboLicencia.GetColumnValue("ID")
                NombreLicencia = cboLicencia.Text

                ' Cerrar conexión de forma segura
                If _conn IsNot Nothing AndAlso _conn.State = ConnectionState.Open Then
                    _conn.Close()
                End If

                ' Abrir formulario principal
                Dim _frmOpen As New frmInicio
                _frmOpen.LicenciaG = Licencia
                _frmOpen.IdEmpleadoG = IDEmpleado
                _frmOpen.NombreEmpleado = NombreEmpleado
                _frmOpen.Show()
                Me.Close()

            Else
                lblValidar.Visible = True
                txtPass.Text = String.Empty
                txtPass.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ─────────────────────────────────────────────
    ' BOTONES NAVEGACIÓN / SALIR
    ' ─────────────────────────────────────────────
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If _conn IsNot Nothing AndAlso _conn.State = ConnectionState.Open Then
            _conn.Close()
        End If
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

End Class
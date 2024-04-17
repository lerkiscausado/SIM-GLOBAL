Imports SIM___GLOBAL.Controles
Public Class frmSesion
    Dim _ds As DataSet
    Dim _dLogin As New DLogin
    Dim _DLicencia = New DLicencias
    Public validar As Boolean
    Public IDEmpleado As String
    Public IDEspecialidad As String
    Public NombreEmpleado As String
    Public Cargo As String
    Public Especialidad As String
    Public Licencia As String
    Public NombreLicencia As String
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
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

            Me.Close()
        Else
            lblValidar.Visible = True
        End If
    End Sub

    Private Sub frmSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar licencias activas
        _ds = _DLicencia.ListarCombo
        cboLicencia.Properties.DataSource = _ds.Tables(0)
        cboLicencia.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboLicencia.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboLicencia.ItemIndex = 0
        lblValidar.Visible = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        validar = False
        Me.Close()
    End Sub

    Private Sub OcultarTexto(sender As Object, e As EventArgs) Handles txtUser.Enter, txtPass.Enter
        lblValidar.Visible = False
    End Sub
End Class
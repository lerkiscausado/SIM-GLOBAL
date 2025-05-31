Public Class frmConfirmarAuditoria
    Public Licencia As String
    Public IdEmpleado As String
    Public IdAdmin As String
    Public Formulario As String
    'datos auditoria usuarios
    Public IdUsuario As String
    Public TipoIdentificacion As String
    Public Identificacion As String
    '-----------------------------
    'datos auditoria estudios
    Public IdDetalleOrden As String
    Public IdOrden As String
    '-----------------------------
    Public Concepto As String
    'Controles
    Dim _Dlogin As New SIM___GLOBAL.Controles.DLogin
    Dim _dAuditoria As New SIM___GLOBAL.Controles.DAuditoria
    Dim _Auditoria As New SIM___GLOBAL.Modelo.Auditoria

    Private Sub AuditoriaUsuario()
        _dAuditoria.GuardarAuditoriaUsuario(IdUsuario, TipoIdentificacion, Identificacion)
        'guardamos la auditoria 
        _Auditoria.Fecha = DateTime.Now
        _Auditoria.Hora = DateTime.Now
        _Auditoria.IdTabla = 1
        _Auditoria.IdRegistro = IdUsuario
        _Auditoria.Concepto = Concepto
        _Auditoria.IdSolicita = IdEmpleado
        _Auditoria.IdAutoriza = IdAdmin
        _Auditoria.Estado = "CERRADA"
        _dAuditoria.Guardar(_Auditoria)
    End Sub
    Private Sub AuditoriaEstudios()
        _dAuditoria.GuardarAuditoriaOrden(IdOrden)
        _dAuditoria.GuardarAuditoriaDetalleOrden(IdDetalleOrden)
        'guardamos la auditoria 
        _Auditoria.Fecha = DateTime.Now
        _Auditoria.Hora = DateTime.Now
        _Auditoria.IdTabla = 2
        _Auditoria.IdRegistro = IdDetalleOrden
        _Auditoria.Concepto = Concepto
        _Auditoria.IdSolicita = IdEmpleado
        _Auditoria.IdAutoriza = IdAdmin
        _Auditoria.Estado = "CERRADA"
        _dAuditoria.Guardar(_Auditoria)
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        ' valimos si usuario es administrador
        If _Dlogin.Auditar(txtUser.Text, txtPass.Text) = True Then
            ' traemos ID de Empleado Administrador
            Dim _ds = New DataSet
            _ds = _Dlogin.ListarEmpleados(txtUser.Text, txtPass.Text)
            IdAdmin = _ds.Tables(0).Rows(0)(0).ToString()
            ' verificamos a que tabla se realizara la auditoria
            Select Case Formulario
                Case "USUARIO"
                    If MessageBox.Show("Desea Realizar los Cambios?", "Auditoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        AuditoriaUsuario()
                        Me.Close()
                        MsgBox("Se realizaron los cambios satisfactoriamente")
                    Else
                        Me.Close()
                    End If
                Case "ESTUDIOS"
                    If MessageBox.Show("Desea Realizar los Cambios?", "Auditoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        AuditoriaEstudios()
                        Me.Close()
                        MsgBox("Se realizaron los cambios satisfactoriamente")
                    Else
                        Me.Close()
                    End If
            End Select

        Else
            MessageBox.Show("El Usuario no tiene Permisos para Realizar los Cambios", "Auditoria", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.Close()
        End If


        'validamos el Usuario que Confirma


        'Select Case Formulario
        ' Case "USUARIO"
        ' Case "ESTUDIO"
        '
        '       End Select
        '      MsgBox(Licencia & " " & IdEmpleado & " " & Formulario)
    End Sub

    Private Sub frmConfirmarAuditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = Nothing
        txtPass.Text = Nothing
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
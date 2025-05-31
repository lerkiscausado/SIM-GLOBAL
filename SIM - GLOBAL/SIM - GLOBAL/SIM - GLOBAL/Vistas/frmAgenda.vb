Imports DevExpress.Utils
Imports DevExpress.XtraScheduler
Imports SIM___GLOBAL.Controles
Imports SIM___GLOBAL.My.Modelo
Imports DevExpress.XtraPrinting
Imports System.Net.Mail
Imports System.Net
Imports System.Web.UI.Design
Imports System.Text
Imports System.IO
Public Class frmAgenda
    Dim _idAgenda As String
    Dim _ClickGrilla As String
    Dim _ClickEMail As String
    Dim _ClickFecha As Date
    Dim _ClickPaciente As String
    Dim _ClickIdTipoEstudio As String
    Dim _Fila As String
    Dim _Nota As String
    Dim _ds As DataSet

    Dim _Agenda As New Agenda
    Dim _DAgenda As New DAgenda
    Dim _DUsuarios As New DUsuarios
    Public _Empleado As String
    Public idEmpleado As String
    Public Licencia As String
    Public UsuarioAgenda1 As String
    Public UsuarioAgenda2 As String
    Private Sub ActivaGuardar()
        If cboMedico.Text <> "" Then
            bbiGuardar.Enabled = True
        End If
    End Sub
    Private Sub EditarAgenda()
        _Agenda = _DAgenda.Cargar(_idAgenda)

        dtFecha.Text = _Agenda.Fecha
        dtFechaSolicitudCita.Text = _Agenda.FechaAgenda
        dtFechaSolicitadaPaciente.Text = _Agenda.FechaSolicitada
        teHora.EditValue = Format(_Agenda.Hora, "hh:mm")
        cboUsuarios.EditValue = _Agenda.IdUsuario
        cboContrato.Text = _Agenda.Nota
        'cboTipoEstudio.Properties.ValueMember = "12"
        cboTipoEstudio.ItemIndex = cboTipoEstudio.Properties.GetDataSourceRowIndex("ID", _Agenda.IdTipoEstudio)
        'cboMedico.Enabled = False
        dtFecha.Enabled = False
        dtFechaSolicitudCita.Enabled = True
        dtFechaSolicitadaPaciente.Enabled = True
        cboUsuarios.Enabled = True
        cboTipoEstudio.Enabled = True
        cboProcedimiento.Enabled = True
        cboContrato.Enabled = True ' linea de codigo agregada

        Select Case Licencia
            Case 4
                Select Case idEmpleado
                    Case UsuarioAgenda1, UsuarioAgenda2
                        'ADMINISTRADOR
                        teHora.Enabled = True
                        cboContrato.Enabled = True
                    Case Else
                        'USUARIO
                        teHora.Enabled = True
                        cboContrato.Enabled = True ' linea de codigo habilitada
                End Select
            Case Else
                teHora.Enabled = True
                cboContrato.Enabled = True
        End Select
        bbiGuardar.Enabled = False
    End Sub
    Private Sub EnviarMail(ByVal EMail As String, ByVal Texto As String, ByVal Asunto As String)
        Dim smtp = New System.Net.Mail.SmtpClient
        Dim correo = New System.Net.Mail.MailMessage
        'Dim adjunto As System.Net.Mail.Attachment

        With smtp
            .Port = "587"
            .Host = "mail.diteg.com.co"
            .Credentials = New System.Net.NetworkCredential("info@diteg.com.co", "InfoDiteg2020")
            .EnableSsl = True
        End With

        'adjunto = New System.Net.Mail.Attachment("D:\4203.pdf")
        With correo
            .From = New System.Net.Mail.MailAddress("info@diteg.com.co")
            .To.Add(EMail)
            '.To.Add("cristian.merinoav@hotmail.com")
            .Subject = Asunto
            .Body = Texto
            .IsBodyHtml = False
            .Priority = System.Net.Mail.MailPriority.Normal
            '            .Attachments.Add(adjunto)

        End With

        Try
            smtp.Send(correo)
            MessageBox.Show("Se ha enviado un correo al paciente confirmando su cita.",
                            "Correo enviado",
                             MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message,
                            "Error al enviar correo",
                             MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub NuevaAgenda()
        'formateamos la hora
        teHora.EditValue = DateTime.Now
        teHora.Properties.DisplayFormat.FormatType = FormatType.DateTime
        teHora.Properties.DisplayFormat.FormatString = "t"
        teHora.Properties.EditFormat.FormatType = FormatType.DateTime
        teHora.Properties.EditFormat.FormatString = "t"

        cboUsuarios.EditValue = Nothing
        cboContrato.EditValue = Nothing
        cboTipoEstudio.EditValue = Nothing
        cboProcedimiento.EditValue = Nothing
        bbiGuardar.Enabled = False
        _ClickGrilla = Nothing
        _ClickEMail = Nothing
        _idAgenda = Nothing

        cboContrato.Enabled = True
        teHora.Enabled = True
        cboUsuarios.Enabled = True
        cboTipoEstudio.Enabled = True
        cboProcedimiento.Enabled = True
        dtFechaSolicitudCita.Enabled = True
        dtFechaSolicitadaPaciente.Enabled = True

        dtFechaSolicitudCita.Text = Format(DateTime.Now, "dd/MM/yyyy")
        Select Case Licencia
            Case 14
                dtFechaSolicitadaPaciente.Text = Format(DateTime.Now, "dd/MM/yyyy")
            Case Else
                dtFechaSolicitadaPaciente.Text = ""
        End Select

    End Sub
    Private Sub LimpiarCampos()

        'formateamos la hora
        teHora.EditValue = DateTime.Now
        teHora.Properties.DisplayFormat.FormatType = FormatType.DateTime
        teHora.Properties.DisplayFormat.FormatString = "t"
        teHora.Properties.EditFormat.FormatType = FormatType.DateTime
        teHora.Properties.EditFormat.FormatString = "t"

        cboUsuarios.EditValue = Nothing
        cboContrato.EditValue = Nothing
        cboTipoEstudio.EditValue = Nothing
        cboProcedimiento.EditValue = Nothing
        bbiGuardar.Enabled = False
        _ClickGrilla = Nothing
        _ClickEMail = Nothing
        _idAgenda = ""
        dtFechaSolicitudCita.Text = Format(DateTime.Now, "dd/MM/yyyy")

        Select Case Licencia
            Case 14
                dtFechaSolicitadaPaciente.Text = Format(DateTime.Now, "dd/MM/yyyy")
            Case Else
                dtFechaSolicitadaPaciente.Text = ""
        End Select

        'bloqueamos campos
        cboContrato.Enabled = False
        teHora.Enabled = False
        cboUsuarios.Enabled = False
        cboTipoEstudio.Enabled = False
        cboProcedimiento.Enabled = False
        dtFechaSolicitudCita.Enabled = False
        dtFechaSolicitadaPaciente.Enabled = False
        DNFecha.Enabled = True

    End Sub
    Private Sub AgendaDia()
        ' Cargar agenda del dia
        _ds = _DAgenda.Listar(cboMedico.EditValue, Format(DNFecha.DateTime, "yyyy-MM-dd"))
        If _ds IsNot Nothing AndAlso _ds.Tables.Count > 0 AndAlso _ds.Tables(0).Rows.Count > 0 Then
            ' Hay datos
            GCAgenda.DataSource = _ds.Tables(0)
        Else
            ' No hay datos
            MessageBox.Show("No se encontraron registros para ese médico y fecha.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GCAgenda.DataSource = Nothing ' opcional: limpiar el grid
        End If

        'riteHora.DisplayFormat.FormatType = FormatType.DateTime
        'riteHora.DisplayFormat.FormatString = "t"

        'riteHora.EditFormat.FormatType = FormatType.DateTime
        'riteHora.EditFormat.FormatString = "t"

    End Sub

    Private Sub DNFecha_DateTimeChanged(sender As Object, e As EventArgs) Handles DNFecha.DateTimeChanged
        GCFecha.Text = "Fecha Actual: " & Format(DNFecha.DateTime, "D")
        dtFecha.Text = DNFecha.DateTime
        If cboMedico.Text <> "" Then
            LimpiarCampos()
            'MessageBox.Show(cboMedico.EditValue)
            Dim _dAgenda = New DAgenda
            If _dAgenda.ExisteDia(cboMedico.EditValue, DNFecha.DateTime) = False Then
                _dAgenda.Dia(cboMedico.EditValue, idEmpleado, DNFecha.DateTime)
            End If
            AgendaDia()
            '_ClickGrilla = ""



            'MsgBox(DNFecha.DateTime)
            'AgendaDia()

        End If


        'PROCESO DE CARGA

        '_ds = _dAgenda.Listar(Format(DNFecha.DateTime, "yyyy/MM/dd"))
        'GCAgenda.DataSource = _ds.Tables(0)
    End Sub

    Private Sub frmAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bbiConfigurarAgenda.Visibility = 1
        colFECHA.Visible = False
        dtFecha.Text = DNFecha.DateTime

        'formateamos la hora
        teHora.EditValue = DateTime.Now
        teHora.Properties.DisplayFormat.FormatType = FormatType.DateTime
        teHora.Properties.DisplayFormat.FormatString = "t"
        teHora.Properties.EditFormat.FormatType = FormatType.DateTime
        teHora.Properties.EditFormat.FormatString = "t"


        ' Cargar Especialista
        Dim _Despecialista = New SIM___GLOBAL.Controles.DEspecialista
        _ds = _Despecialista.ListarCombo
        cboMedico.Properties.DataSource = _ds.Tables(0)
        cboMedico.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboMedico.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboMedico.ItemIndex = -1

        ' Cargar Tipo Estudio
        Dim _DTipoEstudio = New DTipoEstudio
        _ds = _DTipoEstudio.Listar
        cboTipoEstudio.Properties.DataSource = _ds.Tables(0)
        cboTipoEstudio.Properties.DisplayMember = _ds.Tables(0).Columns(1).Caption
        cboTipoEstudio.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboTipoEstudio.ItemIndex = 0

        ' Cargar Usuarios
        Dim _DUsuarios = New DUsuarios
        _ds = _DUsuarios.ListarCombo
        cboUsuarios.Properties.DataSource = _ds.Tables(0)
        cboUsuarios.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboUsuarios.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        'cboUsuarios.ItemIndex = -1

        ' Cargar Contratos
        Dim _DContratos = New DContratos
        _ds = _DContratos.ListarCombo
        cboContrato.Properties.DataSource = _ds.Tables(0)
        cboContrato.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboContrato.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        cboContrato.ItemIndex = -1

        UsuarioAgenda1 = "19" 'Administrador 26
        UsuarioAgenda2 = "23" 'Administrador 23

        Select Case Licencia
            Case 4
                Select Case idEmpleado
                    Case UsuarioAgenda1, UsuarioAgenda2
                        'ADMINISTRADOR
                        bbiConfigurarAgenda.Visibility = 0
                        bbiEliminarRegistros.Visibility = 0
                        cboTipoEstudio.Visible = True
                    Case Else
                        'USUARIOS
                        bbiConfigurarAgenda.Visibility = 1
                        bbiEliminarRegistros.Visibility = 1
                        cboProcedimiento.Visible = True
                End Select
                bbiEditarAgenda.Visibility = 1
            Case Else
                'USUARIOS
                bbiConfigurarAgenda.Visibility = 1
                bbiEliminarRegistros.Visibility = 1
                cboProcedimiento.Visible = True
        End Select

        'bloqueo de campos
        LimpiarCampos()
    End Sub

    Private Sub GVAgenda_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs)

        If GVAgenda.GetFocusedRowCellValue("FECHA") < DateTime.Now Then
            MessageBox.Show("La Fecha seleccionada no puede ser MENOR a la fecha Actual", "AGENDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'GuardarOrden()
            'TODO: esta línea de código carga datos en la tabla 'DSVistas.DTOrdenesAtendidas' Puede moverla o quitarla según sea necesario.
            'Me.DTAgendaTableAdapter.Fill(Me.DSVistas.DTAgenda)
            'MsgBox(GVOrdenesAtendidas.RowCount)
        End If
    End Sub
    Private Sub Mail()
        'Creamos un nuevo objeto MailMessage donde especificamos el "From" y el "To"
        Dim correo As New System.Net.Mail.MailMessage("info@diteg.com.co", "cristian.merinoav@hotmail.com")
        correo.Subject = "Probando el asunto"
        correo.Body = "Estamos realizando una prueba"
        Dim mailclient As New System.Net.Mail.SmtpClient()
        'Creamos el objeto que va a "preparar" la autentificación
        Dim autentificacion As New System.Net.NetworkCredential("info@diteg.com.co", "InfoDiteg2020")
        'Incluimos esta información a la hora de logarnos en el servidor
        mailclient.Port = "587"
        mailclient.Host = "mail.diteg.com.co"
        mailclient.UseDefaultCredentials = False
        mailclient.EnableSsl = True
        mailclient.Credentials = autentificacion
        mailclient.Send(correo)
    End Sub
    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        'Mail()
        If Licencia = 4 Then ' GASTROLAP
            _idAgenda = _ClickGrilla
            If _idAgenda = "" Then
                MessageBox.Show("Debe Seleccionar Agenda a Crear", "Nueva Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf _ClickFecha < Format(DateTime.Now, "dd/MM/yyyy") Then
                MessageBox.Show("Fecha no Valida para crear Cita", "Nueva Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' habilitamos los procedimientos a la agenda

                cboTipoEstudio.Visible = False ' estaba en false
                cboProcedimiento.Visible = True

                teHora.Enabled = False
                EditarAgenda()
            End If
        Else
            NuevaAgenda()
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        'txtNota.Enabled = True
        'txtNota.Text = _Nota
        'txtNota.Focus()
        bbiGuardar.Enabled = False
        bbiCancelar.Enabled = False
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        'MsgBox(DNFecha.DateTime & " - " & Format(DateTime.Now, "dd/MM/yyyy"))
        If cboMedico.Text = "" Then
            MessageBox.Show("Debe Seleccionar el Especialista", "ASIGNAR CITA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboUsuarios.EditValue = Nothing And idEmpleado <> UsuarioAgenda1 And idEmpleado <> UsuarioAgenda2 Then
            MessageBox.Show("Debe Seleccionar un Usuario", "ASIGNAR CITA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboContrato.Text = "" Then
            MessageBox.Show("Debe Seleccionar un Contrato", "ASIGNAR CITA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboProcedimiento.Text = "" And cboProcedimiento.Visible = True Then
            MessageBox.Show("Debe Seleccionar un Estudio", "ASIGNAR CITA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ElseIf cboTipoEstudio.Text = "" And cboTipoEstudio.Visible = True Then
            'MessageBox.Show("Debe Seleccionar un Estudio", "ASIGNAR CITA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf DNFecha.DateTime < Format(DateTime.Now, "dd/MM/yyyy") Then
            MessageBox.Show("Fecha no Valida para apartar Cita, la fecha debe ser mayor a la fecha actual", "ASIGNAR CITA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaSolicitudCita.Text = "" Then
            MessageBox.Show("Fecha Solicitud es obligatoria", "ASIGNAR CITA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dtFechaSolicitadapaciente.Text = "" Then
            MessageBox.Show("Fecha Solicitada es obligatoria", "ASIGNAR CITA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _Agenda.Id = Val(_idAgenda)
            _Agenda.Fecha = DNFecha.DateTime
            _Agenda.FechaAgenda = dtFechaSolicitudCita.Text
            _Agenda.FechaSolicitada = dtFechaSolicitadaPaciente.Text
            _Agenda.Hora = teHora.EditValue

            Select Case Licencia
                Case 4
                    If cboUsuarios.EditValue = Nothing And (idEmpleado = UsuarioAgenda1 Or idEmpleado = UsuarioAgenda2) Then
                        _Agenda.IdUsuario = 1
                        cboUsuarios.EditValue = 1
                    Else
                        _Agenda.IdUsuario = cboUsuarios.EditValue
                    End If
                Case Else
                    _Agenda.IdUsuario = cboUsuarios.EditValue
            End Select

            If cboTipoEstudio.Visible = True Then
                _Agenda.IdTipoEstudio = cboTipoEstudio.EditValue
                _Agenda.CodigoCups = ""
                _Agenda.NombreCups = ""
            Else
                _Agenda.IdTipoEstudio = _ClickIdTipoEstudio
                _Agenda.CodigoCups = cboProcedimiento.EditValue
                _Agenda.NombreCups = cboProcedimiento.Text

            End If

            _Agenda.IdContrato = cboContrato.EditValue
            _Agenda.Nota = cboContrato.Text
            _Agenda.IdEmpleado = idEmpleado
            _Agenda.IdEspecialista = cboMedico.EditValue
            _Agenda.IdOrden = Val("0")

            If Licencia = 4 And cboUsuarios.EditValue = 1 Then
                Select Case idEmpleado
                    Case UsuarioAgenda1, UsuarioAgenda2
                        _Agenda.Estado = "DISPONIBLE"
                    Case Else
                        _Agenda.Estado = "APARTADA"
                End Select
            Else
                _Agenda.Estado = "APARTADA"
            End If
            _DAgenda.GuardarCita(_Agenda)

            bbiGuardar.Enabled = False

            '************************ Actualizamos la grilla **********************************
            _ds = _DAgenda.Listar(cboMedico.EditValue, Format(DNFecha.DateTime, "yyyy-MM-dd"))
            GCAgenda.DataSource = _ds.Tables(0)

            Select Case Licencia
                Case 3 ' Diteg envio de correo 
                    If _ClickEMail <> "" Then
                        Dim Texto As String
                        _ds = _DAgenda.UltimoPacienteAgenda()
                        Texto = "Estimad@ " & _ds.Tables(0).Rows(0)(0).ToString() & ", tienes una nueva cita:" & vbCrLf
                        Texto = Texto & "Fecha: " & _ds.Tables(0).Rows(0)(1).ToString() & " a las " & _ds.Tables(0).Rows(0)(2).ToString() & vbCrLf
                        Texto = Texto & "Estudio: " & _ds.Tables(0).Rows(0)(3).ToString() & vbCrLf
                        Texto = Texto & "Medico: " & _ds.Tables(0).Rows(0)(4).ToString()
                        EnviarMail(_ClickEMail, Texto, "Su cita de " & _ds.Tables(0).Rows(0)(3).ToString() & " ha sido confirmada")

                    End If
                Case Else

            End Select

            LimpiarCampos()
        End If
    End Sub

    Private Sub bbiCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancelar.ItemClick
        Dim Estado As String = ""
        If _ClickGrilla <> "" Then
            Estado = _DAgenda.EstadoCita(_ClickGrilla)
        End If

        If _ClickGrilla = "" Then
            MessageBox.Show("Debe Seleccionar Cita a Cancelar", "Cancelar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _ClickFecha < Format(DateTime.Now, "dd/MM/yyyy") Then
            MessageBox.Show("Fecha no Valida para Cancelar Cita", "Cancelar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Estado = "ATENDIDA" Or Estado = "DISPONIBLE" Or Estado = "CANCELADA" Then
            MessageBox.Show("La cita no puede ser cancelada", "Cancelar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _frmOpen As New SIM___GLOBAL.frmCancelacionCitas
            _frmOpen.txtPaciente.Text = _ClickPaciente
            _frmOpen.IdAgenda = _ClickGrilla
            _frmOpen.Dia = _ClickFecha
            _frmOpen.Licencia = Licencia
            _frmOpen.ShowDialog()

            AgendaDia()
            _ClickGrilla = ""
        End If
        '************************ Actualizamos la grilla **********************************
        '_ds = _DAgenda.Listar(Format(DNFecha.DateTime, "yyyy/MM/dd"))
        'GCAgenda.DataSource = _ds.Tables(0)
    End Sub

    Private Sub bwCargar_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
        If e.Cancelled Then
            MessageBox.Show("Laación ha sido cancelada.")
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show("Seroducido un error durante la ejecución: " & e.Error.Message)
        Else
            'Mostramos los resultados de las consultas
            '  ppCargar.Visible = False
            ' GCAgenda.DataSource = _ds.Tables(0)

        End If
    End Sub

    Private Sub bwCargar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        ' Dim _dAgenda = New DAgenda
        ' _ds = _dAgenda.Listar(Format(DNFecha.DateTime, "yyyy/MM/dd"))

    End Sub

    Private Sub cboMedico_EditValueChanged(sender As Object, e As EventArgs) Handles cboMedico.EditValueChanged
        AgendaDia()
        'ActivaGuardar()
        'colHora.DisplayFormat.FormatType = FormatType.DateTime
        'colHora.DisplayFormat.FormatString = "T"
        LimpiarCampos()
    End Sub

    Private Sub cboUsuarios_EditValueChanged(sender As Object, e As EventArgs) Handles cboUsuarios.EditValueChanged
        '------------Traemos datos usuarios--------------
        If cboUsuarios.EditValue <> "1" Then
            _ds = New DataSet
            _ds = _DUsuarios.DatosUsuarioCARD(cboUsuarios.EditValue)
            GCDatosUsuarios.DataSource = _ds.Tables(0)
        End If
        ActivaGuardar()
    End Sub

    Private Sub cboContrato_EditValueChanged(sender As Object, e As EventArgs) Handles cboContrato.EditValueChanged


        'llenamos combo procedimientos
        Dim _DDetalleTarifa As New SIM___GLOBAL.Controles.DDetalleTarifas
        _ds = New DataSet()
        _ds = _DDetalleTarifa.ListarCombo2(cboContrato.GetColumnValue("ID"))
        cboProcedimiento.Properties.DataSource = _ds.Tables(0)
        cboProcedimiento.Properties.DisplayMember = _ds.Tables(0).Columns(3).Caption
        cboProcedimiento.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption

        'llenamos combo subentidades
        Dim _DSubentidades = New DSudentidades
        _ds = New DataSet()

        '----------------------------------------------
        ActivaGuardar()
    End Sub

    Private Sub cboTipoEstudio_EditValueChanged(sender As Object, e As EventArgs) Handles cboTipoEstudio.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub GVAgenda_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVAgenda.RowClick
        If e.RowHandle >= 0 Then
            _ClickGrilla = GVAgenda.GetRowCellValue(e.RowHandle.ToString, "ID").ToString()
            _ClickFecha = GVAgenda.GetRowCellValue(e.RowHandle.ToString, "FECHA").ToString()
            _ClickPaciente = GVAgenda.GetRowCellValue(e.RowHandle.ToString, "PACIENTE").ToString()
        End If
    End Sub

    Private Sub bbiUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUsuarios.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmUsuarios
        _frmOpen.Licencia = Licencia
        _frmOpen.IdEmpleado = idEmpleado
        _frmOpen.ShowDialog()

        ' Cargar Usuarios
        Dim _DUsuarios = New DUsuarios
        _ds = _DUsuarios.ListarCombo
        cboUsuarios.Properties.DataSource = _ds.Tables(0)
        cboUsuarios.Properties.DisplayMember = _ds.Tables(0).Columns(2).Caption
        cboUsuarios.Properties.ValueMember = _ds.Tables(0).Columns(0).Caption
        'cboUsuarios.ItemIndex = -1
    End Sub

    Private Sub bbiEditarAgenda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditarAgenda.ItemClick
        _idAgenda = _ClickGrilla
        If _idAgenda = "" Then
            MessageBox.Show("Debe Seleccionar Agenda a Editar", "Editar Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf DNFecha.DateTime < Format(DateTime.Now, "dd/MM/yyyy") Then
            MessageBox.Show("Fecha no Valida para Editar Cita", "Editar Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            EditarAgenda()
        End If
    End Sub

    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        If GVAgenda.RowCount <> 0 Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            Dim fechaAgenda As Date = dtFecha.Text
            ImprimirFrm.ImprimirAgenda(Format(fechaAgenda, "yyyy/MM/dd"), cboMedico.EditValue)
        Else
            MessageBox.Show("No se ha registrado agenda", "Imprimir Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub GVAgenda_PrintInitialize(sender As Object, e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GVAgenda.PrintInitialize
        Dim pb As PrintingSystemBase = CType(e.PrintingSystem, PrintingSystemBase)
        pb.PageSettings.Landscape = True
        'pb.PageSettings.UsablePageSize.
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        If GVAgenda.OptionsFind.AlwaysVisible = True Then
            GVAgenda.OptionsFind.AlwaysVisible = False
            _ds = _DAgenda.Listar(cboMedico.EditValue, Format(DNFecha.DateTime, "yyyy-MM-dd"))
            GCAgenda.DataSource = _ds.Tables(0)
            colFECHA.Visible = False
        Else
            GVAgenda.OptionsFind.AlwaysVisible = True
            ' Cargar agenda Completa
            _ds = _DAgenda.ListarAgenda
            GCAgenda.DataSource = _ds.Tables(0)
            colFECHA.Visible = True
        End If
    End Sub

    Private Sub GVUsuarios_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVUsuarios.RowClick
        If e.RowHandle >= 0 Then
            _ClickEMail = GVUsuarios.GetRowCellValue(e.RowHandle.ToString, "EMAIL").ToString()
            'MsgBox(_ClickEMail)
        End If
    End Sub

    Private Sub teHora_EditValueChanged(sender As Object, e As EventArgs) Handles teHora.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub bbiConfigurarAgenda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConfigurarAgenda.ItemClick
        'If _idAgenda = Nothing Then
        _idAgenda = Nothing
        cboUsuarios.EditValue = 1
        cboUsuarios.Enabled = False
        'cboTipoEstudio.EditValue = 8
        cboTipoEstudio.ItemIndex = cboTipoEstudio.Properties.GetDataSourceRowIndex("ID", 8)
        cboContrato.EditValue = Nothing
        cboContrato.Enabled = True
        teHora.Enabled = True
        cboTipoEstudio.Enabled = True
        cboProcedimiento.Visible = False
        cboTipoEstudio.Visible = True
        dtFechaSolicitadaPaciente.Text = DNFecha.DateTime
        'End If
    End Sub

    Private Sub bbiEliminarRegistros_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminarRegistros.ItemClick
        If _ClickGrilla = "" Then
            MessageBox.Show("Debe Seleccionar el registro", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _clickfecha < Format(DateTime.Now, "dd/MM/yyyy") Then
            MessageBox.Show("Este registro no se puede eliminar", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                _DAgenda.EliminarRegistro(_ClickGrilla)
                AgendaDia()
                _ClickGrilla = ""
            End If
        End If
    End Sub

    Private Sub dtFechaSolicitudCita_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaSolicitudCita.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub dtFechaSolicitadaPaciente_EditValueChanged(sender As Object, e As EventArgs) Handles dtFechaSolicitadaPaciente.EditValueChanged
        ActivaGuardar()
    End Sub

    Private Sub cboGVProcedimientos_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles cboGVProcedimientos.RowClick
        If e.RowHandle >= 0 Then
            _ClickIdTipoEstudio = cboGVProcedimientos.GetRowCellValue(e.RowHandle.ToString, "TIPOESTUDIO").ToString()
        End If
    End Sub


End Class
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Controles
Imports System.IO

Public Class frmInicio
    'VARIABLES GLOBALES 
    Public ContadorFotos As Byte
    ReadOnly _funciones As New Funciones
    ' Dim _frmConsultar As New frmConsultar


    '-----------------------
    Dim conectar = New ConexionODBC
    Dim _conn As OdbcConnection
    'Dim _user As New DUsers
    Dim cerrar As Boolean = True
    Dim _Users As New SIM___GLOBAL.Modelo.Users
    Dim _dUsers As New SIM___GLOBAL.Controles.DUsers

    Dim _dImpresionHistoria As New SIM___GLOBAL.Controles.DImpresionHistoria
    Dim _ImpresionHistoria As New SIM___GLOBAL.Modelo.ImpresionHistoria
    Dim _dImpresionDetalleHistoria As New SIM___GLOBAL.Controles.DImpresionDetalleHistoria

    Dim _dImpresionEndoscopia As New SIM___GLOBAL.Controles.DImpresionEndoscopia
    Dim _ImpresionEndoscopia As New SIM___GLOBAL.Modelo.ImpresionEndoscopia

    ' Clases Cierre Sesion
    Dim _frmConsultar As SIM_ENDOSCOPIA.frmConsultar
    Dim _frmAgenda As SIM___GLOBAL.frmAgenda
    Dim _frmHistoria As SIM_ENDOSCOPIA.frmHistoria
    Dim _frmHistoriaGL As SIM_ENDOSCOPIA.frmHistoriaGL
    Dim _frmEndoscopia As SIM_ENDOSCOPIA.frmEndoscopia
    Dim _frmEndoscopiaGl As SIM_ENDOSCOPIA.frmEndoscopiaGL
    Dim _frmEstudiosEspeciales As SIM_ENDOSCOPIA.frmEstudiosEspeciales
    Dim _frmOrtodoncia As SIM___GLOBAL.frmOrtodoncia
    'Dim _frmImagenes As SIM___GLOBAL.frmImagenes
    Dim _frmImagenes As SIM___GLOBAL.frmImagenesVideo
    Dim _frmFacturacion As SIM___GLOBAL.frmFacturas


    Private Sub HabilitarPrivilegios(ByVal Filtro As String)
        Select Case Filtro
            Case 4 'Gastrolap
                'Ordenbes de Atencion
                rpgOrdenesAtencion.Visible = True
                bbtNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbtEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbtCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbtConsultar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbtAdjuntos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAgenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'Estudios
                bbtHistoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbtHistoriasAnteriores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbtProgramacionProcedimientos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEndoscopia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImagenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOtrosEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'Contable
                rpgContable.Visible = False

                'Reportes
                rpgReportes.Visible = False

                'Ficha Administracion
                rpgAdministracion.Visible = False

                'Configuracion - Reportes
                rpgOtrosReportes.Visible = False

                'sistema
                bbiUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiSeguridad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPrivilegios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiAuditoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Case 20 'Gastrolap

                bbtEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbiDetalleTarifa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Case 9 'Administrador
                'Ordenbes de Atencion
                bbtNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbtEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbtCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbtConsultar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbtAdjuntos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiAgenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Estudios
                bbtHistoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbtHistoriasAnteriores.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiHistoriaGrupal.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEvolucionPaciente.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbtProgramacionProcedimientos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiCitologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPatologia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiEndoscopia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImagenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiOtrosEstudios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'contable
                bbiListadoOrdenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFactura.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiRips.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'reportes
                bbiVistaPrevia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiImprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'ventana
                'Administracion
                'Configuracion
                'Reportes
                bbiEncabezadoPie.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiLogo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiFirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'sistema
                bbiUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiSeguridad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbiPrivilegios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Ayuda




        End Select

    End Sub
    Private Sub CargarPrivilegios(ByVal filtro As String)
        _Users = _dUsers.Cargar(filtro)
        'ORDENES DE ATENCION
        bbtNuevo.Enabled = _Users.Nuevo
        bbtEditar.Enabled = _Users.Editar
        bbtCancelar.Enabled = _Users.Anular
        bbtConsultar.Enabled = _Users.Consultar
        bbtAdjuntos.Enabled = _Users.Adjuntos
        bbiAgenda.Enabled = _Users.Agenda
        'ESTUDIOS
        bbtHistoria.Enabled = _Users.HistoriaClinica
        bbtHistoriasAnteriores.Enabled = _Users.HistoriaAnteriores
        bbiHistoriaGrupal.Enabled = _Users.HistoriaGrupal
        bbiEvolucionPaciente.Enabled = _Users.EvolucionPaciente
        bbtProgramacionProcedimientos.Enabled = _Users.ProgramacionCirugia
        bbiCitologia.Enabled = _Users.Citologia
        bbiPatologia.Enabled = _Users.Patologia
        bbiEndoscopia.Enabled = _Users.Endoscopia
        bbiImagenes.Enabled = _Users.AdjuntarImagenes
        'CONTABLE
        bbiListadoOrdenes.Enabled = _Users.ListadoOrdenes
        bbiFactura.Enabled = _Users.GenerarFactura
        bbiRips.Enabled = _Users.Rips
        'inventario = _Users.Inventario
        'nomina = _Users.Nomina
        'REPORTES
        bbiVistaPrevia.Enabled = _Users.VistaPrevia
        bbiImprimir.Enabled = _Users.Imprimir
        'Indicadores = _Users.IndicadoresGestion
        'PACIENTES
        bbtUsuarios.Enabled = _Users.Usuarios
        'CONTRATACION
        bbiEntidades.Enabled = _Users.Entidades
        bbiSubEntidades.Enabled = _Users.SubEntidades
        bbiContratos.Enabled = _Users.Contratos
        bbiTarifas.Enabled = _Users.Tarifas
        bbiDetalleTarifa.Enabled = _Users.DetalleTarifas
        'TALENTO HUMANO
        bbiCargos.Enabled = _Users.Cargos
        bbiEspecialidades.Enabled = _Users.Especialidades
        bbiEmpleados.Enabled = _Users.Empleados
        'COMPLEMENTOS
        bbtExamanes.Enabled = _Users.Examenes
        bbtMedicamentos.Enabled = _Users.Medicamentos
        bbiCups.Enabled = _Users.Cups
        bbtDiagnosticos.Enabled = _Users.Cie10
        bbiTipoPatologia.Enabled = _Users.TipoPatologia
        bbiEstudiosPredeterminados.Enabled = _Users.EstudiosPredeterminados
        bbiEquipos.Enabled = _Users.EquiposApoyo
        bbiTerapeuticos.Enabled = _Users.ProcedimientoTerapeutico
        'REPORTES
        bbiEncabezadoPie.Enabled = _Users.EncabezadoPiedepagina
        bbiLogo.Enabled = _Users.Logo
        bbiFirma.Enabled = _Users.Firma
        'SISTEMA
        bbiUsers.Enabled = _Users.Users
        bbiSeguridad.Enabled = True
        bbiPrivilegios.Enabled = _Users.Privilegios
        'CONTENIDO SIM
        bbiAyudaProducto.Enabled = _Users.AyudaProducto
        bbiSoporteTecnico.Enabled = _Users.SoporteTecnico
        bbiTutoriales.Enabled = _Users.Tutoriales
        bbiAcercaDe.Enabled = _Users.Acercade


    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Selecciona el SKIN predeterminado
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013")
        'INICIAR CONEXION BASE DE DATOS
        Try
            conectar.Cadena = String.Format("Dsn=SIMDB;uid=unidadde_admin;pwd=80082552700ers")
            _conn = conectar.Open()
            cerrar = False
        Catch ex As Exception
        End Try
        '-----------------------------
        '******** Formulario Inicio de Sesion 
        'Dim _frmOpen As New frmSesion
        ' _frmOpen.ShowDialog()
        '
        '       If _frmOpen.validar = True Then
        '       IdEmpleado = _frmOpen.IDEmpleado
        '       lblUsers.Caption = _frmOpen.NombreEmpleado

        'CARGAR PRIVILEGIOS


        '******** Formulario Inicio de Sesion 
        Dim _frmOpen As New SIM___GLOBAL.frmSesion
        _frmOpen.ShowDialog()

        If _frmOpen.validar = True Then
            IdEmpleadoG = _frmOpen.IDEmpleado
            lblUsers.Caption = _frmOpen.NombreEmpleado
            LicenciaG = _frmOpen.Licencia
            Me.Text = "SIM  Sistema Integrado Medico - Licencia Autorizada a: " & _frmOpen.NombreLicencia
            HabilitarPrivilegios(LicenciaG)
            CargarPrivilegios(IdEmpleadoG)

        Else
            End
        End If
    End Sub

    Private Sub bbtExamanes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtExamanes.ItemClick
        'Dim _frmOpen As New frmExamenes
        '_frmOpen.ShowDialog()
    End Sub

    Private Sub bbtProcedimientos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCups.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCups
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtDiagnosticos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtDiagnosticos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmDiagnosticos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtMedicamentos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtMedicamentos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmMedicamentos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtUsuarios.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmUsuarios
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        Formulario = Nothing
        'Dim _frmOpen As New SIM_ENDOSCOPIA.frmOrdenes
        Dim _frmOpen As New SIM___GLOBAL.frmOrdenes
        IDDetalleOrdenG = Nothing
        'Registro = ""
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtConsultar.ItemClick
        If Funciones.IsLoaded("frmConsultar") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Consultar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmConsultar = New SIM_ENDOSCOPIA.frmConsultar
            _frmConsultar.MdiParent = Me
            _frmConsultar.Recargar("2020")
            _frmConsultar.Show()
        End If
    End Sub

    Private Sub bbtEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtEditar.ItemClick
        If IDDetalleOrdenG <> Nothing Then
            Formulario = "Editar"
            Dim _DdetalleOrden = New SIM___GLOBAL.Controles.DDetalleOrden
            Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden

            If _DdetalleOrden.DetalleOrdenPendienteEndoscopia(IDDetalleOrdenG) = True Then
                'MsgBox("EDITAR")
                Dim _frmOpen As New frmOrdenes
                _frmOpen.SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
                _frmOpen.Size = New Size(750, 600)
                _frmOpen.StartPosition = FormStartPosition.CenterScreen
                _frmOpen.ShowDialog()

            Else
                MessageBox.Show("Esta orden ya fue Atendida o Cancelada", "Editar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Editar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbtAdjuntos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtAdjuntos.ItemClick
        If IDORdenG <> Nothing Then
            Dim _frmOpen As New SIM___GLOBAL.frmAdjuntos
            _frmOpen.Orden = IDORdenG
            _frmOpen.ShowDialog()

        Else
            MessageBox.Show("Debe Seleccionar una Orden para Adjuntar Archivos", "Adjuntar Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbtCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtCancelar.ItemClick
        If IDDetalleOrdenG <> Nothing Then
            'Dim _Dorden = New DOrdenes
            Dim _DDetalleOrden = New SIM___GLOBAL.Controles.DDetalleOrden
            If _DDetalleOrden.DetalleOrdenPendienteEndoscopia(IDDetalleOrdenG) = True Then
                If MessageBox.Show("¿Desea cancelar el estudio o historia?", "Cancelar Estudio/Historia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    _DDetalleOrden.CancelarDetalleOrden(IDDetalleOrdenG)
                    Dim funciones = New Funciones
                    funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
                End If
            Else
                MessageBox.Show("El estudio o historia no se puede cancelar", "Cancelar Estudio/Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe seleccionar un estudio o historia", "Cancelar Estudio/Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbtHistoria_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtHistoria.ItemClick
        If Funciones.IsLoaded("frmHistoria") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Historia Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Select Case LicenciaG
                Case 3 ' DITEG
                    _frmHistoria = New SIM_ENDOSCOPIA.frmHistoria
                    _frmHistoria.Licencia = LicenciaG
                    _frmHistoria.IdEmpleado = IdEmpleadoG
                    _frmHistoria.MdiParent = Me
                    _frmHistoria.Show()
                Case 4 ' Gastrolap
                    _frmHistoria = New SIM_ENDOSCOPIA.frmHistoria
                    _frmHistoria.Licencia = LicenciaG
                    _frmHistoria.IdEmpleado = IdEmpleadoG
                    _frmHistoria.MdiParent = Me
                    _frmHistoria.Show()
                Case 9 ' ADOS ADMINISTRADOR
                    _frmHistoriaGL = New SIM_ENDOSCOPIA.frmHistoriaGL
                    _frmHistoriaGL.MdiParent = Me
                    _frmHistoriaGL.Show()
                Case Else
            End Select

        End If


    End Sub

    Private Sub bbtCirugia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtProgramacionProcedimientos.ItemClick
        'If Registro <> "" Then
        ' Dim _Dorden = New DOrdenes
        ' If _Dorden.OrdenAtendida(Registro) = True Then
        ' Dim _frmOpen As New frmProgramacionCirugia
        ' Registro = ""
        ' _frmOpen.ShowDialog()
        ' Else
        ' MessageBox.Show("Esta orden no tiene Historia Clinica", "Programación de Cirugia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '     End If
        ' End If
    End Sub

    Private Sub bbtSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtSalir.ItemClick
        End
    End Sub

    Private Sub bbtPrueba_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        'If Funciones.IsLoaded("frmPrueba") = True Then
        ' MsgBox("cargado")
        ' '_consultarFrm.Focus()
        ' Else
        ' MsgBox("NO cargado")
        '
        '        End If
        'Dim _frm   Open As New frmPrueba
        '_frmOpen.ShowDialog()
    End Sub

    Private Sub bbiImagenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImagenes.ItemClick
        If Funciones.IsLoaded("frmImagenesVideo") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Captura de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            '_frmImagenes = New SIM___GLOBAL.frmImagenes 'SIM_ENDOSCOPIA.frmImagenes
            '_frmImagenes = New SIM___GLOBAL.frmCapturaImagenes
            _frmImagenes = New SIM___GLOBAL.frmImagenesVideo
            _frmImagenes.MdiParent = Me
            _frmImagenes.Show()
        End If
    End Sub


    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        If IDDetalleOrdenG <> Nothing Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
            Dim _dDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
            _DetalleOrden = _dDetalleOrden.Cargar(IDDetalleOrdenG)
            If _DetalleOrden.Estado = "ATENDIDO" Then

                Select Case _DetalleOrden.IdTipoEstudio
                    Case 8
                        _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                        _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                        _funciones.ImprimirHistoria(IDDetalleOrdenG, IdEmpleadoG)
                        'ImpresionHistoria(IDDetalleOrdenG, "H")
                        ImprimirFrm.ImprimirReporte("historia_clinica.rpt", IDDetalleOrdenG)
                    Case 9
                        _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                        _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                        _funciones.ImprimirHistoria(IDDetalleOrdenG, IdEmpleadoG)
                        'ImpresionHistoria(IDDetalleOrdenG, "C")
                        ImprimirFrm.ImprimirReporte("historia_clinica.rpt", IDDetalleOrdenG)
                    Case 10
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        ImprimirFrm.ImprimirReporte("endoscopia.rpt", IDDetalleOrdenG)
                    Case 11
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        ImprimirFrm.ImprimirReporte("colonoscopia.rpt", IDDetalleOrdenG)
                    Case 12
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        ImprimirFrm.ImprimirReporte("rectoscopia.rpt", IDDetalleOrdenG)
                    Case 13
                        _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                        ImpresionHistoria(IDDetalleOrdenG, "C")
                        ImprimirFrm.ImprimirReporte("historia_preanestesica.rpt", IDDetalleOrdenG)
                    Case 15
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        ImprimirFrm.ImprimirReporte("estudios_especiales.rpt", IDDetalleOrdenG)
                    Case Else
                        'MsgBox(Registro)

                End Select

            Else
                MessageBox.Show("El Estudio se Encuentra en Estado: " & _DetalleOrden.Estado, "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiCargos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCargos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCargos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEspecialidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEspecialidades.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmEspecialidades
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEmpleados_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEmpleados.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmEmpleados
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiUsers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUsers.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmUsers
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEvolucionPaciente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEvolucionPaciente.ItemClick
        'If Registro <> "" Then
        ' Dim ImprimirFrm As New frmImprimir
        ' Dim _DOrdenes As New DOrdenes
        ' ImprimirFrm.CargarReporte("ReporteGeneral.rpt", _DOrdenes.IdUsuario(Registro))
        ' Else
        ' MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If
    End Sub

    Private Sub bbiTipoPatologia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTipoPatologia.ItemClick
        'Dim _frmOpen As New frmTipoPatologia
        '_frmOpen.ShowDialog()
    End Sub


    Private Sub bbiAcercaDe_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAcercaDe.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmAcercaDe
        _frmOpen.Licencia = 3
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEntidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEntidades.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.FrmEntidades
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiTarifas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTarifas.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmTarifas
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiDetalleTarifa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDetalleTarifa.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmDetalleTarifa
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiContratos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiContratos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmContratos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtHistoriasAnteriores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtHistoriasAnteriores.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmHistoriasAnteriores
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiListadoOrdenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiListadoOrdenes.ItemClick
        'Dim _frmOpen As New SIM_ENDOSCOPIA.frmListadoOrdenes
        '_frmOpen.ShowDialog()
        Dim _frmopen As New SIM___GLOBAL.frmListadoOrdenes
        _frmopen.Licencia = LicenciaG
        _frmopen.IdEmpleado = IdEmpleadoG
        _frmopen.ShowDialog()
    End Sub

    Private Sub bbiFactura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFactura.ItemClick

        If Funciones.IsLoaded("frmFacturas") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmFacturacion = New SIM___GLOBAL.frmFacturas
            _frmFacturacion.MdiParent = Me
            _frmFacturacion.IDEmpleado = IdEmpleadoG
            _frmFacturacion.Licencia = LicenciaG
            _frmFacturacion.Show()
        End If


        'Dim _frmOpen As New SIM___GLOBAL.frmFacturas
        '_frmOpen.Licencia = LicenciaG
        '_frmOpen.IDEmpleado = IdEmpleadoG
        '_frmOpen.ShowDialog()
    End Sub

    Private Sub bbiAgenda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAgenda.ItemClick
        If Funciones.IsLoaded("frmAgenda") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmAgenda = New SIM___GLOBAL.frmAgenda
            _frmAgenda.MdiParent = Me
            _frmAgenda.idEmpleado = IdEmpleadoG
            _frmAgenda.Licencia = LicenciaG
            _frmAgenda.Show()
        End If
    End Sub

    Private Sub bbiPrivilegios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrivilegios.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmPrivilegios
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiSeguridad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSeguridad.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmSeguridad
        _frmOpen.idEmpleado2 = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEndoscopia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEndoscopia.ItemClick
        If Funciones.IsLoaded("frmEndoscopia") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Estudios de Endoscopia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If LicenciaG = "3" Then 'DITEG
                _frmEndoscopia = New SIM_ENDOSCOPIA.frmEndoscopia
                _frmEndoscopia.MdiParent = Me
                _frmEndoscopia.Show()
            Else ' GASTROLAP
                _frmEndoscopiaGl = New SIM_ENDOSCOPIA.frmEndoscopiaGL
                _frmEndoscopiaGl.Licencia = LicenciaG
                _frmEndoscopiaGl.IdEmpleado = IdEmpleadoG
                _frmEndoscopiaGl.MdiParent = Me
                _frmEndoscopiagl.Show()
            End If

        End If
    End Sub

    Private Sub bbiAyudaProducto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAyudaProducto.ItemClick
        Dim _frmOpen As New frmPrueba

        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEquipos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEquipos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmEquipos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiSubEntidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSubEntidades.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmSubEntidades
        _frmOpen.ShowDialog()

    End Sub
    Private Sub ImpresionHistoria(ByVal Filtro As String, ByVal Control As String)

        Dim _ds = New DataSet
        _ds = _dImpresionHistoria.Listar(Filtro, Control)
        '************* CARGAMOS DATOS DE IMPRESION **************
        _ImpresionHistoria.Id = Val("")
        _ImpresionHistoria.IdOrden = _ds.Tables(0).Rows(0)(0).ToString
        _ImpresionHistoria.IdDetalleOrden = _ds.Tables(0).Rows(0)(1).ToString
        _ImpresionHistoria.NumeroHistoria = _ds.Tables(0).Rows(0)(2).ToString
        _ImpresionHistoria.Nombre = _ds.Tables(0).Rows(0)(3).ToString
        _ImpresionHistoria.Identificacion = _ds.Tables(0).Rows(0)(4).ToString
        _ImpresionHistoria.Edad = _ds.Tables(0).Rows(0)(5).ToString

        _ImpresionHistoria.Sexo = _ds.Tables(0).Rows(0)(6).ToString
        _ImpresionHistoria.EstadoCivil = _ds.Tables(0).Rows(0)(7).ToString
        _ImpresionHistoria.Telefono = _ds.Tables(0).Rows(0)(8).ToString
        _ImpresionHistoria.Direccion = _ds.Tables(0).Rows(0)(9).ToString
        _ImpresionHistoria.Entidad = _ds.Tables(0).Rows(0)(10).ToString

        _ImpresionHistoria.FechaIngreso = _ds.Tables(0).Rows(0)(11).ToString
        _ImpresionHistoria.FechaAtencion = _ds.Tables(0).Rows(0)(12).ToString
        _ImpresionHistoria.MotivoConsulta = _ds.Tables(0).Rows(0)(13).ToString
        _ImpresionHistoria.AntecedentesFamiliares = _ds.Tables(0).Rows(0)(14).ToString
        _ImpresionHistoria.AntecedentesPersonales = _ds.Tables(0).Rows(0)(15).ToString

        _ImpresionHistoria.EnfermedadActual = _ds.Tables(0).Rows(0)(16).ToString
        _ImpresionHistoria.PlanSeguir = _ds.Tables(0).Rows(0)(17).ToString
        _ImpresionHistoria.Diagnostico = _ds.Tables(0).Rows(0)(18).ToString
        _ImpresionHistoria.Recomendaciones = _ds.Tables(0).Rows(0)(19).ToString
        _ImpresionHistoria.Firma = _funciones.Bytes_Imagen(_ds.Tables(0).Rows(0)(20))

        _ImpresionHistoria.Medico = _ds.Tables(0).Rows(0)(21).ToString
        _ImpresionHistoria.Especialidad = _ds.Tables(0).Rows(0)(22).ToString
        _ImpresionHistoria.RegistroMedico = _ds.Tables(0).Rows(0)(23).ToString
        _ImpresionHistoria.IdEmpleado = IdEmpleadoG
        _dImpresionHistoria.Guardar(_ImpresionHistoria)
    End Sub
    Private Sub ImpresionEndoscopia(ByVal Filtro As String)
        Dim _dimagenes As New SIM_ENDOSCOPIA.Controles.DImagenes
        Dim _ds = New DataSet

        _ds = _dImpresionEndoscopia.Listar(Filtro)
        '************* CARGAMOS DATOS DE IMPRESION **************
        _ImpresionEndoscopia.Id = Val("")
        _ImpresionEndoscopia.IdOrden = _ds.Tables(0).Rows(0)(0).ToString
        _ImpresionEndoscopia.IdDetalleOrden = _ds.Tables(0).Rows(0)(1).ToString
        _ImpresionEndoscopia.Estudio = _ds.Tables(0).Rows(0)(2).ToString
        _ImpresionEndoscopia.FechaIngreso = _ds.Tables(0).Rows(0)(3).ToString
        _ImpresionEndoscopia.Nombre = _ds.Tables(0).Rows(0)(4).ToString
        _ImpresionEndoscopia.Identificacion = _ds.Tables(0).Rows(0)(5).ToString

        _ImpresionEndoscopia.Edad = _ds.Tables(0).Rows(0)(6).ToString
        _ImpresionEndoscopia.Sexo = _ds.Tables(0).Rows(0)(7).ToString
        _ImpresionEndoscopia.EstadoCivil = _ds.Tables(0).Rows(0)(8).ToString
        _ImpresionEndoscopia.Telefono = _ds.Tables(0).Rows(0)(9).ToString
        _ImpresionEndoscopia.Direccion = _ds.Tables(0).Rows(0)(10).ToString

        _ImpresionEndoscopia.Entidad = _ds.Tables(0).Rows(0)(11).ToString
        _ImpresionEndoscopia.MedicoSolicita = _ds.Tables(0).Rows(0)(12).ToString
        _ImpresionEndoscopia.Indicacion = _ds.Tables(0).Rows(0)(13).ToString
        _ImpresionEndoscopia.Medicamentos = _ds.Tables(0).Rows(0)(14).ToString
        _ImpresionEndoscopia.Equipo = _ds.Tables(0).Rows(0)(15).ToString

        _ImpresionEndoscopia.Anestesiologo = _ds.Tables(0).Rows(0)(16).ToString
        _ImpresionEndoscopia.ProcedimientoTerapeutico = _ds.Tables(0).Rows(0)(17).ToString
        _ImpresionEndoscopia.Campo1 = _ds.Tables(0).Rows(0)(18).ToString
        _ImpresionEndoscopia.Campo2 = _ds.Tables(0).Rows(0)(19).ToString
        _ImpresionEndoscopia.Campo3 = _ds.Tables(0).Rows(0)(20).ToString
        _ImpresionEndoscopia.Campo4 = _ds.Tables(0).Rows(0)(21).ToString
        _ImpresionEndoscopia.Campo5 = _ds.Tables(0).Rows(0)(22).ToString
        _ImpresionEndoscopia.Campo6 = _ds.Tables(0).Rows(0)(23).ToString

        _ImpresionEndoscopia.Diagnostico = _ds.Tables(0).Rows(0)(24).ToString
        _ImpresionEndoscopia.Firma = _funciones.Bytes_Imagen(_ds.Tables(0).Rows(0)(25))
        _ImpresionEndoscopia.Medico = _ds.Tables(0).Rows(0)(26).ToString
        _ImpresionEndoscopia.Especialidad = _ds.Tables(0).Rows(0)(27).ToString
        _ImpresionEndoscopia.RegistroMedico = _ds.Tables(0).Rows(0)(28).ToString
        _ImpresionEndoscopia.IdEmpleado = IdEmpleadoG '_ds.Tables(0).Rows(0)(26).ToString

        '************* VERIFICAMOS SI EXISTEN IMAGENES **********
        ContadorFotos = 0
        If _dimagenes.ExisteImagenes(Filtro) = True Then

            'MsgBox("tiene imagenesssssss")
            _ds = _dimagenes.ListarImagenesActivas(Filtro)
            ContadorFotos = 1
            Select Case _ds.Tables(0).Rows.Count
                Case 0
                    ' _ImpresionEndoscopia.Imagen1 = ""
                    ' _ImpresionEndoscopia.Imagen2 = ""
                    ' _ImpresionEndoscopia.Imagen3 = ""
                    ' _ImpresionEndoscopia.Imagen4 = ""
                    ' _ImpresionEndoscopia.Imagen5 = ""
                    ' _ImpresionEndoscopia.Imagen6 = ""
                    ' _ImpresionEndoscopia.Imagen7 = ""
                   ' _ImpresionEndoscopia.Imagen8 = ""
                Case 1
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString) '_funciones.Bytes_Imagen(_ds.Tables(0).Rows(0)(0))
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = ""
                    _ImpresionEndoscopia.Texto3 = ""
                    _ImpresionEndoscopia.Texto4 = ""
                    _ImpresionEndoscopia.Texto5 = ""
                    _ImpresionEndoscopia.Texto6 = ""
                    _ImpresionEndoscopia.Texto7 = ""
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("1")
                    'ContadorFotos = 1
                Case 2
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = ""
                    _ImpresionEndoscopia.Texto4 = ""
                    _ImpresionEndoscopia.Texto5 = ""
                    _ImpresionEndoscopia.Texto6 = ""
                    _ImpresionEndoscopia.Texto7 = ""
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("2")
                    'ContadorFotos = 2
                Case 3
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = ""
                    _ImpresionEndoscopia.Texto5 = ""
                    _ImpresionEndoscopia.Texto6 = ""
                    _ImpresionEndoscopia.Texto7 = ""
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("3")
                    'ContadorFotos = 3
                Case 4
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = _ds.Tables(0).Rows(3)(1).ToString
                    _ImpresionEndoscopia.Texto5 = ""
                    _ImpresionEndoscopia.Texto6 = ""
                    _ImpresionEndoscopia.Texto7 = ""
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("4")
                    'ContadorFotos = 4
                Case 5
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile(_ds.Tables(0).Rows(4)(0).ToString)
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = _ds.Tables(0).Rows(3)(1).ToString
                    _ImpresionEndoscopia.Texto5 = _ds.Tables(0).Rows(4)(1).ToString
                    _ImpresionEndoscopia.Texto6 = ""
                    _ImpresionEndoscopia.Texto7 = ""
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("5")
                    'ContadorFotos = 5
                Case 6
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile(_ds.Tables(0).Rows(4)(0).ToString)
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile(_ds.Tables(0).Rows(5)(0).ToString)
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = _ds.Tables(0).Rows(3)(1).ToString
                    _ImpresionEndoscopia.Texto5 = _ds.Tables(0).Rows(4)(1).ToString
                    _ImpresionEndoscopia.Texto6 = _ds.Tables(0).Rows(5)(1).ToString
                    _ImpresionEndoscopia.Texto7 = ""
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("6")
                    'ContadorFotos = 6
                Case 7
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile(_ds.Tables(0).Rows(4)(0).ToString)
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile(_ds.Tables(0).Rows(5)(0).ToString)
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile(_ds.Tables(0).Rows(6)(0).ToString)
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = _ds.Tables(0).Rows(3)(1).ToString
                    _ImpresionEndoscopia.Texto5 = _ds.Tables(0).Rows(4)(1).ToString
                    _ImpresionEndoscopia.Texto6 = _ds.Tables(0).Rows(5)(1).ToString
                    _ImpresionEndoscopia.Texto7 = _ds.Tables(0).Rows(6)(1).ToString
                    _ImpresionEndoscopia.Texto8 = ""
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("7")
                    'ContadorFotos = 7
                Case 8
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile(_ds.Tables(0).Rows(4)(0).ToString)
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile(_ds.Tables(0).Rows(5)(0).ToString)
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile(_ds.Tables(0).Rows(6)(0).ToString)
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile(_ds.Tables(0).Rows(7)(0).ToString)
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile("x:\temporal.jpg")
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = _ds.Tables(0).Rows(3)(1).ToString
                    _ImpresionEndoscopia.Texto5 = _ds.Tables(0).Rows(4)(1).ToString
                    _ImpresionEndoscopia.Texto6 = _ds.Tables(0).Rows(5)(1).ToString
                    _ImpresionEndoscopia.Texto7 = _ds.Tables(0).Rows(6)(1).ToString
                    _ImpresionEndoscopia.Texto8 = _ds.Tables(0).Rows(7)(1).ToString
                    _ImpresionEndoscopia.Texto9 = ""
                    _ImpresionEndoscopia.NumeroFotos = Val("8")
                    'ContadorFotos = 8
                Case Else
                    _ImpresionEndoscopia.Imagen1 = Image.FromFile(_ds.Tables(0).Rows(0)(0).ToString)
                    _ImpresionEndoscopia.Imagen2 = Image.FromFile(_ds.Tables(0).Rows(1)(0).ToString)
                    _ImpresionEndoscopia.Imagen3 = Image.FromFile(_ds.Tables(0).Rows(2)(0).ToString)
                    _ImpresionEndoscopia.Imagen4 = Image.FromFile(_ds.Tables(0).Rows(3)(0).ToString)
                    _ImpresionEndoscopia.Imagen5 = Image.FromFile(_ds.Tables(0).Rows(4)(0).ToString)
                    _ImpresionEndoscopia.Imagen6 = Image.FromFile(_ds.Tables(0).Rows(5)(0).ToString)
                    _ImpresionEndoscopia.Imagen7 = Image.FromFile(_ds.Tables(0).Rows(6)(0).ToString)
                    _ImpresionEndoscopia.Imagen8 = Image.FromFile(_ds.Tables(0).Rows(7)(0).ToString)
                    _ImpresionEndoscopia.Imagen9 = Image.FromFile(_ds.Tables(0).Rows(8)(0).ToString)
                    _ImpresionEndoscopia.Texto1 = _ds.Tables(0).Rows(0)(1).ToString
                    _ImpresionEndoscopia.Texto2 = _ds.Tables(0).Rows(1)(1).ToString
                    _ImpresionEndoscopia.Texto3 = _ds.Tables(0).Rows(2)(1).ToString
                    _ImpresionEndoscopia.Texto4 = _ds.Tables(0).Rows(3)(1).ToString
                    _ImpresionEndoscopia.Texto5 = _ds.Tables(0).Rows(4)(1).ToString
                    _ImpresionEndoscopia.Texto6 = _ds.Tables(0).Rows(5)(1).ToString
                    _ImpresionEndoscopia.Texto7 = _ds.Tables(0).Rows(6)(1).ToString
                    _ImpresionEndoscopia.Texto8 = _ds.Tables(0).Rows(7)(1).ToString
                    _ImpresionEndoscopia.Texto9 = _ds.Tables(0).Rows(8)(1).ToString
                    _ImpresionEndoscopia.NumeroFotos = Val("9")
                    'ContadorFotos = 9
            End Select

            _dImpresionEndoscopia.GuardarImagenes(_ImpresionEndoscopia, _ds.Tables(0).Rows.Count)
            'MsgBox(_ds.Tables(0).Rows.Count)
            _dimagenes.EliminarTemporales(Filtro, _ds.Tables(0).Rows.Count)
        Else
            ContadorFotos = 0
            'MsgBox("NO tiene imagenes")
            '_ImpresionEndoscopia.Imagen1 = ""
            '_ImpresionEndoscopia.Imagen2 = ""
            '_ImpresionEndoscopia.Imagen3 = ""
            '_ImpresionEndoscopia.Imagen4 = ""
            '_ImpresionEndoscopia.Imagen5 = ""
            '_ImpresionEndoscopia.Imagen6 = ""
            '_ImpresionEndoscopia.Imagen7 = ""
            '_ImpresionEndoscopia.Imagen8 = ""

            _dImpresionEndoscopia.Guardar(_ImpresionEndoscopia)
        End If

    End Sub

    Private Sub bbiTerapeuticos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTerapeuticos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmProcedimientosTerapeuticos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub BbiEstudiosFotos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEstudiosFotos.ItemClick
        If IDDetalleOrdenG <> Nothing Then
            Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
            'Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
            'Dim _dDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
            ImprimirFrm = New SIM___GLOBAL.frmImprimir
            '_DetalleOrden = _dDetalleOrden.Cargar(IDDetalleOrdenG)
            If Estado = "ATENDIDO" Then
                Select Case Estudio
                    Case "CONSULTA PRIMERA VEZ"
                        MessageBox.Show("El Estudio Seleccionado no registra Fotos", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case "CONSULTA DE CONTROL"
                        MessageBox.Show("El Estudio Seleccionado no registra Fotos", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case "ENDOSCOPIA"
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        Select Case LicenciaG
                            Case 4
                                If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    ImprimirFrm.ImprimirEndoscopia(IDDetalleOrdenG, 1, LicenciaG, "1")
                                Else
                                    ImprimirFrm.ImprimirEndoscopia(IDDetalleOrdenG, 0, LicenciaG, "1")
                                End If
                            Case 3
                                ImprimirFrm.CargarReporte("imgendoscopia.rpt", IDDetalleOrdenG)
                        End Select
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                    Case "COLONOSCOPIA"
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        Select Case LicenciaG
                            Case 4
                                If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    ImprimirFrm.ImprimirColonoscopia(IDDetalleOrdenG, 1, LicenciaG, "1")
                                Else
                                    ImprimirFrm.ImprimirColonoscopia(IDDetalleOrdenG, 0, LicenciaG, "1")
                                End If
                            Case 3
                                ImprimirFrm.CargarReporte("imgcolonoscopia.rpt", IDDetalleOrdenG)
                        End Select
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                    Case "RECTOSCOPIA"
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        Select Case LicenciaG
                            Case 4
                                If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    ImprimirFrm.ImprimirRectoscopia(IDDetalleOrdenG, 1, LicenciaG, "1")
                                Else
                                    ImprimirFrm.ImprimirRectoscopia(IDDetalleOrdenG, 0, LicenciaG, "1")
                                End If
                            Case 3
                                ImprimirFrm.CargarReporte("imgrectoscopia.rpt", IDDetalleOrdenG)
                        End Select
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                    Case "CONSULTA PREANESTESICA"
                        MessageBox.Show("El Estudio Seleccionado no registra Fotos", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case "ESTUDIOS ESPECIALES"
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        ImprimirFrm.CargarReporte("imgestudios_especiales.rpt", IDDetalleOrdenG)
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                    Case Else
                        'MsgBox(Registro)

                End Select

            Else
                MessageBox.Show("El Estudio se Encuentra en Estado: " & Estado, "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BbiReporteEstudios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReporteEstudios.ItemClick
        If IDDetalleOrdenG <> Nothing Then
            'Dim _funciones = New SIM___GLOBAL.Utilidades.Funciones
            Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
            'Dim _DetalleOrden As New SIM___GLOBAL.My.Modelo.DetalleOrden
            'Dim _dDetalleOrden As New SIM___GLOBAL.Controles.DDetalleOrden
            ImprimirFrm = New SIM___GLOBAL.frmImprimir
            '_DetalleOrden = _dDetalleOrden.Cargar(Registro)
            If Estado = "ATENDIDO" Then
                Select Case Estudio
                    Case "CONSULTA PRIMERA VEZ"
                        _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                        _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                        _funciones.ImprimirHistoria(IDDetalleOrdenG, IdEmpleadoG)
                        Select Case LicenciaG
                            Case 4
                                'llamamos el Reporte de historia
                                If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 1, LicenciaG)
                                Else
                                    ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 0, LicenciaG)
                                End If
                            Case 3, 9
                                ImprimirFrm.CargarReporte("historia_clinica.rpt", IDDetalleOrdenG)
                                'ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 0, LicenciaG)

                        End Select
                        _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                        _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                    Case "CONSULTA DE CONTROL"
                        _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                        _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                        _funciones.ImprimirHistoria(IDDetalleOrdenG, IdEmpleadoG)
                        Select Case LicenciaG
                            Case 4
                                'llamamos el Reporte de historia
                                If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 1, LicenciaG)
                                Else
                                    ImprimirFrm.ImprimirHistoria(IDDetalleOrdenG, 0, LicenciaG)
                                End If
                            Case 3, 9
                                ImprimirFrm.CargarReporte("historia_clinica.rpt", IDDetalleOrdenG)
                        End Select
                        _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                        _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)
                    Case "ENDOSCOPIA"
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        Select Case LicenciaG
                            Case 4
                                If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    ImprimirFrm.ImprimirEndoscopia(IDDetalleOrdenG, 1, LicenciaG, "0")
                                Else
                                    ImprimirFrm.ImprimirEndoscopia(IDDetalleOrdenG, 0, LicenciaG, "0")
                                End If
                            Case 3
                                ImprimirFrm.CargarReporte("endoscopia.rpt", IDDetalleOrdenG)
                        End Select
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                    Case "COLONOSCOPIA"
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        Select Case LicenciaG
                            Case 4
                                If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    ImprimirFrm.ImprimirColonoscopia(IDDetalleOrdenG, 1, LicenciaG, "0")
                                Else
                                    ImprimirFrm.ImprimirColonoscopia(IDDetalleOrdenG, 0, LicenciaG, "0")
                                End If
                            Case 3
                                ImprimirFrm.CargarReporte("colonoscopia.rpt", IDDetalleOrdenG)
                        End Select
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                    Case "RECTOSCOPIA"
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        Select Case LicenciaG
                            Case 4
                                If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    ImprimirFrm.ImprimirRectoscopia(IDDetalleOrdenG, 1, LicenciaG, "0")
                                Else
                                    ImprimirFrm.ImprimirRectoscopia(IDDetalleOrdenG, 0, LicenciaG, "0")
                                End If
                            Case 3
                                ImprimirFrm.CargarReporte("rectoscopia.rpt", IDDetalleOrdenG)
                        End Select
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                    Case "CONSULTA PREANESTESICA"
                        _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
                        ImpresionHistoria(IDDetalleOrdenG, "C")
                        ImprimirFrm.CargarReporte("historia_preanestesica.rpt", IDDetalleOrdenG)
                    Case "ESTUDIOS ESPECIALES"
                        '_dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        'ImpresionEndoscopia(IDDetalleOrdenG)
                        'ImprimirFrm.CargarReporte("estudios_especiales.rpt", IDDetalleOrdenG)
                        '_dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                        ImpresionEndoscopia(IDDetalleOrdenG)
                        Select Case LicenciaG
                            Case 4
                                If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    ImprimirFrm.ImprimirEstudiosEspeciales(IDDetalleOrdenG, 1, LicenciaG, "0")
                                Else
                                    ImprimirFrm.ImprimirEstudiosEspeciales(IDDetalleOrdenG, 0, LicenciaG, "0")
                                End If
                            Case 3
                                ImprimirFrm.CargarReporte("estudios_especiales.rpt", IDDetalleOrdenG)
                        End Select
                        _dImpresionEndoscopia.EliminarEndoscopia(IdEmpleadoG)
                    Case Else
                        'MsgBox(Registro)
                End Select

            Else
                MessageBox.Show("El Estudio no se Encuentra Atendido", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbiPlantillas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPlantillas.ItemClick
        Dim _frmOpen As New SIM_ENDOSCOPIA.frmPlantillasInformes
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiCerrarSesion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrarSesion.ItemClick
        If Funciones.IsLoaded("frmConsultar") = True Or Funciones.IsLoaded("frmAgenda") = True Or Funciones.IsLoaded("frmHistoria") = True Or Funciones.IsLoaded("frmEndoscopiaGL") = True Or Funciones.IsLoaded("frmImagenes") = True Then
            If MessageBox.Show("Se encuentran ventanas Abiertas, ¿Desea cerrarlas junto con la Sesion?", "Cerrar Sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                'MessageBox.Show("SI")
                If Funciones.IsLoaded("frmConsultar") = True Then
                    _frmConsultar.Close()
                End If
                If Funciones.IsLoaded("frmAgenda") = True Then
                    _frmAgenda.Close()
                End If
                If Funciones.IsLoaded("frmHistoria") = True Then
                    _frmHistoria.Close()
                End If
                If Funciones.IsLoaded("frmEndoscopiaGL") = True Then
                    _frmEndoscopia.Close()
                End If
                If Funciones.IsLoaded("frmImagenes") = True Then
                    _frmImagenes.Close()
                End If
                'If Funciones.IsLoaded("frmHistoriaGrupal") = True Then
                ' _frmHistoriaGrupal.Close()
                ' End If

                'MessageBox.Show("Cerrar Sesion")
                '******** Formulario Inicio de Sesion 
                Dim _frmOpen As New SIM___GLOBAL.frmSesion
                _frmOpen.ShowDialog()

                If _frmOpen.validar = True Then
                    IdEmpleadoG = _frmOpen.IDEmpleado
                    lblUsers.Caption = _frmOpen.NombreEmpleado
                    'bsiCargo.Caption = _frmOpen.Cargo
                    'bsiEspecialidad.Caption = _frmOpen.Especialidad
                    'IdEspecialidad = _frmOpen.IDEspecialidad
                    LicenciaG = _frmOpen.Licencia
                    HabilitarPrivilegios(LicenciaG)
                    CargarPrivilegios(IdEmpleadoG)
                Else
                    End
                End If
            End If
        Else
            'MessageBox.Show("NO")
            '******** Formulario Inicio de Sesion 
            Dim _frmOpen As New SIM___GLOBAL.frmSesion
            _frmOpen.ShowDialog()

            If _frmOpen.validar = True Then
                IdEmpleadoG = _frmOpen.IDEmpleado
                lblUsers.Caption = _frmOpen.NombreEmpleado
                'bsiCargo.Caption = _frmOpen.Cargo
                'bsiEspecialidad.Caption = _frmOpen.Especialidad
                'IdEspecialidad = _frmOpen.IDEspecialidad
                LicenciaG = _frmOpen.Licencia
                HabilitarPrivilegios(LicenciaG)
                CargarPrivilegios(IdEmpleadoG)
            Else
                End
            End If
        End If
    End Sub

    Private Sub bbiRips_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRips.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmRips
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiOtrosEstudios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOtrosEstudios.ItemClick
        If Funciones.IsLoaded("frmEstudiosEspeciales") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Estudios Especiales", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmEstudiosEspeciales = New SIM_ENDOSCOPIA.frmEstudiosEspeciales
            _frmEstudiosEspeciales.MdiParent = Me
            _frmEstudiosEspeciales.Show()
        End If
    End Sub

    Private Sub RibbonControl_Click(sender As Object, e As EventArgs) Handles RibbonControl.Click

    End Sub

    Private Sub bbiSoporteTecnico_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSoporteTecnico.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmVistaHistoria
        _frmOpen.IdDetalleOrden = IDDetalleOrdenG
        _frmOpen.Licencia = LicenciaG
        _frmOpen.Estudio = Estudio
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiTutoriales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTutoriales.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.FrmPrueba
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiOrtodoncia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOrtodoncia.ItemClick
        _frmOrtodoncia = New SIM___GLOBAL.frmOrtodoncia
        _frmOrtodoncia._IDEmpleado = IdEmpleadoG
        _frmOrtodoncia.Licencia = LicenciaG
        _frmOrtodoncia.MdiParent = Me
        _frmOrtodoncia.Show()
    End Sub

    Private Sub bbiPlantillaConsentimiento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPlantillaConsentimiento.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmConsentimientoInformadoPlantillas

        _frmOpen.Licencia = LicenciaG
        '_frmOpen.Estudio = Estudio
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiAuditoria_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAuditoria.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmAuditoria
        _frmOpen.Licencia = LicenciaG
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiInformes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiInformes.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmInformes
        _frmOpen.Admin = lblUsers.Caption
        _frmOpen.ShowDialog()
    End Sub
End Class
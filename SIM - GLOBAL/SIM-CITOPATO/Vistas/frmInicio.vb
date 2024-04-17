Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.My.Controles

Imports System.Data.Odbc



Public Class frmInicio
    'VARIABLES GLOBALES 
    ReadOnly _funciones As New Funciones
    'Dim _frmConsultar As New frmConsultar

    '-----------------------
    Dim conectar = New ConexionODBC
    Dim _conn As OdbcConnection
    Dim _Users As New SIM___GLOBAL.Modelo.Users
    Dim _dUsers As New SIM___GLOBAL.Controles.DUsers
    'Dim _user As New DUsers
    Dim cerrar As Boolean = True

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
        bbiHistoria.Enabled = _Users.HistoriaClinica
        bbiHistoriasAnteriores.Enabled = _Users.HistoriaAnteriores
        'historiagrupal = _Users.HistoriaGrupal
        bbiEvolucionPaciente.Enabled = _Users.EvolucionPaciente
        bbiProgramacionProcedimiento.Enabled = _Users.ProgramacionCirugia
        'citologia = _Users.Citologia
        'Patologia = _Users.Patologia
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

        '******** Formulario Inicio de Sesion 
        Dim _frmOpen As New SIM___GLOBAL.frmSesion
        _frmOpen.ShowDialog()

        If _frmOpen.validar = True Then
            IdEmpleadoG = _frmOpen.IDEmpleado
            LicenciaG = _frmOpen.Licencia
            Me.Text = "SIM  Sistema Integrado Medico - Licencia Autorizada a: " & _frmOpen.NombreLicencia
            'IdEmpleado = _frmOpen.IDEmpleado
            'MsgBox(IdEmpleado)
            lblUsers.Caption = _frmOpen.NombreEmpleado
            CargarPrivilegios(IdEmpleadoG)

            'prueba de Clase Privilegios
            'Dim _Privilegios As New SIM___GLOBAL.Modelo.Privilegios.Archivo.OrdenesAtencion

            '_Privilegios.Orden = True
            'bbtNuevo.Enabled = _Privilegios.Orden


        Else
            End
        End If


    End Sub

    Private Sub bbtExamanes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtExamanes.ItemClick
        'Dim _frmOpen As New frmExamenes
        '_frmOpen.ShowDialog()
    End Sub

    Private Sub bbtDiagnosticos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtDiagnosticos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmDiagnosticos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtMedicamentos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtMedicamentos.ItemClick
        'Dim _frmOpen As New frmMedicamentos
        '_frmOpen.ShowDialog()
    End Sub

    Private Sub bbtUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtUsuarios.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmUsuarios
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()

    End Sub

    Private Sub bbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmOrdenes
        'Formulario = "Nuevo"
        _frmOpen.IDEmpleado = IdEmpleadoG
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtConsultar.ItemClick
        If Funciones.IsLoaded("frmConsultar") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Consultar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _frmConsultar = New frmConsultar
            _frmConsultar.MdiParent = Me
            _frmConsultar.Show()
            _frmConsultar.Recargar()
        End If


    End Sub

    '   Private Sub bbtEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtEditar.ItemClick
    'If IDORdenG <> "" Then
    ' Formulario = "Editar"
    ' Dim _Dorden = New SIM___GLOBAL.Controles.DOrdenes
    ' Dim _Ordenes As New SIM___GLOBAL.My.Modelo.Ordenes
    ' 'Dim _DUsuarios As New SIM___GLOBAL.Controles.DUsuarios
    ' 'Dim _ds As DataSet
    ' If _Dorden.OrdenPendiente(IDORdenG) = True Then
    ' Dim _frmOpen As New frmOrdenes
    ' _frmOpen.SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    ' _frmOpen.Size = New Size(750, 600)
    ' _frmOpen.StartPosition = FormStartPosition.CenterScreen
    ' _frmOpen.ShowDialog()
    '
    '        Else
    '        MessageBox.Show("Esta Orden Ya Fue Atendida o Cancelada", "Editar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '        Else
    '        MessageBox.Show("Debe Seleccionar una Orden", "Editar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    End Sub

    Private Sub bbtAdjuntos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtAdjuntos.ItemClick

        Dim _frmOpen As New SIM___GLOBAL.frmAdjuntos
        _frmOpen.ShowDialog()

    End Sub

    'Private Sub bbtCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtCancelar.ItemClick
    'If IDORdenG <> "" Then
    ' Dim _Dorden = New SIM_CITOPATO.Controles.DOrdenes
    ' If _Dorden.OrdenPendiente(IDORdenG) = True Then
    ' If MessageBox.Show("¿Desea Anular la Orden?", "Ordenes", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
    ' _Dorden.CancelarOrden(IDORdenG)
    ' Dim funciones = New Funciones
    ' Funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
    ' End If
    ' Else
    ' MessageBox.Show("Esta Orden Ya Fue Atendida o Cancelada", "Cancelar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
    ' End If
    ' Else
    ' MessageBox.Show("Debe Seleccionar una Orden", "Cancelar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
    ' End If
    'End Sub



    Private Sub bbtCirugia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        'If Registro <> "" Then
        ' Dim _Dorden = New DOrdenes
        ' If _Dorden.OrdenAtendida(Registro) = True Then
        ' Dim _frmOpen As New frmProgramacionCirugia
        ' Registro = ""
        ' _frmOpen.ShowDialog()
        ' Else
        ' MessageBox.Show("Esta orden no tiene Historia Clinica", "Programación de Cirugia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If
        ' End If
    End Sub

    Private Sub bbtSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtSalir.ItemClick
        End
    End Sub





    Private Sub bbiVistaPrevia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVistaPrevia.ItemClick
        If IDORdenG <> Nothing Then
            Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
            ImprimirFrm = New SIM___GLOBAL.frmImprimir
            ' declaracion solo para pruebas
            Dim Estado As String = "ATENDIDO"

            'If Estado = "ATENDIDO" Then
            ' Select Case Estudio

            ' Case "BIOPSIA"
            If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                ImprimirFrm.ImprimirCitologia(IDORdenG, 1, LicenciaG, 1, True)
            Else
                ImprimirFrm.ImprimirCitologia(IDORdenG, 0, LicenciaG, 1, True)
            End If
            '        Case Else
            '  MsgBox(Registro)
            '    End Select

            'Else
            MessageBox.Show("El Estudio no se Encuentra Atendido", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '   End If

        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        'If Registro <> "" Then
        ' Dim ImprimirFrm As New frmImprimir
        ' ImprimirFrm.ImprimirReporte("prueba.rpt", Registro)
        ' Else
        ' MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If
        If IDORdenG <> "" Then
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            Dim _ordenes As New SIM_CITOPATO.My.Modelo.Ordenes
            Dim _dOrdenes As New SIM_CITOPATO.Controles.DOrdenes
            _ordenes = _dOrdenes.Cargar(IDORdenG)
            If _ordenes.Estado = "ATENDIDO" Then
                If MessageBox.Show("¿Desea Imprimir el Reporte con el Membrete?", "Vista Previa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Select Case _ordenes.IdTipoEstudio
                        Case 1
                            ImprimirFrm.CargarReporte("m_citologia.rpt", IDORdenG)
                        Case 2
                            ImprimirFrm.CargarReporte("m_citologia_base_liquida.rpt", IDORdenG)
                        Case 7
                            ImprimirFrm.CargarReporte("m_inmunohistoquimica.rpt", IDORdenG)
                        Case Else
                            ImprimirFrm.CargarReporte("m_patologia.rpt", IDORdenG)
                    End Select
                Else
                    Select Case _ordenes.IdTipoEstudio
                        Case 1
                            ImprimirFrm.CargarReporte("citologia.rpt", IDORdenG)
                        Case 2
                            ImprimirFrm.CargarReporte("citologia_base_liquida.rpt", IDORdenG)
                        Case 7
                            ImprimirFrm.CargarReporte("inmunohistoquimica.rpt", IDORdenG)
                        Case Else
                            ImprimirFrm.CargarReporte("patologia.rpt", IDORdenG)
                    End Select
                End If
            Else
                MessageBox.Show("El Estudio se Encuentra en Estado: " & _ordenes.Estado, "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEvolucionPaciente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEvolucionPaciente.ItemClick

    End Sub

    Private Sub bbiEntidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEntidades.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.FrmEntidades
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtCitologia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtCitologia.ItemClick
        If Funciones.IsLoaded("frmCitologiaGeneral") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Citologia Vaginal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _frmCitologia As New SIM___GLOBAL.frmCitologiaGeneral
            _frmCitologia.MdiParent = Me
            _frmCitologia.IDEmpleado = IdEmpleadoG
            _frmCitologia.Show()
        End If
    End Sub

    Private Sub bbiContratos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiContratos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmContratos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiTarifas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTarifas.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmTarifas
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiListadoOrdenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiListadoOrdenes.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmListadoOrdenes
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiPatologia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPatologia.ItemClick
        If Funciones.IsLoaded("frmPatologiaGeneral") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Estudios de Patologia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _frmPatologia As New SIM___GLOBAL.frmPatologiaGeneral
            _frmPatologia.MdiParent = Me
            _frmPatologia.idempleado = IdEmpleadoG
            _frmPatologia.Show()
        End If
    End Sub

    Private Sub bbiAgenda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAgenda.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmAgenda
        _frmOpen._Empleado = lblUsers.Caption
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiFactura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFactura.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmFacturas
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiCups_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCups.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCups
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiPrivilegios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrivilegios.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmPrivilegios
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiSeguridad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSeguridad.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmSeguridad
        '_frmOpen.idEmpleado = IdEmpleado
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiAcercaDe_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAcercaDe.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmAcercaDe
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiSubEntidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSubEntidades.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmSubEntidades
        _frmOpen.ShowDialog()

    End Sub

    Private Sub bbiTerapeuticos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTerapeuticos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmProcedimientosTerapeuticos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiAyudaProducto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAyudaProducto.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmOrdenes
        _frmOpen.IDEmpleado = IdEmpleadoG
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiClientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClientes.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmClientes
        '_frmOpen.IDEmpleado = IdEmpleadoG
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiProveedores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProveedores.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmProveedores
        '_frmOpen.IDEmpleado = IdEmpleadoG
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiProductos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProductos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmProductos
        '_frmOpen.IDEmpleado = IdEmpleadoG
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiOrdenCompra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOrdenCompra.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmOrdenCompra
        _frmOpen.IDEmpleado = IdEmpleadoG
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiCompras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCompras.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCompras
        _frmOpen.IdEmpleado = IdEmpleadoG
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiDebito_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDebito.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmDebito
        '_frmOpen.IDEmpleado = IdEmpleadoG
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiCredito_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCredito.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCredito
        '_frmOpen.IDEmpleado = IdEmpleadoG
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiInventario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiInventario.ItemClick
        'Dim _frmOpen As New SIM___GLOBAL.frminventario
        '_frmOpen.IDEmpleado = IdEmpleadoG
        '_frmOpen.Licencia = LicenciaG
        '_frmOpen.ShowDialog()
    End Sub

    Private Sub bbiTarifaProducto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTarifaProducto.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmTarifaProductos
        '_frmOpen.IDEmpleado = IdEmpleadoG
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiCotizaciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCotizaciones.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCotizaciones
        _frmOpen.IDEmpleado = IdEmpleadoG
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiOrtodoncia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOrtodoncia.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmOrtodoncia
        '_frmOpen.IDEmpleado = IdEmpleadoG
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiImagenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImagenes.ItemClick
        If Funciones.IsLoaded("frmImagenes") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Captura de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _frmImagenes As New SIM___GLOBAL.frmImagenes
            _frmImagenes.MdiParent = Me
            '_frmImagenes.IDEmpleado = IdEmpleadoG
            _frmImagenes.Show()
        End If
    End Sub

    Private Sub bbiRips_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRips.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmRips
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiTutoriales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTutoriales.ItemClick
        Dim _frmOpen As New frmImagenesVideo
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiTomaMuestra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTomaMuestra.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmTomaMuestra
        _frmOpen.ShowDialog()
    End Sub
End Class
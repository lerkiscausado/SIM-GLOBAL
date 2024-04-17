Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Controles

Public Class frmInicio
    'VARIABLES GLOBALES 
    ReadOnly _funciones As New Funciones
    ' Dim _frmConsultar As New frmConsultar

    Dim _dImpresionHistoria As New SIM___GLOBAL.Controles.DImpresionHistoria
    Dim _dImpresionDetalleHistoria As New SIM___GLOBAL.Controles.DImpresionDetalleHistoria
    Dim _ImpresionHistoria As New SIM___GLOBAL.Modelo.ImpresionHistoria
    '-----------------------
    Dim conectar = New ConexionODBC
    Dim _conn As OdbcConnection
    'Dim _user As New DUsers
    Dim cerrar As Boolean = True
    Dim _Users As New SIM___GLOBAL.Modelo.Users
    Dim _dUsers As New SIM___GLOBAL.Controles.DUsers

    'inicio de sesion
    Dim _frmAgenda As SIM___GLOBAL.frmAgenda

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
        Dim _frmOpen As New SIM___GLOBAL.frmSesion
        _frmOpen.ShowDialog()

        If _frmOpen.validar = True Then
            IdEmpleadoG = _frmOpen.IDEmpleado
            LicenciaG = _frmOpen.Licencia
            lblUsers.Caption = _frmOpen.NombreEmpleado
            CargarPrivilegios(IdEmpleadoG)
        Else
            End
        End If
        'FORMULARIO DE BIENVENIDA
        'Dim _frmBienvenidos = New SIM___GLOBAL.frmBienvenida
        '_frmBienvenidos.MdiParent = Me
        '_frmBienvenidos.Show()
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
        Dim _frmOpen As New frmOrdenes2
        IDORdenG = Nothing
        IDDetalleOrdenG = Nothing
        _frmOpen.ShowDialog()



    End Sub

    Private Sub bbtConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtConsultar.ItemClick
        If Funciones.IsLoaded("frmConsultar") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Consultar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _frmConsultar = New frmConsultar
            _frmConsultar.MdiParent = Me
            _frmConsultar.Show()
            '_frmConsultar.DtOrdenesTableAdapter.Fill(_frmConsultar.DSVistas.dtOrdenes)
        End If


    End Sub

    Private Sub bbtEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtEditar.ItemClick
        'If Registro <> "" Then
        ' Dim _Dorden = New DOrdenes
        ' If _Dorden.OrdenPendiente(Registro) = True Then
        ' Dim _frmOpen As New frmOrdenes
        ' _frmOpen.ShowDialog()
        ' Else
        ' MessageBox.Show("Esta Orden Ya Fue Atendida o Cancelada", "Editar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If
        ' Else
        ' MessageBox.Show("Debe Seleccionar una Orden", "Editar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If
    End Sub

    Private Sub bbtAdjuntos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtAdjuntos.ItemClick
        ' If Registro <> "" Then
        ' Dim _frmOpen As New frmAdjuntos
        ' _frmOpen.ShowDialog()
        ' Else
        ' MessageBox.Show("Debe Seleccionar una Orden para Adjuntar Archivos", "Adjuntar Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If
    End Sub

    Private Sub bbtCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtCancelar.ItemClick

        If IDORdenG <> "" Then
            Dim _Dorden = New DOrdenes
            If _Dorden.OrdenPendiente(IDORdenG) = True Then
                If MessageBox.Show("¿Desea Anular la Orden?", "Ordenes", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    _Dorden.CancelarOrdenMartinez(IDORdenG)
                    Dim funciones = New Funciones
                    funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
                End If
            Else
                MessageBox.Show("Esta Orden Ya Fue Atendida o Cancelada", "Cancelar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Cancelar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub bbtHistoria_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtHistoria.ItemClick
        If Funciones.IsLoaded("frmHistoria") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Historia Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _frmHistoria As New frmHistoria
            _frmHistoria.MdiParent = Me
            _frmHistoria.Show()
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
        '       If Registro <> "" Then
        '       Dim _frmOpen As New frmImagenes
        '       _frmOpen.ShowDialog()
        '       Else
        '       MessageBox.Show("Debe Seleccionar una Orden para Adjuntar Imagenes", "Registro de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '       End If
    End Sub

    Private Sub bbiVistaPrevia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVistaPrevia.ItemClick
        'Registro = 26
        If IDDetalleOrdenG <> Nothing Then
            'Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            'ImprimirFrm.CargarReporte("historia_martinez.rpt", Registro)
            Dim ImprimirFrm As SIM___GLOBAL.frmImprimir
            ImprimirFrm = New SIM___GLOBAL.frmImprimir

            _funciones.ImprimirHistoria(IDDetalleOrdenG, IdEmpleadoG)
            ImprimirFrm.CargarReporte("historia_martinez.rpt", IDDetalleOrdenG)
            _dImpresionHistoria.EliminarHistoria(IdEmpleadoG)
            _dImpresionDetalleHistoria.EliminarDetalleHistoria(IdEmpleadoG)

        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        ' If Registro <> "" Then
        ' Dim ImprimirFrm As New frmImprimir
        ' ImprimirFrm.ImprimirReporte("prueba.rpt", Registro)
        ' Else
        ' MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If
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
    Private Sub RibbonControl_Click(sender As Object, e As EventArgs) Handles RibbonControl.Click

    End Sub

    Private Sub bbiAcercaDe_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAcercaDe.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmAcercaDe
        _frmOpen.Licencia = LicenciaG
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
        _frmOpen._IDEmpleado = IdEmpleadoG
        _frmOpen.ShowDialog()
    End Sub



    Private Sub bbiFactura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFactura.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmFacturas
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiAgenda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAgenda.ItemClick
        'Dim _frmOpen As New SIM___GLOBAL.frmAgenda
        '_frmOpen._empleado = lblUsers.Caption
        '_frmOpen.ShowDialog()
        If Funciones.IsLoaded("frmAgenda") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmAgenda = New SIM___GLOBAL.frmAgenda
            _frmAgenda.MdiParent = Me
            _frmAgenda.idEmpleado = IdEmpleadoG
            _frmAgenda.Show()
        End If
    End Sub

    Private Sub bbiPrivilegios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrivilegios.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmPrivilegios
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiSeguridad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSeguridad.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmSeguridad
        ' _frmOpen.idEmpleado = IdEmpleado
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiAyudaProducto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAyudaProducto.ItemClick
        Dim _frmOpen As New frmPrueba
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

    Private Sub bbiRips_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim _frmOpen As New SIM___GLOBAL.frmRips
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiProductos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim _frmOpen As New SIM___GLOBAL.frmProductos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiProveedores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim _frmOpen As New SIM___GLOBAL.frmProveedores
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiOrdenCompra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOrdenCompra.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmOrdenCompra
        _frmOpen.IdEmpleado = IdEmpleadoG
        _frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiListadoOrdenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiListadoOrdenes.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmListadoOrdenes
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiGlosa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGlosa.ItemClick

    End Sub

    Private Sub bbiRips_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRips.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmRips
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiProveedores_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProveedores.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmProveedores

        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiClientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClientes.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmClientes
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiProductos_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProductos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmProductos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiCompras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCompras.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCompras
        '_frmOpen.IdEmpleado = IdEmpleadoG
        '_frmOpen.Licencia = LicenciaG
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiInventario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiInventario.ItemClick

    End Sub

    Private Sub bbiUnidadMedida_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUnidadMedida.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmUnidadMedida
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiSoporteTecnico_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSoporteTecnico.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.FrmPrueba
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiTutoriales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTutoriales.ItemClick

    End Sub








    'Private Sub bbiOrdenCompra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOrdenCompra.ItemClick
    ' 'Abrir ventana proveedores
    ' Dim _frmOpen As New SIM___GLOBAL.frmOrdenCompra
    '     _frmOpen.ShowDialog()
    ' End Sub

    'Private Sub bbiUnidadMedida_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUnidadMedida.ItemClick
    ' Dim _frmOpen As New SIM___GLOBAL.frmUnidadMedida
    '     _frmOpen.ShowDialog()
    ' End Sub
End Class
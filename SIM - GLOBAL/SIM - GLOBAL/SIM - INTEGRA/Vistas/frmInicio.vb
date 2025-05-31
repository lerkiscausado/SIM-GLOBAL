Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Controles
Public Class frmInicio
    'VARIABLES GLOBALES 
    ReadOnly _funciones As New Funciones
    Dim conectar = New ConexionODBC
    Dim _conn As OdbcConnection
    Dim cerrar As Boolean = True
    Dim _Users As New SIM___GLOBAL.Modelo.Users
    Dim _dUsers As New SIM___GLOBAL.Controles.DUsers
    Dim _DHistoriaIntegra As New SIM___INTEGRA.Controles.DHistoriaIntegra
    Dim _DOrdenes As New SIM___GLOBAL.Controles.DOrdenes
    Dim _ImpresionHistoria As New SIM___INTEGRA.Modelo.ImpresionHistoria
    Dim _DImpresionHistoria As New SIM___INTEGRA.Controles.DImpresionHistoria
    ' Clases Cierre Sesion
    Dim _frmConsultar As SIM___INTEGRA.frmConsultar
    Dim _frmHistoria As SIM___INTEGRA.frmHistoria
    Dim _frmHistoriasAnteriores As SIM___INTEGRA.frmHistoriasAnteriores
    Dim _frmHistoriaGrupal As SIM___INTEGRA.frmHistoriaGrupal

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
        'bbiTerapeuticos.Enabled = _Users.ProcedimientoTerapeutico
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
            conectar.Cadena = String.Format("Dsn=SIMINTEGRA;uid=unidadde_admin;pwd=80082552700ers")
            _conn = conectar.Open()
            cerrar = False
        Catch ex As Exception
        End Try
        '-----------------------------
        '******** Formulario Inicio de Sesion 
        Dim _frmOpen As New SIM___GLOBAL.frmSesion
        _frmOpen.ShowDialog()

        If _frmOpen.validar = True Then
            IdEmpleado = _frmOpen.IDEmpleado
            lblUsers.Caption = _frmOpen.NombreEmpleado
            bsiCargo.Caption = _frmOpen.Cargo
            bsiEspecialidad.Caption = _frmOpen.Especialidad
            IdEspecialidad = _frmOpen.IDEspecialidad
            CargarPrivilegios(IdEmpleado)
        Else
            End
        End If
        'FORMULARIO DE BIENVENIDA
        'Dim _frmBienvenidos = New SIM___GLOBAL.frmBienvenida
        '_frmBienvenidos.MdiParent = Me
        '_frmBienvenidos.Show()
    End Sub

    Private Sub bbiAcercaDe_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAcercaDe.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmAcercaDe
        _frmOpen.IDLicencia = 4 'idlicenciag
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiPrivilegios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrivilegios.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmPrivilegios
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiSeguridad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSeguridad.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmSeguridad
        _frmOpen.idEmpleado2 = IdEmpleado
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtSalir.ItemClick
        End
    End Sub

    Private Sub bbiUsers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUsers.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmUsers
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtDiagnosticos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtDiagnosticos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmDiagnosticos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiCups_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCups.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCups
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtMedicamentos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtMedicamentos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmMedicamentos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEmpleados_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEmpleados.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmEmpleados
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEspecialidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEspecialidades.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmEspecialidades
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiCargos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCargos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmCargos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiTarifas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTarifas.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmTarifas
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiContratos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiContratos.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmContratos
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiSubEntidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSubEntidades.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.frmSubEntidades
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiEntidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEntidades.ItemClick
        Dim _frmOpen As New SIM___GLOBAL.FrmEntidades
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtUsuarios.ItemClick
        Dim _frmOpen As New SIM___INTEGRA.frmUsuarios
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbiImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        If Registro <> "" Then
            If _DHistoriaIntegra.ExisteEvolucionHistoria(Registro) = False Then
                MessageBox.Show("La orden # " & Registro & " no tiene evoluciones", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf _DHistoriaIntegra.HistoriaSinFirma(Registro) = True Then
                MessageBox.Show("La orden no puede imprimirse porque presenta historias sin firma", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '_DImpresionHistoria.EliminarHistoria(Registro, IdEmpleado)
                '_DImpresionHistoria.Guardar(Registro, IdEmpleado)
            Else
                _DImpresionHistoria.EliminarHistoria(IdEmpleado)
                _DImpresionHistoria.Guardar(Registro, IdEmpleado)
                ImprimirFrm.CargarReporte("reportemensual.rpt", Registro)
                _DImpresionHistoria.EliminarHistoria(IdEmpleado)
            End If
        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub bbiVistaPrevia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVistaPrevia.ItemClick
        'Registro = 26
        Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
        If Registro <> "" Then
            If _DHistoriaIntegra.ExisteEvolucionHistoria(Registro) = False Then
                MessageBox.Show("La orden # " & Registro & " no tiene evoluciones", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf _DHistoriaIntegra.HistoriaSinFirma(Registro) = True Then
                MessageBox.Show("La orden no puede imprimirse porque presenta historias sin firma", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                _DImpresionHistoria.EliminarHistoria(IdEmpleado)
                _DImpresionHistoria.Guardar(Registro, IdEmpleado)
                ImprimirFrm.CargarReporte("reportemensual.rpt", Registro)
                _DImpresionHistoria.EliminarHistoria(IdEmpleado)
            End If
        Else
            MessageBox.Show("Debe Seleccionar una Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub BbtNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNuevo.ItemClick
        Dim _frmOpen As New SIM___INTEGRA.frmOrdenes
        _frmOpen.ShowDialog()
    End Sub

    Private Sub BbtConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtConsultar.ItemClick
        If Funciones.IsLoaded("frmConsultar") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Consultar Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmConsultar = New SIM___INTEGRA.frmConsultar
            _frmConsultar.MdiParent = Me
            _frmConsultar.Recargar()
            _frmConsultar.Show()

        End If
    End Sub

    Private Sub BbtHistoria_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtHistoria.ItemClick
        If Funciones.IsLoaded("frmHistoria") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Historia Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmHistoria = New SIM___INTEGRA.frmHistoria
            _frmHistoria.MdiParent = Me
            _frmHistoria.especialistahistoria = lblUsers.Caption & " - " & bsiEspecialidad.Caption
            _frmHistoria.Show()


        End If
    End Sub

    Private Sub BbiAyudaProducto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAyudaProducto.ItemClick
        Dim _frmOpen As New SIM___INTEGRA.frmPrueba
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtHistoriasAnteriores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtHistoriasAnteriores.ItemClick
        If Funciones.IsLoaded("frmHistoriasAnteriores") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Historias Anteriores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmHistoriasAnteriores = New SIM___INTEGRA.frmHistoriasAnteriores
            _frmHistoriasAnteriores.MdiParent = Me
            _frmHistoriasAnteriores.Show()
        End If
    End Sub

    Private Sub BbiHistoriaGrupal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiHistoriaGrupal.ItemClick
        If Funciones.IsLoaded("frmHistoriaGrupal") = True Then
            MessageBox.Show("Esta Ventana se encuentra abierta", "Historia Grupal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _frmHistoriaGrupal = New SIM___INTEGRA.frmHistoriaGrupal
            _frmHistoriaGrupal.MdiParent = Me
            _frmHistoriaGrupal._Especialista = lblUsers.Caption & " - " & bsiEspecialidad.Caption
            _frmHistoriaGrupal.Show()

        End If
    End Sub

    Private Sub BbiSoporteTecnico_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSoporteTecnico.ItemClick
        Dim _frmOpen As New SIM___INTEGRA.frmVistaHistoria
        _frmOpen.IdDetalleOrden = "38442"
        _frmOpen.ShowDialog()
    End Sub

    Private Sub BbiCerrarSesion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrarSesion.ItemClick
        If Funciones.IsLoaded("frmConsultar") = True Or Funciones.IsLoaded("frmHistoria") = True Or Funciones.IsLoaded("frmHistoriasAnteriores") = True Or Funciones.IsLoaded("frmHistoriaGrupal") = True Then
            If MessageBox.Show("Se encuentran ventanas Abiertas, ¿Desea cerrarlas junto con la Sesion?", "Cerrar Sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                'MessageBox.Show("SI")
                If Funciones.IsLoaded("frmConsultar") = True Then
                    _frmConsultar.Close()
                End If
                If Funciones.IsLoaded("frmHistoria") = True Then
                    _frmHistoria.Close()
                End If
                If Funciones.IsLoaded("frmHistoriasAnteriores") = True Then
                    _frmHistoriasAnteriores.Close()
                End If
                If Funciones.IsLoaded("frmHistoriaGrupal") = True Then
                    _frmHistoriaGrupal.Close()
                End If

                'MessageBox.Show("Cerrar Sesion")
                '******** Formulario Inicio de Sesion 
                Dim _frmOpen As New SIM___GLOBAL.frmSesion
                _frmOpen.ShowDialog()

                If _frmOpen.validar = True Then
                    IdEmpleado = _frmOpen.IDEmpleado
                    lblUsers.Caption = _frmOpen.NombreEmpleado
                    bsiCargo.Caption = _frmOpen.Cargo
                    bsiEspecialidad.Caption = _frmOpen.Especialidad
                    IdEspecialidad = _frmOpen.IDEspecialidad
                    CargarPrivilegios(IdEmpleado)
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
                IdEmpleado = _frmOpen.IDEmpleado
                lblUsers.Caption = _frmOpen.NombreEmpleado
                bsiCargo.Caption = _frmOpen.Cargo
                bsiEspecialidad.Caption = _frmOpen.Especialidad
                IdEspecialidad = _frmOpen.IDEspecialidad
                CargarPrivilegios(IdEmpleado)
            Else
                End
            End If
        End If
    End Sub

    Private Sub BbiListadoOrdenes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiListadoOrdenes.ItemClick
        Dim _frmOpen As New SIM___INTEGRA.frmListadoOrdenes
        _frmOpen.ShowDialog()
    End Sub

    Private Sub bbtCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtCancelar.ItemClick
        If Registro = "" Then
            MessageBox.Show("Debe seleccionar una orden", "Anular Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf _dhistoriaintegra.Existeordenhistoria(Registro) = True Then
            'MsgBox("Existe")
            MessageBox.Show("Esta orden no puede ser anulada porque tiene historias vinculadas", "Anular Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Esta seguro que desea anular la orden # " & Registro, "Anular Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                _DOrdenes.CancelarOrden(Registro)
                Dim funciones = New SIM___GLOBAL.Utilidades.Funciones
                funciones.CargarFuncionFormulario("frmConsultar", "Recargar")
                Registro = ""
            End If
        End If
    End Sub

    Private Sub ImpresionHistoria(ByVal Filtro As String)

        Dim _ds = New DataSet
        ' _ds = _dImpresionHistoria.Listar(Filtro, Control)
        '************* CARGAMOS DATOS DE IMPRESION **************
        _ImpresionHistoria.Id = Val("")
        _ImpresionHistoria.IdOrden = _ds.Tables(0).Rows(0)(0).ToString
        ' _ImpresionHistoria.Contrato = _ds.Tables(0).Rows(0)(1).ToString
        ' _ImpresionHistoria.Identificacion = _ds.Tables(0).Rows(0)(2).ToString
        ' _ImpresionHistoria.Nombre = _ds.Tables(0).Rows(0)(3).ToString
        ' _ImpresionHistoria.Edad = _ds.Tables(0).Rows(0)(4).ToString
        ' _ImpresionHistoria.Sexo = _ds.Tables(0).Rows(0)(5).ToString

        '_ImpresionHistoria.FechaNacimiento = _ds.Tables(0).Rows(0)(6).ToString
        '_ImpresionHistoria.EstadoCivil = _ds.Tables(0).Rows(0)(7).ToString
        '_ImpresionHistoria.Direccion = _ds.Tables(0).Rows(0)(8).ToString
        '_ImpresionHistoria.Ocupacion = _ds.Tables(0).Rows(0)(9).ToString
        '_ImpresionHistoria.Telefono = _ds.Tables(0).Rows(0)(10).ToString

        '_ImpresionHistoria.Responsable = _ds.Tables(0).Rows(0)(11).ToString
        '_ImpresionHistoria.Acompanante = _ds.Tables(0).Rows(0)(12).ToString
        _ImpresionHistoria.Fecha = _ds.Tables(0).Rows(0)(13).ToString
        _ImpresionHistoria.ReporteEvolucion = _ds.Tables(0).Rows(0)(14).ToString
        _ImpresionHistoria.Especialista = _ds.Tables(0).Rows(0)(15).ToString

        _ImpresionHistoria.RegistroMedico = _ds.Tables(0).Rows(0)(16).ToString
        _ImpresionHistoria.NombreEspecialidad = _ds.Tables(0).Rows(0)(17).ToString
        _ImpresionHistoria.Firma = _funciones.Bytes_Imagen(_ds.Tables(0).Rows(0)(18))

        '_DImpresionHistoria.Guardar(_ImpresionHistoria)
    End Sub
End Class
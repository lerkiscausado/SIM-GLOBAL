Imports System.Data.Common
Imports System.Reflection
Imports System.Data.Odbc
Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.My.Modelo
Imports System.IO
Imports CrystalDecisions.Shared

Namespace Utilidades

    Public Class Funciones
        Shared _conn As New OdbcConnection
        Public Shared idEmpleadoPrueba As String
        Public Shared Function IsLoaded(ByVal formName As String) As Boolean
            Try
                For Each f As Form In Application.OpenForms
                    If f.Name = formName Then
                        Return True

                    End If
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End Function

        Public Sub CargarFuncionFormulario(ByVal formName As String, ByVal metodo As String,
                                            ByVal parametros() As Object)
            For Each f As Form In Application.OpenForms
                If f.Name = formName Then
                    If parametros.Count() > 0 Then
                        f.GetType().GetMethod(metodo).Invoke(f, parametros)
                    Else
                        f.GetType().GetMethod(metodo).Invoke(f, Nothing)
                    End If
                End If
            Next
        End Sub
        Public Sub CargarFuncionFormulario(ByVal formName As String, ByVal metodo As String)
            Try
                For Each f As Form In Application.OpenForms
                    If f.Name = formName Then
                        f.GetType().GetMethod(metodo).Invoke(f, New Object() {})
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub
        Public Function ImprimirOrden(ByVal filtro As String) As DataSet
            Dim _conn As New OdbcConnection
            Dim _ds As DataSet
            Dim _adapter As DataAdapter
            Try
                Dim query As String =
                        String.Format("select * from ordenes where codigo_orden ='{0}'", filtro)
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        'FUNCION DEVUELVE DATOS DE USUARIO
        Public Shared Function CalcularEdad(ByVal Fecha As Date) As String
            Try
                Dim fecha1 As Date = (Fecha) 'Fecha de nacimiento
                Dim fecha2 As Date = Today 'Fecha actual del sistema

                If fecha2.Year < fecha1.Year Then
                    MessageBox.Show("El año de nacimiento debe ser menor al año actual")
                    Return Nothing
                Else
                    If fecha2.Month - fecha1.Month < 0 Then
                        Return CStr((fecha2.Year - fecha1.Year) - 1) & " año(s) " & CStr((fecha2.Month - fecha1.Month) + 12) & " mes(s) "
                    Else
                        Return CStr(fecha2.Year - fecha1.Year) & " año(s) " & CStr(fecha2.Month - fecha1.Month) & " mes(s) "
                    End If

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
                Return Nothing
            End Try
        End Function
        Public Shared Function DatosUsuarioDS(ByVal filtro As String) As DataSet
            Dim _conn As New OdbcConnection
            Dim _ds As DataSet
            Dim _adapter As DataAdapter
            Try
                Dim query As String =
                        String.Format("SELECT usuarios.ID, CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) AS IDENTIFICACION " _
                                      & ",  CONCAT(usuarios.PRIMER_NOMBRE,' ',usuarios.SEGUNDO_NOMBRE,' ',usuarios.PRIMER_APELLIDO,' ',usuarios.SEGUNDO_APELLIDO) AS PACIENTE " _
                                      & ", usuarios.SEXO, usuarios.FECHA_NACIMIENTO, usuarios.TELEFONO, usuarios.DIRECCION, usuarios.CORREO_ELECTRONICO " _
                                      & "FROM ordenes INNER JOIN usuarios ON (ordenes.ID_USUARIO = usuarios.ID) WHERE (ordenes.ID ='" & filtro & "')")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Return _ds
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Shared Function DatosUsuario(ByVal filtro As String, ByVal tabla As String) As String
            Select Case tabla
                Case "ORDENES"
                    Try
                        Dim query As String = String.Format("SELECT id, CONCAT(id_tipo_identificacion,identificacion) AS IDENTIFICACION " _
                                                            & ",CONCAT(primer_nombre,' ',segundo_nombre,' ',primer_apellido,' ',segundo_apellido) " _
                                                            & "AS NOMBRE ,sexo	,fecha_nacimiento	,telefono ,direccion " _
                                                            & ",CORREO_ELECTRONICO FROM usuarios where id='" & filtro & "'")
                        Dim _conn As New OdbcConnection
                        _conn = ConexionODBC.Open()
                        Dim comando = New OdbcCommand(query, _conn)
                        Dim _adapter = New OdbcDataAdapter(comando)
                        Dim _ds = New DataSet()
                        _adapter.Fill(_ds)
                        ConexionODBC.Close(_conn)
                        Dim datos As String
                        Dim edad = CalcularEdad(_ds.Tables(0).Rows(0)(4).ToString)
                        datos = "ID: " & _ds.Tables(0).Rows(0)(0).ToString & "     IDENTIFICACION: " & _ds.Tables(0).Rows(0)(1).ToString & vbCrLf _
                            & "PACIENTE: " & _ds.Tables(0).Rows(0)(2).ToString & vbCrLf _
                            & "SEXO: " & _ds.Tables(0).Rows(0)(3).ToString & " EDAD:" & edad & "  TELEFONO: " & _ds.Tables(0).Rows(0)(5).ToString & vbCrLf _
                            & "DIRECCION: " & _ds.Tables(0).Rows(0)(6).ToString & vbCrLf _
                            & "CORREO ELECTRONICO: " & _ds.Tables(0).Rows(0)(7).ToString
                        Return datos
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Return Nothing
                    End Try
                Case "HISTORIA"
                    Try
                        Dim query As String = String.Format("SELECT usuarios.id,CONCAT(usuarios.id_tipo_identificacion,usuarios.identificacion) AS IDENTIFICACION " _
                            & ",CONCAT(usuarios.primer_nombre,' ',usuarios.segundo_nombre,' ',usuarios.primer_apellido,' ',usuarios.segundo_apellido) AS NOMBRE " _
                            & ",usuarios.sexo ,fecha_nacimiento ,usuarios.telefono ,usuarios.direccion " _
                            & " ,usuarios.CORREO_ELECTRONICO  FROM usuarios INNER JOIN `ordenes` ON (`usuarios`.`ID` = `ordenes`.`ID_USUARIO`) WHERE ordenes.id='" & filtro & "'")
                        Dim _conn As New OdbcConnection
                        _conn = ConexionODBC.Open()
                        Dim comando = New OdbcCommand(query, _conn)
                        Dim _adapter = New OdbcDataAdapter(comando)
                        Dim _ds = New DataSet()
                        _adapter.Fill(_ds)
                        ConexionODBC.Close(_conn)
                        Dim datos As String
                        Dim edad = CalcularEdad(_ds.Tables(0).Rows(0)(4).ToString)

                        datos = "ID: " & _ds.Tables(0).Rows(0)(0).ToString & "     IDENTIFICACION: " & _ds.Tables(0).Rows(0)(1).ToString & vbCrLf _
                            & "PACIENTE: " & _ds.Tables(0).Rows(0)(2).ToString & vbCrLf _
                            & "SEXO: " & _ds.Tables(0).Rows(0)(3).ToString & " EDAD:" & edad & "  TELEFONO: " & _ds.Tables(0).Rows(0)(5).ToString & vbCrLf _
                            & "DIRECCION: " & _ds.Tables(0).Rows(0)(6).ToString & vbCrLf _
                            & "CORREO ELECTRONICO: " & _ds.Tables(0).Rows(0)(7).ToString
                        Return datos
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Return Nothing
                    End Try
                Case Else
                    Return Nothing
            End Select
        End Function
        Public Shared Function CodigoUsuario(ByVal filtro As String) As String
            Try
                Dim query As String = String.Format("SELECT CONCAT(usuarios.ID_TIPO_IDENTIFICACION,usuarios.IDENTIFICACION) " _
                                                & "AS CODIGO FROM ordenes INNER JOIN usuarios ON " _
                                                & "(ordenes.ID_USUARIO = usuarios.ID) WHERE (ordenes.ID ='" & filtro & "')")
                Dim _conn As New OdbcConnection
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                Dim _adapter = New OdbcDataAdapter(comando)
                Dim _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim datos As String
                datos = _ds.Tables(0).Rows(0)(0).ToString
                Return datos
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try

        End Function
        Public Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
            'si hay imagen
            If Not Imagen Is Nothing Then
                'variable de datos binarios en stream(flujo)
                Dim Bin As New MemoryStream
                'convertir a bytes
                Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
                'retorna binario
                Return Bin.GetBuffer
            Else
                Return Nothing
            End If
        End Function
        Public Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
            Try
                'si hay imagen
                If Not Imagen Is Nothing Then
                    'caturar array con memorystream hacia Bin
                    Dim Bin As New MemoryStream(Imagen)
                    'con el método FroStream de Image obtenemos imagen
                    Dim Resultado As Image = Image.FromStream(Bin)
                    'y la retornamos
                    Return Resultado
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
        Public Function Num2Text(ByVal value As Double) As String
            Select Case value
                Case 0 : Num2Text = "CERO"
                Case 1 : Num2Text = "UN"
                Case 2 : Num2Text = "DOS"
                Case 3 : Num2Text = "TRES"
                Case 4 : Num2Text = "CUATRO"
                Case 5 : Num2Text = "CINCO"
                Case 6 : Num2Text = "SEIS"
                Case 7 : Num2Text = "SIETE"
                Case 8 : Num2Text = "OCHO"
                Case 9 : Num2Text = "NUEVE"
                Case 10 : Num2Text = "DIEZ"
                Case 11 : Num2Text = "ONCE"
                Case 12 : Num2Text = "DOCE"
                Case 13 : Num2Text = "TRECE"
                Case 14 : Num2Text = "CATORCE"
                Case 15 : Num2Text = "QUINCE"
                Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
                Case 20 : Num2Text = "VEINTE"
                Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
                Case 30 : Num2Text = "TREINTA"
                Case 40 : Num2Text = "CUARENTA"
                Case 50 : Num2Text = "CINCUENTA"
                Case 60 : Num2Text = "SESENTA"
                Case 70 : Num2Text = "SETENTA"
                Case 80 : Num2Text = "OCHENTA"
                Case 90 : Num2Text = "NOVENTA"
                Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
                Case 100 : Num2Text = "CIEN"
                Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
                Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
                Case 500 : Num2Text = "QUINIENTOS"
                Case 700 : Num2Text = "SETECIENTOS"
                Case 900 : Num2Text = "NOVECIENTOS"
                Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
                Case 1000 : Num2Text = "MIL"
                Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
                Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                    If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
                Case 1000000 : Num2Text = "UN MILLON"
                Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
                Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES"
                    If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
                Case 1000000000000.0# : Num2Text = "UN BILLON"
                Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
                Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                    If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            End Select

            Return Num2Text
        End Function
#Region "Funciones de Impresion"
        Public Sub ImprimirHistoria(ByVal IDDetalleOrden As String, ByVal IDEmpleado As String)
            'Declaramos las variables a utilizar
            Dim _ds As DataSet

            'traemos los datos de historia a imprimir
            Dim _dImpresionHistoria As New SIM___GLOBAL.Controles.DImpresionHistoria
            'Dim _ImpresionHistoria As New SIM___GLOBAL.Modelo.ImpresionHistoria
            _dImpresionHistoria.GuardarImpresionHistoria(IDDetalleOrden, IDEmpleado)
            ImprimirDetalleHistoriaGlobal(IDDetalleOrden, IDEmpleado)

        End Sub
        Public Sub ImprimirDetalleHistoria(ByVal Filtro As String, ByVal IDEmpleado As String, ByVal Tabla As String)
            'Declaramos las variables a utilizar
            Dim _ds As DataSet

            'traemos los datos de historia a imprimir
            Dim _dImpresiondetalleHistoria As New SIM___GLOBAL.Controles.DImpresionDetalleHistoria
            'Dim _ImpresionHistoria As New SIM___GLOBAL.Modelo.ImpresionHistoria
            _dImpresiondetalleHistoria.GuardarImpresionDetalleHistoria(Filtro, IDEmpleado, Tabla)

        End Sub
        Public Sub ImprimirDetalleHistoriaGlobal(ByVal IDDetalleOrden As String, ByVal IDEmpleado As String)
            'Declaramos las variables a utilizar
            Dim _ds As DataSet

            'traemos los datos de historia a imprimir
            Dim _dImpresiondetalleHistoria As New SIM___GLOBAL.Controles.DImpresionDetalleHistoria
            'Dim _ImpresionHistoria As New SIM___GLOBAL.Modelo.ImpresionHistoria
            _dImpresiondetalleHistoria.GuardarDetalleHistoriaGlobal(IDDetalleOrden, IDEmpleado)

        End Sub
#End Region
#Region "FUNCION IMPRIMIR ACTUALIZADA"
        Public Sub Imprimir(ByVal IdOrden, ByVal IdDetalleOrden, ByVal TipoEstudio, ByVal Licencia)
            Dim _dImpresion As New SIM___GLOBAL.Controles.DImpresion
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir
            Select Case Licencia
                Case 1 'ADOS
                    MsgBox("Licencia ADOS")
                Case 2 'INMUNOPAT 
                    MsgBox("Licencia Inmunopat")
                Case 3 'DITEG
                    MsgBox("Licencia Diteg")
                Case 4 'GASTROLAP
                    MsgBox("Licencia Gastrolap")
                    'verificamos si el registro existe IDDEtalleORDEN
                    Select Case TipoEstudio
                        Case "CONSULTA PRIMERA VEZ", "CONSULTA DE CONTROL"
                            'If _dImpresion.ExisteIDDetalleOrden(IdDetalleOrden) = True Then
                            'MsgBox("existe historia")
                            'ImprimirFrm.ImprimirHistoria(IdDetalleOrden, 1, Licencia)
                            'Else
                            '_dImpresion.GuardarHistoria(IdOrden)
                            '_dImpresion.GuardarImpresion(IdOrden, TipoEstudio)
                            'MsgBox("no existe historia - historia guardada")
                            'ImprimirFrm.ImprimirHistoria(IdDetalleOrden, 1, Licencia)
                            'End If
                            If _dImpresion.ExisteIDDetalleOrden(IdDetalleOrden) = False Then
                                _dImpresion.GuardarImpresion(IdOrden, TipoEstudio)
                            End If

                            If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                ImprimirFrm.ImprimirHistoria(IdDetalleOrden, 1, Licencia)
                            Else
                                ImprimirFrm.ImprimirHistoria(IdDetalleOrden, 0, Licencia)
                            End If
                        Case "ENDOSCOPIA"

                            If _dImpresion.ExisteIDDetalleOrden(IdDetalleOrden) = False Then
                                _dImpresion.GuardarImpresion(IdOrden, TipoEstudio)
                            End If

                            If MessageBox.Show("¿Desea Imprimir Reporte con Encabezado?", "Imprimir Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                ImprimirFrm.ImprimirEndoscopia(IdDetalleOrden, 1, Licencia, "0")
                            Else
                                ImprimirFrm.ImprimirEndoscopia(IdDetalleOrden, 0, Licencia, "0")
                            End If

                        Case Else
                    End Select

                Case 6 'KELLY GOMEZ
                    Select Case TipoEstudio
                        Case "CITOLOGIA"
                            ImprimirFrm.ImprimirCitologia(IdOrden, 1, Licencia, 0, True)
                        Case "BIOPSIA", "BACAF", "INMUNOHISTOQUIMICA", "RECEPTORES HORMONALES"
                            ImprimirFrm.ImprimirPatologia(IdOrden, 1, Licencia, 0, True)
                        Case Else
                    End Select
                Case 9 'BEATRIZ LINCE ENDOSCOPIA
                    Select Case TipoEstudio
                        Case "CONSULTA PRIMERA VEZ", "CONSULTA DE CONTROL"
                            If _dImpresion.ExisteIDDetalleOrden(IdDetalleOrden) = True Then
                                'MsgBox("existe historia")
                                ImprimirFrm.ImprimirHistoria(IdDetalleOrden, 1, Licencia)
                            Else
                                _dImpresion.GuardarImpresion(IdOrden, TipoEstudio)
                                'MsgBox("no existe historia - historia guardada")
                                ImprimirFrm.ImprimirHistoria(IdDetalleOrden, 1, Licencia)
                            End If
                        Case Else
                    End Select
                Case 10 'FANNY LINCE ORTODONCIA
                    MsgBox("Licencia FANNY LINCE ORTODONCIA")
                Case 11 'CITOPAT DE LA COSTA
                    Select Case TipoEstudio
                        Case "CITOLOGIA"
                            ImprimirFrm.ImprimirCitologia(IdOrden, 1, Licencia, 0, True)
                        Case "BIOPSIA", "BACAF", "INMUNOHISTOQUIMICA", "RECEPTORES HORMONALES"
                            ImprimirFrm.ImprimirPatologia(IdOrden, 1, Licencia, 0, True)
                        Case Else
                    End Select

                Case 12 'AQUAMEDICA
                Case 14 'FERNANDO PONCE
                    Select Case TipoEstudio
                        Case "CONSULTA PRIMERA VEZ", "CONSULTA DE CONTROL"
                            If _dImpresion.ExisteIDDetalleOrden(IdDetalleOrden) = True Then
                                'MsgBox("existe historia")
                                ImprimirFrm.ImprimirHistoria(IdDetalleOrden, 1, Licencia)
                            Else
                                _dImpresion.GuardarImpresion(IdOrden, TipoEstudio)
                                'MsgBox("no existe historia - historia guardada")
                                ImprimirFrm.ImprimirHistoria(IdDetalleOrden, 1, Licencia)
                            End If
                        Case Else
                    End Select
            End Select
        End Sub
        Public Sub ImprimirOrdenesMedicas(ByVal IdOrden, ByVal IdDetalleOrden, ByVal TipoEstudio, ByVal Licencia, ByVal OrdenMedica)
            Dim _dImpresion As New SIM___GLOBAL.Controles.DImpresion
            Dim ImprimirFrm As New SIM___GLOBAL.frmImprimir

            Select Case TipoEstudio
                Case "CONSULTA PRIMERA VEZ", "CONSULTA DE CONTROL"
                    Select Case OrdenMedica
                        Case "LABORATORIOS"
                            Dim _dHistoriaLaboratorio As New SIM___GLOBAL.Controles.DHistoriaLaboratorios
                            If _dHistoriaLaboratorio.ExisteLaboratorio(IdOrden) = True Then
                                'Imprimimos los laboratorios
                                ImprimirFrm.ImprimirOrdenMedica(IdOrden, Licencia, "LABORATORIOS")
                            Else
                                MessageBox.Show("No existen Laboratorios para esta Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Case "ESTUDIOS DIAGNOSTICOS"
                            Dim _dHistoriaLaboratorio As New SIM___GLOBAL.Controles.DHistoriaEstudiosDiagnosticos
                            If _dHistoriaLaboratorio.ExisteEstudiosDiagnosticos(IdOrden) = True Then
                                'Imprimimos los procedimientos
                                ImprimirFrm.ImprimirOrdenMedica(IdOrden, Licencia, "ESTUDIOS DIAGNOSTICOS")
                            Else
                                MessageBox.Show("No existen Procedimientos para esta Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Case "PROCEDIMIENTOS"
                            Dim _dHistoriaProcedimientos As New SIM___GLOBAL.Controles.DHistoriaProcedimientos
                            If _dHistoriaProcedimientos.ExisteProcedimientos(IdOrden) = True Then
                                'Imprimimos los procedimientos
                                ImprimirFrm.ImprimirOrdenMedica(IdOrden, Licencia, "PROCEDIMIENTOS")
                            Else
                                MessageBox.Show("No existen Procedimientos para esta Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Case "MEDICAMENTOS"
                            Dim _dHistoriaMedicamentos As New SIM___GLOBAL.Controles.DHistoriaMedicamentos
                            If _dHistoriaMedicamentos.ExisteMedicamento(IdOrden) = True Then
                                'Imprimimos los laboratorios
                                ImprimirFrm.ImprimirOrdenMedica(IdOrden, Licencia, "MEDICAMENTOS")
                            Else
                                MessageBox.Show("No existen Medicamentos para esta Orden", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                    End Select
                Case Else
                    MessageBox.Show("Estudio no aplica para Ordenes Medicas", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select

        End Sub
#End Region
        Public Sub EnviarReporteMail(ByVal IdOrden, ByVal IdDetalleOrden, ByVal TipoEstudio, ByVal Licencia, ByVal Ruta, ByVal Mail)
            Dim _dImpresion As New SIM___GLOBAL.Controles.DImpresion
            Select Case Licencia
                Case 1 'ADOS
                    MsgBox("Licencia ADOS")
                Case 2 'INMUNOPAT 
                    MsgBox("Licencia Inmunopat")
                Case 3 'DITEG
                    MsgBox("Licencia Diteg")
                Case 4 'GASTROLAP
                    'verificamos si el registro existe IDDEtalleORDEN
                    If _dImpresion.ExisteIDDetalleOrden(IdDetalleOrden) = False Then
                        _dImpresion.GuardarImpresion(IdOrden, TipoEstudio)
                    End If
                    'GenerarPDF(IdDetalleOrden, 1, Licencia, Ruta)
                    'EnviarPDF(Mail, Ruta, TipoEstudio)
                Case 6 'KELLY GOMEZ
                Case 9 'BEATRIZ LINCE ENDOSCOPIA
                    Select Case TipoEstudio
                        Case "CONSULTA PRIMERA VEZ", "CONSULTA DE CONTROL"
                            If _dImpresion.ExisteIDDetalleOrden(IdDetalleOrden) = False Then
                                _dImpresion.GuardarImpresion(IdOrden, TipoEstudio)
                            End If
                            'GenerarPDF(IdDetalleOrden, 1, Licencia, Ruta)
                            'EnviarPDF(Mail, Ruta, TipoEstudio)
                        Case Else
                    End Select
                Case 10 'FANNY LINCE ORTODONCIA
                    MsgBox("Licencia FANNY LINCE ORTODONCIA")
                Case 11 'CITOPAT DE LA COSTA
                    Select Case TipoEstudio
                        Case "CITOLOGIA"
                            'ImprimirFrm.ImprimirCitologia(IdOrden, 1, Licencia, 0, True)
                        Case "BIOPSIA", "BACAF", "INMUNOHISTOQUIMICA", "RECEPTORES HORMONALES"
                            'ImprimirFrm.ImprimirPatologia(IdOrden, 1, Licencia, 0, True)
                        Case Else
                    End Select

                Case 12 'AQUAMEDICA

            End Select
        End Sub
        Public Sub GenerarPDF(ByVal filtro As String, ByVal TipoEstudio As String, ByVal Reporte As String, ByVal Licencia As String, ByVal Ruta As String)
            Select Case Licencia
                Case "3", "4", "9", "14"
                    Select Case TipoEstudio
                        Case "CONSULTA PRIMERA VEZ", "CONSULTA DE CONTROL"
                            Try
                                Dim rptHistoriaClinica As New rptHistoriaClinica
                                rptHistoriaClinica.SetParameterValue("filtro", filtro)
                                rptHistoriaClinica.SetParameterValue("reporte", Reporte)

                                Dim crDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                                Dim crExportOptions As CrystalDecisions.Shared.ExportOptions = New CrystalDecisions.Shared.ExportOptions

                                crDiskFileDestinationOptions.DiskFileName = "d:\estudios\pdf\" & Ruta
                                'crDiskFileDestinationOptions.DiskFileName = "\\192.168.1.1\resultados\pdf\" & Ruta

                                With crExportOptions
                                    .ExportDestinationType = ExportDestinationType.DiskFile
                                    .ExportFormatType = ExportFormatType.PortableDocFormat
                                    .ExportDestinationOptions = crDiskFileDestinationOptions
                                End With

                                rptHistoriaClinica.Export(crExportOptions)
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                    End Select

                Case "11"
                    Select Case TipoEstudio
                        Case "CITOLOGIA"
                            Try
                                Dim rptCitologia = New rptCitologia
                                rptCitologia.SetParameterValue("filtro", filtro)

                                Dim crDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                                Dim crExportOptions As CrystalDecisions.Shared.ExportOptions = New CrystalDecisions.Shared.ExportOptions

                                'crDiskFileDestinationOptions.DiskFileName = "x:\pdf\" & Ruta
                                crDiskFileDestinationOptions.DiskFileName = Ruta

                                With crExportOptions
                                    .ExportDestinationType = ExportDestinationType.DiskFile
                                    .ExportFormatType = ExportFormatType.PortableDocFormat
                                    .ExportDestinationOptions = crDiskFileDestinationOptions
                                End With

                                rptCitologia.Export(crExportOptions)

                                'rptCitologia = Nothing
                                'crDiskFileDestinationOptions = Nothing
                                'crExportOptions = Nothing
                                rptCitologia.Close() ' Cierra el informe después de exportar
                                rptCitologia.Dispose() ' Libera los recursos
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                        Case "CITOLOGIA ANAL"
                            Try
                                Dim rptCitologia As New rptCitologiaAnoRectal
                                rptCitologia.SetParameterValue("filtro", filtro)

                                Dim crDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                                Dim crExportOptions As CrystalDecisions.Shared.ExportOptions = New CrystalDecisions.Shared.ExportOptions

                                'crDiskFileDestinationOptions.DiskFileName = "x:\pdf\" & Ruta
                                crDiskFileDestinationOptions.DiskFileName = Ruta

                                With crExportOptions
                                    .ExportDestinationType = ExportDestinationType.DiskFile
                                    .ExportFormatType = ExportFormatType.PortableDocFormat
                                    .ExportDestinationOptions = crDiskFileDestinationOptions
                                End With

                                rptCitologia.Export(crExportOptions)

                                rptCitologia = Nothing
                                crDiskFileDestinationOptions = Nothing
                                crExportOptions = Nothing
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                        Case "BIOPSIA", "BACAF", "INMUNOHISTOQUIMICA", "RECEPTORES HORMONALES"
                            Try
                                Dim rptPatologia = New rptPatologia
                                rptPatologia.SetParameterValue("filtro", filtro)

                                Dim crDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                                Dim crExportOptions As CrystalDecisions.Shared.ExportOptions = New CrystalDecisions.Shared.ExportOptions

                                'crDiskFileDestinationOptions.DiskFileName = "x:\pdf\" & Ruta
                                crDiskFileDestinationOptions.DiskFileName = Ruta

                                With crExportOptions
                                    .ExportDestinationType = ExportDestinationType.DiskFile
                                    .ExportFormatType = ExportFormatType.PortableDocFormat
                                    .ExportDestinationOptions = crDiskFileDestinationOptions
                                End With

                                rptPatologia.Export(crExportOptions)
                                'rptPatologia = Nothing
                                'crDiskFileDestinationOptions = Nothing
                                'crExportOptions = Nothing
                                rptPatologia.Close() ' Cierra el informe después de exportar
                                rptPatologia.Dispose() ' Libera los recursos
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                    End Select

            End Select

        End Sub
        Public Sub GenerarPDFAgora(ByVal filtro As String, ByVal Reporte As String, ByVal Licencia As String, ByVal Ruta As String)
            Try
                'generar Reporte Cotizacion
                Dim rptCotizacion As New rptCotizacionAgora
                rptCotizacion.SetParameterValue("filtro", filtro)

                Dim crDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                Dim crExportOptions As CrystalDecisions.Shared.ExportOptions = New CrystalDecisions.Shared.ExportOptions

                crDiskFileDestinationOptions.DiskFileName = "c:\sim\pdf\" & Ruta
                'crDiskFileDestinationOptions.DiskFileName = "\\192.168.1.1\resultados\pdf\" & Ruta

                With crExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .ExportDestinationOptions = crDiskFileDestinationOptions
                End With

                rptCotizacion.Export(crExportOptions)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End Sub
        Public Sub EnviarPDF(ByVal EMail As String, ByVal PDF As String, ByVal Asunto As String, ByVal Texto As String, ByVal Licencia As String)
            Dim smtp = New System.Net.Mail.SmtpClient
            Dim correo = New System.Net.Mail.MailMessage
            Dim adjunto As System.Net.Mail.Attachment
            Dim DatosCorreo As New SIM___GLOBAL.Modelo.ConfiguracionCorreo
            Dim dCorreo As New SIM___GLOBAL.Controles.DConfiguracionCorreo

            'llamamos la configuracion del correo
            DatosCorreo = dCorreo.Cargar(Licencia)

            With smtp
                .Port = DatosCorreo.Puerto '"587"
                .Host = DatosCorreo.Servidor '"cpanel6-co.conexcol.net"
                '.Host = "mail.citopatdelacosta.co"
                .Credentials = New System.Net.NetworkCredential(DatosCorreo.Correo, DatosCorreo.Pass)
                .EnableSsl = True
            End With

            adjunto = New System.Net.Mail.Attachment("c:\sim\pdf\" & PDF)
            With correo
                .From = New System.Net.Mail.MailAddress(DatosCorreo.Correo)
                .To.Add(EMail)
                .Subject = "Reporte: " & Asunto
                .Body = String.Format(Texto & "<p><span>Has recibido este e-mail porque eres usuario registrado en:<br />" _
                                      & "LICENCIA al amparo de nuestra Pol&iacute;tica de Privacidad. <br /><br />" _
                                      & "Enviado desde <span style='color: #ff0000;'>Software SIM </span>" _
                                      & "&nbsp;</span><span style='font-size: 13.3333px;'>se ha generado por un sistema autom&aacute;tico. <br />" _
                                      & "Por favor, no responda a este e-mail directamente. <br />Si tiene alguna duda o necesita ayuda contacte&nbsp;</span>" _
                                      & "<span style='font-size: 13.3333px;'>con nosotros.</span><span><br /></span></p>")
                .IsBodyHtml = True
                .Priority = System.Net.Mail.MailPriority.Normal
                .Attachments.Add(adjunto)

            End With

            Try
                smtp.Send(correo)
                MessageBox.Show("Su mensaje de correo ha sido enviado.",
                                "Correo enviado",
                                 MessageBoxButtons.OK)

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message,
                                "Error al enviar correo",
                                 MessageBoxButtons.OK)
            End Try
        End Sub
        Public Sub GuardarRegistro(ByVal IdTabla As String, ByVal IdRegistro As String, ByVal IdUsuario As String, ByVal TipoRegistro As String, ByVal Nota As String)
            Try
                Dim query As String
                query = "INSERT INTO registros VALUES(0, " _
                            & "CURDATE(), " _
                            & "TIME_FORMAT(NOW( ) , '%H:%i:%s'), " _
                            & "'" & IdTabla & "', " _
                            & "'" & IdRegistro & "', " _
                            & "'" & IdUsuario & "', " _
                            & "'" & TipoRegistro & "', " _
                            & "'" & Nota & "')"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
    End Class
End Namespace


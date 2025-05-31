Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.IO
Namespace Controles
    Public Class DImpresionEndoscopia
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As New SIM___GLOBAL.Utilidades.Funciones
        Public Sub EliminarEndoscopia(ByVal IdEmpleado As String)
            Try
                Dim query As String
                query = "DELETE FROM impresion_endoscopia WHERE id_empleado='" & IdEmpleado & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar(ByVal filtro As String) As DataSet
            Try
                Dim query As String
                query = String.Format("SELECT `ordenes`.`ID` AS ID_ORDEN, " _
                                      & "detalle_orden.id as ID_DETALLE_ORDEN, " _
                                      & "endoscopias.id as ESTUDIO, " _
                                      & "ordenes.FECHA_INGRESO, " _
                                      & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS NOMBRE, " _
                                      & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) As IDENTIFICACION, " _
                                      & "`usuarios`.`FECHA_NACIMIENTO` AS EDAD, " _
                                      & "`usuarios`.`SEXO`, " _
                                      & "`usuarios`.`ESTADO_CIVIL`, " _
                                      & "`usuarios`.`TELEFONO`, " _
                                      & "`usuarios`.`DIRECCION`, " _
                                      & "`entidades`.`NOMBRE_ENTIDAD` AS ENTIDAD, " _
                                      & "`endoscopias`.`MEDICO_SOLICITA`, " _
                                      & "`endoscopias`.`INDICACION`, " _
                                      & "`endoscopias`.`MEDICAMENTOS`, " _
                                      & "`equipos`.`NOMBRE` AS EQUIPO, " _
                                      & "`endoscopias`.`ANESTESIOLOGO`, " _
                                      & "`procedimientos_terapeuticos`.`nombre`, " _
                                      & "`endoscopias`.`CAMPO1`, " _
                                      & "`endoscopias`.`CAMPO2`, " _
                                      & "`endoscopias`.`CAMPO3`, " _
                                      & "`endoscopias`.`CAMPO4`, " _
                                      & "`endoscopias`.`CAMPO5`, " _
                                      & "`endoscopias`.`CAMPO6`, " _
                                      & "`endoscopias`.`DIAGNOSTICO`, " _
                                      & "especialistas.`FIRMA`, " _
                                      & "especialistas.`NOMBRE`, " _
                                      & "especialistas.`ESPECIALIDAD`, " _
                                      & "especialistas.`REGISTRO_MEDICO`, " _
                                      & "ordenes.id_empleado, " _
                                      & "'' as IMAGEN1, " _
                                      & "'' as IMAGEN2, " _
                                      & "'' as IMAGEN3, " _
                                      & "'' as IMAGEN4, " _
                                      & "'' as IMAGEN5, " _
                                      & "'' as IMAGEN6, " _
                                      & "'' as IMAGEN7, " _
                                      & "'' as IMAGEN8, " _
                                      & "'' as IMAGEN9, " _
                                      & "'' as TEXTO1, " _
                                      & "'' as TEXTO2, " _
                                      & "'' as TEXTO3, " _
                                      & "'' as TEXTO4, " _
                                      & "'' as TEXTO5, " _
                                      & "'' as TEXTO6, " _
                                      & "'' as TEXTO7, " _
                                      & "'' as TEXTO8, " _
                                      & "'' as TEXTO9, " _
                                      & "'' as NUMERO_FOTOS " _
                                      & "FROM " _
                                      & "`detalle_orden` INNER JOIN `ordenes` ON (`detalle_orden`.`ID_ORDEN` = `ordenes`.`ID`) " _
                                      & "INNER JOIN `endoscopias` ON (`detalle_orden`.`ID` = `endoscopias`.`ID_DETALLE_ORDEN`) " _
                                      & "INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                      & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) " _
                                      & "INNER JOIN `equipos` ON (`endoscopias`.`ID_EQUIPO` = `equipos`.`ID`) " _
                                      & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) " _
                                      & "INNER JOIN especialistas ON(`ordenes`.`ID_empleado` = `especialistas`.`ID_especialista`) " _
                                      & "INNER JOIN procedimientos_terapeuticos ON (`endoscopias`.`id_procedimiento_terapeutico` = `procedimientos_terapeuticos`.`ID`) " _
                                      & "WHERE detalle_orden.id='" & filtro & "'")
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
        Public Function VistaPreviaEndoscopia(ByVal filtro As String) As DataSet
            Try
                Dim query As String
                query = String.Format("select usuarios.`ID`, CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',`usuarios`.`SEGUNDO_NOMBRE`,' ',`usuarios`.`PRIMER_APELLIDO`,' ',`usuarios`.`SEGUNDO_APELLIDO`) AS NOMBRE " _
                                      & ",CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,`usuarios`.`IDENTIFICACION`) AS IDENTIFICACION ,`usuarios`.`SEXO` " _
                                      & ",TIMESTAMPDIFF(YEAR,usuarios.FECHA_NACIMIENTO,CURDATE()) AS EDAD, `usuarios`.`TELEFONO` ,`usuarios`.`DIRECCION` ,`ordenes`.`ID` AS ID_ORDEN  " _
                                      & ",`endoscopias`.FECHA_ESTUDIO,`entidades`.`NOMBRE_ENTIDAD`	,especialistas.`NOMBRE` , especialistas.`ESPECIALIDAD` ,cups.`NOMBRE_CUPS` " _
                                      & ",`endoscopias`.`MEDICO_SOLICITA`, `endoscopias`.`INDICACION`,`endoscopias`.`MEDICAMENTOS`,`equipos`.`NOMBRE` AS EQUIPO	,`endoscopias`.`ANESTESIOLOGO`, " _
                                      & "`procedimientos_terapeuticos`.`nombre`	, `endoscopias`.`CAMPO1`, `endoscopias`.`CAMPO2`, `endoscopias`.`CAMPO3`, `endoscopias`.`CAMPO4`, `endoscopias`.`CAMPO5` " _
                                      & ", `endoscopias`.`CAMPO6`, `endoscopias`.`DIAGNOSTICO`	, especialistas.`FIRMA`	, especialistas.`NOMBRE`, especialistas.`ESPECIALIDAD`, " _
                                      & "especialistas.`REGISTRO_MEDICO`, ordenes.id_empleado FROM 	`detalle_orden` INNER JOIN `ordenes` ON (`detalle_orden`.`ID_ORDEN` = `ordenes`.`ID`) " _
                                      & "INNER JOIN `endoscopias` ON (`detalle_orden`.`ID` = `endoscopias`.`ID_DETALLE_ORDEN`) 	INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                      & "INNER JOIN `contratos` ON (`ordenes`.`ID_CONTRATO` = `contratos`.`ID`) INNER JOIN `equipos` ON (`endoscopias`.`ID_EQUIPO` = `equipos`.`ID`) " _
                                      & "INNER JOIN `entidades` ON (`contratos`.`CODIGO_ENTIDAD` = `entidades`.`CODIGO_ENTIDAD`) INNER JOIN especialistas ON(`ordenes`.`ID_empleado` = `especialistas`.`ID_especialista`) " _
                                      & "INNER JOIN procedimientos_terapeuticos ON (`endoscopias`.`id_procedimiento_terapeutico` = `procedimientos_terapeuticos`.`ID`) " _
                                      & "INNER JOIN cups ON (detalle_orden.`CODIGO_CUPS`= cups.`CODIGO_CUPS`) WHERE detalle_orden.id='" & filtro & "'")
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
        Public Sub GuardarImagenes(ByVal _ImpresionEndoscopia As ImpresionEndoscopia, ByVal Contador As Integer)
            Try
                'Dim query As String

                Dim sql As String = "insert into impresion_endoscopia " _
                                    & "(ID,ID_ORDEN,ID_DETALLE_ORDEN,ESTUDIO,FECHA_INGRESO,NOMBRE,IDENTIFICACION,EDAD,SEXO,ESTADO_CIVIL,TELEFONO,DIRECCION,ENTIDAD,MEDICO_SOLICITA,INDICACION,MEDICAMENTOS,EQUIPO,ANESTESIOLOGO,PROCEDIMIENTO_TERAPEUTICO,CAMPO1,CAMPO2,CAMPO3,CAMPO4,CAMPO5,CAMPO6,DIAGNOSTICO,FIRMA,MEDICO,ESPECIALIDAD,REGISTRO_MEDICO,ID_EMPLEADO,IMAGEN1,IMAGEN2,IMAGEN3,IMAGEN4,IMAGEN5,IMAGEN6,IMAGEN7,IMAGEN8,IMAGEN9,TEXTO1,TEXTO2,TEXTO3,TEXTO4,TEXTO5,TEXTO6,TEXTO7,TEXTO8,TEXTO9,NUMERO_FOTOS) " _
                                    & "values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

                _conn = ConexionODBC.Open()

                Dim Comando As New OdbcCommand(sql, _conn)
                Dim Firma As Byte()
                Dim Imag1 As Byte()
                Dim Imag2 As Byte()
                Dim Imag3 As Byte()
                Dim Imag4 As Byte()
                Dim Imag5 As Byte()
                Dim Imag6 As Byte()
                Dim Imag7 As Byte()
                Dim Imag8 As Byte()
                Dim Imag9 As Byte()

                Firma = _funciones.Imagen_Bytes(_ImpresionEndoscopia.Firma)
                Imag1 = _funciones.Imagen_Bytes(_ImpresionEndoscopia.Imagen1)
                Imag2 = _funciones.Imagen_Bytes(_ImpresionEndoscopia.Imagen2)
                Imag3 = _funciones.Imagen_Bytes(_ImpresionEndoscopia.Imagen3)
                Imag4 = _funciones.Imagen_Bytes(_ImpresionEndoscopia.Imagen4)
                Imag5 = _funciones.Imagen_Bytes(_ImpresionEndoscopia.Imagen5)
                Imag6 = _funciones.Imagen_Bytes(_ImpresionEndoscopia.Imagen6)
                Imag7 = _funciones.Imagen_Bytes(_ImpresionEndoscopia.Imagen7)
                Imag8 = _funciones.Imagen_Bytes(_ImpresionEndoscopia.Imagen8)
                Imag9 = _funciones.Imagen_Bytes(_ImpresionEndoscopia.Imagen9)

                Comando.Parameters.AddWithValue(1, Val(_ImpresionEndoscopia.Id))
                Comando.Parameters.AddWithValue(2, _ImpresionEndoscopia.IdOrden)
                Comando.Parameters.AddWithValue(3, _ImpresionEndoscopia.IdDetalleOrden)
                Comando.Parameters.AddWithValue(4, _ImpresionEndoscopia.Estudio)
                Comando.Parameters.AddWithValue(5, _ImpresionEndoscopia.FechaIngreso)
                Comando.Parameters.AddWithValue(6, _ImpresionEndoscopia.Nombre)
                Comando.Parameters.AddWithValue(7, _ImpresionEndoscopia.Identificacion)
                Comando.Parameters.AddWithValue(8, _ImpresionEndoscopia.Edad)
                Comando.Parameters.AddWithValue(9, _ImpresionEndoscopia.Sexo)
                Comando.Parameters.AddWithValue(10, _ImpresionEndoscopia.EstadoCivil)
                Comando.Parameters.AddWithValue(11, _ImpresionEndoscopia.Telefono)
                Comando.Parameters.AddWithValue(12, _ImpresionEndoscopia.Direccion)
                Comando.Parameters.AddWithValue(13, _ImpresionEndoscopia.Entidad)
                Comando.Parameters.AddWithValue(14, _ImpresionEndoscopia.MedicoSolicita)
                Comando.Parameters.AddWithValue(15, _ImpresionEndoscopia.Indicacion)
                Comando.Parameters.AddWithValue(16, _ImpresionEndoscopia.Medicamentos)
                Comando.Parameters.AddWithValue(17, _ImpresionEndoscopia.Equipo)
                Comando.Parameters.AddWithValue(18, _ImpresionEndoscopia.Anestesiologo)
                Comando.Parameters.AddWithValue(19, _ImpresionEndoscopia.ProcedimientoTerapeutico)
                Comando.Parameters.AddWithValue(20, _ImpresionEndoscopia.Campo1)
                Comando.Parameters.AddWithValue(21, _ImpresionEndoscopia.Campo2)
                Comando.Parameters.AddWithValue(22, _ImpresionEndoscopia.Campo3)
                Comando.Parameters.AddWithValue(23, _ImpresionEndoscopia.Campo4)
                Comando.Parameters.AddWithValue(24, _ImpresionEndoscopia.Campo5)
                Comando.Parameters.AddWithValue(25, _ImpresionEndoscopia.Campo6)
                Comando.Parameters.AddWithValue(26, _ImpresionEndoscopia.Diagnostico)
                Comando.Parameters.AddWithValue(27, Firma)
                Comando.Parameters.AddWithValue(28, _ImpresionEndoscopia.Medico)
                Comando.Parameters.AddWithValue(29, _ImpresionEndoscopia.Especialidad)
                Comando.Parameters.AddWithValue(30, _ImpresionEndoscopia.RegistroMedico)
                Comando.Parameters.AddWithValue(31, _ImpresionEndoscopia.IdEmpleado)
                Comando.Parameters.AddWithValue(32, Imag1)
                Comando.Parameters.AddWithValue(33, Imag2)
                Comando.Parameters.AddWithValue(34, Imag3)
                Comando.Parameters.AddWithValue(35, Imag4)
                Comando.Parameters.AddWithValue(36, Imag5)
                Comando.Parameters.AddWithValue(37, Imag6)
                Comando.Parameters.AddWithValue(38, Imag7)
                Comando.Parameters.AddWithValue(39, Imag8)
                Comando.Parameters.AddWithValue(40, Imag9)
                Select Case Contador
                    Case 1
                        Comando.Parameters.AddWithValue(41, _ImpresionEndoscopia.Texto1)
                        Comando.Parameters.AddWithValue(42, "")
                        Comando.Parameters.AddWithValue(43, "")
                        Comando.Parameters.AddWithValue(44, "")
                        Comando.Parameters.AddWithValue(45, "")
                        Comando.Parameters.AddWithValue(46, "")
                        Comando.Parameters.AddWithValue(47, "")
                        Comando.Parameters.AddWithValue(48, "")
                        Comando.Parameters.AddWithValue(49, "")
                    Case 2
                        Comando.Parameters.AddWithValue(41, _ImpresionEndoscopia.Texto1)
                        Comando.Parameters.AddWithValue(42, _ImpresionEndoscopia.Texto2)
                        Comando.Parameters.AddWithValue(43, "")
                        Comando.Parameters.AddWithValue(44, "")
                        Comando.Parameters.AddWithValue(45, "")
                        Comando.Parameters.AddWithValue(46, "")
                        Comando.Parameters.AddWithValue(47, "")
                        Comando.Parameters.AddWithValue(48, "")
                        Comando.Parameters.AddWithValue(49, "")
                    Case 3
                        Comando.Parameters.AddWithValue(41, _ImpresionEndoscopia.Texto1)
                        Comando.Parameters.AddWithValue(42, _ImpresionEndoscopia.Texto2)
                        Comando.Parameters.AddWithValue(43, _ImpresionEndoscopia.Texto3)
                        Comando.Parameters.AddWithValue(44, "")
                        Comando.Parameters.AddWithValue(45, "")
                        Comando.Parameters.AddWithValue(46, "")
                        Comando.Parameters.AddWithValue(47, "")
                        Comando.Parameters.AddWithValue(48, "")
                        Comando.Parameters.AddWithValue(49, "")
                    Case 4
                        Comando.Parameters.AddWithValue(41, _ImpresionEndoscopia.Texto1)
                        Comando.Parameters.AddWithValue(42, _ImpresionEndoscopia.Texto2)
                        Comando.Parameters.AddWithValue(43, _ImpresionEndoscopia.Texto3)
                        Comando.Parameters.AddWithValue(44, _ImpresionEndoscopia.Texto4)
                        Comando.Parameters.AddWithValue(45, "")
                        Comando.Parameters.AddWithValue(46, "")
                        Comando.Parameters.AddWithValue(47, "")
                        Comando.Parameters.AddWithValue(48, "")
                        Comando.Parameters.AddWithValue(49, "")
                    Case 5
                        Comando.Parameters.AddWithValue(41, _ImpresionEndoscopia.Texto1)
                        Comando.Parameters.AddWithValue(42, _ImpresionEndoscopia.Texto2)
                        Comando.Parameters.AddWithValue(43, _ImpresionEndoscopia.Texto3)
                        Comando.Parameters.AddWithValue(44, _ImpresionEndoscopia.Texto4)
                        Comando.Parameters.AddWithValue(45, _ImpresionEndoscopia.Texto5)
                        Comando.Parameters.AddWithValue(46, "")
                        Comando.Parameters.AddWithValue(47, "")
                        Comando.Parameters.AddWithValue(48, "")
                        Comando.Parameters.AddWithValue(49, "")
                    Case 6
                        Comando.Parameters.AddWithValue(41, _ImpresionEndoscopia.Texto1)
                        Comando.Parameters.AddWithValue(42, _ImpresionEndoscopia.Texto2)
                        Comando.Parameters.AddWithValue(43, _ImpresionEndoscopia.Texto3)
                        Comando.Parameters.AddWithValue(44, _ImpresionEndoscopia.Texto4)
                        Comando.Parameters.AddWithValue(45, _ImpresionEndoscopia.Texto5)
                        Comando.Parameters.AddWithValue(46, _ImpresionEndoscopia.Texto6)
                        Comando.Parameters.AddWithValue(47, "")
                        Comando.Parameters.AddWithValue(48, "")
                        Comando.Parameters.AddWithValue(49, "")
                    Case 7
                        Comando.Parameters.AddWithValue(41, _ImpresionEndoscopia.Texto1)
                        Comando.Parameters.AddWithValue(42, _ImpresionEndoscopia.Texto2)
                        Comando.Parameters.AddWithValue(43, _ImpresionEndoscopia.Texto3)
                        Comando.Parameters.AddWithValue(44, _ImpresionEndoscopia.Texto4)
                        Comando.Parameters.AddWithValue(45, _ImpresionEndoscopia.Texto5)
                        Comando.Parameters.AddWithValue(46, _ImpresionEndoscopia.Texto6)
                        Comando.Parameters.AddWithValue(47, _ImpresionEndoscopia.Texto7)
                        Comando.Parameters.AddWithValue(48, "")
                        Comando.Parameters.AddWithValue(49, "")
                    Case 8
                        Comando.Parameters.AddWithValue(41, _ImpresionEndoscopia.Texto1)
                        Comando.Parameters.AddWithValue(42, _ImpresionEndoscopia.Texto2)
                        Comando.Parameters.AddWithValue(43, _ImpresionEndoscopia.Texto3)
                        Comando.Parameters.AddWithValue(44, _ImpresionEndoscopia.Texto4)
                        Comando.Parameters.AddWithValue(45, _ImpresionEndoscopia.Texto5)
                        Comando.Parameters.AddWithValue(46, _ImpresionEndoscopia.Texto6)
                        Comando.Parameters.AddWithValue(47, _ImpresionEndoscopia.Texto7)
                        Comando.Parameters.AddWithValue(48, _ImpresionEndoscopia.Texto8)
                        Comando.Parameters.AddWithValue(49, "")
                    Case Else
                        Comando.Parameters.AddWithValue(41, _ImpresionEndoscopia.Texto1)
                        Comando.Parameters.AddWithValue(42, _ImpresionEndoscopia.Texto2)
                        Comando.Parameters.AddWithValue(43, _ImpresionEndoscopia.Texto3)
                        Comando.Parameters.AddWithValue(44, _ImpresionEndoscopia.Texto4)
                        Comando.Parameters.AddWithValue(45, _ImpresionEndoscopia.Texto5)
                        Comando.Parameters.AddWithValue(46, _ImpresionEndoscopia.Texto6)
                        Comando.Parameters.AddWithValue(47, _ImpresionEndoscopia.Texto7)
                        Comando.Parameters.AddWithValue(48, _ImpresionEndoscopia.Texto8)
                        Comando.Parameters.AddWithValue(49, _ImpresionEndoscopia.Texto9)
                End Select
                Comando.Parameters.AddWithValue(50, _ImpresionEndoscopia.NumeroFotos)

                Comando.ExecuteNonQuery()

                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

        Public Sub Guardar(ByVal _ImpresionEndoscopia As ImpresionEndoscopia)
            Try
                'Dim query As String

                Dim sql As String = "insert into impresion_endoscopia " _
                                    & "(ID,ID_ORDEN,ID_DETALLE_ORDEN,ESTUDIO,FECHA_INGRESO,NOMBRE,IDENTIFICACION,EDAD,SEXO,ESTADO_CIVIL,TELEFONO,DIRECCION,ENTIDAD,MEDICO_SOLICITA,INDICACION,MEDICAMENTOS,EQUIPO,ANESTESIOLOGO,PROCEDIMIENTO_TERAPEUTICO,CAMPO1,CAMPO2,CAMPO3,CAMPO4,CAMPO5,CAMPO6,DIAGNOSTICO,FIRMA,MEDICO,ESPECIALIDAD,REGISTRO_MEDICO,ID_EMPLEADO) " _
                                    & "values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

                _conn = ConexionODBC.Open()

                Dim Comando As New OdbcCommand(sql, _conn)
                Dim Firma As Byte()

                Firma = _funciones.Imagen_Bytes(_ImpresionEndoscopia.Firma)

                Comando.Parameters.AddWithValue(1, Val(_ImpresionEndoscopia.Id))
                Comando.Parameters.AddWithValue(2, _ImpresionEndoscopia.IdOrden)
                Comando.Parameters.AddWithValue(3, _ImpresionEndoscopia.IdDetalleOrden)
                Comando.Parameters.AddWithValue(4, _ImpresionEndoscopia.Estudio)
                Comando.Parameters.AddWithValue(5, _ImpresionEndoscopia.FechaIngreso)
                Comando.Parameters.AddWithValue(6, _ImpresionEndoscopia.Nombre)
                Comando.Parameters.AddWithValue(7, _ImpresionEndoscopia.Identificacion)
                Comando.Parameters.AddWithValue(8, _ImpresionEndoscopia.Edad)
                Comando.Parameters.AddWithValue(9, _ImpresionEndoscopia.Sexo)
                Comando.Parameters.AddWithValue(10, _ImpresionEndoscopia.EstadoCivil)
                Comando.Parameters.AddWithValue(11, _ImpresionEndoscopia.Telefono)
                Comando.Parameters.AddWithValue(12, _ImpresionEndoscopia.Direccion)
                Comando.Parameters.AddWithValue(13, _ImpresionEndoscopia.Entidad)
                Comando.Parameters.AddWithValue(14, _ImpresionEndoscopia.MedicoSolicita)
                Comando.Parameters.AddWithValue(15, _ImpresionEndoscopia.Indicacion)
                Comando.Parameters.AddWithValue(16, _ImpresionEndoscopia.Medicamentos)
                Comando.Parameters.AddWithValue(17, _ImpresionEndoscopia.Equipo)
                Comando.Parameters.AddWithValue(18, _ImpresionEndoscopia.Anestesiologo)
                Comando.Parameters.AddWithValue(19, _ImpresionEndoscopia.ProcedimientoTerapeutico)
                Comando.Parameters.AddWithValue(20, _ImpresionEndoscopia.Campo1)
                Comando.Parameters.AddWithValue(21, _ImpresionEndoscopia.Campo2)
                Comando.Parameters.AddWithValue(22, _ImpresionEndoscopia.Campo3)
                Comando.Parameters.AddWithValue(23, _ImpresionEndoscopia.Campo4)
                Comando.Parameters.AddWithValue(24, _ImpresionEndoscopia.Campo5)
                Comando.Parameters.AddWithValue(25, _ImpresionEndoscopia.Campo6)
                Comando.Parameters.AddWithValue(26, _ImpresionEndoscopia.Diagnostico)
                Comando.Parameters.AddWithValue(27, Firma)
                Comando.Parameters.AddWithValue(28, _ImpresionEndoscopia.Medico)
                Comando.Parameters.AddWithValue(29, _ImpresionEndoscopia.Especialidad)
                Comando.Parameters.AddWithValue(30, _ImpresionEndoscopia.RegistroMedico)
                Comando.Parameters.AddWithValue(31, _ImpresionEndoscopia.IdEmpleado)

                Comando.ExecuteNonQuery()

                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

    End Class
End Namespace


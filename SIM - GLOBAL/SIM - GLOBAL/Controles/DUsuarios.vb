Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Namespace Controles
    Public Class DUsuarios
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As Funciones
        Public Shared Function Cargar(ByVal filtro As String) As Usuarios
            Try
                Dim query As String = String.Format("SELECT * FROM usuarios WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _usuarios = New Usuarios
                _usuarios.ID = _ds.Tables(0).Rows(0)(0).ToString()
                _usuarios.CodigotipoIdentificacion = _ds.Tables(0).Rows(0)(1).ToString()
                _usuarios.Identificacion = _ds.Tables(0).Rows(0)(2).ToString()
                _usuarios.PrimerNombre = _ds.Tables(0).Rows(0)(3).ToString()
                _usuarios.SegundoNombre = _ds.Tables(0).Rows(0)(4).ToString()
                _usuarios.PrimerApellido = _ds.Tables(0).Rows(0)(5).ToString()
                _usuarios.SegundoApellido = _ds.Tables(0).Rows(0)(6).ToString()
                _usuarios.Sexo = _ds.Tables(0).Rows(0)(7).ToString()
                _usuarios.FechaNacimiento = _ds.Tables(0).Rows(0)(8).ToString()
                _usuarios.CiudadNacimiento = _ds.Tables(0).Rows(0)(9).ToString()
                _usuarios.PaisNacimiento = _ds.Tables(0).Rows(0)(10).ToString()
                _usuarios.Direccion = _ds.Tables(0).Rows(0)(11).ToString()
                _usuarios.Telefono = _ds.Tables(0).Rows(0)(12).ToString()
                _usuarios.CorreoElectronico = _ds.Tables(0).Rows(0)(13).ToString()
                _usuarios.EstadoCivil = _ds.Tables(0).Rows(0)(14).ToString()
                _usuarios.Zona = _ds.Tables(0).Rows(0)(15).ToString()
                _usuarios.CodigoMunicipio = _ds.Tables(0).Rows(0)(16).ToString()
                _usuarios.CodigoTipoUsuario = _ds.Tables(0).Rows(0)(17).ToString()
                _usuarios.Carnet = _ds.Tables(0).Rows(0)(18).ToString()
                _usuarios.Foto = _ds.Tables(0).Rows(0)(19)

                ' Campos RDA-Paciente: lectura defensiva por nombre (no rompe si la migración
                ' Sql/rda_usuarios_campos_obligatorios.sql aún no se ha corrido en esta base).
                Dim tabla As DataTable = _ds.Tables(0)
                If tabla.Columns.Contains("codigo_pais_nacimiento") Then
                    _usuarios.CodigoPaisNacimiento = _ds.Tables(0).Rows(0)("codigo_pais_nacimiento").ToString()
                End If
                If tabla.Columns.Contains("codigo_etnia") Then
                    _usuarios.CodigoEtnia = _ds.Tables(0).Rows(0)("codigo_etnia").ToString()
                End If
                If tabla.Columns.Contains("codigo_discapacidad") Then
                    _usuarios.CodigoDiscapacidad = _ds.Tables(0).Rows(0)("codigo_discapacidad").ToString()
                End If
                If tabla.Columns.Contains("codigo_identidad_genero") Then
                    _usuarios.CodigoIdentidadGenero = _ds.Tables(0).Rows(0)("codigo_identidad_genero").ToString()
                End If

                Return _usuarios
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT ID, ID_TIPO_IDENTIFICACION AS TI, IDENTIFICACION AS IDENTIFICACION " _
                                        & ", CONCAT(PRIMER_NOMBRE,' ', SEGUNDO_NOMBRE,' ', PRIMER_APELLIDO,' ', SEGUNDO_APELLIDO)AS NOMBRE " _
                                        & ", SEXO, TELEFONO, CORREO_ELECTRONICO FROM usuarios WHERE ID <> '1'")
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
        Public Function ListarUltimosRegistros() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT ID, ID_TIPO_IDENTIFICACION AS TI, IDENTIFICACION, CONCAT_WS(' ', PRIMER_NOMBRE, NULLIF(SEGUNDO_NOMBRE, ''),PRIMER_APELLIDO, NULLIF(SEGUNDO_APELLIDO, '')) AS NOMBRE, " _
                                        & " SEXO, TELEFONO, CORREO_ELECTRONICO FROM usuarios WHERE ID != 1 ORDER BY ID DESC LIMIT 100;")
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
        Public Function DatosUsuarioCARD(ByVal IDUsuario As String) As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT	id AS ID, CONCAT(id_tipo_identificacion,identificacion) AS IDENTIFICACION, CONCAT(primer_nombre,' ',Segundo_nombre) AS NOMBRES " _
                                        & ",CONCAT(primer_apellido,' ', segundo_apellido) AS APELLIDOS,TIMESTAMPDIFF(YEAR,Fecha_nacimiento,CURDATE()) AS EDAD	,SEXO	,DIRECCION	,correo_electronico AS EMAIL ,TELEFONO ,FOTO " _
                                        & "FROM usuarios where id='" & IDUsuario & "'")
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
        Public Function ListarCombo() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT ID,CONCAT(ID_TIPO_IDENTIFICACION,IDENTIFICACION) AS IDENTIFICACION, " _
                                        & "CONCAT(PRIMER_NOMBRE,' ', SEGUNDO_NOMBRE,' ', PRIMER_APELLIDO,' ', SEGUNDO_APELLIDO)AS NOMBRE, " _
                                        & "SEXO	,TIMESTAMPDIFF(YEAR,Fecha_nacimiento,CURDATE()) AS EDAD, correo_electronico AS EMAIL FROM usuarios")
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
        Public Function Existe(ByVal TI As String, ByVal Numero As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT ID FROM usuarios WHERE id_tipo_identificacion='" & TI & "' AND identificacion='" & Numero & "' ")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                Dim reader As OdbcDataReader
                reader = comando.ExecuteReader()
                If reader.Read() Then
                    ConexionODBC.Close(_conn)
                    Return True
                Else
                    ConexionODBC.Close(_conn)
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return Nothing
        End Function
        Public Sub Guardar(ByVal _usuarios As Usuarios)
            Try
                Dim query As String
                Dim Imag As Byte()
                Imag = _usuarios.Foto

                If Existe(_usuarios.CodigotipoIdentificacion, _usuarios.Identificacion) = True Then
                    'Actualizamos el Usuario
                    query = "UPDATE usuarios SET primer_nombre='" & _usuarios.PrimerNombre & "', " _
                            & "segundo_nombre='" & _usuarios.SegundoNombre & "', " _
                            & "primer_apellido='" & _usuarios.PrimerApellido & "'," _
                            & "segundo_apellido='" & _usuarios.SegundoApellido & "', " _
                            & "sexo='" & _usuarios.Sexo & "', " _
                            & "fecha_nacimiento='" & Format(_usuarios.FechaNacimiento, "yyyy/MM/dd") & "'," _
                            & "CIUDAD_NACIMIENTO='" & _usuarios.CiudadNacimiento & "', " _
                            & "PAIS_NACIMIENTO='" & _usuarios.PaisNacimiento & "',	" _
                            & "DIRECCION='" & _usuarios.Direccion & "',	" _
                            & "TELEFONO='" & _usuarios.Telefono & "', " _
                            & "CORREO_ELECTRONICO='" & _usuarios.CorreoElectronico & "', " _
                            & "ESTADO_CIVIL='" & _usuarios.EstadoCivil & "', zona='U', codigo_municipio='" & _usuarios.CodigoMunicipio & "',codigo_tipo_usuario='1', carnet='0000' " _
                            & "WHERE id='" & _usuarios.ID & "'"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    'comando.Parameters.AddWithValue(1, Imag)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)

                    MsgBox("actualizar datos Usuario")
                    query = "UPDATE usuarios SET Foto=? WHERE id='" & _usuarios.ID & "'"
                    _conn = ConexionODBC.Open()
                    comando = New OdbcCommand(query, _conn)
                    comando.Parameters.AddWithValue(1, Imag)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)

                    ' Campos RDA-Paciente: UPDATE aparte y defensivo (columnas pueden no existir
                    ' aún en esta base, si la migración correspondiente no se ha corrido).
                    Try
                        query = "UPDATE usuarios SET codigo_pais_nacimiento = ?, codigo_etnia = ?, codigo_discapacidad = ?, codigo_identidad_genero = ? WHERE id = ?"
                        _conn = ConexionODBC.Open()
                        comando = New OdbcCommand(query, _conn)
                        comando.Parameters.AddWithValue("?", _usuarios.CodigoPaisNacimiento)
                        comando.Parameters.AddWithValue("?", _usuarios.CodigoEtnia)
                        comando.Parameters.AddWithValue("?", _usuarios.CodigoDiscapacidad)
                        comando.Parameters.AddWithValue("?", _usuarios.CodigoIdentidadGenero)
                        comando.Parameters.AddWithValue("?", _usuarios.ID)
                        comando.ExecuteNonQuery()
                        ConexionODBC.Close(_conn)
                    Catch
                        ' Columnas RDA aún no existen en esta base: se ignora, no bloquea el guardado.
                    End Try

                Else
                    ' Antes: INSERT posicional sin nombres de columna (VALUES(...)) - se rompería
                    ' en cuanto la tabla tuviera columnas nuevas. Se cambia a columnas explícitas
                    ' (las 20 originales, que siempre existen) + un UPDATE aparte y defensivo para
                    ' los campos RDA, por si la migración correspondiente aún no se ha corrido.
                    query = "INSERT INTO usuarios " &
                        "(id, id_tipo_identificacion, identificacion, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, " &
                        "sexo, fecha_nacimiento, ciudad_nacimiento, pais_nacimiento, direccion, telefono, correo_electronico, estado_civil, " &
                        "zona, codigo_municipio, codigo_tipo_usuario, carnet, foto) " &
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.Parameters.AddWithValue("?", _usuarios.ID)
                    comando.Parameters.AddWithValue("?", _usuarios.CodigotipoIdentificacion)
                    comando.Parameters.AddWithValue("?", _usuarios.Identificacion)
                    comando.Parameters.AddWithValue("?", _usuarios.PrimerNombre)
                    comando.Parameters.AddWithValue("?", _usuarios.SegundoNombre)
                    comando.Parameters.AddWithValue("?", _usuarios.PrimerApellido)
                    comando.Parameters.AddWithValue("?", _usuarios.SegundoApellido)
                    comando.Parameters.AddWithValue("?", _usuarios.Sexo)
                    comando.Parameters.AddWithValue("?", Format(_usuarios.FechaNacimiento, "yyyy/MM/dd"))
                    comando.Parameters.AddWithValue("?", _usuarios.CiudadNacimiento)
                    comando.Parameters.AddWithValue("?", _usuarios.PaisNacimiento)
                    comando.Parameters.AddWithValue("?", _usuarios.Direccion)
                    comando.Parameters.AddWithValue("?", _usuarios.Telefono)
                    comando.Parameters.AddWithValue("?", _usuarios.CorreoElectronico)
                    comando.Parameters.AddWithValue("?", _usuarios.EstadoCivil)
                    comando.Parameters.AddWithValue("?", "U")
                    comando.Parameters.AddWithValue("?", _usuarios.CodigoMunicipio)
                    comando.Parameters.AddWithValue("?", 1)
                    comando.Parameters.AddWithValue("?", "0000")
                    comando.Parameters.AddWithValue("?", Imag)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)

                    ' Campos RDA-Paciente: UPDATE aparte y defensivo (ver nota arriba).
                    Try
                        Dim queryRda As String = "UPDATE usuarios SET codigo_pais_nacimiento = ?, codigo_etnia = ?, codigo_discapacidad = ?, codigo_identidad_genero = ? WHERE id_tipo_identificacion = ? AND identificacion = ?"
                        _conn = ConexionODBC.Open()
                        Dim comandoRda As New OdbcCommand(queryRda, _conn)
                        comandoRda.Parameters.AddWithValue("?", _usuarios.CodigoPaisNacimiento)
                        comandoRda.Parameters.AddWithValue("?", _usuarios.CodigoEtnia)
                        comandoRda.Parameters.AddWithValue("?", _usuarios.CodigoDiscapacidad)
                        comandoRda.Parameters.AddWithValue("?", _usuarios.CodigoIdentidadGenero)
                        comandoRda.Parameters.AddWithValue("?", _usuarios.CodigotipoIdentificacion)
                        comandoRda.Parameters.AddWithValue("?", _usuarios.Identificacion)
                        comandoRda.ExecuteNonQuery()
                        ConexionODBC.Close(_conn)
                    Catch
                        ' Columnas RDA aún no existen en esta base: se ignora, no bloquea el registro.
                    End Try
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub GuardarFoto(ByVal _usuarios As Usuarios)
            Try
                Dim query As String
                Dim Imag As Byte()
                'Imag = _funciones.Imagen_Bytes(_usuarios.Foto)

                ' Convertido a columnas explícitas (ver nota en Guardar()) para no romperse
                ' cuando la tabla usuarios tenga columnas nuevas (RDA-Paciente).
                query = "INSERT INTO usuarios " &
                    "(id, id_tipo_identificacion, identificacion, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, " &
                    "sexo, fecha_nacimiento, ciudad_nacimiento, pais_nacimiento, direccion, telefono, correo_electronico, estado_civil, " &
                    "zona, codigo_municipio, codigo_tipo_usuario, carnet, foto) " &
                    "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue("?", _usuarios.ID)
                comando.Parameters.AddWithValue("?", _usuarios.CodigotipoIdentificacion)
                comando.Parameters.AddWithValue("?", _usuarios.Identificacion)
                comando.Parameters.AddWithValue("?", _usuarios.PrimerNombre)
                comando.Parameters.AddWithValue("?", _usuarios.SegundoNombre)
                comando.Parameters.AddWithValue("?", _usuarios.PrimerApellido)
                comando.Parameters.AddWithValue("?", _usuarios.SegundoApellido)
                comando.Parameters.AddWithValue("?", _usuarios.Sexo)
                comando.Parameters.AddWithValue("?", Format(_usuarios.FechaNacimiento, "yyyy/MM/dd"))
                comando.Parameters.AddWithValue("?", _usuarios.CiudadNacimiento)
                comando.Parameters.AddWithValue("?", _usuarios.PaisNacimiento)
                comando.Parameters.AddWithValue("?", _usuarios.Direccion)
                comando.Parameters.AddWithValue("?", _usuarios.Telefono)
                comando.Parameters.AddWithValue("?", _usuarios.CorreoElectronico)
                comando.Parameters.AddWithValue("?", _usuarios.EstadoCivil)
                comando.Parameters.AddWithValue("?", "U")
                comando.Parameters.AddWithValue("?", _usuarios.CodigoMunicipio)
                comando.Parameters.AddWithValue("?", 1)
                comando.Parameters.AddWithValue("?", "0000")
                comando.Parameters.AddWithValue("?", Imag)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

        Public Shared Function DatosUsuarios(ByVal ti As String, ByVal numero As String) As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT * FROM usuarios WHERE id_tipo_identificacion='" & ti & "' AND IDENTIFICACION='" & numero & "'")
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
        Public Function VerificarUsuario(ByVal ti As String, ByVal numero As String) As Boolean
            Try
                Dim query As String =
                                    String.Format(
                                        "SELECT * FROM usuarios WHERE id_tipo_identificacion='" & ti & "' AND IDENTIFICACION='" & numero & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                If _ds.Tables(0).Rows(0)(0).ToString = 0 Then
                    Return False
                Else
                    Return True
                End If

            Catch ex As Exception
                Return Nothing
            End Try
        End Function
        Public Shared Function DatosUsuarios2(ByVal IdUsuario As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT * FROM usuarios WHERE id='" & IdUsuario & "'")
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
        Public Function CumpleanosMes() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT CONCAT(`ID_TIPO_IDENTIFICACION`,IDENTIFICACION) AS IDENTIFICACION, " _
                                                & "CONCAT(`PRIMER_NOMBRE`,' ',SEGUNDO_NOMBRE,' ',PRIMER_APELLIDO,' ',SEGUNDO_APELLIDO) AS NOMBRE, " _
                                                & "`SEXO`, " _
                                                & "`FECHA_NACIMIENTO`, " _
                                                & "`ESTADO_CIVIL`, " _
                                                & "`DIRECCION`, " _
                                                & "`TELEFONO`, " _
                                                & "`CORREO_ELECTRONICO` AS `MAIL` " _
                                                & "FROM `usuarios` WHERE MONTH(`FECHA_NACIMIENTO`)=MONTH(CURRENT_DATE())")
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
        Public Shared Function UltimoRegistro() As SIM___GLOBAL.Modelo.Usuarios
            Try
                Dim query As String = String.Format("SELECT id FROM usuarios ORDER BY id DESC LIMIT 1")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Usuarios = New SIM___GLOBAL.Modelo.Usuarios
                _Usuarios.ID = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Usuarios
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace


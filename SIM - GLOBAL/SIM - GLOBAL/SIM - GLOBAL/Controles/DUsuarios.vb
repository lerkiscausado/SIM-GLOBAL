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
                                        "SELECT ID, ID_TIPO_IDENTIFICACION AS TI, IDENTIFICACION AS IDENTIFICACION " _
                                        & ", CONCAT(PRIMER_NOMBRE,' ', SEGUNDO_NOMBRE,' ', PRIMER_APELLIDO,' ', SEGUNDO_APELLIDO)AS NOMBRE " _
                                        & ", SEXO, TELEFONO, CORREO_ELECTRONICO FROM usuarios WHERE ID <> '1' ORDER BY id DESC LIMIT 0, 500")
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

                Else
                    query = "INSERT INTO usuarios VALUES('" & _usuarios.ID & "','" & _usuarios.CodigotipoIdentificacion & "','" & _usuarios.Identificacion & "','" & _usuarios.PrimerNombre & "','" & _usuarios.SegundoNombre & "','" & _usuarios.PrimerApellido & "','" & _usuarios.SegundoApellido & "'," _
                        & "'" & _usuarios.Sexo & "','" & Format(_usuarios.FechaNacimiento, "yyyy/MM/dd") & "','" & _usuarios.CiudadNacimiento & "','" & _usuarios.PaisNacimiento & "','" & _usuarios.Direccion & "','" & _usuarios.Telefono & "','" & _usuarios.CorreoElectronico & "','" & _usuarios.EstadoCivil & "','U'," _
                        & "'" & _usuarios.CodigoMunicipio & "','1','0000',?);"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.Parameters.AddWithValue(1, Imag)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)
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

                query = "INSERT INTO usuarios VALUES('" & _usuarios.ID & "','" & _usuarios.CodigotipoIdentificacion & "','" & _usuarios.Identificacion & "','" & _usuarios.PrimerNombre & "','" & _usuarios.SegundoNombre & "','" & _usuarios.PrimerApellido & "','" & _usuarios.SegundoApellido & "'," _
                        & "'" & _usuarios.Sexo & "','" & Format(_usuarios.FechaNacimiento, "yyyy/MM/dd") & "','" & _usuarios.CiudadNacimiento & "','" & _usuarios.PaisNacimiento & "','" & _usuarios.Direccion & "','" & _usuarios.Telefono & "','" & _usuarios.CorreoElectronico & "','" & _usuarios.EstadoCivil & "','U'," _
                        & "'" & _usuarios.CodigoMunicipio & "','1','0000',?);"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, Imag)
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


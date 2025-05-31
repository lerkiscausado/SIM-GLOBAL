Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DUsuarios
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As SIM___INTEGRA.Modelo.Usuarios
            Try
                Dim query As String = String.Format("SELECT * FROM usuarios WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _usuarios = New SIM___INTEGRA.Modelo.Usuarios
                _usuarios.ID = _ds.Tables(0).Rows(0)(0).ToString()
                _usuarios.IdTipoIdentificacion = _ds.Tables(0).Rows(0)(1).ToString()
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
                _usuarios.Ocupacion = _ds.Tables(0).Rows(0)(15).ToString()
                _usuarios.Responsable = _ds.Tables(0).Rows(0)(16).ToString()
                _usuarios.ParentescoR = _ds.Tables(0).Rows(0)(17).ToString()
                _usuarios.TelefonoR = _ds.Tables(0).Rows(0)(18).ToString()
                _usuarios.Acompanante = _ds.Tables(0).Rows(0)(19).ToString()
                _usuarios.ParentescoA = _ds.Tables(0).Rows(0)(20).ToString()
                _usuarios.TelefonoA = _ds.Tables(0).Rows(0)(21).ToString()
                _usuarios.AntecedentesFamiliares = _ds.Tables(0).Rows(0)(22).ToString()
                _usuarios.AntecedentesPersonales = _ds.Tables(0).Rows(0)(23).ToString()
                _usuarios.Zona = _ds.Tables(0).Rows(0)(24).ToString()
                _usuarios.CodigoMunicipio = _ds.Tables(0).Rows(0)(25).ToString()
                _usuarios.CodigoTipoUsuario = _ds.Tables(0).Rows(0)(26).ToString()
                _usuarios.Carnet = _ds.Tables(0).Rows(0)(27).ToString()
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
                                        & ", SEXO, TELEFONO FROM usuarios")
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
        Public Sub Guardar(ByVal _usuarios As SIM___INTEGRA.Modelo.Usuarios)
            Try
                Dim query As String
                If Existe(_usuarios.IdTipoIdentificacion, _usuarios.Identificacion) = True Then

                    query = "UPDATE Usuarios SET primer_nombre='" & _usuarios.PrimerNombre & "', " _
                            & "segundo_nombre='" & _usuarios.SegundoNombre & "',	" _
                            & "primer_apellido='" & _usuarios.PrimerApellido & "'," _
                            & "segundo_apellido='" & _usuarios.SegundoApellido & "'," _
                            & "sexo='" & _usuarios.Sexo & "'," _
                            & "fecha_nacimiento='" & Format(_usuarios.FechaNacimiento, "yyyy/MM/dd") & "'," _
                            & "CIUDAD_NACIMIENTO='" & _usuarios.CiudadNacimiento & "',	" _
                            & "PAIS_NACIMIENTO='" & _usuarios.PaisNacimiento & "',	" _
                            & "DIRECCION='" & _usuarios.Direccion & "',	" _
                            & "TELEFONO='" & _usuarios.Telefono & "',	" _
                            & "CORREO_ELECTRONICO='" & _usuarios.CorreoElectronico & "', " _
                            & "ESTADO_CIVIL='" & _usuarios.EstadoCivil & "', " _
                            & "ocupacion='" & _usuarios.Ocupacion & "', " _
                            & "responsable='" & _usuarios.Responsable & "', " _
                            & "parentesco_r='" & _usuarios.ParentescoR & "', " _
                            & "telefono_r='" & _usuarios.TelefonoR & "', " _
                            & "acompanante='" & _usuarios.Acompanante & "', " _
                            & "parentesco_a='" & _usuarios.ParentescoA & "', " _
                            & "telefono_a='" & _usuarios.TelefonoA & "', " _
                            & "antecedentes_familiares='" & _usuarios.AntecedentesFamiliares & "', " _
                            & "antecedentes_personales='" & _usuarios.AntecedentesPersonales & "' WHERE id='" & _usuarios.ID & "'"
                Else

                    query = "INSERT INTO usuarios VALUES('','" & _usuarios.IdTipoIdentificacion & "','" & _usuarios.Identificacion & "','" & _usuarios.PrimerNombre & "','" & _usuarios.SegundoNombre & "','" & _usuarios.PrimerApellido & "','" & _usuarios.SegundoApellido & "'," _
                        & "'" & _usuarios.Sexo & "','" & Format(_usuarios.FechaNacimiento, "yyyy/MM/dd") & "','" & _usuarios.CiudadNacimiento & "','" & _usuarios.PaisNacimiento & "','" & _usuarios.Direccion & "', " _
                        & "'" & _usuarios.Telefono & "','" & _usuarios.CorreoElectronico & "','" & _usuarios.EstadoCivil & "','" & _usuarios.Ocupacion & "','" & _usuarios.Responsable & "', " _
                        & "'" & _usuarios.ParentescoR & "','" & _usuarios.TelefonoR & "','" & _usuarios.Acompanante & "','" & _usuarios.ParentescoA & "','" & _usuarios.TelefonoA & "', " _
                        & "'" & _usuarios.AntecedentesFamiliares & "','" & _usuarios.AntecedentesPersonales & "','U'," _
                        & "'13001','1','0000')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
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
        Public Sub GuardarAntecedentes(ByVal _usuarios As SIM___INTEGRA.Modelo.Usuarios)
            Try
                Dim query As String
                query = "UPDATE Usuarios SET antecedentes_familiares='" & _usuarios.AntecedentesFamiliares & "', " _
                            & "antecedentes_personales='" & _usuarios.AntecedentesPersonales & "' " _
                            & "WHERE id='" & _usuarios.ID & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Shared Function Antecedentes(ByVal filtro As String) As SIM___INTEGRA.Modelo.Usuarios
            Try
                Dim query As String = String.Format("SELECT antecedentes_familiares FROM usuarios WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _usuarios = New SIM___INTEGRA.Modelo.Usuarios
                _usuarios.AntecedentesFamiliares = _ds.Tables(0).Rows(0)(0).ToString()
                Return _usuarios
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Shared Function CargarAntecedentes(ByVal filtro As String) As SIM___INTEGRA.Modelo.Usuarios
            Try
                Dim query As String = String.Format("SELECT antecedentes_familiares, antecedentes_personales FROM usuarios WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _usuarios = New SIM___INTEGRA.Modelo.Usuarios
                _usuarios.AntecedentesFamiliares = _ds.Tables(0).Rows(0)(0).ToString()
                _usuarios.AntecedentesPersonales = _ds.Tables(0).Rows(0)(1).ToString()
                Return _usuarios
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace


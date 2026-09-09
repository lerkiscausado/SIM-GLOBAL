Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Namespace Controles
    Public Class DEmpresa
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As Funciones
        Public Shared Function Cargar(ByVal filtro As String) As Empresa
            Try
                ' Antes: "SELECT *" + lectura por índice posicional (con varios índices mal
                ' copiados: IdTipoIdentificacion/Identificacion/Ciudad/Celular/Fax/Estado todos
                ' leían la columna 0). Se reemplaza por columnas explícitas por NOMBRE, que es
                ' seguro sin importar el orden físico real de columnas en la tabla.
                Dim query As String = "SELECT id, id_licencia, id_tipo_identificacion, identificacion, nombre, " &
                    "direccion, ciudad, telefono, celular, fax, email, pagina_web, logo, estado " &
                    "FROM empresa WHERE id_licencia = ?"
                _conn = ConexionODBC.Open()
                Dim comando As New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue("?", filtro)
                Dim reader As OdbcDataReader = comando.ExecuteReader()

                Dim _empresa As New Empresa
                If reader.Read() Then
                    _empresa.Id = reader("id").ToString()
                    _empresa.IdLicencia = reader("id_licencia").ToString()
                    _empresa.IdTipoIdentificacion = reader("id_tipo_identificacion").ToString()
                    _empresa.Identificacion = reader("identificacion").ToString()
                    _empresa.Nombre = reader("nombre").ToString()
                    _empresa.Direccion = reader("direccion").ToString()
                    _empresa.Ciudad = reader("ciudad").ToString()
                    _empresa.Telefono = reader("telefono").ToString()
                    _empresa.Celular = reader("celular").ToString()
                    _empresa.Fax = reader("fax").ToString()
                    _empresa.Email = reader("email").ToString()
                    _empresa.PaginaWeb = reader("pagina_web").ToString()
                    If Not IsDBNull(reader("logo")) Then _empresa.Logo = CType(reader("logo"), Byte())
                    _empresa.Estado = reader("estado").ToString()
                End If
                reader.Close()

                ' Código REPS: lectura defensiva por si la columna aún no existe en esta base de
                ' datos (ver Sql/rda_empresa_codigo_prestador.sql). No rompe Cargar() si falta.
                Try
                    Dim queryReps As String = "SELECT codigo_prestador FROM empresa WHERE id_licencia = ?"
                    Dim comandoReps As New OdbcCommand(queryReps, _conn)
                    comandoReps.Parameters.AddWithValue("?", filtro)
                    Dim readerReps As OdbcDataReader = comandoReps.ExecuteReader()
                    If readerReps.Read() AndAlso Not IsDBNull(readerReps("codigo_prestador")) Then
                        _empresa.CodigoPrestador = readerReps("codigo_prestador").ToString()
                    End If
                    readerReps.Close()
                Catch
                    ' Columna codigo_prestador no existe todavía en esta instalación: se ignora.
                End Try

                ConexionODBC.Close(_conn)
                Return _empresa
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT ID FROM empresa WHERE id_licencia='" & filtro & "'")
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
        Public Sub Guardar(ByVal _empresa As Empresa)
            Try
                Dim query As String
                Dim Imag As Byte()
                Imag = _empresa.Logo

                If Existe(_empresa.Id) = True Then
                    'Actualizamos la Empresa
                    query = "UPDATE empresa SET id_tipo_identificacion='" & _empresa.IdTipoIdentificacion & "', " _
                            & "identificacion='" & _empresa.Identificacion & "', " _
                            & "nombre='" & _empresa.Nombre & "',	" _
                            & "DIRECCION='" & _empresa.Direccion & "',	" _
                            & "ciudad='" & _empresa.Ciudad & "',	" _
                            & "TELEFONO='" & _empresa.Telefono & "', " _
                            & "celular='" & _empresa.Celular & "',	" _
                            & "fax='" & _empresa.Fax & "',	" _
                            & "email='" & _empresa.Email & "', " _
                            & "pagina_web='" & _empresa.PaginaWeb & "' " _
                            & "WHERE id_licencia='" & _empresa.IdLicencia & "'"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    'comando.Parameters.AddWithValue(1, Imag)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)


                    query = "UPDATE empresa SET logo=? WHERE id='" & _empresa.Id & "'"
                    _conn = ConexionODBC.Open()
                    comando = New OdbcCommand(query, _conn)
                    comando.Parameters.AddWithValue(1, Imag)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)

                    ' Código REPS: UPDATE aparte y defensivo (columna puede no existir aún).
                    Try
                        query = "UPDATE empresa SET codigo_prestador = ? WHERE id_licencia = ?"
                        _conn = ConexionODBC.Open()
                        comando = New OdbcCommand(query, _conn)
                        comando.Parameters.AddWithValue("?", _empresa.CodigoPrestador)
                        comando.Parameters.AddWithValue("?", _empresa.IdLicencia)
                        comando.ExecuteNonQuery()
                        ConexionODBC.Close(_conn)
                    Catch
                        ' Columna codigo_prestador no existe todavía en esta instalación: se ignora.
                    End Try

                Else
                    ' Antes: INSERT posicional sin nombres de columna (VALUES(...) en el mismo
                    ' orden que la declaración de la tabla) - fragil ante cualquier cambio de
                    ' esquema y no incluía codigo_prestador. Se cambia a columnas explícitas.
                    query = "INSERT INTO empresa (id, id_licencia, id_tipo_identificacion, identificacion, nombre, " &
                            "direccion, ciudad, telefono, celular, fax, email, pagina_web, logo, estado) " &
                            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.Parameters.AddWithValue("?", _empresa.Id)
                    comando.Parameters.AddWithValue("?", _empresa.IdLicencia)
                    comando.Parameters.AddWithValue("?", _empresa.IdTipoIdentificacion)
                    comando.Parameters.AddWithValue("?", _empresa.Identificacion)
                    comando.Parameters.AddWithValue("?", _empresa.Nombre)
                    comando.Parameters.AddWithValue("?", _empresa.Direccion)
                    comando.Parameters.AddWithValue("?", _empresa.Ciudad)
                    comando.Parameters.AddWithValue("?", _empresa.Telefono)
                    comando.Parameters.AddWithValue("?", _empresa.Celular)
                    comando.Parameters.AddWithValue("?", _empresa.Fax)
                    comando.Parameters.AddWithValue("?", _empresa.Email)
                    comando.Parameters.AddWithValue("?", _empresa.PaginaWeb)
                    comando.Parameters.AddWithValue("?", Imag)
                    comando.Parameters.AddWithValue("?", _empresa.Estado)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)

                    Try
                        query = "UPDATE empresa SET codigo_prestador = ? WHERE id_licencia = ?"
                        _conn = ConexionODBC.Open()
                        comando = New OdbcCommand(query, _conn)
                        comando.Parameters.AddWithValue("?", _empresa.CodigoPrestador)
                        comando.Parameters.AddWithValue("?", _empresa.IdLicencia)
                        comando.ExecuteNonQuery()
                        ConexionODBC.Close(_conn)
                    Catch
                        ' Columna codigo_prestador no existe todavía en esta instalación: se ignora.
                    End Try
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
    End Class
End Namespace

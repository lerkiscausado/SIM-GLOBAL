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
                Dim query As String = String.Format("SELECT * FROM empresa WHERE id_licencia='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _empresa = New Empresa
                _empresa.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _empresa.IdLicencia = _ds.Tables(0).Rows(0)(0).ToString()
                _empresa.IdTipoIdentificacion = _ds.Tables(0).Rows(0)(0).ToString()
                _empresa.Identificacion = _ds.Tables(0).Rows(0)(0).ToString()
                _empresa.Nombre = _ds.Tables(0).Rows(0)(3).ToString()
                _empresa.Direccion = _ds.Tables(0).Rows(0)(11).ToString()
                _empresa.Ciudad = _ds.Tables(0).Rows(0)(0).ToString()
                _empresa.Telefono = _ds.Tables(0).Rows(0)(12).ToString()
                _empresa.Celular = _ds.Tables(0).Rows(0)(0).ToString()
                _empresa.Fax = _ds.Tables(0).Rows(0)(0).ToString()
                _empresa.Email = _ds.Tables(0).Rows(0)(13).ToString()
                _empresa.PaginaWeb = _ds.Tables(0).Rows(0)(13).ToString()
                _empresa.Logo = _ds.Tables(0).Rows(0)(19)
                _empresa.Estado = _ds.Tables(0).Rows(0)(13).ToString()
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

                Else
                    query = "INSERT INTO empresa VALUES('" & _empresa.Id & "','" & _empresa.IdLicencia & "','" & _empresa.IdTipoIdentificacion & "','" & _empresa.Identificacion & "','" & _empresa.Nombre & "','" & _empresa.Direccion & "','" & _empresa.Ciudad & "','" & _empresa.Telefono & "', " _
                        & "'" & _empresa.Celular & "','" & _empresa.Fax & "','" & _empresa.Email & "','" & _empresa.PaginaWeb & "',?,'" & _empresa.Estado & "');"
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
    End Class
End Namespace

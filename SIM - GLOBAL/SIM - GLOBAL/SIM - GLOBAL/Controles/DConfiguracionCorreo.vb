Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DConfiguracionCorreo
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As ConfiguracionCorreo

            Try
                Dim query As String = String.Format("SELECT * FROM configuracion_correo WHERE id_licencia='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Correo = New ConfiguracionCorreo
                _Correo.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Correo.IdLicencia = _ds.Tables(0).Rows(0)(1).ToString()
                _Correo.Servidor = _ds.Tables(0).Rows(0)(2).ToString()
                _Correo.Puerto = _ds.Tables(0).Rows(0)(3).ToString()
                _Correo.Correo = _ds.Tables(0).Rows(0)(4).ToString()
                _Correo.Pass = _ds.Tables(0).Rows(0)(5).ToString()
                Return _Correo
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub Guardar(ByVal _correo As ConfiguracionCorreo)
            Try
                Dim query As String
                If Existe(_correo.IdLicencia) = True Then
                    query = "UPDATE configuracion_correo SET servidor='" & _correo.Servidor & "', puerto='" & _correo.Puerto & "' " _
                    & ", correo='" & _correo.Correo & "', pass='" & _correo.Pass & "' where id_licencia='" & _correo.IdLicencia & "'"
                Else
                    query = "insert into configuracion_correo values('','" & _correo.IdLicencia & "','" & _correo.Servidor & "','" & _correo.Puerto & "'" _
                    & ", '" & _correo.Correo & "', '" & _correo.Pass & "' )"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM configuracion_correo WHERE id_licencia='" & filtro & "'")
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
    End Class
End Namespace

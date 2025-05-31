Imports System.Data.Common
Imports System.Reflection
Imports System.Data.Odbc
Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.My.Modelo


Namespace Utilidades

    Public Class Funciones
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
            For Each f As Form In Application.OpenForms
                If f.Name = formName Then
                    f.GetType().GetMethod(metodo).Invoke(f, New Object() {})
                End If
            Next
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
        Public Shared Function DatosUsuario(ByVal filtro As String, ByVal tabla As String) As String
            Select Case tabla
                Case "ORDENES"
                    Try
                        Dim query As String = String.Format("SELECT id, CONCAT(id_tipo_identificacion,identificacion) AS IDENTIFICACION " _
                                                            & ",CONCAT(primer_nombre,' ',segundo_nombre,' ',primer_apellido,' ',segundo_apellido) " _
                                                            & "AS NOMBRE ,sexo	,TIMESTAMPDIFF(YEAR,Fecha_Nacimiento,CURDATE()) AS EDAD	,telefono ,direccion " _
                                                            & ",CORREO_ELECTRONICO FROM usuarios where id='" & filtro & "'")
                        Dim _conn As New OdbcConnection
                        _conn = ConexionODBC.Open()
                        Dim comando = New OdbcCommand(query, _conn)
                        Dim _adapter = New OdbcDataAdapter(comando)
                        Dim _ds = New DataSet()
                        _adapter.Fill(_ds)
                        ConexionODBC.Close(_conn)
                        Dim datos As String
                        datos = "ID: " & _ds.Tables(0).Rows(0)(0).ToString & "     IDENTIFICACION: " & _ds.Tables(0).Rows(0)(1).ToString & vbCrLf _
                            & "PACIENTE: " & _ds.Tables(0).Rows(0)(2).ToString & vbCrLf _
                            & "SEXO: " & _ds.Tables(0).Rows(0)(3).ToString & " EDAD:" & _ds.Tables(0).Rows(0)(4).ToString & "  TELEFONO: " & _ds.Tables(0).Rows(0)(5).ToString & vbCrLf _
                            & "DIRECCION: " & _ds.Tables(0).Rows(0)(6).ToString & vbCrLf _
                            & "CORREO ELECTRONICO: " & _ds.Tables(0).Rows(0)(7).ToString
                        Return datos
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Return Nothing
                    End Try
                Case "HISTORIA"
                    Try
                        Dim query As String = String.Format("SELECT usuarios.id ,CONCAT(usuarios.id_tipo_identificacion,usuarios.identificacion) AS IDENTIFICACION " _
                                                            & ",CONCAT(usuarios.primer_nombre,' ',usuarios.segundo_nombre,' ',usuarios.primer_apellido,' ',usuarios.segundo_apellido) AS NOMBRE " _
                                                            & ",usuarios.sexo,TIMESTAMPDIFF(YEAR,usuarios.Fecha_Nacimiento,CURDATE()) AS EDAD ,usuarios.telefono ,usuarios.direccion " _
                                                            & ",usuarios.CORREO_ELECTRONICO FROM usuarios INNER JOIN `ordenes` ON (`usuarios`.`ID` = `ordenes`.`ID_USUARIO`) WHERE ordenes.id='" & filtro & "'")
                        Dim _conn As New OdbcConnection
                        _conn = ConexionODBC.Open()
                        Dim comando = New OdbcCommand(query, _conn)
                        Dim _adapter = New OdbcDataAdapter(comando)
                        Dim _ds = New DataSet()
                        _adapter.Fill(_ds)
                        ConexionODBC.Close(_conn)
                        Dim datos As String
                        datos = "ID: " & _ds.Tables(0).Rows(0)(0).ToString & "     IDENTIFICACION: " & _ds.Tables(0).Rows(0)(1).ToString & vbCrLf _
                            & "PACIENTE: " & _ds.Tables(0).Rows(0)(2).ToString & vbCrLf _
                            & "SEXO: " & _ds.Tables(0).Rows(0)(3).ToString & " EDAD:" & _ds.Tables(0).Rows(0)(4).ToString & "  TELEFONO: " & _ds.Tables(0).Rows(0)(5).ToString & vbCrLf _
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
    End Class
End Namespace


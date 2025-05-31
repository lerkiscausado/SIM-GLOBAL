Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DIncapacidades
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IdOrden As String) As Incapacidades
            Try
                Dim query As String = String.Format("SELECT * FROM incapacidades WHERE id_orden='" & IdOrden & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Incapacidades = New Incapacidades
                _Incapacidades.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Incapacidades.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _Incapacidades.IdDetalleOrden = _ds.Tables(0).Rows(0)(2).ToString()
                _Incapacidades.TipoIncapacidad = _ds.Tables(0).Rows(0)(3).ToString()
                _Incapacidades.FechaInicial = _ds.Tables(0).Rows(0)(4).ToString()
                _Incapacidades.FechaFinal = _ds.Tables(0).Rows(0)(5).ToString()
                _Incapacidades.Nota = _ds.Tables(0).Rows(0)(6).ToString()
                _Incapacidades.Diagnostico = _ds.Tables(0).Rows(0)(7).ToString()
                Return _Incapacidades
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT `incapacidades`.`ID`, " _
                                        & "`incapacidades`.`ID_ORDEN` AS `ORDEN`, " _
                                        & "`incapacidades`.`ID_DETALLE_ORDEN`, " _
                                        & "CONCAT(`usuarios`.`ID_TIPO_IDENTIFICACION`,usuarios.`IDENTIFICACION`) AS IDENTIFICACION, " _
                                        & "CONCAT(`usuarios`.`PRIMER_NOMBRE`,' ',usuarios.`SEGUNDO_NOMBRE`,' ',usuarios.`PRIMER_APELLIDO`,' ',usuarios.`SEGUNDO_APELLIDO`) AS NOMBRE, " _
                                        & "`incapacidades`.`TIPO_INCAPACIDAD`, " _
                                        & "`incapacidades`.`FECHA_INICIAL`, " _
                                        & "`incapacidades`.`FECHA_FINAL`, " _
                                        & "DATEDIFF(`incapacidades`.`FECHA_FINAL`, `incapacidades`.`FECHA_INICIAL`)+1 AS DIAS " _
                                        & "FROM `ordenes` INNER JOIN `usuarios` ON (`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) " _
                                        & "INNER JOIN `incapacidades` ON (`ordenes`.`ID` = `incapacidades`.`ID_ORDEN`) " _
                                        & "ORDER BY `incapacidades`.`ID` ASC")
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

        Public Function Existe(ByVal IdOrden As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT ID FROM incapacidades WHERE id_orden='" & IdOrden & "'")
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
        Public Sub Guardar(ByVal _Incapacidades As Incapacidades)
            Try
                Dim query As String

                If Existe(_Incapacidades.IdOrden) = True Then
                    'Actualizamos la Incapacidad
                    query = "UPDATE incapacidades SET tipo_incapacidad='" & _Incapacidades.TipoIncapacidad & "', " _
                            & "fecha_inicial='" & Format(_Incapacidades.FechaInicial, "yyyy/MM/dd") & "', " _
                            & "fecha_final='" & Format(_Incapacidades.FechaFinal, "yyyy/MM/dd") & "', " _
                            & "nota='" & _Incapacidades.Nota & "', " _
                            & "diagnostico='" & _Incapacidades.Diagnostico & "' " _
                            & "WHERE id_orden='" & _Incapacidades.IdOrden & "'"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)

                Else
                    query = "INSERT INTO incapacidades VALUES('" & _Incapacidades.Id & "', " _
                        & "'" & _Incapacidades.IdOrden & "', " _
                        & "'" & _Incapacidades.IdDetalleOrden & "', " _
                        & "'" & _Incapacidades.TipoIncapacidad & "', " _
                        & "'" & Format(_Incapacidades.FechaInicial, "yyyy/MM/dd") & "', " _
                        & "'" & Format(_Incapacidades.FechaFinal, "yyyy/MM/dd") & "', " _
                        & "'" & _Incapacidades.Nota & "', " _
                        & "'" & _Incapacidades.Diagnostico & "')"
                    _conn = ConexionODBC.Open()
                    Dim comando = New OdbcCommand(query, _conn)
                    comando.ExecuteNonQuery()
                    ConexionODBC.Close(_conn)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

    End Class

End Namespace

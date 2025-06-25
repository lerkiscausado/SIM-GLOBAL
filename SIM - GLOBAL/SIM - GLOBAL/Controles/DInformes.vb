Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DInformes
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Existe(ByVal Id As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT id FROM informes WHERE id='" & Id & "'")
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
        Public Sub Guardar(ByVal _informes As SIM___GLOBAL.Modelo.Informes)
            Try
                Dim query As String
                If Existe(_informes.Id) = True Then
                    query = "UPDATE informes SET nombre='" &
                        _informes.Nombre & "',query ='" & _informes.Query & "', estado='" & _informes.Estado & "' where id='" & _informes.Id & "'"
                Else
                    query = "insert into informes values('" & _informes.Id & "','" & _informes.Nombre & "','" & _informes.Query & "','" & _informes.Estado & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function Listar() As DataSet
            Try
                Dim query As String =
                                    String.Format(
                                        "Select ID, nombre as INFORME, QUERY, estado from informes")
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
        Public Function Resultado(ByVal Consulta As String) As DataSet
            Try
                Dim query As String =
                                    String.Format(Consulta)
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
        Public Function RelacionFactura() As DataSet
            Try
                Dim query As String =
                    String.Format("SELECT ordenes.CONSECUTIVO AS CASO, ordenes.FECHA_INGRESO AS FECHA_INGRESO, " _
                    & "CONCAT(usuarios.ID_TIPO_IDENTIFICACION, usuarios.IDENTIFICACION) AS IDENTIFICACION, " _
                    & "CONCAT(usuarios.PRIMER_NOMBRE, ' ', usuarios.SEGUNDO_NOMBRE, ' ', usuarios.PRIMER_APELLIDO, ' ', usuarios.SEGUNDO_APELLIDO) AS NOMBRE, " _
                    & "usuarios.SEXO AS SEXO, TIMESTAMPDIFF(YEAR, usuarios.FECHA_NACIMIENTO, CURDATE()) AS EDAD, " _
                    & "sedes.nombre AS ENTIDAD, subentidades.nombre AS SUBENTIDAD, tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, ordenes.AUTORIZACION, " _
                    & "especimenes.nombre AS ESPECIMEN, GROUP_CONCAT(detalle_orden.codigo_cups) AS CUPS, " _
                    & "SUM(detalle_orden.valor) AS VALOR, ordenes.ESTADO, ordenes.ID AS ORDEN FROM detalle_orden " _
                    & "INNER JOIN ordenes ON detalle_orden.id_orden = ordenes.id " _
                    & "INNER JOIN tipo_estudio ON ordenes.ID_TIPO_ESTUDIO = tipo_estudio.ID " _
                    & "INNER JOIN usuarios ON ordenes.ID_USUARIO = usuarios.ID " _
                    & "INNER JOIN contratos ON ordenes.ID_CONTRATO = contratos.ID " _
                    & "INNER JOIN entidades ON contratos.CODIGO_ENTIDAD = entidades.CODIGO_ENTIDAD " _
                    & "INNER JOIN especimenes ON especimenes.id = ordenes.id_especimen " _
                    & "INNER JOIN sedes ON sedes.id = ordenes.id_sede " _
                    & "INNER JOIN subentidades ON subentidades.id = ordenes.id_subentidad " _
                    & "WHERE ordenes.estado <> 'CANCELADO' AND ordenes.FECHA_INGRESO >= CURDATE() - INTERVAL 6 MONTH GROUP BY ordenes.id")
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
        Public Sub ActualizarAutorizacion(ByVal idOrden As String, ByVal autorizacion As String)
            Try
                Dim query As String
                query = "UPDATE ordenes SET autorizacion='" & autorizacion & "' " _
                        & "where id='" & idOrden & "'"
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
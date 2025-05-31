Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports SIM___GLOBAL.Utilidades
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DImagenes
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly Funciones As Funciones

        Public Shared Function Cargar(ByVal filtro As String) As SIM___GLOBAL.Modelo.Imagenes 'Imagenes
            Try
                Dim query As String = String.Format("SELECT * FROM imagenes WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Imagenes = New SIM___GLOBAL.Modelo.Imagenes
                _Imagenes.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Imagenes.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _Imagenes.IdDetalleOrden = _ds.Tables(0).Rows(0)(2).ToString()
                _Imagenes.Ruta = _ds.Tables(0).Rows(0)(3).ToString()
                _Imagenes.Texto = _ds.Tables(0).Rows(0)(4).ToString()
                _Imagenes.Estado = _ds.Tables(0).Rows(0)(5).ToString()
                Return _Imagenes
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT ID FROM imagenes WHERE id='" & filtro & "'")
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
        Public Sub Guardar(ByVal _Imagenes As Imagenes)
            Try
                Dim query As String
                If Existe(_Imagenes.Id) = True Then
                    'Actualizar Imagenes
                    query = "UPDATE imagenes SET ruta='" & _Imagenes.Ruta & "', texto='" & _Imagenes.Texto & "', " _
                        & "estado='" & _Imagenes.Estado & "' WHERE id='" & _Imagenes.Id & "'"
                Else
                    'Guardar Imagenes
                    query = "INSERT INTO imagenes VALUES('" & _Imagenes.Id & "','" & _Imagenes.IdOrden & "', " _
                        & "'" & _Imagenes.IdDetalleOrden & "','" & _Imagenes.Id & _Imagenes.Ruta & "', '" & _Imagenes.Texto & "', " _
                        & "'" & _Imagenes.Estado & "','')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarImagenes(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
              String.Format("SELECT ruta AS RUTA,ID FROM imagenes WHERE id_detalle_orden= '" & filtro & "'")
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
        Public Function ListarImagenesCapturadas(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
              String.Format("SELECT id, ruta, texto FROM imagenes WHERE id_detalle_orden= '" & filtro & "'")
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
        Public Function ExisteImagenes(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT ID FROM imagenes WHERE id_detalle_orden='" & filtro & "' and estado='A'")
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
        Public Function ListarImagenesActivas(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
              String.Format("SELECT ruta AS RUTA, TEXTO FROM imagenes WHERE id_detalle_orden='" & filtro & "' and estado='A'")
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
        Public Sub EliminarTemporales(ByVal IdDetalleOrden As String, ByVal caso As Integer)
            Try
                Dim query As String
                query = ""
                Select Case caso
                    Case 1
                        query = "UPDATE impresion_endoscopia SET imagen2='', imagen3='', imagen4='', imagen5='', imagen6='', imagen7='', imagen8='' WHERE id_detalle_orden='" & IdDetalleOrden & "'"
                    Case 2
                        query = "UPDATE impresion_endoscopia SET imagen3='', imagen4='', imagen5='', imagen6='', imagen7='', imagen8='' WHERE id_detalle_orden='" & IdDetalleOrden & "'"
                    Case 3
                        query = "UPDATE impresion_endoscopia SET imagen4='', imagen5='', imagen6='', imagen7='', imagen8='' WHERE id_detalle_orden='" & IdDetalleOrden & "'"
                    Case 4
                        query = "UPDATE impresion_endoscopia SET imagen5='', imagen6='', imagen7='', imagen8='' WHERE id_detalle_orden='" & IdDetalleOrden & "'"
                    Case 5
                        query = "UPDATE impresion_endoscopia SET imagen6='', imagen7='', imagen8='' WHERE id_detalle_orden='" & IdDetalleOrden & "'"
                    Case 6
                        query = "UPDATE impresion_endoscopia SET imagen7='', imagen8='' WHERE id_detalle_orden='" & IdDetalleOrden & "'"
                    Case 7
                        query = "UPDATE impresion_endoscopia SET imagen8='' WHERE id_detalle_orden='" & IdDetalleOrden & "'"
                    Case Else
                        query = "UPDATE impresion_endoscopia SET imagen8='' WHERE id_detalle_orden='-1'"
                End Select

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ExisteImagenSeleccionada(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT ID FROM imagenes WHERE id='" & filtro & "' and estado='A'")
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
        Public Shared Function ContarImagenesSeleccionadas(ByVal IdDetalleOrden As String) As String
            Try
                Dim query As String = String.Format("SELECT id FROM imagenes WHERE id_detalle_orden='" & IdDetalleOrden & "' and estado='A'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                'Dim CantidadRegistros As String
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                'Dim _Imagenes = New SIM_ENDOSCOPIA.Modelo.Imagenes
                'CantidadRegistros = _ds.Tables(0).Rows(0)(0).ToString() Then
                Return _ds.Tables(0).Rows.Count
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Sub ActualizarEstadoImagen(ByVal filtro As String, ByVal filtro2 As String, ByVal filtro3 As String, imagen As Image)
            Try
                Dim imag As Byte()
                imag = Funciones.imagen_bytes(imagen)
                Dim query As String
                query = "UPDATE imagenes SET estado='" & filtro2 & "', texto='" & filtro3 & "', imagen=? WHERE id='" & filtro & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, Imag)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarImagenesActivasIC(ByVal IdDetalleOrden As String) As DataSet
            Try
                Dim query As String =
              String.Format("SELECT imagen,id,texto FROM imagenes WHERE id_detalle_orden='" & IdDetalleOrden & "' and estado='A'")
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
        Public Function ListarImagenesPaciente(ByVal IdDetalleOrden As String) As DataSet
            Try
                Dim query As String =
              String.Format("SELECT ruta AS RUTA,id FROM imagenes WHERE id_detalle_orden='" & IdDetalleOrden & "' order by id desc")
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
        Public Function ListarImagenesCapturadas2(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
              String.Format("SELECT ruta AS RUTA,id,texto FROM imagenes WHERE id_orden='" & IdOrden & "' order by id desc")
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
        Public Function ImagenesActivas(ByVal IdOrden As String) As DataSet
            Try
                Dim query As String =
              String.Format("SELECT id_orden, id_detalle_orden, ruta, texto FROM imagenes WHERE id_orden='" & IdOrden & "' and estado='A' order by id asc")
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
        Public Function ListarImagenesUpdate() As DataSet
            Try
                Dim query As String =
              String.Format("SELECT * from imagenes WHERE estado='A'")
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
        Public Sub GuardarFoto(ByVal id As String, ByVal image As Byte())
            Try
                Dim query As String
                'Imag = _funciones.Imagen_Bytes(_usuarios.Foto)

                query = "UPDATE imagenes SET imagen=? WHERE id='" & id & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.Parameters.AddWithValue(1, image)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
    End Class
End Namespace


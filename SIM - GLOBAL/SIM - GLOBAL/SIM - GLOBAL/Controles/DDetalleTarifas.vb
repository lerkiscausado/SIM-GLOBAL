Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DDetalleTarifas
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As DetalleTarifa
            Try
                Dim query As String = String.Format("SELECT * FROM detalle_tarifa WHERE id='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _DetalleTarifa = New DetalleTarifa
                _DetalleTarifa.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _DetalleTarifa.IdTarifa = _ds.Tables(0).Rows(0)(1).ToString()
                _DetalleTarifa.CodigoProcedimiento = _ds.Tables(0).Rows(0)(2).ToString()
                _DetalleTarifa.IDTipoEstudio = _ds.Tables(0).Rows(0)(3).ToString()
                _DetalleTarifa.CodigoCups = _ds.Tables(0).Rows(0)(4).ToString()
                _DetalleTarifa.Valor = _ds.Tables(0).Rows(0)(5).ToString()
                _DetalleTarifa.Descuento = _ds.Tables(0).Rows(0)(6).ToString()
                _DetalleTarifa.TipoAtencion = _ds.Tables(0).Rows(0)(7).ToString()
                _DetalleTarifa.Estado = _ds.Tables(0).Rows(0)(8).ToString()
                Return _DetalleTarifa
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM detalle_tarifa WHERE id='" & filtro & "'")
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
        Public Sub Guardar(ByVal _DetalleTarifa As DetalleTarifa)
            Try
                Dim query As String
                If Existe(_DetalleTarifa.Id) = True Then
                    query = "UPDATE detalle_tarifa SET codigo_cups='" & _DetalleTarifa.CodigoCups & "', " _
                            & "valor='" & _DetalleTarifa.Valor & "', descuento='" & _DetalleTarifa.Descuento & "', tipo_atencion='" & _DetalleTarifa.TipoAtencion & "', " _
                            & "estado='" & _DetalleTarifa.Estado & "' where id='" & _DetalleTarifa.Id & "'"
                Else
                    query = "insert into detalle_tarifa values('" & _DetalleTarifa.Id & "','" &
                            _DetalleTarifa.IdTarifa & "','" & _DetalleTarifa.CodigoProcedimiento & "','" &
                            _DetalleTarifa.IDTipoEstudio & "','" & _DetalleTarifa.CodigoCups & "', '" &
                            _DetalleTarifa.Valor & "','" & _DetalleTarifa.Descuento & "', '" & _DetalleTarifa.TipoAtencion & "', '" & _DetalleTarifa.Estado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarCombo(ByVal filtro As Integer) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_tarifa.CODIGO_PROCEDIMIENTO AS CODIGO " _
                                                  & ", tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, detalle_tarifa.VALOR, detalle_tarifa.id_tipo_estudio as TIPOESTUDIO, detalle_tarifa.codigo_cups as CUPS " _
                                                  & "FROM contratos INNER JOIN detalle_tarifa ON (contratos.ID_TARIFA = detalle_tarifa.ID_TARIFA) " _
                                                  & " INNER JOIN tipo_estudio ON (detalle_tarifa.ID_TIPO_ESTUDIO = tipo_estudio.ID) " _
                                                  & "WHERE (contratos.ID ='" & filtro & "'  And detalle_tarifa.ESTADO ='A')")
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
        Public Function ExisteCodigoTarifa(ByVal filtro1 As String, ByVal filtro2 As String) As Boolean
            Try
                Dim query As String =
                        String.Format("SELECT ID FROM detalle_tarifa 
                                        WHERE (ID_TARIFA ='" & filtro1 & "' AND CODIGO_PROCEDIMIENTO ='" & filtro2 & "')")
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
        Public Function Listar(ByVal filtro As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_tarifa.ID, detalle_tarifa.CODIGO_PROCEDIMIENTO AS CODIGO, " _
                                                  & "tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, detalle_tarifa.CODIGO_CUPS " _
                                                  & "AS CUPS, cups.NOMBRE_CUPS AS NOMBRE, detalle_tarifa.VALOR FROM " _
                                                  & "detalle_tarifa INNER JOIN cups ON (detalle_tarifa.CODIGO_CUPS = cups.CODIGO_CUPS) " _
                                                  & "INNER JOIN tipo_estudio ON (detalle_tarifa.ID_TIPO_ESTUDIO = tipo_estudio.ID) WHERE " _
                                                  & "detalle_tarifa.id_tarifa='" & filtro & "' and detalle_tarifa.estado='A'")
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
        Public Sub CambiarEstado(ByVal filtro As String)
            Try
                Dim query As String
                query = "UPDATE detalle_tarifa SET estado='I' where id='" & filtro & "'"
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarCombo2(ByVal Contrato As Integer) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_tarifa.CODIGO_PROCEDIMIENTO AS CODIGO, " _
                                                  & "tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, detalle_tarifa.CODIGO_CUPS AS CUPS, " _
                                                  & "cups.NOMBRE_CUPS AS NOMBRE, detalle_tarifa.VALOR, tipo_estudio.ID AS TIPOESTUDIO " _
                                                  & "FROM detalle_tarifa INNER JOIN tipo_estudio ON (detalle_tarifa.ID_TIPO_ESTUDIO = tipo_estudio.ID) " _
                                                  & "INNER JOIN cups ON (detalle_tarifa.CODIGO_CUPS = cups.CODIGO_CUPS) INNER JOIN contratos ON " _
                                                  & "(detalle_tarifa.ID_TARIFA = contratos.ID_TARIFA) WHERE (detalle_tarifa.ESTADO ='A' AND contratos.ID ='" & Contrato & "')")
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
        Public Function ListarComboAnexos(ByVal Contrato As Integer) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_tarifa.CODIGO_PROCEDIMIENTO AS CODIGO, " _
                                                  & "tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, detalle_tarifa.CODIGO_CUPS AS CUPS, " _
                                                  & "cups.NOMBRE_CUPS AS NOMBRE, detalle_tarifa.VALOR, tipo_estudio.ID AS TIPOESTUDIO " _
                                                  & "FROM detalle_tarifa INNER JOIN tipo_estudio ON (detalle_tarifa.ID_TIPO_ESTUDIO = tipo_estudio.ID) " _
                                                  & "INNER JOIN cups ON (detalle_tarifa.CODIGO_CUPS = cups.CODIGO_CUPS) INNER JOIN contratos ON " _
                                                  & "(detalle_tarifa.ID_TARIFA = contratos.ID_TARIFA) WHERE (detalle_tarifa.ESTADO ='A' AND contratos.ID ='" & Contrato & "' and detalle_tarifa.id_tipo_estudio='14')")
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
        Public Function ListarValor(ByVal IdContrato As String, ByVal CodigoTarifa As String) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_tarifa.CODIGO_PROCEDIMIENTO AS CODIGO, " _
                                                  & "tipo_estudio.ID AS TIPOESTUDIO, " _
                                                  & "detalle_tarifa.VALOR, " _
                                                  & "detalle_tarifa.codigo_cups, " _
                                                  & "IF(detalle_tarifa.`TIPO_ATENCION`='CONSULTA','C','P') AS TIPO " _
                                                  & "FROM detalle_tarifa INNER JOIN tipo_estudio ON " _
                                                  & "(detalle_tarifa.ID_TIPO_ESTUDIO = tipo_estudio.ID) INNER JOIN cups ON " _
                                                  & "(detalle_tarifa.CODIGO_CUPS = cups.CODIGO_CUPS) INNER JOIN contratos ON " _
                                                  & "(detalle_tarifa.ID_TARIFA = contratos.ID_TARIFA) WHERE " _
                                                  & "(detalle_tarifa.ESTADO ='A' AND contratos.ID ='" & IdContrato & "' AND detalle_tarifa.CODIGO_PROCEDIMIENTO='" & CodigoTarifa & "')")
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
        Public Sub ActualizarDetalleTarifa(ByVal filtro As String, ByVal filtro2 As String)
            Try
                Dim query As String
                query = "UPDATE detalle_tarifa SET id_tarifa='" & filtro & "' WHERE id_tarifa='" & filtro2 & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarDetalleTarifa(ByVal IdTarifa As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_tarifa WHERE id_tarifa='" & IdTarifa & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Sub EliminarItemDetalleTarifa(ByVal Id As String)
            Try
                Dim query As String
                query = "DELETE FROM detalle_tarifa WHERE id='" & Id & "'"

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Function ListarComboCitoPat(ByVal Contrato As Integer) As DataSet
            Try
                Dim query As String =
                                    String.Format("SELECT detalle_tarifa.CODIGO_PROCEDIMIENTO AS CODIGO, " _
                                                  & "tipo_estudio.NOMBRE_TIPO_ESTUDIO AS ESTUDIO, detalle_tarifa.CODIGO_CUPS AS CUPS, " _
                                                  & "cups.NOMBRE_CUPS AS NOMBRE, detalle_tarifa.VALOR, tipo_estudio.ID AS TIPOESTUDIO " _
                                                  & "FROM detalle_tarifa INNER JOIN tipo_estudio ON (detalle_tarifa.ID_TIPO_ESTUDIO = tipo_estudio.ID) " _
                                                  & "INNER JOIN cups ON (detalle_tarifa.CODIGO_CUPS = cups.CODIGO_CUPS) INNER JOIN contratos ON " _
                                                  & "(detalle_tarifa.ID_TARIFA = contratos.ID_TARIFA) WHERE (detalle_tarifa.ESTADO ='A' AND contratos.ID ='" & Contrato & "')")
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
    End Class
End Namespace


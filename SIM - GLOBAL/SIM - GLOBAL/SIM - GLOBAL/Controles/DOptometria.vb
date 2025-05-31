Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Utilidades
Namespace Controles
    Public Class DOptometria
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        ReadOnly _funciones As Funciones
        Public Function Existe(ByVal IdOrden As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT ID FROM optometria WHERE id_orden='" & IdOrden & "'")
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
        Public Sub Guardar(ByVal _Optometria As SIM___GLOBAL.Modelo.HistoriaOptometria)
            Try
                Dim query As String
                If Existe(_Optometria.IdOrden) = True Then
                    'Actualizar optometria
                    query = "UPDATE optometria SET motivo_consulta='" & _Optometria.MotivoConsulta & "'	, responsables='" & _Optometria.Responsables & "',ocupacion='" & _Optometria.Ocupacion & "' " _
                        & ",rx_uso='" & _Optometria.RXUSO & "', ANTECEDENTES='" & _Optometria.Antecedentes & "'	,AV_VL='" & _Optometria.AVVL & "' " _
                        & ",AV_VP='" & _Optometria.AVVP & "',refraccion_estatica='" & _Optometria.RefraccionEstatica & "',distancia_pupilar='" & _Optometria.DistanciaPupilar & "' " _
                        & ",subjetivo='" & _Optometria.Subjetivo & "',cover_test='" & _Optometria.CoverTest & "',modo_uso='" & _Optometria.ModoUso & "' " _
                        & ",lensometria='" & _Optometria.Lensometria & "',avf='" & _Optometria.AVF & "',diagnostico='" & _Optometria.Diagnostico & "',otros_hallazgos='" & _Optometria.OtrosHallazgos & "' " _
                        & ",cie10='" & _Optometria.CIE10 & "' ,conducta='" & _Optometria.Conducta & "',ID_especialista='" & _Optometria.IdEspecialista & "'	WHERE id_detalle_orden='" & _Optometria.IdDetalleOrden & "' "
                Else
                    'Guardar optometria
                    query = "INSERT INTO optometria VALUES('','" & _Optometria.IdOrden & "','" & _Optometria.IdDetalleOrden & "','" & Format(_Optometria.FechaHistoria, "yyyy/MM/dd") & "' " _
                        & ",'" & _Optometria.MotivoConsulta & "','" & _Optometria.Responsables & "','" & _Optometria.Ocupacion & "','" & _Optometria.RXUSO & "' " _
                        & ",'" & _Optometria.Antecedentes & "','" & _Optometria.AVVL & "','" & _Optometria.AVVP & "' " _
                        & ",'" & _Optometria.RefraccionEstatica & "','" & _Optometria.DistanciaPupilar & "','" & _Optometria.Subjetivo & "' " _
                        & ",'" & _Optometria.CoverTest & "','" & _Optometria.ModoUso & "','" & _Optometria.Lensometria & "' " _
                        & ",'" & _Optometria.AVF & "','" & _Optometria.Diagnostico & "','" & _Optometria.OtrosHallazgos & "' " _
                        & ",'" & _Optometria.CIE10 & "','" & _Optometria.Conducta & "','" & _Optometria.IdEspecialista & "')"
                End If
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Shared Function Cargar(ByVal IdOrden As String) As HistoriaOptometria
            Try
                Dim query As String = String.Format("SELECT * FROM optometria WHERE id_orden='" & IdOrden & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Optometria = New HistoriaOptometria
                _Optometria.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Optometria.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _Optometria.IdDetalleOrden = _ds.Tables(0).Rows(0)(2).ToString()
                _Optometria.FechaHistoria = _ds.Tables(0).Rows(0)(3).ToString()
                _Optometria.MotivoConsulta = _ds.Tables(0).Rows(0)(4).ToString()
                _Optometria.Responsables = _ds.Tables(0).Rows(0)(5).ToString()
                _Optometria.Ocupacion = _ds.Tables(0).Rows(0)(6).ToString()
                _Optometria.RXUSO = _ds.Tables(0).Rows(0)(7).ToString()
                _Optometria.Antecedentes = _ds.Tables(0).Rows(0)(8).ToString()
                _Optometria.AVVL = _ds.Tables(0).Rows(0)(9).ToString()
                _Optometria.AVVP = _ds.Tables(0).Rows(0)(10).ToString()
                _Optometria.RefraccionEstatica = _ds.Tables(0).Rows(0)(11).ToString()
                _Optometria.DistanciaPupilar = _ds.Tables(0).Rows(0)(12).ToString()
                _Optometria.Subjetivo = _ds.Tables(0).Rows(0)(13).ToString()
                _Optometria.CoverTest = _ds.Tables(0).Rows(0)(14).ToString()
                _Optometria.ModoUso = _ds.Tables(0).Rows(0)(15).ToString()
                _Optometria.Lensometria = _ds.Tables(0).Rows(0)(16).ToString()
                _Optometria.AVF = _ds.Tables(0).Rows(0)(17).ToString()
                _Optometria.Diagnostico = _ds.Tables(0).Rows(0)(18).ToString()
                _Optometria.OtrosHallazgos = _ds.Tables(0).Rows(0)(19).ToString()
                _Optometria.CIE10 = _ds.Tables(0).Rows(0)(20).ToString()
                _Optometria.Conducta = _ds.Tables(0).Rows(0)(21).ToString()
                _Optometria.IdEspecialista = _ds.Tables(0).Rows(0)(22).ToString()

                Return _Optometria
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace


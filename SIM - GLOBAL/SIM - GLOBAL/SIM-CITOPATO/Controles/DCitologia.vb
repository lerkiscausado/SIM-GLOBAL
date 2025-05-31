Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.My.Controles
'Imports SIM_CITOPATO.Modelo
Namespace Controles
    Public Class DCitologia
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal filtro As String) As SIM_CITOPATO.My.Modelo.Citologia
            Try
                Dim query As String = String.Format("SELECT * FROM citologia WHERE id_orden='" & filtro & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Citologia = New SIM_CITOPATO.My.Modelo.Citologia
                _Citologia.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _Citologia.IdOrden = _ds.Tables(0).Rows(0)(1).ToString()
                _Citologia.Fecha = _ds.Tables(0).Rows(0)(2).ToString()
                _Citologia.CM1 = _ds.Tables(0).Rows(0)(3).ToString()
                _Citologia.CM2 = _ds.Tables(0).Rows(0)(4).ToString()
                _Citologia.CM3 = _ds.Tables(0).Rows(0)(5).ToString()
                _Citologia.CM4 = _ds.Tables(0).Rows(0)(6).ToString()
                _Citologia.CM5 = _ds.Tables(0).Rows(0)(7).ToString()
                _Citologia.CG1 = _ds.Tables(0).Rows(0)(8).ToString()
                _Citologia.CG2 = _ds.Tables(0).Rows(0)(9).ToString()
                _Citologia.M1 = _ds.Tables(0).Rows(0)(10).ToString()
                _Citologia.M2 = _ds.Tables(0).Rows(0)(11).ToString()
                _Citologia.M3 = _ds.Tables(0).Rows(0)(12).ToString()
                _Citologia.M4 = _ds.Tables(0).Rows(0)(13).ToString()
                _Citologia.M5 = _ds.Tables(0).Rows(0)(14).ToString()
                _Citologia.M6 = _ds.Tables(0).Rows(0)(15).ToString()
                _Citologia.OHNN1 = _ds.Tables(0).Rows(0)(16).ToString()
                _Citologia.OHNN2 = _ds.Tables(0).Rows(0)(17).ToString()
                _Citologia.OHNN3 = _ds.Tables(0).Rows(0)(18).ToString()
                _Citologia.OHNN4 = _ds.Tables(0).Rows(0)(19).ToString()
                _Citologia.OHNN5 = _ds.Tables(0).Rows(0)(20).ToString()
                _Citologia.OHNN6 = _ds.Tables(0).Rows(0)(21).ToString()
                _Citologia.ACE1 = _ds.Tables(0).Rows(0)(22).ToString()
                _Citologia.ACE2 = _ds.Tables(0).Rows(0)(23).ToString()
                _Citologia.ACE3 = _ds.Tables(0).Rows(0)(24).ToString()
                _Citologia.ACE4 = _ds.Tables(0).Rows(0)(25).ToString()
                _Citologia.ACE5 = _ds.Tables(0).Rows(0)(26).ToString()
                _Citologia.ACG1 = _ds.Tables(0).Rows(0)(27).ToString()
                _Citologia.ACG2 = _ds.Tables(0).Rows(0)(28).ToString()
                _Citologia.ACG3 = _ds.Tables(0).Rows(0)(29).ToString()
                _Citologia.ACG4 = _ds.Tables(0).Rows(0)(30).ToString()
                _Citologia.ACG5 = _ds.Tables(0).Rows(0)(31).ToString()
                _Citologia.ACG6 = _ds.Tables(0).Rows(0)(32).ToString()
                _Citologia.ACG7 = _ds.Tables(0).Rows(0)(33).ToString()
                _Citologia.ACG8 = _ds.Tables(0).Rows(0)(34).ToString()
                _Citologia.FB1 = _ds.Tables(0).Rows(0)(35).ToString()
                _Citologia.FB2 = _ds.Tables(0).Rows(0)(36).ToString()
                _Citologia.FB3 = _ds.Tables(0).Rows(0)(37).ToString()
                _Citologia.I1 = _ds.Tables(0).Rows(0)(38).ToString()
                _Citologia.I2 = _ds.Tables(0).Rows(0)(39).ToString()
                _Citologia.I3 = _ds.Tables(0).Rows(0)(40).ToString()
                _Citologia.Observaciones = _ds.Tables(0).Rows(0)(41).ToString()
                _Citologia.Diagnostico = _ds.Tables(0).Rows(0)(42).ToString()
                _Citologia.Img1 = _ds.Tables(0).Rows(0)(43).ToString()
                _Citologia.Img2 = _ds.Tables(0).Rows(0)(44).ToString()
                _Citologia.IdEmpleado = _ds.Tables(0).Rows(0)(45).ToString()

                Return _Citologia
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal filtro As String) As Boolean

            Try
                Dim query As String =
                    String.Format("SELECT id FROM citologia WHERE id_orden='" & filtro & "'")
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
        Public Sub Guardar(ByVal _Citologia As SIM_CITOPATO.My.Modelo.Citologia)
            Try
                Dim query As String
                If Existe(_Citologia.IdOrden) = True Then
                    query = "UPDATE citologia SET cm_1='" & _Citologia.CM1 & "', " _
                        & "cm_2='" & _Citologia.CM2 & "', " _
                        & "cm_3='" & _Citologia.CM3 & "', " _
                        & "cm_4='" & _Citologia.CM4 & "', " _
                        & "cm_5='" & _Citologia.CM5 & "', " _
                        & "cg_1='" & _Citologia.CG1 & "', " _
                        & "cg_2='" & _Citologia.CG2 & "', " _
                        & "m_1='" & _Citologia.M1 & "', " _
                        & "m_2='" & _Citologia.M2 & "', " _
                        & "m_3='" & _Citologia.M3 & "', " _
                        & "m_4='" & _Citologia.M4 & "', " _
                        & "m_5='" & _Citologia.M5 & "', " _
                        & "m_6='" & _Citologia.M6 & "', " _
                        & "OHNN_1='" & _Citologia.OHNN1 & "', " _
                        & "OHNN_2='" & _Citologia.OHNN2 & "', " _
                        & "OHNN_3='" & _Citologia.OHNN3 & "', " _
                        & "OHNN_4='" & _Citologia.OHNN4 & "', " _
                        & "OHNN_5='" & _Citologia.OHNN5 & "', " _
                        & "OHNN_6='" & _Citologia.OHNN6 & "', " _
                        & "ace_1='" & _Citologia.ACE1 & "', " _
                        & "ace_2='" & _Citologia.ACE2 & "', " _
                        & "ace_3='" & _Citologia.ACE3 & "', " _
                        & "ace_4='" & _Citologia.ACE4 & "', " _
                        & "ace_5='" & _Citologia.ACE5 & "', " _
                        & "acg_1='" & _Citologia.ACG1 & "', " _
                        & "acg_2='" & _Citologia.ACG2 & "', " _
                        & "acg_3='" & _Citologia.ACG3 & "', " _
                        & "acg_4='" & _Citologia.ACG4 & "', " _
                        & "acg_5='" & _Citologia.ACG5 & "', " _
                        & "acg_6='" & _Citologia.ACG6 & "', " _
                        & "acg_7='" & _Citologia.ACG7 & "', " _
                        & "acg_8='" & _Citologia.ACG8 & "', " _
                        & "fb_1='" & _Citologia.FB1 & "', " _
                        & "fb_2='" & _Citologia.FB2 & "', " _
                        & "fb_3='" & _Citologia.FB3 & "', " _
                        & "i_1='" & _Citologia.I1 & "', " _
                        & "i_2='" & _Citologia.I2 & "', " _
                        & "i_3='" & _Citologia.I3 & "', " _
                        & "observaciones='" & _Citologia.Observaciones & "', " _
                        & "diagnostico='" & _Citologia.Diagnostico & "', " _
                        & "img1='" & _Citologia.Img1 & "', " _
                        & "img2='" & _Citologia.Img2 & "', " _
                        & "id_empleado='" & _Citologia.IdEmpleado & "' " _
                        & "WHERE id_orden='" & _Citologia.IdOrden & "'"



                Else
                    query = "insert into citologia values('" & _Citologia.Id & "','" &
                        _Citologia.IdOrden & "','" & Format(_Citologia.Fecha, "yyyy/MM/dd") & "'," _
                        & "'" & _Citologia.CM1 & "'," _
                        & "'" & _Citologia.CM2 & "'," _
                        & "'" & _Citologia.CM3 & "'," _
                        & "'" & _Citologia.CM4 & "'," _
                        & "'" & _Citologia.CM5 & "'," _
                        & "'" & _Citologia.CG1 & "'," _
                        & "'" & _Citologia.CG2 & "'," _
                        & "'" & _Citologia.M1 & "'," _
                        & "'" & _Citologia.M2 & "'," _
                        & "'" & _Citologia.M3 & "'," _
                        & "'" & _Citologia.M4 & "'," _
                        & "'" & _Citologia.M5 & "'," _
                        & "'" & _Citologia.M6 & "'," _
                        & "'" & _Citologia.OHNN1 & "'," _
                        & "'" & _Citologia.OHNN2 & "'," _
                        & "'" & _Citologia.OHNN3 & "'," _
                        & "'" & _Citologia.OHNN4 & "'," _
                        & "'" & _Citologia.OHNN5 & "'," _
                        & "'" & _Citologia.OHNN6 & "'," _
                        & "'" & _Citologia.ACE1 & "'," _
                        & "'" & _Citologia.ACE2 & "'," _
                        & "'" & _Citologia.ACE3 & "'," _
                        & "'" & _Citologia.ACE4 & "'," _
                        & "'" & _Citologia.ACE5 & "'," _
                        & "'" & _Citologia.ACG1 & "'," _
                        & "'" & _Citologia.ACG2 & "'," _
                        & "'" & _Citologia.ACG3 & "'," _
                        & "'" & _Citologia.ACG4 & "'," _
                        & "'" & _Citologia.ACG5 & "'," _
                        & "'" & _Citologia.ACG6 & "'," _
                        & "'" & _Citologia.ACG7 & "'," _
                        & "'" & _Citologia.ACG8 & "'," _
                        & "'" & _Citologia.FB1 & "'," _
                        & "'" & _Citologia.FB2 & "'," _
                        & "'" & _Citologia.FB3 & "'," _
                        & "'" & _Citologia.I1 & "'," _
                        & "'" & _Citologia.I2 & "'," _
                        & "'" & _Citologia.I3 & "'," _
                        & "'" & _Citologia.Observaciones & "'," _
                        & "'" & _Citologia.Diagnostico & "'," _
                        & "'" & _Citologia.Img1 & "'," _
                        & "'" & _Citologia.Img2 & "'," _
                        & "'" & _Citologia.IdEmpleado & "')"
                End If

                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                comando.ExecuteNonQuery()
                ConexionODBC.Close(_conn)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub
        Public Shared Function UltimoRegistroCitologia() As DataSet
            Try
                Dim query As String = String.Format("SELECT tipo_estudio.PREFIJO, citologia.ID FROM ordenes " _
                                                & "INNER JOIN citologia ON (ordenes.ID = citologia.ID_ORDEN) " _
                                                & "INNER JOIN tipo_estudio ON (ordenes.ID_TIPO_ESTUDIO = " _
                                                & "tipo_estudio.ID) ORDER BY citologia.id DESC LIMIT 1")
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
        Public Shared Function OrdenCitologia(ByVal filtro As String) As SIM_CITOPATO.My.Modelo.Citologia
            Try
                Dim query As String = String.Format("SELECT id_orden FROM citologia WHERE (ID_ORDEN='" & filtro & "')")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _Citologia = New SIM_CITOPATO.My.Modelo.Citologia
                _Citologia.IdOrden = _ds.Tables(0).Rows(0)(0).ToString()
                Return _Citologia
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class

End Namespace

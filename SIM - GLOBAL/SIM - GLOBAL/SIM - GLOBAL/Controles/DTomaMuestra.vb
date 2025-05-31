Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Namespace Controles
    Public Class DTomaMuestra
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Shared Function Cargar(ByVal IDUsuario As String) As TomaMuestra
            Try
                Dim query As String = String.Format("SELECT * FROM toma_muestra WHERE id_usuario='" & IDUsuario & "'")
                _conn = ConexionODBC.Open()
                Dim comando = New OdbcCommand(query, _conn)
                _adapter = New OdbcDataAdapter(comando)
                _ds = New DataSet()
                _adapter.Fill(_ds)
                ConexionODBC.Close(_conn)
                Dim _tomaMuestra = New TomaMuestra
                _tomaMuestra.Id = _ds.Tables(0).Rows(0)(0).ToString()
                _tomaMuestra.IdUsuario = _ds.Tables(0).Rows(0)(1).ToString()
                _tomaMuestra.G = _ds.Tables(0).Rows(0)(2).ToString()
                _tomaMuestra.P = _ds.Tables(0).Rows(0)(3).ToString()
                _tomaMuestra.A = _ds.Tables(0).Rows(0)(4).ToString()
                _tomaMuestra.C = _ds.Tables(0).Rows(0)(5).ToString()
                _tomaMuestra.IVSA = _ds.Tables(0).Rows(0)(6).ToString()
                _tomaMuestra.MPF = _ds.Tables(0).Rows(0)(7).ToString()
                _tomaMuestra.FUM = _ds.Tables(0).Rows(0)(8).ToString()
                _tomaMuestra.FUC = _ds.Tables(0).Rows(0)(9).ToString()
                _tomaMuestra.FUP = _ds.Tables(0).Rows(0)(10).ToString()
                _tomaMuestra.S = _ds.Tables(0).Rows(0)(11).ToString()
                _tomaMuestra.U = _ds.Tables(0).Rows(0)(12).ToString()
                _tomaMuestra.L = _ds.Tables(0).Rows(0)(13).ToString()
                _tomaMuestra.BN = _ds.Tables(0).Rows(0)(14).ToString()
                _tomaMuestra.CN = _ds.Tables(0).Rows(0)(15).ToString()
                _tomaMuestra.BA = _ds.Tables(0).Rows(0)(16).ToString()
                _tomaMuestra.O = _ds.Tables(0).Rows(0)(17).ToString()
                _tomaMuestra.Observaciones = _ds.Tables(0).Rows(0)(18).ToString()
                Return _tomaMuestra
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Existe(ByVal IdUsuario As String) As Boolean

            Try
                Dim query As String =
                        String.Format("SELECT id FROM toma_Muestra WHERE id_usuario='" & IdUsuario & "'")
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
        Public Sub Guardar(ByVal _TomaMuestra As TomaMuestra)
            Try
                Dim query As String
                If Existe(_TomaMuestra.IdUsuario) = True Then
                    query = "UPDATE toma_muestra SET " _
                            & "g='" & _TomaMuestra.G & "'" _
                            & ",p='" & _TomaMuestra.P & "'" _
                            & ",a='" & _TomaMuestra.A & "'" _
                            & ",c='" & _TomaMuestra.C & "'" _
                            & ",ivsa='" & _TomaMuestra.IVSA & "'" _
                            & ",mpf='" & _TomaMuestra.MPF & "'" _
                            & ",fum='" & _TomaMuestra.FUM & "'" _
                            & ",fuc='" & _TomaMuestra.FUC & "'" _
                            & ",fup='" & _TomaMuestra.FUP & "'" _
                            & ",s='" & _TomaMuestra.S & "'" _
                            & ",u='" & _TomaMuestra.U & "'" _
                            & ",l='" & _TomaMuestra.L & "'" _
                            & ",bn='" & _TomaMuestra.BN & "'" _
                            & ",cn='" & _TomaMuestra.CN & "'" _
                            & ",ba='" & _TomaMuestra.BA & "'" _
                            & ",o='" & _TomaMuestra.O & "'" _
                            & ",observaciones='" & _TomaMuestra.Observaciones & "'" _
                            & "where id_usuario='" & _TomaMuestra.IdUsuario & "'"
                Else
                    query = "insert into toma_muestra values(''" _
                            & ",'" & _TomaMuestra.IdUsuario & "'" _
                            & ",'" & _TomaMuestra.G & "'" _
                            & ",'" & _TomaMuestra.P & "'" _
                            & ",'" & _TomaMuestra.A & "'" _
                            & ",'" & _TomaMuestra.C & "'" _
                            & ",'" & _TomaMuestra.IVSA & "'" _
                            & ",'" & _TomaMuestra.MPF & "'" _
                            & ",'" & _TomaMuestra.FUM & "'" _
                            & ",'" & _TomaMuestra.FUC & "'" _
                            & ",'" & _TomaMuestra.FUP & "'" _
                            & ",'" & _TomaMuestra.S & "'" _
                            & ",'" & _TomaMuestra.U & "'" _
                            & ",'" & _TomaMuestra.L & "'" _
                            & ",'" & _TomaMuestra.BN & "'" _
                            & ",'" & _TomaMuestra.CN & "'" _
                            & ",'" & _TomaMuestra.BA & "'" _
                            & ",'" & _TomaMuestra.O & "'" _
                            & ",'" & _TomaMuestra.Observaciones & "')"
                End If

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

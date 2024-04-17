Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Namespace Controles
    Public Class DPercentiles
        Shared _conn As New OdbcConnection
        Shared _ds As DataSet
        Shared _adapter As DataAdapter
        Public Function Listar(ByVal filtro As String) As DataSet
            Dim query As String = ""
            Try
                Select Case filtro
                    'Grafica de Altura Masculino
                    Case "AMAXIMOM"
                        query = String.Format("SELECT `edad` AS `Argument`, `AMaximoM` AS `value` FROM `percentiles`")
                    Case "ANORMALM"
                        query = String.Format("SELECT `edad` AS `Argument`, `ANormalM` AS `value` FROM `percentiles`")
                    Case "AMINIMOM"
                        query = String.Format("SELECT `edad` AS `Argument`, `AMinimaM` AS `value` FROM `percentiles`")
                   'Grafica de Altura Femenino
                    Case "AMAXIMOF"
                        query = String.Format("SELECT `edad` AS `Argument`, `AMaximoF` AS `value` FROM `percentiles`")
                    Case "ANORMALF"
                        query = String.Format("SELECT `edad` AS `Argument`, `ANormalF` AS `value` FROM `percentiles`")
                    Case "AMINIMOF"
                        query = String.Format("SELECT `edad` AS `Argument`, `AMinimaF` AS `value` FROM `percentiles`")
                    'Grafica de PESO Masculino
                    Case "PMAXIMOM"
                        query = String.Format("SELECT `edad` AS `Argument`, `PMaximoM` AS `value` FROM `percentiles`")
                    Case "PNORMALM"
                        query = String.Format("SELECT `edad` AS `Argument`, `PNormalM` AS `value` FROM `percentiles`")
                    Case "PMINIMOM"
                        query = String.Format("SELECT `edad` AS `Argument`, `PMinimaM` AS `value` FROM `percentiles`")
                   'Grafica de PESO Femenino
                    Case "PMAXIMOF"
                        query = String.Format("SELECT `edad` AS `Argument`, `PMaximoF` AS `value` FROM `percentiles`")
                    Case "PNORMALF"
                        query = String.Format("SELECT `edad` AS `Argument`, `PNormalF` AS `value` FROM `percentiles`")
                    Case "PMINIMOF"
                        query = String.Format("SELECT `edad` AS `Argument`, `PMinimaF` AS `value` FROM `percentiles`")

                End Select

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
        Public Function Paciente(ByVal Orden As String, ByVal Grafica As String) As DataSet
            Dim query As String = ""
            Try
                Select Case Grafica
                    'Grafica TALLA
                    Case "TALLA"
                        query = String.Format("SELECT TIMESTAMPDIFF(YEAR,Fecha_Nacimiento,CURDATE()) AS `Argument`, " _
                                              & "`historia_clinica`.`TALLA` as value FROM `ordenes` INNER JOIN `historia_clinica` " _
                                              & "ON (`ordenes`.`ID` = `historia_clinica`.`ID_ORDEN`) INNER JOIN `usuarios` ON " _
                                              & "(`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) WHERE (`ordenes`.`ID` ='" & Orden & "')")
                    'Grafica TALLA
                    Case "PESO"
                        query = String.Format("SELECT TIMESTAMPDIFF(YEAR,Fecha_Nacimiento,CURDATE()) AS `Argument`, " _
                                              & "`historia_clinica`.`PESO` as value FROM `ordenes` INNER JOIN `historia_clinica` " _
                                              & "ON (`ordenes`.`ID` = `historia_clinica`.`ID_ORDEN`) INNER JOIN `usuarios` ON " _
                                              & "(`ordenes`.`ID_USUARIO` = `usuarios`.`ID`) WHERE (`ordenes`.`ID` ='" & Orden & "')")
                End Select

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

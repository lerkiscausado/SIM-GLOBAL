Imports SIM___GLOBAL.My.Modelo
Imports SIM___GLOBAL.My.Controles
Imports System.Data.Common
Imports System.Data.Odbc
Public Class DInsertar
    Shared _conn As New OdbcConnection
    Shared _ds As DataSet
    Shared _adapter As DataAdapter
    Public Function Listar() As DataSet
        Try
            Dim query As String =
                                String.Format(
                                    "Select id, id_orden from historia_clinica")
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
    Public Sub Guardar(ByVal _id_historia As String, ByVal id_orden As String)
        Try
            Dim query As String
            query = "INSERT INTO  `detalle_orden` (`ID` ,`ID_ORDEN` ,`ID_CAUSA` ,`ID_FINALIDAD_CONSULTA` ,`ID_FINALIDAD_PROCEDIMIENTO` " _
& ",`ID_AMBITO` ,`ID_PERSONA_ATIENDE` ,`FECHA_SALIDA` ,`HORA` ,`ID_TIPO_DIAGNOSTICO` ,`DIAGNOSTICO1` ,`DIAGNOSTICO2` ,`DIAGNOSTICO3` , " _
& "`DIAGNOSTICO4` ,`ID_FORMA_REALIZACION` ,`CODIGO_PROCEDIMIENTO` ,`ID_TIPO_ESTUDIO` ,`VALOR` ,`COPAGO` ,`NETO` ,`TIPO` ,`ESTADO` ,`ID_HISTORIA`) " _
& "VALUES ('' ,  '" & id_orden & "',  '15',  '10',  '1',  '1',  '1',  '2019-09-12',  '08:00 AM',  '1', '' , '' , '' , '' ,  '1',  '890202',  '9',  '1000', '0' ,  '1000',  'C',  'ATENDIDO',  '" & _id_historia & "')"

            _conn = ConexionODBC.Open()
            Dim comando = New OdbcCommand(query, _conn)
            comando.ExecuteNonQuery()
            ConexionODBC.Close(_conn)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

End Class

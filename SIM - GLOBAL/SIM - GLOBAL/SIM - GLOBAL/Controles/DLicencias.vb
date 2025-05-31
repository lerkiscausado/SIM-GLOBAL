Imports System.Data
Imports System.Data.Odbc
Imports SIM___GLOBAL.Modelo
Imports SIM___GLOBAL.My.Controles


Namespace Controles
    Public Class DLicencias
        ' Ya no usamos campos Shared; cada instancia maneja su propio estado.
        Private ReadOnly _connectionString As String

        Public Sub New()
            _connectionString = ConexionODBC.Cadena
        End Sub

        ''' <summary>
        ''' Obtiene una licencia por su ID.
        ''' </summary>
        Public Function Cargar(ByVal idLicencia As String) As Licencias
            Dim sql As String = "SELECT id, cliente, fechaContratacion, serial, idOrigen, estado " &
                                "FROM licencias WHERE id = ?"

            ' Usamos Using para asegurar cierre/disposición correcta
            Using conn As OdbcConnection = New OdbcConnection(_connectionString)
                Using cmd As New OdbcCommand(sql, conn)
                    cmd.Parameters.Add("id", OdbcType.VarChar, 50).Value = idLicencia
                    conn.Open()

                    Using reader = cmd.ExecuteReader()
                        If Not reader.Read() Then
                            Return Nothing
                        End If

                        Dim lic As New Licencias() With {
                            .Id = reader("id").ToString(),
                            .NombreCliente = reader("cliente").ToString(),
                            .FechaContatacion = reader("fechaContratacion").ToString(),
                            .Serial = reader("serial").ToString(),
                            .IdOrigen = reader("idOrigen").ToString(),
                            .Estado = reader("estado").ToString()
                        }
                        Return lic
                    End Using
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Lista las licencias activas (estado = 'A') para un combo.
        ''' </summary>
        Public Function ListarCombo() As DataSet
            Dim sql As String = "SELECT id AS ID, cliente AS EMPRESA FROM licencias WHERE estado = 'A'"
            Dim ds As New DataSet()

            Using conn As New OdbcConnection(_connectionString)
                Using cmd As New OdbcCommand(sql, conn)
                    conn.Open()
                    Using adapter As New OdbcDataAdapter(cmd)
                        adapter.Fill(ds)  ' Llenamos el DataSet completo
                    End Using
                End Using
            End Using

            Return ds
        End Function
    End Class
End Namespace



Imports StackExchange.Redis
Imports Newtonsoft.Json ' Para serializar objetos
Public Class RedisCacheService
    Private Shared ReadOnly _conexion As Lazy(Of ConnectionMultiplexer) =
        New Lazy(Of ConnectionMultiplexer)(Function()
                                               Return ConnectionMultiplexer.Connect("tu_servidor_redis:6379,password=tu_clave")
                                           End Function)

    Public Shared ReadOnly Property Cache As IDatabase
        Get
            Return _conexion.Value.GetDatabase()
        End Get
    End Property
End Class

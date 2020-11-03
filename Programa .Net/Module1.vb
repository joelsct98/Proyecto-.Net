Module Module1
    Public codigo_aceptado As String
    Public nombre_aceptado As String
    Public direccion_aceptado As String
    Public pedido As String
    Public cuenta_aceptado As Integer
    Public valor_total_total As Integer = 0
    Public contador As Integer = 0
    Public contador_rechazos As Integer = 0


    Public tiempo_perdido_minutos As Integer = 0
    Public tiempo_perdido_segundos As Integer = 0
    Public tiempo_total_minutos As Integer = 0
    Public tiempo_total_segundos As Integer = 0


    Public minutos As Integer = 0
    Public segundos As Integer = 0


    Public cargar As Integer = 1
    Public i As Integer = 1



    Structure pedidoAceptados
        Public codigo_aceptado As String
        Public nombre_aceptado As String
        Public direccion_aceptado As String
        Public pedido As String
        Public cuenta_aceptado As String
    End Structure


    Public pedidos(30) As pedidoAceptados


End Module
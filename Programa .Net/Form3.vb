Public Class Form3


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 1
        valor_total.Text = valor_total_total
        numero_pedidos.Text = contador
        rechazados.Text = contador_rechazos

        'pedidos aceptados'
        codigo.Text = Module1.pedidos(i).codigo_aceptado
        nombre.Text = Module1.pedidos(i).nombre_aceptado
        direccion.Text = Module1.pedidos(i).direccion_aceptado
        pedido.Text = Module1.pedidos(i).pedido
        precio.Text = Module1.pedidos(i).cuenta_aceptado

        If tiempo_perdido_segundos >= 60 And tiempo_perdido_segundos < 120 Then
            tiempo_perdido_minutos += 1
            tiempo_perdido_segundos = tiempo_perdido_segundos - 60
        ElseIf tiempo_perdido_segundos >= 120 And tiempo_perdido_segundos < 180 Then
            tiempo_perdido_minutos += 2
            tiempo_perdido_segundos = tiempo_perdido_segundos - 120
        ElseIf tiempo_perdido_segundos >= 180 And tiempo_perdido_segundos < 240 Then
            tiempo_perdido_minutos += 3
            tiempo_perdido_segundos = tiempo_perdido_segundos - 180
        ElseIf tiempo_perdido_segundos >= 240 And tiempo_perdido_segundos < 300 Then
            tiempo_perdido_minutos += 4
            tiempo_perdido_segundos = tiempo_perdido_segundos - 240
        End If

        minutos.Text = tiempo_perdido_minutos
        segundos.Text = tiempo_perdido_segundos

        '---------------
        If tiempo_total_segundos >= 60 And tiempo_total_segundos < 120 Then
            tiempo_total_minutos += 1
            tiempo_total_segundos = tiempo_total_segundos - 60
        ElseIf tiempo_total_segundos >= 120 And tiempo_total_segundos < 180 Then
            tiempo_total_minutos += 2
            tiempo_total_segundos = tiempo_total_segundos - 120
        ElseIf tiempo_total_segundos >= 180 And tiempo_total_segundos < 240 Then
            tiempo_total_minutos += 3
            tiempo_total_segundos = tiempo_total_segundos - 180
        ElseIf tiempo_total_segundos >= 240 And tiempo_total_segundos < 300 Then
            tiempo_total_minutos += 4
            tiempo_total_segundos = tiempo_total_segundos - 240
        End If

        minutos_totales.Text = tiempo_total_minutos
        segundos_totales.Text = tiempo_total_segundos
    End Sub


    Private Sub adelante_Click(sender As Object, e As EventArgs) Handles adelante.Click

        If (i > contador) Then
            i = 1
        Else
            i = i + 1
        End If

        codigo.Text = Module1.pedidos(i).codigo_aceptado
        nombre.Text = Module1.pedidos(i).nombre_aceptado
        direccion.Text = Module1.pedidos(i).direccion_aceptado
        pedido.Text = Module1.pedidos(i).pedido
        precio.Text = Module1.pedidos(i).cuenta_aceptado
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click

        If (i = 0) Then
            i = contador
        Else
            i = i - 1
        End If

        codigo.Text = Module1.pedidos(i).codigo_aceptado
        nombre.Text = Module1.pedidos(i).nombre_aceptado
        direccion.Text = Module1.pedidos(i).direccion_aceptado
        pedido.Text = Module1.pedidos(i).pedido
        precio.Text = Module1.pedidos(i).cuenta_aceptado
    End Sub
    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click

        Form1.Show()
        Me.Close()
    End Sub
End Class
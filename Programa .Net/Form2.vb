Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        codigo.Text = Module1.codigo_aceptado
        nombre.Text = Module1.nombre_aceptado
        direccion.Text = Module1.direccion_aceptado
        pedido.Text = Module1.pedido
        precio.Text = Module1.cuenta_aceptado
        minutos.Text = Module1.minutos
        segundos.Text = Module1.segundos
    End Sub

    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click

        Module1.pedidos(cargar).codigo_aceptado = codigo.Text
        Module1.pedidos(cargar).nombre_aceptado = nombre.Text
        Module1.pedidos(cargar).direccion_aceptado = direccion.Text
        Module1.pedidos(cargar).pedido = pedido.Text
        Module1.pedidos(cargar).cuenta_aceptado = precio.Text
        valor_total_total = (valor_total_total + Module1.cuenta_aceptado) * 0.9 'iba'

        cargar = cargar + 1

        contador = contador + 1
        codigo.Text = ""
        nombre.Text = ""
        direccion.Text = ""
        pedido.Text = ""
        precio.Text = ""
        Module1.cuenta_aceptado = 0
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click

        'limpiamos'
        codigo.Text = ""
        nombre.Text = ""
        direccion.Text = ""
        pedido.Text = ""
        precio.Text = ""

        Me.Close()
        Form1.Show()
        contador_rechazos = contador_rechazos + 1
        contador = contador + 1
    End Sub


End Class
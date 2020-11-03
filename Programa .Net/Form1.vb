Imports System.Text.RegularExpressions
Public Class Form1
    Dim codigo_pasado As String
    Dim bocadillos_pasado As String
    Dim extras1 As String
    Dim extras2 As String
    Dim extras3 As String
    Dim cuenta As Integer = 0
    Dim terminar As Boolean = True
    Dim valores As Integer = 6
    Dim seguir As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cliente.BackColor = Color.White
        nombre.BackColor = Color.White
        bocadillos.BackColor = Color.White
        direccion.BackColor = Color.White
        dni.BackColor = Color.White

        cliente.Text = "inserte aqui"
        nombre.Text = "inserte aqui"
        direccion.Text = "inserte aqui"
        bocadillos.Text = "inserte aqui"
        telefono.Text = "inserte aqui"
        dni.Text = "inserte aqui"
        Label9.Text = "00"
        Label8.Text = "00"
        Label7.Text = "00"

        Timer1.Start()
        Me.Label6.Text = DateTime.Now.ToShortTimeString

        If Label6.Text = "13:57" Then
            MsgBox("estamos apunto de cerrar")
        ElseIf Label6.Text = "14:00" Then
            End
        ElseIf Label6.Text = "19:57" Then
            MsgBox("estamos apunto de cerrar")
        ElseIf Label6.Text = "20:00" Then
            End
        End If
    End Sub
    Private Sub cliente_TextChanged(sender As Object, e As EventArgs) Handles cliente.TextChanged
        codigo_pasado = cliente.Text


        If (codigo_pasado.Equals("1")) Then
            nombre.Text = "joel"
            direccion.Text = "calle Soledad 25"
            telefono.Text = "685219563"
            dni.Text = "51760791G"
        ElseIf (codigo_pasado.Equals("2")) Then
            nombre.Text = "oscar"
            direccion.Text = "calle 123"
            telefono.Text = "682349563"
            dni.Text = "51723491G"
        ElseIf (codigo_pasado.Equals("3")) Then
            nombre.Text = "martin"
            direccion.Text = "calle 777"
            telefono.Text = "656719563"
            dni.Text = "51767891G"
        ElseIf (codigo_pasado.Equals("4")) Then
            nombre.Text = "adrian"
            direccion.Text = "calle 444"
            telefono.Text = "685457563"
            dni.Text = "51745691G"
        ElseIf (codigo_pasado.Equals("5")) Then
            nombre.Text = "juan antonio de la vera"
            direccion.Text = "calle 222"
            telefono.Text = "688919563"
            dni.Text = "51778991G"
        ElseIf (codigo_pasado.Equals("0")) Then
            nombre.Text = ""
            direccion.Text = ""
            telefono.Text = ""
            dni.Text = ""
        ElseIf (codigo_pasado.Equals("")) Then
            nombre.Text = ""
            direccion.Text = ""
            telefono.Text = ""
            dni.Text = ""
        Else
            cliente.Text = valores
            nombre.Text = ""
            direccion.Text = ""
            telefono.Text = ""
            dni.Text = ""
        End If



    End Sub

    Private Sub bocadillos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bocadillos.SelectedIndexChanged

        cuenta = 0
        bocadillos_pasado = bocadillos.Text
        extras1 = extra1.Text
        extras2 = extra2.Text
        extras3 = extra3.Text

        If (bocadillos_pasado.Contains("bocadillo")) Then
            cuenta = cuenta + 6
        End If
        If (extras1.Contains("extra")) Then
            cuenta = cuenta + 0.5
        End If
        If (extras2.Contains("extra")) Then
            cuenta = cuenta + 0.5
        End If
        If (extras3.Contains("extra")) Then
            cuenta = cuenta + 0.5
        End If
    End Sub

    Private Sub aceptado_Click(sender As Object, e As EventArgs) Handles aceptado.Click
        seguir = True

        If (cliente.Text.Contains("inserte aqui") Or cliente.Text.Equals("")) Then
            cliente.BackColor = Color.Red

            seguir = False
        Else
            cliente.BackColor = Color.White
        End If
        If (nombre.Text.Contains("inserte aqui") Or nombre.Text.Equals("")) Then
            nombre.BackColor = Color.Red
            nombre.Text = ""
            seguir = False
        Else
            nombre.BackColor = Color.White
        End If
        If (direccion.Text.Contains("inserte aqui") Or direccion.Text.Equals("")) Then
            direccion.BackColor = Color.Red
            direccion.Text = ""
            seguir = False
        Else
            direccion.BackColor = Color.White
        End If
        If (telefono.Text.Contains("inserte aqui") Or telefono.Text.Equals("")) Then
            telefono.BackColor = Color.Red
            seguir = False
        Else
            telefono.BackColor = Color.White
        End If
        If (dni.Text.Contains("inserte aqui") Or dni.Text.Equals("")) Then
            dni.BackColor = Color.Red
            seguir = False
        Else
            dni.BackColor = Color.White
        End If
        If (bocadillos.Text.Contains("inserte aqui") Or bocadillos.Text.Equals("")) Then
            bocadillos.BackColor = Color.Red
            bocadillos.Text = ""
            seguir = False
        Else
            bocadillos.BackColor = Color.White
        End If

        'nombre depuracion
        Do While Regex.IsMatch(nombre.Text, "^[0-9]+$") Or Regex.IsMatch(nombre.Text, "[`~!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>,\.\?/]")
            If Regex.IsMatch(nombre.Text, "[`~!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>,\.\?/]") Then
                nombre.Text = ""
                nombre.BackColor = Color.Red
                seguir = False
            ElseIf Regex.IsMatch(nombre.Text, "^[0-9]+$") Then
                nombre.Text = ""
                nombre.BackColor = Color.Red
                seguir = False
            Else
                'vbLf  introduce un salto de linea'
                nombre.Text = ""
                nombre.BackColor = Color.Red
                seguir = False
            End If
        Loop


        'dni depuracion
        If dni.Text.Length < 9 Or dni.Text.Length > 9 Then
            dni.Text = ""
            dni.BackColor = Color.Red
            seguir = False

        ElseIf Regex.IsMatch(dni.Text, "[`~!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>,\.\?/]") Then
            dni.Text = ""
            dni.BackColor = Color.Red
            seguir = False
        ElseIf IsNumeric(dni.Text.Last) Then
            dni.Text = ""
            dni.BackColor = Color.Red
            seguir = False
        Else
            If Not IsNumeric(dni.Text.Substring(0, (dni.Text.Length - 2))) Then
                dni.Text = ""
                dni.BackColor = Color.Red
                seguir = False
            End If
        End If


        'telefono
        If telefono.Text.Length < 9 Or telefono.Text.Length > 9 Then
            telefono.Text = ""
            telefono.BackColor = Color.Red
            seguir = False
        ElseIf Regex.IsMatch(telefono.Text, "[`~!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>,\.\?/]") Then
            telefono.Text = ""
            telefono.BackColor = Color.Red
            seguir = False
        ElseIf Regex.IsMatch(telefono.Text, "^[a-z]+$") Then
            telefono.Text = ""
            telefono.BackColor = Color.Red
            seguir = False
        End If

        'direccion
        Do While Regex.IsMatch(direccion.Text, "^[0-9]+$") Or Regex.IsMatch(direccion.Text, "[`~!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>,\.\?/]")
            If Regex.IsMatch(direccion.Text, "[`~!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>,\.\?/]") Then
                direccion.Text = ""
                direccion.BackColor = Color.Red
                seguir = False
            ElseIf Regex.IsMatch(direccion.Text, "^[0-9]+$") Then
                direccion.Text = ""
                direccion.BackColor = Color.Red
                seguir = False
            Else
                'vbLf  introduce un salto de linea'
                direccion.Text = ""
                direccion.BackColor = Color.Red
                seguir = False
            End If
        Loop

        If seguir = True Then
            Module1.codigo_aceptado = cliente.Text
            Module1.nombre_aceptado = nombre.Text
            Module1.direccion_aceptado = direccion.Text
            Module1.pedido = bocadillos.Text + "-" + extra1.Text + "-" + extra2.Text + "-" + extra3.Text
            Module1.cuenta_aceptado = cuenta

            Module1.minutos = Int32.Parse(Label7.Text)
            Module1.segundos = Int32.Parse(Label8.Text)

            If (cliente.Text >= "6") Then
                valores = valores + 1
            End If

            If minutos >= 2 Then
                Dim sumar As Integer = minutos
                tiempo_perdido_minutos = tiempo_perdido_minutos + sumar - 2

                Dim sumars As Integer = segundos
                tiempo_perdido_segundos = tiempo_perdido_segundos + sumars

            End If

            Dim sumarr As Integer = minutos
            tiempo_total_minutos = tiempo_total_minutos + sumarr


            Dim sumarsr As Integer = segundos
            tiempo_total_segundos = tiempo_total_segundos + sumarsr
            Form2.Show()

            cliente.Text = "inserte aqui"
            nombre.Text = "inserte aqui"
            direccion.Text = "inserte aqui"
            bocadillos.Text = "inserte aqui"
            telefono.Text = "inserte aqui"
            dni.Text = "inserte aqui"
            extra1.Text = ""
            extra2.Text = ""
            extra3.Text = ""
            Label9.Text = "00"
            Label8.Text = "00"
            Label7.Text = "00"
            terminar = True

            cliente.BackColor = Color.White
            nombre.BackColor = Color.White
            bocadillos.BackColor = Color.White
            direccion.BackColor = Color.White
            telefono.BackColor = Color.White
            dni.BackColor = Color.White
        End If
    End Sub


    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        End
    End Sub

    Private Sub resumen_Click(sender As Object, e As EventArgs) Handles resumen.Click
        cliente.Text = "inserte aqui"
        nombre.Text = "inserte aqui"
        direccion.Text = "inserte aqui"
        bocadillos.Text = "inserte aqui"
        telefono.Text = "inserte aqui"
        dni.Text = "inserte aqui"
        extra1.Text = ""
        extra2.Text = ""
        extra3.Text = ""
        Label9.Text = "00"
        Label8.Text = "00"
        Label7.Text = "00"
        Form3.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label9.Text += 5
        If Label9.Text = "60" Then
            Label8.Text += 1
            Label9.Text = "00"
        End If
        If Label8.Text = "60" Then
            Label7.Text += 1
            Label8.Text = "00"
        End If

        If Label7.Text = "2" Then
            If terminar = True Then
                terminar = False
                MsgBox("ya expiro el tiempo de el pedido")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cliente.Text = ""
        nombre.Text = ""
        direccion.Text = ""
        bocadillos.Text = ""
        telefono.Text = ""
        dni.Text = ""
        extra1.Text = ""
        extra2.Text = ""
        extra3.Text = ""
        Label9.Text = "00"
        Label8.Text = "00"
        Label7.Text = "00"
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.valor_total = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numero_pedidos = New System.Windows.Forms.TextBox()
        Me.salir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rechazados = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pedido = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.atras = New System.Windows.Forms.Button()
        Me.adelante = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.segundos = New System.Windows.Forms.Label()
        Me.minutos = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.segundos_totales = New System.Windows.Forms.Label()
        Me.minutos_totales = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'valor_total
        '
        Me.valor_total.Location = New System.Drawing.Point(138, 22)
        Me.valor_total.Name = "valor_total"
        Me.valor_total.Size = New System.Drawing.Size(168, 20)
        Me.valor_total.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VALOR_TOTAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NUMERO DE PEDIDOS"
        '
        'numero_pedidos
        '
        Me.numero_pedidos.Location = New System.Drawing.Point(138, 48)
        Me.numero_pedidos.Name = "numero_pedidos"
        Me.numero_pedidos.Size = New System.Drawing.Size(168, 20)
        Me.numero_pedidos.TabIndex = 4
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(207, 326)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(100, 36)
        Me.salir.TabIndex = 6
        Me.salir.Text = "SALIR"
        Me.salir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "PEDIDOS RECHAZADOS"
        '
        'rechazados
        '
        Me.rechazados.Location = New System.Drawing.Point(138, 74)
        Me.rechazados.Name = "rechazados"
        Me.rechazados.Size = New System.Drawing.Size(168, 20)
        Me.rechazados.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "PEDIDOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "PEDIDO"
        '
        'pedido
        '
        Me.pedido.Location = New System.Drawing.Point(105, 265)
        Me.pedido.Name = "pedido"
        Me.pedido.Size = New System.Drawing.Size(202, 20)
        Me.pedido.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "NOMBRE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "DIRECCION"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "PRECIO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(50, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "CODIGO"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(105, 213)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(202, 20)
        Me.nombre.TabIndex = 25
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(105, 239)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(202, 20)
        Me.direccion.TabIndex = 24
        '
        'precio
        '
        Me.precio.Location = New System.Drawing.Point(105, 291)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(202, 20)
        Me.precio.TabIndex = 23
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(105, 187)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(202, 20)
        Me.codigo.TabIndex = 22
        '
        'atras
        '
        Me.atras.Location = New System.Drawing.Point(49, 333)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(50, 23)
        Me.atras.TabIndex = 32
        Me.atras.Text = "<<"
        Me.atras.UseVisualStyleBackColor = True
        '
        'adelante
        '
        Me.adelante.Location = New System.Drawing.Point(105, 333)
        Me.adelante.Name = "adelante"
        Me.adelante.Size = New System.Drawing.Size(50, 23)
        Me.adelante.TabIndex = 34
        Me.adelante.Text = ">>"
        Me.adelante.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(190, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = ":"
        '
        'segundos
        '
        Me.segundos.AutoSize = True
        Me.segundos.Location = New System.Drawing.Point(206, 108)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(19, 13)
        Me.segundos.TabIndex = 37
        Me.segundos.Text = "00"
        '
        'minutos
        '
        Me.minutos.AutoSize = True
        Me.minutos.Location = New System.Drawing.Point(165, 108)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(19, 13)
        Me.minutos.TabIndex = 36
        Me.minutos.Text = "00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "TIEMPO PERDIDO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(190, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = ":"
        '
        'segundos_totales
        '
        Me.segundos_totales.AutoSize = True
        Me.segundos_totales.Location = New System.Drawing.Point(206, 132)
        Me.segundos_totales.Name = "segundos_totales"
        Me.segundos_totales.Size = New System.Drawing.Size(19, 13)
        Me.segundos_totales.TabIndex = 41
        Me.segundos_totales.Text = "00"
        '
        'minutos_totales
        '
        Me.minutos_totales.AutoSize = True
        Me.minutos_totales.Location = New System.Drawing.Point(165, 132)
        Me.minutos_totales.Name = "minutos_totales"
        Me.minutos_totales.Size = New System.Drawing.Size(19, 13)
        Me.minutos_totales.TabIndex = 40
        Me.minutos_totales.Text = "00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(46, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "TIEMPO TOTAL"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 400)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.segundos_totales)
        Me.Controls.Add(Me.minutos_totales)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.segundos)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.adelante)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pedido)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.precio)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rechazados)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numero_pedidos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.valor_total)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents valor_total As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numero_pedidos As TextBox
    Friend WithEvents salir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents rechazados As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pedido As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents direccion As TextBox
    Friend WithEvents precio As TextBox
    Friend WithEvents codigo As TextBox
    Friend WithEvents atras As Button
    Friend WithEvents adelante As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents segundos As Label
    Friend WithEvents minutos As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents segundos_totales As Label
    Friend WithEvents minutos_totales As Label
    Friend WithEvents Label15 As Label
End Class

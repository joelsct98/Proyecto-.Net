<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bocadillos = New System.Windows.Forms.ComboBox()
        Me.extra1 = New System.Windows.Forms.ComboBox()
        Me.extra3 = New System.Windows.Forms.ComboBox()
        Me.extra2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.aceptado = New System.Windows.Forms.Button()
        Me.resumen = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.dni = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cliente
        '
        Me.cliente.Location = New System.Drawing.Point(90, 29)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(412, 20)
        Me.cliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CLIENTE"
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(90, 106)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(412, 20)
        Me.direccion.TabIndex = 2
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(90, 80)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(412, 20)
        Me.nombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DIRECCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NOMBRE"
        '
        'bocadillos
        '
        Me.bocadillos.FormattingEnabled = True
        Me.bocadillos.Items.AddRange(New Object() {"bocadillo tortilla", "bocadillo calamares", "bocadillo lomo", "bocadillo vegetariano", "bocadillo vegano", "bocadillo ternera"})
        Me.bocadillos.Location = New System.Drawing.Point(90, 215)
        Me.bocadillos.Name = "bocadillos"
        Me.bocadillos.Size = New System.Drawing.Size(412, 21)
        Me.bocadillos.TabIndex = 8
        '
        'extra1
        '
        Me.extra1.FormattingEnabled = True
        Me.extra1.Items.AddRange(New Object() {"extra salsa", "extra queso", "extra patatas"})
        Me.extra1.Location = New System.Drawing.Point(90, 264)
        Me.extra1.Name = "extra1"
        Me.extra1.Size = New System.Drawing.Size(412, 21)
        Me.extra1.TabIndex = 9
        '
        'extra3
        '
        Me.extra3.FormattingEnabled = True
        Me.extra3.Items.AddRange(New Object() {"extra salsa", "extra queso", "extra patatas"})
        Me.extra3.Location = New System.Drawing.Point(90, 318)
        Me.extra3.Name = "extra3"
        Me.extra3.Size = New System.Drawing.Size(412, 21)
        Me.extra3.TabIndex = 10
        '
        'extra2
        '
        Me.extra2.FormattingEnabled = True
        Me.extra2.Items.AddRange(New Object() {"extra salsa", "extra queso", "extra patatas"})
        Me.extra2.Location = New System.Drawing.Point(90, 291)
        Me.extra2.Name = "extra2"
        Me.extra2.Size = New System.Drawing.Size(412, 21)
        Me.extra2.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "EXTRAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "BOCADILLOS"
        '
        'aceptado
        '
        Me.aceptado.Location = New System.Drawing.Point(90, 369)
        Me.aceptado.Name = "aceptado"
        Me.aceptado.Size = New System.Drawing.Size(76, 36)
        Me.aceptado.TabIndex = 14
        Me.aceptado.Text = "ACEPTAR PEDIDO"
        Me.aceptado.UseVisualStyleBackColor = True
        '
        'resumen
        '
        Me.resumen.Location = New System.Drawing.Point(172, 369)
        Me.resumen.Name = "resumen"
        Me.resumen.Size = New System.Drawing.Size(84, 36)
        Me.resumen.TabIndex = 15
        Me.resumen.Text = "RESUMEN DEL DIA"
        Me.resumen.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(262, 369)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(71, 36)
        Me.salir.TabIndex = 16
        Me.salir.Text = "SALIR"
        Me.salir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "00:00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(381, 392)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(422, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(463, 392)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "00"
        '
        'Timer1
        '
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(406, 392)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(447, 392)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "TELEFONO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(58, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "DNI"
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(90, 132)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(412, 20)
        Me.telefono.TabIndex = 24
        '
        'dni
        '
        Me.dni.Location = New System.Drawing.Point(90, 158)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(412, 20)
        Me.dni.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(384, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "B"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 462)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.dni)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.resumen)
        Me.Controls.Add(Me.aceptado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.extra2)
        Me.Controls.Add(Me.extra3)
        Me.Controls.Add(Me.extra1)
        Me.Controls.Add(Me.bocadillos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.cliente)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents direccion As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bocadillos As ComboBox
    Friend WithEvents extra1 As ComboBox
    Friend WithEvents extra3 As ComboBox
    Friend WithEvents extra2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents aceptado As Button
    Friend WithEvents resumen As Button
    Friend WithEvents salir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents telefono As TextBox
    Friend WithEvents dni As TextBox
    Friend WithEvents Button1 As Button
End Class

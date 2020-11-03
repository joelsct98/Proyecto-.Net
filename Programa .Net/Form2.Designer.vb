<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pedido = New System.Windows.Forms.TextBox()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.segundos = New System.Windows.Forms.Label()
        Me.minutos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(86, 36)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(202, 20)
        Me.codigo.TabIndex = 0
        '
        'precio
        '
        Me.precio.Location = New System.Drawing.Point(86, 140)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(202, 20)
        Me.precio.TabIndex = 1
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(86, 88)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(202, 20)
        Me.direccion.TabIndex = 2
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(86, 62)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(202, 20)
        Me.nombre.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CODIGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PRECIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DIRECCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NOMBRE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PEDIDO"
        '
        'pedido
        '
        Me.pedido.Location = New System.Drawing.Point(86, 114)
        Me.pedido.Name = "pedido"
        Me.pedido.Size = New System.Drawing.Size(202, 20)
        Me.pedido.TabIndex = 8
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(86, 183)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(85, 37)
        Me.aceptar.TabIndex = 10
        Me.aceptar.Text = "ACEPTAR"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(203, 183)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(85, 37)
        Me.cancelar.TabIndex = 11
        Me.cancelar.Text = "CANCELAR"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "TIEMPO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(136, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = ":"
        '
        'segundos
        '
        Me.segundos.AutoSize = True
        Me.segundos.Location = New System.Drawing.Point(152, 238)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(19, 13)
        Me.segundos.TabIndex = 23
        Me.segundos.Text = "00"
        '
        'minutos
        '
        Me.minutos.AutoSize = True
        Me.minutos.Location = New System.Drawing.Point(111, 238)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(19, 13)
        Me.minutos.TabIndex = 22
        Me.minutos.Text = "00"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 295)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.segundos)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pedido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.precio)
        Me.Controls.Add(Me.codigo)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents codigo As TextBox
    Friend WithEvents precio As TextBox
    Friend WithEvents direccion As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pedido As TextBox
    Friend WithEvents aceptar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents segundos As Label
    Friend WithEvents minutos As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F6_Maths
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
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.TxtX = New System.Windows.Forms.TextBox()
        Me.TxtY = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblSuma = New System.Windows.Forms.Label()
        Me.LblResta = New System.Windows.Forms.Label()
        Me.LblDivision = New System.Windows.Forms.Label()
        Me.LblMulti = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(123, 118)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(145, 16)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Input two numbers"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtX
        '
        Me.TxtX.Location = New System.Drawing.Point(126, 169)
        Me.TxtX.Name = "TxtX"
        Me.TxtX.Size = New System.Drawing.Size(100, 22)
        Me.TxtX.TabIndex = 1
        '
        'TxtY
        '
        Me.TxtY.Location = New System.Drawing.Point(126, 208)
        Me.TxtY.Name = "TxtY"
        Me.TxtY.Size = New System.Drawing.Size(100, 22)
        Me.TxtY.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Operations"
        '
        'LblSuma
        '
        Me.LblSuma.AutoSize = True
        Me.LblSuma.Location = New System.Drawing.Point(490, 172)
        Me.LblSuma.Name = "LblSuma"
        Me.LblSuma.Size = New System.Drawing.Size(42, 16)
        Me.LblSuma.TabIndex = 6
        Me.LblSuma.Text = "Suma"
        Me.LblSuma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblResta
        '
        Me.LblResta.AutoSize = True
        Me.LblResta.Location = New System.Drawing.Point(489, 267)
        Me.LblResta.Name = "LblResta"
        Me.LblResta.Size = New System.Drawing.Size(43, 16)
        Me.LblResta.TabIndex = 7
        Me.LblResta.Text = "Resta"
        Me.LblResta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDivision
        '
        Me.LblDivision.AutoSize = True
        Me.LblDivision.Location = New System.Drawing.Point(611, 172)
        Me.LblDivision.Name = "LblDivision"
        Me.LblDivision.Size = New System.Drawing.Size(55, 16)
        Me.LblDivision.TabIndex = 8
        Me.LblDivision.Text = "Division"
        Me.LblDivision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMulti
        '
        Me.LblMulti.AutoSize = True
        Me.LblMulti.Location = New System.Drawing.Point(611, 267)
        Me.LblMulti.Name = "LblMulti"
        Me.LblMulti.Size = New System.Drawing.Size(88, 16)
        Me.LblMulti.TabIndex = 9
        Me.LblMulti.Text = "Multiplicacion"
        Me.LblMulti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(614, 40)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Mathematics with a pair of numbers"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'F6_Maths
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblMulti)
        Me.Controls.Add(Me.LblDivision)
        Me.Controls.Add(Me.LblResta)
        Me.Controls.Add(Me.LblSuma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtY)
        Me.Controls.Add(Me.TxtX)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "F6_Maths"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents TxtX As TextBox
    Friend WithEvents TxtY As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LblSuma As Label
    Friend WithEvents LblResta As Label
    Friend WithEvents LblDivision As Label
    Friend WithEvents LblMulti As Label
    Friend WithEvents Label2 As Label
End Class

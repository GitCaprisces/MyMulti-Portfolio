<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Primos
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
        Me.btnPrimo = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.LblPrimos = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPrimo
        '
        Me.btnPrimo.Location = New System.Drawing.Point(355, 121)
        Me.btnPrimo.Name = "btnPrimo"
        Me.btnPrimo.Size = New System.Drawing.Size(75, 23)
        Me.btnPrimo.TabIndex = 0
        Me.btnPrimo.Text = "&Aceptar"
        Me.btnPrimo.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(136, 121)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(163, 22)
        Me.txtNum.TabIndex = 1
        '
        'LblPrimos
        '
        Me.LblPrimos.AutoSize = True
        Me.LblPrimos.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrimos.Location = New System.Drawing.Point(131, 62)
        Me.LblPrimos.Name = "LblPrimos"
        Me.LblPrimos.Size = New System.Drawing.Size(299, 28)
        Me.LblPrimos.TabIndex = 2
        Me.LblPrimos.Text = "¿Es un numero primo?"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(239, 164)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 27)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Primos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 203)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.LblPrimos)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.btnPrimo)
        Me.Name = "Primos"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrimo As Button
    Friend WithEvents txtNum As TextBox
    Friend WithEvents LblPrimos As Label
    Friend WithEvents Button6 As Button
End Class

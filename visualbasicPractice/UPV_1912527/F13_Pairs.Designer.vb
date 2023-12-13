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
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCalcula = New System.Windows.Forms.Button()
        Me.txbLimite = New System.Windows.Forms.TextBox()
        Me.lstRes = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(140, 35)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(507, 34)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "Numeros pares hasta un limite"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese un numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(527, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Resultado:"
        '
        'BtnCalcula
        '
        Me.BtnCalcula.Location = New System.Drawing.Point(337, 143)
        Me.BtnCalcula.Name = "BtnCalcula"
        Me.BtnCalcula.Size = New System.Drawing.Size(83, 28)
        Me.BtnCalcula.TabIndex = 3
        Me.BtnCalcula.Text = "Enviar"
        Me.BtnCalcula.UseVisualStyleBackColor = True
        '
        'txbLimite
        '
        Me.txbLimite.Location = New System.Drawing.Point(254, 148)
        Me.txbLimite.Name = "txbLimite"
        Me.txbLimite.Size = New System.Drawing.Size(77, 22)
        Me.txbLimite.TabIndex = 4
        '
        'lstRes
        '
        Me.lstRes.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRes.FormattingEnabled = True
        Me.lstRes.ItemHeight = 22
        Me.lstRes.Location = New System.Drawing.Point(470, 171)
        Me.lstRes.Name = "lstRes"
        Me.lstRes.Size = New System.Drawing.Size(228, 136)
        Me.lstRes.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstRes)
        Me.Controls.Add(Me.txbLimite)
        Me.Controls.Add(Me.BtnCalcula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCalcula As Button
    Friend WithEvents txbLimite As TextBox
    Friend WithEvents lstRes As ListBox
End Class

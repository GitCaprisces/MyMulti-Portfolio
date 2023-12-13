<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Conteo
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
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.LblCuenta = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnInicio
        '
        Me.BtnInicio.Location = New System.Drawing.Point(126, 102)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(125, 43)
        Me.BtnInicio.TabIndex = 0
        Me.BtnInicio.Text = "Empezar"
        Me.BtnInicio.UseVisualStyleBackColor = True
        '
        'LblCuenta
        '
        Me.LblCuenta.AutoSize = True
        Me.LblCuenta.Font = New System.Drawing.Font("Showcard Gothic", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuenta.Location = New System.Drawing.Point(101, 148)
        Me.LblCuenta.Name = "LblCuenta"
        Me.LblCuenta.Size = New System.Drawing.Size(186, 149)
        Me.LblCuenta.TabIndex = 1
        Me.LblCuenta.Text = "10"
        Me.LblCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(41, 33)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(305, 34)
        Me.LblTitulo.TabIndex = 2
        Me.LblTitulo.Text = "Cuenta Regresiva!"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(146, 364)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 27)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Conteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 403)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.LblCuenta)
        Me.Controls.Add(Me.BtnInicio)
        Me.Name = "Conteo"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnInicio As Button
    Friend WithEvents LblCuenta As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents Button6 As Button
End Class

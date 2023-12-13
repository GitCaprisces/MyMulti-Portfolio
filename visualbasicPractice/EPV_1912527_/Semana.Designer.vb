<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Semana
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
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.LblDia = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.btnDia = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNum
        '
        Me.TxtNum.Location = New System.Drawing.Point(155, 140)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(218, 22)
        Me.TxtNum.TabIndex = 0
        '
        'LblDia
        '
        Me.LblDia.AutoSize = True
        Me.LblDia.Location = New System.Drawing.Point(174, 91)
        Me.LblDia.Name = "LblDia"
        Me.LblDia.Size = New System.Drawing.Size(0, 16)
        Me.LblDia.TabIndex = 1
        Me.LblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(86, 37)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(368, 28)
        Me.LblTitulo.TabIndex = 2
        Me.LblTitulo.Text = "¿Que dia de la semana es..?"
        '
        'btnDia
        '
        Me.btnDia.Location = New System.Drawing.Point(227, 195)
        Me.btnDia.Name = "btnDia"
        Me.btnDia.Size = New System.Drawing.Size(75, 23)
        Me.btnDia.TabIndex = 3
        Me.btnDia.Text = "Aceptar"
        Me.btnDia.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(218, 364)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 27)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Semana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 403)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnDia)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.LblDia)
        Me.Controls.Add(Me.TxtNum)
        Me.Name = "Semana"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNum As TextBox
    Friend WithEvents LblDia As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents btnDia As Button
    Friend WithEvents Button6 As Button
End Class

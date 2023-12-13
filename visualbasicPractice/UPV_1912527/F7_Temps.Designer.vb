<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TxtTemp = New System.Windows.Forms.TextBox()
        Me.LblFahr = New System.Windows.Forms.Label()
        Me.LblCelsius = New System.Windows.Forms.Label()
        Me.LblResultado = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(76, 29)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(352, 34)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Celsius to Fahrenheit"
        '
        'TxtTemp
        '
        Me.TxtTemp.Location = New System.Drawing.Point(255, 101)
        Me.TxtTemp.Name = "TxtTemp"
        Me.TxtTemp.Size = New System.Drawing.Size(100, 22)
        Me.TxtTemp.TabIndex = 1
        '
        'LblFahr
        '
        Me.LblFahr.AutoSize = True
        Me.LblFahr.Location = New System.Drawing.Point(46, 161)
        Me.LblFahr.Name = "LblFahr"
        Me.LblFahr.Size = New System.Drawing.Size(187, 16)
        Me.LblFahr.TabIndex = 2
        Me.LblFahr.Text = "Temperature in Fahrenheit (°F)"
        '
        'LblCelsius
        '
        Me.LblCelsius.AutoSize = True
        Me.LblCelsius.Location = New System.Drawing.Point(64, 107)
        Me.LblCelsius.Name = "LblCelsius"
        Me.LblCelsius.Size = New System.Drawing.Size(169, 16)
        Me.LblCelsius.TabIndex = 3
        Me.LblCelsius.Text = "Temperature in Celsius (°C)"
        '
        'LblResultado
        '
        Me.LblResultado.AutoSize = True
        Me.LblResultado.Location = New System.Drawing.Point(255, 161)
        Me.LblResultado.Name = "LblResultado"
        Me.LblResultado.Size = New System.Drawing.Size(0, 16)
        Me.LblResultado.TabIndex = 4
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(370, 134)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(74, 22)
        Me.BtnConvert.TabIndex = 5
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 293)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.LblResultado)
        Me.Controls.Add(Me.LblCelsius)
        Me.Controls.Add(Me.LblFahr)
        Me.Controls.Add(Me.TxtTemp)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents TxtTemp As TextBox
    Friend WithEvents LblFahr As Label
    Friend WithEvents LblCelsius As Label
    Friend WithEvents LblResultado As Label
    Friend WithEvents BtnConvert As Button
End Class

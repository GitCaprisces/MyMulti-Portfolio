<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calificacion
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.TxtCalificacion = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblEstudiante = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(49, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(357, 28)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Clasificador de calificación"
        '
        'TxtCalificacion
        '
        Me.TxtCalificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCalificacion.Location = New System.Drawing.Point(89, 86)
        Me.TxtCalificacion.Name = "TxtCalificacion"
        Me.TxtCalificacion.Size = New System.Drawing.Size(183, 22)
        Me.TxtCalificacion.TabIndex = 6
        Me.TxtCalificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(288, 85)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "&Aceptar"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblEstudiante
        '
        Me.lblEstudiante.AutoSize = True
        Me.lblEstudiante.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstudiante.Location = New System.Drawing.Point(91, 164)
        Me.lblEstudiante.Name = "lblEstudiante"
        Me.lblEstudiante.Size = New System.Drawing.Size(130, 20)
        Me.lblEstudiante.TabIndex = 8
        Me.lblEstudiante.Text = "El estudiante:"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(227, 164)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 20)
        Me.lblResultado.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Calificación:"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(179, 291)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 27)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Calificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 330)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblEstudiante)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TxtCalificacion)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Calificacion"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTitulo As Label
    Private WithEvents TxtCalificacion As TextBox
    Private WithEvents btnOK As Button
    Private WithEvents lblEstudiante As Label
    Private WithEvents lblResultado As Label
    Private WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
End Class

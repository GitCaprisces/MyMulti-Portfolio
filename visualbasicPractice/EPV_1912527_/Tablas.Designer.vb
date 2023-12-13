<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tablas
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
        Me.LblCrea = New System.Windows.Forms.Label()
        Me.BtnMulti = New System.Windows.Forms.Button()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.LblTablas = New System.Windows.Forms.Label()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblCrea
        '
        Me.LblCrea.AutoSize = True
        Me.LblCrea.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCrea.Location = New System.Drawing.Point(103, 98)
        Me.LblCrea.Name = "LblCrea"
        Me.LblCrea.Size = New System.Drawing.Size(187, 25)
        Me.LblCrea.TabIndex = 0
        Me.LblCrea.Text = "Crea la tabla del:"
        '
        'BtnMulti
        '
        Me.BtnMulti.Location = New System.Drawing.Point(210, 143)
        Me.BtnMulti.Name = "BtnMulti"
        Me.BtnMulti.Size = New System.Drawing.Size(90, 38)
        Me.BtnMulti.TabIndex = 1
        Me.BtnMulti.Text = "Empezar"
        Me.BtnMulti.UseVisualStyleBackColor = True
        '
        'TxtNum
        '
        Me.TxtNum.Location = New System.Drawing.Point(296, 98)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(91, 22)
        Me.TxtNum.TabIndex = 2
        '
        'LblTablas
        '
        Me.LblTablas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTablas.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTablas.Location = New System.Drawing.Point(108, 184)
        Me.LblTablas.Name = "LblTablas"
        Me.LblTablas.Size = New System.Drawing.Size(291, 141)
        Me.LblTablas.TabIndex = 3
        Me.LblTablas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbltitulo
        '
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.Location = New System.Drawing.Point(186, 25)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(119, 34)
        Me.Lbltitulo.TabIndex = 4
        Me.Lbltitulo.Text = "Tablas"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(210, 364)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 27)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Tablas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 403)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Lbltitulo)
        Me.Controls.Add(Me.LblTablas)
        Me.Controls.Add(Me.TxtNum)
        Me.Controls.Add(Me.BtnMulti)
        Me.Controls.Add(Me.LblCrea)
        Me.Name = "Tablas"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCrea As Label
    Friend WithEvents BtnMulti As Button
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents LblTablas As Label
    Friend WithEvents Lbltitulo As Label
    Friend WithEvents Button6 As Button
End Class

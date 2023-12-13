<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class intro
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
        Me.comboForms = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'comboForms
        '
        Me.comboForms.FormattingEnabled = True
        Me.comboForms.Location = New System.Drawing.Point(398, 193)
        Me.comboForms.Name = "comboForms"
        Me.comboForms.Size = New System.Drawing.Size(121, 24)
        Me.comboForms.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.comboForms)
        Me.Name = "intro"
        Me.Text = "Form7"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents comboForms As ComboBox
    Friend WithEvents Button1 As Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnota1 = New System.Windows.Forms.TextBox()
        Me.txtnota2 = New System.Windows.Forms.TextBox()
        Me.txtnota3 = New System.Windows.Forms.TextBox()
        Me.txtnota4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btcalcular = New System.Windows.Forms.Button()
        Me.txtnotafinal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nota 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nota 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nota 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nota 4"
        '
        'txtnota1
        '
        Me.txtnota1.Location = New System.Drawing.Point(94, 40)
        Me.txtnota1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnota1.Name = "txtnota1"
        Me.txtnota1.Size = New System.Drawing.Size(74, 23)
        Me.txtnota1.TabIndex = 4
        '
        'txtnota2
        '
        Me.txtnota2.Location = New System.Drawing.Point(94, 75)
        Me.txtnota2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnota2.Name = "txtnota2"
        Me.txtnota2.Size = New System.Drawing.Size(74, 23)
        Me.txtnota2.TabIndex = 5
        '
        'txtnota3
        '
        Me.txtnota3.Location = New System.Drawing.Point(94, 110)
        Me.txtnota3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnota3.Name = "txtnota3"
        Me.txtnota3.Size = New System.Drawing.Size(74, 23)
        Me.txtnota3.TabIndex = 6
        '
        'txtnota4
        '
        Me.txtnota4.Location = New System.Drawing.Point(94, 142)
        Me.txtnota4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnota4.Name = "txtnota4"
        Me.txtnota4.Size = New System.Drawing.Size(74, 23)
        Me.txtnota4.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Promedio de Notas"
        '
        'Btcalcular
        '
        Me.Btcalcular.Location = New System.Drawing.Point(81, 174)
        Me.Btcalcular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btcalcular.Name = "Btcalcular"
        Me.Btcalcular.Size = New System.Drawing.Size(98, 48)
        Me.Btcalcular.TabIndex = 10
        Me.Btcalcular.Text = "Calcular"
        Me.Btcalcular.UseVisualStyleBackColor = True
        '
        'txtnotafinal
        '
        Me.txtnotafinal.Location = New System.Drawing.Point(1, 254)
        Me.txtnotafinal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnotafinal.Multiline = True
        Me.txtnotafinal.Name = "txtnotafinal"
        Me.txtnotafinal.Size = New System.Drawing.Size(218, 90)
        Me.txtnotafinal.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nota final "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 279)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 349)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtnotafinal)
        Me.Controls.Add(Me.Btcalcular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnota4)
        Me.Controls.Add(Me.txtnota3)
        Me.Controls.Add(Me.txtnota2)
        Me.Controls.Add(Me.txtnota1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnota1 As TextBox
    Friend WithEvents txtnota2 As TextBox
    Friend WithEvents txtnota3 As TextBox
    Friend WithEvents txtnota4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Btcalcular As Button
    Friend WithEvents txtnotafinal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class

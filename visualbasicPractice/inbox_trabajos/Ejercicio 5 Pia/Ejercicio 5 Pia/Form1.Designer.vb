<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtnota1 = New TextBox()
        txtnota2 = New TextBox()
        txtnota3 = New TextBox()
        txtnota4 = New TextBox()
        Label5 = New Label()
        Btcalcular = New Button()
        txtnotafinal = New TextBox()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nota 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nota 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 2
        Label3.Text = "Nota 3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 3
        Label4.Text = "Nota 4"
        ' 
        ' txtnota1
        ' 
        txtnota1.Location = New Point(107, 53)
        txtnota1.Name = "txtnota1"
        txtnota1.Size = New Size(84, 27)
        txtnota1.TabIndex = 4
        ' 
        ' txtnota2
        ' 
        txtnota2.Location = New Point(107, 100)
        txtnota2.Name = "txtnota2"
        txtnota2.Size = New Size(84, 27)
        txtnota2.TabIndex = 5
        ' 
        ' txtnota3
        ' 
        txtnota3.Location = New Point(107, 147)
        txtnota3.Name = "txtnota3"
        txtnota3.Size = New Size(84, 27)
        txtnota3.TabIndex = 6
        ' 
        ' txtnota4
        ' 
        txtnota4.Location = New Point(107, 189)
        txtnota4.Name = "txtnota4"
        txtnota4.Size = New Size(84, 27)
        txtnota4.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 20)
        Label5.TabIndex = 8
        Label5.Text = "Promedio de Notas"
        ' 
        ' Btcalcular
        ' 
        Btcalcular.Location = New Point(93, 232)
        Btcalcular.Name = "Btcalcular"
        Btcalcular.Size = New Size(112, 64)
        Btcalcular.TabIndex = 10
        Btcalcular.Text = "Calcular"
        Btcalcular.UseVisualStyleBackColor = True
        ' 
        ' txtnotafinal
        ' 
        txtnotafinal.Location = New Point(1, 339)
        txtnotafinal.Multiline = True
        txtnotafinal.Name = "txtnotafinal"
        txtnotafinal.Size = New Size(248, 118)
        txtnotafinal.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 307)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 20)
        Label7.TabIndex = 14
        Label7.Text = "Nota final "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(288, 465)
        Controls.Add(Label7)
        Controls.Add(txtnotafinal)
        Controls.Add(Btcalcular)
        Controls.Add(Label5)
        Controls.Add(txtnota4)
        Controls.Add(txtnota3)
        Controls.Add(txtnota2)
        Controls.Add(txtnota1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
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
End Class

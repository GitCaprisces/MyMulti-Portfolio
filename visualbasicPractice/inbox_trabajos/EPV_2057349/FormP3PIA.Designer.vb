<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormP3PIA
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
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpre1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpre3 = New System.Windows.Forms.TextBox()
        Me.txtpre2 = New System.Windows.Forms.TextBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncalcular.Font = New System.Drawing.Font("Swis721 Ex BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.Location = New System.Drawing.Point(81, 254)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(107, 51)
        Me.btncalcular.TabIndex = 0
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PanRoman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Problema #3"
        '
        'txtpre1
        '
        Me.txtpre1.Location = New System.Drawing.Point(557, 128)
        Me.txtpre1.Name = "txtpre1"
        Me.txtpre1.Size = New System.Drawing.Size(100, 20)
        Me.txtpre1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PanRoman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.Location = New System.Drawing.Point(289, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Precio promedio del producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(488, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Introduzca el precio del producto en el establecimiento número 1, en euros: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(484, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Introduzca el precio del producto en el establecimiento número 3, en euros:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(484, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Introduzca el precio del producto en el establecimiento número 2, en euros:"
        '
        'txtpre3
        '
        Me.txtpre3.Location = New System.Drawing.Point(557, 194)
        Me.txtpre3.Name = "txtpre3"
        Me.txtpre3.Size = New System.Drawing.Size(100, 20)
        Me.txtpre3.TabIndex = 7
        '
        'txtpre2
        '
        Me.txtpre2.Location = New System.Drawing.Point(557, 162)
        Me.txtpre2.Name = "txtpre2"
        Me.txtpre2.Size = New System.Drawing.Size(100, 20)
        Me.txtpre2.TabIndex = 8
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlimpiar.Font = New System.Drawing.Font("Swis721 Ex BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(81, 311)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(107, 51)
        Me.btnlimpiar.TabIndex = 9
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnregresar
        '
        Me.btnregresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnregresar.Font = New System.Drawing.Font("Swis721 Ex BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregresar.Location = New System.Drawing.Point(81, 368)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(107, 51)
        Me.btnregresar.TabIndex = 10
        Me.btnregresar.Text = "Regresar"
        Me.btnregresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EPV_2057349.My.Resources.Resources.euro_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(247, 167)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(481, 252)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'FormP3PIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.txtpre2)
        Me.Controls.Add(Me.txtpre3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpre1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormP3PIA"
        Me.Text = "FormPIA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpre1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpre3 As TextBox
    Friend WithEvents txtpre2 As TextBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnregresar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

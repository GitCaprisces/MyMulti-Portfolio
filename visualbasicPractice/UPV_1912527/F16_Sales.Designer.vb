<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F16_Sales
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
        Me.btnCalcula = New System.Windows.Forms.Button()
        Me.lstCompras = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txbProducto = New System.Windows.Forms.TextBox()
        Me.txbCantidad = New System.Windows.Forms.TextBox()
        Me.txbUnitto = New System.Windows.Forms.TextBox()
        Me.txbVTotal = New System.Windows.Forms.TextBox()
        Me.txbIVA = New System.Windows.Forms.TextBox()
        Me.txbTOTAL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcula
        '
        Me.btnCalcula.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcula.Location = New System.Drawing.Point(100, 352)
        Me.btnCalcula.Name = "btnCalcula"
        Me.btnCalcula.Size = New System.Drawing.Size(390, 40)
        Me.btnCalcula.TabIndex = 0
        Me.btnCalcula.Text = "CALCULAR"
        Me.btnCalcula.UseVisualStyleBackColor = True
        '
        'lstCompras
        '
        Me.lstCompras.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCompras.FormattingEnabled = True
        Me.lstCompras.ItemHeight = 20
        Me.lstCompras.Location = New System.Drawing.Point(279, 87)
        Me.lstCompras.Name = "lstCompras"
        Me.lstCompras.Size = New System.Drawing.Size(293, 244)
        Me.lstCompras.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VENTAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(234, 398)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 40)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "SALIR"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(100, 398)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 40)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "LIMPIAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(365, 398)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(125, 40)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "SELECCIONAR"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txbProducto
        '
        Me.txbProducto.Location = New System.Drawing.Point(168, 119)
        Me.txbProducto.Name = "txbProducto"
        Me.txbProducto.Size = New System.Drawing.Size(100, 22)
        Me.txbProducto.TabIndex = 11
        '
        'txbCantidad
        '
        Me.txbCantidad.Location = New System.Drawing.Point(168, 149)
        Me.txbCantidad.Name = "txbCantidad"
        Me.txbCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txbCantidad.TabIndex = 12
        '
        'txbUnitto
        '
        Me.txbUnitto.Location = New System.Drawing.Point(168, 177)
        Me.txbUnitto.Name = "txbUnitto"
        Me.txbUnitto.Size = New System.Drawing.Size(100, 22)
        Me.txbUnitto.TabIndex = 13
        '
        'txbVTotal
        '
        Me.txbVTotal.Location = New System.Drawing.Point(168, 238)
        Me.txbVTotal.Name = "txbVTotal"
        Me.txbVTotal.Size = New System.Drawing.Size(100, 22)
        Me.txbVTotal.TabIndex = 14
        '
        'txbIVA
        '
        Me.txbIVA.Location = New System.Drawing.Point(168, 271)
        Me.txbIVA.Name = "txbIVA"
        Me.txbIVA.Size = New System.Drawing.Size(100, 22)
        Me.txbIVA.TabIndex = 15
        '
        'txbTOTAL
        '
        Me.txbTOTAL.Location = New System.Drawing.Point(168, 302)
        Me.txbTOTAL.Name = "txbTOTAL"
        Me.txbTOTAL.Size = New System.Drawing.Size(100, 22)
        Me.txbTOTAL.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 22)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Cantidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 22)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Valor unitario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 22)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Venta Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 22)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "IVA 16%:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 22)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "TOTAL a pagar:"
        '
        'F16_Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbTOTAL)
        Me.Controls.Add(Me.txbIVA)
        Me.Controls.Add(Me.txbVTotal)
        Me.Controls.Add(Me.txbUnitto)
        Me.Controls.Add(Me.txbCantidad)
        Me.Controls.Add(Me.txbProducto)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstCompras)
        Me.Controls.Add(Me.btnCalcula)
        Me.Name = "F16_Sales"
        Me.Text = "F16_Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcula As Button
    Friend WithEvents lstCompras As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txbProducto As TextBox
    Friend WithEvents txbCantidad As TextBox
    Friend WithEvents txbUnitto As TextBox
    Friend WithEvents txbVTotal As TextBox
    Friend WithEvents txbIVA As TextBox
    Friend WithEvents txbTOTAL As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

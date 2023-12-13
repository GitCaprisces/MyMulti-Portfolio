Public Class Precio
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim precio1 As Single = txtpre1.Text
        Dim precio2 As Single = txtpre2.Text
        Dim precio3 As Single = txtpre3.Text
        Dim x As Single
        x = (precio1 + precio2 + precio3) / 3
        MessageBox.Show("El precio promedio del producto es de " & x & " euros")
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtpre2.Clear()
        txtpre1.Clear()
        txtpre3.Clear()



    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Me.Hide()
    End Sub

    Private Sub Precio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
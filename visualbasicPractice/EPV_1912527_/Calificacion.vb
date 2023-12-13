Public Class Calificacion
    Private Sub TxtCalificacion_TextChanged(sender As Object, e As EventArgs) Handles TxtCalificacion.TextChanged

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If TxtCalificacion.Text >= 80 Then
            lblResultado.Text = "Ha aprobado."

        ElseIf TxtCalificacion.Text < 80 Then
            lblResultado.Text = "Ha reprobado."


        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()

    End Sub
End Class

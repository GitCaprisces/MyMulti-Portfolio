Public Class F9_chain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena As String = TextBox1.Text
        Dim letra As Char = txtLetra.text
        Dim contador As Integer = 0

        For Each c As Char In cadena
            If c = letra Then
                contador += 1
            End If
        Next

        MessageBox.Show("a letra " & letra & " aparece " & contador & " veces en la cadena de texto.")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
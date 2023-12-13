Public Class F8_List
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Contains(",") Then
            Dim numeros As String() = TextBox1.Text.Split(",")
            Dim suma As Integer = 0

            For Each num As String In numeros
                suma += CInt(num)
            Next

            MessageBox.Show("La suma de los números es: " & suma)
        Else
            MessageBox.Show("El botón no contiene números separados por comas.")
        End If
    End Sub
End Class

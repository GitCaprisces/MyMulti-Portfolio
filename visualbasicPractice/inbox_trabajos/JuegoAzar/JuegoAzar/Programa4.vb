Public Class Programa4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Generar números aleatorios para los tres carretes
        Dim carrete1 As Integer = GenerarNumeroAleatorio()
        Dim carrete2 As Integer = GenerarNumeroAleatorio()
        Dim carrete3 As Integer = GenerarNumeroAleatorio()

        ' Mostrar los resultados en las etiquetas correspondientes
        Label6.Text = carrete1.ToString()
        Label7.Text = carrete2.ToString()
        Label8.Text = carrete3.ToString()

        ' Comprobar si los tres números son iguales para determinar el resultado del juego
        If carrete1 = carrete2 AndAlso carrete2 = carrete3 Then
            MessageBox.Show("¡Has ganado!", "Resultado")
        Else
            MessageBox.Show("Lo siento, has perdido. Inténtalo de nuevo.", "Resultado")
        End If
    End Sub

    Private Function GenerarNumeroAleatorio() As Integer
        ' Generar un número aleatorio entre 1 y 9
        Dim rnd As New Random()
        Return rnd.Next(1, 10)
    End Function


End Class
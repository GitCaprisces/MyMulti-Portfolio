Public Class Promedio
    Private Sub Btcalcular_Click(sender As Object, e As EventArgs) Handles Btcalcular.Click
        ' Obtener las notas ingresadas
        Dim nota1 As Double = Double.Parse(txtnota1.Text)
        Dim nota2 As Double = Double.Parse(txtnota2.Text)
        Dim nota3 As Double = Double.Parse(txtnota3.Text)
        Dim nota4 As Double = Double.Parse(txtnota4.Text)

        ' Calcular el promedio
        Dim promedio As Double = (nota1 + nota2 + nota3 + nota4) / 4

        ' Mostrar el resultado en la etiqueta correspondiente
        txtnotafinal.Text = "El promedio es: " & promedio.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class





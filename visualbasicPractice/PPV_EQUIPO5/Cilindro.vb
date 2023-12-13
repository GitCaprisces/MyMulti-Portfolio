Public Class Cilindro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim D As Integer = Decimal.Parse(TextBox1.Text)
        Dim H As Integer = Integer.Parse(TextBox2.Text)
        Dim R As Decimal = D / 2, Pi = 3.1416
        Dim Volumen As Decimal = Pi * (R * R) * H
        ListBox1.Items.Add(Volumen & " Metros cubicos")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Ejercicio2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
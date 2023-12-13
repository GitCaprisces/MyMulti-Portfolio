Public Class Form1
    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        Dim Celsius As Double
        Dim Fahr As String

        Celsius = Convert.ToDouble(TxtTemp.Text)
        Fahr = ((Celsius * 1.8) + 32)

        LblResultado.Text = Fahr + "°F"
    End Sub

End Class
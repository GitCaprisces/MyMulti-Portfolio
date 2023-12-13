Public Class Maths
    Dim SUM As String
    Dim RES As String
    Dim DIV As String
    Dim MULT As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double
        Dim num2 As Double
        num1 = Convert.ToDouble(TxtX.Text)
        num2 = Convert.ToDouble(TxtY.Text)

        SUM = num1 + num2
        RES = num1 - num2
        DIV = num1 / num2
        MULT = num1 * num2

        LblSuma.Text = TxtX.Text + " + " + TxtY.Text + " = " + SUM
        LblResta.Text = TxtX.Text + " - " + TxtY.Text + " = " + RES
        LblDivision.Text = TxtX.Text + " / " + TxtY.Text + " = " + DIV
        LblMulti.Text = TxtX.Text + " * " + TxtY.Text + " = " + MULT

    End Sub
End Class

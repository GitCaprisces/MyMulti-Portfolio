Public Class Semana
    Dim Disem As String
    Private Sub TxtNum_TextChanged(sender As Object, e As EventArgs) Handles TxtNum.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDia.Click

        If TxtNum.Text = 1 Then
            Disem = "Lunes"
        ElseIf TxtNum.Text = 2 Then
            Disem = "Martes"
        ElseIf TxtNum.Text = 3 Then
            Disem = "Miercoles"
        ElseIf TxtNum.Text = 4 Then
            Disem = "Jueves"
        ElseIf TxtNum.Text = 5 Then
            Disem = "Viernes"
        ElseIf TxtNum.Text = 6 Then
            Disem = "Sabado"
        ElseIf TxtNum.Text = 7 Then
            Disem = "Domingo"
        End If

        LblDia.Text = "Que tengan un feliz " & Disem & "! "

    End Sub

    Private Sub LblDia_Click(sender As Object, e As EventArgs) Handles LblDia.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()

    End Sub
End Class
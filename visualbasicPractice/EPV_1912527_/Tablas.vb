Public Class Tablas
    Dim numbr As Integer = 0
    Private Sub BtnMulti_Click(sender As Object, e As EventArgs) Handles BtnMulti.Click

        numbr = TxtNum.Text

        LblTablas.Text = numbr * 1 & ", " & numbr * 2 & ", " & numbr * 3 & ", " & numbr * 4 & ", " & numbr * 5 & ", " & numbr * 6 & ", " & numbr * 7 & ", " & numbr * 8 & ", " & numbr * 9 & ", " & numbr * 10
    End Sub

    Private Sub TxtNum_TextChanged(sender As Object, e As EventArgs) Handles TxtNum.TextChanged
        If TxtNum.Text = " " Then
            numbr = 0
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()

    End Sub

    Private Sub LblTablas_Click(sender As Object, e As EventArgs) Handles LblTablas.Click

    End Sub

    Private Sub Tablas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
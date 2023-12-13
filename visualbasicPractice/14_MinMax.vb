Public Class Form3
    Private Sub btnCalcula_Click(sender As Object, e As EventArgs) Handles btnCalcula.Click
        Dim nums As String() = txbList.Text.Split(",")

        Dim max As Integer = Integer.MinValue
        Dim min As Integer = Integer.MaxValue
        For Each num As String In nums
            Dim numInt As Integer = Integer.Parse(num)
            If numInt > max Then
                max = numInt
            End If
            If numInt < min Then
                min = numInt
            End If
        Next

        lblMax.Text = max
        lblMin.Text = min
    End Sub
End Class
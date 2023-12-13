Public Class Form2
    Private Sub BtnCalcula_Click(sender As Object, e As EventArgs) Handles BtnCalcula.Click
        lstRes.Items.Clear()
        Dim lim As Integer = Integer.Parse(txbLimite.Text)
        For i As Integer = 1 To lim - 1
            If i Mod 2 = 0 Then
                lstRes.Items.Add(i)
            End If
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
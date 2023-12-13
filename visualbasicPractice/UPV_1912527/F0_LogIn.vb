Public Class F0_LogIn
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url As String = "https://www.youtube.com/watch?v=fC7oUOUEEi4"
        Process.Start(url)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lobby As New intro
        If TxtUser.Text = "progvis" And TxtPwd.Text = "1912527" Then
            lobby.Show()
        End If
    End Sub
End Class
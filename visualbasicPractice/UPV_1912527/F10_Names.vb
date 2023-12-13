Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lstNombres.Items.Add(TextBox1.Text)
        lstNombres.Sorted = True
        TextBox1.Clear()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
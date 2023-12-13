Public Class Form11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim num As Integer = CInt(TextBox1.Text)
        For i As Integer = 2 To num
            Dim esPrimo As Boolean = True
            For j As Integer = 2 To i - 1
                If i Mod j = 0 Then
                    esPrimo = False
                    Exit For
                End If
            Next
            If esPrimo Then
                ListBox1.Items.Add(i)
            End If
        Next
    End Sub
End Class
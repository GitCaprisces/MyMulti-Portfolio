Public Class Primos
    Dim num1 As Integer
    Dim num2 As Integer
    Dim check As Boolean = True

    Private Sub TxtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged

    End Sub

    Private Sub BtnPrimo_Click(sender As Object, e As EventArgs) Handles btnPrimo.Click
        num1 = txtNum.Text

        For num2 = 2 To (num1 - 1)
            If num1 Mod num2 = 0 Then
                check = False
                Exit For
            End If
        Next num2
        If check Then
            MsgBox(num1 & " es un numero primo.")
            txtNum.Focus()
            check = True
        Else
            MsgBox(num1 & " no es un numero primo.")
            txtNum.Focus()
            check = True
        End If
    End Sub

    Private Sub Primos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()

    End Sub
End Class
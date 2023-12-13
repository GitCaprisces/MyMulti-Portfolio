Imports System.ComponentModel

Public Class Form4


    Private Sub btnCalcula_Click(sender As Object, e As EventArgs) Handles btnCalcula.Click
        lstRes.Items.Clear()
        Dim lim As Integer = Integer.Parse(txbLimite.Text)
        For i As Integer = 1 To lim - 1
            lstRes.Items.Add(i)
        Next
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
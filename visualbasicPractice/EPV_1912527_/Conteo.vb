Imports VB = Microsoft.VisualBasic
Public Class Conteo
    Dim count As Integer
    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        count = 10

        While count >= 0
            wait(0.9)
            LblCuenta.Text = count
            count -= 1

            Continue While
        End While

        LblTitulo.Text = "Adios!"
        wait(2)
        Close()
    End Sub

    Private Sub LblCuenta_Click(sender As Object, e As EventArgs) Handles LblCuenta.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()

    End Sub

    Private Sub Conteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
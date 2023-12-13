Public Class Form10

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fechaActual As Date = Date.Now.ToLongDateString
        lblFechach.Text = fechaActual

        lblDia.Text = fechaActual.Day.ToString()
        lblMes.Text = fechaActual.Month.ToString()
        lblAño.Text = fechaActual.Year.ToString()
    End Sub
End Class
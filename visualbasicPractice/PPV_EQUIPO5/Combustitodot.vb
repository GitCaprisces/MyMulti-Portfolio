Public Class Combustitodot
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        ' Definición de Vehiculos
        Dim Turismos As Integer = 32
        Dim Todoterrenos As Integer = 11

        ' Definición de capacidad del depósito
        Dim CapTurismos As Integer = 40
        Dim CapTodoterrenos As Integer = 65

        ' Cálculo de necesidades de combustible
        Dim NecesidadesCom As Integer = Turismos * CapTurismos + Todoterrenos * CapTodoterrenos
        ' Mostrar el resultado en TextBox
        TxtResultado.Text = "Las necesidades de combustible son: " & NecesidadesCom.ToString() & " litros"
    End Sub

    Private Sub Combustitodot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

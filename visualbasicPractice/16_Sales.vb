



Public Class Form5
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim nombre As String = CStr(txbProducto.Text)
        Dim precio As Decimal = CDec(txbUnitto.Text)
        Dim cantidad As Integer = CInt(txbCantidad.Text)

        Dim nuevoProducto As New Producto(nombre, precio, cantidad)

        lstCompras.Items.Add(nuevoProducto)

        txbProducto.Text = ""
        txbUnitto.Text = ""
        txbCantidad.Text = ""

        'Mostrar un mensaje de confirmación
        MessageBox.Show("Producto agregado correctamente.")
    End Sub
    Private _productos As New List(Of Producto)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim producto1 As New Producto("Papa", 10.0, 1)
        Dim producto2 As New Producto("Tomates", 20.0, 2)
        Dim producto3 As New Producto("Aguas", 30.0, 3)
        _productos.Add(producto1)
        _productos.Add(producto2)
        _productos.Add(producto3)

        ' Mostrar los productos en el ListBox
        For Each producto As Producto In _productos
            lstCompras.Items.Add(producto.Nombre)
        Next
    End Sub

    Private Sub lstCompras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCompras.SelectedIndexChanged
        ' Obtener el producto seleccionado
        Dim nombreProducto As String = lstCompras.SelectedItem.ToString()
        Dim productoSeleccionado As Producto = _productos.Find(Function(p) p.Nombre = nombreProducto)

        ' Mostrar la información del producto en los controles TextBox
        txbProducto.Text = productoSeleccionado.Nombre
        txbUnitto.Text = productoSeleccionado.Precio.ToString()
        txbCantidad.Text = productoSeleccionado.Cantidad.ToString()
    End Sub

    Private Sub btnCalcula_Click(sender As Object, e As EventArgs) Handles btnCalcula.Click
        txbVTotal.Text = CInt(txbCantidad.Text) * CDec(txbUnitto.Text)
        txbIVA.Text = txbVTotal.Text * 0.16
        txbTOTAL.Text = txbVTotal.Text + txbIVA.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txbProducto.Text = ""
        txbUnitto.Text = ""
        txbCantidad.Text = ""
        txbVTotal.Text = ""
        txbIVA.Text = ""
        txbTOTAL.Text = ""
    End Sub
End Class
Public Class Producto
    Public Property Nombre As String
    Public Property Precio As Decimal
    Public Property Cantidad As Integer
    Public Sub New(nombre As String, precio As Decimal, cantidad As Integer)
        Me.Nombre = nombre
        Me.Precio = precio
        Me.Cantidad = cantidad
    End Sub
End Class
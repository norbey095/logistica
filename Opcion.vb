Public Class Opcion
    Private Sub Btnclientes_Click(sender As Object, e As EventArgs) Handles Btnclientes.Click
        Dim cliente As New Clientes
        cliente.Show()
        Me.Hide()
    End Sub

    Private Sub Btnventas_Click(sender As Object, e As EventArgs) Handles Btnventas.Click
        Dim ventas As New Venta
        ventas.Show()
        Me.Hide()
    End Sub

    Private Sub Btnfacturacion_Click(sender As Object, e As EventArgs) Handles Btnfacturacion.Click
        Dim facturacion As New Facturacion
        facturacion.Show()
        Me.Hide()
    End Sub

    Private Sub Btnnomina_Click(sender As Object, e As EventArgs) Handles Btnnomina.Click
        Dim nomina As New Nomina
        nomina.Show()
        Me.Hide()
    End Sub

    Private Sub Btninventario_Click(sender As Object, e As EventArgs) Handles Btninventario.Click
        Dim inventario As New Inventario
        inventario.Show()
        Me.Hide()
    End Sub

    Private Sub Btnimpuestos_Click(sender As Object, e As EventArgs) Handles Btnimpuestos.Click
        Dim impuestos As New Impuestos
        impuestos.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class
Public Class Impuestos
    Private Sub Btnvalor_Click(sender As Object, e As EventArgs) Handles Btnvalor.Click
        Dim valor As Double
        Dim can As Double
        Dim total As Double
        Dim impuesto As Double
        valor = Txtval.Text
        can = Rbt1.Text
        impuesto = valor * can
        total = impuesto * 0.1

        Label4.Text = "el impuesto a pagar es: " & total


    End Sub

    Private Sub Btncobrar_Click(sender As Object, e As EventArgs) Handles Btncobrar.Click
        Txtval.Text = ""
        Rbt1.Text = ""
        Txtnom.Text = ""
    End Sub

    Private Sub Btnregresar_Click(sender As Object, e As EventArgs) Handles Btnregresar.Click
        Me.Hide()
        Opcion.Show()
    End Sub
End Class
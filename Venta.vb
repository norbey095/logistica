Public Class Venta
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static IM
        IM = IM + 1
        PictureBox1.Image = ImageList1.Images(IM)
        If IM = 4 Then
            IM = 0
        End If
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Hide()
        Opcion.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        Txtrefe.Text = ("")
        Txtnombre.Text = ("")
        Txtcan.Text = ("")
        Txtval.Text = ("")

    End Sub

    Private Sub Btncomprar_Click(sender As Object, e As EventArgs) Handles Btncomprar.Click
        Dim can As Double
        Dim val As Double
        Dim total As Double
        can = Txtcan.Text
        val = Txtval.Text
        total = can * val

        Label6.Text = "el valor a pagar es: " & total
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
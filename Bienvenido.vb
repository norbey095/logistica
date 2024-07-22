Public Class Bienvenido
    Private Sub Btncontinuar_Click(sender As Object, e As EventArgs) Handles Btncontinuar.Click
        Dim continuar As New Corporativo
        continuar.Show()
        Me.Hide()
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Dim valor As Integer
        valor = MsgBox("Desea salir de la aplicacion?", 20, "pregunta")
        If valor = 6 Then
            Me.Hide()
        End If
        If valor = 7 Then
            MsgBox("bienvenido de nuevo")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class

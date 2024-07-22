Public Class Loguin
    Private Sub Btnatenticar_Click(sender As Object, e As EventArgs) Handles Btnatenticar.Click
        Dim nombre As String
        Dim contra As Integer
        nombre = Txtusu.Text
        contra = txtcontra.Text
        If nombre = "alejandro" And contra = 123456 Then
            MsgBox("Sus datos son correctos")
            Me.Hide()
            Opcion.Show()
        Else
            MsgBox("Usuario incorrecto" + " Ingrese de nuevo")
        End If
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
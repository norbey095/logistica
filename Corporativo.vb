Public Class Corporativo
    Private Sub Btnvision_Click(sender As Object, e As EventArgs) Handles Btnvision.Click
        RichTextBox1.LoadFile("..\Visión.rtf")
    End Sub

    Private Sub Btnmision_Click(sender As Object, e As EventArgs) Handles Btnmision.Click
        RichTextBox1.LoadFile("..\Mision.rtf")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim seguir As New Loguin
        seguir.Show()
        Me.Hide()
    End Sub

    Private Sub Btncon_Click(sender As Object, e As EventArgs) Handles Btncon.Click
        Dim loguin As New Loguin
        loguin.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
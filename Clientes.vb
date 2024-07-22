Public Class Clientes
    Dim x As Integer = 0
    Dim ed As String()
    Dim tipo As String()
    Dim nac As String()
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnregresar_Click(sender As Object, e As EventArgs) Handles Btnregresar.Click
        Me.Close()
        Opcion.Show()
    End Sub

    Private Sub Btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click
        If Txtedad.Text <> "" And Cmbtipo.Text <> "" And Cmbnaci.Text <> "" Then
            ReDim Preserve ed(x), tipo(x), nac(x)
            ed(x) = Txtedad.Text
            tipo(x) = Cmbtipo.Text
            nac(x) = Cmbnaci.Text
            Txtedad.Clear()
            Cmbtipo.SelectedIndex = -1
            Cmbnaci.SelectedIndex = -1
            Txtedad.Focus()
            x = x + 1

        Else
            MessageBox.Show("Ingrese todos los datos", "Error...")
            Txtedad.Focus()
        End If
        If Rbthom.Checked = True Then
            MsgBox("Gracias por su compra caballero")
        Else
            MsgBox("Gracias por su compra dama")
        End If
    End Sub

    Private Sub Btnconsultar_Click(sender As Object, e As EventArgs) Handles Btnconsultar.Click
        Dim r As Integer
        r = InputBox("Ingrese el numero de registro que desea consultar", "consultar registro")
        For i = 0 To x
            If i = (r - 1) Then
                Lblr.Text = "El registro consultado nro. " + r.ToString + "Contiene la siguiente informacion: " + vbCrLf +
                    "edad: " + ed(i).ToString + vbCrLf +
                    "tipo: " + tipo(i).ToString + vbCrLf +
                    "nacionalidad: " + nac(i).ToString
            End If
        Next
    End Sub

    Private Sub Cmbtipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbtipo.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Txtedad_TextChanged(sender As Object, e As EventArgs) Handles Txtedad.TextChanged

    End Sub
End Class
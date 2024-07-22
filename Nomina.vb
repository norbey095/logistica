Public Class Nomina
    Private Sub btnpagar_Click(sender As Object, e As EventArgs) Handles btnpagar.Click
        If Rbdhombre.Checked Then
            MsgBox("Gracias por hacer parte de esta compañia")
        Else
            MsgBox("Feliz resto de dia")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Btndato_Click(sender As Object, e As EventArgs) Handles Btndato.Click
        With DataGridView1
            Dim table As New DataTable
            table.Columns.Add(New DataColumn("nombre"))
            table.Columns.Add(New DataColumn("cedula"))
            table.Columns.Add(New DataColumn("tipo de contrato"))
            table.Columns.Add(New DataColumn("fecha de ingreso"))
            table.Columns.Add(New DataColumn("ultimo pago"))
            table.Rows.Add("carlos", "1017238251", "indefinido", "27/12/2018", "2500000")
            table.Rows.Add("felipe", "1265425441", "termino fijo", "18/08/2019", "1800000")
            table.Rows.Add("andres", "1369785217", "obra labor", "05/04/2020", "1500000")
            DataGridView1.DataSource = table





        End With
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Hide()
        Opcion.Show()
    End Sub
End Class
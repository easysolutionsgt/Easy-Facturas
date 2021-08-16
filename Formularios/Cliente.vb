Public Class Cliente
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim mensaje As MsgBoxResult

        mensaje = MsgBox("¿Desea salir, no se almacenaran los datos", MsgBoxStyle.YesNoCancel, "Easy Solutions")

        If mensaje = 6 Then
            Me.Close()
            frmInicio.Show()
        Else

        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InicioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem1.Click
        Dim response As String

        response = MsgBox("¿Esta seguro que desea salir? No se almacenaran los datos.", MsgBoxStyle.YesNoCancel, "Easy Solutions | Facturas")

        If response = 6 Then
            frmInicio.Show()
            Me.Close()
        End If

    End Sub
End Class
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
End Class
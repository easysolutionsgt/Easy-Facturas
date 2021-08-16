Public Class ImprimirDoc
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InicioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem1.Click
        Dim response As String

        response = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.YesNoCancel, "Easy Solutions | Facturas")

        If response = 6 Then
            frmInicio.Show()
            Me.Close()
        End If
    End Sub
End Class
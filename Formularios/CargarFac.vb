Public Class CargarFac
    Private Sub InicioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem1.Click
        Dim response As String

        response = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.YesNoCancel, "Easy Solutions | Facturas")

        If response = 6 Then
            frmInicio.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim response As String

        response = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.YesNoCancel, "Easy Solutions | Facturas")

        If response = 6 Then
            frmInicio.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CrearFact.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()

    End Sub
End Class
Public Class frmInicio
    Private Sub TransaccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaccionesToolStripMenuItem.Click

    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCrearC_Click(sender As Object, e As EventArgs) Handles BtnCrearC.Click
        Cliente.Show()
        Me.Hide()

    End Sub
End Class

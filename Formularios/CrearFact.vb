Public Class CrearFact
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub InicioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem1.Click
        Dim response As String

        response = MsgBox("¿Esta seguro que desea salir? No se almacenaran los datos.", MsgBoxStyle.YesNoCancel, "Easy Solutions | Facturas")

        If response = 6 Then
            CargarFac.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim response As String

        response = MsgBox("¿Esta seguro que desea salir? No se almacenaran los datos.", MsgBoxStyle.YesNoCancel, "Easy Solutions | Facturas")

        If response = 6 Then
            CargarFac.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'BUSCAR CLIENTE, SI EXISTE IGNORAR SI NO EXISRE PREGUNTAR SI DESEA ACTUALIZAR 

        'CREAR DOCUMENTO 


    End Sub
End Class
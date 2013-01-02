Public Class Auditoria

    Private Sub Auditoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Variables.app_buscar = "Usuarios"
        field_buscar = "a_usuario"
        Buscar.Show()
    End Sub
End Class
Public Class Saldos

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Variables.app_buscar = "Productos"
        field_buscar = "s_producto"
        Buscar.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        LblUbicacion.Text = F_asigna_nombre.Nombre_label("Ubicaciones", Me.CBubica_saldos.Text)
    End Sub

    Private Sub Saldos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
    End Sub
End Class
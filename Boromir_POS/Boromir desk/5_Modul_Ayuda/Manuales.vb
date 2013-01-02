Public Class Manuales

    Private Sub Manuales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub RBBasico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBBasico.CheckedChanged
        If RBBasico.Checked = True Then
            Browser_Manuales.Navigate(carpeta_manuales & "\Funcionalidad_basica.mht")
        End If
    End Sub

    Private Sub RBadmon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBadmon.CheckedChanged
        If RBadmon.Checked = True Then
            Browser_Manuales.Navigate(carpeta_manuales & "\Modul_Admin.mht")
        End If
    End Sub
    Private Sub RB_inventarios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_inventarios.CheckedChanged
        If RB_inventarios.Checked = True Then
            Browser_Manuales.Navigate(carpeta_manuales & "\Modul_Inven.mht")
        End If
    End Sub

    Private Sub RBtnCompleto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnCompleto.CheckedChanged
        If RBtnCompleto.Checked = True Then
            Browser_Manuales.Navigate(carpeta_manuales & "\Manual.mht")
        End If
    End Sub

    Private Sub RBweb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBweb.CheckedChanged
        If RBweb.Checked = True Then
            Browser_Manuales.Navigate("http://sistemasboromir.site50.net/")
        End If
    End Sub

  
End Class
Public Class Empresa

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        TxtRutaimgpro.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        TxtManuales.Text = FolderBrowserDialog1.SelectedPath
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FolderBrowserDialog1.ShowDialog()
        TxtReportes.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub TxtCorreo_Ubica_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCorreo_Ubica.LostFocus
        Dim arroba, punto, underline, guion, asterisco As Integer
        Dim correo As String = TxtCorreo_Ubica.Text
        arroba = InStr(correo, "@")
        punto = InStr(correo, ".")
        underline = InStr(correo, "_")
        guion = InStr(correo, "-")
        asterisco = InStr(correo, "*")
        If arroba = 0 Or arroba = 1 Then
            MsgBox("Formato de correo incorrecto", MsgBoxStyle.Critical, "Boromir dice:")
            TxtCorreo_Ubica.Text = "correo@email.com"
        End If
        If punto = 0 Or punto = 1 Or underline > arroba Or guion > arroba Then
            MsgBox("Formato de correo incorrecto", MsgBoxStyle.Critical, "Boromir dice:")
            TxtCorreo_Ubica.Text = "correo@email.com"
        End If
        If asterisco > 0 Then
            MsgBox("Formato de correo incorrecto", MsgBoxStyle.Critical, "Boromir dice:")
            TxtCorreo_Ubica.Text = "correo@email.com"
        End If
    End Sub

    Private Sub Txt_nit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_nit.TextChanged
        If IsNumeric(Txt_nit.Text) Then

        Else
            MsgBox("Campo debe ser numerico, de maximo 10 digitos", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub

    Private Sub TxtTelefono_ubica_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTelefono_ubica.TextChanged
        If IsNumeric(TxtTelefono_ubica.Text) Then

        Else
            MsgBox("Campo debe ser numerico, de maximo 7 digitos", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub

    Private Sub TxtCelular_ubica_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCelular_ubica.TextChanged
        If IsNumeric(TxtCelular_ubica.Text) Then

        Else
            MsgBox("Campo Codigo debe ser numerico, de maximo 10 digitos", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub

    Private Sub Txtpuerto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpuerto.TextChanged
        If IsNumeric(Txtpuerto.Text) Then

        Else
            MsgBox("Campo puerto debe ser numerico", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub

    Private Sub RBtnGmail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnGmail.CheckedChanged
        If RBtnGmail.Checked = True Then
            Txtsmpt.Text = "smtp.gmail.com"
            Txtpuerto.Text = "587"
        End If
    End Sub

    Private Sub RBtnHotmail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnHotmail.CheckedChanged
        If RBtnHotmail.Checked = True Then
            Txtsmpt.Text = "smtp.live.com"
            Txtpuerto.Text = "25"
        End If
    End Sub
End Class
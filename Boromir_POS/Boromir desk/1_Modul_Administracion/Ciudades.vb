
Public Class Ciudades

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Variables.ciudades_visible = False
        Boromir.Tab1.TabPages.Remove(Me.Tag)
    End Sub

    Private Sub TxtCodigo_ciudad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo_ciudad.TextChanged
        If IsNumeric(TxtCodigo_ciudad.Text) Then

        Else
            MsgBox("Campo Codigo debe ser numerico, de 2 digitos", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub
End Class
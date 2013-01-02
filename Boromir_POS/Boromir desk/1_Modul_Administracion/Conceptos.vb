Public Class Conceptos

    Private Sub TxtCodigo_Concep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo_Concep.TextChanged
        If IsNumeric(TxtCodigo_Concep.Text) Then
            MsgBox("Codigo no permite numeros", MsgBoxStyle.Information, "Boromir Dice:")
        Else

        End If
    End Sub
End Class
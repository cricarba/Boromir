Public Class Documentos


    Private Sub TxtCodigo_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo_doc.TextChanged
        If IsNumeric(TxtCodigo_doc.Text) Then
            MsgBox("Codigo no permite numeros", MsgBoxStyle.Information, "Boromir Dice:")
        Else

        End If
    End Sub
End Class
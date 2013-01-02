Public Class Tipo_Costo
  

    Private Sub TxtCodigo_costo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo_costo.TextChanged
        If IsNumeric(TxtCodigo_costo.Text) Then
            MsgBox("Campo Codigo no admite numeros, maximo 1 digito", MsgBoxStyle.Information, "Boromir Dice:")
        Else

        End If
    End Sub

    Private Sub TxValor_costo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxValor_costo.TextChanged
        If IsNumeric(TxValor_costo.Text) Then

        Else
            MsgBox("Campo Codigo debe ser numerico", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub

    Private Sub CBubic_tipocost_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBubic_tipocost.SelectedIndexChanged
        LblUbica.Text = F_asigna_nombre.Nombre_label("Ubicaciones", Me.CBubic_tipocost.Text)
    End Sub
End Class
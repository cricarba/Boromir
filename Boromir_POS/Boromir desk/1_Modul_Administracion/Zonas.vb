Imports System.Data
Imports System.Data.SqlClient
Public Class Zonas

    Private Sub TxtCodigo_Zona_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo_Zona.TextChanged
        If IsNumeric(TxtCodigo_Zona.Text) Then

        Else
            MsgBox("Campo Codigo debe ser numerico, de maximo2 digitos", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub

    Private Sub Txtciudad_zona_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtciudad_zona.SelectedIndexChanged
        Lblciudad.Text = F_asigna_nombre.Nombre_label("Ciudades", Txtciudad_zona.Text)
    End Sub
End Class
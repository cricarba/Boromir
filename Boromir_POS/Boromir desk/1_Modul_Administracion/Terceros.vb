Imports System.Data
Imports System.Data.SqlClient
Public Class Terceros
    Private Sub Terceros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Variables.app_buscar = "Terceros"
        field_buscar = "t_tercero"
        Buscar.Show()
    End Sub

    Private Sub TxtCodigo_terce_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo_terce.TextChanged
        If IsNumeric(TxtCodigo_terce.Text) Then

        Else
            MsgBox("Campo Codigo debe ser numerico, de maximo 10 digitos", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub

    Private Sub TxtTelefono_terce_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTelefono_terce.TextChanged
        If IsNumeric(TxtTelefono_terce.Text) Then

        Else
            MsgBox("Campo debe ser numerico, de maximo 7 digitos", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub

    Private Sub TxtCelular_terce_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCelular_terce.TextChanged
        If IsNumeric(TxtCelular_terce.Text) Then

        Else
            MsgBox("Campo debe ser numerico, de maximo 10 digitos", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub

    Private Sub Txtcorreo_terce_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtcorreo_terce.LostFocus
        Dim arroba, punto, underline, guion, asterisco As Integer
        Dim correo As String = Txtcorreo_terce.Text
        arroba = InStr(correo, "@")
        punto = InStr(correo, ".")
        underline = InStr(correo, "_")
        guion = InStr(correo, "-")
        asterisco = InStr(correo, "*")
        If arroba = 0 Or arroba = 1 Then
            MsgBox("Formato de correo incorrecto", MsgBoxStyle.Critical, "Boromir dice:")
            Txtcorreo_terce.Text = "correo@email.com"
        End If
        If punto = 0 Or punto = 1 Or underline > arroba Or guion > arroba Then
            MsgBox("Formato de correo incorrecto", MsgBoxStyle.Critical, "Boromir dice:")
            Txtcorreo_terce.Text = "correo@email.com"
        End If
        If asterisco > 0 Then
            MsgBox("Formato de correo incorrecto", MsgBoxStyle.Critical, "Boromir dice:")
            Txtcorreo_terce.Text = "correo@email.com"
        End If

    End Sub

    Private Sub CBoxTipodoc_terce_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTipodoc.SelectedIndexChanged
        Me.LblNombredoc.Text = F_asigna_nombre.Nombre_label("Documentos", Me.CBTipodoc.Text)
    End Sub

    Private Sub CBoxCiudad_terce_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoxCiudad_terce.SelectedIndexChanged
        Me.LblCiudad.Text = F_asigna_nombre.Nombre_label("Ciudades", Me.CBoxCiudad_terce.Text)
    End Sub
End Class
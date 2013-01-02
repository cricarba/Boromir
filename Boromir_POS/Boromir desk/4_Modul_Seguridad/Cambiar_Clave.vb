Imports System.Data
Imports System.Data.SqlClient
Public Class Cambiar_Clave
    Dim i As Integer
    Private Sub Cambiar_Clave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sSel As String = "Select * from tbl_usuarios where cnombre_usua = '" & Inicio_Sesion.TxtUsusario_usuario.Text & "'"
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        da = New SqlDataAdapter(sSel, Variables.sCnn)
        da.Fill(dt)
        Try
            If dt.Rows.Count > 0 Then
                Variables.pass = dt.Rows(i)("ccontraseña_usua").ToString
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Txtpass_actual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpass_actual.TextChanged
        If Variables.pass <> Txtpass_actual.Text Then
            Lblpass_actual.Text = "Contraseña incorrecta"
        Else
            Lblpass_actual.ForeColor = Color.Red
            Lblpass_actual.Text = "Contraseña Correcta"
        End If

    End Sub
    Private Sub TxtContraseña_perfil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNueva_Contraseña.TextChanged
        If TxtNueva_Contraseña.Text.Length < 9 Then
            LblFuerzaContraseña_perfil.Text = "Debil"
            LblFuerzaContraseña_perfil.ForeColor = Color.Green
        Else
            If TxtNueva_Contraseña.Text.Length >= 9 And TxtNueva_Contraseña.Text.Length < 12 Then
                LblFuerzaContraseña_perfil.Text = "Medio"
                LblFuerzaContraseña_perfil.ForeColor = Color.DarkOrange
            Else
                If TxtNueva_Contraseña.Text.Length >= 14 Then
                    LblFuerzaContraseña_perfil.Text = "Fuerte"
                    LblFuerzaContraseña_perfil.ForeColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Sub Txtconfirmacontraseña_perfil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtconfirmacontraseña_perfil.TextChanged
        Variables.confirma_contraseña = Txtconfirmacontraseña_perfil.Text
        If Variables.confirma_contraseña <> TxtNueva_Contraseña.Text Then
            Lblconcide_pass.ForeColor = Color.Red
            Lblconcide_pass.Text = "Contraseña NO Concide"
        Else
            Lblconcide_pass.ForeColor = Color.Green
            Lblconcide_pass.Text = "Contraseña Concide"
        End If
    End Sub
    Private Sub Btncambiar_pass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncambiar_pass.Click
        If Lblconcide_pass.Text = "Contraseña Concide" And Lblpass_actual.Text = "Contraseña Correcta" Then
            Variables.sSel = "update tbl_usuarios set ccontraseña_usua ='" & Txtconfirmacontraseña_perfil.Text & "' where cnombre_usua = '" & Boromir.barra_estad_usuario.Text & "' "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
            MsgBox("Clave cambiada exitosamente ", MsgBoxStyle.Information, "Boromir Dice:")
            Me.Close()
            Boromir.Enabled = True
        Else
            MsgBox("Contraseñas NO Conciden ", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub

    Private Sub Btncancelar_pass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancelar_pass.Click
        Me.Close()
        Boromir.Enabled = True
    End Sub

End Class
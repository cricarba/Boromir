Imports System.Data
Imports System.Data.SqlClient
Public Class Usuarios

    Private Sub TxtContraseña_perfil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtContraseña_perfil.TextChanged
        If TxtContraseña_perfil.Text.Length <= 8 Then
            LblFuerzaContraseña_perfil.Text = "Debil"
            LblFuerzaContraseña_perfil.ForeColor = Color.Green
        Else
            If TxtContraseña_perfil.Text.Length > 8 And TxtContraseña_perfil.Text.Length < 12 Then
                LblFuerzaContraseña_perfil.Text = "Medio"
                LblFuerzaContraseña_perfil.ForeColor = Color.DarkOrange
            Else
                If TxtContraseña_perfil.Text.Length >= 12 Then
                    LblFuerzaContraseña_perfil.Text = "Fuerte"
                    LblFuerzaContraseña_perfil.ForeColor = Color.Red
                End If
            End If
        End If
    End Sub
    Private Sub Txtconfirmacontraseña_perfil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtconfirmacontraseña_perfil.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If TxtContraseña_perfil.Text = Txtconfirmacontraseña_perfil.Text Then
                LblSimilitud.ForeColor = Color.Green
                LblSimilitud.Text = "Coinciden"
            Else
                LblSimilitud.Text = "No coinciden"
            End If
        End If
    End Sub
    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Txtconfirmacontraseña_perfil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtconfirmacontraseña_perfil.TextChanged
        Variables.confirma_contraseña = Txtconfirmacontraseña_perfil.Text
        If Variables.confirma_contraseña <> TxtContraseña_perfil.Text Then
            Lblconcide_pass.ForeColor = Color.Red
            Lblconcide_pass.Text = "Contraseña NO Concide"
        Else
            Lblconcide_pass.ForeColor = Color.Green
            Lblconcide_pass.Text = "Contraseña Concide"
        End If
    End Sub

    Private Sub TxtTercero_usua_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTercero_usua.TextChanged
        Variables.dt.Clear()
        If IsNumeric(TxtTercero_usua.Text) Then
            Dim i As Integer
            TxtTercero_usua.Text = Integer.Parse(TxtTercero_usua.Text)
            Variables.sSel = "Select * from tbl_terceros, tbl_tipodoc where ncodigo_terce = '" & TxtTercero_usua.Text & "' and ccod_tipodoc_terce = ccodigo_tipodoc"
            Try
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dt)
                TxtNombre1_terce.Text = dt.Rows(i)("cnombre_terce").ToString()
                TxtNombre2_terce.Text = dt.Rows(i)("cnombre2_terce").ToString()
                Txtapellido1_usua.Text = dt.Rows(i)("capellido_terce").ToString()
                TxtApellido2_usua.Text = dt.Rows(i)("capellido2_terce").ToString()
                TxtTelefono_usua.Text = dt.Rows(i)("ntelefono_terce").ToString()
                TxtCelular.Text = dt.Rows(i)("ncelular_terce").ToString()
                TxtCorreo_usua.Text = dt.Rows(i)("cemail_terce").ToString()
                LblNombredoc_terce.Text = dt.Rows(i)("cnombre_tipodoc").ToString()

            Catch ex As Exception
                TxtNombre1_terce.Text = ""
                TxtNombre2_terce.Text = ""
                Txtapellido1_usua.Text = ""
                TxtApellido2_usua.Text = ""
                TxtTelefono_usua.Text = ""
                TxtCelular.Text = ""
                TxtCorreo_usua.Text = ""
                LblNombredoc_terce.Text = ""
            End Try
        Else
            MsgBox("Campo cedula debe ser númerico", MsgBoxStyle.Critical, "Boromir dice: ")
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Variables.app_buscar = "Terceros"
        field_buscar = "u_tercero"
        Buscar.Show()
    End Sub

    Private Sub CBPerfil_usuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPerfil_usuario.SelectedIndexChanged
        LblPerfildes.Text = F_asigna_nombre.Nombre_label("Perfiles", Me.CBPerfil_usuario.Text)
    End Sub

    Private Sub CBUbica_Usuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBUbica_Usuarios.SelectedIndexChanged
        Lblubica.Text = F_asigna_nombre.Nombre_label("Ubicaciones", Me.CBUbica_Usuarios.Text)
    End Sub
End Class
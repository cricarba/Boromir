Imports System.Data
Imports System.Data.SqlClient
Public Class Ubicaciones
    Private Sub Ubicaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Txtcodigo.Focus()
    End Sub
    Private Sub Txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcodigo.KeyPress
       
    End Sub

    Private Sub TxtNombre_ubica_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre_ubica.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TxtDireccion_ubica.Focus()
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Variables.app_buscar = "Ubicaciones"
        field_buscar = "U_ubicacion"
        Buscar.Show()
    End Sub

    Private Sub TxtCedula_ubica_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCedula_ubica.TextChanged
        Variables.dt.Clear()
        If IsNumeric(TxtCedula_ubica.Text) Then
            Dim i As Integer
            Variables.sSel = "Select * from tbl_terceros where ncodigo_terce = '" & Integer.Parse(TxtCedula_ubica.Text) & "'"
            Try
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dt)
                TxtNombre1_ubica.Text = dt.Rows(i)("cnombre_terce").ToString()
                TxtNombre2_ubica.Text = dt.Rows(i)("cnombre2_terce").ToString()
                TxtApellido1_ubica.Text = dt.Rows(i)("capellido_terce").ToString()
                TxtApellido2_ubica.Text = dt.Rows(i)("capellido2_terce").ToString()
            Catch ex As Exception
                TxtNombre1_ubica.Text = ""
                TxtNombre2_ubica.Text = ""
                TxtApellido1_ubica.Text = ""
                TxtApellido2_ubica.Text = ""
            End Try
        Else
            TxtCedula_ubica.Text = "0"
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Variables.app_buscar = "Terceros"
        field_buscar = "U_tercero"
        Buscar.Show()
    End Sub

    Private Sub CBoxCiudad_ubica_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBoxCiudad_ubica.TextChanged
        Variables.dt.Clear()
        Variables.codigo = CBoxCiudad_ubica.Text
        Try
            CBoxZona_ubica.Text = ""
            Me.CBoxZona_ubica.Items.Clear()
            Call F_Cargar_Combox.Cargar_Zonas()
            For Each dr As DataRow In Variables.Filas_zonas
                Me.CBoxZona_ubica.Items.Add(dr("ncodigo_zona"))
            Next
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Txtcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcodigo.TextChanged
        If IsNumeric(Txtcodigo.Text) Then

        Else
            MsgBox("Campo codigo debe ser númerico", MsgBoxStyle.Critical, "Boromir dice: ")
        End If
    End Sub

    Private Sub CBoxCiudad_ubica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoxCiudad_ubica.SelectedIndexChanged
        LblCiudad.Text = F_asigna_nombre.Nombre_label("Ciudades", Me.CBoxCiudad_ubica.Text)
    End Sub

    Private Sub CBoxZona_ubica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoxZona_ubica.SelectedIndexChanged
        LblZona.Text = F_asigna_nombre.Nombre_label("Zonas", Me.CBoxZona_ubica.Text)
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
            MsgBox("Campo debe ser numerico, de maximo 10 digitos", MsgBoxStyle.Information, "Boromir Dice:")
        End If
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

  
End Class

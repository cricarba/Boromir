Imports System.Data
Imports System.Data.SqlClient

Public Class Inicio_Sesion
    Dim i As Integer
    Private Sub Inicio_Sesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Boromir.Show()
        Boromir.Enabled = False
        TxtUsusario_usuario.Focus()
        Me.LabelVersion.Text = String.Format("V. {0}", My.Application.Info.Version.ToString)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        Try
            Dim sSel As String = "Select * from tbl_usuarios where cnombre_usua = '" & TxtUsusario_usuario.Text & "'"
            Dim da As SqlDataAdapter
            Dim dt As New DataTable

            da = New SqlDataAdapter(sSel, Variables.sCnn)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If IsNumeric(TxtUbicacion_usuario.Text) Then
                    Variables.ubcn1 = Integer.Parse(TxtUbicacion_usuario.Text)
                    Variables.user = dt.Rows(i)("cnombre_usua").ToString
                    Variables.pass = dt.Rows(i)("ccontraseña_usua").ToString
                    Variables.ubcn = dt.Rows(i)("ncod_ubic_usua").ToString
                    If Variables.pass <> TxtContraseña_usuario.Text Then
                        MsgBox("Contraseña Incorrecta", MsgBoxStyle.Critical, "Boromir dice:")
                        TxtContraseña_usuario.Text = ""
                        TxtContraseña_usuario.Focus()
                    ElseIf Variables.ubcn <> Variables.ubcn1 Then
                        MsgBox("Ubicación Incorrecta", MsgBoxStyle.Critical, "Boromir dice:")
                        TxtUbicacion_usuario.Text = ""
                        TxtUbicacion_usuario.Focus()
                    Else
                        Dim et As New DataTable
                        Variables.sSel = "select * from tbl_empresa"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(et)
                        If et.Rows.Count > 0 Then
                            carpeta_imagenes = et.Rows(i)("cruta_produ_empre").ToString
                            carpeta_manuales = et.Rows(i)("cruta_manual_empre").ToString
                            carpeta_reportes = et.Rows(i)("cruta_repor_empre").ToString
                        Else
                            MsgBox("No olvide asignar la ruta de las carpetas de Imagenes, Manules y Reportes. Aplicacion Empresa.", MsgBoxStyle.Critical, "Boromir Dice:")
                        End If

                        Boromir.Show()
                        Boromir.Enabled = True
                        Call F_Permisos_usuarios.Permisos_perfil_botones()
                        Call F_Licencia.licencia_modulos()
                        TxtUsusario_usuario.Text = ""
                        TxtContraseña_usuario.Text = ""
                        TxtUbicacion_usuario.Text = ""
                        TxtUsusario_usuario.Focus()
                        Me.Hide()
                    End If
                Else
                    MsgBox("Campo Ubicación debe ser numerico ", MsgBoxStyle.Critical, "Boromir dice:")
                End If
            Else
                MsgBox("Usuario Incorrecto", MsgBoxStyle.Critical, "Boromir dice:")
            End If

            Boromir.barra_estad_usuario.Text = Variables.user
            Boromir.Barra_estad_ubica.Text = Variables.ubcn1


            Variables.Des_auditoria = "INICIO DE SESION"
            Variables.sSel = "Exec proc_auditoria '" & Boromir.barra_estad_usuario.Text.ToUpper & "',INGRESO, LOGIN ,'" & Variables.Des_auditoria.ToUpper & "','" & Now() & "' "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Boromir.Close()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBServer.SelectedIndexChanged
        Variables.sCnn = Variables.conexion(Me.CBServer.Text)
    End Sub
End Class
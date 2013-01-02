Imports System.Data
Imports System.Data.SqlClient
Public Class ConsolaSQL


    Private Sub ConsolaSQL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Picture_error.Visible = False
        Picture_ok.Visible = False
    End Sub

    Private Sub BtnCambiaconexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnejecutar.Click
        Try
            Dim dtsql As New DataTable
            Variables.consola = TxtConsola.Text
            Variables.sSel = " " & Variables.consola & " "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtsql)
            Dtconsola.DataSource = dtsql
            Picture_error.Visible = False
            Picture_ok.Visible = True
            Lbl_mensaje.ForeColor = Color.Green
            Lbl_mensaje.Text = "Consulta realizada correctamente"
            Lbl_error.Text = String.Format(dtsql.Rows.Count) & " Registros Afectados/Encontrados"
        Catch ex As Exception
            Picture_ok.Visible = False
            Picture_error.Visible = True
            Lbl_mensaje.ForeColor = Color.Red
            Lbl_mensaje.Text = "La consulta presenta errores. Vea la pestaña Mensages"
            Lbl_error.Text = ex.Message
        End Try
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        Picture_error.Visible = False
        Picture_ok.Visible = False
        Lbl_mensaje.ForeColor = Color.Red
        Lbl_mensaje.Text = ""
        Lbl_error.Text = ""
        TxtConsola.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtConsola_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtConsola.KeyPress
        If e.KeyChar = ChrW(Keys.OemQuestion) Then
            Try
                Dim dtsql As New DataTable
                Variables.consola = TxtConsola.Text
                Variables.sSel = " " & Variables.consola & " "
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dtsql)
                Dtconsola.DataSource = dtsql
                Picture_error.Visible = False
                Picture_ok.Visible = True
                Lbl_mensaje.ForeColor = Color.Green
                Lbl_mensaje.Text = "Consulta realizada correctamente"
                Lbl_error.Text = String.Format(dtsql.Rows.Count) & " Registros Afectados/Encontrados"
            Catch ex As Exception
                Picture_ok.Visible = False
                Picture_error.Visible = True
                Lbl_mensaje.ForeColor = Color.Red
                Lbl_mensaje.Text = "La consulta presenta errores. Vea la pestaña Mensages"
                Lbl_error.Text = ex.Message
            End Try
        End If
    End Sub
End Class
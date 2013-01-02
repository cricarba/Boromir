Imports System.IO
Imports System.Net.Mail
Imports System.Data
Imports System.Data.SqlClient
Public Class Mensajes
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            OpenFileDialog1.Filter = "Todos los archivos (*.*)|*.*"
            OpenFileDialog1.ShowDialog()
            Variables.nombre_adjunto = OpenFileDialog1.FileName
            Variables.archivo_adjunto = New Attachment(Variables.nombre_adjunto)
            LblNombreArchivo.Text = Variables.nombre_adjunto
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnPara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPara.Click
        app_buscar = "Correos"
        field_buscar = "m_para"
        Buscar.Show()
    End Sub

    Private Sub BtnCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCC.Click
        app_buscar = "Correos"
        field_buscar = "m_cc"
        Buscar.Show()
    End Sub

    Private Sub Btncco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncco.Click
        app_buscar = "Correos"
        field_buscar = "m_cco"
        Buscar.Show()
    End Sub

    Private Sub RBtnMasivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnMasivo.CheckedChanged
        If RBtnMasivo.Checked = True Then
            Me.TxtPara.Enabled = False
            Me.TxtCC.Enabled = False
            Me.TxtCCO.Enabled = False
        End If
    End Sub

    Private Sub RBtnNormal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnNormal.CheckedChanged
        If RBtnNormal.Checked = True Then
            Me.TxtPara.Enabled = True
            Me.TxtCC.Enabled = True
            Me.TxtCCO.Enabled = True
        End If
    End Sub
End Class



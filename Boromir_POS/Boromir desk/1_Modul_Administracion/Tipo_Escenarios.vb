Imports System.Data
Imports System.Data.SqlClient
Public Class Tipo_Escenarios
    Private Sub Tipo_Escenarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtCodigo_cancha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo_cancha.TextChanged
        If IsNumeric(TxtCodigo_cancha.Text) Then
            MsgBox("Campo Codigo no admite numeros, maximo 2 digitos", MsgBoxStyle.Information, "Boromir Dice:")
        Else

        End If
    End Sub
End Class
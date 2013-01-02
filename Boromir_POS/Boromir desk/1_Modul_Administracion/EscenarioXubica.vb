Imports System.Data
Imports System.Data.SqlClient
Public Class EscenarioXubica
    Dim i As Integer
    Dim tipo_costo As Integer
    Private Sub CBUbic_EXU_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBUbic_EXU.TextChanged
        Try
            Variables.dt.Clear()
            Variables.codigo =
            Variables.sSel = "select  ncobro_ubica from tbl_ubicaciones where ncodigo_ubica = '" & Integer.Parse(CBtcosto_EXU.Text) & "' "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
            Tipo_Costo = dt.Rows(i)("ncobro_ubica").ToString()
            If Tipo_Costo = 1 Then
                Label2.Visible = False
                CBtcosto_EXU.Visible = False
            End If
            If Tipo_Costo = 0 Then
                Label2.Visible = True
                CBtcosto_EXU.Visible = True
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub TxtCodigo_EXU_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo_EXU.TextChanged
        If IsNumeric(TxtCodigo_EXU.Text) Then

        Else
            MsgBox("Campo Codigo debe ser numerico, de 1 digito", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub


    Private Sub CBUbic_EXU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBUbic_EXU.SelectedIndexChanged
        LblUbica.Text = F_asigna_nombre.Nombre_label("Ubicaciones", Me.CBUbic_EXU.Text)
    End Sub

    Private Sub CBTipo_EXU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTipo_EXU.SelectedIndexChanged
        LblTipo.Text = F_asigna_nombre.Nombre_label("Tipo Escenarios", Me.CBTipo_EXU.Text)
    End Sub

    Private Sub CBtcosto_EXU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBtcosto_EXU.SelectedIndexChanged
        LblTipoCosto.Text = F_asigna_nombre.Nombre_label("Tipo Costo", Me.CBtcosto_EXU.Text)
    End Sub

    Private Sub CBEstado_EXU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEstado_EXU.SelectedIndexChanged
        LblEstado.Text = F_asigna_nombre.Nombre_label("Estados", CBEstado_EXU.Text)
    End Sub
End Class
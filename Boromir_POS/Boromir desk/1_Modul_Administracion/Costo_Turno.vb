Public Class Costo_Turno

    Private Sub CBubic_tabla_costo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBubic_tabla_costo.TextChanged
        CBtipoescen_costo_turno.Items.Clear()
        Try
            Call F_Cargar_Combox.Cargar_TEscenXubica()
            For Each dr As DataRow In Variables.Filas_escenarios
                Me.CBtipoescen_costo_turno.Items.Add(dr("ctipo_escen"))
            Next
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Variables.dt.Clear()
        Try
            Call F_Cargar_Combox.Cargar_Tipo_Costo_turno()
            For Each dr As DataRow In Variables.Filas_tipo_costo
                Me.CBLunes.Items.Add(dr("ccodigo_tcosto"))
                Me.CBMartes.Items.Add(dr("ccodigo_tcosto"))
                Me.CBMiercoles.Items.Add(dr("ccodigo_tcosto"))
                Me.CBJueves.Items.Add(dr("ccodigo_tcosto"))
                Me.CBViernes.Items.Add(dr("ccodigo_tcosto"))
                Me.CBSabado.Items.Add(dr("ccodigo_tcosto"))
                Me.CBDomingo.Items.Add(dr("ccodigo_tcosto"))
                Me.CBFestivo.Items.Add(dr("ccodigo_tcosto"))
            Next
        Catch ex As Exception
            MsgBox("Error Reload Costo_Turno: " & ex.Message)
        End Try
        Variables.dt.Clear()
    End Sub

    Private Sub CBubic_tabla_costo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBubic_tabla_costo.SelectedIndexChanged
        Lblubica.Text = F_asigna_nombre.Nombre_label("Ubicaciones", CBubic_tabla_costo.Text)
    End Sub

    Private Sub CBtipoescen_costo_turno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBtipoescen_costo_turno.SelectedIndexChanged
        Lbltipoescen.Text = F_asigna_nombre.Nombre_label("Tipo Escenarios", Me.CBtipoescen_costo_turno.Text)
    End Sub
End Class
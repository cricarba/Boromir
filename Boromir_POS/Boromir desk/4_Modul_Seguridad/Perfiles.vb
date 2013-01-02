Public Class Perfiles
    Private Sub Perfiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub CBAdmon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBAdmon.CheckedChanged
        If CBAdmon.Checked = True Then
            Paneladmon.Enabled = True
        ElseIf CBAdmon.Checked = False Then
            Paneladmon.Enabled = False
        End If
    End Sub

    Private Sub CBTipos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTipos.CheckedChanged
        If CBTipos.Checked = True Then
            Paneltipos_admon.Enabled = True
        ElseIf CBTipos.Checked = False Then
            Paneltipos_admon.Enabled = False
        End If
    End Sub

    Private Sub CBLocalizacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBLocalizacion.CheckedChanged
        If CBLocalizacion.Checked = True Then
            PanelLocGeo_admon.Enabled = True
        ElseIf CBLocalizacion.Checked = False Then
            PanelLocGeo_admon.Enabled = False
        End If
    End Sub

    Private Sub CBInventarios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBInventarios.CheckedChanged
        If CBInventarios.Checked = True Then
            PanelInven.Enabled = True
        ElseIf CBInventarios.Checked = False Then
            PanelInven.Enabled = False
        End If
    End Sub

    Private Sub CBFacturacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBFacturacion.CheckedChanged
        If CBFacturacion.Checked = True Then
            Panelfactu.Enabled = True
        ElseIf CBFacturacion.Checked = False Then
            Panelfactu.Enabled = False
        End If
    End Sub

    Private Sub CBReportes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBReportes.CheckedChanged
        If CBReportes.Checked = True Then
            PanelReport.Enabled = True
        ElseIf CBReportes.Checked = False Then
            PanelReport.Enabled = False
        End If
    End Sub

    Private Sub CBSeguridad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBSeguridad.CheckedChanged
        If CBSeguridad.Checked = True Then
            PanelSegu.Enabled = True
        ElseIf CBSeguridad.Checked = False Then
            PanelSegu.Enabled = False
        End If
    End Sub
End Class
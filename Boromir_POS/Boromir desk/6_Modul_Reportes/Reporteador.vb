Public Class Reporteador

    Private Sub CBPeriodicos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPeriodicos.CheckedChanged
        If CBPeriodicos.Checked = True Then
            GBPeriodicos.Enabled = True
        Else
            GBPeriodicos.Enabled = False
        End If
    End Sub

    Private Sub CBProductos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBProductos.CheckedChanged
        If CBProductos.Checked = True Then
            GBProductos.Enabled = True
        Else
            GBProductos.Enabled = False
        End If
    End Sub

    Private Sub CBTerceros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTerceros.CheckedChanged
        If CBTerceros.Checked = True Then
            GBTerceros.Enabled = True
        Else
            GBTerceros.Enabled = False
        End If
    End Sub

    Private Sub CBConceptos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBConceptos.CheckedChanged
        If CBConceptos.Checked = True Then
            GBConceptos.Enabled = True
        Else
            GBConceptos.Enabled = False
        End If
    End Sub
End Class
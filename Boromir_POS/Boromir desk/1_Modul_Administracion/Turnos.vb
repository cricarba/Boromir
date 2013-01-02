Public Class Turnos
    Private Sub Turnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call F_Cargar_Combox.Cargar_Ubicaciones()
            For Each dr As DataRow In Variables.Filas_ubicaciones
                Me.CBubic_turnos.Items.Add(dr("cnombre_ubica"))
            Next
            Variables.dt.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class
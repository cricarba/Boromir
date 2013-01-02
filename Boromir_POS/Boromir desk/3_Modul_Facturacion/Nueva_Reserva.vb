Imports System.Data
Imports System.Data.SqlClient
Public Class Nueva_Reserva
    Private Sub Nueva_Reserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call F_Cargar_Combox.Cargar_Ubicaciones()
            For Each dr As DataRow In Variables.Filas_ubicaciones
                Me.CBoxUbicacion_reser.Items.Add(dr("ncodigo_ubica"))
            Next
            Variables.dt.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Try
            Call F_Cargar_Combox.Cargar_estados()
            For Each dr As DataRow In Variables.Filas_estado
                Me.CBEstado_reser.Items.Add(dr("ccodigo_estad"))
            Next
            Variables.dt.Clear()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnDisponibles_reser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisponibles_reser.Click
        Variables.fechas = TxtFecha_reser.Text
        Call F_Datos_reserva.f_consulta_disponible()
        Me.BtnDisponibles_reser.Visible = False
        Me.Btn_buscar.Visible = True
        Variables.dt.Clear()
    End Sub
    Private Sub Btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_buscar.Click
        Variables.dia_reserva = TxtFecha_reser.Text
        Variables.dia_reserva2 = Variables.dia_reserva.DayOfWeek.ToString
        Try
            Variables.datos_escen = CBlist_disponibles.SelectedItem.ToString
            TxtDatos_Cod_escen.Text = Variables.datos_escen
            Call F_Datos_reserva.F_Datos_escen()
        Catch ex As Exception
            MsgBox("Error:")
        End Try
    End Sub
    Private Sub TxtDocumento_terce_reser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDocumento_terce_reser.TextChanged
        Variables.dt.Clear()
        Try
            If IsNumeric(TxtDocumento_terce_reser.Text) Then
                Dim i As Integer
                TxtDocumento_terce_reser.Text = Integer.Parse(TxtDocumento_terce_reser.Text)
                Variables.sSel = "Select * from tbl_terceros where ncodigo_terce = '" & TxtDocumento_terce_reser.Text & "'"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dt)
                TxtNombre1_terce.Text = dt.Rows(i)("cnombre_terce").ToString()
                TxtNombre2_terce.Text = dt.Rows(i)("cnombre2_terce").ToString()
                TxtApellido_terce_reser.Text = dt.Rows(i)("capellido_terce").ToString()
                TxtApellido2_terce_reser.Text = dt.Rows(i)("capellido2_terce").ToString()
                Txt_doc.Text = dt.Rows(i)("ccod_tipodoc_terce").ToString
                Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
            Else
                MsgBox("Campo cedula debe ser númerico", MsgBoxStyle.Critical, "Boromir dice: ")
            End If
        Catch ex As Exception
            TxtNombre1_terce.Text = ""
            TxtNombre2_terce.Text = ""
            TxtApellido_terce_reser.Text = ""
            TxtApellido2_terce_reser.Text = ""
            Txt_doc.Text = "0"
        End Try
    End Sub
End Class
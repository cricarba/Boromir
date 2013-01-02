Imports System.Data
Imports System.Data.SqlClient
Module F_Datos_reserva
    Dim i As Integer
    Public Sub f_consulta_disponible()

        Try
            Variables.sSel = "select * from tbl_escenarios where ncod_ubica_escen = '" & Nueva_Reserva.CBoxUbicacion_reser.Text & "'  and ncodigo_escen not in ( select ncod_escen_reser from tbl_reservas where ncod_ubic_reser = '" & Nueva_Reserva.CBoxUbicacion_reser.Text & "' and ffecha_reser = '" & Variables.fechas & "'and hhora_reser = '" & Nueva_Reserva.MTxtHora_reser.Text & "') "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
            Variables.Filas_escen_x_ubic = dt.Select
            Nueva_Reserva.CBlist_disponibles.Items.Clear()
            If Filas_escen_x_ubic.Length > 0 Then
                For Each dr As DataRow In Filas_escen_x_ubic
                    Nueva_Reserva.CBlist_disponibles.Items.Add(dr("ncodigo_escen").ToString)
                Next
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub F_Datos_escen()
        Try
            Variables.sSel = " exec proc_datos_escen '" & Nueva_Reserva.CBoxUbicacion_reser.Text & "','" & Variables.datos_escen & "','" & Nueva_Reserva.MTxtHora_reser.Text & "','" & Variables.dia_reserva2 & "'"
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Variables.dt.Clear()
        Try
            Variables.sSel = " select * from  tbl_datos_escen_reser"
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
            Nueva_Reserva.TxtDatos_escen.Text = dt.Rows(i)("cnombre_tescen_der").ToString()
            Nueva_Reserva.TxtDatos_tipocosto.Text = dt.Rows(i)("ccod_tcosto_der").ToString()
            Nueva_Reserva.TxtDatos_Costo.Text = dt.Rows(i)("mvalor_tcosto_der").ToString()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Module

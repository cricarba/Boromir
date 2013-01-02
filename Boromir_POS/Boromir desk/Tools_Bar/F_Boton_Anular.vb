Imports System.Data
Imports System.Data.SqlClient
Module F_Boton_Anular
    Dim i As Integer
    Public Sub boton_anular()
        Try
            Dim apps As String = Boromir.Tab1.SelectedTab.Text
            Select Case apps
                Case "Cotizaciones"
                    Try
                        Variables.sSel = "Exec proc_anular_movimiento '" & Cotizaciones.TxtFactura_factu.Text & "','" & Cotizaciones.CBConcepto.Text & "','" & Cotizaciones.CBUbicacion.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Cotizaciones Anulado", MsgBoxStyle.Information, "Boromir Dice:")
                        Call F_Boton_buscar.Boton_Buscar()
                    Catch ex As Exception
                        MsgBox("Error Anular Movimiento: " & ex.Message)
                    End Try
                Case "Pedidos"
                    Try
                        Variables.sSel = "Exec proc_anular_movimiento '" & Pedidos.TxtFactura_factu.Text & "','" & Pedidos.CBConcepto.Text & "','" & Pedidos.CBUbicacion.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Pedidos Anulado", MsgBoxStyle.Information, "Boromir Dice:")
                        Call F_Boton_buscar.Boton_Buscar()
                    Catch ex As Exception
                        MsgBox("Error Anular Pedidos: " & ex.Message)
                    End Try
                Case "Facturas"
                    Try
                        Variables.sSel = "Exec proc_anular_movimiento '" & Facturas.TxtFactura_factu.Text & "','" & Facturas.CBConcepto_factu.Text & "','" & Facturas.CBoxUbicacion_factu.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Factura Anulada", MsgBoxStyle.Information, "Boromir Dice:")
                        Call F_Boton_buscar.Boton_Buscar()
                    Catch ex As Exception
                        MsgBox("Error Anular Factura: " & ex.Message)
                    End Try

                Case "Nueva Reserva"
                    Try
                        Variables.sSel = "Exec proc_anular_movimiento '" & Nueva_Reserva.TxtReserva_reser.Text & "','" & "RV" & "','" & Nueva_Reserva.CBoxUbicacion_reser.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Reserva Anulada", MsgBoxStyle.Information, "Boromir Dice:")
                        Call F_Boton_buscar.Boton_Buscar()
                    Catch ex As Exception
                        MsgBox("Error Anular Reserva: " & ex.Message)
                    End Try

                Case "Movimientos"
                    Try
                        Variables.sSel = "Exec proc_anular_movimiento '" & Mov_inventarios.Txtcodigo_movprodu.Text & "','" & Mov_inventarios.CBConcepto.Text & "','" & Mov_inventarios.CBUbicacion.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Movimiento Anulado", MsgBoxStyle.Information, "Boromir Dice:")
                        Call F_Boton_buscar.Boton_Buscar()
                    Catch ex As Exception
                        MsgBox("Error Anular Movimiento: " & ex.Message)
                    End Try
                Case Else
                    MsgBox("Opcion no habilitada para esta accion", MsgBoxStyle.Information, "Boromir Dice:")
            End Select

            Variables.accion_sql = Mid(Variables.sSel, 1, 6)
            If Variables.accion_sql = "Exec p" Then
                Variables.buscar_from = InStr(Variables.sSel, "proc")
            End If
            If Variables.accion_sql = "insert" Then
                Variables.buscar_from = InStr(Variables.sSel, "values")
            End If
            If Variables.accion_sql = "select" Then
                Variables.buscar_from = InStr(Variables.sSel, "where")
            End If
            If Variables.accion_sql = "update" Then
                Variables.buscar_from = InStr(Variables.sSel, "set")
            End If
            If Variables.buscar_from <> 0 Then
                Variables.campos_auditoria = Variables.sSel.Substring(Variables.buscar_from)
            Else
                Variables.campos_auditoria = Mid(Variables.sSel, 1)
            End If

            Variables.campos_modificados = Variables.campos_auditoria.Replace(",", " - ")
            Variables.campos_auditoria = Variables.campos_modificados.Replace("'", " ")
            Variables.Des_auditoria = Variables.campos_auditoria
            Variables.sSel = "Exec proc_auditoria '" & Boromir.barra_estad_usuario.Text.ToUpper & "',ANULAR,'" & apps.ToUpper & "','" & Variables.Des_auditoria.ToUpper & "','" & Now() & "' "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
           
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Module

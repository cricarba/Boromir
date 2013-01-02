Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Module F_Boton_guardar
    Dim i As Integer
    Public Sub Boton_Guardar()
        Try
            Dim apps As String = Boromir.Tab1.SelectedTab.Text
            Select Case apps
                Case "Tipo Escenarios"
                    Try
                        Variables.sSel = "update tbl_tescenarios set cnombre_tescen ='" & Tipo_Escenarios.TxtNombre_cancha.Text & "' where ccodigo_tescen = '" & Tipo_Escenarios.TxtCodigo_cancha.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Tipo Escenario Actualizado ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Tipo Costo"
                    Try
                        Variables.sSel = "update tbl_tipocosto set mvalor_tcosto = '" & Integer.Parse(Tipo_Costo.TxValor_costo.Text) & "'where ccodigo_tcosto = '" & Tipo_Costo.TxtCodigo_costo.Text & "' and  ncod_ubica_tcosto ='" & Integer.Parse(Tipo_Costo.CBubic_tipocost.Text) & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Tipo Costo Actualizado ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Conceptos"
                    Try
                        Variables.sSel = "update tbl_conceptos set cnombre_conce = '" & Conceptos.TxtNombre_Concep.Text & "' where ccodigo_conce= '" & Conceptos.TxtCodigo_Concep.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Concepto Actualizado ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Documentos"
                    Try
                        Variables.sSel = "update tbl_tipodoc set cnombre_tipodoc = '" & Documentos.TxtNombre_doc.Text & "' where ccodigo_tipodoc = '" & Documentos.TxtCodigo_doc.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Documeto Actualizado ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Ciudades"
                    Try
                        Variables.sSel = "update tbl_ciudad set cnombre_ciudad = '" & Ciudades.TxtNombre_ciudad.Text & "' where ncodigo_ciudad = '" & Ciudades.TxtCodigo_ciudad.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Ciudad Actualizado ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Zonas"
                    Try
                        Variables.sSel = "update tbl_zonas set cnombre_zona = '" & Zonas.TxtNombre_Zona.Text & "' where ncodigo_zona = '" & Zonas.TxtCodigo_Zona.Text & "'and ncod_ciudad_zona ='" & Zonas.Txtciudad_zona.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Zona Actualizado ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Terceros"
                    Try
                        If Terceros.CheBoxCliente_terce.Checked = True Then
                            Variables.tercero_cliente = 1
                        Else
                            Variables.tercero_cliente = 0
                        End If
                        If Terceros.ChBoxProveedor_terce.Checked = True Then
                            Variables.tercero_proveedor = 1
                        Else
                            Variables.tercero_proveedor = 0
                        End If
                        If Terceros.ChBoxEmpleado_terce.Checked = True Then
                            Variables.tercero_empleado = 1
                        Else
                            Variables.tercero_empleado = 0
                        End If
                        Variables.sSel = "update tbl_terceros set ccod_tipodoc_terce = '" & Terceros.CBTipodoc.Text & "', cnombre_terce = '" & Terceros.TxtNombre1_terce.Text & "', cnombre2_terce = '" & Terceros.TxtNombre2_terce.Text & "', capellido_terce = '" & Terceros.Txtapellido_terce.Text & "', capellido2_terce = '" & Terceros.TxtApellido_terce2.Text & "', ntelefono_terce = '" & Terceros.TxtTelefono_terce.Text & "', ncelular_terce = '" & Terceros.TxtCelular_terce.Text & "',  cdireccion_terce = '" & Terceros.TxtDireccion_terce.Text & "', ncod_ciudad_terce = '" & Terceros.CBoxCiudad_terce.Text & "', cemail_terce = '" & Terceros.Txtcorreo_terce.Text & "',ncliente_terce = '" & Variables.tercero_cliente & "',nproveedor_terce = '" & Variables.tercero_proveedor & "', nempleado_terce = '" & Variables.tercero_empleado & "'  where ncodigo_terce = '" & Terceros.TxtCodigo_terce.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Tercero Actualizado ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Ubicaciones"
                    Try
                        If Ubicaciones.CheckBox1.Checked = True Then
                            Variables.ubic_costo = 1
                        Else
                            Variables.ubic_costo = 0
                        End If

                        Variables.sSel = "update tbl_ubicaciones set cnombre_ubica = '" & Ubicaciones.TxtNombre_ubica.Text & "',cdireccion_ubica = '" & Ubicaciones.TxtDireccion_ubica.Text & "',ntelefono_ubica = '" & Integer.Parse(Ubicaciones.TxtTelefono_ubica.Text) & "',ncelular_ubica = '" & Int64.Parse(Ubicaciones.TxtCelular_ubica.Text) & "',ccorreo_ubica = '" & Ubicaciones.TxtCorreo_Ubica.Text & "',ncod_ciudad_ubica = '" & Integer.Parse(Ubicaciones.CBoxCiudad_ubica.Text) & "',ncod_zona_ubica = '" & Integer.Parse(Ubicaciones.CBoxZona_ubica.Text) & "',ncod_admon_ubica='" & Integer.Parse(Ubicaciones.TxtCedula_ubica.Text) & "', ncobro_ubica = '" & Variables.ubic_costo & "' where ncodigo_ubica = '" & Integer.Parse(Ubicaciones.Txtcodigo.Text) & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Ubicacion Actualizada ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Escenario X ubicacion"
                    Try
                        Variables.sSel = "update tbl_escenarios set   ctipo_escen = '" & EscenarioXubica.CBTipo_EXU.Text & "', cnombre_escen = '" & EscenarioXubica.TxtNombre_EXU.Text & "'  where ncodigo_escen = '" & EscenarioXubica.TxtNombre_EXU.Text & "' and ncod_ubica_escen = '" & EscenarioXubica.CBUbic_EXU.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Escenario X ubicacion Actualizado ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Turnos"
                    Try
                        Variables.sSel = "update tbl_turnos set cnombre_turno = '" & Turnos.TxtNombre_turno.Text = "" & "', where ncodigo_turno = '" & Turnos.TxtCodigo_turno.Text & "' and ncod_hinicio_turno = '" & Turnos.TxtHora_inicio.Text & "' and ncod_hfinal_turno = '" & Turnos.TxtHora_Final.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Turno Actualizado ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Costo Turno"
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "update  tbl_costoturno set ccod_tcosto_costurno = '" & Costo_Turno.CBLunes.Text & "' where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Monday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Lunes " & ex.Message)
                    End Try
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "update  tbl_costoturno set ccod_tcosto_costurno = '" & Costo_Turno.CBMartes.Text & "' where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Tuesday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Martes" & ex.Message)
                    End Try
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "update  tbl_costoturno set ccod_tcosto_costurno = '" & Costo_Turno.CBMiercoles.Text & "' where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Wednesday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Miercoles" & ex.Message)
                    End Try
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "update  tbl_costoturno set ccod_tcosto_costurno = '" & Costo_Turno.CBJueves.Text & "' where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Thursday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Jueves" & ex.Message)
                    End Try
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "update  tbl_costoturno set ccod_tcosto_costurno = '" & Costo_Turno.CBViernes.Text & "' where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Friday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Viernes" & ex.Message)
                    End Try
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "update  tbl_costoturno set ccod_tcosto_costurno = '" & Costo_Turno.CBSabado.Text & "' where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Saturday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Sabado" & ex.Message)
                    End Try
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "update  tbl_costoturno set ccod_tcosto_costurno = '" & Costo_Turno.CBDomingo.Text & "' where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Sunday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Domingo" & ex.Message)
                    End Try
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "update  tbl_costoturno set ccod_tcosto_costurno = '" & Costo_Turno.CBFestivo.Text & "' where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Festivo' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Tabla de Costos Actualizada ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: Festivo" & ex.Message)
                    End Try
                Case "Nueva Reserva"
                    Try
                        Variables.sSel = "update tbl_reservas set ncod_ubic_reser = '" & Nueva_Reserva.CBoxUbicacion_reser.Text & "',ffecha_reser = '" & Nueva_Reserva.TxtFecha_reser.Text & "' ,hhora_reser = '" & Nueva_Reserva.MTxtHora_reser.Text & "', ncod_escen_reser = '" & Nueva_Reserva.TxtDatos_Cod_escen.Text & "' , ncod_terce_reser = '" & Nueva_Reserva.TxtDocumento_terce_reser.Text & "', ccod_estad_reser = '" & Nueva_Reserva.CBEstado_reser.Text & "', ccod_tcosto_reser = '" & Nueva_Reserva.TxtDatos_tipocosto.Text & " where  ncodigo_reser = '" & Nueva_Reserva.TxtReserva_reser.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Reserva Actualizada", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Facturas"
                    Try
                        Variables.sSel = "Select * from tbl_facturas where  ncodigo_factu='" & Integer.Parse(Facturas.TxtFactura_factu.Text) & "' and ccod_conce_factu = '" & Facturas.CBConcepto_factu.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(bf)
                        If bf.Rows.Count = 0 Then
                            Try
                                Variables.sSel = "insert into tbl_facturas (ncodigo_factu,ncod_ubic_factu,ncod_terce_factu,ffecha_factu,ccod_conce_factu,ccod_estad_factu,nneto_factu,nimpuesto_factu,ndescuento_factu,ntotal_factu) values ('" & Facturas.TxtFactura_factu.Text & "','" & Facturas.CBoxUbicacion_factu.Text & "','" & Facturas.TxtDocumento_terce_factu.Text & "','" & Facturas.TxtFecha_factu.Text & "','" & Facturas.CBConcepto_factu.Text & "','AC',0,0,0,0)"
                                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                Variables.da.Fill(dt)
                                Facturas.TBtnNuevodetalle.Enabled = True
                                Facturas.TBtneliminardetalle.Enabled = True
                            Catch ex As Exception
                                MsgBox("Error Guardando Maestro: " & ex.Message)
                            End Try
                        ElseIf bf.Rows.Count >= 1 Then
                            Try
                                Variables.sSel = "Update tbl_facturas set ncod_terce_factu = '" & Facturas.TxtDocumento_terce_factu.Text & "', ffecha_factu = '" & Facturas.TxtFecha_factu.Text & "' where  ncodigo_factu='" & Integer.Parse(Facturas.TxtFactura_factu.Text) & "' and ccod_conce_factu = '" & Facturas.CBConcepto_factu.Text & "'"
                                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                Variables.da.Fill(dt)
                                MsgBox("Factura Actualizada", MsgBoxStyle.Information, "Boromir dice:")
                                Facturas.TBtnNuevodetalle.Enabled = True
                                Facturas.TBtneliminardetalle.Enabled = True
                            Catch ex As Exception
                                MsgBox("Error Actualizar: " & ex.Message)
                            End Try
                        End If
                    Catch ex As Exception
                        MsgBox("Error Consultando: " & ex.Message)
                    End Try
                    Variables.bf.Clear()
                Case "Pedidos"
                    Try
                        Variables.sSel = "Select * from tbl_pedidos where  ncodigo_pedid='" & Integer.Parse(Pedidos.TxtFactura_factu.Text) & "' and ccod_conce_pedid = '" & Pedidos.CBConcepto.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(bf)
                        If bf.Rows.Count = 0 Then
                            Try
                                Variables.sSel = "insert into tbl_pedidOs (ncodigo_pedid,ncod_ubic_pedid,ncod_terce_pedid,ffecha_pedid,ccod_conce_pedid,ccod_estad_pedid,nneto_pedid,nimpuesto_pedid,ndescuento_pedid,ntotal_pedid,cobservacion_pedid) values ('" & Pedidos.TxtFactura_factu.Text & "','" & Pedidos.CBUbicacion.Text & "','" & Pedidos.TxtDocumento_terce_factu.Text & "','" & Pedidos.TxtFecha_factu.Text & "','" & Pedidos.CBConcepto.Text & "','AC',0,0,0,0,'" & Pedidos.txt_observaciones.Text & "')"
                                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                Variables.da.Fill(dt)
                                Pedidos.TBtnNuevodetalle.Enabled = True
                                Pedidos.TBtneliminardetalle.Enabled = True
                            Catch ex As Exception
                                MsgBox("Error Guardando Maestro: " & ex.Message)
                            End Try
                        ElseIf bf.Rows.Count >= 1 Then
                            Try
                                Variables.sSel = "Update tbl_pedidos set ncod_terce_pedid = '" & Pedidos.TxtDocumento_terce_factu.Text & "', ffecha_pedid = '" & Pedidos.TxtFecha_factu.Text & "',cobservacion_pedid = '" & Pedidos.txt_observaciones.Text & "' where  ncodigo_pedid='" & Integer.Parse(Pedidos.TxtFactura_factu.Text) & "' and ccod_conce_pedid = '" & Pedidos.CBConcepto.Text & "'"
                                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                Variables.da.Fill(dt)
                                MsgBox("Pedidos Actualizada", MsgBoxStyle.Information, "Boromir dice:")
                                Pedidos.TBtnNuevodetalle.Enabled = True
                                Pedidos.TBtneliminardetalle.Enabled = True
                            Catch ex As Exception
                                MsgBox("Error Actualizar: " & ex.Message)
                            End Try
                        End If
                    Catch ex As Exception
                        MsgBox("Error Consultando: " & ex.Message)
                    End Try
                    Variables.bf.Clear()
                Case "Cotizaciones"
                    Try
                        Variables.sSel = "Select * from tbl_cotizaciones where  ncodigo_cotiz='" & Integer.Parse(Cotizaciones.TxtFactura_factu.Text) & "' and ccod_conce_cotiz = '" & Cotizaciones.CBConcepto.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(bf)
                        If bf.Rows.Count = 0 Then
                            Try
                                Variables.sSel = "insert into tbl_cotizaciones (ncodigo_cotiz,ncod_ubic_cotiz,ncod_terce_cotiz,ffecha_cotiz,ccod_conce_cotiz,ccod_estad_cotiz,nneto_cotiz,nimpuesto_cotiz,ndescuento_cotiz,ntotal_cotiz,cobservacion_cotiz) values ('" & Cotizaciones.TxtFactura_factu.Text & "','" & Cotizaciones.CBUbicacion.Text & "','" & Cotizaciones.TxtDocumento_terce_factu.Text & "','" & Cotizaciones.TxtFecha_factu.Text & "','" & Cotizaciones.CBConcepto.Text & "','AC',0,0,0,0,'" & Cotizaciones.txt_observaciones.Text & "')"
                                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                Variables.da.Fill(dt)
                                Cotizaciones.TBtnNuevodetalle.Enabled = True
                                Cotizaciones.TBtneliminardetalle.Enabled = True
                            Catch ex As Exception
                                MsgBox("Error Guardando Maestro: " & ex.Message)
                            End Try
                        ElseIf bf.Rows.Count >= 1 Then
                            Try
                                Variables.sSel = "Update tbl_cotizaciones set ncod_terce_cotiz = '" & Cotizaciones.TxtDocumento_terce_factu.Text & "', ffecha_cotiz = '" & Cotizaciones.TxtFecha_factu.Text & "',cobservacion_cotiz = '" & Cotizaciones.txt_observaciones.Text & "' where  ncodigo_cotiz='" & Integer.Parse(Cotizaciones.TxtFactura_factu.Text) & "' and ccod_conce_cotiz = '" & Cotizaciones.CBConcepto.Text & "'"
                                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                Variables.da.Fill(dt)
                                MsgBox("Cotizacion Actualizada", MsgBoxStyle.Information, "Boromir dice:")
                                Cotizaciones.TBtnNuevodetalle.Enabled = True
                                Cotizaciones.TBtneliminardetalle.Enabled = True
                            Catch ex As Exception
                                MsgBox("Error Actualizar: " & ex.Message)
                            End Try
                        End If
                    Catch ex As Exception
                        MsgBox("Error Consultando: " & ex.Message)
                    End Try
                    Variables.bf.Clear()
                Case "Orden de Compra"
                    Try
                        Variables.sSel = "Select * from tbl_ordenes where  ncodigo_orden='" & Integer.Parse(Ordenes_Compra.Txtnumero.Text) & "' and ccod_conce_orden = '" & Ordenes_Compra.CBConcepto.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(bf)
                        If bf.Rows.Count = 0 Then
                            Try
                                Variables.sSel = "insert into tbl_ordenes (ncodigo_orden,ncod_ubic_orden,ncod_terce_orden,ffecha_orden,ccod_conce_orden,ccod_estad_orden,nneto_orden,nimpuesto_orden,ndescuento_orden,ntotal_orden) values ('" & Ordenes_Compra.Txtnumero.Text & "','" & Ordenes_Compra.CBUbicacion.Text & "','" & Ordenes_Compra.TxtDocumento_terce_factu.Text & "','" & Ordenes_Compra.TxtFecha_factu.Text & "','" & Ordenes_Compra.CBConcepto.Text & "','AC',0,0,0,0)"
                                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                Variables.da.Fill(dt)
                                Ordenes_Compra.TBtnNuevodetalle.Enabled = True
                                Ordenes_Compra.TBtneliminardetalle.Enabled = True
                            Catch ex As Exception
                                MsgBox("Error Guardando Maestro: " & ex.Message)
                            End Try
                        ElseIf bf.Rows.Count >= 1 Then
                            Try
                                Variables.sSel = "Update tbl_ordenes set ncod_terce_orden = '" & Ordenes_Compra.TxtDocumento_terce_factu.Text & "', ffecha_orden = '" & Ordenes_Compra.TxtFecha_factu.Text & "' where  ncodigo_orden='" & Integer.Parse(Ordenes_Compra.Txtnumero.Text) & "' and ccod_conce_orden = '" & Ordenes_Compra.CBConcepto.Text & "'"
                                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                Variables.da.Fill(dt)
                                MsgBox("Orden de Compra Actualizada", MsgBoxStyle.Information, "Boromir dice:")
                                Ordenes_Compra.TBtnNuevodetalle.Enabled = True
                                Ordenes_Compra.TBtneliminardetalle.Enabled = True
                            Catch ex As Exception
                                MsgBox("Error Actualizar: " & ex.Message)
                            End Try
                        End If
                    Catch ex As Exception
                        MsgBox("Error Consultando: " & ex.Message)
                    End Try
                    Variables.bf.Clear()
                Case "Perfiles"
                    Try
                        Variables.sSel = "UPDATE tbl_perfiles set ccrear_perfil = '" & Perfiles.CBcrear.Text & "', cconsultar_perfil = '" & Perfiles.CBconsultar.Text & "',  cmodificar_perfil = '" & Perfiles.CBactualizar.Text & "',cconfirmar_perfil = '" & Perfiles.CBconfirmar.Text & "', creversar_perfil = '" & Perfiles.CBreversar.Text & "', canular_perfil = '" & Perfiles.CBanular.Text & "' ,cimprimir_perfil = '" & Perfiles.CBimprimir.Text & "', csql_perfil = '" & Perfiles.CBconsola.Text & "',ccod_estad_perfil = '" & Perfiles.CBEstado.Text & "' where ncodigo_perfil ='" & Perfiles.TxtCodigo_perfil.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error Botones: " & ex.Message)
                    End Try
                    Try
                        Variables.sSel = "UPDATE tbl_aplicperfil set documentos_admon = '" & Perfiles.documentos_admon.Text & "',  conceptos_admon = '" & Perfiles.conceptos_admon.Text & "',escenarios_admon = '" & Perfiles.escenarios_admon.Text & "', costos_admon = '" & Perfiles.costos_admon.Text & "', cuidades_admon = '" & Perfiles.cuidades_admon.Text & "', zonas_admon= '" & Perfiles.zonas_admon.Text & "' , terceros_admon = '" & Perfiles.terceros_admon.Text & "' , ubicaciones_admon = '" & Perfiles.ubicaciones_admon.Text & "', escenxubica_admon = '" & Perfiles.escenxubica_admon.Text & "',tblcostos_admon = '" & Perfiles.tblcostos_admon.Text & "', productos_inven= '" & Perfiles.productos_inven.Text & "', movimientos_inven = '" & Perfiles.movimientos_inven.Text & "', saldos_inven= '" & Perfiles.saldos_inven.Text & "', ordenes_inven= '" & Perfiles.Ordenes_segur.Text & "' ,facturas_factu = '" & Perfiles.facturas_factu.Text & "', pedidos_factu = '" & Perfiles.Pedidos_factu.Text & "',cotizaciones_factu = '" & Perfiles.cotizaciones_factu.Text & "',reservas_factu = '" & Perfiles.reservas_factu.Text & "',administraivos_report = '" & Perfiles.administraivos_report.Text & "',inventarios_report = '" & Perfiles.inventarios_report.Text & "', facturacion_report = '" & Perfiles.facturacion_report.Text & "', perfiles_segur = '" & Perfiles.perfiles_segur.Text & "',usuarios_segur = '" & Perfiles.usuarios_segur.Text & "',claves_segur = '" & Perfiles.claves_segur.Text & "',empresa_segur = '" & Perfiles.empresa_segur.Text & "', licencia_segur = '" & Perfiles.Licencia_segur.Text & "', auditoria_segur = '" & Perfiles.Auditoria_segur.Text & "' where ncod_perfil_aplicperfil = '" & Perfiles.TxtCodigo_perfil.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Perfil Actualizado", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error Aplicaciones: " & ex.Message)
                    End Try
                Case "Usuarios"
                    Try
                        Variables.sSel = "UPDATE tbl_usuarios set  ccontraseña_usua = '" & Usuarios.Txtconfirmacontraseña_perfil.Text & "', ncod_ubic_usua= '" & Usuarios.CBUbica_Usuarios.Text & "',ncod_perfil_usua = '" & Usuarios.CBPerfil_usuario.Text & "',ccod_estad_usua= '" & Usuarios.CBEstado_Usuarios.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Usuario Actualizado", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Productos"
                    Variables.sSel = "UPDATE tbl_productos set ncod_externo_produ = '" & Int64.Parse(Productos.Txtcodigoext_produ.Text) & "',cnombre_produ = '" & Productos.TxtNombre_produ.Text & "',ccod_categ_produ = '" & Productos.TxtCategoria_produ.Text & "',ccod_marca_produ = '" & Productos.TxtMarca_produ.Text & "',ccod_und_produ = '" & Productos.TxtUnidad_produ.Text & "',ffecha_vence_produ = '" & Productos.TxtFechavence_produ.Text & "',nalto_produ = '" & Integer.Parse(Productos.Txtalto_produ.Text) & "',nancho_produ = '" & Integer.Parse(Productos.TxtAncho_produ.Text) & "',nlargo_produ = '" & Integer.Parse(Productos.TxtLargo_produ.Text) & "',ncapacidad_produ = '" & Integer.Parse(Productos.TxtCapacidad_produ.Text) & "',ndiametro_produ = '" & Integer.Parse(Productos.Txtdiametro_produ.Text) & "',npeso_produ = '" & Integer.Parse(Productos.TxtPeso_produ.Text) & "',ccod_color_produ = '" & Productos.TxtColor_produ.Text & "',nimpuesto_produ = '" & Integer.Parse(Productos.Txtiva_produ.Text) & "',ndescuento_produ = '" & Integer.Parse(Productos.Txtdescuento_produ.Text) & "',nprecio_compra_produ = '" & Integer.Parse(Productos.Txtcompra_produ.Text) & "',nprecio_venta_produ = '" & Integer.Parse(Productos.TxtVenta_produ.Text) & "', cobservacion_produ = '" & Productos.Txtobservacion_produ.Text & "',ccombo_produ = '" & Productos.CB_Combo.Text & "' where ncodigo_produ = '" & Productos.Txtcodigo_produ.Text & "' "
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dt)
                    If Variables.update_imagen = True Then
                        Dim archivo As String = Variables.carpeta_imagenes & "\" & Productos.Txtcodigo_produ.Text & ".jpg"
                        FileOpen(1, archivo, OpenMode.Append)
                        FileClose(1)
                        Kill(Variables.carpeta_imagenes & "\" & Productos.Txtcodigo_produ.Text & ".jpg")
                        ruta_imagen_guardar = Variables.carpeta_imagenes & "\" & Productos.Txtcodigo_produ.Text & ".jpg"
                        Productos.Imagen_produc.Image.Save(ruta_imagen_guardar)
                    End If
                    If Productos.CB_Combo.Text = "SI" Then
                        Try
                            Variables.sSel = "select * from tbl_combos where ncodigo_combo = '" & Integer.Parse(Productos.Txtcodigo_produ.Text) & "'"
                            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                            Variables.da.Fill(dt)
                            Dim rowcomponente As DataRow
                            Dim codigo, cantidad As String
                            Dim dtcombo As New DataTable
                            dtcombo = Productos.dtviewcombos.DataSource
                            If dt.Rows.Count > 0 Then
                                For Each rowcomponente In dtcombo.Rows
                                    codigo = rowcomponente.Item(1).ToString
                                    cantidad = rowcomponente.Item(2).ToString
                                    Variables.sSel = "update tbl_combos set ncantidad_componente_combo = '" & cantidad & "' where ncodigo_combo = '" & Integer.Parse(Productos.Txtcodigo_produ.Text) & "' and  ncod_componente_combo = '" & codigo & "'"
                                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                    Variables.da.Fill(dt)
                                Next
                            Else
                                For Each rowcomponente In dtcombo.Rows
                                    codigo = rowcomponente.Item(1).ToString
                                    cantidad = rowcomponente.Item(3).ToString
                                    Variables.sSel = "insert into tbl_combos (ncodigo_combo, ncod_componente_combo,ncantidad_componente_combo) values ('" & Productos.Txtcodigo_produ.Text & "','" & codigo & "','" & cantidad & "')"
                                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                    Variables.da.Fill(dt)
                                Next
                            End If
                        Catch ex As Exception
                            MsgBox("Error: " & ex.Message)
                        End Try
                    End If
                    MsgBox("Producto Actualizado", MsgBoxStyle.Information, "Boromir Dice:")
                Case "Movimientos"
                    Try
                        Dim bm As New DataTable
                        Variables.sSel = "Select * from tbl_movimiento_producto where  ncodigo_moviprodu='" & Integer.Parse(Mov_inventarios.Txtcodigo_movprodu.Text) & "' and ccod_conce_moviprodu = '" & Mov_inventarios.CBConcepto.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(bm)
                        If bm.Rows.Count = 0 Then
                            Try
                                Variables.sSel = "insert into tbl_movimiento_producto (ncodigo_moviprodu,ncod_ubica_moviprodu,ncod_terce_moviprodu,ffecha_moviprodu,ccod_conce_moviprodu,ccod_estad_moviprodu,nneto_moviprodu,nimpuesto_moviprodu,ndescuento_moviprodu,ntotal_moviprodu) values ('" & Integer.Parse(Mov_inventarios.Txtcodigo_movprodu.Text) & "','" & Integer.Parse(Mov_inventarios.CBUbicacion.Text) & "','" & Integer.Parse(Mov_inventarios.TxtDocumento_terce_factu.Text) & "','" & Mov_inventarios.TxtFecha_reser.Text & "','" & Mov_inventarios.CBConcepto.Text & "','AC',0,0,0,0)"
                                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                Variables.da.Fill(dt)
                                Mov_inventarios.TBtnNuevodetalle.Enabled = True
                                Mov_inventarios.TBtneliminardetalle.Enabled = True
                            Catch ex As Exception
                                MsgBox("Error Guardando Maestro: " & ex.Message)
                            End Try
                        ElseIf bm.Rows.Count >= 1 Then
                            Try
                                Variables.sSel = "Update tbl_movimiento_producto set ncod_terce_moviprodu = '" & Mov_inventarios.TxtDocumento_terce_factu.Text & "', ffecha_moviprodu = '" & Mov_inventarios.TxtFecha_reser.Text & "' where  ncodigo_moviprodu= '" & Integer.Parse(Mov_inventarios.Txtcodigo_movprodu.Text) & "' and ccod_conce_moviprodu = '" & Mov_inventarios.CBConcepto.Text & "'"
                                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                Variables.da.Fill(dt)
                                MsgBox("Movimiento Actualizado", MsgBoxStyle.Information, "Boromir dice:")
                                Mov_inventarios.TBtnNuevodetalle.Enabled = True
                                Mov_inventarios.TBtneliminardetalle.Enabled = True
                            Catch ex As Exception
                                MsgBox("Error Actualizar: " & ex.Message)
                            End Try
                        End If
                    Catch ex As Exception
                        MsgBox("Error Consultando: " & ex.Message)
                    End Try
                    Variables.bf.Clear()
                Case "Empresa"
                    Variables.sSel = "update tbl_empresa set cnombre_empre = '" & Empresa.TxtNombre.Text & "',nnit_empre = '" & Integer.Parse(Empresa.Txt_nit.Text) & "',cdireccion_empre = '" & Empresa.TxtDireccion.Text & "',ntelefono_empre = '" & Integer.Parse(Empresa.TxtTelefono_ubica.Text) & "',ncelular_empre = '" & Empresa.TxtCelular_ubica.Text & "',ccorreo_empre = '" & Empresa.TxtCorreo_Ubica.Text & "',cruta_repor_empre = '" & Empresa.TxtReportes.Text & "' ,cruta_produ_empre = '" & Empresa.TxtRutaimgpro.Text & "' ,cruta_manual_empre = '" & Empresa.TxtManuales.Text & "',cclave_empre = '" & Empresa.TxTclave.Text & "',csmtp_empre = '" & Empresa.Txtsmpt.Text & "',cpuerto_empre = '" & Empresa.Txtpuerto.Text & "',cresolucion_empre = '" & Empresa.Txtresolucion.Text & "'"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dt)
                    MsgBox("Empresa Actualizada", MsgBoxStyle.Information, "Boromir Dice:")
                Case "Licencia"
                    Try
                        Variables.sSel = "update tbl_modulos set nuno_modul = '" & Licencia.a1.Text & "' , ndos_modul = '" & Licencia.a2.Text & "' , ntres_modul = '" & Licencia.a3.Text & "' ,  ncuatro_modul =  '" & Licencia.a4.Text & "' , ncinco_modul =  '" & Licencia.a5.Text & "' , nseis_modul =  '" & Licencia.a6.Text & "' where ccodigo_modul = 'ADMIN' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error ADMIN: " & ex.Message)
                    End Try
                    Try
                        Variables.sSel = "update tbl_modulos set nuno_modul = '" & Licencia.i1.Text & "' , ndos_modul = '" & Licencia.i2.Text & "' , ntres_modul = '" & Licencia.i3.Text & "' ,  ncuatro_modul =  '" & Licencia.i4.Text & "' , ncinco_modul =  '" & Licencia.i5.Text & "' , nseis_modul =  '" & Licencia.i6.Text & "' where ccodigo_modul = 'INVEN' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error INVEN: " & ex.Message)
                    End Try
                    Try
                        Variables.sSel = "update tbl_modulos set nuno_modul = '" & Licencia.f1.Text & "' , ndos_modul = '" & Licencia.f2.Text & "' , ntres_modul = '" & Licencia.f3.Text & "' ,  ncuatro_modul =  '" & Licencia.f4.Text & "' , ncinco_modul =  '" & Licencia.f5.Text & "' , nseis_modul =  '" & Licencia.f6.Text & "' where ccodigo_modul = 'FACTU' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error FACTU: " & ex.Message)
                    End Try
                    Try
                        Variables.sSel = "update tbl_modulos set nuno_modul = '" & Licencia.r1.Text & "' , ndos_modul = '" & Licencia.r2.Text & "' , ntres_modul = '" & Licencia.r3.Text & "' ,  ncuatro_modul =  '" & Licencia.r4.Text & "' , ncinco_modul =  '" & Licencia.r5.Text & "' , nseis_modul =  '" & Licencia.r6.Text & "' where ccodigo_modul = 'REPOR' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error REPOR: " & ex.Message)
                    End Try
                    Try
                        Variables.sSel = "update tbl_modulos set nuno_modul = '" & Licencia.s1.Text & "' , ndos_modul = '" & Licencia.s2.Text & "' , ntres_modul = '" & Licencia.s3.Text & "' ,  ncuatro_modul =  '" & Licencia.s4.Text & "' , ncinco_modul =  '" & Licencia.s5.Text & "' , nseis_modul =  '" & Licencia.s6.Text & "' where ccodigo_modul = 'SEGUR' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error SEGUR: " & ex.Message)
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
            Variables.sSel = "Exec proc_auditoria '" & Boromir.barra_estad_usuario.Text.ToUpper & "',GUARDAR,'" & apps.ToUpper & "','" & Variables.Des_auditoria.ToUpper & "','" & Now() & "' "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Module

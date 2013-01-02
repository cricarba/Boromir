Imports System.Data
Imports System.Data.SqlClient
Imports System.IO.FileStream
Imports System.IO
Imports System.IO.StreamReader
Imports System.Net.Mail
Module F_Boton_confirmar
    Dim i As Integer
    Public Sub Boton_Confirmar()
        Try
            Dim apps As String = Boromir.Tab1.SelectedTab.Text
            Select Case apps
                Case "Conceptos"
                    Try
                        Variables.sSel = "insert into tbl_conceptos (ccodigo_conce, cnombre_conce,ccod_aplic_conce,caccion_conce) values ('" & Conceptos.TxtCodigo_Concep.Text & "','" & Conceptos.TxtNombre_Concep.Text & "','" & Conceptos.CBAplic_concep.Text & "','" & Conceptos.CbAccion.Text & "') "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Concepto Creado ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Tipo Escenarios"
                    Try
                        Variables.sSel = "insert into tbl_tescenarios (cnombre_tescen, ccodigo_tescen) values ('" & Tipo_Escenarios.TxtNombre_cancha.Text & "','" & Tipo_Escenarios.TxtCodigo_cancha.Text & "') "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Tipo Escenario Creado ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Tipo Costo"
                    Try
                        Tipo_Costo.TxValor_costo.Text = Integer.Parse(Tipo_Costo.TxValor_costo.Text)
                        Tipo_Costo.CBubic_tipocost.Text = Integer.Parse(Tipo_Costo.CBubic_tipocost.Text)
                        Variables.sSel = "insert into tbl_tipocosto (mvalor_tcosto,ccodigo_tcosto,ncod_ubica_tcosto) values ('" & Tipo_Costo.TxValor_costo.Text & "', '" & Tipo_Costo.TxtCodigo_costo.Text & "', '" & Tipo_Costo.CBubic_tipocost.Text & "') "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Tipo Costo Creado", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Documentos"
                    Try
                        Variables.sSel = "insert into tbl_tipodoc (cnombre_tipodoc,ccodigo_tipodoc) values ('" & Documentos.TxtNombre_doc.Text & "','" & Documentos.TxtCodigo_doc.Text & "') "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Documento Creado ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Ciudades"
                    Try
                        Ciudades.TxtCodigo_ciudad.Text = Integer.Parse(Ciudades.TxtCodigo_ciudad.Text)
                        Variables.sSel = "insert into tbl_ciudad (cnombre_ciudad,ncodigo_ciudad) values ('" & Ciudades.TxtNombre_ciudad.Text & "','" & Ciudades.TxtCodigo_ciudad.Text & "') "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Ciudad Creada ", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Zonas"
                    Try
                        Variables.sSel = "insert into tbl_zonas (cnombre_zona,ncodigo_zona,ncod_ciudad_zona) values ('" & Zonas.TxtNombre_Zona.Text & "', '" & Integer.Parse(Zonas.TxtCodigo_Zona.Text) & "','" & Integer.Parse(Zonas.Txtciudad_zona.Text) & "') "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Zona Creada", MsgBoxStyle.Information, "Boromir Dice:")
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

                        Variables.sSel = "insert into tbl_terceros (ccod_tipodoc_terce,cnombre_terce,cnombre2_terce,capellido_terce,capellido2_terce,ntelefono_terce,ncelular_terce,cdireccion_terce,ncod_ciudad_terce,cemail_terce,ncodigo_terce, ncliente_terce,nproveedor_terce,nempleado_terce,ccod_estad_terce) values ('" & Terceros.CBTipodoc.Text & "','" & Terceros.TxtNombre1_terce.Text & "','" & Terceros.TxtNombre2_terce.Text & "','" & Terceros.Txtapellido_terce.Text & "','" & Terceros.TxtApellido_terce2.Text & "', '" & Integer.Parse(Terceros.TxtTelefono_terce.Text) & "', '" & Terceros.TxtCelular_terce.Text & "', '" & Terceros.TxtDireccion_terce.Text & "', '" & Integer.Parse(Terceros.CBoxCiudad_terce.Text) & "', '" & Terceros.Txtcorreo_terce.Text & "' , '" & Integer.Parse(Terceros.TxtCodigo_terce.Text) & "','" & Variables.tercero_cliente & "','" & Variables.tercero_proveedor & "','" & Variables.tercero_empleado & "','" & Terceros.CBEstado.Text & "') "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Tercero Creado", MsgBoxStyle.Information, "Boromir Dice:")
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
                        Variables.sSel = "insert into tbl_ubicaciones(ncodigo_ubica,cnombre_ubica,cdireccion_ubica,ntelefono_ubica,ncelular_ubica,ccorreo_ubica,ncod_ciudad_ubica,ncod_zona_ubica,ncod_admon_ubica,ncobro_ubica) values ('" & Integer.Parse(Ubicaciones.Txtcodigo.Text) & "','" & Ubicaciones.TxtNombre_ubica.Text & "','" & Ubicaciones.TxtDireccion_ubica.Text & "','" & Int64.Parse(Ubicaciones.TxtTelefono_ubica.Text) & "','" & Int64.Parse(Ubicaciones.TxtCelular_ubica.Text) & "','" & Ubicaciones.TxtCorreo_Ubica.Text & "','" & Ubicaciones.CBoxCiudad_ubica.Text & "','" & Ubicaciones.CBoxZona_ubica.Text & "','" & Integer.Parse(Ubicaciones.TxtCedula_ubica.Text) & "','" & Variables.ubic_costo & "')"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Ubicacion Creada ", MsgBoxStyle.Information, "UBICACIONES")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Escenario X ubicacion"
                    Try
                        Variables.sSel = "insert into tbl_escenarios (cnombre_escen,ncodigo_escen,ncod_ubica_escen,ctipo_escen,ccod_estad_escen) values  ('" & EscenarioXubica.TxtNombre_EXU.Text & "', '" & EscenarioXubica.TxtCodigo_EXU.Text & "' ,'" & EscenarioXubica.CBUbic_EXU.Text & "' , '" & EscenarioXubica.CBTipo_EXU.Text & "', '" & EscenarioXubica.CBEstado_EXU.Text & "' )"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Escenario asignado a la ubicacion", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Turnos"
                    Try
                        Variables.sSel = "insert into tbl_turnos (cnombre_turno, ncodigo_turno,ncod_hinicio_turno,ncod_hfinal_turno) values  ('" & Turnos.TxtNombre_turno.Text & "','" & Turnos.TxtCodigo_turno.Text & "','" & Turnos.TxtHora_inicio.Text & "','" & Turnos.TxtHora_Final.Text & "')"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Turno Creado", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Costo Turno"
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Insert into tbl_costoturno (ncod_ubica_costurno,ccod_tescen_costurno,cdia_costurno,chora_costurno,ccod_tcosto_costurno) values ('" & Costo_Turno.CBubic_tabla_costo.Text & "', '" & Costo_Turno.CBtipoescen_costo_turno.Text & "', '" & "Monday" & "', '" & Costo_Turno.MTxt_hora.Text & "','" & Costo_Turno.CBLunes.Text & "' )"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Lunes " & ex.Message)
                    End Try
                    Variables.dt.Clear()
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Insert into tbl_costoturno (ncod_ubica_costurno,ccod_tescen_costurno,cdia_costurno,chora_costurno,ccod_tcosto_costurno) values ('" & Costo_Turno.CBubic_tabla_costo.Text & "', '" & Costo_Turno.CBtipoescen_costo_turno.Text & "', '" & "Tuesday" & "', '" & Costo_Turno.MTxt_hora.Text & "','" & Costo_Turno.CBMartes.Text & "' )"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Martes " & ex.Message)
                    End Try
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Insert into tbl_costoturno (ncod_ubica_costurno,ccod_tescen_costurno,cdia_costurno,chora_costurno,ccod_tcosto_costurno) values ('" & Costo_Turno.CBubic_tabla_costo.Text & "', '" & Costo_Turno.CBtipoescen_costo_turno.Text & "', '" & "Wednesday" & "', '" & Costo_Turno.MTxt_hora.Text & "','" & Costo_Turno.CBMiercoles.Text & "' )"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Miercoles" & ex.Message)
                    End Try
                    Variables.dt.Clear()
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Insert into tbl_costoturno (ncod_ubica_costurno,ccod_tescen_costurno,cdia_costurno,chora_costurno,ccod_tcosto_costurno) values ('" & Costo_Turno.CBubic_tabla_costo.Text & "', '" & Costo_Turno.CBtipoescen_costo_turno.Text & "', '" & "Thursday" & "', '" & Costo_Turno.MTxt_hora.Text & "','" & Costo_Turno.CBJueves.Text & "' )"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Jueves " & ex.Message)
                    End Try
                    Variables.dt.Clear()
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Insert into tbl_costoturno (ncod_ubica_costurno,ccod_tescen_costurno,cdia_costurno,chora_costurno,ccod_tcosto_costurno) values ('" & Costo_Turno.CBubic_tabla_costo.Text & "', '" & Costo_Turno.CBtipoescen_costo_turno.Text & "', '" & "Friday" & "', '" & Costo_Turno.MTxt_hora.Text & "','" & Costo_Turno.CBViernes.Text & "' )"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Viernes " & ex.Message)
                    End Try
                    Variables.dt.Clear()
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Insert into tbl_costoturno (ncod_ubica_costurno,ccod_tescen_costurno,cdia_costurno,chora_costurno,ccod_tcosto_costurno) values ('" & Costo_Turno.CBubic_tabla_costo.Text & "', '" & Costo_Turno.CBtipoescen_costo_turno.Text & "', '" & "Saturday" & "', '" & Costo_Turno.MTxt_hora.Text & "','" & Costo_Turno.CBSabado.Text & "' )"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Sabado " & ex.Message)
                    End Try
                    Variables.dt.Clear()
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Insert into tbl_costoturno (ncod_ubica_costurno,ccod_tescen_costurno,cdia_costurno,chora_costurno,ccod_tcosto_costurno) values ('" & Costo_Turno.CBubic_tabla_costo.Text & "', '" & Costo_Turno.CBtipoescen_costo_turno.Text & "', '" & "Sunday" & "', '" & Costo_Turno.MTxt_hora.Text & "','" & Costo_Turno.CBDomingo.Text & "' )"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error: Domingo " & ex.Message)
                    End Try
                    Variables.dt.Clear()
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Insert into tbl_costoturno (ncod_ubica_costurno,ccod_tescen_costurno,cdia_costurno,chora_costurno,ccod_tcosto_costurno) values ('" & Costo_Turno.CBubic_tabla_costo.Text & "', '" & Costo_Turno.CBtipoescen_costo_turno.Text & "', '" & "Festivo" & "', '" & Costo_Turno.MTxt_hora.Text & "','" & Costo_Turno.CBFestivo.Text & "' )"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Valores insertados, Ubicacion: " & Boromir.Barra_estad_ubica.Text & "Tipo de Escenario: " & Costo_Turno.CBtipoescen_costo_turno.Text & "Hora: " & Costo_Turno.MTxt_hora.Text, MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: Festivo " & ex.Message)
                    End Try
                    Variables.dt.Clear()
                Case "Nueva Reserva"
                    Try
                        Variables.sSel = "Insert into tbl_reservas (ncodigo_reser ,ncod_ubic_reser ,ffecha_reser ,hhora_reser,ncod_escen_reser ,ncod_terce_reser,ccod_estad_reser,ccod_tcosto_reser) values ('" & Nueva_Reserva.TxtReserva_reser.Text & "','" & Nueva_Reserva.CBoxUbicacion_reser.Text & "','" & Variables.fechas & "','" & Nueva_Reserva.MTxtHora_reser.Text & "','" & Nueva_Reserva.TxtDatos_Cod_escen.Text & "', '" & Nueva_Reserva.TxtDocumento_terce_reser.Text & "','AC','" & Trim(Nueva_Reserva.TxtDatos_tipocosto.Text) & "')"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Try
                            Variables.sSel = "Exec proc_crea_fact_reser "
                            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                            Variables.da.Fill(dt)
                            MsgBox("Reserva Creada", MsgBoxStyle.Information, "Boromir Dice:")
                        Catch ex As Exception
                            MsgBox("Error Creacion Factura: " & ex.Message)
                        End Try
                    Catch ex As Exception
                        MsgBox("Error Datos Reserva: " & ex.Message)
                    End Try

                Case "Facturas"
                    Dim estado As String = 0
                    Try
                        Variables.sSel = ""
                        Variables.sSel = "exec proc_confirma_movimiento '" & Integer.Parse(Facturas.TxtFactura_factu.Text) & "','" & Facturas.CBConcepto_factu.Text & "','" & Integer.Parse(Facturas.CBoxUbicacion_factu.Text) & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        estado = 1
                        MsgBox("Factura Confirmada", MsgBoxStyle.Information, "Boromir Dice:")
                        'Call F_Boton_buscar.Boton_Buscar()
                    Catch ex As Exception
                        MsgBox("Error Confirmando Factura: " & ex.Message)
                    End Try
                    If Facturas.CBConcepto_factu.Text = "FR" Then
                        Try
                            Variables.sSel = "Update tbl_reservas set ccod_estad_reser = 'CF' where ncodigo_reser = '" & Facturas.TxtFactura_factu.Text & "'"
                            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                            Variables.da.Fill(dt)
                        Catch ex As Exception
                            MsgBox("Error Confirmando Reserva: " & ex.Message)
                        End Try
                    End If
                Case "Cotizaciones"
                    Try
                        Variables.sSel = ""
                        Variables.sSel = "exec proc_confirma_movimiento '" & Integer.Parse(Cotizaciones.TxtFactura_factu.Text) & "','" & Cotizaciones.CBConcepto.Text & "','" & Integer.Parse(Cotizaciones.CBUbicacion.Text) & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Cotizacion Confirmada", MsgBoxStyle.Information, "Boromir Dice:")
                        Call F_Boton_buscar.Boton_Buscar()
                    Catch ex As Exception
                        MsgBox("Error Confirmando Cotizacion: " & ex.Message)
                    End Try
                Case "Pedidos"
                    Try
                        Variables.sSel = ""
                        Variables.sSel = "exec proc_confirma_movimiento '" & Integer.Parse(Pedidos.TxtFactura_factu.Text) & "','" & Pedidos.CBConcepto.Text & "','" & Integer.Parse(Pedidos.CBUbicacion.Text) & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Pedido Confirmado", MsgBoxStyle.Information, "Boromir Dice:")
                        Call F_Boton_buscar.Boton_Buscar()
                    Catch ex As Exception
                        MsgBox("Error Confirmando Pedido: " & ex.Message)
                    End Try
                Case "Orden de Compra"
                    Try
                        Variables.sSel = ""
                        Variables.sSel = "exec proc_confirma_orden '" & Integer.Parse(Ordenes_Compra.Txtnumero.Text) & "' ,'" & Ordenes_Compra.CBConcepto.Text & "','" & Integer.Parse(Ordenes_Compra.CBUbicacion.Text) & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Orden Confirmada", MsgBoxStyle.Information, "Boromir Dice:")
                        Call F_Boton_buscar.Boton_Buscar()
                    Catch ex As Exception
                        MsgBox("Error Confirmando Orden: " & ex.Message)
                    End Try
                Case "Perfiles"
                    Try
                        Variables.sSel = "INSERT into tbl_perfiles (ncodigo_perfil ,cnombre_perfil , ccrear_perfil , cconsultar_perfil ,  cmodificar_perfil ,  cconfirmar_perfil,creversar_perfil, canular_perfil ,cimprimir_perfil,csql_perfil,ccod_estad_perfil)values('" & Perfiles.TxtCodigo_perfil.Text & "', '" & Perfiles.TxtNombre_perfil.Text & "', '" & Perfiles.CBcrear.Text & "', '" & Perfiles.CBconsultar.Text & "', '" & Perfiles.CBactualizar.Text & "', '" & Perfiles.CBconfirmar.Text & "', '" & Perfiles.CBreversar.Text & "', '" & Perfiles.CBanular.Text & "','" & Perfiles.CBimprimir.Text & "','" & Perfiles.CBconsola.Text & "','" & Perfiles.CBEstado.Text & "')"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                    Catch ex As Exception
                        MsgBox("Error Botones: " & ex.Message)
                    End Try
                    Try
                        Variables.sSel = "INSERT into tbl_aplicperfil (ncod_perfil_aplicperfil,documentos_admon,conceptos_admon,escenarios_admon,costos_admon,cuidades_admon,zonas_admon,terceros_admon,ubicaciones_admon,escenxubica_admon,tblcostos_admon,productos_inven,movimientos_inven,saldos_inven,ordenes_inven,facturas_factu,cotizaciones_factu,pedidos_factu,reservas_factu,administraivos_report,inventarios_report,facturacion_report,perfiles_segur,usuarios_segur,	claves_segur,empresa_segur,licencia_segur,auditoria_segur)values('" & Perfiles.TxtCodigo_perfil.Text & "','" & Perfiles.documentos_admon.Text & "', '" & Perfiles.conceptos_admon.Text & "', '" & Perfiles.escenarios_admon.Text & "', '" & Perfiles.costos_admon.Text & "', '" & Perfiles.cuidades_admon.Text & "', '" & Perfiles.zonas_admon.Text & "', '" & Perfiles.terceros_admon.Text & "', '" & Perfiles.ubicaciones_admon.Text & "','" & Perfiles.escenxubica_admon.Text & "','" & Perfiles.tblcostos_admon.Text & "','" & Perfiles.productos_inven.Text & "','" & Perfiles.movimientos_inven.Text & "','" & Perfiles.saldos_inven.Text & "','" & Perfiles.Ordenes_segur.Text & "','" & Perfiles.facturas_factu.Text & "','" & Perfiles.cotizaciones_factu.Text & "','" & Perfiles.Pedidos_factu.Text & "','" & Perfiles.reservas_factu.Text & "','" & Perfiles.administraivos_report.Text & "','" & Perfiles.inventarios_report.Text & "','" & Perfiles.facturacion_report.Text & "','" & Perfiles.perfiles_segur.Text & "','" & Perfiles.usuarios_segur.Text & "','" & Perfiles.claves_segur.Text & "','" & Perfiles.empresa_segur.Text & "','" & Perfiles.Licencia_segur.Text & "','" & Perfiles.Auditoria_segur.Text & "')"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Perfil Creado", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error Aplicaciones: " & ex.Message)
                    End Try
                Case "Usuarios"
                    Try
                        Variables.sSel = "INSERT INTO tbl_usuarios (cnombre_usua, ccontraseña_usua ,ncod_ubic_usua,ncod_perfil_usua , ncod_terce_usua , ccod_estad_usua ) VALUES ('" & Usuarios.Txt_usuario_usua.Text & "','" & Usuarios.Txtconfirmacontraseña_perfil.Text & "','" & Usuarios.CBUbica_Usuarios.Text & "', '" & Usuarios.CBPerfil_usuario.Text & "', '" & Usuarios.TxtTercero_usua.Text & "','" & Usuarios.CBEstado_Usuarios.Text & "')"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Usuario Creado", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Productos"
                    Try
                        ruta_imagen_guardar = Variables.carpeta_imagenes & "\" & Productos.Txtcodigo_produ.Text & ".jpg"
                        Variables.sSel = "insert into tbl_productos (ncodigo_produ,ncod_externo_produ,cnombre_produ,cimagen_produ,ccod_categ_produ,ccod_marca_produ,ccod_und_produ,ffecha_vence_produ,nalto_produ,nancho_produ,nlargo_produ,ncapacidad_produ,ndiametro_produ,npeso_produ,ccod_color_produ,nimpuesto_produ,ndescuento_produ,nprecio_compra_produ,nprecio_venta_produ,ccombo_produ,cobservacion_produ) values('" & Int64.Parse(Productos.Txtcodigo_produ.Text) & "','" & Int64.Parse(Productos.Txtcodigoext_produ.Text) & "','" & Productos.TxtNombre_produ.Text & "','" & ruta_imagen_guardar & "','" & Productos.TxtCategoria_produ.Text & "','" & Productos.TxtMarca_produ.Text & "','" & Productos.TxtUnidad_produ.Text & "','" & Productos.TxtFechavence_produ.Text & "','" & Int64.Parse(Productos.Txtalto_produ.Text) & "','" & Integer.Parse(Productos.TxtAncho_produ.Text) & "','" & Integer.Parse(Productos.TxtLargo_produ.Text) & "', '" & Int64.Parse(Productos.TxtCapacidad_produ.Text) & "','" & Int64.Parse(Productos.Txtdiametro_produ.Text) & "','" & Integer.Parse(Productos.TxtPeso_produ.Text) & "','" & Productos.TxtColor_produ.Text & "','" & Int64.Parse(Productos.Txtiva_produ.Text) & "','" & Int64.Parse(Productos.Txtdescuento_produ.Text) & "','" & Int64.Parse(Productos.Txtcompra_produ.Text) & "','" & Int64.Parse(Productos.TxtVenta_produ.Text) & "','" & Productos.CB_Combo.Text & "','" & Productos.Txtobservacion_produ.Text & "')"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Productos.Imagen_produc.Image.Save(ruta_imagen_guardar)
                        If Productos.CB_Combo.Text = "SI" Then
                            Try
                                Dim rowcomponente As DataRow
                                Dim codigo, cantidad As String
                                Dim dtcombo As New DataTable
                                dtcombo = Productos.dtviewcombos.DataSource
                                For Each rowcomponente In dtcombo.Rows
                                    codigo = rowcomponente.Item(1).ToString
                                    cantidad = rowcomponente.Item(3).ToString
                                    Variables.sSel = "insert into tbl_combos (ncodigo_combo, ncod_componente_combo,ncantidad_componente_combo) values ('" & Productos.Txtcodigo_produ.Text & "','" & codigo & "','" & cantidad & "')"
                                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                    Variables.da.Fill(dt)
                                Next
                            Catch ex As Exception
                                MsgBox("Error: " & ex.Message)
                            End Try
                        End If
                        MsgBox("Producto Creado", MsgBoxStyle.Information, "Boromir Dice:")
                    Catch ex As Exception
                        MsgBox("Error Productos: " & ex.Message)
                    End Try
                Case "Movimientos"
                    Try
                        Variables.sSel = ""
                        Variables.sSel = "exec proc_confirma_movimiento '" & Integer.Parse(Mov_inventarios.Txtcodigo_movprodu.Text) & "','" & Mov_inventarios.CBConcepto.Text & "','" & Integer.Parse(Mov_inventarios.CBUbicacion.Text) & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        MsgBox("Movimiento Confirmado", MsgBoxStyle.Information, "Boromir Dice:")
                        Call F_Boton_buscar.Boton_Buscar()
                    Catch ex As Exception
                        MsgBox("Error proc_confirma_movimiento: " & ex.Message)
                    End Try
                Case "Empresa"
                    Try
                        Dim de As New DataTable
                        Variables.sSel = " select * from tbl_empresa"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(de)
                        If de.Rows.Count > 1 Then
                            MsgBox("Ya existe una empresa creada", MsgBoxStyle.Information, "Boromir Dice:")
                        Else
                            ruta_imagen_guardar = Variables.carpeta_imagenes & "\Empresa.jpg"
                            Variables.sSel = "insert into tbl_empresa (cnombre_empre,nnit_empre,cdireccion_empre,ntelefono_empre,ncelular_empre,ccorreo_empre,cruta_repor_empre,cruta_produ_empre,cruta_manual_empre,cclave_empre,csmtp_empre,cpuerto_empre,cresolucion_empre)values('" & Empresa.TxtNombre.Text & "','" & Integer.Parse(Empresa.Txt_nit.Text) & "', '" & Empresa.TxtDireccion.Text & "','" & Integer.Parse(Empresa.TxtTelefono_ubica.Text) & "','" & Empresa.TxtCelular_ubica.Text & "','" & Empresa.TxtCorreo_Ubica.Text & "','" & Empresa.TxtReportes.Text & "','" & Empresa.TxtRutaimgpro.Text & "','" & Empresa.TxtManuales.Text & "','" & Empresa.TxTclave.Text & "','" & Empresa.Txtsmpt.Text & "','" & Empresa.Txtpuerto.Text & "','" & Empresa.Txtresolucion.Text & "') "
                            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                            Variables.da.Fill(dt)
                            MsgBox("Empresa Creada", MsgBoxStyle.Information, "Boromir Dice:")
                        End If
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Mensajes"
                    Try
                        Dim ms As New DataTable
                        Dim correo_de, clave, hostsmtp As String
                        Dim i, puerto As Integer
                        Variables.sSel = " select ccorreo_empre,cclave_empre,csmtp_empre,cpuerto_empre from tbl_empresa"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(ms)
                        correo_de = ms.Rows(i)("ccorreo_empre").ToString
                        clave = ms.Rows(i)("cclave_empre").ToString
                        puerto = ms.Rows(i)("cpuerto_empre").ToString
                        hostsmtp = ms.Rows(i)("csmtp_empre").ToString
                        Dim Msj As MailMessage = New MailMessage()
                        Dim client As SmtpClient = New SmtpClient()
                        Msj.From = New MailAddress(correo_de)


                        If Mensajes.RBtnMasivo.Checked = True Then
                            Variables.sSel = " select cemail_terce from tbl_terceros"
                            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                            Variables.da.Fill(dt)
                            For i = 0 To (dt.Rows.Count - 1)
                                Mensajes.TxtPara.Text = Mensajes.TxtPara.Text & ";" & dt.Rows(i)("cemail_terce").ToString
                                Msj.Bcc.Add(New MailAddress(dt.Rows(i)("cemail_terce")))
                            Next
                        ElseIf Mensajes.RBtnNormal.Checked = True Then
                            If Mensajes.TxtPara.Text <> "" Then
                                Msj.To.Add(New MailAddress(Mensajes.TxtPara.Text))
                            End If
                            If Mensajes.TxtCC.Text <> "" Then
                                Msj.CC.Add(New MailAddress(Mensajes.TxtCC.Text))
                            End If
                            If Mensajes.TxtCCO.Text <> "" Then
                                Msj.Bcc.Add(New MailAddress(Mensajes.TxtCCO.Text))
                            End If

                        End If

                        If Variables.archivo_adjunto IsNot Nothing Then
                            Msj.Attachments.Add(Variables.archivo_adjunto)
                        End If
                        If Mensajes.TxtAsunto.Text <> "" Then
                            Msj.Subject = Mensajes.TxtAsunto.Text
                        End If
                        If Mensajes.TxtPara.Text = "" And Mensajes.TxtCC.Text = "" And Mensajes.TxtCCO.Text = "" Then
                            MsgBox("Debe Haber Al Menos Un Destinatario", MsgBoxStyle.Critical, "Boromir Dice:")
                        Else
                            Msj.Body = "<html><body><b></b><p>" + Mensajes.TxtBody.Text + ".</p><p><b>Enviado desde Boromir POS</b></body></html>"
                            Msj.IsBodyHtml = True
                            client.Credentials = New System.Net.NetworkCredential(correo_de, clave)
                            client.Port = Integer.Parse(puerto)
                            client.Host = hostsmtp
                            client.EnableSsl = True
                            client.Send(Msj)
                            MsgBox("Mensaje Enviado", MsgBoxStyle.Information, "Boromirm Dice.")
                        End If
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case Else
                    MsgBox("Opcion no habilitada para esta accion", MsgBoxStyle.Information, "Boromir Dice:")
            End Select


            Variables.accion_sql = Mid(Variables.sSel, 1, 6)
            If Variables.accion_sql = "exec p" Then
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
            Variables.sSel = "Exec proc_auditoria '" & Boromir.barra_estad_usuario.Text.ToUpper & "',CONFIRMAR,'" & apps.ToUpper & "','" & Variables.Des_auditoria.ToUpper & "','" & Now() & "' "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Module

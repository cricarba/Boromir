Imports System.Data
Imports System.Data.SqlClient
Module F_ultimo_registro
    Public Sub ultimo_registro()
        Try
            Dim apps As String = Boromir.Tab1.SelectedTab.Text
            Dim sr As New DataTable
            Select Case apps
                Case "Tipo Escenarios"
                    Try
                        Variables.sSel = "Select * from tbl_tescenarios"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)
                        Tipo_Escenarios.TxtNombre_cancha.Text = sr.Rows(sr.Rows.Count - 1)("cnombre_tescen").ToString()
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Tipo Costo"
                    Try
                        Variables.sSel = "Select * from tbl_tipocosto"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)
                        Tipo_Costo.CBubic_tipocost.Text = sr.Rows(sr.Rows.Count - 1)("ncod_ubica_tcosto").ToString()
                        Tipo_Costo.TxValor_costo.Text = sr.Rows(sr.Rows.Count - 1)("mvalor_tcosto").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Conceptos"
                    Try
                        Variables.sSel = "Select * from tbl_conceptos"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)
                        Conceptos.TxtCodigo_Concep.Text = sr.Rows(sr.Rows.Count - 1)("ccodigo_conce").ToString()
                        Conceptos.TxtNombre_Concep.Text = sr.Rows(sr.Rows.Count - 1)("cnombre_conce").ToString()
                        Conceptos.CBAplic_concep.Text = sr.Rows(sr.Rows.Count - 1)("ccod_aplic_conce").ToString()
                        Conceptos.CbAccion.Text = sr.Rows(sr.Rows.Count - 1)("caccion_conce").ToString
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Documentos"
                    Try
                        Variables.sSel = "Select * from tbl_tipodoc"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Documentos.TxtCodigo_doc.Text = sr.Rows(sr.Rows.Count - 1)("ccodigo_tipodoc").ToString()
                        Documentos.TxtNombre_doc.Text = sr.Rows(sr.Rows.Count - 1)("cnombre_tipodoc").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Ciudades"
                    Try
                        Variables.sSel = "Select * from tbl_ciudad  "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)
                        Ciudades.TxtNombre_ciudad.Text = sr.Rows(sr.Rows.Count - 1)("cnombre_ciudad").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Zonas"
                    Try
                        Variables.sSel = "Select * from tbl_zonas"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)
                        Zonas.TxtCodigo_Zona.Text = sr.Rows(sr.Rows.Count - 1)("ncodigo_zona").ToString()
                        Zonas.Txtciudad_zona.Text = sr.Rows(sr.Rows.Count - 1)("ncod_ciudad_zona").ToString()
                        Zonas.TxtNombre_Zona.Text = sr.Rows(sr.Rows.Count - 1)("cnombre_zona").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Terceros"
                    Try

                        Variables.sSel = "Select * from tbl_terceros"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Terceros.TxtCodigo_terce.Text = sr.Rows(sr.Rows.Count - 1)("ncodigo_terce").ToString()
                        Terceros.TxtNombre1_terce.Text = sr.Rows(sr.Rows.Count - 1)("cnombre_terce").ToString()
                        Terceros.TxtNombre2_terce.Text = sr.Rows(sr.Rows.Count - 1)("cnombre2_terce").ToString()
                        Terceros.Txtapellido_terce.Text = sr.Rows(sr.Rows.Count - 1)("capellido_terce").ToString()
                        Terceros.TxtApellido_terce2.Text = sr.Rows(sr.Rows.Count - 1)("capellido2_terce").ToString()
                        Terceros.TxtTelefono_terce.Text = sr.Rows(sr.Rows.Count - 1)("ntelefono_terce").ToString()
                        Terceros.TxtCelular_terce.Text = sr.Rows(sr.Rows.Count - 1)("ncelular_terce").ToString()
                        Terceros.TxtDireccion_terce.Text = sr.Rows(sr.Rows.Count - 1)("cdireccion_terce").ToString()
                        Terceros.CBTipodoc.Text = sr.Rows(sr.Rows.Count - 1)("ccod_tipodoc_terce").ToString()
                        Terceros.CBoxCiudad_terce.Text = sr.Rows(sr.Rows.Count - 1)("ncod_ciudad_terce").ToString()
                        Variables.tercero_cliente = sr.Rows(sr.Rows.Count - 1)("ncliente_terce").ToString()
                        Variables.tercero_proveedor = sr.Rows(sr.Rows.Count - 1)("nproveedor_terce").ToString()
                        Variables.tercero_empleado = sr.Rows(sr.Rows.Count - 1)("nempleado_terce").ToString()
                        Terceros.Txtcorreo_terce.Text = sr.Rows(sr.Rows.Count - 1)("cemail_terce").ToString()
                        If Variables.tercero_cliente = 1 Then
                            Terceros.CheBoxCliente_terce.Checked = True
                        End If
                        If Variables.tercero_proveedor = 1 Then
                            Terceros.ChBoxProveedor_terce.Checked = True
                        End If
                        If Variables.tercero_empleado = 1 Then
                            Terceros.ChBoxEmpleado_terce.Checked = True
                        End If
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Ubicaciones"
                    Try

                        Variables.sSel = "Select * from tbl_ubicaciones, tbl_terceros where ncod_admon_ubica = ncodigo_terce "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Ubicaciones.TxtNombre_ubica.Text = sr.Rows(sr.Rows.Count - 1)("cnombre_ubica").ToString()
                        Ubicaciones.TxtDireccion_ubica.Text = sr.Rows(sr.Rows.Count - 1)("cdireccion_ubica").ToString()
                        Ubicaciones.TxtTelefono_ubica.Text = sr.Rows(sr.Rows.Count - 1)("ntelefono_ubica").ToString()
                        Ubicaciones.TxtCelular_ubica.Text = sr.Rows(sr.Rows.Count - 1)("ncelular_ubica").ToString()
                        Variables.ubic_costo = sr.Rows(sr.Rows.Count - 1)("ncobro_ubica").ToString
                        Ubicaciones.TxtCorreo_Ubica.Text = sr.Rows(sr.Rows.Count - 1)("ccorreo_ubica").ToString()
                        Ubicaciones.TxtCedula_ubica.Text = sr.Rows(sr.Rows.Count - 1)("ncod_admon_ubica").ToString()
                        Ubicaciones.TxtNombre1_ubica.Text = sr.Rows(sr.Rows.Count - 1)("cnombre_terce").ToString()
                        Ubicaciones.TxtNombre2_ubica.Text = sr.Rows(sr.Rows.Count - 1)("cnombre2_terce").ToString()
                        Ubicaciones.TxtApellido1_ubica.Text = sr.Rows(sr.Rows.Count - 1)("capellido_terce").ToString()
                        Ubicaciones.TxtApellido2_ubica.Text = sr.Rows(sr.Rows.Count - 1)("capellido2_terce").ToString()
                        If Variables.ubic_costo = 1 Then
                            Ubicaciones.CheckBox1.Checked = True
                        End If
                        Ubicaciones.CBoxCiudad_ubica.Text = sr.Rows(sr.Rows.Count - 1)("ncod_ciudad_ubica").ToString()
                        Ubicaciones.CBoxZona_ubica.Text = sr.Rows(sr.Rows.Count - 1)("ncod_zona_ubica").ToString()

                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Escenario X ubicacion"
                    Try

                        Variables.sSel = "Select * from tbl_escenarios"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        EscenarioXubica.TxtCodigo_EXU.Text = sr.Rows(sr.Rows.Count - 1)("ncodigo_escen").ToString()
                        EscenarioXubica.TxtNombre_EXU.Text = sr.Rows(sr.Rows.Count - 1)("cnombre_escen").ToString()
                        EscenarioXubica.CBEstado_EXU.Text = sr.Rows(sr.Rows.Count - 1)("ccod_estad_escen").ToString()
                        EscenarioXubica.CBUbic_EXU.Text = sr.Rows(sr.Rows.Count - 1)("ncod_ubica_escen").ToString()
                        EscenarioXubica.CBTipo_EXU.Text = sr.Rows(sr.Rows.Count - 1)("ctipo_escen").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Turnos"
                    Try

                        Variables.codigo = Integer.Parse(EscenarioXubica.TxtCodigo_EXU.Text)
                        Variables.sSel = "Select * from tbl_turnos "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Turnos.TxtCodigo_turno.Text = sr.Rows(sr.Rows.Count - 1)("ncodigo_turno").ToString()
                        Turnos.TxtNombre_turno.Text = sr.Rows(sr.Rows.Count - 1)("cnombre_turno").ToString()
                        Turnos.CBubic_turnos.Text = sr.Rows(sr.Rows.Count - 1)("ncod_ubica_turno").ToString()
                        Turnos.TxtHora_inicio.Text = sr.Rows(sr.Rows.Count - 1)("ncod_hinicio_turno").ToString()
                        Turnos.TxtHora_Final.Text = sr.Rows(sr.Rows.Count - 1)("ncod_hfinal_turno").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Costo Turno"
                    Try


                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Costo_Turno.CBLunes.Text = sr.Rows(sr.Rows.Count - 1)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: Lunes " & ex.Message)
                    End Try

                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Tuesday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Costo_Turno.CBMartes.Text = sr.Rows(sr.Rows.Count - 1)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: Martes " & ex.Message)
                    End Try

                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno ='Wednesday'and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Costo_Turno.CBMiercoles.Text = sr.Rows(sr.Rows.Count - 1)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: Miercoles " & ex.Message)
                    End Try

                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Thursday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Costo_Turno.CBJueves.Text = sr.Rows(sr.Rows.Count - 1)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count

                    Catch ex As Exception
                        MsgBox("Error: Jueves " & ex.Message)
                    End Try

                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Friday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Costo_Turno.CBViernes.Text = sr.Rows(sr.Rows.Count - 1)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                    Catch ex As Exception
                        MsgBox("Error: Viernes " & ex.Message)
                    End Try

                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Saturday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Costo_Turno.CBSabado.Text = sr.Rows(sr.Rows.Count - 1)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                    Catch ex As Exception
                        MsgBox("Error: Sabado " & ex.Message)
                    End Try

                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Sunday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Costo_Turno.CBDomingo.Text = sr.Rows(sr.Rows.Count - 1)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                    Catch ex As Exception
                        MsgBox("Error: Domingo " & ex.Message)
                    End Try

                    Try
                        Dim ct As New DataTable
                        Variables.sSel = "select cdia_costurno Dia,chora_costurno Hora,ccod_tcosto_costurno Tipo_Costo,mvalor_tcosto Valor  from tbl_costoturno,tbl_tipocosto  where  ncod_ubica_costurno = '" & Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text) & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and ncod_ubica_costurno = ncod_ubica_tcosto AND ccodigo_tcosto = ccod_tcosto_costurno"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(ct)

                        Costo_Turno.data_costoturno.DataSource = ct
                    Catch ex As Exception
                        MsgBox("Error: Domingo " & ex.Message)
                    End Try
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Festivo' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Costo_Turno.CBFestivo.Text = sr.Rows(sr.Rows.Count - 1)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                    Catch ex As Exception
                        MsgBox("Error: Festivo " & ex.Message)
                    End Try
                    '---------------------------------
                    'Facturacion
                    '----------------------------------
                Case "Facturas"
                    Try

                        Variables.sSel = "Select * from tbl_facturas"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Facturas.TxtFactura_factu.Text = sr.Rows(sr.Rows.Count - 1)("ncodigo_factu").ToString
                        Facturas.CBConcepto_factu.Text = sr.Rows(sr.Rows.Count - 1)("ccod_conce_factu").ToString
                        Facturas.CBoxUbicacion_factu.Text = sr.Rows(sr.Rows.Count - 1)("ncod_ubic_factu").ToString
                        Facturas.TxtFecha_factu.Text = sr.Rows(sr.Rows.Count - 1)("ffecha_factu").ToString
                        Facturas.LblEstado.Text = sr.Rows(sr.Rows.Count - 1)("ccod_estad_factu").ToString
                        Facturas.gran_descuento.Text = sr.Rows(sr.Rows.Count - 1)("ndescuento_factu").ToString
                        Facturas.impuesto.Text = sr.Rows(sr.Rows.Count - 1)("nimpuesto_factu").ToString
                        Facturas.neto.Text = sr.Rows(sr.Rows.Count - 1)("nneto_factu").ToString
                        Facturas.gran_total.Text = sr.Rows(sr.Rows.Count - 1)("ntotal_factu").ToString
                        Facturas.TxtDocumento_terce_factu.Text = sr.Rows(sr.Rows.Count - 1)("ncod_terce_factu").ToString
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error Maestro: " & ex.Message)
                    End Try
                    Try
                        Variables.df.Clear()
                        Variables.sSel = "select ncod_produ_detmovim 'Codigo',cnombre_produ 'Nombre',ncantidad_detmovim 'Cantidad',ccod_und_produ'Unidad de Medida',nprecio_detmovim 'Precio',ndescuento_detmovim 'Descuento',nimpuesto_detmovim 'Impuesto' from tbl_detalle_movimientos, tbl_facturas,tbl_productos where ncod_movim_detmovim = ncodigo_factu and ncod_movim_detmovim = '" & Integer.Parse(Facturas.TxtFactura_factu.Text) & "' and ncod_produ_detmovim = ncodigo_produ and ccod_conce_detmovim = '" & Facturas.CBConcepto_factu.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(df)
                        Facturas.DetFac.DataSource = df
                        Facturas.TBtnNuevodetalle.Enabled = True
                        Facturas.TBtneliminardetalle.Enabled = True
                    Catch ex As Exception
                        MsgBox("Error Detalle: " & ex.Message)
                    End Try
                Case "Cotizaciones"
                    Try
                        Variables.sSel = "Select * from tbl_Cotizaciones"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Cotizaciones.TxtFactura_factu.Text = sr.Rows(sr.Rows.Count - 1)("ncodigo_cotiz").ToString
                        Cotizaciones.CBConcepto.Text = sr.Rows(sr.Rows.Count - 1)("ccod_conce_cotiz").ToString
                        Cotizaciones.CBUbicacion.Text = sr.Rows(sr.Rows.Count - 1)("ncod_ubic_cotiz").ToString
                        Cotizaciones.TxtFecha_factu.Text = sr.Rows(sr.Rows.Count - 1)("ffecha_cotiz").ToString
                        Cotizaciones.LblEstado.Text = sr.Rows(sr.Rows.Count - 1)("ccod_estad_cotiz").ToString
                        Cotizaciones.gran_descuento.Text = sr.Rows(sr.Rows.Count - 1)("ndescuento_cotiz").ToString
                        Cotizaciones.impuesto.Text = sr.Rows(sr.Rows.Count - 1)("nimpuesto_cotiz").ToString
                        Cotizaciones.neto.Text = sr.Rows(sr.Rows.Count - 1)("nneto_cotiz").ToString
                        Cotizaciones.gran_total.Text = sr.Rows(sr.Rows.Count - 1)("ntotal_cotiz").ToString
                        Cotizaciones.TxtDocumento_terce_factu.Text = sr.Rows(sr.Rows.Count - 1)("ncod_terce_cotiz").ToString
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error Maestro: " & ex.Message)
                    End Try
                    Try
                        Variables.df.Clear()
                        Variables.sSel = "select ncod_produ_detmovim 'Codigo',cnombre_produ 'Nombre',ncantidad_detmovim 'Cantidad',ccod_und_produ'Unidad de Medida',nprecio_detmovim 'Precio',ndescuento_detmovim 'Descuento',nimpuesto_detmovim 'Impuesto' from tbl_detalle_movimientos, tbl_facturas,tbl_productos where ncod_movim_detmovim = ncodigo_factu and ncod_movim_detmovim = '" & Integer.Parse(Cotizaciones.TxtFactura_factu.Text) & "' and ncod_produ_detmovim = ncodigo_produ and ccod_conce_detmovim = '" & Cotizaciones.CBConcepto.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(df)
                        Cotizaciones.DetCotiza.DataSource = df
                        Cotizaciones.TBtnNuevodetalle.Enabled = True
                        Cotizaciones.TBtneliminardetalle.Enabled = True
                    Catch ex As Exception
                        MsgBox("Error Detalle: " & ex.Message)
                    End Try

                Case "Nueva Reserva"
                    Try
                        Variables.sSel = "Select * from tbl_reservas"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Nueva_Reserva.MTxtHora_reser.Text = sr.Rows(sr.Rows.Count - 1)("ffecha_reser").ToString
                        Nueva_Reserva.TxtFecha_reser.Text = sr.Rows(sr.Rows.Count - 1)("hhora_reser").ToString
                        Nueva_Reserva.CBEstado_reser.Text = sr.Rows(sr.Rows.Count - 1)("ccod_estad_reser").ToString
                        Nueva_Reserva.TxtDocumento_terce_reser.Text = sr.Rows(sr.Rows.Count - 1)("ncod_terce_reser").ToString
                        Nueva_Reserva.TxtDatos_escen.Text = sr.Rows(sr.Rows.Count - 1)("ncod_escen_reser").ToString
                        Nueva_Reserva.TxtDatos_tipocosto.Text = sr.Rows(sr.Rows.Count - 1)("ccod_tcosto_reser").ToString
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                    '-----------------
                    'Seguridad
                    '-----------------
                Case "Perfiles"
                    Try

                        Variables.sSel = "Select * from tbl_perfiles,tbl_aplicperfil"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Perfiles.CBcrear.Text = sr.Rows(sr.Rows.Count - 1)("ccrear_perfil").ToString()
                        Perfiles.TxtNombre_perfil.Text = sr.Rows(sr.Rows.Count - 1)("cnombre_perfil").ToString()
                        Perfiles.CBconsultar.Text = sr.Rows(sr.Rows.Count - 1)("cconsultar_perfil").ToString()
                        Perfiles.CBactualizar.Text = sr.Rows(sr.Rows.Count - 1)("cmodificar_perfil").ToString()
                        Perfiles.CBconfirmar.Text = sr.Rows(sr.Rows.Count - 1)("cconfirmar_perfil").ToString()
                        Perfiles.CBreversar.Text = sr.Rows(sr.Rows.Count - 1)("creversar_perfil").ToString()
                        Perfiles.CBanular.Text = sr.Rows(sr.Rows.Count - 1)("canular_perfil").ToString()
                        Perfiles.CBimprimir.Text = sr.Rows(sr.Rows.Count - 1)("cimprimir_perfil").ToString()
                        Perfiles.CBconsola.Text = sr.Rows(sr.Rows.Count - 1)("csql_perfil").ToString()
                        Perfiles.CBEstado.Text = sr.Rows(sr.Rows.Count - 1)("ccod_estad_perfil").ToString()
                        Perfiles.documentos_admon.Text = sr.Rows(sr.Rows.Count - 1)("documentos_admon").ToString()
                        Perfiles.conceptos_admon.Text = sr.Rows(sr.Rows.Count - 1)("conceptos_admon").ToString()
                        Perfiles.escenarios_admon.Text = sr.Rows(sr.Rows.Count - 1)("escenarios_admon").ToString()
                        Perfiles.costos_admon.Text = sr.Rows(sr.Rows.Count - 1)("costos_admon").ToString()
                        Perfiles.cuidades_admon.Text = sr.Rows(sr.Rows.Count - 1)("cuidades_admon").ToString()
                        Perfiles.zonas_admon.Text = sr.Rows(sr.Rows.Count - 1)("zonas_admon").ToString()
                        Perfiles.terceros_admon.Text = sr.Rows(sr.Rows.Count - 1)("terceros_admon").ToString()
                        Perfiles.ubicaciones_admon.Text = sr.Rows(sr.Rows.Count - 1)("ubicaciones_admon").ToString()
                        Perfiles.escenxubica_admon.Text = sr.Rows(sr.Rows.Count - 1)("escenxubica_admon").ToString()
                        Perfiles.tblcostos_admon.Text = sr.Rows(sr.Rows.Count - 1)("tblcostos_admon").ToString()
                        Perfiles.productos_inven.Text = sr.Rows(sr.Rows.Count - 1)("productos_inven").ToString()
                        Perfiles.movimientos_inven.Text = sr.Rows(sr.Rows.Count - 1)("movimientos_inven").ToString()
                        Perfiles.saldos_inven.Text = sr.Rows(sr.Rows.Count - 1)("saldos_inven").ToString()
                        Perfiles.Ordenes_segur.Text = sr.Rows(sr.Rows.Count - 1)("combos_inven").ToString()
                        Perfiles.facturas_factu.Text = sr.Rows(sr.Rows.Count - 1)("facturas_factu").ToString()
                        Perfiles.cotizaciones_factu.Text = sr.Rows(sr.Rows.Count - 1)("cotizaciones_factu").ToString()
                        Perfiles.reservas_factu.Text = sr.Rows(sr.Rows.Count - 1)("reservas_factu").ToString()
                        Perfiles.administraivos_report.Text = sr.Rows(sr.Rows.Count - 1)("administraivos_report").ToString()
                        Perfiles.inventarios_report.Text = sr.Rows(sr.Rows.Count - 1)("inventarios_report").ToString()
                        Perfiles.facturacion_report.Text = sr.Rows(sr.Rows.Count - 1)("facturacion_report").ToString()
                        Perfiles.perfiles_segur.Text = sr.Rows(sr.Rows.Count - 1)("perfiles_segur").ToString()
                        Perfiles.usuarios_segur.Text = sr.Rows(sr.Rows.Count - 1)("usuarios_segur").ToString()
                        Perfiles.claves_segur.Text = sr.Rows(sr.Rows.Count - 1)("claves_segur").ToString()
                        Perfiles.empresa_segur.Text = sr.Rows(sr.Rows.Count - 1)("empresa_segur").ToString()
                        Perfiles.Licencia_segur.Text = sr.Rows(sr.Rows.Count - 1)("licencia_segur").ToString()
                        Perfiles.Auditoria_segur.Text = sr.Rows(sr.Rows.Count - 1)("auditoria_segur").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Usuarios"
                    Try

                        Variables.sSel = "Select * from tbl_usuarios"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Usuarios.TxtContraseña_perfil.Text = sr.Rows(sr.Rows.Count - 1)("ccontraseña_usua").ToString()
                        Usuarios.CBUbica_Usuarios.Text = sr.Rows(sr.Rows.Count - 1)("ncod_ubic_usua").ToString()
                        Usuarios.CBPerfil_usuario.Text = sr.Rows(sr.Rows.Count - 1)("ncod_perfil_usua").ToString()
                        Usuarios.TxtTercero_usua.Text = sr.Rows(sr.Rows.Count - 1)("ncod_terce_usua").ToString()
                        Usuarios.CBEstado_Usuarios.Text = sr.Rows(sr.Rows.Count - 1)("ccod_estad_usua").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                    '---------------------
                    'inventarios
                    '---------------------

                Case "Movimientos"
                    Try

                        Variables.sSel = "Select * from tbl_movimiento_producto"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Mov_inventarios.Txtcodigo_movprodu.Text = sr.Rows(sr.Rows.Count - 1)("ncodigo_moviprodu").ToString
                        Mov_inventarios.CBConcepto.Text = sr.Rows(sr.Rows.Count - 1)("ccod_conce_moviprodu").ToString
                        ' Mov_inventarios.CBoxUbicacion.Text = sr.Rows(sr.rows.count - 1)("ncod_ubic_moviprodu").ToString
                        Mov_inventarios.TxtFecha_reser.Text = sr.Rows(sr.Rows.Count - 1)("ffecha_moviprodu").ToString
                        Mov_inventarios.LblEstado.Text = sr.Rows(sr.Rows.Count - 1)("ccod_estad_moviprodu").ToString
                        Mov_inventarios.gran_descuento.Text = sr.Rows(sr.Rows.Count - 1)("ndescuento_moviprodu").ToString
                        Mov_inventarios.impuesto.Text = sr.Rows(sr.Rows.Count - 1)("nimpuesto_moviprodu").ToString
                        Mov_inventarios.neto.Text = sr.Rows(sr.Rows.Count - 1)("nneto_moviprodu").ToString
                        Mov_inventarios.gran_total.Text = sr.Rows(sr.Rows.Count - 1)("ntotal_moviprodu").ToString
                        Mov_inventarios.TxtDocumento_terce_factu.Text = sr.Rows(sr.Rows.Count - 1)("ncod_terce_moviprodu").ToString
                        Mov_inventarios.Codigo1.Text = "0"
                        Mov_inventarios.Precio1.Text = "0"
                        Mov_inventarios.Producto1.Text = "*"
                        Mov_inventarios.Impuesto1.Text = "0"
                        Mov_inventarios.Descuento1.Text = "0"
                        Mov_inventarios.Existencia1.Text = ""
                        Mov_inventarios.Unidad1.Text = "*"
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error Maestro: " & ex.Message)
                    End Try
                    Try
                        Variables.dm.Clear()
                        Variables.sSel = "select ncod_produ_detmovim 'Codigo',cnombre_produ 'Nombre',ncantidad_detmovim 'Cantidad',ccod_und_produ'Unidad de Medida',nprecio_detmovim 'Precio',ndescuento_detmovim 'Descuento',nimpuesto_detmovim 'Impuesto' from tbl_detalle_movimientos, tbl_movimiento_producto,tbl_productos where ncod_movim_detmovim= ncodigo_moviprodu and ncod_movim_detmovim = '" & Integer.Parse(Mov_inventarios.Txtcodigo_movprodu.Text) & "'and ncod_produ_detmovim = ncodigo_produ and ccod_conce_detmovim = '" & Mov_inventarios.CBConcepto.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dm)
                        Mov_inventarios.data_movimientos.DataSource = dm
                        Mov_inventarios.TBtnNuevodetalle.Enabled = True
                        Mov_inventarios.TBtneliminardetalle.Enabled = True
                    Catch ex As Exception
                        MsgBox("Error Detalle: " & ex.Message)
                    End Try
                Case "Productos"
                    Try
                        Variables.sSel = "select * from tbl_productos"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(sr)

                        Variables.ruta_imagen_buscar = sr.Rows(sr.Rows.Count - 1)("cimagen_produ").ToString
                        Productos.Txtcodigo_produ.Text = sr.Rows(sr.Rows.Count - 1)("ncodigo_produ").ToString
                        Productos.Txtcodigoext_produ.Text = sr.Rows(sr.Rows.Count - 1)("ncod_externo_produ").ToString
                        Productos.TxtNombre_produ.Text = sr.Rows(sr.Rows.Count - 1)("cnombre_produ").ToString
                        Productos.TxtCategoria_produ.Text = sr.Rows(sr.Rows.Count - 1)("ccod_categ_produ").ToString
                        Productos.TxtMarca_produ.Text = sr.Rows(sr.Rows.Count - 1)("ccod_marca_produ").ToString
                        Productos.TxtUnidad_produ.Text = sr.Rows(sr.Rows.Count - 1)("ccod_und_produ").ToString
                        Productos.Txtalto_produ.Text = sr.Rows(sr.Rows.Count - 1)("nalto_produ").ToString
                        Productos.TxtAncho_produ.Text = sr.Rows(sr.Rows.Count - 1)("nancho_produ").ToString
                        Productos.TxtLargo_produ.Text = sr.Rows(sr.Rows.Count - 1)("nlargo_produ").ToString
                        Productos.TxtCapacidad_produ.Text = sr.Rows(sr.Rows.Count - 1)("ncapacidad_produ").ToString
                        Productos.Txtdiametro_produ.Text = sr.Rows(sr.Rows.Count - 1)("ndiametro_produ").ToString
                        Productos.TxtPeso_produ.Text = sr.Rows(sr.Rows.Count - 1)("npeso_produ").ToString
                        Productos.TxtColor_produ.Text = sr.Rows(sr.Rows.Count - 1)("ccod_color_produ").ToString
                        Productos.Txtiva_produ.Text = sr.Rows(sr.Rows.Count - 1)("nimpuesto_produ").ToString
                        Productos.Txtdescuento_produ.Text = sr.Rows(sr.Rows.Count - 1)("ndescuento_produ").ToString
                        Productos.Txtcompra_produ.Text = sr.Rows(sr.Rows.Count - 1)("nprecio_compra_produ").ToString
                        Productos.TxtVenta_produ.Text = sr.Rows(sr.Rows.Count - 1)("nprecio_venta_produ").ToString
                        Productos.TxtFechavence_produ.Text = sr.Rows(sr.Rows.Count - 1)("ffecha_vence_produ").ToString
                        Productos.Txtobservacion_produ.Text = sr.Rows(sr.Rows.Count - 1)("cobservacion_produ").ToString
                        Productos.CB_Combo.Text = sr.Rows(sr.Rows.Count - 1)("ccombo_produ").ToString
                        If Productos.TxtFechavence_produ.Text <> "01/01/1900" Then
                            Productos.CBVencimiento_produ.Checked = True
                            Productos.TxtFechavence_produ.Visible = True
                        End If
                        Productos.Imagen_produc.Image = Image.FromFile(Variables.ruta_imagen_buscar)
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", sr.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(sr.Rows.Count)
                        Boromir.TLbl_0.Text = sr.Rows.Count
                        app_ref = apps
                        Variables.rg = sr.Rows.Count - 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case Else
                    MsgBox("Opcion no habilitada para esta accion", MsgBoxStyle.Information, "Boromir Dice:")
            End Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Module

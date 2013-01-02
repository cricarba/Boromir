Imports System.Data
Imports System.Data.SqlClient
Module F_Boton_buscar
    Dim i As Integer
    Public Sub Boton_Buscar()
        Try
            Boromir.TLbl_x.Text = "0"
            Boromir.TLbl_0.Text = "0"
            Dim apps As String = Boromir.Tab1.SelectedTab.Text
            Select Case apps

                '---------------------
                'administracion
                '---------------------
                Case "Tipo Escenarios"
                    Try
                        Variables.sSel = "Select * from tbl_tescenarios where ccodigo_tescen ='" & Tipo_Escenarios.TxtCodigo_cancha.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Tipo_Escenarios.TxtNombre_cancha.Text = dt.Rows(i)("cnombre_tescen").ToString()
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Tipo Costo"
                    Try
                        Variables.sSel = "Select * from tbl_tipocosto where ccodigo_tcosto ='" & Tipo_Costo.TxtCodigo_costo.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Tipo_Costo.CBubic_tipocost.Text = dt.Rows(i)("ncod_ubica_tcosto").ToString()
                        Tipo_Costo.TxValor_costo.Text = dt.Rows(i)("mvalor_tcosto").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Conceptos"
                    Try
                        Variables.sSel = "Select * from tbl_conceptos where ccodigo_conce ='" & Conceptos.TxtCodigo_Concep.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Conceptos.TxtCodigo_Concep.Text = dt.Rows(i)("ccodigo_conce").ToString()
                        Conceptos.TxtNombre_Concep.Text = dt.Rows(i)("cnombre_conce").ToString()
                        Conceptos.CBAplic_concep.Text = dt.Rows(i)("ccod_aplic_conce").ToString()
                        Conceptos.CbAccion.Text = dt.Rows(i)("caccion_conce").ToString
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Documentos"
                    Try
                        Variables.sSel = "Select * from tbl_tipodoc where ccodigo_tipodoc = '" & Documentos.TxtCodigo_doc.Text & "' OR cnombre_tipodoc ='" & Documentos.TxtNombre_doc.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Documentos.TxtCodigo_doc.Text = dt.Rows(i)("ccodigo_tipodoc").ToString()
                        Documentos.TxtNombre_doc.Text = dt.Rows(i)("cnombre_tipodoc").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Ciudades"
                    Try
                        Variables.sSel = "Select * from tbl_ciudad where ncodigo_ciudad ='" & Ciudades.TxtCodigo_ciudad.Text & "' or cnombre_ciudad = '" & Ciudades.TxtNombre_ciudad.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Ciudades.TxtNombre_ciudad.Text = dt.Rows(i)("cnombre_ciudad").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Zonas"
                    Try
                        Variables.sSel = "Select * from tbl_zonas where ncod_ciudad_zona ='" & Zonas.Txtciudad_zona.Text & "' AND ncodigo_zona = '" & Zonas.TxtCodigo_Zona.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Zonas.TxtCodigo_Zona.Text = dt.Rows(i)("ncodigo_zona").ToString()
                        Zonas.Txtciudad_zona.Text = dt.Rows(i)("ncod_ciudad_zona").ToString()
                        Zonas.TxtNombre_Zona.Text = dt.Rows(i)("cnombre_zona").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Terceros"
                    Try
                        Variables.sSel = "Select * from tbl_terceros where ncodigo_terce ='" & Integer.Parse(Terceros.TxtCodigo_terce.Text) & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Terceros.TxtCodigo_terce.Text = dt.Rows(i)("ncodigo_terce").ToString()
                        Terceros.TxtNombre1_terce.Text = dt.Rows(i)("cnombre_terce").ToString()
                        Terceros.TxtNombre2_terce.Text = dt.Rows(i)("cnombre2_terce").ToString()
                        Terceros.Txtapellido_terce.Text = dt.Rows(i)("capellido_terce").ToString()
                        Terceros.TxtApellido_terce2.Text = dt.Rows(i)("capellido2_terce").ToString()
                        Terceros.TxtTelefono_terce.Text = dt.Rows(i)("ntelefono_terce").ToString()
                        Terceros.TxtCelular_terce.Text = dt.Rows(i)("ncelular_terce").ToString()
                        Terceros.TxtDireccion_terce.Text = dt.Rows(i)("cdireccion_terce").ToString()
                        Terceros.CBTipodoc.Text = dt.Rows(i)("ccod_tipodoc_terce").ToString()
                        Terceros.CBoxCiudad_terce.Text = dt.Rows(i)("ncod_ciudad_terce").ToString()
                        Variables.tercero_cliente = dt.Rows(i)("ncliente_terce").ToString()
                        Variables.tercero_proveedor = dt.Rows(i)("nproveedor_terce").ToString()
                        Variables.tercero_empleado = dt.Rows(i)("nempleado_terce").ToString()
                        Terceros.Txtcorreo_terce.Text = dt.Rows(i)("cemail_terce").ToString()
                        If Variables.tercero_cliente = 1 Then
                            Terceros.CheBoxCliente_terce.Checked = True
                        End If
                        If Variables.tercero_proveedor = 1 Then
                            Terceros.ChBoxProveedor_terce.Checked = True
                        End If
                        If Variables.tercero_empleado = 1 Then
                            Terceros.ChBoxEmpleado_terce.Checked = True
                        End If
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Ubicaciones"
                    Try
                        Variables.sSel = "Select * from tbl_ubicaciones, tbl_terceros where ncodigo_ubica ='" & Integer.Parse(Ubicaciones.Txtcodigo.Text) & "' and ncod_admon_ubica = ncodigo_terce "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Ubicaciones.TxtNombre_ubica.Text = dt.Rows(i)("cnombre_ubica").ToString()
                        Ubicaciones.TxtDireccion_ubica.Text = dt.Rows(i)("cdireccion_ubica").ToString()
                        Ubicaciones.TxtTelefono_ubica.Text = dt.Rows(i)("ntelefono_ubica").ToString()
                        Ubicaciones.TxtCelular_ubica.Text = dt.Rows(i)("ncelular_ubica").ToString()
                        Variables.ubic_costo = dt.Rows(i)("ncobro_ubica").ToString
                        Ubicaciones.TxtCorreo_Ubica.Text = dt.Rows(i)("ccorreo_ubica").ToString()
                        Ubicaciones.TxtCedula_ubica.Text = dt.Rows(i)("ncod_admon_ubica").ToString()
                        Ubicaciones.TxtNombre1_ubica.Text = dt.Rows(i)("cnombre_terce").ToString()
                        Ubicaciones.TxtNombre2_ubica.Text = dt.Rows(i)("cnombre2_terce").ToString()
                        Ubicaciones.TxtApellido1_ubica.Text = dt.Rows(i)("capellido_terce").ToString()
                        Ubicaciones.TxtApellido2_ubica.Text = dt.Rows(i)("capellido2_terce").ToString()
                        If Variables.ubic_costo = 1 Then
                            Ubicaciones.CheckBox1.Checked = True
                        End If
                        Ubicaciones.CBoxCiudad_ubica.Text = dt.Rows(i)("ncod_ciudad_ubica").ToString()
                        Ubicaciones.CBoxZona_ubica.Text = dt.Rows(i)("ncod_zona_ubica").ToString()

                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Escenario X ubicacion"
                    Try
                        Variables.sSel = "Select * from tbl_escenarios where  ncod_ubica_escen = '" & EscenarioXubica.CBUbic_EXU.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        EscenarioXubica.TxtCodigo_EXU.Text = dt.Rows(i)("ncodigo_escen").ToString()
                        EscenarioXubica.TxtNombre_EXU.Text = dt.Rows(i)("cnombre_escen").ToString()
                        EscenarioXubica.CBEstado_EXU.Text = dt.Rows(i)("ccod_estad_escen").ToString()
                        EscenarioXubica.CBUbic_EXU.Text = dt.Rows(i)("ncod_ubica_escen").ToString()
                        EscenarioXubica.CBTipo_EXU.Text = dt.Rows(i)("ctipo_escen").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Turnos"
                    Try
                        Variables.codigo = Integer.Parse(EscenarioXubica.TxtCodigo_EXU.Text)
                        Variables.sSel = "Select * from tbl_turnos where ncodigo_turno ='" & Turnos.TxtCodigo_turno.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Turnos.TxtCodigo_turno.Text = dt.Rows(i)("ncodigo_turno").ToString()
                        Turnos.TxtNombre_turno.Text = dt.Rows(i)("cnombre_turno").ToString()
                        Turnos.CBubic_turnos.Text = dt.Rows(i)("ncod_ubica_turno").ToString()
                        Turnos.TxtHora_inicio.Text = dt.Rows(i)("ncod_hinicio_turno").ToString()
                        Turnos.TxtHora_Final.Text = dt.Rows(i)("ncod_hfinal_turno").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Costo Turno"
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Monday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Costo_Turno.CBLunes.Text = dt.Rows(i)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                    Catch ex As Exception
                        MsgBox("Error: Lunes " & ex.Message)
                    End Try
                    Variables.dt.Clear()
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Tuesday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Costo_Turno.CBMartes.Text = dt.Rows(i)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: Martes " & ex.Message)
                    End Try
                    Variables.dt.Clear()
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno ='Wednesday'and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Costo_Turno.CBMiercoles.Text = dt.Rows(i)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: Miercoles " & ex.Message)
                    End Try
                    Variables.dt.Clear()
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Thursday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Costo_Turno.CBJueves.Text = dt.Rows(i)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: Jueves " & ex.Message)
                    End Try
                    Variables.dt.Clear()
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Friday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Costo_Turno.CBViernes.Text = dt.Rows(i)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: Viernes " & ex.Message)
                    End Try
                    Variables.dt.Clear()
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Saturday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Costo_Turno.CBSabado.Text = dt.Rows(i)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: Sabado " & ex.Message)
                    End Try
                    Variables.dt.Clear()
                    Try
                        Variables.codigo = Integer.Parse(Costo_Turno.CBubic_tabla_costo.Text)
                        Variables.sSel = "Select ccod_tcosto_costurno from tbl_costoturno where ncod_ubica_costurno = '" & Variables.codigo & "' and ccod_tescen_costurno = '" & Costo_Turno.CBtipoescen_costo_turno.Text & "' and cdia_costurno = 'Sunday' and chora_costurno = '" & Costo_Turno.MTxt_hora.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Costo_Turno.CBDomingo.Text = dt.Rows(i)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: Domingo " & ex.Message)
                    End Try
                    Variables.dt.Clear()
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
                        Variables.da.Fill(dt)
                        Costo_Turno.CBFestivo.Text = dt.Rows(i)("ccod_tcosto_costurno").ToString
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: Festivo " & ex.Message)
                    End Try
                    '---------------------------------
                    'Facturacion
                    '----------------------------------
                Case "Facturas"
                    Try
                        Variables.sSel = "Select * from tbl_facturas where  ncodigo_factu='" & Integer.Parse(Facturas.TxtFactura_factu.Text) & "' and ccod_conce_factu = '" & Facturas.CBConcepto_factu.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Facturas.TxtFactura_factu.Text = dt.Rows(i)("ncodigo_factu").ToString
                        Facturas.CBConcepto_factu.Text = dt.Rows(i)("ccod_conce_factu").ToString
                        Facturas.CBoxUbicacion_factu.Text = dt.Rows(i)("ncod_ubic_factu").ToString
                        Facturas.TxtFecha_factu.Text = dt.Rows(i)("ffecha_factu").ToString
                        Facturas.LblEstado.Text = dt.Rows(i)("ccod_estad_factu").ToString
                        Facturas.gran_descuento.Text = dt.Rows(0)("ndescuento_factu").ToString
                        Facturas.impuesto.Text = dt.Rows(i)("nimpuesto_factu").ToString
                        Facturas.neto.Text = dt.Rows(i)("nneto_factu").ToString
                        Facturas.gran_total.Text = dt.Rows(i)("ntotal_factu").ToString
                        Facturas.TxtDocumento_terce_factu.Text = dt.Rows(i)("ncod_terce_factu").ToString
                    Catch ex As Exception
                        MsgBox("Error Maestro: " & ex.Message)
                    End Try
                    Try
                        Variables.df = New DataTable()
                        Variables.sSel = "select ncod_produ_detmovim 'Codigo',cnombre_produ 'Nombre',ncantidad_detmovim 'Cantidad',ccod_und_produ'Unidad de Medida',nprecio_detmovim 'Precio',ndescuento_detmovim 'Descuento',nimpuesto_detmovim 'Impuesto' from tbl_detalle_movimientos, tbl_facturas,tbl_productos where ncod_movim_detmovim = ncodigo_factu and ncod_movim_detmovim = '" & Integer.Parse(Facturas.TxtFactura_factu.Text) & "' and ncod_produ_detmovim = ncodigo_produ and ccod_conce_detmovim = '" & Facturas.CBConcepto_factu.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(df)
                        Facturas.DetFac.DataSource = df
                        Facturas.TBtnNuevodetalle.Enabled = True
                        Facturas.TBtneliminardetalle.Enabled = True
                    Catch ex As Exception
                        MsgBox("Error Detalle: " & ex.Message)
                    End Try
                    If Facturas.LblEstado.Text <> "AC" Then
                        Facturas.GroupBox2.Enabled = False
                    Else
                        Facturas.GroupBox2.Enabled = True
                    End If
                Case "Cotizaciones"
                    Try
                        Variables.sSel = "Select * from tbl_Cotizaciones where  ncodigo_cotiz='" & Integer.Parse(Cotizaciones.TxtFactura_factu.Text) & "' and ccod_conce_cotiz = '" & Cotizaciones.CBConcepto.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Cotizaciones.TxtFactura_factu.Text = dt.Rows(i)("ncodigo_cotiz").ToString
                        Cotizaciones.CBConcepto.Text = dt.Rows(i)("ccod_conce_cotiz").ToString
                        Cotizaciones.txt_observaciones.Text = dt.Rows(i)("cobservacion_cotiz").ToString
                        Cotizaciones.CBUbicacion.Text = dt.Rows(i)("ncod_ubic_cotiz").ToString
                        Cotizaciones.TxtFecha_factu.Text = dt.Rows(i)("ffecha_cotiz").ToString
                        Cotizaciones.LblEstado.Text = dt.Rows(i)("ccod_estad_cotiz").ToString
                        Cotizaciones.gran_descuento.Text = dt.Rows(0)("ndescuento_cotiz").ToString
                        Cotizaciones.impuesto.Text = dt.Rows(i)("nimpuesto_cotiz").ToString
                        Cotizaciones.neto.Text = dt.Rows(i)("nneto_cotiz").ToString
                        Cotizaciones.gran_total.Text = dt.Rows(i)("ntotal_cotiz").ToString
                        Cotizaciones.TxtDocumento_terce_factu.Text = dt.Rows(i)("ncod_terce_cotiz").ToString

                    Catch ex As Exception
                        MsgBox("Error Maestro: " & ex.Message)
                    End Try
                    Try
                        Variables.df = New DataTable()
                        Variables.sSel = "select ncod_produ_detmovim 'Codigo',cnombre_produ 'Nombre',ncantidad_detmovim 'Cantidad',ccod_und_produ'Unidad de Medida',nprecio_detmovim 'Precio',ndescuento_detmovim 'Descuento',nimpuesto_detmovim 'Impuesto' from tbl_detalle_movimientos, tbl_cotizaciones,tbl_productos where ncod_movim_detmovim = ncodigo_cotiz and ncod_movim_detmovim = '" & Integer.Parse(Cotizaciones.TxtFactura_factu.Text) & "' and ncod_produ_detmovim = ncodigo_produ and ccod_conce_detmovim = '" & Cotizaciones.CBConcepto.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(df)
                        Cotizaciones.DetCotiza.DataSource = df
                        Cotizaciones.TBtnNuevodetalle.Enabled = True
                        Cotizaciones.TBtneliminardetalle.Enabled = True
                    Catch ex As Exception
                        MsgBox("Error Detalle: " & ex.Message)
                    End Try
                    If Cotizaciones.LblEstado.Text <> "AC" Then
                        Cotizaciones.GroupBox2.Enabled = False
                    Else
                        Cotizaciones.GroupBox2.Enabled = True
                    End If
                Case "Pedidos"
                    Try
                        Variables.sSel = "Select * from tbl_pedidos where  ncodigo_pedid='" & Integer.Parse(Pedidos.TxtFactura_factu.Text) & "' and ccod_conce_pedid = '" & Pedidos.CBConcepto.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Pedidos.TxtFactura_factu.Text = dt.Rows(i)("ncodigo_pedid").ToString
                        Pedidos.CBConcepto.Text = dt.Rows(i)("ccod_conce_pedid").ToString
                        Pedidos.txt_observaciones.Text = dt.Rows(i)("cobservacion_pedid").ToString
                        Pedidos.CBUbicacion.Text = dt.Rows(i)("ncod_ubic_pedid").ToString
                        Pedidos.TxtFecha_factu.Text = dt.Rows(i)("ffecha_pedid").ToString
                        Pedidos.LblEstado.Text = dt.Rows(i)("ccod_estad_pedid").ToString
                        Pedidos.gran_descuento.Text = dt.Rows(0)("ndescuento_pedid").ToString
                        Pedidos.impuesto.Text = dt.Rows(i)("nimpuesto_pedid").ToString
                        Pedidos.neto.Text = dt.Rows(i)("nneto_pedid").ToString
                        Pedidos.gran_total.Text = dt.Rows(i)("ntotal_pedid").ToString
                        Pedidos.TxtDocumento_terce_factu.Text = dt.Rows(i)("ncod_terce_pedid").ToString

                    Catch ex As Exception
                        MsgBox("Error Maestro: " & ex.Message)
                    End Try
                    Try
                        Variables.df = New DataTable()
                        Variables.sSel = "select ncod_produ_detmovim 'Codigo',cnombre_produ 'Nombre',ncantidad_detmovim 'Cantidad',ccod_und_produ'Unidad de Medida',nprecio_detmovim 'Precio',ndescuento_detmovim 'Descuento',nimpuesto_detmovim 'Impuesto' from tbl_detalle_movimientos, tbl_pedidos,tbl_productos where ncod_movim_detmovim = ncodigo_pedid and ncod_movim_detmovim = '" & Integer.Parse(Pedidos.TxtFactura_factu.Text) & "' and ncod_produ_detmovim = ncodigo_produ and ccod_conce_detmovim = '" & Pedidos.CBConcepto.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(df)
                        Pedidos.DetPedido.DataSource = df
                        Pedidos.TBtnNuevodetalle.Enabled = True
                        Pedidos.TBtneliminardetalle.Enabled = True
                    Catch ex As Exception
                        MsgBox("Error Detalle: " & ex.Message)
                    End Try
                    If Pedidos.LblEstado.Text <> "AC" Then
                        Pedidos.GroupBox2.Enabled = False
                    Else
                        Pedidos.GroupBox2.Enabled = True
                    End If
                Case "Orden de Compra"
                    Try

                        Variables.sSel = "Select * from tbl_ordenes where  ncodigo_orden='" & Integer.Parse(Ordenes_Compra.Txtnumero.Text) & "' and ccod_conce_orden = '" & Ordenes_Compra.CBConcepto.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Ordenes_Compra.Txtnumero.Text = dt.Rows(i)("ncodigo_orden").ToString
                        Ordenes_Compra.CBConcepto.Text = dt.Rows(i)("ccod_conce_orden").ToString
                        Ordenes_Compra.CBUbicacion.Text = dt.Rows(i)("ncod_ubic_orden").ToString
                        Ordenes_Compra.TxtFecha_factu.Text = dt.Rows(i)("ffecha_orden").ToString
                        Ordenes_Compra.LblEstado.Text = dt.Rows(i)("ccod_estad_orden").ToString
                        Ordenes_Compra.gran_descuento.Text = dt.Rows(0)("ndescuento_orden").ToString
                        Ordenes_Compra.impuesto.Text = dt.Rows(i)("nimpuesto_orden").ToString
                        Ordenes_Compra.neto.Text = dt.Rows(i)("nneto_orden").ToString
                        Ordenes_Compra.gran_total.Text = dt.Rows(i)("ntotal_orden").ToString
                        Ordenes_Compra.TxtDocumento_terce_factu.Text = dt.Rows(i)("ncod_terce_orden").ToString
                    Catch ex As Exception
                        MsgBox("Error Maestro: " & ex.Message)
                    End Try
                    Try
                        Variables.df.Clear()
                        Variables.sSel = "select ncod_produ_detmovim 'Codigo',cnombre_produ 'Nombre',ncantidad_detmovim 'Cantidad',ccod_und_produ'Unidad de Medida',nprecio_detmovim 'Precio',ndescuento_detmovim 'Descuento',nimpuesto_detmovim 'Impuesto' from tbl_detalle_movimientos, tbl_cotizaciones,tbl_productos where ncod_movim_detmovim = ncodigo_cotiz and ncod_movim_detmovim = '" & Integer.Parse(Ordenes_Compra.Txtnumero.Text) & "' and ncod_produ_detmovim = ncodigo_produ and ccod_conce_detmovim = '" & Ordenes_Compra.CBConcepto.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(df)
                        Ordenes_Compra.detCOTt_datagrid.DataSource = df
                        Ordenes_Compra.TBtnNuevodetalle.Enabled = True
                        Ordenes_Compra.TBtneliminardetalle.Enabled = True
                    Catch ex As Exception
                        MsgBox("Error Detalle: " & ex.Message)
                    End Try
                    If Ordenes_Compra.LblEstado.Text <> "AC" Then
                        Ordenes_Compra.GroupBox2.Enabled = False
                    Else
                        Ordenes_Compra.GroupBox2.Enabled = True
                    End If
                Case "Nueva Reserva"
                    Try
                        Variables.sSel = "Select * from tbl_reservas where  ncodigo_reser='" & Integer.Parse(Nueva_Reserva.TxtReserva_reser.Text) & "' and ncod_ubic_reser = '" & Nueva_Reserva.CBoxUbicacion_reser.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Nueva_Reserva.MTxtHora_reser.Text = dt.Rows(i)("ffecha_reser").ToString
                        Nueva_Reserva.TxtFecha_reser.Text = dt.Rows(i)("hhora_reser").ToString
                        Nueva_Reserva.CBEstado_reser.Text = dt.Rows(i)("ccod_estad_reser").ToString
                        Nueva_Reserva.TxtDocumento_terce_reser.Text = dt.Rows(i)("ncod_terce_reser").ToString
                        Nueva_Reserva.TxtDatos_escen.Text = dt.Rows(i)("ncod_escen_reser").ToString
                        Nueva_Reserva.TxtDatos_tipocosto.Text = dt.Rows(i)("ccod_tcosto_reser").ToString
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                    '-----------------
                    'Seguridad
                    '-----------------
                Case "Perfiles"
                    Try
                        Variables.sSel = "Select * from tbl_perfiles,tbl_aplicperfil where ncodigo_perfil ='" & Integer.Parse(Perfiles.TxtCodigo_perfil.Text) & "' and ncod_perfil_aplicperfil  ='" & Integer.Parse(Perfiles.TxtCodigo_perfil.Text) & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Perfiles.CBcrear.Text = dt.Rows(i)("ccrear_perfil").ToString()
                        Perfiles.TxtNombre_perfil.Text = dt.Rows(i)("cnombre_perfil").ToString()
                        Perfiles.CBconsultar.Text = dt.Rows(i)("cconsultar_perfil").ToString()
                        Perfiles.CBactualizar.Text = dt.Rows(i)("cmodificar_perfil").ToString()
                        Perfiles.CBconfirmar.Text = dt.Rows(i)("cconfirmar_perfil").ToString()
                        Perfiles.CBreversar.Text = dt.Rows(i)("creversar_perfil").ToString()
                        Perfiles.CBanular.Text = dt.Rows(i)("canular_perfil").ToString()
                        Perfiles.CBimprimir.Text = dt.Rows(i)("cimprimir_perfil").ToString()
                        Perfiles.CBconsola.Text = dt.Rows(i)("csql_perfil").ToString()
                        Perfiles.CBEstado.Text = dt.Rows(i)("ccod_estad_perfil").ToString()
                        Perfiles.documentos_admon.Text = dt.Rows(i)("documentos_admon").ToString()
                        Perfiles.conceptos_admon.Text = dt.Rows(i)("conceptos_admon").ToString()
                        Perfiles.escenarios_admon.Text = dt.Rows(i)("escenarios_admon").ToString()
                        Perfiles.costos_admon.Text = dt.Rows(i)("costos_admon").ToString()
                        Perfiles.cuidades_admon.Text = dt.Rows(i)("cuidades_admon").ToString()
                        Perfiles.zonas_admon.Text = dt.Rows(i)("zonas_admon").ToString()
                        Perfiles.terceros_admon.Text = dt.Rows(i)("terceros_admon").ToString()
                        Perfiles.ubicaciones_admon.Text = dt.Rows(i)("ubicaciones_admon").ToString()
                        Perfiles.escenxubica_admon.Text = dt.Rows(i)("escenxubica_admon").ToString()
                        Perfiles.tblcostos_admon.Text = dt.Rows(i)("tblcostos_admon").ToString()
                        Perfiles.productos_inven.Text = dt.Rows(i)("productos_inven").ToString()
                        Perfiles.movimientos_inven.Text = dt.Rows(i)("movimientos_inven").ToString()
                        Perfiles.saldos_inven.Text = dt.Rows(i)("saldos_inven").ToString()
                        Perfiles.Ordenes_segur.Text = dt.Rows(i)("ordenes_inven").ToString()
                        Perfiles.cotizaciones_factu.Text = dt.Rows(i)("cotizaciones_factu").ToString()
                        Perfiles.Pedidos_factu.Text = dt.Rows(i)("pedidos_factu").ToString()
                        Perfiles.facturas_factu.Text = dt.Rows(i)("facturas_factu").ToString()
                        Perfiles.reservas_factu.Text = dt.Rows(i)("reservas_factu").ToString()
                        Perfiles.administraivos_report.Text = dt.Rows(i)("administraivos_report").ToString()
                        Perfiles.inventarios_report.Text = dt.Rows(i)("inventarios_report").ToString()
                        Perfiles.facturacion_report.Text = dt.Rows(i)("facturacion_report").ToString()
                        Perfiles.perfiles_segur.Text = dt.Rows(i)("perfiles_segur").ToString()
                        Perfiles.usuarios_segur.Text = dt.Rows(i)("usuarios_segur").ToString()
                        Perfiles.claves_segur.Text = dt.Rows(i)("claves_segur").ToString()
                        Perfiles.empresa_segur.Text = dt.Rows(i)("empresa_segur").ToString()
                        Perfiles.Licencia_segur.Text = dt.Rows(i)("licencia_segur").ToString()
                        Perfiles.Auditoria_segur.Text = dt.Rows(i)("auditoria_segur").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Usuarios"
                    Try
                        Variables.sSel = "Select * from tbl_usuarios where cnombre_usua ='" & Usuarios.Txt_usuario_usua.Text & "' "
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Usuarios.TxtContraseña_perfil.Text = dt.Rows(i)("ccontraseña_usua").ToString()
                        Usuarios.CBUbica_Usuarios.Text = dt.Rows(i)("ncod_ubic_usua").ToString()
                        Usuarios.CBPerfil_usuario.Text = dt.Rows(i)("ncod_perfil_usua").ToString()
                        Usuarios.TxtTercero_usua.Text = dt.Rows(i)("ncod_terce_usua").ToString()
                        Usuarios.CBEstado_Usuarios.Text = dt.Rows(i)("ccod_estad_usua").ToString()
                        Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
                        Boromir.TLbl_x.Text = String.Format(dt.Rows.Count)
                        Boromir.TLbl_0.Text = i + 1
                        Variables.rg = dt.Rows.Count
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                    '---------------------
                    'inventarios
                    '---------------------

                Case "Movimientos"
                    Try
                        Variables.sSel = "Select * from tbl_movimiento_producto where  ncodigo_moviprodu='" & Integer.Parse(Mov_inventarios.Txtcodigo_movprodu.Text) & "' and ccod_conce_moviprodu = '" & Mov_inventarios.CBConcepto.Text & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Mov_inventarios.Txtcodigo_movprodu.Text = dt.Rows(i)("ncodigo_moviprodu").ToString
                        Mov_inventarios.CBConcepto.Text = dt.Rows(i)("ccod_conce_moviprodu").ToString
                        ' Mov_inventarios.CBoxUbicacion.Text = dt.Rows(i)("ncod_ubic_moviprodu").ToString
                        Mov_inventarios.TxtFecha_reser.Text = dt.Rows(i)("ffecha_moviprodu").ToString
                        Mov_inventarios.LblEstado.Text = dt.Rows(i)("ccod_estad_moviprodu").ToString
                        Mov_inventarios.gran_descuento.Text = dt.Rows(0)("ndescuento_moviprodu").ToString
                        Mov_inventarios.impuesto.Text = dt.Rows(i)("nimpuesto_moviprodu").ToString
                        Mov_inventarios.neto.Text = dt.Rows(i)("nneto_moviprodu").ToString
                        Mov_inventarios.gran_total.Text = dt.Rows(i)("ntotal_moviprodu").ToString
                        Mov_inventarios.TxtDocumento_terce_factu.Text = dt.Rows(i)("ncod_terce_moviprodu").ToString
                        Mov_inventarios.Codigo1.Text = "0"
                        Mov_inventarios.Precio1.Text = "0"
                        Mov_inventarios.Producto1.Text = "*"
                        Mov_inventarios.Impuesto1.Text = "0"
                        Mov_inventarios.Descuento1.Text = "0"
                        Mov_inventarios.Existencia1.Text = ""
                        Mov_inventarios.Unidad1.Text = "*"

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
                    If Mov_inventarios.LblEstado.Text <> "AC" Then
                        Mov_inventarios.GroupBox2.Enabled = False
                    Else
                        Mov_inventarios.GroupBox2.Enabled = True
                    End If
                Case "Productos"
                    Try
                        Variables.sSel = "select * from tbl_productos where ncodigo_produ = '" & Integer.Parse(Productos.Txtcodigo_produ.Text) & "'"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Variables.ruta_imagen_buscar = dt.Rows(i)("cimagen_produ").ToString
                        Productos.Txtcodigo_produ.Text = dt.Rows(i)("ncodigo_produ").ToString
                        Productos.Txtcodigoext_produ.Text = dt.Rows(i)("ncod_externo_produ").ToString
                        Productos.TxtNombre_produ.Text = dt.Rows(i)("cnombre_produ").ToString
                        Productos.TxtCategoria_produ.Text = dt.Rows(i)("ccod_categ_produ").ToString
                        Productos.TxtMarca_produ.Text = dt.Rows(i)("ccod_marca_produ").ToString
                        Productos.TxtUnidad_produ.Text = dt.Rows(i)("ccod_und_produ").ToString
                        Productos.Txtalto_produ.Text = dt.Rows(i)("nalto_produ").ToString
                        Productos.TxtAncho_produ.Text = dt.Rows(i)("nancho_produ").ToString
                        Productos.TxtLargo_produ.Text = dt.Rows(i)("nlargo_produ").ToString
                        Productos.TxtCapacidad_produ.Text = dt.Rows(i)("ncapacidad_produ").ToString
                        Productos.Txtdiametro_produ.Text = dt.Rows(i)("ndiametro_produ").ToString
                        Productos.TxtPeso_produ.Text = dt.Rows(i)("npeso_produ").ToString
                        Productos.TxtColor_produ.Text = dt.Rows(i)("ccod_color_produ").ToString
                        Productos.Txtiva_produ.Text = dt.Rows(i)("nimpuesto_produ").ToString
                        Productos.Txtdescuento_produ.Text = dt.Rows(i)("ndescuento_produ").ToString
                        Productos.TxtVenta_produ.Text = dt.Rows(i)("nprecio_venta_produ").ToString
                        Productos.TxtFechavence_produ.Text = dt.Rows(i)("ffecha_vence_produ").ToString
                        Productos.Txtobservacion_produ.Text = dt.Rows(i)("cobservacion_produ").ToString
                        Productos.CB_Combo.Text = dt.Rows(i)("ccombo_produ").ToString
                        If Productos.TxtFechavence_produ.Text <> "01/01/1900" Then
                            Productos.CBVencimiento_produ.Checked = True
                            Productos.TxtFechavence_produ.Visible = True
                        End If


                        dt.Clear()
                        Dim cantidad, precio As Integer
                        Variables.sSel = "select  nprecio_detmovim,ncantidad_detmovim  from tbl_detalle_movimientos where ccod_conce_detmovim = 'EI' and ncod_produ_detmovim = '" & Integer.Parse(Productos.Txtcodigo_produ.Text) & "' order by ncod_movim_detmovim desc"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            cantidad = dt.Rows(0)("ncantidad_detmovim").ToString
                            precio = dt.Rows(0)("nprecio_detmovim").ToString
                            Productos.Txtcompra_produ.Text = (precio / cantidad).ToString
                        Else
                            Productos.Txtcompra_produ.Text = "0"
                        End If
                        Productos.Imagen_produc.Image = Image.FromFile(Variables.ruta_imagen_buscar)
                        If Productos.CB_Combo.Text = "SI" Then
                            Try
                                Dim dtcombo As New DataTable
                                dtcombo.Columns.Add("No")
                                Variables.sSel = "select ncod_componente_combo Codigo,cnombre_produ Nombre,ncantidad_componente_combo Cantidad  from tbl_combos, tbl_productos a where ncodigo_combo = '" & Integer.Parse(Productos.Txtcodigo_produ.Text) & "' and ncodigo_combo = ncodigo_produ  "
                                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                                Variables.da.Fill(dtcombo)
                                Productos.dtviewcombos.DataSource = dtcombo
                                dtcombo_global = dtcombo
                            Catch ex As Exception
                                MsgBox("Error: " & ex.Message)
                            End Try
                        End If
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Saldos"
                    Try
                        Dim ds As New DataTable()
                        Variables.sSel = F_Filtros_Reportes.filtros_saldos()
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(ds)
                        Saldos.DataSaldos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        Saldos.DataSaldos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                        Saldos.DataSaldos.DataSource = ds
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Empresa"
                    Try
                        Variables.sSel = "select * from tbl_empresa"
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Empresa.TxtNombre.Text = dt.Rows(i)("cnombre_empre").ToString
                        Empresa.Txt_nit.Text = dt.Rows(i)("nnit_empre").ToString
                        Empresa.TxtDireccion.Text = dt.Rows(i)("cdireccion_empre").ToString
                        Empresa.TxtTelefono_ubica.Text = dt.Rows(i)("ntelefono_empre").ToString
                        Empresa.TxtCelular_ubica.Text = dt.Rows(i)("ncelular_empre").ToString
                        Empresa.TxtManuales.Text = dt.Rows(i)("cruta_manual_empre").ToString
                        Empresa.TxtRutaimgpro.Text = dt.Rows(i)("cruta_produ_empre").ToString
                        Empresa.TxtCorreo_Ubica.Text = dt.Rows(i)("ccorreo_empre").ToString
                        Empresa.TxtReportes.Text = dt.Rows(i)("cruta_repor_empre").ToString
                        Empresa.TxTclave.Text = dt.Rows(i)("cclave_empre").ToString
                        Empresa.Txtsmpt.Text = dt.Rows(i)("csmtp_empre").ToString
                        Empresa.Txtpuerto.Text = dt.Rows(i)("cpuerto_empre").ToString
                        Empresa.Txtresolucion.Text = dt.Rows(i)("cresolucion_empre").ToString
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Auditoria"
                    Try
                        Dim dtaudi As New DataTable
                        If Auditoria.TxtUsuario.Text = "" And Auditoria.CBaccion.Text = "" Then
                            Variables.sSel = "select ncod_usua_audi Usuario,caccion_audi Accion,cnombre_aplic_audi Aplicacion,cdescripcion_audi Descripcion,ffecha_audi Fecha from tbl_auditoria"
                        End If
                        If Auditoria.TxtUsuario.Text <> "" And Auditoria.CBaccion.Text = "" Then
                            Variables.sSel = "select ncod_usua_audi Usuario,caccion_audi Accion,cnombre_aplic_audi Aplicacion,cdescripcion_audi Descripcion,ffecha_audi Fecha from tbl_auditoria where ncod_usua_audi = '" & Auditoria.TxtUsuario.Text & "'"
                        End If
                        If Auditoria.TxtUsuario.Text = "" And Auditoria.CBaccion.Text <> "" Then
                            Variables.sSel = "select ncod_usua_audi Usuario,caccion_audi Accion,cnombre_aplic_audi Aplicacion,cdescripcion_audi Descripcion,ffecha_audi Fecha from tbl_auditoria where caccion_audi = '" & Auditoria.CBaccion.Text & "'"
                        End If
                        If Auditoria.TxtUsuario.Text <> "" And Auditoria.CBaccion.Text <> "" Then
                            Variables.sSel = "select ncod_usua_audi Usuario,caccion_audi Accion,cnombre_aplic_audi Aplicacion,cdescripcion_audi Descripcion,ffecha_audi Fecha from tbl_auditoria where ncod_usua_audi = '" & Auditoria.TxtUsuario.Text & "' and caccion_audi = '" & Auditoria.CBaccion.Text & "'"
                        End If
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dtaudi)
                        Auditoria.DTaudioria.DataSource = dtaudi
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Licencia"
                    Dim dtlicencia As New DataTable
                    Variables.sSel = "select * from tbl_modulos"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlicencia)
                    Licencia.a1.Text = dtlicencia.Rows(0)("nuno_modul").ToString
                    Licencia.a2.Text = dtlicencia.Rows(0)("ndos_modul").ToString
                    Licencia.a3.Text = dtlicencia.Rows(0)("ntres_modul").ToString
                    Licencia.a4.Text = dtlicencia.Rows(0)("ncuatro_modul").ToString
                    Licencia.a5.Text = dtlicencia.Rows(0)("ncinco_modul").ToString
                    Licencia.a6.Text = dtlicencia.Rows(0)("nseis_modul").ToString
                    Licencia.i1.Text = dtlicencia.Rows(1)("nuno_modul").ToString
                    Licencia.i2.Text = dtlicencia.Rows(1)("ndos_modul").ToString
                    Licencia.i3.Text = dtlicencia.Rows(1)("ntres_modul").ToString
                    Licencia.i4.Text = dtlicencia.Rows(1)("ncuatro_modul").ToString
                    Licencia.i5.Text = dtlicencia.Rows(1)("ncinco_modul").ToString
                    Licencia.i6.Text = dtlicencia.Rows(1)("nseis_modul").ToString
                    Licencia.f1.Text = dtlicencia.Rows(2)("nuno_modul").ToString
                    Licencia.f2.Text = dtlicencia.Rows(2)("ndos_modul").ToString
                    Licencia.f3.Text = dtlicencia.Rows(2)("ntres_modul").ToString
                    Licencia.f4.Text = dtlicencia.Rows(2)("ncuatro_modul").ToString
                    Licencia.f5.Text = dtlicencia.Rows(2)("ncinco_modul").ToString
                    Licencia.f6.Text = dtlicencia.Rows(2)("nseis_modul").ToString
                    Licencia.r1.Text = dtlicencia.Rows(3)("nuno_modul").ToString
                    Licencia.r2.Text = dtlicencia.Rows(3)("ndos_modul").ToString
                    Licencia.r3.Text = dtlicencia.Rows(3)("ntres_modul").ToString
                    Licencia.r4.Text = dtlicencia.Rows(3)("ncuatro_modul").ToString
                    Licencia.r5.Text = dtlicencia.Rows(3)("ncinco_modul").ToString
                    Licencia.r6.Text = dtlicencia.Rows(3)("nseis_modul").ToString
                    Licencia.s1.Text = dtlicencia.Rows(3)("nuno_modul").ToString
                    Licencia.s2.Text = dtlicencia.Rows(3)("ndos_modul").ToString
                    Licencia.s3.Text = dtlicencia.Rows(3)("ntres_modul").ToString
                    Licencia.s4.Text = dtlicencia.Rows(3)("ncuatro_modul").ToString
                    Licencia.s5.Text = dtlicencia.Rows(3)("ncinco_modul").ToString
                    Licencia.s6.Text = dtlicencia.Rows(3)("nseis_modul").ToString
            End Select

            Boromir.LblRegistrios.Text = Variables.Registros

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
            Variables.sSel = "Exec proc_auditoria '" & Boromir.barra_estad_usuario.Text.ToUpper & "',BUSCAR,'" & apps.ToUpper & "','" & Variables.Des_auditoria.ToUpper & "','" & Now() & "' "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)

        Catch ex As Exception
            MsgBox("Error Case: " & ex.Message)
        End Try


    End Sub

End Module

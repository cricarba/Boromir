Imports System.Data
Imports System.Data.SqlClient
Module F_Boton_nuevo
    Dim i As Integer
    Public Sub Boton_Nuevo()
        Try
            Boromir.TLbl_x.Text = "0"
            Boromir.TLbl_0.Text = "0"
            Dim apps As String = Boromir.Tab1.SelectedTab.Text
            Select Case apps
                Case "Tipo Escenarios"
                    Tipo_Escenarios.TxtCodigo_cancha.Text = ""
                    Tipo_Escenarios.TxtNombre_cancha.Text = ""
                Case "Tipo Costo"
                    Tipo_Costo.TxtCodigo_costo.Text = ""
                    Tipo_Costo.CBubic_tipocost.Text = ""
                    Tipo_Costo.TxValor_costo.Text = ""
                Case "Conceptos"
                    Conceptos.CBAplic_concep.Text = ""
                    Conceptos.TxtCodigo_Concep.Text = ""
                    Conceptos.TxtNombre_Concep.Text = ""
                    Conceptos.CbAccion.Text = ""
                Case "Documentos"
                    Documentos.TxtCodigo_doc.Text = ""
                    Documentos.TxtNombre_doc.Text = ""
                Case "Ciudades"
                    Ciudades.TxtCodigo_ciudad.Text = ""
                    Ciudades.TxtNombre_ciudad.Text = ""
                Case "Zonas"
                    Zonas.TxtCodigo_Zona.Text = ""
                    Zonas.Txtciudad_zona.Text = ""
                    Zonas.TxtNombre_Zona.Text = ""
                Case "Terceros"
                    Terceros.TxtCodigo_terce.Text = "0"
                    Terceros.TxtNombre1_terce.Text = ""
                    Terceros.TxtNombre2_terce.Text = ""
                    Terceros.Txtapellido_terce.Text = ""
                    Terceros.TxtApellido_terce2.Text = ""
                    Terceros.TxtTelefono_terce.Text = "0"
                    Terceros.TxtCelular_terce.Text = "0"
                    Terceros.TxtDireccion_terce.Text = ""
                    Terceros.CBTipodoc.Text = ""
                    Terceros.CBoxCiudad_terce.Text = "0"
                    Terceros.Txtcorreo_terce.Text = "correo@email.com"
                    Terceros.CheBoxCliente_terce.Checked = False
                    Terceros.ChBoxProveedor_terce.Checked = False
                    Terceros.ChBoxEmpleado_terce.Checked = False
                Case "Ubicaciones"
                    Variables.sSel = "Select ncodigo_ubica, cnombre_ubica from tbl_ubicaciones order by ncodigo_ubica desc "
                    Try
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Ubicaciones.Txtcodigo.Text = dt.Rows(i)("ncodigo_ubica").ToString() + 1
                        Ubicaciones.TxtNombre_ubica.Text = ""
                        Ubicaciones.TxtDireccion_ubica.Text = ""
                        Ubicaciones.TxtTelefono_ubica.Text = ""
                        Ubicaciones.TxtCelular_ubica.Text = ""
                        Ubicaciones.TxtCorreo_Ubica.Text = ""
                        Ubicaciones.CBoxCiudad_ubica.Text = "0"
                        Ubicaciones.CBoxZona_ubica.Text = ""
                        Ubicaciones.TxtCedula_ubica.Text = "0"
                        Ubicaciones.TxtNombre1_ubica.Text = ""
                        Ubicaciones.TxtNombre2_ubica.Text = ""
                        Ubicaciones.TxtApellido1_ubica.Text = ""
                        Ubicaciones.TxtApellido2_ubica.Text = ""
                        Ubicaciones.CheckBox1.Checked = False
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Escenario X ubicacion"
                    EscenarioXubica.TxtCodigo_EXU.Text = ""
                    EscenarioXubica.TxtNombre_EXU.Text = ""
                    EscenarioXubica.CBEstado_EXU.Text = ""
                    EscenarioXubica.CBUbic_EXU.Text = ""
                    EscenarioXubica.CBTipo_EXU.Text = ""
                Case "Turnos"
                    Turnos.TxtCodigo_turno.Text = ""
                    Turnos.TxtNombre_turno.Text = ""
                    Turnos.TxtHora_inicio.Text = ""
                    Turnos.TxtHora_Final.Text = ""
                Case "Costo Turno"
                    Costo_Turno.CBubic_tabla_costo.Text = ""
                    Costo_Turno.CBtipoescen_costo_turno.Text = ""
                    Costo_Turno.MTxt_hora.Text = ""
                    Costo_Turno.CBLunes.Text = ""
                    Costo_Turno.CBMartes.Text = ""
                    Costo_Turno.CBMiercoles.Text = ""
                    Costo_Turno.CBJueves.Text = ""
                    Costo_Turno.CBViernes.Text = ""
                    Costo_Turno.CBSabado.Text = ""
                    Costo_Turno.CBDomingo.Text = ""
                    Costo_Turno.CBFestivo.Text = ""
                Case "Nueva Reserva"
                    Variables.sSel = "Select ((ncodigo_reser) + 1) ultima from tbl_reservas order by ncodigo_reser desc "
                    Try
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Nueva_Reserva.TxtReserva_reser.Text = dt.Rows(0)("ultima").ToString()
                        Nueva_Reserva.CBoxUbicacion_reser.Text = ""
                        Nueva_Reserva.TxtFecha_reser.Text = ""
                        Nueva_Reserva.MTxtHora_reser.Text = ""
                        Nueva_Reserva.TxtDatos_Cod_escen.Text = ""
                        Nueva_Reserva.TxtDatos_escen.Text = ""
                        Nueva_Reserva.TxtDatos_tipocosto.Text = ""
                        Nueva_Reserva.TxtDatos_Costo.Text = ""
                        Nueva_Reserva.TxtDocumento_terce_reser.Text = "0"
                        Nueva_Reserva.Txt_doc.Text = ""
                        Nueva_Reserva.TxtNombre1_terce.Text = ""
                        Nueva_Reserva.TxtNombre2_terce.Text = ""
                        Nueva_Reserva.TxtApellido_terce_reser.Text = ""
                        Nueva_Reserva.TxtApellido2_terce_reser.Text = ""
                        Nueva_Reserva.CBEstado_reser.Text = "AC"
                        Nueva_Reserva.BtnDisponibles_reser.Visible = True
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Facturas"
                    Variables.sSel = "Select * from tbl_facturas where ccod_conce_factu = 'FV'order by ncodigo_factu desc "
                    Try
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Facturas.TxtFactura_factu.Text = dt.Rows(i)("ncodigo_factu").ToString() + 1
                        Facturas.CBConcepto_factu.Text = "FV"
                        Facturas.TxtFecha_factu.Text = Today()
                        Facturas.CBoxUbicacion_factu.Text = ""
                        Facturas.TxtDocumento_terce_factu.Text = "0"
                        Facturas.TxtNombre1_factu.Text = ""
                        Facturas.TxtNombre2_factu.Text = ""
                        Facturas.TxtApellido_terce_factu.Text = ""
                        Facturas.TxtApellido2_terce_factu.Text = ""
                        Facturas.LblEstado.ForeColor = Color.Green
                        Facturas.LblEstado.Text = "Activo"
                        Facturas.Codigo1.Text = ""
                        Facturas.Producto1.Text = "*"
                        Facturas.Existencia1.Text = ""
                        Facturas.Cantidad1.Text = ""
                        Facturas.Impuesto1.Text = "0"
                        Facturas.Descuento1.Text = "0"
                        Facturas.Unidad1.Text = "*"
                        Facturas.precio1.Text = "0"
                        Variables.bf.Clear()
                        Variables.df.Clear()
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Cotizaciones"
                    Variables.sSel = "Select * from tbl_cotizaciones where ccod_conce_cotiz = 'CT'order by ncodigo_cotiz desc "
                    Try
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Cotizaciones.TxtFactura_factu.Text = dt.Rows(i)("ncodigo_cotiz").ToString() + 1
                        Cotizaciones.CBConcepto.Text = "CT"
                        Cotizaciones.TxtFecha_factu.Text = Today()
                        Cotizaciones.CBUbicacion.Text = "0"
                        Cotizaciones.TxtDocumento_terce_factu.Text = "0"
                        Cotizaciones.TxtNombre1_factu.Text = ""
                        Cotizaciones.TxtNombre2_factu.Text = ""
                        Cotizaciones.TxtApellido_terce_factu.Text = ""
                        Cotizaciones.TxtApellido2_terce_factu.Text = ""
                        Cotizaciones.txt_observaciones.Text = ""
                        Cotizaciones.LblEstado.ForeColor = Color.Green
                        Cotizaciones.LblEstado.Text = "Activo"
                        Cotizaciones.Codigo1.Text = ""
                        Cotizaciones.Producto1.Text = "*"
                        Cotizaciones.Existencia1.Text = ""
                        Cotizaciones.Cantidad1.Text = "0"
                        Cotizaciones.Impuesto1.Text = "0"
                        Cotizaciones.Descuento1.Text = "0"
                        Cotizaciones.Unidad1.Text = "*"
                        Cotizaciones.precio1.Text = "0"
                        Variables.bf.Clear()
                        Variables.df.Clear()
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Pedidos"
                    Variables.sSel = "Select * from tbl_pedidos where ccod_conce_pedid = 'PD'order by ncodigo_pedid desc "
                    Try
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Pedidos.TxtFactura_factu.Text = dt.Rows(i)("ncodigo_pedid").ToString() + 1
                        Pedidos.CBConcepto.Text = "PD"
                        Pedidos.TxtFecha_factu.Text = Today()
                        Pedidos.CBUbicacion.Text = "0"
                        Pedidos.TxtDocumento_terce_factu.Text = "0"
                        Pedidos.TxtNombre1_factu.Text = ""
                        Pedidos.TxtNombre2_factu.Text = ""
                        Pedidos.TxtApellido_terce_factu.Text = ""
                        Pedidos.TxtApellido2_terce_factu.Text = ""
                        Pedidos.txt_observaciones.Text = ""
                        Pedidos.LblEstado.ForeColor = Color.Green
                        Pedidos.LblEstado.Text = "Activo"
                        Pedidos.Codigo1.Text = ""
                        Pedidos.Producto1.Text = "*"
                        Pedidos.Existencia1.Text = ""
                        Pedidos.Cantidad1.Text = "0"
                        Pedidos.Impuesto1.Text = "0"
                        Pedidos.Descuento1.Text = "0"
                        Pedidos.Unidad1.Text = "*"
                        Pedidos.precio1.Text = "0"
                        Variables.bf.Clear()
                        Variables.df.Clear()
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Perfiles"
                    Variables.sSel = "Select * from tbl_perfiles order by ncodigo_perfil desc"
                    Try
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Perfiles.TxtCodigo_perfil.Text = dt.Rows(i)("ncodigo_perfil").ToString() + 1
                        Perfiles.CBcrear.Text = "NO"
                        Perfiles.TxtNombre_perfil.Text = ""
                        Perfiles.CBconsultar.Text = "NO"
                        Perfiles.CBactualizar.Text = "NO"
                        Perfiles.CBconfirmar.Text = "NO"
                        Perfiles.CBreversar.Text = "NO"
                        Perfiles.CBanular.Text = "NO"
                        Perfiles.CBimprimir.Text = "NO"
                        Perfiles.CBconsola.Text = "NO"
                        Perfiles.CBEstado.Text = ""
                        Perfiles.documentos_admon.Text = "NO"
                        Perfiles.conceptos_admon.Text = "NO"
                        Perfiles.escenarios_admon.Text = "NO"
                        Perfiles.costos_admon.Text = "NO"
                        Perfiles.cuidades_admon.Text = "NO"
                        Perfiles.zonas_admon.Text = "NO"
                        Perfiles.terceros_admon.Text = "NO"
                        Perfiles.ubicaciones_admon.Text = "NO"
                        Perfiles.escenxubica_admon.Text = "NO"
                        Perfiles.tblcostos_admon.Text = "NO"
                        Perfiles.productos_inven.Text = "NO"
                        Perfiles.movimientos_inven.Text = "NO"
                        Perfiles.saldos_inven.Text = "NO"
                        Perfiles.Ordenes_segur.Text = "NO"
                        Perfiles.facturas_factu.Text = "NO"
                        Perfiles.Pedidos_factu.Text = "NO"
                        Perfiles.cotizaciones_factu.Text = "NO"
                        Perfiles.reservas_factu.Text = "NO"
                        Perfiles.administraivos_report.Text = "NO"
                        Perfiles.inventarios_report.Text = "NO"
                        Perfiles.facturacion_report.Text = "NO"
                        Perfiles.perfiles_segur.Text = "NO"
                        Perfiles.usuarios_segur.Text = "NO"
                        Perfiles.claves_segur.Text = "NO"
                        Perfiles.empresa_segur.Text = "NO"
                        Perfiles.Auditoria_segur.Text = "NO"
                        Perfiles.Licencia_segur.Text = "NO"
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Usuarios"
                    Try
                        Usuarios.TxtContraseña_perfil.Text = ""
                        Usuarios.CBUbica_Usuarios.Text = "0"
                        Usuarios.CBPerfil_usuario.Text = "0"
                        Usuarios.TxtTercero_usua.Text = "0"
                        Usuarios.CBEstado_Usuarios.Text = ""
                        Usuarios.Txtconfirmacontraseña_perfil.Text = ""
                        Usuarios.Txt_usuario_usua.Text = "0"
                        Usuarios.Txtapellido1_usua.Text = ""
                        Usuarios.TxtApellido2_usua.Text = ""
                        Usuarios.TxtCelular.Text = "0"
                        Usuarios.TxtCorreo_usua.Text = ""
                        Usuarios.TxtNombre1_terce.Text = ""
                        Usuarios.TxtNombre2_terce.Text = ""
                        Usuarios.TxtTelefono_usua.Text = "0"
                        Usuarios.LblPerfildes.Text = ""
                        Usuarios.LblNombredoc_terce.Text = ""
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try
                Case "Productos"
                    Productos.Imagen_produc.Image = Image.FromFile(carpeta_imagenes & "\Foto.jpg")
                    Productos.Txtcodigo_produ.Text = ""
                    Productos.Txtcodigoext_produ.Text = ""
                    Productos.TxtNombre_produ.Text = ""
                    ruta_imagen_guardar = ""
                    Productos.TxtCategoria_produ.Text = ""
                    Productos.TxtMarca_produ.Text = ""
                    Productos.TxtUnidad_produ.Text = ""
                    Productos.TxtFechavence_produ.Text = ""
                    Productos.Txtalto_produ.Text = ""
                    Productos.TxtAncho_produ.Text = ""
                    Productos.TxtLargo_produ.Text = ""
                    Productos.TxtCapacidad_produ.Text = ""
                    Productos.Txtdiametro_produ.Text = ""
                    Productos.TxtPeso_produ.Text = ""
                    Productos.TxtColor_produ.Text = ""
                    Productos.Txtiva_produ.Text = ""
                    Productos.Txtdescuento_produ.Text = ""
                    Productos.Txtcompra_produ.Text = ""
                    Productos.TxtVenta_produ.Text = ""
                    Productos.CBVencimiento_produ.Checked = False
                    Productos.TxtFechavence_produ.Visible = False
                    Productos.CB_Combo.Text = "NO"
                    Productos.Txtobservacion_produ.Text = ""
                    Productos.TxtCantidad.Text = "0"
                    Productos.TxtComponente.Text = "0"
                    Productos.GroupCombo.Visible = False
                Case "Movimientos"
                    Variables.sSel = "select * from tbl_movimiento_producto order by ncodigo_moviprodu desc"
                    Try
                        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                        Variables.da.Fill(dt)
                        Variables.da.Fill(dt)
                        Mov_inventarios.Txtcodigo_movprodu.Text = dt.Rows(i)("ncodigo_moviprodu").ToString + 1
                        Mov_inventarios.CBConcepto.Text = ""
                        Mov_inventarios.CBUbicacion.Text = ""
                        Mov_inventarios.TxtFecha_reser.Text = Today
                        Mov_inventarios.LblEstado.Text = "AC"
                        Mov_inventarios.gran_descuento.Text = "0"
                        Mov_inventarios.impuesto.Text = "0"
                        Mov_inventarios.neto.Text = "0"
                        Mov_inventarios.gran_total.Text = "0"
                        Mov_inventarios.TxtDocumento_terce_factu.Text = "0"
                        Mov_inventarios.Codigo1.Text = "0"
                        Mov_inventarios.Precio1.Text = "0"
                        Mov_inventarios.Producto1.Text = "*"
                        Mov_inventarios.Impuesto1.Text = "0"
                        Mov_inventarios.Descuento1.Text = "0"
                        Mov_inventarios.Existencia1.Text = ""
                        Mov_inventarios.Unidad1.Text = "*"
                        Mov_inventarios.Cantidad1.Text = "0"
                        Mov_inventarios.TxtFactuproveedor.Text = ""
                        Mov_inventarios.Descuento_Movi.Text = ""
                        Variables.dm.Clear()
                        Variables.dm.Clear()
                    Catch ex As Exception

                    End Try
                Case "Empresa"
                    Empresa.TxtNombre.Text = ""
                    Empresa.Txt_nit.Text = "0"
                    Empresa.TxtDireccion.Text = ""
                    Empresa.TxtTelefono_ubica.Text = "0"
                    Empresa.TxtCelular_ubica.Text = "0"
                    Empresa.TxtManuales.Text = ""
                    Empresa.TxtRutaimgpro.Text = ""
                    Empresa.TxtReportes.Text = ""
                    Empresa.TxtCorreo_Ubica.Text = ""
                    Empresa.TxTclave.Text = ""
                    Empresa.Txtsmpt.Text = ""
                    Empresa.Txtpuerto.Text = "0"
                    Empresa.Txtresolucion.Text = ""
            End Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Module

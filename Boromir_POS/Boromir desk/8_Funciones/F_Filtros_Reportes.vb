Module F_Filtros_Reportes

    Public Function filtros_saldos()
        Dim consulta As String = "select ncod_produ_saldo 'Codigo',ncod_externo_produ'Cod Externo' ,cnombre_produ 'Nombre',ncod_ubica_saldo 'Ubicacion', ncantidad_saldo 'Saldo' from tbl_saldos,tbl_productos where ncodigo_produ = ncod_produ_saldo "

        If Saldos.Txtcodigo_saldos.Text <> "" Then
            consulta = "select ncod_produ_saldo 'Codigo',ncod_externo_produ'Cod Externo' ,cnombre_produ 'Nombre',ncod_ubica_saldo 'Ubicacion', ncantidad_saldo 'Saldo' from tbl_saldos,tbl_productos where ncodigo_produ = ncod_produ_saldo "
        End If

        If Saldos.Txtcodigo_saldos.Text = "" And Saldos.CBubica_saldos.Text = "" And Saldos.txtcantidad_saldo.Text <> "" Then
            consulta = "select ncod_produ_saldo 'Codigo',ncod_externo_produ'Cod Externo' ,cnombre_produ 'Nombre',ncod_ubica_saldo 'Ubicacion', ncantidad_saldo 'Saldo' from tbl_saldos,tbl_productos where ncodigo_produ = ncod_produ_saldo and ncantidad_saldo >= '" & Integer.Parse(Saldos.txtcantidad_saldo.Text) & "' "
        End If

        If Saldos.Txtcodigo_saldos.Text = "" And Saldos.CBubica_saldos.Text <> "" And Saldos.txtcantidad_saldo.Text = "" Then
            consulta = "select ncod_produ_saldo 'Codigo',ncod_externo_produ'Cod Externo' ,cnombre_produ 'Nombre',ncod_ubica_saldo 'Ubicacion', ncantidad_saldo 'Saldo' from tbl_saldos,tbl_productos where ncodigo_produ = ncod_produ_saldo and ncod_ubica_saldo = '" & Integer.Parse(Saldos.CBubica_saldos.Text) & "' "
        End If

        If Saldos.Txtcodigo_saldos.Text <> "" And Saldos.CBubica_saldos.Text = "" And Saldos.txtcantidad_saldo.Text = "" Then
            consulta = "select ncod_produ_saldo 'Codigo',ncod_externo_produ'Cod Externo' ,cnombre_produ 'Nombre',ncod_ubica_saldo 'Ubicacion', ncantidad_saldo 'Saldo' from tbl_saldos,tbl_productos where ncodigo_produ = ncod_produ_saldo and ncod_produ_saldo = '" & Integer.Parse(Saldos.Txtcodigo_saldos.Text) & "' "
        End If

        If Saldos.Txtcodigo_saldos.Text <> "" And Saldos.CBubica_saldos.Text <> "" And Saldos.txtcantidad_saldo.Text = "" Then
            consulta = "select ncod_produ_saldo 'Codigo',ncod_externo_produ'Cod Externo' ,cnombre_produ 'Nombre',ncod_ubica_saldo 'Ubicacion', ncantidad_saldo 'Saldo' from tbl_saldos,tbl_productos where ncodigo_produ = ncod_produ_saldo and ncod_produ_saldo = '" & Integer.Parse(Saldos.Txtcodigo_saldos.Text) & "' and ncod_ubica_saldo = '" & Integer.Parse(Saldos.CBubica_saldos.Text) & "' "
        End If

        If Saldos.Txtcodigo_saldos.Text <> "" And Saldos.CBubica_saldos.Text <> "" And Saldos.txtcantidad_saldo.Text <> "" Then
            consulta = "select ncod_produ_saldo 'Codigo',ncod_externo_produ'Cod Externo' ,cnombre_produ 'Nombre',ncod_ubica_saldo 'Ubicacion', ncantidad_saldo 'Saldo' from tbl_saldos,tbl_productos where ncodigo_produ = ncod_produ_saldo and ncod_produ_saldo = '" & Integer.Parse(Saldos.Txtcodigo_saldos.Text) & "' and ncod_ubica_saldo = '" & Integer.Parse(Saldos.CBubica_saldos.Text) & "'  and ncantidad_saldo >= '" & Integer.Parse(Saldos.txtcantidad_saldo.Text) & "' "
        End If

        If Saldos.Txtcodigo_saldos.Text <> "" And Saldos.CBubica_saldos.Text = "" And Saldos.txtcantidad_saldo.Text <> "" Then
            consulta = "select ncod_produ_saldo 'Codigo',ncod_externo_produ'Cod Externo' ,cnombre_produ 'Nombre',ncod_ubica_saldo 'Ubicacion', ncantidad_saldo 'Saldo' from tbl_saldos,tbl_productos where ncodigo_produ = ncod_produ_saldo and ncod_produ_saldo = '" & Integer.Parse(Saldos.Txtcodigo_saldos.Text) & "' and ncantidad_saldo >= '" & Integer.Parse(Saldos.txtcantidad_saldo.Text) & "' "
        End If

        If Saldos.Txtcodigo_saldos.Text = "" And Saldos.CBubica_saldos.Text <> "" And Saldos.txtcantidad_saldo.Text <> "" Then
            consulta = "select ncod_produ_saldo 'Codigo',ncod_externo_produ'Cod Externo' ,cnombre_produ 'Nombre',ncod_ubica_saldo 'Ubicacion', ncantidad_saldo 'Saldo' from tbl_saldos,tbl_productos where ncodigo_produ = ncod_produ_saldo and ncod_ubica_saldo = '" & Integer.Parse(Saldos.CBubica_saldos.Text) & "'   and ncantidad_saldo >= '" & Integer.Parse(Saldos.txtcantidad_saldo.Text) & "' "
        End If
        Return consulta
    End Function
    Public Function filtros_facturacion()
        Dim retorno As String = " 'CF'"
        If Reporteador.CBPeriodicos.Checked = True Then
            retorno = retorno & " and ffecha_factu in ('" & Reporteador.DTxtdesde.Text & "', '" & Reporteador.DTxthasta.Text & "')"
        End If

        If Reporteador.CBPeriodicos.Checked = False And Reporteador.CBProductos.Checked = True And Reporteador.CBTerceros.Checked = False And Reporteador.CBConceptos.Checked = False Then
            retorno = retorno & " and tbl_detalle_movimientos.ncod_produ_detmovim = '" & Integer.Parse(Reporteador.TxtProducto.Text) & "'"
        End If
        If Reporteador.CBTerceros.Checked = True Then
            retorno = retorno & " and tbl_facturas.ncod_terce_factu = '" & Integer.Parse(Reporteador.TxtTercero.Text) & "'"
        End If
        If Reporteador.CBConceptos.Checked = True Then
            retorno = retorno & " and ccod_conce_detmovim = '" & Reporteador.ComboBConcepto.Text & "'"
        End If
        Return retorno
    End Function
    Public Function filtros_inventarios()
        Dim retorno As String = ""
        If Reporteador.CBPeriodicos.Checked = True Then
            retorno = retorno & " and ffecha_detmovim in ('" & Reporteador.DTxtdesde.Text & "', '" & Reporteador.DTxthasta.Text & "')"
        End If
        If Reporteador.CBProductos.Checked = True Then
            retorno = retorno & "and  tbl_detalle_movimientos.ncod_produ_detmovim = '" & Integer.Parse(Reporteador.TxtProducto.Text) & "'"
        End If
        If Reporteador.CBTerceros.Checked = True Then
            retorno = retorno & " and tbl_movimiento_producto.ncod_terce_moviprodu = '" & Integer.Parse(Reporteador.TxtTercero.Text) & "'"
        End If
        If Reporteador.CBConceptos.Checked = True Then
            retorno = retorno & " and ccod_conce_detmovim = '" & Reporteador.ComboBConcepto.Text & "'"
        End If
        Return retorno
    End Function

End Module

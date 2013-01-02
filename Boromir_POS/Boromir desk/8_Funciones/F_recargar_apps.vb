Module F_recargar_apps

    Public Sub perfiles_reload()
        Try
            Call F_Cargar_Combox.Cargar_estados()
            For Each dr As DataRow In Variables.Filas_estado
                Perfiles.CBEstado.Items.Add(dr("ccodigo_estad"))
            Next
            Variables.dt.Clear()
        Catch ex As Exception
            MsgBox("Error Reload Perfil: " & ex.Message)
        End Try
    End Sub
    Public Sub usuarios_reload()
        Try
            Call F_Cargar_Combox.Cargar_estados()
            For Each dr As DataRow In Variables.Filas_estado
                Usuarios.CBEstado_Usuarios.Items.Add(dr("ccodigo_estad"))
            Next
            Variables.dt.Clear()

            Call F_Cargar_Combox.Cargar_Ubicaciones()
            For Each dr As DataRow In Variables.Filas_ubicaciones
                Usuarios.CBUbica_Usuarios.Items.Add(dr("ncodigo_ubica"))
            Next
            Variables.dt.Clear()

            Call F_Cargar_Combox.Cargar_Periles()
            For Each dr As DataRow In Variables.Filas_perfil
                Usuarios.CBPerfil_usuario.Items.Add(dr("ncodigo_perfil"))
            Next
            Variables.dt.Clear()
        Catch ex As Exception
            MsgBox("Error Reload Usuarios: " & ex.Message)
        End Try
    End Sub
    Public Sub saldos_reload()
        Try
            Call F_Cargar_Combox.Cargar_Ubicaciones()
            For Each dr As DataRow In Variables.Filas_ubicaciones
                Saldos.CBubica_saldos.Items.Add(dr("ncodigo_ubica"))
            Next
            Variables.dt.Clear()
        Catch ex As Exception
            MsgBox("Error Reload Movimientos: " & ex.Message)
        End Try
    End Sub
    Public Sub movimientos_reload()
        Try
            Call F_Cargar_Combox.Cargar_Conceptos()
            Mov_inventarios.CBConcepto.Items.Clear()
            For Each dr As DataRow In Variables.Filas_conceptos
                Mov_inventarios.CBConcepto.Items.Add(dr("ccodigo_conce"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()

            Call F_Cargar_Combox.Cargar_Ubicaciones()
            Mov_inventarios.CBUbicacion.Items.Clear()
            For Each dr As DataRow In Variables.Filas_ubicaciones
                Mov_inventarios.CBUbicacion.Items.Add(dr("ncodigo_ubica"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
        Catch ex As Exception
            MsgBox("Error Reload Movimientos: " & ex.Message)
        End Try
    End Sub
    Public Sub Cotizaciones_reload()
        Try
            Call F_Cargar_Combox.Cargar_Conceptos()
            Cotizaciones.CBConcepto.Items.Clear()
            For Each dr As DataRow In Variables.Filas_conceptos
                Cotizaciones.CBConcepto.Items.Add(dr("ccodigo_conce"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()

            Call F_Cargar_Combox.Cargar_Ubicaciones()
            Cotizaciones.CBUbicacion.Items.Clear()
            For Each dr As DataRow In Variables.Filas_ubicaciones
                Cotizaciones.CBUbicacion.Items.Add(dr("ncodigo_ubica"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
        Catch ex As Exception
            MsgBox("Error Reload Movimientos: " & ex.Message)
        End Try
    End Sub

    Public Sub produtos_reload()
        Try
            Call F_Cargar_Combox.cargar_categorias()
            Productos.TxtCategoria_produ.Items.Clear()
            For Each dr As DataRow In Variables.filas_categorias
                Productos.TxtCategoria_produ.Items.Add(dr("cnombre_categ").ToString)
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
            Call F_Cargar_Combox.cargar_marcas()
            Productos.TxtMarca_produ.Items.Clear()
            For Each dr As DataRow In Variables.filas_marcas
                Productos.TxtMarca_produ.Items.Add(dr("cnombre_marca").ToString)
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
            Call F_Cargar_Combox.cargar_colores()
            Productos.TxtColor_produ.Items.Clear()
            For Each dr As DataRow In Variables.filas_colores
                Productos.TxtColor_produ.Items.Add(dr("cnombre_color").ToString)
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
            Call F_Cargar_Combox.cargar_undmed()
            Productos.TxtUnidad_produ.Items.Clear()
            For Each dr As DataRow In Variables.filas_unidades
                Productos.TxtUnidad_produ.Items.Add(dr("cnombre_undmed").ToString)
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
        Catch ex As Exception
            MsgBox("Error Reload  Productos: " & ex.Message)
        End Try
    End Sub

    Public Sub conceptos_reload()
        Try
            Call F_Cargar_Combox.cargar_aplicaciones()
            Conceptos.CBAplic_concep.Items.Clear()
            For Each dr As DataRow In Variables.filas_aplicaciones
                Conceptos.CBAplic_concep.Items.Add(dr("ccodigo_aplic").ToString)
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
        Catch ex As Exception
            MsgBox("Error Reload  Conceptos: " & ex.Message)
        End Try

    End Sub
    Public Sub costo_turno_reload()
        Try
            Call F_Cargar_Combox.Cargar_Ubicaciones()
            Costo_Turno.CBubic_tabla_costo.Items.Clear()
            For Each dr As DataRow In Variables.Filas_ubicaciones
                Costo_Turno.CBubic_tabla_costo.Items.Add(dr("ncodigo_ubica"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub escenXubica_reload()
        Try

            Call F_Cargar_Combox.Cargar_Tipo_Costo()
            EscenarioXubica.CBtcosto_EXU.Items.Clear()
            For Each dr As DataRow In Variables.Filas_tipo_costo
                EscenarioXubica.CBtcosto_EXU.Items.Add(dr("ccodigo_tcosto"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()

            Call F_Cargar_Combox.Cargar_Ubicaciones()
            EscenarioXubica.CBUbic_EXU.Items.Clear()
            For Each dr As DataRow In Variables.Filas_ubicaciones
                EscenarioXubica.CBUbic_EXU.Items.Add(dr("ncodigo_ubica"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()

            Call F_Cargar_Combox.Cargar_estados()
            EscenarioXubica.CBEstado_EXU.Items.Clear()
            For Each dr As DataRow In Variables.Filas_estado
                EscenarioXubica.CBEstado_EXU.Items.Add(dr("ccodigo_estad"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()

            Call F_Cargar_Combox.Cargar_TipoEscenario()
            EscenarioXubica.CBTipo_EXU.Items.Clear()
            For Each dr As DataRow In Variables.Filas_escenarios
                EscenarioXubica.CBTipo_EXU.Items.Add(dr("cnombre_tescen"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()

        Catch ex As Exception
            MsgBox("Error Reload EscenXubica: " & ex.Message)
        End Try
    End Sub
    Public Sub terceros_reload()
        Try
            Call F_Cargar_Combox.Cargar_TipoDoc()
            Terceros.CBTipodoc.Items.Clear()
            For Each dr As DataRow In Variables.Filas_tipodoc
                Terceros.CBTipodoc.Items.Add(dr("ccodigo_tipodoc"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()

            Call F_Cargar_Combox.Cargar_Ciudad()
            Terceros.CBoxCiudad_terce.Items.Clear()
            For Each dr As DataRow In Variables.Filas_ciudad
                Terceros.CBoxCiudad_terce.Items.Add(dr("ncodigo_ciudad"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()

            Call F_Cargar_Combox.Cargar_estados()
            Terceros.CBEstado.Items.Clear()
            For Each dr As DataRow In Variables.Filas_estado
                Terceros.CBEstado.Items.Add(dr("ccodigo_estad"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
        Catch ex As Exception
            MsgBox("Error Reload Terceros: " & ex.Message)
        End Try
    End Sub
    Public Sub tipo_costo_reload()
        Try
            Call F_Cargar_Combox.Cargar_Ubicaciones()
            Tipo_Costo.CBubic_tipocost.Items.Clear()
            For Each dr As DataRow In Variables.Filas_ubicaciones
                Tipo_Costo.CBubic_tipocost.Items.Add(dr("ncodigo_ubica"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
        Catch ex As Exception
            MsgBox("Error Reload Tipo costo: " & ex.Message)
        End Try
    End Sub
    Public Sub tipo_escenario_reload()
        Try

        Catch ex As Exception
            MsgBox("Error Reload Escenarios: " & ex.Message)
        End Try
    End Sub
    Public Sub ubicaciones_reload()
        Try
            Call F_Cargar_Combox.Cargar_Ciudad()
            Ubicaciones.CBoxCiudad_ubica.Items.Clear()
            For Each dr As DataRow In Variables.Filas_ciudad
                Ubicaciones.CBoxCiudad_ubica.Items.Add(dr("ncodigo_ciudad"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
        Catch ex As Exception
            MsgBox("Error Reload Ubicaciones: " & ex.Message)
        End Try
    End Sub
    Public Sub zonas_reload()
        '  Dim i As Integer
        Try
            Call F_Cargar_Combox.Cargar_Ciudad()
            Zonas.Txtciudad_zona.Items.Clear()
            For Each dr As DataRow In Variables.Filas_ciudad
                Zonas.Txtciudad_zona.Items.Add(dr("ncodigo_ciudad").ToString)
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
        Catch ex As Exception
            MsgBox("Error Reload Zonas: " & ex.Message)
        End Try
    End Sub
    Public Sub facturas_reload()

        Try
            Call F_Cargar_Combox.Cargar_Conceptos()
            Facturas.CBConcepto_factu.Items.Clear()
            For Each dr As DataRow In Variables.Filas_conceptos
                Facturas.CBConcepto_factu.Items.Add(dr("ccodigo_conce"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()

            Call F_Cargar_Combox.Cargar_Ubicaciones()
            Facturas.CBoxUbicacion_factu.Items.Clear()
            For Each dr As DataRow In Variables.Filas_ubicaciones
                Facturas.CBoxUbicacion_factu.Items.Add(dr("ncodigo_ubica"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
        Catch ex As Exception
            MsgBox("Error Reload Facturas: " & ex.Message)
        End Try
    End Sub
    Public Sub Pedidos_reload()
        Try
            Call F_Cargar_Combox.Cargar_Conceptos()
            Pedidos.CBConcepto.Items.Clear()
            For Each dr As DataRow In Variables.Filas_conceptos
                Pedidos.CBConcepto.Items.Add(dr("ccodigo_conce"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()

            Call F_Cargar_Combox.Cargar_Ubicaciones()
            Pedidos.CBUbicacion.Items.Clear()
            For Each dr As DataRow In Variables.Filas_ubicaciones
                Pedidos.CBUbicacion.Items.Add(dr("ncodigo_ubica"))
            Next
            F_Cargar_Combox.dtcargarcb.Clear()
        Catch ex As Exception
            MsgBox("Error Reload Movimientos: " & ex.Message)
        End Try
    End Sub
End Module

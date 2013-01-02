Imports System.Data
Imports System.Data.SqlClient
Module F_Permisos_usuarios
    Dim i As Integer
    '----------------------------------------------------------------------------------------------------------
    '----------------Bloquear  SEGUN PERFIL-------------------------------------------------------------------
    Public Sub Permisos_perfil_botones()
        Dim i As Integer
        Try
            Dim ds As New DataTable
            Variables.sSel = "select * from tbl_usuarios, tbl_perfiles,tbl_aplicperfil where cnombre_usua = '" & Variables.user & "' and ncod_perfil_usua = ncodigo_perfil and ncodigo_perfil = ncod_perfil_aplicperfil "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(ds)
            Variables.Crear = ds.Rows(i)("ccrear_perfil").ToString()
            Variables.Consultar = ds.Rows(i)("cconsultar_perfil").ToString()
            Variables.Modificar = ds.Rows(i)("cmodificar_perfil").ToString()
            Variables.Confirmar = ds.Rows(i)("cconfirmar_perfil").ToString()
            Variables.Reversar = ds.Rows(i)("creversar_perfil").ToString()
            Variables.Anular = ds.Rows(i)("canular_perfil").ToString()
            Variables.imprimir = ds.Rows(i)("cimprimir_perfil").ToString
            Variables.consolasql = ds.Rows(i)("csql_perfil").ToString
            ' ****************************************
            'BLOQUEO DE APLICACIONES SEGUN PERFIL
            '-***************************************
            Variables.documentos_admon = ds.Rows(i)("documentos_admon").ToString()
            Variables.conceptos_admon = ds.Rows(i)("conceptos_admon").ToString()
            Variables.escenarios_admon = ds.Rows(i)("escenarios_admon").ToString()
            Variables.costos_admon = ds.Rows(i)("costos_admon").ToString()
            Variables.cuidades_admon = ds.Rows(i)("cuidades_admon").ToString()
            Variables.zonas_admon = ds.Rows(i)("zonas_admon").ToString()
            Variables.terceros_admon = ds.Rows(i)("terceros_admon").ToString()
            Variables.ubicaciones_admon = ds.Rows(i)("ubicaciones_admon").ToString()
            Variables.escenxubica_admon = ds.Rows(i)("escenxubica_admon").ToString()
            Variables.tblcostos_admon = ds.Rows(i)("tblcostos_admon").ToString()
            Variables.productos_inven = ds.Rows(i)("productos_inven").ToString()
            Variables.movimientos_inven = ds.Rows(i)("movimientos_inven").ToString()
            Variables.saldos_inven = ds.Rows(i)("saldos_inven").ToString()
            Variables.pedidos_factu = ds.Rows(i)("pedidos_factu").ToString()
            Variables.facturas_factu = ds.Rows(i)("facturas_factu").ToString()
            Variables.cotizaciones_factu = ds.Rows(i)("cotizaciones_factu").ToString()
            Variables.reservas_factu = ds.Rows(i)("reservas_factu").ToString()
            Variables.ordenes_inven = ds.Rows(i)("ordenes_inven").ToString()
            Variables.administraivos_report = ds.Rows(i)("administraivos_report").ToString()
            Variables.inventarios_report = ds.Rows(i)("inventarios_report").ToString()
            Variables.facturacion_report = ds.Rows(i)("facturacion_report").ToString()
            Variables.perfiles_segur = ds.Rows(i)("perfiles_segur").ToString()
            Variables.usuarios_segur = ds.Rows(i)("usuarios_segur").ToString()
            Variables.claves_segur = ds.Rows(i)("claves_segur").ToString()
            Variables.empresa_segur = ds.Rows(i)("empresa_segur").ToString()
            Variables.licencia_segur = ds.Rows(i)("licencia_segur").ToString()
            Variables.auditoria_segur = ds.Rows(i)("auditoria_segur").ToString()

            ' AQUI LOS PERMISOS SEGUN BOTONES
            If Variables.Crear = "SI" Then
                Boromir.TBtnNuevo.Enabled = True
            Else
                Boromir.TBtnNuevo.Enabled = False
            End If

            If Variables.Consultar = "SI" Then
                Boromir.TBtnBuscar.Enabled = True
            Else
                Boromir.TBtnBuscar.Enabled = False
            End If

            If Variables.Modificar = "SI" Then
                Boromir.TBtnGuardar.Enabled = True
            Else
                Boromir.TBtnGuardar.Enabled = False
            End If

            If Variables.Confirmar = "SI" Then
                Boromir.TBtnConfirmar.Enabled = True
            Else
                Boromir.TBtnConfirmar.Enabled = False
            End If

            If Variables.Reversar = "SI" Then
                Boromir.TBtnReversar.Enabled = True
            Else
                Boromir.TBtnReversar.Enabled = False
            End If

            If Variables.Anular = "SI" Then
                Boromir.TBtnAnular.Enabled = True
            Else
                Boromir.TBtnAnular.Enabled = False
            End If

            If Variables.imprimir = "SI" Then
                Boromir.TbtnImprimir.Enabled = True
            Else
                Boromir.TbtnImprimir.Enabled = False
            End If

            If Variables.consolasql = "SI" Then
                Boromir.TBtnConsola.Enabled = True
            Else
                Boromir.TBtnConsola.Enabled = False
            End If

            '------------------------FIN BLOQUEO X PERFIL-----------------------------------------------------------------------------
            '-------------------------------------------------------------------------------------------------------------------------
            If Variables.documentos_admon = "SI" Then
                Boromir.DocumentosToolStripMenuItem.Enabled = True
            Else
                Boromir.DocumentosToolStripMenuItem.Enabled = False
            End If

            If Variables.conceptos_admon = "SI" Then
                Boromir.ConceptosToolStripMenuItem.Enabled = True
            Else
                Boromir.ConceptosToolStripMenuItem.Enabled = False
            End If

            If Variables.escenarios_admon = "SI" Then
                Boromir.EscenariosToolStripMenuItem.Enabled = True
            Else
                Boromir.EscenariosToolStripMenuItem.Enabled = False
            End If

            If Variables.costos_admon = "SI" Then
                Boromir.CostosToolStripMenuItem1.Enabled = True
            Else
                Boromir.CostosToolStripMenuItem1.Enabled = False
            End If

            If Variables.cuidades_admon = "SI" Then
                Boromir.CiudadesToolStripMenuItem.Enabled = True
            Else
                Boromir.CiudadesToolStripMenuItem.Enabled = False
            End If


            If Variables.zonas_admon = "SI" Then
                Boromir.ZonasToolStripMenuItem.Enabled = True
            Else
                Boromir.ZonasToolStripMenuItem.Enabled = False
            End If

            If Variables.terceros_admon = "SI" Then
                Boromir.TercerosT.Enabled = True
            Else
                Boromir.TercerosT.Enabled = False
            End If

            If Variables.ubicaciones_admon = "SI" Then
                Boromir.UbicacionesT.Enabled = True
            Else
                Boromir.UbicacionesT.Enabled = False
            End If

            If Variables.escenxubica_admon = "SI" Then
                Boromir.EscenarioXUbicacionToolStripMenuItem.Enabled = True
            Else
                Boromir.EscenarioXUbicacionToolStripMenuItem.Enabled = False
            End If

            If Variables.tblcostos_admon = "SI" Then
                Boromir.CostoPorTurnoToolStripMenuItem.Enabled = True
            Else
                Boromir.CostoPorTurnoToolStripMenuItem.Enabled = False
            End If
            '---------------
            If Variables.productos_inven = "SI" Then
                Boromir.ProductosToolStripMenuItem.Enabled = True
            Else
                Boromir.ProductosToolStripMenuItem.Enabled = False
            End If

            If Variables.movimientos_inven = "SI" Then
                Boromir.MovimientosToolStripMenuItem.Enabled = True
            Else
                Boromir.MovimientosToolStripMenuItem.Enabled = False
            End If

            If Variables.saldos_inven = "SI" Then
                Boromir.SaldosToolStripMenuItem.Enabled = True
            Else
                Boromir.SaldosToolStripMenuItem.Enabled = False
            End If

            'If Variables.combos_inven = "SI" Then
            '    Boromir.CombosToolStripMenuItem.Enabled = True
            'Else
            '    Boromir.CombosToolStripMenuItem.Enabled = False
            'End If
            '-----------
            If Variables.pedidos_factu = "SI" Then
                Boromir.Pedidos_Factu.Enabled = True
            Else
                Boromir.Pedidos_Factu.Enabled = False
            End If

            If Variables.facturas_factu = "SI" Then
                Boromir.FacturasT.Enabled = True
            Else
                Boromir.FacturasT.Enabled = False
            End If

            If Variables.cotizaciones_factu = "SI" Then
                Boromir.CotizacionesT.Enabled = True
            Else
                Boromir.CotizacionesT.Enabled = False
            End If

            If Variables.reservas_factu = "SI" Then
                Boromir.ReservasT.Enabled = True
            Else
                Boromir.ReservasT.Enabled = False
            End If

            If Variables.administraivos_report = "SI" Then
                Boromir.AdministrativosRT.Enabled = True
            Else
                Boromir.AdministrativosRT.Enabled = False
            End If

            If Variables.inventarios_report = "SI" Then
                Boromir.InventariosRT.Enabled = True
            Else
                Boromir.InventariosRT.Enabled = False
            End If

            If Variables.facturacion_report = "SI" Then
                Boromir.FacturacionRT.Enabled = True
            Else
                Boromir.FacturacionRT.Enabled = False
            End If
            '-------------
            If Variables.perfiles_segur = "SI" Then
                Boromir.PerfilesToolStripMenuItem.Enabled = True
            Else
                Boromir.PerfilesToolStripMenuItem.Enabled = False
            End If

            If Variables.usuarios_segur = "SI" Then
                Boromir.UsuariosToolStripMenuItem.Enabled = True
            Else
                Boromir.UsuariosToolStripMenuItem.Enabled = False
            End If

            If Variables.claves_segur = "SI" Then
                Boromir.ClavesToolStripMenuItem.Enabled = True
            Else
                Boromir.ClavesToolStripMenuItem.Enabled = False
            End If

            If Variables.empresa_segur = "SI" Then
                Boromir.EmpresaToolStripMenuItem.Enabled = True
            Else
                Boromir.EmpresaToolStripMenuItem.Enabled = False
            End If

            If Variables.auditoria_segur = "SI" Then
                Boromir.AuditoriaToolStripMenuItem.Enabled = True
            Else
                Boromir.AuditoriaToolStripMenuItem.Enabled = False
            End If

            If Variables.licencia_segur = "SI" Then
                Boromir.LicenciamientoToolStripMenuItem.Enabled = True
            Else
                Boromir.LicenciamientoToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error permisos " & ex.Message)
        End Try
    End Sub
End Module

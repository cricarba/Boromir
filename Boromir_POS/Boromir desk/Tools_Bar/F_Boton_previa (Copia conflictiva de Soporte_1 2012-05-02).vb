Imports Microsoft.Reporting.WinForms
Imports System.Data
Imports System.Data.SqlClient
Module F_Boton_previa
    '*****vistas previas****
    Public Sub Carga_Ventana_Vista_previa()
        Try
            Static i As Integer
            i += 1
            Dim R As String = i.ToString() + 51
            If i = 1 Then
                Vista_Previa.Text = String.Format("Vista Previa")
                Boromir.Tab1.TabPages.Add(R, Vista_Previa.Text)
                Vista_Previa.TopLevel = False
                Vista_Previa.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Vista_Previa.Dock = DockStyle.Fill
                Boromir.Tab1.TabPages(R).Controls.Add(Vista_Previa)
                Boromir.Tab1.SelectedTab = Boromir.Tab1.TabPages(R)
                Boromir.Tab1.TabPages(R).Tag = Vista_Previa
                Vista_Previa.Tag = Boromir.Tab1.TabPages(R)
                Vista_Previa.Show()
            ElseIf Variables.Previa_visible = False And i > 1 Then
                Boromir.Tab1.TabPages.Add(Vista_Previa.Tag)
                Boromir.Tab1.SelectedTab = Vista_Previa.Tag
                Variables.Previa_visible = True
            ElseIf Variables.Previa_visible = True And i > 1 Then
                Boromir.Tab1.SelectedTab = Vista_Previa.Tag
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub


    Public Sub Carga_Datos_Vista_Previa()
        Try
            Dim app As String = Boromir.Tab1.SelectedTab.Text
            Select Case app
                Case "Facturas"
                    Call F_Boton_previa.Carga_Ventana_Vista_previa()
                    Dim listparamter As New List(Of ReportParameter)
                    Vista_Previa.ReportViewer1.ProcessingMode = ProcessingMode.Local
                    Vista_Previa.ReportViewer1.LocalReport.ReportPath = carpeta_reportes & "\vp_facturas.rdlc"
                    Vista_Previa.ReportViewer1.LocalReport.DataSources.Clear()
                    Dim ds As New DataSet()
                    Variables.sSel = "Select * from tbl_facturas,tbl_detalle_movimientos,tbl_productos,tbl_conceptos  where  ncodigo_factu ='" & Facturas.TxtFactura_factu.Text & "' and ccod_conce_factu =  '" & Facturas.CBConcepto_factu.Text & "' and ncod_movim_detmovim = ncodigo_factu and ncod_produ_detmovim = ncodigo_produ and ccodigo_conce = ccod_conce_factu and ccod_conce_detmovim = ccod_conce_factu and ncod_movim_detmovim =  '" & Facturas.TxtFactura_factu.Text & "' and ccod_conce_detmovim = '" & Facturas.CBConcepto_factu.Text & "' "
                    Variables.da = (New SqlDataAdapter(sSel, sCnn))
                    Variables.da.Fill(ds)
                    Dim data1 As New ReportDataSource("DataSet1", ds.Tables(0))
                    Vista_Previa.ReportViewer1.LocalReport.DataSources.Add(data1)

                    Dim de As New DataSet()
                    Variables.sSel = "Select * from tbl_empresa"
                    Variables.da = (New SqlDataAdapter(sSel, sCnn))
                    Variables.da.Fill(de)
                    Dim data2 As New ReportDataSource("Empresa", de.Tables(0))
                    Vista_Previa.ReportViewer1.LocalReport.DataSources.Add(data2)

                    Dim numero = New ReportParameter("numero", Facturas.TxtFactura_factu.Text)
                    Dim concepto = New ReportParameter("concepto", Facturas.CBConcepto_factu.Text)
                    listparamter.Add(numero)
                    listparamter.Add(concepto)
                    numero.Visible = False
                    concepto.Visible = False
                    Vista_Previa.ReportViewer1.LocalReport.SetParameters(listparamter)
                    Vista_Previa.ReportViewer1.RefreshReport()
                Case "Movimientos"
                    Call F_Boton_previa.Carga_Ventana_Vista_previa()
                    'Dim listparamter As New List(Of ReportParameter)
                    Vista_Previa.ReportViewer1.ProcessingMode = ProcessingMode.Local
                    Vista_Previa.ReportViewer1.LocalReport.ReportPath = carpeta_reportes & "\vp_movimientos.rdlc"
                    Vista_Previa.ReportViewer1.LocalReport.DataSources.Clear()
                    Dim ds As New DataSet()
                    Variables.sSel = "Select * from tbl_movimiento_producto,tbl_detalle_movimientos,tbl_productos,tbl_conceptos,tbl_empresa,tbl_ubicaciones  where  ncodigo_moviprodu ='" & Mov_inventarios.Txtcodigo_movprodu.Text & "' and ccod_conce_moviprodu =  '" & Mov_inventarios.CBConcepto.Text & "' and ccodigo_conce = ccod_conce_moviprodu and ncod_movim_detmovim = ncodigo_moviprodu and ncod_produ_detmovim = ncodigo_produ and ccod_conce_detmovim = ccod_conce_moviprodu and ncod_movim_detmovim =  '" & Mov_inventarios.Txtcodigo_movprodu.Text & "' and ccod_conce_detmovim = '" & Mov_inventarios.CBConcepto.Text & "' "
                    Variables.da = (New SqlDataAdapter(sSel, sCnn))
                    Variables.da.Fill(ds)
                    Dim data1 As New ReportDataSource("DataSet1", ds.Tables(0))
                    Vista_Previa.ReportViewer1.LocalReport.DataSources.Add(data1)

                    'Dim numero = New ReportParameter("numero", Facturas.TxtFactura_factu.Text)
                    'Dim concepto = New ReportParameter("concepto", Facturas.CBConcepto_factu.Text)
                    'listparamter.Add(numero)
                    'listparamter.Add(concepto)
                    'numero.Visible = False
                    'concepto.Visible = False
                    'Vista_Previa.ReportViewer1.LocalReport.SetParameters(listparamter)
                    Vista_Previa.ReportViewer1.RefreshReport()
                Case "Cotizaciones"
                    Call F_Boton_previa.Carga_Ventana_Vista_previa()
                    'Dim listparamter As New List(Of ReportParameter)
                    Vista_Previa.ReportViewer1.ProcessingMode = ProcessingMode.Local
                    Vista_Previa.ReportViewer1.LocalReport.ReportPath = carpeta_reportes & "\vp_cotizaciones.rdlc"
                    Vista_Previa.ReportViewer1.LocalReport.DataSources.Clear()
                    Dim ds As New DataSet()
                    Variables.sSel = "Select ncod_produ_detmovim,cnombre_produ,ncantidad_detmovim ,nprecio_detmovim,ncod_ubica_detmovim,nimpuesto_detmovim,ndescuento_detmovim,nneto_cotiz,ndescuento_cotiz,nimpuesto_cotiz,ntotal_cotiz,ncodigo_cotiz, ccod_conce_cotiz,ffecha_cotiz,ncod_movim_detmovim,ccodigo_conce,ncod_ubic_cotiz,cnombre_ubica,cnombre_conce from tbl_cotizaciones,tbl_detalle_movimientos,tbl_productos,tbl_conceptos,tbl_ubicaciones,tbl_terceros where  ncodigo_cotiz ='" & Cotizaciones.TxtFactura_factu.Text & "' and ccod_conce_cotiz =  '" & Cotizaciones.CBConcepto.Text & "' and ccodigo_conce = ccod_conce_cotiz and ncod_movim_detmovim = ncodigo_cotiz and ncod_produ_detmovim = ncodigo_produ and ccod_conce_detmovim = ccod_conce_cotiz and ncod_movim_detmovim =  '" & Cotizaciones.TxtFactura_factu.Text & "' and ccod_conce_detmovim = '" & Cotizaciones.CBConcepto.Text & "' and tbl_ubicaciones.ncodigo_ubica = tbl_cotizaciones.ncod_ubic_cotiz and tbl_terceros.ncodigo_terce = tbl_cotizaciones.ncod_terce_cotiz"
                    Variables.da = (New SqlDataAdapter(sSel, sCnn))
                    Variables.da.Fill(ds)
                    Dim data1 As New ReportDataSource("DataSet1", ds.Tables(0))
                    Vista_Previa.ReportViewer1.LocalReport.DataSources.Add(data1)

                    Dim de As New DataSet()
                    Variables.sSel = "Select * from tbl_empresa"
                    Variables.da = (New SqlDataAdapter(sSel, sCnn))
                    Variables.da.Fill(de)
                    Dim data2 As New ReportDataSource("Empresa", de.Tables(0))
                    Vista_Previa.ReportViewer1.LocalReport.DataSources.Add(data2)

                    Vista_Previa.ReportViewer1.RefreshReport()
            End Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    '******reportes**********
    Public Sub carga_ventana_reporteador()
        Try
            Static i As Integer
            i += 1
            Dim R As String = i.ToString() + 24
            If i = 1 Then
                Reporteador.Text = String.Format("Reporteador")
                Boromir.Tab1.TabPages.Add(R, Reporteador.Text)
                Reporteador.TopLevel = False
                Reporteador.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Reporteador.Dock = DockStyle.Fill
                Boromir.Tab1.TabPages(R).Controls.Add(Reporteador)
                Boromir.Tab1.SelectedTab = Boromir.Tab1.TabPages(R)
                Boromir.Tab1.TabPages(R).Tag = Reporteador
                Reporteador.Tag = Boromir.Tab1.TabPages(R)
                Reporteador.Show()
            ElseIf Variables.Reporteador_visible = False And i > 1 Then
                Boromir.Tab1.TabPages.Add(Reporteador.Tag)
                Boromir.Tab1.SelectedTab = Reporteador.Tag
                Variables.Reporteador_visible = True
            ElseIf Variables.Reporteador_visible = True And i > 1 Then
                Boromir.Tab1.SelectedTab = Reporteador.Tag
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    Public Sub carga_reporte()
        Dim consulta, filtro As String
        Try
            Select Case Variables.nombre_report
                Case "Movimientos Inventario"
                    Dim listparamter As New List(Of ReportParameter)
                    Reporteador.ReportViewer1.ProcessingMode = ProcessingMode.Local
                    Reporteador.ReportViewer1.LocalReport.ReportPath = carpeta_reportes & "\r_inv_movimientos.rdlc"
                    Reporteador.ReportViewer1.LocalReport.DataSources.Clear()
                    consulta = "SELECT tbl_detalle_movimientos.ncod_movim_detmovim ,tbl_detalle_movimientos.ccod_conce_detmovim,tbl_detalle_movimientos.ncod_ubica_detmovim ,tbl_detalle_movimientos.ffecha_detmovim,tbl_detalle_movimientos.ncod_produ_detmovim,tbl_detalle_movimientos.ncantidad_detmovim,tbl_detalle_movimientos.nprecio_detmovim,tbl_detalle_movimientos.ndescuento_detmovim,tbl_detalle_movimientos.nimpuesto_detmovim ,tbl_productos.ncodigo_produ,ncod_externo_produ,tbl_productos.cnombre_produ,tbl_ubicaciones.ncodigo_ubica,tbl_ubicaciones.cnombre_ubica,tbl_conceptos.ccodigo_conce,tbl_conceptos.cnombre_conce FROM tbl_movimiento_producto,tbl_detalle_movimientos INNER JOIN tbl_ubicaciones ON tbl_ubicaciones.ncodigo_ubica = tbl_detalle_movimientos.ncod_ubica_detmovim INNER JOIN tbl_conceptos ON tbl_conceptos.ccodigo_conce = tbl_detalle_movimientos.ccod_conce_detmovim INNER JOIN tbl_productos ON tbl_productos.ncodigo_produ = tbl_detalle_movimientos.ncod_produ_detmovim"
                    filtro = F_Filtros_Reportes.filtros_inventarios()
                    If filtro <> "" Then
                        consulta = consulta & " where 1 = 1 " & filtro
                    End If
                    Dim de As New DataSet()
                    Variables.sSel = consulta
                    Variables.da = (New SqlDataAdapter(sSel, sCnn))
                    Variables.da.Fill(de)
                    Dim data2 As New ReportDataSource("Mov_x_prod", de.Tables(0))
                    Reporteador.ReportViewer1.LocalReport.DataSources.Add(data2)
                    Reporteador.ReportViewer1.RefreshReport()

                Case "Movimientos Facturacion"
                    Dim listparamter As New List(Of ReportParameter)
                    Reporteador.ReportViewer1.ProcessingMode = ProcessingMode.Local
                    Reporteador.ReportViewer1.LocalReport.ReportPath = carpeta_reportes & "\r_fact_movimientos.rdlc"
                    Reporteador.ReportViewer1.LocalReport.DataSources.Clear()
                    consulta = "SELECT tbl_empresa.cnombre_empre,tbl_empresa.nnit_empre,tbl_empresa.cdireccion_empre,tbl_empresa.ntelefono_empre,tbl_detalle_movimientos.ncod_movim_detmovim,tbl_detalle_movimientos.ccod_conce_detmovim,tbl_detalle_movimientos.ncod_ubica_detmovim,tbl_detalle_movimientos.ffecha_detmovim,tbl_detalle_movimientos.ncod_produ_detmovim,tbl_detalle_movimientos.ncantidad_detmovim,tbl_detalle_movimientos.nprecio_detmovim,tbl_detalle_movimientos.ndescuento_detmovim,tbl_detalle_movimientos.nimpuesto_detmovim,tbl_facturas.ncodigo_factu,tbl_facturas.ccod_conce_factu,tbl_facturas.ncod_ubic_factu,tbl_facturas.ncod_terce_factu,tbl_facturas.ffecha_factu,tbl_facturas.nneto_factu,tbl_facturas.ndescuento_factu,tbl_facturas.nimpuesto_factu,tbl_facturas.ntotal_factu,tbl_facturas.ccod_estad_factu,tbl_productos.ncodigo_produ,tbl_productos.ncod_externo_produ,tbl_productos.cnombre_produ,tbl_productos.ccod_categ_produ,tbl_productos.ccod_marca_produ,tbl_productos.ccod_und_produ,tbl_productos.nimpuesto_produ,tbl_productos.ndescuento_produ,tbl_productos.nprecio_compra_produ,tbl_productos.nprecio_venta_produ,tbl_conceptos.ccodigo_conce,tbl_conceptos.cnombre_conce FROM tbl_facturas INNER JOIN tbl_conceptos ON tbl_conceptos.ccodigo_conce = tbl_facturas.ccod_conce_factu  INNER JOIN tbl_detalle_movimientos ON tbl_conceptos.ccodigo_conce = tbl_detalle_movimientos.ccod_conce_detmovim INNER JOIN tbl_productos ON tbl_productos.ncodigo_produ = tbl_detalle_movimientos.ncod_produ_detmovim  CROSS JOIN tbl_empresa"
                    filtro = F_Filtros_Reportes.filtros_facturacion()
                    If filtro <> "" Then
                        consulta = consulta & " where 1 = 1 and ccod_estad_factu = 'CF' " & filtro
                    End If
                    Dim de As New DataSet()
                    Variables.sSel = F_Filtros_Reportes.filtros_facturacion
                    Variables.da = (New SqlDataAdapter(sSel, sCnn))
                    Variables.da.Fill(de)
                    Dim data2 As New ReportDataSource("DataSet1", de.Tables(0))
                    Reporteador.ReportViewer1.LocalReport.DataSources.Add(data2)
                    Reporteador.ReportViewer1.RefreshReport()

                Case "Ventas Producto Fecha"
                    Dim listparamter As New List(Of ReportParameter)
                    Reporteador.ReportViewer1.ProcessingMode = ProcessingMode.Local
                    Reporteador.ReportViewer1.LocalReport.ReportPath = carpeta_reportes & " \r_fact_produc_fecha.rdlc"
                    Reporteador.ReportViewer1.LocalReport.DataSources.Clear()
                    consulta = "SELECT  tbl_detalle_movimientos.ffecha_detmovim ,tbl_detalle_movimientos.ncod_produ_detmovim,tbl_detalle_movimientos.ncantidad_detmovim,tbl_detalle_movimientos.ccod_conce_detmovim,tbl_empresa.cnombre_empre,tbl_empresa.nnit_empre,tbl_productos.ncodigo_produ,tbl_productos.cnombre_produ,tbl_productos.ncod_externo_produ FROM tbl_movimiento_producto,tbl_detalle_movimientos INNER JOIN tbl_productos ON tbl_productos.ncodigo_produ = tbl_detalle_movimientos.ncod_produ_detmovim CROSS JOIN tbl_empresa where ccod_conce_detmovim in ('FR','FV')"
                    filtro = F_Filtros_Reportes.filtros_inventarios()
                    If filtro <> "" Then
                        consulta = consulta & " where 1 = 1 " & filtro
                    End If
                    Dim de As New DataSet()
                    Variables.sSel = consulta
                    Variables.da = (New SqlDataAdapter(sSel, sCnn))
                    Variables.da.Fill(de)
                    Dim data2 As New ReportDataSource("DataSet1", de.Tables(0))
                    Reporteador.ReportViewer1.LocalReport.DataSources.Add(data2)
                    Reporteador.ReportViewer1.RefreshReport()

            End Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub



End Module

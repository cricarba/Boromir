Imports System.Data
Imports System.Data.SqlClient
Module F_Boton_cerrar_pestaña
    Dim i As Integer
    Public Sub cerrar_pestañas()
        Try
            Dim apps As String = Boromir.Tab1.SelectedTab.Text
            Select Case apps
                Case "Tipo Escenarios"
                    Variables.tcanchas_visible = False
                    Boromir.Tab1.TabPages.Remove(Tipo_Escenarios.Tag)
                Case "Tipo Costo"
                    Variables.tcostos_visible = False
                    Boromir.Tab1.TabPages.Remove(Tipo_Costo.Tag)
                Case "Documentos"
                    Variables.tdocumentos_visible = False
                    Boromir.Tab1.TabPages.Remove(Documentos.Tag)
                Case "Conceptos"
                    Variables.Conceptos_visible = False
                    Boromir.Tab1.TabPages.Remove(Conceptos.Tag)
                Case "Ciudades"
                    Variables.ciudades_visible = False
                    Boromir.Tab1.TabPages.Remove(Ciudades.Tag)
                Case "Zonas"
                    Variables.zonas_visible = False
                    Boromir.Tab1.TabPages.Remove(Zonas.Tag)
                Case "Terceros"
                    Variables.teceros_visible = False
                    Boromir.Tab1.TabPages.Remove(Terceros.Tag)
                Case "Ubicaciones"
                    Variables.ubicaciones_visible = False
                    Boromir.Tab1.TabPages.Remove(Ubicaciones.Tag)
                Case "Escenario X ubicacion"
                    Variables.EscenarioXubica_visible = False
                    Boromir.Tab1.TabPages.Remove(EscenarioXubica.Tag)
                Case "Turnos"
                    Variables.turnos_visible = False
                    Boromir.Tab1.TabPages.Remove(Turnos.Tag)
                Case "Costo Turno"
                    Variables.costoturnos_visible = False
                    Boromir.Tab1.TabPages.Remove(Costo_Turno.Tag)
                Case "Productos"
                    Variables.Productos_visible = False
                    Boromir.Tab1.TabPages.Remove(Productos.Tag)
                Case "Saldos"
                    Saldos_visble = False
                    Boromir.Tab1.TabPages.Remove(Saldos.Tag)
                Case "Nueva Reserva"
                    Variables.nueva_visible = False
                    Boromir.Tab1.TabPages.Remove(Nueva_Reserva.Tag)
                Case "Orden de Compra"
                    Ordenes_visible = False
                    Boromir.Tab1.TabPages.Remove(Ordenes_Compra.Tag)
                Case "Facturas"
                    Variables.facturas_visible = False
                    Boromir.Tab1.TabPages.Remove(Facturas.Tag)
                Case "Perfiles"
                    Variables.perfiles_visible = False
                    Boromir.Tab1.TabPages.Remove(Perfiles.Tag)
                Case "Usuarios"
                    Variables.usuarios_visible = False
                    Boromir.Tab1.TabPages.Remove(Usuarios.Tag)
                Case "Movimientos"
                    Movimientos_visible = False
                    Boromir.Tab1.TabPages.Remove(Mov_inventarios.Tag)
                Case "Manuales"
                    Manuales_visible = False
                    Boromir.Tab1.TabPages.Remove(Manuales.Tag)
                Case "Empresa"
                    Empresa_visible = False
                    Boromir.Tab1.TabPages.Remove(Empresa.Tag)
                Case "Mensajes"
                    Mensajes_visible = False
                    Boromir.Tab1.TabPages.Remove(Mensajes.Tag)
                Case "Auditoria"
                    Auditoria_visible = False
                    Boromir.Tab1.TabPages.Remove(Auditoria.Tag)
                Case "Licencia"
                    Licencia_visible = False
                    Boromir.Tab1.TabPages.Remove(Licencia.Tag)
                Case "Cotizaciones"
                    Cotizaciones_visible = False
                    Boromir.Tab1.TabPages.Remove(Cotizaciones.Tag)
                Case "Vista Previa"
                    Previa_visible = False
                    Boromir.Tab1.TabPages.Remove(Vista_Previa.Tag)
                Case "Reporteador"
                    Reporteador_visible = False
                    Boromir.Tab1.TabPages.Remove(Reporteador.Tag)
                Case "Pedidos"
                    Variables.Pedidos_visible = False
                    Boromir.Tab1.TabPages.Remove(Pedidos.Tag)
                Case Else
                    MsgBox("Opcion no habilitada para esta accion", MsgBoxStyle.Information, "Boromir Dice:")
            End Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Module

Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Public Class Boromir
    Dim msj As String
    Dim i As Integer
    Private Sub Boromir_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        msj = MsgBox("¿Desea salir de la aplicacion?", MsgBoxStyle.YesNo, "Boromir Dice:")
        If msj = vbNo Then
            e.Cancel = True
        ElseIf msj = vbYes Then
            Variables.Des_auditoria = "FIN DE SESION"
            Try
                Variables.sSel = "Exec proc_auditoria '" & barra_estad_usuario.Text.ToUpper & "',SALIDA, LOGOUT ,'" & Variables.Des_auditoria.ToUpper & "','" & Now() & "' "
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dt)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        TxtFecha.Text = Today
        Tlbversiontxt.Text = String.Format("{0}", My.Application.Info.Version.ToString)
    End Sub
    '----------------ABRIR PESTAÑAS DE OPCIONS--------------------------
    'administracion
    '---------------------
    Private Sub DocumentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentosToolStripMenuItem.Click
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 1
        If i = 1 Then
            Documentos.Text = String.Format("Documentos")
            Me.Tab1.TabPages.Add(R, Documentos.Text)
            Documentos.TopLevel = False
            Documentos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Documentos.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Documentos)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Documentos
            Documentos.Tag = Me.Tab1.TabPages(R)
            Documentos.Show()
        ElseIf Variables.tdocumentos_visible = False And i > 1 Then
            Tab1.TabPages.Add(Documentos.Tag)
            Tab1.SelectedTab = Documentos.Tag
            Variables.tdocumentos_visible = True
        ElseIf Variables.tdocumentos_visible = True And i > 1 Then
            Tab1.SelectedTab = Documentos.Tag
        End If
    End Sub
    Private Sub ConceptosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConceptosToolStripMenuItem.Click
        Variables.aplic = "CONCE"
        Call F_recargar_apps.conceptos_reload()
        Dim r As New Random()
        Static i As Integer
        i += 1
        Dim k As String = i.ToString() + 2
        If i = 1 Then
            Conceptos.Text = String.Format("Conceptos")
            Me.Tab1.TabPages.Add(k, Conceptos.Text)
            Conceptos.TopLevel = False
            Conceptos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Conceptos.Dock = DockStyle.Fill
            Me.Tab1.TabPages(k).Controls.Add(Conceptos)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(k)
            Me.Tab1.TabPages(k).Tag = Conceptos
            Conceptos.Tag = Me.Tab1.TabPages(k)
            Conceptos.Show()
        ElseIf Variables.Conceptos_visible = False And i > 1 Then
            Tab1.TabPages.Add(Conceptos.Tag)
            Tab1.SelectedTab = Conceptos.Tag
            Variables.Conceptos_visible = True
        ElseIf Variables.Conceptos_visible = True And i > 1 Then
            Tab1.SelectedTab = Conceptos.Tag
        End If
    End Sub
    Private Sub CanchasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EscenariosToolStripMenuItem.Click
        Call F_recargar_apps.tipo_escenario_reload()
        Dim r As New Random()
        Static i As Integer
        i += 1
        Dim k As String = i.ToString() + 3
        If i = 1 Then
            Tipo_Escenarios.Text = String.Format("Tipo Escenarios")
            Me.Tab1.TabPages.Add(k, Tipo_Escenarios.Text)
            Tipo_Escenarios.TopLevel = False
            Tipo_Escenarios.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Tipo_Escenarios.Dock = DockStyle.Fill
            Me.Tab1.TabPages(k).Controls.Add(Tipo_Escenarios)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(k)
            Me.Tab1.TabPages(k).Tag = Terceros
            Tipo_Escenarios.Tag = Me.Tab1.TabPages(k)
            Tipo_Escenarios.Show()
        ElseIf Variables.tcanchas_visible = False And i > 1 Then
            Tab1.TabPages.Add(Tipo_Escenarios.Tag)
            Tab1.SelectedTab = Tipo_Escenarios.Tag
            Variables.tcanchas_visible = True
        ElseIf Variables.tcanchas_visible = True And i > 1 Then
            Tab1.SelectedTab = Tipo_Escenarios.Tag
        End If
    End Sub
    Private Sub CostosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostosToolStripMenuItem1.Click
        Call F_recargar_apps.tipo_costo_reload()
        Dim r As New Random()
        Static i As Integer
        i += 1
        Dim k As String = i.ToString() + 4
        If i = 1 Then
            Tipo_Costo.Text = String.Format("Tipo Costo")
            Me.Tab1.TabPages.Add(k, Tipo_Costo.Text)
            Tipo_Costo.TopLevel = False
            Tipo_Costo.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Tipo_Costo.Dock = DockStyle.Fill
            Me.Tab1.TabPages(k).Controls.Add(Tipo_Costo)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(k)
            Me.Tab1.TabPages(k).Tag = Terceros
            Tipo_Costo.Tag = Me.Tab1.TabPages(k)
            Tipo_Costo.Show()
        ElseIf Variables.tcostos_visible = False And i > 1 Then
            Tab1.TabPages.Add(Tipo_Costo.Tag)
            Tab1.SelectedTab = Tipo_Costo.Tag
            Variables.tcostos_visible = True
        ElseIf Variables.tcostos_visible = True And i > 1 Then
            Tab1.SelectedTab = Tipo_Costo.Tag
        End If
    End Sub
    Private Sub CiudadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CiudadesToolStripMenuItem.Click
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 5
        If i = 1 Then
            Ciudades.Text = String.Format("Ciudades")
            Me.Tab1.TabPages.Add(R, Ciudades.Text)
            Ciudades.TopLevel = False
            Ciudades.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Ciudades.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Ciudades)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Ciudades
            Ciudades.Tag = Me.Tab1.TabPages(R)
            Ciudades.Show()
        ElseIf Variables.ciudades_visible = False And i > 1 Then
            Tab1.TabPages.Add(Ciudades.Tag)
            Tab1.SelectedTab = Ciudades.Tag
            Variables.ciudades_visible = True
        ElseIf Variables.ciudades_visible = True And i > 1 Then
            Tab1.SelectedTab = Ciudades.Tag
        End If
    End Sub
    Private Sub ZonasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZonasToolStripMenuItem.Click
        Call F_recargar_apps.zonas_reload()
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 6
        If i = 1 Then
            Zonas.Text = String.Format("Zonas")
            Me.Tab1.TabPages.Add(R, Zonas.Text)
            Zonas.TopLevel = False
            Zonas.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Zonas.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Zonas)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Zonas
            Zonas.Tag = Me.Tab1.TabPages(R)
            Zonas.Show()
        ElseIf Variables.zonas_visible = False And i > 1 Then
            Tab1.TabPages.Add(Zonas.Tag)
            Tab1.SelectedTab = Zonas.Tag
            Variables.zonas_visible = True
        ElseIf Variables.zonas_visible = True And i > 1 Then
            Tab1.SelectedTab = Zonas.Tag
        End If
    End Sub
    Private Sub TercerosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TercerosT.Click
        Call F_recargar_apps.terceros_reload()
        Dim r As New Random()
        Static i As Integer
        i += 1
        Dim k As String = i.ToString() + 7
        If i = 1 Then
            Terceros.Text = String.Format("Terceros")
            Me.Tab1.TabPages.Add(k, Terceros.Text)
            Terceros.TopLevel = False
            Terceros.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Terceros.Dock = DockStyle.Fill
            Me.Tab1.TabPages(k).Controls.Add(Terceros)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(k)
            Me.Tab1.TabPages(k).Tag = Terceros
            Terceros.Tag = Me.Tab1.TabPages(k)
            Terceros.Show()
        ElseIf Variables.teceros_visible = False And i > 1 Then
            Tab1.TabPages.Add(Terceros.Tag)
            Tab1.SelectedTab = Terceros.Tag
            Variables.teceros_visible = True
        ElseIf Variables.teceros_visible = True And i > 1 Then
            Tab1.SelectedTab = Terceros.Tag
        End If
    End Sub
    Private Sub UbicacionesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbicacionesT.Click
        Call F_recargar_apps.ubicaciones_reload()
        Dim r As New Random()
        Static i As Integer
        i += 1
        Dim k As String = i.ToString() + 8
        If i = 1 Then
            Ubicaciones.Text = String.Format("Ubicaciones")
            'Crea el tab que lo contiene
            Me.Tab1.TabPages.Add(k, Ubicaciones.Text)
            Ubicaciones.TopLevel = False
            Ubicaciones.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Ubicaciones.Dock = DockStyle.Fill
            Me.Tab1.TabPages(k).Controls.Add(Ubicaciones)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(k)
            'Asigna el nuevo form al tag del tabpage
            Me.Tab1.TabPages(k).Tag = Ubicaciones
            'Por si desde el propio form quieres cerrar y eliminar el tab
            Ubicaciones.Tag = Me.Tab1.TabPages(k)
            Ubicaciones.Show()
        ElseIf Variables.ubicaciones_visible = False And i > 1 Then
            Tab1.TabPages.Add(Ubicaciones.Tag)
            Tab1.SelectedTab = Ubicaciones.Tag
            Variables.ubicaciones_visible = True
        ElseIf Variables.ubicaciones_visible = True And i > 1 Then
            Tab1.SelectedTab = Ubicaciones.Tag
        End If
    End Sub
    Private Sub EscenarioXUbicacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EscenarioXUbicacionToolStripMenuItem.Click

        Call F_recargar_apps.escenXubica_reload()
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 9
        If i = 1 Then
            EscenarioXubica.Text = String.Format("Escenario X ubicacion")
            Me.Tab1.TabPages.Add(R, EscenarioXubica.Text)
            EscenarioXubica.TopLevel = False
            EscenarioXubica.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            EscenarioXubica.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(EscenarioXubica)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = EscenarioXubica
            EscenarioXubica.Tag = Me.Tab1.TabPages(R)
            EscenarioXubica.Show()
        ElseIf Variables.EscenarioXubica_visible = False And i > 1 Then
            Tab1.TabPages.Add(EscenarioXubica.Tag)
            Tab1.SelectedTab = EscenarioXubica.Tag
            Variables.EscenarioXubica_visible = True
        ElseIf Variables.EscenarioXubica_visible = True And i > 1 Then
            Tab1.SelectedTab = EscenarioXubica.Tag
        End If
    End Sub
    Private Sub CostoPorTurnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostoPorTurnoToolStripMenuItem.Click
        Call F_recargar_apps.costo_turno_reload()
        Dim r As New Random()
        Static i As Integer
        i += 1
        Dim k As String = i.ToString() + 11
        If i = 1 Then
            Costo_Turno.Text = String.Format("Costo Turno")
            Me.Tab1.TabPages.Add(k, Costo_Turno.Text)
            Costo_Turno.TopLevel = False
            Costo_Turno.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Costo_Turno.Dock = DockStyle.Fill
            Me.Tab1.TabPages(k).Controls.Add(Costo_Turno)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(k)
            Me.Tab1.TabPages(k).Tag = Terceros
            Costo_Turno.Tag = Me.Tab1.TabPages(k)
            Costo_Turno.Show()
        ElseIf Variables.costoturnos_visible = False And i > 1 Then
            Tab1.TabPages.Add(Costo_Turno.Tag)
            Tab1.SelectedTab = Costo_Turno.Tag
            Variables.costoturnos_visible = True
        ElseIf Variables.costoturnos_visible = True And i > 1 Then
            Tab1.SelectedTab = Costo_Turno.Tag
        End If
    End Sub
    '---------------------
    'inventarios
    '---------------------
    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click

        Call F_recargar_apps.produtos_reload()
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 12
        If i = 1 Then
            Productos.Text = String.Format("Productos")
            Me.Tab1.TabPages.Add(R, Productos.Text)
            Productos.TopLevel = False
            Productos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Productos.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Productos)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Productos
            Productos.Tag = Me.Tab1.TabPages(R)
            Productos.Show()
        ElseIf Variables.Productos_visible = False And i > 1 Then
            Tab1.TabPages.Add(Productos.Tag)
            Tab1.SelectedTab = Productos.Tag
            Variables.Productos_visible = True
        ElseIf Variables.Productos_visible = True And i > 1 Then
            Tab1.SelectedTab = Productos.Tag
        End If
    End Sub

    Private Sub MovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosToolStripMenuItem.Click
        Variables.aplic = "MOVIM"
        Call F_recargar_apps.movimientos_reload()
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 13
        If i = 1 Then
            Mov_inventarios.Text = String.Format("Movimientos")
            Me.Tab1.TabPages.Add(R, Mov_inventarios.Text)
            Mov_inventarios.TopLevel = False
            Mov_inventarios.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Mov_inventarios.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Mov_inventarios)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Mov_inventarios
            Mov_inventarios.Tag = Me.Tab1.TabPages(R)
            Mov_inventarios.Show()
        ElseIf Variables.Movimientos_visible = False And i > 1 Then
            Tab1.TabPages.Add(Mov_inventarios.Tag)
            Tab1.SelectedTab = Mov_inventarios.Tag
            Variables.Movimientos_visible = True
        ElseIf Variables.Movimientos_visible = True And i > 1 Then
            Tab1.SelectedTab = Mov_inventarios.Tag
        End If
    End Sub
    Private Sub SaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldosToolStripMenuItem.Click
        Call F_recargar_apps.saldos_reload()
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 14
        If i = 1 Then
            Saldos.Text = String.Format("Saldos")
            Me.Tab1.TabPages.Add(R, Saldos.Text)
            Saldos.TopLevel = False
            Saldos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Saldos.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Saldos)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Saldos
            Saldos.Tag = Me.Tab1.TabPages(R)
            Saldos.Show()
        ElseIf Variables.Saldos_visble = False And i > 1 Then
            Tab1.TabPages.Add(Saldos.Tag)
            Tab1.SelectedTab = Saldos.Tag
            Variables.Saldos_visble = True
        ElseIf Variables.Saldos_visble = True And i > 1 Then
            Tab1.SelectedTab = Saldos.Tag
        End If
    End Sub
    '---------------------
    'facturacion
    '---------------------
    Private Sub Pedidos_Factu_Click(sender As System.Object, e As System.EventArgs) Handles Pedidos_Factu.Click
        Variables.aplic = "PEDID"
        Call F_recargar_apps.Pedidos_reload()
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 26
        If i = 1 Then
            Pedidos.Text = String.Format("Pedidos")
            Me.Tab1.TabPages.Add(R, Pedidos.Text)
            Pedidos.TopLevel = False
            Pedidos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Pedidos.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Pedidos)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Pedidos
            Pedidos.Tag = Me.Tab1.TabPages(R)
            Pedidos.Show()
        ElseIf Variables.Pedidos_visible = False And i > 1 Then
            Tab1.TabPages.Add(Pedidos.Tag)
            Tab1.SelectedTab = Pedidos.Tag
            Variables.Pedidos_visible = True
        ElseIf Variables.Pedidos_visible = True And i > 1 Then
            Tab1.SelectedTab = Pedidos.Tag
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasT.Click
        Variables.aplic = "FACTU"
        Call F_recargar_apps.facturas_reload()
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 15
        If i = 1 Then
            Facturas.Text = String.Format("Facturas")
            Me.Tab1.TabPages.Add(R, Facturas.Text)
            Facturas.TopLevel = False
            Facturas.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Facturas.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Facturas)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Facturas
            Facturas.Tag = Me.Tab1.TabPages(R)
            Facturas.Show()
        ElseIf Variables.facturas_visible = False And i > 1 Then
            Tab1.TabPages.Add(Facturas.Tag)
            Tab1.SelectedTab = Facturas.Tag
            Variables.facturas_visible = True
        ElseIf Variables.facturas_visible = True And i > 1 Then
            Tab1.SelectedTab = Facturas.Tag
        End If
    End Sub
    Private Sub CotizacionesT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizacionesT.Click
        Variables.aplic = "COTIZ"
        Call F_recargar_apps.Cotizaciones_reload()
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 16
        If i = 1 Then
            Cotizaciones.Text = String.Format("Cotizaciones")
            Me.Tab1.TabPages.Add(R, Cotizaciones.Text)
            Cotizaciones.TopLevel = False
            Cotizaciones.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Cotizaciones.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Cotizaciones)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Cotizaciones
            Cotizaciones.Tag = Me.Tab1.TabPages(R)
            Cotizaciones.Show()
        ElseIf Variables.Cotizaciones_visible = False And i > 1 Then
            Tab1.TabPages.Add(Cotizaciones.Tag)
            Tab1.SelectedTab = Cotizaciones.Tag
            Variables.Cotizaciones_visible = True
        ElseIf Variables.Cotizaciones_visible = True And i > 1 Then
            Tab1.SelectedTab = Cotizaciones.Tag
        End If
    End Sub
    Private Sub ReservasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservasT.Click
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 17
        If i = 1 Then
            Nueva_Reserva.Text = String.Format("Nueva Reserva")
            Me.Tab1.TabPages.Add(R, Nueva_Reserva.Text)
            Nueva_Reserva.TopLevel = False
            Nueva_Reserva.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Nueva_Reserva.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Nueva_Reserva)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Nueva_Reserva
            Nueva_Reserva.Tag = Me.Tab1.TabPages(R)
            Nueva_Reserva.Show()
        ElseIf Variables.nueva_visible = False And i > 1 Then
            Tab1.TabPages.Add(Nueva_Reserva.Tag)
            Tab1.SelectedTab = Nueva_Reserva.Tag
            Variables.nueva_visible = True
        ElseIf Variables.nueva_visible = True And i > 1 Then
            Tab1.SelectedTab = Nueva_Reserva.Tag
        End If
    End Sub
    Private Sub Ordenes_inven_Click(sender As System.Object, e As System.EventArgs) Handles Ordenes_inven.Click
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 25
        If i = 1 Then
            Ordenes_Compra.Text = String.Format("Orden de Compra")
            Me.Tab1.TabPages.Add(R, Ordenes_Compra.Text)
            Ordenes_Compra.TopLevel = False
            Ordenes_Compra.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Ordenes_Compra.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Ordenes_Compra)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Ordenes_Compra
            Ordenes_Compra.Tag = Me.Tab1.TabPages(R)
            Ordenes_Compra.Show()
        ElseIf Variables.Ordenes_visible = False And i > 1 Then
            Tab1.TabPages.Add(Ordenes_Compra.Tag)
            Tab1.SelectedTab = Ordenes_Compra.Tag
            Variables.Ordenes_visible = True
        ElseIf Variables.Ordenes_visible = True And i > 1 Then
            Tab1.SelectedTab = Ordenes_Compra.Tag
        End If
    End Sub
    '---------------------
    'seguridad
    '---------------------
    Private Sub PerfilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerfilesToolStripMenuItem.Click
        Call F_recargar_apps.perfiles_reload()
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 18
        If i = 1 Then
            Perfiles.Text = String.Format("Perfiles")
            Me.Tab1.TabPages.Add(R, Perfiles.Text)
            Perfiles.TopLevel = False
            Perfiles.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Perfiles.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Perfiles)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Perfiles
            Perfiles.Tag = Me.Tab1.TabPages(R)
            Perfiles.Show()
        ElseIf Variables.perfiles_visible = False And i > 1 Then
            Tab1.TabPages.Add(Perfiles.Tag)
            Tab1.SelectedTab = Perfiles.Tag
            Variables.perfiles_visible = True
        ElseIf Variables.perfiles_visible = True And i > 1 Then
            Tab1.SelectedTab = Perfiles.Tag
        End If
    End Sub
    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        Call F_recargar_apps.usuarios_reload()
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 19
        If i = 1 Then
            Usuarios.Text = String.Format("Usuarios")
            Me.Tab1.TabPages.Add(R, Usuarios.Text)
            Usuarios.TopLevel = False
            Usuarios.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Usuarios.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Usuarios)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Usuarios
            Usuarios.Tag = Me.Tab1.TabPages(R)
            Usuarios.Show()
        ElseIf Variables.usuarios_visible = False And i > 1 Then
            Tab1.TabPages.Add(Usuarios.Tag)
            Tab1.SelectedTab = Usuarios.Tag
            Variables.usuarios_visible = True
        ElseIf Variables.usuarios_visible = True And i > 1 Then
            Tab1.SelectedTab = Usuarios.Tag
        End If
    End Sub
    Private Sub CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClavesToolStripMenuItem.Click
        Cambiar_Clave.Show()
        Me.Enabled = False
    End Sub
    Private Sub AuditoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuditoriaToolStripMenuItem.Click
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 20
        If i = 1 Then
            Auditoria.Text = String.Format("Auditoria")
            Me.Tab1.TabPages.Add(R, Auditoria.Text)
            Auditoria.TopLevel = False
            Auditoria.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Auditoria.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Auditoria)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Auditoria
            Auditoria.Tag = Me.Tab1.TabPages(R)
            Auditoria.Show()
        ElseIf Variables.Auditoria_visible = False And i > 1 Then
            Tab1.TabPages.Add(Auditoria.Tag)
            Tab1.SelectedTab = Auditoria.Tag
            Variables.Auditoria_visible = True
        ElseIf Variables.Auditoria_visible = True And i > 1 Then
            Tab1.SelectedTab = Auditoria.Tag
        End If
    End Sub
    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 21
        If i = 1 Then
            Empresa.Text = String.Format("Empresa")
            Me.Tab1.TabPages.Add(R, Empresa.Text)
            Empresa.TopLevel = False
            Empresa.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Empresa.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Empresa)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Empresa
            Empresa.Tag = Me.Tab1.TabPages(R)
            Empresa.Show()
        ElseIf Variables.Empresa_visible = False And i > 1 Then
            Tab1.TabPages.Add(Empresa.Tag)
            Tab1.SelectedTab = Empresa.Tag
            Variables.Empresa_visible = True
        ElseIf Variables.Empresa_visible = True And i > 1 Then
            Tab1.SelectedTab = Empresa.Tag
        End If
    End Sub

    Private Sub LicenciamientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LicenciamientoToolStripMenuItem.Click
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 22
        If i = 1 Then
            Licencia.Text = String.Format("Licencia")
            Me.Tab1.TabPages.Add(R, Licencia.Text)
            Licencia.TopLevel = False
            Licencia.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Licencia.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Licencia)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Licencia
            Licencia.Tag = Me.Tab1.TabPages(R)
            Licencia.Show()
        ElseIf Variables.Licencia_visible = False And i > 1 Then
            Tab1.TabPages.Add(Licencia.Tag)
            Tab1.SelectedTab = Licencia.Tag
            Variables.Licencia_visible = True
        ElseIf Variables.Licencia_visible = True And i > 1 Then
            Tab1.SelectedTab = Licencia.Tag
        End If
    End Sub
    '--------------------------------
    'Reportes
    '--------------------------------
    Private Sub MovimientosProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosProductos.Click
        Variables.nombre_report = "Movimientos Inventario"
        Reporteador.ReportViewer1.Clear()
        Call carga_ventana_reporteador()
    End Sub
    Private Sub CostoProductoXProveedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CostoProductoXProveedorToolStripMenuItem.Click
        Variables.nombre_report = "Costo Producto X Proveedor"
        Reporteador.ReportViewer1.Clear()
        Call carga_ventana_reporteador()
    End Sub
    Private Sub FacturacionProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionProductoToolStripMenuItem.Click
        Variables.nombre_report = "Movimientos Facturacion"
        Reporteador.ReportViewer1.Clear()
        Call carga_ventana_reporteador()
    End Sub

    Private Sub VentasProductoPorFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasProductoPorFechaToolStripMenuItem.Click
        Variables.nombre_report = "Ventas Producto Fecha"
        Reporteador.ReportViewer1.Clear()
        Call carga_ventana_reporteador()
    End Sub
    '---------------------
    'Ayuda
    '---------------------
    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Acerca.Show()
    End Sub
    Private Sub ManualesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualesToolStripMenuItem.Click
        Dim a As New Random()
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 23
        If i = 1 Then
            Manuales.Text = String.Format("Manuales")
            Me.Tab1.TabPages.Add(R, Manuales.Text)
            Manuales.TopLevel = False
            Manuales.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Manuales.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Manuales)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Manuales
            Manuales.Tag = Me.Tab1.TabPages(R)
            Manuales.Show()
        ElseIf Variables.Manuales_visible = False And i > 1 Then
            Tab1.TabPages.Add(Manuales.Tag)
            Tab1.SelectedTab = Manuales.Tag
            Variables.Manuales_visible = True
        ElseIf Variables.Manuales_visible = True And i > 1 Then
            Tab1.SelectedTab = Manuales.Tag
        End If
    End Sub
    Private Sub MensajesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MensajesToolStripMenuItem.Click
        Static i As Integer
        i += 1
        Dim R As String = i.ToString() + 24
        If i = 1 Then
            Mensajes.Text = String.Format("Mensajes")
            Me.Tab1.TabPages.Add(R, Mensajes.Text)
            Mensajes.TopLevel = False
            Mensajes.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Mensajes.Dock = DockStyle.Fill
            Me.Tab1.TabPages(R).Controls.Add(Mensajes)
            Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
            Me.Tab1.TabPages(R).Tag = Mensajes
            Mensajes.Tag = Me.Tab1.TabPages(R)
            Mensajes.Show()
        ElseIf Variables.Mensajes_visible = False And i > 1 Then
            Tab1.TabPages.Add(Mensajes.Tag)
            Tab1.SelectedTab = Mensajes.Tag
            Variables.Mensajes_visible = True
        ElseIf Variables.Mensajes_visible = True And i > 1 Then
            Tab1.SelectedTab = Mensajes.Tag
        End If
    End Sub
    Private Sub ReiniciarBoromirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReiniciarBoromirToolStripMenuItem.Click
        Me.Close()
        Inicio_Sesion.Show()
    End Sub
    '----------------------------------------------------------------------------------------------------------
    '----------------FIN ABRIR PESTAÑAS DE OPCIONS-----------------------------------------------------------------
   

    '----------------------------------------------------------------------------------------------------------
    '----------------TOOLS BAR LLAMADO A FUNCIONES DE CADA BOTON------------------------------------------------
    Private Sub TBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnNuevo.Click
        Variables.dt.Clear()
        Call F_Boton_nuevo.Boton_Nuevo()
        Variables.dt.Clear()
    End Sub

    Private Sub TBtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnBuscar.Click
        Variables.dt.Clear()
        Call F_Boton_buscar.Boton_Buscar()
    End Sub
    Private Sub TBtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnLimpiar.Click
        Variables.dt.Clear()
        Call F_Boton_limpiar.Boton_Limpiar()
    End Sub
    Private Sub TBtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnGuardar.Click
        Call F_Boton_guardar.Boton_Guardar()
        Variables.dt.Clear()
    End Sub
    Private Sub TBtnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnConfirmar.Click
        Call F_Boton_confirmar.Boton_Confirmar()
    End Sub
    Private Sub TBtnReversar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnReversar.Click
        Call F_Boton_reversar.boton_reversar()
    End Sub
    Private Sub TBtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnAnular.Click
        Call F_Boton_Anular.boton_anular()
    End Sub
    Private Sub TbtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbtnImprimir.Click
        Call F_Boton_previa.Carga_Datos_Vista_Previa()
        Call F_Boton_previa.carga_reporte()
    End Sub

    Private Sub TBnConsola_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnConsola.Click
        ConsolaSQL.Show()
    End Sub
    Private Sub TBtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnCerrar.Click
        Call F_Boton_cerrar_pestaña.cerrar_pestañas()
    End Sub

    Private Sub TBtn_primero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtn_primero.Click
        Call F_primer_registro.primer_registro()
    End Sub
    Private Sub TBtn_anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtn_anterior.Click
        Call F_anterior_registro.anterior_registro()
    End Sub
    Private Sub Tbt_siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtn_siguiente.Click
        Call F_siguiente_registro.siguiente_registro()
    End Sub
    Private Sub TBtn_ultimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtn_ultimo.Click
        Call F_ultimo_registro.ultimo_registro()
        '--------------------------------------------------------
        '    FIN BOTONES BARRA DE HERRAMIENTAS
        '--------------------------------------------------------
    End Sub

    '--------------------------------------------------------
    '    COMIENZO ACCESO RAPIDO A BOTONES
    '--------------------------------------------------------
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        If Me.TBtnNuevo.Enabled = True Then
            Call F_Boton_nuevo.Boton_Nuevo()
            Variables.dt.Clear()
        End If
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        If Me.TBtnBuscar.Enabled = True Then
            Call F_Boton_buscar.Boton_Buscar()
            Variables.dt.Clear()
        End If
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarToolStripMenuItem.Click
        If Me.TBtnLimpiar.Enabled = True Then
            Call F_Boton_limpiar.Boton_Limpiar()
            Variables.dt.Clear()
        End If
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        If Me.TBtnGuardar.Enabled = True Then
            Call F_Boton_guardar.Boton_Guardar()
            Variables.dt.Clear()
        End If
    End Sub

    Private Sub ConfirmarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmarToolStripMenuItem.Click
        If Me.TBtnConfirmar.Enabled = True Then
            Call F_Boton_confirmar.Boton_Confirmar()
        End If
    End Sub
    Private Sub ReversarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReversarToolStripMenuItem.Click
        If Me.TBtnReversar.Enabled = True Then
            Call F_Boton_reversar.boton_reversar()
            Variables.dt.Clear()
        End If
    End Sub
    Private Sub AnularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularToolStripMenuItem.Click
        If Me.TBtnAnular.Enabled = True Then
            Call F_Boton_Anular.boton_anular()
        End If
    End Sub
    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Call F_Boton_cerrar_pestaña.cerrar_pestañas()
    End Sub
    Private Sub ConsolaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsolaToolStripMenuItem.Click
        If Me.TBtnConsola.Enabled = True Then
            ConsolaSQL.Show()
        End If
    End Sub
    Private Sub PreviaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviaToolStripMenuItem.Click
        Call F_Boton_previa.Carga_Datos_Vista_Previa()
        Call F_Boton_previa.carga_reporte()

    End Sub
    '--------------------------------------------------------
    '    FIN ACCESO RAPIDO A BOTONES
    '--------------------------------------------------------

    '--------------------------------------------------------
    '    COMIENZO MENU ALERTAS
    '-------------------------------------------------------
    Private Sub tabFacturas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabFacturas.MouseLeave
        Me.LBFacturas.Items.Clear()
        Variables.dt.Clear()
        Dim dr As DataRow
        Dim fecha_value As String = TxtFecha.Text
        Variables.sSel = "select * from tbl_facturas where ccod_estad_factu = 'AC' order by ncodigo_factu desc "
        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
        Variables.da.Fill(dt)
        Dim filas() As DataRow
        filas = dt.Select
        For Each dr In filas
            Me.LBFacturas.Items.Add(dr("ncodigo_factu").ToString & " - " & dr("ccod_conce_factu").ToString & " / " & dr("ccod_estad_factu").ToString & " - " & dr("ffecha_factu").ToString)
        Next
        Variables.dt.Clear()
    End Sub

    Private Sub LBPedidos_MouseLeave(sender As Object, e As System.EventArgs) Handles LBPedidos.MouseLeave
        Me.LBPedidos.Items.Clear()
        Variables.dt.Clear()
        Dim dr As DataRow
        Variables.sSel = "select * from tbl_pedidos where ccod_estad_pedid = 'AC' order by ncodigo_pedid desc "
        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
        Variables.da.Fill(dt)
        Dim filas() As DataRow
        filas = dt.Select
        For Each dr In filas
            Me.LBPedidos.Items.Add(dr("ncodigo_pedid").ToString & " - " & dr("ccod_conce_pedid").ToString & " / " & dr("ccod_estad_pedid").ToString & " - " & dr("ffecha_pedid").ToString)
        Next
        Variables.dt.Clear()
    End Sub
    Private Sub TabCotizacion_MouseLeave(sender As Object, e As System.EventArgs) Handles TabCotizacion.MouseLeave
        Me.LBCotiz.Items.Clear()
        Variables.dt.Clear()
        Dim dr As DataRow
        Variables.sSel = "select * from tbl_cotizaciones where ccod_estad_cotiz = 'AC' order by ncodigo_cotiz desc "
        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
        Variables.da.Fill(dt)
        Dim filas() As DataRow
        filas = dt.Select
        For Each dr In filas
            Me.LBCotiz.Items.Add(dr("ncodigo_cotiz").ToString & " - " & dr("ccod_conce_cotiz").ToString & " / " & dr("ccod_estad_cotiz").ToString & " - " & dr("ffecha_cotiz").ToString)
        Next
        Variables.dt.Clear()
    End Sub
    Private Sub TabReservas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabReservas.MouseLeave
        Me.LBResevas.Items.Clear()
        Variables.dt.Clear()
        Dim dr As DataRow
        Dim fecha_value As String = TxtFecha.Text
        Variables.sSel = "select * from tbl_reservas where ccod_estad_reser = 'AC' order by ffecha_reser desc "
        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
        Variables.da.Fill(dt)
        Dim filas() As DataRow
        filas = dt.Select
        For Each dr In filas
            Me.LBResevas.Items.Add(dr("ncodigo_reser").ToString & " - " & dr("ffecha_reser").ToString & " - " & dr("hhora_reser").ToString & " -Esc: " & dr("ncod_escen_reser").ToString)
        Next
        Variables.dt.Clear()
    End Sub

    Private Sub Reloj_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reloj.Tick
        Lblreloj.Text = String.Format("{0:00}:{1:00}:{2:00}", My.Computer.Clock.LocalTime.Hour, My.Computer.Clock.LocalTime.Minute, My.Computer.Clock.LocalTime.Second)
    End Sub
    '--------------------------------------------------------
    '    COMIENZO SELECCION DE ITEM MENU
    '-------------------------------------------------------

    Private Sub LBFacturas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBFacturas.SelectedIndexChanged
        Try
            Variables.cadena = LBFacturas.SelectedItem
            Variables.factura = Convert.ToInt16(cadena.Substring(0, (cadena.IndexOf("-") - 1)))
            Variables.concepto = cadena.Substring((cadena.IndexOf("-") + 2), 2)
            Open_App("FACTU")
        Catch
            MsgBox("Error al intentar abrir Factura", MsgBoxStyle.Information, "Boromir dice")
        End Try
    End Sub
    Private Sub Open_App(ByVal app As String)
        Variables.aplic = app
        Select Case Variables.aplic
            Case "FACTU"
                Call F_recargar_apps.facturas_reload()
                Dim a As New Random()
                Static i As Integer
                i += 1
                Dim R As String = i.ToString() + 15
                If i = 1 And Variables.Fact_alert = False Then
                    Facturas.Text = String.Format("Facturas")
                    Me.Tab1.TabPages.Add(R, Facturas.Text)
                    Facturas.TopLevel = False
                    Facturas.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    Facturas.Dock = DockStyle.Fill
                    Me.Tab1.TabPages(R).Controls.Add(Facturas)
                    Me.Tab1.SelectedTab = Me.Tab1.TabPages(R)
                    Me.Tab1.TabPages(R).Tag = Facturas
                    Facturas.Tag = Me.Tab1.TabPages(R)
                    Facturas.Show()
                ElseIf Variables.facturas_visible = False And i > 1 Then
                    Tab1.TabPages.Add(Facturas.Tag)
                    Tab1.SelectedTab = Facturas.Tag
                    Variables.facturas_visible = True
                ElseIf Variables.facturas_visible = True And i > 1 Or Variables.Fact_alert = True Then
                    Tab1.SelectedTab = Facturas.Tag
                End If
                Variables.Fact_alert = True
                Facturas.TxtFactura_factu.Text = Variables.factura.ToString
                Facturas.CBConcepto_factu.Text = Variables.concepto
                Facturas.CBoxUbicacion_factu.Text = Me.Barra_estad_ubica.Text
                Call F_Boton_buscar.Boton_Buscar()
        End Select
    End Sub

    Private Sub FacturasTouchToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FacturasTouchToolStripMenuItem.Click
        'Facturas_t.Show()
    End Sub
End Class

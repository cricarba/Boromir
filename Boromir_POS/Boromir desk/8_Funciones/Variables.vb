Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Mail
Imports System.Windows.Forms
Imports System.IO.MemoryStream
'Dim cmd As System.Data.SqlClient.SqlCommand
'cmd = New System.Data.SqlClient.SqlCommand()
'cmd.Connection = cnn
'cmd.CommandText = _
'    "Select * From Empleados Where Nombre = @Nombre"

'cmd.Parameters.Add( _
'    "@Nombre", SqlDbType.VarChar, 20).Value = txtNombre.Text
'cmd.ExecuteNonQuery()
Module Variables
    Public Function conexion(ByVal Server As String)
        Dim servidor As String = Server
        Dim Cnn As String = ""
        If servidor = "Boromir" Then
            Cnn = "Data Source = .; Initial Catalog = Boromir; Integrated Security = True"
        ElseIf servidor = "Default" Then
            Cnn = "Data Source = .\sqlexpress; Initial Catalog = Boromir; Integrated Security = True"
        End If
        Return Cnn
    End Function
    'VARIABLES PARA LA CONEXION A LA BD
    Public sCnn As String
    'Public sCnn As String = "Data Source = COMERCIAL1\sqlexpress; Initial Catalog = Boromir; Integrated Security = True"
    Public sSel As String
    Public da As SqlDataAdapter
    Public dt As New DataTable
    Public Registros As String
    Public rg As Integer = 0

    'VARIABLES PARA EL CONTROL DEPESTAÑAS
    Public ubicaciones_visible As Boolean = True ' para saber que pestaña esta abierta
    Public teceros_visible As Boolean = True
    Public tcanchas_visible As Boolean = True
    Public tcostos_visible As Boolean = True
    Public tdocumentos_visible As Boolean = True
    Public turnos_visible As Boolean = True
    Public costoturnos_visible As Boolean = True
    Public ciudades_visible As Boolean = True
    Public zonas_visible As Boolean = True
    Public nueva_visible As Boolean = True
    Public reservas_visible As Boolean = True
    Public facturas_visible As Boolean = True
    Public perfiles_visible As Boolean = True
    Public usuarios_visible As Boolean = True
    Public EscenarioXubica_visible As Boolean = True
    Public Productos_visible As Boolean = True
    Public Conceptos_visible As Boolean = True
    Public Saldos_visble As Boolean = True
    Public Movimientos_visible As Boolean = True
    Public Manuales_visible As Boolean = True
    Public Empresa_visible As Boolean = True
    Public Mensajes_visible As Boolean = True
    Public Cotizaciones_visible As Boolean = True
    Public Auditoria_visible As Boolean = True
    Public Licencia_visible As Boolean = True
    Public Combos_visible As Boolean = True
    Public Previa_visible As Boolean = True
    Public Reporteador_visible As Boolean = True
    Public Ordenes_visible As Boolean = True
    Public Pedidos_visible As Boolean = True



    'VARIABLES PARA LAS CONSULTAS
    Public codigo As Integer
    Public entero As Integer
    Public datos_escen As String
    Public dia_reserva As Date
    Public dia_reserva2 As String
    Public fechas As String
    Public app_buscar As String 'aplicaion para hacer filtro
    Public field_buscar As String 'campo al cual se lleva el filtro
    Public app_ref As String = "" 'se utiliza para saber en que aplicaion estoy navegando por los registros
    Public dtcombo_global As DataTable
    ' variables para crear la descripcion de la auditoria
    Public buscar_from As Integer
    Public campos_modificados As String
    Public campos_auditoria As String
    Public accion_sql As String
    Public Des_auditoria As String 'para guardar la descripcion

    'VARIABLES PARA LOS CHECHBOX
    Public tercero_cliente As Integer 'para saber que check esta activo
    Public tercero_proveedor As Integer
    Public tercero_empleado As Integer
    Public ubic_costo As Integer

    'Variables para los combobox
    Public Filas_estado() As DataRow  'para guardar la consulta y cargar los combobox
    Public Filas_ciudad() As DataRow
    Public Filas_zonas() As DataRow
    Public Filas_tipodoc() As DataRow
    Public Filas_ubicaciones() As DataRow
    Public Filas_perfil() As DataRow
    Public Filas_escenarios() As DataRow
    Public Filas_turno() As DataRow
    Public Filas_escen_x_ubic() As DataRow
    Public Filas_tipo_costo() As DataRow
    Public Filas_disponible() As DataRow
    Public Filas_conceptos() As DataRow
    Public filas_aplicaciones() As DataRow
    Public filas_categorias() As DataRow
    Public filas_marcas() As DataRow
    Public filas_colores() As DataRow
    Public filas_unidades() As DataRow
    Public filas_cotizaciones() As DataRow
    'VARIABLES PARA LOS PERMISOS DE PERFILES

    ' para el login
    Public user As String
    Public pass As String
    Public ubcn As String
    Public ubcn1 As String
    Public confirma_contraseña As String ' para confirmar las constraseñas en el cambio
    Public touch As Boolean = False
    'para saber que puede hacer la persona en cada aplicaicon
    Public Crear As String
    Public Consultar As String
    Public Modificar As String
    Public Confirmar As String
    Public Reversar As String
    Public Anular As String
    Public imprimir As String
    Public consolasql As String

    'PARA PARA PERMISOS EN APLICACIONES
    Public documentos_admon As String
    Public conceptos_admon As String
    Public escenarios_admon As String
    Public costos_admon As String
    Public cuidades_admon As String
    Public zonas_admon As String
    Public terceros_admon As String
    Public ubicaciones_admon As String
    Public escenxubica_admon As String
    Public tblcostos_admon As String
    Public productos_inven As String
    Public movimientos_inven As String
    Public saldos_inven As String
    Public pedidos_factu As String
    Public facturas_factu As String
    Public cotizaciones_factu As String
    Public reservas_factu As String
    Public administraivos_report As String
    Public inventarios_report As String
    Public facturacion_report As String
    Public perfiles_segur As String
    Public usuarios_segur As String
    Public claves_segur As String
    Public empresa_segur As String
    Public licencia_segur As String
    Public auditoria_segur As String
    Public ordenes_inven As String
    Public ccod_perfil_aplicperfil As String

    'VARIABLES PARA Los modulos
    Public aplic As String ' para filtar conceptos
    Public nombre_report As String 'para el nobre del reporte

    'VARIABLES PARLA CONSOLA
    Public consola As String

    'variables para la fatura
    Public neto As Integer = 0
    Public total As Integer = 0
    Public descuento As Integer = 0
    Public gran_descuento As Integer = 0
    Public Subtotal As Integer = 0
    Public gran_total As Integer = 0
    Public impuesto As Integer = 0
    Public gran_impuesto As Integer = 0
    Public df As New DataTable 'detalle factura
    Public bf As New DataTable 'busca factura
    Public dm As New DataTable 'detalle movimiento



    'variables para el manejo de imagenes
    Public ruta_imagen As String
    Public ruta_imagen_buscar As String
    Public ruta_imagen_guardar As String
    Public ruta_imagen_borrar As String
    Public update_imagen As Boolean
    Public imagen As FileStream
    Public ms As New System.IO.MemoryStream

    'variables de empresa
    Public carpeta_imagenes As String
    Public carpeta_manuales As String
    Public carpeta_reportes As String
    Public logo_empresa As String

    'variables para el adjunto de correo
    Public archivo_adjunto As Attachment
    Public nombre_adjunto As String

    'variables para abrir facturas desde el panel de alertas
    Public cadena, concepto As String
    Public factura As Integer
    Public Fact_alert As Boolean = False
End Module

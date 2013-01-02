<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mov_inventarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mov_inventarios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblUbica = New System.Windows.Forms.Label()
        Me.LblConcepto = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CBConcepto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtFecha_reser = New System.Windows.Forms.DateTimePicker()
        Me.LblFecha_reser = New System.Windows.Forms.Label()
        Me.CBUbicacion = New System.Windows.Forms.ComboBox()
        Me.LblUbicacion_reser = New System.Windows.Forms.Label()
        Me.LblReserva_reser = New System.Windows.Forms.Label()
        Me.Txtcodigo_movprodu = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Descuento_Movi = New System.Windows.Forms.TextBox()
        Me.TxtFactuproveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtApellido_terce_factu = New System.Windows.Forms.TextBox()
        Me.TxtNombre2_factu = New System.Windows.Forms.TextBox()
        Me.TxtNombre1_factu = New System.Windows.Forms.TextBox()
        Me.TxtDocumento_terce_factu = New System.Windows.Forms.TextBox()
        Me.LblCodigo_terce = New System.Windows.Forms.Label()
        Me.LblNombre1_terce = New System.Windows.Forms.Label()
        Me.ToolStripfacturas = New System.Windows.Forms.ToolStrip()
        Me.TBtnNuevodetalle = New System.Windows.Forms.ToolStripButton()
        Me.TBtneliminardetalle = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Codigo1 = New System.Windows.Forms.TextBox()
        Me.Producto1 = New System.Windows.Forms.Label()
        Me.Cantidad1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Unidad1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.data_movimientos = New System.Windows.Forms.DataGridView()
        Me.lblexistencia = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Impuesto1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Descuento1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Precio1 = New System.Windows.Forms.TextBox()
        Me.Existencia1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gran_total = New System.Windows.Forms.Label()
        Me.impuesto = New System.Windows.Forms.Label()
        Me.gran_descuento = New System.Windows.Forms.Label()
        Me.neto = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TxtApellido2_terce_factu = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripfacturas.SuspendLayout()
        CType(Me.data_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblUbica)
        Me.GroupBox1.Controls.Add(Me.LblConcepto)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.CBConcepto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtFecha_reser)
        Me.GroupBox1.Controls.Add(Me.LblFecha_reser)
        Me.GroupBox1.Controls.Add(Me.CBUbicacion)
        Me.GroupBox1.Controls.Add(Me.LblUbicacion_reser)
        Me.GroupBox1.Controls.Add(Me.LblReserva_reser)
        Me.GroupBox1.Controls.Add(Me.Txtcodigo_movprodu)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(797, 68)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Movimiento"
        '
        'LblUbica
        '
        Me.LblUbica.AutoSize = True
        Me.LblUbica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbica.Location = New System.Drawing.Point(388, 47)
        Me.LblUbica.Name = "LblUbica"
        Me.LblUbica.Size = New System.Drawing.Size(16, 15)
        Me.LblUbica.TabIndex = 9
        Me.LblUbica.Text = "U"
        '
        'LblConcepto
        '
        Me.LblConcepto.AutoSize = True
        Me.LblConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConcepto.Location = New System.Drawing.Point(205, 47)
        Me.LblConcepto.Name = "LblConcepto"
        Me.LblConcepto.Size = New System.Drawing.Size(15, 15)
        Me.LblConcepto.TabIndex = 8
        Me.LblConcepto.Text = "C"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(714, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 15)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Estado:"
        '
        'CBConcepto
        '
        Me.CBConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBConcepto.FormattingEnabled = True
        Me.CBConcepto.Location = New System.Drawing.Point(208, 23)
        Me.CBConcepto.Name = "CBConcepto"
        Me.CBConcepto.Size = New System.Drawing.Size(42, 21)
        Me.CBConcepto.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(152, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Concepto"
        '
        'TxtFecha_reser
        '
        Me.TxtFecha_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha_reser.Location = New System.Drawing.Point(497, 22)
        Me.TxtFecha_reser.Name = "TxtFecha_reser"
        Me.TxtFecha_reser.Size = New System.Drawing.Size(211, 20)
        Me.TxtFecha_reser.TabIndex = 7
        '
        'LblFecha_reser
        '
        Me.LblFecha_reser.AutoSize = True
        Me.LblFecha_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha_reser.Location = New System.Drawing.Point(452, 24)
        Me.LblFecha_reser.Name = "LblFecha_reser"
        Me.LblFecha_reser.Size = New System.Drawing.Size(41, 15)
        Me.LblFecha_reser.TabIndex = 6
        Me.LblFecha_reser.Text = "Fecha"
        '
        'CBUbicacion
        '
        Me.CBUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUbicacion.FormattingEnabled = True
        Me.CBUbicacion.Location = New System.Drawing.Point(391, 21)
        Me.CBUbicacion.Name = "CBUbicacion"
        Me.CBUbicacion.Size = New System.Drawing.Size(42, 21)
        Me.CBUbicacion.TabIndex = 5
        '
        'LblUbicacion_reser
        '
        Me.LblUbicacion_reser.AutoSize = True
        Me.LblUbicacion_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbicacion_reser.Location = New System.Drawing.Point(327, 24)
        Me.LblUbicacion_reser.Name = "LblUbicacion_reser"
        Me.LblUbicacion_reser.Size = New System.Drawing.Size(62, 15)
        Me.LblUbicacion_reser.TabIndex = 4
        Me.LblUbicacion_reser.Text = "Ubicación"
        '
        'LblReserva_reser
        '
        Me.LblReserva_reser.AutoSize = True
        Me.LblReserva_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReserva_reser.Location = New System.Drawing.Point(6, 26)
        Me.LblReserva_reser.Name = "LblReserva_reser"
        Me.LblReserva_reser.Size = New System.Drawing.Size(52, 15)
        Me.LblReserva_reser.TabIndex = 0
        Me.LblReserva_reser.Text = "Numero"
        '
        'Txtcodigo_movprodu
        '
        Me.Txtcodigo_movprodu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcodigo_movprodu.Location = New System.Drawing.Point(64, 23)
        Me.Txtcodigo_movprodu.Name = "Txtcodigo_movprodu"
        Me.Txtcodigo_movprodu.Size = New System.Drawing.Size(73, 20)
        Me.Txtcodigo_movprodu.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Descuento_Movi)
        Me.GroupBox3.Controls.Add(Me.TxtFactuproveedor)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtApellido2_terce_factu)
        Me.GroupBox3.Controls.Add(Me.TxtApellido_terce_factu)
        Me.GroupBox3.Controls.Add(Me.TxtNombre2_factu)
        Me.GroupBox3.Controls.Add(Me.TxtNombre1_factu)
        Me.GroupBox3.Controls.Add(Me.TxtDocumento_terce_factu)
        Me.GroupBox3.Controls.Add(Me.LblCodigo_terce)
        Me.GroupBox3.Controls.Add(Me.LblNombre1_terce)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(4, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(463, 128)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Proveedor"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(272, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox2.TabIndex = 133
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(436, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(269, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Descuento Factura:"
        '
        'Descuento_Movi
        '
        Me.Descuento_Movi.Location = New System.Drawing.Point(383, 103)
        Me.Descuento_Movi.Name = "Descuento_Movi"
        Me.Descuento_Movi.Size = New System.Drawing.Size(51, 21)
        Me.Descuento_Movi.TabIndex = 11
        '
        'TxtFactuproveedor
        '
        Me.TxtFactuproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFactuproveedor.Location = New System.Drawing.Point(98, 103)
        Me.TxtFactuproveedor.Name = "TxtFactuproveedor"
        Me.TxtFactuproveedor.Size = New System.Drawing.Size(169, 21)
        Me.TxtFactuproveedor.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fact Proveedor"
        '
        'TxtApellido_terce_factu
        '
        Me.TxtApellido_terce_factu.Enabled = False
        Me.TxtApellido_terce_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido_terce_factu.Location = New System.Drawing.Point(97, 79)
        Me.TxtApellido_terce_factu.Name = "TxtApellido_terce_factu"
        Me.TxtApellido_terce_factu.Size = New System.Drawing.Size(168, 21)
        Me.TxtApellido_terce_factu.TabIndex = 6
        '
        'TxtNombre2_factu
        '
        Me.TxtNombre2_factu.Enabled = False
        Me.TxtNombre2_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre2_factu.Location = New System.Drawing.Point(264, 55)
        Me.TxtNombre2_factu.Name = "TxtNombre2_factu"
        Me.TxtNombre2_factu.Size = New System.Drawing.Size(168, 21)
        Me.TxtNombre2_factu.TabIndex = 5
        '
        'TxtNombre1_factu
        '
        Me.TxtNombre1_factu.Enabled = False
        Me.TxtNombre1_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre1_factu.Location = New System.Drawing.Point(97, 55)
        Me.TxtNombre1_factu.Name = "TxtNombre1_factu"
        Me.TxtNombre1_factu.Size = New System.Drawing.Size(168, 21)
        Me.TxtNombre1_factu.TabIndex = 4
        '
        'TxtDocumento_terce_factu
        '
        Me.TxtDocumento_terce_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocumento_terce_factu.Location = New System.Drawing.Point(97, 28)
        Me.TxtDocumento_terce_factu.Name = "TxtDocumento_terce_factu"
        Me.TxtDocumento_terce_factu.Size = New System.Drawing.Size(169, 21)
        Me.TxtDocumento_terce_factu.TabIndex = 2
        '
        'LblCodigo_terce
        '
        Me.LblCodigo_terce.AutoSize = True
        Me.LblCodigo_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo_terce.Location = New System.Drawing.Point(11, 28)
        Me.LblCodigo_terce.Name = "LblCodigo_terce"
        Me.LblCodigo_terce.Size = New System.Drawing.Size(71, 15)
        Me.LblCodigo_terce.TabIndex = 0
        Me.LblCodigo_terce.Text = "Documento"
        '
        'LblNombre1_terce
        '
        Me.LblNombre1_terce.AutoSize = True
        Me.LblNombre1_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre1_terce.Location = New System.Drawing.Point(11, 60)
        Me.LblNombre1_terce.Name = "LblNombre1_terce"
        Me.LblNombre1_terce.Size = New System.Drawing.Size(52, 15)
        Me.LblNombre1_terce.TabIndex = 3
        Me.LblNombre1_terce.Text = "Nombre"
        '
        'ToolStripfacturas
        '
        Me.ToolStripfacturas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TBtnNuevodetalle, Me.TBtneliminardetalle})
        Me.ToolStripfacturas.Location = New System.Drawing.Point(3, 17)
        Me.ToolStripfacturas.Name = "ToolStripfacturas"
        Me.ToolStripfacturas.Size = New System.Drawing.Size(794, 25)
        Me.ToolStripfacturas.TabIndex = 0
        Me.ToolStripfacturas.Text = "ToolStrip1"
        '
        'TBtnNuevodetalle
        '
        Me.TBtnNuevodetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBtnNuevodetalle.Enabled = False
        Me.TBtnNuevodetalle.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.TBtnNuevodetalle.Image = CType(resources.GetObject("TBtnNuevodetalle.Image"), System.Drawing.Image)
        Me.TBtnNuevodetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBtnNuevodetalle.Name = "TBtnNuevodetalle"
        Me.TBtnNuevodetalle.Size = New System.Drawing.Size(23, 22)
        Me.TBtnNuevodetalle.Text = "Nuevo"
        '
        'TBtneliminardetalle
        '
        Me.TBtneliminardetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBtneliminardetalle.Enabled = False
        Me.TBtneliminardetalle.Image = CType(resources.GetObject("TBtneliminardetalle.Image"), System.Drawing.Image)
        Me.TBtneliminardetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBtneliminardetalle.Name = "TBtneliminardetalle"
        Me.TBtneliminardetalle.Size = New System.Drawing.Size(23, 22)
        Me.TBtneliminardetalle.Text = "Eliminar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Codigo                      "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Producto                                "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(330, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cantidad"
        '
        'Codigo1
        '
        Me.Codigo1.Location = New System.Drawing.Point(7, 60)
        Me.Codigo1.Name = "Codigo1"
        Me.Codigo1.Size = New System.Drawing.Size(128, 21)
        Me.Codigo1.TabIndex = 2
        '
        'Producto1
        '
        Me.Producto1.AutoSize = True
        Me.Producto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto1.Location = New System.Drawing.Point(153, 66)
        Me.Producto1.Name = "Producto1"
        Me.Producto1.Size = New System.Drawing.Size(11, 13)
        Me.Producto1.TabIndex = 4
        Me.Producto1.Text = "*"
        '
        'Cantidad1
        '
        Me.Cantidad1.Location = New System.Drawing.Point(330, 60)
        Me.Cantidad1.Name = "Cantidad1"
        Me.Cantidad1.Size = New System.Drawing.Size(59, 21)
        Me.Cantidad1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(453, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Unidad"
        '
        'Unidad1
        '
        Me.Unidad1.AutoSize = True
        Me.Unidad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unidad1.Location = New System.Drawing.Point(452, 67)
        Me.Unidad1.Name = "Unidad1"
        Me.Unidad1.Size = New System.Drawing.Size(11, 13)
        Me.Unidad1.TabIndex = 10
        Me.Unidad1.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(500, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Valor Compra "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(587, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Impuesto"
        '
        'data_movimientos
        '
        Me.data_movimientos.AllowUserToAddRows = False
        Me.data_movimientos.AllowUserToDeleteRows = False
        Me.data_movimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_movimientos.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.data_movimientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data_movimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.data_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_movimientos.Location = New System.Drawing.Point(7, 88)
        Me.data_movimientos.Name = "data_movimientos"
        Me.data_movimientos.ReadOnly = True
        Me.data_movimientos.Size = New System.Drawing.Size(787, 249)
        Me.data_movimientos.TabIndex = 1
        '
        'lblexistencia
        '
        Me.lblexistencia.AutoSize = True
        Me.lblexistencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblexistencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexistencia.Location = New System.Drawing.Point(388, 42)
        Me.lblexistencia.Name = "lblexistencia"
        Me.lblexistencia.Size = New System.Drawing.Size(66, 15)
        Me.lblexistencia.TabIndex = 9
        Me.lblexistencia.Text = "Existencia"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Impuesto1)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Descuento1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Precio1)
        Me.GroupBox2.Controls.Add(Me.Existencia1)
        Me.GroupBox2.Controls.Add(Me.lblexistencia)
        Me.GroupBox2.Controls.Add(Me.data_movimientos)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Unidad1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Cantidad1)
        Me.GroupBox2.Controls.Add(Me.Producto1)
        Me.GroupBox2.Controls.Add(Me.Codigo1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ToolStripfacturas)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 343)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(136, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Impuesto1
        '
        Me.Impuesto1.Location = New System.Drawing.Point(590, 61)
        Me.Impuesto1.Name = "Impuesto1"
        Me.Impuesto1.Size = New System.Drawing.Size(33, 21)
        Me.Impuesto1.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(697, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 15)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(622, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 15)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "%"
        '
        'Descuento1
        '
        Me.Descuento1.Location = New System.Drawing.Point(646, 61)
        Me.Descuento1.Name = "Descuento1"
        Me.Descuento1.Size = New System.Drawing.Size(50, 21)
        Me.Descuento1.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(646, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 15)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Descuento"
        '
        'Precio1
        '
        Me.Precio1.Location = New System.Drawing.Point(500, 61)
        Me.Precio1.Name = "Precio1"
        Me.Precio1.Size = New System.Drawing.Size(86, 21)
        Me.Precio1.TabIndex = 12
        '
        'Existencia1
        '
        Me.Existencia1.AutoSize = True
        Me.Existencia1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Existencia1.Location = New System.Drawing.Point(405, 65)
        Me.Existencia1.Name = "Existencia1"
        Me.Existencia1.Size = New System.Drawing.Size(13, 13)
        Me.Existencia1.TabIndex = 8
        Me.Existencia1.Text = "0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gran_total)
        Me.GroupBox4.Controls.Add(Me.impuesto)
        Me.GroupBox4.Controls.Add(Me.gran_descuento)
        Me.GroupBox4.Controls.Add(Me.neto)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(806, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(178, 128)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Valores"
        '
        'gran_total
        '
        Me.gran_total.AutoSize = True
        Me.gran_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gran_total.ForeColor = System.Drawing.Color.Red
        Me.gran_total.Location = New System.Drawing.Point(81, 91)
        Me.gran_total.Name = "gran_total"
        Me.gran_total.Size = New System.Drawing.Size(15, 16)
        Me.gran_total.TabIndex = 7
        Me.gran_total.Text = "0"
        '
        'impuesto
        '
        Me.impuesto.AutoSize = True
        Me.impuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.impuesto.Location = New System.Drawing.Point(81, 67)
        Me.impuesto.Name = "impuesto"
        Me.impuesto.Size = New System.Drawing.Size(15, 16)
        Me.impuesto.TabIndex = 5
        Me.impuesto.Text = "0"
        '
        'gran_descuento
        '
        Me.gran_descuento.AutoSize = True
        Me.gran_descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gran_descuento.Location = New System.Drawing.Point(81, 45)
        Me.gran_descuento.Name = "gran_descuento"
        Me.gran_descuento.Size = New System.Drawing.Size(15, 16)
        Me.gran_descuento.TabIndex = 3
        Me.gran_descuento.Text = "0"
        '
        'neto
        '
        Me.neto.AutoSize = True
        Me.neto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.neto.Location = New System.Drawing.Point(81, 25)
        Me.neto.Name = "neto"
        Me.neto.Size = New System.Drawing.Size(15, 16)
        Me.neto.TabIndex = 1
        Me.neto.Text = "0"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(35, 91)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(42, 16)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Total:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(13, 67)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 16)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Impuesto:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Descuento:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(37, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Neto:"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(686, 36)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(0, 15)
        Me.LblEstado.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(473, 73)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(330, 129)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Observaciones"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(6, 20)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(318, 50)
        Me.TextBox2.TabIndex = 3
        '
        'TxtApellido2_terce_factu
        '
        Me.TxtApellido2_terce_factu.Enabled = False
        Me.TxtApellido2_terce_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido2_terce_factu.Location = New System.Drawing.Point(264, 79)
        Me.TxtApellido2_terce_factu.Name = "TxtApellido2_terce_factu"
        Me.TxtApellido2_terce_factu.Size = New System.Drawing.Size(168, 21)
        Me.TxtApellido2_terce_factu.TabIndex = 7
        '
        'Mov_inventarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 557)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Mov_inventarios"
        Me.Text = "Movimiento inventarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripfacturas.ResumeLayout(False)
        Me.ToolStripfacturas.PerformLayout()
        CType(Me.data_movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtFecha_reser As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecha_reser As System.Windows.Forms.Label
    Friend WithEvents CBUbicacion As System.Windows.Forms.ComboBox
    Friend WithEvents LblUbicacion_reser As System.Windows.Forms.Label
    Friend WithEvents LblReserva_reser As System.Windows.Forms.Label
    Friend WithEvents Txtcodigo_movprodu As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtFactuproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtApellido_terce_factu As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre2_factu As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre1_factu As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocumento_terce_factu As System.Windows.Forms.TextBox
    Friend WithEvents LblCodigo_terce As System.Windows.Forms.Label
    Friend WithEvents LblNombre1_terce As System.Windows.Forms.Label
    Friend WithEvents ToolStripfacturas As System.Windows.Forms.ToolStrip
    Friend WithEvents TBtnNuevodetalle As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBtneliminardetalle As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Codigo1 As System.Windows.Forms.TextBox
    Friend WithEvents Producto1 As System.Windows.Forms.Label
    Friend WithEvents Cantidad1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Unidad1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents data_movimientos As System.Windows.Forms.DataGridView
    Friend WithEvents lblexistencia As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Precio1 As System.Windows.Forms.TextBox
    Friend WithEvents Existencia1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Descuento1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Descuento_Movi As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Impuesto1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents gran_total As System.Windows.Forms.Label
    Friend WithEvents impuesto As System.Windows.Forms.Label
    Friend WithEvents gran_descuento As System.Windows.Forms.Label
    Friend WithEvents neto As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblUbica As System.Windows.Forms.Label
    Friend WithEvents LblConcepto As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido2_terce_factu As System.Windows.Forms.TextBox
End Class

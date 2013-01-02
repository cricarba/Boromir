<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBConcepto_factu = New System.Windows.Forms.ComboBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFecha_factu = New System.Windows.Forms.DateTimePicker()
        Me.LblFecha_reser = New System.Windows.Forms.Label()
        Me.CBoxUbicacion_factu = New System.Windows.Forms.ComboBox()
        Me.LblUbicacion_reser = New System.Windows.Forms.Label()
        Me.LblReserva_reser = New System.Windows.Forms.Label()
        Me.TxtFactura_factu = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TxtApellido2_terce_factu = New System.Windows.Forms.TextBox()
        Me.TxtApellido_terce_factu = New System.Windows.Forms.TextBox()
        Me.LblApellidos_terce = New System.Windows.Forms.Label()
        Me.TxtNombre2_factu = New System.Windows.Forms.TextBox()
        Me.TxtNombre1_factu = New System.Windows.Forms.TextBox()
        Me.TxtDocumento_terce_factu = New System.Windows.Forms.TextBox()
        Me.LblCodigo_terce = New System.Windows.Forms.Label()
        Me.LblNombre1_terce = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TxtCodBarras = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Existencia1 = New System.Windows.Forms.Label()
        Me.lblexistencia = New System.Windows.Forms.Label()
        Me.Descuento1 = New System.Windows.Forms.Label()
        Me.DetFac = New System.Windows.Forms.DataGridView()
        Me.Impuesto1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.precio1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Unidad1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cantidad1 = New System.Windows.Forms.TextBox()
        Me.Producto1 = New System.Windows.Forms.Label()
        Me.Codigo1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStripfacturas = New System.Windows.Forms.ToolStrip()
        Me.TBtnNuevodetalle = New System.Windows.Forms.ToolStripButton()
        Me.TBtneliminardetalle = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gran_total = New System.Windows.Forms.Label()
        Me.impuesto = New System.Windows.Forms.Label()
        Me.gran_descuento = New System.Windows.Forms.Label()
        Me.neto = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbldetallefacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetFac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripfacturas.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TbldetallefacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBConcepto_factu)
        Me.GroupBox1.Controls.Add(Me.LblEstado)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtFecha_factu)
        Me.GroupBox1.Controls.Add(Me.LblFecha_reser)
        Me.GroupBox1.Controls.Add(Me.CBoxUbicacion_factu)
        Me.GroupBox1.Controls.Add(Me.LblUbicacion_reser)
        Me.GroupBox1.Controls.Add(Me.LblReserva_reser)
        Me.GroupBox1.Controls.Add(Me.TxtFactura_factu)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(871, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Factura"
        '
        'CBConcepto_factu
        '
        Me.CBConcepto_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBConcepto_factu.FormattingEnabled = True
        Me.CBConcepto_factu.Location = New System.Drawing.Point(188, 25)
        Me.CBConcepto_factu.Name = "CBConcepto_factu"
        Me.CBConcepto_factu.Size = New System.Drawing.Size(49, 23)
        Me.CBConcepto_factu.TabIndex = 3
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(665, 27)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(106, 15)
        Me.LblEstado.TabIndex = 9
        Me.LblEstado.Text = "Nombre Estado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(619, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Estado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Concepto:"
        '
        'TxtFecha_factu
        '
        Me.TxtFecha_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha_factu.Location = New System.Drawing.Point(408, 25)
        Me.TxtFecha_factu.Name = "TxtFecha_factu"
        Me.TxtFecha_factu.Size = New System.Drawing.Size(199, 20)
        Me.TxtFecha_factu.TabIndex = 7
        '
        'LblFecha_reser
        '
        Me.LblFecha_reser.AutoSize = True
        Me.LblFecha_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha_reser.Location = New System.Drawing.Point(358, 27)
        Me.LblFecha_reser.Name = "LblFecha_reser"
        Me.LblFecha_reser.Size = New System.Drawing.Size(44, 15)
        Me.LblFecha_reser.TabIndex = 6
        Me.LblFecha_reser.Text = "Fecha:"
        '
        'CBoxUbicacion_factu
        '
        Me.CBoxUbicacion_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxUbicacion_factu.FormattingEnabled = True
        Me.CBoxUbicacion_factu.Location = New System.Drawing.Point(313, 24)
        Me.CBoxUbicacion_factu.Name = "CBoxUbicacion_factu"
        Me.CBoxUbicacion_factu.Size = New System.Drawing.Size(42, 23)
        Me.CBoxUbicacion_factu.TabIndex = 5
        '
        'LblUbicacion_reser
        '
        Me.LblUbicacion_reser.AutoSize = True
        Me.LblUbicacion_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbicacion_reser.Location = New System.Drawing.Point(243, 27)
        Me.LblUbicacion_reser.Name = "LblUbicacion_reser"
        Me.LblUbicacion_reser.Size = New System.Drawing.Size(65, 15)
        Me.LblUbicacion_reser.TabIndex = 4
        Me.LblUbicacion_reser.Text = "Ubicación:"
        '
        'LblReserva_reser
        '
        Me.LblReserva_reser.AutoSize = True
        Me.LblReserva_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReserva_reser.Location = New System.Drawing.Point(6, 28)
        Me.LblReserva_reser.Name = "LblReserva_reser"
        Me.LblReserva_reser.Size = New System.Drawing.Size(55, 15)
        Me.LblReserva_reser.TabIndex = 0
        Me.LblReserva_reser.Text = "Numero:"
        '
        'TxtFactura_factu
        '
        Me.TxtFactura_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFactura_factu.Location = New System.Drawing.Point(76, 27)
        Me.TxtFactura_factu.Name = "TxtFactura_factu"
        Me.TxtFactura_factu.Size = New System.Drawing.Size(42, 21)
        Me.TxtFactura_factu.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.TxtApellido2_terce_factu)
        Me.GroupBox3.Controls.Add(Me.TxtApellido_terce_factu)
        Me.GroupBox3.Controls.Add(Me.LblApellidos_terce)
        Me.GroupBox3.Controls.Add(Me.TxtNombre2_factu)
        Me.GroupBox3.Controls.Add(Me.TxtNombre1_factu)
        Me.GroupBox3.Controls.Add(Me.TxtDocumento_terce_factu)
        Me.GroupBox3.Controls.Add(Me.LblCodigo_terce)
        Me.GroupBox3.Controls.Add(Me.LblNombre1_terce)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(437, 128)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Tercero"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(285, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox2.TabIndex = 134
        Me.PictureBox2.TabStop = False
        '
        'TxtApellido2_terce_factu
        '
        Me.TxtApellido2_terce_factu.Enabled = False
        Me.TxtApellido2_terce_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido2_terce_factu.Location = New System.Drawing.Point(247, 92)
        Me.TxtApellido2_terce_factu.Name = "TxtApellido2_terce_factu"
        Me.TxtApellido2_terce_factu.Size = New System.Drawing.Size(168, 21)
        Me.TxtApellido2_terce_factu.TabIndex = 7
        '
        'TxtApellido_terce_factu
        '
        Me.TxtApellido_terce_factu.Enabled = False
        Me.TxtApellido_terce_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido_terce_factu.Location = New System.Drawing.Point(78, 92)
        Me.TxtApellido_terce_factu.Name = "TxtApellido_terce_factu"
        Me.TxtApellido_terce_factu.Size = New System.Drawing.Size(168, 21)
        Me.TxtApellido_terce_factu.TabIndex = 6
        '
        'LblApellidos_terce
        '
        Me.LblApellidos_terce.AutoSize = True
        Me.LblApellidos_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellidos_terce.Location = New System.Drawing.Point(11, 95)
        Me.LblApellidos_terce.Name = "LblApellidos_terce"
        Me.LblApellidos_terce.Size = New System.Drawing.Size(60, 15)
        Me.LblApellidos_terce.TabIndex = 5
        Me.LblApellidos_terce.Text = "Apellidos:"
        '
        'TxtNombre2_factu
        '
        Me.TxtNombre2_factu.Enabled = False
        Me.TxtNombre2_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre2_factu.Location = New System.Drawing.Point(247, 65)
        Me.TxtNombre2_factu.Name = "TxtNombre2_factu"
        Me.TxtNombre2_factu.Size = New System.Drawing.Size(168, 21)
        Me.TxtNombre2_factu.TabIndex = 4
        '
        'TxtNombre1_factu
        '
        Me.TxtNombre1_factu.Enabled = False
        Me.TxtNombre1_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre1_factu.Location = New System.Drawing.Point(78, 65)
        Me.TxtNombre1_factu.Name = "TxtNombre1_factu"
        Me.TxtNombre1_factu.Size = New System.Drawing.Size(168, 21)
        Me.TxtNombre1_factu.TabIndex = 3
        '
        'TxtDocumento_terce_factu
        '
        Me.TxtDocumento_terce_factu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocumento_terce_factu.Location = New System.Drawing.Point(110, 33)
        Me.TxtDocumento_terce_factu.Name = "TxtDocumento_terce_factu"
        Me.TxtDocumento_terce_factu.Size = New System.Drawing.Size(169, 21)
        Me.TxtDocumento_terce_factu.TabIndex = 1
        '
        'LblCodigo_terce
        '
        Me.LblCodigo_terce.AutoSize = True
        Me.LblCodigo_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo_terce.Location = New System.Drawing.Point(11, 36)
        Me.LblCodigo_terce.Name = "LblCodigo_terce"
        Me.LblCodigo_terce.Size = New System.Drawing.Size(93, 15)
        Me.LblCodigo_terce.TabIndex = 0
        Me.LblCodigo_terce.Text = "No Documento:"
        '
        'LblNombre1_terce
        '
        Me.LblNombre1_terce.AutoSize = True
        Me.LblNombre1_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre1_terce.Location = New System.Drawing.Point(11, 68)
        Me.LblNombre1_terce.Name = "LblNombre1_terce"
        Me.LblNombre1_terce.Size = New System.Drawing.Size(61, 15)
        Me.LblNombre1_terce.TabIndex = 2
        Me.LblNombre1_terce.Text = "Nombres:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.TxtCodBarras)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Existencia1)
        Me.GroupBox2.Controls.Add(Me.lblexistencia)
        Me.GroupBox2.Controls.Add(Me.Descuento1)
        Me.GroupBox2.Controls.Add(Me.DetFac)
        Me.GroupBox2.Controls.Add(Me.Impuesto1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.precio1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Unidad1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Cantidad1)
        Me.GroupBox2.Controls.Add(Me.Producto1)
        Me.GroupBox2.Controls.Add(Me.Codigo1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ToolStripfacturas)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(872, 408)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(305, 63)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox3.TabIndex = 138
        Me.PictureBox3.TabStop = False
        '
        'TxtCodBarras
        '
        Me.TxtCodBarras.Location = New System.Drawing.Point(149, 60)
        Me.TxtCodBarras.Name = "TxtCodBarras"
        Me.TxtCodBarras.Size = New System.Drawing.Size(150, 21)
        Me.TxtCodBarras.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(144, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 15)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "Codigo EAN/ Codigo de Barras"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(130, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(844, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "%"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(776, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "%"
        '
        'Existencia1
        '
        Me.Existencia1.AutoSize = True
        Me.Existencia1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Existencia1.Location = New System.Drawing.Point(584, 65)
        Me.Existencia1.Name = "Existencia1"
        Me.Existencia1.Size = New System.Drawing.Size(13, 13)
        Me.Existencia1.TabIndex = 6
        Me.Existencia1.Text = "0"
        '
        'lblexistencia
        '
        Me.lblexistencia.AutoSize = True
        Me.lblexistencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblexistencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexistencia.Location = New System.Drawing.Point(567, 42)
        Me.lblexistencia.Name = "lblexistencia"
        Me.lblexistencia.Size = New System.Drawing.Size(66, 15)
        Me.lblexistencia.TabIndex = 7
        Me.lblexistencia.Text = "Existencia"
        '
        'Descuento1
        '
        Me.Descuento1.AutoSize = True
        Me.Descuento1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descuento1.Location = New System.Drawing.Point(796, 63)
        Me.Descuento1.Name = "Descuento1"
        Me.Descuento1.Size = New System.Drawing.Size(14, 15)
        Me.Descuento1.TabIndex = 16
        Me.Descuento1.Text = "0"
        '
        'DetFac
        '
        Me.DetFac.AllowUserToAddRows = False
        Me.DetFac.AllowUserToDeleteRows = False
        Me.DetFac.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DetFac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetFac.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DetFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetFac.Location = New System.Drawing.Point(7, 88)
        Me.DetFac.Name = "DetFac"
        Me.DetFac.ReadOnly = True
        Me.DetFac.Size = New System.Drawing.Size(850, 314)
        Me.DetFac.TabIndex = 4
        '
        'Impuesto1
        '
        Me.Impuesto1.AutoSize = True
        Me.Impuesto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impuesto1.Location = New System.Drawing.Point(740, 65)
        Me.Impuesto1.Name = "Impuesto1"
        Me.Impuesto1.Size = New System.Drawing.Size(13, 13)
        Me.Impuesto1.TabIndex = 12
        Me.Impuesto1.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(793, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 15)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Descuento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(734, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Impuesto"
        '
        'precio1
        '
        Me.precio1.AutoSize = True
        Me.precio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precio1.Location = New System.Drawing.Point(682, 65)
        Me.precio1.Name = "precio1"
        Me.precio1.Size = New System.Drawing.Size(13, 13)
        Me.precio1.TabIndex = 10
        Me.precio1.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(679, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Precio   "
        '
        'Unidad1
        '
        Me.Unidad1.AutoSize = True
        Me.Unidad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unidad1.Location = New System.Drawing.Point(638, 65)
        Me.Unidad1.Name = "Unidad1"
        Me.Unidad1.Size = New System.Drawing.Size(11, 13)
        Me.Unidad1.TabIndex = 8
        Me.Unidad1.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(632, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Unidad"
        '
        'Cantidad1
        '
        Me.Cantidad1.Location = New System.Drawing.Point(509, 60)
        Me.Cantidad1.Name = "Cantidad1"
        Me.Cantidad1.Size = New System.Drawing.Size(59, 21)
        Me.Cantidad1.TabIndex = 3
        '
        'Producto1
        '
        Me.Producto1.AutoSize = True
        Me.Producto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto1.Location = New System.Drawing.Point(324, 65)
        Me.Producto1.Name = "Producto1"
        Me.Producto1.Size = New System.Drawing.Size(11, 13)
        Me.Producto1.TabIndex = 2
        Me.Producto1.Text = "*"
        '
        'Codigo1
        '
        Me.Codigo1.Location = New System.Drawing.Point(7, 60)
        Me.Codigo1.Name = "Codigo1"
        Me.Codigo1.Size = New System.Drawing.Size(119, 21)
        Me.Codigo1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(509, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(323, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Producto                                "
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
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo                      "
        '
        'ToolStripfacturas
        '
        Me.ToolStripfacturas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TBtnNuevodetalle, Me.TBtneliminardetalle})
        Me.ToolStripfacturas.Location = New System.Drawing.Point(3, 17)
        Me.ToolStripfacturas.Name = "ToolStripfacturas"
        Me.ToolStripfacturas.Size = New System.Drawing.Size(866, 25)
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gran_total)
        Me.GroupBox4.Controls.Add(Me.impuesto)
        Me.GroupBox4.Controls.Add(Me.gran_descuento)
        Me.GroupBox4.Controls.Add(Me.neto)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(454, 79)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(339, 128)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Valores"
        '
        'gran_total
        '
        Me.gran_total.AutoSize = True
        Me.gran_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gran_total.ForeColor = System.Drawing.Color.Red
        Me.gran_total.Location = New System.Drawing.Point(114, 91)
        Me.gran_total.Name = "gran_total"
        Me.gran_total.Size = New System.Drawing.Size(23, 25)
        Me.gran_total.TabIndex = 0
        Me.gran_total.Text = "0"
        '
        'impuesto
        '
        Me.impuesto.AutoSize = True
        Me.impuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.impuesto.Location = New System.Drawing.Point(114, 67)
        Me.impuesto.Name = "impuesto"
        Me.impuesto.Size = New System.Drawing.Size(23, 25)
        Me.impuesto.TabIndex = 6
        Me.impuesto.Text = "0"
        '
        'gran_descuento
        '
        Me.gran_descuento.AutoSize = True
        Me.gran_descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gran_descuento.Location = New System.Drawing.Point(114, 45)
        Me.gran_descuento.Name = "gran_descuento"
        Me.gran_descuento.Size = New System.Drawing.Size(23, 25)
        Me.gran_descuento.TabIndex = 4
        Me.gran_descuento.Text = "0"
        '
        'neto
        '
        Me.neto.AutoSize = True
        Me.neto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.neto.Location = New System.Drawing.Point(114, 25)
        Me.neto.Name = "neto"
        Me.neto.Size = New System.Drawing.Size(23, 25)
        Me.neto.TabIndex = 2
        Me.neto.Text = "0"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(53, 91)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(62, 25)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Total:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(17, 67)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(98, 25)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Impuesto:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 25)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Descuento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(56, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Neto:"
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 631)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Facturas"
        Me.Text = "Facturas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetFac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripfacturas.ResumeLayout(False)
        Me.ToolStripfacturas.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TbldetallefacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFecha_factu As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecha_reser As System.Windows.Forms.Label
    Friend WithEvents CBoxUbicacion_factu As System.Windows.Forms.ComboBox
    Friend WithEvents LblUbicacion_reser As System.Windows.Forms.Label
    Friend WithEvents LblReserva_reser As System.Windows.Forms.Label
    Friend WithEvents TxtFactura_factu As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtApellido2_terce_factu As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido_terce_factu As System.Windows.Forms.TextBox
    Friend WithEvents LblApellidos_terce As System.Windows.Forms.Label
    Friend WithEvents TxtNombre2_factu As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre1_factu As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocumento_terce_factu As System.Windows.Forms.TextBox
    Friend WithEvents LblCodigo_terce As System.Windows.Forms.Label
    Friend WithEvents LblNombre1_terce As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripfacturas As System.Windows.Forms.ToolStrip
    Friend WithEvents TBtnNuevodetalle As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBtneliminardetalle As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cantidad1 As System.Windows.Forms.TextBox
    Friend WithEvents Producto1 As System.Windows.Forms.Label
    Friend WithEvents Codigo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents precio1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Unidad1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Impuesto1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents DetFac As System.Windows.Forms.DataGridView
    Friend WithEvents TbldetallefacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CBConcepto_factu As System.Windows.Forms.ComboBox
    Friend WithEvents Descuento1 As System.Windows.Forms.Label
    Friend WithEvents gran_total As System.Windows.Forms.Label
    Friend WithEvents impuesto As System.Windows.Forms.Label
    Friend WithEvents gran_descuento As System.Windows.Forms.Label
    Friend WithEvents neto As System.Windows.Forms.Label
    Friend WithEvents Existencia1 As System.Windows.Forms.Label
    Friend WithEvents lblexistencia As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtCodBarras As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class

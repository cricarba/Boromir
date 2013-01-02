<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordenes_Compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ordenes_Compra))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gran_total = New System.Windows.Forms.Label()
        Me.impuesto = New System.Windows.Forms.Label()
        Me.gran_descuento = New System.Windows.Forms.Label()
        Me.neto = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Descuento1 = New System.Windows.Forms.TextBox()
        Me.TxtCodBarras = New System.Windows.Forms.TextBox()
        Me.Impuesto1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.precio1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.detCOTt_datagrid = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblUbica = New System.Windows.Forms.Label()
        Me.LblConcepto = New System.Windows.Forms.Label()
        Me.CBConcepto = New System.Windows.Forms.ComboBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFecha_factu = New System.Windows.Forms.DateTimePicker()
        Me.LblFecha_reser = New System.Windows.Forms.Label()
        Me.CBUbicacion = New System.Windows.Forms.ComboBox()
        Me.LblUbicacion_reser = New System.Windows.Forms.Label()
        Me.LblReserva_reser = New System.Windows.Forms.Label()
        Me.Txtnumero = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detCOTt_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripfacturas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox4.Location = New System.Drawing.Point(435, 75)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(220, 128)
        Me.GroupBox4.TabIndex = 3
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Neto:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.Descuento1)
        Me.GroupBox2.Controls.Add(Me.TxtCodBarras)
        Me.GroupBox2.Controls.Add(Me.Impuesto1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.precio1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.detCOTt_datagrid)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label9)
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
        Me.GroupBox2.Location = New System.Drawing.Point(8, 207)
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
        Me.PictureBox3.TabIndex = 141
        Me.PictureBox3.TabStop = False
        '
        'Descuento1
        '
        Me.Descuento1.Location = New System.Drawing.Point(783, 60)
        Me.Descuento1.Name = "Descuento1"
        Me.Descuento1.Size = New System.Drawing.Size(44, 21)
        Me.Descuento1.TabIndex = 138
        '
        'TxtCodBarras
        '
        Me.TxtCodBarras.Location = New System.Drawing.Point(149, 60)
        Me.TxtCodBarras.Name = "TxtCodBarras"
        Me.TxtCodBarras.Size = New System.Drawing.Size(150, 21)
        Me.TxtCodBarras.TabIndex = 139
        '
        'Impuesto1
        '
        Me.Impuesto1.Location = New System.Drawing.Point(723, 60)
        Me.Impuesto1.Name = "Impuesto1"
        Me.Impuesto1.Size = New System.Drawing.Size(44, 21)
        Me.Impuesto1.TabIndex = 137
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
        Me.Label7.TabIndex = 140
        Me.Label7.Text = "Codigo EAN/ Codigo de Barras"
        '
        'precio1
        '
        Me.precio1.Location = New System.Drawing.Point(615, 60)
        Me.precio1.Name = "precio1"
        Me.precio1.Size = New System.Drawing.Size(105, 21)
        Me.precio1.TabIndex = 136
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
        Me.Label5.Location = New System.Drawing.Point(833, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "%"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(765, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 15)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "%"
        '
        'detCOTt_datagrid
        '
        Me.detCOTt_datagrid.AllowUserToAddRows = False
        Me.detCOTt_datagrid.AllowUserToDeleteRows = False
        Me.detCOTt_datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.detCOTt_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.detCOTt_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.detCOTt_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.detCOTt_datagrid.Enabled = False
        Me.detCOTt_datagrid.Location = New System.Drawing.Point(7, 88)
        Me.detCOTt_datagrid.Name = "detCOTt_datagrid"
        Me.detCOTt_datagrid.ReadOnly = True
        Me.detCOTt_datagrid.Size = New System.Drawing.Size(859, 314)
        Me.detCOTt_datagrid.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(782, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 15)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Descuento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(723, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Impuesto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(615, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Precio                "
        '
        'Unidad1
        '
        Me.Unidad1.AutoSize = True
        Me.Unidad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unidad1.Location = New System.Drawing.Point(574, 65)
        Me.Unidad1.Name = "Unidad1"
        Me.Unidad1.Size = New System.Drawing.Size(11, 13)
        Me.Unidad1.TabIndex = 4
        Me.Unidad1.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(568, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Unidad"
        '
        'Cantidad1
        '
        Me.Cantidad1.Location = New System.Drawing.Point(510, 60)
        Me.Cantidad1.Name = "Cantidad1"
        Me.Cantidad1.Size = New System.Drawing.Size(59, 21)
        Me.Cantidad1.TabIndex = 2
        '
        'Producto1
        '
        Me.Producto1.AutoSize = True
        Me.Producto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto1.Location = New System.Drawing.Point(325, 65)
        Me.Producto1.Name = "Producto1"
        Me.Producto1.Size = New System.Drawing.Size(11, 13)
        Me.Producto1.TabIndex = 1
        Me.Producto1.Text = "*"
        '
        'Codigo1
        '
        Me.Codigo1.Location = New System.Drawing.Point(7, 60)
        Me.Codigo1.Name = "Codigo1"
        Me.Codigo1.Size = New System.Drawing.Size(119, 21)
        Me.Codigo1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(510, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(324, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 15)
        Me.Label3.TabIndex = 18
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
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Codigo                      "
        '
        'ToolStripfacturas
        '
        Me.ToolStripfacturas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TBtnNuevodetalle, Me.TBtneliminardetalle})
        Me.ToolStripfacturas.Location = New System.Drawing.Point(3, 17)
        Me.ToolStripfacturas.Name = "ToolStripfacturas"
        Me.ToolStripfacturas.Size = New System.Drawing.Size(866, 25)
        Me.ToolStripfacturas.TabIndex = 20
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
        Me.GroupBox3.Location = New System.Drawing.Point(6, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(424, 128)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Proveedor"
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
        Me.TxtApellido2_terce_factu.Location = New System.Drawing.Point(250, 92)
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
        Me.TxtNombre2_factu.Location = New System.Drawing.Point(249, 65)
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
        Me.TxtDocumento_terce_factu.TabIndex = 0
        '
        'LblCodigo_terce
        '
        Me.LblCodigo_terce.AutoSize = True
        Me.LblCodigo_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo_terce.Location = New System.Drawing.Point(11, 36)
        Me.LblCodigo_terce.Name = "LblCodigo_terce"
        Me.LblCodigo_terce.Size = New System.Drawing.Size(93, 15)
        Me.LblCodigo_terce.TabIndex = 1
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblUbica)
        Me.GroupBox1.Controls.Add(Me.LblConcepto)
        Me.GroupBox1.Controls.Add(Me.CBConcepto)
        Me.GroupBox1.Controls.Add(Me.LblEstado)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtFecha_factu)
        Me.GroupBox1.Controls.Add(Me.LblFecha_reser)
        Me.GroupBox1.Controls.Add(Me.CBUbicacion)
        Me.GroupBox1.Controls.Add(Me.LblUbicacion_reser)
        Me.GroupBox1.Controls.Add(Me.LblReserva_reser)
        Me.GroupBox1.Controls.Add(Me.Txtnumero)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Cotizacion"
        '
        'LblUbica
        '
        Me.LblUbica.AutoSize = True
        Me.LblUbica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbica.Location = New System.Drawing.Point(246, 50)
        Me.LblUbica.Name = "LblUbica"
        Me.LblUbica.Size = New System.Drawing.Size(0, 15)
        Me.LblUbica.TabIndex = 11
        '
        'LblConcepto
        '
        Me.LblConcepto.AutoSize = True
        Me.LblConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConcepto.Location = New System.Drawing.Point(130, 48)
        Me.LblConcepto.Name = "LblConcepto"
        Me.LblConcepto.Size = New System.Drawing.Size(0, 15)
        Me.LblConcepto.TabIndex = 10
        '
        'CBConcepto
        '
        Me.CBConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBConcepto.FormattingEnabled = True
        Me.CBConcepto.Location = New System.Drawing.Point(188, 25)
        Me.CBConcepto.Name = "CBConcepto"
        Me.CBConcepto.Size = New System.Drawing.Size(49, 23)
        Me.CBConcepto.TabIndex = 3
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(665, 27)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(0, 15)
        Me.LblEstado.TabIndex = 9
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
        'CBUbicacion
        '
        Me.CBUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUbicacion.FormattingEnabled = True
        Me.CBUbicacion.Location = New System.Drawing.Point(313, 24)
        Me.CBUbicacion.Name = "CBUbicacion"
        Me.CBUbicacion.Size = New System.Drawing.Size(42, 23)
        Me.CBUbicacion.TabIndex = 5
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
        'Txtnumero
        '
        Me.Txtnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnumero.Location = New System.Drawing.Point(66, 27)
        Me.Txtnumero.Name = "Txtnumero"
        Me.Txtnumero.Size = New System.Drawing.Size(42, 21)
        Me.Txtnumero.TabIndex = 1
        '
        'Ordenes_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 616)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Ordenes_Compra"
        Me.Text = "Ordenes_Compra"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detCOTt_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripfacturas.ResumeLayout(False)
        Me.ToolStripfacturas.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents gran_total As System.Windows.Forms.Label
    Friend WithEvents impuesto As System.Windows.Forms.Label
    Friend WithEvents gran_descuento As System.Windows.Forms.Label
    Friend WithEvents neto As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents detCOTt_datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Unidad1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cantidad1 As System.Windows.Forms.TextBox
    Friend WithEvents Producto1 As System.Windows.Forms.Label
    Friend WithEvents Codigo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripfacturas As System.Windows.Forms.ToolStrip
    Friend WithEvents TBtnNuevodetalle As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBtneliminardetalle As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtApellido2_terce_factu As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido_terce_factu As System.Windows.Forms.TextBox
    Friend WithEvents LblApellidos_terce As System.Windows.Forms.Label
    Friend WithEvents TxtNombre2_factu As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre1_factu As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocumento_terce_factu As System.Windows.Forms.TextBox
    Friend WithEvents LblCodigo_terce As System.Windows.Forms.Label
    Friend WithEvents LblNombre1_terce As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFecha_factu As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecha_reser As System.Windows.Forms.Label
    Friend WithEvents CBUbicacion As System.Windows.Forms.ComboBox
    Friend WithEvents LblUbicacion_reser As System.Windows.Forms.Label
    Friend WithEvents LblReserva_reser As System.Windows.Forms.Label
    Friend WithEvents Txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents LblUbica As System.Windows.Forms.Label
    Friend WithEvents LblConcepto As System.Windows.Forms.Label
    Friend WithEvents Descuento1 As System.Windows.Forms.TextBox
    Friend WithEvents Impuesto1 As System.Windows.Forms.TextBox
    Friend WithEvents precio1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtCodBarras As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class

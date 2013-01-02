<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nueva_Reserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nueva_Reserva))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MTxtHora_reser = New System.Windows.Forms.MaskedTextBox()
        Me.LblHora_reser = New System.Windows.Forms.Label()
        Me.TxtFecha_reser = New System.Windows.Forms.DateTimePicker()
        Me.LblFecha_reser = New System.Windows.Forms.Label()
        Me.CBoxUbicacion_reser = New System.Windows.Forms.ComboBox()
        Me.LblUbicacion_reser = New System.Windows.Forms.Label()
        Me.LblReserva_reser = New System.Windows.Forms.Label()
        Me.TxtReserva_reser = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtApellido2_terce_reser = New System.Windows.Forms.TextBox()
        Me.TxtApellido_terce_reser = New System.Windows.Forms.TextBox()
        Me.LblApellidos_terce = New System.Windows.Forms.Label()
        Me.TxtNombre2_terce = New System.Windows.Forms.TextBox()
        Me.TxtNombre1_terce = New System.Windows.Forms.TextBox()
        Me.TxtDocumento_terce_reser = New System.Windows.Forms.TextBox()
        Me.LblCodigo_terce = New System.Windows.Forms.Label()
        Me.Txt_doc = New System.Windows.Forms.Label()
        Me.LblTipodoc_terce = New System.Windows.Forms.Label()
        Me.LblNombre1_terce = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_buscar = New System.Windows.Forms.Button()
        Me.TxtDatos_Costo = New System.Windows.Forms.TextBox()
        Me.TxtDatos_tipocosto = New System.Windows.Forms.TextBox()
        Me.TxtDatos_escen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDatos_Cod_escen = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnDisponibles_reser = New System.Windows.Forms.Button()
        Me.CBlist_disponibles = New System.Windows.Forms.CheckedListBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblEstado_reser = New System.Windows.Forms.Label()
        Me.CBEstado_reser = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MTxtHora_reser)
        Me.GroupBox1.Controls.Add(Me.LblHora_reser)
        Me.GroupBox1.Controls.Add(Me.TxtFecha_reser)
        Me.GroupBox1.Controls.Add(Me.LblFecha_reser)
        Me.GroupBox1.Controls.Add(Me.CBoxUbicacion_reser)
        Me.GroupBox1.Controls.Add(Me.LblUbicacion_reser)
        Me.GroupBox1.Controls.Add(Me.LblReserva_reser)
        Me.GroupBox1.Controls.Add(Me.TxtReserva_reser)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Reserva"
        '
        'MTxtHora_reser
        '
        Me.MTxtHora_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtHora_reser.Location = New System.Drawing.Point(309, 25)
        Me.MTxtHora_reser.Mask = "00:00"
        Me.MTxtHora_reser.Name = "MTxtHora_reser"
        Me.MTxtHora_reser.Size = New System.Drawing.Size(33, 20)
        Me.MTxtHora_reser.TabIndex = 4
        Me.MTxtHora_reser.ValidatingType = GetType(Date)
        '
        'LblHora_reser
        '
        Me.LblHora_reser.AutoSize = True
        Me.LblHora_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora_reser.Location = New System.Drawing.Point(268, 26)
        Me.LblHora_reser.Name = "LblHora_reser"
        Me.LblHora_reser.Size = New System.Drawing.Size(40, 15)
        Me.LblHora_reser.TabIndex = 3
        Me.LblHora_reser.Text = "Hora :"
        '
        'TxtFecha_reser
        '
        Me.TxtFecha_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha_reser.Location = New System.Drawing.Point(48, 57)
        Me.TxtFecha_reser.Name = "TxtFecha_reser"
        Me.TxtFecha_reser.Size = New System.Drawing.Size(202, 20)
        Me.TxtFecha_reser.TabIndex = 6
        '
        'LblFecha_reser
        '
        Me.LblFecha_reser.AutoSize = True
        Me.LblFecha_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha_reser.Location = New System.Drawing.Point(7, 60)
        Me.LblFecha_reser.Name = "LblFecha_reser"
        Me.LblFecha_reser.Size = New System.Drawing.Size(44, 15)
        Me.LblFecha_reser.TabIndex = 5
        Me.LblFecha_reser.Text = "Fecha:"
        '
        'CBoxUbicacion_reser
        '
        Me.CBoxUbicacion_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxUbicacion_reser.FormattingEnabled = True
        Me.CBoxUbicacion_reser.Location = New System.Drawing.Point(214, 24)
        Me.CBoxUbicacion_reser.Name = "CBoxUbicacion_reser"
        Me.CBoxUbicacion_reser.Size = New System.Drawing.Size(42, 21)
        Me.CBoxUbicacion_reser.TabIndex = 2
        '
        'LblUbicacion_reser
        '
        Me.LblUbicacion_reser.AutoSize = True
        Me.LblUbicacion_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbicacion_reser.Location = New System.Drawing.Point(143, 27)
        Me.LblUbicacion_reser.Name = "LblUbicacion_reser"
        Me.LblUbicacion_reser.Size = New System.Drawing.Size(65, 15)
        Me.LblUbicacion_reser.TabIndex = 5
        Me.LblUbicacion_reser.Text = "Ubicación:"
        '
        'LblReserva_reser
        '
        Me.LblReserva_reser.AutoSize = True
        Me.LblReserva_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReserva_reser.Location = New System.Drawing.Point(6, 27)
        Me.LblReserva_reser.Name = "LblReserva_reser"
        Me.LblReserva_reser.Size = New System.Drawing.Size(52, 15)
        Me.LblReserva_reser.TabIndex = 0
        Me.LblReserva_reser.Text = "Numero"
        '
        'TxtReserva_reser
        '
        Me.TxtReserva_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReserva_reser.Location = New System.Drawing.Point(64, 24)
        Me.TxtReserva_reser.Name = "TxtReserva_reser"
        Me.TxtReserva_reser.Size = New System.Drawing.Size(73, 20)
        Me.TxtReserva_reser.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtApellido2_terce_reser)
        Me.GroupBox2.Controls.Add(Me.TxtApellido_terce_reser)
        Me.GroupBox2.Controls.Add(Me.LblApellidos_terce)
        Me.GroupBox2.Controls.Add(Me.TxtNombre2_terce)
        Me.GroupBox2.Controls.Add(Me.TxtNombre1_terce)
        Me.GroupBox2.Controls.Add(Me.TxtDocumento_terce_reser)
        Me.GroupBox2.Controls.Add(Me.LblCodigo_terce)
        Me.GroupBox2.Controls.Add(Me.Txt_doc)
        Me.GroupBox2.Controls.Add(Me.LblTipodoc_terce)
        Me.GroupBox2.Controls.Add(Me.LblNombre1_terce)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 128)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Tercero"
        '
        'TxtApellido2_terce_reser
        '
        Me.TxtApellido2_terce_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido2_terce_reser.Location = New System.Drawing.Point(301, 92)
        Me.TxtApellido2_terce_reser.Name = "TxtApellido2_terce_reser"
        Me.TxtApellido2_terce_reser.Size = New System.Drawing.Size(195, 20)
        Me.TxtApellido2_terce_reser.TabIndex = 8
        '
        'TxtApellido_terce_reser
        '
        Me.TxtApellido_terce_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido_terce_reser.Location = New System.Drawing.Point(78, 92)
        Me.TxtApellido_terce_reser.Name = "TxtApellido_terce_reser"
        Me.TxtApellido_terce_reser.Size = New System.Drawing.Size(217, 20)
        Me.TxtApellido_terce_reser.TabIndex = 7
        '
        'LblApellidos_terce
        '
        Me.LblApellidos_terce.AutoSize = True
        Me.LblApellidos_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellidos_terce.Location = New System.Drawing.Point(11, 95)
        Me.LblApellidos_terce.Name = "LblApellidos_terce"
        Me.LblApellidos_terce.Size = New System.Drawing.Size(60, 15)
        Me.LblApellidos_terce.TabIndex = 6
        Me.LblApellidos_terce.Text = "Apellidos:"
        '
        'TxtNombre2_terce
        '
        Me.TxtNombre2_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre2_terce.Location = New System.Drawing.Point(301, 65)
        Me.TxtNombre2_terce.Name = "TxtNombre2_terce"
        Me.TxtNombre2_terce.Size = New System.Drawing.Size(194, 20)
        Me.TxtNombre2_terce.TabIndex = 5
        '
        'TxtNombre1_terce
        '
        Me.TxtNombre1_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre1_terce.Location = New System.Drawing.Point(78, 65)
        Me.TxtNombre1_terce.Name = "TxtNombre1_terce"
        Me.TxtNombre1_terce.Size = New System.Drawing.Size(217, 20)
        Me.TxtNombre1_terce.TabIndex = 4
        '
        'TxtDocumento_terce_reser
        '
        Me.TxtDocumento_terce_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocumento_terce_reser.Location = New System.Drawing.Point(115, 33)
        Me.TxtDocumento_terce_reser.Name = "TxtDocumento_terce_reser"
        Me.TxtDocumento_terce_reser.Size = New System.Drawing.Size(180, 20)
        Me.TxtDocumento_terce_reser.TabIndex = 1
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
        'Txt_doc
        '
        Me.Txt_doc.AutoSize = True
        Me.Txt_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_doc.Location = New System.Drawing.Point(338, 36)
        Me.Txt_doc.Name = "Txt_doc"
        Me.Txt_doc.Size = New System.Drawing.Size(0, 15)
        Me.Txt_doc.TabIndex = 10
        '
        'LblTipodoc_terce
        '
        Me.LblTipodoc_terce.AutoSize = True
        Me.LblTipodoc_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipodoc_terce.Location = New System.Drawing.Point(304, 36)
        Me.LblTipodoc_terce.Name = "LblTipodoc_terce"
        Me.LblTipodoc_terce.Size = New System.Drawing.Size(28, 15)
        Me.LblTipodoc_terce.TabIndex = 9
        Me.LblTipodoc_terce.Text = "D.I. "
        '
        'LblNombre1_terce
        '
        Me.LblNombre1_terce.AutoSize = True
        Me.LblNombre1_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre1_terce.Location = New System.Drawing.Point(11, 68)
        Me.LblNombre1_terce.Name = "LblNombre1_terce"
        Me.LblNombre1_terce.Size = New System.Drawing.Size(61, 15)
        Me.LblNombre1_terce.TabIndex = 3
        Me.LblNombre1_terce.Text = "Nombres:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_buscar)
        Me.GroupBox3.Controls.Add(Me.TxtDatos_Costo)
        Me.GroupBox3.Controls.Add(Me.TxtDatos_tipocosto)
        Me.GroupBox3.Controls.Add(Me.TxtDatos_escen)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtDatos_Cod_escen)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(289, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(229, 136)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Reserva"
        '
        'Btn_buscar
        '
        Me.Btn_buscar.Image = CType(resources.GetObject("Btn_buscar.Image"), System.Drawing.Image)
        Me.Btn_buscar.Location = New System.Drawing.Point(191, 15)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Size = New System.Drawing.Size(25, 25)
        Me.Btn_buscar.TabIndex = 2
        Me.Btn_buscar.UseVisualStyleBackColor = True
        Me.Btn_buscar.Visible = False
        '
        'TxtDatos_Costo
        '
        Me.TxtDatos_Costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDatos_Costo.Location = New System.Drawing.Point(101, 106)
        Me.TxtDatos_Costo.Name = "TxtDatos_Costo"
        Me.TxtDatos_Costo.Size = New System.Drawing.Size(122, 20)
        Me.TxtDatos_Costo.TabIndex = 9
        '
        'TxtDatos_tipocosto
        '
        Me.TxtDatos_tipocosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDatos_tipocosto.Location = New System.Drawing.Point(102, 78)
        Me.TxtDatos_tipocosto.Name = "TxtDatos_tipocosto"
        Me.TxtDatos_tipocosto.Size = New System.Drawing.Size(24, 20)
        Me.TxtDatos_tipocosto.TabIndex = 7
        '
        'TxtDatos_escen
        '
        Me.TxtDatos_escen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDatos_escen.Location = New System.Drawing.Point(102, 53)
        Me.TxtDatos_escen.Name = "TxtDatos_escen"
        Me.TxtDatos_escen.Size = New System.Drawing.Size(120, 20)
        Me.TxtDatos_escen.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipo Escenario :"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(458, 57)
        Me.MaskedTextBox1.Mask = "00:00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(43, 21)
        Me.MaskedTextBox1.TabIndex = 7
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(411, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hora :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Costo Reserva :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo Costo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Escenario No :"
        '
        'TxtDatos_Cod_escen
        '
        Me.TxtDatos_Cod_escen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDatos_Cod_escen.Location = New System.Drawing.Point(101, 26)
        Me.TxtDatos_Cod_escen.Name = "TxtDatos_Cod_escen"
        Me.TxtDatos_Cod_escen.Size = New System.Drawing.Size(24, 20)
        Me.TxtDatos_Cod_escen.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnDisponibles_reser)
        Me.GroupBox4.Controls.Add(Me.CBlist_disponibles)
        Me.GroupBox4.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(10, 110)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(273, 179)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ubicaciones Disponibles"
        '
        'BtnDisponibles_reser
        '
        Me.BtnDisponibles_reser.Image = CType(resources.GetObject("BtnDisponibles_reser.Image"), System.Drawing.Image)
        Me.BtnDisponibles_reser.Location = New System.Drawing.Point(236, 15)
        Me.BtnDisponibles_reser.Name = "BtnDisponibles_reser"
        Me.BtnDisponibles_reser.Size = New System.Drawing.Size(25, 25)
        Me.BtnDisponibles_reser.TabIndex = 0
        Me.BtnDisponibles_reser.UseVisualStyleBackColor = True
        '
        'CBlist_disponibles
        '
        Me.CBlist_disponibles.BackColor = System.Drawing.SystemColors.MenuBar
        Me.CBlist_disponibles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CBlist_disponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBlist_disponibles.FormattingEnabled = True
        Me.CBlist_disponibles.Location = New System.Drawing.Point(6, 23)
        Me.CBlist_disponibles.Name = "CBlist_disponibles"
        Me.CBlist_disponibles.Size = New System.Drawing.Size(224, 150)
        Me.CBlist_disponibles.TabIndex = 1
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(458, 57)
        Me.MaskedTextBox2.Mask = "00:00"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(43, 21)
        Me.MaskedTextBox2.TabIndex = 3
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(411, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Hora :"
        '
        'LblEstado_reser
        '
        Me.LblEstado_reser.AutoSize = True
        Me.LblEstado_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado_reser.Location = New System.Drawing.Point(12, 430)
        Me.LblEstado_reser.Name = "LblEstado_reser"
        Me.LblEstado_reser.Size = New System.Drawing.Size(51, 15)
        Me.LblEstado_reser.TabIndex = 4
        Me.LblEstado_reser.Text = "Estado :"
        '
        'CBEstado_reser
        '
        Me.CBEstado_reser.Enabled = False
        Me.CBEstado_reser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEstado_reser.ForeColor = System.Drawing.Color.Green
        Me.CBEstado_reser.FormattingEnabled = True
        Me.CBEstado_reser.Location = New System.Drawing.Point(69, 429)
        Me.CBEstado_reser.Name = "CBEstado_reser"
        Me.CBEstado_reser.Size = New System.Drawing.Size(121, 21)
        Me.CBEstado_reser.TabIndex = 5
        '
        'Nueva_Reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 458)
        Me.Controls.Add(Me.CBEstado_reser)
        Me.Controls.Add(Me.LblEstado_reser)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Nueva_Reserva"
        Me.Text = "Nueva_Reserva"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MTxtHora_reser As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblHora_reser As System.Windows.Forms.Label
    Friend WithEvents TxtFecha_reser As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecha_reser As System.Windows.Forms.Label
    Friend WithEvents CBoxUbicacion_reser As System.Windows.Forms.ComboBox
    Friend WithEvents LblUbicacion_reser As System.Windows.Forms.Label
    Friend WithEvents LblReserva_reser As System.Windows.Forms.Label
    Friend WithEvents TxtReserva_reser As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtApellido2_terce_reser As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido_terce_reser As System.Windows.Forms.TextBox
    Friend WithEvents LblApellidos_terce As System.Windows.Forms.Label
    Friend WithEvents TxtNombre2_terce As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre1_terce As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocumento_terce_reser As System.Windows.Forms.TextBox
    Friend WithEvents LblCodigo_terce As System.Windows.Forms.Label
    Friend WithEvents Txt_doc As System.Windows.Forms.Label
    Friend WithEvents LblTipodoc_terce As System.Windows.Forms.Label
    Friend WithEvents LblNombre1_terce As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDatos_tipocosto As System.Windows.Forms.TextBox
    Friend WithEvents TxtDatos_escen As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDatos_Cod_escen As System.Windows.Forms.TextBox
    Friend WithEvents TxtDatos_Costo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnDisponibles_reser As System.Windows.Forms.Button
    Friend WithEvents LblEstado_reser As System.Windows.Forms.Label
    Friend WithEvents CBEstado_reser As System.Windows.Forms.ComboBox
    Friend WithEvents CBlist_disponibles As System.Windows.Forms.CheckedListBox
    Friend WithEvents Btn_buscar As System.Windows.Forms.Button
End Class

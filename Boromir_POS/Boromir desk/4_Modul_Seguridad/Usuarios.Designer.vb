<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCorreo_usua = New System.Windows.Forms.TextBox()
        Me.LblCorreo_terce = New System.Windows.Forms.Label()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.LblCelular_terce = New System.Windows.Forms.Label()
        Me.TxtTelefono_usua = New System.Windows.Forms.TextBox()
        Me.LblTelefono_terce = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtApellido2_usua = New System.Windows.Forms.TextBox()
        Me.Txtapellido1_usua = New System.Windows.Forms.TextBox()
        Me.LblApellidos_terce = New System.Windows.Forms.Label()
        Me.TxtNombre2_terce = New System.Windows.Forms.TextBox()
        Me.TxtNombre1_terce = New System.Windows.Forms.TextBox()
        Me.TxtTercero_usua = New System.Windows.Forms.TextBox()
        Me.LblCodigo_terce = New System.Windows.Forms.Label()
        Me.LblNombredoc_terce = New System.Windows.Forms.Label()
        Me.LblNombre1_terce = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lblubica = New System.Windows.Forms.Label()
        Me.Lblconcide_pass = New System.Windows.Forms.Label()
        Me.CBPerfil_usuario = New System.Windows.Forms.ComboBox()
        Me.CBUbica_Usuarios = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBEstado_Usuarios = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_usuario_usua = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblSimilitud = New System.Windows.Forms.Label()
        Me.LblFuerzaContraseña_perfil = New System.Windows.Forms.Label()
        Me.Txtconfirmacontraseña_perfil = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtContraseña_perfil = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblPerfil = New System.Windows.Forms.Label()
        Me.LblPerfildes = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtCorreo_usua)
        Me.GroupBox2.Controls.Add(Me.LblCorreo_terce)
        Me.GroupBox2.Controls.Add(Me.TxtCelular)
        Me.GroupBox2.Controls.Add(Me.LblCelular_terce)
        Me.GroupBox2.Controls.Add(Me.TxtTelefono_usua)
        Me.GroupBox2.Controls.Add(Me.LblTelefono_terce)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 348)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 94)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Contacto"
        '
        'TxtCorreo_usua
        '
        Me.TxtCorreo_usua.Location = New System.Drawing.Point(78, 59)
        Me.TxtCorreo_usua.Name = "TxtCorreo_usua"
        Me.TxtCorreo_usua.Size = New System.Drawing.Size(341, 21)
        Me.TxtCorreo_usua.TabIndex = 2
        '
        'LblCorreo_terce
        '
        Me.LblCorreo_terce.AutoSize = True
        Me.LblCorreo_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo_terce.Location = New System.Drawing.Point(11, 62)
        Me.LblCorreo_terce.Name = "LblCorreo_terce"
        Me.LblCorreo_terce.Size = New System.Drawing.Size(47, 15)
        Me.LblCorreo_terce.TabIndex = 6
        Me.LblCorreo_terce.Text = "Correo:"
        '
        'TxtCelular
        '
        Me.TxtCelular.Location = New System.Drawing.Point(273, 32)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(146, 21)
        Me.TxtCelular.TabIndex = 1
        '
        'LblCelular_terce
        '
        Me.LblCelular_terce.AutoSize = True
        Me.LblCelular_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCelular_terce.Location = New System.Drawing.Point(218, 35)
        Me.LblCelular_terce.Name = "LblCelular_terce"
        Me.LblCelular_terce.Size = New System.Drawing.Size(49, 15)
        Me.LblCelular_terce.TabIndex = 4
        Me.LblCelular_terce.Text = "Celular:"
        '
        'TxtTelefono_usua
        '
        Me.TxtTelefono_usua.Location = New System.Drawing.Point(78, 32)
        Me.TxtTelefono_usua.Name = "TxtTelefono_usua"
        Me.TxtTelefono_usua.Size = New System.Drawing.Size(134, 21)
        Me.TxtTelefono_usua.TabIndex = 0
        '
        'LblTelefono_terce
        '
        Me.LblTelefono_terce.AutoSize = True
        Me.LblTelefono_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono_terce.Location = New System.Drawing.Point(11, 35)
        Me.LblTelefono_terce.Name = "LblTelefono_terce"
        Me.LblTelefono_terce.Size = New System.Drawing.Size(58, 15)
        Me.LblTelefono_terce.TabIndex = 2
        Me.LblTelefono_terce.Text = "Telefono:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TxtApellido2_usua)
        Me.GroupBox1.Controls.Add(Me.Txtapellido1_usua)
        Me.GroupBox1.Controls.Add(Me.LblApellidos_terce)
        Me.GroupBox1.Controls.Add(Me.TxtNombre2_terce)
        Me.GroupBox1.Controls.Add(Me.TxtNombre1_terce)
        Me.GroupBox1.Controls.Add(Me.TxtTercero_usua)
        Me.GroupBox1.Controls.Add(Me.LblCodigo_terce)
        Me.GroupBox1.Controls.Add(Me.LblNombredoc_terce)
        Me.GroupBox1.Controls.Add(Me.LblNombre1_terce)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 115)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Basicos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(377, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'TxtApellido2_usua
        '
        Me.TxtApellido2_usua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido2_usua.Location = New System.Drawing.Point(246, 83)
        Me.TxtApellido2_usua.Name = "TxtApellido2_usua"
        Me.TxtApellido2_usua.Size = New System.Drawing.Size(168, 21)
        Me.TxtApellido2_usua.TabIndex = 7
        '
        'Txtapellido1_usua
        '
        Me.Txtapellido1_usua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtapellido1_usua.Location = New System.Drawing.Point(73, 83)
        Me.Txtapellido1_usua.Name = "Txtapellido1_usua"
        Me.Txtapellido1_usua.Size = New System.Drawing.Size(168, 21)
        Me.Txtapellido1_usua.TabIndex = 6
        '
        'LblApellidos_terce
        '
        Me.LblApellidos_terce.AutoSize = True
        Me.LblApellidos_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellidos_terce.Location = New System.Drawing.Point(6, 86)
        Me.LblApellidos_terce.Name = "LblApellidos_terce"
        Me.LblApellidos_terce.Size = New System.Drawing.Size(60, 15)
        Me.LblApellidos_terce.TabIndex = 8
        Me.LblApellidos_terce.Text = "Apellidos:"
        '
        'TxtNombre2_terce
        '
        Me.TxtNombre2_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre2_terce.Location = New System.Drawing.Point(247, 56)
        Me.TxtNombre2_terce.Name = "TxtNombre2_terce"
        Me.TxtNombre2_terce.Size = New System.Drawing.Size(167, 21)
        Me.TxtNombre2_terce.TabIndex = 5
        '
        'TxtNombre1_terce
        '
        Me.TxtNombre1_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre1_terce.Location = New System.Drawing.Point(73, 56)
        Me.TxtNombre1_terce.Name = "TxtNombre1_terce"
        Me.TxtNombre1_terce.Size = New System.Drawing.Size(168, 21)
        Me.TxtNombre1_terce.TabIndex = 4
        '
        'TxtTercero_usua
        '
        Me.TxtTercero_usua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTercero_usua.Location = New System.Drawing.Point(110, 24)
        Me.TxtTercero_usua.Name = "TxtTercero_usua"
        Me.TxtTercero_usua.Size = New System.Drawing.Size(180, 21)
        Me.TxtTercero_usua.TabIndex = 1
        '
        'LblCodigo_terce
        '
        Me.LblCodigo_terce.AutoSize = True
        Me.LblCodigo_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo_terce.Location = New System.Drawing.Point(6, 27)
        Me.LblCodigo_terce.Name = "LblCodigo_terce"
        Me.LblCodigo_terce.Size = New System.Drawing.Size(93, 15)
        Me.LblCodigo_terce.TabIndex = 0
        Me.LblCodigo_terce.Text = "No Documento:"
        '
        'LblNombredoc_terce
        '
        Me.LblNombredoc_terce.AutoSize = True
        Me.LblNombredoc_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombredoc_terce.Location = New System.Drawing.Point(296, 27)
        Me.LblNombredoc_terce.Name = "LblNombredoc_terce"
        Me.LblNombredoc_terce.Size = New System.Drawing.Size(75, 15)
        Me.LblNombredoc_terce.TabIndex = 2
        Me.LblNombredoc_terce.Text = "Nombre doc"
        '
        'LblNombre1_terce
        '
        Me.LblNombre1_terce.AutoSize = True
        Me.LblNombre1_terce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre1_terce.Location = New System.Drawing.Point(6, 59)
        Me.LblNombre1_terce.Name = "LblNombre1_terce"
        Me.LblNombre1_terce.Size = New System.Drawing.Size(61, 15)
        Me.LblNombre1_terce.TabIndex = 3
        Me.LblNombre1_terce.Text = "Nombres:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lblubica)
        Me.GroupBox3.Controls.Add(Me.Lblconcide_pass)
        Me.GroupBox3.Controls.Add(Me.CBPerfil_usuario)
        Me.GroupBox3.Controls.Add(Me.CBUbica_Usuarios)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.CBEstado_Usuarios)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Txt_usuario_usua)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.LblSimilitud)
        Me.GroupBox3.Controls.Add(Me.LblFuerzaContraseña_perfil)
        Me.GroupBox3.Controls.Add(Me.Txtconfirmacontraseña_perfil)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtContraseña_perfil)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.LblPerfil)
        Me.GroupBox3.Controls.Add(Me.LblPerfildes)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(436, 213)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seguridad"
        '
        'Lblubica
        '
        Me.Lblubica.AutoSize = True
        Me.Lblubica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblubica.Location = New System.Drawing.Point(149, 87)
        Me.Lblubica.Name = "Lblubica"
        Me.Lblubica.Size = New System.Drawing.Size(0, 15)
        Me.Lblubica.TabIndex = 32
        '
        'Lblconcide_pass
        '
        Me.Lblconcide_pass.AutoSize = True
        Me.Lblconcide_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblconcide_pass.Location = New System.Drawing.Point(88, 185)
        Me.Lblconcide_pass.Name = "Lblconcide_pass"
        Me.Lblconcide_pass.Size = New System.Drawing.Size(139, 15)
        Me.Lblconcide_pass.TabIndex = 31
        Me.Lblconcide_pass.Text = "Concidencia contraseña"
        '
        'CBPerfil_usuario
        '
        Me.CBPerfil_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPerfil_usuario.FormattingEnabled = True
        Me.CBPerfil_usuario.Location = New System.Drawing.Point(88, 55)
        Me.CBPerfil_usuario.Name = "CBPerfil_usuario"
        Me.CBPerfil_usuario.Size = New System.Drawing.Size(59, 23)
        Me.CBPerfil_usuario.TabIndex = 3
        '
        'CBUbica_Usuarios
        '
        Me.CBUbica_Usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUbica_Usuarios.FormattingEnabled = True
        Me.CBUbica_Usuarios.Location = New System.Drawing.Point(88, 83)
        Me.CBUbica_Usuarios.Name = "CBUbica_Usuarios"
        Me.CBUbica_Usuarios.Size = New System.Drawing.Size(59, 23)
        Me.CBUbica_Usuarios.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(253, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Estado :"
        '
        'CBEstado_Usuarios
        '
        Me.CBEstado_Usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEstado_Usuarios.ForeColor = System.Drawing.Color.Green
        Me.CBEstado_Usuarios.FormattingEnabled = True
        Me.CBEstado_Usuarios.Location = New System.Drawing.Point(310, 84)
        Me.CBEstado_Usuarios.Name = "CBEstado_Usuarios"
        Me.CBEstado_Usuarios.Size = New System.Drawing.Size(38, 23)
        Me.CBEstado_Usuarios.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ubicación :"
        '
        'Txt_usuario_usua
        '
        Me.Txt_usuario_usua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_usuario_usua.Location = New System.Drawing.Point(110, 29)
        Me.Txt_usuario_usua.Name = "Txt_usuario_usua"
        Me.Txt_usuario_usua.Size = New System.Drawing.Size(313, 21)
        Me.Txt_usuario_usua.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre usuario :"
        '
        'LblSimilitud
        '
        Me.LblSimilitud.AutoSize = True
        Me.LblSimilitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSimilitud.Location = New System.Drawing.Point(31, 149)
        Me.LblSimilitud.Name = "LblSimilitud"
        Me.LblSimilitud.Size = New System.Drawing.Size(0, 15)
        Me.LblSimilitud.TabIndex = 18
        '
        'LblFuerzaContraseña_perfil
        '
        Me.LblFuerzaContraseña_perfil.AutoSize = True
        Me.LblFuerzaContraseña_perfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFuerzaContraseña_perfil.Location = New System.Drawing.Point(88, 141)
        Me.LblFuerzaContraseña_perfil.Name = "LblFuerzaContraseña_perfil"
        Me.LblFuerzaContraseña_perfil.Size = New System.Drawing.Size(109, 15)
        Me.LblFuerzaContraseña_perfil.TabIndex = 17
        Me.LblFuerzaContraseña_perfil.Text = "Fuerza contraseña"
        '
        'Txtconfirmacontraseña_perfil
        '
        Me.Txtconfirmacontraseña_perfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtconfirmacontraseña_perfil.Location = New System.Drawing.Point(88, 163)
        Me.Txtconfirmacontraseña_perfil.Name = "Txtconfirmacontraseña_perfil"
        Me.Txtconfirmacontraseña_perfil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtconfirmacontraseña_perfil.Size = New System.Drawing.Size(335, 21)
        Me.Txtconfirmacontraseña_perfil.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 30)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Confirmar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contraseña :"
        '
        'TxtContraseña_perfil
        '
        Me.TxtContraseña_perfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña_perfil.Location = New System.Drawing.Point(88, 117)
        Me.TxtContraseña_perfil.Name = "TxtContraseña_perfil"
        Me.TxtContraseña_perfil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña_perfil.Size = New System.Drawing.Size(335, 21)
        Me.TxtContraseña_perfil.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña :"
        '
        'LblPerfil
        '
        Me.LblPerfil.AutoSize = True
        Me.LblPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPerfil.Location = New System.Drawing.Point(6, 58)
        Me.LblPerfil.Name = "LblPerfil"
        Me.LblPerfil.Size = New System.Drawing.Size(41, 15)
        Me.LblPerfil.TabIndex = 2
        Me.LblPerfil.Text = "Perfil :"
        '
        'LblPerfildes
        '
        Me.LblPerfildes.AutoSize = True
        Me.LblPerfildes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPerfildes.Location = New System.Drawing.Point(153, 58)
        Me.LblPerfildes.Name = "LblPerfildes"
        Me.LblPerfildes.Size = New System.Drawing.Size(0, 15)
        Me.LblPerfildes.TabIndex = 4
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 448)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCorreo_usua As System.Windows.Forms.TextBox
    Friend WithEvents LblCorreo_terce As System.Windows.Forms.Label
    Friend WithEvents TxtCelular As System.Windows.Forms.TextBox
    Friend WithEvents LblCelular_terce As System.Windows.Forms.Label
    Friend WithEvents TxtTelefono_usua As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefono_terce As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtApellido2_usua As System.Windows.Forms.TextBox
    Friend WithEvents Txtapellido1_usua As System.Windows.Forms.TextBox
    Friend WithEvents LblApellidos_terce As System.Windows.Forms.Label
    Friend WithEvents TxtNombre2_terce As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre1_terce As System.Windows.Forms.TextBox
    Friend WithEvents TxtTercero_usua As System.Windows.Forms.TextBox
    Friend WithEvents LblCodigo_terce As System.Windows.Forms.Label
    Friend WithEvents LblNombredoc_terce As System.Windows.Forms.Label
    Friend WithEvents LblNombre1_terce As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblSimilitud As System.Windows.Forms.Label
    Friend WithEvents LblFuerzaContraseña_perfil As System.Windows.Forms.Label
    Friend WithEvents Txtconfirmacontraseña_perfil As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtContraseña_perfil As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblPerfil As System.Windows.Forms.Label
    Friend WithEvents LblPerfildes As System.Windows.Forms.Label
    Friend WithEvents Txt_usuario_usua As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBEstado_Usuarios As System.Windows.Forms.ComboBox
    Friend WithEvents CBPerfil_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents CBUbica_Usuarios As System.Windows.Forms.ComboBox
    Friend WithEvents Lblconcide_pass As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lblubica As System.Windows.Forms.Label
End Class

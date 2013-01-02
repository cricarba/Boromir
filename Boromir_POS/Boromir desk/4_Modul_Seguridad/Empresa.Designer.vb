<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empresa))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_nit = New System.Windows.Forms.TextBox()
        Me.TxtCelular_ubica = New System.Windows.Forms.TextBox()
        Me.LblNombre_ubica = New System.Windows.Forms.Label()
        Me.TxtTelefono_ubica = New System.Windows.Forms.TextBox()
        Me.LblTelefono_ubica = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.LblDireccion_ubica = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblCelular_ubica = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TxtReportes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtManuales = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtRutaimgpro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBtnHotmail = New System.Windows.Forms.RadioButton()
        Me.RBtnGmail = New System.Windows.Forms.RadioButton()
        Me.TxtCorreo_Ubica = New System.Windows.Forms.TextBox()
        Me.LblCorreo_ubica = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxTclave = New System.Windows.Forms.TextBox()
        Me.Txtpuerto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtsmpt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Imagen = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtresolucion = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_nit)
        Me.GroupBox1.Controls.Add(Me.TxtCelular_ubica)
        Me.GroupBox1.Controls.Add(Me.LblNombre_ubica)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono_ubica)
        Me.GroupBox1.Controls.Add(Me.LblTelefono_ubica)
        Me.GroupBox1.Controls.Add(Me.TxtDireccion)
        Me.GroupBox1.Controls.Add(Me.LblDireccion_ubica)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.LblCelular_ubica)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 146)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Basicos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(11, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nit:"
        '
        'Txt_nit
        '
        Me.Txt_nit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Txt_nit.Location = New System.Drawing.Point(79, 50)
        Me.Txt_nit.Name = "Txt_nit"
        Me.Txt_nit.Size = New System.Drawing.Size(283, 20)
        Me.Txt_nit.TabIndex = 7
        '
        'TxtCelular_ubica
        '
        Me.TxtCelular_ubica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCelular_ubica.Location = New System.Drawing.Point(254, 115)
        Me.TxtCelular_ubica.MaxLength = 10
        Me.TxtCelular_ubica.Name = "TxtCelular_ubica"
        Me.TxtCelular_ubica.Size = New System.Drawing.Size(108, 20)
        Me.TxtCelular_ubica.TabIndex = 3
        '
        'LblNombre_ubica
        '
        Me.LblNombre_ubica.AutoSize = True
        Me.LblNombre_ubica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre_ubica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblNombre_ubica.Location = New System.Drawing.Point(11, 25)
        Me.LblNombre_ubica.Name = "LblNombre_ubica"
        Me.LblNombre_ubica.Size = New System.Drawing.Size(55, 15)
        Me.LblNombre_ubica.TabIndex = 4
        Me.LblNombre_ubica.Text = "Nombre:"
        '
        'TxtTelefono_ubica
        '
        Me.TxtTelefono_ubica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtTelefono_ubica.Location = New System.Drawing.Point(80, 112)
        Me.TxtTelefono_ubica.MaxLength = 7
        Me.TxtTelefono_ubica.Name = "TxtTelefono_ubica"
        Me.TxtTelefono_ubica.Size = New System.Drawing.Size(114, 20)
        Me.TxtTelefono_ubica.TabIndex = 1
        '
        'LblTelefono_ubica
        '
        Me.LblTelefono_ubica.AutoSize = True
        Me.LblTelefono_ubica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono_ubica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTelefono_ubica.Location = New System.Drawing.Point(13, 113)
        Me.LblTelefono_ubica.Name = "LblTelefono_ubica"
        Me.LblTelefono_ubica.Size = New System.Drawing.Size(58, 15)
        Me.LblTelefono_ubica.TabIndex = 0
        Me.LblTelefono_ubica.Text = "Telefono:"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtDireccion.Location = New System.Drawing.Point(80, 76)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(283, 20)
        Me.TxtDireccion.TabIndex = 9
        '
        'LblDireccion_ubica
        '
        Me.LblDireccion_ubica.AutoSize = True
        Me.LblDireccion_ubica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion_ubica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblDireccion_ubica.Location = New System.Drawing.Point(13, 77)
        Me.LblDireccion_ubica.Name = "LblDireccion_ubica"
        Me.LblDireccion_ubica.Size = New System.Drawing.Size(65, 15)
        Me.LblDireccion_ubica.TabIndex = 8
        Me.LblDireccion_ubica.Text = "Direccion: "
        '
        'TxtNombre
        '
        Me.TxtNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtNombre.Location = New System.Drawing.Point(79, 24)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(283, 20)
        Me.TxtNombre.TabIndex = 5
        '
        'LblCelular_ubica
        '
        Me.LblCelular_ubica.AutoSize = True
        Me.LblCelular_ubica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCelular_ubica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblCelular_ubica.Location = New System.Drawing.Point(201, 115)
        Me.LblCelular_ubica.Name = "LblCelular_ubica"
        Me.LblCelular_ubica.Size = New System.Drawing.Size(49, 15)
        Me.LblCelular_ubica.TabIndex = 2
        Me.LblCelular_ubica.Text = "Celular:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.TxtReportes)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.TxtManuales)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TxtRutaimgpro)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 147)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Carpetas"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(357, 119)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(23, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TxtReportes
        '
        Me.TxtReportes.Location = New System.Drawing.Point(6, 121)
        Me.TxtReportes.Name = "TxtReportes"
        Me.TxtReportes.Size = New System.Drawing.Size(346, 20)
        Me.TxtReportes.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ruta Carpeta Reportes"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(357, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtManuales
        '
        Me.TxtManuales.Location = New System.Drawing.Point(6, 82)
        Me.TxtManuales.Name = "TxtManuales"
        Me.TxtManuales.Size = New System.Drawing.Size(346, 20)
        Me.TxtManuales.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ruta Carpeta Manuales"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(357, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtRutaimgpro
        '
        Me.TxtRutaimgpro.Location = New System.Drawing.Point(6, 43)
        Me.TxtRutaimgpro.Name = "TxtRutaimgpro"
        Me.TxtRutaimgpro.Size = New System.Drawing.Size(347, 20)
        Me.TxtRutaimgpro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ruta Carpeta Imagenes Productos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RBtnHotmail)
        Me.GroupBox3.Controls.Add(Me.RBtnGmail)
        Me.GroupBox3.Controls.Add(Me.TxtCorreo_Ubica)
        Me.GroupBox3.Controls.Add(Me.LblCorreo_ubica)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxTclave)
        Me.GroupBox3.Controls.Add(Me.Txtpuerto)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Txtsmpt)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 317)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(382, 156)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Correos"
        '
        'RBtnHotmail
        '
        Me.RBtnHotmail.AutoSize = True
        Me.RBtnHotmail.Location = New System.Drawing.Point(135, 19)
        Me.RBtnHotmail.Name = "RBtnHotmail"
        Me.RBtnHotmail.Size = New System.Drawing.Size(60, 17)
        Me.RBtnHotmail.TabIndex = 9
        Me.RBtnHotmail.TabStop = True
        Me.RBtnHotmail.Text = "Hotmail"
        Me.RBtnHotmail.UseVisualStyleBackColor = True
        '
        'RBtnGmail
        '
        Me.RBtnGmail.AutoSize = True
        Me.RBtnGmail.Location = New System.Drawing.Point(78, 19)
        Me.RBtnGmail.Name = "RBtnGmail"
        Me.RBtnGmail.Size = New System.Drawing.Size(51, 17)
        Me.RBtnGmail.TabIndex = 8
        Me.RBtnGmail.TabStop = True
        Me.RBtnGmail.Text = "Gmail"
        Me.RBtnGmail.UseVisualStyleBackColor = True
        '
        'TxtCorreo_Ubica
        '
        Me.TxtCorreo_Ubica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCorreo_Ubica.Location = New System.Drawing.Point(79, 44)
        Me.TxtCorreo_Ubica.Name = "TxtCorreo_Ubica"
        Me.TxtCorreo_Ubica.Size = New System.Drawing.Size(283, 20)
        Me.TxtCorreo_Ubica.TabIndex = 1
        '
        'LblCorreo_ubica
        '
        Me.LblCorreo_ubica.AutoSize = True
        Me.LblCorreo_ubica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo_ubica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblCorreo_ubica.Location = New System.Drawing.Point(12, 42)
        Me.LblCorreo_ubica.Name = "LblCorreo_ubica"
        Me.LblCorreo_ubica.Size = New System.Drawing.Size(47, 15)
        Me.LblCorreo_ubica.TabIndex = 0
        Me.LblCorreo_ubica.Text = "Correo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(10, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Clave:"
        '
        'TxTclave
        '
        Me.TxTclave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxTclave.Location = New System.Drawing.Point(78, 70)
        Me.TxTclave.Name = "TxTclave"
        Me.TxTclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxTclave.Size = New System.Drawing.Size(284, 20)
        Me.TxTclave.TabIndex = 3
        '
        'Txtpuerto
        '
        Me.Txtpuerto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Txtpuerto.Location = New System.Drawing.Point(78, 128)
        Me.Txtpuerto.MaxLength = 10
        Me.Txtpuerto.Name = "Txtpuerto"
        Me.Txtpuerto.Size = New System.Drawing.Size(102, 20)
        Me.Txtpuerto.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(13, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Puerto:"
        '
        'Txtsmpt
        '
        Me.Txtsmpt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Txtsmpt.Location = New System.Drawing.Point(79, 96)
        Me.Txtsmpt.Name = "Txtsmpt"
        Me.Txtsmpt.Size = New System.Drawing.Size(284, 20)
        Me.Txtsmpt.TabIndex = 5
        Me.Txtsmpt.Text = "smtp."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(12, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "smtp: "
        '
        'Imagen
        '
        Me.Imagen.FileName = "OpenFileDialog1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Txtresolucion)
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(400, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(221, 96)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Aplicaciones Touch"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(6, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Resolucion DIAN"
        '
        'Txtresolucion
        '
        Me.Txtresolucion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Txtresolucion.Location = New System.Drawing.Point(6, 69)
        Me.Txtresolucion.Name = "Txtresolucion"
        Me.Txtresolucion.Size = New System.Drawing.Size(206, 20)
        Me.Txtresolucion.TabIndex = 6
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Facturacion"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 503)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Empresa"
        Me.Text = "Empresa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtRutaimgpro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TxtManuales As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCelular_ubica As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre_ubica As System.Windows.Forms.Label
    Friend WithEvents TxtTelefono_ubica As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefono_ubica As System.Windows.Forms.Label
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents LblDireccion_ubica As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblCelular_ubica As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_nit As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxTclave As System.Windows.Forms.TextBox
    Friend WithEvents Txtpuerto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txtsmpt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCorreo_Ubica As System.Windows.Forms.TextBox
    Friend WithEvents LblCorreo_ubica As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TxtReportes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RBtnGmail As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnHotmail As System.Windows.Forms.RadioButton
    Friend WithEvents Imagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txtresolucion As System.Windows.Forms.TextBox
End Class

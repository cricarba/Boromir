<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio_Sesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio_Sesion))
        Me.TxtUsusario_usuario = New System.Windows.Forms.TextBox()
        Me.TxtContraseña_usuario = New System.Windows.Forms.TextBox()
        Me.LblUsuario_usuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtUbicacion_usuario = New System.Windows.Forms.TextBox()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.CBServer = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TxtUsusario_usuario
        '
        Me.TxtUsusario_usuario.Location = New System.Drawing.Point(92, 23)
        Me.TxtUsusario_usuario.Name = "TxtUsusario_usuario"
        Me.TxtUsusario_usuario.Size = New System.Drawing.Size(174, 20)
        Me.TxtUsusario_usuario.TabIndex = 0
        '
        'TxtContraseña_usuario
        '
        Me.TxtContraseña_usuario.Location = New System.Drawing.Point(92, 49)
        Me.TxtContraseña_usuario.Name = "TxtContraseña_usuario"
        Me.TxtContraseña_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña_usuario.Size = New System.Drawing.Size(174, 20)
        Me.TxtContraseña_usuario.TabIndex = 1
        '
        'LblUsuario_usuario
        '
        Me.LblUsuario_usuario.AutoSize = True
        Me.LblUsuario_usuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario_usuario.Location = New System.Drawing.Point(12, 26)
        Me.LblUsuario_usuario.Name = "LblUsuario_usuario"
        Me.LblUsuario_usuario.Size = New System.Drawing.Size(56, 15)
        Me.LblUsuario_usuario.TabIndex = 6
        Me.LblUsuario_usuario.Text = "Usuario :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ubicacion :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Contraseña :"
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(92, 114)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnIngresar.TabIndex = 4
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(173, 114)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TxtUbicacion_usuario
        '
        Me.TxtUbicacion_usuario.Location = New System.Drawing.Point(92, 78)
        Me.TxtUbicacion_usuario.Name = "TxtUbicacion_usuario"
        Me.TxtUbicacion_usuario.Size = New System.Drawing.Size(44, 20)
        Me.TxtUbicacion_usuario.TabIndex = 2
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersion.Location = New System.Drawing.Point(12, 119)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(42, 13)
        Me.LabelVersion.TabIndex = 9
        Me.LabelVersion.Text = "Version"
        '
        'CBServer
        '
        Me.CBServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBServer.FormattingEnabled = True
        Me.CBServer.Items.AddRange(New Object() {"Boromir", "Default"})
        Me.CBServer.Location = New System.Drawing.Point(145, 78)
        Me.CBServer.Name = "CBServer"
        Me.CBServer.Size = New System.Drawing.Size(121, 21)
        Me.CBServer.Sorted = True
        Me.CBServer.TabIndex = 3
        '
        'Inicio_Sesion
        '
        Me.AcceptButton = Me.BtnIngresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.BtnCancelar
        Me.ClientSize = New System.Drawing.Size(275, 144)
        Me.Controls.Add(Me.CBServer)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.TxtUbicacion_usuario)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblUsuario_usuario)
        Me.Controls.Add(Me.TxtContraseña_usuario)
        Me.Controls.Add(Me.TxtUsusario_usuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Inicio_Sesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio Sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtUsusario_usuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtContraseña_usuario As System.Windows.Forms.TextBox
    Friend WithEvents LblUsuario_usuario As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnIngresar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents TxtUbicacion_usuario As System.Windows.Forms.TextBox
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents CBServer As System.Windows.Forms.ComboBox
End Class

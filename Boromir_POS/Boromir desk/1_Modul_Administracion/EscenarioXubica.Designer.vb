<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EscenarioXubica
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.LblUbica = New System.Windows.Forms.Label()
        Me.CBtcosto_EXU = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBTipo_EXU = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBUbic_EXU = New System.Windows.Forms.ComboBox()
        Me.CBEstado_EXU = New System.Windows.Forms.ComboBox()
        Me.LblEstado_EXU = New System.Windows.Forms.Label()
        Me.TxtNombre_EXU = New System.Windows.Forms.TextBox()
        Me.LblNombre_EXU = New System.Windows.Forms.Label()
        Me.LblCodigo_EXU = New System.Windows.Forms.Label()
        Me.TxtCodigo_EXU = New System.Windows.Forms.TextBox()
        Me.LblUbicacion_EXU = New System.Windows.Forms.Label()
        Me.LblTipoCosto = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblEstado)
        Me.GroupBox1.Controls.Add(Me.LblTipoCosto)
        Me.GroupBox1.Controls.Add(Me.LblTipo)
        Me.GroupBox1.Controls.Add(Me.LblUbica)
        Me.GroupBox1.Controls.Add(Me.CBtcosto_EXU)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CBTipo_EXU)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CBUbic_EXU)
        Me.GroupBox1.Controls.Add(Me.CBEstado_EXU)
        Me.GroupBox1.Controls.Add(Me.LblEstado_EXU)
        Me.GroupBox1.Controls.Add(Me.TxtNombre_EXU)
        Me.GroupBox1.Controls.Add(Me.LblNombre_EXU)
        Me.GroupBox1.Controls.Add(Me.LblCodigo_EXU)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo_EXU)
        Me.GroupBox1.Controls.Add(Me.LblUbicacion_EXU)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asignar Escenario"
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipo.Location = New System.Drawing.Point(130, 61)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(0, 15)
        Me.LblTipo.TabIndex = 13
        '
        'LblUbica
        '
        Me.LblUbica.AutoSize = True
        Me.LblUbica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbica.Location = New System.Drawing.Point(130, 32)
        Me.LblUbica.Name = "LblUbica"
        Me.LblUbica.Size = New System.Drawing.Size(0, 15)
        Me.LblUbica.TabIndex = 12
        '
        'CBtcosto_EXU
        '
        Me.CBtcosto_EXU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBtcosto_EXU.FormattingEnabled = True
        Me.CBtcosto_EXU.Location = New System.Drawing.Point(85, 87)
        Me.CBtcosto_EXU.Name = "CBtcosto_EXU"
        Me.CBtcosto_EXU.Size = New System.Drawing.Size(39, 23)
        Me.CBtcosto_EXU.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tipo Costo :"
        '
        'CBTipo_EXU
        '
        Me.CBTipo_EXU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTipo_EXU.FormattingEnabled = True
        Me.CBTipo_EXU.Location = New System.Drawing.Point(81, 58)
        Me.CBTipo_EXU.Name = "CBTipo_EXU"
        Me.CBTipo_EXU.Size = New System.Drawing.Size(43, 23)
        Me.CBTipo_EXU.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo :"
        '
        'CBUbic_EXU
        '
        Me.CBUbic_EXU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUbic_EXU.FormattingEnabled = True
        Me.CBUbic_EXU.Location = New System.Drawing.Point(81, 29)
        Me.CBUbic_EXU.Name = "CBUbic_EXU"
        Me.CBUbic_EXU.Size = New System.Drawing.Size(43, 23)
        Me.CBUbic_EXU.TabIndex = 1
        '
        'CBEstado_EXU
        '
        Me.CBEstado_EXU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEstado_EXU.FormattingEnabled = True
        Me.CBEstado_EXU.Location = New System.Drawing.Point(81, 185)
        Me.CBEstado_EXU.Name = "CBEstado_EXU"
        Me.CBEstado_EXU.Size = New System.Drawing.Size(43, 23)
        Me.CBEstado_EXU.TabIndex = 11
        '
        'LblEstado_EXU
        '
        Me.LblEstado_EXU.AutoSize = True
        Me.LblEstado_EXU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado_EXU.Location = New System.Drawing.Point(7, 188)
        Me.LblEstado_EXU.Name = "LblEstado_EXU"
        Me.LblEstado_EXU.Size = New System.Drawing.Size(51, 15)
        Me.LblEstado_EXU.TabIndex = 10
        Me.LblEstado_EXU.Text = "Estado :"
        '
        'TxtNombre_EXU
        '
        Me.TxtNombre_EXU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre_EXU.Location = New System.Drawing.Point(81, 148)
        Me.TxtNombre_EXU.Name = "TxtNombre_EXU"
        Me.TxtNombre_EXU.Size = New System.Drawing.Size(283, 21)
        Me.TxtNombre_EXU.TabIndex = 9
        '
        'LblNombre_EXU
        '
        Me.LblNombre_EXU.AutoSize = True
        Me.LblNombre_EXU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre_EXU.Location = New System.Drawing.Point(7, 154)
        Me.LblNombre_EXU.Name = "LblNombre_EXU"
        Me.LblNombre_EXU.Size = New System.Drawing.Size(58, 15)
        Me.LblNombre_EXU.TabIndex = 8
        Me.LblNombre_EXU.Text = "Nombre :"
        '
        'LblCodigo_EXU
        '
        Me.LblCodigo_EXU.AutoSize = True
        Me.LblCodigo_EXU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo_EXU.Location = New System.Drawing.Point(7, 124)
        Me.LblCodigo_EXU.Name = "LblCodigo_EXU"
        Me.LblCodigo_EXU.Size = New System.Drawing.Size(52, 15)
        Me.LblCodigo_EXU.TabIndex = 6
        Me.LblCodigo_EXU.Text = "Codigo :"
        '
        'TxtCodigo_EXU
        '
        Me.TxtCodigo_EXU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo_EXU.Location = New System.Drawing.Point(81, 121)
        Me.TxtCodigo_EXU.MaxLength = 1
        Me.TxtCodigo_EXU.Name = "TxtCodigo_EXU"
        Me.TxtCodigo_EXU.Size = New System.Drawing.Size(65, 21)
        Me.TxtCodigo_EXU.TabIndex = 7
        '
        'LblUbicacion_EXU
        '
        Me.LblUbicacion_EXU.AutoSize = True
        Me.LblUbicacion_EXU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbicacion_EXU.Location = New System.Drawing.Point(7, 32)
        Me.LblUbicacion_EXU.Name = "LblUbicacion_EXU"
        Me.LblUbicacion_EXU.Size = New System.Drawing.Size(68, 15)
        Me.LblUbicacion_EXU.TabIndex = 0
        Me.LblUbicacion_EXU.Text = "Ubicacion :"
        '
        'LblTipoCosto
        '
        Me.LblTipoCosto.AutoSize = True
        Me.LblTipoCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoCosto.Location = New System.Drawing.Point(130, 90)
        Me.LblTipoCosto.Name = "LblTipoCosto"
        Me.LblTipoCosto.Size = New System.Drawing.Size(0, 15)
        Me.LblTipoCosto.TabIndex = 14
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(130, 188)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(0, 15)
        Me.LblEstado.TabIndex = 15
        '
        'EscenarioXubica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 240)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EscenarioXubica"
        Me.Text = "EscenarioXubica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBEstado_EXU As System.Windows.Forms.ComboBox
    Friend WithEvents LblEstado_EXU As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_EXU As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre_EXU As System.Windows.Forms.Label
    Friend WithEvents LblCodigo_EXU As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo_EXU As System.Windows.Forms.TextBox
    Friend WithEvents LblUbicacion_EXU As System.Windows.Forms.Label
    Friend WithEvents CBUbic_EXU As System.Windows.Forms.ComboBox
    Friend WithEvents CBTipo_EXU As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBtcosto_EXU As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblTipo As System.Windows.Forms.Label
    Friend WithEvents LblUbica As System.Windows.Forms.Label
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents LblTipoCosto As System.Windows.Forms.Label
End Class

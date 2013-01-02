<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zonas
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
        Me.Lblciudad = New System.Windows.Forms.Label()
        Me.Txtciudad_zona = New System.Windows.Forms.ComboBox()
        Me.TxtNombre_Zona = New System.Windows.Forms.TextBox()
        Me.TxtCodigo_Zona = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblCodigo_ciudad = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lblciudad)
        Me.GroupBox1.Controls.Add(Me.Txtciudad_zona)
        Me.GroupBox1.Controls.Add(Me.TxtNombre_Zona)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo_Zona)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblCodigo_ciudad)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maestro de Zonas"
        '
        'Lblciudad
        '
        Me.Lblciudad.AutoSize = True
        Me.Lblciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblciudad.Location = New System.Drawing.Point(109, 39)
        Me.Lblciudad.Name = "Lblciudad"
        Me.Lblciudad.Size = New System.Drawing.Size(0, 15)
        Me.Lblciudad.TabIndex = 6
        '
        'Txtciudad_zona
        '
        Me.Txtciudad_zona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtciudad_zona.FormattingEnabled = True
        Me.Txtciudad_zona.Location = New System.Drawing.Point(66, 36)
        Me.Txtciudad_zona.Name = "Txtciudad_zona"
        Me.Txtciudad_zona.Size = New System.Drawing.Size(37, 21)
        Me.Txtciudad_zona.TabIndex = 1
        '
        'TxtNombre_Zona
        '
        Me.TxtNombre_Zona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre_Zona.Location = New System.Drawing.Point(66, 93)
        Me.TxtNombre_Zona.Name = "TxtNombre_Zona"
        Me.TxtNombre_Zona.Size = New System.Drawing.Size(263, 20)
        Me.TxtNombre_Zona.TabIndex = 5
        '
        'TxtCodigo_Zona
        '
        Me.TxtCodigo_Zona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo_Zona.Location = New System.Drawing.Point(67, 66)
        Me.TxtCodigo_Zona.Name = "TxtCodigo_Zona"
        Me.TxtCodigo_Zona.Size = New System.Drawing.Size(37, 20)
        Me.TxtCodigo_Zona.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo :"
        '
        'LblCodigo_ciudad
        '
        Me.LblCodigo_ciudad.AutoSize = True
        Me.LblCodigo_ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo_ciudad.Location = New System.Drawing.Point(11, 39)
        Me.LblCodigo_ciudad.Name = "LblCodigo_ciudad"
        Me.LblCodigo_ciudad.Size = New System.Drawing.Size(49, 15)
        Me.LblCodigo_ciudad.TabIndex = 0
        Me.LblCodigo_ciudad.Text = "Ciudad:"
        '
        'Zonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 153)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Zonas"
        Me.Text = "Zonas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblCodigo_ciudad As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_Zona As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo_Zona As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtciudad_zona As System.Windows.Forms.ComboBox
    Friend WithEvents Lblciudad As System.Windows.Forms.Label
End Class

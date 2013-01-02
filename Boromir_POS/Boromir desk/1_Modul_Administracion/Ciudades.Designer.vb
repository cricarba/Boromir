<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ciudades
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
        Me.TxtNombre_ciudad = New System.Windows.Forms.TextBox()
        Me.TxtCodigo_ciudad = New System.Windows.Forms.TextBox()
        Me.LblNombre_ciudad = New System.Windows.Forms.Label()
        Me.LblCodigo_ciudad = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNombre_ciudad)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo_ciudad)
        Me.GroupBox1.Controls.Add(Me.LblNombre_ciudad)
        Me.GroupBox1.Controls.Add(Me.LblCodigo_ciudad)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 87)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maestro de Ciudades"
        '
        'TxtNombre_ciudad
        '
        Me.TxtNombre_ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre_ciudad.Location = New System.Drawing.Point(74, 59)
        Me.TxtNombre_ciudad.Name = "TxtNombre_ciudad"
        Me.TxtNombre_ciudad.Size = New System.Drawing.Size(180, 21)
        Me.TxtNombre_ciudad.TabIndex = 1
        '
        'TxtCodigo_ciudad
        '
        Me.TxtCodigo_ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo_ciudad.Location = New System.Drawing.Point(74, 27)
        Me.TxtCodigo_ciudad.MaxLength = 2
        Me.TxtCodigo_ciudad.Name = "TxtCodigo_ciudad"
        Me.TxtCodigo_ciudad.Size = New System.Drawing.Size(28, 21)
        Me.TxtCodigo_ciudad.TabIndex = 0
        '
        'LblNombre_ciudad
        '
        Me.LblNombre_ciudad.AutoSize = True
        Me.LblNombre_ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre_ciudad.Location = New System.Drawing.Point(16, 62)
        Me.LblNombre_ciudad.Name = "LblNombre_ciudad"
        Me.LblNombre_ciudad.Size = New System.Drawing.Size(52, 15)
        Me.LblNombre_ciudad.TabIndex = 1
        Me.LblNombre_ciudad.Text = "Nombre"
        '
        'LblCodigo_ciudad
        '
        Me.LblCodigo_ciudad.AutoSize = True
        Me.LblCodigo_ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo_ciudad.Location = New System.Drawing.Point(17, 27)
        Me.LblCodigo_ciudad.Name = "LblCodigo_ciudad"
        Me.LblCodigo_ciudad.Size = New System.Drawing.Size(52, 15)
        Me.LblCodigo_ciudad.TabIndex = 0
        Me.LblCodigo_ciudad.Text = "Codigo :"
        '
        'Ciudades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 111)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Ciudades"
        Me.Text = "Ciudades"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNombre_ciudad As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo_ciudad As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre_ciudad As System.Windows.Forms.Label
    Friend WithEvents LblCodigo_ciudad As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_Escenarios
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
        Me.TxtNombre_cancha = New System.Windows.Forms.TextBox()
        Me.TxtCodigo_cancha = New System.Windows.Forms.TextBox()
        Me.LblNombre_cancha = New System.Windows.Forms.Label()
        Me.LblCodigo_cancha = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNombre_cancha)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo_cancha)
        Me.GroupBox1.Controls.Add(Me.LblNombre_cancha)
        Me.GroupBox1.Controls.Add(Me.LblCodigo_cancha)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maestro de Escenarios"
        '
        'TxtNombre_cancha
        '
        Me.TxtNombre_cancha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre_cancha.Location = New System.Drawing.Point(63, 61)
        Me.TxtNombre_cancha.Name = "TxtNombre_cancha"
        Me.TxtNombre_cancha.Size = New System.Drawing.Size(202, 21)
        Me.TxtNombre_cancha.TabIndex = 3
        '
        'TxtCodigo_cancha
        '
        Me.TxtCodigo_cancha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo_cancha.Location = New System.Drawing.Point(63, 31)
        Me.TxtCodigo_cancha.MaxLength = 2
        Me.TxtCodigo_cancha.Name = "TxtCodigo_cancha"
        Me.TxtCodigo_cancha.Size = New System.Drawing.Size(43, 21)
        Me.TxtCodigo_cancha.TabIndex = 1
        '
        'LblNombre_cancha
        '
        Me.LblNombre_cancha.AutoSize = True
        Me.LblNombre_cancha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre_cancha.Location = New System.Drawing.Point(5, 64)
        Me.LblNombre_cancha.Name = "LblNombre_cancha"
        Me.LblNombre_cancha.Size = New System.Drawing.Size(52, 15)
        Me.LblNombre_cancha.TabIndex = 2
        Me.LblNombre_cancha.Text = "Nombre"
        '
        'LblCodigo_cancha
        '
        Me.LblCodigo_cancha.AutoSize = True
        Me.LblCodigo_cancha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo_cancha.Location = New System.Drawing.Point(6, 31)
        Me.LblCodigo_cancha.Name = "LblCodigo_cancha"
        Me.LblCodigo_cancha.Size = New System.Drawing.Size(52, 15)
        Me.LblCodigo_cancha.TabIndex = 0
        Me.LblCodigo_cancha.Text = "Codigo :"
        '
        'Tipo_Escenarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 121)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Tipo_Escenarios"
        Me.Text = "Tipo Escenarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNombre_cancha As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo_cancha As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre_cancha As System.Windows.Forms.Label
    Friend WithEvents LblCodigo_cancha As System.Windows.Forms.Label
End Class

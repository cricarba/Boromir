<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turnos
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
        Me.TxtHora_Final = New System.Windows.Forms.MaskedTextBox()
        Me.TxtHora_inicio = New System.Windows.Forms.MaskedTextBox()
        Me.CBubic_turnos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre_turno = New System.Windows.Forms.TextBox()
        Me.TxtCodigo_turno = New System.Windows.Forms.TextBox()
        Me.LblNombre_turno = New System.Windows.Forms.Label()
        Me.LblCodigo_turno = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtHora_Final)
        Me.GroupBox1.Controls.Add(Me.TxtHora_inicio)
        Me.GroupBox1.Controls.Add(Me.CBubic_turnos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNombre_turno)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo_turno)
        Me.GroupBox1.Controls.Add(Me.LblNombre_turno)
        Me.GroupBox1.Controls.Add(Me.LblCodigo_turno)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maestro Turnos"
        '
        'TxtHora_Final
        '
        Me.TxtHora_Final.Location = New System.Drawing.Point(218, 83)
        Me.TxtHora_Final.Mask = "00:00"
        Me.TxtHora_Final.Name = "TxtHora_Final"
        Me.TxtHora_Final.Size = New System.Drawing.Size(42, 21)
        Me.TxtHora_Final.TabIndex = 9
        Me.TxtHora_Final.ValidatingType = GetType(Date)
        '
        'TxtHora_inicio
        '
        Me.TxtHora_inicio.Location = New System.Drawing.Point(94, 83)
        Me.TxtHora_inicio.Mask = "00:00"
        Me.TxtHora_inicio.Name = "TxtHora_inicio"
        Me.TxtHora_inicio.Size = New System.Drawing.Size(42, 21)
        Me.TxtHora_inicio.TabIndex = 7
        Me.TxtHora_inicio.ValidatingType = GetType(Date)
        '
        'CBubic_turnos
        '
        Me.CBubic_turnos.FormattingEnabled = True
        Me.CBubic_turnos.Location = New System.Drawing.Point(216, 22)
        Me.CBubic_turnos.Name = "CBubic_turnos"
        Me.CBubic_turnos.Size = New System.Drawing.Size(49, 23)
        Me.CBubic_turnos.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ubicación :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hora Inicio :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Hora Final :"
        '
        'TxtNombre_turno
        '
        Me.TxtNombre_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre_turno.Location = New System.Drawing.Point(94, 54)
        Me.TxtNombre_turno.Name = "TxtNombre_turno"
        Me.TxtNombre_turno.Size = New System.Drawing.Size(171, 21)
        Me.TxtNombre_turno.TabIndex = 5
        '
        'TxtCodigo_turno
        '
        Me.TxtCodigo_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo_turno.Location = New System.Drawing.Point(94, 24)
        Me.TxtCodigo_turno.Name = "TxtCodigo_turno"
        Me.TxtCodigo_turno.Size = New System.Drawing.Size(42, 21)
        Me.TxtCodigo_turno.TabIndex = 1
        '
        'LblNombre_turno
        '
        Me.LblNombre_turno.AutoSize = True
        Me.LblNombre_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre_turno.Location = New System.Drawing.Point(16, 57)
        Me.LblNombre_turno.Name = "LblNombre_turno"
        Me.LblNombre_turno.Size = New System.Drawing.Size(58, 15)
        Me.LblNombre_turno.TabIndex = 4
        Me.LblNombre_turno.Text = "Nombre :"
        '
        'LblCodigo_turno
        '
        Me.LblCodigo_turno.AutoSize = True
        Me.LblCodigo_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo_turno.Location = New System.Drawing.Point(17, 27)
        Me.LblCodigo_turno.Name = "LblCodigo_turno"
        Me.LblCodigo_turno.Size = New System.Drawing.Size(52, 15)
        Me.LblCodigo_turno.TabIndex = 0
        Me.LblCodigo_turno.Text = "Codigo :"
        '
        'Turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 134)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Turnos"
        Me.Text = "Turnos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNombre_turno As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo_turno As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre_turno As System.Windows.Forms.Label
    Friend WithEvents LblCodigo_turno As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBubic_turnos As System.Windows.Forms.ComboBox
    Friend WithEvents TxtHora_Final As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtHora_inicio As System.Windows.Forms.MaskedTextBox
End Class

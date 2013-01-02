<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conceptos
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
        Me.CbAccion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBAplic_concep = New System.Windows.Forms.ComboBox()
        Me.TxtNombre_Concep = New System.Windows.Forms.TextBox()
        Me.TxtCodigo_Concep = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblCodigo_ciudad = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbAccion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CBAplic_concep)
        Me.GroupBox1.Controls.Add(Me.TxtNombre_Concep)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo_Concep)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblCodigo_ciudad)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maestro de Conceptos"
        '
        'CbAccion
        '
        Me.CbAccion.FormattingEnabled = True
        Me.CbAccion.Items.AddRange(New Object() {"SUMA", "RESTA", "NULO"})
        Me.CbAccion.Location = New System.Drawing.Point(81, 110)
        Me.CbAccion.Name = "CbAccion"
        Me.CbAccion.Size = New System.Drawing.Size(184, 23)
        Me.CbAccion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Accion:"
        '
        'CBAplic_concep
        '
        Me.CBAplic_concep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBAplic_concep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBAplic_concep.FormattingEnabled = True
        Me.CBAplic_concep.Location = New System.Drawing.Point(81, 80)
        Me.CBAplic_concep.MaxLength = 5
        Me.CBAplic_concep.Name = "CBAplic_concep"
        Me.CBAplic_concep.Size = New System.Drawing.Size(263, 23)
        Me.CBAplic_concep.Sorted = True
        Me.CBAplic_concep.TabIndex = 5
        '
        'TxtNombre_Concep
        '
        Me.TxtNombre_Concep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre_Concep.Location = New System.Drawing.Point(81, 48)
        Me.TxtNombre_Concep.Name = "TxtNombre_Concep"
        Me.TxtNombre_Concep.Size = New System.Drawing.Size(263, 21)
        Me.TxtNombre_Concep.TabIndex = 3
        '
        'TxtCodigo_Concep
        '
        Me.TxtCodigo_Concep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo_Concep.Location = New System.Drawing.Point(81, 20)
        Me.TxtCodigo_Concep.MaxLength = 2
        Me.TxtCodigo_Concep.Name = "TxtCodigo_Concep"
        Me.TxtCodigo_Concep.Size = New System.Drawing.Size(44, 21)
        Me.TxtCodigo_Concep.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo :"
        '
        'LblCodigo_ciudad
        '
        Me.LblCodigo_ciudad.AutoSize = True
        Me.LblCodigo_ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo_ciudad.Location = New System.Drawing.Point(9, 83)
        Me.LblCodigo_ciudad.Name = "LblCodigo_ciudad"
        Me.LblCodigo_ciudad.Size = New System.Drawing.Size(66, 15)
        Me.LblCodigo_ciudad.TabIndex = 4
        Me.LblCodigo_ciudad.Text = "Aplicacion:"
        '
        'Conceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 173)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Conceptos"
        Me.Text = "Conceptos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNombre_Concep As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo_Concep As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblCodigo_ciudad As System.Windows.Forms.Label
    Friend WithEvents CBAplic_concep As System.Windows.Forms.ComboBox
    Friend WithEvents CbAccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

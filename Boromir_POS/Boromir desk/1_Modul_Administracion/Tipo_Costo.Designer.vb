<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_Costo
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
        Me.LblUbica = New System.Windows.Forms.Label()
        Me.CBubic_tipocost = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxValor_costo = New System.Windows.Forms.TextBox()
        Me.TxtCodigo_costo = New System.Windows.Forms.TextBox()
        Me.LblValor_costo = New System.Windows.Forms.Label()
        Me.LblCodigo_Costo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblUbica)
        Me.GroupBox1.Controls.Add(Me.CBubic_tipocost)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxValor_costo)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo_costo)
        Me.GroupBox1.Controls.Add(Me.LblValor_costo)
        Me.GroupBox1.Controls.Add(Me.LblCodigo_Costo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maestro de Costos"
        '
        'LblUbica
        '
        Me.LblUbica.AutoSize = True
        Me.LblUbica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbica.Location = New System.Drawing.Point(148, 57)
        Me.LblUbica.Name = "LblUbica"
        Me.LblUbica.Size = New System.Drawing.Size(0, 15)
        Me.LblUbica.TabIndex = 6
        '
        'CBubic_tipocost
        '
        Me.CBubic_tipocost.FormattingEnabled = True
        Me.CBubic_tipocost.Location = New System.Drawing.Point(92, 53)
        Me.CBubic_tipocost.Name = "CBubic_tipocost"
        Me.CBubic_tipocost.Size = New System.Drawing.Size(50, 23)
        Me.CBubic_tipocost.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ubicacion :"
        '
        'TxValor_costo
        '
        Me.TxValor_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxValor_costo.Location = New System.Drawing.Point(92, 83)
        Me.TxValor_costo.Name = "TxValor_costo"
        Me.TxValor_costo.Size = New System.Drawing.Size(206, 21)
        Me.TxValor_costo.TabIndex = 5
        '
        'TxtCodigo_costo
        '
        Me.TxtCodigo_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo_costo.Location = New System.Drawing.Point(92, 27)
        Me.TxtCodigo_costo.MaxLength = 1
        Me.TxtCodigo_costo.Name = "TxtCodigo_costo"
        Me.TxtCodigo_costo.Size = New System.Drawing.Size(38, 21)
        Me.TxtCodigo_costo.TabIndex = 1
        '
        'LblValor_costo
        '
        Me.LblValor_costo.AutoSize = True
        Me.LblValor_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor_costo.Location = New System.Drawing.Point(18, 86)
        Me.LblValor_costo.Name = "LblValor_costo"
        Me.LblValor_costo.Size = New System.Drawing.Size(41, 15)
        Me.LblValor_costo.TabIndex = 4
        Me.LblValor_costo.Text = "Valor :"
        '
        'LblCodigo_Costo
        '
        Me.LblCodigo_Costo.AutoSize = True
        Me.LblCodigo_Costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo_Costo.Location = New System.Drawing.Point(18, 30)
        Me.LblCodigo_Costo.Name = "LblCodigo_Costo"
        Me.LblCodigo_Costo.Size = New System.Drawing.Size(52, 15)
        Me.LblCodigo_Costo.TabIndex = 0
        Me.LblCodigo_Costo.Text = "Codigo :"
        '
        'Tipo_Costo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 141)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Tipo_Costo"
        Me.Text = "Tipo Costo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxValor_costo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo_costo As System.Windows.Forms.TextBox
    Friend WithEvents LblValor_costo As System.Windows.Forms.Label
    Friend WithEvents LblCodigo_Costo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBubic_tipocost As System.Windows.Forms.ComboBox
    Friend WithEvents LblUbica As System.Windows.Forms.Label
End Class

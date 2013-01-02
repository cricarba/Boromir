<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Documentos
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
        Me.TxtNombre_doc = New System.Windows.Forms.TextBox()
        Me.TxtCodigo_doc = New System.Windows.Forms.TextBox()
        Me.LblNombre_doc = New System.Windows.Forms.Label()
        Me.LblCodigo_doc = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNombre_doc)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo_doc)
        Me.GroupBox1.Controls.Add(Me.LblNombre_doc)
        Me.GroupBox1.Controls.Add(Me.LblCodigo_doc)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maestro de Documentos"
        '
        'TxtNombre_doc
        '
        Me.TxtNombre_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre_doc.Location = New System.Drawing.Point(74, 59)
        Me.TxtNombre_doc.Name = "TxtNombre_doc"
        Me.TxtNombre_doc.Size = New System.Drawing.Size(180, 21)
        Me.TxtNombre_doc.TabIndex = 3
        '
        'TxtCodigo_doc
        '
        Me.TxtCodigo_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo_doc.Location = New System.Drawing.Point(74, 27)
        Me.TxtCodigo_doc.MaxLength = 2
        Me.TxtCodigo_doc.Name = "TxtCodigo_doc"
        Me.TxtCodigo_doc.Size = New System.Drawing.Size(27, 21)
        Me.TxtCodigo_doc.TabIndex = 1
        '
        'LblNombre_doc
        '
        Me.LblNombre_doc.AutoSize = True
        Me.LblNombre_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre_doc.Location = New System.Drawing.Point(16, 62)
        Me.LblNombre_doc.Name = "LblNombre_doc"
        Me.LblNombre_doc.Size = New System.Drawing.Size(58, 15)
        Me.LblNombre_doc.TabIndex = 2
        Me.LblNombre_doc.Text = "Nombre :"
        '
        'LblCodigo_doc
        '
        Me.LblCodigo_doc.AutoSize = True
        Me.LblCodigo_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo_doc.Location = New System.Drawing.Point(17, 27)
        Me.LblCodigo_doc.Name = "LblCodigo_doc"
        Me.LblCodigo_doc.Size = New System.Drawing.Size(52, 15)
        Me.LblCodigo_doc.TabIndex = 0
        Me.LblCodigo_doc.Text = "Codigo :"
        '
        'Documentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 125)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Documentos"
        Me.Text = "Documentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNombre_doc As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo_doc As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre_doc As System.Windows.Forms.Label
    Friend WithEvents LblCodigo_doc As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mensajes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mensajes))
        Me.TxtPara = New System.Windows.Forms.TextBox()
        Me.Mensaje = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAsunto = New System.Windows.Forms.TextBox()
        Me.Btncco = New System.Windows.Forms.Button()
        Me.BtnCC = New System.Windows.Forms.Button()
        Me.BtnPara = New System.Windows.Forms.Button()
        Me.TxtCCO = New System.Windows.Forms.TextBox()
        Me.TxtCC = New System.Windows.Forms.TextBox()
        Me.TxtBody = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblNombreArchivo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBtnMasivo = New System.Windows.Forms.RadioButton()
        Me.RBtnNormal = New System.Windows.Forms.RadioButton()
        Me.Mensaje.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtPara
        '
        Me.TxtPara.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPara.Location = New System.Drawing.Point(87, 21)
        Me.TxtPara.Name = "TxtPara"
        Me.TxtPara.Size = New System.Drawing.Size(438, 20)
        Me.TxtPara.TabIndex = 1
        '
        'Mensaje
        '
        Me.Mensaje.Controls.Add(Me.Label1)
        Me.Mensaje.Controls.Add(Me.TxtAsunto)
        Me.Mensaje.Controls.Add(Me.Btncco)
        Me.Mensaje.Controls.Add(Me.BtnCC)
        Me.Mensaje.Controls.Add(Me.BtnPara)
        Me.Mensaje.Controls.Add(Me.TxtCCO)
        Me.Mensaje.Controls.Add(Me.TxtCC)
        Me.Mensaje.Controls.Add(Me.TxtPara)
        Me.Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mensaje.Location = New System.Drawing.Point(10, 53)
        Me.Mensaje.Name = "Mensaje"
        Me.Mensaje.Size = New System.Drawing.Size(534, 125)
        Me.Mensaje.TabIndex = 1
        Me.Mensaje.TabStop = False
        Me.Mensaje.Text = "Nuevo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ASUNTO:"
        '
        'TxtAsunto
        '
        Me.TxtAsunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAsunto.Location = New System.Drawing.Point(87, 97)
        Me.TxtAsunto.Name = "TxtAsunto"
        Me.TxtAsunto.Size = New System.Drawing.Size(438, 20)
        Me.TxtAsunto.TabIndex = 7
        '
        'Btncco
        '
        Me.Btncco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncco.Location = New System.Drawing.Point(6, 68)
        Me.Btncco.Name = "Btncco"
        Me.Btncco.Size = New System.Drawing.Size(75, 23)
        Me.Btncco.TabIndex = 4
        Me.Btncco.Text = "CCO:"
        Me.Btncco.UseVisualStyleBackColor = True
        '
        'BtnCC
        '
        Me.BtnCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCC.Location = New System.Drawing.Point(6, 43)
        Me.BtnCC.Name = "BtnCC"
        Me.BtnCC.Size = New System.Drawing.Size(75, 23)
        Me.BtnCC.TabIndex = 2
        Me.BtnCC.Text = "CC:"
        Me.BtnCC.UseVisualStyleBackColor = True
        '
        'BtnPara
        '
        Me.BtnPara.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPara.Location = New System.Drawing.Point(6, 19)
        Me.BtnPara.Name = "BtnPara"
        Me.BtnPara.Size = New System.Drawing.Size(75, 23)
        Me.BtnPara.TabIndex = 0
        Me.BtnPara.Text = "PARA:"
        Me.BtnPara.UseVisualStyleBackColor = True
        '
        'TxtCCO
        '
        Me.TxtCCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCCO.Location = New System.Drawing.Point(87, 71)
        Me.TxtCCO.Name = "TxtCCO"
        Me.TxtCCO.Size = New System.Drawing.Size(438, 20)
        Me.TxtCCO.TabIndex = 5
        '
        'TxtCC
        '
        Me.TxtCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCC.Location = New System.Drawing.Point(87, 45)
        Me.TxtCC.Name = "TxtCC"
        Me.TxtCC.Size = New System.Drawing.Size(438, 20)
        Me.TxtCC.TabIndex = 3
        '
        'TxtBody
        '
        Me.TxtBody.Location = New System.Drawing.Point(10, 207)
        Me.TxtBody.Multiline = True
        Me.TxtBody.Name = "TxtBody"
        Me.TxtBody.Size = New System.Drawing.Size(534, 252)
        Me.TxtBody.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(14, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Archivo Adjunto:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(114, 183)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'LblNombreArchivo
        '
        Me.LblNombreArchivo.AutoSize = True
        Me.LblNombreArchivo.Location = New System.Drawing.Point(138, 186)
        Me.LblNombreArchivo.Name = "LblNombreArchivo"
        Me.LblNombreArchivo.Size = New System.Drawing.Size(88, 13)
        Me.LblNombreArchivo.TabIndex = 3
        Me.LblNombreArchivo.Text = "Clic en la Imagen"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBtnMasivo)
        Me.GroupBox1.Controls.Add(Me.RBtnNormal)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 43)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Correo"
        '
        'RBtnMasivo
        '
        Me.RBtnMasivo.AutoSize = True
        Me.RBtnMasivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnMasivo.Location = New System.Drawing.Point(101, 17)
        Me.RBtnMasivo.Name = "RBtnMasivo"
        Me.RBtnMasivo.Size = New System.Drawing.Size(59, 17)
        Me.RBtnMasivo.TabIndex = 1
        Me.RBtnMasivo.TabStop = True
        Me.RBtnMasivo.Text = "Masivo"
        Me.RBtnMasivo.UseVisualStyleBackColor = True
        '
        'RBtnNormal
        '
        Me.RBtnNormal.AutoSize = True
        Me.RBtnNormal.Checked = True
        Me.RBtnNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnNormal.Location = New System.Drawing.Point(7, 17)
        Me.RBtnNormal.Name = "RBtnNormal"
        Me.RBtnNormal.Size = New System.Drawing.Size(58, 17)
        Me.RBtnNormal.TabIndex = 0
        Me.RBtnNormal.TabStop = True
        Me.RBtnNormal.Text = "Normal"
        Me.RBtnNormal.UseVisualStyleBackColor = True
        '
        'Mensajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 466)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblNombreArchivo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBody)
        Me.Controls.Add(Me.Mensaje)
        Me.Name = "Mensajes"
        Me.Text = "Form1"
        Me.Mensaje.ResumeLayout(False)
        Me.Mensaje.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPara As System.Windows.Forms.TextBox
    Friend WithEvents Mensaje As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents Btncco As System.Windows.Forms.Button
    Friend WithEvents BtnCC As System.Windows.Forms.Button
    Friend WithEvents BtnPara As System.Windows.Forms.Button
    Friend WithEvents TxtCCO As System.Windows.Forms.TextBox
    Friend WithEvents TxtCC As System.Windows.Forms.TextBox
    Friend WithEvents TxtBody As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblNombreArchivo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBtnMasivo As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnNormal As System.Windows.Forms.RadioButton

End Class

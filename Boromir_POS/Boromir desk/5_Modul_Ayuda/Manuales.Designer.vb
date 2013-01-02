<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manuales
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
        Me.Browser_Manuales = New System.Windows.Forms.WebBrowser()
        Me.RBBasico = New System.Windows.Forms.RadioButton()
        Me.RBadmon = New System.Windows.Forms.RadioButton()
        Me.RBtnCompleto = New System.Windows.Forms.RadioButton()
        Me.RBweb = New System.Windows.Forms.RadioButton()
        Me.RB_inventarios = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Browser_Manuales
        '
        Me.Browser_Manuales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Browser_Manuales.Location = New System.Drawing.Point(12, 90)
        Me.Browser_Manuales.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Browser_Manuales.Name = "Browser_Manuales"
        Me.Browser_Manuales.Size = New System.Drawing.Size(765, 369)
        Me.Browser_Manuales.TabIndex = 0
        '
        'RBBasico
        '
        Me.RBBasico.AutoSize = True
        Me.RBBasico.Location = New System.Drawing.Point(6, 19)
        Me.RBBasico.Name = "RBBasico"
        Me.RBBasico.Size = New System.Drawing.Size(126, 17)
        Me.RBBasico.TabIndex = 1
        Me.RBBasico.TabStop = True
        Me.RBBasico.Text = "Funcionalidad Basica"
        Me.RBBasico.UseVisualStyleBackColor = True
        '
        'RBadmon
        '
        Me.RBadmon.AutoSize = True
        Me.RBadmon.Location = New System.Drawing.Point(138, 19)
        Me.RBadmon.Name = "RBadmon"
        Me.RBadmon.Size = New System.Drawing.Size(128, 17)
        Me.RBadmon.TabIndex = 2
        Me.RBadmon.TabStop = True
        Me.RBadmon.Text = "Modulo Administrativo"
        Me.RBadmon.UseVisualStyleBackColor = True
        '
        'RBtnCompleto
        '
        Me.RBtnCompleto.AutoSize = True
        Me.RBtnCompleto.Location = New System.Drawing.Point(272, 42)
        Me.RBtnCompleto.Name = "RBtnCompleto"
        Me.RBtnCompleto.Size = New System.Drawing.Size(107, 17)
        Me.RBtnCompleto.TabIndex = 3
        Me.RBtnCompleto.TabStop = True
        Me.RBtnCompleto.Text = "Manual Completo"
        Me.RBtnCompleto.UseVisualStyleBackColor = True
        '
        'RBweb
        '
        Me.RBweb.AutoSize = True
        Me.RBweb.Location = New System.Drawing.Point(393, 42)
        Me.RBweb.Name = "RBweb"
        Me.RBweb.Size = New System.Drawing.Size(84, 17)
        Me.RBweb.TabIndex = 4
        Me.RBweb.TabStop = True
        Me.RBweb.Text = "Pagina Web"
        Me.RBweb.UseVisualStyleBackColor = True
        '
        'RB_inventarios
        '
        Me.RB_inventarios.AutoSize = True
        Me.RB_inventarios.Location = New System.Drawing.Point(272, 19)
        Me.RB_inventarios.Name = "RB_inventarios"
        Me.RB_inventarios.Size = New System.Drawing.Size(115, 17)
        Me.RB_inventarios.TabIndex = 5
        Me.RB_inventarios.TabStop = True
        Me.RB_inventarios.Text = "Modulo Inventarios"
        Me.RB_inventarios.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RBweb)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RBtnCompleto)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RBBasico)
        Me.GroupBox1.Controls.Add(Me.RB_inventarios)
        Me.GroupBox1.Controls.Add(Me.RBadmon)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 72)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manuales"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(393, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(119, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Modulo Facturacion"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(514, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(106, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Modulo Reportes"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(111, 17)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Modulo Seguridad"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(138, 42)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(93, 17)
        Me.RadioButton4.TabIndex = 9
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Modulo Ayuda"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Manuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 463)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Browser_Manuales)
        Me.Name = "Manuales"
        Me.Text = "Manuales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Browser_Manuales As System.Windows.Forms.WebBrowser
    Friend WithEvents RBBasico As System.Windows.Forms.RadioButton
    Friend WithEvents RBadmon As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnCompleto As System.Windows.Forms.RadioButton
    Friend WithEvents RBweb As System.Windows.Forms.RadioButton
    Friend WithEvents RB_inventarios As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class

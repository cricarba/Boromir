<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Costo_Turno
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
        Me.CBtipoescen_costo_turno = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CBubic_tabla_costo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MTxt_hora = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBFestivo = New System.Windows.Forms.ComboBox()
        Me.CBDomingo = New System.Windows.Forms.ComboBox()
        Me.CBSabado = New System.Windows.Forms.ComboBox()
        Me.CBViernes = New System.Windows.Forms.ComboBox()
        Me.CBJueves = New System.Windows.Forms.ComboBox()
        Me.CBMiercoles = New System.Windows.Forms.ComboBox()
        Me.CBMartes = New System.Windows.Forms.ComboBox()
        Me.CBLunes = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.data_costoturno = New System.Windows.Forms.DataGridView()
        Me.Lblubica = New System.Windows.Forms.Label()
        Me.Lbltipoescen = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.data_costoturno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBtipoescen_costo_turno
        '
        Me.CBtipoescen_costo_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBtipoescen_costo_turno.FormattingEnabled = True
        Me.CBtipoescen_costo_turno.Location = New System.Drawing.Point(307, 25)
        Me.CBtipoescen_costo_turno.Name = "CBtipoescen_costo_turno"
        Me.CBtipoescen_costo_turno.Size = New System.Drawing.Size(49, 21)
        Me.CBtipoescen_costo_turno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo Escenario:"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.Lbltipoescen)
        Me.GroupBox2.Controls.Add(Me.Lblubica)
        Me.GroupBox2.Controls.Add(Me.CBubic_tabla_costo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CBtipoescen_costo_turno)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.MTxt_hora)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(603, 66)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tabla de Precios"
        '
        'CBubic_tabla_costo
        '
        Me.CBubic_tabla_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBubic_tabla_costo.FormattingEnabled = True
        Me.CBubic_tabla_costo.Location = New System.Drawing.Point(76, 25)
        Me.CBubic_tabla_costo.Name = "CBubic_tabla_costo"
        Me.CBubic_tabla_costo.Size = New System.Drawing.Size(46, 21)
        Me.CBubic_tabla_costo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ubicacion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(462, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hora:"
        '
        'MTxt_hora
        '
        Me.MTxt_hora.Location = New System.Drawing.Point(501, 25)
        Me.MTxt_hora.Mask = "00:00"
        Me.MTxt_hora.Name = "MTxt_hora"
        Me.MTxt_hora.Size = New System.Drawing.Size(46, 21)
        Me.MTxt_hora.TabIndex = 5
        Me.MTxt_hora.ValidatingType = GetType(Date)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBFestivo)
        Me.GroupBox1.Controls.Add(Me.CBDomingo)
        Me.GroupBox1.Controls.Add(Me.CBSabado)
        Me.GroupBox1.Controls.Add(Me.CBViernes)
        Me.GroupBox1.Controls.Add(Me.CBJueves)
        Me.GroupBox1.Controls.Add(Me.CBMiercoles)
        Me.GroupBox1.Controls.Add(Me.CBMartes)
        Me.GroupBox1.Controls.Add(Me.CBLunes)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 79)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Costo por Dias"
        '
        'CBFestivo
        '
        Me.CBFestivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFestivo.FormattingEnabled = True
        Me.CBFestivo.Location = New System.Drawing.Point(545, 44)
        Me.CBFestivo.Name = "CBFestivo"
        Me.CBFestivo.Size = New System.Drawing.Size(41, 21)
        Me.CBFestivo.TabIndex = 15
        '
        'CBDomingo
        '
        Me.CBDomingo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDomingo.FormattingEnabled = True
        Me.CBDomingo.Location = New System.Drawing.Point(468, 44)
        Me.CBDomingo.Name = "CBDomingo"
        Me.CBDomingo.Size = New System.Drawing.Size(41, 21)
        Me.CBDomingo.TabIndex = 13
        '
        'CBSabado
        '
        Me.CBSabado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSabado.FormattingEnabled = True
        Me.CBSabado.Location = New System.Drawing.Point(392, 44)
        Me.CBSabado.Name = "CBSabado"
        Me.CBSabado.Size = New System.Drawing.Size(41, 21)
        Me.CBSabado.TabIndex = 11
        '
        'CBViernes
        '
        Me.CBViernes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBViernes.FormattingEnabled = True
        Me.CBViernes.Location = New System.Drawing.Point(315, 44)
        Me.CBViernes.Name = "CBViernes"
        Me.CBViernes.Size = New System.Drawing.Size(41, 21)
        Me.CBViernes.TabIndex = 9
        '
        'CBJueves
        '
        Me.CBJueves.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBJueves.FormattingEnabled = True
        Me.CBJueves.Location = New System.Drawing.Point(239, 44)
        Me.CBJueves.Name = "CBJueves"
        Me.CBJueves.Size = New System.Drawing.Size(41, 21)
        Me.CBJueves.TabIndex = 7
        '
        'CBMiercoles
        '
        Me.CBMiercoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMiercoles.FormattingEnabled = True
        Me.CBMiercoles.Location = New System.Drawing.Point(162, 44)
        Me.CBMiercoles.Name = "CBMiercoles"
        Me.CBMiercoles.Size = New System.Drawing.Size(41, 21)
        Me.CBMiercoles.TabIndex = 5
        '
        'CBMartes
        '
        Me.CBMartes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMartes.FormattingEnabled = True
        Me.CBMartes.Location = New System.Drawing.Point(85, 44)
        Me.CBMartes.Name = "CBMartes"
        Me.CBMartes.Size = New System.Drawing.Size(41, 21)
        Me.CBMartes.TabIndex = 3
        '
        'CBLunes
        '
        Me.CBLunes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLunes.FormattingEnabled = True
        Me.CBLunes.Location = New System.Drawing.Point(6, 44)
        Me.CBLunes.Name = "CBLunes"
        Me.CBLunes.Size = New System.Drawing.Size(41, 21)
        Me.CBLunes.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(542, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Festivo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(465, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Domingo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(389, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Sabado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(312, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Viernes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(236, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Jueves"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(159, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Miercoles"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Martes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Lunes"
        '
        'data_costoturno
        '
        Me.data_costoturno.AllowUserToAddRows = False
        Me.data_costoturno.AllowUserToDeleteRows = False
        Me.data_costoturno.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.data_costoturno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data_costoturno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.data_costoturno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_costoturno.Location = New System.Drawing.Point(9, 169)
        Me.data_costoturno.Name = "data_costoturno"
        Me.data_costoturno.ReadOnly = True
        Me.data_costoturno.Size = New System.Drawing.Size(604, 389)
        Me.data_costoturno.TabIndex = 2
        '
        'Lblubica
        '
        Me.Lblubica.AutoSize = True
        Me.Lblubica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblubica.Location = New System.Drawing.Point(124, 29)
        Me.Lblubica.Name = "Lblubica"
        Me.Lblubica.Size = New System.Drawing.Size(0, 13)
        Me.Lblubica.TabIndex = 6
        '
        'Lbltipoescen
        '
        Me.Lbltipoescen.AutoSize = True
        Me.Lbltipoescen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltipoescen.Location = New System.Drawing.Point(362, 29)
        Me.Lbltipoescen.Name = "Lbltipoescen"
        Me.Lbltipoescen.Size = New System.Drawing.Size(0, 13)
        Me.Lbltipoescen.TabIndex = 7
        '
        'Costo_Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 570)
        Me.Controls.Add(Me.data_costoturno)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Costo_Turno"
        Me.Text = "Costo_Turno"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.data_costoturno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBtipoescen_costo_turno As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MTxt_hora As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBFestivo As System.Windows.Forms.ComboBox
    Friend WithEvents CBDomingo As System.Windows.Forms.ComboBox
    Friend WithEvents CBSabado As System.Windows.Forms.ComboBox
    Friend WithEvents CBViernes As System.Windows.Forms.ComboBox
    Friend WithEvents CBJueves As System.Windows.Forms.ComboBox
    Friend WithEvents CBMiercoles As System.Windows.Forms.ComboBox
    Friend WithEvents CBMartes As System.Windows.Forms.ComboBox
    Friend WithEvents CBLunes As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBubic_tabla_costo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents data_costoturno As System.Windows.Forms.DataGridView
    Friend WithEvents Lbltipoescen As System.Windows.Forms.Label
    Friend WithEvents Lblubica As System.Windows.Forms.Label
End Class

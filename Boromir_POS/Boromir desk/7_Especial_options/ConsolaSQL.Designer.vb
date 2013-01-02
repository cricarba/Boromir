<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsolaSQL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsolaSQL))
        Me.LblAplicacion = New System.Windows.Forms.Label()
        Me.TxtConsola = New System.Windows.Forms.TextBox()
        Me.Btnejecutar = New System.Windows.Forms.Button()
        Me.Dtconsola = New System.Windows.Forms.DataGridView()
        Me.Lbl_error = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Lbl_mensaje = New System.Windows.Forms.Label()
        Me.Picture_error = New System.Windows.Forms.PictureBox()
        Me.Picture_ok = New System.Windows.Forms.PictureBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        CType(Me.Dtconsola, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Picture_error, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblAplicacion
        '
        Me.LblAplicacion.AutoSize = True
        Me.LblAplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAplicacion.Location = New System.Drawing.Point(12, 9)
        Me.LblAplicacion.Name = "LblAplicacion"
        Me.LblAplicacion.Size = New System.Drawing.Size(92, 13)
        Me.LblAplicacion.TabIndex = 0
        Me.LblAplicacion.Text = "Sentencia SQL"
        '
        'TxtConsola
        '
        Me.TxtConsola.BackColor = System.Drawing.SystemColors.MenuText
        Me.TxtConsola.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConsola.ForeColor = System.Drawing.SystemColors.Menu
        Me.TxtConsola.Location = New System.Drawing.Point(12, 25)
        Me.TxtConsola.Multiline = True
        Me.TxtConsola.Name = "TxtConsola"
        Me.TxtConsola.Size = New System.Drawing.Size(458, 166)
        Me.TxtConsola.TabIndex = 1
        '
        'Btnejecutar
        '
        Me.Btnejecutar.Location = New System.Drawing.Point(476, 25)
        Me.Btnejecutar.Name = "Btnejecutar"
        Me.Btnejecutar.Size = New System.Drawing.Size(60, 23)
        Me.Btnejecutar.TabIndex = 2
        Me.Btnejecutar.Text = "Ejecutar"
        Me.Btnejecutar.UseVisualStyleBackColor = True
        '
        'Dtconsola
        '
        Me.Dtconsola.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dtconsola.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dtconsola.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dtconsola.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Dtconsola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtconsola.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.Dtconsola.Location = New System.Drawing.Point(0, 3)
        Me.Dtconsola.Name = "Dtconsola"
        Me.Dtconsola.Size = New System.Drawing.Size(505, 178)
        Me.Dtconsola.TabIndex = 0
        '
        'Lbl_error
        '
        Me.Lbl_error.AutoSize = True
        Me.Lbl_error.ForeColor = System.Drawing.Color.Red
        Me.Lbl_error.Location = New System.Drawing.Point(6, 14)
        Me.Lbl_error.Name = "Lbl_error"
        Me.Lbl_error.Size = New System.Drawing.Size(111, 13)
        Me.Lbl_error.TabIndex = 5
        Me.Lbl_error.Text = "Esperando Consulta..."
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 215)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(521, 207)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Dtconsola)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(513, 181)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Resultados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Lbl_error)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(513, 181)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mensajes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Lbl_mensaje
        '
        Me.Lbl_mensaje.AutoSize = True
        Me.Lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_mensaje.Location = New System.Drawing.Point(34, 194)
        Me.Lbl_mensaje.Name = "Lbl_mensaje"
        Me.Lbl_mensaje.Size = New System.Drawing.Size(136, 13)
        Me.Lbl_mensaje.TabIndex = 3
        Me.Lbl_mensaje.Text = "Esperando Consulta ..."
        '
        'Picture_error
        '
        Me.Picture_error.Image = CType(resources.GetObject("Picture_error.Image"), System.Drawing.Image)
        Me.Picture_error.Location = New System.Drawing.Point(15, 191)
        Me.Picture_error.Name = "Picture_error"
        Me.Picture_error.Size = New System.Drawing.Size(16, 18)
        Me.Picture_error.TabIndex = 8
        Me.Picture_error.TabStop = False
        Me.Picture_error.Visible = False
        '
        'Picture_ok
        '
        Me.Picture_ok.Image = CType(resources.GetObject("Picture_ok.Image"), System.Drawing.Image)
        Me.Picture_ok.Location = New System.Drawing.Point(15, 191)
        Me.Picture_ok.Name = "Picture_ok"
        Me.Picture_ok.Size = New System.Drawing.Size(16, 18)
        Me.Picture_ok.TabIndex = 9
        Me.Picture_ok.TabStop = False
        Me.Picture_ok.Visible = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(476, 54)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(60, 23)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(476, 83)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 23)
        Me.BtnClose.TabIndex = 6
        Me.BtnClose.Text = "Cerrar"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'ConsolaSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 429)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Picture_ok)
        Me.Controls.Add(Me.Picture_error)
        Me.Controls.Add(Me.Lbl_mensaje)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Btnejecutar)
        Me.Controls.Add(Me.TxtConsola)
        Me.Controls.Add(Me.LblAplicacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsolaSQL"
        Me.Text = "Consola SQL"
        CType(Me.Dtconsola, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Picture_error, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_ok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblAplicacion As System.Windows.Forms.Label
    Friend WithEvents TxtConsola As System.Windows.Forms.TextBox
    Friend WithEvents Btnejecutar As System.Windows.Forms.Button
    Friend WithEvents Dtconsola As System.Windows.Forms.DataGridView
    Friend WithEvents Lbl_error As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_mensaje As System.Windows.Forms.Label
    Friend WithEvents Picture_error As System.Windows.Forms.PictureBox
    Friend WithEvents Picture_ok As System.Windows.Forms.PictureBox
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporteador
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
        Me.CBConceptos = New System.Windows.Forms.CheckBox()
        Me.CBProductos = New System.Windows.Forms.CheckBox()
        Me.CBTerceros = New System.Windows.Forms.CheckBox()
        Me.CBPeriodicos = New System.Windows.Forms.CheckBox()
        Me.GBConceptos = New System.Windows.Forms.GroupBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.ComboBConcepto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GBProductos = New System.Windows.Forms.GroupBox()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GBTerceros = New System.Windows.Forms.GroupBox()
        Me.TxtTercero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GBPeriodicos = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTxthasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTxtdesde = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1.SuspendLayout()
        Me.GBConceptos.SuspendLayout()
        Me.GBProductos.SuspendLayout()
        Me.GBTerceros.SuspendLayout()
        Me.GBPeriodicos.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBConceptos)
        Me.GroupBox1.Controls.Add(Me.CBProductos)
        Me.GroupBox1.Controls.Add(Me.CBTerceros)
        Me.GroupBox1.Controls.Add(Me.CBPeriodicos)
        Me.GroupBox1.Controls.Add(Me.GBConceptos)
        Me.GroupBox1.Controls.Add(Me.GBProductos)
        Me.GroupBox1.Controls.Add(Me.GBTerceros)
        Me.GroupBox1.Controls.Add(Me.GBPeriodicos)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'CBConceptos
        '
        Me.CBConceptos.AutoSize = True
        Me.CBConceptos.Location = New System.Drawing.Point(234, 94)
        Me.CBConceptos.Name = "CBConceptos"
        Me.CBConceptos.Size = New System.Drawing.Size(15, 14)
        Me.CBConceptos.TabIndex = 14
        Me.CBConceptos.UseVisualStyleBackColor = True
        '
        'CBProductos
        '
        Me.CBProductos.AutoSize = True
        Me.CBProductos.Location = New System.Drawing.Point(560, 38)
        Me.CBProductos.Name = "CBProductos"
        Me.CBProductos.Size = New System.Drawing.Size(15, 14)
        Me.CBProductos.TabIndex = 13
        Me.CBProductos.UseVisualStyleBackColor = True
        '
        'CBTerceros
        '
        Me.CBTerceros.AutoSize = True
        Me.CBTerceros.Location = New System.Drawing.Point(6, 94)
        Me.CBTerceros.Name = "CBTerceros"
        Me.CBTerceros.Size = New System.Drawing.Size(15, 14)
        Me.CBTerceros.TabIndex = 13
        Me.CBTerceros.UseVisualStyleBackColor = True
        '
        'CBPeriodicos
        '
        Me.CBPeriodicos.AutoSize = True
        Me.CBPeriodicos.Location = New System.Drawing.Point(6, 39)
        Me.CBPeriodicos.Name = "CBPeriodicos"
        Me.CBPeriodicos.Size = New System.Drawing.Size(15, 14)
        Me.CBPeriodicos.TabIndex = 12
        Me.CBPeriodicos.UseVisualStyleBackColor = True
        '
        'GBConceptos
        '
        Me.GBConceptos.Controls.Add(Me.LblNombre)
        Me.GBConceptos.Controls.Add(Me.ComboBConcepto)
        Me.GBConceptos.Controls.Add(Me.Label5)
        Me.GBConceptos.Enabled = False
        Me.GBConceptos.Location = New System.Drawing.Point(253, 72)
        Me.GBConceptos.Name = "GBConceptos"
        Me.GBConceptos.Size = New System.Drawing.Size(188, 52)
        Me.GBConceptos.TabIndex = 11
        Me.GBConceptos.TabStop = False
        Me.GBConceptos.Text = "Conceptos"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(111, 25)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 11
        Me.LblNombre.Text = "Nombre"
        '
        'ComboBConcepto
        '
        Me.ComboBConcepto.FormattingEnabled = True
        Me.ComboBConcepto.Location = New System.Drawing.Point(58, 22)
        Me.ComboBConcepto.Name = "ComboBConcepto"
        Me.ComboBConcepto.Size = New System.Drawing.Size(49, 21)
        Me.ComboBConcepto.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Codigo"
        '
        'GBProductos
        '
        Me.GBProductos.Controls.Add(Me.TxtProducto)
        Me.GBProductos.Controls.Add(Me.Label4)
        Me.GBProductos.Enabled = False
        Me.GBProductos.Location = New System.Drawing.Point(581, 19)
        Me.GBProductos.Name = "GBProductos"
        Me.GBProductos.Size = New System.Drawing.Size(188, 47)
        Me.GBProductos.TabIndex = 2
        Me.GBProductos.TabStop = False
        Me.GBProductos.Text = "Productos"
        '
        'TxtProducto
        '
        Me.TxtProducto.Location = New System.Drawing.Point(58, 16)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(124, 20)
        Me.TxtProducto.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Codigo"
        '
        'GBTerceros
        '
        Me.GBTerceros.Controls.Add(Me.TxtTercero)
        Me.GBTerceros.Controls.Add(Me.Label3)
        Me.GBTerceros.Enabled = False
        Me.GBTerceros.Location = New System.Drawing.Point(24, 72)
        Me.GBTerceros.Name = "GBTerceros"
        Me.GBTerceros.Size = New System.Drawing.Size(204, 52)
        Me.GBTerceros.TabIndex = 2
        Me.GBTerceros.TabStop = False
        Me.GBTerceros.Text = "Terceros"
        '
        'TxtTercero
        '
        Me.TxtTercero.Location = New System.Drawing.Point(52, 23)
        Me.TxtTercero.Name = "TxtTercero"
        Me.TxtTercero.Size = New System.Drawing.Size(146, 20)
        Me.TxtTercero.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Codigo"
        '
        'GBPeriodicos
        '
        Me.GBPeriodicos.Controls.Add(Me.Label2)
        Me.GBPeriodicos.Controls.Add(Me.DTxthasta)
        Me.GBPeriodicos.Controls.Add(Me.Label1)
        Me.GBPeriodicos.Controls.Add(Me.DTxtdesde)
        Me.GBPeriodicos.Enabled = False
        Me.GBPeriodicos.Location = New System.Drawing.Point(24, 19)
        Me.GBPeriodicos.Name = "GBPeriodicos"
        Me.GBPeriodicos.Size = New System.Drawing.Size(530, 47)
        Me.GBPeriodicos.TabIndex = 1
        Me.GBPeriodicos.TabStop = False
        Me.GBPeriodicos.Text = "Periodicos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta"
        '
        'DTxthasta
        '
        Me.DTxthasta.Location = New System.Drawing.Point(320, 18)
        Me.DTxthasta.Name = "DTxthasta"
        Me.DTxthasta.Size = New System.Drawing.Size(200, 20)
        Me.DTxthasta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde"
        '
        'DTxtdesde
        '
        Me.DTxtdesde.Location = New System.Drawing.Point(61, 18)
        Me.DTxtdesde.Name = "DTxtdesde"
        Me.DTxtdesde.Size = New System.Drawing.Size(200, 20)
        Me.DTxtdesde.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AllowDrop = True
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Boromir.r_inv_movimientos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(944, 382)
        Me.ReportViewer1.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(953, 529)
        Me.SplitContainer1.SplitterDistance = 137
        Me.SplitContainer1.TabIndex = 2
        '
        'Reporteador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 532)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Reporteador"
        Me.Text = "Reporteador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBConceptos.ResumeLayout(False)
        Me.GBConceptos.PerformLayout()
        Me.GBProductos.ResumeLayout(False)
        Me.GBProductos.PerformLayout()
        Me.GBTerceros.ResumeLayout(False)
        Me.GBTerceros.PerformLayout()
        Me.GBPeriodicos.ResumeLayout(False)
        Me.GBPeriodicos.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GBProductos As System.Windows.Forms.GroupBox
    Friend WithEvents GBTerceros As System.Windows.Forms.GroupBox
    Friend WithEvents GBPeriodicos As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTxtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtTercero As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTxthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GBConceptos As System.Windows.Forms.GroupBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents ComboBConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CBConceptos As System.Windows.Forms.CheckBox
    Friend WithEvents CBProductos As System.Windows.Forms.CheckBox
    Friend WithEvents CBTerceros As System.Windows.Forms.CheckBox
    Friend WithEvents CBPeriodicos As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class

Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Facturas_t
    Public producto As PictureBox = New PictureBox()
    Private Sub Facturas_t_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CBcategorias.Items.Clear()
        Call F_Cargar_Combox.cargar_categorias()
        For Each dr As DataRow In Variables.filas_categorias
            CBcategorias.Items.Add(dr("cnombre_categ").ToString)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CBcategorias.SelectedIndexChanged
        Dim i As Integer
        Dim vertical As Integer = 10
        Dim horizontal As Integer = 10
        Dim categoria As String = CBcategorias.Text
        Dim nombre As String
        Variables.sSel = "select cimagen_produ,cnombre_produ from tbl_productos,tbl_categorias where cnombre_categ = '" & categoria & "' and ccod_categ_produ = cnombre_categ"
        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
        Variables.da.Fill(dt)

        For i = 0 To dt.Rows.Count - 1
            nombre = dt.Rows(i)("cnombre_produ").ToString

            producto.Name = nombre
            producto.Image = Image.FromFile(dt.Rows(i)("cimagen_produ").ToString)
            producto.SizeMode = PictureBoxSizeMode.StretchImage
            producto.Width = 100
            producto.Height = 100
            AddHandler producto.Click, AddressOf producto_click
            If i > 0 Then
                vertical = (producto.Width * i) + 15
                If i Mod 5 = 0 Then
                    horizontal = producto.Height * 2
                    vertical = 10
                End If
            End If
            producto.Location = New System.Drawing.Point(vertical, horizontal)
            GBproductos.Controls.Add(producto)
        Next
    End Sub

    Private Sub producto_click(sender As Object, e As System.EventArgs)

    End Sub
End Class
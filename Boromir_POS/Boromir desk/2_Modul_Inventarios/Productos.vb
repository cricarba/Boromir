Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Productos
    Dim dtcombo As New DataTable
    Dim numero As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Variables.update_imagen = True
            OpenFileDialog1.Filter = "Todos los archivos (*.*)|*.*"
            OpenFileDialog1.ShowDialog()
            Imagen_produc.Image = Image.FromFile(OpenFileDialog1.FileName)
            Imagen_produc.Image.Save(ms, Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MsgBox("Guardar Imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub CBVencimiento_produ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBVencimiento_produ.CheckedChanged
        If CBVencimiento_produ.Checked = True Then
            TxtFechavence_produ.Visible = True
            TxtFechavence_produ.Text = "01011900"
        Else
            TxtFechavence_produ.Visible = False
        End If
    End Sub

    Private Sub BtnCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCategoria.Click
        Try
            
            Variables.sSel = "insert into tbl_categorias (cnombre_categ) values ('" & Me.TxtCategoria_produ.Text & "') "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
            F_recargar_apps.produtos_reload()
        Catch ex As Exception
            MsgBox("Error Insert Categorias: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMarca.Click
        Try
            Variables.sSel = "insert into tbl_marcas (cnombre_marca) values ('" & Me.TxtMarca_produ.Text & "') "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
            F_recargar_apps.produtos_reload()
        Catch ex As Exception
            MsgBox("Error Insert Marcas: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnUnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnd.Click
        Try
            Variables.sSel = "insert into tbl_unidad_medida (cnombre_undmed) values ('" & Me.TxtUnidad_produ.Text & "') "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
            F_recargar_apps.produtos_reload()
        Catch ex As Exception
            MsgBox("Error Insert Und. Medida: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnColor.Click
        Try
            Variables.sSel = "insert into tbl_colores (cnombre_color) values ('" & Me.TxtColor_produ.Text & "') "
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
            F_recargar_apps.produtos_reload()
        Catch ex As Exception
            MsgBox("Error Insert Colores: " & ex.Message)
        End Try
    End Sub

    Private Sub Txtcodigoext_produ_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcodigoext_produ.TextChanged
        LblEAN.Text = Txtcodigoext_produ.Text
    End Sub

    Private Sub CB_Combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Combo.SelectedIndexChanged

        If CB_Combo.Text = "SI" Then
            If dtcombo.Columns.Count > 0 Then
                dtcombo.Columns.Remove("No")
                dtcombo.Columns.Remove("Codigo")
                dtcombo.Columns.Remove("Nombre")
                dtcombo.Columns.Remove("Cantidad")
            End If

            dtcombo.Columns.Add("No")
            dtcombo.Columns.Add("Codigo")
            dtcombo.Columns.Add("Nombre")
            dtcombo.Columns.Add("Cantidad")
            GroupCombo.Visible = True
        ElseIf CB_Combo.Text = "NO" Then
            If dtcombo.Columns.Count > 0 Then
                dtcombo.Columns.Remove("No")
                dtcombo.Columns.Remove("Codigo")
                dtcombo.Columns.Remove("Nombre")
                dtcombo.Columns.Remove("Cantidad")
            End If
            GroupCombo.Visible = False
            End If
    End Sub

    Private Sub TBtnNuevodetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnNuevodetalle.Click
        Try
            Dim rowcombo As DataRow = dtcombo.NewRow
            numero = numero + 1
            rowcombo.Item(0) = numero
            rowcombo.Item(1) = TxtComponente.Text
            rowcombo.Item(2) = Lblnombre_componente.Text
            rowcombo.Item(3) = TxtCantidad.Text
            dtcombo.Rows.Add(rowcombo)
            dtviewcombos.DataSource = dtcombo
        Catch ex As Exception
            MsgBox("Error al Insertar", MsgBoxStyle.Critical, "Boromir Dice:")
        End Try
    End Sub

    Private Sub TBtneliminardetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtneliminardetalle.Click
        Try
            If dtcombo_global.Rows.Count > 0 Then
                dtcombo = dtcombo_global
            End If
            Dim codigo As Integer
            Dim columna As Integer = Integer.Parse(TxtBorrar.Text) - 1
            codigo = dtcombo.Rows(columna)(1)
            Variables.sSel = "delete tbl_combos where ncod_componente_combo = '" & Integer.Parse(codigo) & "'  and ncodigo_combo =  '" & Integer.Parse(Me.Txtcodigo_produ.Text) & "'"
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dt)
            dtcombo.Rows.RemoveAt(columna)
            dtviewcombos.DataSource = dtcombo
            dtcombo_global.Clear()
        Catch ex As Exception
            MsgBox("Error al borrar", MsgBoxStyle.Critical, "Boromir Dice:")
        End Try
    End Sub

    Private Sub TxtComponente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtComponente.TextChanged
        Dim dtcomponente As New DataTable
        Dim i As Integer
        If IsNumeric(TxtComponente.Text) Then
            Try
                Variables.sSel = "Select * from tbl_productos,tbl_saldos where ncodigo_produ = '" & Integer.Parse(TxtComponente.Text) & "'  and ncodigo_produ = ncod_produ_saldo"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dtcomponente)

                If dtcomponente.Rows.Count = 0 Then
                    Variables.sSel = "Select * from tbl_productos where ncodigo_produ = '" & Integer.Parse(TxtComponente.Text) & "'"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtcomponente)
                    Lblnombre_componente.Text = dtcomponente.Rows(i)("cnombre_produ").ToString()

                Else
                    Lblnombre_componente.Text = dtcomponente.Rows(i)("cnombre_produ").ToString()
                End If

            Catch ex As Exception
                Lblnombre_componente.Text = "*"
            End Try
        Else
            Lblnombre_componente.Text = " CODIGO PRODUCTO DEBE SER NUMERICO"
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Variables.app_buscar = "Productos_Cs"
        field_buscar = "c_producto"
        Buscar.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Variables.app_buscar = "Productos"
        field_buscar = "pr_producto"
        Buscar.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Variables.app_buscar = "Productos_CB"
        field_buscar = "pr_producto_CB"
        Buscar.Show()
    End Sub

    Private Sub Productos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
Imports System.Data
Imports System.Data.SqlClient
Public Class Mov_inventarios
    Dim i As Integer
    Dim estado As Integer
    Dim limpiar As Boolean
    Private Sub TBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnNuevodetalle.Click
        Try
            Variables.sSel = "exec proc_detalles_movimientos '" & Integer.Parse(Txtcodigo_movprodu.Text) & "','" & Me.CBConcepto.Text & "','" & Integer.Parse(Codigo1.Text) & "','" & Integer.Parse(Me.CBUbicacion.Text) & "','" & Me.TxtFecha_reser.Text & "','" & Integer.Parse(Cantidad1.Text) & "','" & Integer.Parse(Precio1.Text) & "','" & Integer.Parse(Impuesto1.Text) & "','" & Integer.Parse(Descuento1.Text) & "', agregar"
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dm)
            estado = 2
        Catch ex As Exception
            MsgBox("Error Insert Detalle: " & ex.Message)
        End Try

        If estado = 2 Then
            Try
                Variables.dt.Clear()
                Call F_Boton_buscar.Boton_Buscar()
            Catch ex As Exception
                MsgBox("Error Select Detalle: " & ex.Message)
            End Try
        End If
        limpiar = True
        Me.Codigo1.Focus()
        Me.Codigo1.Text = "0"
        Me.Producto1.Text = "*"
        Me.Existencia1.Text = ""
        Me.Impuesto1.Text = "0"
        Me.Descuento1.Text = "0"
        Me.Unidad1.Text = "*"
        Me.Precio1.Text = "0"
        Me.Cantidad1.Text = "0"
    End Sub


    Private Sub Codigo1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Codigo1.TextChanged
        Variables.dt.Clear()
        If IsNumeric(Codigo1.Text) Then
            Variables.Subtotal = 0
            Variables.descuento = 0
            Variables.impuesto = 0
            Variables.total = 0
            Try
                Variables.sSel = "Select * from tbl_productos,tbl_saldos where ncodigo_produ = '" & Integer.Parse(Codigo1.Text) & "' and ncod_ubica_saldo = '" & CBUbicacion.Text & "' and ncodigo_produ = ncod_produ_saldo"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dt)

                If dt.Rows.Count = 0 Then
                    Variables.sSel = "Select * from tbl_productos where ncodigo_produ = '" & Integer.Parse(Codigo1.Text) & "'"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dt)
                    Producto1.Text = dt.Rows(i)("cnombre_produ").ToString()
                    Unidad1.Text = dt.Rows(i)("ccod_und_produ").ToString()
                    Precio1.Text = dt.Rows(i)("nprecio_compra_produ").ToString()
                    Impuesto1.Text = dt.Rows(i)("nimpuesto_produ").ToString()
                    Descuento1.Text = dt.Rows(i)("ndescuento_produ").ToString()
                    Producto1.Text = dt.Rows(i)("cnombre_produ").ToString()
                    Unidad1.Text = dt.Rows(i)("ccod_und_produ").ToString()
                    Precio1.Text = dt.Rows(i)("nprecio_compra_produ").ToString()
                    Impuesto1.Text = dt.Rows(i)("nimpuesto_produ").ToString()
                    Descuento1.Text = dt.Rows(i)("ndescuento_produ").ToString()
                    Existencia1.Text = "0"
                Else
                    Producto1.Text = dt.Rows(i)("cnombre_produ").ToString()
                    Unidad1.Text = dt.Rows(i)("ccod_und_produ").ToString()
                    Precio1.Text = dt.Rows(i)("nprecio_compra_produ").ToString()
                    Impuesto1.Text = dt.Rows(i)("nimpuesto_produ").ToString()
                    Descuento1.Text = dt.Rows(i)("ndescuento_produ").ToString()
                    Producto1.Text = dt.Rows(i)("cnombre_produ").ToString()
                    Unidad1.Text = dt.Rows(i)("ccod_und_produ").ToString()
                    Precio1.Text = dt.Rows(i)("nprecio_compra_produ").ToString()
                    Impuesto1.Text = dt.Rows(i)("nimpuesto_produ").ToString()
                    Descuento1.Text = dt.Rows(i)("ndescuento_produ").ToString()
                    Existencia1.Text = dt.Rows(i)("ncantidad_saldo").ToString()
                End If

            Catch ex As Exception
                Producto1.Text = "*"
                Unidad1.Text = "*"
                Precio1.Text = "0"
                Impuesto1.Text = "0"
                Descuento1.Text = "0"
            End Try
        Else
            Producto1.Text = "PRODUCTO DEBE SER NUMERICO"
            Unidad1.Text = "*"
            Precio1.Text = "0"
            Codigo1.Text = "0"
            Impuesto1.Text = "0"
            Descuento1.Text = "0"
        End If
    End Sub

    Private Sub Cantidad1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cantidad1.TextChanged
        If limpiar = True Then
            limpiar = False
        Else
            Try
                If IsNumeric(Cantidad1.Text) Then
                    'Variables.Subtotal = 0
                    'Variables.descuento = 0
                    'Variables.impuesto = 0
                    'Variables.total = 0
                    'Variables.Subtotal = Integer.Parse(Cantidad1.Text * Precio1.Text)
                    'Variables.descuento = Integer.Parse((Cantidad1.Text * Precio1.Text) * Descuento1.Text / 100)
                    'Variables.impuesto = Integer.Parse((Cantidad1.Text * Precio1.Text) * Impuesto1.Text / 100)
                    'Variables.total = Integer.Parse(Variables.Subtotal - Variables.descuento + Variables.impuesto)
                    'Total1.Text = String.Format(total)
                Else
                    MsgBox("Campo cantidad debe ser númerico", MsgBoxStyle.Critical, "Boromir dice: ")
                End If
            Catch ex As Exception
                MsgBox("Error Cantidad Detalle: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub TxtDocumento_terce_factu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDocumento_terce_factu.TextChanged
        Variables.dt.Clear()
        Try
            If IsNumeric(TxtDocumento_terce_factu.Text) Then
                Dim i As Integer
                TxtDocumento_terce_factu.Text = Integer.Parse(TxtDocumento_terce_factu.Text)
                Variables.sSel = "Select * from tbl_terceros where ncodigo_terce = '" & TxtDocumento_terce_factu.Text & "'"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dt)
                TxtNombre1_factu.Text = dt.Rows(i)("cnombre_terce").ToString()
                TxtNombre2_factu.Text = dt.Rows(i)("cnombre2_terce").ToString()
                TxtApellido_terce_factu.Text = dt.Rows(i)("capellido_terce").ToString()
                TxtApellido2_terce_factu.Text = dt.Rows(i)("capellido2_terce").ToString()
                Variables.Registros = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
            Else
                MsgBox("Campo cedula debe ser númerico", MsgBoxStyle.Critical, "Boromir dice: ")
            End If
        Catch ex As Exception
            TxtNombre1_factu.Text = ""
            TxtNombre2_factu.Text = ""
            TxtApellido_terce_factu.Text = ""
            TxtApellido2_terce_factu.Text = ""
        End Try
    End Sub

    Private Sub TBtneliminardetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtneliminardetalle.Click
        Try
            Variables.sSel = "exec proc_detalles_movimientos '" & Integer.Parse(Txtcodigo_movprodu.Text) & "','" & Me.CBConcepto.Text & "','" & Integer.Parse(Codigo1.Text) & "','" & Integer.Parse(Me.CBUbicacion.Text) & "','" & Me.TxtFecha_reser.Text & "','" & Integer.Parse(Cantidad1.Text) & "','" & Integer.Parse(Precio1.Text) & "','" & Integer.Parse(Impuesto1.Text) & "','" & Integer.Parse(Descuento1.Text) & "',eliminar"
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dm)
        Catch ex As Exception
            MsgBox("Error Delete Detalle: " & ex.Message)
        End Try

        Try
            Variables.dt.Clear()
            Call F_Boton_buscar.Boton_Buscar()
        Catch ex As Exception
            MsgBox("Error Select Detalle: " & ex.Message)
        End Try
        limpiar = True
        Me.Codigo1.Focus()
        Me.Codigo1.Text = "0"
        Me.Producto1.Text = "*"
        Me.Existencia1.Text = ""
        Me.Impuesto1.Text = "0"
        Me.Descuento1.Text = "0"
        Me.Unidad1.Text = "*"
        Me.Precio1.Text = "0"
        Me.Cantidad1.Text = "0"
    End Sub

    Private Sub Descuento_Movi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Descuento_Movi.TextChanged
        If IsNumeric(Descuento_Movi.Text) Then
            If Descuento_Movi.Text <> "" Then
                Descuento1.Text = Descuento_Movi.Text
                Descuento1.Enabled = False
            End If
        Else
            MsgBox("Campo descuento debe ser numerico", MsgBoxStyle.Information, "Boromir Dice:")
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Variables.app_buscar = "Productos"
        field_buscar = "m_producto"
        Buscar.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Variables.app_buscar = "Terceros"
        field_buscar = "m_tercero"
        Buscar.Show()
    End Sub

    Private Sub CBConcepto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBConcepto.SelectedIndexChanged
        LblConcepto.Text = F_asigna_nombre.Nombre_label("Conceptos", Me.CBConcepto.Text)
    End Sub

    Private Sub CBUbicacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBUbicacion.SelectedIndexChanged
        LblUbica.Text = F_asigna_nombre.Nombre_label("Ubicaciones", Me.CBUbicacion.Text)
    End Sub

    Private Sub Label17_Click(sender As System.Object, e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub LblFecha_reser_Click(sender As System.Object, e As System.EventArgs) Handles LblFecha_reser.Click

    End Sub

    Private Sub TxtFecha_reser_ValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtFecha_reser.ValueChanged

    End Sub
End Class


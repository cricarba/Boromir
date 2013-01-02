
Imports System.Data
Imports System.Data.SqlClient
Public Class Ordenes_Compra
    Dim i As Integer
    Dim estado As Integer
    Dim limpiar As Boolean


    Private Sub TBtnNuevodetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnNuevodetalle.Click
        'If Existencia1.ForeColor = Color.Red Then
        '    MsgBox("La cantidad es superior a la existencia del producto", MsgBoxStyle.Information, "Boromir Dice:")
        'Else
        Try
            Variables.sSel = "exec proc_detalles_movimientos '" & Integer.Parse(Txtnumero.Text) & "','" & Me.CBConcepto.Text & "','" & Integer.Parse(Codigo1.Text) & "','" & Integer.Parse(Me.CBUbicacion.Text) & "','" & Me.TxtFecha_factu.Text & "','" & Integer.Parse(Cantidad1.Text) & "','" & Integer.Parse(precio1.Text) & "','" & Integer.Parse(Impuesto1.Text) & "','" & Integer.Parse(Descuento1.Text) & "',agregar"
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(df)
            estado = 2
        Catch ex As Exception
            MsgBox("Error Insert Detalle: " & ex.Message)
        End Try
        'End If

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
        Me.Impuesto1.Text = "0"
        Me.Descuento1.Text = "0"
        Me.Unidad1.Text = "*"
        Me.precio1.Text = "0"
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
                Variables.sSel = "Select * from tbl_productos where ncodigo_produ = '" & Integer.Parse(Codigo1.Text) & "'"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Producto1.Text = dt.Rows(i)("cnombre_produ").ToString()
                    Unidad1.Text = dt.Rows(i)("ccod_und_produ").ToString()
                    precio1.Text = dt.Rows(i)("nprecio_venta_produ").ToString()
                    Descuento1.Text = dt.Rows(i)("ndescuento_produ").ToString()
                    Impuesto1.Text = dt.Rows(i)("nimpuesto_produ").ToString()
                    'Existencia1.Text = dt.Rows(i)("ncantidad_saldo").ToString()
                Else
                    Producto1.Text = "Producto no existe."
                    Unidad1.Text = ""
                    precio1.Text = ""
                    Descuento1.Text = ""
                    Impuesto1.Text = ""
                End If
            Catch ex As Exception
                Producto1.Text = "Producto no existe."
                Unidad1.Text = ""
                precio1.Text = ""
                Descuento1.Text = ""
                Impuesto1.Text = ""
            End Try
        Else
            Producto1.Text = "Codigo debe ser numerico."
            Unidad1.Text = ""
            precio1.Text = ""
            Codigo1.Text = "0"
            Descuento1.Text = ""
            Impuesto1.Text = ""
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
                    'If Me.CBConcepto.Text <> "FR" Then
                    '    If Me.Descuento1.Text > 0 Then
                    '        Variables.Subtotal = Integer.Parse(Cantidad1.Text * precio1.Text)
                    '        Variables.descuento = Integer.Parse((Cantidad1.Text * precio1.Text) * Descuento1.Text / 100)
                    '        Variables.impuesto = Integer.Parse((Cantidad1.Text * precio1.Text) * Impuesto1.Text / 100)
                    '        Variables.total = Integer.Parse(Variables.Subtotal - Variables.descuento + Variables.impuesto)
                    '        Total1.Text = String.Format(total)
                    '    Else
                    '        Variables.impuesto = Integer.Parse((Cantidad1.Text * precio1.Text) * Impuesto1.Text / 100)
                    '        Variables.Subtotal = Integer.Parse(Cantidad1.Text * precio1.Text + Variables.impuesto)
                    '        Variables.total = Integer.Parse(Variables.Subtotal)
                    '        Total1.Text = String.Format(total)
                    '    End If
                    'End If

                    'Dim cantidad, existencia As Integer
                    'If existencia <> 0 Then
                    '    cantidad = Integer.Parse(Cantidad1.Text)
                    '    existencia = Integer.Parse(Existencia1.Text)
                    '    If cantidad > existencia Then
                    '        Existencia1.ForeColor = Color.Red
                    '        lblexistencia.BackColor = Color.Red
                    '    ElseIf cantidad <= existencia Then
                    '        Existencia1.ForeColor = Color.Blue
                    '        lblexistencia.BackColor = Color.Blue
                    '    End If
                    'End If

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
            Variables.sSel = "exec proc_detalles_movimientos '" & Integer.Parse(Txtnumero.Text) & "','" & Me.CBConcepto.Text & "','" & Integer.Parse(Codigo1.Text) & "','" & Integer.Parse(Me.CBUbicacion.Text) & "','" & Me.TxtFecha_factu.Text & "','" & Integer.Parse(Cantidad1.Text) & "','" & Integer.Parse(precio1.Text) & "','" & Integer.Parse(Impuesto1.Text) & "','" & Integer.Parse(Descuento1.Text) & "',eliminar"
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(df)
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
        Me.Impuesto1.Text = "0"
        Me.Descuento1.Text = "0"
        Me.Unidad1.Text = "*"
        Me.precio1.Text = "0"
        Me.Cantidad1.Text = "0"
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Variables.app_buscar = "Terceros"
        field_buscar = "oc_tercero"
        Buscar.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Variables.app_buscar = "Productos"
        field_buscar = "oc_producto"
        Buscar.Show()
    End Sub
    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Variables.app_buscar = "Productos_CB"
        field_buscar = "oc_producto_CB"
        Buscar.Show()
    End Sub

    Private Sub CBConcepto_factu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBConcepto.SelectedIndexChanged
        LblConcepto.Text = F_asigna_nombre.Nombre_label("Conceptos", Me.CBConcepto.Text)
    End Sub

    Private Sub CBoxUbicacion_factu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBUbicacion.SelectedIndexChanged
        LblUbica.Text = F_asigna_nombre.Nombre_label("Ubicaciones", Me.CBUbicacion.Text)
    End Sub

    Private Sub TxtCodBarras_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodBarras.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Cantidad1.Text = "1"
            TBtnNuevodetalle_Click(TBtnNuevodetalle, e)
        End If
    End Sub

    Private Sub TxtCodBarras_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtCodBarras.TextChanged
        Variables.dt.Clear()
        If IsNumeric(TxtCodBarras.Text) Then
            Try
                Variables.sSel = "Select ncodigo_produ from tbl_productos where ncod_externo_produ = '" & Int64.Parse(TxtCodBarras.Text) & "'"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dt)
                Codigo1.Text = dt.Rows(i)("ncodigo_produ").ToString()    
            Catch ex As Exception
                Producto1.Text = "CODIGO DE BARRAS INCORRECTO"
                Unidad1.Text = ""
                precio1.Text = ""
                Descuento1.Text = ""
                Impuesto1.Text = ""
            End Try
        Else
            Producto1.Text = "Codigo debe ser numerico"
            Unidad1.Text = ""
            precio1.Text = ""
            Codigo1.Text = "0"
            Descuento1.Text = ""
            Impuesto1.Text = ""
        End If
    End Sub

End Class
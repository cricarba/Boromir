Imports System.Data
Imports System.Data.SqlClient
Public Class Buscar
    Dim i As Integer
    Public dr As DataRow

    Private Sub Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtBuscar.Text = ""
    End Sub

    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        Dim dtbuscar As New DataTable
        Select Case Variables.app_buscar
            Case "Ubicaciones"
                Dim filas() As DataRow
                Variables.sSel = "select * from tbl_ubicaciones"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dtbuscar)
                filas = dtbuscar.Select("cnombre_ubica LIKE '%" & Me.TxtBuscar.Text & "%'")
                Me.ListBuscar.Items.Clear()
                If filas.Length > 0 Then
                    For Each Me.dr In filas
                        'Me.ListBuscar.Items.Clear()
                        Me.ListBuscar.Items.Add(dr("ncodigo_ubica").ToString & "-" & dr("cnombre_ubica").ToString)
                    Next
                End If
            Case "Terceros"
                Dim filas() As DataRow
                Variables.sSel = "select * from tbl_terceros"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dtbuscar)
                filas = dtbuscar.Select("cnombre_terce LIKE '%" & Me.TxtBuscar.Text & "%'")
                Me.ListBuscar.Items.Clear()
                If filas.Length > 0 Then
                    For Each Me.dr In filas
                        'Me.ListBuscar.Items.Clear()
                        Me.ListBuscar.Items.Add(dr("ncodigo_terce").ToString & "-" & RTrim(dr("cnombre_terce").ToString) & " " & RTrim(dr("cnombre2_terce").ToString) & " " & RTrim(dr("capellido_terce").ToString))
                    Next
                End If
            Case "Productos"
                Dim filas() As DataRow
                Variables.sSel = "select * from tbl_productos"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dtbuscar)
                filas = dtbuscar.Select("cnombre_produ LIKE '%" & Me.TxtBuscar.Text & "%'")
                Me.ListBuscar.Items.Clear()
                If filas.Length > 0 Then
                    For Each Me.dr In filas
                        'Me.ListBuscar.Items.Clear()
                        Me.ListBuscar.Items.Add(dr("ncodigo_produ").ToString & "-" & dr("cnombre_produ").ToString)
                    Next
                End If
            Case "Productos_Cs"
                Dim filas() As DataRow
                Variables.sSel = "select * from tbl_productos  where ccombo_produ = 'SI'"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dtbuscar)
                filas = dtbuscar.Select("cnombre_produ LIKE '%" & Me.TxtBuscar.Text & "%'")
                Me.ListBuscar.Items.Clear()
                If filas.Length > 0 Then
                    For Each Me.dr In filas
                        'Me.ListBuscar.Items.Clear()
                        Me.ListBuscar.Items.Add(dr("ncodigo_produ").ToString & "-" & dr("cnombre_produ").ToString)
                    Next
                End If
            Case "Productos_CB"
                Dim filas() As DataRow
                Variables.sSel = "select * from tbl_productos"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dtbuscar)
                filas = dtbuscar.Select("cnombre_produ LIKE '%" & Me.TxtBuscar.Text & "%'")
                Me.ListBuscar.Items.Clear()
                If filas.Length > 0 Then
                    For Each Me.dr In filas
                        'Me.ListBuscar.Items.Clear()
                        Me.ListBuscar.Items.Add(dr("ncod_externo_produ").ToString & "-" & dr("cnombre_produ").ToString)
                    Next
                End If
            Case "Correos"
                Dim filas() As DataRow
                Variables.sSel = "select cemail_terce from tbl_terceros where cemail_terce <> 'correo@email.com'"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dtbuscar)
                filas = dtbuscar.Select
                filas = dtbuscar.Select("cemail_terce LIKE '%" & Me.TxtBuscar.Text & "%'")
                Me.ListBuscar.Items.Clear()
                If filas.Length > 0 Then
                    For Each Me.dr In filas
                        'Me.ListBuscar.Items.Clear()
                        Me.ListBuscar.Items.Add(dr("cemail_terce").ToString)
                    Next
                End If
            Case "Usuarios"
                Dim filas() As DataRow
                Variables.sSel = "select cnombre_usua from tbl_usuarios"
                Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                Variables.da.Fill(dtbuscar)
                filas = dtbuscar.Select
                filas = dtbuscar.Select("cnombre_usua LIKE '%" & Me.TxtBuscar.Text & "%'")
                Me.ListBuscar.Items.Clear()
                If filas.Length > 0 Then
                    For Each Me.dr In filas
                        'Me.ListBuscar.Items.Clear()
                        Me.ListBuscar.Items.Add(dr("cnombre_usua").ToString)
                    Next
                End If
        End Select
    End Sub
    Private Sub ListBuscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBuscar.SelectedIndexChanged
        Dim cadena, retorno As String
        Try
        cadena = ListBuscar.SelectedItem
        If field_buscar = "m_para" Or field_buscar = "m_cc" Or field_buscar = "m_cco" Then
            retorno = cadena
        Else
            retorno = cadena.Substring(0, (cadena.IndexOf("-")))
        End If

        Select Case field_buscar

            Case "t_tercero"
                Terceros.TxtCodigo_terce.Text = retorno
            Case "m_tercero"
                Mov_inventarios.TxtDocumento_terce_factu.Text = retorno
            Case "ct_tercero"
                Cotizaciones.TxtDocumento_terce_factu.Text = retorno
                Case "pd_tercero"
                    Pedidos.TxtDocumento_terce_factu.Text = retorno
                Case "u_tercero"
                    Usuarios.TxtTercero_usua.Text = retorno
            Case "m_para"
                Mensajes.TxtPara.Text = retorno
            Case "m_cc"
                Mensajes.TxtCC.Text = retorno
            Case "m_cco"
                Mensajes.TxtCCO.Text = retorno
            Case "m_producto"
                Mov_inventarios.Codigo1.Text = retorno
            Case "f_producto"
                Facturas.Codigo1.Text = retorno
            Case "c_producto"
                Productos.TxtComponente.Text = retorno
            Case "ct_producto"
                    Cotizaciones.Codigo1.Text = retorno
                Case "pd_producto"
                    Pedidos.Codigo1.Text = retorno
            Case "s_producto"
                Saldos.Txtcodigo_saldos.Text = retorno
            Case "f_tercero"
                Facturas.TxtDocumento_terce_factu.Text = retorno
            Case "a_usuario"
                Auditoria.TxtUsuario.Text = retorno
            Case "U_ubicacion"
                Ubicaciones.Txtcodigo.Text = retorno
            Case "U_tercero"
                Ubicaciones.TxtCedula_ubica.Text = retorno
            Case "f_productoCB"
                Facturas.TxtCodBarras.Text = retorno
            Case "oc_tercero"
                Ordenes_Compra.TxtDocumento_terce_factu.Text = retorno
            Case "oc_producto"
                Ordenes_Compra.Codigo1.Text = retorno
            Case "oc_producto_CB"
                Ordenes_Compra.TxtCodBarras.Text = retorno
            Case "pr_producto"
                Productos.Txtcodigo_produ.Text = retorno
            Case "pr_producto_CB"
                Productos.Txtcodigoext_produ.Text = retorno
        End Select
        Catch ex As Exception
            MsgBox("Error Asignar Codigo:" & ex.Message)
        End Try
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Me.Close()
    End Sub
End Class
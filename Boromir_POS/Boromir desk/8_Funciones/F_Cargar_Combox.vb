Imports System.Data
Imports System.Data.SqlClient
Module F_Cargar_Combox
    Dim i As Integer
    Public dtcargarcb As New DataTable
    '----------------------------------------------------------------------------------------------------------
    '----------------CARGAR COMBO BOX---------------------------------------------------------------------
    Public Sub cargar_undmed()
        Variables.sSel = "Select * from tbl_unidad_medida"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.filas_unidades = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub cargar_colores()
        Variables.sSel = "Select * from tbl_colores"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.filas_colores = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub cargar_categorias()
        Variables.sSel = "Select * from tbl_categorias"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.filas_categorias = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub cargar_marcas()
        Variables.sSel = "Select * from tbl_marcas"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.filas_marcas = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Cargar_turnos()
        Variables.sSel = "Select * from tbl_turnos"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.Filas_turno = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub Cargar_estados()
        Variables.sSel = "Select * from tbl_estados"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.Filas_estado = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Cargar_Ubicaciones()
        Variables.sSel = "Select * from tbl_ubicaciones"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.Filas_ubicaciones = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Cargar_Periles()
        Variables.sSel = "Select * from tbl_perfiles"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.Filas_perfil = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub
    Public Sub Cargar_TipoDoc()
        Variables.sSel = "Select * from tbl_tipodoc"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.Filas_tipodoc = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Cargar_TipoEscenario()
        Variables.sSel = "Select * from tbl_tescenarios"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.Filas_escenarios = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Cargar_TEscenXubica()
        Variables.sSel = "Select ctipo_escen from tbl_escenarios where ncod_ubica_escen = '" & Costo_Turno.CBubic_tabla_costo.Text & "'group by ctipo_escen"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.Filas_escenarios = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Cargar_Ciudad()
        Variables.sSel = "Select * from tbl_ciudad"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.Filas_ciudad = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Cargar_Zonas()
        Variables.sSel = "select * from tbl_zonas where ncod_ciudad_zona = '" & Variables.codigo & "'"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.Filas_zonas = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub Cargar_Tipo_Costo()
        Variables.sSel = "Select * from tbl_tipocosto where ncod_ubica_tcosto = '" & Costo_Turno.CBubic_tabla_costo.Text & "'"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.Filas_tipo_costo = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Cargar_Tipo_Costo_turno()
        Variables.sSel = "Select * from tbl_tipocosto where ncod_ubica_tcosto = '" & Costo_Turno.CBubic_tabla_costo.Text & "'"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.Filas_tipo_costo = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub cargar_aplicaciones()
        Variables.sSel = "Select * from tbl_aplicaciones"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.filas_aplicaciones = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Public Sub Cargar_Conceptos()
        Variables.sSel = "Select * from tbl_conceptos where ccod_aplic_conce = '" & Variables.aplic & "'"
        Try
            Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
            Variables.da.Fill(dtcargarcb)
            Variables.Filas_conceptos = dtcargarcb.Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    '----------------------------------------------------------------------------------------------------------
    '----------------FIN CARGAR COMBO BOX---------------------------------------------------------------------
End Module

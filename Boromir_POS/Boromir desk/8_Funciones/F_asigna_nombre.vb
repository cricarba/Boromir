Imports System.Data
Imports System.Data.SqlClient
Module F_asigna_nombre
    Public Function Nombre_label(ByVal Aplicacion As String, ByVal codigo As String)
        Dim retorno, app, cod As String
        Dim i As Integer
        Dim dtlabel As New DataTable
        app = Aplicacion
        cod = codigo
        retorno = ""
        Select Case app
            Case "Tipo Escenarios"
                Try
                    Variables.sSel = "Select cnombre_tescen from tbl_tescenarios where ccodigo_tescen ='" & cod & "'"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    retorno = dtlabel.Rows(i)("cnombre_tescen").ToString()
                Catch ex As Exception
                    MsgBox("Error Nombre_label: " & ex.Message)
                End Try
            Case "Tipo Costo"
                Try
                    'Variables.sSel = "Select * from tbl_tipocosto where ccodigo_tcosto ='" & Tipo_Costo.TxtCodigo_costo.Text & "'"
                    'Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    'Variables.da.Fill(dtlabel)
                    'Tipo_Costo.CBubic_tipocost.Text = dtlabel.Rows(i)("ncod_ubica_tcosto").ToString()
                    'Tipo_Costo.TxValor_costo.Text = dtlabel.Rows(i)("mvalor_tcosto").ToString()

                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            Case "Conceptos"
                Try
                    Variables.sSel = "Select cnombre_conce from tbl_conceptos where ccodigo_conce ='" & cod & "'"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    retorno = dtlabel.Rows(i)("cnombre_conce").ToString()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            Case "Documentos"
                Try
                    Variables.sSel = "Select cnombre_tipodoc from tbl_tipodoc where ccodigo_tipodoc = '" & cod & "' "
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    retorno = dtlabel.Rows(i)("cnombre_tipodoc").ToString()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            Case "Ciudades"
                Try
                    Variables.sSel = "Select cnombre_ciudad from tbl_ciudad where ncodigo_ciudad = '" & Integer.Parse(cod) & "'"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    retorno = dtlabel.Rows(i)("cnombre_ciudad").ToString()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            Case "Zonas"
                Try
                    Variables.sSel = "Select cnombre_zona from tbl_zonas where ncod_ciudad_zona ='" & Integer.Parse(cod) & "' AND ncodigo_zona = '" & Ubicaciones.CBoxCiudad_ubica.Text & "'"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    retorno = dtlabel.Rows(i)("cnombre_zona").ToString()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            Case "Terceros"
                Try
                    Variables.sSel = "Select cnombre_terce,cnombre2_terce,capellido_terce,capellido2_terce from tbl_terceros where ncodigo_terce ='" & Integer.Parse(cod) & "'"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    retorno = dtlabel.Rows(i)("cnombre_terce").ToString() & " " & dtlabel.Rows(i)("cnombre2_terce").ToString() & " " & dtlabel.Rows(i)("capellido_terce").ToString() & " " & dtlabel.Rows(i)("capellido2_terce").ToString()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            Case "Ubicaciones"
                Try
                    Variables.sSel = "Select cnombre_ubica from tbl_ubicaciones, tbl_terceros where ncodigo_ubica ='" & Integer.Parse(cod) & "'"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    retorno = dtlabel.Rows(i)("cnombre_ubica").ToString()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            Case "Escenario X ubicacion"
                Try
                    Variables.sSel = "Select cnombre_escen from tbl_escenarios where  ncod_ubica_escen = '" & cod & "'"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    EscenarioXubica.TxtNombre_EXU.Text = dtlabel.Rows(i)("cnombre_escen").ToString()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            Case "Perfiles"
                Try
                    Variables.sSel = "Select cnombre_perfil from tbl_perfiles where ncodigo_perfil ='" & Integer.Parse(cod) & "' "
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    retorno = dtlabel.Rows(i)("cnombre_perfil").ToString()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            Case "Usuarios"
                Try
                    Variables.sSel = "Select ncod_terce_usua from tbl_usuarios where cnombre_usua ='" & cod & "' "
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    retorno = dtlabel.Rows(i)("ncod_terce_usua").ToString()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            Case "Empresa"
                Try
                    Variables.sSel = "select cnombre_empre from tbl_empresa"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    retorno = dtlabel.Rows(i)("cnombre_empre").ToString
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            Case "Productos"
                Try
                    Variables.sSel = "select cnombre_produ from tbl_productos where ncodigo_produ = '" & Integer.Parse(cod) & "'"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    retorno = dtlabel.Rows(i)("cnombre_produ").ToString
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            Case "Estados"
                Try
                    Variables.sSel = "select cnombre_estad from tbl_estados where ncodigo_estad = '" & Integer.Parse(cod) & "'"
                    Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
                    Variables.da.Fill(dtlabel)
                    retorno = dtlabel.Rows(i)("cnombre_estad").ToString
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
        End Select
        Return RTrim(retorno)
    End Function
End Module

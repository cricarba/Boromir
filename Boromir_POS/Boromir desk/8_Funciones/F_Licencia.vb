Imports System.Data
Imports System.Data.SqlClient
Module F_Licencia
    Public Sub licencia_modulos()
        Dim dtlicencia As New DataTable
        Dim n1, n2, n3, n4, n5, n6, serial As Integer
        Dim modulo As String
        Variables.sSel = "select * from tbl_modulos"
        Variables.da = New SqlDataAdapter(Variables.sSel, Variables.sCnn)
        Variables.da.Fill(dtlicencia)
        For i = 0 To dtlicencia.Rows.Count - 1
            modulo = dtlicencia.Rows(i)("ccodigo_modul").ToString
            n1 = dtlicencia.Rows(i)("nuno_modul").ToString
            n2 = dtlicencia.Rows(i)("ndos_modul").ToString
            n3 = dtlicencia.Rows(i)("ntres_modul").ToString
            n4 = dtlicencia.Rows(i)("ncuatro_modul").ToString
            n5 = dtlicencia.Rows(i)("ncinco_modul").ToString
            n6 = dtlicencia.Rows(i)("nseis_modul").ToString
            serial = n1 + n2 - n3 + n4 - n5 + n6

            If modulo = "ADMIN" Then
                If serial = 22 Or serial = 26 Then
                    Boromir.Modul_admin.Enabled = True
                Else
                    Boromir.Modul_admin.Enabled = False
                End If
            End If

            If modulo = "FACTU" Then
                If serial = 22 Or serial = 26 Then
                    Boromir.Modul_Factu.Enabled = True
                Else
                    Boromir.Modul_Factu.Enabled = False
                End If
            End If

            If modulo = "INVEN" Then
                If serial = 22 Or serial = 26 Then
                    Boromir.Modul_Inven.Enabled = True
                Else
                    Boromir.Modul_Inven.Enabled = False
                End If
            End If

            If modulo = "REPOR" Then
                If serial = 22 Or serial = 26 Then
                    Boromir.Modul_Repor.Enabled = True
                Else
                    Boromir.Modul_Repor.Enabled = False
                End If
            End If

            If modulo = "SEGUR" Then
                If serial = 22 Or serial = 26 Then
                    Boromir.Modul_Segur.Enabled = True
                Else
                    Boromir.Modul_Segur.Enabled = False
                End If
            End If
        Next
    End Sub

    Public Function Confirma_Licencia(ByVal sn1 As Integer, ByVal sn2 As Integer, ByVal sn3 As Integer, ByVal sn4 As Integer, ByVal sn5 As Integer, ByVal sn6 As Integer)
        Dim sn As Integer
        sn = sn1 + sn2 - sn3 + sn4 - sn5 + sn6
        Return sn
    End Function

End Module

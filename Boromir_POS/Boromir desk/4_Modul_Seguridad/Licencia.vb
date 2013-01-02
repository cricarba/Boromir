Public Class Licencia
    Dim sn As Integer
    Private Sub BtnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdmin.Click
        sn = F_Licencia.Confirma_Licencia(Integer.Parse(a1.Text), Integer.Parse(a2.Text), Integer.Parse(a3.Text), Integer.Parse(a4.Text), Integer.Parse(a5.Text), Integer.Parse(a6.Text))
        If sn = 22 Or sn = 26 Then
            a1.BackColor = Color.LightGreen
            a2.BackColor = Color.LightGreen
            a3.BackColor = Color.LightGreen
            a4.BackColor = Color.LightGreen
            a5.BackColor = Color.LightGreen
            a6.BackColor = Color.LightGreen
        Else
            a1.BackColor = Color.OrangeRed
            a2.BackColor = Color.OrangeRed
            a3.BackColor = Color.OrangeRed
            a4.BackColor = Color.OrangeRed
            a5.BackColor = Color.OrangeRed
            a6.BackColor = Color.OrangeRed
        End If
    End Sub

    Private Sub BtnInven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInven.Click
        sn = F_Licencia.Confirma_Licencia(Integer.Parse(i1.Text), Integer.Parse(i2.Text), Integer.Parse(i3.Text), Integer.Parse(i4.Text), Integer.Parse(i5.Text), Integer.Parse(i6.Text))
        If sn = 22 Or sn = 26 Then
            i1.BackColor = Color.LightGreen
            i2.BackColor = Color.LightGreen
            i3.BackColor = Color.LightGreen
            i4.BackColor = Color.LightGreen
            i5.BackColor = Color.LightGreen
            i6.BackColor = Color.LightGreen
        Else
            i1.BackColor = Color.OrangeRed
            i2.BackColor = Color.OrangeRed
            i3.BackColor = Color.OrangeRed
            i4.BackColor = Color.OrangeRed
            i5.BackColor = Color.OrangeRed
            i6.BackColor = Color.OrangeRed
        End If
    End Sub

    Private Sub BtnFactu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFactu.Click
        sn = F_Licencia.Confirma_Licencia(Integer.Parse(f1.Text), Integer.Parse(f2.Text), Integer.Parse(f3.Text), Integer.Parse(f4.Text), Integer.Parse(f5.Text), Integer.Parse(f6.Text))
        If sn = 22 Or sn = 26 Then
            f1.BackColor = Color.LightGreen
            f2.BackColor = Color.LightGreen
            f3.BackColor = Color.LightGreen
            f4.BackColor = Color.LightGreen
            f5.BackColor = Color.LightGreen
            f6.BackColor = Color.LightGreen
        Else
            f1.BackColor = Color.OrangeRed
            f2.BackColor = Color.OrangeRed
            f3.BackColor = Color.OrangeRed
            f4.BackColor = Color.OrangeRed
            f5.BackColor = Color.OrangeRed
            f6.BackColor = Color.OrangeRed
        End If
    End Sub

    Private Sub BtnRepor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRepor.Click
        sn = F_Licencia.Confirma_Licencia(Integer.Parse(r1.Text), Integer.Parse(r2.Text), Integer.Parse(r3.Text), Integer.Parse(r4.Text), Integer.Parse(r5.Text), Integer.Parse(r6.Text))
        If sn = 22 Or sn = 26 Then
            r1.BackColor = Color.LightGreen
            r2.BackColor = Color.LightGreen
            r3.BackColor = Color.LightGreen
            r4.BackColor = Color.LightGreen
            r5.BackColor = Color.LightGreen
            r6.BackColor = Color.LightGreen
        Else
            r1.BackColor = Color.OrangeRed
            r2.BackColor = Color.OrangeRed
            r3.BackColor = Color.OrangeRed
            r4.BackColor = Color.OrangeRed
            r5.BackColor = Color.OrangeRed
            r6.BackColor = Color.OrangeRed
        End If
    End Sub

    Private Sub Btnsegur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsegur.Click
        sn = F_Licencia.Confirma_Licencia(Integer.Parse(s1.Text), Integer.Parse(s2.Text), Integer.Parse(s3.Text), Integer.Parse(s4.Text), Integer.Parse(s5.Text), Integer.Parse(s6.Text))
        If sn = 22 Or sn = 26 Then
            s1.BackColor = Color.LightGreen
            s2.BackColor = Color.LightGreen
            s3.BackColor = Color.LightGreen
            s4.BackColor = Color.LightGreen
            s5.BackColor = Color.LightGreen
            s6.BackColor = Color.LightGreen
        Else
            s1.BackColor = Color.OrangeRed
            s2.BackColor = Color.OrangeRed
            s3.BackColor = Color.OrangeRed
            s4.BackColor = Color.OrangeRed
            s5.BackColor = Color.OrangeRed
            s6.BackColor = Color.OrangeRed
        End If
    End Sub
End Class
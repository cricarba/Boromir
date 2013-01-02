Imports Microsoft.Reporting.WinForms
Imports System.Data
Imports System.Data.SqlClient

Public Class Vista_Previa
    Private Sub Report_Factu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ReportViewer1.ProcessingMode = ProcessingMode.Local
        'ReportViewer1.LocalReport.ReportPath = "D:\Boromir\Boromir\Boromir desk\6_Modul_Reportes\r_inv_movimientos.rdlc"
        'Me.ReportViewer1.LocalReport.DataSources.Clear()
        'Dim ds As New DataSet()
        'Variables.sSel = "Select * from tbl_facturas,tbl_detalle_movimientos,tbl_productos ,tbl_movimiento_producto"
        'Variables.da = (New SqlDataAdapter(sSel, sCnn))
        'Variables.da.Fill(ds)
        'Dim datasource As New ReportDataSource("Mov_x_prod", ds.Tables(0))
        'Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        ' ''Le indicamos al Control que la invocación del reporte será de modo remoto
        ' ''Le indicamos la URL donde se encuentra hospedado Reporting Services
        ' ''ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://localhost/ReportServer")
        ' ''/Le indicamos la carpeta y el Reporte que deseamos Ver

        ''//Definimos los parámetros
        ''Dim numero = New ReportParameter("numero", "7")
        ''Dim concepto = New ReportParameter("concepto", "FV")
        ''listrepor.Add(numero)
        ''listrepor.Add(concepto)
        ' ''numero.Name = "numero"
        ' ''numero.Values.Add("7")
        ' '' //Aqui le indicaremos si queremos que el parámetro 
        ' '' '' //sea visible para el usuario o no
        ''numero.Visible = False
        ''concepto.Visible = False
        ''ReportViewer1.LocalReport.SetParameters(listrepor)
        'Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class
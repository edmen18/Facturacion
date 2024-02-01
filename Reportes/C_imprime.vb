Public Class C_imprime

    Sub reporte(ByVal dsobj As System.Data.DataSet, ByVal report As Object, ByVal titulo As String)
        Dim frmrepDev As New frm_preview
        report.DataSource = dsobj
        report.CreateDocument()
        frmrepDev.Text = titulo
        frmrepDev.RibbonControl1.PrintingSystem = report.PrintingSystem
        frmrepDev.Show()
    End Sub

    Sub reporteTipado(ByVal report As Object, ByVal titulo As String)
        Dim frmrepDev As New frm_preview
        report.CreateDocument()
        frmrepDev.Text = titulo
        frmrepDev.RibbonControl1.PrintingSystem = report.PrintingSystem
        frmrepDev.Show()
    End Sub

    Sub reporteIntegrado(ByVal dsobj As System.Data.DataSet, ByVal report As Object, ByVal titulo As String, ByVal padre As Object)
        Dim frmrepDev As New frm_preview
        report.DataSource = dsobj
        report.CreateDocument()
        frmrepDev.Text = titulo
        frmrepDev.RibbonControl1.PrintingSystem = report.PrintingSystem
        frmrepDev.MdiParent = padre
        frmrepDev.Show()
    End Sub

End Class

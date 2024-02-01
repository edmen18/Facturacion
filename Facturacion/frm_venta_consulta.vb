Imports Logica
Imports Reportes
Public Class frm_venta_consulta
    'Dim Venta As New cl_venta_detalle
    Dim DetalleVenta As New cl_venta_detalle
    Dim Imprimir As New C_imprime

    Private Sub frm_venta_detalle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DetalleVenta.Listar_Venta_General(dgvVenta)
        HeadGrid()
    End Sub

    Sub HeadGrid()

        With gvVenta
            .Columns(8).Group()
            '.ExpandAllGroups()
        End With

    End Sub

    Private Sub cmExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles cmExportarExcel.Click
        sfdRuta.Filter = "Archivos Excel | *.xlsx"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            dgvVenta.ExportToXlsx(sfdRuta.FileName)
        End If
    End Sub

    Private Sub cmExportarPdf_Click(sender As System.Object, e As System.EventArgs) Handles cmExportarPdf.Click
        sfdRuta.Filter = "Archivos Pdf | *.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            dgvVenta.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub

    Private Sub cmImprimir_Click(sender As System.Object, e As System.EventArgs) Handles cmImprimir.Click
        dgvVenta.ShowRibbonPrintPreview()
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        dgvVenta.ShowRibbonPrintPreview()
    End Sub
End Class
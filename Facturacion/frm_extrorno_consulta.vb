Imports Logica

Public Class frm_extrorno_consulta
    Dim Venta As New cl_venta

    Private Sub frm_extrorno_consulta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListarVentas()
    End Sub

    Private Sub dgvVenta_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvVenta.DoubleClick
        ExtornarIngreso()
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

    Public Sub ListarVentas()
        Venta.Listar_Venta_General(dgvVenta)
    End Sub

  
    Private Sub btnExtornar_Click(sender As System.Object, e As System.EventArgs) Handles btnExtornar.Click
        ExtornarIngreso()
    End Sub

    Sub ExtornarIngreso()
        With frm_extorno_registra
            .txtVenta.EditValue = ObtenerItemDevGrid("codi_vent", gvVenta)
            .txtMonto.EditValue = ObtenerItemDevGrid("tota_vent", gvVenta)
            .txtEmpleado.Text = UsuarioActivo.IdUsuario
            .ShowDialog()
        End With
    End Sub
End Class
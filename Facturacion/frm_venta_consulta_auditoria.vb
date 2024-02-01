Imports Logica
Imports Reportes
Public Class frm_venta_consulta_auditoria
    Dim Venta As New cl_venta
    Dim DetalleVenta As New cl_venta_detalle
    Dim Imprimir As New C_imprime
    Public flg As Char

    Private Sub frm_venta_detalle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListarVentasActivas()
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        RegistraAuditoria()
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

    Private Sub cmObservar_Click(sender As Object, e As EventArgs) Handles cmObservar.Click
        RegistraAuditoria()
    End Sub

    Sub ListarVentasActivas()
        DetalleVenta.ConsultaVentaDetalleAuditoria(dgvVenta, 1)
    End Sub

    Sub RegistraAuditoria()
        Dim form_Auditoria As New frm_auditoria

        If Not IsDBNull(ObtenerItemDevGrid("esta_audi", gvVenta)) Then
            flg = "E"
            With form_Auditoria
                .txtCodigo.EditValue = ObtenerItemDevGrid("id_audi", gvVenta)
                .txtVenta.EditValue = ObtenerItemDevGrid("codi_vent", gvVenta)
                .txtMonto.EditValue = ObtenerItemDevGrid("tota_vent", gvVenta)
                .txtEmpleado.Text = UsuarioActivo.IdUsuario
                .cmbEstado.Text = ObtenerItemDevGrid("esta_audi", gvVenta)
                .meObservacion.EditValue = ObtenerItemDevGrid("nota_audi", gvVenta)
                .btnRegistrar.Text = "Actualizar"
                .ShowDialog()
            End With

        Else
            flg = "I"
            With form_Auditoria
                .txtVenta.EditValue = ObtenerItemDevGrid("codi_vent", gvVenta)
                .txtMonto.EditValue = ObtenerItemDevGrid("tota_vent", gvVenta)
                .txtEmpleado.Text = UsuarioActivo.IdUsuario
                .ShowDialog()
            End With
        End If

      
    End Sub

End Class
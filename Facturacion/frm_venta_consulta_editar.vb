Imports Logica
Imports Reportes
Public Class frm_venta_consulta_editar
    Dim Venta As New cl_venta
    Dim DetalleVenta As New cl_venta_detalle
    Dim Imprimir As New C_imprime


    Private Sub dgvVenta_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvVenta.DoubleClick
        Try
            DetalleVenta.CodigoVenta = ObtenerItemDevGrid("codi_vent", gvVenta)
            DetalleVenta.Listar_Venta_Detalle(dgvDetalle, 1)
            HeadGridDetalle()
        Catch ex As Exception
        End Try
    End Sub

#Region "Look Grid"
    Sub HeadGrid()
        With gvVenta
            .Columns(0).Width = 80
            .Columns(0).Caption = "CODIGO"
            .Columns(1).Width = 180
            .Columns(1).Caption = "NOMBRE DE CLIENTE"
            .Columns(2).Caption = "DOCUMENTO"
            .Columns(3).Caption = "NRO. DOCUMENTO"
            .Columns(4).Caption = "FORMA DE PAGO"
            .Columns(5).Caption = "FECHA"
            .Columns(6).Caption = "SUBTOTAL"
            .Columns(7).Caption = "IGV"
            .Columns(8).Caption = "TOTAL"
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False

        End With

    End Sub

    Sub HeadGridDetalle()
        Try
            With gvDetalle
                .Columns(0).Width = 50
                .Columns(0).Caption = "ITEM"
                .Columns(2).Width = 350
                .Columns(2).Caption = "DESCRIPCION DE PRODUCTO/SERVICIO"
                .Columns(3).Caption = "UNIDAD"
                .Columns(4).Caption = "CANTIDAD"
                .Columns(5).Caption = "VALOR"
                .Columns(9).Caption = "SUBTOTAL"

                .Columns(1).Visible = False
                .Columns(3).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
            End With

        Catch ex As Exception
        End Try
    End Sub
#End Region

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


    Private Sub frm_venta_consulta_editar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Venta.Listar_Venta_Head(dgvVenta, 2)
        HeadGrid()
    End Sub

    Private Sub btnISeleccionar_Click(sender As System.Object, e As System.EventArgs) Handles btnISeleccionar.Click
        With frm_venta_editar

            'Llenar el Encabezado de la Venta
            .txtCodigo.EditValue = ObtenerItemDevGrid("codi_vent", gvVenta)
            .txtCodCli.EditValue = ObtenerItemDevGrid("codi_clie", gvVenta)
            .txtCliente.EditValue = ObtenerItemDevGrid("nomb_clie", gvVenta)
            .cmbDocVenta.EditValue = ObtenerItemDevGrid("id_dove", gvVenta)
            .txtNumDoc.EditValue = ObtenerItemDevGrid("nudo_vent", gvVenta)
            .dtpFecha.EditValue = ObtenerItemDevGrid("fech_vent", gvVenta)
            .cmbFormaPago.EditValue = ObtenerItemDevGrid("id_fopa", gvVenta)
            .txtNota.EditValue = ObtenerItemDevGrid("nota_vent", gvVenta)
            .txtSubtotal.EditValue = ObtenerItemDevGrid("subt_vent", gvVenta)
            .txtIgv.EditValue = ObtenerItemDevGrid("toiv_vent", gvVenta)
            .txtTotal.EditValue = ObtenerItemDevGrid("tota_vent", gvVenta)
            .lblMontoLetras.Text = "SON: " + Convertir(CDbl(.txtTotal.EditValue))
            .cmbBanco.EditValue = ObtenerItemDevGrid("id_banc", gvVenta)
            .txtNumCheque.EditValue = ObtenerItemDevGrid("nudo_fopa", gvVenta)
            .btnBuscarVenta.Enabled = False

            'Llenar el detalle de la Venta

            '.gvDetalle.SelectAll()
            '.gvDetalle.DeleteSelectedRows()

            For i = 0 To gvDetalle.RowCount - 1
                .gvDetalle.AddNewRow()

                Dim fila = .gvDetalle.FocusedRowHandle()
                Dim xrow = gvDetalle.GetVisibleRowHandle(i)

                .gvDetalle.SetRowCellValue(fila, "ITEM", gvDetalle.GetRowCellValue(xrow, "item_veda"))
                .gvDetalle.SetRowCellValue(fila, "CODPROD", gvDetalle.GetRowCellValue(xrow, "codi_prod"))
                .gvDetalle.SetRowCellValue(fila, "DESCRIPCION_DEL_PRODUCTO", gvDetalle.GetRowCellValue(xrow, "nomb_prod"))
                .gvDetalle.SetRowCellValue(fila, "CODUNI", gvDetalle.GetRowCellValue(xrow, "codi_unid"))
                .gvDetalle.SetRowCellValue(fila, "CANTIDAD", gvDetalle.GetRowCellValue(xrow, "capr_veda"))
                .gvDetalle.SetRowCellValue(fila, "VALOR", gvDetalle.GetRowCellValue(xrow, "vaun_veda"))
                .gvDetalle.SetRowCellValue(fila, "VALIGV", gvDetalle.GetRowCellValue(xrow, "vaiv_veda"))
                .gvDetalle.SetRowCellValue(fila, "TOTIGV", gvDetalle.GetRowCellValue(xrow, "toiv_veda"))
                .gvDetalle.SetRowCellValue(fila, "SUBT", gvDetalle.GetRowCellValue(xrow, "impo_veda"))
                .gvDetalle.SetRowCellValue(fila, "TOTAL", gvDetalle.GetRowCellValue(xrow, "tota_veda"))

            Next
        End With
        Me.Close()
    End Sub
End Class
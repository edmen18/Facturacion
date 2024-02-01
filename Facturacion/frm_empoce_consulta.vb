Imports Logica
Imports Reportes
Public Class frm_empoce_consulta
    Dim Empoce As New cl_empoce
    Dim Imprimir As New C_imprime

    Private Sub frm_empoce_consulta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Empoce.Listar_Empoce(dgEmpoce, 0)
        HeadGridEmpoce()
        IniciarValores()
    End Sub

#Region "Funciones de control"
    Private Sub dgEmpoce_DoubleClick(sender As Object, e As System.EventArgs) Handles dgEmpoce.DoubleClick
        Empoce.NumeroPapeleta = ObtenerItemDevGrid("nupa_empo", gvEmpoce)
        Empoce.Listar_Empoce_Detalle(dgDetalle)
        HeadGridDetalle()
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Dim repEmpoce As New xrcEmpoces
        Dim numPapeleta As String = ObtenerItemDevGrid("nupa_empo", gvEmpoce)
        Imprimir.reporte(Empoce.ReporteEmpoce(numPapeleta), repEmpoce, "Listado de empoces")
    End Sub

    Private Sub btnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultar.Click
        Empoce.Listar_Empoce(dgEmpoce, 1, dtpDesde.EditValue, dtpHasta.EditValue)
    End Sub

    Private Sub cmExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles cmExportarExcel.Click
        sfdRuta.Filter = "Archivos Excel | *.xlsx"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            dgEmpoce.ExportToXlsx(sfdRuta.FileName)
        End If
    End Sub

    Private Sub cmExportarPdf_Click(sender As System.Object, e As System.EventArgs) Handles cmExportarPdf.Click
        sfdRuta.Filter = "Archivos Pdf | *.pdf"
        If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            dgEmpoce.ExportToPdf(sfdRuta.FileName)
        End If
    End Sub

    Private Sub cmImprimir_Click(sender As System.Object, e As System.EventArgs) Handles cmImprimir.Click
        dgEmpoce.ShowRibbonPrintPreview()
    End Sub


#End Region

    Sub IniciarValores()
        Me.dtpDesde.EditValue = Date.Today
        Me.dtpHasta.EditValue = Date.Today
    End Sub

#Region "Look Grid"
    Sub HeadGridEmpoce()
        gvEmpoce.Columns(0).Width = 80
        gvEmpoce.Columns(0).Caption = "NRO. PAPELETA"
        gvEmpoce.Columns(1).Caption = "F. EMPOCE"
        gvEmpoce.Columns(2).Caption = "CUENTA"
        gvEmpoce.Columns(3).Caption = "MONTO"
    End Sub

    Sub HeadGridDetalle()
        With gvDetalle
            .Columns(0).Visible = False
            .Columns(1).Caption = "VENTA"
            .Columns(2).Caption = "DOCUMENTO DE INGRESO"
            .Columns(3).Caption = "NRO. DOCUMENTO"
            .Columns(4).Caption = "TOTAL"

            .Columns(4).SummaryItem.FieldName = "tota_vent"
            .Columns(4).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns(4).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        End With
    End Sub
#End Region
End Class
Imports Logica
Imports System.Data
Imports DevExpress.XtraCharts

Public Class frm_grafico_ingresos

    Dim Venta As New cl_venta

    Private Sub frm_grafico_ingresos_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Venta.Listar_Venta_grafico(Chart, fdesde, fhasta)
    End Sub

End Class
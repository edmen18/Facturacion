Imports Logica

Public Class frm_producto_consulta
    Dim Producto As New cl_producto
    Public flag As Byte


    Private Sub frm_producto_consulta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Producto.Listar_Producto(dgvProducto, 0)
        HeadGrid()
    End Sub


    Private Sub dgvProducto_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvProducto.DoubleClick
        If flag = 0 Then
            With frm_venta
                .txtCodProd.Text = ObtenerItemDevGrid("codi_prod", gvProducto)
                .txtProducto.Text = ObtenerItemDevGrid("nomb_prod", gvProducto)
                .txtPrecio.EditValue = ObtenerItemDevGrid("prec_prod", gvProducto)
            End With
        Else
            With frm_venta_editar
                .txtCodProd.Text = ObtenerItemDevGrid("codi_prod", gvProducto)
                .txtProducto.Text = ObtenerItemDevGrid("nomb_prod", gvProducto)
                .txtPrecio.EditValue = ObtenerItemDevGrid("prec_prod", gvProducto)
            End With
        End If
       
        Me.Close()
    End Sub


    Private Sub txtDato_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtDato.EditValueChanged
        Producto.Listar_Producto(dgvProducto, 1, Me.txtDato.EditValue)
    End Sub

#Region "Look Grid"
    Sub HeadGrid()
        gvProducto.Columns(0).Width = 80
        gvProducto.Columns(0).Caption = "CODIGO"
        gvProducto.Columns(1).Width = 250
        gvProducto.Columns(1).Caption = "DESCRIPCION DE PRODUCTO"
        gvProducto.Columns(2).Caption = "TIPO PRODUCTO"
        gvProducto.Columns(3).Caption = "COSTO"
        gvProducto.Columns(4).Caption = "PRECIO"
        gvProducto.Columns(5).Caption = "IMPUESTO"

        gvProducto.Columns(2).Visible = False
        gvProducto.Columns(3).Visible = False
        gvProducto.Columns(4).Visible = False
        gvProducto.Columns(5).Visible = False
    End Sub
#End Region

    
End Class
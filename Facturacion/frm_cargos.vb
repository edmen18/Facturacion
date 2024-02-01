Imports Logica

Public Class frm_cargos
    Dim Cargo As New cl_cargo
    Dim flg As Byte


    Private Sub frm_cargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargo.Listar_Cargos(gcCargos)
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        flg = 0
        Me.txt_descripcion.Text = ""
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        Cargo.Descripcion = Me.txt_descripcion.EditValue
        Cargo.Codigo = Me.txt_codigo.EditValue
        If flg = 0 Then
            Cargo.AgregarCargo()
        Else
            Cargo.ActualizaCargo()
        End If
        Cargo.Listar_Cargos(gcCargos)
    End Sub

    Private Sub gcCargos_DoubleClick(sender As Object, e As EventArgs) Handles gcCargos.DoubleClick
        Me.txt_codigo.Text = ObtenerItemDevGrid("id_carg", gvCargos)
        Me.txt_descripcion.Text = ObtenerItemDevGrid("desc_carg", gvCargos)
        flg = 1
    End Sub

    Private Sub btnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminar.ItemClick
        Cargo.Codigo = Me.txt_codigo.EditValue
        Cargo.EliminaCargo()
        Cargo.Listar_Cargos(gcCargos)
    End Sub

    Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub
End Class
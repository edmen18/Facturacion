Imports Logica
Imports DevExpress.XtraBars

Public Class frm_empleados_permisos
    Dim Empleado As New cl_usuarios
    Dim Permisos As New cl_usuarios_permisos


    Private Sub frm_empleados_permisos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Empleado.ListarModulos(gcModulos)
        CreaColumnsPermisos()
    End Sub

    Sub CreaColumnsPermisos()
        Dim dtAuxi As New Data.DataTable
        dtAuxi.Columns.Add("codi_empl")
        dtAuxi.Columns.Add("id_moduper")
        dtAuxi.Columns.Add("des_moduper")
        gcPermisos.DataSource = dtAuxi
    End Sub

    Private Sub btnAsignar_Click(sender As System.Object, e As System.EventArgs) Handles btnAsignar.Click

        Dim Modulo = CStr(ObtenerItemDevGrid("id_modu", gvModulos))

        If Not BuscarDuplicado(Modulo, gvPermisos, "id_moduper") Then
            gvPermisos.AddNewRow()
            Dim fila = gvPermisos.FocusedRowHandle()
            gvPermisos.SetRowCellValue(fila, "codi_empl", lblId.Text)
            gvPermisos.SetRowCellValue(fila, "id_moduper", CStr(ObtenerItemDevGrid("id_modu", gvModulos)))
            gvPermisos.SetRowCellValue(fila, "des_moduper", CStr(ObtenerItemDevGrid("nomb_modu", gvModulos)))
            gvPermisos.UpdateCurrentRow()
            gvModulos.DeleteSelectedRows()
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        Dim pregunta As DialogResult
        pregunta = MessageBox.Show("Desea continuar con el registro del elemento", "Registros", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pregunta = DialogResult.Yes Then
            Permisos.AgregarPermisosUsuario(lblId.Text, gvPermisos)
            MessageBox.Show("El registro se realizó satisfactoriamente", "SIF", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Sub LLenarGridModulos()
    '    For Each Elemento As Object In Principal.RibbonControl.Items
    '        Dim TipoElemento As Type = Elemento.GetType

    '        If TipoElemento.FullName = "DevExpress.XtraBars.BarButtonItem" Then
    '            Dim BarButton As BarButtonItem = DirectCast(Elemento, BarButtonItem)

    '            'gvModulos.AddNewRow()

    '            MsgBox(BarButton.Caption & " " & BarButton.Tag)

    '            'Dim fila = gvModulos.FocusedRowHandle()

    '            'gvModulos.SetRowCellValue(fila, "gc_id_modu", CStr(BarButton.Tag))
    '            'gvModulos.SetRowCellValue(fila, "gc_nomb_modu", CStr(BarButton.Caption))
    '            ''
    '            'gvModulos.UpdateCurrentRow()


    '        End If
    '    Next
    'End Sub


    Private Sub btnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitar.Click

        If gvPermisos.RowCount > 0 Then
            gvPermisos.DeleteSelectedRows()
        Else
            MessageBox.Show("No hay ingresos que remover", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

    End Sub

    Private Sub btnRefrescar_Click(sender As System.Object, e As System.EventArgs) Handles btnRefrescar.Click
        Empleado.ListarModulos(gcModulos)
    End Sub
End Class
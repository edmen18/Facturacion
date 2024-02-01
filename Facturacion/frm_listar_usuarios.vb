Imports Logica
Imports DevExpress.XtraVerticalGrid.Rows


Public Class frm_listar_usuarios
    Dim Empleado As New cl_usuarios
    Dim Entidad As New cl_entidad
    'Private rowcodi_empl As BaseRow

    Private Sub frm_listar_usuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Empleado.ListarUsuarios(vgcEmpleados, 0)

    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles btnObtenerText.Click

        Dim cod As String
        cod = vgcEmpleados.GetCellValue(rowcodi_empl, 1).ToString()

        Try
            MsgBox(cod.ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    'Private Function GetText(ByVal sourceIndex As Integer) As String
    '    Dim result As String = ""
    '    Select Case cbNameOrder.SelectedIndex
    '        Case 0
    '            result = vgcEmpleados.GetCellValue(firstNameRow, sourceIndex).ToString() & " " & vGridControl1.GetCellValue(lastNameRow, sourceIndex).ToString()
    '        Case 1
    '            result = vGridControl1.GetCellValue(lastNameRow, sourceIndex).ToString() & " " & vGridControl1.GetCellValue(firstNameRow, sourceIndex).ToString()
    '        Case 2
    '            result = vGridControl1.GetCellValue(firstNameRow, sourceIndex).ToString()
    '        Case 3
    '            result = vGridControl1.GetCellValue(lastNameRow, sourceIndex).ToString()
    '        Case 4
    '        Case Else
    '            Throw New Exception()
    '    End Select
    '    Return result
    'End Function
End Class
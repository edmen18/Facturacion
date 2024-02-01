Imports Logica
Public Class frm_unidad
    Dim Unidad As New cl_unidad
    Dim flg As Char

    Private Sub frm_banco_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Unidad.Listar_Unidades(dgvCargos)
    End Sub

    Private Sub dgvCargos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCargos.CellContentClick
        Unidad.Codigo = CInt(ObtenerItemGrid(0, dgvCargos))
        Me.txtDescripcion.Text = CStr(ObtenerItemGrid(1, dgvCargos))
        Me.txtAbreviatura.Text = CStr(ObtenerItemGrid(2, dgvCargos))
        flg = "E"
    End Sub

    Private Sub btGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btGuardar.Click
        If Me.txtDescripcion.Text <> "" Then
            Unidad.Descripcion = Me.txtDescripcion.Text
            Unidad.Abreviatura = Me.txtAbreviatura.Text
            If flg = "N" Then
                If Unidad.AgregarUnidad() = True Then
                    Unidad.Listar_Unidades(dgvCargos)
                End If
            Else
                If Unidad.ActualizaUnidad = True Then
                    Unidad.Listar_Unidades(dgvCargos)
                End If
            End If
            Me.txtDescripcion.ResetText()
            Me.txtAbreviatura.ResetText()
            Me.txtDescripcion.Enabled = False
            Me.txtAbreviatura.Enabled = False
        Else
            MessageBox.Show("Debe ingresar la descripcion para elnuevo registro", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo.Click
        Me.txtDescripcion.Enabled = True
        Me.txtAbreviatura.Enabled = True

        Me.txtDescripcion.ResetText()
        Me.txtDescripcion.Focus()
        Me.txtAbreviatura.ResetText()
        flg = "N"
    End Sub

    Private Sub tbEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tbEliminar.Click
        If flg = "E" Then
            If Unidad.EliminaUnidad = True Then
                Unidad.Listar_Unidades(dgvCargos)
                Me.txtDescripcion.ResetText()
                Me.txtAbreviatura.ResetText()
            End If
        End If
    End Sub

    Private Sub dgvCargos_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvCargos.DoubleClick
        Me.txtDescripcion.Enabled = True
        Me.txtAbreviatura.Enabled = True
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.txtDescripcion.Enabled = False
        Me.txtAbreviatura.Enabled = False
        Me.txtDescripcion.ResetText()
    End Sub
 
End Class
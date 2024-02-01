Imports Logica

Public Class frm_mae_cargos
    Dim Cargo As New cl_mae_cargos
    Dim flg As Char

    Private Sub frm_mae_cargos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Cargo.Listar_Cargos(dgvCargos)
    End Sub

    Private Sub dgvCargos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCargos.CellContentClick
        Cargo.Codigo = CInt(ObtenerItemGrid(0, dgvCargos))
        Me.txtCargo.Text = CStr(ObtenerItemGrid(1, dgvCargos))
        flg = "E"
    End Sub

    Private Sub btGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btGuardar.Click
        If Me.txtCargo.Text <> "" Then
            Cargo.Descripcion = Me.txtCargo.Text
            If flg = "N" Then
                If Cargo.AgregarCargo() = True Then
                    Cargo.Listar_Cargos(dgvCargos)
                End If
            Else
                If Cargo.ActualizaCargo = True Then
                    Cargo.Listar_Cargos(dgvCargos)
                End If
            End If
            txtCargo.ResetText()
            Me.txtCargo.Enabled = False
        Else
            MessageBox.Show("Debe ingresar la descripcion del cargo", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCargo.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo.Click
        Me.txtCargo.ResetText()
        Me.txtCargo.Focus()
        flg = "N"
    End Sub

    Private Sub tbEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tbEliminar.Click
        If flg = "E" Then
            If Cargo.EliminaCargo = True Then
                Cargo.Listar_Cargos(dgvCargos)
                Me.txtCargo.ResetText()
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.txtCargo.Enabled = False
        Me.txtCargo.ResetText()
    End Sub

    Private Sub dgvCargos_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCargos.CellValueChanged
      
    End Sub

    Private Sub dgvCargos_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvCargos.DoubleClick
        Me.txtCargo.Enabled = True
        Me.txtCargo.Focus()
    End Sub
End Class
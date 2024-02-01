Imports Logica

Public Class frm_banco
    Dim Banco As New cl_banco
    Dim flg As Char

    Private Sub frm_banco_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Banco.Listar_Bancos(dgvCargos)
        HeadGrid()
    End Sub

    Private Sub dgvCargos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCargos.CellContentClick
        Banco.Codigo = CInt(ObtenerItemGrid(0, dgvCargos))
        Me.txtDescripcion.Text = CStr(ObtenerItemGrid(1, dgvCargos))
        flg = "E"
    End Sub

    Private Sub btGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btGuardar.Click
        If Me.txtDescripcion.Text <> "" Then
            Banco.Descripcion = Me.txtDescripcion.Text
            If flg = "N" Then
                If Banco.AgregarBanco() = True Then
                    Banco.Listar_Bancos(dgvCargos)
                End If
            Else
                If Banco.ActualizaBanco = True Then
                    Banco.Listar_Bancos(dgvCargos)
                End If
            End If
            Me.txtDescripcion.ResetText()
            Me.txtDescripcion.Enabled = False
        Else
            MessageBox.Show("Debe ingresar la descripcion para elnuevo registro", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo.Click
        Me.txtDescripcion.Enabled = True
        Me.txtDescripcion.ResetText()
        Me.txtDescripcion.Focus()
        flg = "N"
    End Sub

    Private Sub tbEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tbEliminar.Click
        If flg = "E" Then
            If Banco.EliminaBanco = True Then
                Banco.Listar_Bancos(dgvCargos)
                Me.txtDescripcion.ResetText()
            End If
        End If
    End Sub

    Private Sub dgvCargos_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvCargos.DoubleClick
        Me.txtDescripcion.Enabled = True
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.ResetText()
    End Sub

    Sub HeadGrid()
        With dgvCargos

            .Columns(0).HeaderText = "CODIGO"
            .Columns(1).HeaderText = "DESCRIPCION"
            .Columns(0).Width = 100
            .Columns(1).Width = Me.Width - .Columns(0).Width
        End With
    End Sub

End Class
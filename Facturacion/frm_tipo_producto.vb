Imports Logica
Public Class frm_tipo_producto
    Dim TipoProducto As New cl_tipo_producto
    Dim flg As Char

    Private Sub frm_banco_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TipoProducto.Listar_Tipo_Producto(dgvCargos)
        HeadGrid()
    End Sub

    Private Sub dgvCargos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCargos.CellContentClick
        TipoProducto.Codigo = CInt(ObtenerItemGrid(0, dgvCargos))
        Me.txtDescripcion.Text = CStr(ObtenerItemGrid(1, dgvCargos))
        flg = "E"
    End Sub

    Private Sub btGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btGuardar.Click
        If Me.txtDescripcion.Text <> "" Then
            TipoProducto.Descripcion = Me.txtDescripcion.Text
            If flg = "N" Then
                If TipoProducto.AgregarTipo_Producto() = True Then
                    TipoProducto.Listar_Tipo_Producto(dgvCargos)
                End If
            Else
                If TipoProducto.ActualizaTipo_Producto = True Then
                    TipoProducto.Listar_Tipo_Producto(dgvCargos)
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
            If TipoProducto.EliminaTipoProducto = True Then
                TipoProducto.Listar_Tipo_Producto(dgvCargos)
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
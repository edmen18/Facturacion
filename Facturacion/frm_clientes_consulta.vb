Imports Logica
Public Class frm_clientes_consulta
    Dim Cliente As New cl_cliente
    Public flag As Byte

    Private Sub frm_clientes_consulta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Cliente.Listar_Cliente(dgvCliente, 0)
        HeadGrid()
    End Sub

    Private Sub dgvCliente_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvCliente.DoubleClick
        If flag = 0 Then
            With frm_venta
                .txtCodCli.Text = ObtenerItemDevGrid("codi_clie", gvClientes)
                .txtCliente.Text = ObtenerItemDevGrid("nomb_clie", gvClientes)
            End With
        Else
            With frm_venta_editar
                .txtCodCli.Text = ObtenerItemDevGrid("codi_clie", gvClientes)
                .txtCliente.Text = ObtenerItemDevGrid("nomb_clie", gvClientes)
            End With
        End If
        Me.Close()
    End Sub

#Region "Look Grid"
    Sub HeadGrid()

        gvClientes.Columns(0).Caption = "CODIGO"
        gvClientes.Columns(1).Caption = "tipo cliente"
        gvClientes.Columns(2).Width = 200
        gvClientes.Columns(2).Caption = "NOMBRE DE CLIENTE"
        gvClientes.Columns(3).Caption = "DIRECCION"
        gvClientes.Columns(4).Caption = "DOCUMENTO"
        gvClientes.Columns(5).Caption = "TELEFONO"

        gvClientes.Columns(0).Visible = False
        gvClientes.Columns(1).Visible = False
        gvClientes.Columns(3).Visible = False
        gvClientes.Columns(5).Visible = False
        gvClientes.Columns(6).Visible = False
    End Sub
#End Region

    
    Private Sub txtDato_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtDato.EditValueChanged
        Cliente.Nombre = Me.txtDato.Text
        Cliente.Listar_Cliente(dgvCliente, 1)
    End Sub
End Class
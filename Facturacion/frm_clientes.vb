Imports Logica

Public Class frm_clientes
    Dim Cliente As New cl_cliente
    Dim TipoCliente As New cl_tipo_cliente
    Dim flg As Byte

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        flg = 0 ' Nuevo
        Nuevo()
        LimpiarCajas()
        Habilitar_Controles(gcCliente)
        txtCodigo.Text = "C" & Format(Cliente.GeneraCodigo(), "000000000")
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If Not ValidarFormulario() Then
            Exit Sub
        End If

        Cliente.Codigo = Me.txtCodigo.Text
        Cliente.Nombre = Me.txtNombre.Text
        Cliente.NumeroDocumento = Me.txtNumDoc.Text
        Cliente.Telefono = Me.txtTelefono.Text
        Cliente.TipoCliente = Me.cmbTipoCliente.GetColumnValue("id_ticl")
        Cliente.Email = Me.txtEmail.Text
        Cliente.Direccion = Me.txtDireccion.Text

        If flg = 0 Then
            If Cliente.AgregarCliente() = True Then
                Cliente.Listar_Cliente(dgvCliente, 0)
            End If
        Else
            If Cliente.ActualizarCliente() = True Then
                Cliente.Listar_Cliente(dgvCliente, 0)
            End If
        End If
        'flg = 0
        Guardar()
        Deshabilitar_Controles(gcCliente)

    End Sub

    Private Sub frm_clientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TipoCliente.LlenarComboTipoCliente(cmbTipoCliente)
        Cliente.Listar_Cliente(dgvCliente, 0)

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dgvCliente_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvCliente.DoubleClick
        Me.txtCodigo.EditValue = ObtenerItemDevGrid("codi_clie", gvClientes)
        Me.txtNombre.EditValue = ObtenerItemDevGrid("nomb_clie", gvClientes)
        Me.txtNumDoc.EditValue = ObtenerItemDevGrid("nudo_clie", gvClientes)
        Me.txtDireccion.EditValue = ObtenerItemDevGrid("dire_clie", gvClientes)
        Me.txtTelefono.EditValue = ObtenerItemDevGrid("tele_clie", gvClientes)
        Me.txtEmail.EditValue = ObtenerItemDevGrid("emai_clie", gvClientes)
        Me.cmbTipoCliente.EditValue = ObtenerItemDevGrid("id_ticl", gvClientes)
        flg = 1
        Actualizar()
        Habilitar_Controles(gcCliente)

    End Sub

    Private Sub gvClientes_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs)
        Me.txtCodigo.Text = ObtenerItemDevGrid("codi_clie", dgvCliente)
        Me.txtNombre.Text = ObtenerItemDevGrid("nomb_clie", dgvCliente)
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Cancelar()
        LimpiarCajas()
        Deshabilitar_Controles(gcCliente)
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If flg = 1 Then
            Cliente.Codigo = Me.txtCodigo.Text
            If Cliente.EliminarCliente = True Then
                Cliente.Listar_Cliente(dgvCliente, 0)
            End If
            Deshabilitar_Controles(gcCliente)
            LimpiarCajas()
        End If
    End Sub

#Region "Funciones de control"
    Sub Nuevo()
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnNuevo.Enabled = False
        Me.btnEliminar.Enabled = False
        'LimpiarCajas()

        Me.txtCodigo.Focus()
    End Sub

    Sub Guardar()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnEliminar.Enabled = False
    End Sub

    Sub Actualizar()
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnEliminar.Enabled = True
    End Sub

    Sub Cancelar()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnEliminar.Enabled = False
        'LimpiarCajas()
    End Sub

    Sub LimpiarCajas()
        Me.txtNombre.Text = ""
        Me.txtNumDoc.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtTelefono.Text = "0"
        'Me.cmbTipoCliente.Text = ""
        Me.txtEmail.Text = "Ninguno"
    End Sub

#End Region

#Region "Validacion y control"

    Function validaCampo(ByVal texto As Object, ByVal mensaje As String) As Boolean
        If texto.Text = "" Then
            DxError.SetError(texto, "Falta campo")
            With ToolTip
                ShowToolTipoBase(texto, mensaje, "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                texto.Focus()
            End With
            Return False
            Exit Function
        End If
        Return False
    End Function

    Protected Function ValidarFormulario() As Boolean
        DxError.ClearErrors()

        If cmbTipoCliente.Text = "" Then
            DxError.SetError(cmbTipoCliente, "Falta cargo")
            With ToolTip
                ShowToolTipoBase(cmbTipoCliente, "Debe seleccionar un cargo", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                cmbTipoCliente.Focus()
            End With
            Return False
        End If

        If txtNombre.Text = "" Then
            DxError.SetError(txtNombre, "Falta nombre")
            With ToolTip
                ShowToolTipoBase(txtNombre, "Debe introducir el nombre", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtNombre.Focus()
            End With
            Return False
        End If


        If txtNumDoc.Text = "" Then
            DxError.SetError(txtNumDoc, "Falta dni")
            With ToolTip
                ShowToolTipoBase(txtNumDoc, "Debe introducir el Documento de identidad", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtNumDoc.Focus()
            End With
            Return False
        End If


        If txtDireccion.Text = "" Then
            DxError.SetError(txtDireccion, "Falta direccion")
            With ToolTip
                ShowToolTipoBase(txtDireccion, "Debe introducir la dirección", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtDireccion.Focus()
            End With
            Return False
        End If


        If txtTelefono.Text = "" Then
            DxError.SetError(txtNumDoc, "Falta telefono")
            With ToolTip
                ShowToolTipoBase(txtTelefono, "Debe introducir el telefono", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtTelefono.Focus()
            End With
            Return False
        End If

        Return True
    End Function

    Protected Sub ShowToolTipoBase(ByVal sender As Object, ByVal Mensaje As String, _
    ByVal Titulo As String, ByVal lIcon As DevExpress.Utils.ToolTipIconType)
        Dim args As DevExpress.Utils.ToolTipControllerShowEventArgs = ToolTip.CreateShowArgs()
        With args
            .Title = Titulo
            .ToolTip = Mensaje
            .IconType = lIcon
            .ToolTipLocation = DevExpress.Utils.ToolTipLocation.LeftBottom
        End With
        With ToolTip
            .InitialDelay = 1
            .ToolTipLocation = DevExpress.Utils.ToolTipLocation.RightCenter
            .ShowHint(args, sender)
        End With
    End Sub
#End Region


End Class
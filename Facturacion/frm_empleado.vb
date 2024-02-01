Imports Logica

Public Class frm_empleado
    Dim Empleado As New cl_usuarios
    Dim Cargo As New cl_cargo
    Dim flg As Byte


    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        flg = 1 ' Nuevo
        Nuevo()
        HabilitarCajas()

    End Sub


    Sub HeadGrid()
        With vgcEmpleados
            .RowHeaderWidth = 250
            .RecordWidth = (.Width + .RowHeaderWidth) / 2
        End With
    End Sub

#Region "Funciones de control"
    Sub Nuevo()
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnNuevo.Enabled = False
        Me.btnEliminar.Enabled = False
        'LimpiarCajas()
        txtCodigo.Text = "E" & Format(Empleado.GeneraCodigo(), "0000")
        Me.txtNombre.Focus()

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


    Sub HabilitarCajas()
        Me.txtNombre.Enabled = True
        Me.txtNumDoc.Enabled = True
        Me.txtDireccion.Enabled = True
        'Me.txtEmail.Enabled = True
        Me.txtTelefono.Enabled = True
        Me.cmbCargo.Enabled = True

        Me.txtUsuario.Enabled = True
        Me.txtClave.Enabled = True
        Me.txtConfirmar.Enabled = True
    End Sub

    Sub DeshabilitarCajas()
        Me.txtNombre.Enabled = False
        Me.txtNumDoc.Enabled = False
        Me.txtDireccion.Enabled = False
        'Me.txtEmail.Enabled = False
        Me.txtTelefono.Enabled = False
        Me.cmbCargo.Enabled = False

        Me.txtUsuario.Enabled = False
        Me.txtClave.Enabled = False
        Me.txtConfirmar.Enabled = False
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

        If cmbCargo.Text = "" Then
            DxError.SetError(cmbCargo, "Falta cargo")
            With ToolTip
                ShowToolTipoBase(cmbCargo, "Debe seleccionar un cargo", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                cmbCargo.Focus()
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


        If txtUsuario.Text = "" Then
            DxError.SetError(txtUsuario, "Falta usuario")
            With ToolTip
                ShowToolTipoBase(txtUsuario, "Debe introducir el Usuario", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtUsuario.Focus()
            End With
            Return False
        End If

        If txtClave.Text = "" Then
            DxError.SetError(txtClave, "Falta clave")
            With ToolTip
                ShowToolTipoBase(txtUsuario, "Debe introducir la clave", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtClave.Focus()
            End With
            Return False
        End If


        If txtClave.EditValue <> txtConfirmar.EditValue Then
            DxError.SetError(txtClave, "Falta nombre")
            With ToolTip
                ShowToolTipoBase(txtUsuario, "La clave no coincide", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtClave.Focus()
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

    Private Sub frm_empleado_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Cargo.LlenarComboCargo(cmbCargo)
        Empleado.ListarUsuarios(vgcEmpleados, 0)
        'HeadGrid()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        If Not ValidarFormulario() Then
            Exit Sub
        End If

        Empleado.IdUsuario = Me.txtCodigo.EditValue
        Empleado.Nombre = Me.txtNombre.EditValue
        Empleado.Dni = Me.txtNumDoc.EditValue
        Empleado.Direccion = Me.txtDireccion.EditValue
        Empleado.Telefono = Me.txtTelefono.EditValue
        Empleado.Cargo = Me.cmbCargo.GetColumnValue("id_carg")

        If chkAdmin.Checked = True Then
            Empleado.EsAdmin = True
        Else
            Empleado.EsAdmin = False
        End If

        Empleado.Usuario = Me.txtUsuario.EditValue
        Empleado.Clave = SHA1(Me.txtClave.EditValue)
        Empleado.AgregarUsuario()
        flg = 1
        DeshabilitarCajas()
        Empleado.ListarUsuarios(vgcEmpleados, 0)

    End Sub


    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnPermisos_Click(sender As System.Object, e As System.EventArgs) Handles btnPermisos.Click
        With frm_empleados_permisos
            .lblId.Text = Me.txtCodigo.Text
            .lblEmpleado.Text = Me.txtNombre.Text
            .ShowDialog()
        End With

    End Sub

    Private Sub vgcEmpleados_Click(sender As System.Object, e As System.EventArgs) Handles vgcEmpleados.Click
      
        Me.txtCodigo.EditValue = ObtenerItemVerticalGrid(rowcodi_empl, vgcEmpleados)
        Me.txtNombre.EditValue = ObtenerItemVerticalGrid(rownomb_empl, vgcEmpleados)
        Me.cmbCargo.EditValue = ObtenerItemVerticalGrid(rowid_carg, vgcEmpleados)
        Me.txtNumDoc.EditValue = ObtenerItemVerticalGrid(rownudo_empl, vgcEmpleados)
        Me.txtDireccion.EditValue = ObtenerItemVerticalGrid(rowdire_empl, vgcEmpleados)
        Me.txtTelefono.EditValue = ObtenerItemVerticalGrid(rowtele_empl, vgcEmpleados)
        Me.txtUsuario.EditValue = ObtenerItemVerticalGrid(rowusua_empl, vgcEmpleados)
        Me.chkAdmin.Checked = ObtenerItemVerticalGrid(rowesad_empl, vgcEmpleados)
        'Me.txtConfirmar.EditValue = ObtenerItemVerticalGrid(rowclav_empl, vgcEmpleados)


    End Sub

    Private Sub chkAdmin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAdmin.CheckedChanged
        If Me.chkAdmin.Checked = True Then
            btnPermisos.Enabled = False
        Else
            btnPermisos.Enabled = True
        End If
    End Sub
End Class
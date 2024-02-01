Imports Logica

Public Class frm_auditoria
    Dim Auditoria As New cl_auditoria

    Private Sub frm_auditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtCodigo.EditValue = "A" & Format(Auditoria.GeneraCodigo(), "000000000")
        Me.txtFechaAuditoria.EditValue = Date.Now.ToString
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Not ValidarFormulario() Then
            Exit Sub
        End If

        Auditoria.Id_Auditoria = Me.txtCodigo.EditValue
        Auditoria.CodigoVenta = Me.txtVenta.EditValue
        Auditoria.FechaAuditoria = CDate(txtFechaAuditoria.EditValue.ToString)
        Auditoria.Empleado = Me.txtEmpleado.EditValue
        Auditoria.EstadoAuditoria = cmbEstado.Text
        Auditoria.Observacion = meObservacion.EditValue

        If frm_venta_consulta_auditoria.flg = "I" Then
            If Auditoria.RegistrarAuditoria() = True Then
                With frm_venta_consulta_auditoria
                    .ListarVentasActivas()
                End With
            End If

        Else
            If Auditoria.ActualizaAuditoria() = True Then
                With frm_venta_consulta_auditoria
                    .ListarVentasActivas()
                End With

            End If
        End If
        Me.Close()
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub


#Region "Validacion y control"

    Protected Function ValidarFormulario() As Boolean
        DxError.ClearErrors()

        If cmbEstado.Text = "" Then
            DxError.SetError(cmbEstado, "Falta estado")
            With ToolTip
                ShowToolTipoBase(cmbEstado, "Debe seleccionar un estado", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                cmbEstado.Focus()
            End With
            Return False
        End If

        If meObservacion.Text = "" Then
            DxError.SetError(meObservacion, "Falta observacion")
            With ToolTip
                ShowToolTipoBase(meObservacion, "Debe registrar una observación", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                meObservacion.Focus()
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
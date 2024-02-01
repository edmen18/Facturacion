Imports Logica

Public Class frm_extorno_registra
    Dim Extorno As New cl_extorno
    Dim MotivoExtorno As New cl_motivo_extorno

    Private Sub frm_extorno_registra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.txtCodigo.EditValue = "X" & Format(Extorno.GeneraCodigo(), "0000")
        Me.dtpFecha.EditValue = Now.Date
        MotivoExtorno.LlenarMotivoExtorno(cmbMotivo)
    End Sub

    Private Sub btnRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrar.Click
        If Not ValidarFormulario() Then
            Exit Sub
        End If

        Extorno.Codigo = Me.txtCodigo.EditValue
        Extorno.Fecha = Me.dtpFecha.EditValue
        Extorno.CodigoVenta = Me.txtVenta.EditValue
        Extorno.Motivo = CInt(cmbMotivo.GetColumnValue("id_moex"))
        Extorno.Monto = CDbl(Me.txtMonto.EditValue)
        Extorno.Empleado = Me.txtEmpleado.EditValue
        If Extorno.AgregarExtorno() = True Then
            With frm_extrorno_consulta
                .ListarVentas()
            End With
            Me.Close()
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

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

        If cmbMotivo.Text = "" Then
            DxError.SetError(cmbMotivo, "Falta cargo")
            With ToolTip
                ShowToolTipoBase(cmbMotivo, "Debe seleccionar un motivo", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                cmbMotivo.Focus()
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
Imports Logica

Public Class frm_empoce_registra
    Dim Venta As New cl_venta
    Dim Cuenta As New cl_cuenta
    Dim Empoce As New cl_empoce
    Dim flg As Byte

    Private Sub frm_registro_empoce_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Venta.Listar_Venta_Empoce_Head(dgvVenta, 0)
        Cuenta.LlenarComboCuenta(cmbCuenta)
        HeadGrid()
        'HeadCuenta()
        CreaColumnsEmpoce()
        HeadGridEmpoce()
    End Sub

    Sub HeadGrid()
        gvVenta.Columns(0).Width = 80
        gvVenta.Columns(0).Caption = "CODIGO"
        gvVenta.Columns(1).Caption = "CLIENTE"
        gvVenta.Columns(2).Caption = "DOCUMENTO"
        gvVenta.Columns(3).Caption = "NRO.DOC."
        gvVenta.Columns(4).Caption = "FORMA DE PAGO"
        gvVenta.Columns(5).Caption = "FECHA"
        gvVenta.Columns(6).Caption = "SUBTOTAL"
        gvVenta.Columns(7).Caption = "IGV"
        gvVenta.Columns(8).Caption = "TOTAL"

        gvVenta.Columns(1).Visible = False
        gvVenta.Columns(6).Visible = False
        gvVenta.Columns(7).Visible = False
    End Sub

    Sub HeadCuenta()
        cmbCuenta.Properties.Columns(0).Caption = "ID"
        cmbCuenta.Properties.Columns(1).Caption = "DES"
    End Sub

#Region "Grid Empoce"
    Sub CreaColumnsEmpoce()
        Dim dtAuxi As New Data.DataTable
        dtAuxi.Columns.Add("CODIGO")
        dtAuxi.Columns.Add("FECHA")
        dtAuxi.Columns.Add("NRO.DOC")
        dtAuxi.Columns.Add("TOTAL")
        gcEmpoce.DataSource = dtAuxi
    End Sub

    Sub HeadGridEmpoce()
        With gvEmpoce
            .Columns(1).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            .Columns(1).DisplayFormat.FormatString = "d"
            .Columns(3).SummaryItem.FieldName = "TOTAL"
            .Columns(3).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns(3).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        End With
    End Sub
#End Region

#Region "Funciones de control"
    Sub Nuevo()
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnNuevo.Enabled = False
        Me.btnEliminar.Enabled = False
        LimpiarCajas()

        Me.txtCodigo.Focus()
        Me.dtpFecha.EditValue = Now.Date
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
        LimpiarCajas()
    End Sub

    Sub LimpiarCajas()
        Me.txtCodigo.EditValue = ""
        Me.txtMonto.EditValue = ""
        Me.cmbCuenta.EditValue = ""
    End Sub

    Sub HabilitarCajas()
        Me.txtCodigo.Enabled = True
        'Me.txtMonto.Enabled = True
        Me.cmbCuenta.Enabled = True
        Me.txtCodigo.Focus()
    End Sub

    Sub DeshabilitarCajas()
        Me.txtCodigo.Enabled = False
        Me.txtMonto.Enabled = False
        Me.cmbCuenta.Enabled = False
    End Sub
#End Region

#Region "Validar Formulario"
    Protected Function ValidarFormulario() As Boolean
        DxError.ClearErrors()


        If txtCodigo.Text = "" Then
            DxError.SetError(txtCodigo, "Falta Codigo")
            With ToolTip
                ShowToolTipoBase(txtCodigo, "Debe ingresar el número de papeleta", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtCodigo.Focus()
            End With
            Return False
        End If

        If cmbCuenta.Text = "" Then
            DxError.SetError(cmbCuenta, "Falta cuenta")
            With ToolTip
                ShowToolTipoBase(cmbCuenta, "Debe seleccionar una cuenta Bancaria", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                cmbCuenta.Focus()
            End With
            Return False
        End If

        If txtMonto.Text = "" Then
            DxError.SetError(txtMonto, "Falta monto")
            With ToolTip
                ShowToolTipoBase(txtMonto, "Debe ingresar el monto", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtMonto.Focus()
            End With
            Return False
        End If
        If gvEmpoce.RowCount = 0 Then
            DxError.SetError(dgEmpoce, "Falta ventas")
            With ToolTip
                ShowToolTipoBase(dgEmpoce, "Debe agregar registros de ventas", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                dgEmpoce.Focus()
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

#Region "Calculos"
    Function MontoAcumulado() As Double
        Dim i, xRow As Integer
        Dim total As Double = 0.0
        Try
            For i = 0 To gvEmpoce.RowCount - 1
                xRow = gvEmpoce.GetVisibleRowHandle(i) 'Esto es por si el grid esta filtrado
                total += gvEmpoce.GetRowCellValue(xRow, "TOTAL")
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return total
    End Function
#End Region

#Region "Mantenimiento"
    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        flg = 0 ' Nuevo
        Nuevo()
        HabilitarCajas()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Cancelar()
        DeshabilitarCajas()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        If Not ValidarFormulario() Then
            Exit Sub
        End If

        Empoce.NumeroPapeleta = Me.txtCodigo.EditValue
        Empoce.Fecha = Me.dtpFecha.EditValue
        Empoce.Monto = Me.txtMonto.EditValue
        Empoce.Cuenta = Me.cmbCuenta.GetColumnValue("id_cuen")
        Empoce.Empleado = UsuarioActivo.IdUsuario
        If Empoce.AgregarEmpoce(gvEmpoce) = True Then
            Venta.Listar_Venta_Empoce_Head(dgvVenta, 0)
            flg = 1
            Guardar()
        End If
       
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Dim codigoVenta As String = ObtenerItemDevGrid("codi_vent", gvVenta)

        If Not BuscarDuplicado(codigoVenta, gvEmpoce, "CODIGO") Then
            gvEmpoce.AddNewRow()

            Dim fila = gvEmpoce.FocusedRowHandle()
            gvEmpoce.SetRowCellValue(fila, "CODIGO", ObtenerItemDevGrid("codi_vent", gvVenta))
            gvEmpoce.SetRowCellValue(fila, "FECHA", CStr(ObtenerItemDevGrid("fech_vent", gvVenta)))
            gvEmpoce.SetRowCellValue(fila, "NRO.DOC", ObtenerItemDevGrid("nudo_vent", gvVenta))
            gvEmpoce.SetRowCellValue(fila, "TOTAL", ObtenerItemDevGrid("tota_vent", gvVenta))
            gvEmpoce.UpdateCurrentRow()
            Me.txtMonto.EditValue = MontoAcumulado()
            gvVenta.DeleteSelectedRows()
        End If

       
    End Sub

    Private Sub dgEmpoce_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            gvEmpoce.DeleteSelectedRows()
            Me.txtMonto.EditValue = MontoAcumulado()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultar.Click
        Venta.Listar_Venta_Empoce_Head(dgvVenta, 1, Me.dtpDesde.EditValue, Me.dtpHasta.EditValue)
    End Sub
#End Region


    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        If gvEmpoce.RowCount > 0 Then
            gvEmpoce.DeleteSelectedRows()
            Me.txtMonto.EditValue = MontoAcumulado()
        Else
            MessageBox.Show("No hay ingresos que remover", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
       
    End Sub


    'Private Function BuscarDuplicado(ByVal CodigoVenta As String) As Boolean

    '    Dim i As Integer = 0
    '    Dim CuantasVecesExiste As Integer = 0
    '    Dim xrow As Integer

    '    For i = 0 To gvEmpoce.RowCount - 1
    '        xrow = gvEmpoce.GetVisibleRowHandle(i)
    '        If gvEmpoce.GetRowCellValue(xrow, "CODIGO") = CodigoVenta Then
    '            CuantasVecesExiste = CuantasVecesExiste + 1
    '            If CuantasVecesExiste > 0 Then
    '                BuscarDuplicado = True
    '                Exit Function
    '            Else
    '                BuscarDuplicado = False
    '            End If
    '        Else
    '            BuscarDuplicado = False
    '        End If
    '    Next
    '    Return Nothing
    'End Function


End Class
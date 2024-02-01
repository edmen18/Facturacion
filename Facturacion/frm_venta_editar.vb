Imports Logica
Imports Reportes
Public Class frm_venta_editar
    Dim Venta As New cl_venta
    Dim VentaDetalle As New cl_venta_detalle
    Dim DocumentoVenta As New cl_documento_venta
    Dim FormaPago As New cl_forma_pago
    Dim DetallePago As New cl_venta_detalle_pago
    Dim ProductoUnidad As New cl_producto_unidad
    Dim Igv As New cl_igv
    Dim Banco As New cl_banco
    Dim Imprimir As New C_imprime

    Dim valorIgv As Decimal
    Dim flg As Byte

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        flg = 0 ' Nuevo
        Nuevo()
        LimpiarCajas()
        HabilitarCajas()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If Not ValidarFormulario() Then
            Exit Sub
        End If
        Try
            Venta.Codigo = Me.txtCodigo.Text
            Venta.Cliente = Me.txtCodCli.Text
            Venta.DocumentoVenta = CInt(cmbDocVenta.GetColumnValue("id_dove"))
            Venta.FormaPago = CInt(cmbFormaPago.GetColumnValue("id_fopa"))
            Venta.NumeroDocumento = Me.txtNumDoc.Text
            Venta.FechaVenta = dtpFecha.DateTime.Date
            Venta.HoraVenta = DateTime.Now
            Venta.Subtotal = CDbl(Me.txtSubtotal.Text)
            Venta.Igv = CDbl(Me.txtIgv.Text)
            Venta.TotalVenta = CDbl(Me.txtTotal.Text)
            Venta.Empleado = UsuarioActivo.IdUsuario
            Venta.Estado = True
            Venta.MontoenLetras = Me.lblMontoLetras.Text
            Venta.Nota = Me.txtNota.Text

            If cmbFormaPago.GetColumnValue("id_fopa") = 1 Then
                If Venta.ActualizarVenta(gvDetalle) Then
                    MostrarDocumentoVenta()
                End If

            ElseIf cmbFormaPago.GetColumnValue("id_fopa") = 3 Then

                'Detalle Pago 'Cheque
                DetallePago.Codigo = "DP" & Format(DetallePago.GeneraCodigo(), "00000000")
                DetallePago.CodigoVenta = Me.txtCodigo.EditValue
                DetallePago.Banco = cmbBanco.GetColumnValue("id_banc")
                DetallePago.Numero = Me.txtNumCheque.EditValue

                If Venta.ActualizarVenta(gvDetalle) = True Then
                    DetallePago.RegistraPago()
                    MostrarDocumentoVenta()
                End If
            End If

            flg = 1
            Guardar()
            LimpiarCajas()
            DesHabilitarCajas()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub frm_venta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DocumentoVenta.LlenarComboDocumentoVenta(cmbDocVenta)
        FormaPago.LlenarComboFormaPago(cmbFormaPago)
        Banco.LlenarComboBanco(cmbBanco)
        Me.dtpFecha.EditValue = Date.Today
        Columns()
        HeadGrid()
    End Sub

#Region "Funciones de control"
    Sub Nuevo()
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnNuevo.Enabled = False
        Me.btnBuscarVenta.Enabled = True
        Me.txtCodigo.Focus()
    End Sub

    Sub Guardar()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnBuscarVenta.Enabled = False
    End Sub

    Sub Cancelar()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
    End Sub

    Sub HabilitarCajas()
        Me.txtCliente.Enabled = True
        Me.cmbFormaPago.Enabled = True
        Me.cmbDocVenta.Enabled = True
        Me.dtpFecha.Enabled = True
        Me.txtNumDoc.Enabled = True

        Me.txtProducto.Enabled = True
        Me.txtCantidad.Enabled = True
        Me.cmbUnidad.Enabled = True
        Me.txtPrecio.Enabled = True
        Me.txtNota.Enabled = True
    End Sub

    Sub DesHabilitarCajas()
        Me.txtCliente.Enabled = False
        Me.cmbFormaPago.Enabled = False
        Me.cmbDocVenta.Enabled = False
        Me.dtpFecha.Enabled = False
        Me.txtNumDoc.Enabled = False
        Me.txtNumCheque.Enabled = False
        Me.cmbBanco.Enabled = False

        Me.txtProducto.Enabled = False
        Me.txtCantidad.Enabled = False
        Me.cmbUnidad.Enabled = False
        Me.txtPrecio.Enabled = False
        Me.txtNota.Enabled = False
    End Sub

    Sub LimpiarCajas()
        Me.txtCodigo.Text = ""
        Me.txtCodCli.Text = ""
        Me.txtCliente.Text = ""
        Me.txtNumDoc.Text = ""
        Me.txtCodProd.Text = ""
        Me.txtProducto.Text = ""
        Me.txtCantidad.Text = ""
        Me.txtPrecio.Text = ""
        Me.txtNota.Text = ""
        Me.txtSubtotal.Text = ""
        Me.txtTotal.Text = ""
        Me.txtIgv.Text = ""
        'Limpiamos el Grid
        gvDetalle.SelectAll()
        gvDetalle.DeleteSelectedRows()
    End Sub

#End Region

#Region "Validar formulario"
    Protected Function ValidarFormulario() As Boolean
        DxError.ClearErrors()


        If txtCodCli.Text = "" Then
            DxError.SetError(txtCodCli, "Falta cliente")
            With ToolTip
                ShowToolTipoBase(txtCodCli, "Debe seleccionar un cliente", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtCliente.Focus()
            End With
            Return False
        End If

        If cmbDocVenta.Text = "" Then
            DxError.SetError(cmbDocVenta, "Falta documento")
            With ToolTip
                ShowToolTipoBase(cmbDocVenta, "Debe seleccionar un documento de venta", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                cmbDocVenta.Focus()
            End With
            Return False
        End If

        If txtNumDoc.Text = "" Then
            DxError.SetError(txtNumDoc, "Falta Número de documento")
            With ToolTip
                ShowToolTipoBase(txtNumDoc, "Debe ingresar el número de documento", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtNumDoc.Focus()
            End With
            Return False
        End If

        If cmbFormaPago.Text = "" Then
            DxError.SetError(cmbFormaPago, "Falta forma de pago")
            With ToolTip
                ShowToolTipoBase(cmbFormaPago, "Debe seleccionar una forma de pago", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                cmbFormaPago.Focus()
            End With
            Return False
        End If


        If gvDetalle.RowCount = 0 Then
            DxError.SetError(dgDetalle, "Falta productos")
            With ToolTip
                ShowToolTipoBase(dgDetalle, "Debe registrar productos", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                dgDetalle.Focus()
            End With
            Return False
        End If

        If txtTotal.Text = "" Then
            DxError.SetError(txtTotal, "Falta total")
            With ToolTip
                ShowToolTipoBase(txtTotal, "Debe registrar productos", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtTotal.Focus()
            End With
            Return False
        End If

        If txtNota.Text = "" Then
            DxError.SetError(txtNota, "Falta Nota")
            With ToolTip
                ShowToolTipoBase(txtNota, "Debe registrar Nota", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtNota.Focus()
            End With
            Return False
        End If

        Return True
    End Function

    Protected Function ValidarDetalle() As Boolean
        If txtCodProd.Text = "" Then
            DxError.SetError(txtCodProd, "Falta Producto")
            With ToolTip
                ShowToolTipoBase(txtCodProd, "Debe seleccionar un producto/servicio", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtProducto.Focus()
            End With
            Return False
        End If

        If txtCantidad.Text = "" Then
            DxError.SetError(txtCantidad, "Falta cantidad")
            With ToolTip
                ShowToolTipoBase(txtCantidad, "Debe seleccionar un producto/servicio", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtCantidad.Focus()
            End With
            Return False
        End If

        If cmbDocVenta.Text = "" Then
            DxError.SetError(cmbDocVenta, "Falta documento")
            With ToolTip
                ShowToolTipoBase(cmbDocVenta, "Debe seleccionar un documento de venta", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                cmbDocVenta.Focus()
            End With
            Return False
        End If


        If txtPrecio.Text = "" Then
            DxError.SetError(txtPrecio, "Falta Valor")
            With ToolTip
                ShowToolTipoBase(txtPrecio, "Debe ingresar un precio", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtPrecio.Focus()
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

    Sub Columns()
        Dim dtAuxi As New Data.DataTable
        dtAuxi.Columns.Add("ITEM")
        dtAuxi.Columns.Add("CODPROD")
        dtAuxi.Columns.Add("DESCRIPCION_DEL_PRODUCTO")
        dtAuxi.Columns.Add("CODUNI")
        dtAuxi.Columns.Add("CANTIDAD")
        dtAuxi.Columns.Add("VALOR")
        dtAuxi.Columns.Add("VALIGV")
        dtAuxi.Columns.Add("TOTIGV")
        dtAuxi.Columns.Add("SUBT")
        dtAuxi.Columns.Add("TOTAL")
        dgDetalle.DataSource = dtAuxi
    End Sub

    Sub HeadGrid()
        With gvDetalle
            .Columns("ITEM").Visible = False
            .Columns("VALIGV").Visible = False
            .Columns("TOTIGV").Visible = False
            .Columns("SUBT").Visible = False
            .Columns("CODUNI").Visible = False
            .Columns("DESCRIPCION_DEL_PRODUCTO").Width = 400
        End With
    End Sub

    Function SubtotalVenta() As Double
        Dim i, xRow As Integer
        Dim total As Double = 0.0
        Try
            For i = 0 To gvDetalle.RowCount - 1
                xRow = gvDetalle.GetVisibleRowHandle(i) 'Esto es por si el grid esta filtrado
                total += gvDetalle.GetRowCellValue(xRow, "TOTAL")
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return total
    End Function

    'Sub CalcularTotal()
    '    Me.txtIgv.Text = SubtotalVenta() * 0.18
    '    Me.txtTotal.Text = SubtotalVenta()
    '    Me.txtSubtotal.Text = CDbl(Me.txtTotal.Text) - CDbl(txtIgv.Text)
    '    Me.lblMontoLetras.Text = "SON: " + Convertir(CDbl(Me.txtTotal.EditValue))
    'End Sub

    Sub CalcularTotalFactura()
        Dim igv As Double
        igv = SubtotalVenta() / 1.18
        Me.txtIgv.Text = igv * 0.18
        Me.txtTotal.Text = SubtotalVenta()
        Me.txtSubtotal.Text = CDbl(Me.txtTotal.Text) - CDbl(txtIgv.Text)
        Me.lblMontoLetras.Text = "SON: " + Convertir(CDbl(Me.txtTotal.EditValue))
    End Sub

    Sub CalcularTotalRecBol()
        Me.txtIgv.Text = 0.0
        Me.txtTotal.Text = SubtotalVenta()
        Me.txtSubtotal.Text = CDbl(Me.txtTotal.Text)
        Me.lblMontoLetras.Text = "SON: " + Convertir(CDbl(Me.txtTotal.EditValue))
    End Sub


    Private Sub txtCliente_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCliente.ButtonClick
        With frm_clientes_consulta
            .ShowDialog()
            .flag = 1
        End With
    End Sub

    Private Sub txtProducto_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtProducto.ButtonClick
        With frm_producto_consulta
            .ShowDialog()
            .flag = 1
        End With
    End Sub

    Private Sub txtCodProd_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtCodProd.EditValueChanged
        ProductoUnidad.LlenarComboUnidad(cmbUnidad, Me.txtCodProd.Text)
        valorIgv = Igv.ObtenerIgv(Me.txtCodProd.Text)
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        If Not ValidarDetalle() Then
            Exit Sub
        End If

        If Not BuscarDuplicado(Me.txtCodProd.EditValue, gvDetalle, "CODPROD") Then
            gvDetalle.AddNewRow()

            Dim total, subtotal As Double
            Dim igv As Decimal

            igv = CDbl(Me.txtPrecio.Text) * valorIgv
            total = CDbl(Me.txtPrecio.Text) * CDbl(Me.txtCantidad.Text)
            subtotal = total - igv

            Dim fila = gvDetalle.FocusedRowHandle()
            gvDetalle.SetRowCellValue(fila, "CODPROD", Me.txtCodProd.Text)
            gvDetalle.SetRowCellValue(fila, "DESCRIPCION_DEL_PRODUCTO", Me.txtProducto.Text)
            gvDetalle.SetRowCellValue(fila, "CODUNI", CInt(cmbUnidad.GetColumnValue("codi_unid")))
            gvDetalle.SetRowCellValue(fila, "CANTIDAD", CDbl(Me.txtCantidad.Text))
            gvDetalle.SetRowCellValue(fila, "VALOR", CDbl(Me.txtPrecio.Text))
            gvDetalle.SetRowCellValue(fila, "VALIGV", valorIgv)
            gvDetalle.SetRowCellValue(fila, "TOTIGV", igv)
            gvDetalle.SetRowCellValue(fila, "SUBT", subtotal)
            gvDetalle.SetRowCellValue(fila, "TOTAL", total)
            gvDetalle.UpdateCurrentRow()

            If CInt(cmbDocVenta.GetColumnValue("id_dove")) = 2 Then
                CalcularTotalFactura()
            Else
                CalcularTotalRecBol()
            End If
            'CalcularTotal()
        End If


    End Sub

    Private Sub cmbDocVenta_EditValueChanged(sender As System.Object, e As System.EventArgs)
        Me.txtNumDoc.Properties.Mask.EditMask = DocumentoVenta.ObtenerFormatoDocumento(CInt(cmbDocVenta.GetColumnValue("id_dove")))
        DocumentoVenta.ObtenerFormatoDocumento(CInt(cmbDocVenta.GetColumnValue("id_dove")))

    End Sub

    Sub MostrarDocumentoVenta()
        If CInt(cmbDocVenta.GetColumnValue("id_dove")) = 2 Then
            Dim repDocFactura As New xrc_documento_factura
            Imprimir.reporte(Venta.ImprimeDvFactura(Me.txtCodigo.EditValue), repDocFactura, "Imprimir Factura")

        ElseIf CInt(cmbDocVenta.GetColumnValue("id_dove")) = 3 Then
            Dim repDocRecibo As New xrc_documento_recibo
            repDocRecibo.prmExtornado.Visible = False
            Imprimir.reporte(Venta.ImprimeDvRecibo(Me.txtCodigo.EditValue), repDocRecibo, "Recibo de Ingresos")
        End If
    End Sub

    Private Sub dgDetalle_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgDetalle.KeyDown
        If e.KeyCode = Keys.Delete Then
            gvDetalle.DeleteSelectedRows()
            If CInt(cmbUnidad.GetColumnValue("id_dove")) = 2 Then
                CalcularTotalFactura()
            Else
                CalcularTotalRecBol()
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Cancelar()
        dgDetalle.DataSource = Nothing
        'gvDetalle.SelectAll()
        'gvDetalle.DeleteSelectedRows()
    End Sub

    Private Sub cmbFormaPago_EditValueChanged(sender As System.Object, e As System.EventArgs)
        If cmbFormaPago.GetColumnValue("id_fopa") = 3 Then
            Me.cmbBanco.Enabled = True
            Me.txtNumCheque.Enabled = True
        Else
            Me.cmbBanco.Enabled = False
            Me.txtNumCheque.Enabled = False

        End If
    End Sub

    Private Sub btnBuscarVenta_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarVenta.Click
       
        frm_venta_consulta_editar.ShowDialog()
       
    End Sub

    Private Sub cmbDocVenta_EditValueChanged_1(sender As System.Object, e As System.EventArgs) Handles cmbDocVenta.EditValueChanged
        Me.txtNumDoc.Properties.Mask.EditMask = DocumentoVenta.ObtenerFormatoDocumento(CInt(cmbDocVenta.GetColumnValue("id_dove")))
        DocumentoVenta.ObtenerFormatoDocumento(CInt(cmbDocVenta.GetColumnValue("id_dove")))
    End Sub

    'Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
    '    'LimpiarCajas()
    '    gvDetalle.Focus()
    '    'dgDetalle.Focus()
    '    gvDetalle.SelectAll()
    '    gvDetalle.DeleteSelectedRows()
    'End Sub
End Class
Imports Logica
Public Class frm_articulo
    Dim Producto As New cl_producto
    Dim TipoProducto As New cl_tipo_producto
    Dim Iva As New cl_igv
    Dim Unidad As New cl_unidad
    Dim Producto_Unidad As New cl_producto_unidad
    Dim flg As Byte

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        flg = 0 ' Nuevo
        Nuevo()
        HabilitarCajas()
        Me.txtCodigo.EditValue = "PR" & Format(Producto.GeneraCodigo, "00000000")
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If Not ValidarFormulario() Then
            Exit Sub
        End If

        If Not ValidaSeleccionUnidad() Then
            Exit Sub
        End If

        Producto.Codigo = Me.txtCodigo.Text
        Producto.Descripcion = Me.txtDescripcion.Text
        Producto.TipoProducto = CInt(cmbTipoProducto.GetColumnValue("codi_tipr"))
        Producto.Iva = CInt(cmbTipoIva.GetColumnValue("id_iva"))
        Producto.CostoProducto = CDbl(Me.txtCosto.Text)
        Producto.PrecioProducto = CDbl(Me.txtPrecioVenta.Text)

        If flg = 0 Then
            If Producto.AgregarProducto(chkUnidades) = True Then
                Producto.Listar_Producto(dgvProducto, 0)
            End If
        Else
            If Producto.ActualizarProducto(chkUnidades) = True Then
                Producto.Listar_Producto(dgvProducto, 0)
            End If
        End If
        Guardar()
        DeshabilitarCajas()
    End Sub

    Private Sub frm_articulo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TipoProducto.LlenarComboTipoProducto(cmbTipoProducto)
        Producto.Listar_Producto(dgvProducto, 0)
        Iva.LlenarComboIva(cmbTipoIva)
        Unidad.LlenarListaUnidades(chkUnidades)
        HeadGrid()
    End Sub

    Private Sub dgvProducto_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvProducto.DoubleClick
        Me.txtCodigo.EditValue = ObtenerItemDevGrid("codi_prod", gvProducto)
        Me.txtDescripcion.EditValue = ObtenerItemDevGrid("nomb_prod", gvProducto)
        Me.cmbTipoProducto.EditValue = ObtenerItemDevGrid("codi_tipr", gvProducto)
        Me.cmbTipoIva.EditValue = ObtenerItemDevGrid("id_iva", gvProducto)
        Me.txtCosto.Text = ObtenerItemDevGrid("cost_prod", gvProducto)
        Me.txtPrecioVenta.EditValue = ObtenerItemDevGrid("prec_prod", gvProducto)

        'Seleccionamos las Unidades
        Producto_Unidad.SeleccionaUnidades(chkUnidades, Me.txtCodigo.EditValue)

        flg = 1
        Actualizar()
        HabilitarCajas()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If flg = 1 Then
            Producto.Codigo = Me.txtCodigo.Text
            If Producto.EliminarProducto = True Then
                Producto.Listar_Producto(dgvProducto, 0)
            End If
            DeshabilitarCajas()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Cancelar()
        DeshabilitarCajas()
    End Sub


#Region "Funciones de control"
    Sub Nuevo()
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnNuevo.Enabled = False
        Me.btnEliminar.Enabled = False
        LimpiarCajas()
      
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
        LimpiarCajas()
    End Sub

    Sub LimpiarCajas()
        Me.txtCodigo.EditValue = ""
        Me.txtDescripcion.EditValue = ""
        Me.txtCosto.EditValue = ""
        Me.txtPrecioVenta.EditValue = ""
    End Sub

    Sub HabilitarCajas()
        Me.txtDescripcion.Enabled = True
        Me.txtCosto.Enabled = True
        Me.txtPrecioVenta.Enabled = True

        Me.cmbTipoIva.Enabled = True
        Me.cmbTipoProducto.Enabled = True

        Me.chkUnidades.Enabled = True
    End Sub

    Sub DeshabilitarCajas()
        Me.txtDescripcion.Enabled = False
        Me.txtCosto.Enabled = False
        Me.txtPrecioVenta.Enabled = False

        Me.cmbTipoIva.Enabled = False
        Me.cmbTipoProducto.Enabled = False

        Me.chkUnidades.Enabled = False
    End Sub
#End Region

#Region "Validar Formulario"
    Protected Function ValidarFormulario() As Boolean
        DxError.ClearErrors()

        If txtDescripcion.Text = "" Then
            DxError.SetError(txtDescripcion, "Falta descripción")
            With ToolTip
                ShowToolTipoBase(txtDescripcion, "Debe introducir la descripción del producto o servicio", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtDescripcion.Focus()
            End With
            Return False
        End If

        If cmbTipoProducto.Text = "" Then
            DxError.SetError(cmbTipoProducto, "Falta elegir una categoría")
            With ToolTip
                ShowToolTipoBase(cmbTipoProducto, "Debe seleccionar la categoría del producto", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                cmbTipoProducto.Focus()
            End With
            Return False
        End If

        If cmbTipoIva.Text = "" Then
            DxError.SetError(cmbTipoIva, "Falta elegir el impuesto")
            With ToolTip
                ShowToolTipoBase(cmbTipoIva, "Debe seleccionar el impuesto a aplicar al producto", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                cmbTipoIva.Focus()
            End With
            Return False
        End If

        If txtCosto.Text = "" Then
            DxError.SetError(txtCosto, "Falta el costo")
            With ToolTip
                ShowToolTipoBase(txtCosto, "Debe introducir el costo del producto o servicio", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtCosto.Focus()
            End With
            Return False
        End If

      
        If txtPrecioVenta.Text = "" Then
            DxError.SetError(txtPrecioVenta, "Falta el precio de venta")
            With ToolTip
                ShowToolTipoBase(txtPrecioVenta, "Debe introducir el precio de venta al público", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                txtPrecioVenta.Focus()
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

    Function ValidaSeleccionUnidad() As Boolean
        DxError.ClearErrors()
        Dim i As Integer
        Dim nElementos = chkUnidades.ItemCount
        Dim contador = 0

        For i = 0 To nElementos - 1
            If chkUnidades.GetItemCheckState(i) = CheckState.Unchecked Then
                contador = contador + 1
            End If
        Next
        If nElementos = contador Then
            DxError.SetError(chkUnidades, "Falta elegir Unidad")
            With ToolTip
                ShowToolTipoBase(chkUnidades, "Debe seleccionar al menos una Unidad de prodcuto", "Datos insuficientes", DevExpress.Utils.ToolTipIconType.Error)
                chkUnidades.Focus()
            End With
            Return False
        End If

        Return True
    End Function

#End Region

#Region "Look Grid"
    Sub HeadGrid()
        gvProducto.Columns(0).Width = 80
        gvProducto.Columns(0).Caption = "CODIGO"
        gvProducto.Columns(1).Caption = "DESCRIPCION DEL PRODUCTO"
        gvProducto.Columns(2).Caption = "TIPO PRODUCTO"
        gvProducto.Columns(3).Caption = "COSTO"
        gvProducto.Columns(4).Caption = "PRECIO VENTA"
        gvProducto.Columns(5).Caption = "IMPUESTO"

    End Sub
#End Region


End Class
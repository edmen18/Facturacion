<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_venta_editar
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_venta_editar))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.txtSubtotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtIgv = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCliente = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtNumDoc = New DevExpress.XtraEditors.TextEdit()
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cmbFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbBanco = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbDocVenta = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnBuscarVenta = New DevExpress.XtraEditors.SimpleButton()
        Me.lblMontoLetras = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumCheque = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodCli = New DevExpress.XtraEditors.TextEdit()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.gcDetalle = New DevExpress.XtraEditors.GroupControl()
        Me.cmbUnidad = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCodProd = New DevExpress.XtraEditors.TextEdit()
        Me.txtPrecio = New DevExpress.XtraEditors.TextEdit()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtProducto = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.dgDetalle = New DevExpress.XtraGrid.GridControl()
        Me.gvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DxError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.txtNota = New DevExpress.XtraEditors.MemoEdit()
        Me.ToolTip = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.txtSubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIgv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDocVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodCli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcDetalle.SuspendLayout()
        CType(Me.cmbUnidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(760, 450)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSubtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSubtotal.Properties.Mask.EditMask = "c"
        Me.txtSubtotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSubtotal.Size = New System.Drawing.Size(123, 20)
        Me.txtSubtotal.TabIndex = 3
        '
        'txtIgv
        '
        Me.txtIgv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIgv.Enabled = False
        Me.txtIgv.Location = New System.Drawing.Point(760, 476)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIgv.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIgv.Properties.Mask.EditMask = "c"
        Me.txtIgv.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIgv.Size = New System.Drawing.Size(123, 20)
        Me.txtIgv.TabIndex = 4
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(760, 502)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.Mask.EditMask = "c2"
        Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal.Size = New System.Drawing.Size(123, 20)
        Me.txtTotal.TabIndex = 5
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Location = New System.Drawing.Point(557, 545)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 24)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Editar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(641, 545)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 24)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(725, 545)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(78, 24)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(809, 545)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 24)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(14, 66)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(98, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 51)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Código"
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(244, 66)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtCliente.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtCliente.Size = New System.Drawing.Size(212, 20)
        Me.txtCliente.TabIndex = 5
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumDoc.Enabled = False
        Me.txtNumDoc.Location = New System.Drawing.Point(709, 66)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Properties.Mask.EditMask = "0000-000000"
        Me.txtNumDoc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtNumDoc.Size = New System.Drawing.Size(161, 20)
        Me.txtNumDoc.TabIndex = 8
        '
        'dtpFecha
        '
        Me.dtpFecha.EditValue = Nothing
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(14, 113)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFecha.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.dtpFecha.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.dtpFecha.Size = New System.Drawing.Size(198, 20)
        Me.dtpFecha.TabIndex = 9
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionImage = Global.Facturacion.My.Resources.Resources._47
        Me.GroupControl1.Controls.Add(Me.cmbFormaPago)
        Me.GroupControl1.Controls.Add(Me.cmbBanco)
        Me.GroupControl1.Controls.Add(Me.cmbDocVenta)
        Me.GroupControl1.Controls.Add(Me.btnBuscarVenta)
        Me.GroupControl1.Controls.Add(Me.lblMontoLetras)
        Me.GroupControl1.Controls.Add(Me.dtpFecha)
        Me.GroupControl1.Controls.Add(Me.txtNumCheque)
        Me.GroupControl1.Controls.Add(Me.txtNumDoc)
        Me.GroupControl1.Controls.Add(Me.txtCliente)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtCodCli)
        Me.GroupControl1.Controls.Add(Me.txtCodigo)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 16)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(876, 523)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Datos de la Venta"
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFormaPago.EditValue = ""
        Me.cmbFormaPago.Enabled = False
        Me.cmbFormaPago.EnterMoveNextControl = True
        Me.cmbFormaPago.Location = New System.Drawing.Point(218, 113)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbFormaPago.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_fopa", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_fopa", "Descripción")})
        Me.cmbFormaPago.Properties.NullText = ""
        Me.cmbFormaPago.Size = New System.Drawing.Size(239, 20)
        Me.cmbFormaPago.TabIndex = 20
        '
        'cmbBanco
        '
        Me.cmbBanco.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBanco.EditValue = ""
        Me.cmbBanco.Enabled = False
        Me.cmbBanco.EnterMoveNextControl = True
        Me.cmbBanco.Location = New System.Drawing.Point(464, 113)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbBanco.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_banc", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_banc", "Nombre de banco")})
        Me.cmbBanco.Properties.NullText = ""
        Me.cmbBanco.Size = New System.Drawing.Size(243, 20)
        Me.cmbBanco.TabIndex = 21
        '
        'cmbDocVenta
        '
        Me.cmbDocVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDocVenta.EditValue = ""
        Me.cmbDocVenta.Enabled = False
        Me.cmbDocVenta.EnterMoveNextControl = True
        Me.cmbDocVenta.Location = New System.Drawing.Point(463, 66)
        Me.cmbDocVenta.Name = "cmbDocVenta"
        Me.cmbDocVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDocVenta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_dove", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_dove", "Descripción"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_mask", "Mak", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cmbDocVenta.Properties.NullText = ""
        Me.cmbDocVenta.Size = New System.Drawing.Size(243, 20)
        Me.cmbDocVenta.TabIndex = 19
        '
        'btnBuscarVenta
        '
        Me.btnBuscarVenta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnBuscarVenta.Enabled = False
        Me.btnBuscarVenta.Location = New System.Drawing.Point(110, 66)
        Me.btnBuscarVenta.Name = "btnBuscarVenta"
        Me.btnBuscarVenta.Size = New System.Drawing.Size(21, 20)
        Me.btnBuscarVenta.TabIndex = 18
        Me.btnBuscarVenta.Text = "..."
        '
        'lblMontoLetras
        '
        Me.lblMontoLetras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMontoLetras.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblMontoLetras.Location = New System.Drawing.Point(5, 493)
        Me.lblMontoLetras.Name = "lblMontoLetras"
        Me.lblMontoLetras.Size = New System.Drawing.Size(0, 13)
        Me.lblMontoLetras.TabIndex = 16
        '
        'txtNumCheque
        '
        Me.txtNumCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumCheque.Enabled = False
        Me.txtNumCheque.Location = New System.Drawing.Point(712, 113)
        Me.txtNumCheque.Name = "txtNumCheque"
        Me.txtNumCheque.Properties.Mask.EditMask = "0000-000000"
        Me.txtNumCheque.Size = New System.Drawing.Size(161, 20)
        Me.txtNumCheque.TabIndex = 8
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Location = New System.Drawing.Point(709, 489)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl10.TabIndex = 17
        Me.LabelControl10.Text = "Total"
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Location = New System.Drawing.Point(717, 463)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Igv"
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Location = New System.Drawing.Point(14, 429)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl7.TabIndex = 17
        Me.LabelControl7.Text = "Nota:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Location = New System.Drawing.Point(693, 437)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl8.TabIndex = 17
        Me.LabelControl8.Text = "Subtotal"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(14, 94)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "Fecha de venta"
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Location = New System.Drawing.Point(712, 98)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl12.TabIndex = 4
        Me.LabelControl12.Text = "Numero Cheque"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Location = New System.Drawing.Point(709, 51)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Numero documento"
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Location = New System.Drawing.Point(463, 98)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl11.TabIndex = 4
        Me.LabelControl11.Text = "Seleccione Banco"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(217, 94)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Forma de Pago"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Location = New System.Drawing.Point(462, 51)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Doc. Venta"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(137, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Cliente"
        '
        'txtCodCli
        '
        Me.txtCodCli.Enabled = False
        Me.txtCodCli.Location = New System.Drawing.Point(137, 66)
        Me.txtCodCli.Name = "txtCodCli"
        Me.txtCodCli.Size = New System.Drawing.Size(102, 20)
        Me.txtCodCli.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Image = Global.Facturacion.My.Resources.Resources.S40
        Me.btnAgregar.Location = New System.Drawing.Point(770, 63)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(90, 23)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        '
        'gcDetalle
        '
        Me.gcDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDetalle.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcDetalle.AppearanceCaption.Options.UseFont = True
        Me.gcDetalle.CaptionImage = Global.Facturacion.My.Resources.Resources._90
        Me.gcDetalle.Controls.Add(Me.cmbUnidad)
        Me.gcDetalle.Controls.Add(Me.txtCodProd)
        Me.gcDetalle.Controls.Add(Me.btnAgregar)
        Me.gcDetalle.Controls.Add(Me.txtPrecio)
        Me.gcDetalle.Controls.Add(Me.txtCantidad)
        Me.gcDetalle.Controls.Add(Me.txtProducto)
        Me.gcDetalle.Controls.Add(Me.LabelControl17)
        Me.gcDetalle.Controls.Add(Me.LabelControl16)
        Me.gcDetalle.Controls.Add(Me.LabelControl15)
        Me.gcDetalle.Controls.Add(Me.LabelControl14)
        Me.gcDetalle.Controls.Add(Me.dgDetalle)
        Me.gcDetalle.Location = New System.Drawing.Point(18, 173)
        Me.gcDetalle.Name = "gcDetalle"
        Me.gcDetalle.Size = New System.Drawing.Size(865, 266)
        Me.gcDetalle.TabIndex = 15
        Me.gcDetalle.Text = "Detalle de la Venta"
        '
        'cmbUnidad
        '
        Me.cmbUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbUnidad.EditValue = ""
        Me.cmbUnidad.Enabled = False
        Me.cmbUnidad.EnterMoveNextControl = True
        Me.cmbUnidad.Location = New System.Drawing.Point(478, 66)
        Me.cmbUnidad.Name = "cmbUnidad"
        Me.cmbUnidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbUnidad.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("codi_unid", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_unid", "Descripción")})
        Me.cmbUnidad.Properties.NullText = ""
        Me.cmbUnidad.Size = New System.Drawing.Size(187, 20)
        Me.cmbUnidad.TabIndex = 27
        '
        'txtCodProd
        '
        Me.txtCodProd.Enabled = False
        Me.txtCodProd.Location = New System.Drawing.Point(9, 66)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(86, 20)
        Me.txtCodProd.TabIndex = 25
        '
        'txtPrecio
        '
        Me.txtPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(671, 66)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecio.Properties.Mask.EditMask = "c2"
        Me.txtPrecio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecio.Size = New System.Drawing.Size(93, 20)
        Me.txtPrecio.TabIndex = 24
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(407, 66)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCantidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCantidad.Properties.Mask.EditMask = "n"
        Me.txtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Size = New System.Drawing.Size(65, 20)
        Me.txtCantidad.TabIndex = 26
        '
        'txtProducto
        '
        Me.txtProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProducto.Enabled = False
        Me.txtProducto.Location = New System.Drawing.Point(97, 66)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtProducto.Size = New System.Drawing.Size(304, 20)
        Me.txtProducto.TabIndex = 23
        '
        'LabelControl17
        '
        Me.LabelControl17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl17.Location = New System.Drawing.Point(671, 50)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl17.TabIndex = 17
        Me.LabelControl17.Text = "Valor"
        '
        'LabelControl16
        '
        Me.LabelControl16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl16.Location = New System.Drawing.Point(478, 50)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl16.TabIndex = 18
        Me.LabelControl16.Text = "Forma"
        '
        'LabelControl15
        '
        Me.LabelControl15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl15.Location = New System.Drawing.Point(407, 50)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl15.TabIndex = 19
        Me.LabelControl15.Text = "Cantidad"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(9, 50)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl14.TabIndex = 20
        Me.LabelControl14.Text = "Producto"
        '
        'dgDetalle
        '
        Me.dgDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalle.Location = New System.Drawing.Point(9, 117)
        Me.dgDetalle.MainView = Me.gvDetalle
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.Size = New System.Drawing.Size(851, 129)
        Me.dgDetalle.TabIndex = 21
        Me.dgDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalle})
        '
        'gvDetalle
        '
        Me.gvDetalle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvDetalle.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvDetalle.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvDetalle.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvDetalle.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gvDetalle.Appearance.Empty.Options.UseBackColor = True
        Me.gvDetalle.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gvDetalle.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gvDetalle.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvDetalle.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvDetalle.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvDetalle.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gvDetalle.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvDetalle.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gvDetalle.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvDetalle.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.gvDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvDetalle.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvDetalle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvDetalle.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvDetalle.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvDetalle.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvDetalle.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvDetalle.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvDetalle.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvDetalle.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvDetalle.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvDetalle.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvDetalle.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvDetalle.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvDetalle.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvDetalle.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvDetalle.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvDetalle.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvDetalle.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvDetalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvDetalle.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.gvDetalle.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.gvDetalle.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gvDetalle.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvDetalle.Appearance.HorzLine.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.OddRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.OddRow.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.OddRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvDetalle.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gvDetalle.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.gvDetalle.Appearance.Preview.Options.UseBackColor = True
        Me.gvDetalle.Appearance.Preview.Options.UseFont = True
        Me.gvDetalle.Appearance.Preview.Options.UseForeColor = True
        Me.gvDetalle.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.Row.Options.UseBackColor = True
        Me.gvDetalle.Appearance.Row.Options.UseForeColor = True
        Me.gvDetalle.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gvDetalle.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvDetalle.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.gvDetalle.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvDetalle.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.gvDetalle.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gvDetalle.Appearance.VertLine.Options.UseBackColor = True
        Me.gvDetalle.Appearance.VertLine.Options.UseBorderColor = True
        Me.gvDetalle.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvDetalle.GridControl = Me.dgDetalle
        Me.gvDetalle.Name = "gvDetalle"
        Me.gvDetalle.OptionsBehavior.Editable = False
        Me.gvDetalle.OptionsSelection.MultiSelect = True
        Me.gvDetalle.OptionsView.EnableAppearanceEvenRow = True
        Me.gvDetalle.OptionsView.EnableAppearanceOddRow = True
        Me.gvDetalle.OptionsView.ShowGroupPanel = False
        '
        'DxError
        '
        Me.DxError.ContainerControl = Me
        '
        'txtNota
        '
        Me.txtNota.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNota.Enabled = False
        Me.txtNota.Location = New System.Drawing.Point(27, 461)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNota.Properties.MaxLength = 100
        Me.txtNota.Size = New System.Drawing.Size(410, 35)
        Me.txtNota.TabIndex = 17
        '
        'frm_venta_editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 581)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.gcDetalle)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtIgv)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frm_venta_editar"
        Me.Text = "Facturación"
        CType(Me.txtSubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIgv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDocVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodCli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcDetalle.ResumeLayout(False)
        Me.gcDetalle.PerformLayout()
        CType(Me.cmbUnidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSubtotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIgv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCliente As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtNumDoc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodCli As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcDetalle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCodProd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPrecio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProducto As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblMontoLetras As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DxError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents ToolTip As DevExpress.Utils.ToolTipController
    Friend WithEvents txtNota As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBuscarVenta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbDocVenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbBanco As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbUnidad As DevExpress.XtraEditors.LookUpEdit
End Class

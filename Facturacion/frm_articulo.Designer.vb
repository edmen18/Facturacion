<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_articulo
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.chkUnidades = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbTipoIva = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCosto = New DevExpress.XtraEditors.TextEdit()
        Me.cmbTipoProducto = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.txtPrecioVenta = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvProducto = New DevExpress.XtraGrid.GridControl()
        Me.gvProducto = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DxError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.ToolTip = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.chkUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoIva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionImage = Global.Facturacion.My.Resources.Resources._12
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.btnCancelar)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.btnEliminar)
        Me.GroupControl1.Controls.Add(Me.chkUnidades)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.cmbTipoIva)
        Me.GroupControl1.Controls.Add(Me.btnNuevo)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtCosto)
        Me.GroupControl1.Controls.Add(Me.cmbTipoProducto)
        Me.GroupControl1.Controls.Add(Me.txtDescripcion)
        Me.GroupControl1.Controls.Add(Me.txtPrecioVenta)
        Me.GroupControl1.Controls.Add(Me.txtCodigo)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(15, 10)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(799, 549)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos del Producto"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(710, 226)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(629, 226)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Location = New System.Drawing.Point(684, 68)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl7.TabIndex = 19
        Me.LabelControl7.Text = "Seleccione Unidades:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(548, 226)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        '
        'chkUnidades
        '
        Me.chkUnidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkUnidades.Enabled = False
        Me.chkUnidades.Location = New System.Drawing.Point(684, 92)
        Me.chkUnidades.Name = "chkUnidades"
        Me.chkUnidades.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.chkUnidades.Size = New System.Drawing.Size(101, 113)
        Me.chkUnidades.TabIndex = 18
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(467, 226)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        '
        'cmbTipoIva
        '
        Me.cmbTipoIva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTipoIva.EditValue = ""
        Me.cmbTipoIva.Enabled = False
        Me.cmbTipoIva.EnterMoveNextControl = True
        Me.cmbTipoIva.Location = New System.Drawing.Point(190, 137)
        Me.cmbTipoIva.Name = "cmbTipoIva"
        Me.cmbTipoIva.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipoIva.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_iva", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_iva", "Impuesto")})
        Me.cmbTipoIva.Properties.NullText = ""
        Me.cmbTipoIva.Size = New System.Drawing.Size(488, 20)
        Me.cmbTipoIva.TabIndex = 3
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Location = New System.Drawing.Point(386, 226)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(21, 144)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Impuesto Aplicado:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(21, 192)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Precio venta:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(21, 168)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Costo:"
        '
        'txtCosto
        '
        Me.txtCosto.EditValue = ""
        Me.txtCosto.Enabled = False
        Me.txtCosto.EnterMoveNextControl = True
        Me.txtCosto.Location = New System.Drawing.Point(190, 161)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCosto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCosto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtCosto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCosto.Properties.EditFormat.FormatString = "0.00"
        Me.txtCosto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCosto.Properties.Mask.EditMask = "c"
        Me.txtCosto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCosto.Size = New System.Drawing.Size(148, 20)
        Me.txtCosto.TabIndex = 4
        '
        'cmbTipoProducto
        '
        Me.cmbTipoProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTipoProducto.EditValue = ""
        Me.cmbTipoProducto.Enabled = False
        Me.cmbTipoProducto.EnterMoveNextControl = True
        Me.cmbTipoProducto.Location = New System.Drawing.Point(190, 113)
        Me.cmbTipoProducto.Name = "cmbTipoProducto"
        Me.cmbTipoProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipoProducto.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("codi_tipr", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_tipr", "Descripcion")})
        Me.cmbTipoProducto.Properties.NullText = ""
        Me.cmbTipoProducto.Size = New System.Drawing.Size(488, 20)
        Me.cmbTipoProducto.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.EnterMoveNextControl = True
        Me.txtDescripcion.Location = New System.Drawing.Point(190, 89)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtDescripcion.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Size = New System.Drawing.Size(488, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Enabled = False
        Me.txtPrecioVenta.EnterMoveNextControl = True
        Me.txtPrecioVenta.Location = New System.Drawing.Point(190, 185)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecioVenta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecioVenta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtPrecioVenta.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPrecioVenta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrecioVenta.Properties.Mask.EditMask = "c2"
        Me.txtPrecioVenta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioVenta.Size = New System.Drawing.Size(148, 20)
        Me.txtPrecioVenta.TabIndex = 5
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(190, 65)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(21, 96)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(121, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Descripción del producto:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(21, 118)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Tipo de producto:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 72)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "ID Producto:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionImage = Global.Facturacion.My.Resources.Resources._126
        Me.GroupControl2.Controls.Add(Me.dgvProducto)
        Me.GroupControl2.Location = New System.Drawing.Point(31, 278)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(769, 276)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Listado de Productos"
        '
        'dgvProducto
        '
        Me.dgvProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducto.Location = New System.Drawing.Point(5, 43)
        Me.dgvProducto.MainView = Me.gvProducto
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.Size = New System.Drawing.Size(759, 228)
        Me.dgvProducto.TabIndex = 0
        Me.dgvProducto.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProducto})
        '
        'gvProducto
        '
        Me.gvProducto.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvProducto.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvProducto.Appearance.FocusedRow.BackColor = System.Drawing.Color.Orange
        Me.gvProducto.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvProducto.GridControl = Me.dgvProducto
        Me.gvProducto.Name = "gvProducto"
        Me.gvProducto.OptionsBehavior.Editable = False
        '
        'DxError
        '
        Me.DxError.ContainerControl = Me
        '
        'frm_articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 571)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frm_articulo"
        Me.Text = "Registro de artículo"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.chkUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoIva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Private WithEvents cmbTipoProducto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecioVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cmbTipoIva As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkUnidades As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToolTip As DevExpress.Utils.ToolTipController
    Friend WithEvents DxError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents dgvProducto As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProducto As DevExpress.XtraGrid.Views.Grid.GridView
End Class

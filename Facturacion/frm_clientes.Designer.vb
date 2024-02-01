<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes
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
        Me.gcCliente = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvCliente = New DevExpress.XtraGrid.GridControl()
        Me.gvClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbTipoCliente = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumDoc = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.DxError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.ToolTip = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.gcCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcCliente.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcCliente
        '
        Me.gcCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcCliente.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcCliente.AppearanceCaption.Options.UseFont = True
        Me.gcCliente.CaptionImage = Global.Facturacion.My.Resources.Resources.M_18
        Me.gcCliente.Controls.Add(Me.GroupControl2)
        Me.gcCliente.Controls.Add(Me.btnCancelar)
        Me.gcCliente.Controls.Add(Me.cmbTipoCliente)
        Me.gcCliente.Controls.Add(Me.LabelControl7)
        Me.gcCliente.Controls.Add(Me.LabelControl6)
        Me.gcCliente.Controls.Add(Me.btnSalir)
        Me.gcCliente.Controls.Add(Me.LabelControl5)
        Me.gcCliente.Controls.Add(Me.btnEliminar)
        Me.gcCliente.Controls.Add(Me.btnGuardar)
        Me.gcCliente.Controls.Add(Me.btnNuevo)
        Me.gcCliente.Controls.Add(Me.txtEmail)
        Me.gcCliente.Controls.Add(Me.txtTelefono)
        Me.gcCliente.Controls.Add(Me.txtDireccion)
        Me.gcCliente.Controls.Add(Me.txtNumDoc)
        Me.gcCliente.Controls.Add(Me.txtNombre)
        Me.gcCliente.Controls.Add(Me.txtCodigo)
        Me.gcCliente.Controls.Add(Me.LabelControl4)
        Me.gcCliente.Controls.Add(Me.LabelControl3)
        Me.gcCliente.Controls.Add(Me.LabelControl2)
        Me.gcCliente.Controls.Add(Me.LabelControl1)
        Me.gcCliente.Controls.Add(Me.PictureEdit1)
        Me.gcCliente.Location = New System.Drawing.Point(12, 12)
        Me.gcCliente.Name = "gcCliente"
        Me.gcCliente.Size = New System.Drawing.Size(833, 566)
        Me.gcCliente.TabIndex = 0
        Me.gcCliente.Text = "Información del Cliente"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionImage = Global.Facturacion.My.Resources.Resources._126
        Me.GroupControl2.Controls.Add(Me.dgvCliente)
        Me.GroupControl2.Location = New System.Drawing.Point(18, 288)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(798, 273)
        Me.GroupControl2.TabIndex = 21
        Me.GroupControl2.Text = "Listado de Clientes"
        '
        'dgvCliente
        '
        Me.dgvCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCliente.Location = New System.Drawing.Point(5, 43)
        Me.dgvCliente.MainView = Me.gvClientes
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.Size = New System.Drawing.Size(788, 225)
        Me.dgvCliente.TabIndex = 21
        Me.dgvCliente.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvClientes})
        '
        'gvClientes
        '
        Me.gvClientes.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvClientes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvClientes.Appearance.FocusedRow.BackColor = System.Drawing.Color.Orange
        Me.gvClientes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvClientes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.gvClientes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvClientes.GridControl = Me.dgvCliente
        Me.gvClientes.Name = "gvClientes"
        Me.gvClientes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvClientes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvClientes.OptionsBehavior.Editable = False
        Me.gvClientes.OptionsBehavior.ReadOnly = True
        Me.gvClientes.OptionsView.ShowAutoFilterRow = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Código"
        Me.GridColumn1.FieldName = "codi_clie"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 80
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tipo Clie"
        Me.GridColumn2.FieldName = "id_ticl"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Nombre / Razón social"
        Me.GridColumn3.FieldName = "nomb_clie"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 200
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Documento"
        Me.GridColumn4.FieldName = "nudo_clie"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 113
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Direccion"
        Me.GridColumn5.FieldName = "dire_clie"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 113
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Telefono"
        Me.GridColumn6.FieldName = "tele_clie"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 113
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Email"
        Me.GridColumn7.FieldName = "emai_clie"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 122
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(579, 246)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        '
        'cmbTipoCliente
        '
        Me.cmbTipoCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTipoCliente.EditValue = ""
        Me.cmbTipoCliente.Enabled = False
        Me.cmbTipoCliente.EnterMoveNextControl = True
        Me.cmbTipoCliente.Location = New System.Drawing.Point(336, 88)
        Me.cmbTipoCliente.Name = "cmbTipoCliente"
        Me.cmbTipoCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipoCliente.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_ticl", 10, "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_ticl", 30, "Descripción")})
        Me.cmbTipoCliente.Properties.NullText = ""
        Me.cmbTipoCliente.Size = New System.Drawing.Size(480, 20)
        Me.cmbTipoCliente.TabIndex = 2
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(215, 217)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl7.TabIndex = 1
        Me.LabelControl7.Text = "Email de cliente:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Location = New System.Drawing.Point(668, 185)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 1
        Me.LabelControl6.Text = "Teléfono:"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(741, 246)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(215, 185)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Dirección:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(660, 246)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(498, 246)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Location = New System.Drawing.Point(417, 246)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Enabled = False
        Me.txtEmail.EnterMoveNextControl = True
        Me.txtEmail.Location = New System.Drawing.Point(336, 210)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtEmail.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEmail.Size = New System.Drawing.Size(480, 20)
        Me.txtEmail.TabIndex = 7
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.EnterMoveNextControl = True
        Me.txtTelefono.Location = New System.Drawing.Point(724, 178)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtTelefono.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTelefono.Properties.NullText = "0"
        Me.txtTelefono.Size = New System.Drawing.Size(92, 20)
        Me.txtTelefono.TabIndex = 6
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.EnterMoveNextControl = True
        Me.txtDireccion.Location = New System.Drawing.Point(336, 178)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtDireccion.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDireccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Size = New System.Drawing.Size(315, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumDoc.Enabled = False
        Me.txtNumDoc.EnterMoveNextControl = True
        Me.txtNumDoc.Location = New System.Drawing.Point(336, 149)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtNumDoc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNumDoc.Properties.Mask.EditMask = "d11"
        Me.txtNumDoc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumDoc.Properties.MaxLength = 11
        Me.txtNumDoc.Size = New System.Drawing.Size(480, 20)
        Me.txtNumDoc.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Enabled = False
        Me.txtNombre.EnterMoveNextControl = True
        Me.txtNombre.Location = New System.Drawing.Point(336, 121)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtNombre.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Size = New System.Drawing.Size(480, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(336, 59)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(215, 156)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Nro. Documento:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(215, 128)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Nombre / Razón Social:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(215, 96)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tipo de persona:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(215, 66)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "ID Cliente:"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(18, 66)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(173, 164)
        Me.PictureEdit1.TabIndex = 0
        '
        'DxError
        '
        Me.DxError.ContainerControl = Me
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 587)
        Me.Controls.Add(Me.gcCliente)
        Me.Name = "frm_clientes"
        Me.Text = "Registro de Clientes"
        CType(Me.gcCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcCliente.ResumeLayout(False)
        Me.gcCliente.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcCliente As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumDoc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Private WithEvents cmbTipoCliente As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolTip As DevExpress.Utils.ToolTipController
    Friend WithEvents DxError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvCliente As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
End Class

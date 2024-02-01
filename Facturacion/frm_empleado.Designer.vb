<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_empleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_empleado))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnPermisos = New DevExpress.XtraEditors.SimpleButton()
        Me.chkAdmin = New DevExpress.XtraEditors.CheckEdit()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbCargo = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtConfirmar = New DevExpress.XtraEditors.TextEdit()
        Me.txtClave = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumDoc = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.xtcEmpleados = New DevExpress.XtraTab.XtraTabControl()
        Me.tpgDireccion = New DevExpress.XtraTab.XtraTabPage()
        Me.vgcEmpleados = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.category = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowcodi_empl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownomb_empl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowid_carg = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownudo_empl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.category1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowdire_empl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowtele_empl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.Acceso = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowusua_empl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowclav_empl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowesad_empl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.DxError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.ToolTip = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.chkAdmin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConfirmar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcEmpleados.SuspendLayout()
        Me.tpgDireccion.SuspendLayout()
        CType(Me.vgcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionImage = Global.Facturacion.My.Resources.Resources.M_18
        Me.GroupControl1.Controls.Add(Me.btnPermisos)
        Me.GroupControl1.Controls.Add(Me.chkAdmin)
        Me.GroupControl1.Controls.Add(Me.btnCancelar)
        Me.GroupControl1.Controls.Add(Me.cmbCargo)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.btnEliminar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.btnNuevo)
        Me.GroupControl1.Controls.Add(Me.txtConfirmar)
        Me.GroupControl1.Controls.Add(Me.txtClave)
        Me.GroupControl1.Controls.Add(Me.txtUsuario)
        Me.GroupControl1.Controls.Add(Me.txtTelefono)
        Me.GroupControl1.Controls.Add(Me.txtDireccion)
        Me.GroupControl1.Controls.Add(Me.txtNumDoc)
        Me.GroupControl1.Controls.Add(Me.txtNombre)
        Me.GroupControl1.Controls.Add(Me.txtCodigo)
        Me.GroupControl1.Controls.Add(Me.xtcEmpleados)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.PictureEdit1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(820, 556)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Información del Empleado"
        '
        'btnPermisos
        '
        Me.btnPermisos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPermisos.Enabled = False
        Me.btnPermisos.Image = Global.Facturacion.My.Resources.Resources.M_13
        Me.btnPermisos.Location = New System.Drawing.Point(687, 0)
        Me.btnPermisos.Name = "btnPermisos"
        Me.btnPermisos.Size = New System.Drawing.Size(128, 37)
        Me.btnPermisos.TabIndex = 17
        Me.btnPermisos.Text = "Permisos"
        '
        'chkAdmin
        '
        Me.chkAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAdmin.Location = New System.Drawing.Point(711, 59)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Properties.Caption = "Administrador"
        Me.chkAdmin.Size = New System.Drawing.Size(91, 19)
        Me.chkAdmin.TabIndex = 16
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(567, 259)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        '
        'cmbCargo
        '
        Me.cmbCargo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCargo.EditValue = ""
        Me.cmbCargo.Enabled = False
        Me.cmbCargo.Location = New System.Drawing.Point(336, 149)
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCargo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_carg", "Cargo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_carg", "Descripcion")})
        Me.cmbCargo.Properties.NullText = ""
        Me.cmbCargo.Size = New System.Drawing.Size(467, 20)
        Me.cmbCargo.TabIndex = 6
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(602, 213)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl11.TabIndex = 1
        Me.LabelControl11.Text = "Confirmar Clave:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(450, 213)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl10.TabIndex = 1
        Me.LabelControl10.Text = "Clave:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(216, 220)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl9.TabIndex = 1
        Me.LabelControl9.Text = "Usuario:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Location = New System.Drawing.Point(655, 185)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 1
        Me.LabelControl6.Text = "Teléfono:"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(729, 259)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(215, 186)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Dirección:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(648, 259)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(486, 259)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Location = New System.Drawing.Point(405, 259)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo"
        '
        'txtConfirmar
        '
        Me.txtConfirmar.Enabled = False
        Me.txtConfirmar.Location = New System.Drawing.Point(701, 210)
        Me.txtConfirmar.Name = "txtConfirmar"
        Me.txtConfirmar.Properties.Appearance.Font = New System.Drawing.Font("Californian FB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmar.Properties.Appearance.Options.UseFont = True
        Me.txtConfirmar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtConfirmar.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtConfirmar.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmar.Size = New System.Drawing.Size(103, 22)
        Me.txtConfirmar.TabIndex = 3
        '
        'txtClave
        '
        Me.txtClave.Enabled = False
        Me.txtClave.Location = New System.Drawing.Point(489, 210)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Properties.Appearance.Font = New System.Drawing.Font("Californian FB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Properties.Appearance.Options.UseFont = True
        Me.txtClave.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtClave.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtClave.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtClave.Size = New System.Drawing.Size(103, 22)
        Me.txtClave.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(338, 210)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtUsuario.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Size = New System.Drawing.Size(103, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(711, 178)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtTelefono.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTelefono.Size = New System.Drawing.Size(92, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(336, 179)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtDireccion.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDireccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Size = New System.Drawing.Size(302, 20)
        Me.txtDireccion.TabIndex = 3
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumDoc.Enabled = False
        Me.txtNumDoc.Location = New System.Drawing.Point(337, 122)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtNumDoc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNumDoc.Properties.Mask.EditMask = "d11"
        Me.txtNumDoc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumDoc.Properties.MaxLength = 11
        Me.txtNumDoc.Size = New System.Drawing.Size(467, 20)
        Me.txtNumDoc.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(336, 89)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtNombre.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Size = New System.Drawing.Size(467, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(336, 59)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(144, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'xtcEmpleados
        '
        Me.xtcEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcEmpleados.Location = New System.Drawing.Point(24, 298)
        Me.xtcEmpleados.Name = "xtcEmpleados"
        Me.xtcEmpleados.SelectedTabPage = Me.tpgDireccion
        Me.xtcEmpleados.Size = New System.Drawing.Size(785, 247)
        Me.xtcEmpleados.TabIndex = 2
        Me.xtcEmpleados.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpgDireccion, Me.XtraTabPage2})
        '
        'tpgDireccion
        '
        Me.tpgDireccion.Controls.Add(Me.vgcEmpleados)
        Me.tpgDireccion.Image = Global.Facturacion.My.Resources.Resources.S05
        Me.tpgDireccion.Name = "tpgDireccion"
        Me.tpgDireccion.Size = New System.Drawing.Size(783, 219)
        Me.tpgDireccion.Text = "Listado de Empleados"
        '
        'vgcEmpleados
        '
        Me.vgcEmpleados.Appearance.Category.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.vgcEmpleados.Appearance.Category.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.vgcEmpleados.Appearance.Category.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vgcEmpleados.Appearance.Category.ForeColor = System.Drawing.Color.Black
        Me.vgcEmpleados.Appearance.Category.Options.UseBackColor = True
        Me.vgcEmpleados.Appearance.Category.Options.UseBorderColor = True
        Me.vgcEmpleados.Appearance.Category.Options.UseFont = True
        Me.vgcEmpleados.Appearance.Category.Options.UseForeColor = True
        Me.vgcEmpleados.Appearance.CategoryExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.vgcEmpleados.Appearance.CategoryExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.vgcEmpleados.Appearance.CategoryExpandButton.Options.UseBackColor = True
        Me.vgcEmpleados.Appearance.CategoryExpandButton.Options.UseBorderColor = True
        Me.vgcEmpleados.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.vgcEmpleados.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.vgcEmpleados.Appearance.Empty.Options.UseBackColor = True
        Me.vgcEmpleados.Appearance.ExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.vgcEmpleados.Appearance.ExpandButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.vgcEmpleados.Appearance.ExpandButton.Options.UseBackColor = True
        Me.vgcEmpleados.Appearance.ExpandButton.Options.UseBorderColor = True
        Me.vgcEmpleados.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vgcEmpleados.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vgcEmpleados.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vgcEmpleados.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vgcEmpleados.Appearance.FocusedRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.vgcEmpleados.Appearance.FocusedRecord.Options.UseBackColor = True
        Me.vgcEmpleados.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.vgcEmpleados.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.vgcEmpleados.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vgcEmpleados.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vgcEmpleados.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vgcEmpleados.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.vgcEmpleados.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.vgcEmpleados.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vgcEmpleados.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.vgcEmpleados.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vgcEmpleados.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.vgcEmpleados.Appearance.HorzLine.Options.UseBackColor = True
        Me.vgcEmpleados.Appearance.RecordValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.vgcEmpleados.Appearance.RecordValue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.vgcEmpleados.Appearance.RecordValue.ForeColor = System.Drawing.Color.Black
        Me.vgcEmpleados.Appearance.RecordValue.Options.UseBackColor = True
        Me.vgcEmpleados.Appearance.RecordValue.Options.UseBorderColor = True
        Me.vgcEmpleados.Appearance.RecordValue.Options.UseForeColor = True
        Me.vgcEmpleados.Appearance.RowHeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.vgcEmpleados.Appearance.RowHeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.vgcEmpleados.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.vgcEmpleados.Appearance.RowHeaderPanel.Options.UseBackColor = True
        Me.vgcEmpleados.Appearance.RowHeaderPanel.Options.UseBorderColor = True
        Me.vgcEmpleados.Appearance.RowHeaderPanel.Options.UseForeColor = True
        Me.vgcEmpleados.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.vgcEmpleados.Appearance.VertLine.Options.UseBackColor = True
        Me.vgcEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vgcEmpleados.ImageList = Me.ImageCollection1
        Me.vgcEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.vgcEmpleados.Name = "vgcEmpleados"
        Me.vgcEmpleados.OptionsBehavior.Editable = False
        Me.vgcEmpleados.RecordWidth = 250
        Me.vgcEmpleados.RowHeaderWidth = 150
        Me.vgcEmpleados.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.category, Me.category1, Me.Acceso})
        Me.vgcEmpleados.Size = New System.Drawing.Size(783, 219)
        Me.vgcEmpleados.TabIndex = 20
        Me.vgcEmpleados.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "S03.png")
        Me.ImageCollection1.Images.SetKeyName(1, "S12.png")
        Me.ImageCollection1.Images.SetKeyName(2, "S30.png")
        Me.ImageCollection1.Images.SetKeyName(3, "S35.png")
        '
        'category
        '
        Me.category.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowcodi_empl, Me.rownomb_empl, Me.rowid_carg, Me.rownudo_empl})
        Me.category.Name = "category"
        Me.category.Properties.Caption = "Empleados"
        Me.category.Properties.ImageIndex = 0
        '
        'rowcodi_empl
        '
        Me.rowcodi_empl.Height = 17
        Me.rowcodi_empl.Name = "rowcodi_empl"
        Me.rowcodi_empl.Properties.Caption = "Codigo"
        Me.rowcodi_empl.Properties.FieldName = "codi_empl"
        '
        'rownomb_empl
        '
        Me.rownomb_empl.Name = "rownomb_empl"
        Me.rownomb_empl.Properties.Caption = "Nombre"
        Me.rownomb_empl.Properties.FieldName = "nomb_empl"
        '
        'rowid_carg
        '
        Me.rowid_carg.Name = "rowid_carg"
        Me.rowid_carg.Properties.Caption = "Cargo"
        Me.rowid_carg.Properties.FieldName = "id_carg"
        '
        'rownudo_empl
        '
        Me.rownudo_empl.Name = "rownudo_empl"
        Me.rownudo_empl.Properties.Caption = "Documento"
        Me.rownudo_empl.Properties.FieldName = "nudo_empl"
        '
        'category1
        '
        Me.category1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowdire_empl, Me.rowtele_empl})
        Me.category1.Height = 16
        Me.category1.Name = "category1"
        Me.category1.Properties.Caption = "Datos de ubicación"
        Me.category1.Properties.ImageIndex = 1
        '
        'rowdire_empl
        '
        Me.rowdire_empl.Name = "rowdire_empl"
        Me.rowdire_empl.Properties.Caption = "Direccion"
        Me.rowdire_empl.Properties.FieldName = "dire_empl"
        '
        'rowtele_empl
        '
        Me.rowtele_empl.Name = "rowtele_empl"
        Me.rowtele_empl.Properties.Caption = "Telefono"
        Me.rowtele_empl.Properties.FieldName = "tele_empl"
        '
        'Acceso
        '
        Me.Acceso.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowusua_empl, Me.rowclav_empl, Me.rowesad_empl})
        Me.Acceso.Name = "Acceso"
        Me.Acceso.Properties.Caption = "Acceso"
        Me.Acceso.Properties.ImageIndex = 3
        '
        'rowusua_empl
        '
        Me.rowusua_empl.Name = "rowusua_empl"
        Me.rowusua_empl.Properties.Caption = "Usuario"
        Me.rowusua_empl.Properties.FieldName = "usua_empl"
        '
        'rowclav_empl
        '
        Me.rowclav_empl.Name = "rowclav_empl"
        Me.rowclav_empl.Properties.Caption = "Clave"
        Me.rowclav_empl.Properties.FieldName = "clav_empl"
        '
        'rowesad_empl
        '
        Me.rowesad_empl.Name = "rowesad_empl"
        Me.rowesad_empl.Properties.Caption = "Estado"
        Me.rowesad_empl.Properties.FieldName = "esad_empl"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Image = Global.Facturacion.My.Resources.Resources.S20
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(783, 219)
        Me.XtraTabPage2.Text = "Notas"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(215, 125)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Nro. Documento:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(215, 96)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Nombre:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(215, 156)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Cargo:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(215, 66)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "ID Empleado:"
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
        'frm_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 580)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frm_empleado"
        Me.Text = "Registrar Empleado"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.chkAdmin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConfirmar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcEmpleados.ResumeLayout(False)
        Me.tpgDireccion.ResumeLayout(False)
        CType(Me.vgcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cmbCargo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumDoc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents xtcEmpleados As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpgDireccion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConfirmar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents ToolTip As DevExpress.Utils.ToolTipController
    Friend WithEvents chkAdmin As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents vgcEmpleados As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents category As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowcodi_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownomb_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowid_carg As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownudo_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents category1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowdire_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowtele_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents btnPermisos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Acceso As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowusua_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowclav_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowesad_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
End Class

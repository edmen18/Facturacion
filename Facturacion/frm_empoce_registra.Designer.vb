<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_empoce_registra
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
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbCuenta = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpHasta = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDesde = New DevExpress.XtraEditors.DateEdit()
        Me.dgvVenta = New DevExpress.XtraGrid.GridControl()
        Me.gvVenta = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgEmpoce = New DevExpress.XtraEditors.GroupControl()
        Me.gcEmpoce = New DevExpress.XtraGrid.GridControl()
        Me.gvEmpoce = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.DxError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.ToolTip = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEmpoce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dgEmpoce.SuspendLayout()
        CType(Me.gcEmpoce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEmpoce, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupControl1.CaptionImage = Global.Facturacion.My.Resources.Resources._03
        Me.GroupControl1.Controls.Add(Me.dtpFecha)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.cmbCuenta)
        Me.GroupControl1.Controls.Add(Me.txtCodigo)
        Me.GroupControl1.Controls.Add(Me.txtMonto)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(917, 442)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos del empoce"
        '
        'dtpFecha
        '
        Me.dtpFecha.EditValue = Nothing
        Me.dtpFecha.Location = New System.Drawing.Point(167, 121)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFecha.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.dtpFecha.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.dtpFecha.Size = New System.Drawing.Size(148, 20)
        Me.dtpFecha.TabIndex = 22
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(119, 124)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "Fecha:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(119, 148)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl5.TabIndex = 20
        Me.LabelControl5.Text = "Monto:"
        '
        'cmbCuenta
        '
        Me.cmbCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCuenta.EditValue = ""
        Me.cmbCuenta.Enabled = False
        Me.cmbCuenta.Location = New System.Drawing.Point(167, 95)
        Me.cmbCuenta.Name = "cmbCuenta"
        Me.cmbCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCuenta.Properties.NullText = ""
        Me.cmbCuenta.Size = New System.Drawing.Size(743, 20)
        Me.cmbCuenta.TabIndex = 19
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(167, 69)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Mask.EditMask = "d8"
        Me.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCodigo.Properties.MaxLength = 8
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 18
        '
        'txtMonto
        '
        Me.txtMonto.EditValue = ""
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(167, 147)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMonto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMonto.Properties.EditFormat.FormatString = "0.00"
        Me.txtMonto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Size = New System.Drawing.Size(148, 20)
        Me.txtMonto.TabIndex = 21
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(66, 100)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Cuenta Corriente:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(83, 76)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "Nro. Papeleta:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionImage = Global.Facturacion.My.Resources.Resources.S06
        Me.GroupControl2.Controls.Add(Me.btnConsultar)
        Me.GroupControl2.Controls.Add(Me.dtpHasta)
        Me.GroupControl2.Controls.Add(Me.dtpDesde)
        Me.GroupControl2.Controls.Add(Me.dgvVenta)
        Me.GroupControl2.Location = New System.Drawing.Point(15, 189)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(440, 249)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Seleccione ingresos"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(367, 29)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(60, 23)
        Me.btnConsultar.TabIndex = 16
        Me.btnConsultar.Text = "Consultar"
        '
        'dtpHasta
        '
        Me.dtpHasta.EditValue = Nothing
        Me.dtpHasta.Location = New System.Drawing.Point(261, 32)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpHasta.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.dtpHasta.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.dtpHasta.Size = New System.Drawing.Size(100, 20)
        Me.dtpHasta.TabIndex = 15
        '
        'dtpDesde
        '
        Me.dtpDesde.EditValue = Nothing
        Me.dtpDesde.Location = New System.Drawing.Point(155, 32)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDesde.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.dtpDesde.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.dtpDesde.Size = New System.Drawing.Size(100, 20)
        Me.dtpDesde.TabIndex = 15
        '
        'dgvVenta
        '
        Me.dgvVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVenta.Location = New System.Drawing.Point(2, 24)
        Me.dgvVenta.MainView = Me.gvVenta
        Me.dgvVenta.Name = "dgvVenta"
        Me.dgvVenta.Size = New System.Drawing.Size(436, 223)
        Me.dgvVenta.TabIndex = 0
        Me.dgvVenta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVenta})
        '
        'gvVenta
        '
        Me.gvVenta.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvVenta.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvVenta.Appearance.FocusedRow.BackColor = System.Drawing.Color.Orange
        Me.gvVenta.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvVenta.GridControl = Me.dgvVenta
        Me.gvVenta.GroupPanelText = "Seleccione las fechas a filtrar"
        Me.gvVenta.Name = "gvVenta"
        Me.gvVenta.OptionsBehavior.Editable = False
        Me.gvVenta.OptionsView.ShowAutoFilterRow = True
        '
        'dgEmpoce
        '
        Me.dgEmpoce.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEmpoce.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgEmpoce.AppearanceCaption.Options.UseFont = True
        Me.dgEmpoce.CaptionImage = Global.Facturacion.My.Resources.Resources.S52
        Me.dgEmpoce.Controls.Add(Me.gcEmpoce)
        Me.dgEmpoce.Location = New System.Drawing.Point(516, 189)
        Me.dgEmpoce.Name = "dgEmpoce"
        Me.dgEmpoce.Size = New System.Drawing.Size(409, 247)
        Me.dgEmpoce.TabIndex = 1
        Me.dgEmpoce.Text = "Recibos de empoce"
        '
        'gcEmpoce
        '
        Me.gcEmpoce.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcEmpoce.Location = New System.Drawing.Point(2, 24)
        Me.gcEmpoce.MainView = Me.gvEmpoce
        Me.gcEmpoce.Name = "gcEmpoce"
        Me.gcEmpoce.Size = New System.Drawing.Size(405, 221)
        Me.gcEmpoce.TabIndex = 0
        Me.gcEmpoce.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEmpoce})
        '
        'gvEmpoce
        '
        Me.gvEmpoce.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvEmpoce.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.FocusedRow.BackColor = System.Drawing.Color.Orange
        Me.gvEmpoce.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvEmpoce.GridControl = Me.gcEmpoce
        Me.gvEmpoce.Name = "gvEmpoce"
        Me.gvEmpoce.OptionsBehavior.Editable = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Image = Global.Facturacion.My.Resources.Resources.M_09
        Me.btnAgregar.Location = New System.Drawing.Point(463, 298)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(43, 45)
        Me.btnAgregar.TabIndex = 2
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.Facturacion.My.Resources.Resources.M_10
        Me.SimpleButton2.Location = New System.Drawing.Point(463, 349)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(43, 45)
        Me.SimpleButton2.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(855, 470)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(774, 470)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(693, 470)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(612, 470)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Location = New System.Drawing.Point(531, 470)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        '
        'DxError
        '
        Me.DxError.ContainerControl = Me
        '
        'frm_empoce_registra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 505)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgEmpoce)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frm_empoce_registra"
        Me.Text = "Registro de empoce"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEmpoce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dgEmpoce.ResumeLayout(False)
        CType(Me.gcEmpoce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEmpoce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Private WithEvents cmbCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgEmpoce As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dgvVenta As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVenta As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtpHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolTip As DevExpress.Utils.ToolTipController
    Friend WithEvents DxError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcEmpoce As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEmpoce As DevExpress.XtraGrid.Views.Grid.GridView
End Class

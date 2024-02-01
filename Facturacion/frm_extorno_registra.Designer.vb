<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_extorno_registra
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
        Me.cmbMotivo = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtVenta = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnRegistrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.DxError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.ToolTip = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmbMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.CaptionImage = Global.Facturacion.My.Resources.Resources.S36
        Me.GroupControl1.Controls.Add(Me.cmbMotivo)
        Me.GroupControl1.Controls.Add(Me.dtpFecha)
        Me.GroupControl1.Controls.Add(Me.txtVenta)
        Me.GroupControl1.Controls.Add(Me.txtEmpleado)
        Me.GroupControl1.Controls.Add(Me.txtMonto)
        Me.GroupControl1.Controls.Add(Me.txtCodigo)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(361, 220)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos del extorno"
        '
        'cmbMotivo
        '
        Me.cmbMotivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMotivo.EditValue = ""
        Me.cmbMotivo.Location = New System.Drawing.Point(131, 146)
        Me.cmbMotivo.Name = "cmbMotivo"
        Me.cmbMotivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMotivo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_moex", 10, "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_moex", 30, "Motivo")})
        Me.cmbMotivo.Properties.NullText = ""
        Me.cmbMotivo.Size = New System.Drawing.Size(190, 20)
        Me.cmbMotivo.TabIndex = 12
        '
        'dtpFecha
        '
        Me.dtpFecha.EditValue = Nothing
        Me.dtpFecha.Location = New System.Drawing.Point(131, 68)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFecha.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.dtpFecha.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.dtpFecha.Size = New System.Drawing.Size(190, 20)
        Me.dtpFecha.TabIndex = 11
        '
        'txtVenta
        '
        Me.txtVenta.Enabled = False
        Me.txtVenta.Location = New System.Drawing.Point(131, 94)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(190, 20)
        Me.txtVenta.TabIndex = 7
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Location = New System.Drawing.Point(131, 172)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(190, 20)
        Me.txtEmpleado.TabIndex = 9
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(131, 123)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(190, 20)
        Me.txtMonto.TabIndex = 10
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(131, 41)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(190, 20)
        Me.txtCodigo.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(40, 174)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Empleado:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(40, 149)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Motivo extorno:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(40, 98)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Código venta:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(40, 48)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Código:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(40, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Fecha extorno:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(40, 126)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Monto:"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.Location = New System.Drawing.Point(219, 246)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 1
        Me.btnRegistrar.Text = "Registrar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(300, 246)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        '
        'DxError
        '
        Me.DxError.ContainerControl = Me
        '
        'frm_extorno_registra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 283)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_extorno_registra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Extorno"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmbMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRegistrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbMotivo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToolTip As DevExpress.Utils.ToolTipController
    Friend WithEvents DxError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class

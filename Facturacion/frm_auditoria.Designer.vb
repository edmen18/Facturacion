<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_auditoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_auditoria))
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRegistrar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cmbEstado = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.imcEstado = New DevExpress.Utils.ImageCollection(Me.components)
        Me.meObservacion = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVenta = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaAuditoria = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DxError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.ToolTip = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmbEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imcEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meObservacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaAuditoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(367, 336)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.Location = New System.Drawing.Point(286, 336)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 3
        Me.btnRegistrar.Text = "Registrar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.CaptionImage = Global.Facturacion.My.Resources.Resources.S37
        Me.GroupControl1.Controls.Add(Me.cmbEstado)
        Me.GroupControl1.Controls.Add(Me.meObservacion)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtVenta)
        Me.GroupControl1.Controls.Add(Me.txtEmpleado)
        Me.GroupControl1.Controls.Add(Me.txtMonto)
        Me.GroupControl1.Controls.Add(Me.txtFechaAuditoria)
        Me.GroupControl1.Controls.Add(Me.txtCodigo)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 11)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(429, 314)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Datos de auditoria"
        '
        'cmbEstado
        '
        Me.cmbEstado.Location = New System.Drawing.Point(132, 147)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbEstado.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("CORRECTO", "0", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("INCONSISTENTE", "1", 0)})
        Me.cmbEstado.Properties.LargeImages = Me.imcEstado
        Me.cmbEstado.Size = New System.Drawing.Size(282, 20)
        Me.cmbEstado.TabIndex = 16
        '
        'imcEstado
        '
        Me.imcEstado.ImageStream = CType(resources.GetObject("imcEstado.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imcEstado.Images.SetKeyName(0, "96.png")
        Me.imcEstado.Images.SetKeyName(1, "97.png")
        Me.imcEstado.Images.SetKeyName(2, "93.png")
        '
        'meObservacion
        '
        Me.meObservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.meObservacion.Location = New System.Drawing.Point(132, 172)
        Me.meObservacion.Name = "meObservacion"
        Me.meObservacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.meObservacion.Size = New System.Drawing.Size(282, 96)
        Me.meObservacion.TabIndex = 14
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(40, 178)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "Observación:"
        '
        'txtVenta
        '
        Me.txtVenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVenta.Enabled = False
        Me.txtVenta.Location = New System.Drawing.Point(132, 93)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Properties.ReadOnly = True
        Me.txtVenta.Size = New System.Drawing.Size(282, 20)
        Me.txtVenta.TabIndex = 7
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Location = New System.Drawing.Point(132, 274)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Properties.ReadOnly = True
        Me.txtEmpleado.Size = New System.Drawing.Size(282, 20)
        Me.txtEmpleado.TabIndex = 9
        '
        'txtMonto
        '
        Me.txtMonto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(132, 119)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Properties.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(282, 20)
        Me.txtMonto.TabIndex = 10
        '
        'txtFechaAuditoria
        '
        Me.txtFechaAuditoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFechaAuditoria.Enabled = False
        Me.txtFechaAuditoria.Location = New System.Drawing.Point(132, 67)
        Me.txtFechaAuditoria.Name = "txtFechaAuditoria"
        Me.txtFechaAuditoria.Properties.Mask.EditMask = "d"
        Me.txtFechaAuditoria.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.txtFechaAuditoria.Properties.ReadOnly = True
        Me.txtFechaAuditoria.Size = New System.Drawing.Size(282, 20)
        Me.txtFechaAuditoria.TabIndex = 10
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(132, 41)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(282, 20)
        Me.txtCodigo.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(40, 277)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Empleado:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(40, 152)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Estado:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(40, 100)
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
        Me.LabelControl2.Location = New System.Drawing.Point(40, 74)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Fecha auditoria:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(40, 126)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Monto:"
        '
        'DxError
        '
        Me.DxError.ContainerControl = Me
        '
        'frm_auditoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 366)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_auditoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar observación"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmbEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imcEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meObservacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaAuditoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRegistrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents meObservacion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbEstado As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents imcEstado As DevExpress.Utils.ImageCollection
    Friend WithEvents txtFechaAuditoria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents ToolTip As DevExpress.Utils.ToolTipController
End Class

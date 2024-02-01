<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes_consulta
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
        Me.dgvCliente = New DevExpress.XtraGrid.GridControl()
        Me.gvClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDato = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCliente
        '
        Me.dgvCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCliente.Location = New System.Drawing.Point(9, 50)
        Me.dgvCliente.MainView = Me.gvClientes
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.Size = New System.Drawing.Size(747, 239)
        Me.dgvCliente.TabIndex = 20
        Me.dgvCliente.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvClientes})
        '
        'gvClientes
        '
        Me.gvClientes.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvClientes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvClientes.Appearance.FocusedRow.BackColor = System.Drawing.Color.Orange
        Me.gvClientes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvClientes.GridControl = Me.dgvCliente
        Me.gvClientes.Name = "gvClientes"
        Me.gvClientes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvClientes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvClientes.OptionsBehavior.Editable = False
        Me.gvClientes.OptionsBehavior.ReadOnly = True
        Me.gvClientes.OptionsView.ShowGroupPanel = False
        '
        'txtDato
        '
        Me.txtDato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDato.Location = New System.Drawing.Point(9, 22)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDato.Size = New System.Drawing.Size(747, 20)
        Me.txtDato.TabIndex = 21
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl1.TabIndex = 25
        Me.LabelControl1.Text = "Digite nombre a consultar:"
        '
        'frm_clientes_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 304)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.dgvCliente)
        Me.Name = "frm_clientes_consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Cliente"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCliente As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDato As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class

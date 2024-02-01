<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_producto_consulta
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
        Me.txtDato = New DevExpress.XtraEditors.TextEdit()
        Me.dgvProducto = New DevExpress.XtraGrid.GridControl()
        Me.gvProducto = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtDato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDato
        '
        Me.txtDato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDato.Location = New System.Drawing.Point(12, 27)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDato.Size = New System.Drawing.Size(751, 20)
        Me.txtDato.TabIndex = 23
        '
        'dgvProducto
        '
        Me.dgvProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducto.Location = New System.Drawing.Point(12, 55)
        Me.dgvProducto.MainView = Me.gvProducto
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.Size = New System.Drawing.Size(751, 231)
        Me.dgvProducto.TabIndex = 22
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
        Me.gvProducto.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvProducto.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvProducto.OptionsBehavior.Editable = False
        Me.gvProducto.OptionsBehavior.ReadOnly = True
        Me.gvProducto.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl1.TabIndex = 24
        Me.LabelControl1.Text = "Digite nombre a consultar:"
        '
        'frm_producto_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 298)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.dgvProducto)
        Me.Name = "frm_producto_consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Producto"
        CType(Me.txtDato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDato As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dgvProducto As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProducto As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class

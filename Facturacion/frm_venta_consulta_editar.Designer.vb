<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_venta_consulta_editar
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
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnISeleccionar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvDetalle = New DevExpress.XtraGrid.GridControl()
        Me.gvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgvVenta = New DevExpress.XtraGrid.GridControl()
        Me.cmMenuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmExportarExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmExportarPdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.gvVenta = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmMenuGrid.SuspendLayout()
        CType(Me.gvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionImage = Global.Facturacion.My.Resources.Resources._126
        Me.GroupControl2.Controls.Add(Me.btnISeleccionar)
        Me.GroupControl2.Controls.Add(Me.dgvDetalle)
        Me.GroupControl2.Controls.Add(Me.dgvVenta)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(871, 543)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Consultar Venta / Servicios"
        '
        'btnISeleccionar
        '
        Me.btnISeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnISeleccionar.Image = Global.Facturacion.My.Resources.Resources._28
        Me.btnISeleccionar.Location = New System.Drawing.Point(736, 3)
        Me.btnISeleccionar.Name = "btnISeleccionar"
        Me.btnISeleccionar.Size = New System.Drawing.Size(130, 33)
        Me.btnISeleccionar.TabIndex = 24
        Me.btnISeleccionar.Text = "Editar"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.Location = New System.Drawing.Point(5, 370)
        Me.dgvDetalle.MainView = Me.gvDetalle
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(861, 162)
        Me.dgvDetalle.TabIndex = 23
        Me.dgvDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalle})
        '
        'gvDetalle
        '
        Me.gvDetalle.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvDetalle.GridControl = Me.dgvDetalle
        Me.gvDetalle.Name = "gvDetalle"
        Me.gvDetalle.OptionsBehavior.Editable = False
        Me.gvDetalle.OptionsView.ShowGroupPanel = False
        '
        'dgvVenta
        '
        Me.dgvVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVenta.ContextMenuStrip = Me.cmMenuGrid
        Me.dgvVenta.Location = New System.Drawing.Point(5, 44)
        Me.dgvVenta.MainView = Me.gvVenta
        Me.dgvVenta.Name = "dgvVenta"
        Me.dgvVenta.Size = New System.Drawing.Size(861, 306)
        Me.dgvVenta.TabIndex = 22
        Me.dgvVenta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVenta})
        '
        'cmMenuGrid
        '
        Me.cmMenuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmExportarExcel, Me.cmExportarPdf, Me.cmImprimir})
        Me.cmMenuGrid.Name = "cmMenuGrid"
        Me.cmMenuGrid.Size = New System.Drawing.Size(156, 70)
        '
        'cmExportarExcel
        '
        Me.cmExportarExcel.Name = "cmExportarExcel"
        Me.cmExportarExcel.Size = New System.Drawing.Size(155, 22)
        Me.cmExportarExcel.Text = "Exportar a Excel"
        '
        'cmExportarPdf
        '
        Me.cmExportarPdf.Name = "cmExportarPdf"
        Me.cmExportarPdf.Size = New System.Drawing.Size(155, 22)
        Me.cmExportarPdf.Text = "Exportar a Pdf"
        '
        'cmImprimir
        '
        Me.cmImprimir.Name = "cmImprimir"
        Me.cmImprimir.Size = New System.Drawing.Size(155, 22)
        Me.cmImprimir.Text = "Imprimir "
        '
        'gvVenta
        '
        Me.gvVenta.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvVenta.GridControl = Me.dgvVenta
        Me.gvVenta.Name = "gvVenta"
        Me.gvVenta.OptionsBehavior.Editable = False
        Me.gvVenta.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag
        Me.gvVenta.OptionsView.ShowAutoFilterRow = True
        Me.gvVenta.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvVenta.OptionsView.ShowFooter = True
        '
        'frm_venta_consulta_editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 567)
        Me.Controls.Add(Me.GroupControl2)
        Me.Name = "frm_venta_consulta_editar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Ingresos"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmMenuGrid.ResumeLayout(False)
        CType(Me.gvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvVenta As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVenta As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnISeleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmMenuGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmExportarExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfdRuta As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmExportarPdf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmImprimir As System.Windows.Forms.ToolStripMenuItem
End Class

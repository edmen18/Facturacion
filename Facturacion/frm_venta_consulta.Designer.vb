<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_venta_consulta
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
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvVenta = New DevExpress.XtraGrid.GridControl()
        Me.cmMenuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmExportarExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmExportarPdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.gvVenta = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gc_codi_vent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_fech_vent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_desc_dove = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_nudo_vent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_nomb_clie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_nudo_clie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_dire_clie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_nomb_prod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_desc_tipr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_nota_vent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.gc_esta_vent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_tiempo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_impo_veda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_toiv_veda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_tota_veda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmMenuGrid.SuspendLayout()
        CType(Me.gvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionImage = Global.Facturacion.My.Resources.Resources._47
        Me.GroupControl2.Controls.Add(Me.btnImprimir)
        Me.GroupControl2.Controls.Add(Me.dgvVenta)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(871, 543)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Consultar Venta / Servicios"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.Facturacion.My.Resources.Resources._98
        Me.btnImprimir.Location = New System.Drawing.Point(736, 3)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(130, 33)
        Me.btnImprimir.TabIndex = 24
        Me.btnImprimir.Text = "Imprimir"
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
        Me.dgvVenta.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.dgvVenta.Size = New System.Drawing.Size(861, 494)
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
        Me.gvVenta.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvVenta.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvVenta.Appearance.FocusedRow.BackColor = System.Drawing.Color.Orange
        Me.gvVenta.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvVenta.Appearance.FooterPanel.BackColor = System.Drawing.Color.Cornsilk
        Me.gvVenta.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvVenta.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvVenta.Appearance.FooterPanel.Options.UseFont = True
        Me.gvVenta.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gc_codi_vent, Me.gc_fech_vent, Me.gc_desc_dove, Me.gc_nudo_vent, Me.gc_nomb_clie, Me.gc_nudo_clie, Me.gc_dire_clie, Me.gc_nomb_prod, Me.gc_desc_tipr, Me.gc_nota_vent, Me.gc_esta_vent, Me.gc_tiempo, Me.gc_impo_veda, Me.gc_toiv_veda, Me.gc_tota_veda})
        Me.gvVenta.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvVenta.GridControl = Me.dgvVenta
        Me.gvVenta.Name = "gvVenta"
        Me.gvVenta.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvVenta.OptionsBehavior.Editable = False
        Me.gvVenta.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag
        Me.gvVenta.OptionsView.ShowAutoFilterRow = True
        Me.gvVenta.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvVenta.OptionsView.ShowFooter = True
        '
        'gc_codi_vent
        '
        Me.gc_codi_vent.Caption = "Código"
        Me.gc_codi_vent.FieldName = "codi_vent"
        Me.gc_codi_vent.Name = "gc_codi_vent"
        '
        'gc_fech_vent
        '
        Me.gc_fech_vent.Caption = "Fecha venta"
        Me.gc_fech_vent.FieldName = "fech_vent"
        Me.gc_fech_vent.Image = Global.Facturacion.My.Resources.Resources.S05
        Me.gc_fech_vent.Name = "gc_fech_vent"
        Me.gc_fech_vent.Visible = True
        Me.gc_fech_vent.VisibleIndex = 0
        Me.gc_fech_vent.Width = 57
        '
        'gc_desc_dove
        '
        Me.gc_desc_dove.Caption = "Documento de venta"
        Me.gc_desc_dove.FieldName = "desc_dove"
        Me.gc_desc_dove.Image = Global.Facturacion.My.Resources.Resources.S29
        Me.gc_desc_dove.Name = "gc_desc_dove"
        Me.gc_desc_dove.Visible = True
        Me.gc_desc_dove.VisibleIndex = 1
        Me.gc_desc_dove.Width = 77
        '
        'gc_nudo_vent
        '
        Me.gc_nudo_vent.Caption = "Número documento"
        Me.gc_nudo_vent.FieldName = "nudo_vent"
        Me.gc_nudo_vent.Image = Global.Facturacion.My.Resources.Resources.S10
        Me.gc_nudo_vent.Name = "gc_nudo_vent"
        Me.gc_nudo_vent.Visible = True
        Me.gc_nudo_vent.VisibleIndex = 2
        Me.gc_nudo_vent.Width = 51
        '
        'gc_nomb_clie
        '
        Me.gc_nomb_clie.Caption = "Cliente / Razón social"
        Me.gc_nomb_clie.FieldName = "nomb_clie"
        Me.gc_nomb_clie.Image = Global.Facturacion.My.Resources.Resources.S03
        Me.gc_nomb_clie.Name = "gc_nomb_clie"
        Me.gc_nomb_clie.Visible = True
        Me.gc_nomb_clie.VisibleIndex = 3
        Me.gc_nomb_clie.Width = 124
        '
        'gc_nudo_clie
        '
        Me.gc_nudo_clie.Caption = "Dni / Ruc"
        Me.gc_nudo_clie.FieldName = "nudo_clie"
        Me.gc_nudo_clie.Image = Global.Facturacion.My.Resources.Resources.S47
        Me.gc_nudo_clie.Name = "gc_nudo_clie"
        Me.gc_nudo_clie.Width = 50
        '
        'gc_dire_clie
        '
        Me.gc_dire_clie.Caption = "Dirección del cliente"
        Me.gc_dire_clie.FieldName = "dire_clie"
        Me.gc_dire_clie.Image = Global.Facturacion.My.Resources.Resources.S08
        Me.gc_dire_clie.Name = "gc_dire_clie"
        Me.gc_dire_clie.Width = 120
        '
        'gc_nomb_prod
        '
        Me.gc_nomb_prod.Caption = "Producto o servicio"
        Me.gc_nomb_prod.FieldName = "nomb_prod"
        Me.gc_nomb_prod.Image = Global.Facturacion.My.Resources.Resources.S17
        Me.gc_nomb_prod.Name = "gc_nomb_prod"
        Me.gc_nomb_prod.Visible = True
        Me.gc_nomb_prod.VisibleIndex = 4
        Me.gc_nomb_prod.Width = 120
        '
        'gc_desc_tipr
        '
        Me.gc_desc_tipr.Caption = "Categoría"
        Me.gc_desc_tipr.FieldName = "desc_tipr"
        Me.gc_desc_tipr.Image = Global.Facturacion.My.Resources.Resources.S51
        Me.gc_desc_tipr.Name = "gc_desc_tipr"
        Me.gc_desc_tipr.Visible = True
        Me.gc_desc_tipr.VisibleIndex = 5
        Me.gc_desc_tipr.Width = 115
        '
        'gc_nota_vent
        '
        Me.gc_nota_vent.Caption = "Nota / Observación"
        Me.gc_nota_vent.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.gc_nota_vent.FieldName = "nota_vent"
        Me.gc_nota_vent.Image = Global.Facturacion.My.Resources.Resources.S20
        Me.gc_nota_vent.Name = "gc_nota_vent"
        Me.gc_nota_vent.Visible = True
        Me.gc_nota_vent.VisibleIndex = 6
        Me.gc_nota_vent.Width = 112
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'gc_esta_vent
        '
        Me.gc_esta_vent.Caption = "Estado"
        Me.gc_esta_vent.FieldName = "esta_vent"
        Me.gc_esta_vent.Name = "gc_esta_vent"
        '
        'gc_tiempo
        '
        Me.gc_tiempo.Caption = "Cantidad"
        Me.gc_tiempo.FieldName = "tiempo"
        Me.gc_tiempo.Image = Global.Facturacion.My.Resources.Resources.S40
        Me.gc_tiempo.Name = "gc_tiempo"
        Me.gc_tiempo.Visible = True
        Me.gc_tiempo.VisibleIndex = 7
        Me.gc_tiempo.Width = 64
        '
        'gc_impo_veda
        '
        Me.gc_impo_veda.AppearanceHeader.Options.UseTextOptions = True
        Me.gc_impo_veda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gc_impo_veda.Caption = "Subtotal"
        Me.gc_impo_veda.FieldName = "impo_veda"
        Me.gc_impo_veda.Image = Global.Facturacion.My.Resources.Resources.S31
        Me.gc_impo_veda.Name = "gc_impo_veda"
        Me.gc_impo_veda.Visible = True
        Me.gc_impo_veda.VisibleIndex = 8
        Me.gc_impo_veda.Width = 64
        '
        'gc_toiv_veda
        '
        Me.gc_toiv_veda.Caption = "Igv"
        Me.gc_toiv_veda.FieldName = "toiv_veda"
        Me.gc_toiv_veda.Name = "gc_toiv_veda"
        '
        'gc_tota_veda
        '
        Me.gc_tota_veda.AppearanceCell.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gc_tota_veda.AppearanceCell.Options.UseBackColor = True
        Me.gc_tota_veda.AppearanceHeader.Options.UseTextOptions = True
        Me.gc_tota_veda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gc_tota_veda.Caption = "Total"
        Me.gc_tota_veda.DisplayFormat.FormatString = "c2"
        Me.gc_tota_veda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_tota_veda.FieldName = "tota_veda"
        Me.gc_tota_veda.Image = Global.Facturacion.My.Resources.Resources.S46
        Me.gc_tota_veda.Name = "gc_tota_veda"
        Me.gc_tota_veda.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gc_tota_veda.Visible = True
        Me.gc_tota_veda.VisibleIndex = 9
        Me.gc_tota_veda.Width = 56
        '
        'frm_venta_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 567)
        Me.Controls.Add(Me.GroupControl2)
        Me.Name = "frm_venta_consulta"
        Me.Text = "Consulta general"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmMenuGrid.ResumeLayout(False)
        CType(Me.gvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvVenta As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVenta As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmMenuGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmExportarExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfdRuta As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmExportarPdf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gc_fech_vent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_desc_dove As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nudo_vent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nomb_clie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nudo_clie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_dire_clie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nomb_prod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_desc_tipr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nota_vent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_esta_vent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_tiempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_impo_veda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_tota_veda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_toiv_veda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents gc_codi_vent As DevExpress.XtraGrid.Columns.GridColumn
End Class

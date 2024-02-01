<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_venta_anulada
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.gvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gc_codi_vent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_item_veda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_nomb_prod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_desc_unid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_capr_veda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_vaun_veda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_tota_veda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgvVenta = New DevExpress.XtraGrid.GridControl()
        Me.cmMenuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmExportarExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmExportarPdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.gvVenta = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gc_fech_vent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_nomb_clie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_nudo_clie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_dire_clie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_desc_dove = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_nudo_vent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_desc_fopa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_subt_vent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_toiv_vent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_tota_vent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_esta_vent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmMenuGrid.SuspendLayout()
        CType(Me.gvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvDetalle
        '
        Me.gvDetalle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.gvDetalle.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.gvDetalle.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.gvDetalle.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvDetalle.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvDetalle.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.gvDetalle.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.gvDetalle.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.gvDetalle.Appearance.Empty.Options.UseBackColor = True
        Me.gvDetalle.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.gvDetalle.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.gvDetalle.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.gvDetalle.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.gvDetalle.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.gvDetalle.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.gvDetalle.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.gvDetalle.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.gvDetalle.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.gvDetalle.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvDetalle.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetalle.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.gvDetalle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.gvDetalle.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.gvDetalle.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.gvDetalle.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvDetalle.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.gvDetalle.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.gvDetalle.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvDetalle.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.gvDetalle.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.gvDetalle.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvDetalle.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.gvDetalle.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvDetalle.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.GroupRow.Options.UseFont = True
        Me.gvDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.gvDetalle.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.gvDetalle.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvDetalle.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.gvDetalle.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.gvDetalle.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvDetalle.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvDetalle.Appearance.OddRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.gvDetalle.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.gvDetalle.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.gvDetalle.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.gvDetalle.Appearance.Preview.Options.UseBackColor = True
        Me.gvDetalle.Appearance.Preview.Options.UseFont = True
        Me.gvDetalle.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvDetalle.Appearance.Row.Options.UseBackColor = True
        Me.gvDetalle.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.gvDetalle.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvDetalle.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.gvDetalle.Appearance.VertLine.Options.UseBackColor = True
        Me.gvDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gc_codi_vent, Me.gc_item_veda, Me.gc_nomb_prod, Me.gc_desc_unid, Me.gc_capr_veda, Me.gc_vaun_veda, Me.gc_tota_veda})
        Me.gvDetalle.GridControl = Me.dgvVenta
        Me.gvDetalle.Name = "gvDetalle"
        Me.gvDetalle.OptionsBehavior.Editable = False
        Me.gvDetalle.OptionsView.EnableAppearanceEvenRow = True
        Me.gvDetalle.OptionsView.EnableAppearanceOddRow = True
        Me.gvDetalle.OptionsView.ShowGroupPanel = False
        '
        'gc_codi_vent
        '
        Me.gc_codi_vent.Caption = "Venta"
        Me.gc_codi_vent.FieldName = "codi_vent"
        Me.gc_codi_vent.Name = "gc_codi_vent"
        '
        'gc_item_veda
        '
        Me.gc_item_veda.Caption = "Item"
        Me.gc_item_veda.FieldName = "item_veda"
        Me.gc_item_veda.Name = "gc_item_veda"
        Me.gc_item_veda.Visible = True
        Me.gc_item_veda.VisibleIndex = 0
        Me.gc_item_veda.Width = 50
        '
        'gc_nomb_prod
        '
        Me.gc_nomb_prod.Caption = "Producto / Servicio"
        Me.gc_nomb_prod.FieldName = "nomb_prod"
        Me.gc_nomb_prod.Name = "gc_nomb_prod"
        Me.gc_nomb_prod.Visible = True
        Me.gc_nomb_prod.VisibleIndex = 1
        Me.gc_nomb_prod.Width = 250
        '
        'gc_desc_unid
        '
        Me.gc_desc_unid.Caption = "Unidad"
        Me.gc_desc_unid.FieldName = "desc_unid"
        Me.gc_desc_unid.Name = "gc_desc_unid"
        Me.gc_desc_unid.Visible = True
        Me.gc_desc_unid.VisibleIndex = 2
        '
        'gc_capr_veda
        '
        Me.gc_capr_veda.Caption = "Cantidad"
        Me.gc_capr_veda.FieldName = "capr_veda"
        Me.gc_capr_veda.Name = "gc_capr_veda"
        Me.gc_capr_veda.Visible = True
        Me.gc_capr_veda.VisibleIndex = 3
        '
        'gc_vaun_veda
        '
        Me.gc_vaun_veda.Caption = "Valor"
        Me.gc_vaun_veda.FieldName = "vaun_veda"
        Me.gc_vaun_veda.Name = "gc_vaun_veda"
        Me.gc_vaun_veda.Visible = True
        Me.gc_vaun_veda.VisibleIndex = 4
        '
        'gc_tota_veda
        '
        Me.gc_tota_veda.Caption = "Total"
        Me.gc_tota_veda.FieldName = "tota_veda"
        Me.gc_tota_veda.Name = "gc_tota_veda"
        Me.gc_tota_veda.Visible = True
        Me.gc_tota_veda.VisibleIndex = 5
        '
        'dgvVenta
        '
        Me.dgvVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVenta.ContextMenuStrip = Me.cmMenuGrid
        GridLevelNode1.LevelTemplate = Me.gvDetalle
        GridLevelNode1.RelationName = "Detalle"
        Me.dgvVenta.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgvVenta.Location = New System.Drawing.Point(5, 44)
        Me.dgvVenta.MainView = Me.gvVenta
        Me.dgvVenta.Name = "dgvVenta"
        Me.dgvVenta.Size = New System.Drawing.Size(861, 494)
        Me.dgvVenta.TabIndex = 22
        Me.dgvVenta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVenta, Me.gvDetalle})
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
        Me.gvVenta.Appearance.FooterPanel.BackColor = System.Drawing.Color.Linen
        Me.gvVenta.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvVenta.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvVenta.Appearance.FooterPanel.Options.UseFont = True
        Me.gvVenta.Appearance.Row.Options.UseFont = True
        Me.gvVenta.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gc_fech_vent, Me.gc_Codigo, Me.gc_nomb_clie, Me.gc_nudo_clie, Me.gc_dire_clie, Me.gc_desc_dove, Me.gc_nudo_vent, Me.gc_desc_fopa, Me.gc_subt_vent, Me.gc_toiv_vent, Me.gc_tota_vent, Me.gc_esta_vent})
        Me.gvVenta.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvVenta.GridControl = Me.dgvVenta
        Me.gvVenta.Name = "gvVenta"
        Me.gvVenta.OptionsBehavior.Editable = False
        Me.gvVenta.OptionsPrint.ExpandAllDetails = True
        Me.gvVenta.OptionsPrint.PrintDetails = True
        Me.gvVenta.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag
        Me.gvVenta.OptionsView.ShowAutoFilterRow = True
        Me.gvVenta.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvVenta.OptionsView.ShowFooter = True
        '
        'gc_fech_vent
        '
        Me.gc_fech_vent.Caption = "Fecha venta"
        Me.gc_fech_vent.FieldName = "fech_vent"
        Me.gc_fech_vent.Image = Global.Facturacion.My.Resources.Resources.S05
        Me.gc_fech_vent.Name = "gc_fech_vent"
        Me.gc_fech_vent.Visible = True
        Me.gc_fech_vent.VisibleIndex = 0
        Me.gc_fech_vent.Width = 70
        '
        'gc_Codigo
        '
        Me.gc_Codigo.Caption = "Código"
        Me.gc_Codigo.FieldName = "codi_vent"
        Me.gc_Codigo.Name = "gc_Codigo"
        Me.gc_Codigo.Width = 93
        '
        'gc_nomb_clie
        '
        Me.gc_nomb_clie.Caption = "Nombre de cliente / Razón social"
        Me.gc_nomb_clie.FieldName = "nomb_clie"
        Me.gc_nomb_clie.Image = Global.Facturacion.My.Resources.Resources.S03
        Me.gc_nomb_clie.Name = "gc_nomb_clie"
        Me.gc_nomb_clie.Visible = True
        Me.gc_nomb_clie.VisibleIndex = 1
        Me.gc_nomb_clie.Width = 250
        '
        'gc_nudo_clie
        '
        Me.gc_nudo_clie.Caption = "Dni / Ruc"
        Me.gc_nudo_clie.FieldName = "nudo_clie"
        Me.gc_nudo_clie.Name = "gc_nudo_clie"
        '
        'gc_dire_clie
        '
        Me.gc_dire_clie.Caption = "Dirección"
        Me.gc_dire_clie.FieldName = "dire_clie"
        Me.gc_dire_clie.Name = "gc_dire_clie"
        '
        'gc_desc_dove
        '
        Me.gc_desc_dove.Caption = "Documento Venta"
        Me.gc_desc_dove.FieldName = "desc_dove"
        Me.gc_desc_dove.Image = Global.Facturacion.My.Resources.Resources.S11
        Me.gc_desc_dove.Name = "gc_desc_dove"
        Me.gc_desc_dove.Visible = True
        Me.gc_desc_dove.VisibleIndex = 2
        Me.gc_desc_dove.Width = 70
        '
        'gc_nudo_vent
        '
        Me.gc_nudo_vent.Caption = "Nro. Documento"
        Me.gc_nudo_vent.FieldName = "nudo_vent"
        Me.gc_nudo_vent.Image = Global.Facturacion.My.Resources.Resources.S10
        Me.gc_nudo_vent.Name = "gc_nudo_vent"
        Me.gc_nudo_vent.Visible = True
        Me.gc_nudo_vent.VisibleIndex = 3
        Me.gc_nudo_vent.Width = 70
        '
        'gc_desc_fopa
        '
        Me.gc_desc_fopa.Caption = "Forma Pago"
        Me.gc_desc_fopa.FieldName = "desc_fopa"
        Me.gc_desc_fopa.Image = Global.Facturacion.My.Resources.Resources.S06
        Me.gc_desc_fopa.Name = "gc_desc_fopa"
        Me.gc_desc_fopa.Visible = True
        Me.gc_desc_fopa.VisibleIndex = 4
        Me.gc_desc_fopa.Width = 70
        '
        'gc_subt_vent
        '
        Me.gc_subt_vent.AppearanceHeader.Options.UseTextOptions = True
        Me.gc_subt_vent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gc_subt_vent.Caption = "Subtotal"
        Me.gc_subt_vent.FieldName = "subt_vent"
        Me.gc_subt_vent.Image = Global.Facturacion.My.Resources.Resources.S18
        Me.gc_subt_vent.Name = "gc_subt_vent"
        Me.gc_subt_vent.Visible = True
        Me.gc_subt_vent.VisibleIndex = 5
        Me.gc_subt_vent.Width = 70
        '
        'gc_toiv_vent
        '
        Me.gc_toiv_vent.AppearanceHeader.Options.UseTextOptions = True
        Me.gc_toiv_vent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gc_toiv_vent.Caption = "Igv"
        Me.gc_toiv_vent.FieldName = "toiv_vent"
        Me.gc_toiv_vent.Image = Global.Facturacion.My.Resources.Resources.S50
        Me.gc_toiv_vent.Name = "gc_toiv_vent"
        Me.gc_toiv_vent.Visible = True
        Me.gc_toiv_vent.VisibleIndex = 6
        Me.gc_toiv_vent.Width = 70
        '
        'gc_tota_vent
        '
        Me.gc_tota_vent.AppearanceCell.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gc_tota_vent.AppearanceCell.Options.UseBackColor = True
        Me.gc_tota_vent.AppearanceHeader.Options.UseTextOptions = True
        Me.gc_tota_vent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gc_tota_vent.Caption = "Total"
        Me.gc_tota_vent.DisplayFormat.FormatString = "c2"
        Me.gc_tota_vent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_tota_vent.FieldName = "tota_vent"
        Me.gc_tota_vent.Image = Global.Facturacion.My.Resources.Resources.S46
        Me.gc_tota_vent.Name = "gc_tota_vent"
        Me.gc_tota_vent.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gc_tota_vent.Visible = True
        Me.gc_tota_vent.VisibleIndex = 7
        Me.gc_tota_vent.Width = 80
        '
        'gc_esta_vent
        '
        Me.gc_esta_vent.Caption = "Estado"
        Me.gc_esta_vent.FieldName = "esta_vent"
        Me.gc_esta_vent.Name = "gc_esta_vent"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionImage = Global.Facturacion.My.Resources.Resources._126
        Me.GroupControl2.Controls.Add(Me.btnImprimir)
        Me.GroupControl2.Controls.Add(Me.dgvVenta)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(871, 543)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Consultar Venta / Servicios Anulados"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.Facturacion.My.Resources.Resources._98
        Me.btnImprimir.Location = New System.Drawing.Point(736, 3)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(130, 33)
        Me.btnImprimir.TabIndex = 24
        Me.btnImprimir.Text = "Imprimir recibo"
        '
        'frm_venta_anulada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 567)
        Me.Controls.Add(Me.GroupControl2)
        Me.Name = "frm_venta_anulada"
        Me.Text = "Consultar Extornos"
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmMenuGrid.ResumeLayout(False)
        CType(Me.gvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sfdRuta As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmMenuGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmExportarExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmExportarPdf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvVenta As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gc_codi_vent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_item_veda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nomb_prod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_desc_unid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_capr_veda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_vaun_veda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_tota_veda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvVenta As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gc_fech_vent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nomb_clie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nudo_clie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_dire_clie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_desc_dove As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nudo_vent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_desc_fopa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_subt_vent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_toiv_vent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_tota_vent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_esta_vent As DevExpress.XtraGrid.Columns.GridColumn
End Class

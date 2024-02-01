<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_empoce_consulta
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
        Me.dgEmpoce = New DevExpress.XtraGrid.GridControl()
        Me.gvEmpoce = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgDetalle = New DevExpress.XtraGrid.GridControl()
        Me.gvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpHasta = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDesde = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.cmMenuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmExportarExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmExportarPdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgEmpoce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEmpoce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmMenuGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgEmpoce
        '
        Me.dgEmpoce.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgEmpoce.ContextMenuStrip = Me.cmMenuGrid
        Me.dgEmpoce.Location = New System.Drawing.Point(12, 55)
        Me.dgEmpoce.MainView = Me.gvEmpoce
        Me.dgEmpoce.Name = "dgEmpoce"
        Me.dgEmpoce.Size = New System.Drawing.Size(514, 274)
        Me.dgEmpoce.TabIndex = 24
        Me.dgEmpoce.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEmpoce})
        '
        'gvEmpoce
        '
        Me.gvEmpoce.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvEmpoce.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvEmpoce.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvEmpoce.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvEmpoce.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvEmpoce.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvEmpoce.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvEmpoce.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gvEmpoce.Appearance.Empty.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gvEmpoce.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gvEmpoce.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gvEmpoce.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvEmpoce.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvEmpoce.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvEmpoce.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvEmpoce.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gvEmpoce.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gvEmpoce.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvEmpoce.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.gvEmpoce.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvEmpoce.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvEmpoce.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvEmpoce.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvEmpoce.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvEmpoce.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvEmpoce.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvEmpoce.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvEmpoce.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvEmpoce.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvEmpoce.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvEmpoce.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvEmpoce.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvEmpoce.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvEmpoce.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvEmpoce.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvEmpoce.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvEmpoce.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvEmpoce.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvEmpoce.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.gvEmpoce.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.gvEmpoce.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gvEmpoce.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.HorzLine.Options.UseBorderColor = True
        Me.gvEmpoce.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvEmpoce.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvEmpoce.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.OddRow.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.OddRow.Options.UseBorderColor = True
        Me.gvEmpoce.Appearance.OddRow.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvEmpoce.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gvEmpoce.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.gvEmpoce.Appearance.Preview.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.Preview.Options.UseFont = True
        Me.gvEmpoce.Appearance.Preview.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvEmpoce.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.Row.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.Row.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvEmpoce.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gvEmpoce.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.gvEmpoce.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.gvEmpoce.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvEmpoce.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvEmpoce.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.gvEmpoce.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gvEmpoce.Appearance.VertLine.Options.UseBackColor = True
        Me.gvEmpoce.Appearance.VertLine.Options.UseBorderColor = True
        Me.gvEmpoce.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvEmpoce.GridControl = Me.dgEmpoce
        Me.gvEmpoce.Name = "gvEmpoce"
        Me.gvEmpoce.OptionsBehavior.Editable = False
        Me.gvEmpoce.OptionsView.EnableAppearanceEvenRow = True
        Me.gvEmpoce.OptionsView.EnableAppearanceOddRow = True
        Me.gvEmpoce.OptionsView.ShowAutoFilterRow = True
        Me.gvEmpoce.OptionsView.ShowGroupPanel = False
        '
        'dgDetalle
        '
        Me.dgDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalle.Location = New System.Drawing.Point(547, 55)
        Me.dgDetalle.MainView = Me.gvDetalle
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.Size = New System.Drawing.Size(441, 274)
        Me.dgDetalle.TabIndex = 24
        Me.dgDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalle})
        '
        'gvDetalle
        '
        Me.gvDetalle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvDetalle.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvDetalle.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvDetalle.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvDetalle.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gvDetalle.Appearance.Empty.Options.UseBackColor = True
        Me.gvDetalle.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gvDetalle.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gvDetalle.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvDetalle.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvDetalle.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvDetalle.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gvDetalle.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvDetalle.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gvDetalle.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvDetalle.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.gvDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvDetalle.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvDetalle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gvDetalle.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvDetalle.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvDetalle.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvDetalle.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvDetalle.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvDetalle.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvDetalle.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvDetalle.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvDetalle.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvDetalle.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvDetalle.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvDetalle.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvDetalle.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvDetalle.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvDetalle.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.gvDetalle.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvDetalle.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvDetalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvDetalle.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.gvDetalle.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.gvDetalle.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gvDetalle.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvDetalle.Appearance.HorzLine.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.OddRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.OddRow.Options.UseBorderColor = True
        Me.gvDetalle.Appearance.OddRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvDetalle.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gvDetalle.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.gvDetalle.Appearance.Preview.Options.UseBackColor = True
        Me.gvDetalle.Appearance.Preview.Options.UseFont = True
        Me.gvDetalle.Appearance.Preview.Options.UseForeColor = True
        Me.gvDetalle.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.Row.Options.UseBackColor = True
        Me.gvDetalle.Appearance.Row.Options.UseForeColor = True
        Me.gvDetalle.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvDetalle.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gvDetalle.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvDetalle.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.gvDetalle.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetalle.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvDetalle.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvDetalle.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvDetalle.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.gvDetalle.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gvDetalle.Appearance.VertLine.Options.UseBackColor = True
        Me.gvDetalle.Appearance.VertLine.Options.UseBorderColor = True
        Me.gvDetalle.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvDetalle.GridControl = Me.dgDetalle
        Me.gvDetalle.Name = "gvDetalle"
        Me.gvDetalle.OptionsBehavior.Editable = False
        Me.gvDetalle.OptionsView.EnableAppearanceEvenRow = True
        Me.gvDetalle.OptionsView.EnableAppearanceOddRow = True
        Me.gvDetalle.OptionsView.ShowFooter = True
        Me.gvDetalle.OptionsView.ShowGroupPanel = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.Facturacion.My.Resources.Resources._129
        Me.btnImprimir.Location = New System.Drawing.Point(868, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(120, 37)
        Me.btnImprimir.TabIndex = 25
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(466, 17)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(60, 23)
        Me.btnConsultar.TabIndex = 28
        Me.btnConsultar.Text = "Consultar"
        '
        'dtpHasta
        '
        Me.dtpHasta.EditValue = Nothing
        Me.dtpHasta.Location = New System.Drawing.Point(337, 20)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpHasta.Size = New System.Drawing.Size(125, 20)
        Me.dtpHasta.TabIndex = 27
        '
        'dtpDesde
        '
        Me.dtpDesde.EditValue = Nothing
        Me.dtpDesde.Location = New System.Drawing.Point(201, 20)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDesde.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDesde.Size = New System.Drawing.Size(125, 20)
        Me.dtpDesde.TabIndex = 26
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(180, 13)
        Me.LabelControl1.TabIndex = 29
        Me.LabelControl1.Text = "Seleccione extornos entre dos fechas"
        '
        'cmMenuGrid
        '
        Me.cmMenuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmExportarExcel, Me.cmExportarPdf, Me.cmImprimir})
        Me.cmMenuGrid.Name = "cmMenuGrid"
        Me.cmMenuGrid.Size = New System.Drawing.Size(156, 92)
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
        'frm_empoce_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 341)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.dgDetalle)
        Me.Controls.Add(Me.dgEmpoce)
        Me.Name = "frm_empoce_consulta"
        Me.Text = "Consulta de empoces"
        CType(Me.dgEmpoce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEmpoce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmMenuGrid.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgEmpoce As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEmpoce As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sfdRuta As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmMenuGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmExportarExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmExportarPdf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmImprimir As System.Windows.Forms.ToolStripMenuItem
End Class

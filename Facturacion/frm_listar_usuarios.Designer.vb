<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listar_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listar_usuarios))
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
        Me.btnObtenerText = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.vgcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vgcEmpleados
        '
        Me.vgcEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.vgcEmpleados.ImageList = Me.ImageCollection1
        Me.vgcEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.vgcEmpleados.Name = "vgcEmpleados"
        Me.vgcEmpleados.OptionsBehavior.Editable = False
        Me.vgcEmpleados.RecordWidth = 250
        Me.vgcEmpleados.RowHeaderWidth = 150
        Me.vgcEmpleados.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.category, Me.category1})
        Me.vgcEmpleados.Size = New System.Drawing.Size(592, 180)
        Me.vgcEmpleados.TabIndex = 0
        Me.vgcEmpleados.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "S03.png")
        Me.ImageCollection1.Images.SetKeyName(1, "S12.png")
        Me.ImageCollection1.Images.SetKeyName(2, "S30.png")
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
        Me.category1.Properties.Caption = "Direccion"
        Me.category1.Properties.ImageIndex = 1
        '
        'rowdire_empl
        '
        Me.rowdire_empl.Name = "rowdire_empl"
        Me.rowdire_empl.Properties.Caption = "Direccion"
        Me.rowdire_empl.Properties.FieldName = "dire_empl"
        Me.rowdire_empl.Properties.ImageIndex = 2
        '
        'rowtele_empl
        '
        Me.rowtele_empl.Name = "rowtele_empl"
        Me.rowtele_empl.Properties.Caption = "Telefono"
        Me.rowtele_empl.Properties.FieldName = "tele_empl"
        '
        'btnObtenerText
        '
        Me.btnObtenerText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnObtenerText.Location = New System.Drawing.Point(478, 195)
        Me.btnObtenerText.Name = "btnObtenerText"
        Me.btnObtenerText.Size = New System.Drawing.Size(102, 23)
        Me.btnObtenerText.TabIndex = 1
        Me.btnObtenerText.Text = "Mostrar "
        '
        'frm_listar_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 235)
        Me.Controls.Add(Me.btnObtenerText)
        Me.Controls.Add(Me.vgcEmpleados)
        Me.Name = "frm_listar_usuarios"
        Me.Text = "frm_listar_usuarios"
        CType(Me.vgcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vgcEmpleados As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents rowcodi_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownomb_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowid_carg As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownudo_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowdire_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowtele_empl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents category As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents category1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents btnObtenerText As DevExpress.XtraEditors.SimpleButton
End Class

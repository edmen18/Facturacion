<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cargos
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txt_descripcion = New DevExpress.XtraEditors.TextEdit()
        Me.gcCargos = New DevExpress.XtraGrid.GridControl()
        Me.gvCargos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gc_id_carg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_desc_carg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_codigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_descripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnNuevo, Me.btnGuardar, Me.btnEliminar, Me.btnSalir})
        Me.BarManager1.MaxItemId = 4
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.btnGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEliminar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSalir, True)})
        Me.Bar1.Text = "Herramientas"
        '
        'btnNuevo
        '
        Me.btnNuevo.Caption = "Nuevo"
        Me.btnNuevo.Glyph = Global.Facturacion.My.Resources.Resources.S17
        Me.btnNuevo.Id = 0
        Me.btnNuevo.Name = "btnNuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Caption = "Guardar"
        Me.btnGuardar.Glyph = Global.Facturacion.My.Resources.Resources.S15
        Me.btnGuardar.Id = 1
        Me.btnGuardar.Name = "btnGuardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Caption = "Eliminar"
        Me.btnEliminar.Glyph = Global.Facturacion.My.Resources.Resources.S19
        Me.btnEliminar.Id = 2
        Me.btnEliminar.Name = "btnEliminar"
        '
        'btnSalir
        '
        Me.btnSalir.Caption = "Salir"
        Me.btnSalir.Glyph = Global.Facturacion.My.Resources.Resources.S30
        Me.btnSalir.Id = 3
        Me.btnSalir.Name = "btnSalir"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(529, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 312)
        Me.barDockControlBottom.Size = New System.Drawing.Size(529, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 281)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(529, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 281)
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(72, 61)
        Me.txt_descripcion.MenuManager = Me.BarManager1
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(445, 20)
        Me.txt_descripcion.TabIndex = 4
        '
        'gcCargos
        '
        Me.gcCargos.Location = New System.Drawing.Point(12, 87)
        Me.gcCargos.MainView = Me.gvCargos
        Me.gcCargos.MenuManager = Me.BarManager1
        Me.gcCargos.Name = "gcCargos"
        Me.gcCargos.Size = New System.Drawing.Size(505, 213)
        Me.gcCargos.TabIndex = 5
        Me.gcCargos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCargos})
        '
        'gvCargos
        '
        Me.gvCargos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvCargos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvCargos.Appearance.FocusedRow.BackColor = System.Drawing.Color.Orange
        Me.gvCargos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvCargos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gc_id_carg, Me.gc_desc_carg})
        Me.gvCargos.GridControl = Me.gcCargos
        Me.gvCargos.Name = "gvCargos"
        Me.gvCargos.OptionsBehavior.Editable = False
        '
        'gc_id_carg
        '
        Me.gc_id_carg.Caption = "Id"
        Me.gc_id_carg.FieldName = "id_carg"
        Me.gc_id_carg.Name = "gc_id_carg"
        Me.gc_id_carg.Visible = True
        Me.gc_id_carg.VisibleIndex = 0
        Me.gc_id_carg.Width = 35
        '
        'gc_desc_carg
        '
        Me.gc_desc_carg.Caption = "Descripción"
        Me.gc_desc_carg.FieldName = "desc_carg"
        Me.gc_desc_carg.Name = "gc_desc_carg"
        Me.gc_desc_carg.Visible = True
        Me.gc_desc_carg.VisibleIndex = 1
        Me.gc_desc_carg.Width = 452
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 64)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Descripción"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(72, 37)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Properties.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(121, 20)
        Me.txt_codigo.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Código"
        '
        'frm_cargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 312)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.gcCargos)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_cargos"
        Me.Text = "Registrar cargos"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_descripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcCargos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCargos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_descripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gc_id_carg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_desc_carg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_codigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class

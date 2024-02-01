<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_empleados_permisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_empleados_permisos))
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblId = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmpleado = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnRefrescar = New DevExpress.XtraEditors.SimpleButton()
        Me.gcModulos = New DevExpress.XtraGrid.GridControl()
        Me.gvModulos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gc_id_modu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_nomb_modu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gruPermisos = New DevExpress.XtraEditors.GroupControl()
        Me.gcPermisos = New DevExpress.XtraGrid.GridControl()
        Me.gvPermisos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.codi_empl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_id_moduper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_des_moduper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuitar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAsignar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.gcModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gruPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruPermisos.SuspendLayout()
        CType(Me.gcPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "S03.png")
        Me.ImageCollection1.Images.SetKeyName(1, "S12.png")
        Me.ImageCollection1.Images.SetKeyName(2, "S30.png")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupControl2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gruPermisos, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.59533!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.40467!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(898, 591)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionImage = Global.Facturacion.My.Resources.Resources.M_18
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupControl1, 3)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.lblId)
        Me.GroupControl1.Controls.Add(Me.lblEmpleado)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(892, 121)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Empleado seleccionado."
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(49, 78)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 20)
        Me.LabelControl3.TabIndex = 25
        Me.LabelControl3.Text = "Nombre:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(49, 48)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(97, 20)
        Me.LabelControl1.TabIndex = 24
        Me.LabelControl1.Text = "ID Empleado:"
        '
        'lblId
        '
        Me.lblId.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(182, 44)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 20)
        Me.lblId.TabIndex = 23
        '
        'lblEmpleado
        '
        Me.lblEmpleado.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleado.Location = New System.Drawing.Point(182, 74)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(0, 20)
        Me.lblEmpleado.TabIndex = 23
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionImage = Global.Facturacion.My.Resources.Resources.M_19
        Me.GroupControl2.Controls.Add(Me.btnRefrescar)
        Me.GroupControl2.Controls.Add(Me.gcModulos)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(3, 130)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(407, 458)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Modulos disponibles"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefrescar.Location = New System.Drawing.Point(269, 0)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(133, 34)
        Me.btnRefrescar.TabIndex = 1
        Me.btnRefrescar.Text = "Volver a cargar modulos"
        '
        'gcModulos
        '
        Me.gcModulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcModulos.Location = New System.Drawing.Point(2, 40)
        Me.gcModulos.MainView = Me.gvModulos
        Me.gcModulos.Name = "gcModulos"
        Me.gcModulos.Size = New System.Drawing.Size(403, 416)
        Me.gcModulos.TabIndex = 0
        Me.gcModulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvModulos})
        '
        'gvModulos
        '
        Me.gvModulos.Appearance.FocusedCell.BackColor = System.Drawing.Color.Orange
        Me.gvModulos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvModulos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvModulos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvModulos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gc_id_modu, Me.gc_nomb_modu})
        Me.gvModulos.GridControl = Me.gcModulos
        Me.gvModulos.Name = "gvModulos"
        Me.gvModulos.OptionsBehavior.Editable = False
        Me.gvModulos.OptionsView.ShowGroupPanel = False
        '
        'gc_id_modu
        '
        Me.gc_id_modu.Caption = "id_modu"
        Me.gc_id_modu.FieldName = "id_modu"
        Me.gc_id_modu.Name = "gc_id_modu"
        '
        'gc_nomb_modu
        '
        Me.gc_nomb_modu.Caption = "Nombre de Módulo"
        Me.gc_nomb_modu.FieldName = "nomb_modu"
        Me.gc_nomb_modu.Name = "gc_nomb_modu"
        Me.gc_nomb_modu.Visible = True
        Me.gc_nomb_modu.VisibleIndex = 0
        '
        'gruPermisos
        '
        Me.gruPermisos.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.gruPermisos.AppearanceCaption.Options.UseFont = True
        Me.gruPermisos.CaptionImage = Global.Facturacion.My.Resources.Resources.M_13
        Me.gruPermisos.Controls.Add(Me.gcPermisos)
        Me.gruPermisos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gruPermisos.Location = New System.Drawing.Point(487, 130)
        Me.gruPermisos.Name = "gruPermisos"
        Me.gruPermisos.Size = New System.Drawing.Size(408, 458)
        Me.gruPermisos.TabIndex = 2
        Me.gruPermisos.Text = "Permisos asignados"
        '
        'gcPermisos
        '
        Me.gcPermisos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPermisos.Location = New System.Drawing.Point(2, 40)
        Me.gcPermisos.MainView = Me.gvPermisos
        Me.gcPermisos.Name = "gcPermisos"
        Me.gcPermisos.Size = New System.Drawing.Size(404, 416)
        Me.gcPermisos.TabIndex = 1
        Me.gcPermisos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPermisos})
        '
        'gvPermisos
        '
        Me.gvPermisos.Appearance.FocusedCell.BackColor = System.Drawing.Color.Orange
        Me.gvPermisos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvPermisos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.codi_empl, Me.gc_id_moduper, Me.gc_des_moduper})
        Me.gvPermisos.GridControl = Me.gcPermisos
        Me.gvPermisos.Name = "gvPermisos"
        Me.gvPermisos.OptionsBehavior.Editable = False
        Me.gvPermisos.OptionsView.ShowGroupPanel = False
        '
        'codi_empl
        '
        Me.codi_empl.Caption = "Empleado"
        Me.codi_empl.FieldName = "codi_empl"
        Me.codi_empl.Name = "codi_empl"
        '
        'gc_id_moduper
        '
        Me.gc_id_moduper.Caption = "Módulo"
        Me.gc_id_moduper.FieldName = "id_moduper"
        Me.gc_id_moduper.Name = "gc_id_moduper"
        '
        'gc_des_moduper
        '
        Me.gc_des_moduper.Caption = "Módulo asignado"
        Me.gc_des_moduper.FieldName = "des_moduper"
        Me.gc_des_moduper.Name = "gc_des_moduper"
        Me.gc_des_moduper.Visible = True
        Me.gc_des_moduper.VisibleIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnGuardar)
        Me.PanelControl1.Controls.Add(Me.btnQuitar)
        Me.PanelControl1.Controls.Add(Me.btnAsignar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(416, 130)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(65, 458)
        Me.PanelControl1.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = Global.Facturacion.My.Resources.Resources._145
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(10, 219)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(47, 57)
        Me.btnGuardar.TabIndex = 1
        '
        'btnQuitar
        '
        Me.btnQuitar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitar.Image = Global.Facturacion.My.Resources.Resources.M_10
        Me.btnQuitar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuitar.Location = New System.Drawing.Point(10, 162)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(47, 51)
        Me.btnQuitar.TabIndex = 0
        '
        'btnAsignar
        '
        Me.btnAsignar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAsignar.Image = Global.Facturacion.My.Resources.Resources.M_09
        Me.btnAsignar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAsignar.Location = New System.Drawing.Point(10, 105)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(47, 51)
        Me.btnAsignar.TabIndex = 0
        '
        'frm_empleados_permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 591)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frm_empleados_permisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar permisos a empleados"
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.gcModulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvModulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gruPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruPermisos.ResumeLayout(False)
        CType(Me.gcPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcModulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvModulos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gruPermisos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcPermisos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPermisos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnQuitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAsignar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gc_id_modu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nomb_modu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents codi_empl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_id_moduper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_des_moduper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefrescar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblEmpleado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblId As DevExpress.XtraEditors.LabelControl
End Class

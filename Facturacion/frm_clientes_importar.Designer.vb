<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes_importar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.grExportar = New DevExpress.XtraEditors.GroupControl()
        Me.txtRuta = New DevExpress.XtraEditors.ButtonEdit()
        Me.gcClientes = New DevExpress.XtraGrid.GridControl()
        Me.gvClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gc_codi_clie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_id_ticl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_nomb_clie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_nudo_clie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_dire_clie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_tele_clie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_emai_clie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ofdRuta = New System.Windows.Forms.OpenFileDialog()
        CType(Me.grExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grExportar.SuspendLayout()
        CType(Me.txtRuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grExportar
        '
        Me.grExportar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grExportar.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold)
        Me.grExportar.AppearanceCaption.Options.UseFont = True
        Me.grExportar.CaptionImage = Global.Facturacion.My.Resources.Resources.M_03
        Me.grExportar.Controls.Add(Me.txtRuta)
        Me.grExportar.Controls.Add(Me.gcClientes)
        Me.grExportar.Location = New System.Drawing.Point(5, 4)
        Me.grExportar.Name = "grExportar"
        Me.grExportar.Size = New System.Drawing.Size(703, 371)
        Me.grExportar.TabIndex = 0
        Me.grExportar.Text = "Seleccione archivo de excel a importar"
        '
        'txtRuta
        '
        Me.txtRuta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRuta.EnterMoveNextControl = True
        Me.txtRuta.Location = New System.Drawing.Point(5, 43)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.GreenYellow
        Me.txtRuta.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.Facturacion.My.Resources.Resources.S53, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", "BuscarProducto", Nothing, True)})
        Me.txtRuta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtRuta.Size = New System.Drawing.Size(693, 22)
        Me.txtRuta.TabIndex = 10
        '
        'gcClientes
        '
        Me.gcClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcClientes.Location = New System.Drawing.Point(5, 71)
        Me.gcClientes.MainView = Me.gvClientes
        Me.gcClientes.Name = "gcClientes"
        Me.gcClientes.Size = New System.Drawing.Size(693, 295)
        Me.gcClientes.TabIndex = 0
        Me.gcClientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvClientes})
        '
        'gvClientes
        '
        Me.gvClientes.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvClientes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvClientes.Appearance.FocusedRow.BackColor = System.Drawing.Color.Orange
        Me.gvClientes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvClientes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gc_codi_clie, Me.gc_id_ticl, Me.gc_nomb_clie, Me.gc_nudo_clie, Me.gc_dire_clie, Me.gc_tele_clie, Me.gc_emai_clie})
        Me.gvClientes.GridControl = Me.gcClientes
        Me.gvClientes.Name = "gvClientes"
        Me.gvClientes.OptionsBehavior.Editable = False
        '
        'gc_codi_clie
        '
        Me.gc_codi_clie.Caption = "Código"
        Me.gc_codi_clie.FieldName = "codi_clie"
        Me.gc_codi_clie.Name = "gc_codi_clie"
        Me.gc_codi_clie.Visible = True
        Me.gc_codi_clie.VisibleIndex = 0
        '
        'gc_id_ticl
        '
        Me.gc_id_ticl.Caption = "Tipo cliente"
        Me.gc_id_ticl.FieldName = "id_ticl"
        Me.gc_id_ticl.Name = "gc_id_ticl"
        Me.gc_id_ticl.Visible = True
        Me.gc_id_ticl.VisibleIndex = 1
        '
        'gc_nomb_clie
        '
        Me.gc_nomb_clie.Caption = "Nombre de cliente"
        Me.gc_nomb_clie.FieldName = "nomb_clie"
        Me.gc_nomb_clie.Name = "gc_nomb_clie"
        Me.gc_nomb_clie.Visible = True
        Me.gc_nomb_clie.VisibleIndex = 2
        '
        'gc_nudo_clie
        '
        Me.gc_nudo_clie.Caption = "Documento"
        Me.gc_nudo_clie.FieldName = "nudo_clie"
        Me.gc_nudo_clie.Name = "gc_nudo_clie"
        Me.gc_nudo_clie.Visible = True
        Me.gc_nudo_clie.VisibleIndex = 3
        '
        'gc_dire_clie
        '
        Me.gc_dire_clie.Caption = "Direccón"
        Me.gc_dire_clie.FieldName = "dire_clie"
        Me.gc_dire_clie.Name = "gc_dire_clie"
        Me.gc_dire_clie.Visible = True
        Me.gc_dire_clie.VisibleIndex = 4
        '
        'gc_tele_clie
        '
        Me.gc_tele_clie.Caption = "Teléfono"
        Me.gc_tele_clie.FieldName = "tele_clie"
        Me.gc_tele_clie.Name = "gc_tele_clie"
        Me.gc_tele_clie.Visible = True
        Me.gc_tele_clie.VisibleIndex = 5
        '
        'gc_emai_clie
        '
        Me.gc_emai_clie.Caption = "Email"
        Me.gc_emai_clie.FieldName = "emai_clie"
        Me.gc_emai_clie.Name = "gc_emai_clie"
        Me.gc_emai_clie.Visible = True
        Me.gc_emai_clie.VisibleIndex = 6
        '
        'ofdRuta
        '
        Me.ofdRuta.FileName = "clientes"
        Me.ofdRuta.Filter = "Archivos xlsx|*.xls|Archivos xls|*.xls"
        '
        'frm_clientes_importar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 379)
        Me.Controls.Add(Me.grExportar)
        Me.Name = "frm_clientes_importar"
        Me.Text = "Importar clientes"
        CType(Me.grExportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grExportar.ResumeLayout(False)
        CType(Me.txtRuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grExportar As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcClientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gc_codi_clie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_id_ticl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nomb_clie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nudo_clie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_dire_clie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_tele_clie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_emai_clie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRuta As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ofdRuta As System.Windows.Forms.OpenFileDialog
End Class

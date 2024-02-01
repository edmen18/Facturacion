<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_entidad
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.dgvEntidad = New DevExpress.XtraGrid.GridControl()
        Me.gvEntidad = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnExaminar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAnio = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtRuc = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.btnRegistrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionImage = Global.Facturacion.My.Resources.Resources._87
        Me.GroupControl1.Controls.Add(Me.picLogo)
        Me.GroupControl1.Controls.Add(Me.dgvEntidad)
        Me.GroupControl1.Controls.Add(Me.btnExaminar)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtAnio)
        Me.GroupControl1.Controls.Add(Me.txtEmail)
        Me.GroupControl1.Controls.Add(Me.txtTelefono)
        Me.GroupControl1.Controls.Add(Me.txtDireccion)
        Me.GroupControl1.Controls.Add(Me.txtRuc)
        Me.GroupControl1.Controls.Add(Me.txtNombre)
        Me.GroupControl1.Controls.Add(Me.txtCodigo)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 13)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(720, 484)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Información de la Entidad"
        '
        'picLogo
        '
        Me.picLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogo.Location = New System.Drawing.Point(589, 76)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(124, 124)
        Me.picLogo.TabIndex = 34
        Me.picLogo.TabStop = False
        '
        'dgvEntidad
        '
        Me.dgvEntidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEntidad.Location = New System.Drawing.Point(13, 252)
        Me.dgvEntidad.MainView = Me.gvEntidad
        Me.dgvEntidad.Name = "dgvEntidad"
        Me.dgvEntidad.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.dgvEntidad.Size = New System.Drawing.Size(705, 212)
        Me.dgvEntidad.TabIndex = 33
        Me.dgvEntidad.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEntidad})
        '
        'gvEntidad
        '
        Me.gvEntidad.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.gvEntidad.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvEntidad.GridControl = Me.dgvEntidad
        Me.gvEntidad.Name = "gvEntidad"
        Me.gvEntidad.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvEntidad.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvEntidad.OptionsBehavior.Editable = False
        Me.gvEntidad.OptionsBehavior.ReadOnly = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Código"
        Me.GridColumn1.FieldName = "codi_enti"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre"
        Me.GridColumn2.FieldName = "nomb_enti"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Ruc"
        Me.GridColumn3.FieldName = "ruc_enti"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Dirección"
        Me.GridColumn4.FieldName = "dire_enti"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Telefono"
        Me.GridColumn5.FieldName = "tele_enti"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Email"
        Me.GridColumn6.FieldName = "emai_enti"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Logo"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.GridColumn7.FieldName = "logo_enti"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Año"
        Me.GridColumn8.FieldName = "anio_enti"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'btnExaminar
        '
        Me.btnExaminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExaminar.Location = New System.Drawing.Point(589, 207)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(125, 25)
        Me.btnExaminar.TabIndex = 1
        Me.btnExaminar.Text = "Seleccionar"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(13, 210)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl7.TabIndex = 32
        Me.LabelControl7.Text = "Nombre Año:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(13, 184)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl6.TabIndex = 32
        Me.LabelControl6.Text = "E-mail:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(13, 158)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl5.TabIndex = 32
        Me.LabelControl5.Text = "Teléfono:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(13, 132)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 32
        Me.LabelControl4.Text = "Dirección:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(13, 106)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl3.TabIndex = 32
        Me.LabelControl3.Text = "Ruc:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 80)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl2.TabIndex = 32
        Me.LabelControl2.Text = "Nombre:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 54)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Código:"
        '
        'txtAnio
        '
        Me.txtAnio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnio.Location = New System.Drawing.Point(96, 207)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(479, 20)
        Me.txtAnio.TabIndex = 28
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(96, 181)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(479, 20)
        Me.txtEmail.TabIndex = 29
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefono.Location = New System.Drawing.Point(96, 155)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(479, 20)
        Me.txtTelefono.TabIndex = 27
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Location = New System.Drawing.Point(96, 129)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(479, 20)
        Me.txtDireccion.TabIndex = 23
        '
        'txtRuc
        '
        Me.txtRuc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRuc.Location = New System.Drawing.Point(96, 103)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(479, 20)
        Me.txtRuc.TabIndex = 26
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(96, 77)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(479, 20)
        Me.txtNombre.TabIndex = 25
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(96, 51)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(89, 20)
        Me.txtCodigo.TabIndex = 24
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.Location = New System.Drawing.Point(477, 503)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(125, 25)
        Me.btnRegistrar.TabIndex = 1
        Me.btnRegistrar.Text = "Registrar"
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(608, 503)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(125, 25)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Actualizar"
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'frm_entidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 542)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frm_entidad"
        Me.Text = "Configurar datos de entidad"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtAnio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRuc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRegistrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvEntidad As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEntidad As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExaminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
End Class

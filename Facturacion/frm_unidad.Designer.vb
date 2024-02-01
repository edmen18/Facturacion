<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_unidad
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
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCargos = New System.Windows.Forms.DataGridView()
        Me.txtAbreviatura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(10, 52)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(400, 20)
        Me.txtDescripcion.TabIndex = 10
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNuevo, Me.btGuardar, Me.tbEliminar, Me.ToolStripSeparator1, Me.btnCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(417, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btNuevo
        '
        Me.btNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btNuevo.Image = Global.Facturacion.My.Resources.Resources.S17
        Me.btNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(23, 22)
        Me.btNuevo.Text = "Nuevo"
        '
        'btGuardar
        '
        Me.btGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btGuardar.Image = Global.Facturacion.My.Resources.Resources.S15
        Me.btGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(23, 22)
        Me.btGuardar.Text = "Guardar datos"
        '
        'tbEliminar
        '
        Me.tbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbEliminar.Image = Global.Facturacion.My.Resources.Resources.S19
        Me.tbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbEliminar.Name = "tbEliminar"
        Me.tbEliminar.Size = New System.Drawing.Size(23, 22)
        Me.tbEliminar.Text = "Eliminar el registro"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = Global.Facturacion.My.Resources.Resources.S28
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(23, 22)
        Me.btnCancelar.Text = "Cancelar el proceso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Descripcion de la Unidad"
        '
        'dgvCargos
        '
        Me.dgvCargos.AllowUserToAddRows = False
        Me.dgvCargos.AllowUserToDeleteRows = False
        Me.dgvCargos.AllowUserToOrderColumns = True
        Me.dgvCargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCargos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargos.Location = New System.Drawing.Point(10, 117)
        Me.dgvCargos.MultiSelect = False
        Me.dgvCargos.Name = "dgvCargos"
        Me.dgvCargos.ReadOnly = True
        Me.dgvCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCargos.Size = New System.Drawing.Size(400, 157)
        Me.dgvCargos.TabIndex = 8
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.Enabled = False
        Me.txtAbreviatura.Location = New System.Drawing.Point(10, 91)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(400, 20)
        Me.txtAbreviatura.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Abreviatura"
        '
        'frm_unidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 278)
        Me.Controls.Add(Me.txtAbreviatura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCargos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_unidad"
        Me.Text = "Registro Unidad"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvCargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvCargos As System.Windows.Forms.DataGridView
    Friend WithEvents txtAbreviatura As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

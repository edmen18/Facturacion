<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_backup
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
        Me.btnBackup = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDestino = New DevExpress.XtraEditors.ButtonEdit()
        Me.FldrView = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnBackup)
        Me.GroupControl1.Controls.Add(Me.txtDestino)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(572, 111)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Seleccione destino"
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(416, 75)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(132, 23)
        Me.btnBackup.TabIndex = 1
        Me.btnBackup.Text = "Realizar copia"
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(21, 34)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDestino.Size = New System.Drawing.Size(527, 20)
        Me.txtDestino.TabIndex = 0
        '
        'frm_backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 136)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_backup"
        Me.Text = "Backup de la base de datos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnBackup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDestino As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents FldrView As System.Windows.Forms.FolderBrowserDialog
End Class

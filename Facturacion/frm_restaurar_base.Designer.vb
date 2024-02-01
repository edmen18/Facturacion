<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_restaurar_base
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
        Me.btnRestaura = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBase = New DevExpress.XtraEditors.TextEdit()
        Me.txtRuta = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtServer = New DevExpress.XtraEditors.TextEdit()
        Me.ofdRuta = New System.Windows.Forms.OpenFileDialog()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtBase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnRestaura)
        Me.GroupControl1.Controls.Add(Me.txtBase)
        Me.GroupControl1.Controls.Add(Me.txtRuta)
        Me.GroupControl1.Controls.Add(Me.txtServer)
        Me.GroupControl1.Location = New System.Drawing.Point(10, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(612, 196)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'btnRestaura
        '
        Me.btnRestaura.Location = New System.Drawing.Point(320, 162)
        Me.btnRestaura.Name = "btnRestaura"
        Me.btnRestaura.Size = New System.Drawing.Size(193, 23)
        Me.btnRestaura.TabIndex = 3
        Me.btnRestaura.Text = "Restaurar base datos"
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(157, 84)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(203, 20)
        Me.txtBase.TabIndex = 2
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(157, 124)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtRuta.Size = New System.Drawing.Size(356, 20)
        Me.txtRuta.TabIndex = 1
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(157, 45)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(203, 20)
        Me.txtServer.TabIndex = 0
        '
        'ofdRuta
        '
        Me.ofdRuta.FileName = "OpenFileDialog1"
        '
        'frm_restaurar_base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 214)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frm_restaurar_base"
        Me.Text = "frm_restaurar_base"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtBase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtRuta As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtServer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnRestaura As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ofdRuta As System.Windows.Forms.OpenFileDialog
End Class

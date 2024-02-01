<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_convertidor
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
        Me.btnConvertir = New DevExpress.XtraEditors.SimpleButton()
        Me.lblDecimal = New DevExpress.XtraEditors.LabelControl()
        Me.TimeEdit1 = New DevExpress.XtraEditors.TimeEdit()
        CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(52, 73)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(142, 23)
        Me.btnConvertir.TabIndex = 1
        Me.btnConvertir.Text = "Convertir"
        '
        'lblDecimal
        '
        Me.lblDecimal.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDecimal.Location = New System.Drawing.Point(102, 120)
        Me.lblDecimal.Name = "lblDecimal"
        Me.lblDecimal.Size = New System.Drawing.Size(30, 23)
        Me.lblDecimal.TabIndex = 2
        Me.lblDecimal.Text = "0.0"
        '
        'TimeEdit1
        '
        Me.TimeEdit1.EditValue = New Date(CType(0, Long))
        Me.TimeEdit1.Location = New System.Drawing.Point(52, 24)
        Me.TimeEdit1.Name = "TimeEdit1"
        Me.TimeEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeEdit1.Properties.Appearance.Options.UseFont = True
        Me.TimeEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeEdit1.Properties.Mask.EditMask = ""
        Me.TimeEdit1.Size = New System.Drawing.Size(142, 30)
        Me.TimeEdit1.TabIndex = 3
        '
        'frm_convertidor
        '
        Me.AcceptButton = Me.btnConvertir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 163)
        Me.Controls.Add(Me.TimeEdit1)
        Me.Controls.Add(Me.lblDecimal)
        Me.Controls.Add(Me.btnConvertir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frm_convertidor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convertir Horas a decimal"
        CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConvertir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblDecimal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TimeEdit1 As DevExpress.XtraEditors.TimeEdit
End Class

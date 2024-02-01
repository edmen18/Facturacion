Public Class frm_convertidor 

    Private Sub btnConvertir_Click(sender As System.Object, e As System.EventArgs) Handles btnConvertir.Click
        Dim ADate As DateTime
        ADate = TimeEdit1.EditValue
        Dim DbleTime As Double = ADate.ToOADate()

        'Dim TheMinute As Double = CDbl(DatePart(DateInterval.Minute, ADate)) / 60.0
        lblDecimal.Text = Math.Round(DbleTime * 24, 2)

        'MsgBox(DbleTime * 24)
        'MsgBox(TheMinute)
    End Sub

    Private Sub frm_convertidor_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub frm_convertidor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TimeEdit1.Properties.EditMask = "HH:mm"
    End Sub

   
End Class
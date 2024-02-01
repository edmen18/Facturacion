Imports Logica
Public Class frm_backup

    Dim Backup As New cl_backup
    Private Sub btnBackup_Click(sender As System.Object, e As System.EventArgs) Handles btnBackup.Click
        Backup.CreaBackup(Me.txtDestino.EditValue, "DB_FACTURACION")
    End Sub

    Private Sub txtDestino_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDestino.ButtonClick
        Me.txtDestino.ResetText()
        If FldrView.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.txtDestino.Text = FldrView.SelectedPath & "\DB_FACTURACION" & Date.Now.Day & Date.Now.Month & Date.Now.Year & ".BAK"
        End If
    End Sub
End Class
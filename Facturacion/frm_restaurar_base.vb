Imports Logica



Public Class frm_restaurar_base
    Dim Backup As New cl_backup


    Private Sub btnRestaura_Click(sender As System.Object, e As System.EventArgs) Handles btnRestaura.Click
        Backup.RestauraBackup(Me.txtServer.EditValue, Me.txtBase.EditValue, Me.txtRuta.EditValue)
    End Sub

    Private Sub txtRuta_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtRuta.ButtonClick
        Me.txtRuta.ResetText()
        If ofdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.txtRuta.Text = ofdRuta.FileName()
        End If

    End Sub

End Class
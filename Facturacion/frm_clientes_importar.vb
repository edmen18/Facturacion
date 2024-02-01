


Public Class frm_clientes_importar

    Private Sub txtRuta_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtRuta.ButtonClick
        Me.txtRuta.ResetText()
        If ofdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.txtRuta.Text = ofdRuta.FileName()
        End If

    End Sub
End Class
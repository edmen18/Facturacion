Imports Logica
Public Class frm_login
    Dim usuario As New cl_usuarios
    Dim Cryp As New cl_encrypta

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If usuario.LoginUsuario(Me.UsernameTextBox.Text, SHA1(PasswordTextBox.Text)) = True Then
            With UsuarioActivo
                .EsAdmin = usuario.EsAdmin
                .Nombre = usuario.Nombre
                .Apellido = usuario.Apellido
                .IdUsuario = usuario.IdUsuario
                .Dni = usuario.Dni
            End With

            DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Usuario o clave incorrecta", "Logueo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.PasswordTextBox.Focus()
            PasswordTextBox.SelectionStart = 0
            PasswordTextBox.SelectionLength = Len(PasswordTextBox.Text)
            Exit Sub
        End If

        'MsgBox(UsuarioActivo.EsAdmin)
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class

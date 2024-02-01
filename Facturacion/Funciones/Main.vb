Imports DevExpress.LookAndFeel
Module Main

    Public fdesde As String 'Fecha Inicial reporte grafico
    Public fhasta As String 'Fecha Final reporte grafico

    Dim Settings As New My.MySettings
    Sub Main()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        Application.EnableVisualStyles()
        UserLookAndFeel.Default.SkinName = Settings.Skin
        If My.Forms.frm_login.ShowDialog = DialogResult.OK Then
            Application.Run(New Principal())
        End If
    End Sub

    Public Structure Usuario
        Public IdUsuario As String
        Public Nombre As String
        Public Apellido As String
        Public EsAdmin As Boolean
        Public Dni As String
    End Structure

    Public UsuarioActivo As Usuario
End Module

Imports Datos

Public Class cl_encrypta

    Public Sub IniciaCrypt()
        Dim db As BaseDatos = New BaseDatos()
        db.EncriptaApp()
        'db.Desconectar()
    End Sub

End Class

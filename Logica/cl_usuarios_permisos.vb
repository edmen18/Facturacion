Imports Datos
Imports System.Windows.Forms
Imports System.Data

Public Class cl_usuarios_permisos
    Private _idUsuario As String
    Public Property IdUsuario() As String
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As String)
            _idUsuario = value
        End Set
    End Property

    Private _idModulo As Integer
    Public Property IdModulo() As Integer
        Get
            Return _idModulo
        End Get
        Set(ByVal value As Integer)
            _idModulo = value
        End Set
    End Property

    Public Function AgregarPermisosUsuario(ByVal Usuario As String, ByRef dataGridPermisos As Object) As Boolean

        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.ComenzarTransaccion()
        'Registramos los recibos que conforman el empoce
        Dim i, xRow As Integer

        For i = 0 To dataGridPermisos.RowCount - 1
            xRow = dataGridPermisos.GetVisibleRowHandle(i) 'Esto es por si el grid esta filtrado

            'VentaEmpoce.CodigoVenta = dg.GetRowCellValue(xRow, "CODIGO")

            IdUsuario = Usuario
            IdModulo = dataGridPermisos.GetRowCellValue(xRow, "id_moduper")

            db.CrearStoreProcedure("SP_USUARIOS_ASIGNA_PERMISOS")
            db.AsignarParametrosPA("usu", 0, 3, Me.IdUsuario)
            db.AsignarParametrosPA("mod", 0, 8, Me.IdModulo)

            Try
                db.EjecutarComando()
            Catch ex As Exception
                MessageBox.Show("Error Alta " + ex.ToString, "TELSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                db.CancelarTransaccion()
                Return False
            End Try
        Next
        db.ConfirmarTransaccion()
        db.Desconectar()
        Return True

    End Function

End Class

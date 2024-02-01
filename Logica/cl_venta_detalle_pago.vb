Imports System.Data
Imports System.Windows.Forms
Imports Datos

Public Class cl_venta_detalle_pago
    Dim FDB As New cFuncionesDB

    Private _codigo As String
    Private _codigoVenta As String
    Private _banco As Integer
    Private _numero As String


    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    Public Property Banco() As Integer
        Get
            Return _banco
        End Get
        Set(ByVal value As Integer)
            _banco = value
        End Set
    End Property


    Public Property CodigoVenta() As String
        Get
            Return _codigoVenta
        End Get
        Set(ByVal value As String)
            _codigoVenta = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Function GeneraCodigo() As Integer
        Dim strsql As String
        Dim codigo As Integer

        strsql = "SELECT MAX(CONVERT(INT,RIGHT(codi_fdpa,8))) AS CCOD FROM T_VENTA_DETALLE_PAGO"
        Dim dato As String = FDB.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            codigo = 1
        Else
            codigo = CInt(dato) + 1
        End If
        Return codigo
    End Function

    Public Function RegistraPago() As Boolean
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_VENTA_DETALLE_PAGO_REGISTRA")
        db.AsignarParametrosPA("cod", 0, 3, Me.Codigo)
        db.AsignarParametrosPA("ven", 0, 22, Me.CodigoVenta)
        db.AsignarParametrosPA("ban", 0, 8, Me.Banco)
        db.AsignarParametrosPA("che", 0, 22, Me.Numero)
        db.AsignarParametrosPA("est", 0, 8, "1")

        Try
            db.EjecutarComando()
        Catch ex As Exception
            MessageBox.Show("Error al insertar el Pago" + ex.ToString, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            db.CancelarTransaccion()
            Return False
        End Try
        db.ConfirmarTransaccion()
        MessageBox.Show("Se ha registrado informacion de pago con Cheque", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        db.Desconectar()
        Return True
    End Function


    Public Function ActualizarPago() As Boolean
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_VENTA_DETALLE_PAGO_ACTUALIZA")
        db.AsignarParametrosPA("codi_vent", 0, 22, Me.CodigoVenta)
        db.AsignarParametrosPA("id_banc", 0, 8, Me.Banco)
        db.AsignarParametrosPA("nudo_fopa", 0, 22, Me.Numero)

        Try
            db.EjecutarComando()
        Catch ex As Exception
            MessageBox.Show("Error al insertar el Pago" + ex.ToString, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            db.CancelarTransaccion()
            Return False
        End Try
        db.ConfirmarTransaccion()
        MessageBox.Show("Se ha registrado informacion de pago con Cheque", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        db.Desconectar()
        Return True
    End Function


    Public Function EliminarPago(ByVal codigoVenta As String) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_VENTA_DETALLE_PAGO_ELIMINA")
        db.AsignarParametrosPA("codi_vent", 0, 22, codigoVenta)
        Try
            db.EjecutarComando()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el detalle de Pago con Documento" + ex.ToString, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            db.CancelarTransaccion()
            Return False
        End Try
        db.ConfirmarTransaccion()
        db.Desconectar()
        Return True
    End Function


End Class

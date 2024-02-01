Imports Datos
Imports System.Windows.Forms

Public Class cl_extorno
    Dim FDB As New cFuncionesDB
#Region "Variables"
    Private _codigo As String
    Private _fecha As Date
    Private _codigoVenta As String
    Private _motivo As Integer
    Private _monto As Double
    Private _empleado As String
#End Region

#Region "Propiedades"

    Public Property Empleado() As String
        Get
            Return _empleado
        End Get
        Set(ByVal value As String)
            _empleado = value
        End Set
    End Property

    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    Public Property Motivo() As Integer
        Get
            Return _motivo
        End Get
        Set(ByVal value As Integer)
            _motivo = value
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

    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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

    Private _codigoFormaPago As String
    Public Property CodigoFormaPago() As String
        Get
            Return _codigoFormaPago
        End Get
        Set(ByVal value As String)
            _codigoFormaPago = value
        End Set
    End Property


#End Region


#Region "Metodos"

#End Region

    Public Function AgregarExtorno() As Boolean
        'Try
        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_EXTORNO_REGISTRA")
        db.AsignarParametrosPA("cod", 0, 3, Me.Codigo)
        db.AsignarParametrosPA("fec", 0, 31, Me.Fecha)
        db.AsignarParametrosPA("ven", 0, 22, Me.CodigoVenta)
        db.AsignarParametrosPA("moe", 0, 8, Me.Motivo)
        db.AsignarParametrosPA("mon", 0, 9, Me.Monto)
        db.AsignarParametrosPA("emp", 0, 3, Me.Empleado)

        pregunta = MessageBox.Show("Desea continuar con el registro del elemento", "Registros", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pregunta = DialogResult.Yes Then
            Try
                db.EjecutarComando()
            Catch ex As Exception
                If ex.Message.Contains("clave duplicada") Then
                    MessageBox.Show("Ya se encuentra registrado un cliente con ese código", "SIF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Error al insertar" + ex.ToString, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                db.CancelarTransaccion()
                Return False
            End Try

            db.CrearStoreProcedure("SP_VENTA_DETALLE_PAGO_EXTORNA")
            db.AsignarParametrosPA("codi_vent", 0, 3, Me.CodigoVenta)
            db.AsignarParametrosPA("esta_fopa", 0, 8, vbNull)

            Try
                db.EjecutarComando()
            Catch ex As Exception
                MessageBox.Show("Error al insertar" + ex.ToString, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                db.CancelarTransaccion()
                Return False
            End Try

        Else
            db.CancelarTransaccion()
            Return False
        End If
        db.ConfirmarTransaccion()
        MessageBox.Show("El registro se realizó con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        db.Desconectar()
        Return True
    End Function

    Function GeneraCodigo() As Integer
        Dim strsql As String
        Dim codigo As Integer

        strsql = "SELECT  MAX(CONVERT(INT,RIGHT(codi_exto,4))) AS CCOD FROM T_EXTORNO"
        Dim dato As String = FDB.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            codigo = 1
        Else
            codigo = CInt(dato) + 1
        End If
        Return codigo
    End Function

    Public Function ReporteExtornos(ByVal fdesde As Date, ByVal fhasta As Date) As DataSet
        Dim dset As New DataSet
        Try

            Dim sql As String = "SELECT * " & _
               "FROM V_EXTORNO " & _
               "WHERE fech_exto >= '" + fdesde + "' AND fech_exto <= '" + fhasta + "' " & _
               "ORDER BY fech_exto"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(sql, "V_EXTORNO")
            dset = db.MapeadatasetSP("SP_ENTIDAD_LISTA", "T_ENTIDAD")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function


End Class

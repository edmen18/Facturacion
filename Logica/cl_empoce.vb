Imports System.Data
Imports System.Windows.Forms
Imports Datos

Public Class cl_empoce
    Dim VentaEmpoce As New cl_venta_empoce
    Dim Venta As New cl_venta
    Private _numPapeleta As String
    Private _fecha As Date
    Private _monto As Double
    Private _idCuenta As Integer
    Private _idEmpleado As String
#Region "Propiedades"
    Public Property Empleado() As String
        Get
            Return _idEmpleado
        End Get
        Set(ByVal value As String)
            _idEmpleado = value
        End Set
    End Property

    Public Property Cuenta() As Integer
        Get
            Return _idCuenta
        End Get
        Set(ByVal value As Integer)
            _idCuenta = value
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

    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Public Property NumeroPapeleta() As String
        Get
            Return _numPapeleta
        End Get
        Set(ByVal value As String)
            _numPapeleta = value
        End Set
    End Property
#End Region

    Public Function AgregarEmpoce(ByRef dg As Object) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_EMPOCE_REGISTRA")
        db.AsignarParametrosPA("npa", 0, 3, Me.NumeroPapeleta)
        db.AsignarParametrosPA("fec", 0, 31, Me.Fecha)
        db.AsignarParametrosPA("mon", 0, 5, Me.Monto)
        db.AsignarParametrosPA("cue", 0, 8, Me.Cuenta)
        db.AsignarParametrosPA("usu", 0, 3, Me.Empleado)

        pregunta = MessageBox.Show("Desea continuar con el registro del elemento", "Registros", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pregunta = DialogResult.Yes Then
            Try
                db.EjecutarComando()
            Catch ex As Exception
                MessageBox.Show("Error al insertar" + ex.ToString, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                db.CancelarTransaccion()
                Return False
            End Try
            'Registramos los recibos que conforman el empoce
            Dim i, xRow As Integer
            Dim total As Double = 0

            For i = 0 To dg.RowCount - 1
                xRow = dg.GetVisibleRowHandle(i) 'Esto es por si el grid esta filtrado
                VentaEmpoce.NumPapeleta = Me.NumeroPapeleta
                VentaEmpoce.CodigoVenta = dg.GetRowCellValue(xRow, "CODIGO")

                db.CrearStoreProcedure("SP_VENTA_EMPOCE_REGISTRA")
                db.AsignarParametrosPA("npa", 0, 3, VentaEmpoce.NumPapeleta)
                db.AsignarParametrosPA("cod", 0, 22, VentaEmpoce.CodigoVenta)

                Try
                    db.EjecutarComando()
                Catch ex As Exception
                    MessageBox.Show("Error Alta Orden" + ex.ToString, "TELSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    db.CancelarTransaccion()
                End Try
            Next

        Else
            db.CancelarTransaccion()
            Return False
        End If
        db.ConfirmarTransaccion()
        MessageBox.Show("El registro se realizó con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        db.Desconectar()
        Return True
    End Function

    Public Function Listar_Empoce(ByVal oDgv As Object, ByVal opcion As Integer, Optional ByVal fdesde As Date = #1/11/1984#, Optional ByVal fhasta As Date = #1/11/1984#) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_EMPOCE_LISTA")

            If opcion = 0 Then
                db.AsignarParametrosPA("op", 0, 8, "0")
                db.AsignarParametrosPA("fde", 0, 4, vbNull)
                db.AsignarParametrosPA("fha", 0, 4, vbNull)
            Else
                db.AsignarParametrosPA("op", 0, 8, "1")
                db.AsignarParametrosPA("fde", 0, 4, fdesde)
                db.AsignarParametrosPA("fha", 0, 4, fhasta)
            End If

            Try
                dt.Load(db.EjecutarConsulta())
                oDgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            db.Desconectar()
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            db.CancelarTransaccion()
            db.Desconectar()
            Return False
        End Try
    End Function

    Public Function Listar_Empoce_Detalle(ByVal oDgv As Object) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_EMPOCE_DETALLE_LISTA")
            db.AsignarParametrosPA("npa", 0, 3, Me.NumeroPapeleta)
            Try
                dt.Load(db.EjecutarConsulta())
                oDgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            db.Desconectar()
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            db.CancelarTransaccion()
            db.Desconectar()
            Return False
        End Try
    End Function

    Public Function ReporteEmpoce(ByVal numeroPapeleta As String) As DataSet
        Dim dset As New DataSet
        Try

            Dim sql As String = "SELECT E.nupa_empo, E.fech_empo, E.mont_empo, C.desc_cuen " & _
               "FROM T_CUENTA C " & _
               "INNER JOIN T_EMPOCE E ON C.id_cuen = E.id_cuen " & _
               "WHERE E.nupa_empo = '" + numeroPapeleta + "'"

            Dim sqlDetalle As String = "SELECT * FROM V_EMPOCE_DETALLE " & _
            "WHERE nupa_empo = '" + numeroPapeleta + "'"

            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()

            dset = db.MapeadatasetSP("SP_ENTIDAD_LISTA", "T_ENTIDAD")
            dset = db.Mapeadataset(sql, "V_EMPOCE")
            dset = db.Mapeadataset(sqlDetalle, "V_EMPOCE_DETALLE")

            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function


End Class

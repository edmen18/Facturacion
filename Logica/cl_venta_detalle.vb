Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class cl_venta_detalle
    Private _item As Integer
    Private _codPrd As String
    Private _codUnd As Integer
    Private _cantidad As Double
    Private _valorUni As Decimal
    Private _valorIgv As Decimal
    Private _totIgv As Decimal
    Private _subtotal As Decimal
    Private _total As Decimal
#Region "Propiedades"


    Public Property Total() As Decimal
        Get
            Return _total
        End Get
        Set(ByVal value As Decimal)
            _total = value
        End Set
    End Property

    Public Property Subtotal() As Decimal
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Decimal)
            _subtotal = value
        End Set
    End Property

    Public Property TotalIgv() As Decimal
        Get
            Return _totIgv
        End Get
        Set(ByVal value As Decimal)
            _totIgv = value
        End Set
    End Property


    Public Property ValorIgv() As Decimal
        Get
            Return _valorIgv
        End Get
        Set(ByVal value As Decimal)
            _valorIgv = value
        End Set
    End Property

    Public Property ValorUnitario() As Decimal
        Get
            Return _valorUni
        End Get
        Set(ByVal value As Decimal)
            _valorUni = value
        End Set
    End Property

    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property


    Public Property CodUnidad() As Integer
        Get
            Return _codUnd
        End Get
        Set(ByVal value As Integer)
            _codUnd = value
        End Set
    End Property

    Public Property Producto() As String
        Get
            Return _codPrd
        End Get
        Set(ByVal value As String)
            _codPrd = value
        End Set
    End Property

    Public Property Item() As Integer
        Get
            Return _item
        End Get
        Set(ByVal value As Integer)
            _item = value
        End Set
    End Property

    Private _codVenta As String
    Public Property CodigoVenta() As String
        Get
            Return _codVenta
        End Get
        Set(ByVal value As String)
            _codVenta = value
        End Set
    End Property


#End Region

#Region "Metodos"
    Public Function Listar_Venta_Detalle(ByVal oDgv As Object, ByVal opcion As Integer) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_VENTA_CONSULTA_DETALLE")

            If opcion = 0 Then
                db.AsignarParametrosPA("op", 0, 3, "0")
                db.AsignarParametrosPA("cod", 0, 3, Me.CodigoVenta)

            Else : opcion = 1
                db.AsignarParametrosPA("op", 0, 3, "1")
                db.AsignarParametrosPA("cod", 0, 3, Me.CodigoVenta)
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

    Public Function Listar_Venta_General(ByVal oDgv As Object) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_VENTA_CONSULTA_GENERAL")

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

    Public Function EliminarDetalle(ByVal codigoVenta As String) As Boolean
        'Try
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.ComenzarTransaccion()
        'Elimina el detalle de la venta
        db.CrearStoreProcedure("SP_VENTA_DETALLE_ELIMINA")
        db.AsignarParametrosPA("cod", 0, 3, codigoVenta)

        Try
            db.EjecutarComando()
        Catch ex As Exception
            MessageBox.Show("Error al insertar" + ex.ToString, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            db.CancelarTransaccion()
            Return False
        End Try

        db.ConfirmarTransaccion()
        db.Desconectar()
        Return True
    End Function

    Public Function ConsultaVentaDetalle(ByVal oDgv As Object, ByVal Activas As Integer) As DataSet
        Dim db As BaseDatos = New BaseDatos()
        Dim dset As New DataSet
        Dim dt_ventas As New DataTable("V_REGISTRO_VENTAS")
        Dim dt_detalle As New DataTable("V_INGRESOS_DIARIOS_DETALLADO")

        Try
            Dim sqlHead As String = "SELECT * FROM V_REGISTRO_VENTAS WHERE ESTA_VENT = " & Activas & ""
            Dim sqlDetalle As String = "SELECT * FROM V_DETALLE_VENTA ORDER BY item_veda"
            db.Conectar()

            Try
                db.CrearComando(sqlHead)
                dt_ventas.Load(db.EjecutarConsulta())
                db.CrearComando(sqlDetalle)
                dt_detalle.Load(db.EjecutarConsulta())
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            dset.Tables.Add(dt_ventas)
            dset.Tables.Add(dt_detalle)
            dset.Relations.Add("Detalle", dset.Tables("V_REGISTRO_VENTAS").Columns("codi_vent"), dset.Tables("V_INGRESOS_DIARIOS_DETALLADO").Columns("codi_vent"), False)
            oDgv.DataSource = dt_ventas
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

    Public Function ConsultaVentaDetalleAuditoria(ByVal oDgv As Object, ByVal Activas As Integer) As DataSet
        Dim db As BaseDatos = New BaseDatos()
        Dim dset As New DataSet
        Dim dt_ventas As New DataTable("V_REGISTRO_VENTAS_AUDITORIA")
        Dim dt_detalle As New DataTable("V_INGRESOS_DIARIOS_DETALLADO")

        Try
            Dim sqlHead As String = "SELECT * FROM V_REGISTRO_VENTAS_AUDITORIA WHERE ESTA_VENT = " & Activas & ""
            Dim sqlDetalle As String = "SELECT * FROM V_DETALLE_VENTA ORDER BY item_veda"
            db.Conectar()

            Try
                db.CrearComando(sqlHead)
                dt_ventas.Load(db.EjecutarConsulta())
                db.CrearComando(sqlDetalle)
                dt_detalle.Load(db.EjecutarConsulta())
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            dset.Tables.Add(dt_ventas)
            dset.Tables.Add(dt_detalle)
            dset.Relations.Add("Detalle", dset.Tables("V_REGISTRO_VENTAS_AUDITORIA").Columns("codi_vent"), dset.Tables("V_INGRESOS_DIARIOS_DETALLADO").Columns("codi_vent"), False)
            oDgv.DataSource = dt_ventas
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function


    'Public Function ConsultaVentaDetalle(ByVal oDgv As Object) As DataSet
    '    Dim db As BaseDatos = New BaseDatos()
    '    Dim dset As New DataSet
    '    Dim dt_ventas As New DataTable("V_INGRESOS_HEAD")
    '    Dim dt_detalle As New DataTable("V_INGRESOS_DETALLE")

    '    Dim csqldetalle As String = "SELECT * FROM V_INGRESOS_DETALLE"
    '    Dim csqlcabecera As String = "SELECT * FROM V_INGRESOS_HEAD"
    '    db.Conectar()
    '    Try
    '        dset = db.Mapeadataset(csqlcabecera, "dt_ventas")
    '        dset = db.Mapeadataset(csqldetalle, "dt_detalle")
    '        dset.Relations.Add("Detalle", dset.Tables("dt_ventas").Columns("codi_vent"), dset.Tables("dt_detalle").Columns("codi_vent"), False)
    '        oDgv.datasource = dset.Tables(0)
    '        db.Desconectar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    '    Return dset
    'End Function


#End Region
   
End Class

Imports System.Data
Imports System.Windows.Forms
Imports Datos

Public Class cl_venta

    Private _codigo As String
    Private _cliente As String
    Private _docventa As Integer
    Private _formaPago As Integer
    Private _numDoc As String
    Private _fechaVenta As Date
    Private _horaVenta As DateTime
    Private _subtotal As Decimal
    Private _igv As Decimal
    Private _total As Decimal
    Private _empleado As String
    Private _estado As Byte
    Private _totletra As String
    Private _nota As String

    Dim DetalleVenta As New cl_venta_detalle
    Dim DetallePago As New cl_venta_detalle_pago
    Dim FDB As New cFuncionesDB

#Region "Propiedades"

    Public Property Nota() As String
        Get
            Return _nota
        End Get
        Set(ByVal value As String)
            _nota = value
        End Set
    End Property

    Public Property MontoenLetras() As String
        Get
            Return _totletra
        End Get
        Set(ByVal value As String)
            _totletra = value
        End Set
    End Property

    Public Property Estado() As Byte
        Get
            Return _estado
        End Get
        Set(ByVal value As Byte)
            _estado = value
        End Set
    End Property

    Public Property Empleado() As String
        Get
            Return _empleado
        End Get
        Set(ByVal value As String)
            _empleado = value
        End Set
    End Property

    Public Property TotalVenta() As Decimal
        Get
            Return _total
        End Get
        Set(ByVal value As Decimal)
            _total = value
        End Set
    End Property

    Public Property Igv() As Decimal
        Get
            Return _igv
        End Get
        Set(ByVal value As Decimal)
            _igv = value
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

    Public Property HoraVenta() As DateTime
        Get
            Return _horaVenta
        End Get
        Set(ByVal value As DateTime)
            _horaVenta = value
        End Set
    End Property

    Public Property FechaVenta() As Date
        Get
            Return _fechaVenta
        End Get
        Set(ByVal value As Date)
            _fechaVenta = value
        End Set
    End Property

    Public Property NumeroDocumento() As String
        Get
            Return _numDoc
        End Get
        Set(ByVal value As String)
            _numDoc = value
        End Set
    End Property

    Public Property FormaPago() As Integer
        Get
            Return _formaPago
        End Get
        Set(ByVal value As Integer)
            _formaPago = value
        End Set
    End Property

    Public Property DocumentoVenta() As Integer
        Get
            Return _docventa
        End Get
        Set(ByVal value As Integer)
            _docventa = value
        End Set
    End Property

    Public Property Cliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
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
#End Region

#Region "Metodos"
    Public Function AgregarVenta(ByRef dg As Object) As Boolean
        'Try
        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_VENTA_REGISTRA")
        db.AsignarParametrosPA("cod", 0, 3, Me.Codigo)
        db.AsignarParametrosPA("cli", 0, 3, Me.Cliente)
        db.AsignarParametrosPA("doc", 0, 8, Me.DocumentoVenta)
        db.AsignarParametrosPA("fpa", 0, 8, Me.FormaPago)
        db.AsignarParametrosPA("ndo", 0, 3, Me.NumeroDocumento)
        db.AsignarParametrosPA("fve", 0, 31, Me.FechaVenta)
        db.AsignarParametrosPA("hve", 0, 4, Me.HoraVenta)
        db.AsignarParametrosPA("sub", 0, 5, Me.Subtotal)
        db.AsignarParametrosPA("igv", 0, 5, Me.Igv)
        db.AsignarParametrosPA("tot", 0, 5, Me.TotalVenta)
        db.AsignarParametrosPA("emp", 0, 3, Me.Empleado)
        db.AsignarParametrosPA("est", 0, 1, Me.Estado)
        db.AsignarParametrosPA("let", 0, 22, Me.MontoenLetras)
        db.AsignarParametrosPA("not", 0, 22, Me.Nota)

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

            Dim i, xRow As Integer
            Dim total As Double = 0

            For i = 0 To dg.RowCount - 1
                xRow = dg.GetVisibleRowHandle(i) 'Esto es por si el grid esta filtrado

                DetalleVenta.CodigoVenta = Me.Codigo
                DetalleVenta.Item = i + 1
                DetalleVenta.Producto = dg.GetRowCellValue(xRow, "CODPROD")
                DetalleVenta.CodUnidad = CInt(dg.GetRowCellValue(xRow, "CODUNI"))
                DetalleVenta.Cantidad = CDbl(dg.GetRowCellValue(xRow, "CANTIDAD"))
                DetalleVenta.ValorUnitario = CDbl(dg.GetRowCellValue(xRow, "VALOR"))
                DetalleVenta.ValorIgv = CDbl(dg.GetRowCellValue(xRow, "VALIGV"))
                DetalleVenta.TotalIgv = CDbl(dg.GetRowCellValue(xRow, "TOTIGV"))
                DetalleVenta.Subtotal = CDbl(dg.GetRowCellValue(xRow, "SUBT"))
                DetalleVenta.Total = CDbl(dg.GetRowCellValue(xRow, "TOTAL"))

                db.CrearStoreProcedure("SP_VENTA_DETALLE_REGISTRA")
                db.AsignarParametrosPA("cod", 0, 3, Me.Codigo)
                db.AsignarParametrosPA("ite", 0, 8, DetalleVenta.Item)
                db.AsignarParametrosPA("pro", 0, 3, DetalleVenta.Producto)
                db.AsignarParametrosPA("cun", 0, 8, DetalleVenta.CodUnidad)
                db.AsignarParametrosPA("can", 0, 6, DetalleVenta.Cantidad)
                db.AsignarParametrosPA("vun", 0, 5, DetalleVenta.ValorUnitario)
                db.AsignarParametrosPA("vig", 0, 5, DetalleVenta.ValorIgv)
                db.AsignarParametrosPA("tig", 0, 5, DetalleVenta.TotalIgv)
                db.AsignarParametrosPA("sub", 0, 5, DetalleVenta.Subtotal)
                db.AsignarParametrosPA("tot", 0, 5, DetalleVenta.Total)

                Try
                    db.EjecutarComando()
                Catch ex As Exception
                    MessageBox.Show("Error Alta Orden" + ex.ToString, "TELSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    db.CancelarTransaccion()
                End Try
            Next
            db.ConfirmarTransaccion()
        Else
            db.CancelarTransaccion()
            Return False
        End If

        MessageBox.Show("El registro se realizó con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        db.Desconectar()
        Return True
    End Function

    Public Function ActualizarVenta(ByRef dg As Object) As Boolean
        'Try
        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()

        'Actualiza la venta
        db.CrearStoreProcedure("SP_VENTA_ACTUALIZA")
        db.AsignarParametrosPA("codi_vent", 0, 3, Me.Codigo)
        db.AsignarParametrosPA("codi_clie", 0, 3, Me.Cliente)
        db.AsignarParametrosPA("id_dove", 0, 8, Me.DocumentoVenta)
        db.AsignarParametrosPA("id_fopa", 0, 8, Me.FormaPago)
        db.AsignarParametrosPA("nudo_vent", 0, 3, Me.NumeroDocumento)
        db.AsignarParametrosPA("fech_vent", 0, 31, Me.FechaVenta)
        db.AsignarParametrosPA("hora_vent", 0, 4, Me.HoraVenta)
        db.AsignarParametrosPA("subt_vent", 0, 5, Me.Subtotal)
        db.AsignarParametrosPA("toiv_vent", 0, 5, Me.Igv)
        db.AsignarParametrosPA("tota_vent", 0, 5, Me.TotalVenta)
        db.AsignarParametrosPA("codi_empl", 0, 3, Me.Empleado)
        db.AsignarParametrosPA("esta_vent", 0, 1, Me.Estado)
        db.AsignarParametrosPA("tlet_vent", 0, 22, Me.MontoenLetras)
        db.AsignarParametrosPA("nota_vent", 0, 22, Me.Nota)

        pregunta = MessageBox.Show("Desea continuar actualizando el registro ", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pregunta = DialogResult.Yes Then

            DetalleVenta.EliminarDetalle(Me.Codigo)
            DetallePago.EliminarPago(Me.Codigo)

            Try
                db.EjecutarComando()
            Catch ex As Exception
                MessageBox.Show("Error al insertar" + ex.ToString, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                db.CancelarTransaccion()
                Return False
            End Try

            'Registra el detalle de la venta
            Dim i, xRow As Integer
            Dim total As Double = 0

            For i = 0 To dg.RowCount - 1
                xRow = dg.GetVisibleRowHandle(i) 'Esto es por si el grid esta filtrado

                DetalleVenta.CodigoVenta = Me.Codigo
                DetalleVenta.Item = i + 1
                DetalleVenta.Producto = dg.GetRowCellValue(xRow, "CODPROD")
                DetalleVenta.CodUnidad = CInt(dg.GetRowCellValue(xRow, "CODUNI"))
                DetalleVenta.Cantidad = CDbl(dg.GetRowCellValue(xRow, "CANTIDAD"))
                DetalleVenta.ValorUnitario = CDbl(dg.GetRowCellValue(xRow, "VALOR"))
                DetalleVenta.ValorIgv = CDbl(dg.GetRowCellValue(xRow, "VALIGV"))
                DetalleVenta.TotalIgv = CDbl(dg.GetRowCellValue(xRow, "TOTIGV"))
                DetalleVenta.Subtotal = CDbl(dg.GetRowCellValue(xRow, "SUBT"))
                DetalleVenta.Total = CDbl(dg.GetRowCellValue(xRow, "TOTAL"))

                db.CrearStoreProcedure("SP_VENTA_DETALLE_ACTUALIZA")
                db.AsignarParametrosPA("cod", 0, 3, Me.Codigo)
                db.AsignarParametrosPA("ite", 0, 8, DetalleVenta.Item)
                db.AsignarParametrosPA("pro", 0, 3, DetalleVenta.Producto)
                db.AsignarParametrosPA("cun", 0, 8, DetalleVenta.CodUnidad)
                db.AsignarParametrosPA("can", 0, 6, DetalleVenta.Cantidad)
                db.AsignarParametrosPA("vun", 0, 5, DetalleVenta.ValorUnitario)
                db.AsignarParametrosPA("vig", 0, 5, DetalleVenta.ValorIgv)
                db.AsignarParametrosPA("tig", 0, 5, DetalleVenta.TotalIgv)
                db.AsignarParametrosPA("sub", 0, 5, DetalleVenta.Subtotal)
                db.AsignarParametrosPA("tot", 0, 5, DetalleVenta.Total)

                Try
                    db.EjecutarComando()
                Catch ex As Exception
                    MessageBox.Show("Error Alta Orden" + ex.ToString, "TELSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    db.CancelarTransaccion()
                End Try
            Next
            db.ConfirmarTransaccion()
        Else
            db.CancelarTransaccion()
            Return False
        End If

        MessageBox.Show("El registro se realizó con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        db.Desconectar()
        Return True
    End Function

    Function GeneraCodigo() As Integer
        Dim strsql As String
        Dim codigo As Integer

        strsql = "SELECT  MAX(CONVERT(INT,RIGHT(codi_vent,8))) AS CCOD FROM T_VENTA"
        Dim dato As String = FDB.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            codigo = 1
        Else
            codigo = CInt(dato) + 1
        End If
        Return codigo
    End Function

    Function GeneraNumeroRecibo() As Integer
        Dim strsql As String
        Dim codigo As Integer
        strsql = "SELECT  MAX(CONVERT(INT,(nudo_vent))) AS CCOD FROM dbo.T_VENTA WHERE id_dove = 3"
        Dim dato As String = FDB.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            codigo = 1
        Else
            codigo = CInt(dato) + 1
        End If
        Return codigo
    End Function

    Function VerificaNumeroRecibo(ByVal documento As Integer, ByVal Numero As String) As Boolean
        Dim strsql As String
        strsql = "SELECT nudo_vent FROM T_VENTA WHERE id_dove = " & documento & " and nudo_vent= '" & Numero & "'"
        Dim resultado As String = FDB.ConsultaUnDato(strsql, 0)
        If resultado = "" Then
            Return False
        End If
        MessageBox.Show("Ya se encuentra registrado un documento de ingreso con ese número", "SIF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return True
    End Function

    Public Function ImprimeDvFactura(ByVal CodigoFactura As String) As DataSet
        Dim dset As New DataSet
        Try

            Dim sqlHead As String = "SELECT V.codi_vent, C.nomb_clie,C.dire_clie,C.nudo_clie, DV.desc_dove, V.nudo_vent, " & _
                "V.fech_vent,V.hora_vent,FP.desc_fopa, V.subt_vent,V.toiv_vent,V.tota_vent,V.tlet_vent " & _
               "FROM T_VENTA V " & _
               "INNER JOIN T_CLIENTE C ON C.codi_clie = V.codi_clie " & _
               "INNER JOIN T_DOCUMENTO_VENTA DV ON DV.id_dove = V.id_dove " & _
               "INNER JOIN T_FORMA_PAGO FP ON FP.id_fopa = V.id_fopa " & _
               "WHERE V.codi_vent = '" + CodigoFactura + "'"

            Dim sqlDetalle As String = "SELECT 	VD.item_veda,P.codi_prod,P.nomb_prod,VD.capr_veda,U.abre_unid,VD.vaun_veda,VD.tota_veda " & _
                "FROM T_VENTA_DETALLE VD " & _
                "INNER JOIN T_PRODUCTO P ON P.codi_prod = VD.codi_prod " & _
                "INNER JOIN T_UNIDAD U ON U.codi_unid = VD.codi_unid " & _
                "WHERE VD.codi_vent ='" + CodigoFactura + "'"

            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.MapeadatasetSP("SP_ENTIDAD_LISTA", "T_ENTIDAD")
            dset = db.Mapeadataset(sqlHead, "T_VENTA")
            dset = db.Mapeadataset(sqlDetalle, "T_VENTA_DETALLE")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

    Public Function ImprimeDvRecibo(ByVal CodigoFactura As String) As DataSet
        Dim dset As New DataSet
        Try

            Dim sqlHead As String = "SELECT V.codi_vent, C.nomb_clie,C.dire_clie,C.nudo_clie, DV.desc_dove, V.nudo_vent, " & _
                "V.fech_vent,V.hora_vent,FP.desc_fopa, V.subt_vent,V.toiv_vent,V.tota_vent,V.tlet_vent, V.nota_vent " & _
               "FROM T_VENTA V " & _
               "INNER JOIN T_CLIENTE C ON C.codi_clie = V.codi_clie " & _
               "INNER JOIN T_DOCUMENTO_VENTA DV ON DV.id_dove = V.id_dove " & _
               "INNER JOIN T_FORMA_PAGO FP ON FP.id_fopa = V.id_fopa " & _
               "WHERE V.codi_vent = '" + CodigoFactura + "'"

            Dim sqlDetalle As String = "SELECT 	VD.item_veda,P.codi_prod,P.nomb_prod,VD.capr_veda,U.abre_unid,VD.vaun_veda,VD.tota_veda " & _
                "FROM T_VENTA_DETALLE VD " & _
                "INNER JOIN T_PRODUCTO P ON P.codi_prod = VD.codi_prod " & _
                "INNER JOIN T_UNIDAD U ON U.codi_unid = VD.codi_unid " & _
                "WHERE VD.codi_vent ='" + CodigoFactura + "'"

            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()

            dset = db.MapeadatasetSP("SP_ENTIDAD_LISTA", "T_ENTIDAD")
            dset = db.Mapeadataset(sqlHead, "T_VENTA")
            dset = db.Mapeadataset(sqlDetalle, "T_VENTA_DETALLE")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

    Public Function ReporteIngresosDiarios(ByVal fdesde As Date, ByVal fhasta As Date) As DataSet
        Dim dset As New DataSet
        Try

            Dim sql As String = "SELECT codi_vent, fech_vent, hora_vent, tota_vent " & _
               "FROM T_VENTA " & _
               "WHERE fech_vent >= '" + fdesde + "' AND fech_vent <= '" + fhasta + "' AND esta_vent = 1 " & _
               "ORDER BY fech_vent"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(sql, "V_INGRESOS_DIARIOS")
            dset = db.MapeadatasetSP("SP_ENTIDAD_LISTA", "T_ENTIDAD")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

    Public Function ReporteIngresosDiariosResumen(ByVal fdesde As Date, ByVal fhasta As Date) As DataSet
        Dim dset As New DataSet
        Try

            Dim sql As String = "SELECT DISTINCT TP.desc_tipr AS tipo_producto, SUM(VD.tota_veda) AS total " & _
               "FROM T_VENTA V " & _
               "INNER JOIN T_VENTA_DETALLE VD on V.codi_vent=VD.codi_vent " & _
               "INNER JOIN T_PRODUCTO P on P.codi_prod=VD.codi_prod " & _
               "INNER JOIN T_TIPO_PRODUCTO TP on P.codi_tipr=TP.codi_tipr " & _
               "WHERE fech_vent >= '" + fdesde + "' AND fech_vent <= '" + fhasta + "' AND esta_vent = 1 " & _
               "group by desc_tipr"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(sql, "V_INGRESOS_DIARIOS_RESUMEN")
            dset = db.MapeadatasetSP("SP_ENTIDAD_LISTA", "T_ENTIDAD")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

    Public Function ReporteIngresosDiariosDetallado(ByVal fdesde As Date, ByVal fhasta As Date) As DataSet
        Dim dset As New DataSet
        Try

            Dim sql As String = "SELECT distinct  v.codi_vent, v.nudo_vent, dv.desc_dove,fech_vent, p.nomb_prod, vd.tota_veda, tp.desc_tipr, v.esta_vent " & _
                "FROM T_VENTA AS v INNER JOIN " & _
               "T_VENTA_DETALLE AS vd ON v.codi_vent = vd.codi_vent INNER JOIN " & _
               "T_PRODUCTO AS p ON p.codi_prod = vd.codi_prod INNER JOIN " & _
               "T_TIPO_PRODUCTO AS tp ON p.codi_tipr = tp.codi_tipr INNER JOIN " & _
               "T_DOCUMENTO_VENTA dv ON v.id_dove = dv.id_dove " & _
               "WHERE fech_vent >= '" + fdesde + "' AND fech_vent <= '" + fhasta + "' AND esta_vent = 1 " & _
               "ORDER BY v.fech_vent"

            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(sql, "V_INGRESOS_DIARIOS_DETALLADO")
            dset = db.MapeadatasetSP("SP_ENTIDAD_LISTA", "T_ENTIDAD")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

    Public Function ReporteIngresosDiariosDetallado2(ByVal fdesde As Date, ByVal fhasta As Date) As DataSet
        Dim dset As New DataSet
        Try

            Dim sql As String = "SELECT * FROM V_INGRESOS_DIARIOS_DETALLADO2 WHERE fech_vent >= '" + fdesde + "' AND fech_vent <= '" + fhasta + "' AND esta_vent = 1 ORDER BY fech_vent"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(sql, "V_INGRESOS_DIARIOS_DETALLADO2")
            dset = db.MapeadatasetSP("SP_ENTIDAD_LISTA", "T_ENTIDAD")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

    Public Function ReporteRegistroVentas(ByVal fdesde As Date, ByVal fhasta As Date) As DataSet
        Dim dset As New DataSet
        Try

            Dim sql As String = "SELECT * FROM V_REGISTRO_VENTAS WHERE fech_vent >= '" + fdesde + "' AND fech_vent <= '" + fhasta + "' AND esta_vent = 1 ORDER BY fech_vent"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(sql, "V_REGISTRO_VENTAS")
            dset = db.MapeadatasetSP("SP_ENTIDAD_LISTA", "T_ENTIDAD")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

    Public Function Listar_Venta_Head(ByVal oDgv As Object, ByVal opcion As String, Optional ByVal fdesde As Date = #1/11/1984#, Optional ByVal fhasta As Date = #1/11/1984#) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_VENTA_CONSULTA_HEAD")

            If opcion = 0 Then
                db.AsignarParametrosPA("op", 0, 3, "0")
                db.AsignarParametrosPA("fde", 0, 4, vbNull)
                db.AsignarParametrosPA("fha", 0, 4, vbNull)
            ElseIf opcion = 1 Then
                db.AsignarParametrosPA("op", 0, 3, "1")
                db.AsignarParametrosPA("fde", 0, 4, fdesde)
                db.AsignarParametrosPA("fha", 0, 4, fhasta)
            Else
                db.AsignarParametrosPA("op", 0, 3, "2")
                db.AsignarParametrosPA("fde", 0, 4, vbNull)
                db.AsignarParametrosPA("fha", 0, 4, vbNull)
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

    Public Function Listar_Venta_Empoce_Head(ByVal oDgv As Object, ByVal opcion As Integer, Optional ByVal fdesde As Date = #1/11/1984#, Optional ByVal fhasta As Date = #1/11/1984#) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_VENTA_EMPOCE_CONSULTA_HEAD")

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

    Public Function Listar_Venta_grafico(ByVal oChart As Object, Optional ByVal fdesde As Date = #1/11/1984#, Optional ByVal fhasta As Date = #1/11/1984#) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable

        Dim sql As String = "SELECT DISTINCT TP.desc_tipr AS tipo_producto, SUM(VD.tota_veda) AS total " & _
               "FROM T_VENTA V " & _
               "INNER JOIN T_VENTA_DETALLE VD on V.codi_vent=VD.codi_vent " & _
               "INNER JOIN T_PRODUCTO P on P.codi_prod=VD.codi_prod " & _
               "INNER JOIN T_TIPO_PRODUCTO TP on P.codi_tipr=TP.codi_tipr " & _
               "WHERE fech_vent >= '" + fdesde + "' AND fech_vent <= '" + fhasta + "' AND esta_vent = 1 " & _
               "group by desc_tipr"
        Try
            db.Conectar()
            db.CrearComando(sql)

            Try
                dt.Load(db.EjecutarConsulta())
                oChart.DataSource = dt

                'oChart.SeriesDataMember = "tipo_producto"
                'oChart.SeriesTemplate.ArgumentDataMember = "tipo_producto"
                'oChart.SeriesTemplate.ValueDataMembersSerializable = "total"

                oChart.SeriesTemplate.LabelsVisibility = True
               
                ' Specify the template's name prefix.
                oChart.SeriesNameTemplate.BeginText = "CATEGORIA: "

                'Alineacion de Leyenda
                oChart.Legend.AlignmentHorizontal = 1
                oChart.Legend.AlignmentVertical = 4


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
            Dim sqlHead As String = "SELECT * FROM V_REGISTRO_VENTAS WHERE ESTA_VENT = 1"
            db.Conectar()

            Try
                db.CrearComando(sqlHead)
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


#End Region

End Class

Imports System.Data
Imports System.Windows.Forms
Imports Datos

Public Class cl_producto
    Dim ProductoUnidad As New cl_producto_unidad
    Dim FDB As New cFuncionesDB

    Private _codigo As String
    Private _descripcion As String
    Private _tipoProducto As Integer
    Private _costoProducto As Decimal
    Private _precioProducto As Decimal
    Private _iva As Integer

#Region "Propiedades"
    Public Property Iva() As Integer
        Get
            Return _iva
        End Get
        Set(ByVal value As Integer)
            _iva = value
        End Set
    End Property

    Public Property PrecioProducto() As Decimal
        Get
            Return _precioProducto
        End Get
        Set(ByVal value As Decimal)
            _precioProducto = value
        End Set
    End Property


    Public Property CostoProducto() As Decimal
        Get
            Return _costoProducto
        End Get
        Set(ByVal value As Decimal)
            _costoProducto = value
        End Set
    End Property

    Public Property TipoProducto() As Integer
        Get
            Return _tipoProducto
        End Get
        Set(ByVal value As Integer)
            _tipoProducto = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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
    Public Function AgregarProducto(ByRef LstUnidades As Object) As Boolean
        'Try
        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_PRODUCTO_REGISTRA")
        db.AsignarParametrosPA("cod", 0, 3, Me.Codigo)
        db.AsignarParametrosPA("des", 0, 22, Me.Descripcion)
        db.AsignarParametrosPA("tpr", 0, 8, Me.TipoProducto)
        db.AsignarParametrosPA("cos", 0, 5, Me.CostoProducto)
        db.AsignarParametrosPA("pre", 0, 5, Me.PrecioProducto)
        db.AsignarParametrosPA("iva", 0, 8, Me.Iva)

        pregunta = MessageBox.Show("Desea continuar con el registro del elemento", "Registros", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pregunta = DialogResult.Yes Then
            Try
                db.EjecutarComando()
            Catch ex As Exception
                If ex.Message.Contains("clave duplicada") Then
                    MessageBox.Show("Ya existe un registro con ese código", "SIF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Error al insertar" + ex.ToString, "SIF", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                db.CancelarTransaccion()
                Return False
            End Try

            'Registrar las Unidades dentro de la transacción

            For i = 0 To LstUnidades.CheckedItems.Count - 1
                ProductoUnidad.CodigoProd = Me.Codigo.ToString
                ProductoUnidad.CodigoUnid = LstUnidades.CheckedItems(i).ToString()

                db.CrearStoreProcedure("SP_PRODUCTO_UNIDAD_REGISTRA")
                db.AsignarParametrosPA("pro", 0, 22, ProductoUnidad.CodigoProd)
                db.AsignarParametrosPA("uni", 0, 8, ProductoUnidad.CodigoUnid)

                Try
                    db.EjecutarComando()
                Catch ex As Exception
                    MessageBox.Show("Error " + ex.ToString)
                    db.CancelarTransaccion()
                End Try
            Next

        Else
            db.CancelarTransaccion()
            Return False
        End If
        db.ConfirmarTransaccion()
        MessageBox.Show("El registro se realizó con exito", "SIF", MessageBoxButtons.OK, MessageBoxIcon.Information)
        db.Desconectar()
        Return True
    End Function

    Public Function ActualizarProducto(ByRef LstUnidades As Object) As Boolean

        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_PRODUCTO_EDITA")
        db.AsignarParametrosPA("cod", 0, 3, Me.Codigo)
        db.AsignarParametrosPA("des", 0, 22, Me.Descripcion)
        db.AsignarParametrosPA("tpr", 0, 8, Me.TipoProducto)
        db.AsignarParametrosPA("cos", 0, 6, Me.CostoProducto)
        db.AsignarParametrosPA("pre", 0, 6, Me.PrecioProducto)
        db.AsignarParametrosPA("iva", 0, 8, Me.Iva)

        pregunta = MessageBox.Show("Desea actualizar el registro", "SIF", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pregunta = DialogResult.Yes Then
            Try
                db.EjecutarComando()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar el registro" + ex.ToString, "SIF", MessageBoxButtons.OK, MessageBoxIcon.Error)
                db.CancelarTransaccion()
                Return False
            End Try

            'Eliminar las unidades anteriores
            db.CrearStoreProcedure("SP_PRODUCTO_UNIDAD_ELIMINA")
            db.AsignarParametrosPA("pro", 0, 3, Me.Codigo)

            Try
                db.EjecutarComando()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar el registro" + ex.ToString, "SIF", MessageBoxButtons.OK, MessageBoxIcon.Error)
                db.CancelarTransaccion()
                Return False
            End Try


            'Registrar las Unidades dentro de la transacción

            For i = 0 To LstUnidades.CheckedItems.Count - 1
                ProductoUnidad.CodigoProd = Me.Codigo.ToString
                ProductoUnidad.CodigoUnid = LstUnidades.CheckedItems(i).ToString()

                db.CrearStoreProcedure("SP_PRODUCTO_UNIDAD_REGISTRA")
                db.AsignarParametrosPA("pro", 0, 3, ProductoUnidad.CodigoProd)
                db.AsignarParametrosPA("uni", 0, 8, ProductoUnidad.CodigoUnid)

                Try
                    db.EjecutarComando()
                Catch ex As Exception
                    MessageBox.Show("Error " + ex.ToString)
                    db.CancelarTransaccion()
                End Try
            Next


        Else
            db.CancelarTransaccion()
            Return False
        End If
        db.ConfirmarTransaccion()
        MessageBox.Show("El registro se actualizó con exito", "SIF", MessageBoxButtons.OK, MessageBoxIcon.Information)
        db.Desconectar()
        Return True
    End Function

    Public Function EliminarProducto() As Boolean

        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_PRODUCTO_ELIMINA")
        db.AsignarParametrosPA("cod", 0, 8, Me.Codigo)

        pregunta = MessageBox.Show("Desea eliminar el registro", "Eliminar Cargo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pregunta = DialogResult.Yes Then
            Try
                db.EjecutarComando()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el registro" + ex.ToString, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                db.CancelarTransaccion()
                Return False
            End Try
        Else
            db.CancelarTransaccion()
            Return False
        End If
        db.ConfirmarTransaccion()
        MessageBox.Show("El registro se eliminó con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        db.Desconectar()
        Return True
    End Function

    Public Function Listar_Producto(ByVal oDgv As Object, ByVal opcion As Integer, Optional ByVal NomProducto As String = "") As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_PRODUCTO_LISTA")

            If opcion = 0 Then
                db.AsignarParametrosPA("op", 0, 8, "0")
                db.AsignarParametrosPA("nom", 0, 22, vbNull)
            Else
                db.AsignarParametrosPA("op", 0, 8, "1")
                db.AsignarParametrosPA("nom", 0, 22, NomProducto)
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

    Function GeneraCodigo() As Integer
        Dim strsql As String
        Dim codigo As Integer

        strsql = "SELECT  MAX(CONVERT(INT,RIGHT(codi_prod,8))) AS CCOD FROM T_PRODUCTO"
        Dim dato As String = FDB.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            codigo = 1
        Else
            codigo = CInt(dato) + 1
        End If
        Return codigo
    End Function

    Public Function ReporteProductos() As DataSet
        Dim dset As New DataSet
        Try
            Dim sql As String = "SELECT * FROM V_PRODUCTOS "
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.MapeadatasetSP("SP_ENTIDAD_LISTA", "T_ENTIDAD")
            dset = db.Mapeadataset(sql, "V_PRODUCTOS")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

#End Region

End Class

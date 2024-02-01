Imports System.Data
Imports System.Windows.Forms
Imports Datos

Public Class cl_cliente
    Private _codigo As String
    Private _tipoCliente As Integer
    Private _nombre As String
    Private _direccion As String
    Private _numeroDocumento As String
    Private _telefono As String
    Private _fax As String
    Private _email As String

    Dim FDB As New cFuncionesDB

#Region "Propiedades"


    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property Fax() As String
        Get
            Return _fax
        End Get
        Set(ByVal value As String)
            _fax = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property NumeroDocumento() As String
        Get
            Return _numeroDocumento
        End Get
        Set(ByVal value As String)
            _numeroDocumento = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property TipoCliente() As Integer
        Get
            Return _tipoCliente
        End Get
        Set(ByVal value As Integer)
            _tipoCliente = value
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
    Public Function AgregarCliente() As Boolean
        'Try
        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_CLIENTE_REGISTRA")

        db.AsignarParametrosPA("cod", 0, 22, Me.Codigo)
        db.AsignarParametrosPA("tcl", 0, 8, Me.TipoCliente)
        db.AsignarParametrosPA("nom", 0, 22, Me.Nombre)
        db.AsignarParametrosPA("dir", 0, 22, Me.Direccion)
        db.AsignarParametrosPA("doc", 0, 22, Me.NumeroDocumento)
        db.AsignarParametrosPA("tel", 0, 22, Me.Telefono)
        db.AsignarParametrosPA("mai", 0, 22, Me.Email)
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
        Else
            db.CancelarTransaccion()
            Return False
        End If
        db.ConfirmarTransaccion()
        MessageBox.Show("El registro se realizó con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        db.Desconectar()
        Return True
    End Function

    Public Function ActualizarCliente() As Boolean

        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_CLIENTE_EDITA")
        db.AsignarParametrosPA("cod", 0, 22, Me.Codigo)
        db.AsignarParametrosPA("tcl", 0, 8, Me.TipoCliente)
        db.AsignarParametrosPA("nom", 0, 22, Me.Nombre)
        db.AsignarParametrosPA("dir", 0, 22, Me.Direccion)
        db.AsignarParametrosPA("doc", 0, 22, Me.NumeroDocumento)
        db.AsignarParametrosPA("tel", 0, 22, Me.Telefono)
        db.AsignarParametrosPA("mai", 0, 22, Me.Email)
        pregunta = MessageBox.Show("Desea actualizar el registro", "Registro de Cargos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pregunta = DialogResult.Yes Then
            Try
                db.EjecutarComando()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar el registro" + ex.ToString, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                db.CancelarTransaccion()
                Return False
            End Try
        Else
            db.CancelarTransaccion()
            Return False
        End If
        db.ConfirmarTransaccion()
        MessageBox.Show("El registro se actualizó con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        db.Desconectar()
        Return True
    End Function

    Public Function EliminarCliente() As Boolean

        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_CLIENTE_ELIMINA")
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

    Public Function Listar_Cliente(ByVal oDgv As Object, ByVal opcion As Integer) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_CLIENTE_LISTA")

            If opcion = 0 Then
                db.AsignarParametrosPA("op", 0, 8, "0")
                db.AsignarParametrosPA("nom", 0, 22, vbNull)
            Else
                db.AsignarParametrosPA("op", 0, 8, "1")
                db.AsignarParametrosPA("nom", 0, 22, Nombre)
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

        strsql = "SELECT  MAX(CONVERT(INT,RIGHT(codi_clie,9))) AS CCOD FROM T_CLIENTE"
        Dim dato As String = FDB.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            codigo = 1
        Else
            codigo = CInt(dato) + 1
        End If
        Return codigo
    End Function

    Public Function ReporteClientes() As DataSet
        Dim dset As New DataSet
        Try
            Dim sql As String = "SELECT * FROM V_CLIENTES "
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.MapeadatasetSP("SP_ENTIDAD_LISTA", "T_ENTIDAD")
            dset = db.Mapeadataset(sql, "V_CLIENTES")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

#End Region
End Class

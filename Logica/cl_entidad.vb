Imports Datos
Imports System.Windows.Forms
Public Class cl_entidad

#Region "Variables"
    Private _codigo As Integer
    Private _nombre As String
    Private _ruc As String
    Private _direccion As String
    Private _telefono As String
    Private _email As String
    Private _logo
    Private _anio As String
#End Region

#Region "Propiedades"

    Property Logo()
        Get
            Return _logo
        End Get
        Set(ByVal value)
            _logo = value
        End Set
    End Property


    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
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



    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Public Property Ruc() As String
        Get
            Return _ruc
        End Get
        Set(ByVal value As String)
            _ruc = value
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


    Public Property Codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property


    Public Property Anio() As String
        Get
            Return _anio
        End Get
        Set(ByVal value As String)
            _anio = value
        End Set
    End Property



#End Region

    Public Function AltaEntidad() As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        Try
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearStoreProcedure("SP_ENTIDAD_REGISTRA")
            db.AsignarParametrosPA("cod", 0, 8, Me.Codigo)
            db.AsignarParametrosPA("nom", 0, 22, Me.Nombre)
            db.AsignarParametrosPA("ruc", 0, 3, Me.Ruc)
            db.AsignarParametrosPA("dir", 0, 22, Me.Direccion)
            db.AsignarParametrosPA("tel", 0, 22, Me.Telefono)
            db.AsignarParametrosPA("mail", 0, 22, Me.Email)
            db.AsignarParametrosPA("anio", 0, 22, Me.Anio)
            pregunta = MessageBox.Show("Desea continuar con el registro del elemento", "Registros", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
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
            db.Desconectar()
            MsgBox("Los datos se insertaron correctamente", MsgBoxStyle.Information, "SAB")
            Return True
        Catch ex As Exception
            MessageBox.Show("Error " + ex.ToString, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            db.CancelarTransaccion()
            db.Desconectar()
            Return False
        End Try
    End Function

    Public Function insertarimagen(ByVal i As Byte) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Try
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearStoreProcedure("SP_ENTIDAD_LOGO")
            db.AsignarParametrosPA("id", 0, 8, Me.Codigo)
            db.AsignarParametrosPA("op", 0, 8, "1")
            db.AsignarParametrosPA("E_LOGO", 0, 21, Me.Logo)
            Try
                db.EjecutarComando()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            db.CancelarTransaccion()
            db.Desconectar()
            Return False
        End Try
    End Function

    Public Function Listar_Entidad(ByVal oDgv As Object) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_ENTIDAD_LISTA")
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
End Class

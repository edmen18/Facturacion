Imports Datos
Imports System.Windows.Forms

Public Class cl_auditoria
    Private _id_audi As String
    Private _codi_vent As String
    Private _fech_audi As DateTime
    Private _esta_audi As String
    Private _nota_audi As String
    Private _usuario As String

    Dim FDB As New cFuncionesDB

#Region "Propiedades"

    Public Property Empleado() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property Observacion() As String
        Get
            Return _nota_audi
        End Get
        Set(ByVal value As String)
            _nota_audi = value
        End Set
    End Property

    Public Property EstadoAuditoria() As String
        Get
            Return _esta_audi
        End Get
        Set(ByVal value As String)
            _esta_audi = value
        End Set
    End Property

    Public Property FechaAuditoria() As DateTime
        Get
            Return _fech_audi
        End Get
        Set(ByVal value As DateTime)
            _fech_audi = value
        End Set
    End Property

    Public Property CodigoVenta() As String
        Get
            Return _codi_vent
        End Get
        Set(ByVal value As String)
            _codi_vent = value
        End Set
    End Property

    Public Property Id_Auditoria() As String
        Get
            Return _id_audi
        End Get
        Set(ByVal value As String)
            _id_audi = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Function RegistrarAuditoria() As Boolean
        'Try
        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()

        db.CrearStoreProcedure("SP_AUDITORIA_INSERTAR")
        db.AsignarParametrosPA("id_audi", 0, 3, Me.Id_Auditoria)
        db.AsignarParametrosPA("codi_vent", 0, 22, Me.CodigoVenta)
        db.AsignarParametrosPA("fech_audi", 0, 31, Me.FechaAuditoria)
        db.AsignarParametrosPA("esta_audi", 0, 22, Me.EstadoAuditoria)
        db.AsignarParametrosPA("nota_audi", 0, 22, Me.Observacion)
        db.AsignarParametrosPA("codi_empl", 0, 3, Me.Empleado)


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
        MessageBox.Show("El registro se realizó con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        db.Desconectar()
        Return True
    End Function


    Public Function ActualizaAuditoria() As Boolean
        'Try
        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()

        db.CrearStoreProcedure("SP_AUDITORIA_ACTUALIZA")
        db.AsignarParametrosPA("id_audi", 0, 3, Me.Id_Auditoria)
        db.AsignarParametrosPA("codi_vent", 0, 22, Me.CodigoVenta)
        db.AsignarParametrosPA("fech_audi", 0, 31, Me.FechaAuditoria)
        db.AsignarParametrosPA("esta_audi", 0, 22, Me.EstadoAuditoria)
        db.AsignarParametrosPA("nota_audi", 0, 22, Me.Observacion)
        db.AsignarParametrosPA("codi_empl", 0, 3, Me.Empleado)


        pregunta = MessageBox.Show("Desea continuar con la actualización del registro", "Registros", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pregunta = DialogResult.Yes Then
            Try
                db.EjecutarComando()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar" + ex.ToString, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
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




    Function GeneraCodigo() As Integer
        Dim strsql As String
        Dim codigo As Integer

        strsql = "SELECT  MAX(CONVERT(INT,RIGHT(id_audi,9))) AS CCOD FROM T_AUDITORIA"
        Dim dato As String = FDB.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            codigo = 1
        Else
            codigo = CInt(dato) + 1
        End If
        Return codigo
    End Function

#End Region

End Class

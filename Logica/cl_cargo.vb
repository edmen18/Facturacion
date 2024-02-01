Imports Datos
Imports System.Windows.Forms
Imports System.Data

Public Class cl_cargo

    Private _descripcion As String
    Private _codigo As String

    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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

    Public Function AgregarCargo() As Boolean
        'Try
        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_CARGO_REGISTRA")
        db.AsignarParametrosPA("des", 0, 22, Me.Descripcion)
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

    Public Function ActualizaCargo() As Boolean

        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_CARGO_EDITA")
        db.AsignarParametrosPA("cod", 0, 8, Me.Codigo)
        db.AsignarParametrosPA("des", 0, 22, Me.Descripcion)

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

    Public Function EliminaCargo() As Boolean

        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_CARGO_ELIMINA")
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

    Public Function Listar_Cargos(ByVal oDgv As Object) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_CARGO_LISTA")
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


    Public Function LlenarComboCargo(ByRef oCombo As Object) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_CARGO_LISTA")
            Try
                dt.Load(db.EjecutarConsulta())
                oCombo.Properties.DataSource = dt
                oCombo.Properties.ValueMember = "id_carg"
                oCombo.Properties.DisplayMember = "desc_carg"
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

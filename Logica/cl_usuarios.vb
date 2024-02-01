Imports Datos
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraBars

Public Class cl_usuarios
    Dim FDB As New cFuncionesDB

#Region "Propiedades"
    Private _idUsuario As String
    Public Property IdUsuario() As String
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As String)
            _idUsuario = value
        End Set
    End Property


    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _clave As String
    Public Property Clave() As String
        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
        End Set
    End Property


    Private _esadmin As Boolean
    Public Property EsAdmin() As Boolean
        Get
            Return _esadmin
        End Get
        Set(ByVal value As Boolean)
            _esadmin = value
        End Set
    End Property

    Private _estado As Boolean
    Public Property Estado() As Boolean
        Get
            Return _estado
        End Get
        Set(ByVal value As Boolean)
            _estado = value
        End Set
    End Property
    Private _dni As String
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    Private _cargo As String
    Public Property Cargo() As String
        Get
            Return _cargo
        End Get
        Set(ByVal value As String)
            _cargo = value
        End Set
    End Property

    Private _direccion As String
    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Private _telefono As String
    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

#End Region

    Public Sub ListarModulos(ByRef oDgv As Object)
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable

        db.Conectar()
        db.CrearStoreProcedure("SP_MODULOS_LISTA")
        Try
            dt.Load(db.EjecutarConsulta())

            'For i = 0 To dt.Rows.Count - 1
            '    Dim fila = oDgv.FocusedRowHandle()
            '    oDgv.AddNewRow()
            '    'MsgBox(dt.Rows(i).Item(0).ToString)
            '    oDgv.SetRowCellValue(fila, "id_modu", dt.Rows(i).Item(0).ToString)
            '    oDgv.SetRowCellValue(fila, "nomb_modu", dt.Rows(i).Item(1).ToString)
            '    oDgv.UpdateCurrentRow()
            'Next

            oDgv.DataSource = dt
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            db.CancelarTransaccion()
            db.Desconectar()
        End Try
    End Sub

    Public Function ListarUsuarios(ByVal oDgv As Object, ByVal op As Int16) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_USUARIOS_LISTA")
            db.AsignarParametrosPA("op", 0, 8, op)
            If op = 0 Then
                db.AsignarParametrosPA("usu", 0, 22, vbNull)
                db.AsignarParametrosPA("cla", 0, 22, vbNull)
            ElseIf op = 1 Then
                db.AsignarParametrosPA("usu", 0, 22, Me.Usuario)

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

    Public Function LoginUsuario(ByVal Usuario As String, ByVal Clave As String) As Boolean
        Dim dt As New Data.DataTable
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.CrearStoreProcedure("SP_USUARIOS_LISTA")
        db.AsignarParametrosPA("op", 0, 8, 1)
        db.AsignarParametrosPA("usu", 0, 22, Usuario)
        db.AsignarParametrosPA("cla", 0, 22, Clave)

        Try
            dt.Load(db.EjecutarConsulta())

            If dt.Rows.Count > 0 Then
                Dim UsuarioBd As String = dt.Rows(0).Item(0).ToString
                Dim ClaveBd As String = dt.Rows(0).Item(1).ToString

                If UsuarioBd = Usuario And ClaveBd = Clave Then
                    IdUsuario = dt.Rows(0).Item(2).ToString
                    Nombre = dt.Rows(0).Item(3).ToString
                    EsAdmin = dt.Rows(0).Item(4).ToString
                    'Dni = dt.Rows(0).Item(6).ToString
                    Return True
                End If
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            db.CancelarTransaccion()
            db.Desconectar()
        End Try
        Return False
    End Function

    Public Sub CargaMenu(Rbmenu As Object)
        Dim dt As New DataTable
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.CrearComando("SELECT * FROM T_USUARIO_MODULOS WHERE codi_empl = '" + IdUsuario.ToString + "'")
        Try
            For Each Elemento As Object In Rbmenu.Items
                Dim TipoElemento As Type = Elemento.GetType

                If TipoElemento.FullName = "DevExpress.XtraBars.BarButtonItem" Then
                    Dim BarButton As BarButtonItem = DirectCast(Elemento, BarButtonItem)

                    dt.Load(db.EjecutarConsulta())
                    If dt.Rows.Count > 0 Then
                        For i As Integer = 0 To dt.Rows.Count - 1
                            Dim modulo = dt.Rows(i).Item(1).ToString

                            If BarButton.Tag = modulo Then
                                BarButton.Enabled = True
                                Exit For
                            End If
                        Next
                    End If
                End If
            Next
            db.Desconectar()
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
    End Sub

    Public Function AgregarUsuario() As Boolean
        'Try
        Dim db As BaseDatos = New BaseDatos()
        Dim pregunta As DialogResult
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearStoreProcedure("SP_EMPLEADO_REGISTRA")
        db.AsignarParametrosPA("cod", 0, 3, Me.IdUsuario)
        db.AsignarParametrosPA("nom", 0, 22, Me.Nombre)
        db.AsignarParametrosPA("car", 0, 8, Me.Cargo)
        db.AsignarParametrosPA("tdo", 0, 8, "1")
        db.AsignarParametrosPA("ndo", 0, 3, Me.Dni)
        db.AsignarParametrosPA("dir", 0, 22, Me.Direccion)
        db.AsignarParametrosPA("tel", 0, 22, Me.Telefono)

        db.AsignarParametrosPA("usu", 0, 22, Me.Usuario)
        db.AsignarParametrosPA("cla", 0, 22, Me.Clave)
        db.AsignarParametrosPA("adm", 0, 1, Me.EsAdmin)
        db.AsignarParametrosPA("est", 0, 1, "1")

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

    Function GeneraCodigo() As Integer
        Dim strsql As String
        Dim codigo As Integer

        strsql = "SELECT  MAX(CONVERT(INT,RIGHT(codi_empl,4))) AS CCOD FROM T_EMPLEADO"
        Dim dato As String = FDB.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            codigo = 1
        Else
            codigo = CInt(dato) + 1
        End If
        Return codigo
    End Function

End Class

Imports System.Windows.Forms
Imports Datos

Public Class cl_producto_unidad

    Private _codpro As String
    Private _coduni As Integer
    Public Property CodigoUnid() As Integer
        Get
            Return _coduni
        End Get
        Set(ByVal value As Integer)
            _coduni = value
        End Set
    End Property


    Public Property CodigoProd() As String
        Get
            Return _codpro
        End Get
        Set(ByVal value As String)
            _codpro = value
        End Set
    End Property



    Public Function LlenarComboUnidad(ByVal oCombo As Object, ByVal Producto As String) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_PRODUCTO_UNIDAD_LISTA")
            db.AsignarParametrosPA("cod", 0, 3, Producto)
            Try
                dt.Load(db.EjecutarConsulta())
                oCombo.Properties.DataSource = dt
                oCombo.Properties.ValueMember = "codi_unid"
                oCombo.Properties.DisplayMember = "desc_unid"
                'oCombo.Properties.Columns("id_ticl").Visible = False
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

    Public Function SeleccionaUnidades(ByRef oLista As Object, ByVal Producto As String) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_PRODUCTO_UNIDAD_SELECCIONA")
            db.AsignarParametrosPA("cod", 0, 3, Producto)
            Try
                dt.Load(db.EjecutarConsulta())
                oLista.UnCheckAll()
                oLista.UnSelectAll()
                If dt.Rows.Count > 0 Then
                    For i = 0 To dt.Rows.Count - 1
                        oLista.SetItemChecked(CInt(dt.Rows(i).Item(0)) - 1, True)
                        oLista.SetSelected(CInt(dt.Rows(i).Item(0)) - 1, True)
                    Next
                    db.Desconectar()
                End If
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

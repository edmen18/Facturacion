Imports System.Windows.Forms
Imports Datos

Public Class cl_igv

    Public Function LlenarComboIva(ByRef oCombo As Object) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_IVAS_LISTA")
            Try
                dt.Load(db.EjecutarConsulta())
                oCombo.Properties.DataSource = dt
                oCombo.Properties.ValueMember = "id_iva"
                oCombo.Properties.DisplayMember = "desc_iva"
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

    Public Function ObtenerIgv(ByVal Producto As String) As Double
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Dim valorIgv As Decimal
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_PRODUCTO_IGV_LISTA")
            db.AsignarParametrosPA("cod", 0, 22, Producto)
            Try
                dt.Load(db.EjecutarConsulta())
                If dt.Rows.Count > 0 Then
                    valorIgv = CDec(dt.Rows(0).Item(1).ToString)
                    db.Desconectar()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            db.Desconectar()
            Return valorIgv

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            db.CancelarTransaccion()
            db.Desconectar()
            Return False
        End Try
    End Function
End Class

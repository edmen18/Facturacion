Imports System.Windows.Forms
Imports Datos
Public Class cl_forma_pago
    Public Overloads Function LlenarComboFormaPago(ByRef oCombo As Object) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_FORMA_PAGO_LISTA")
            Try
                dt.Load(db.EjecutarConsulta())
                oCombo.Properties.DataSource = dt
                oCombo.Properties.ValueMember = "id_fopa"
                oCombo.Properties.DisplayMember = "desc_fopa"
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
End Class

Imports Datos
Imports System.Windows.Forms

Public Class cl_motivo_extorno

    Public Function LlenarMotivoExtorno(ByRef oCombo As Object) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_MOTIVO_EXTORNO_LISTA")
            Try
                dt.Load(db.EjecutarConsulta())
                oCombo.Properties.DataSource = dt
                oCombo.Properties.ValueMember = "id_moex"
                oCombo.Properties.DisplayMember = "desc_moex"
                'oCombo.Properties.Columns.Add(New LookUpColumnInfo("CategoryName", 0, "Category Name"))

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

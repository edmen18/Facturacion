'Imports System.Data
Imports System.Windows.Forms
Imports Datos

Public Class cl_documento_venta

    Public Function LlenarComboDocumentoVenta(ByRef oCombo As Object) As Boolean
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_DOCUMENTO_VENTA_LISTA")
            Try
                dt.Load(db.EjecutarConsulta())
                oCombo.Properties.DataSource = dt
                oCombo.Properties.ValueMember = "id_dove"
                oCombo.Properties.DisplayMember = "desc_dove"
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

    Public Function ObtenerFormatoDocumento(ByVal DocumentoVenta As Integer) As String
        Dim db As BaseDatos = New BaseDatos()
        Dim dt As New Data.DataTable
        Dim formato As String
        Try
            db.Conectar()
            db.CrearStoreProcedure("SP_DOCUMENTO_VENTA_FORMATO")
            db.AsignarParametrosPA("cod", 0, 8, DocumentoVenta)
            Try
                dt.Load(db.EjecutarConsulta())
                If dt.Rows.Count > 0 Then
                    formato = dt.Rows(0).Item(0).ToString
                    db.Desconectar()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            db.Desconectar()
            Return formato

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            db.CancelarTransaccion()
            db.Desconectar()
            Return False
        End Try
    End Function

End Class

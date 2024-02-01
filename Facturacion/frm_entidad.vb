Imports Logica

Public Class frm_entidad
    Dim Entidad As New cl_entidad

    Private Sub btnRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrar.Click
        Entidad.Codigo = Me.txtCodigo.EditValue
        Entidad.Nombre = Me.txtNombre.EditValue
        Entidad.Ruc = Me.txtRuc.EditValue
        Entidad.Direccion = Me.txtDireccion.EditValue
        Entidad.Telefono = Me.txtTelefono.EditValue
        Entidad.Email = Me.txtEmail.EditValue
        Entidad.Anio = Me.txtAnio.EditValue
        Entidad.AltaEntidad()

    End Sub

    Private Sub frm_entidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Entidad.Listar_Entidad(dgvEntidad)
    End Sub

    Private Sub btnExaminar_Click(sender As System.Object, e As System.EventArgs) Handles btnExaminar.Click
        With OpenFD
            .InitialDirectory = ""
            .FileName = "Todos los Archivos"
            .Filter = "Todos los Archivos|*.*|JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp"
            .FilterIndex = 2
        End With
        If OpenFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With picLogo
                .Image = Image.FromFile(OpenFD.FileName)
                .SizeMode = PictureBoxSizeMode.CenterImage
                .BorderStyle = BorderStyle.Fixed3D
            End With
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Entidad.Codigo = Me.txtCodigo.EditValue
        Entidad.Logo = SetearImagen(Me.picLogo)
        Entidad.insertarimagen(1)
    End Sub


    Private Sub dgvEntidad_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvEntidad.DoubleClick
        'Try
        '    Me.PictureEdit1.Image = ObtenerItemDevGrid("logo_enti", gvEntidad)
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

    End Sub


End Class
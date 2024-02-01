Imports System.Security.Cryptography
Imports System.Text
Imports DevExpress.XtraBars



Module Mo_funciones

    Public Function ObtenerObjetoTabla(ByVal pos As Integer, ByVal dtgr As DataGridView) As Object
        Dim i As Integer
        With dtgr
            For i = 0 To .RowCount - 1
                If .Item(0, i).Selected Then
                    Return .Item(pos, i).Value
                End If
            Next
            Return Nothing
        End With
    End Function

    Public Function ObtenerItemGrid(ByVal item As Integer, ByRef dg As DataGridView) As Object
        If dg.RowCount > 0 Then
            'dg.Select()
            Dim i As Integer = dg.CurrentRow.Index
            Try
                If Not IsDBNull(dg.Item(item, i).Value) Then
                    Return dg.Item(item, i).Value
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Return Nothing
            End Try
        End If
        Return Nothing
    End Function

    Public Function ObtenerItemDevGrid(ByVal columna As String, ByRef dg As Object) As Object
        Try
            Return dg.GetRowCellValue(dg.FocusedRowHandle, columna)
        Catch ex As Exception
            Return Nothing
        End Try

        Return Nothing
    End Function

    Public Function ObtenerItemVerticalGrid(ByVal columna As Object, ByRef vg As Object) As Object
        Try
            Return vg.GetCellValue(columna, vg.FocusedRecord)



            'Dim fila = vgcEmpleados.FocusedRecord
            'Dim nom As String
            'nom = vgcEmpleados.GetCellValue(rownomb_empl, fila).ToString


        Catch ex As Exception
            Return Nothing
        End Try

        Return Nothing
    End Function

    Public Function BuscarDuplicado(ByVal datoBuscar As String, ByRef Grilla As Object, ByVal Columna As String) As Boolean

        Dim i As Integer = 0
        Dim CuantasVecesExiste As Integer = 0
        Dim xrow As Integer

        For i = 0 To Grilla.RowCount - 1
            xrow = Grilla.GetVisibleRowHandle(i)
            If Grilla.GetRowCellValue(xrow, Columna) = datoBuscar Then
                CuantasVecesExiste = CuantasVecesExiste + 1
                If CuantasVecesExiste > 0 Then
                    BuscarDuplicado = True
                    Exit Function
                Else
                    BuscarDuplicado = False
                End If
            Else
                BuscarDuplicado = False
            End If
        Next
        Return Nothing
    End Function

    Public Function ObtenerItemGridImagen(ByVal item As Integer, ByRef dg As DataGridView) As Object
        If dg.RowCount > 0 Then
            Dim i As Integer = dg.CurrentRow.Index
            Try
                Dim ms As New System.IO.MemoryStream
                If Not IsDBNull(dg.Item(item, i).Value) Then
                    Dim bits As Byte() = CType(dg.Item(item, i).Value, Byte())
                    ms = New System.IO.MemoryStream(bits)
                    Return Image.FromStream(ms)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Return Nothing
            End Try
        End If
        Return Nothing
    End Function

    Public Function ObtenerItemGridImagen(ByVal columna As Integer, ByRef dg As Object) As Object
        If dg.RowCount > 0 Then
            'dg.Select()

            Try
                Dim iCeldaImagen As Object = dg.GetRowCellValue(dg.FocusedRowHandle, columna)
                Dim ms As New System.IO.MemoryStream

                If Not dg.GetRowCellValue(iCeldaImagen) Then

                    Dim bits As Byte() = CType(iCeldaImagen.value, Byte())
                    ms = New System.IO.MemoryStream(bits)
                    Return Image.FromStream(ms)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Return Nothing
            End Try
        End If
        Return Nothing
    End Function

    Public Function SetearImagen(ByRef PicImagen As PictureBox)

        If Not PicImagen.Image Is Nothing Then
            Dim oStream As New IO.MemoryStream()
            PicImagen.Image.Save(oStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim oBytes(oStream.Length - 1) As Byte
            oStream.Position = 0
            oStream.Read(oBytes, 0, Convert.ToInt32(oStream.Length))
            oStream.Close()
            Return oBytes
        End If
        Return Nothing
    End Function

    Public Function getMd5Hash(ByVal input As String) As String
        Dim md5Hasher As New MD5CryptoServiceProvider()
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function

    Public Function SHA1(ByVal strToHash As String) As String
        Using sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider()
            Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
            bytesToHash = sha1Obj.ComputeHash(bytesToHash)
            Dim strResult As String = ""
            For Each b As Byte In bytesToHash
                strResult += b.ToString("x2")
            Next
            Return strResult
        End Using
    End Function


    'Limpiar textbox de form devexpress
    Public Sub Limpiar_TextBox(ByVal controls As Control)
        For Each control As Control In controls.Controls
            If TypeOf control Is DevExpress.XtraEditors.TextEdit Then
                control.Text = ""
            End If
        Next
    End Sub

    Sub Limpiar(ByVal obj As Control)

        For Each obj In obj.Controls
            If TypeOf (obj) Is DevExpress.XtraEditors.TextEdit Then
                obj.Text = ""
            End If
        Next
    End Sub

    Sub Habilitar_Controles(ByVal obj As Control)

        For Each obj In obj.Controls
            If TypeOf (obj) Is DevExpress.XtraEditors.TextEdit Then
                obj.Enabled = True
            End If

            If TypeOf (obj) Is DevExpress.XtraEditors.LookUpEdit Then
                obj.Enabled = True
            End If

        Next
    End Sub

    Sub Deshabilitar_Controles(ByVal obj As Control)

        For Each obj In obj.Controls
            If TypeOf (obj) Is DevExpress.XtraEditors.TextEdit Then
                obj.Enabled = False
            End If

            If TypeOf (obj) Is DevExpress.XtraEditors.LookUpEdit Then
                obj.Enabled = False
            End If

        Next
    End Sub


End Module




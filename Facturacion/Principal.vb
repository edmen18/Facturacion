Imports Logica
Imports Reportes
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon
Imports System.Threading
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors


Public Class Principal
    Dim Unidad As New cl_unidad
    Dim DocumentoVenta As New cl_venta
    Dim Extorno As New cl_extorno
    Dim Usuarios As New cl_usuarios
    Dim Imprimir As New C_imprime
    Dim Settings As New My.MySettings

    Public f_hatas As String

    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        initSkinGallery()
        IniciarValores()
        DatosUsuario()
        btnGraficoIngresos.Enabled = False
    End Sub


    Private Sub initSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub

    Sub GestionarPanel()
        If tmdiManager.Pages.Count = 0 Then
            ClientPanel.Visible = True
        Else
            ClientPanel.Visible = False
        End If
    End Sub

    Sub Mostrarform_Modal(ByRef frm As Form)
        With frm
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
            .Focus()
        End With
    End Sub
    Public Sub Mostrarform(ByRef frm As Form)
        With frm
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub tmdiManager_PageAdded(sender As System.Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles tmdiManager.PageAdded
        GestionarPanel()
    End Sub

    Private Sub tmdiManager_PageRemoved(sender As System.Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles tmdiManager.PageRemoved
        GestionarPanel()
    End Sub

    Private Sub tbCargos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbCargos.ItemClick
        Mostrarform_Modal(frm_cargos)
    End Sub

    Private Sub tbBanco_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbBanco.ItemClick
        Mostrarform_Modal(frm_banco)
    End Sub

    Private Sub tbTipoProducto_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbTipoProducto.ItemClick
        Mostrarform_Modal(frm_tipo_producto)
    End Sub

    Private Sub tbUnidad_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbUnidad.ItemClick
        Mostrarform_Modal(frm_unidad)
    End Sub

    Private Sub tbClientes_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbClientes.ItemClick
        Mostrarform(frm_clientes)
    End Sub

    Private Sub tbArticulos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbArticulos.ItemClick
        Mostrarform(frm_articulo)
    End Sub

    Private Sub btnFacturacion_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFacturacion.ItemClick
        Mostrarform(frm_venta)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnListarUnidades.ItemClick
        Dim cr As New xrc_unidad
        Imprimir.reporteIntegrado(Unidad.ImprimeUnidades(), cr, "Listado de Unidades", Me)
    End Sub


    Private Sub btnEntidad_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEntidad.ItemClick
        Mostrarform(frm_entidad)
    End Sub


    Private Sub Principal_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Thread.Sleep(5000)
        'UserLookAndFeel.Default.SkinName = Settings.Skin
    End Sub

    Sub IniciarValores()
        Me.dtpDesde.EditValue = Date.Today
        Me.dtpHasta.EditValue = Date.Today

        Me.dtpInicio.EditValue = Date.Today
        Me.dtpFin.EditValue = Date.Today
    End Sub

    Private Sub btnMaestroDetalle_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMaestroDetalle.ItemClick
        Mostrarform(frm_venta_detalle)
    End Sub

    Private Sub btnEmpozar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmpozar.ItemClick
        Mostrarform(frm_empoce_registra)
    End Sub


    Private Sub btnConsultaEmpoce_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultaEmpoce.ItemClick
        Mostrarform(frm_empoce_consulta)
    End Sub

    Private Sub btnExtornar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExtornar.ItemClick
        'Instanciar el formulario de inicio de sesion
        Using FormInicioSesion As New frm_login
            FormInicioSesion.ShowDialog()
            If FormInicioSesion.DialogResult = Windows.Forms.DialogResult.OK Then
                'DatosUsuario()
                Mostrarform(frm_extrorno_consulta)
            End If
        End Using
    End Sub

    Private Sub btnIngresos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIngresos.ItemClick
        If Me.cmbRepIngresos.EditValue = "" Then
            MessageBox.Show("Debe Seleccionar un tipo de informe", "SIF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If cmbRepIngresos.EditValue.Equals("Resumen") Then
            Dim repIngresos As New xrc_ingresos_diarios_resumen

            repIngresos.pfecha_de.Value = Me.dtpDesde.EditValue
            repIngresos.pfecha_de.Visible = False

            repIngresos.pfecha_al.Value = Me.dtpHasta.EditValue
            repIngresos.pfecha_al.Visible = False

            Imprimir.reporteIntegrado(DocumentoVenta.ReporteIngresosDiariosResumen(dtpDesde.EditValue, dtpHasta.EditValue), repIngresos, "Listado de ingresos diarios", Me)
        ElseIf cmbRepIngresos.EditValue.Equals("General") Then
            Dim repIngresos As New xrc_ingresos_diarios
            Imprimir.reporteIntegrado(DocumentoVenta.ReporteIngresosDiarios(dtpDesde.EditValue, dtpHasta.EditValue), repIngresos, "Listado de ingresos diarios", Me)
        ElseIf cmbRepIngresos.EditValue.Equals("Detallado") Then
            Dim repIngresos As New xrc_ingresos_diarios_detallado2

            repIngresos.pfecha_del.Value = Me.dtpDesde.EditValue
            repIngresos.pfecha_del.Visible = False

            repIngresos.pfecha_al.Value = Me.dtpHasta.EditValue
            repIngresos.pfecha_al.Visible = False
            Imprimir.reporteIntegrado(DocumentoVenta.ReporteIngresosDiariosDetallado2(dtpDesde.EditValue, dtpHasta.EditValue), repIngresos, "Listado de ingresos detallado", Me)
        Else
            Dim repRegistroVentas As New xrc_registro_ventas
            repRegistroVentas.pfecha_del.Value = Me.dtpDesde.EditValue
            repRegistroVentas.pfecha_del.Visible = False

            repRegistroVentas.pfecha_al.Value = Me.dtpHasta.EditValue
            repRegistroVentas.pfecha_al.Visible = False
            Imprimir.reporteIntegrado(DocumentoVenta.ReporteRegistroVentas(dtpDesde.EditValue, dtpHasta.EditValue), repRegistroVentas, "Registro de ventas", Me)
        End If
    End Sub

    Private Sub btnCambiarUsuairio_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCambiarUsuairio.ItemClick
        If XtraMessageBox.Show("Esta seguro de cambiar de usuario?", "SIF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim Formularios() As Form
                Formularios = Me.MdiChildren

                For Each Formulario In Formularios
                    Formulario.Close()
                Next
            Catch ex As Exception
            End Try

            HabilitarMenu(False)
            btnCambiarUsuairio.Enabled = True
            btnSalir.Enabled = True
            bsUsuario.Caption = "NO HAY SESION ACTIVA"

            'Instanciar el formulario de inicio de sesion
            Using FormInicioSesion As New frm_login
                FormInicioSesion.ShowDialog()
                If FormInicioSesion.DialogResult = Windows.Forms.DialogResult.OK Then
                    DatosUsuario()
                End If
            End Using
        End If
    End Sub

    Private Sub Principal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If XtraMessageBox.Show("Desea abandonar el Sistema", "SIF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
        SaveDefaultSkin()
    End Sub

    Private Sub btnSalir_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub


#Region "Permisos"
    Private Sub HabilitarMenu(ByVal Habilitar As Boolean)
        For Each Elemento As Object In RibbonControl.Items
            Dim TipoElemento As Type = Elemento.GetType

            If TipoElemento.FullName = "DevExpress.XtraBars.BarButtonItem" Then
                Dim BarButton As BarButtonItem = DirectCast(Elemento, BarButtonItem)

                If Habilitar Then
                    BarButton.Enabled = True
                Else
                    BarButton.Enabled = False
                End If
            End If
        Next
    End Sub


    Private Sub DatosUsuario()
        Try
            If UsuarioActivo.EsAdmin Then
                HabilitarMenu(True)
            Else
                HabilitarMenu(False)
                Usuarios.IdUsuario = UsuarioActivo.IdUsuario
                Usuarios.CargaMenu(RibbonControl)
            End If
            bsUsuario.Caption = String.Format("{0} - {1}", UsuarioActivo.IdUsuario, UsuarioActivo.Nombre)
            'bsUsuario.Caption = UsuarioActivo.Nombre
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub btnUsuarios_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUsuarios.ItemClick
        Mostrarform(frm_empleado)
    End Sub

    Private Sub btnImprimirExtornos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImprimirExtornos.ItemClick
        Dim repExtornos As New xrc_extornos
        repExtornos.pfecha_de.Value = Me.dtpInicio.EditValue
        repExtornos.pfecha_de.Visible = False

        repExtornos.pfecha_al.Value = Me.dtpFin.EditValue
        repExtornos.pfecha_al.Visible = False

        Imprimir.reporteIntegrado(Extorno.ReporteExtornos(dtpInicio.EditValue, dtpFin.EditValue), repExtornos, "Listado de Extornos", Me)
    End Sub

    Private Sub btnAcerca_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAcerca.ItemClick
        Mostrarform_Modal(frm_acerca)
    End Sub

    Private Sub btnConsultaExtorno_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultaExtorno.ItemClick
        Mostrarform(frm_venta_anulada)
    End Sub

    Private Sub btnEditarVenta_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditarVenta.ItemClick

        Using FormInicioSesion As New frm_login
            FormInicioSesion.ShowDialog()
            If FormInicioSesion.DialogResult = Windows.Forms.DialogResult.OK Then
                'DatosUsuario()
                Mostrarform(frm_venta_editar)
            End If
        End Using

    End Sub

    Private Sub btnBanco_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBanco.ItemClick
        Mostrarform_Modal(frm_banco)
    End Sub


    Private Sub BarButtonItem1_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Mostrarform(frm_venta_consulta)
    End Sub
    Private Sub btnConvertir_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConvertir.ItemClick
        Mostrarform_Modal(frm_convertidor)
    End Sub


    Private Sub btnSowReport_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSowReport.ItemClick
        Dim Clientes As New cl_cliente
        Dim Produtos As New cl_producto

        If Me.cmbListados.EditValue = "" Then
            MessageBox.Show("Debe Seleccionar un tipo de informe", "SIF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If cmbListados.EditValue.Equals("Clientes") Then
            Dim repClientes As New xrc_clientes
            Imprimir.reporteIntegrado(Clientes.ReporteClientes(), repClientes, "Listado de Clientes", Me)
        ElseIf cmbListados.EditValue.Equals("Productos") Then
            Dim repProductos As New xrc_productos
            Imprimir.reporteIntegrado(Produtos.ReporteProductos(), repProductos, "Listado de Productos", Me)
        Else
            MessageBox.Show("Informe de Proveedores aun no implementado", "SIF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub

    Private Sub btnCopiaBd_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCopiaBd.ItemClick
        Mostrarform_Modal(frm_backup)
    End Sub

    Private Sub btnRestauraBd_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRestauraBd.ItemClick
        MessageBox.Show("Función no implementada", "SIF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub SelectFirstMergedPage()
        If RibbonControl.MergedCategories.Count > 0 Then
            RibbonControl.SelectedPage = RibbonControl.MergedCategories(0).Pages(0)
        Else
            RibbonControl.SelectedPage = RibbonControl.MergedPages(0)
        End If
    End Sub

    Private Sub RibbonControl_Merge(sender As Object, e As DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs) Handles RibbonControl.Merge
        SelectFirstMergedPage()
    End Sub

    Private Sub cmbRepIngresos_EditValueChanged(sender As Object, e As System.EventArgs) Handles cmbRepIngresos.EditValueChanged
        If cmbRepIngresos.EditValue.Equals("Resumen") Then
            btnGraficoIngresos.Enabled = True
        Else
            btnGraficoIngresos.Enabled = False
        End If
    End Sub

    Private Sub btnGraficoIngresos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGraficoIngresos.ItemClick
        fdesde = dtpDesde.EditValue
        fhasta = dtpHasta.EditValue
        Mostrarform(frm_grafico_ingresos)
    End Sub

    Private Sub SaveDefaultSkin()
        Settings.Skin = String.Format("{0}", UserLookAndFeel.Default.ActiveSkinName)
        Settings.Save()
    End Sub

    Private Sub btnAuditoria_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAuditoria.ItemClick
        Mostrarform(frm_venta_consulta_auditoria)
    End Sub

    Private Sub btnImportar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnImportar.ItemClick
        Mostrarform(frm_clientes_importar)

    End Sub
End Class
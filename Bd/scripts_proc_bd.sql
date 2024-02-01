USE [DB_FACTURACION]
GO
/****** Object:  StoredProcedure [dbo].[SP_EMPOCE_DETALLE_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_EMPOCE_DETALLE_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_EMPOCE_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_EMPOCE_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_EXTORNO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_EXTORNO_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_CONSULTA_DETALLE]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_CONSULTA_DETALLE]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_CONSULTA_HEAD]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_CONSULTA_HEAD]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_ACTUALIZA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_DETALLE_ACTUALIZA]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_DETALLE_ELIMINA]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_PAGO_ACTUALIZA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_DETALLE_PAGO_ACTUALIZA]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_PAGO_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_DETALLE_PAGO_ELIMINA]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_PAGO_EXTORNA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_DETALLE_PAGO_EXTORNA]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_PAGO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_DETALLE_PAGO_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_DETALLE_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DOCUMENTO_DETALLE]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_DOCUMENTO_DETALLE]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_EMPOCE_CONSULTA_HEAD]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_EMPOCE_CONSULTA_HEAD]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_EMPOCE_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_EMPOCE_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DOCUMENTO_HEAD]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_DOCUMENTO_HEAD]
GO
/****** Object:  StoredProcedure [dbo].[SP_USUARIOS_ASIGNA_PERMISOS]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_USUARIOS_ASIGNA_PERMISOS]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_ACTUALIZA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_ACTUALIZA]
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_ANULADA_CONSULTA_HEAD]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_VENTA_ANULADA_CONSULTA_HEAD]
GO
/****** Object:  StoredProcedure [dbo].[SP_EMPOCE_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_EMPOCE_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_UNIDAD_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_PRODUCTO_UNIDAD_ELIMINA]
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_UNIDAD_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_PRODUCTO_UNIDAD_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_UNIDAD_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_PRODUCTO_UNIDAD_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_UNIDAD_SELECCIONA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_PRODUCTO_UNIDAD_SELECCIONA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE_EDITA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_CLIENTE_EDITA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_CLIENTE_ELIMINA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_CLIENTE_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_CLIENTE_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_USUARIOS_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_USUARIOS_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_EDITA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_PRODUCTO_EDITA]
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_PRODUCTO_ELIMINA]
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_IGV_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_PRODUCTO_IGV_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_PRODUCTO_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_PRODUCTO_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_EMPLEADO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_EMPLEADO_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CUENTA_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_CUENTA_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CUENTA_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_CUENTA_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_DOCUMENTO_VENTA_FORMATO]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_DOCUMENTO_VENTA_FORMATO]
GO
/****** Object:  StoredProcedure [dbo].[SP_DOCUMENTO_VENTA_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_DOCUMENTO_VENTA_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_BANCO_EDITA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_BANCO_EDITA]
GO
/****** Object:  StoredProcedure [dbo].[SP_BANCO_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_BANCO_ELIMINA]
GO
/****** Object:  StoredProcedure [dbo].[SP_BANCO_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_BANCO_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_BANCO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_BANCO_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGO_EDITA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_CARGO_EDITA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGO_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_CARGO_ELIMINA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGO_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_CARGO_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_CARGO_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_PROVEEDORES_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_PROVEEDORES_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_TIPO_CLIENTE_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_TIPO_CLIENTE_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_TIPO_PRODUCTO_EDITA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_TIPO_PRODUCTO_EDITA]
GO
/****** Object:  StoredProcedure [dbo].[SP_TIPO_PRODUCTO_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_TIPO_PRODUCTO_ELIMINA]
GO
/****** Object:  StoredProcedure [dbo].[SP_TIPO_PRODUCTO_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_TIPO_PRODUCTO_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_TIPO_PRODUCTO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_TIPO_PRODUCTO_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD_EDITA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_UNIDAD_EDITA]
GO
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_UNIDAD_ELIMINA]
GO
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_UNIDAD_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_UNIDAD_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_ENTIDAD_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_ENTIDAD_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_ENTIDAD_LOGO]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_ENTIDAD_LOGO]
GO
/****** Object:  StoredProcedure [dbo].[SP_ENTIDAD_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_ENTIDAD_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_FORMA_PAGO_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_FORMA_PAGO_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_FORMA_PAGO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_FORMA_PAGO_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_IVAS_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_IVAS_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_IVAS_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_IVAS_REGISTRA]
GO
/****** Object:  StoredProcedure [dbo].[SP_MOTIVO_EXTORNO_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
DROP PROCEDURE [dbo].[SP_MOTIVO_EXTORNO_LISTA]
GO
/****** Object:  StoredProcedure [dbo].[SP_MOTIVO_EXTORNO_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_MOTIVO_EXTORNO_LISTA]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM T_MOTIVO_EXTORNO

END
GO
/****** Object:  StoredProcedure [dbo].[SP_IVAS_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_IVAS_REGISTRA]
	-- Add the parameters for the stored procedure here
@des varchar(30),
@val decimal(4,4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_IVAS (desc_iva,valo_iva)
VALUES(@des,@val)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_IVAS_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_IVAS_LISTA]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM T_IVAS

END
GO
/****** Object:  StoredProcedure [dbo].[SP_FORMA_PAGO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_FORMA_PAGO_REGISTRA]
	-- Add the parameters for the stored procedure here
@des varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_FORMA_PAGO(desc_fopa)
	VALUES (@des)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_FORMA_PAGO_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_FORMA_PAGO_LISTA]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM T_FORMA_PAGO

END
GO
/****** Object:  StoredProcedure [dbo].[SP_ENTIDAD_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Fabian Ramirez
-- Create date: 25/08/2012
-- Description:	INSERTAR REGISTRO EN TABLA ENTIDAD
-- =============================================
CREATE PROCEDURE [dbo].[SP_ENTIDAD_REGISTRA] 
	-- Add the parameters for the stored procedure here
@cod int,
@nom varchar(max),
@ruc char(12),
@dir varchar(max),
@tel varchar(20),
@mail varchar(max),
@anio varchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_ENTIDAD (codi_enti,nomb_enti,ruc_enti,dire_enti,tele_enti,emai_enti,anio_enti) VALUES (@cod,@nom,@ruc,@dir,@tel,@mail,@anio)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ENTIDAD_LOGO]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ENTIDAD_LOGO] @id int, @E_LOGO image, @op bit
 AS
begin
 if @op=1 
    update T_ENTIDAD set logo_enti=@E_LOGO where codi_enti=@id 
 if @op=0 
    update T_ENTIDAD set logo_enti=null where codi_enti=@id 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ENTIDAD_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_ENTIDAD_LISTA]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT nomb_enti,ruc_enti,dire_enti,tele_enti,emai_enti,logo_enti FROM T_ENTIDAD

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_UNIDAD_REGISTRA]
	-- Add the parameters for the stored procedure here
@des varchar(60),
@abr varchar(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	INSERT INTO T_UNIDAD
	VALUES (@des,@abr)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_UNIDAD_LISTA]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM T_UNIDAD

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_UNIDAD_ELIMINA]
	-- Add the parameters for the stored procedure here
@cod int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DELETE FROM T_UNIDAD WHERE codi_unid = @cod 


END
GO
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD_EDITA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_UNIDAD_EDITA]
	-- Add the parameters for the stored procedure here
@cod int,
@des varchar(30),
@abr varchar(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE T_UNIDAD 
	SET
	desc_unid = @des, 
	abre_unid = @abr
	WHERE 
	codi_unid = @cod 

END
GO
/****** Object:  StoredProcedure [dbo].[SP_TIPO_PRODUCTO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_TIPO_PRODUCTO_REGISTRA]
	-- Add the parameters for the stored procedure here
@des varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_TIPO_PRODUCTO(desc_tipr)
	VALUES (@des)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_TIPO_PRODUCTO_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_TIPO_PRODUCTO_LISTA]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM T_TIPO_PRODUCTO

END
GO
/****** Object:  StoredProcedure [dbo].[SP_TIPO_PRODUCTO_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_TIPO_PRODUCTO_ELIMINA]
	-- Add the parameters for the stored procedure here
@cod int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DELETE FROM T_TIPO_PRODUCTO WHERE codi_tipr = @cod 


END
GO
/****** Object:  StoredProcedure [dbo].[SP_TIPO_PRODUCTO_EDITA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_TIPO_PRODUCTO_EDITA]
	-- Add the parameters for the stored procedure here
@cod int,
@des varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE T_TIPO_PRODUCTO
	SET
	desc_tipr = @des 
	WHERE 
	codi_tipr = @cod 


END
GO
/****** Object:  StoredProcedure [dbo].[SP_TIPO_CLIENTE_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_TIPO_CLIENTE_LISTA]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM T_TIPO_CLIENTE

END
GO
/****** Object:  StoredProcedure [dbo].[SP_PROVEEDORES_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_PROVEEDORES_REGISTRA]
	-- Add the parameters for the stored procedure here
@cod char(11),
@des varchar(max),
@dir text,
@tel varchar(50),
@cel varchar(50),
@mai varchar(50),
@nota varchar(200)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_PROVEEDOR (codi_prov,raso_prov,dire_prov,tele_prov,celu_prov,mail_prov,nota_prov)
	VALUES (@cod,@des,@dir,@tel,@cel,@mai,@nota)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CARGO_REGISTRA]
	-- Add the parameters for the stored procedure here
@des varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_CARGO(desc_carg)
	VALUES (@des)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGO_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CARGO_LISTA]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM T_CARGO

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGO_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CARGO_ELIMINA]
	-- Add the parameters for the stored procedure here
@cod int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DELETE FROM T_CARGO WHERE id_carg = @cod 


END
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGO_EDITA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CARGO_EDITA]
	-- Add the parameters for the stored procedure here
@cod int,
@des varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE T_CARGO
	SET
	desc_carg = @des 
	WHERE 
	id_carg = @cod 


END
GO
/****** Object:  StoredProcedure [dbo].[SP_BANCO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_BANCO_REGISTRA]
	-- Add the parameters for the stored procedure here
@des varchar(60)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_BANCO(desc_banc)
	VALUES (@des)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_BANCO_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_BANCO_LISTA]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM T_BANCO

END
GO
/****** Object:  StoredProcedure [dbo].[SP_BANCO_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_BANCO_ELIMINA]
	-- Add the parameters for the stored procedure here
@cod int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DELETE FROM T_BANCO WHERE id_banc = @cod 


END
GO
/****** Object:  StoredProcedure [dbo].[SP_BANCO_EDITA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_BANCO_EDITA]
	-- Add the parameters for the stored procedure here
@cod int,
@des varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE T_BANCO
	SET
	desc_banc = @des 
	WHERE 
	id_banc = @cod 


END
GO
/****** Object:  StoredProcedure [dbo].[SP_DOCUMENTO_VENTA_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_DOCUMENTO_VENTA_LISTA]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM T_DOCUMENTO_VENTA

END
GO
/****** Object:  StoredProcedure [dbo].[SP_DOCUMENTO_VENTA_FORMATO]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_DOCUMENTO_VENTA_FORMATO]
	-- Add the parameters for the stored procedure here
@cod INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT desc_mask FROM T_DOCUMENTO_VENTA
	WHERE id_dove = @cod 

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CUENTA_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CUENTA_REGISTRA]
	-- Add the parameters for the stored procedure here
@cod char(10),
@des varchar(50),
@ent varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_CUENTA(id_cuen,desc_cuen,enti_cuent)
	VALUES (@cod,@des,@ent)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CUENTA_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CUENTA_LISTA]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM T_CUENTA

END
GO
/****** Object:  StoredProcedure [dbo].[SP_EMPLEADO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_EMPLEADO_REGISTRA]
	-- Add the parameters for the stored procedure here
@cod char(5),
@nom varchar(250),
@car int,
@tdo int,
@ndo char(11),
@dir varchar(200),
@tel varchar(12),
@usu varchar(30),
@cla varchar(100),
@adm bit,
@est bit

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_EMPLEADO
	VALUES (@cod,@nom,@car,@tdo,@ndo,@dir,@tel,@usu,@cla,@adm,@est)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_PRODUCTO_REGISTRA]
	-- Add the parameters for the stored procedure here
@cod char(10),
@des varchar(200),
@tpr int,
@cos decimal(9, 2),
@pre decimal(9, 2),
@iva int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_PRODUCTO (codi_prod,nomb_prod,codi_tipr,cost_prod,prec_prod,id_iva)
	VALUES (@cod,@des,@tpr,@cos,@pre,@iva)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_PRODUCTO_LISTA]
	-- Add the parameters for the stored procedure here
@op bit,
@nom varchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if @op=0
	SELECT * FROM T_PRODUCTO
	if @op=1
		SELECT * FROM T_PRODUCTO WHERE nomb_prod like '%' + @nom + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_IGV_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_PRODUCTO_IGV_LISTA]
	-- Add the parameters for the stored procedure here
@cod char(10) 
	
AS
BEGIN
	
SET NOCOUNT ON;

	SELECT I.id_iva,I.valo_iva 
	FROM T_IVAS I
	INNER JOIN T_PRODUCTO P ON P.id_iva = I.id_iva
	WHERE P.codi_prod =@cod

END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_PRODUCTO_ELIMINA]
	-- Add the parameters for the stored procedure here
@cod char(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DELETE FROM T_PRODUCTO WHERE codi_prod = @cod 


END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_EDITA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_PRODUCTO_EDITA]
	-- Add the parameters for the stored procedure here
@cod char(10),
@des varchar(200),
@tpr int,
@cos float,
@pre float,
@iva int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	UPDATE T_PRODUCTO 
	SET
		nomb_prod = @des,
		codi_tipr = @tpr,
		cost_prod = @cos,
		prec_prod = @pre,
		id_iva = @iva
	WHERE codi_prod = @cod

END
GO
/****** Object:  StoredProcedure [dbo].[SP_USUARIOS_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_USUARIOS_LISTA]
	-- Add the parameters for the stored procedure here
@usu varchar(30),
@cla varchar(100),
@op int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF @op = 0 
	SELECT * FROM T_EMPLEADO 
	
	IF @op = 1
	SELECT usua_empl,clav_empl,codi_empl,nomb_empl,esad_empl 
	FROM T_EMPLEADO  
	WHERE usua_empl = @usu AND clav_empl = @cla


END
GO
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CLIENTE_REGISTRA]
	-- Add the parameters for the stored procedure here
@cod char(11),
@tcl int,
@nom varchar(250),
@dir varchar(200),
@doc varchar(11),
@tel varchar(50),
@mai varchar(80)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_CLIENTE (codi_clie,id_ticl,nomb_clie,dire_clie,nudo_clie,tele_clie,emai_clie)
	VALUES (@cod,@tcl,@nom,@dir,@doc,@tel,@mai)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CLIENTE_LISTA]
	-- Add the parameters for the stored procedure here
@op bit,
@nom varchar(250)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if @op=0
	SELECT * FROM T_CLIENTE
	if @op=1
	SELECT * FROM T_CLIENTE WHERE nomb_clie like '%' + @nom + '%'

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CLIENTE_ELIMINA]
	-- Add the parameters for the stored procedure here
	@cod char(11)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DELETE FROM T_CLIENTE
	WHERE codi_clie = @cod

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE_EDITA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CLIENTE_EDITA]
	-- Add the parameters for the stored procedure here
@cod char(11),
@tcl int,
@nom varchar(250),
@dir varchar(200),
@doc varchar(11),
@tel varchar(50),
@mai varchar(80)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
		
	UPDATE T_CLIENTE 
	SET
		id_ticl = @tcl,
		nomb_clie = @nom,
		dire_clie = @dir,
		nudo_clie = @doc,
		tele_clie = @tel,
		emai_clie =@mai
	WHERE codi_clie = @cod
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_UNIDAD_SELECCIONA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_PRODUCTO_UNIDAD_SELECCIONA]
	-- Add the parameters for the stored procedure here
@cod char(10) 
	
AS
BEGIN
	
SET NOCOUNT ON;

	SELECT codi_unid FROM T_PRODUCTO_UNIDAD 
	WHERE codi_prod =@cod

END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_UNIDAD_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_PRODUCTO_UNIDAD_REGISTRA]
	-- Add the parameters for the stored procedure here
@pro varchar(10),
@uni int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	INSERT INTO T_PRODUCTO_UNIDAD
	VALUES (@pro,@uni)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_UNIDAD_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_PRODUCTO_UNIDAD_LISTA]
	-- Add the parameters for the stored procedure here
@cod char(10) 
	
AS
BEGIN
	
SET NOCOUNT ON;

	SELECT U.codi_unid,U.desc_unid,U.abre_unid
	FROM T_UNIDAD U
	INNER JOIN T_PRODUCTO_UNIDAD PU ON PU.codi_unid = U.codi_unid 
	INNER JOIN T_PRODUCTO P ON P.codi_prod= PU.codi_prod
	WHERE P.codi_prod=@cod

END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_UNIDAD_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_PRODUCTO_UNIDAD_ELIMINA]
	-- Add the parameters for the stored procedure here
@pro char(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	DELETE T_PRODUCTO_UNIDAD
	WHERE codi_prod = @pro 
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EMPOCE_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_EMPOCE_REGISTRA]
	-- Add the parameters for the stored procedure here
@npa char(8),
@fec date,
@mon decimal(9, 2),
@cue int,
@usu char(5)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_EMPOCE
	VALUES (@npa,@fec,@mon,@cue,@usu)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_ANULADA_CONSULTA_HEAD]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_ANULADA_CONSULTA_HEAD]
	-- Add the parameters for the stored procedure here
@op bit,
@fde datetime,
@fha datetime


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if @op=0 
		SELECT V.codi_vent,C.nomb_clie,D.desc_dove,V.nudo_vent,P.desc_fopa,V.fech_vent,V.subt_vent,V.toiv_vent,V.tota_vent
		FROM T_VENTA V
		INNER JOIN T_CLIENTE C ON C.codi_clie = V.codi_clie 
		INNER JOIN T_DOCUMENTO_VENTA D ON D.id_dove = V.id_dove
		INNER JOIN T_FORMA_PAGO P ON P.id_fopa = V.id_fopa
		WHERE esta_vent = 0
		ORDER BY V.fech_vent
		
	if @op=1 
		SELECT V.codi_vent,C.nomb_clie,D.desc_dove,V.nudo_vent,P.desc_fopa,V.fech_vent,V.subt_vent,V.toiv_vent,V.tota_vent
		FROM T_VENTA V
		INNER JOIN T_CLIENTE C ON C.codi_clie = V.codi_clie 
		INNER JOIN T_DOCUMENTO_VENTA D ON D.id_dove = V.id_dove
		INNER JOIN T_FORMA_PAGO P ON P.id_fopa = V.id_fopa
		WHERE fech_vent >= @fde AND fech_vent <= @fha AND esta_vent = 0
		ORDER BY V.fech_vent
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_ACTUALIZA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_VENTA_ACTUALIZA]
@codi_vent AS VARCHAR(10),
@codi_clie AS CHAR(10),
@id_dove AS INT,
@id_fopa AS INT,
@nudo_vent AS CHAR(10),
@fech_vent AS DATE,
@hora_vent AS TIME,
@subt_vent AS DECIMAL(9,2),
@toiv_vent AS DECIMAL(9,2),
@tota_vent AS DECIMAL(9,2),
@codi_empl AS CHAR(5),
@esta_vent AS BIT,
@tlet_vent AS VARCHAR(200),
@nota_vent AS VARCHAR(100)
AS
BEGIN
UPDATE T_VENTA
SET codi_clie = @codi_clie,
id_dove = @id_dove,
id_fopa = @id_fopa,
nudo_vent = @nudo_vent,
fech_vent = @fech_vent,
hora_vent = @hora_vent,
subt_vent = @subt_vent,
toiv_vent = @toiv_vent,
tota_vent = @tota_vent,
codi_empl = @codi_empl,
esta_vent = @esta_vent,
tlet_vent = @tlet_vent,
nota_vent = @nota_vent
WHERE codi_vent = @codi_vent
END
GO
/****** Object:  StoredProcedure [dbo].[SP_USUARIOS_ASIGNA_PERMISOS]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_USUARIOS_ASIGNA_PERMISOS]
	-- Add the parameters for the stored procedure here
@usu int,
@mod int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_USUARIO_MODULOS (codi_empl,id_modu)
	VALUES (@usu,@mod)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DOCUMENTO_HEAD]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_DOCUMENTO_HEAD]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	
SET NOCOUNT ON;
	
SELECT V.codi_vent, C.nomb_clie,C.dire_clie,C.nudo_clie, DV.desc_dove, V.nudo_vent,V.fech_vent,V.hora_vent, 
	FP.desc_fopa, V.subt_vent,V.toiv_vent,V.tota_vent
FROM T_VENTA V
INNER JOIN T_CLIENTE C ON C.codi_clie = V.codi_clie
INNER JOIN T_DOCUMENTO_VENTA DV ON DV.id_dove = V.id_dove
INNER JOIN T_FORMA_PAGO FP ON FP.id_fopa = V.id_fopa

WHERE V.codi_vent = '4356787654'

END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_REGISTRA]
	-- Add the parameters for the stored procedure here
@cod char(10),
@cli char(10),
@doc int,
@fpa int,
@ndo char(10),
@fve date,
@hve time,
@sub decimal(9, 2),
@igv decimal(9, 2),
@tot decimal(9, 2),
@emp char(5),
@est bit,
@let varchar(200),
@not varchar(100)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_VENTA (codi_vent,codi_clie,id_dove,id_fopa,nudo_vent,fech_vent,hora_vent,subt_vent,toiv_vent,tota_vent,codi_empl,esta_vent,tlet_vent,nota_vent)
	VALUES (@cod,@cli,@doc,@fpa,@ndo,@fve,@hve,@sub,@igv,@tot,@emp,@est,@let,@not)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_EMPOCE_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_EMPOCE_REGISTRA]
	-- Add the parameters for the stored procedure here
@npa char(8),
@cod varchar(10)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_VENTA_EMPOCE
	VALUES (@npa,@cod)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_EMPOCE_CONSULTA_HEAD]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_EMPOCE_CONSULTA_HEAD]
	-- Add the parameters for the stored procedure here
@op bit,
@fde datetime,
@fha datetime


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if @op=0 
		SELECT V.codi_vent,C.nomb_clie,D.desc_dove,V.nudo_vent,P.desc_fopa,V.fech_vent,V.subt_vent,V.toiv_vent,V.tota_vent
		FROM T_VENTA V
		INNER JOIN T_CLIENTE C ON C.codi_clie = V.codi_clie 
		INNER JOIN T_DOCUMENTO_VENTA D ON D.id_dove = V.id_dove
		INNER JOIN T_FORMA_PAGO P ON P.id_fopa = V.id_fopa
		WHERE V.codi_vent NOT IN(SELECT codi_vent FROM T_VENTA_EMPOCE) AND esta_vent = 1
		ORDER BY V.fech_vent
		
	if @op=1 
		SELECT V.codi_vent,C.nomb_clie,D.desc_dove,V.nudo_vent,P.desc_fopa,V.fech_vent,V.subt_vent,V.toiv_vent,V.tota_vent
		FROM T_VENTA V
		INNER JOIN T_CLIENTE C ON C.codi_clie = V.codi_clie 
		INNER JOIN T_DOCUMENTO_VENTA D ON D.id_dove = V.id_dove
		INNER JOIN T_FORMA_PAGO P ON P.id_fopa = V.id_fopa
		WHERE V.codi_vent NOT IN(SELECT codi_vent FROM T_VENTA_EMPOCE) AND fech_vent >= @fde AND fech_vent <= @fha AND esta_vent = 1
		ORDER BY V.fech_vent
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DOCUMENTO_DETALLE]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_DOCUMENTO_DETALLE]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	
SET NOCOUNT ON;
	
SELECT 
	VD.item_veda, 
	P.codi_prod,
	P.nomb_prod, 
	VD.capr_veda, 
	U.abre_unid, 
	VD.vaun_veda,
	VD.tota_veda

FROM T_VENTA_DETALLE VD
INNER JOIN T_PRODUCTO P ON P.codi_prod = VD.codi_prod
INNER JOIN T_UNIDAD U ON U.codi_unid = VD.codi_unid

WHERE VD.codi_vent = '99999996'

END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_DETALLE_REGISTRA]
	-- Add the parameters for the stored procedure here
@cod char(10),
@ite int,
@pro char(10),
@cun int,
@can float,
@vun decimal(9, 2),
@vig decimal(9, 2),
@tig decimal(9, 2),
@sub decimal(9, 2),
@tot decimal(9, 2)



AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO dbo.T_VENTA_DETALLE (codi_vent,item_veda,codi_prod,codi_unid,capr_veda,vaun_veda,vaiv_veda,toiv_veda,impo_veda,tota_veda)
	VALUES (@cod,@ite,@pro,@cun,@can,@vun,@vig,@tig,@sub,@tot)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_PAGO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_DETALLE_PAGO_REGISTRA]
	-- Add the parameters for the stored procedure here
@cod char(10),
@ven varchar(10),
@ban int,
@che varchar(15),
@est bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO dbo.T_VENTA_DETALLE_PAGO
	VALUES (@cod,@ven,@ban,@che,@est)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_PAGO_EXTORNA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_VENTA_DETALLE_PAGO_EXTORNA]
@codi_vent AS VARCHAR(10),
@esta_fopa AS bit
AS
BEGIN
UPDATE T_VENTA_DETALLE_PAGO
SET esta_fopa = 0
WHERE codi_vent = @codi_vent
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_PAGO_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_VENTA_DETALLE_PAGO_ELIMINA]
@codi_vent AS VARCHAR(10)
AS
BEGIN
DELETE FROM T_VENTA_DETALLE_PAGO
WHERE codi_vent = @codi_vent
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_PAGO_ACTUALIZA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_VENTA_DETALLE_PAGO_ACTUALIZA]
@codi_vent AS VARCHAR(10),
@id_banc AS INT,
@nudo_fopa AS VARCHAR(15)
AS
BEGIN
UPDATE T_VENTA_DETALLE_PAGO
SET codi_vent = @codi_vent,
id_banc = @id_banc,
nudo_fopa = @nudo_fopa
WHERE codi_vent = @codi_vent
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_ELIMINA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_DETALLE_ELIMINA]
	-- Add the parameters for the stored procedure here
@cod char(10)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	DELETE FROM T_VENTA_DETALLE WHERE codi_vent = @cod

END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_ACTUALIZA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_DETALLE_ACTUALIZA]
	-- Add the parameters for the stored procedure here
@cod char(10),
@ite int,
@pro char(10),
@cun int,
@can float,
@vun decimal(9, 2),
@vig decimal(9, 2),
@tig decimal(9, 2),
@sub decimal(9, 2),
@tot decimal(9, 2)



AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	--DELETE FROM T_VENTA_DETALLE WHERE codi_vent = @cod
	
	INSERT INTO dbo.T_VENTA_DETALLE (codi_vent,item_veda,codi_prod,codi_unid,capr_veda,vaun_veda,vaiv_veda,toiv_veda,impo_veda,tota_veda)
	VALUES (@cod,@ite,@pro,@cun,@can,@vun,@vig,@tig,@sub,@tot)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_CONSULTA_HEAD]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_CONSULTA_HEAD]
	-- Add the parameters for the stored procedure here
@op char(1),
@fde datetime,
@fha datetime


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if @op=0 
		SELECT V.codi_vent,C.nomb_clie,D.desc_dove,V.nudo_vent,P.desc_fopa,V.fech_vent,V.subt_vent,V.toiv_vent,V.tota_vent
		FROM T_VENTA V
		INNER JOIN T_CLIENTE C ON C.codi_clie = V.codi_clie 
		INNER JOIN T_DOCUMENTO_VENTA D ON D.id_dove = V.id_dove
		INNER JOIN T_FORMA_PAGO P ON P.id_fopa = V.id_fopa
		WHERE esta_vent = 1
		ORDER BY V.fech_vent
		
	if @op=1 
		SELECT V.codi_vent,C.nomb_clie,D.desc_dove,V.nudo_vent,P.desc_fopa,V.fech_vent,V.subt_vent,V.toiv_vent,V.tota_vent
		FROM T_VENTA V
		INNER JOIN T_CLIENTE C ON C.codi_clie = V.codi_clie 
		INNER JOIN T_DOCUMENTO_VENTA D ON D.id_dove = V.id_dove
		INNER JOIN T_FORMA_PAGO P ON P.id_fopa = V.id_fopa
		WHERE fech_vent >= @fde AND fech_vent <= @fha AND esta_vent = 1
		ORDER BY V.fech_vent
		
	if @op=2 --Editar
		SELECT V.codi_vent,C.nomb_clie,D.id_dove,V.nudo_vent,P.id_fopa,V.fech_vent,V.subt_vent,V.toiv_vent,V.tota_vent,C.codi_clie,V.nota_vent,VDP.id_banc,VDP.nudo_fopa
		FROM T_VENTA V
		FULL JOIN T_CLIENTE C ON C.codi_clie = V.codi_clie 
		FULL JOIN T_DOCUMENTO_VENTA D ON D.id_dove = V.id_dove
		FULL JOIN T_FORMA_PAGO P ON P.id_fopa = V.id_fopa
		FULL JOIN  T_VENTA_DETALLE_PAGO VDP ON VDP.codi_vent = V.codi_vent
		WHERE esta_vent = 1
		ORDER BY V.fech_vent
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_CONSULTA_DETALLE]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_CONSULTA_DETALLE]
	-- Add the parameters for the stored procedure here
@op bit,
@cod varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if @op=0
	SELECT VD.item_veda,P.nomb_prod,U.desc_unid,VD.capr_veda,VD.vaun_veda,VD.tota_veda
	FROM T_VENTA_DETALLE VD
	INNER JOIN T_PRODUCTO P ON P.codi_prod = VD.codi_prod
	INNER JOIN T_UNIDAD U ON U.codi_unid = VD.codi_unid
	WHERE codi_vent = @cod
	
	if @op=1
	SELECT VD.item_veda,P.codi_prod,P.nomb_prod,U.codi_unid,VD.capr_veda,VD.vaun_veda,VD.vaiv_veda,VD.toiv_veda,VD.impo_veda,VD.tota_veda
	FROM T_VENTA_DETALLE VD
	INNER JOIN T_PRODUCTO P ON P.codi_prod = VD.codi_prod
	INNER JOIN T_UNIDAD U ON U.codi_unid = VD.codi_unid
	WHERE codi_vent = @cod
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EXTORNO_REGISTRA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_EXTORNO_REGISTRA]
	-- Add the parameters for the stored procedure here
@cod char(5),
@fec date,
@ven varchar(10),
@moe int,
@mon money,
@emp char(5)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO T_EXTORNO
	VALUES (@cod,@fec,@ven,@moe,@mon,@emp)
	
	UPDATE T_VENTA 
	SET esta_vent = 0
	WHERE codi_vent = @ven
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EMPOCE_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_EMPOCE_LISTA]
	-- Add the parameters for the stored procedure here
	@op bit,
	@fde datetime,
	@fha datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if @op=0
	SELECT * FROM V_EMPOCE
	
	if @op=1 
	SELECT * FROM V_EMPOCE
	WHERE fech_empo >= @fde AND fech_empo <= @fha

END
GO
/****** Object:  StoredProcedure [dbo].[SP_EMPOCE_DETALLE_LISTA]    Script Date: 11/07/2013 12:11:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_EMPOCE_DETALLE_LISTA]
	-- Add the parameters for the stored procedure here
@npa char(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM V_EMPOCE_DETALLE
	WHERE nupa_empo = @npa

END
GO

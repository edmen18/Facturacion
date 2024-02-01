USE [DB_FACTURACION]
GO
/****** Object:  StoredProcedure [dbo].[SP_MOTIVO_EXTORNO_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_IVAS_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_IVAS_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_FORMA_PAGO_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_FORMA_PAGO_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ENTIDAD_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ENTIDAD_LOGO]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ENTIDAD_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD_ELIMINA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD_EDITA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_TIPO_PRODUCTO_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_TIPO_PRODUCTO_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_TIPO_PRODUCTO_ELIMINA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_TIPO_PRODUCTO_EDITA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_TIPO_CLIENTE_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_PROVEEDORES_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CARGO_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CARGO_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CARGO_ELIMINA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CARGO_EDITA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_BANCO_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_BANCO_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_BANCO_ELIMINA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_BANCO_EDITA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DOCUMENTO_VENTA_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DOCUMENTO_VENTA_FORMATO]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CUENTA_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CUENTA_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_PRODUCTO_REGISTRA]
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
	INSERT INTO T_PRODUCTO (codi_prod,nomb_prod,codi_tipr,cost_prod,prec_prod,id_iva)
	VALUES (@cod,@des,@tpr,@cos,@pre,@iva)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_IGV_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_ELIMINA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_EDITA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_USUARIOS_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_EMPLEADO_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE_ELIMINA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE_EDITA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_UNIDAD_SELECCIONA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_UNIDAD_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_UNIDAD_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO_UNIDAD_ELIMINA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_EMPOCE_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_EMPOCE_REGISTRA]
	-- Add the parameters for the stored procedure here
@npa char(8),
@fec date,
@mon money,
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
/****** Object:  StoredProcedure [dbo].[SP_VENTA_ANULADA_CONSULTA_HEAD]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_USUARIOS_ASIGNA_PERMISOS]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_VENTA_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
@sub money,
@igv money,
@tot money,
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
/****** Object:  View [dbo].[V_EMPOCE]    Script Date: 11/06/2013 10:41:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_EMPOCE]
AS
SELECT     dbo.T_EMPOCE.nupa_empo, dbo.T_EMPOCE.fech_empo, dbo.T_CUENTA.desc_cuen, dbo.T_EMPOCE.mont_empo
FROM         dbo.T_CUENTA INNER JOIN
                      dbo.T_EMPOCE ON dbo.T_CUENTA.id_cuen = dbo.T_EMPOCE.id_cuen
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[50] 4[21] 2[8] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_CUENTA"
            Begin Extent = 
               Top = 35
               Left = 457
               Bottom = 139
               Right = 655
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_EMPOCE"
            Begin Extent = 
               Top = 27
               Left = 215
               Bottom = 187
               Right = 413
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_EMPOCE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_EMPOCE'
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DOCUMENTO_HEAD]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  View [dbo].[V_INGRESOS_DIARIOS]    Script Date: 11/06/2013 10:41:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_INGRESOS_DIARIOS]
AS
SELECT     codi_vent, fech_vent, hora_vent, tota_vent, esta_vent
FROM         dbo.T_VENTA
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_VENTA"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 170
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 6
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_INGRESOS_DIARIOS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_INGRESOS_DIARIOS'
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_CONSULTA_HEAD]    Script Date: 11/06/2013 10:41:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_CONSULTA_HEAD]
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
END
GO
/****** Object:  View [dbo].[V_INGRESOS_DIARIOS_RESUMEN]    Script Date: 11/06/2013 10:41:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_INGRESOS_DIARIOS_RESUMEN]
AS
SELECT DISTINCT TP.desc_tipr AS tipo_producto, SUM(VD.tota_veda) AS total
FROM         dbo.T_VENTA AS V INNER JOIN
                      dbo.T_VENTA_DETALLE AS VD ON V.codi_vent = VD.codi_vent INNER JOIN
                      dbo.T_PRODUCTO AS P ON P.codi_prod = VD.codi_prod INNER JOIN
                      dbo.T_TIPO_PRODUCTO AS TP ON P.codi_tipr = TP.codi_tipr
GROUP BY TP.desc_tipr
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "V"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VD"
            Begin Extent = 
               Top = 6
               Left = 290
               Bottom = 125
               Right = 504
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "P"
            Begin Extent = 
               Top = 6
               Left = 542
               Bottom = 125
               Right = 756
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TP"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 215
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_INGRESOS_DIARIOS_RESUMEN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_INGRESOS_DIARIOS_RESUMEN'
GO
/****** Object:  View [dbo].[V_INGRESOS_DIARIOS_DETALLADO]    Script Date: 11/06/2013 10:41:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_INGRESOS_DIARIOS_DETALLADO]
AS
SELECT     TOP (100) PERCENT v.codi_vent, v.nudo_vent, dbo.T_DOCUMENTO_VENTA.desc_dove, CONVERT(char(10), v.fech_vent, 103) AS fech_vent, p.nomb_prod, 
                      vd.tota_veda, tp.desc_tipr, v.esta_vent
FROM         dbo.T_VENTA AS v INNER JOIN
                      dbo.T_VENTA_DETALLE AS vd ON v.codi_vent = vd.codi_vent INNER JOIN
                      dbo.T_PRODUCTO AS p ON p.codi_prod = vd.codi_prod INNER JOIN
                      dbo.T_TIPO_PRODUCTO AS tp ON p.codi_tipr = tp.codi_tipr INNER JOIN
                      dbo.T_DOCUMENTO_VENTA ON v.id_dove = dbo.T_DOCUMENTO_VENTA.id_dove
ORDER BY tp.desc_tipr
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[35] 4[32] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -192
         Left = 0
      End
      Begin Tables = 
         Begin Table = "v"
            Begin Extent = 
               Top = 198
               Left = 77
               Bottom = 317
               Right = 275
            End
            DisplayFlags = 280
            TopColumn = 9
         End
         Begin Table = "vd"
            Begin Extent = 
               Top = 17
               Left = 320
               Bottom = 156
               Right = 518
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 49
               Left = 651
               Bottom = 168
               Right = 849
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tp"
            Begin Extent = 
               Top = 224
               Left = 888
               Bottom = 313
               Right = 1086
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_DOCUMENTO_VENTA"
            Begin Extent = 
               Top = 298
               Left = 334
               Bottom = 402
               Right = 532
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 2055
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1200
         Tab' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_INGRESOS_DIARIOS_DETALLADO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'le = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1980
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_INGRESOS_DIARIOS_DETALLADO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_INGRESOS_DIARIOS_DETALLADO'
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_CONSULTA_DETALLE]    Script Date: 11/06/2013 10:41:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_CONSULTA_DETALLE]
	-- Add the parameters for the stored procedure here
@cod varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT VD.item_veda,P.nomb_prod,U.desc_unid,VD.capr_veda,VD.vaun_veda,VD.tota_veda
	FROM T_VENTA_DETALLE VD
	INNER JOIN T_PRODUCTO P ON P.codi_prod = VD.codi_prod
	INNER JOIN T_UNIDAD U ON U.codi_unid = VD.codi_unid
	WHERE codi_vent = @cod
END
GO
/****** Object:  View [dbo].[V_EXTORNO]    Script Date: 11/06/2013 10:41:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_EXTORNO]
AS
SELECT     dbo.T_EXTORNO.codi_exto, dbo.T_EXTORNO.fech_exto, dbo.T_EXTORNO.codi_vent, dbo.T_MOTIVO_EXTORNO.desc_moex, dbo.T_EXTORNO.mont_exto, 
                      dbo.T_EXTORNO.codi_empl, dbo.T_EXTORNO.fech_exto AS Expr1
FROM         dbo.T_EXTORNO INNER JOIN
                      dbo.T_MOTIVO_EXTORNO ON dbo.T_EXTORNO.id_moex = dbo.T_MOTIVO_EXTORNO.id_moex
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_EXTORNO"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 164
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_MOTIVO_EXTORNO"
            Begin Extent = 
               Top = 6
               Left = 274
               Bottom = 95
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 3495
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 2160
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_EXTORNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_EXTORNO'
GO
/****** Object:  View [dbo].[V_EMPOCE_DETALLE]    Script Date: 11/06/2013 10:41:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_EMPOCE_DETALLE]
AS
SELECT     dbo.T_VENTA_EMPOCE.nupa_empo, dbo.T_VENTA.codi_vent, dbo.T_DOCUMENTO_VENTA.desc_dove, dbo.T_VENTA.nudo_vent, dbo.T_VENTA.tota_vent
FROM         dbo.T_VENTA INNER JOIN
                      dbo.T_VENTA_EMPOCE ON dbo.T_VENTA.codi_vent = dbo.T_VENTA_EMPOCE.codi_vent INNER JOIN
                      dbo.T_DOCUMENTO_VENTA ON dbo.T_VENTA.id_dove = dbo.T_DOCUMENTO_VENTA.id_dove
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[37] 4[25] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_VENTA"
            Begin Extent = 
               Top = 9
               Left = 318
               Bottom = 179
               Right = 516
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_VENTA_EMPOCE"
            Begin Extent = 
               Top = 37
               Left = 65
               Bottom = 126
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_DOCUMENTO_VENTA"
            Begin Extent = 
               Top = 6
               Left = 574
               Bottom = 110
               Right = 772
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_EMPOCE_DETALLE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_EMPOCE_DETALLE'
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DOCUMENTO_DETALLE]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
@vun float,
@vig float,
@tig float,
@sub float,
@tot float



AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO dbo.T_VENTA_DETALLE (codi_vent,item_veda,codi_prod,codi_unid,capr_veda,vaun_veda,vaiv_veda,toiv_veda,impo_veda,tota_veda)
	VALUES (@cod,@ite,@pro,@cun,@can,@vun,@vig,@tig,@sub,@tot)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_DETALLE_PAGO_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VENTA_DETALLE_PAGO_REGISTRA]
	-- Add the parameters for the stored procedure here
@cod char(10),
@ven varchar(10),
@ban int,
@che varchar(15)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO dbo.T_VENTA_DETALLE_PAGO
	VALUES (@cod,@ven,@ban,@che)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTA_EMPOCE_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_VENTA_EMPOCE_CONSULTA_HEAD]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_EXTORNO_REGISTRA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_EMPOCE_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_EMPOCE_DETALLE_LISTA]    Script Date: 11/06/2013 10:41:16 ******/
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

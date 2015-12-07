GO
/****** Object:  StoredProcedure [dbo].[pr_por_add_usuario]    Script Date: 07/28/2008 10:48:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_por_add_usuario]
				(@id_usuario int output,
			     @ds_login  varchar(10),
			     @ds_senha  varchar(15),
			     @ds_nome  varchar(50),
			     @ds_telefone varchar(15),
			     @ds_email  varchar(100))

AS

INSERT INTO tb_por_usuario
           (ds_login,
           ds_senha,
           ds_nome,
           ds_telefone,
           ds_email)
     VALUES
           (@ds_login,
			@ds_senha,
			@ds_nome,
			@ds_telefone,
			@ds_email)

SELECT @id_usuario = @@IDENTITY

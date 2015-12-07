
GO
/****** Object:  StoredProcedure [dbo].[pr_por_upd_usuario]    Script Date: 07/28/2008 10:48:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_por_upd_usuario] 
				(@id_usuario int,
			     @ds_nome  varchar(50),
			     @ds_telefone varchar(15),
			     @ds_email  varchar(100))

AS

UPDATE tb_por_usuario
           SET ds_nome = @ds_nome,
               ds_telefone = @ds_telefone,
               ds_email = @ds_email
WHERE id_usuario = @id_usuario 

